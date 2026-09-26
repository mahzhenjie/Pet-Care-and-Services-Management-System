Imports MySql.Data.MySqlClient
Imports System.IO

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

                        Dim cardNumber As Integer = 1

                        While reader.Read() AndAlso cardNumber <= 6

                            LoadServiceCard(cardNumber, reader)
                            cardNumber += 1

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

        Dim panels() As Panel = {pnlService1, pnlService2, pnlService3, pnlService4, pnlService5, pnlService6}
        Dim pictures() As PictureBox = {picService1, picService2, picService3, picService4, picService5, picService6}
        Dim names() As Label = {lblServiceName1, lblServiceName2, lblServiceName3, lblServiceName4, lblServiceName5, lblServiceName6}
        Dim prices() As Label = {lblPrice1, lblPrice2, lblPrice3, lblPrice4, lblPrice5, lblPrice6}
        Dim durations() As Label = {lblDuration1, lblDuration2, lblDuration3, lblDuration4, lblDuration5, lblDuration6}
        Dim descriptions() As Label = {lblDescription1, lblDescription2, lblDescription3, lblDescription4, lblDescription5, lblDescription6}

        For i As Integer = 0 To 5

            panels(i).Tag = Nothing
            pictures(i).Image = Nothing
            names(i).Text = ""
            prices(i).Text = ""
            durations(i).Text = ""
            descriptions(i).Text = ""

            panels(i).Visible = False

        Next

    End Sub

    ' LOAD SERVICE CARD
    Private Sub LoadServiceCard(cardNumber As Integer, reader As MySqlDataReader)

        Dim serviceID As Integer = Convert.ToInt32(reader("ServiceID"))
        Dim serviceName As String = reader("ServiceName").ToString()
        Dim description As String = reader("Description").ToString()
        Dim price As Decimal = Convert.ToDecimal(reader("Price"))
        Dim duration As Integer = Convert.ToInt32(reader("Duration"))

        Dim servicePanel As Panel = Nothing
        Dim servicePicture As PictureBox = Nothing
        Dim serviceNameLabel As Label = Nothing
        Dim priceLabel As Label = Nothing
        Dim durationLabel As Label = Nothing
        Dim descriptionLabel As Label = Nothing

        Select Case cardNumber

            Case 1

                servicePanel = pnlService1
                servicePicture = picService1
                serviceNameLabel = lblServiceName1
                priceLabel = lblPrice1
                durationLabel = lblDuration1
                descriptionLabel = lblDescription1

            Case 2

                servicePanel = pnlService2
                servicePicture = picService2
                serviceNameLabel = lblServiceName2
                priceLabel = lblPrice2
                durationLabel = lblDuration2
                descriptionLabel = lblDescription2

            Case 3

                servicePanel = pnlService3
                servicePicture = picService3
                serviceNameLabel = lblServiceName3
                priceLabel = lblPrice3
                durationLabel = lblDuration3
                descriptionLabel = lblDescription3

            Case 4

                servicePanel = pnlService4
                servicePicture = picService4
                serviceNameLabel = lblServiceName4
                priceLabel = lblPrice4
                durationLabel = lblDuration4
                descriptionLabel = lblDescription4

            Case 5

                servicePanel = pnlService5
                servicePicture = picService5
                serviceNameLabel = lblServiceName5
                priceLabel = lblPrice5
                durationLabel = lblDuration5
                descriptionLabel = lblDescription5

            Case 6

                servicePanel = pnlService6
                servicePicture = picService6
                serviceNameLabel = lblServiceName6
                priceLabel = lblPrice6
                durationLabel = lblDuration6
                descriptionLabel = lblDescription6

        End Select

        If servicePanel Is Nothing Then
            Return
        End If

        servicePanel.Tag = serviceID
        servicePanel.Visible = True

        serviceNameLabel.Text = serviceName
        priceLabel.Text = "RM " & price.ToString("0.00")
        durationLabel.Text = duration.ToString() & " minutes"
        descriptionLabel.Text = description

        ' LOAD SERVICE PHOTO
        If Not IsDBNull(reader("ServicePhoto")) Then

            Dim imageBytes() As Byte = DirectCast(reader("ServicePhoto"), Byte())

            If imageBytes IsNot Nothing AndAlso imageBytes.Length > 0 Then

                Using memoryStream As New MemoryStream(imageBytes)

                    Using tempImage As Image = Image.FromStream(memoryStream)

                        servicePicture.Image = New Bitmap(tempImage)

                    End Using

                End Using

                servicePicture.SizeMode = PictureBoxSizeMode.Zoom

            End If

        End If

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

                        Dim cardNumber As Integer = 1

                        While reader.Read() AndAlso cardNumber <= 6

                            LoadServiceCard(cardNumber, reader)
                            cardNumber += 1

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

        Dim addForm As New frmAddGroomingService()

        addForm.ShowDialog()

        LoadGroomingServices()

    End Sub

    ' EDIT SERVICE 1
    Private Sub btnEdit1_Click(sender As Object, e As EventArgs) Handles btnEdit1.Click
        EditService(pnlService1)
    End Sub

    ' EDIT SERVICE 2
    Private Sub btnEdit2_Click(sender As Object, e As EventArgs) Handles btnEdit2.Click
        EditService(pnlService2)
    End Sub

    ' EDIT SERVICE 3
    Private Sub btnEdit3_Click(sender As Object, e As EventArgs) Handles btnEdit3.Click
        EditService(pnlService3)
    End Sub

    ' EDIT SERVICE 4
    Private Sub btnEdit4_Click(sender As Object, e As EventArgs) Handles btnEdit4.Click
        EditService(pnlService4)
    End Sub

    ' EDIT SERVICE 5
    Private Sub btnEdit5_Click(sender As Object, e As EventArgs) Handles btnEdit5.Click
        EditService(pnlService5)
    End Sub

    ' EDIT SERVICE 6
    Private Sub btnEdit6_Click(sender As Object, e As EventArgs) Handles btnEdit6.Click
        EditService(pnlService6)
    End Sub

    ' EDIT SERVICE
    Private Sub EditService(servicePanel As Panel)

        If servicePanel.Tag Is Nothing Then

            MessageBox.Show("Please select a grooming service.", "Edit Service", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Return

        End If

        Dim serviceID As Integer = Convert.ToInt32(servicePanel.Tag)

        Dim editForm As New frmEditGroomingService(serviceID)

        editForm.ShowDialog()

        LoadGroomingServices()

    End Sub

    ' DELETE SERVICE 1
    Private Sub btnDelete1_Click(sender As Object, e As EventArgs) Handles btnDelete1.Click
        DeleteService(pnlService1)
    End Sub

    ' DELETE SERVICE 2
    Private Sub btnDelete2_Click(sender As Object, e As EventArgs) Handles btnDelete2.Click
        DeleteService(pnlService2)
    End Sub

    ' DELETE SERVICE 3
    Private Sub btnDelete3_Click(sender As Object, e As EventArgs) Handles btnDelete3.Click
        DeleteService(pnlService3)
    End Sub

    ' DELETE SERVICE 4
    Private Sub btnDelete4_Click(sender As Object, e As EventArgs) Handles btnDelete4.Click
        DeleteService(pnlService4)
    End Sub

    ' DELETE SERVICE 5
    Private Sub btnDelete5_Click(sender As Object, e As EventArgs) Handles btnDelete5.Click
        DeleteService(pnlService5)
    End Sub

    ' DELETE SERVICE 6
    Private Sub btnDelete6_Click(sender As Object, e As EventArgs) Handles btnDelete6.Click
        DeleteService(pnlService6)
    End Sub

    ' DELETE SERVICE
    Private Sub DeleteService(servicePanel As Panel)

        If servicePanel.Tag Is Nothing Then

            MessageBox.Show("Please select a grooming service.", "Delete Service", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Return

        End If

        Dim serviceID As Integer = Convert.ToInt32(servicePanel.Tag)

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this grooming service?", "Delete Service", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.No Then
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

        Dim dashboardForm As New frmEmployeeDashboard()

        dashboardForm.Show()

        Me.Close()

    End Sub

End Class