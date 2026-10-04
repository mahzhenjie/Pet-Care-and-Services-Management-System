<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBoardingVideos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
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
        lblCameraURL = New Label()
        btnDashboard = New Button()
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
        pnlMain.BackColor = Color.FromArgb(CByte(245), CByte(230), CByte(209))
        pnlMain.Controls.Add(pnlContent)
        pnlMain.Controls.Add(pnlHeader)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(0, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Padding = New Padding(20)
        pnlMain.Size = New Size(1162, 1127)
        pnlMain.TabIndex = 1
        ' 
        ' pnlContent
        ' 
        pnlContent.BackColor = Color.FromArgb(CByte(245), CByte(230), CByte(209))
        pnlContent.Controls.Add(flpVideos)
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(20, 105)
        pnlContent.Name = "pnlContent"
        pnlContent.Padding = New Padding(0, 15, 0, 0)
        pnlContent.Size = New Size(1122, 1002)
        pnlContent.TabIndex = 2
        ' 
        ' flpVideos
        ' 
        flpVideos.AutoScroll = True
        flpVideos.BackColor = Color.FromArgb(CByte(245), CByte(230), CByte(209))
        flpVideos.Controls.Add(Label1)
        flpVideos.Controls.Add(lblPet)
        flpVideos.Controls.Add(cmbPetName)
        flpVideos.Controls.Add(Panel1)
        flpVideos.Dock = DockStyle.Fill
        flpVideos.Location = New Point(0, 15)
        flpVideos.Name = "flpVideos"
        flpVideos.Padding = New Padding(5)
        flpVideos.Size = New Size(1122, 987)
        flpVideos.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.SaddleBrown
        Label1.Location = New Point(8, 5)
        Label1.Name = "Label1"
        Label1.Size = New Size(169, 38)
        Label1.TabIndex = 1
        Label1.Text = "Pet Name : "
        ' 
        ' lblPet
        ' 
        lblPet.AutoSize = True
        lblPet.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPet.ForeColor = Color.SaddleBrown
        lblPet.Location = New Point(183, 5)
        lblPet.Name = "lblPet"
        lblPet.Size = New Size(0, 38)
        lblPet.TabIndex = 2
        ' 
        ' cmbPetName
        ' 
        cmbPetName.FormattingEnabled = True
        cmbPetName.Location = New Point(189, 8)
        cmbPetName.Name = "cmbPetName"
        cmbPetName.Size = New Size(206, 38)
        cmbPetName.TabIndex = 5
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(245), CByte(230), CByte(209))
        Panel1.Controls.Add(VideoView1)
        Panel1.Controls.Add(pnlControls)
        Panel1.Location = New Point(8, 52)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(20)
        Panel1.Size = New Size(1099, 853)
        Panel1.TabIndex = 3
        ' 
        ' VideoView1
        ' 
        VideoView1.BackColor = Color.Black
        VideoView1.Location = New Point(4, 8)
        VideoView1.MediaPlayer = Nothing
        VideoView1.Name = "VideoView1"
        VideoView1.Size = New Size(1089, 650)
        VideoView1.TabIndex = 2
        VideoView1.Text = "VideoView1"
        ' 
        ' pnlControls
        ' 
        pnlControls.BackColor = Color.FromArgb(CByte(232), CByte(216), CByte(194))
        pnlControls.Controls.Add(btnStartLive)
        pnlControls.Controls.Add(Label2)
        pnlControls.Controls.Add(txtCameraURL)
        pnlControls.Controls.Add(btnDashboard)
        pnlControls.Controls.Add(lblCameraURL)
        pnlControls.Dock = DockStyle.Bottom
        pnlControls.Location = New Point(20, 678)
        pnlControls.Name = "pnlControls"
        pnlControls.Padding = New Padding(18, 12, 18, 12)
        pnlControls.Size = New Size(1059, 155)
        pnlControls.TabIndex = 1
        ' 
        ' btnStartLive
        ' 
        btnStartLive.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnStartLive.BackColor = Color.Sienna
        btnStartLive.FlatAppearance.BorderSize = 0
        btnStartLive.FlatStyle = FlatStyle.Flat
        btnStartLive.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnStartLive.ForeColor = Color.WhiteSmoke
        btnStartLive.Location = New Point(391, 107)
        btnStartLive.Name = "btnStartLive"
        btnStartLive.Size = New Size(294, 40)
        btnStartLive.TabIndex = 3
        btnStartLive.Text = "Start Live"
        btnStartLive.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Georgia", 15F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(61), CByte(40), CByte(27))
        Label2.Location = New Point(21, 12)
        Label2.Name = "Label2"
        Label2.Size = New Size(260, 35)
        Label2.TabIndex = 0
        Label2.Text = "Live CCTV View"
        ' 
        ' txtCameraURL
        ' 
        txtCameraURL.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtCameraURL.Font = New Font("Segoe UI", 9.5F)
        txtCameraURL.Location = New Point(144, 59)
        txtCameraURL.Name = "txtCameraURL"
        txtCameraURL.Size = New Size(894, 33)
        txtCameraURL.TabIndex = 3
        ' 
        ' lblCameraURL
        ' 
        lblCameraURL.AutoSize = True
        lblCameraURL.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblCameraURL.ForeColor = Color.SaddleBrown
        lblCameraURL.Location = New Point(18, 62)
        lblCameraURL.Name = "lblCameraURL"
        lblCameraURL.Size = New Size(120, 25)
        lblCameraURL.TabIndex = 2
        lblCameraURL.Text = "Camera URL"
        ' 
        ' btnDashboard
        ' 
        btnDashboard.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnDashboard.BackColor = Color.SaddleBrown
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnDashboard.ForeColor = Color.WhiteSmoke
        btnDashboard.Location = New Point(708, 107)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(330, 40)
        btnDashboard.TabIndex = 7
        btnDashboard.Text = "Back to Dashboard"
        btnDashboard.UseVisualStyleBackColor = False
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(252), CByte(235), CByte(213))
        pnlHeader.Controls.Add(lblSubtitle)
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(20, 20)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1122, 85)
        pnlHeader.TabIndex = 0
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.Font = New Font("Segoe UI", 9.5F)
        lblSubtitle.ForeColor = Color.FromArgb(CByte(107), CByte(98), CByte(91))
        lblSubtitle.Location = New Point(20, 49)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(331, 25)
        lblSubtitle.TabIndex = 1
        lblSubtitle.Text = "View pet boarding and activity videos."
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Georgia", 20F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(CByte(61), CByte(40), CByte(27))
        lblTitle.Location = New Point(15, 14)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(237, 46)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Pet Videos"
        ' 
        ' FrmBoardingVideos
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1162, 1127)
        Controls.Add(pnlMain)
        Name = "FrmBoardingVideos"
        Text = "FrmBoardingVideos"
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
