Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmEditBoardingRoom

    ' DATABASE CONNECTION
    Private connectionString As String = "Server=localhost;Database=pet_care_and_services_management_system;Uid=root;Pwd=;"
    Private roomID As String
    Private selectedPhoto As Byte() = Nothing

    ' FORM CONSTRUCTOR
    Public Sub New(ByVal id As String)
        InitializeComponent()
        roomID = id
    End Sub

    ' FORM LOAD
    Private Sub frmEditBoardingRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboRoomType.Items.Clear()
        cboRoomType.Items.Add("Small")
        cboRoomType.Items.Add("Medium")
        cboRoomType.Items.Add("Large")
        cboRoomType.Items.Add("VIP")

        cboStatus.Items.Clear()
        cboStatus.Items.Add("Available")
        cboStatus.Items.Add("Occupied")

        LoadBoardingRoomData()
    End Sub

    ' LOAD BOARDING ROOM DATA FROM DATABASE
    Private Sub LoadBoardingRoomData()

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT RoomID, RoomType, PricePerDay, Status, Description, RoomPhoto FROM BoardingRooms WHERE RoomID = @RoomID"

                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@RoomID", roomID)

                    Using reader As MySqlDataReader = command.ExecuteReader()

                        If reader.Read() Then

                            txtRoomID.Text = reader("RoomID").ToString()
                            cboRoomType.Text = reader("RoomType").ToString()
                            txtPrice.Text = reader("PricePerDay").ToString()
                            cboStatus.Text = reader("Status").ToString()
                            txtDescription.Text = reader("Description").ToString()

                            If Not IsDBNull(reader("RoomPhoto")) Then
                                Dim photoData As Byte() = DirectCast(reader("RoomPhoto"), Byte())

                                Using memoryStream As New MemoryStream(photoData)
                                    picRoom.Image = New Bitmap(Image.FromStream(memoryStream))
                                End Using

                                selectedPhoto = photoData
                            Else
                                picRoom.Image = Nothing
                                selectedPhoto = Nothing
                            End If

                        Else
                            MessageBox.Show("Boarding room not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Me.Close()
                        End If

                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading boarding room:" & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

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

    ' SAVE CHANGES
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

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

                Dim query As String = "UPDATE BoardingRooms SET RoomType = @RoomType, PricePerDay = @PricePerDay, Status = @Status, Description = @Description, RoomPhoto = @RoomPhoto WHERE RoomID = @RoomID"

                Using command As New MySqlCommand(query, connection)

                    command.Parameters.AddWithValue("@RoomID", txtRoomID.Text.Trim())
                    command.Parameters.AddWithValue("@RoomType", cboRoomType.Text)
                    command.Parameters.AddWithValue("@PricePerDay", price)
                    command.Parameters.AddWithValue("@Status", cboStatus.Text)
                    command.Parameters.AddWithValue("@Description", txtDescription.Text.Trim())

                    If selectedPhoto IsNot Nothing Then
                        command.Parameters.Add("@RoomPhoto", MySqlDbType.LongBlob).Value = selectedPhoto
                    Else
                        command.Parameters.Add("@RoomPhoto", MySqlDbType.LongBlob).Value = DBNull.Value
                    End If

                    command.ExecuteNonQuery()

                End Using
            End Using

            MessageBox.Show("Boarding room updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error updating boarding room:" & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    ' CANCEL
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class