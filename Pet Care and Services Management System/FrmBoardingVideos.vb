Imports MySql.Data.MySqlClient
Imports System.Data
Imports LibVLCSharp.Shared
Imports LibVLCSharp.WinForms

Public Class FrmBoardingVideos

    Private connectionString As String = "Server=127.0.0.1;Database=pet_care_and_services_management_system;Uid=root;Pwd=;"

    ' LibVLC Core Components
    Private _libVLC As LibVLC
    Private _mediaPlayer As MediaPlayer

    ' -----------------------------------------------------------
    ' FORM LOAD & INITIALIZATION
    ' -----------------------------------------------------------
    Private Sub FrmBoardingVideos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If GlobalVariables.LoggedInCustomerID <= 0 Then
            MessageBox.Show("Error: You must be logged in to view your pets' videos.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If

        ' 1. Initialize VLC Engine
        Core.Initialize()
        _libVLC = New LibVLC()
        _mediaPlayer = New MediaPlayer(_libVLC)

        ' 2. Bind the MediaPlayer to the VideoView control on your form
        VideoView1.MediaPlayer = _mediaPlayer

        ' 3. Load the Customer's Pets into the Dropdown
        LoadCustomerPets()
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
    ' WHEN A PET IS SELECTED: FETCH THE CCTV URL
    ' -----------------------------------------------------------
    Private Sub cmbPetName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPetName.SelectedIndexChanged
        If cmbPetName.SelectedIndex = -1 OrElse cmbPetName.SelectedValue Is Nothing Then
            txtCameraURL.Clear()
            Return
        End If

        Dim selectedPetId As Integer

        If Not Integer.TryParse(cmbPetName.SelectedValue.ToString(), selectedPetId) Then
            Return
        End If

        ' Retrieve the latest VideoURL for the selected pet by joining videos, bookings and rooms
        Dim query As String = "
            SELECT v.VideoURL
            FROM petvideos v
            INNER JOIN boardingbookings bb ON v.RoomID = bb.RoomID
            WHERE bb.PetID = @PetID
            ORDER BY v.UploadDate DESC
            LIMIT 1"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@PetID", selectedPetId)

                Try
                    connection.Open()

                    Dim url As Object = command.ExecuteScalar()

                    If url IsNot Nothing AndAlso Not DBNull.Value.Equals(url) Then
                        txtCameraURL.Text = url.ToString()
                    Else
                        txtCameraURL.Text = ""
                        MessageBox.Show("No active camera stream found for this pet.", "No Video", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                Catch ex As Exception
                    MessageBox.Show("Error retrieving camera URL: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    ' -----------------------------------------------------------
    ' START LIVE BUTTON
    ' -----------------------------------------------------------
    Private Sub btnStartLive_Click(sender As Object, e As EventArgs) Handles btnStartLive.Click
        Dim streamUrl As String = txtCameraURL.Text.Trim()

        If String.IsNullOrWhiteSpace(streamUrl) Then
            MessageBox.Show("Please select a pet with an active camera or enter a valid Camera URL.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' Create new media from the network IP Camera URL
            ' FromType.FromLocation tells VLC this is a network stream/URL
            Dim media As New Media(_libVLC, streamUrl, FromType.FromLocation)

            ' Add options for IP cameras to reduce delay
            media.AddOption(":network-caching=300")
            media.AddOption(":clock-jitter=0")
            media.AddOption(":clock-synchro=0")

            _mediaPlayer.Play(media)

        Catch ex As Exception
            MessageBox.Show("Error starting stream: " & ex.Message, "Stream Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' -----------------------------------------------------------
    ' FORM CLOSING (CLEANUP MEMORY LEAKS)
    ' -----------------------------------------------------------
    Private Sub FrmBoardingVideos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' IMPORTANT: You must dispose of VLC resources when closing the form,
        ' otherwise the video thread remains open in the background and crashes the app.
        If _mediaPlayer IsNot Nothing Then
            If _mediaPlayer.IsPlaying Then _mediaPlayer.Stop()
            _mediaPlayer.Dispose()
        End If

        If _libVLC IsNot Nothing Then
            _libVLC.Dispose()
        End If
    End Sub

    ' -----------------------------------------------------------
    ' DASHBOARD BUTTON
    ' -----------------------------------------------------------
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Me.Close()
    End Sub

End Class