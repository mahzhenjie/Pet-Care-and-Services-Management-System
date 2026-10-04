Imports MySql.Data.MySqlClient
Imports System.Data

Public Class FrmBookingBoardingService

    Private connectionString As String = "Server=127.0.0.1;Database=pet_care_and_services_management_system;Uid=root;Pwd=;"
    Private passedRoomId As Integer = 0

    ' -----------------------------------------------------------
    ' CONSTRUCTOR
    ' -----------------------------------------------------------
    ' Allow passing a RoomID if the user clicks "Book" directly from a specific room card
    Public Sub New(Optional roomId As Integer = 0)
        InitializeComponent()
        passedRoomId = roomId
    End Sub

    ' -----------------------------------------------------------
    ' FORM LOAD
    ' -----------------------------------------------------------
    Private Sub FrmBookingBoardingService_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If GlobalVariables.LoggedInCustomerID <= 0 Then
            MessageBox.Show("Error: You must be logged in to make a booking.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If

        ' Set default date rules (Cannot book in the past)
        dtpStartDate.MinDate = DateTime.Today
        dtpEndDate.MinDate = DateTime.Today

        ' Set End Date to default to tomorrow
        If dtpEndDate.Value <= dtpStartDate.Value Then
            dtpEndDate.Value = dtpStartDate.Value.AddDays(1)
        End If

        LoadCustomerPets()
        LoadAvailableRooms()
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
                    cmbPetName.SelectedIndex = -1
                Catch ex As Exception
                    MessageBox.Show("Error loading pets: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    ' -----------------------------------------------------------
    ' LOAD ONLY AVAILABLE ROOMS FOR SELECTED DATES
    ' -----------------------------------------------------------
    Private Sub LoadAvailableRooms()
        ' Clear previous selections and textboxes
        cmbRoom.DataSource = Nothing
        cmbRoom.Items.Clear()
        txtRoomType.Clear()
        txtRoomDescription.Clear()
        txtPricePerDay.Clear()
        txtTotal.Clear()

        ' SQL Logic: Select rooms that are NOT booked overlapping the selected dates
        ' Overlap happens if: (ExistingStart <= NewEnd) AND (ExistingEnd >= NewStart)
        Dim query As String = "
            SELECT RoomID, CONCAT(RoomNumber, ' - ', RoomType) AS DisplayName 
            FROM boardingrooms 
            WHERE RoomID NOT IN (
                SELECT RoomID FROM boardingbookings 
                WHERE Status IN ('Confirmed', 'Pending') 
                AND StartDate <= @EndDate 
                AND EndDate >= @StartDate
            )"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@StartDate", dtpStartDate.Value.Date.ToString("yyyy-MM-dd"))
                command.Parameters.AddWithValue("@EndDate", dtpEndDate.Value.Date.ToString("yyyy-MM-dd"))

                Try
                    connection.Open()
                    Dim adapter As New MySqlDataAdapter(command)
                    Dim dtRooms As New DataTable()
                    adapter.Fill(dtRooms)

                    cmbRoom.DataSource = dtRooms
                    cmbRoom.DisplayMember = "DisplayName"
                    cmbRoom.ValueMember = "RoomID"
                    cmbRoom.SelectedIndex = -1

                    ' If the user came from a specific room card, try to pre-select it
                    If passedRoomId > 0 Then
                        cmbRoom.SelectedValue = passedRoomId
                        passedRoomId = 0 ' reset after first load
                    End If

                Catch ex As Exception
                    MessageBox.Show("Error loading available rooms: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    ' -----------------------------------------------------------
    ' TRIGGER ROOM RELOAD WHEN DATES CHANGE
    ' -----------------------------------------------------------
    Private Sub dtpStartDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpStartDate.ValueChanged
        ' Ensure End Date is never before Start Date
        If dtpEndDate.Value < dtpStartDate.Value Then
            dtpEndDate.Value = dtpStartDate.Value.AddDays(1)
        End If
        LoadAvailableRooms()
    End Sub

    Private Sub dtpEndDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpEndDate.ValueChanged
        ' Ensure Start Date is never after End Date
        If dtpStartDate.Value > dtpEndDate.Value Then
            dtpStartDate.Value = dtpEndDate.Value.AddDays(-1)
        End If
        LoadAvailableRooms()
    End Sub

    ' -----------------------------------------------------------
    ' WHEN A ROOM IS SELECTED: LOAD DETAILS & CALCULATE TOTAL
    ' -----------------------------------------------------------
    Private Sub cmbRoom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRoom.SelectedIndexChanged
        If cmbRoom.SelectedIndex = -1 OrElse cmbRoom.SelectedValue Is Nothing Then Return

        Dim selectedRoomId As Integer
        If Not Integer.TryParse(cmbRoom.SelectedValue.ToString(), selectedRoomId) Then Return

        Dim query As String = "SELECT RoomType, Description, PricePerDay FROM boardingrooms WHERE RoomID = @RoomID"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@RoomID", selectedRoomId)
                Try
                    connection.Open()
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            txtRoomType.Text = reader("RoomType").ToString()
                            txtRoomDescription.Text = reader("Description").ToString()

                            Dim pricePerDay As Decimal = Convert.ToDecimal(reader("PricePerDay"))
                            txtPricePerDay.Text = pricePerDay.ToString("0.00")

                            ' Calculate Days (Minimum 1 day charge even for same-day checkout)
                            Dim days As Integer = (dtpEndDate.Value.Date - dtpStartDate.Value.Date).Days
                            If days <= 0 Then days = 1

                            Dim total As Decimal = days * pricePerDay
                            txtTotal.Text = total.ToString("0.00")
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error loading room details: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    ' -----------------------------------------------------------
    ' BOOK BOARDING BUTTON
    ' -----------------------------------------------------------
    Private Sub btnBookBoarding_Click(sender As Object, e As EventArgs) Handles btnBookBoarding.Click
        ' Validation
        If cmbPetName.SelectedIndex = -1 Then
            MessageBox.Show("Please select a Pet.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If cmbRoom.SelectedIndex = -1 Then
            MessageBox.Show("Please select an available Room.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim petID As Integer = Convert.ToInt32(cmbPetName.SelectedValue)
        Dim roomID As Integer = Convert.ToInt32(cmbRoom.SelectedValue)
        Dim startDateStr As String = dtpStartDate.Value.ToString("yyyy-MM-dd")
        Dim endDateStr As String = dtpEndDate.Value.ToString("yyyy-MM-dd")

        Dim query As String = "INSERT INTO boardingbookings (PetID, RoomID, StartDate, EndDate, Status) VALUES (@PetID, @RoomID, @StartDate, @EndDate, 'Pending')"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@PetID", petID)
                command.Parameters.AddWithValue("@RoomID", roomID)
                command.Parameters.AddWithValue("@StartDate", startDateStr)
                command.Parameters.AddWithValue("@EndDate", endDateStr)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Boarding Service booked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Catch ex As Exception
                    MessageBox.Show("Error booking room: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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