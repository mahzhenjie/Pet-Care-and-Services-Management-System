Imports MySql.Data.MySqlClient

Public Class frmBooking

    ' DATABASE CONNECTION
    Private connectionString As String = "Server=localhost;Database=pet_care_and_services_management_system;Uid=root;Pwd=;"

    ' FORM LOAD
    Private Sub frmGroomingBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGroomingBookingData()
        LoadBoardingBookingData()
    End Sub

    ' LOAD GROOMING BOOKING DATA FROM DATABASE
    Private Sub LoadGroomingBookingData()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim sql As String = "SELECT GroomingBookingID, PetID, ServiceID, DATE_FORMAT(BookingDate, '%Y-%m-%d') AS BookingDate, TIME_FORMAT(BookingTime, '%H:%i') AS BookingTime, Status FROM GroomingBookings ORDER BY GroomingBookingID"

                Using cmd As New MySqlCommand(sql, conn)
                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim table As New DataTable()
                        adapter.Fill(table)
                        dgvGroomingBooking.Rows.Clear()

                        For Each row As DataRow In table.Rows
                            dgvGroomingBooking.Rows.Add(
                                row("GroomingBookingID").ToString(),
                                row("PetID").ToString(),
                                row("ServiceID").ToString(),
                                row("BookingDate").ToString(),
                                row("BookingTime").ToString(),
                                row("Status").ToString()
                            )
                        Next
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Unable to load grooming booking data." & Environment.NewLine & Environment.NewLine & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' LOAD BOARDING BOOKING DATA FROM DATABASE
    Private Sub LoadBoardingBookingData()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim sql As String = "SELECT BoardingBookingID, PetID, RoomID, DATE_FORMAT(StartDate, '%Y-%m-%d') AS StartDate, DATE_FORMAT(EndDate, '%Y-%m-%d') AS EndDate, Status FROM BoardingBookings ORDER BY BoardingBookingID"

                Using cmd As New MySqlCommand(sql, conn)
                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim table As New DataTable()
                        adapter.Fill(table)
                        dgvBoardingBooking.Rows.Clear()

                        For Each row As DataRow In table.Rows
                            dgvBoardingBooking.Rows.Add(
                                row("BoardingBookingID").ToString(),
                                row("PetID").ToString(),
                                row("RoomID").ToString(),
                                row("StartDate").ToString(),
                                row("EndDate").ToString(),
                                row("Status").ToString()
                            )
                        Next
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Unable to load boarding booking data." & Environment.NewLine & Environment.NewLine & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' GO BACK TO DASHBOARD
    Private Sub btnGoBackDashboard_Click(sender As Object, e As EventArgs) Handles btnGoBackDashboard.Click
        frmEmployeeDashboard.Show()
        Me.Hide()
    End Sub

    ' ADD GROOMING BOOKING
    Private Sub btnAddGroomingBooking_Click(sender As Object, e As EventArgs) Handles btnAddGroomingBooking.Click
        Dim frm As New frmAddBooking()
        frm.ShowDialog()
        LoadGroomingBookingData()
    End Sub

    ' REFRESH
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtSearch.Text = ""
        LoadGroomingBookingData()
        LoadBoardingBookingData()
    End Sub

    ' SEARCH GROOMING BOOKING
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim searchText As String = txtSearch.Text.Trim()

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim sql As String = "SELECT GroomingBookingID, PetID, ServiceID, DATE_FORMAT(BookingDate, '%Y-%m-%d') AS BookingDate, TIME_FORMAT(BookingTime, '%H:%i') AS BookingTime, Status FROM GroomingBookings WHERE GroomingBookingID LIKE @search OR PetID LIKE @search OR ServiceID LIKE @search OR DATE_FORMAT(BookingDate, '%Y-%m-%d') LIKE @search OR TIME_FORMAT(BookingTime, '%H:%i') LIKE @search OR Status LIKE @search ORDER BY GroomingBookingID"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@search", "%" & searchText & "%")

                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim table As New DataTable()
                        adapter.Fill(table)
                        dgvGroomingBooking.Rows.Clear()

                        For Each row As DataRow In table.Rows
                            dgvGroomingBooking.Rows.Add(
                                row("GroomingBookingID").ToString(),
                                row("PetID").ToString(),
                                row("ServiceID").ToString(),
                                row("BookingDate").ToString(),
                                row("BookingTime").ToString(),
                                row("Status").ToString()
                            )
                        Next
                    End Using
                End Using
            End Using

            SearchBoardingBooking(searchText)

        Catch ex As Exception
            MessageBox.Show("Search failed." & Environment.NewLine & Environment.NewLine & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' SEARCH BOARDING BOOKING
    Private Sub SearchBoardingBooking(searchText As String)
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim sql As String = "SELECT BoardingBookingID, PetID, RoomID, DATE_FORMAT(StartDate, '%Y-%m-%d') AS StartDate, DATE_FORMAT(EndDate, '%Y-%m-%d') AS EndDate, Status FROM BoardingBookings WHERE BoardingBookingID LIKE @search OR PetID LIKE @search OR RoomID LIKE @search OR DATE_FORMAT(StartDate, '%Y-%m-%d') LIKE @search OR DATE_FORMAT(EndDate, '%Y-%m-%d') LIKE @search OR Status LIKE @search ORDER BY BoardingBookingID"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@search", "%" & searchText & "%")

                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim table As New DataTable()
                        adapter.Fill(table)
                        dgvBoardingBooking.Rows.Clear()

                        For Each row As DataRow In table.Rows
                            dgvBoardingBooking.Rows.Add(
                                row("BoardingBookingID").ToString(),
                                row("PetID").ToString(),
                                row("RoomID").ToString(),
                                row("StartDate").ToString(),
                                row("EndDate").ToString(),
                                row("Status").ToString()
                            )
                        Next
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Boarding booking search failed." & Environment.NewLine & Environment.NewLine & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' EDIT / DELETE GROOMING BOOKING
    Private Sub dgvGroomingBooking_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGroomingBooking.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        If dgvGroomingBooking.Rows(e.RowIndex).IsNewRow Then
            Exit Sub
        End If

        ' EDIT GROOMING BOOKING
        If e.ColumnIndex = dgvGroomingBooking.Columns("colEdit").Index Then
            Dim bookingID As String = dgvGroomingBooking.Rows(e.RowIndex).Cells("colGroomingBookingID").Value.ToString()
            Dim frm As New frmEditGroomingBooking(bookingID)

            If frm.ShowDialog() = DialogResult.OK Then
                LoadGroomingBookingData()
            End If
        End If

        ' DELETE GROOMING BOOKING
        If e.ColumnIndex = dgvGroomingBooking.Columns("colDelete").Index Then
            Dim bookingID As String = dgvGroomingBooking.Rows(e.RowIndex).Cells("colGroomingBookingID").Value.ToString()

            If MessageBox.Show("Are you sure you want to delete this grooming booking?" & Environment.NewLine & Environment.NewLine & "Booking ID: " & bookingID, "Delete Grooming Booking", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                DeleteGroomingBooking(bookingID)
            End If
        End If
    End Sub

    ' EDIT / DELETE BOARDING BOOKING
    Private Sub dgvBoardingBooking_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBoardingBooking.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        If dgvBoardingBooking.Rows(e.RowIndex).IsNewRow Then
            Exit Sub
        End If

        ' EDIT BOARDING BOOKING
        If e.ColumnIndex = dgvBoardingBooking.Columns("colBoardingEdit").Index Then
            Dim bookingID As String = dgvBoardingBooking.Rows(e.RowIndex).Cells("colBoardingBookingID").Value.ToString()
            Dim frm As New frmEditBoardingBooking(bookingID)

            If frm.ShowDialog() = DialogResult.OK Then
                LoadBoardingBookingData()
            End If
        End If

        ' DELETE BOARDING BOOKING
        If e.ColumnIndex = dgvBoardingBooking.Columns("colBoardingDelete").Index Then
            Dim bookingID As String = dgvBoardingBooking.Rows(e.RowIndex).Cells("colBoardingBookingID").Value.ToString()

            If MessageBox.Show("Are you sure you want to delete this boarding booking?" & Environment.NewLine & Environment.NewLine & "Booking ID: " & bookingID, "Delete Boarding Booking", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                DeleteBoardingBooking(bookingID)
            End If
        End If
    End Sub

    ' DELETE GROOMING BOOKING FROM DATABASE
    Private Sub DeleteGroomingBooking(bookingID As String)
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim sql As String = "DELETE FROM GroomingBookings WHERE GroomingBookingID = @GroomingBookingID"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@GroomingBookingID", bookingID)

                    Dim result As Integer = cmd.ExecuteNonQuery()

                    If result > 0 Then
                        MessageBox.Show("Grooming booking deleted successfully.", "Delete Grooming Booking", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LoadGroomingBookingData()
                    Else
                        MessageBox.Show("Grooming booking was not found.", "Delete Grooming Booking", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Unable to delete grooming booking." & Environment.NewLine & Environment.NewLine & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' DELETE BOARDING BOOKING FROM DATABASE
    Private Sub DeleteBoardingBooking(bookingID As String)
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim sql As String = "DELETE FROM BoardingBookings WHERE BoardingBookingID = @BoardingBookingID"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@BoardingBookingID", bookingID)

                    Dim result As Integer = cmd.ExecuteNonQuery()

                    If result > 0 Then
                        MessageBox.Show("Boarding booking deleted successfully.", "Delete Boarding Booking", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LoadBoardingBookingData()
                    Else
                        MessageBox.Show("Boarding booking was not found.", "Delete Boarding Booking", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Unable to delete boarding booking." & Environment.NewLine & Environment.NewLine & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class