<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBoardingService
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
        flpRooms = New FlowLayoutPanel()
        pnlToolbar = New Panel()
        btnDashboard = New Button()
        btnAddBooking = New Button()
        Refreshbtn = New Button()
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
        pnlMain.BackColor = Color.FromArgb(245, 230, 209)
        pnlMain.Controls.Add(pnlContent)
        pnlMain.Controls.Add(pnlToolbar)
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
        pnlContent.Controls.Add(flpRooms)
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(20, 175)
        pnlContent.Name = "pnlContent"
        pnlContent.Padding = New Padding(0, 15, 0, 0)
        pnlContent.Size = New Size(1144, 655)
        pnlContent.TabIndex = 2

        '
        ' flpRooms
        '
        flpRooms.AutoScroll = True
        flpRooms.BackColor = Color.FromArgb(245, 230, 209)
        flpRooms.Dock = DockStyle.Fill
        flpRooms.Location = New Point(0, 15)
        flpRooms.Name = "flpRooms"
        flpRooms.Padding = New Padding(5)
        flpRooms.Size = New Size(1144, 640)
        flpRooms.TabIndex = 0

        '
        ' pnlToolbar
        '
        pnlToolbar.BackColor = Color.FromArgb(232, 216, 194)
        pnlToolbar.Controls.Add(btnDashboard)
        pnlToolbar.Controls.Add(btnAddBooking)
        pnlToolbar.Controls.Add(Refreshbtn)
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
        ' btnDashboard
        '
        btnDashboard.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnDashboard.BackColor = Color.SaddleBrown
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnDashboard.ForeColor = Color.WhiteSmoke
        btnDashboard.Location = New Point(930, 15)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(195, 40)
        btnDashboard.TabIndex = 5
        btnDashboard.Text = "Dashboard"
        btnDashboard.UseVisualStyleBackColor = False

        '
        ' btnAddBooking
        '
        btnAddBooking.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnAddBooking.BackColor = Color.FromArgb(96, 52, 16)
        btnAddBooking.FlatAppearance.BorderSize = 0
        btnAddBooking.FlatStyle = FlatStyle.Flat
        btnAddBooking.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnAddBooking.ForeColor = Color.WhiteSmoke
        btnAddBooking.Location = New Point(725, 15)
        btnAddBooking.Name = "btnAddBooking"
        btnAddBooking.Size = New Size(190, 40)
        btnAddBooking.TabIndex = 6
        btnAddBooking.Text = "+ Add Booking"
        btnAddBooking.UseVisualStyleBackColor = False

        '
        ' Refreshbtn
        '
        Refreshbtn.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Refreshbtn.BackColor = Color.Sienna
        Refreshbtn.FlatAppearance.BorderSize = 0
        Refreshbtn.FlatStyle = FlatStyle.Flat
        Refreshbtn.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        Refreshbtn.ForeColor = Color.WhiteSmoke
        Refreshbtn.Location = New Point(630, 15)
        Refreshbtn.Name = "Refreshbtn"
        Refreshbtn.Size = New Size(85, 40)
        Refreshbtn.TabIndex = 7
        Refreshbtn.Text = "Refresh"
        Refreshbtn.UseVisualStyleBackColor = False

        '
        ' btnGoBackDashboard
        '
        btnGoBackDashboard.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnGoBackDashboard.BackColor = Color.SaddleBrown
        btnGoBackDashboard.FlatAppearance.BorderSize = 0
        btnGoBackDashboard.FlatStyle = FlatStyle.Flat
        btnGoBackDashboard.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnGoBackDashboard.ForeColor = Color.WhiteSmoke
        btnGoBackDashboard.Location = New Point(2230, 15)
        btnGoBackDashboard.Name = "btnGoBackDashboard"
        btnGoBackDashboard.Size = New Size(195, 40)
        btnGoBackDashboard.TabIndex = 0
        btnGoBackDashboard.Text = "Back to Dashboard"
        btnGoBackDashboard.UseVisualStyleBackColor = False

        '
        ' btnAddBoardingService
        '
        btnAddBoardingService.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnAddBoardingService.BackColor = Color.FromArgb(96, 52, 16)
        btnAddBoardingService.FlatAppearance.BorderSize = 0
        btnAddBoardingService.FlatStyle = FlatStyle.Flat
        btnAddBoardingService.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnAddBoardingService.ForeColor = Color.WhiteSmoke
        btnAddBoardingService.Location = New Point(2025, 15)
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
        btnRefresh.Location = New Point(1930, 15)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(85, 40)
        btnRefresh.TabIndex = 2
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False

        '
        ' txtSearch
        '
        txtSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtSearch.BackColor = Color.White
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Font = New Font("Segoe UI", 10.0F)
        txtSearch.Location = New Point(90, 18)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(515, 34)
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
        lblSearch.Size = New Size(75, 28)
        lblSearch.TabIndex = 4
        lblSearch.Text = "Search"

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
        lblSubtitle.Size = New Size(328, 25)
        lblSubtitle.TabIndex = 0
        lblSubtitle.Text = "Boarding services and service pricing."

        '
        ' lblTitle
        '
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Georgia", 20.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(61, 40, 27)
        lblTitle.Location = New Point(18, 12)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(394, 46)
        lblTitle.TabIndex = 1
        lblTitle.Text = "Boarding Services"

        '
        ' FrmBoardingService
        '
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(245, 230, 209)
        ClientSize = New Size(1184, 850)
        Controls.Add(pnlMain)
        MinimumSize = New Size(1050, 650)
        Name = "FrmBoardingService"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Boarding Services"

        pnlMain.ResumeLayout(False)
        pnlContent.ResumeLayout(False)
        pnlToolbar.ResumeLayout(False)
        pnlToolbar.PerformLayout()
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlContent As Panel
    Friend WithEvents flpRooms As FlowLayoutPanel
    Friend WithEvents pnlToolbar As Panel
    Friend WithEvents btnGoBackDashboard As Button
    Friend WithEvents btnAddBoardingService As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblSearch As Label
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnAddBooking As Button
    Friend WithEvents Refreshbtn As Button

End Class