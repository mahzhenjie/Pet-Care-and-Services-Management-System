Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmBoardingRoom
    ' DATABASE CONNECTION
    Private connectionString As String = "Server=localhost;Database=pet_care_and_services_management_system;Uid=root;Pwd=;"

    ' FORM LOAD
    Private Sub frmBoardingRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboStatus.SelectedIndex = 0
        LoadRoomCards()
    End Sub

    ' LOAD ROOM DATA FROM DATABASE
    Private Sub LoadRoomCards()
        ClearRoomCards()

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT br.RoomID, br.RoomNumber, br.RoomType, br.PricePerDay, br.Description, br.RoomPhoto, CASE WHEN EXISTS (SELECT 1 FROM BoardingBookings bb WHERE bb.RoomID = br.RoomID AND bb.Status IN ('Confirmed', 'Active') AND CURDATE() BETWEEN bb.StartDate AND bb.EndDate) THEN 'Occupied' WHEN EXISTS (SELECT 1 FROM BoardingBookings bb WHERE bb.RoomID = br.RoomID AND bb.Status IN ('Confirmed', 'Active') AND bb.StartDate > CURDATE()) THEN 'Booked' WHEN EXISTS (SELECT 1 FROM BoardingBookings bb WHERE bb.RoomID = br.RoomID AND bb.Status IN ('Confirmed', 'Active') AND bb.EndDate < CURDATE()) THEN 'Available' ELSE br.Status END AS CurrentStatus FROM BoardingRooms br ORDER BY br.RoomID"

                Using command As New MySqlCommand(query, connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()

                        While reader.Read()
                            Dim roomID As Integer = Convert.ToInt32(reader("RoomID"))
                            Dim roomNumber As String = reader("RoomNumber").ToString()
                            Dim roomType As String = reader("RoomType").ToString()
                            Dim price As Decimal = Convert.ToDecimal(reader("PricePerDay"))
                            Dim status As String = reader("CurrentStatus").ToString()
                            Dim description As String = reader("Description").ToString()

                            If cboStatus.SelectedItem.ToString() = "All Status" OrElse cboStatus.SelectedItem.ToString() = status Then
                                CreateRoomCard(roomID, roomNumber, roomType, price, status, description, reader("RoomPhoto"))
                            End If
                        End While

                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading boarding rooms: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' CREATE ROOM CARD
    Private Sub CreateRoomCard(roomID As Integer, roomNumber As String, roomType As String, price As Decimal, status As String, description As String, roomPhoto As Object)

        Dim roomPanel As New Panel()
        roomPanel.BackColor = Color.White
        roomPanel.BorderStyle = BorderStyle.FixedSingle
        roomPanel.Margin = New Padding(10)
        roomPanel.Size = New Size(330, 410)
        roomPanel.Tag = roomID

        Dim roomPicture As New PictureBox()
        roomPicture.BackColor = Color.FromArgb(232, 216, 194)
        roomPicture.Location = New Point(15, 15)
        roomPicture.Size = New Size(298, 180)
        roomPicture.SizeMode = PictureBoxSizeMode.StretchImage

        Dim roomStatus As New Label()
        roomStatus.AutoSize = False
        roomStatus.BackColor = Color.FromArgb(76, 175, 80)
        roomStatus.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        roomStatus.ForeColor = Color.White
        roomStatus.Location = New Point(205, 22)
        roomStatus.Size = New Size(108, 25)
        roomStatus.Text = status
        roomStatus.TextAlign = ContentAlignment.MiddleCenter

        If status = "Available" Then
            roomStatus.ForeColor = Color.Green
        ElseIf status = "Occupied" Then
            roomStatus.ForeColor = Color.Red
        ElseIf status = "Booked" Then
            roomStatus.ForeColor = Color.DarkOrange
        Else
            roomStatus.ForeColor = Color.SaddleBrown
        End If

        Dim roomIDLabel As New Label()
        roomIDLabel.AutoEllipsis = True
        roomIDLabel.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        roomIDLabel.ForeColor = Color.FromArgb(61, 40, 27)
        roomIDLabel.Location = New Point(15, 207)
        roomIDLabel.Size = New Size(298, 30)
        roomIDLabel.Text = roomNumber

        Dim roomTypeLabel As New Label()
        roomTypeLabel.AutoEllipsis = True
        roomTypeLabel.Font = New Font("Segoe UI", 9.5F)
        roomTypeLabel.ForeColor = Color.DimGray
        roomTypeLabel.Location = New Point(15, 242)
        roomTypeLabel.Size = New Size(298, 21)
        roomTypeLabel.Text = roomType

        Dim roomPriceLabel As New Label()
        roomPriceLabel.AutoSize = True
        roomPriceLabel.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        roomPriceLabel.ForeColor = Color.SaddleBrown
        roomPriceLabel.Location = New Point(15, 270)
        roomPriceLabel.Text = "RM " & price.ToString("0.00") & " / Day"

        Dim roomDescriptionLabel As New Label()
        roomDescriptionLabel.AutoEllipsis = True
        roomDescriptionLabel.Font = New Font("Segoe UI", 9.0F)
        roomDescriptionLabel.ForeColor = Color.DimGray
        roomDescriptionLabel.Location = New Point(15, 300)
        roomDescriptionLabel.Size = New Size(298, 45)
        roomDescriptionLabel.Text = description

        Dim editButton As New Button()
        editButton.BackColor = Color.Sienna
        editButton.FlatAppearance.BorderSize = 0
        editButton.FlatStyle = FlatStyle.Flat
        editButton.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        editButton.ForeColor = Color.WhiteSmoke
        editButton.Location = New Point(15, 365)
        editButton.Size = New Size(140, 30)
        editButton.Text = "Edit"
        editButton.UseVisualStyleBackColor = False
        editButton.Tag = roomID

        Dim deleteButton As New Button()
        deleteButton.BackColor = Color.FromArgb(96, 52, 16)
        deleteButton.FlatAppearance.BorderSize = 0
        deleteButton.FlatStyle = FlatStyle.Flat
        deleteButton.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        deleteButton.ForeColor = Color.WhiteSmoke
        deleteButton.Location = New Point(173, 365)
        deleteButton.Size = New Size(140, 30)
        deleteButton.Text = "Delete"
        deleteButton.UseVisualStyleBackColor = False
        deleteButton.Tag = roomID

        ' LOAD ROOM PHOTO FROM DATABASE
        If Not IsDBNull(roomPhoto) Then
            Dim photoBytes As Byte() = DirectCast(roomPhoto, Byte())

            If photoBytes.Length > 0 Then
                Try
                    Using memoryStream As New MemoryStream(photoBytes)
                        Using image As Image = Image.FromStream(memoryStream)
                            roomPicture.Image = New Bitmap(image)
                        End Using
                    End Using
                Catch
                    roomPicture.Image = Nothing
                End Try
            End If
        End If

        ' EDIT BUTTON
        AddHandler editButton.Click, AddressOf EditRoom_Click

        ' DELETE BUTTON
        AddHandler deleteButton.Click, AddressOf DeleteRoom_Click

        roomPanel.Controls.Add(roomPicture)
        roomPanel.Controls.Add(roomStatus)
        roomPanel.Controls.Add(roomIDLabel)
        roomPanel.Controls.Add(roomTypeLabel)
        roomPanel.Controls.Add(roomPriceLabel)
        roomPanel.Controls.Add(roomDescriptionLabel)
        roomPanel.Controls.Add(editButton)
        roomPanel.Controls.Add(deleteButton)

        flpRooms.Controls.Add(roomPanel)
    End Sub

    ' CLEAR ROOM CARDS
    Private Sub ClearRoomCards()
        For Each control As Control In flpRooms.Controls
            control.Dispose()
        Next

        flpRooms.Controls.Clear()
    End Sub

    ' STATUS FILTER
    Private Sub cboStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStatus.SelectedIndexChanged
        LoadRoomCards()
    End Sub

    ' SEARCH ROOM
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        SearchRooms()
    End Sub

    ' SEARCH ROOMS FROM DATABASE
    Private Sub SearchRooms()
        Try
            Dim searchText As String = txtSearch.Text.Trim()

            Dim query As String = "SELECT br.RoomID, br.RoomNumber, br.RoomType, br.PricePerDay, br.Description, br.RoomPhoto, CASE WHEN EXISTS (SELECT 1 FROM BoardingBookings bb WHERE bb.RoomID = br.RoomID AND bb.Status IN ('Confirmed', 'Active') AND CURDATE() BETWEEN bb.StartDate AND bb.EndDate) THEN 'Occupied' WHEN EXISTS (SELECT 1 FROM BoardingBookings bb WHERE bb.RoomID = br.RoomID AND bb.Status IN ('Confirmed', 'Active') AND bb.StartDate > CURDATE()) THEN 'Booked' WHEN EXISTS (SELECT 1 FROM BoardingBookings bb WHERE bb.RoomID = br.RoomID AND bb.Status IN ('Confirmed', 'Active') AND bb.EndDate < CURDATE()) THEN 'Available' ELSE br.Status END AS CurrentStatus FROM BoardingRooms br WHERE br.RoomNumber LIKE @Search OR br.RoomType LIKE @Search OR br.Description LIKE @Search ORDER BY br.RoomID"

            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Search", "%" & searchText & "%")

                    Using reader As MySqlDataReader = command.ExecuteReader()
                        ClearRoomCards()

                        While reader.Read()
                            Dim roomID As Integer = Convert.ToInt32(reader("RoomID"))
                            Dim roomNumber As String = reader("RoomNumber").ToString()
                            Dim roomType As String = reader("RoomType").ToString()
                            Dim price As Decimal = Convert.ToDecimal(reader("PricePerDay"))
                            Dim status As String = reader("CurrentStatus").ToString()
                            Dim description As String = reader("Description").ToString()

                            If cboStatus.SelectedItem.ToString() = "All Status" OrElse cboStatus.SelectedItem.ToString() = status Then
                                CreateRoomCard(roomID, roomNumber, roomType, price, status, description, reader("RoomPhoto"))
                            End If
                        End While

                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error searching boarding rooms: " & ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' REFRESH
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtSearch.Clear()
        LoadRoomCards()
    End Sub

    ' ADD ROOM
    Private Sub btnAddRoom_Click(sender As Object, e As EventArgs) Handles btnAddRoom.Click
        Using addRoomForm As New frmAddBoardingRoom()
            If addRoomForm.ShowDialog() = DialogResult.OK Then
                LoadRoomCards()
            End If
        End Using
    End Sub

    ' EDIT ROOM
    Private Sub EditRoom_Click(sender As Object, e As EventArgs)
        Dim button As Button = DirectCast(sender, Button)
        Dim roomID As Integer = Convert.ToInt32(button.Tag)

        Using editRoomForm As New frmEditBoardingRoom(roomID)
            If editRoomForm.ShowDialog() = DialogResult.OK Then
                LoadRoomCards()
            End If
        End Using
    End Sub

    ' DELETE ROOM
    Private Sub DeleteRoom_Click(sender As Object, e As EventArgs)
        Dim button As Button = DirectCast(sender, Button)
        Dim roomID As Integer = Convert.ToInt32(button.Tag)

        If MessageBox.Show("Are you sure you want to delete this boarding room?", "Delete Room", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            Return
        End If

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                Dim query As String = "DELETE FROM BoardingRooms WHERE RoomID = @RoomID"

                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@RoomID", roomID)
                    command.ExecuteNonQuery()
                End Using

                MessageBox.Show("Boarding room deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadRoomCards()

            Catch ex As Exception
                MessageBox.Show("Error deleting boarding room: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' GO BACK TO DASHBOARD
    Private Sub btnGoBackDashboard_Click(sender As Object, e As EventArgs) Handles btnGoBackDashboard.Click
        frmEmployeeDashboard.Show()
        Me.Close()
    End Sub
End Class