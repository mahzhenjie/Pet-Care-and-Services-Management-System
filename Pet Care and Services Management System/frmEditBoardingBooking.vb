Imports MySql.Data.MySqlClient

Public Class frmEditBoardingBooking

    ' DATABASE CONNECTION
    Private connectionString As String = "Server=localhost;Database=pet_care_and_services_management_system;Uid=root;Pwd=;"

    Private bookingID As String

    ' FORM LOAD
    Private Sub frmEditBoardingBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPetData()
        LoadRoomData()
        LoadBookingData()
    End Sub

    ' CONSTRUCTOR
    Public Sub New(id As String)
        InitializeComponent()
        bookingID = id
    End Sub

    ' LOAD PET DATA FROM DATABASE
    Private Sub LoadPetData()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim sql As String = "SELECT PetID, PetName FROM Pets ORDER BY PetID"

                Using cmd As New MySqlCommand(sql, conn)
                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim table As New DataTable()
                        adapter.Fill(table)

                        cmbPetID.DataSource = table
                        cmbPetID.DisplayMember = "PetName"
                        cmbPetID.ValueMember = "PetID"
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Unable to load pet data." & Environment.NewLine & Environment.NewLine & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' LOAD BOARDING ROOM DATA FROM DATABASE
    Private Sub LoadRoomData()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim sql As String = "SELECT RoomID, RoomNumber FROM BoardingRooms ORDER BY RoomID"

                Using cmd As New MySqlCommand(sql, conn)
                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim table As New DataTable()
                        adapter.Fill(table)

                        cmbRoomID.DataSource = table
                        cmbRoomID.DisplayMember = "RoomNumber"
                        cmbRoomID.ValueMember = "RoomID"
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Unable to load boarding room data." & Environment.NewLine & Environment.NewLine & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' LOAD BOARDING BOOKING DATA FROM DATABASE
    Private Sub LoadBookingData()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim sql As String = "SELECT BoardingBookingID, PetID, RoomID, StartDate, EndDate, Status FROM BoardingBookings WHERE BoardingBookingID = @BoardingBookingID"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@BoardingBookingID", bookingID)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtBookingID.Text = reader("BoardingBookingID").ToString()

                            cmbPetID.SelectedValue = reader("PetID")
                            cmbRoomID.SelectedValue = reader("RoomID")

                            If Not IsDBNull(reader("StartDate")) Then
                                dtpStartDate.Value = Convert.ToDateTime(reader("StartDate"))
                            End If

                            If Not IsDBNull(reader("EndDate")) Then
                                dtpEndDate.Value = Convert.ToDateTime(reader("EndDate"))
                            End If

                            txtStatus.Text = reader("Status").ToString()
                        Else
                            MessageBox.Show("Boarding booking was not found.", "Edit Boarding Booking", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Me.Close()
                        End If
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Unable to load boarding booking data." & Environment.NewLine & Environment.NewLine & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' SAVE CHANGES
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cmbPetID.SelectedIndex = -1 Then
            MessageBox.Show("Please select a pet.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbPetID.Focus()
            Return
        End If

        If cmbRoomID.SelectedIndex = -1 Then
            MessageBox.Show("Please select a boarding room.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbRoomID.Focus()
            Return
        End If

        If dtpEndDate.Value.Date < dtpStartDate.Value.Date Then
            MessageBox.Show("End Date cannot be earlier than Start Date.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dtpEndDate.Focus()
            Return
        End If

        If txtStatus.Text.Trim() = "" Then
            MessageBox.Show("Please enter Status.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtStatus.Focus()
            Return
        End If

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim sql As String = "UPDATE BoardingBookings SET PetID = @PetID, RoomID = @RoomID, StartDate = @StartDate, EndDate = @EndDate, Status = @Status WHERE BoardingBookingID = @BoardingBookingID"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@PetID", cmbPetID.SelectedValue)
                    cmd.Parameters.AddWithValue("@RoomID", cmbRoomID.SelectedValue)
                    cmd.Parameters.AddWithValue("@StartDate", dtpStartDate.Value.Date)
                    cmd.Parameters.AddWithValue("@EndDate", dtpEndDate.Value.Date)
                    cmd.Parameters.AddWithValue("@Status", txtStatus.Text.Trim())
                    cmd.Parameters.AddWithValue("@BoardingBookingID", bookingID)

                    Dim result As Integer = cmd.ExecuteNonQuery()

                    If result > 0 Then
                        MessageBox.Show("Boarding booking updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.DialogResult = DialogResult.OK
                        Me.Close()
                    Else
                        MessageBox.Show("Boarding booking was not found.", "Update Boarding Booking", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Unable to update boarding booking." & Environment.NewLine & Environment.NewLine & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' CANCEL
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class