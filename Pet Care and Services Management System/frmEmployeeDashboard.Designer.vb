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
        pnlSummaryCards = New Panel()
        tlpSummaryCards = New TableLayoutPanel()
        pnlAppointments = New Panel()
        picAppointment = New PictureBox()
        lblAppointmentSubtitle = New Label()
        lblAppointmentCount = New Label()
        lblAppointmentTitle = New Label()
        pnlCustomers = New Panel()
        picCustomer = New PictureBox()
        lblCustomerSubtitle = New Label()
        lblCustomerCount = New Label()
        lblCustomerTitle = New Label()
        pnlPets = New Panel()
        picPets = New PictureBox()
        lblPetSubtitle = New Label()
        lblPetCount = New Label()
        lblPetTitle = New Label()
        pnlOrders = New Panel()
        picOrder = New PictureBox()
        lblOrderSubtitle = New Label()
        lblOrderCount = New Label()
        lblOrderTitle = New Label()
        pnlQuickActions = New Panel()
        PictureBox15 = New PictureBox()
        PictureBox14 = New PictureBox()
        PictureBox13 = New PictureBox()
        PictureBox12 = New PictureBox()
        btnAddService = New Button()
        btnAddPet = New Button()
        btnAddCustomer = New Button()
        btnNewAppointmnet = New Button()
        lblQuickActions = New Label()
        pnlRecentAppointments = New Panel()
        dgvRecentAppointments = New DataGridView()
        lblRecentTitle = New Label()
        pnlWelcome = New Panel()
        picPets2 = New PictureBox()
        lblWelcomeBack = New Label()
        pnlTopBar = New Panel()
        btnDropdown = New Button()
        lblEmployee = New Label()
        btnMenu = New Button()
        lblWelcome = New Label()
        picEmployee = New PictureBox()
        btnNotification = New Button()
        picPaw = New PictureBox()
        pnlSidebar = New Panel()
        PictureBox11 = New PictureBox()
        PictureBox10 = New PictureBox()
        PictureBox9 = New PictureBox()
        PictureBox8 = New PictureBox()
        PictureBox7 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        btnLogout = New Button()
        btnProducts = New Button()
        btnMembership = New Button()
        lblShopAndMembership = New Label()
        lblFacility = New Label()
        lblServices = New Label()
        btnBoardingVideos = New Button()
        btnBoardingRooms = New Button()
        btnBoardingServices = New Button()
        btnGroomingServices = New Button()
        btnPayments = New Button()
        btnOrders = New Button()
        btnBookings = New Button()
        btnPets = New Button()
        lblManagement = New Label()
        btnCustomers = New Button()
        btnDashboard = New Button()
        picLogo = New PictureBox()
        lblSidebarSubtitle = New Label()
        lblSidebarTitle = New Label()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        LogoutToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        ManagementToolStripMenuItem = New ToolStripMenuItem()
        CustomersToolStripMenuItem = New ToolStripMenuItem()
        PetsToolStripMenuItem = New ToolStripMenuItem()
        BookingsToolStripMenuItem = New ToolStripMenuItem()
        OrdersToolStripMenuItem = New ToolStripMenuItem()
        PaymentsToolStripMenuItem = New ToolStripMenuItem()
        ServicesToolStripMenuItem = New ToolStripMenuItem()
        GroomingServicesToolStripMenuItem = New ToolStripMenuItem()
        BoardingServicesToolStripMenuItem = New ToolStripMenuItem()
        ViewToolStripMenuItem = New ToolStripMenuItem()
        DashboardToolStripMenuItem = New ToolStripMenuItem()
        RefreshToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        UserGuideToolStripMenuItem = New ToolStripMenuItem()
        lblDashboardTitle = New Label()
        lblDescription = New Label()
        pnlMain.SuspendLayout()
        pnlSummaryCards.SuspendLayout()
        tlpSummaryCards.SuspendLayout()
        pnlAppointments.SuspendLayout()
        CType(picAppointment, ComponentModel.ISupportInitialize).BeginInit()
        pnlCustomers.SuspendLayout()
        CType(picCustomer, ComponentModel.ISupportInitialize).BeginInit()
        pnlPets.SuspendLayout()
        CType(picPets, ComponentModel.ISupportInitialize).BeginInit()
        pnlOrders.SuspendLayout()
        CType(picOrder, ComponentModel.ISupportInitialize).BeginInit()
        pnlQuickActions.SuspendLayout()
        CType(PictureBox15, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox14, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox13, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox12, ComponentModel.ISupportInitialize).BeginInit()
        pnlRecentAppointments.SuspendLayout()
        CType(dgvRecentAppointments, ComponentModel.ISupportInitialize).BeginInit()
        pnlWelcome.SuspendLayout()
        CType(picPets2, ComponentModel.ISupportInitialize).BeginInit()
        pnlTopBar.SuspendLayout()
        CType(picEmployee, ComponentModel.ISupportInitialize).BeginInit()
        CType(picPaw, ComponentModel.ISupportInitialize).BeginInit()
        pnlSidebar.SuspendLayout()
        CType(PictureBox11, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblDescription
        ' 
        lblDescription.AutoSize = True
        lblDescription.Font = New Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDescription.ForeColor = Color.FromArgb(CByte(61), CByte(40), CByte(27))
        lblDescription.Location = New Point(7, 87)
        lblDescription.Name = "lblDescription"
        lblDescription.Size = New Size(381, 74)
        lblDescription.TabIndex = 6
        lblDescription.Text = "Manage your pet care services " & vbCrLf & "easily and efficiently."
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(25, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 30)
        Label1.TabIndex = 0
        Label1.Text = "Label1"
        ' 
        ' pnlMain
        ' 
        pnlMain.BackColor = Color.FromArgb(CByte(250), CByte(240), CByte(222))
        pnlMain.Controls.Add(pnlSummaryCards)
        pnlMain.Controls.Add(pnlQuickActions)
        pnlMain.Controls.Add(pnlRecentAppointments)
        pnlMain.Controls.Add(pnlWelcome)
        pnlMain.Controls.Add(pnlTopBar)
        pnlMain.Controls.Add(pnlSidebar)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(0, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(1382, 901)
        pnlMain.TabIndex = 1
        ' 
        ' pnlSummaryCards
        ' 
        pnlSummaryCards.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlSummaryCards.Controls.Add(tlpSummaryCards)
        pnlSummaryCards.Location = New Point(292, 308)
        pnlSummaryCards.Name = "pnlSummaryCards"
        pnlSummaryCards.Size = New Size(1072, 163)
        pnlSummaryCards.TabIndex = 15
        ' 
        ' tlpSummaryCards
        ' 
        tlpSummaryCards.ColumnCount = 4
        tlpSummaryCards.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        tlpSummaryCards.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        tlpSummaryCards.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        tlpSummaryCards.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        tlpSummaryCards.Controls.Add(pnlAppointments, 2, 0)
        tlpSummaryCards.Controls.Add(pnlCustomers, 0, 0)
        tlpSummaryCards.Controls.Add(pnlPets, 1, 0)
        tlpSummaryCards.Controls.Add(pnlOrders, 3, 0)
        tlpSummaryCards.Dock = DockStyle.Fill
        tlpSummaryCards.Location = New Point(0, 0)
        tlpSummaryCards.Name = "tlpSummaryCards"
        tlpSummaryCards.RowCount = 1
        tlpSummaryCards.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tlpSummaryCards.Size = New Size(1072, 163)
        tlpSummaryCards.TabIndex = 16
        ' 
        ' pnlAppointments
        ' 
        pnlAppointments.BackColor = Color.FromArgb(CByte(255), CByte(247), CByte(229))
        pnlAppointments.Controls.Add(picAppointment)
        pnlAppointments.Controls.Add(lblAppointmentSubtitle)
        pnlAppointments.Controls.Add(lblAppointmentCount)
        pnlAppointments.Controls.Add(lblAppointmentTitle)
        pnlAppointments.Dock = DockStyle.Fill
        pnlAppointments.Location = New Point(541, 5)
        pnlAppointments.Margin = New Padding(5)
        pnlAppointments.Name = "pnlAppointments"
        pnlAppointments.Size = New Size(258, 153)
        pnlAppointments.TabIndex = 11
        ' 
        ' picAppointment
        ' 
        picAppointment.Image = CType(resources.GetObject("picAppointment.Image"), Image)
        picAppointment.Location = New Point(0, 38)
        picAppointment.Name = "picAppointment"
        picAppointment.Size = New Size(90, 90)
        picAppointment.SizeMode = PictureBoxSizeMode.Zoom
        picAppointment.TabIndex = 13
        picAppointment.TabStop = False
        ' 
        ' lblAppointmentSubtitle
        ' 
        lblAppointmentSubtitle.AutoSize = True
        lblAppointmentSubtitle.Location = New Point(91, 113)
        lblAppointmentSubtitle.Name = "lblAppointmentSubtitle"
        lblAppointmentSubtitle.Size = New Size(218, 30)
        lblAppointmentSubtitle.TabIndex = 10
        lblAppointmentSubtitle.Text = "Today's Appointments"
        ' 
        ' lblAppointmentCount
        ' 
        lblAppointmentCount.AutoSize = True
        lblAppointmentCount.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAppointmentCount.Location = New Point(96, 58)
        lblAppointmentCount.Name = "lblAppointmentCount"
        lblAppointmentCount.Size = New Size(38, 45)
        lblAppointmentCount.TabIndex = 9
        lblAppointmentCount.Text = "0"
        ' 
        ' lblAppointmentTitle
        ' 
        lblAppointmentTitle.AutoSize = True
        lblAppointmentTitle.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAppointmentTitle.ForeColor = Color.DarkKhaki
        lblAppointmentTitle.Location = New Point(96, 16)
        lblAppointmentTitle.Name = "lblAppointmentTitle"
        lblAppointmentTitle.Size = New Size(177, 32)
        lblAppointmentTitle.TabIndex = 8
        lblAppointmentTitle.Text = "Appointments"
        ' 
        ' pnlCustomers
        ' 
        pnlCustomers.BackColor = Color.FromArgb(CByte(244), CByte(248), CByte(232))
        pnlCustomers.Controls.Add(picCustomer)
        pnlCustomers.Controls.Add(lblCustomerSubtitle)
        pnlCustomers.Controls.Add(lblCustomerCount)
        pnlCustomers.Controls.Add(lblCustomerTitle)
        pnlCustomers.Dock = DockStyle.Fill
        pnlCustomers.Location = New Point(5, 5)
        pnlCustomers.Margin = New Padding(5)
        pnlCustomers.Name = "pnlCustomers"
        pnlCustomers.Padding = New Padding(5)
        pnlCustomers.Size = New Size(258, 153)
        pnlCustomers.TabIndex = 7
        ' 
        ' picCustomer
        ' 
        picCustomer.Image = CType(resources.GetObject("picCustomer.Image"), Image)
        picCustomer.Location = New Point(3, 41)
        picCustomer.Name = "picCustomer"
        picCustomer.Size = New Size(90, 90)
        picCustomer.SizeMode = PictureBoxSizeMode.Zoom
        picCustomer.TabIndex = 11
        picCustomer.TabStop = False
        ' 
        ' lblCustomerSubtitle
        ' 
        lblCustomerSubtitle.AutoSize = True
        lblCustomerSubtitle.Location = New Point(109, 116)
        lblCustomerSubtitle.Name = "lblCustomerSubtitle"
        lblCustomerSubtitle.Size = New Size(161, 30)
        lblCustomerSubtitle.TabIndex = 10
        lblCustomerSubtitle.Text = "Total Customers"
        ' 
        ' lblCustomerCount
        ' 
        lblCustomerCount.AutoSize = True
        lblCustomerCount.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCustomerCount.Location = New Point(109, 61)
        lblCustomerCount.Name = "lblCustomerCount"
        lblCustomerCount.Size = New Size(38, 45)
        lblCustomerCount.TabIndex = 9
        lblCustomerCount.Text = "0"
        ' 
        ' lblCustomerTitle
        ' 
        lblCustomerTitle.AutoSize = True
        lblCustomerTitle.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCustomerTitle.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        lblCustomerTitle.Location = New Point(109, 19)
        lblCustomerTitle.Name = "lblCustomerTitle"
        lblCustomerTitle.Size = New Size(135, 32)
        lblCustomerTitle.TabIndex = 8
        lblCustomerTitle.Text = "Customers"
        ' 
        ' pnlPets
        ' 
        pnlPets.BackColor = Color.FromArgb(CByte(240), CByte(245), CByte(252))
        pnlPets.Controls.Add(picPets)
        pnlPets.Controls.Add(lblPetSubtitle)
        pnlPets.Controls.Add(lblPetCount)
        pnlPets.Controls.Add(lblPetTitle)
        pnlPets.Dock = DockStyle.Fill
        pnlPets.Location = New Point(273, 5)
        pnlPets.Margin = New Padding(5)
        pnlPets.Name = "pnlPets"
        pnlPets.Size = New Size(258, 153)
        pnlPets.TabIndex = 11
        ' 
        ' picPets
        ' 
        picPets.Image = CType(resources.GetObject("picPets.Image"), Image)
        picPets.Location = New Point(8, 41)
        picPets.Name = "picPets"
        picPets.Size = New Size(90, 90)
        picPets.SizeMode = PictureBoxSizeMode.Zoom
        picPets.TabIndex = 12
        picPets.TabStop = False
        ' 
        ' lblPetSubtitle
        ' 
        lblPetSubtitle.AutoSize = True
        lblPetSubtitle.Location = New Point(104, 111)
        lblPetSubtitle.Name = "lblPetSubtitle"
        lblPetSubtitle.Size = New Size(101, 30)
        lblPetSubtitle.TabIndex = 10
        lblPetSubtitle.Text = "Total Pets"
        ' 
        ' lblPetCount
        ' 
        lblPetCount.AutoSize = True
        lblPetCount.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPetCount.Location = New Point(104, 56)
        lblPetCount.Name = "lblPetCount"
        lblPetCount.Size = New Size(38, 45)
        lblPetCount.TabIndex = 9
        lblPetCount.Text = "0"
        ' 
        ' lblPetTitle
        ' 
        lblPetTitle.AutoSize = True
        lblPetTitle.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPetTitle.ForeColor = Color.RoyalBlue
        lblPetTitle.Location = New Point(104, 14)
        lblPetTitle.Name = "lblPetTitle"
        lblPetTitle.Size = New Size(61, 32)
        lblPetTitle.TabIndex = 8
        lblPetTitle.Text = "Pets"
        ' 
        ' pnlOrders
        ' 
        pnlOrders.BackColor = Color.FromArgb(CByte(248), CByte(240), CByte(248))
        pnlOrders.Controls.Add(picOrder)
        pnlOrders.Controls.Add(lblOrderSubtitle)
        pnlOrders.Controls.Add(lblOrderCount)
        pnlOrders.Controls.Add(lblOrderTitle)
        pnlOrders.Dock = DockStyle.Fill
        pnlOrders.Location = New Point(809, 5)
        pnlOrders.Margin = New Padding(5)
        pnlOrders.Name = "pnlOrders"
        pnlOrders.Size = New Size(258, 153)
        pnlOrders.TabIndex = 12
        ' 
        ' picOrder
        ' 
        picOrder.Image = CType(resources.GetObject("picOrder.Image"), Image)
        picOrder.Location = New Point(8, 41)
        picOrder.Name = "picOrder"
        picOrder.Size = New Size(90, 90)
        picOrder.SizeMode = PictureBoxSizeMode.Zoom
        picOrder.TabIndex = 14
        picOrder.TabStop = False
        ' 
        ' lblOrderSubtitle
        ' 
        lblOrderSubtitle.AutoSize = True
        lblOrderSubtitle.Location = New Point(104, 111)
        lblOrderSubtitle.Name = "lblOrderSubtitle"
        lblOrderSubtitle.Size = New Size(156, 30)
        lblOrderSubtitle.TabIndex = 10
        lblOrderSubtitle.Text = "Pending Orders"
        ' 
        ' lblOrderCount
        ' 
        lblOrderCount.AutoSize = True
        lblOrderCount.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblOrderCount.Location = New Point(104, 56)
        lblOrderCount.Name = "lblOrderCount"
        lblOrderCount.Size = New Size(38, 45)
        lblOrderCount.TabIndex = 9
        lblOrderCount.Text = "0"
        ' 
        ' lblOrderTitle
        ' 
        lblOrderTitle.AutoSize = True
        lblOrderTitle.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblOrderTitle.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        lblOrderTitle.Location = New Point(104, 14)
        lblOrderTitle.Name = "lblOrderTitle"
        lblOrderTitle.Size = New Size(91, 32)
        lblOrderTitle.TabIndex = 8
        lblOrderTitle.Text = "Orders"
        ' 
        ' pnlQuickActions
        ' 
        pnlQuickActions.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        pnlQuickActions.BackColor = Color.Cornsilk
        pnlQuickActions.BorderStyle = BorderStyle.FixedSingle
        pnlQuickActions.Controls.Add(PictureBox15)
        pnlQuickActions.Controls.Add(PictureBox14)
        pnlQuickActions.Controls.Add(PictureBox13)
        pnlQuickActions.Controls.Add(PictureBox12)
        pnlQuickActions.Controls.Add(btnAddService)
        pnlQuickActions.Controls.Add(btnAddPet)
        pnlQuickActions.Controls.Add(btnAddCustomer)
        pnlQuickActions.Controls.Add(btnNewAppointmnet)
        pnlQuickActions.Controls.Add(lblQuickActions)
        pnlQuickActions.Location = New Point(1061, 495)
        pnlQuickActions.Name = "pnlQuickActions"
        pnlQuickActions.Size = New Size(298, 395)
        pnlQuickActions.TabIndex = 14
        ' 
        ' PictureBox15
        ' 
        PictureBox15.Image = CType(resources.GetObject("PictureBox15.Image"), Image)
        PictureBox15.Location = New Point(5, 311)
        PictureBox15.Name = "PictureBox15"
        PictureBox15.Size = New Size(44, 44)
        PictureBox15.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox15.TabIndex = 8
        PictureBox15.TabStop = False
        ' 
        ' PictureBox14
        ' 
        PictureBox14.Image = CType(resources.GetObject("PictureBox14.Image"), Image)
        PictureBox14.Location = New Point(5, 233)
        PictureBox14.Name = "PictureBox14"
        PictureBox14.Size = New Size(44, 44)
        PictureBox14.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox14.TabIndex = 7
        PictureBox14.TabStop = False
        ' 
        ' PictureBox13
        ' 
        PictureBox13.Image = CType(resources.GetObject("PictureBox13.Image"), Image)
        PictureBox13.Location = New Point(5, 155)
        PictureBox13.Name = "PictureBox13"
        PictureBox13.Size = New Size(44, 44)
        PictureBox13.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox13.TabIndex = 6
        PictureBox13.TabStop = False
        ' 
        ' PictureBox12
        ' 
        PictureBox12.Image = CType(resources.GetObject("PictureBox12.Image"), Image)
        PictureBox12.Location = New Point(5, 79)
        PictureBox12.Name = "PictureBox12"
        PictureBox12.Size = New Size(44, 44)
        PictureBox12.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox12.TabIndex = 5
        PictureBox12.TabStop = False
        ' 
        ' btnAddService
        ' 
        btnAddService.BackColor = Color.FromArgb(CByte(248), CByte(240), CByte(248))
        btnAddService.FlatStyle = FlatStyle.Flat
        btnAddService.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddService.Location = New Point(61, 311)
        btnAddService.Name = "btnAddService"
        btnAddService.Size = New Size(221, 44)
        btnAddService.TabIndex = 4
        btnAddService.Text = "＋ Add Service"
        btnAddService.UseVisualStyleBackColor = False
        ' 
        ' btnAddPet
        ' 
        btnAddPet.BackColor = Color.Khaki
        btnAddPet.FlatStyle = FlatStyle.Flat
        btnAddPet.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddPet.Location = New Point(61, 233)
        btnAddPet.Name = "btnAddPet"
        btnAddPet.Size = New Size(221, 44)
        btnAddPet.TabIndex = 3
        btnAddPet.Text = "＋ Add Pet"
        btnAddPet.UseVisualStyleBackColor = False
        ' 
        ' btnAddCustomer
        ' 
        btnAddCustomer.BackColor = Color.FromArgb(CByte(240), CByte(245), CByte(252))
        btnAddCustomer.FlatStyle = FlatStyle.Flat
        btnAddCustomer.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddCustomer.Location = New Point(61, 155)
        btnAddCustomer.Name = "btnAddCustomer"
        btnAddCustomer.Size = New Size(221, 44)
        btnAddCustomer.TabIndex = 2
        btnAddCustomer.Text = "＋ Add Customer"
        btnAddCustomer.UseVisualStyleBackColor = False
        ' 
        ' btnNewAppointmnet
        ' 
        btnNewAppointmnet.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnNewAppointmnet.BackColor = Color.PaleGreen
        btnNewAppointmnet.FlatStyle = FlatStyle.Flat
        btnNewAppointmnet.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnNewAppointmnet.Location = New Point(61, 79)
        btnNewAppointmnet.Name = "btnNewAppointmnet"
        btnNewAppointmnet.Size = New Size(221, 44)
        btnNewAppointmnet.TabIndex = 1
        btnNewAppointmnet.Text = "＋ New Appointment"
        btnNewAppointmnet.UseVisualStyleBackColor = False
        ' 
        ' lblQuickActions
        ' 
        lblQuickActions.AutoSize = True
        lblQuickActions.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblQuickActions.Location = New Point(5, 11)
        lblQuickActions.Name = "lblQuickActions"
        lblQuickActions.Size = New Size(245, 38)
        lblQuickActions.TabIndex = 0
        lblQuickActions.Text = "⚡ Quick Actions"
        ' 
        ' pnlRecentAppointments
        ' 
        pnlRecentAppointments.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlRecentAppointments.BackColor = Color.Bisque
        pnlRecentAppointments.BorderStyle = BorderStyle.FixedSingle
        pnlRecentAppointments.Controls.Add(dgvRecentAppointments)
        pnlRecentAppointments.Controls.Add(lblRecentTitle)
        pnlRecentAppointments.Location = New Point(309, 495)
        pnlRecentAppointments.Name = "pnlRecentAppointments"
        pnlRecentAppointments.Size = New Size(748, 397)
        pnlRecentAppointments.TabIndex = 13
        ' 
        ' dgvRecentAppointments
        ' 
        dgvRecentAppointments.AllowUserToAddRows = False
        dgvRecentAppointments.AllowUserToDeleteRows = False
        dgvRecentAppointments.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvRecentAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRecentAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRecentAppointments.Location = New Point(26, 60)
        dgvRecentAppointments.MultiSelect = False
        dgvRecentAppointments.Name = "dgvRecentAppointments"
        dgvRecentAppointments.ReadOnly = True
        dgvRecentAppointments.RowHeadersVisible = False
        dgvRecentAppointments.RowHeadersWidth = 51
        dgvRecentAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRecentAppointments.Size = New Size(695, 320)
        dgvRecentAppointments.TabIndex = 1
        ' 
        ' lblRecentTitle
        ' 
        lblRecentTitle.AutoSize = True
        lblRecentTitle.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRecentTitle.Location = New Point(17, 11)
        lblRecentTitle.Name = "lblRecentTitle"
        lblRecentTitle.Size = New Size(356, 38)
        lblRecentTitle.TabIndex = 0
        lblRecentTitle.Text = "📅  Recent Appointments"
        ' 
        ' pnlWelcome
        ' 
        pnlWelcome.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlWelcome.BackColor = Color.FromArgb(CByte(252), CByte(235), CByte(213))
        pnlWelcome.Controls.Add(picPets2)
        pnlWelcome.Controls.Add(lblDescription)
        pnlWelcome.Controls.Add(lblWelcomeBack)
        pnlWelcome.Location = New Point(308, 132)
        pnlWelcome.Margin = New Padding(0)
        pnlWelcome.Name = "pnlWelcome"
        pnlWelcome.Size = New Size(1055, 164)
        pnlWelcome.TabIndex = 5
        ' 
        ' picPets2
        ' 
        picPets2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        picPets2.BackColor = Color.Transparent
        picPets2.ErrorImage = Nothing
        picPets2.Image = CType(resources.GetObject("picPets2.Image"), Image)
        picPets2.Location = New Point(400, 0)
        picPets2.Name = "picPets2"
        picPets2.Size = New Size(655, 168)
        picPets2.SizeMode = PictureBoxSizeMode.Zoom
        picPets2.TabIndex = 8
        picPets2.TabStop = False
        ' 
        ' lblWelcomeBack
        ' 
        lblWelcomeBack.AutoEllipsis = True
        lblWelcomeBack.AutoSize = True
        lblWelcomeBack.Font = New Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblWelcomeBack.ForeColor = Color.FromArgb(CByte(61), CByte(40), CByte(27))
        lblWelcomeBack.Location = New Point(3, 9)
        lblWelcomeBack.Name = "lblWelcomeBack"
        lblWelcomeBack.Size = New Size(486, 70)
        lblWelcomeBack.TabIndex = 7
        lblWelcomeBack.Text = "Welcome back! 👋"
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
        pnlTopBar.Size = New Size(1102, 124)
        pnlTopBar.TabIndex = 4
        ' 
        ' btnDropdown
        ' 
        btnDropdown.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnDropdown.FlatAppearance.BorderSize = 0
        btnDropdown.FlatStyle = FlatStyle.Flat
        btnDropdown.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDropdown.Location = New Point(1053, 61)
        btnDropdown.Name = "btnDropdown"
        btnDropdown.Size = New Size(35, 35)
        btnDropdown.TabIndex = 5
        btnDropdown.Text = "˅"
        btnDropdown.UseVisualStyleBackColor = True
        ' 
        ' lblEmployee
        ' 
        lblEmployee.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblEmployee.AutoEllipsis = True
        lblEmployee.AutoSize = True
        lblEmployee.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEmployee.ForeColor = Color.FromArgb(CByte(61), CByte(40), CByte(27))
        lblEmployee.Location = New Point(943, 65)
        lblEmployee.Name = "lblEmployee"
        lblEmployee.Size = New Size(145, 38)
        lblEmployee.TabIndex = 6
        lblEmployee.Text = "Employee"
        ' 
        ' btnMenu
        ' 
        btnMenu.FlatAppearance.BorderSize = 0
        btnMenu.FlatStyle = FlatStyle.Flat
        btnMenu.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnMenu.Location = New Point(12, 50)
        btnMenu.Name = "btnMenu"
        btnMenu.Size = New Size(54, 45)
        btnMenu.TabIndex = 2
        btnMenu.Text = "☰"
        btnMenu.UseVisualStyleBackColor = True
        ' 
        ' lblWelcome
        ' 
        lblWelcome.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblWelcome.AutoEllipsis = True
        lblWelcome.AutoSize = True
        lblWelcome.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblWelcome.ForeColor = Color.FromArgb(CByte(107), CByte(98), CByte(91))
        lblWelcome.Location = New Point(943, 42)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(104, 30)
        lblWelcome.TabIndex = 5
        lblWelcome.Text = "Welcome,"
        ' 
        ' picEmployee
        ' 
        picEmployee.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        picEmployee.Image = CType(resources.GetObject("picEmployee.Image"), Image)
        picEmployee.Location = New Point(872, 35)
        picEmployee.Name = "picEmployee"
        picEmployee.Size = New Size(65, 65)
        picEmployee.SizeMode = PictureBoxSizeMode.Zoom
        picEmployee.TabIndex = 5
        picEmployee.TabStop = False
        ' 
        ' btnNotification
        ' 
        btnNotification.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnNotification.FlatAppearance.BorderSize = 0
        btnNotification.FlatStyle = FlatStyle.Flat
        btnNotification.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnNotification.Location = New Point(803, 42)
        btnNotification.Name = "btnNotification"
        btnNotification.Size = New Size(54, 45)
        btnNotification.TabIndex = 4
        btnNotification.Text = "🔔"
        btnNotification.UseVisualStyleBackColor = True
        ' 
        ' picPaw
        ' 
        picPaw.Image = CType(resources.GetObject("picPaw.Image"), Image)
        picPaw.Location = New Point(628, 35)
        picPaw.Name = "picPaw"
        picPaw.Size = New Size(63, 69)
        picPaw.SizeMode = PictureBoxSizeMode.Zoom
        picPaw.TabIndex = 3
        picPaw.TabStop = False
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.FromArgb(CByte(74), CByte(44), CByte(26))
        pnlSidebar.Controls.Add(PictureBox11)
        pnlSidebar.Controls.Add(PictureBox10)
        pnlSidebar.Controls.Add(PictureBox9)
        pnlSidebar.Controls.Add(PictureBox8)
        pnlSidebar.Controls.Add(PictureBox7)
        pnlSidebar.Controls.Add(PictureBox6)
        pnlSidebar.Controls.Add(PictureBox5)
        pnlSidebar.Controls.Add(PictureBox4)
        pnlSidebar.Controls.Add(PictureBox3)
        pnlSidebar.Controls.Add(PictureBox2)
        pnlSidebar.Controls.Add(PictureBox1)
        pnlSidebar.Controls.Add(btnLogout)
        pnlSidebar.Controls.Add(btnProducts)
        pnlSidebar.Controls.Add(btnMembership)
        pnlSidebar.Controls.Add(lblShopAndMembership)
        pnlSidebar.Controls.Add(lblFacility)
        pnlSidebar.Controls.Add(lblServices)
        pnlSidebar.Controls.Add(btnBoardingVideos)
        pnlSidebar.Controls.Add(btnBoardingRooms)
        pnlSidebar.Controls.Add(btnBoardingServices)
        pnlSidebar.Controls.Add(btnGroomingServices)
        pnlSidebar.Controls.Add(btnPayments)
        pnlSidebar.Controls.Add(btnOrders)
        pnlSidebar.Controls.Add(btnBookings)
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
        pnlSidebar.Size = New Size(280, 901)
        pnlSidebar.TabIndex = 0
        ' 
        ' PictureBox11
        ' 
        PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), Image)
        PictureBox11.Location = New Point(8, 766)
        PictureBox11.Name = "PictureBox11"
        PictureBox11.Size = New Size(43, 40)
        PictureBox11.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox11.TabIndex = 38
        PictureBox11.TabStop = False
        ' 
        ' PictureBox10
        ' 
        PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), Image)
        PictureBox10.Location = New Point(8, 720)
        PictureBox10.Name = "PictureBox10"
        PictureBox10.Size = New Size(43, 40)
        PictureBox10.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox10.TabIndex = 37
        PictureBox10.TabStop = False
        ' 
        ' PictureBox9
        ' 
        PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), Image)
        PictureBox9.Location = New Point(8, 642)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(43, 40)
        PictureBox9.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox9.TabIndex = 36
        PictureBox9.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), Image)
        PictureBox8.Location = New Point(8, 596)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(43, 40)
        PictureBox8.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox8.TabIndex = 35
        PictureBox8.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(8, 521)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(43, 40)
        PictureBox7.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox7.TabIndex = 34
        PictureBox7.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(8, 475)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(43, 40)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 33
        PictureBox6.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(8, 401)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(43, 40)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 32
        PictureBox5.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(8, 355)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(43, 40)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 31
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(8, 309)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(43, 40)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 30
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(8, 263)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(43, 40)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 29
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(8, 219)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(43, 40)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 28
        PictureBox1.TabStop = False
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.FromArgb(CByte(196), CByte(106), CByte(43))
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogout.ForeColor = Color.White
        btnLogout.Location = New Point(19, 848)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(212, 41)
        btnLogout.TabIndex = 27
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnProducts
        ' 
        btnProducts.FlatAppearance.BorderSize = 0
        btnProducts.FlatStyle = FlatStyle.Flat
        btnProducts.ForeColor = SystemColors.Control
        btnProducts.Location = New Point(57, 720)
        btnProducts.Name = "btnProducts"
        btnProducts.Size = New Size(210, 40)
        btnProducts.TabIndex = 26
        btnProducts.Text = "Products"
        btnProducts.TextAlign = ContentAlignment.MiddleLeft
        btnProducts.UseVisualStyleBackColor = True
        ' 
        ' btnMembership
        ' 
        btnMembership.FlatAppearance.BorderSize = 0
        btnMembership.FlatStyle = FlatStyle.Flat
        btnMembership.ForeColor = SystemColors.Control
        btnMembership.Location = New Point(57, 766)
        btnMembership.Name = "btnMembership"
        btnMembership.Size = New Size(210, 40)
        btnMembership.TabIndex = 25
        btnMembership.Text = "Membership"
        btnMembership.TextAlign = ContentAlignment.MiddleLeft
        btnMembership.UseVisualStyleBackColor = True
        ' 
        ' lblShopAndMembership
        ' 
        lblShopAndMembership.AutoSize = True
        lblShopAndMembership.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblShopAndMembership.ForeColor = Color.FromArgb(CByte(221), CByte(184), CByte(146))
        lblShopAndMembership.Location = New Point(19, 700)
        lblShopAndMembership.Name = "lblShopAndMembership"
        lblShopAndMembership.Size = New Size(201, 21)
        lblShopAndMembership.TabIndex = 24
        lblShopAndMembership.Text = "SHOP AND MEMBERSHIP"
        ' 
        ' lblFacility
        ' 
        lblFacility.AutoSize = True
        lblFacility.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFacility.ForeColor = Color.FromArgb(CByte(221), CByte(184), CByte(146))
        lblFacility.Location = New Point(19, 576)
        lblFacility.Name = "lblFacility"
        lblFacility.Size = New Size(75, 21)
        lblFacility.TabIndex = 23
        lblFacility.Text = "FACILITY"
        ' 
        ' lblServices
        ' 
        lblServices.AutoSize = True
        lblServices.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblServices.ForeColor = Color.FromArgb(CByte(221), CByte(184), CByte(146))
        lblServices.Location = New Point(19, 455)
        lblServices.Name = "lblServices"
        lblServices.Size = New Size(82, 21)
        lblServices.TabIndex = 22
        lblServices.Text = "SERVICES"
        ' 
        ' btnBoardingVideos
        ' 
        btnBoardingVideos.FlatAppearance.BorderSize = 0
        btnBoardingVideos.FlatStyle = FlatStyle.Flat
        btnBoardingVideos.ForeColor = SystemColors.Control
        btnBoardingVideos.Location = New Point(57, 642)
        btnBoardingVideos.Name = "btnBoardingVideos"
        btnBoardingVideos.Size = New Size(210, 40)
        btnBoardingVideos.TabIndex = 21
        btnBoardingVideos.Text = "Boarding Videos"
        btnBoardingVideos.TextAlign = ContentAlignment.MiddleLeft
        btnBoardingVideos.UseVisualStyleBackColor = True
        ' 
        ' btnBoardingRooms
        ' 
        btnBoardingRooms.FlatAppearance.BorderSize = 0
        btnBoardingRooms.FlatStyle = FlatStyle.Flat
        btnBoardingRooms.ForeColor = SystemColors.Control
        btnBoardingRooms.Location = New Point(57, 596)
        btnBoardingRooms.Name = "btnBoardingRooms"
        btnBoardingRooms.Size = New Size(210, 40)
        btnBoardingRooms.TabIndex = 20
        btnBoardingRooms.Text = "Boarding Rooms"
        btnBoardingRooms.TextAlign = ContentAlignment.MiddleLeft
        btnBoardingRooms.UseVisualStyleBackColor = True
        ' 
        ' btnBoardingServices
        ' 
        btnBoardingServices.FlatAppearance.BorderSize = 0
        btnBoardingServices.FlatStyle = FlatStyle.Flat
        btnBoardingServices.ForeColor = SystemColors.Control
        btnBoardingServices.Location = New Point(57, 521)
        btnBoardingServices.Name = "btnBoardingServices"
        btnBoardingServices.Size = New Size(210, 40)
        btnBoardingServices.TabIndex = 19
        btnBoardingServices.Text = "Boarding Services"
        btnBoardingServices.TextAlign = ContentAlignment.MiddleLeft
        btnBoardingServices.UseVisualStyleBackColor = True
        ' 
        ' btnGroomingServices
        ' 
        btnGroomingServices.FlatAppearance.BorderSize = 0
        btnGroomingServices.FlatStyle = FlatStyle.Flat
        btnGroomingServices.ForeColor = SystemColors.Control
        btnGroomingServices.Location = New Point(57, 475)
        btnGroomingServices.Name = "btnGroomingServices"
        btnGroomingServices.Size = New Size(210, 40)
        btnGroomingServices.TabIndex = 18
        btnGroomingServices.Text = "Grooming Services"
        btnGroomingServices.TextAlign = ContentAlignment.MiddleLeft
        btnGroomingServices.UseVisualStyleBackColor = True
        ' 
        ' btnPayments
        ' 
        btnPayments.FlatAppearance.BorderSize = 0
        btnPayments.FlatStyle = FlatStyle.Flat
        btnPayments.ForeColor = SystemColors.Control
        btnPayments.Location = New Point(57, 401)
        btnPayments.Name = "btnPayments"
        btnPayments.Size = New Size(210, 40)
        btnPayments.TabIndex = 17
        btnPayments.Text = "Payments"
        btnPayments.TextAlign = ContentAlignment.MiddleLeft
        btnPayments.UseVisualStyleBackColor = True
        ' 
        ' btnOrders
        ' 
        btnOrders.FlatAppearance.BorderSize = 0
        btnOrders.FlatStyle = FlatStyle.Flat
        btnOrders.ForeColor = SystemColors.Control
        btnOrders.Location = New Point(57, 355)
        btnOrders.Name = "btnOrders"
        btnOrders.Size = New Size(210, 40)
        btnOrders.TabIndex = 16
        btnOrders.Text = "Orders"
        btnOrders.TextAlign = ContentAlignment.MiddleLeft
        btnOrders.UseVisualStyleBackColor = True
        ' 
        ' btnBookings
        ' 
        btnBookings.FlatAppearance.BorderSize = 0
        btnBookings.FlatStyle = FlatStyle.Flat
        btnBookings.ForeColor = SystemColors.Control
        btnBookings.Location = New Point(57, 309)
        btnBookings.Name = "btnBookings"
        btnBookings.Size = New Size(210, 40)
        btnBookings.TabIndex = 14
        btnBookings.Text = "Bookings"
        btnBookings.TextAlign = ContentAlignment.MiddleLeft
        btnBookings.UseVisualStyleBackColor = True
        ' 
        ' btnPets
        ' 
        btnPets.FlatAppearance.BorderSize = 0
        btnPets.FlatStyle = FlatStyle.Flat
        btnPets.ForeColor = SystemColors.Control
        btnPets.Location = New Point(57, 263)
        btnPets.Name = "btnPets"
        btnPets.Size = New Size(210, 40)
        btnPets.TabIndex = 13
        btnPets.Text = "Pets"
        btnPets.TextAlign = ContentAlignment.MiddleLeft
        btnPets.UseVisualStyleBackColor = True
        ' 
        ' lblManagement
        ' 
        lblManagement.AutoSize = True
        lblManagement.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblManagement.ForeColor = Color.FromArgb(CByte(221), CByte(184), CByte(146))
        lblManagement.Location = New Point(19, 194)
        lblManagement.Name = "lblManagement"
        lblManagement.Size = New Size(126, 21)
        lblManagement.TabIndex = 12
        lblManagement.Text = "MANAGEMENT"
        ' 
        ' btnCustomers
        ' 
        btnCustomers.FlatAppearance.BorderSize = 0
        btnCustomers.FlatStyle = FlatStyle.Flat
        btnCustomers.ForeColor = SystemColors.Control
        btnCustomers.Location = New Point(57, 217)
        btnCustomers.Name = "btnCustomers"
        btnCustomers.Size = New Size(210, 40)
        btnCustomers.TabIndex = 4
        btnCustomers.Text = "Customers"
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
        btnDashboard.Location = New Point(11, 141)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(220, 45)
        btnDashboard.TabIndex = 3
        btnDashboard.Text = "Dashboard"
        btnDashboard.UseVisualStyleBackColor = False
        ' 
        ' picLogo
        ' 
        picLogo.BackColor = Color.Transparent
        picLogo.Image = CType(resources.GetObject("picLogo.Image"), Image)
        picLogo.Location = New Point(1, 39)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(92, 85)
        picLogo.SizeMode = PictureBoxSizeMode.Zoom
        picLogo.TabIndex = 2
        picLogo.TabStop = False
        ' 
        ' lblSidebarSubtitle
        ' 
        lblSidebarSubtitle.AutoSize = True
        lblSidebarSubtitle.ForeColor = Color.FromArgb(CByte(245), CByte(230), CByte(209))
        lblSidebarSubtitle.Location = New Point(99, 104)
        lblSidebarSubtitle.Name = "lblSidebarSubtitle"
        lblSidebarSubtitle.Size = New Size(239, 30)
        lblSidebarSubtitle.TabIndex = 1
        lblSidebarSubtitle.Text = "MANAGEMENT SYSTEM"
        lblSidebarSubtitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblSidebarTitle
        ' 
        lblSidebarTitle.AutoSize = True
        lblSidebarTitle.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSidebarTitle.ForeColor = Color.White
        lblSidebarTitle.Location = New Point(99, 39)
        lblSidebarTitle.Name = "lblSidebarTitle"
        lblSidebarTitle.Size = New Size(182, 64)
        lblSidebarTitle.TabIndex = 0
        lblSidebarTitle.Text = "PET CARE " & vbCrLf & "AND SERVICES"
        lblSidebarTitle.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, ManagementToolStripMenuItem, ServicesToolStripMenuItem, ViewToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1382, 38)
        MenuStrip1.TabIndex = 40
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LogoutToolStripMenuItem, ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(60, 34)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' LogoutToolStripMenuItem
        ' 
        LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        LogoutToolStripMenuItem.Size = New Size(181, 38)
        LogoutToolStripMenuItem.Text = "Logout"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(181, 38)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' ManagementToolStripMenuItem
        ' 
        ManagementToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CustomersToolStripMenuItem, PetsToolStripMenuItem, BookingsToolStripMenuItem, OrdersToolStripMenuItem, PaymentsToolStripMenuItem})
        ManagementToolStripMenuItem.Name = "ManagementToolStripMenuItem"
        ManagementToolStripMenuItem.Size = New Size(153, 34)
        ManagementToolStripMenuItem.Text = "Management"
        ' 
        ' CustomersToolStripMenuItem
        ' 
        CustomersToolStripMenuItem.Name = "CustomersToolStripMenuItem"
        CustomersToolStripMenuItem.Size = New Size(214, 38)
        CustomersToolStripMenuItem.Text = "Customers"
        ' 
        ' PetsToolStripMenuItem
        ' 
        PetsToolStripMenuItem.Name = "PetsToolStripMenuItem"
        PetsToolStripMenuItem.Size = New Size(214, 38)
        PetsToolStripMenuItem.Text = "Pets"
        ' 
        ' BookingsToolStripMenuItem
        ' 
        BookingsToolStripMenuItem.Name = "BookingsToolStripMenuItem"
        BookingsToolStripMenuItem.Size = New Size(214, 38)
        BookingsToolStripMenuItem.Text = "Bookings"
        ' 
        ' OrdersToolStripMenuItem
        ' 
        OrdersToolStripMenuItem.Name = "OrdersToolStripMenuItem"
        OrdersToolStripMenuItem.Size = New Size(214, 38)
        OrdersToolStripMenuItem.Text = "Orders"
        ' 
        ' PaymentsToolStripMenuItem
        ' 
        PaymentsToolStripMenuItem.Name = "PaymentsToolStripMenuItem"
        PaymentsToolStripMenuItem.Size = New Size(214, 38)
        PaymentsToolStripMenuItem.Text = "Payments"
        ' 
        ' ServicesToolStripMenuItem
        ' 
        ServicesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {GroomingServicesToolStripMenuItem, BoardingServicesToolStripMenuItem})
        ServicesToolStripMenuItem.Name = "ServicesToolStripMenuItem"
        ServicesToolStripMenuItem.Size = New Size(103, 34)
        ServicesToolStripMenuItem.Text = "Services"
        ' 
        ' GroomingServicesToolStripMenuItem
        ' 
        GroomingServicesToolStripMenuItem.Name = "GroomingServicesToolStripMenuItem"
        GroomingServicesToolStripMenuItem.Size = New Size(288, 38)
        GroomingServicesToolStripMenuItem.Text = "Grooming Services"
        ' 
        ' BoardingServicesToolStripMenuItem
        ' 
        BoardingServicesToolStripMenuItem.Name = "BoardingServicesToolStripMenuItem"
        BoardingServicesToolStripMenuItem.Size = New Size(288, 38)
        BoardingServicesToolStripMenuItem.Text = "Boarding Services"
        ' 
        ' ViewToolStripMenuItem
        ' 
        ViewToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {DashboardToolStripMenuItem, RefreshToolStripMenuItem})
        ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        ViewToolStripMenuItem.Size = New Size(73, 34)
        ViewToolStripMenuItem.Text = "View"
        ' 
        ' DashboardToolStripMenuItem
        ' 
        DashboardToolStripMenuItem.Name = "DashboardToolStripMenuItem"
        DashboardToolStripMenuItem.Size = New Size(217, 38)
        DashboardToolStripMenuItem.Text = "Dashboard"
        ' 
        ' RefreshToolStripMenuItem
        ' 
        RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        RefreshToolStripMenuItem.Size = New Size(217, 38)
        RefreshToolStripMenuItem.Text = "Refresh"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AboutToolStripMenuItem, UserGuideToolStripMenuItem})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(72, 34)
        HelpToolStripMenuItem.Text = "Help"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(217, 38)
        AboutToolStripMenuItem.Text = "About "
        ' 
        ' UserGuideToolStripMenuItem
        ' 
        UserGuideToolStripMenuItem.Name = "UserGuideToolStripMenuItem"
        UserGuideToolStripMenuItem.Size = New Size(217, 38)
        UserGuideToolStripMenuItem.Text = "User Guide"
        ' 
        ' lblDashboardTitle
        ' 
        lblDashboardTitle.AutoSize = True
        lblDashboardTitle.Font = New Font("Georgia", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDashboardTitle.Location = New Point(63, 50)
        lblDashboardTitle.Name = "lblDashboardTitle"
        lblDashboardTitle.Size = New Size(671, 56)
        lblDashboardTitle.TabIndex = 1
        lblDashboardTitle.Text = "EMPLOYEE DASHBOARD"
        ' 
        ' frmEmployeeDashboard
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(245), CByte(230), CByte(209))
        ClientSize = New Size(1382, 901)
        Controls.Add(MenuStrip1)
        Controls.Add(pnlMain)
        Controls.Add(Label1)
        Name = "frmEmployeeDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pet Care and Services Management System"
        pnlMain.ResumeLayout(False)
        pnlSummaryCards.ResumeLayout(False)
        tlpSummaryCards.ResumeLayout(False)
        pnlAppointments.ResumeLayout(False)
        pnlAppointments.PerformLayout()
        CType(picAppointment, ComponentModel.ISupportInitialize).EndInit()
        pnlCustomers.ResumeLayout(False)
        pnlCustomers.PerformLayout()
        CType(picCustomer, ComponentModel.ISupportInitialize).EndInit()
        pnlPets.ResumeLayout(False)
        pnlPets.PerformLayout()
        CType(picPets, ComponentModel.ISupportInitialize).EndInit()
        pnlOrders.ResumeLayout(False)
        pnlOrders.PerformLayout()
        CType(picOrder, ComponentModel.ISupportInitialize).EndInit()
        pnlQuickActions.ResumeLayout(False)
        pnlQuickActions.PerformLayout()
        CType(PictureBox15, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox14, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox13, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox12, ComponentModel.ISupportInitialize).EndInit()
        pnlRecentAppointments.ResumeLayout(False)
        pnlRecentAppointments.PerformLayout()
        CType(dgvRecentAppointments, ComponentModel.ISupportInitialize).EndInit()
        pnlWelcome.ResumeLayout(False)
        pnlWelcome.PerformLayout()
        CType(picPets2, ComponentModel.ISupportInitialize).EndInit()
        pnlTopBar.ResumeLayout(False)
        pnlTopBar.PerformLayout()
        CType(picEmployee, ComponentModel.ISupportInitialize).EndInit()
        CType(picPaw, ComponentModel.ISupportInitialize).EndInit()
        pnlSidebar.ResumeLayout(False)
        pnlSidebar.PerformLayout()
        CType(PictureBox11, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
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
    Friend WithEvents btnBoardingVideos As Button
    Friend WithEvents btnBoardingRooms As Button
    Friend WithEvents btnBoardingServices As Button
    Friend WithEvents btnGroomingServices As Button
    Friend WithEvents btnPayments As Button
    Friend WithEvents btnOrders As Button
    Friend WithEvents btnBookings As Button
    Friend WithEvents btnPets As Button
    Friend WithEvents lblServices As Label
    Friend WithEvents lblFacility As Label
    Friend WithEvents btnProducts As Button
    Friend WithEvents btnMembership As Button
    Friend WithEvents lblShopAndMembership As Label
    Friend WithEvents btnLogout As Button
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
    Friend WithEvents pnlCustomers As Panel
    Friend WithEvents lblCustomerTitle As Label
    Friend WithEvents lblCustomerSubtitle As Label
    Friend WithEvents lblCustomerCount As Label
    Friend WithEvents pnlOrders As Panel
    Friend WithEvents lblOrderSubtitle As Label
    Friend WithEvents lblOrderCount As Label
    Friend WithEvents lblOrderTitle As Label
    Friend WithEvents pnlAppointments As Panel
    Friend WithEvents lblAppointmentSubtitle As Label
    Friend WithEvents lblAppointmentCount As Label
    Friend WithEvents lblAppointmentTitle As Label
    Friend WithEvents pnlPets As Panel
    Friend WithEvents lblPetSubtitle As Label
    Friend WithEvents lblPetCount As Label
    Friend WithEvents lblPetTitle As Label
    Friend WithEvents pnlRecentAppointments As Panel
    Friend WithEvents dgvRecentAppointments As DataGridView
    Friend WithEvents lblRecentTitle As Label
    Friend WithEvents pnlQuickActions As Panel
    Friend WithEvents btnNewAppointmnet As Button
    Friend WithEvents lblQuickActions As Label
    Friend WithEvents btnAddService As Button
    Friend WithEvents btnAddPet As Button
    Friend WithEvents btnAddCustomer As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents picCustomer As PictureBox
    Friend WithEvents picOrder As PictureBox
    Friend WithEvents picAppointment As PictureBox
    Friend WithEvents picPets As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox15 As PictureBox
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents tlpSummaryCards As TableLayoutPanel
    Friend WithEvents pnlSummaryCards As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PetsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrdersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaymentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServicesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroomingServicesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BoardingServicesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DashboardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserGuideToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblDashboardTitle As Label
End Class
