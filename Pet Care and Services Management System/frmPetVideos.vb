Imports MySql.Data.MySqlClient

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

                Dim query As String = "SELECT v.VideoID, v.BoardingBookingID, p.PetName, v.VideoURL, v.UploadDate, v.Description " &
                                      "FROM PetVideos v " &
                                      "INNER JOIN BoardingBookings b ON v.BoardingBookingID = b.BoardingBookingID " &
                                      "INNER JOIN Pets p ON b.PetID = p.PetID " &
                                      "ORDER BY v.VideoID"

                Using cmd As New MySqlCommand(query, conn)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()

                        Dim cardNumber As Integer = 1

                        While reader.Read() AndAlso cardNumber <= 6

                            LoadVideoCard(cardNumber, reader)

                            cardNumber += 1

                        End While

                    End Using

                End Using

            End Using

        Catch ex As MySqlException

            MessageBox.Show(
                "Failed to load pet videos." &
                Environment.NewLine &
                ex.Message,
                "Database Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        Catch ex As Exception

            MessageBox.Show(
                "Failed to load pet videos." &
                Environment.NewLine &
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    ' LOAD VIDEO CARD
    Private Sub LoadVideoCard(cardNumber As Integer, reader As MySqlDataReader)

        Dim videoID As Integer = Convert.ToInt32(reader("VideoID"))
        Dim petName As String = reader("PetName").ToString()
        Dim videoURL As String = reader("VideoURL").ToString()
        Dim description As String = reader("Description").ToString()
        Dim uploadDate As String = Convert.ToDateTime(reader("UploadDate")).ToString("dd/MM/yyyy")

        Select Case cardNumber

            Case 1

                pnlVideo1.Visible = True
                pnlVideo1.Tag = videoID
                lblPetName1.Text = petName
                lblVideoName1.Text = "Live Pet Video"
                lblVideoDate1.Text = "Uploaded: " & uploadDate
                btnView1.Tag = videoURL
                btnDelete1.Tag = videoID

            Case 2

                pnlVideo2.Visible = True
                pnlVideo2.Tag = videoID
                lblPetName2.Text = petName
                lblVideoName2.Text = "Live Pet Video"
                lblVideoDate2.Text = "Uploaded: " & uploadDate
                btnView2.Tag = videoURL
                btnDelete2.Tag = videoID

            Case 3

                pnlVideo3.Visible = True
                pnlVideo3.Tag = videoID
                lblPetName3.Text = petName
                lblVideoName3.Text = "Live Pet Video"
                lblVideoDate3.Text = "Uploaded: " & uploadDate
                btnView3.Tag = videoURL
                btnDelete3.Tag = videoID

            Case 4

                pnlVideo4.Visible = True
                pnlVideo4.Tag = videoID
                lblPetName4.Text = petName
                lblVideoName4.Text = "Live Pet Video"
                lblVideoDate4.Text = "Uploaded: " & uploadDate
                btnView4.Tag = videoURL
                btnDelete4.Tag = videoID

            Case 5

                pnlVideo5.Visible = True
                pnlVideo5.Tag = videoID
                lblPetName5.Text = petName
                lblVideoName5.Text = "Live Pet Video"
                lblVideoDate5.Text = "Uploaded: " & uploadDate
                btnView5.Tag = videoURL
                btnDelete5.Tag = videoID

            Case 6

                pnlVideo6.Visible = True
                pnlVideo6.Tag = videoID
                lblPetName6.Text = petName
                lblVideoName6.Text = "Live Pet Video"
                lblVideoDate6.Text = "Uploaded: " & uploadDate
                btnView6.Tag = videoURL
                btnDelete6.Tag = videoID

        End Select

    End Sub

    ' CLEAR VIDEO CARDS
    Private Sub ClearVideoCards()

        pnlVideo1.Visible = False
        pnlVideo2.Visible = False
        pnlVideo3.Visible = False
        pnlVideo4.Visible = False
        pnlVideo5.Visible = False
        pnlVideo6.Visible = False

        pnlVideo1.Tag = Nothing
        pnlVideo2.Tag = Nothing
        pnlVideo3.Tag = Nothing
        pnlVideo4.Tag = Nothing
        pnlVideo5.Tag = Nothing
        pnlVideo6.Tag = Nothing

        btnView1.Tag = Nothing
        btnView2.Tag = Nothing
        btnView3.Tag = Nothing
        btnView4.Tag = Nothing
        btnView5.Tag = Nothing
        btnView6.Tag = Nothing

        btnDelete1.Tag = Nothing
        btnDelete2.Tag = Nothing
        btnDelete3.Tag = Nothing
        btnDelete4.Tag = Nothing
        btnDelete5.Tag = Nothing
        btnDelete6.Tag = Nothing

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

                Dim query As String = "SELECT v.VideoID, v.BoardingBookingID, p.PetName, v.VideoURL, v.UploadDate, v.Description " &
                                      "FROM PetVideos v " &
                                      "INNER JOIN BoardingBookings b ON v.BoardingBookingID = b.BoardingBookingID " &
                                      "INNER JOIN Pets p ON b.PetID = p.PetID " &
                                      "WHERE p.PetName LIKE @Search OR v.Description LIKE @Search " &
                                      "ORDER BY v.VideoID"

                Using cmd As New MySqlCommand(query, conn)

                    cmd.Parameters.AddWithValue("@Search", "%" & txtSearch.Text.Trim() & "%")

                    Using reader As MySqlDataReader = cmd.ExecuteReader()

                        Dim cardNumber As Integer = 1

                        While reader.Read() AndAlso cardNumber <= 6

                            LoadVideoCard(cardNumber, reader)

                            cardNumber += 1

                        End While

                    End Using

                End Using

            End Using

        Catch ex As MySqlException

            MessageBox.Show(
                "Failed to search pet videos." &
                Environment.NewLine &
                ex.Message,
                "Database Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        Catch ex As Exception

            MessageBox.Show(
                "Failed to search pet videos." &
                Environment.NewLine &
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    ' REFRESH
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

        txtSearch.Text = ""

        LoadPetVideos()

    End Sub

    ' VIEW VIDEO 1
    Private Sub btnView1_Click(sender As Object, e As EventArgs) Handles btnView1.Click
        OpenVideoView(btnView1)
    End Sub

    ' VIEW VIDEO 2
    Private Sub btnView2_Click(sender As Object, e As EventArgs) Handles btnView2.Click
        OpenVideoView(btnView2)
    End Sub

    ' VIEW VIDEO 3
    Private Sub btnView3_Click(sender As Object, e As EventArgs) Handles btnView3.Click
        OpenVideoView(btnView3)
    End Sub

    ' VIEW VIDEO 4
    Private Sub btnView4_Click(sender As Object, e As EventArgs) Handles btnView4.Click
        OpenVideoView(btnView4)
    End Sub

    ' VIEW VIDEO 5
    Private Sub btnView5_Click(sender As Object, e As EventArgs) Handles btnView5.Click
        OpenVideoView(btnView5)
    End Sub

    ' VIEW VIDEO 6
    Private Sub btnView6_Click(sender As Object, e As EventArgs) Handles btnView6.Click
        OpenVideoView(btnView6)
    End Sub

    ' OPEN VIDEO VIEW
    Private Sub OpenVideoView(viewButton As Button)

        Try

            If viewButton.Tag Is Nothing Then

                MessageBox.Show(
                    "Video URL is not available.",
                    "Video",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

                Return

            End If

            Dim videoURL As String = viewButton.Tag.ToString()

            If videoURL.Trim() = "" Then

                MessageBox.Show(
                    "Video URL is not available.",
                    "Video",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

                Return

            End If

            Using videoForm As New frmVideoView(videoURL)

                videoForm.ShowDialog()

            End Using

        Catch ex As Exception

            MessageBox.Show(
                "Failed to open video." &
                Environment.NewLine &
                ex.Message,
                "Video Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    ' DELETE VIDEO 1
    Private Sub btnDelete1_Click(sender As Object, e As EventArgs) Handles btnDelete1.Click
        DeleteVideo(btnDelete1)
    End Sub

    ' DELETE VIDEO 2
    Private Sub btnDelete2_Click(sender As Object, e As EventArgs) Handles btnDelete2.Click
        DeleteVideo(btnDelete2)
    End Sub

    ' DELETE VIDEO 3
    Private Sub btnDelete3_Click(sender As Object, e As EventArgs) Handles btnDelete3.Click
        DeleteVideo(btnDelete3)
    End Sub

    ' DELETE VIDEO 4
    Private Sub btnDelete4_Click(sender As Object, e As EventArgs) Handles btnDelete4.Click
        DeleteVideo(btnDelete4)
    End Sub

    ' DELETE VIDEO 5
    Private Sub btnDelete5_Click(sender As Object, e As EventArgs) Handles btnDelete5.Click
        DeleteVideo(btnDelete5)
    End Sub

    ' DELETE VIDEO 6
    Private Sub btnDelete6_Click(sender As Object, e As EventArgs) Handles btnDelete6.Click
        DeleteVideo(btnDelete6)
    End Sub

    ' DELETE VIDEO FROM DATABASE
    Private Sub DeleteVideo(deleteButton As Button)

        Try

            If deleteButton.Tag Is Nothing Then
                Return
            End If

            Dim videoID As Integer = Convert.ToInt32(deleteButton.Tag)

            Dim result As DialogResult =
                MessageBox.Show(
                    "Are you sure you want to delete this video?",
                    "Delete Video",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                )

            If result <> DialogResult.Yes Then
                Return
            End If

            Using conn As New MySqlConnection(connectionString)

                conn.Open()

                Dim query As String =
                    "DELETE FROM PetVideos WHERE VideoID = @VideoID"

                Using cmd As New MySqlCommand(query, conn)

                    cmd.Parameters.AddWithValue("@VideoID", videoID)

                    cmd.ExecuteNonQuery()

                End Using

            End Using

            MessageBox.Show(
                "Video deleted successfully.",
                "Delete Video",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            LoadPetVideos()

        Catch ex As MySqlException

            MessageBox.Show(
                "Failed to delete video." &
                Environment.NewLine &
                ex.Message,
                "Database Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        Catch ex As Exception

            MessageBox.Show(
                "Failed to delete video." &
                Environment.NewLine &
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    ' ==========================================
    ' ADD VIDEO
    ' ==========================================
    Private Sub btnAddVideo_Click(sender As Object, e As EventArgs) Handles btnAddVideo.Click

        Try

            Using addVideoForm As New frmAddPetVideo()

                addVideoForm.ShowDialog()

            End Using

            ' Refresh video list after Add Video form is closed
            LoadPetVideos()

        Catch ex As Exception

            MessageBox.Show(
                "Failed to open Add Pet Video form." &
                Environment.NewLine &
                ex.Message,
                "Add Video Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    ' ==========================================
    ' GO BACK TO DASHBOARD
    ' ==========================================
    Private Sub btnGoBackDashboard_Click(sender As Object, e As EventArgs) Handles btnGoBackDashboard.Click

        Try

            frmEmployeeDashboard.Show()

            Me.Close()

        Catch ex As Exception

            MessageBox.Show(
                "Failed to return to Dashboard." &
                Environment.NewLine &
                ex.Message,
                "Dashboard Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

End Class