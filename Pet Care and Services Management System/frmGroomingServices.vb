Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing

Public Class frmGrommingServices

    ' DATABASE CONNECTION
    Private connectionString As String = "Server=localhost;Database=pet_care_and_services_management_system;Uid=root;Pwd=;"

    ' FORM LOAD
    Private Sub frmGrommingServices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGroomingServices()
    End Sub

    ' LOAD GROOMING SERVICES FROM DATABASE
    Private Sub LoadGroomingServices()
        Try
            Dim query As String = "SELECT ServiceID, ServiceName, Description, Price, Duration, ServicePhoto FROM GroomingServices ORDER BY ServiceID"

            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Using command As New MySqlCommand(query, connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        ClearServiceCards()

                        While reader.Read()
                            CreateServiceCard(reader)
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading grooming services: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' CLEAR SERVICE CARDS
    Private Sub ClearServiceCards()
        For Each control As Control In flpServices.Controls
            control.Dispose()
        Next

        flpServices.Controls.Clear()
    End Sub

    ' CREATE SERVICE CARD
    Private Sub CreateServiceCard(reader As MySqlDataReader)
        Dim serviceID As Integer = Convert.ToInt32(reader("ServiceID"))
        Dim serviceName As String = reader("ServiceName").ToString()
        Dim description As String = reader("Description").ToString()
        Dim price As Decimal = Convert.ToDecimal(reader("Price"))
        Dim duration As Integer = Convert.ToInt32(reader("Duration"))

        Dim servicePanel As New Panel()
        servicePanel.BackColor = Color.White
        servicePanel.BorderStyle = BorderStyle.FixedSingle
        servicePanel.Size = New Size(330, 390)
        servicePanel.Margin = New Padding(10)
        servicePanel.Tag = serviceID

        Dim servicePicture As New PictureBox()
        servicePicture.BackColor = Color.FromArgb(232, 216, 194)
        servicePicture.Location = New Point(15, 15)
        servicePicture.Size = New Size(298, 180)
        servicePicture.SizeMode = PictureBoxSizeMode.Zoom
        servicePicture.TabStop = False

        Dim serviceNameLabel As New Label()
        serviceNameLabel.AutoEllipsis = True
        serviceNameLabel.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        serviceNameLabel.ForeColor = Color.FromArgb(61, 40, 27)
        serviceNameLabel.Location = New Point(15, 207)
        serviceNameLabel.Size = New Size(298, 30)
        serviceNameLabel.Text = serviceName

        Dim priceLabel As New Label()
        priceLabel.AutoSize = True
        priceLabel.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        priceLabel.ForeColor = Color.SaddleBrown
        priceLabel.Location = New Point(15, 242)
        priceLabel.Text = "RM " & price.ToString("0.00")

        Dim durationLabel As New Label()
        durationLabel.AutoSize = True
        durationLabel.Font = New Font("Segoe UI", 9.5F)
        durationLabel.ForeColor = Color.DimGray
        durationLabel.Location = New Point(15, 270)
        durationLabel.Text = duration.ToString() & " minutes"

        Dim descriptionLabel As New Label()
        descriptionLabel.AutoEllipsis = True
        descriptionLabel.Font = New Font("Segoe UI", 9.0F)
        descriptionLabel.ForeColor = Color.DimGray
        descriptionLabel.Location = New Point(15, 296)
        descriptionLabel.Size = New Size(298, 38)
        descriptionLabel.Text = description

        Dim editButton As New Button()
        editButton.BackColor = Color.Sienna
        editButton.FlatAppearance.BorderSize = 0
        editButton.FlatStyle = FlatStyle.Flat
        editButton.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        editButton.ForeColor = Color.WhiteSmoke
        editButton.Location = New Point(15, 345)
        editButton.Size = New Size(140, 30)
        editButton.Text = "Edit"
        editButton.UseVisualStyleBackColor = False
        editButton.Tag = serviceID
        AddHandler editButton.Click, AddressOf EditService_Click

        Dim deleteButton As New Button()
        deleteButton.BackColor = Color.FromArgb(96, 52, 16)
        deleteButton.FlatAppearance.BorderSize = 0
        deleteButton.FlatStyle = FlatStyle.Flat
        deleteButton.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        deleteButton.ForeColor = Color.WhiteSmoke
        deleteButton.Location = New Point(173, 345)
        deleteButton.Size = New Size(140, 30)
        deleteButton.Text = "Delete"
        deleteButton.UseVisualStyleBackColor = False
        deleteButton.Tag = serviceID
        AddHandler deleteButton.Click, AddressOf DeleteService_Click

        If Not IsDBNull(reader("ServicePhoto")) Then
            Dim imageBytes() As Byte = DirectCast(reader("ServicePhoto"), Byte())

            If imageBytes IsNot Nothing AndAlso imageBytes.Length > 0 Then
                Try
                    Using memoryStream As New MemoryStream(imageBytes)
                        Using tempImage As Image = Image.FromStream(memoryStream)
                            servicePicture.Image = New Bitmap(tempImage)
                        End Using
                    End Using
                Catch
                    servicePicture.Image = Nothing
                End Try
            End If
        End If

        servicePanel.Controls.Add(servicePicture)
        servicePanel.Controls.Add(serviceNameLabel)
        servicePanel.Controls.Add(priceLabel)
        servicePanel.Controls.Add(durationLabel)
        servicePanel.Controls.Add(descriptionLabel)
        servicePanel.Controls.Add(editButton)
        servicePanel.Controls.Add(deleteButton)

        flpServices.Controls.Add(servicePanel)
    End Sub

    ' SEARCH GROOMING SERVICES
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text = "Search grooming service..." Then
            Return
        End If

        SearchGroomingServices()
    End Sub

    ' SEARCH GROOMING SERVICES FROM DATABASE
    Private Sub SearchGroomingServices()
        Try
            Dim searchText As String = txtSearch.Text.Trim()
            Dim query As String = "SELECT ServiceID, ServiceName, Description, Price, Duration, ServicePhoto FROM GroomingServices WHERE ServiceName LIKE @Search OR Description LIKE @Search ORDER BY ServiceID"

            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Search", "%" & searchText & "%")

                    Using reader As MySqlDataReader = command.ExecuteReader()
                        ClearServiceCards()

                        While reader.Read()
                            CreateServiceCard(reader)
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error searching grooming services: " & ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' REFRESH
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtSearch.Text = "Search grooming service..."
        LoadGroomingServices()
    End Sub

    ' ADD GROOMING SERVICE
    Private Sub btnAddGroomingService_Click(sender As Object, e As EventArgs) Handles btnAddGroomingService.Click
        Using addForm As New frmAddGroomingService()
            addForm.ShowDialog()
        End Using

        LoadGroomingServices()
    End Sub

    ' EDIT SERVICE
    Private Sub EditService_Click(sender As Object, e As EventArgs)
        Dim button As Button = DirectCast(sender, Button)
        Dim serviceID As Integer = Convert.ToInt32(button.Tag)

        Using editForm As New frmEditGroomingService(serviceID)
            editForm.ShowDialog()
        End Using

        LoadGroomingServices()
    End Sub

    ' DELETE SERVICE
    Private Sub DeleteService_Click(sender As Object, e As EventArgs)
        Dim button As Button = DirectCast(sender, Button)
        Dim serviceID As Integer = Convert.ToInt32(button.Tag)

        If MessageBox.Show(
            "Are you sure you want to delete this grooming service?",
            "Delete Service",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        ) = DialogResult.No Then
            Return
        End If

        Try
            Dim query As String = "DELETE FROM GroomingServices WHERE ServiceID = @ServiceID"

            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@ServiceID", serviceID)
                    command.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Grooming service deleted successfully.", "Delete Service", MessageBoxButtons.OK, MessageBoxIcon.Information)

            LoadGroomingServices()

        Catch ex As MySqlException
            If ex.Number = 1451 Then
                MessageBox.Show("This grooming service cannot be deleted because it is already used in a grooming booking.", "Delete Service", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Error deleting grooming service: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error deleting grooming service: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' GO BACK TO DASHBOARD
    Private Sub btnGoBackDashboard_Click(sender As Object, e As EventArgs) Handles btnGoBackDashboard.Click
        frmEmployeeDashboard.Show()
        Me.Close()
    End Sub

    Private Sub flpServices_Paint(sender As Object, e As PaintEventArgs) Handles flpServices.Paint

    End Sub
End Class