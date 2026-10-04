<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBoardingVideos
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pnlMain = New Panel()
        pnlContent = New Panel()
        flpVideos = New FlowLayoutPanel()
        Label1 = New Label()
        lblPet = New Label()
        cmbPetName = New ComboBox()
        Panel1 = New Panel()
        VideoView1 = New LibVLCSharp.WinForms.VideoView()
        pnlControls = New Panel()
        btnStartLive = New Button()
        Label2 = New Label()
        txtCameraURL = New TextBox()
        btnDashboard = New Button()
        lblCameraURL = New Label()
        pnlHeader = New Panel()
        lblSubtitle = New Label()
        lblTitle = New Label()

        pnlMain.SuspendLayout()
        pnlContent.SuspendLayout()
        flpVideos.SuspendLayout()
        Panel1.SuspendLayout()
        CType(VideoView1, ComponentModel.ISupportInitialize).BeginInit()
        pnlControls.SuspendLayout()
        pnlHeader.SuspendLayout()
        SuspendLayout()

        '
        ' pnlMain
        '
        pnlMain.BackColor = Color.FromArgb(245, 230, 209)
        pnlMain.Controls.Add(pnlContent)
        pnlMain.Controls.Add(pnlHeader)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(0, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Padding = New Padding(20)
        pnlMain.Size = New Size(1184, 850)
        pnlMain.TabIndex = 1

        '
        ' pnlContent
        '
        pnlContent.BackColor = Color.FromArgb(245, 230, 209)
        pnlContent.Controls.Add(flpVideos)
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(20, 105)
        pnlContent.Name = "pnlContent"
        pnlContent.Padding = New Padding(0, 15, 0, 0)
        pnlContent.Size = New Size(1144, 725)
        pnlContent.TabIndex = 2

        '
        ' flpVideos
        '
        flpVideos.AutoScroll = True
        flpVideos.BackColor = Color.FromArgb(245, 230, 209)
        flpVideos.Controls.Add(Label1)
        flpVideos.Controls.Add(lblPet)
        flpVideos.Controls.Add(cmbPetName)
        flpVideos.Controls.Add(Panel1)
        flpVideos.Dock = DockStyle.Fill
        flpVideos.Location = New Point(0, 15)
        flpVideos.Name = "flpVideos"
        flpVideos.Padding = New Padding(5)
        flpVideos.Size = New Size(1144, 710)
        flpVideos.TabIndex = 0

        '
        ' Label1
        '
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Label1.ForeColor = Color.SaddleBrown
        Label1.Location = New Point(8, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 23)
        Label1.TabIndex = 1
        Label1.Text = "Pet Name :"

        '
        ' lblPet
        '
        lblPet.AutoSize = True
        lblPet.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblPet.ForeColor = Color.SaddleBrown
        lblPet.Location = New Point(101, 8)
        lblPet.Name = "lblPet"
        lblPet.Size = New Size(0, 23)
        lblPet.TabIndex = 2

        '
        ' cmbPetName
        '
        cmbPetName.DropDownStyle = ComboBoxStyle.DropDownList
        cmbPetName.Font = New Font("Segoe UI", 10.0F)
        cmbPetName.FormattingEnabled = True
        cmbPetName.Location = New Point(105, 5)
        cmbPetName.Name = "cmbPetName"
        cmbPetName.Size = New Size(250, 31)
        cmbPetName.TabIndex = 5

        '
        ' Panel1
        '
        Panel1.BackColor = Color.FromArgb(245, 230, 209)
        Panel1.Controls.Add(VideoView1)
        Panel1.Controls.Add(pnlControls)
        Panel1.Location = New Point(10, 48)
        Panel1.Margin = New Padding(5)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(15)
        Panel1.Size = New Size(1095, 650)
        Panel1.TabIndex = 3

        '
        ' VideoView1
        '
        VideoView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        VideoView1.BackColor = Color.Black
        VideoView1.Location = New Point(15, 15)
        VideoView1.MediaPlayer = Nothing
        VideoView1.Name = "VideoView1"
        VideoView1.Size = New Size(1065, 450)
        VideoView1.TabIndex = 2
        VideoView1.Text = "VideoView1"

        '
        ' pnlControls
        '
        pnlControls.BackColor = Color.FromArgb(232, 216, 194)
        pnlControls.Controls.Add(btnStartLive)
        pnlControls.Controls.Add(Label2)
        pnlControls.Controls.Add(txtCameraURL)
        pnlControls.Controls.Add(btnDashboard)
        pnlControls.Controls.Add(lblCameraURL)
        pnlControls.Dock = DockStyle.Bottom
        pnlControls.Location = New Point(15, 480)
        pnlControls.Name = "pnlControls"
        pnlControls.Padding = New Padding(15)
        pnlControls.Size = New Size(1065, 155)
        pnlControls.TabIndex = 1

        '
        ' btnStartLive
        '
        btnStartLive.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnStartLive.BackColor = Color.Sienna
        btnStartLive.FlatAppearance.BorderSize = 0
        btnStartLive.FlatStyle = FlatStyle.Flat
        btnStartLive.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnStartLive.ForeColor = Color.WhiteSmoke
        btnStartLive.Location = New Point(570, 103)
        btnStartLive.Name = "btnStartLive"
        btnStartLive.Size = New Size(225, 40)
        btnStartLive.TabIndex = 3
        btnStartLive.Text = "Start Live"
        btnStartLive.UseVisualStyleBackColor = False

        '
        ' Label2
        '
        Label2.AutoSize = True
        Label2.Font = New Font("Georgia", 15.0F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(61, 40, 27)
        Label2.Location = New Point(15, 12)
        Label2.Name = "Label2"
        Label2.Size = New Size(215, 30)
        Label2.TabIndex = 0
        Label2.Text = "Live CCTV View"

        '
        ' txtCameraURL
        '
        txtCameraURL.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtCameraURL.BackColor = Color.White
        txtCameraURL.BorderStyle = BorderStyle.FixedSingle
        txtCameraURL.Font = New Font("Segoe UI", 10.0F)
        txtCameraURL.Location = New Point(125, 55)
        txtCameraURL.Name = "txtCameraURL"
        txtCameraURL.Size = New Size(910, 30)
        txtCameraURL.TabIndex = 3

        '
        ' btnDashboard
        '
        btnDashboard.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnDashboard.BackColor = Color.SaddleBrown
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnDashboard.ForeColor = Color.WhiteSmoke
        btnDashboard.Location = New Point(805, 103)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(230, 40)
        btnDashboard.TabIndex = 7
        btnDashboard.Text = "Back to Dashboard"
        btnDashboard.UseVisualStyleBackColor = False

        '
        ' lblCameraURL
        '
        lblCameraURL.AutoSize = True
        lblCameraURL.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblCameraURL.ForeColor = Color.SaddleBrown
        lblCameraURL.Location = New Point(15, 59)
        lblCameraURL.Name = "lblCameraURL"
        lblCameraURL.Size = New Size(102, 21)
        lblCameraURL.TabIndex = 2
        lblCameraURL.Text = "Camera URL"

        '
        ' pnlHeader
        '
        pnlHeader.BackColor = Color.FromArgb(252, 235, 213)
        pnlHeader.Controls.Add(lblSubtitle)
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(20, 20)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1144, 85)
        pnlHeader.TabIndex = 0

        '
        ' lblSubtitle
        '
        lblSubtitle.AutoSize = True
        lblSubtitle.Font = New Font("Segoe UI", 9.5F)
        lblSubtitle.ForeColor = Color.FromArgb(107, 98, 91)
        lblSubtitle.Location = New Point(20, 49)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(272, 21)
        lblSubtitle.TabIndex = 1
        lblSubtitle.Text = "View pet boarding and activity videos."

        '
        ' lblTitle
        '
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Georgia", 20.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(61, 40, 27)
        lblTitle.Location = New Point(18, 12)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(202, 39)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Pet Videos"

        '
        ' FrmBoardingVideos
        '
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(245, 230, 209)
        ClientSize = New Size(1184, 850)
        Controls.Add(pnlMain)
        MinimumSize = New Size(1050, 750)
        Name = "FrmBoardingVideos"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pet Videos"

        pnlMain.ResumeLayout(False)
        pnlContent.ResumeLayout(False)
        flpVideos.ResumeLayout(False)
        flpVideos.PerformLayout()
        Panel1.ResumeLayout(False)
        CType(VideoView1, ComponentModel.ISupportInitialize).EndInit()
        pnlControls.ResumeLayout(False)
        pnlControls.PerformLayout()
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlContent As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnDashboard As Button
    Friend WithEvents flpVideos As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPet As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlControls As Panel
    Friend WithEvents txtCameraURL As TextBox
    Friend WithEvents lblCameraURL As Label
    Friend WithEvents cmbPetName As ComboBox
    Friend WithEvents VideoView1 As LibVLCSharp.WinForms.VideoView
    Friend WithEvents btnStartLive As Button
    Friend WithEvents Label2 As Label

End Class