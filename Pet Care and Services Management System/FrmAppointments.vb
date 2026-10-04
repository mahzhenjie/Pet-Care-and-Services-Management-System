Imports MySql.Data.MySqlClient
Imports System.Data

Public Class FrmAppointments

    Private connectionString As String = "Server=127.0.0.1;Database=pet_care_and_services_management_system;Uid=root;Pwd=;"
    Private dtAppointments As DataTable

    ' -----------------------------------------------------------
    ' FORM LOAD
    ' -----------------------------------------------------------
    Private Sub FrmAppointments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If GlobalVariables.LoggedInCustomerID <= 0 Then
            MessageBox.Show("Error: You must be logged in to view your appointments.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If

        LoadAppointments()
    End Sub

    ' -----------------------------------------------------------
    ' LOAD APPOINTMENTS DATA (Combining Grooming and Boarding)
    ' -----------------------------------------------------------
    Private Sub LoadAppointments()
        Dim query As String = "
            SELECT 
                gb.GroomingBookingID AS BookingID, 
                gb.BookingDate AS ApptDate, 
                CAST(gb.BookingTime AS CHAR) AS ApptTime, 
                p.PetName, 
                s.ServiceName AS ServiceName, 
                'Grooming' AS ApptType, 
                gb.Status
            FROM groomingbookings gb
            INNER JOIN pets p ON gb.PetID = p.PetID
            INNER JOIN groomingservices s ON gb.ServiceID = s.ServiceID
            WHERE p.CustomerID = @CustomerID

            UNION ALL

            SELECT 
                bb.BoardingBookingID AS BookingID, 
                bb.StartDate AS ApptDate, 
                '-' AS ApptTime, 
                p.PetName, 
                CONCAT(br.RoomNumber, ' - ', br.RoomType) AS ServiceName, 
                'Boarding' AS ApptType, 
                bb.Status
            FROM boardingbookings bb
            INNER JOIN pets p ON bb.PetID = p.PetID
            INNER JOIN boardingrooms br ON bb.RoomID = br.RoomID
            WHERE p.CustomerID = @CustomerID
            
            ORDER BY 
                CASE 
                    WHEN Status = 'Cancelled' OR Status = 'Completed' THEN 1 
                    ELSE 0 
                END ASC,
                ApptDate DESC"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@CustomerID", GlobalVariables.LoggedInCustomerID)

                Try
                    connection.Open()
                    Dim adapter As New MySqlDataAdapter(command)
                    dtAppointments = New DataTable()
                    adapter.Fill(dtAppointments)

                    AddCancelButton()

                    ApplySearchFilter()

                Catch ex As Exception
                    MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    ' -----------------------------------------------------------
    ' ADD CANCEL BUTTON COLUMN
    ' -----------------------------------------------------------
    Private Sub AddCancelButton()
        If dgvAppointments.Columns("CancelColumn") Is Nothing Then
            Dim cancelBtn As New DataGridViewButtonColumn()
            cancelBtn.Name = "CancelColumn"
            cancelBtn.HeaderText = "Cancel Appointment"
            cancelBtn.Text = "Cancel"
            cancelBtn.UseColumnTextForButtonValue = True
            cancelBtn.DefaultCellStyle.ForeColor = Color.Red
            dgvAppointments.Columns.Add(cancelBtn)
        End If

        ' Always ensure it is the last column on the right
        dgvAppointments.Columns("CancelColumn").DisplayIndex = dgvAppointments.Columns.Count - 1
    End Sub

    ' -----------------------------------------------------------
    ' HIDE CANCEL BUTTON IF NOT PENDING
    ' -----------------------------------------------------------
    Private Sub dgvAppointments_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvAppointments.DataBindingComplete

        If Not dgvAppointments.Columns.Contains("CancelColumn") Then
            Return
        End If

        For Each row As DataGridViewRow In dgvAppointments.Rows
            If row.IsNewRow Then Continue For

            If dgvAppointments.Columns.Contains("Status") AndAlso row.Cells("Status").Value IsNot Nothing Then
                Dim status As String = row.Cells("Status").Value.ToString()

                If status <> "Pending" Then
                    row.Cells("CancelColumn") = New DataGridViewTextBoxCell()
                    row.Cells("CancelColumn").Value = ""
                    row.Cells("CancelColumn").ReadOnly = True
                End If
            End If
        Next
    End Sub

    ' -----------------------------------------------------------
    ' HANDLE BUTTON CLICKS (Cancel Appointment Logic)
    ' -----------------------------------------------------------
    Private Sub dgvAppointments_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAppointments.CellContentClick
        If e.RowIndex < 0 Then Return

        Dim clickedColumn As String = dgvAppointments.Columns(e.ColumnIndex).Name

        If clickedColumn = "CancelColumn" Then
            ' Ensure the cell is actually a button (not the blank text cell we created)
            If TypeOf dgvAppointments.Rows(e.RowIndex).Cells("CancelColumn") Is DataGridViewButtonCell Then

                Dim result As DialogResult = MessageBox.Show("Are you sure you want to cancel this appointment?", "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    Dim bookingID As Integer = Convert.ToInt32(dgvAppointments.Rows(e.RowIndex).Cells("BookingID").Value)
                    Dim apptType As String = dgvAppointments.Rows(e.RowIndex).Cells("ApptType").Value.ToString()

                    CancelAppointment(bookingID, apptType)
                End If
            End If
        End If
    End Sub

    ' -----------------------------------------------------------
    ' CANCEL APPOINTMENT DATABASE LOGIC
    ' -----------------------------------------------------------
    Private Sub CancelAppointment(bookingID As Integer, apptType As String)
        Dim query As String = ""

        ' Determine which table to update based on the Appointment Type
        If apptType = "Grooming" Then
            query = "UPDATE groomingbookings SET Status = 'Cancelled' WHERE GroomingBookingID = @BookingID"
        ElseIf apptType = "Boarding" Then
            query = "UPDATE boardingbookings SET Status = 'Cancelled' WHERE BoardingBookingID = @BookingID"
        End If

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@BookingID", bookingID)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Appointment has been cancelled.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Reload data to reflect changes
                    LoadAppointments()
                Catch ex As Exception
                    MessageBox.Show("Error cancelling appointment: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    ' -----------------------------------------------------------
    ' SEARCH FUNCTIONALITY
    ' -----------------------------------------------------------
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        ApplySearchFilter()
    End Sub
    Private Sub ApplySearchFilter()
        If dtAppointments IsNot Nothing Then
            Dim searchText As String = txtSearch.Text.Trim().Replace("'", "''")

            ' FIXED: Now it ignores "Search appointment..." so it won't hide your data
            If String.IsNullOrWhiteSpace(searchText) OrElse searchText = "Search appointment..." OrElse searchText = "Search booking..." Then
                dtAppointments.DefaultView.RowFilter = ""
            Else
                dtAppointments.DefaultView.RowFilter = String.Format("PetName LIKE '%{0}%' OR ServiceName LIKE '%{0}%' OR ApptType LIKE '%{0}%'", searchText)
            End If

            ' This triggers the DataBindingComplete event
            dgvAppointments.DataSource = dtAppointments

            ' Force the Cancel button to the far right
            If dgvAppointments.Columns.Contains("CancelColumn") Then
                dgvAppointments.Columns("CancelColumn").DisplayIndex = dgvAppointments.Columns.Count - 1
            End If
        End If
    End Sub

    ' -----------------------------------------------------------
    ' OTHER UI BUTTONS
    ' -----------------------------------------------------------
    Private Sub Refreshbtn_Click(sender As Object, e As EventArgs) Handles Refreshbtn.Click
        txtSearch.Clear()
        LoadAppointments()
    End Sub

    Private Sub btnAddAppointment_Click(sender As Object, e As EventArgs) Handles btnAddAppointment.Click
        Dim newApptForm As New FrmNewAppointment()
        newApptForm.ShowDialog()
        ' Refresh the list when returning from the add appointment form
        LoadAppointments()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Me.Close()
    End Sub

End Class