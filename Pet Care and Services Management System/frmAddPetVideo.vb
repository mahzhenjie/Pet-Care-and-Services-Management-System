Imports MySql.Data.MySqlClient

Public Class frmAddPetVideo
    Private connectionString As String = "Server=localhost;Database=pet_care_and_services_management_system;Uid=root;Pwd=;"

    Private Sub frmAddPetVideo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpUploadDate.Value = DateTime.Now
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtBookingID.Text.Trim() = "" Then
            MessageBox.Show("Please enter the Boarding Booking ID.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If txtVideoURL.Text.Trim() = "" Then
            MessageBox.Show("Please enter the Video URL.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not Integer.TryParse(txtBookingID.Text.Trim(), Nothing) Then
            MessageBox.Show("Boarding Booking ID must be a number.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            MySqlConnection = New MySqlConnection(connectionString)
            MySqlConnection.Open()

            MySqlCommand = New MySqlCommand("SELECT COUNT(*) FROM BoardingBookings WHERE BoardingBookingID = @BoardingBookingID", MySqlConnection)
            MySqlCommand.Parameters.AddWithValue("@BoardingBookingID", txtBookingID.Text.Trim())

            If Convert.ToInt32(MySqlCommand.ExecuteScalar()) = 0 Then
                MessageBox.Show("Boarding Booking ID does not exist.", "Invalid Booking", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                MySqlConnection.Close()
                Return
            End If

            MySqlCommand = New MySqlCommand("INSERT INTO PetVideos (BoardingBookingID, VideoURL, UploadDate, Description) VALUES (@BoardingBookingID, @VideoURL, @UploadDate, @Description)", MySqlConnection)
            MySqlCommand.Parameters.AddWithValue("@BoardingBookingID", txtBookingID.Text.Trim())
            MySqlCommand.Parameters.AddWithValue("@VideoURL", txtVideoURL.Text.Trim())
            MySqlCommand.Parameters.AddWithValue("@UploadDate", dtpUploadDate.Value)
            MySqlCommand.Parameters.AddWithValue("@Description", txtDescription.Text.Trim())
            MySqlCommand.ExecuteNonQuery()

            MySqlConnection.Close()

            MessageBox.Show("Pet video added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception
            If MySqlConnection IsNot Nothing AndAlso MySqlConnection.State = ConnectionState.Open Then
                MySqlConnection.Close()
            End If
            MessageBox.Show(ex.Message, "Add Pet Video Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class