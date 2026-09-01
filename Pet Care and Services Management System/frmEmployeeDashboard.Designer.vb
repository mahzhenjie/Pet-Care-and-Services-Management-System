<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployeeDashboard
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
        Dim lblDescription As Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmployeeDashboard))
        Label1 = New Label()
        pnlMain = New Panel()
        pnlSidebar = New Panel()
        btnLogout = New Button()
        btnProducts = New Button()
        btnMembership = New Button()
        lblShopAndMembership = New Label()
        lblFacility = New Label()
        lblServices = New Label()
        btnVideo = New Button()
        btnRooms = New Button()
        btnBoarding = New Button()
        btnGromming = New Button()
        btnPayments = New Button()
        btnOrders = New Button()
        btnBokkings = New Button()
        btnPets = New Button()
        lblManagement = New Label()
        btnCustomers = New Button()
        btnDashboard = New Button()
        picLogo = New PictureBox()
        lblSidebarSubtitle = New Label()
        lblSidebarTitle = New Label()
        lblDashboardTitle = New Label()
        btnMenu = New Button()
        picPaw = New PictureBox()
        pnlTopBar = New Panel()
        btnNotification = New Button()
        picEmployee = New PictureBox()
        lblWelcome = New Label()
        lblEmployee = New Label()
        btnDropdown = New Button()
        pnlWelcome = New Panel()
        lblWelcomeBack = New Label()
        picPets2 = New PictureBox()
        lblDescription = New Label()
        pnlMain.SuspendLayout()
        pnlSidebar.SuspendLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        CType(picPaw, ComponentModel.ISupportInitialize).BeginInit()
        pnlTopBar.SuspendLayout()
        CType(picEmployee, ComponentModel.ISupportInitialize).BeginInit()
        pnlWelcome.SuspendLayout()
        CType(picPets2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(25, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 20)
        Label1.TabIndex = 0
        Label1.Text = "Label1"
        ' 
        ' pnlMain
        ' 
        pnlMain.BackColor = Color.FromArgb(CByte(250), CByte(240), CByte(222))
        pnlMain.BorderStyle = BorderStyle.FixedSingle
        pnlMain.Controls.Add(pnlWelcome)
        pnlMain.Controls.Add(pnlTopBar)
        pnlMain.Controls.Add(pnlSidebar)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(0, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(1382, 873)
        pnlMain.TabIndex = 1
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.FromArgb(CByte(74), CByte(44), CByte(26))
        pnlSidebar.Controls.Add(btnLogout)
        pnlSidebar.Controls.Add(btnProducts)
        pnlSidebar.Controls.Add(btnMembership)
        pnlSidebar.Controls.Add(lblShopAndMembership)
        pnlSidebar.Controls.Add(lblFacility)
        pnlSidebar.Controls.Add(lblServices)
        pnlSidebar.Controls.Add(btnVideo)
        pnlSidebar.Controls.Add(btnRooms)
        pnlSidebar.Controls.Add(btnBoarding)
        pnlSidebar.Controls.Add(btnGromming)
        pnlSidebar.Controls.Add(btnPayments)
        pnlSidebar.Controls.Add(btnOrders)
        pnlSidebar.Controls.Add(btnBokkings)
        pnlSidebar.Controls.Add(btnPets)
        pnlSidebar.Controls.Add(lblManagement)
        pnlSidebar.Controls.Add(btnCustomers)
        pnlSidebar.Controls.Add(btnDashboard)
        pnlSidebar.Controls.Add(picLogo)
        pnlSidebar.Controls.Add(lblSidebarSubtitle)
        pnlSidebar.Controls.Add(lblSidebarTitle)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(280, 871)
        pnlSidebar.TabIndex = 0
        ' 
        ' btnLogout
        ' 
        btnLogout.Location = New Point(19, 820)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(210, 40)
        btnLogout.TabIndex = 27
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' btnProducts
        ' 
        btnProducts.FlatAppearance.BorderSize = 0
        btnProducts.FlatStyle = FlatStyle.Flat
        btnProducts.ForeColor = SystemColors.Control
        btnProducts.Location = New Point(19, 689)
        btnProducts.Name = "btnProducts"
        btnProducts.Size = New Size(210, 40)
        btnProducts.TabIndex = 26
        btnProducts.Text = "🛍 Products"
        btnProducts.TextAlign = ContentAlignment.MiddleLeft
        btnProducts.UseVisualStyleBackColor = True
        ' 
        ' btnMembership
        ' 
        btnMembership.FlatAppearance.BorderSize = 0
        btnMembership.FlatStyle = FlatStyle.Flat
        btnMembership.ForeColor = SystemColors.Control
        btnMembership.Location = New Point(19, 735)
        btnMembership.Name = "btnMembership"
        btnMembership.Size = New Size(210, 40)
        btnMembership.TabIndex = 25
        btnMembership.Text = "⭐ Membership"
        btnMembership.TextAlign = ContentAlignment.MiddleLeft
        btnMembership.UseVisualStyleBackColor = True
        ' 
        ' lblShopAndMembership
        ' 
        lblShopAndMembership.AutoSize = True
        lblShopAndMembership.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblShopAndMembership.ForeColor = Color.FromArgb(CByte(221), CByte(184), CByte(146))
        lblShopAndMembership.Location = New Point(19, 669)
        lblShopAndMembership.Name = "lblShopAndMembership"
        lblShopAndMembership.Size = New Size(134, 17)
        lblShopAndMembership.TabIndex = 24
        lblShopAndMembership.Text = "SHOP & MEMBERSHIP"
        ' 
        ' lblFacility
        ' 
        lblFacility.AutoSize = True
        lblFacility.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFacility.ForeColor = Color.FromArgb(CByte(221), CByte(184), CByte(146))
        lblFacility.Location = New Point(19, 545)
        lblFacility.Name = "lblFacility"
        lblFacility.Size = New Size(62, 17)
        lblFacility.TabIndex = 23
        lblFacility.Text = "FACILITY"
        ' 
        ' lblServices
        ' 
        lblServices.AutoSize = True
        lblServices.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblServices.ForeColor = Color.FromArgb(CByte(221), CByte(184), CByte(146))
        lblServices.Location = New Point(19, 424)
        lblServices.Name = "lblServices"
        lblServices.Size = New Size(65, 17)
        lblServices.TabIndex = 22
        lblServices.Text = "SERVICES"
        ' 
        ' btnVideo
        ' 
        btnVideo.FlatAppearance.BorderSize = 0
        btnVideo.FlatStyle = FlatStyle.Flat
        btnVideo.ForeColor = SystemColors.Control
        btnVideo.Location = New Point(19, 611)
        btnVideo.Name = "btnVideo"
        btnVideo.Size = New Size(210, 40)
        btnVideo.TabIndex = 21
        btnVideo.Text = "🎥 Boarding Videos"
        btnVideo.TextAlign = ContentAlignment.MiddleLeft
        btnVideo.UseVisualStyleBackColor = True
        ' 
        ' btnRooms
        ' 
        btnRooms.FlatAppearance.BorderSize = 0
        btnRooms.FlatStyle = FlatStyle.Flat
        btnRooms.ForeColor = SystemColors.Control
        btnRooms.Location = New Point(19, 565)
        btnRooms.Name = "btnRooms"
        btnRooms.Size = New Size(210, 40)
        btnRooms.TabIndex = 20
        btnRooms.Text = "🛏 Boarding Rooms"
        btnRooms.TextAlign = ContentAlignment.MiddleLeft
        btnRooms.UseVisualStyleBackColor = True
        ' 
        ' btnBoarding
        ' 
        btnBoarding.FlatAppearance.BorderSize = 0
        btnBoarding.FlatStyle = FlatStyle.Flat
        btnBoarding.ForeColor = SystemColors.Control
        btnBoarding.Location = New Point(19, 490)
        btnBoarding.Name = "btnBoarding"
        btnBoarding.Size = New Size(210, 40)
        btnBoarding.TabIndex = 19
        btnBoarding.Text = "🏠 Boarding Services"
        btnBoarding.TextAlign = ContentAlignment.MiddleLeft
        btnBoarding.UseVisualStyleBackColor = True
        ' 
        ' btnGromming
        ' 
        btnGromming.FlatAppearance.BorderSize = 0
        btnGromming.FlatStyle = FlatStyle.Flat
        btnGromming.ForeColor = SystemColors.Control
        btnGromming.Location = New Point(19, 444)
        btnGromming.Name = "btnGromming"
        btnGromming.Size = New Size(210, 40)
        btnGromming.TabIndex = 18
        btnGromming.Text = "✂ Grooming Services"
        btnGromming.TextAlign = ContentAlignment.MiddleLeft
        btnGromming.UseVisualStyleBackColor = True
        ' 
        ' btnPayments
        ' 
        btnPayments.FlatAppearance.BorderSize = 0
        btnPayments.FlatStyle = FlatStyle.Flat
        btnPayments.ForeColor = SystemColors.Control
        btnPayments.Location = New Point(19, 370)
        btnPayments.Name = "btnPayments"
        btnPayments.Size = New Size(210, 40)
        btnPayments.TabIndex = 17
        btnPayments.Text = "💳 Payments"
        btnPayments.TextAlign = ContentAlignment.MiddleLeft
        btnPayments.UseVisualStyleBackColor = True
        ' 
        ' btnOrders
        ' 
        btnOrders.FlatAppearance.BorderSize = 0
        btnOrders.FlatStyle = FlatStyle.Flat
        btnOrders.ForeColor = SystemColors.Control
        btnOrders.Location = New Point(19, 324)
        btnOrders.Name = "btnOrders"
        btnOrders.Size = New Size(210, 40)
        btnOrders.TabIndex = 16
        btnOrders.Text = ChrW(55357) & ChrW(57042) & " Orders"
        btnOrders.TextAlign = ContentAlignment.MiddleLeft
        btnOrders.UseVisualStyleBackColor = True
        ' 
        ' btnBokkings
        ' 
        btnBokkings.FlatAppearance.BorderSize = 0
        btnBokkings.FlatStyle = FlatStyle.Flat
        btnBokkings.ForeColor = SystemColors.Control
        btnBokkings.Location = New Point(19, 278)
        btnBokkings.Name = "btnBokkings"
        btnBokkings.Size = New Size(210, 40)
        btnBokkings.TabIndex = 14
        btnBokkings.Text = "📅 Bookings"
        btnBokkings.TextAlign = ContentAlignment.MiddleLeft
        btnBokkings.UseVisualStyleBackColor = True
        ' 
        ' btnPets
        ' 
        btnPets.FlatAppearance.BorderSize = 0
        btnPets.FlatStyle = FlatStyle.Flat
        btnPets.ForeColor = SystemColors.Control
        btnPets.Location = New Point(19, 232)
        btnPets.Name = "btnPets"
        btnPets.Size = New Size(210, 40)
        btnPets.TabIndex = 13
        btnPets.Text = "🐾 Pets"
        btnPets.TextAlign = ContentAlignment.MiddleLeft
        btnPets.UseVisualStyleBackColor = True
        ' 
        ' lblManagement
        ' 
        lblManagement.AutoSize = True
        lblManagement.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblManagement.ForeColor = Color.FromArgb(CByte(221), CByte(184), CByte(146))
        lblManagement.Location = New Point(19, 163)
        lblManagement.Name = "lblManagement"
        lblManagement.Size = New Size(101, 17)
        lblManagement.TabIndex = 12
        lblManagement.Text = "MANAGEMENT"
        ' 
        ' btnCustomers
        ' 
        btnCustomers.FlatAppearance.BorderSize = 0
        btnCustomers.FlatStyle = FlatStyle.Flat
        btnCustomers.ForeColor = SystemColors.Control
        btnCustomers.Location = New Point(19, 186)
        btnCustomers.Name = "btnCustomers"
        btnCustomers.Size = New Size(210, 40)
        btnCustomers.TabIndex = 4
        btnCustomers.Text = "👥 Customers"
        btnCustomers.TextAlign = ContentAlignment.MiddleLeft
        btnCustomers.UseVisualStyleBackColor = True
        ' 
        ' btnDashboard
        ' 
        btnDashboard.BackColor = Color.FromArgb(CByte(196), CByte(106), CByte(43))
        btnDashboard.BackgroundImageLayout = ImageLayout.Center
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDashboard.ForeColor = Color.White
        btnDashboard.Location = New Point(11, 110)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(220, 45)
        btnDashboard.TabIndex = 3
        btnDashboard.Text = "Dashboard"
        btnDashboard.UseVisualStyleBackColor = False
        ' 
        ' picLogo
        ' 
        picLogo.Location = New Point(1, 8)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(92, 85)
        picLogo.TabIndex = 2
        picLogo.TabStop = False
        ' 
        ' lblSidebarSubtitle
        ' 
        lblSidebarSubtitle.AutoSize = True
        lblSidebarSubtitle.ForeColor = Color.FromArgb(CByte(245), CByte(230), CByte(209))
        lblSidebarSubtitle.Location = New Point(99, 73)
        lblSidebarSubtitle.Name = "lblSidebarSubtitle"
        lblSidebarSubtitle.Size = New Size(168, 20)
        lblSidebarSubtitle.TabIndex = 1
        lblSidebarSubtitle.Text = "MANAGEMENT SYSTEM"
        lblSidebarSubtitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblSidebarTitle
        ' 
        lblSidebarTitle.AutoSize = True
        lblSidebarTitle.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSidebarTitle.ForeColor = Color.White
        lblSidebarTitle.Location = New Point(99, 8)
        lblSidebarTitle.Name = "lblSidebarTitle"
        lblSidebarTitle.Size = New Size(151, 56)
        lblSidebarTitle.TabIndex = 0
        lblSidebarTitle.Text = "PET CARE " & vbCrLf & "AND SERVICES"
        lblSidebarTitle.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblDashboardTitle
        ' 
        lblDashboardTitle.AutoSize = True
        lblDashboardTitle.Font = New Font("Georgia", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDashboardTitle.Location = New Point(63, 14)
        lblDashboardTitle.Name = "lblDashboardTitle"
        lblDashboardTitle.Size = New Size(519, 43)
        lblDashboardTitle.TabIndex = 1
        lblDashboardTitle.Text = "EMPLOYEE DASHBOARD"
        ' 
        ' btnMenu
        ' 
        btnMenu.FlatAppearance.BorderSize = 0
        btnMenu.FlatStyle = FlatStyle.Flat
        btnMenu.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnMenu.Location = New Point(18, 11)
        btnMenu.Name = "btnMenu"
        btnMenu.Size = New Size(54, 45)
        btnMenu.TabIndex = 2
        btnMenu.Text = "☰"
        btnMenu.UseVisualStyleBackColor = True
        ' 
        ' picPaw
        ' 
        picPaw.Location = New Point(588, 5)
        picPaw.Name = "picPaw"
        picPaw.Size = New Size(65, 65)
        picPaw.TabIndex = 3
        picPaw.TabStop = False
        ' 
        ' pnlTopBar
        ' 
        pnlTopBar.Controls.Add(btnDropdown)
        pnlTopBar.Controls.Add(lblEmployee)
        pnlTopBar.Controls.Add(btnMenu)
        pnlTopBar.Controls.Add(lblWelcome)
        pnlTopBar.Controls.Add(picEmployee)
        pnlTopBar.Controls.Add(btnNotification)
        pnlTopBar.Controls.Add(picPaw)
        pnlTopBar.Controls.Add(lblDashboardTitle)
        pnlTopBar.Dock = DockStyle.Top
        pnlTopBar.Location = New Point(280, 0)
        pnlTopBar.Name = "pnlTopBar"
        pnlTopBar.Size = New Size(1100, 77)
        pnlTopBar.TabIndex = 4
        ' 
        ' btnNotification
        ' 
        btnNotification.FlatAppearance.BorderSize = 0
        btnNotification.FlatStyle = FlatStyle.Flat
        btnNotification.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnNotification.Location = New Point(812, 12)
        btnNotification.Name = "btnNotification"
        btnNotification.Size = New Size(54, 45)
        btnNotification.TabIndex = 4
        btnNotification.Text = "🔔"
        btnNotification.UseVisualStyleBackColor = True
        ' 
        ' picEmployee
        ' 
        picEmployee.Location = New Point(881, 5)
        picEmployee.Name = "picEmployee"
        picEmployee.Size = New Size(65, 65)
        picEmployee.SizeMode = PictureBoxSizeMode.Zoom
        picEmployee.TabIndex = 5
        picEmployee.TabStop = False
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoEllipsis = True
        lblWelcome.AutoSize = True
        lblWelcome.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblWelcome.ForeColor = Color.FromArgb(CByte(107), CByte(98), CByte(91))
        lblWelcome.Location = New Point(952, 12)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(84, 23)
        lblWelcome.TabIndex = 5
        lblWelcome.Text = "Welcome,"
        ' 
        ' lblEmployee
        ' 
        lblEmployee.AutoEllipsis = True
        lblEmployee.AutoSize = True
        lblEmployee.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEmployee.ForeColor = Color.FromArgb(CByte(61), CByte(40), CByte(27))
        lblEmployee.Location = New Point(952, 35)
        lblEmployee.Name = "lblEmployee"
        lblEmployee.Size = New Size(118, 31)
        lblEmployee.TabIndex = 6
        lblEmployee.Text = "Employee"
        ' 
        ' btnDropdown
        ' 
        btnDropdown.FlatAppearance.BorderSize = 0
        btnDropdown.FlatStyle = FlatStyle.Flat
        btnDropdown.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDropdown.Location = New Point(1065, 31)
        btnDropdown.Name = "btnDropdown"
        btnDropdown.Size = New Size(35, 35)
        btnDropdown.TabIndex = 5
        btnDropdown.Text = "˅"
        btnDropdown.UseVisualStyleBackColor = True
        ' 
        ' pnlWelcome
        ' 
        pnlWelcome.BackColor = Color.FromArgb(CByte(252), CByte(235), CByte(213))
        pnlWelcome.Controls.Add(picPets2)
        pnlWelcome.Controls.Add(lblDescription)
        pnlWelcome.Controls.Add(lblWelcomeBack)
        pnlWelcome.Location = New Point(313, 101)
        pnlWelcome.Name = "pnlWelcome"
        pnlWelcome.Size = New Size(1056, 158)
        pnlWelcome.TabIndex = 5
        ' 
        ' lblWelcomeBack
        ' 
        lblWelcomeBack.AutoEllipsis = True
        lblWelcomeBack.AutoSize = True
        lblWelcomeBack.Font = New Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblWelcomeBack.ForeColor = Color.FromArgb(CByte(61), CByte(40), CByte(27))
        lblWelcomeBack.Location = New Point(3, 9)
        lblWelcomeBack.Name = "lblWelcomeBack"
        lblWelcomeBack.Size = New Size(413, 60)
        lblWelcomeBack.TabIndex = 7
        lblWelcomeBack.Text = "Welcome back! 👋"
        ' 
        ' lblDescription
        ' 
        lblDescription.AutoSize = True
        lblDescription.Font = New Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDescription.ForeColor = Color.FromArgb(CByte(61), CByte(40), CByte(27))
        lblDescription.Location = New Point(7, 87)
        lblDescription.Name = "lblDescription"
        lblDescription.Size = New Size(330, 62)
        lblDescription.TabIndex = 6
        lblDescription.Text = "Manage your pet care services " & vbCrLf & "easily and efficiently."
        ' 
        ' picPets2
        ' 
        picPets2.BackColor = Color.Transparent
        picPets2.ErrorImage = Nothing
        picPets2.Image = CType(resources.GetObject("picPets2.Image"), Image)
        picPets2.Location = New Point(401, 0)
        picPets2.Name = "picPets2"
        picPets2.Size = New Size(655, 168)
        picPets2.SizeMode = PictureBoxSizeMode.Zoom
        picPets2.TabIndex = 8
        picPets2.TabStop = False
        ' 
        ' frmEmployeeDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(245), CByte(230), CByte(209))
        ClientSize = New Size(1382, 873)
        Controls.Add(pnlMain)
        Controls.Add(Label1)
        Name = "frmEmployeeDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pet Care and Services Management System"
        pnlMain.ResumeLayout(False)
        pnlSidebar.ResumeLayout(False)
        pnlSidebar.PerformLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        CType(picPaw, ComponentModel.ISupportInitialize).EndInit()
        pnlTopBar.ResumeLayout(False)
        pnlTopBar.PerformLayout()
        CType(picEmployee, ComponentModel.ISupportInitialize).EndInit()
        pnlWelcome.ResumeLayout(False)
        pnlWelcome.PerformLayout()
        CType(picPets2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents lblSidebarSubtitle As Label
    Friend WithEvents lblSidebarTitle As Label
    Friend WithEvents btnDashboard As Button
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents btnCustomers As Button
    Friend WithEvents lblManagement As Label
    Friend WithEvents btnVideo As Button
    Friend WithEvents btnRooms As Button
    Friend WithEvents btnBoarding As Button
    Friend WithEvents btnGromming As Button
    Friend WithEvents btnPayments As Button
    Friend WithEvents btnOrders As Button
    Friend WithEvents btnBokkings As Button
    Friend WithEvents btnPets As Button
    Friend WithEvents lblServices As Label
    Friend WithEvents lblFacility As Label
    Friend WithEvents btnProducts As Button
    Friend WithEvents btnMembership As Button
    Friend WithEvents lblShopAndMembership As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblDashboardTitle As Label
    Friend WithEvents btnMenu As Button
    Friend WithEvents pnlTopBar As Panel
    Friend WithEvents picPaw As PictureBox
    Friend WithEvents lblEmployee As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents picEmployee As PictureBox
    Friend WithEvents btnNotification As Button
    Friend WithEvents btnDropdown As Button
    Friend WithEvents pnlWelcome As Panel
    Friend WithEvents lblWelcomeBack As Label
    Friend WithEvents picPets2 As PictureBox
End Class
