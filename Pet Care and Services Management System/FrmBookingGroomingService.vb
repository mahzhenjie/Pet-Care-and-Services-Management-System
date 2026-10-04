Imports System.Data
Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud

Public Class FrmBookingGroomingService

    Private connectionString As String = "Server=127.0.0.1;Database=pet_care_and_services_management_system;Uid=root;Pwd=;"
    Private passedServiceId As Integer = 0

    ' -----------------------------------------------------------
    ' CONSTRUCTOR
    ' -----------------------------------------------------------
    ' Accepts an optional ServiceID so the form can auto-select the service 
    ' if the user clicks "Book Service" from a specific card.
    Public Sub New(Optional serviceId As Integer = 0)
        InitializeComponent()
        passedServiceId = serviceId
    End Sub

    ' -----------------------------------------------------------
    ' FORM LOAD
    ' -----------------------------------------------------------
    Private Sub FrmBookingGroomingService_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If GlobalVariables.LoggedInCustomerID <= 0 Then
            MessageBox.Show("Error: You must be logged in to make a booking.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If

        ' Prevent booking dates in the past
        dtpDate.MinDate = DateTime.Today

        ' Load data into comboboxes
        LoadCustomerPets()
        LoadServices()
    End Sub

    ' -----------------------------------------------------------
    ' LOAD PETS FOR CURRENT CUSTOMER
    ' -----------------------------------------------------------
    Private Sub LoadCustomerPets()
        Dim query As String = "SELECT PetID, PetName FROM pets WHERE CustomerID = @CustomerID"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@CustomerID", GlobalVariables.LoggedInCustomerID)
                Try
                    connection.Open()
                    Dim adapter As New MySqlDataAdapter(command)
                    Dim dtPets As New DataTable()
                    adapter.Fill(dtPets)

                    cmbPetName.DataSource = dtPets
                    cmbPetName.DisplayMember = "PetName"
                    cmbPetName.ValueMember = "PetID"
                    cmbPetName.SelectedIndex = -1 ' Keep blank initially
                Catch ex As Exception
                    MessageBox.Show("Error loading pets: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    ' -----------------------------------------------------------
    ' LOAD AVAILABLE GROOMING SERVICES
    ' -----------------------------------------------------------
    Private Sub LoadServices()
        Dim query As String = "SELECT ServiceID, ServiceName FROM groomingservices"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                Try
                    connection.Open()
                    Dim adapter As New MySqlDataAdapter(command)
                    Dim dtServices As New DataTable()
                    adapter.Fill(dtServices)

                    cmbServiceName.DataSource = dtServices
                    cmbServiceName.DisplayMember = "ServiceName"
                    cmbServiceName.ValueMember = "ServiceID"
                    cmbServiceName.SelectedIndex = -1

                    ' Auto-select the service if the user came from a specific service card
                    If passedServiceId > 0 Then
                        cmbServiceName.SelectedValue = passedServiceId
                        passedServiceId = 0 ' Reset after selection
                    End If

                Catch ex As Exception
                    MessageBox.Show("Error loading services: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    ' -----------------------------------------------------------
    ' WHEN A SERVICE IS SELECTED: LOAD DESCRIPTION AND PRICE
    ' -----------------------------------------------------------
    Private Sub cmbServiceName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbServiceName.SelectedIndexChanged
        If cmbServiceName.SelectedIndex = -1 OrElse cmbServiceName.SelectedValue Is Nothing Then
            txtServiceDescription.Clear()
            txtPrice.Clear()
            Return
        End If

        Dim selectedServiceId As Integer
        If Not Integer.TryParse(cmbServiceName.SelectedValue.ToString(), selectedServiceId) Then Return

        Dim query As String = "SELECT Description, Price FROM groomingservices WHERE ServiceID = @ServiceID"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@ServiceID", selectedServiceId)
                Try
                    connection.Open()
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            txtServiceDescription.Text = reader("Description").ToString()

                            Dim price As Decimal = Convert.ToDecimal(reader("Price"))
                            txtPrice.Text = "RM " & price.ToString("0.00")
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error loading service details: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    ' -----------------------------------------------------------
    ' BOOKING BUTTON CLICK
    ' -----------------------------------------------------------
    Private Sub btnBooking_Click(sender As Object, e As EventArgs) Handles btnBooking.Click
        ' Validation checks
        If cmbPetName.SelectedIndex = -1 Then
            MessageBox.Show("Please select a Pet.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If cmbServiceName.SelectedIndex = -1 Then
            MessageBox.Show("Please select a Service.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim petID As Integer = Convert.ToInt32(cmbPetName.SelectedValue)
        Dim serviceID As Integer = Convert.ToInt32(cmbServiceName.SelectedValue)
        Dim bookingDate As String = dtpDate.Value.ToString("yyyy-MM-dd")
        Dim bookingTime As String = dtpTime.Value.ToString("HH:mm:ss")

        Dim query As String = "INSERT INTO groomingbookings (PetID, ServiceID, BookingDate, BookingTime, Status) VALUES (@PetID, @ServiceID, @BookingDate, @BookingTime, 'Pending')"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@PetID", petID)
                command.Parameters.AddWithValue("@ServiceID", serviceID)
                command.Parameters.AddWithValue("@BookingDate", bookingDate)
                command.Parameters.AddWithValue("@BookingTime", bookingTime)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Grooming Service booked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Catch ex As Exception
                    MessageBox.Show("Error booking service: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    ' -----------------------------------------------------------
    ' CANCEL BUTTON
    ' -----------------------------------------------------------
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class