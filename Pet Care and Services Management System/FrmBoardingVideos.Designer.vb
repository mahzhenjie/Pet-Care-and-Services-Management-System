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
        pnlToolbar = New Panel()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        btnGoBackDashboard = New Button()
        btnAddVideo = New Button()
        btnRefresh = New Button()
        txtSearch = New TextBox()
        lblSearch = New Label()
        pnlHeader = New Panel()
        lblSubtitle = New Label()
        lblTitle = New Label()
        VideoView1 = New LibVLCSharp.WinForms.VideoView()
        Label1 = New Label()
        lblPet = New Label()
        pnlMain.SuspendLayout()
        pnlContent.SuspendLayout()
        flpVideos.SuspendLayout()
        pnlToolbar.SuspendLayout()
        pnlHeader.SuspendLayout()
        CType(VideoView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlMain
        ' 
        pnlMain.BackColor = Color.FromArgb(CByte(245), CByte(230), CByte(209))
        pnlMain.Controls.Add(pnlContent)
        pnlMain.Controls.Add(pnlToolbar)
        pnlMain.Controls.Add(pnlHeader)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(0, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Padding = New Padding(20)
        pnlMain.Size = New Size(1162, 918)
        pnlMain.TabIndex = 1
        ' 
        ' pnlContent
        ' 
        pnlContent.BackColor = Color.FromArgb(CByte(245), CByte(230), CByte(209))
        pnlContent.Controls.Add(flpVideos)
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(20, 175)
        pnlContent.Name = "pnlContent"
        pnlContent.Padding = New Padding(0, 15, 0, 0)
        pnlContent.Size = New Size(1122, 723)
        pnlContent.TabIndex = 2
        ' 
        ' flpVideos
        ' 
        flpVideos.AutoScroll = True
        flpVideos.BackColor = Color.FromArgb(CByte(245), CByte(230), CByte(209))
        flpVideos.Controls.Add(VideoView1)
        flpVideos.Controls.Add(Label1)
        flpVideos.Controls.Add(lblPet)
        flpVideos.Dock = DockStyle.Fill
        flpVideos.Location = New Point(0, 15)
        flpVideos.Name = "flpVideos"
        flpVideos.Padding = New Padding(5)
        flpVideos.Size = New Size(1122, 708)
        flpVideos.TabIndex = 0
        ' 
        ' pnlToolbar
        ' 
        pnlToolbar.BackColor = Color.FromArgb(CByte(232), CByte(216), CByte(194))
        pnlToolbar.Controls.Add(Button1)
        pnlToolbar.Controls.Add(Button2)
        pnlToolbar.Controls.Add(Button3)
        pnlToolbar.Controls.Add(btnGoBackDashboard)
        pnlToolbar.Controls.Add(btnAddVideo)
        pnlToolbar.Controls.Add(btnRefresh)
        pnlToolbar.Controls.Add(txtSearch)
        pnlToolbar.Controls.Add(lblSearch)
        pnlToolbar.Dock = DockStyle.Top
        pnlToolbar.Location = New Point(20, 105)
        pnlToolbar.Name = "pnlToolbar"
        pnlToolbar.Size = New Size(1122, 70)
        pnlToolbar.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.BackColor = Color.SaddleBrown
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        Button1.ForeColor = Color.WhiteSmoke
        Button1.Location = New Point(912, 16)
        Button1.Name = "Button1"
        Button1.Size = New Size(195, 40)
        Button1.TabIndex = 7
        Button1.Text = "Back to Dashboard"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button2.BackColor = Color.FromArgb(CByte(96), CByte(52), CByte(16))
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        Button2.ForeColor = Color.WhiteSmoke
        Button2.Location = New Point(716, 17)
        Button2.Name = "Button2"
        Button2.Size = New Size(190, 40)
        Button2.TabIndex = 6
        Button2.Text = "+ Add Video"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button3.BackColor = Color.Sienna
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        Button3.ForeColor = Color.WhiteSmoke
        Button3.Location = New Point(503, 16)
        Button3.Name = "Button3"
        Button3.Size = New Size(207, 40)
        Button3.TabIndex = 5
        Button3.Text = "Refresh"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' btnGoBackDashboard
        ' 
        btnGoBackDashboard.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnGoBackDashboard.BackColor = Color.SaddleBrown
        btnGoBackDashboard.FlatAppearance.BorderSize = 0
        btnGoBackDashboard.FlatStyle = FlatStyle.Flat
        btnGoBackDashboard.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnGoBackDashboard.ForeColor = Color.WhiteSmoke
        btnGoBackDashboard.Location = New Point(1852, 15)
        btnGoBackDashboard.Name = "btnGoBackDashboard"
        btnGoBackDashboard.Size = New Size(195, 40)
        btnGoBackDashboard.TabIndex = 4
        btnGoBackDashboard.Text = "Back to Dashboard"
        btnGoBackDashboard.UseVisualStyleBackColor = False
        ' 
        ' btnAddVideo
        ' 
        btnAddVideo.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnAddVideo.BackColor = Color.FromArgb(CByte(96), CByte(52), CByte(16))
        btnAddVideo.FlatAppearance.BorderSize = 0
        btnAddVideo.FlatStyle = FlatStyle.Flat
        btnAddVideo.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnAddVideo.ForeColor = Color.WhiteSmoke
        btnAddVideo.Location = New Point(1647, 15)
        btnAddVideo.Name = "btnAddVideo"
        btnAddVideo.Size = New Size(190, 40)
        btnAddVideo.TabIndex = 3
        btnAddVideo.Text = "+ Add Video"
        btnAddVideo.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnRefresh.BackColor = Color.Sienna
        btnRefresh.FlatAppearance.BorderSize = 0
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnRefresh.ForeColor = Color.WhiteSmoke
        btnRefresh.Location = New Point(1552, 15)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(85, 40)
        btnRefresh.TabIndex = 2
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtSearch.Font = New Font("Segoe UI", 10F)
        txtSearch.Location = New Point(90, 18)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(392, 34)
        txtSearch.TabIndex = 1
        txtSearch.Text = "Search pet video..."
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblSearch.ForeColor = Color.SaddleBrown
        lblSearch.Location = New Point(8, 21)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(75, 28)
        lblSearch.TabIndex = 0
        lblSearch.Text = "Search"
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
        ' VideoView1
        ' 
        VideoView1.BackColor = Color.Black
        VideoView1.Location = New Point(8, 8)
        VideoView1.MediaPlayer = Nothing
        VideoView1.Name = "VideoView1"
        VideoView1.Size = New Size(1099, 497)
        VideoView1.TabIndex = 0
        VideoView1.Text = "VideoView1"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.SaddleBrown
        Label1.Location = New Point(8, 508)
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
        lblPet.Location = New Point(183, 508)
        lblPet.Name = "lblPet"
        lblPet.Size = New Size(0, 38)
        lblPet.TabIndex = 2
        ' 
        ' FrmBoardingVideos
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1162, 918)
        Controls.Add(pnlMain)
        Name = "FrmBoardingVideos"
        Text = "FrmBoardingVideos"
        pnlMain.ResumeLayout(False)
        pnlContent.ResumeLayout(False)
        flpVideos.ResumeLayout(False)
        flpVideos.PerformLayout()
        pnlToolbar.ResumeLayout(False)
        pnlToolbar.PerformLayout()
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        CType(VideoView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlContent As Panel
    Friend WithEvents flpVideos As FlowLayoutPanel
    Friend WithEvents pnlToolbar As Panel
    Friend WithEvents btnGoBackDashboard As Button
    Friend WithEvents btnAddVideo As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblSearch As Label
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents VideoView1 As LibVLCSharp.WinForms.VideoView
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPet As Label
End Class
