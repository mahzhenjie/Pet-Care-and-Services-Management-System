Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmAddGroomingService

    ' DATABASE CONNECTION
    Private connectionString As String = "Server=localhost;Database=pet_care_and_services_management_system;Uid=root;Pwd=;"

    ' SELECTED PHOTO
    Private selectedPhoto() As Byte = Nothing

    ' FORM LOAD
    Private Sub frmAddGroomingService_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtServiceName.Focus()
    End Sub

    ' BROWSE SERVICE PHOTO
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim openFileDialog As New OpenFileDialog()

        openFileDialog.Title = "Select Grooming Service Photo"
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                selectedPhoto = File.ReadAllBytes(openFileDialog.FileName)

                Dim memoryStream As New MemoryStream(selectedPhoto)
                Dim tempImage As Image = Image.FromStream(memoryStream)

                picServicePhoto.Image = New Bitmap(tempImage)
                picServicePhoto.SizeMode = PictureBoxSizeMode.Zoom

                tempImage.Dispose()
                memoryStream.Dispose()
            Catch ex As Exception
                MessageBox.Show("Unable to load the selected photo: " & ex.Message, "Photo Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                selectedPhoto = Nothing
                picServicePhoto.Image = Nothing
            End Try
        End If

        openFileDialog.Dispose()
    End Sub

    ' SAVE GROOMING SERVICE
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        ' VALIDATE SERVICE NAME
        If txtServiceName.Text.Trim() = "" Then
            MessageBox.Show("Please enter the service name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtServiceName.Focus()
            Return
        End If

        ' VALIDATE DESCRIPTION
        If txtDescription.Text.Trim() = "" Then
            MessageBox.Show("Please enter the service description.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDescription.Focus()
            Return
        End If

        ' VALIDATE PRICE
        Dim price As Decimal

        If Not Decimal.TryParse(txtPrice.Text.Trim(), price) Then
            MessageBox.Show("Please enter a valid price.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPrice.Focus()
            Return
        End If

        If price < 0 Then
            MessageBox.Show("Price cannot be negative.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPrice.Focus()
            Return
        End If

        ' VALIDATE DURATION
        Dim duration As Integer

        If Not Integer.TryParse(txtDuration.Text.Trim(), duration) Then
            MessageBox.Show("Please enter a valid duration.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDuration.Focus()
            Return
        End If

        If duration <= 0 Then
            MessageBox.Show("Duration must be greater than 0.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDuration.Focus()
            Return
        End If

        Try
            Dim query As String = "INSERT INTO GroomingServices (ServiceName, Description, Price, Duration, ServicePhoto) VALUES (@ServiceName, @Description, @Price, @Duration, @ServicePhoto)"
            Dim connection As New MySqlConnection(connectionString)

            connection.Open()

            Dim command As New MySqlCommand(query, connection)

            command.Parameters.AddWithValue("@ServiceName", txtServiceName.Text.Trim())
            command.Parameters.AddWithValue("@Description", txtDescription.Text.Trim())
            command.Parameters.AddWithValue("@Price", price)
            command.Parameters.AddWithValue("@Duration", duration)

            If selectedPhoto IsNot Nothing AndAlso selectedPhoto.Length > 0 Then
                command.Parameters.Add("@ServicePhoto", MySqlDbType.LongBlob).Value = selectedPhoto
            Else
                command.Parameters.Add("@ServicePhoto", MySqlDbType.LongBlob).Value = DBNull.Value
            End If

            command.ExecuteNonQuery()

            command.Dispose()
            connection.Close()
            connection.Dispose()

            MessageBox.Show("Grooming service added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As MySqlException
            MessageBox.Show("Error adding grooming service: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch ex As Exception
            MessageBox.Show("Error adding grooming service: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' CANCEL
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class