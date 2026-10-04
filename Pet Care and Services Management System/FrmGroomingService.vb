Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.IO

Public Class FrmGroomingService

    Private connectionString As String = "Server=127.0.0.1;Database=pet_care_and_services_management_system;Uid=root;Pwd=;"

    ' -----------------------------------------------------------
    ' FORM LOAD
    ' -----------------------------------------------------------
    Private Sub FrmGroomingService_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadServices()
    End Sub

    ' -----------------------------------------------------------
    ' DYNAMICALLY LOAD GROOMING SERVICES
    ' -----------------------------------------------------------
    Private Sub LoadServices(Optional searchText As String = "")
        ' Clear existing cards from the FlowLayoutPanel
        flpServices.Controls.Clear()

        Dim query As String = "SELECT ServiceID, ServiceName, Description, Price, Duration, ServicePhoto FROM groomingservices WHERE ServiceName LIKE @Search"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Search", "%" & searchText & "%")

                Try
                    connection.Open()
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            ' Generate a card for each grooming service
                            CreateServiceCard(reader)
                        End While
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error loading grooming services: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    ' -----------------------------------------------------------
    ' GENERATE UI CARD FOR EACH SERVICE
    ' -----------------------------------------------------------
    Private Sub CreateServiceCard(reader As MySqlDataReader)
        Dim serviceId As Integer = Convert.ToInt32(reader("ServiceID"))

        ' 1. Main Card Panel
        Dim pnlCard As New Panel()
        pnlCard.Size = New Size(260, 420)
        pnlCard.BackColor = Color.White
        pnlCard.Margin = New Padding(15)
        pnlCard.BorderStyle = BorderStyle.FixedSingle

        ' 2. Service Photo
        Dim pbPhoto As New PictureBox()
        pbPhoto.Size = New Size(260, 160)
        pbPhoto.Location = New Point(0, 0)
        pbPhoto.SizeMode = PictureBoxSizeMode.StretchImage
        If Not IsDBNull(reader("ServicePhoto")) Then
            Dim imgData As Byte() = DirectCast(reader("ServicePhoto"), Byte())
            Using ms As New MemoryStream(imgData)
                pbPhoto.Image = Image.FromStream(ms)
            End Using
        End If
        pnlCard.Controls.Add(pbPhoto)

        ' 3. Service Name (Title)
        Dim lblTitle As New Label()
        lblTitle.Text = reader("ServiceName").ToString()
        lblTitle.Font = New Font("Segoe UI", 12, FontStyle.Bold)
        lblTitle.Location = New Point(10, 175)
        lblTitle.AutoSize = True
        pnlCard.Controls.Add(lblTitle)

        ' 4. Price
        Dim lblPrice As New Label()
        lblPrice.Text = "RM " & Convert.ToDecimal(reader("Price")).ToString("0.00")
        lblPrice.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        lblPrice.ForeColor = Color.SaddleBrown
        lblPrice.Location = New Point(12, 205)
        lblPrice.AutoSize = True
        pnlCard.Controls.Add(lblPrice)

        ' 5. Duration
        Dim lblDuration As New Label()
        lblDuration.Text = reader("Duration").ToString() & " minutes"
        lblDuration.Font = New Font("Segoe UI", 9, FontStyle.Regular)
        lblDuration.ForeColor = Color.Gray
        lblDuration.Location = New Point(12, 230)
        lblDuration.AutoSize = True
        pnlCard.Controls.Add(lblDuration)

        ' 6. Description (Wrapped Text)
        Dim lblDesc As New Label()
        lblDesc.Text = reader("Description").ToString()
        lblDesc.Font = New Font("Segoe UI", 9, FontStyle.Regular)
        lblDesc.ForeColor = Color.DimGray
        lblDesc.Location = New Point(12, 255)
        lblDesc.Size = New Size(236, 80) ' Fixed size to allow text wrapping
        lblDesc.AutoSize = False
        pnlCard.Controls.Add(lblDesc)

        ' 7. Book Service Button (Replaces Edit and Delete)
        Dim btnBook As New Button()
        btnBook.Text = "Book Service"
        btnBook.Size = New Size(236, 35)
        btnBook.Location = New Point(12, 355)
        btnBook.BackColor = Color.SaddleBrown
        btnBook.ForeColor = Color.White
        btnBook.FlatStyle = FlatStyle.Flat

        ' Attach the ServiceID to the button's Tag property
        btnBook.Tag = serviceId
        AddHandler btnBook.Click, AddressOf BookService_Click
        pnlCard.Controls.Add(btnBook)

        ' Add the fully assembled card to the FlowLayoutPanel
        flpServices.Controls.Add(pnlCard)
    End Sub

    ' -----------------------------------------------------------
    ' BOOK SERVICE BUTTON CLICK EVENT
    ' -----------------------------------------------------------
    Private Sub BookService_Click(sender As Object, e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        Dim selectedServiceId As Integer = Convert.ToInt32(btn.Tag)

        ' Open the general Add Appointment form
        ' If your FrmNewAppointment accepts a ServiceID in its constructor, you can pass it here.
        Dim bookingForm As New FrmBookingGroomingService()
        bookingForm.ShowDialog()
    End Sub

    ' -----------------------------------------------------------
    ' TOP MENU BUTTONS & SEARCH
    ' -----------------------------------------------------------
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim searchText As String = txtSearch.Text.Trim()
        ' Ignore the default placeholder text if applicable
        If searchText = "Search grooming service..." Then searchText = ""
        LoadServices(searchText)
    End Sub

    Private Sub Refreshbtn_Click(sender As Object, e As EventArgs) Handles Refreshbtn.Click
        txtSearch.Clear()
        LoadServices()
    End Sub

    Private Sub btnBookingService_Click(sender As Object, e As EventArgs) Handles btnBookingService.Click
        ' This represents the "+ Add Service" button at the top of the form
        Dim bookingForm As New FrmBookingGroomingService()
        bookingForm.ShowDialog()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Me.Close()
    End Sub

End Class