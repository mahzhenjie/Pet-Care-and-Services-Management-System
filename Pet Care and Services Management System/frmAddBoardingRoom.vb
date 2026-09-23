Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmAddBoardingRoom

    ' DATABASE CONNECTION
    Private connectionString As String = "Server=localhost;Database=pet_care_and_services_management_system;Uid=root;Pwd=;"
    Private selectedPhoto As Byte() = Nothing

    ' FORM LOAD
    Private Sub frmAddBoardingRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboRoomType.Items.Clear()
        cboRoomType.Items.Add("Standard")
        cboRoomType.Items.Add("Deluxe")
        cboRoomType.Items.Add("Premium")
        cboRoomType.Items.Add("VIP")

        cboStatus.Items.Clear()
        cboStatus.Items.Add("Available")
        cboStatus.Items.Add("Occupied")

        cboRoomType.SelectedIndex = -1
        cboStatus.SelectedIndex = 0
    End Sub

    ' CHOOSE PHOTO
    Private Sub btnChoosePhoto_Click(sender As Object, e As EventArgs) Handles btnChoosePhoto.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Title = "Select Boarding Room Photo"
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                selectedPhoto = File.ReadAllBytes(openFileDialog.FileName)
                Using memoryStream As New MemoryStream(selectedPhoto)
                    picRoom.Image = New Bitmap(Image.FromStream(memoryStream))
                End Using
            End If
        End Using
    End Sub

    ' SAVE BOARDING ROOM
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtRoomID.Text.Trim() = "" Then
            MessageBox.Show("Please enter Room ID.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtRoomID.Focus()
            Exit Sub
        End If

        If cboRoomType.SelectedIndex = -1 Then
            MessageBox.Show("Please select Room Type.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cboRoomType.Focus()
            Exit Sub
        End If

        Dim price As Decimal

        If Not Decimal.TryParse(txtPrice.Text.Trim(), price) Then
            MessageBox.Show("Please enter a valid price.", "Invalid Price", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPrice.Focus()
            Exit Sub
        End If

        If price < 0 Then
            MessageBox.Show("Price cannot be negative.", "Invalid Price", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPrice.Focus()
            Exit Sub
        End If

        If cboStatus.SelectedIndex = -1 Then
            MessageBox.Show("Please select Status.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cboStatus.Focus()
            Exit Sub
        End If

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "INSERT INTO BoardingRooms (RoomID, RoomType, Price, Status, Description, Photo) VALUES (@RoomID, @RoomType, @Price, @Status, @Description, @Photo)"

                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@RoomID", txtRoomID.Text.Trim())
                    command.Parameters.AddWithValue("@RoomType", cboRoomType.Text)
                    command.Parameters.AddWithValue("@Price", price)
                    command.Parameters.AddWithValue("@Status", cboStatus.Text)
                    command.Parameters.AddWithValue("@Description", txtDescription.Text.Trim())

                    If selectedPhoto IsNot Nothing Then
                        command.Parameters.Add("@Photo", MySqlDbType.LongBlob).Value = selectedPhoto
                    Else
                        command.Parameters.Add("@Photo", MySqlDbType.LongBlob).Value = DBNull.Value
                    End If

                    command.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Boarding room added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As MySqlException When ex.Number = 1062
            MessageBox.Show("Room ID already exists. Please enter a different Room ID.", "Duplicate Room ID", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Catch ex As Exception
            MessageBox.Show("Error adding boarding room:" & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    ' CANCEL
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class