<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVideoView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pnlMain = New Panel()
        pnlVideo = New Panel()
        videoView1 = New LibVLCSharp.WinForms.VideoView()
        pnlControls = New Panel()
        pnlButtons = New Panel()
        btnClose = New Button()
        btnStop = New Button()
        btnStart = New Button()
        txtCameraURL = New TextBox()
        lblCameraURL = New Label()
        pnlTop = New Panel()
        lblStatus = New Label()
        lblTitle = New Label()
        pnlMain.SuspendLayout()
        pnlVideo.SuspendLayout()
        CType(videoView1, ComponentModel.ISupportInitialize).BeginInit()
        pnlControls.SuspendLayout()
        pnlButtons.SuspendLayout()
        pnlTop.SuspendLayout()
        Me.SuspendLayout()

        '
        ' pnlMain
        '
        pnlMain.BackColor = Color.FromArgb(CByte(245), CByte(230), CByte(209))
        pnlMain.Controls.Add(pnlVideo)
        pnlMain.Controls.Add(pnlControls)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Name = "pnlMain"
        pnlMain.Padding = New Padding(20)
        pnlMain.TabIndex = 0

        '
        ' pnlVideo
        '
        pnlVideo.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        pnlVideo.Controls.Add(videoView1)
        pnlVideo.Dock = DockStyle.Fill
        pnlVideo.Name = "pnlVideo"
        pnlVideo.Padding = New Padding(8)
        pnlVideo.TabIndex = 0

        '
        ' videoView1
        '
        videoView1.BackColor = Color.Black
        videoView1.Dock = DockStyle.Fill
        videoView1.Name = "videoView1"
        videoView1.TabIndex = 0
        videoView1.Text = "VideoView"

        '
        ' pnlControls
        '
        pnlControls.BackColor = Color.FromArgb(CByte(232), CByte(216), CByte(194))
        pnlControls.Controls.Add(pnlButtons)
        pnlControls.Controls.Add(txtCameraURL)
        pnlControls.Controls.Add(lblCameraURL)
        pnlControls.Controls.Add(pnlTop)
        pnlControls.Dock = DockStyle.Bottom
        pnlControls.Name = "pnlControls"
        pnlControls.Padding = New Padding(18, 12, 18, 12)
        pnlControls.Size = New Size(1000, 155)
        pnlControls.TabIndex = 1

        '
        ' pnlTop
        '
        pnlTop.Controls.Add(lblStatus)
        pnlTop.Controls.Add(lblTitle)
        pnlTop.Dock = DockStyle.Top
        pnlTop.Height = 35
        pnlTop.Name = "pnlTop"
        pnlTop.TabIndex = 0

        '
        ' lblTitle
        '
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Georgia", 15.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(CByte(61), CByte(40), CByte(27))
        lblTitle.Location = New Point(0, 3)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(145, 24)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Live CCTV View"

        '
        ' lblStatus
        '
        lblStatus.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblStatus.ForeColor = Color.SaddleBrown
        lblStatus.Location = New Point(820, 8)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(140, 15)
        lblStatus.TabIndex = 1
        lblStatus.Text = "●  Status: Stopped"
        lblStatus.TextAlign = ContentAlignment.MiddleRight

        '
        ' lblCameraURL
        '
        lblCameraURL.AutoSize = True
        lblCameraURL.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblCameraURL.ForeColor = Color.SaddleBrown
        lblCameraURL.Location = New Point(0, 50)
        lblCameraURL.Name = "lblCameraURL"
        lblCameraURL.Size = New Size(82, 17)
        lblCameraURL.TabIndex = 2
        lblCameraURL.Text = "Camera URL"

        '
        ' txtCameraURL
        '
        txtCameraURL.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtCameraURL.Font = New Font("Segoe UI", 9.5F)
        txtCameraURL.Location = New Point(92, 47)
        txtCameraURL.Name = "txtCameraURL"
        txtCameraURL.Size = New Size(850, 24)
        txtCameraURL.TabIndex = 3

        '
        ' pnlButtons
        '
        pnlButtons.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlButtons.Controls.Add(btnClose)
        pnlButtons.Controls.Add(btnStop)
        pnlButtons.Controls.Add(btnStart)
        pnlButtons.Location = New Point(0, 82)
        pnlButtons.Name = "pnlButtons"
        pnlButtons.Size = New Size(960, 40)
        pnlButtons.TabIndex = 4

        '
        ' btnStart
        '
        btnStart.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnStart.BackColor = Color.Sienna
        btnStart.FlatAppearance.BorderSize = 0
        btnStart.FlatStyle = FlatStyle.Flat
        btnStart.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnStart.ForeColor = Color.WhiteSmoke
        btnStart.Location = New Point(645, 0)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(105, 35)
        btnStart.TabIndex = 0
        btnStart.Text = "Start Live"
        btnStart.UseVisualStyleBackColor = False

        '
        ' btnStop
        '
        btnStop.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnStop.BackColor = Color.FromArgb(CByte(96), CByte(52), CByte(16))
        btnStop.FlatAppearance.BorderSize = 0
        btnStop.FlatStyle = FlatStyle.Flat
        btnStop.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnStop.ForeColor = Color.WhiteSmoke
        btnStop.Location = New Point(760, 0)
        btnStop.Name = "btnStop"
        btnStop.Size = New Size(90, 35)
        btnStop.TabIndex = 1
        btnStop.Text = "Stop"
        btnStop.UseVisualStyleBackColor = False

        '
        ' btnClose
        '
        btnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClose.BackColor = Color.SaddleBrown
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnClose.ForeColor = Color.WhiteSmoke
        btnClose.Location = New Point(860, 0)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(100, 35)
        btnClose.TabIndex = 2
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = False

        '
        ' frmVideoView
        '
        AutoScaleDimensions = New SizeF(8.0!, 20.0!)
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(245), CByte(230), CByte(209))
        ClientSize = New Size(1000, 700)
        Controls.Add(pnlMain)
        MinimumSize = New Size(900, 600)
        Name = "frmVideoView"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Live CCTV View"

        CType(videoView1, ComponentModel.ISupportInitialize).EndInit()
        pnlButtons.ResumeLayout(False)
        pnlTop.ResumeLayout(False)
        pnlTop.PerformLayout()
        pnlControls.ResumeLayout(False)
        pnlControls.PerformLayout()
        pnlVideo.ResumeLayout(False)
        pnlMain.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlVideo As Panel
    Friend WithEvents videoView1 As LibVLCSharp.WinForms.VideoView
    Friend WithEvents pnlControls As Panel
    Friend WithEvents pnlTop As Panel
    Friend WithEvents pnlButtons As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblCameraURL As Label
    Friend WithEvents txtCameraURL As TextBox
    Friend WithEvents btnStart As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents btnClose As Button

End Class