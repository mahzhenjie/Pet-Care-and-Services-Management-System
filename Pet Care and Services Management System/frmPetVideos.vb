Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmPetVideos

    ' DATABASE CONNECTION
    Private connectionString As String = "Server=localhost;Database=pet_care_and_services_management_system;Uid=root;Pwd=;"

    ' FORM LOAD
    Private Sub frmPetVideos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPetVideos()
    End Sub

    ' LOAD PET VIDEOS FROM DATABASE
    Private Sub LoadPetVideos()
        Try
            ClearVideoCards()

            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim query As String = "SELECT v.VideoID, v.RoomID, p.PetName, v.VideoURL, v.VideoImage, v.UploadDate, v.Description " &
                                      "FROM PetVideos v " &
                                      "LEFT JOIN BoardingBookings b ON v.RoomID = b.RoomID " &
                                      "LEFT JOIN Pets p ON b.PetID = p.PetID " &
                                      "ORDER BY v.VideoID"

                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            CreateVideoCard(reader)
                        End While
                    End Using
                End Using
            End Using

        Catch ex As MySqlException
            MessageBox.Show("Failed to load pet videos." & Environment.NewLine & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch ex As Exception
            MessageBox.Show("Failed to load pet videos." & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    ' CREATE VIDEO CARD
    Private Sub CreateVideoCard(reader As MySqlDataReader)
        Dim videoID As Integer = Convert.ToInt32(reader("VideoID"))
        Dim petName As String = reader("PetName").ToString()
        Dim videoURL As String = reader("VideoURL").ToString()
        Dim uploadDate As String = Convert.ToDateTime(reader("UploadDate")).ToString("dd/MM/yyyy")

        Dim videoCard As New Panel()
        videoCard.BackColor = Color.White
        videoCard.BorderStyle = BorderStyle.FixedSingle
        videoCard.Margin = New Padding(10)
        videoCard.Size = New Size(330, 390)
        videoCard.Tag = videoID

        Dim picVideo As New PictureBox()
        picVideo.BackColor = Color.FromArgb(232, 216, 194)
        picVideo.BorderStyle = BorderStyle.FixedSingle
        picVideo.Location = New Point(15, 15)
        picVideo.Size = New Size(298, 180)
        picVideo.SizeMode = PictureBoxSizeMode.Zoom
        picVideo.TabStop = False

        ' LOAD VIDEO IMAGE FROM DATABASE
        If Not IsDBNull(reader("VideoImage")) Then
            Dim imageBytes() As Byte = DirectCast(reader("VideoImage"), Byte())

            Using ms As New MemoryStream(imageBytes)
                Using tempImage As Image = Image.FromStream(ms)
                    picVideo.Image = New Bitmap(tempImage)
                End Using
            End Using
        End If

        Dim lblPetName As New Label()
        lblPetName.AutoEllipsis = True
        lblPetName.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblPetName.ForeColor = Color.SaddleBrown
        lblPetName.Location = New Point(15, 210)
        lblPetName.Size = New Size(298, 24)
        lblPetName.Text = petName

        Dim lblVideoName As New Label()
        lblVideoName.AutoEllipsis = True
        lblVideoName.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblVideoName.ForeColor = Color.FromArgb(61, 40, 27)
        lblVideoName.Location = New Point(15, 240)
        lblVideoName.Size = New Size(298, 30)
        lblVideoName.Text = "Live Pet Video"

        Dim lblVideoDate As New Label()
        lblVideoDate.AutoEllipsis = True
        lblVideoDate.Font = New Font("Segoe UI", 9.5F)
        lblVideoDate.ForeColor = Color.DimGray
        lblVideoDate.Location = New Point(15, 275)
        lblVideoDate.Size = New Size(298, 25)
        lblVideoDate.Text = "Uploaded: " & uploadDate

        Dim btnView As New Button()
        btnView.BackColor = Color.Sienna
        btnView.FlatAppearance.BorderSize = 0
        btnView.FlatStyle = FlatStyle.Flat
        btnView.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnView.ForeColor = Color.WhiteSmoke
        btnView.Location = New Point(15, 325)
        btnView.Size = New Size(140, 35)
        btnView.Text = "View Video"
        btnView.UseVisualStyleBackColor = False
        btnView.Tag = videoURL

        AddHandler btnView.Click, AddressOf ViewVideo_Click

        Dim btnDelete As New Button()
        btnDelete.BackColor = Color.FromArgb(96, 52, 16)
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnDelete.ForeColor = Color.WhiteSmoke
        btnDelete.Location = New Point(173, 325)
        btnDelete.Size = New Size(140, 35)
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        btnDelete.Tag = videoID

        AddHandler btnDelete.Click, AddressOf DeleteVideo_Click

        videoCard.Controls.Add(picVideo)
        videoCard.Controls.Add(lblPetName)
        videoCard.Controls.Add(lblVideoName)
        videoCard.Controls.Add(lblVideoDate)
        videoCard.Controls.Add(btnView)
        videoCard.Controls.Add(btnDelete)

        flpVideos.Controls.Add(videoCard)
    End Sub

    ' CLEAR VIDEO CARDS
    Private Sub ClearVideoCards()
        While flpVideos.Controls.Count > 0
            Dim control As Control = flpVideos.Controls(0)
            flpVideos.Controls.RemoveAt(0)
            control.Dispose()
        End While
    End Sub

    ' SEARCH PET VIDEOS
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Trim() = "" OrElse txtSearch.Text = "Search pet video..." Then
            LoadPetVideos()
            Return
        End If

        SearchPetVideos()
    End Sub

    ' SEARCH PET VIDEOS FROM DATABASE
    Private Sub SearchPetVideos()
        Try
            ClearVideoCards()

            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim query As String = "SELECT v.VideoID, v.RoomID, p.PetName, v.VideoURL, v.VideoImage, v.UploadDate, v.Description " &
                                      "FROM PetVideos v " &
                                      "LEFT JOIN BoardingBookings b ON v.RoomID = b.RoomID " &
                                      "LEFT JOIN Pets p ON b.PetID = p.PetID " &
                                      "WHERE p.PetName LIKE @Search OR v.Description LIKE @Search " &
                                      "ORDER BY v.VideoID"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Search", "%" & txtSearch.Text.Trim() & "%")

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            CreateVideoCard(reader)
                        End While
                    End Using
                End Using
            End Using

        Catch ex As MySqlException
            MessageBox.Show("Failed to search pet videos." & Environment.NewLine & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch ex As Exception
            MessageBox.Show("Failed to search pet videos." & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    ' REFRESH
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtSearch.Text = ""
        LoadPetVideos()
    End Sub

    ' VIEW VIDEO
    Private Sub ViewVideo_Click(sender As Object, e As EventArgs)
        Dim viewButton As Button = DirectCast(sender, Button)
        OpenVideoView(viewButton)
    End Sub

    ' OPEN VIDEO VIEW
    Private Sub OpenVideoView(viewButton As Button)
        Try
            If viewButton.Tag Is Nothing Then
                MessageBox.Show("Video URL is not available.", "Video", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim videoURL As String = viewButton.Tag.ToString()

            If videoURL.Trim() = "" Then
                MessageBox.Show("Video URL is not available.", "Video", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Using videoForm As New frmVideoView(videoURL)
                videoForm.ShowDialog()
            End Using

        Catch ex As Exception
            MessageBox.Show("Failed to open video." & Environment.NewLine & ex.Message, "Video Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    ' DELETE VIDEO
    Private Sub DeleteVideo_Click(sender As Object, e As EventArgs)
        Dim deleteButton As Button = DirectCast(sender, Button)
        DeleteVideo(deleteButton)
    End Sub

    ' DELETE VIDEO FROM DATABASE
    Private Sub DeleteVideo(deleteButton As Button)
        Try
            If deleteButton.Tag Is Nothing Then
                Return
            End If

            Dim videoID As Integer = Convert.ToInt32(deleteButton.Tag)

            If MessageBox.Show("Are you sure you want to delete this video?", "Delete Video", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
                Return
            End If

            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim query As String = "DELETE FROM PetVideos WHERE VideoID = @VideoID"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@VideoID", videoID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Video deleted successfully.", "Delete Video", MessageBoxButtons.OK, MessageBoxIcon.Information)

            LoadPetVideos()

        Catch ex As MySqlException
            MessageBox.Show("Failed to delete video." & Environment.NewLine & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch ex As Exception
            MessageBox.Show("Failed to delete video." & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    ' ADD VIDEO
    Private Sub btnAddVideo_Click(sender As Object, e As EventArgs) Handles btnAddVideo.Click
        Try
            Using addVideoForm As New frmAddPetVideo()
                addVideoForm.ShowDialog()
            End Using

            LoadPetVideos()

        Catch ex As Exception
            MessageBox.Show("Failed to open Add Pet Video form." & Environment.NewLine & ex.Message, "Add Video Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    ' GO BACK TO DASHBOARD
    Private Sub btnGoBackDashboard_Click(sender As Object, e As EventArgs) Handles btnGoBackDashboard.Click
        Try
            frmEmployeeDashboard.Show()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Failed to return to Dashboard." & Environment.NewLine & ex.Message, "Dashboard Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

End Class