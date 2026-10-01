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

        Dim bookingID As Integer

        If Not Integer.TryParse(txtBookingID.Text.Trim(), bookingID) Then
            MessageBox.Show("Boarding Booking ID must be a number.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim sql As String = "SELECT COUNT(*) FROM BoardingBookings WHERE BoardingBookingID = @BoardingBookingID"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@BoardingBookingID", bookingID)

                    If Convert.ToInt32(cmd.ExecuteScalar()) = 0 Then
                        MessageBox.Show("Boarding Booking ID does not exist.", "Invalid Booking", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                End Using

                sql = "INSERT INTO PetVideos (BoardingBookingID, VideoURL, UploadDate, Description) VALUES (@BoardingBookingID, @VideoURL, @UploadDate, @Description)"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@BoardingBookingID", bookingID)
                    cmd.Parameters.AddWithValue("@VideoURL", txtVideoURL.Text.Trim())
                    cmd.Parameters.AddWithValue("@UploadDate", dtpUploadDate.Value)
                    cmd.Parameters.AddWithValue("@Description", txtDescription.Text.Trim())
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Pet video added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Add Pet Video Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class