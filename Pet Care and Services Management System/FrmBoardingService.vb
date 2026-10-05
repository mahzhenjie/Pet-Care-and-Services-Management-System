Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.IO

Public Class FrmBoardingService

    Private connectionString As String = "Server=127.0.0.1;Database=pet_care_and_services_management_system;Uid=root;Pwd=;"

    Private Sub FrmBoardingService_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRooms()
    End Sub

    ' -----------------------------------------------------------
    ' DYNAMICALLY LOAD ROOM CARDS & CALCULATE REAL STATUS
    ' -----------------------------------------------------------
    Private Sub LoadRooms(Optional searchText As String = "")
        ' Clear existing cards
        flpRooms.Controls.Clear()

        ' This SQL dynamically checks the boardingbookings table to see if the room is currently occupied today.
        Dim query As String = "
            SELECT 
                br.RoomID, br.RoomNumber, br.RoomType, br.PricePerDay, br.Description, br.RoomPhoto,
                CASE 
                    WHEN EXISTS (
                        SELECT 1 FROM boardingbookings bb 
                        WHERE bb.RoomID = br.RoomID 
                          AND bb.Status IN ('Confirmed', 'Pending') 
                          AND CURDATE() <= bb.EndDate 
                          AND CURDATE() >= bb.StartDate
                    ) THEN 'Occupied'
                    ELSE 'Available'
                END AS RealStatus
            FROM boardingrooms br
            WHERE br.RoomNumber LIKE @Search OR br.RoomType LIKE @Search"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Search", "%" & searchText & "%")

                Try
                    connection.Open()
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            ' Create the dynamic card
                            CreateRoomCard(reader)
                        End While
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error loading rooms: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    ' -----------------------------------------------------------
    ' GENERATE UI CARD FOR EACH ROOM
    ' -----------------------------------------------------------
    Private Sub CreateRoomCard(reader As MySqlDataReader)
        Dim roomId As Integer = Convert.ToInt32(reader("RoomID"))
        Dim realStatus As String = reader("RealStatus").ToString()

        ' 1. Main Card Panel
        Dim pnlCard As New Panel()
        pnlCard.Size = New Size(260, 360)
        pnlCard.BackColor = Color.White
        pnlCard.Margin = New Padding(15)
        pnlCard.BorderStyle = BorderStyle.FixedSingle

        ' 2. Room Photo
        Dim pbPhoto As New PictureBox()
        pbPhoto.Size = New Size(260, 150)
        pbPhoto.Location = New Point(0, 0)
        pbPhoto.SizeMode = PictureBoxSizeMode.StretchImage
        If Not IsDBNull(reader("RoomPhoto")) Then
            Dim imgData As Byte() = DirectCast(reader("RoomPhoto"), Byte())
            Using ms As New MemoryStream(imgData)
                pbPhoto.Image = Image.FromStream(ms)
            End Using
        End If
        pnlCard.Controls.Add(pbPhoto)

        ' 3. Room Number (Title)
        Dim lblRoomNumber As New Label()
        lblRoomNumber.Text = reader("RoomNumber").ToString()
        lblRoomNumber.Font = New Font("Segoe UI", 14, FontStyle.Bold)
        lblRoomNumber.Location = New Point(10, 160)
        lblRoomNumber.AutoSize = True
        pnlCard.Controls.Add(lblRoomNumber)

        ' 4. Room Type
        Dim lblType As New Label()
        lblType.Text = reader("RoomType").ToString()
        lblType.ForeColor = Color.Gray
        lblType.Location = New Point(12, 190)
        lblType.AutoSize = True
        pnlCard.Controls.Add(lblType)

        ' 5. Price
        Dim lblPrice As New Label()
        lblPrice.Text = "RM " & Convert.ToDecimal(reader("PricePerDay")).ToString("0.00") & " / Day"
        lblPrice.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        lblPrice.ForeColor = Color.SaddleBrown
        lblPrice.Location = New Point(12, 215)
        lblPrice.AutoSize = True
        pnlCard.Controls.Add(lblPrice)

        ' 6. Status Label (Available or Occupied)
        Dim lblStatus As New Label()
        lblStatus.Text = realStatus
        lblStatus.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblStatus.Location = New Point(170, 165)
        lblStatus.AutoSize = True
        If realStatus = "Available" Then
            lblStatus.ForeColor = Color.Green
        Else
            lblStatus.ForeColor = Color.Red
        End If
        pnlCard.Controls.Add(lblStatus)

        ' 7. Book Room Button (Replaces Edit/Delete)
        Dim btnBook As New Button()
        btnBook.Text = If(realStatus = "Available", "Book Room", "Currently Occupied")
        btnBook.Size = New Size(236, 35)
        btnBook.Location = New Point(12, 310)
        btnBook.BackColor = Color.SaddleBrown
        btnBook.ForeColor = Color.White
        btnBook.FlatStyle = FlatStyle.Flat
        btnBook.Enabled = (realStatus = "Available") ' Disable if occupied

        ' Attach the RoomID to the button's Tag property so we know which room to book
        btnBook.Tag = roomId
        AddHandler btnBook.Click, AddressOf BookRoom_Click
        pnlCard.Controls.Add(btnBook)

        ' Add the fully assembled card to the FlowLayoutPanel
        flpRooms.Controls.Add(pnlCard)
    End Sub

    ' -----------------------------------------------------------
    ' BOOK ROOM BUTTON CLICK EVENT
    ' -----------------------------------------------------------
    Private Sub BookRoom_Click(sender As Object, e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        Dim selectedRoomId As Integer = Convert.ToInt32(btn.Tag)

        ' Open the Add Booking form. 
        ' You can modify your FrmNewAppointment constructor to accept the RoomID to auto-select it.
        Dim bookingForm As New FrmBookingBoardingService()
        bookingForm.ShowDialog()

        ' Refresh the cards after booking is closed to update availability
        LoadRooms()
    End Sub

    ' -----------------------------------------------------------
    ' TOP MENU BUTTONS
    ' -----------------------------------------------------------
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim searchText As String = txtSearch.Text.Trim()
        If searchText = "Search boarding service..." Then searchText = ""
        LoadRooms(searchText)
    End Sub

    Private Sub Refreshbtn_Click(sender As Object, e As EventArgs) Handles Refreshbtn.Click
        txtSearch.Clear()
        LoadRooms()
    End Sub

    Private Sub btnAddBooking_Click(sender As Object, e As EventArgs) Handles btnAddBooking.Click
        Dim bookingForm As New FrmBookingBoardingService()
        bookingForm.ShowDialog()
        LoadRooms()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        frmCustomerDashboard.Show()
        Me.Close()
    End Sub
End Class