Imports System.Data
Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud

Public Class FrmNewAppointment

    Private connectionString As String = "Server=127.0.0.1;Database=pet_care_and_services_management_system;Uid=root;Pwd=;"

    ' -----------------------------------------------------------
    ' FORM LOAD
    ' -----------------------------------------------------------
    Private Sub FrmNewAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If GlobalVariables.LoggedInCustomerID <= 0 Then
            MessageBox.Show("Error: You must be logged in to make an appointment.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If

        ' Setup Service Type combo box
        cmbServiceType.Items.Clear()
        cmbServiceType.Items.Add("Grooming")
        cmbServiceType.Items.Add("Boarding")

        ' Load customer's pets into Pet Name combobox
        LoadCustomerPets()
    End Sub

    ' -----------------------------------------------------------
    ' LOAD PETS FOR CURRENT CUSTOMER
    ' -----------------------------------------------------------
    Private Sub LoadCustomerPets()
        Dim query As String = "SELECT PetID, PetName FROM pets WHERE CustomerID = @CustomerID"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@CustomerID", GlobalVariables.LoggedInCustomerID)

                Try
                    connection.Open()
                    Dim adapter As New MySqlDataAdapter(command)
                    Dim dtPets As New DataTable()
                    adapter.Fill(dtPets)

                    ' Bind DataTable to ComboBox
                    cmbPetName.DataSource = dtPets
                    cmbPetName.DisplayMember = "PetName"
                    cmbPetName.ValueMember = "PetID"
                    cmbPetName.SelectedIndex = -1 ' Clear selection initially
                Catch ex As Exception
                    MessageBox.Show("Error loading pets: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    ' -----------------------------------------------------------
    ' SERVICE TYPE CHANGED (Grooming or Boarding)
    ' -----------------------------------------------------------
    Private Sub cmbServiceType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbServiceType.SelectedIndexChanged
        cmbService.DataSource = Nothing
        cmbService.Items.Clear()
        txtDescription.Clear()

        If cmbServiceType.SelectedIndex = -1 Then Return

        Dim selectedType As String = cmbServiceType.SelectedItem.ToString()
        Dim query As String = ""

        If selectedType = "Grooming" Then

            query = "SELECT ServiceID AS ID, ServiceName AS Name FROM service"
        ElseIf selectedType = "Boarding" Then

            query = "
                SELECT RoomID AS ID, CONCAT(RoomNumber, ' - ', RoomType) AS Name 
                FROM boardingrooms br
                WHERE NOT EXISTS (
                    SELECT 1 FROM boardingbookings bb 
                    WHERE bb.RoomID = br.RoomID 
                      AND bb.Status IN ('Confirmed', 'Pending') 
                      AND @SelectedDate <= bb.EndDate 
                      AND @SelectedDate >= bb.StartDate
                )"
        End If

        If query <> "" Then
            Using connection As New MySqlConnection(connectionString)
                Using command As New MySqlCommand(query, connection)

                    If selectedType = "Boarding" Then
                        command.Parameters.AddWithValue("@SelectedDate", dtpDate.Value.ToString("yyyy-MM-dd"))
                    End If

                    Try
                        connection.Open()
                        Dim adapter As New MySqlDataAdapter(command)
                        Dim dtServices As New DataTable()
                        adapter.Fill(dtServices)

                        cmbService.DataSource = dtServices
                        cmbService.DisplayMember = "Name"
                        cmbService.ValueMember = "ID"
                        cmbService.SelectedIndex = -1
                    Catch ex As Exception
                        MessageBox.Show("Error loading services: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using
            End Using
        End If
    End Sub
    ' -----------------------------------------------------------
    ' SERVICE CHANGED (Load Description)
    ' -----------------------------------------------------------
    Private Sub cmbService_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbService.SelectedIndexChanged
        ' Ensure something is actually selected and it has a ValueMember
        If cmbService.SelectedIndex = -1 OrElse cmbService.SelectedValue Is Nothing Then
            txtDescription.Clear()
            Return
        End If

        ' Prevent casting errors during initial binding
        Dim selectedID As Integer
        If Not Integer.TryParse(cmbService.SelectedValue.ToString(), selectedID) Then
            Return
        End If

        Dim selectedType As String = cmbServiceType.SelectedItem.ToString()
        Dim query As String = ""

        If selectedType = "Grooming" Then
            query = "SELECT Description FROM groomingservices WHERE ServiceID = @ID"
        ElseIf selectedType = "Boarding" Then
            query = "SELECT Description FROM boardingrooms WHERE RoomID = @ID"
        End If

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@ID", selectedID)
                Try
                    connection.Open()
                    Dim desc As Object = command.ExecuteScalar()
                    If desc IsNot Nothing Then
                        txtDescription.Text = desc.ToString()
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error loading description: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    ' -----------------------------------------------------------
    ' BOOK APPOINTMENT BUTTON
    ' -----------------------------------------------------------
    Private Sub btnBookAppointment_Click(sender As Object, e As EventArgs) Handles btnBookAppointment.Click
        ' Basic Validation
        If cmbPetName.SelectedIndex = -1 OrElse cmbServiceType.SelectedIndex = -1 OrElse cmbService.SelectedIndex = -1 Then
            MessageBox.Show("Please select Pet Name, Service Type, and Service.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim petID As Integer = Convert.ToInt32(cmbPetName.SelectedValue)
        Dim selectedServiceID As Integer = Convert.ToInt32(cmbService.SelectedValue)
        Dim selectedType As String = cmbServiceType.SelectedItem.ToString()

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = ""

                If selectedType = "Grooming" Then
                    ' Insert into groomingbooking
                    query = "INSERT INTO groomingbookings (PetID, ServiceID, BookingDate, BookingTime, Status) VALUES (@PetID, @ServiceID, @BookingDate, @BookingTime, 'Pending')"

                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@PetID", petID)
                        command.Parameters.AddWithValue("@ServiceID", selectedServiceID)
                        command.Parameters.AddWithValue("@BookingDate", dtpDate.Value.ToString("yyyy-MM-dd"))
                        command.Parameters.AddWithValue("@BookingTime", dtpTime.Value.ToString("HH:mm:ss"))
                        command.ExecuteNonQuery()
                    End Using

                ElseIf selectedType = "Boarding" Then
                    ' Insert into boardingbookings. 
                    ' NOTE: UI only has one Date field, so setting EndDate to StartDate + 1 day as default.
                    query = "INSERT INTO boardingbookings (PetID, RoomID, StartDate, EndDate, Status) VALUES (@PetID, @RoomID, @StartDate, @EndDate, 'Pending')"

                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@PetID", petID)
                        command.Parameters.AddWithValue("@RoomID", selectedServiceID)
                        command.Parameters.AddWithValue("@StartDate", dtpDate.Value.ToString("yyyy-MM-dd"))
                        command.Parameters.AddWithValue("@EndDate", dtpDate.Value.AddDays(1).ToString("yyyy-MM-dd"))
                        command.ExecuteNonQuery()
                    End Using
                End If

                MessageBox.Show("Appointment booked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End Using

        Catch ex As Exception
            MessageBox.Show("Error booking appointment: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' -----------------------------------------------------------
    ' CANCEL BUTTON
    ' -----------------------------------------------------------
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class