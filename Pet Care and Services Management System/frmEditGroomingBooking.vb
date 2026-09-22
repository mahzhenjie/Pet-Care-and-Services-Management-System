Imports MySql.Data.MySqlClient

Public Class frmEditGroomingBooking

    ' DATABASE CONNECTION
    Private connectionString As String = "Server=localhost;Database=pet_care_and_services_management_system;Uid=root;Pwd=;"

    Private bookingID As String

    ' FORM LOAD
    Private Sub frmEditGroomingBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGroomingBookingData()
    End Sub

    ' CONSTRUCTOR
    Public Sub New(ByVal id As String)
        InitializeComponent()
        bookingID = id
    End Sub

    ' LOAD GROOMING BOOKING DATA
    Private Sub LoadGroomingBookingData()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim sql As String =
                    "SELECT GroomingBookingID, PetID, ServiceID, BookingDate, BookingTime, Status " &
                    "FROM GroomingBookings " &
                    "WHERE GroomingBookingID = @GroomingBookingID"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@GroomingBookingID", bookingID)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtGroomingBookingID.Text = reader("GroomingBookingID").ToString()
                            txtPetID.Text = reader("PetID").ToString()
                            txtServiceID.Text = reader("ServiceID").ToString()

                            If Not IsDBNull(reader("BookingDate")) Then
                                dtpBookingDate.Value = Convert.ToDateTime(reader("BookingDate"))
                            End If

                            If Not IsDBNull(reader("BookingTime")) Then
                                dtpBookingTime.Value = DateTime.Today.Add(
                                    Convert.ToDateTime(reader("BookingTime")).TimeOfDay
                                )
                            End If

                            If Not IsDBNull(reader("Status")) Then
                                cboStatus.Text = reader("Status").ToString()
                            End If
                        Else
                            MessageBox.Show(
                                "Grooming booking was not found.",
                                "Edit Grooming Booking",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            )

                            Me.Close()
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(
                "Unable to load grooming booking data." &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "Database Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        End Try
    End Sub

    ' UPDATE GROOMING BOOKING
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtPetID.Text.Trim() = "" Then
            MessageBox.Show(
                "Please enter Pet ID.",
                "Validation Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            txtPetID.Focus()
            Exit Sub
        End If

        If txtServiceID.Text.Trim() = "" Then
            MessageBox.Show(
                "Please enter Service ID.",
                "Validation Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            txtServiceID.Focus()
            Exit Sub
        End If

        If cboStatus.SelectedIndex = -1 Then
            MessageBox.Show(
                "Please select Status.",
                "Validation Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            cboStatus.Focus()
            Exit Sub
        End If

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim sql As String =
                    "UPDATE GroomingBookings SET " &
                    "PetID = @PetID, " &
                    "ServiceID = @ServiceID, " &
                    "BookingDate = @BookingDate, " &
                    "BookingTime = @BookingTime, " &
                    "Status = @Status " &
                    "WHERE GroomingBookingID = @GroomingBookingID"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@PetID", txtPetID.Text.Trim())
                    cmd.Parameters.AddWithValue("@ServiceID", txtServiceID.Text.Trim())
                    cmd.Parameters.AddWithValue("@BookingDate", dtpBookingDate.Value.Date)
                    cmd.Parameters.AddWithValue("@BookingTime", dtpBookingTime.Value.ToString("HH:mm:ss"))
                    cmd.Parameters.AddWithValue("@Status", cboStatus.Text)
                    cmd.Parameters.AddWithValue("@GroomingBookingID", bookingID)

                    Dim result As Integer = cmd.ExecuteNonQuery()

                    If result > 0 Then
                        MessageBox.Show(
                            "Grooming booking updated successfully.",
                            "Edit Grooming Booking",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        )

                        Me.DialogResult = DialogResult.OK
                        Me.Close()

                    Else
                        MessageBox.Show(
                            "Grooming booking was not updated.",
                            "Edit Grooming Booking",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        )
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(
                "Unable to update grooming booking." &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "Database Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        End Try
    End Sub

    ' CANCEL
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class