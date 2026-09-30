Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmBoardingRoom

    ' DATABASE CONNECTION
    Private connectionString As String = "Server=localhost;Database=pet_care_and_services_management_system;Uid=root;Pwd=;"

    Private roomIDValues(7) As Integer

    ' FORM LOAD
    Private Sub frmBoardingRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboStatus.SelectedIndex = 0
        LoadRoomCards()
    End Sub

    ' LOAD ROOM DATA FROM DATABASE
    Private Sub LoadRoomCards()
        ClearRoomCards()
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT br.RoomID, br.RoomNumber, br.RoomType, br.PricePerDay, br.Description, br.RoomPhoto, CASE WHEN EXISTS (SELECT 1 FROM BoardingBookings bb WHERE bb.RoomID = br.RoomID AND bb.Status IN ('Confirmed', 'Active') AND CURDATE() BETWEEN bb.StartDate AND bb.EndDate) THEN 'Occupied' WHEN EXISTS (SELECT 1 FROM BoardingBookings bb WHERE bb.RoomID = br.RoomID AND bb.Status IN ('Confirmed', 'Active') AND bb.StartDate > CURDATE()) THEN 'Booked' WHEN EXISTS (SELECT 1 FROM BoardingBookings bb WHERE bb.RoomID = br.RoomID AND bb.EndDate < CURDATE()) THEN 'Available' ELSE br.Status END AS CurrentStatus FROM BoardingRooms br ORDER BY br.RoomID"
                Using command As New MySqlCommand(query, connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        Dim index As Integer = 0
                        While reader.Read() AndAlso index < 8
                            Dim roomID As Integer = Convert.ToInt32(reader("RoomID"))
                            Dim roomNumber As String = reader("RoomNumber").ToString()
                            Dim roomType As String = reader("RoomType").ToString()
                            Dim price As Decimal = Convert.ToDecimal(reader("PricePerDay"))
                            Dim status As String = reader("CurrentStatus").ToString()
                            Dim description As String = reader("Description").ToString()
                            If cboStatus.SelectedItem.ToString() = "All Status" OrElse cboStatus.SelectedItem.ToString() = status Then
                                roomIDValues(index) = roomID
                                DisplayRoomCard(index, roomID, roomNumber, roomType, price, status, description, reader("RoomPhoto"))
                                index += 1
                            End If
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading boarding rooms: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' DISPLAY ROOM CARD
    Private Sub DisplayRoomCard(index As Integer, roomID As Integer, roomNumber As String, roomType As String, price As Decimal, status As String, description As String, roomPhoto As Object)

        Dim roomPanel As Panel = Nothing
        Dim roomPicture As PictureBox = Nothing
        Dim roomStatus As Label = Nothing
        Dim roomIDLabel As Label = Nothing
        Dim roomTypeLabel As Label = Nothing
        Dim roomPriceLabel As Label = Nothing
        Dim roomDescriptionLabel As Label = Nothing
        Dim editButton As Button = Nothing
        Dim deleteButton As Button = Nothing

        Select Case index
            Case 0
                roomPanel = pnlRoom1
                roomPicture = picRoom1
                roomStatus = lblStatus1
                roomIDLabel = lblRoomID1
                roomTypeLabel = lblRoomType1
                roomPriceLabel = lblPrice1
                roomDescriptionLabel = lblDescription1
                editButton = btnEdit1
                deleteButton = btnDelete1

            Case 1
                roomPanel = pnlRoom2
                roomPicture = picRoom2
                roomStatus = lblStatus2
                roomIDLabel = lblRoomID2
                roomTypeLabel = lblRoomType2
                roomPriceLabel = lblPrice2
                roomDescriptionLabel = lblDescription2
                editButton = btnEdit2
                deleteButton = btnDelete2

            Case 2
                roomPanel = pnlRoom3
                roomPicture = picRoom3
                roomStatus = lblStatus3
                roomIDLabel = lblRoomID3
                roomTypeLabel = lblRoomType3
                roomPriceLabel = lblPrice3
                roomDescriptionLabel = lblDescription3
                editButton = btnEdit3
                deleteButton = btnDelete3

            Case 3
                roomPanel = pnlRoom4
                roomPicture = picRoom4
                roomStatus = lblStatus4
                roomIDLabel = lblRoomID4
                roomTypeLabel = lblRoomType4
                roomPriceLabel = lblPrice4
                roomDescriptionLabel = lblDescription4
                editButton = btnEdit4
                deleteButton = btnDelete4

            Case 4
                roomPanel = pnlRoom5
                roomPicture = picRoom5
                roomStatus = lblStatus5
                roomIDLabel = lblRoomID5
                roomTypeLabel = lblRoomType5
                roomPriceLabel = lblPrice5
                roomDescriptionLabel = lblDescription5
                editButton = btnEdit5
                deleteButton = btnDelete5

            Case 5
                roomPanel = pnlRoom6
                roomPicture = picRoom6
                roomStatus = lblStatus6
                roomIDLabel = lblRoomID6
                roomTypeLabel = lblRoomType6
                roomPriceLabel = lblPrice6
                roomDescriptionLabel = lblDescription6
                editButton = btnEdit6
                deleteButton = btnDelete6

            Case 6
                roomPanel = pnlRoom7
                roomPicture = picRoom7
                roomStatus = lblStatus7
                roomIDLabel = lblRoomID7
                roomTypeLabel = lblRoomType7
                roomPriceLabel = lblPrice7
                roomDescriptionLabel = lblDescription7
                editButton = btnEdit7
                deleteButton = btnDelete7

            Case 7
                roomPanel = pnlRoom8
                roomPicture = picRoom8
                roomStatus = lblStatus8
                roomIDLabel = lblRoomID8
                roomTypeLabel = lblRoomType8
                roomPriceLabel = lblPrice8
                roomDescriptionLabel = lblDescription8
                editButton = btnEdit8
                deleteButton = btnDelete8
        End Select

        If roomPanel Is Nothing Then
            Return
        End If

        roomPanel.Visible = True

        roomIDLabel.Text = roomNumber
        roomTypeLabel.Text = roomType
        roomPriceLabel.Text = "RM " & price.ToString("0.00") & " / Day"
        roomDescriptionLabel.Text = description
        roomStatus.Text = status

        ' ROOM STATUS COLOR
        If status = "Available" Then
            roomStatus.ForeColor = Color.Green
        ElseIf status = "Occupied" Then
            roomStatus.ForeColor = Color.Red
        ElseIf status = "Booked" Then
            roomStatus.ForeColor = Color.DarkOrange
        Else
            roomStatus.ForeColor = Color.SaddleBrown
        End If

        ' LOAD ROOM PHOTO FROM DATABASE
        roomPicture.SizeMode = PictureBoxSizeMode.StretchImage
        roomPicture.Image = Nothing

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
        RemoveHandler editButton.Click, AddressOf EditRoom_Click
        AddHandler editButton.Click, AddressOf EditRoom_Click

        ' DELETE BUTTON
        RemoveHandler deleteButton.Click, AddressOf DeleteRoom_Click
        AddHandler deleteButton.Click, AddressOf DeleteRoom_Click

        editButton.Tag = roomID
        deleteButton.Tag = roomID

    End Sub

    ' CLEAR ROOM CARDS
    Private Sub ClearRoomCards()

        Dim panels() As Panel = {pnlRoom1, pnlRoom2, pnlRoom3, pnlRoom4, pnlRoom5, pnlRoom6, pnlRoom7, pnlRoom8}

        For Each panel As Panel In panels
            panel.Visible = False
        Next

        picRoom1.Image = Nothing
        picRoom2.Image = Nothing
        picRoom3.Image = Nothing
        picRoom4.Image = Nothing
        picRoom5.Image = Nothing
        picRoom6.Image = Nothing
        picRoom7.Image = Nothing
        picRoom8.Image = Nothing

    End Sub

    ' STATUS FILTER
    Private Sub cboStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStatus.SelectedIndexChanged
        LoadRoomCards()
    End Sub

    ' SEARCH ROOM
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

        Dim searchText As String = txtSearch.Text.Trim().ToLower()

        Dim panels() As Panel = {pnlRoom1, pnlRoom2, pnlRoom3, pnlRoom4, pnlRoom5, pnlRoom6, pnlRoom7, pnlRoom8}

        For Each panel As Panel In panels

            If panel.Visible Then

                Dim roomNumberLabel As Label = Nothing

                For Each control As Control In panel.Controls

                    If TypeOf control Is Label Then

                        Dim currentLabel As Label = DirectCast(control, Label)

                        If currentLabel.Name.StartsWith("lblRoomID") Then
                            roomNumberLabel = currentLabel
                            Exit For
                        End If

                    End If

                Next

                If roomNumberLabel IsNot Nothing Then

                    If roomNumberLabel.Text.ToLower().Contains(searchText) Then
                        panel.Visible = True
                    Else
                        panel.Visible = False
                    End If

                End If

            End If

        Next

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

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this boarding room?", "Delete Room", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then

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

        End If

    End Sub

    ' GO BACK TO DASHBOARD
    Private Sub btnGoBackDashboard_Click(sender As Object, e As EventArgs) Handles btnGoBackDashboard.Click
        Dim dashboardForm As New frmEmployeeDashboard()
        dashboardForm.Show()
        Me.Close()
    End Sub

    ' RESIZE ROOM CARDS
    Private Sub ResizeRoomCards()

        Dim availableWidth As Integer = flpRooms.ClientSize.Width
        Dim cardWidth As Integer = (availableWidth - 45) \ 4

        If cardWidth < 250 Then
            cardWidth = 250
        End If

        Dim roomPanels() As Panel = {pnlRoom1, pnlRoom2, pnlRoom3, pnlRoom4, pnlRoom5, pnlRoom6, pnlRoom7, pnlRoom8}

        Dim roomPictures() As PictureBox = {picRoom1, picRoom2, picRoom3, picRoom4, picRoom5, picRoom6, picRoom7, picRoom8}

        Dim editButtons() As Button = {btnEdit1, btnEdit2, btnEdit3, btnEdit4, btnEdit5, btnEdit6, btnEdit7, btnEdit8}

        Dim deleteButtons() As Button = {btnDelete1, btnDelete2, btnDelete3, btnDelete4, btnDelete5, btnDelete6, btnDelete7, btnDelete8}

        For i As Integer = 0 To roomPanels.Length - 1

            roomPanels(i).Width = cardWidth

            roomPictures(i).Width = cardWidth - 20

            editButtons(i).Width = (cardWidth - 35) \ 2

            deleteButtons(i).Width = (cardWidth - 35) \ 2

            deleteButtons(i).Left = editButtons(i).Right + 10

        Next

    End Sub

    ' FORM RESIZE
    Private Sub frmBoardingRoom_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ResizeRoomCards()
    End Sub

End Class