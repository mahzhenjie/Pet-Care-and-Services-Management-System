<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBoardingServices
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
        flpServices = New FlowLayoutPanel()
        pnlToolbar = New Panel()
        btnGoBackDashboard = New Button()
        btnAddBoardingService = New Button()
        btnRefresh = New Button()
        txtSearch = New TextBox()
        lblSearch = New Label()
        pnlHeader = New Panel()
        lblSubtitle = New Label()
        lblTitle = New Label()
        pnlMain.SuspendLayout()
        pnlContent.SuspendLayout()
        pnlToolbar.SuspendLayout()
        pnlHeader.SuspendLayout()
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
        pnlMain.Size = New Size(1184, 1031)
        pnlMain.TabIndex = 0
        ' 
        ' pnlContent
        ' 
        pnlContent.BackColor = Color.FromArgb(CByte(245), CByte(230), CByte(209))
        pnlContent.Controls.Add(flpServices)
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(20, 175)
        pnlContent.Name = "pnlContent"
        pnlContent.Padding = New Padding(0, 15, 0, 0)
        pnlContent.Size = New Size(1144, 836)
        pnlContent.TabIndex = 2
        ' 
        ' flpServices
        ' 
        flpServices.AutoScroll = True
        flpServices.BackColor = Color.FromArgb(CByte(245), CByte(230), CByte(209))
        flpServices.Dock = DockStyle.Fill
        flpServices.Location = New Point(0, 15)
        flpServices.Name = "flpServices"
        flpServices.Padding = New Padding(5)
        flpServices.Size = New Size(1144, 821)
        flpServices.TabIndex = 0
        ' 
        ' pnlToolbar
        ' 
        pnlToolbar.BackColor = Color.FromArgb(CByte(232), CByte(216), CByte(194))
        pnlToolbar.Controls.Add(btnGoBackDashboard)
        pnlToolbar.Controls.Add(btnAddBoardingService)
        pnlToolbar.Controls.Add(btnRefresh)
        pnlToolbar.Controls.Add(txtSearch)
        pnlToolbar.Controls.Add(lblSearch)
        pnlToolbar.Dock = DockStyle.Top
        pnlToolbar.Location = New Point(20, 105)
        pnlToolbar.Name = "pnlToolbar"
        pnlToolbar.Size = New Size(1144, 70)
        pnlToolbar.TabIndex = 1
        ' 
        ' btnGoBackDashboard
        ' 
        btnGoBackDashboard.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnGoBackDashboard.BackColor = Color.SaddleBrown
        btnGoBackDashboard.FlatAppearance.BorderSize = 0
        btnGoBackDashboard.FlatStyle = FlatStyle.Flat
        btnGoBackDashboard.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnGoBackDashboard.ForeColor = Color.WhiteSmoke
        btnGoBackDashboard.Location = New Point(930, 15)
        btnGoBackDashboard.Name = "btnGoBackDashboard"
        btnGoBackDashboard.Size = New Size(195, 40)
        btnGoBackDashboard.TabIndex = 0
        btnGoBackDashboard.Text = "Back to Dashboard"
        btnGoBackDashboard.UseVisualStyleBackColor = False
        ' 
        ' btnAddBoardingService
        ' 
        btnAddBoardingService.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnAddBoardingService.BackColor = Color.FromArgb(CByte(96), CByte(52), CByte(16))
        btnAddBoardingService.FlatAppearance.BorderSize = 0
        btnAddBoardingService.FlatStyle = FlatStyle.Flat
        btnAddBoardingService.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnAddBoardingService.ForeColor = Color.WhiteSmoke
        btnAddBoardingService.Location = New Point(725, 15)
        btnAddBoardingService.Name = "btnAddBoardingService"
        btnAddBoardingService.Size = New Size(190, 40)
        btnAddBoardingService.TabIndex = 1
        btnAddBoardingService.Text = "+ Add Service"
        btnAddBoardingService.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnRefresh.BackColor = Color.Sienna
        btnRefresh.FlatAppearance.BorderSize = 0
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnRefresh.ForeColor = Color.WhiteSmoke
        btnRefresh.Location = New Point(630, 15)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(85, 40)
        btnRefresh.TabIndex = 2
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtSearch.Font = New Font("Segoe UI", 10.0F)
        txtSearch.Location = New Point(90, 18)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(515, 30)
        txtSearch.TabIndex = 3
        txtSearch.Text = "Search boarding service..."
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblSearch.ForeColor = Color.SaddleBrown
        lblSearch.Location = New Point(15, 22)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(63, 23)
        lblSearch.TabIndex = 4
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
        pnlHeader.Size = New Size(1144, 85)
        pnlHeader.TabIndex = 0
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.Font = New Font("Segoe UI", 9.5F)
        lblSubtitle.ForeColor = Color.FromArgb(CByte(107), CByte(98), CByte(91))
        lblSubtitle.Location = New Point(20, 49)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(335, 21)
        lblSubtitle.TabIndex = 0
        lblSubtitle.Text = "Manage boarding services and service pricing."
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Georgia", 20.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(CByte(61), CByte(40), CByte(27))
        lblTitle.Location = New Point(18, 12)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(586, 39)
        lblTitle.TabIndex = 1
        lblTitle.Text = "Boarding Services Management"
        ' 
        ' frmBoardingServices
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(245), CByte(230), CByte(209))
        ClientSize = New Size(1184, 1031)
        Controls.Add(pnlMain)
        MinimumSize = New Size(1050, 650)
        Name = "frmBoardingServices"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Boarding Services Management"
        pnlMain.ResumeLayout(False)
        pnlContent.ResumeLayout(False)
        pnlToolbar.ResumeLayout(False)
        pnlToolbar.PerformLayout()
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents pnlToolbar As Panel
    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnAddBoardingService As Button
    Friend WithEvents btnGoBackDashboard As Button
    Friend WithEvents pnlContent As Panel
    Friend WithEvents flpServices As FlowLayoutPanel

End Class