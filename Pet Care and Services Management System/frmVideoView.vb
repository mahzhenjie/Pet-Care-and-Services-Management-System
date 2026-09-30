Imports LibVLCSharp.Shared

Public Class frmVideoView

    ' LIBVLC
    Private LibVLC As LibVLC

    ' MEDIA PLAYER
    Private MediaPlayer As MediaPlayer

    ' CAMERA URL
    Private cameraURL As String = ""

    ' FORM CONSTRUCTOR
    Public Sub New()
        InitializeComponent()
    End Sub

    ' FORM CONSTRUCTOR WITH CAMERA URL
    Public Sub New(cameraURL As String)
        InitializeComponent()
        Me.cameraURL = cameraURL
    End Sub

    ' FORM LOAD
    Private Sub frmVideoView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeVideoPlayer()

        If cameraURL <> "" Then
            txtCameraURL.Text = cameraURL
        End If
    End Sub

    ' INITIALIZE VIDEO PLAYER
    Private Sub InitializeVideoPlayer()
        Try
            Core.Initialize()

            LibVLC = New LibVLC()
            MediaPlayer = New MediaPlayer(LibVLC)

            videoView1.MediaPlayer = MediaPlayer

            lblStatus.Text = "●  Status: Ready"

        Catch ex As Exception
            MessageBox.Show("Failed to initialize video player." & Environment.NewLine & ex.Message, "Video Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lblStatus.Text = "●  Status: Error"
        End Try
    End Sub

    ' START LIVE VIDEO
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        StartLiveVideo()
    End Sub

    ' START LIVE VIDEO
    Private Sub StartLiveVideo()
        Try
            If txtCameraURL.Text.Trim() = "" Then
                MessageBox.Show("Please enter the camera URL.", "Camera URL", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtCameraURL.Focus()
                Return
            End If

            If LibVLC Is Nothing OrElse MediaPlayer Is Nothing Then
                InitializeVideoPlayer()
            End If

            If LibVLC Is Nothing OrElse MediaPlayer Is Nothing Then
                Return
            End If

            If MediaPlayer.IsPlaying Then
                MediaPlayer.Stop()
            End If

            Dim media As New Media(LibVLC, txtCameraURL.Text.Trim(), FromType.FromLocation)

            MediaPlayer.Play(media)

            lblStatus.Text = "●  Status: Live"

        Catch ex As Exception
            MessageBox.Show("Failed to start live video." & Environment.NewLine & ex.Message, "Video Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lblStatus.Text = "●  Status: Error"
        End Try
    End Sub

    ' STOP LIVE VIDEO
    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        StopLiveVideo()
    End Sub

    ' STOP LIVE VIDEO
    Private Sub StopLiveVideo()
        Try
            If MediaPlayer IsNot Nothing AndAlso MediaPlayer.IsPlaying Then
                MediaPlayer.Stop()
            End If

            lblStatus.Text = "●  Status: Stopped"

        Catch ex As Exception
            MessageBox.Show("Failed to stop video." & Environment.NewLine & ex.Message, "Video Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' CLOSE VIDEO VIEW
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        StopLiveVideo()
        Me.Close()
    End Sub

    ' FORM CLOSING
    Private Sub frmVideoView_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            If MediaPlayer IsNot Nothing Then
                If MediaPlayer.IsPlaying Then
                    MediaPlayer.Stop()
                End If

                MediaPlayer.Dispose()
                MediaPlayer = Nothing
            End If

            If LibVLC IsNot Nothing Then
                LibVLC.Dispose()
                LibVLC = Nothing
            End If

        Catch
        End Try
    End Sub

End Class