Imports MySql.Data.MySqlClient

Public Class frmAddGroomingBooking

    ' DATABASE CONNECTION
    Private connectionString As String = "Server=localhost;Database=pet_care_and_services_management_system;Uid=root;Pwd=;"

    ' FORM LOAD
    Private Sub frmAddGroomingBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpBookingDate.Value = DateTime.Today
        dtpBookingTime.Value = DateTime.Now
        cboStatus.SelectedIndex = 0
    End Sub

    ' SAVE GROOMING BOOKING
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtPetID.Text.Trim() = "" Then
            MessageBox.Show("Please enter Pet ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPetID.Focus()
            Exit Sub
        End If

        If txtServiceID.Text.Trim() = "" Then
            MessageBox.Show("Please enter Service ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtServiceID.Focus()
            Exit Sub
        End If

        If cboStatus.SelectedIndex = -1 Then
            MessageBox.Show("Please select Status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cboStatus.Focus()
            Exit Sub
        End If

        Try
            Dim conn As New MySqlConnection(connectionString)
            conn.Open()

            Dim sql As String = "INSERT INTO GroomingBookings (PetID, ServiceID, BookingDate, BookingTime, Status) VALUES (@PetID, @ServiceID, @BookingDate, @BookingTime, @Status)"
            Dim cmd As New MySqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@PetID", txtPetID.Text.Trim())
            cmd.Parameters.AddWithValue("@ServiceID", txtServiceID.Text.Trim())
            cmd.Parameters.AddWithValue("@BookingDate", dtpBookingDate.Value.Date)
            cmd.Parameters.AddWithValue("@BookingTime", dtpBookingTime.Value.ToString("HH:mm:ss"))
            cmd.Parameters.AddWithValue("@Status", cboStatus.Text)

            If cmd.ExecuteNonQuery() > 0 Then
                MessageBox.Show("Grooming booking added successfully.", "Add Grooming Booking", MessageBoxButtons.OK, MessageBoxIcon.Information)

                cmd.Dispose()
                conn.Close()
                conn.Dispose()

                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MessageBox.Show("Grooming booking was not added.", "Add Grooming Booking", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                cmd.Dispose()
                conn.Close()
                conn.Dispose()
            End If

        Catch ex As Exception
            MessageBox.Show("Unable to add grooming booking." & Environment.NewLine & Environment.NewLine & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' CANCEL
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class