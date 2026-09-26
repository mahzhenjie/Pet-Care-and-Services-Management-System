<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCustomerDashboard
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim lblDescription As Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomerDashboard))
        pnlMain = New Panel()
        pnlSummaryCards = New Panel()
        tlpSummaryCards = New TableLayoutPanel()
        pnlPets = New Panel()
        picPets = New PictureBox()
        lblPetSubtitle = New Label()
        lblPetCount = New Label()
        lblPetTitle = New Label()
        pnlAppointments = New Panel()
        picAppointment = New PictureBox()
        lblAppointmentSubtitle = New Label()
        lblAppointmentCount = New Label()
        lblAppointmentTitle = New Label()
        pnlOrders = New Panel()
        picOrder = New PictureBox()
        lblOrderSubtitle = New Label()
        lblOrderCount = New Label()
        lblOrderTitle = New Label()
        pnlQuickActions = New Panel()
        PictureBox15 = New PictureBox()
        PictureBox14 = New PictureBox()
        PictureBox13 = New PictureBox()
        PictureBox16 = New PictureBox()
        btnAddService = New Button()
        btnAddPet = New Button()
        btnAddCustomer = New Button()
        btnNewAppointmnet = New Button()
        lblQuickActions = New Label()
        pnlRecentAppointments = New Panel()
        dgvRecentAppointments = New DataGridView()
        lblRecentTitle = New Label()
        pnlWelcome = New Panel()
        PictureBox17 = New PictureBox()
        picPets2 = New PictureBox()
        lblWelcomeBack = New Label()
        pnlTopBar = New Panel()
        Button2 = New Button()
        lblCustomer = New Label()
        Label5 = New Label()
        PictureBox12 = New PictureBox()
        btnDropdown = New Button()
        lblEmployee = New Label()
        btnMenu = New Button()
        lblWelcome = New Label()
        picEmployee = New PictureBox()
        btnNotification = New Button()
        picPaw = New PictureBox()
        lblDashboardTitle = New Label()
        pnlSidebar = New Panel()
        Label3 = New Label()
        Label2 = New Label()
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
        btnMembership = New Button()
        btnProduct = New Button()
        btnBoardingVideos = New Button()
        btnGroomingServices = New Button()
        btnPayments = New Button()
        btnBoardingServices = New Button()
        btnServices = New Button()
        btnOrders = New Button()
        btnAppointments = New Button()
        btnPet = New Button()
        Button3 = New Button()
        btnProfile = New Button()
        Button1 = New Button()
        Label1 = New Label()
        picLogo = New PictureBox()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        lblSidebarTitle = New Label()
        lblSidebarSubtitle = New Label()
        lblDescription = New Label()
        pnlMain.SuspendLayout()
        pnlSummaryCards.SuspendLayout()
        tlpSummaryCards.SuspendLayout()
        pnlPets.SuspendLayout()
        CType(picPets, ComponentModel.ISupportInitialize).BeginInit()
        pnlAppointments.SuspendLayout()
        CType(picAppointment, ComponentModel.ISupportInitialize).BeginInit()
        pnlOrders.SuspendLayout()
        CType(picOrder, ComponentModel.ISupportInitialize).BeginInit()
        pnlQuickActions.SuspendLayout()
        CType(PictureBox15, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox14, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox13, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox16, ComponentModel.ISupportInitialize).BeginInit()
        pnlRecentAppointments.SuspendLayout()
        CType(dgvRecentAppointments, ComponentModel.ISupportInitialize).BeginInit()
        pnlWelcome.SuspendLayout()
        CType(PictureBox17, ComponentModel.ISupportInitialize).BeginInit()
        CType(picPets2, ComponentModel.ISupportInitialize).BeginInit()
        pnlTopBar.SuspendLayout()
        CType(PictureBox12, ComponentModel.ISupportInitialize).BeginInit()
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
        lblDescription.Font = New Font("Segoe UI", 13.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDescription.ForeColor = Color.FromArgb(CByte(61), CByte(40), CByte(27))
        lblDescription.Location = New Point(7, 87)
        lblDescription.Name = "lblDescription"
        lblDescription.Size = New Size(315, 60)
        lblDescription.TabIndex = 6
        lblDescription.Text = "Manage your pet care services " & vbCrLf & "easily and efficiently."
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
        pnlSummaryCards.TabIndex = 19
        ' 
        ' tlpSummaryCards
        ' 
        tlpSummaryCards.ColumnCount = 3
        tlpSummaryCards.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        tlpSummaryCards.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        tlpSummaryCards.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        tlpSummaryCards.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20.0F))
        tlpSummaryCards.Controls.Add(pnlPets, 0, 0)
        tlpSummaryCards.Controls.Add(pnlAppointments, 1, 0)
        tlpSummaryCards.Controls.Add(pnlOrders, 2, 0)
        tlpSummaryCards.Dock = DockStyle.Fill
        tlpSummaryCards.Location = New Point(0, 0)
        tlpSummaryCards.Name = "tlpSummaryCards"
        tlpSummaryCards.RowCount = 1
        tlpSummaryCards.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        tlpSummaryCards.Size = New Size(1072, 163)
        tlpSummaryCards.TabIndex = 16
        ' 
        ' pnlPets
        ' 
        pnlPets.BackColor = Color.FromArgb(CByte(240), CByte(245), CByte(252))
        pnlPets.Controls.Add(picPets)
        pnlPets.Controls.Add(lblPetSubtitle)
        pnlPets.Controls.Add(lblPetCount)
        pnlPets.Controls.Add(lblPetTitle)
        pnlPets.Location = New Point(5, 5)
        pnlPets.Margin = New Padding(5)
        pnlPets.Name = "pnlPets"
        pnlPets.Size = New Size(347, 153)
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
        lblPetSubtitle.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPetSubtitle.ForeColor = SystemColors.ControlText
        lblPetSubtitle.Location = New Point(106, 103)
        lblPetSubtitle.Name = "lblPetSubtitle"
        lblPetSubtitle.Size = New Size(72, 20)
        lblPetSubtitle.TabIndex = 10
        lblPetSubtitle.Text = "Total Pets"
        ' 
        ' lblPetCount
        ' 
        lblPetCount.AutoSize = True
        lblPetCount.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPetCount.ForeColor = SystemColors.ControlText
        lblPetCount.Location = New Point(106, 58)
        lblPetCount.Name = "lblPetCount"
        lblPetCount.Size = New Size(32, 38)
        lblPetCount.TabIndex = 9
        lblPetCount.Text = "0"
        ' 
        ' lblPetTitle
        ' 
        lblPetTitle.AutoSize = True
        lblPetTitle.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPetTitle.ForeColor = Color.RoyalBlue
        lblPetTitle.Location = New Point(128, 3)
        lblPetTitle.Name = "lblPetTitle"
        lblPetTitle.Size = New Size(51, 28)
        lblPetTitle.TabIndex = 8
        lblPetTitle.Text = "Pets"
        ' 
        ' pnlAppointments
        ' 
        pnlAppointments.BackColor = Color.FromArgb(CByte(255), CByte(247), CByte(229))
        pnlAppointments.Controls.Add(picAppointment)
        pnlAppointments.Controls.Add(lblAppointmentSubtitle)
        pnlAppointments.Controls.Add(lblAppointmentCount)
        pnlAppointments.Controls.Add(lblAppointmentTitle)
        pnlAppointments.Location = New Point(362, 5)
        pnlAppointments.Margin = New Padding(5)
        pnlAppointments.Name = "pnlAppointments"
        pnlAppointments.Size = New Size(347, 153)
        pnlAppointments.TabIndex = 11
        ' 
        ' picAppointment
        ' 
        picAppointment.Image = CType(resources.GetObject("picAppointment.Image"), Image)
        picAppointment.Location = New Point(8, 41)
        picAppointment.Name = "picAppointment"
        picAppointment.Size = New Size(90, 90)
        picAppointment.SizeMode = PictureBoxSizeMode.Zoom
        picAppointment.TabIndex = 13
        picAppointment.TabStop = False
        ' 
        ' lblAppointmentSubtitle
        ' 
        lblAppointmentSubtitle.AutoSize = True
        lblAppointmentSubtitle.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAppointmentSubtitle.ForeColor = SystemColors.ControlText
        lblAppointmentSubtitle.Location = New Point(87, 103)
        lblAppointmentSubtitle.Name = "lblAppointmentSubtitle"
        lblAppointmentSubtitle.Size = New Size(156, 20)
        lblAppointmentSubtitle.TabIndex = 10
        lblAppointmentSubtitle.Text = "Today's Appointments"
        ' 
        ' lblAppointmentCount
        ' 
        lblAppointmentCount.AutoSize = True
        lblAppointmentCount.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAppointmentCount.ForeColor = SystemColors.ControlText
        lblAppointmentCount.Location = New Point(96, 58)
        lblAppointmentCount.Name = "lblAppointmentCount"
        lblAppointmentCount.Size = New Size(32, 38)
        lblAppointmentCount.TabIndex = 9
        lblAppointmentCount.Text = "0"
        ' 
        ' lblAppointmentTitle
        ' 
        lblAppointmentTitle.AutoSize = True
        lblAppointmentTitle.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAppointmentTitle.ForeColor = Color.DarkKhaki
        lblAppointmentTitle.Location = New Point(76, 3)
        lblAppointmentTitle.Name = "lblAppointmentTitle"
        lblAppointmentTitle.Size = New Size(146, 28)
        lblAppointmentTitle.TabIndex = 8
        lblAppointmentTitle.Text = "Appointments"
        ' 
        ' pnlOrders
        ' 
        pnlOrders.BackColor = Color.FromArgb(CByte(248), CByte(240), CByte(248))
        pnlOrders.Controls.Add(picOrder)
        pnlOrders.Controls.Add(lblOrderSubtitle)
        pnlOrders.Controls.Add(lblOrderCount)
        pnlOrders.Controls.Add(lblOrderTitle)
        pnlOrders.Location = New Point(719, 5)
        pnlOrders.Margin = New Padding(5)
        pnlOrders.Name = "pnlOrders"
        pnlOrders.Size = New Size(347, 153)
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
        lblOrderSubtitle.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblOrderSubtitle.ForeColor = SystemColors.ControlText
        lblOrderSubtitle.Location = New Point(104, 103)
        lblOrderSubtitle.Name = "lblOrderSubtitle"
        lblOrderSubtitle.Size = New Size(110, 20)
        lblOrderSubtitle.TabIndex = 10
        lblOrderSubtitle.Text = "Pending Orders"
        ' 
        ' lblOrderCount
        ' 
        lblOrderCount.AutoSize = True
        lblOrderCount.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblOrderCount.ForeColor = SystemColors.ControlText
        lblOrderCount.Location = New Point(107, 58)
        lblOrderCount.Name = "lblOrderCount"
        lblOrderCount.Size = New Size(32, 38)
        lblOrderCount.TabIndex = 9
        lblOrderCount.Text = "0"
        ' 
        ' lblOrderTitle
        ' 
        lblOrderTitle.AutoSize = True
        lblOrderTitle.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblOrderTitle.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        lblOrderTitle.Location = New Point(84, 3)
        lblOrderTitle.Name = "lblOrderTitle"
        lblOrderTitle.Size = New Size(75, 28)
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
        pnlQuickActions.Controls.Add(PictureBox16)
        pnlQuickActions.Controls.Add(btnAddService)
        pnlQuickActions.Controls.Add(btnAddPet)
        pnlQuickActions.Controls.Add(btnAddCustomer)
        pnlQuickActions.Controls.Add(btnNewAppointmnet)
        pnlQuickActions.Controls.Add(lblQuickActions)
        pnlQuickActions.Location = New Point(1061, 495)
        pnlQuickActions.Name = "pnlQuickActions"
        pnlQuickActions.Size = New Size(298, 395)
        pnlQuickActions.TabIndex = 18
        ' 
        ' PictureBox15
        ' 
        PictureBox15.Image = CType(resources.GetObject("PictureBox15.Image"), Image)
        PictureBox15.Location = New Point(5, 239)
        PictureBox15.Name = "PictureBox15"
        PictureBox15.Size = New Size(44, 44)
        PictureBox15.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox15.TabIndex = 8
        PictureBox15.TabStop = False
        ' 
        ' PictureBox14
        ' 
        PictureBox14.Image = CType(resources.GetObject("PictureBox14.Image"), Image)
        PictureBox14.Location = New Point(5, 159)
        PictureBox14.Name = "PictureBox14"
        PictureBox14.Size = New Size(44, 44)
        PictureBox14.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox14.TabIndex = 7
        PictureBox14.TabStop = False
        ' 
        ' PictureBox13
        ' 
        PictureBox13.Image = CType(resources.GetObject("PictureBox13.Image"), Image)
        PictureBox13.Location = New Point(5, 316)
        PictureBox13.Name = "PictureBox13"
        PictureBox13.Size = New Size(44, 44)
        PictureBox13.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox13.TabIndex = 6
        PictureBox13.TabStop = False
        ' 
        ' PictureBox16
        ' 
        PictureBox16.Image = CType(resources.GetObject("PictureBox16.Image"), Image)
        PictureBox16.Location = New Point(5, 79)
        PictureBox16.Name = "PictureBox16"
        PictureBox16.Size = New Size(44, 44)
        PictureBox16.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox16.TabIndex = 5
        PictureBox16.TabStop = False
        ' 
        ' btnAddService
        ' 
        btnAddService.BackColor = Color.FromArgb(CByte(248), CByte(240), CByte(248))
        btnAddService.FlatStyle = FlatStyle.Flat
        btnAddService.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddService.ForeColor = SystemColors.ControlText
        btnAddService.Location = New Point(61, 307)
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
        btnAddPet.ForeColor = SystemColors.ControlText
        btnAddPet.Location = New Point(61, 231)
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
        btnAddCustomer.ForeColor = SystemColors.ControlText
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
        btnNewAppointmnet.ForeColor = SystemColors.ControlText
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
        lblQuickActions.ForeColor = SystemColors.ControlText
        lblQuickActions.Location = New Point(5, 11)
        lblQuickActions.Name = "lblQuickActions"
        lblQuickActions.Size = New Size(202, 31)
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
        pnlRecentAppointments.TabIndex = 17
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
        lblRecentTitle.ForeColor = SystemColors.ControlText
        lblRecentTitle.Location = New Point(17, 11)
        lblRecentTitle.Name = "lblRecentTitle"
        lblRecentTitle.Size = New Size(291, 31)
        lblRecentTitle.TabIndex = 0
        lblRecentTitle.Text = "📅  Recent Appointments"
        ' 
        ' pnlWelcome
        ' 
        pnlWelcome.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlWelcome.BackColor = Color.FromArgb(CByte(252), CByte(235), CByte(213))
        pnlWelcome.Controls.Add(PictureBox17)
        pnlWelcome.Controls.Add(picPets2)
        pnlWelcome.Controls.Add(lblDescription)
        pnlWelcome.Controls.Add(lblWelcomeBack)
        pnlWelcome.Location = New Point(308, 132)
        pnlWelcome.Margin = New Padding(0)
        pnlWelcome.Name = "pnlWelcome"
        pnlWelcome.Size = New Size(1055, 164)
        pnlWelcome.TabIndex = 16
        ' 
        ' PictureBox17
        ' 
        PictureBox17.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox17.BackColor = Color.Transparent
        PictureBox17.ErrorImage = Nothing
        PictureBox17.Image = CType(resources.GetObject("PictureBox17.Image"), Image)
        PictureBox17.Location = New Point(484, 0)
        PictureBox17.Name = "PictureBox17"
        PictureBox17.Size = New Size(572, 168)
        PictureBox17.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox17.TabIndex = 9
        PictureBox17.TabStop = False
        PictureBox17.Visible = False
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
        lblWelcomeBack.Font = New Font("Segoe UI", 25.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblWelcomeBack.ForeColor = Color.FromArgb(CByte(61), CByte(40), CByte(27))
        lblWelcomeBack.Location = New Point(3, 9)
        lblWelcomeBack.Name = "lblWelcomeBack"
        lblWelcomeBack.Size = New Size(404, 59)
        lblWelcomeBack.TabIndex = 7
        lblWelcomeBack.Text = "Welcome back! 👋"
        ' 
        ' pnlTopBar
        ' 
        pnlTopBar.Controls.Add(Button2)
        pnlTopBar.Controls.Add(lblCustomer)
        pnlTopBar.Controls.Add(Label5)
        pnlTopBar.Controls.Add(PictureBox12)
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
        pnlTopBar.TabIndex = 5
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 18.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.FromArgb(CByte(75), CByte(43), CByte(28))
        Button2.Location = New Point(803, 42)
        Button2.Name = "Button2"
        Button2.Size = New Size(54, 45)
        Button2.TabIndex = 6
        Button2.Text = "🔔"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' lblCustomer
        ' 
        lblCustomer.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblCustomer.AutoEllipsis = True
        lblCustomer.AutoSize = True
        lblCustomer.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCustomer.ForeColor = Color.FromArgb(CByte(61), CByte(40), CByte(27))
        lblCustomer.Location = New Point(943, 65)
        lblCustomer.Name = "lblCustomer"
        lblCustomer.Size = New Size(117, 31)
        lblCustomer.TabIndex = 9
        lblCustomer.Text = "Customer"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label5.AutoEllipsis = True
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(107), CByte(98), CByte(91))
        Label5.Location = New Point(943, 42)
        Label5.Name = "Label5"
        Label5.Size = New Size(84, 23)
        Label5.TabIndex = 7
        Label5.Text = "Welcome,"
        ' 
        ' PictureBox12
        ' 
        PictureBox12.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox12.Image = CType(resources.GetObject("PictureBox12.Image"), Image)
        PictureBox12.Location = New Point(872, 35)
        PictureBox12.Name = "PictureBox12"
        PictureBox12.Size = New Size(65, 65)
        PictureBox12.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox12.TabIndex = 8
        PictureBox12.TabStop = False
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
        lblEmployee.Location = New Point(1799, 65)
        lblEmployee.Name = "lblEmployee"
        lblEmployee.Size = New Size(118, 31)
        lblEmployee.TabIndex = 6
        lblEmployee.Text = "Employee"
        lblEmployee.Visible = False
        ' 
        ' btnMenu
        ' 
        btnMenu.FlatAppearance.BorderSize = 0
        btnMenu.FlatStyle = FlatStyle.Flat
        btnMenu.Font = New Font("Segoe UI", 19.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnMenu.ForeColor = SystemColors.ControlText
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
        lblWelcome.Location = New Point(1799, 42)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(84, 23)
        lblWelcome.TabIndex = 5
        lblWelcome.Text = "Welcome,"
        lblWelcome.Visible = False
        ' 
        ' picEmployee
        ' 
        picEmployee.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        picEmployee.Image = CType(resources.GetObject("picEmployee.Image"), Image)
        picEmployee.Location = New Point(1728, 35)
        picEmployee.Name = "picEmployee"
        picEmployee.Size = New Size(65, 65)
        picEmployee.SizeMode = PictureBoxSizeMode.Zoom
        picEmployee.TabIndex = 5
        picEmployee.TabStop = False
        picEmployee.Visible = False
        ' 
        ' btnNotification
        ' 
        btnNotification.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnNotification.FlatAppearance.BorderSize = 0
        btnNotification.FlatStyle = FlatStyle.Flat
        btnNotification.Font = New Font("Segoe UI", 18.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnNotification.Location = New Point(1659, 42)
        btnNotification.Name = "btnNotification"
        btnNotification.Size = New Size(54, 45)
        btnNotification.TabIndex = 4
        btnNotification.Text = "🔔"
        btnNotification.UseVisualStyleBackColor = True
        btnNotification.Visible = False
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
        ' lblDashboardTitle
        ' 
        lblDashboardTitle.AutoSize = True
        lblDashboardTitle.Font = New Font("Georgia", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDashboardTitle.ForeColor = SystemColors.ControlText
        lblDashboardTitle.Location = New Point(63, 50)
        lblDashboardTitle.Name = "lblDashboardTitle"
        lblDashboardTitle.Size = New Size(564, 46)
        lblDashboardTitle.TabIndex = 1
        lblDashboardTitle.Text = "CUSTOMER DASHBOARD"
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.FromArgb(CByte(74), CByte(44), CByte(26))
        pnlSidebar.Controls.Add(lblSidebarSubtitle)
        pnlSidebar.Controls.Add(lblSidebarTitle)
        pnlSidebar.Controls.Add(Label3)
        pnlSidebar.Controls.Add(Label2)
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
        pnlSidebar.Controls.Add(btnMembership)
        pnlSidebar.Controls.Add(btnProduct)
        pnlSidebar.Controls.Add(btnBoardingVideos)
        pnlSidebar.Controls.Add(btnGroomingServices)
        pnlSidebar.Controls.Add(btnPayments)
        pnlSidebar.Controls.Add(btnBoardingServices)
        pnlSidebar.Controls.Add(btnServices)
        pnlSidebar.Controls.Add(btnOrders)
        pnlSidebar.Controls.Add(btnAppointments)
        pnlSidebar.Controls.Add(btnPet)
        pnlSidebar.Controls.Add(Button3)
        pnlSidebar.Controls.Add(btnProfile)
        pnlSidebar.Controls.Add(Button1)
        pnlSidebar.Controls.Add(picLogo)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(280, 901)
        pnlSidebar.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(221), CByte(184), CByte(146))
        Label3.Location = New Point(19, 455)
        Label3.Name = "Label3"
        Label3.Size = New Size(65, 17)
        Label3.TabIndex = 29
        Label3.Text = "SERVICES"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(221), CByte(184), CByte(146))
        Label2.Location = New Point(19, 194)
        Label2.Name = "Label2"
        Label2.Size = New Size(101, 17)
        Label2.TabIndex = 28
        Label2.Text = "MANAGEMENT"
        ' 
        ' PictureBox11
        ' 
        PictureBox11.BackColor = Color.FromArgb(CByte(75), CByte(43), CByte(28))
        PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), Image)
        PictureBox11.Location = New Point(8, 735)
        PictureBox11.Name = "PictureBox11"
        PictureBox11.Size = New Size(43, 40)
        PictureBox11.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox11.TabIndex = 27
        PictureBox11.TabStop = False
        ' 
        ' PictureBox10
        ' 
        PictureBox10.BackColor = Color.FromArgb(CByte(75), CByte(43), CByte(28))
        PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), Image)
        PictureBox10.Location = New Point(8, 689)
        PictureBox10.Name = "PictureBox10"
        PictureBox10.Size = New Size(43, 40)
        PictureBox10.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox10.TabIndex = 26
        PictureBox10.TabStop = False
        ' 
        ' PictureBox9
        ' 
        PictureBox9.BackColor = Color.FromArgb(CByte(75), CByte(43), CByte(28))
        PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), Image)
        PictureBox9.Location = New Point(8, 613)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(43, 40)
        PictureBox9.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox9.TabIndex = 25
        PictureBox9.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BackColor = Color.FromArgb(CByte(75), CByte(43), CByte(28))
        PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), Image)
        PictureBox8.Location = New Point(8, 567)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(43, 40)
        PictureBox8.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox8.TabIndex = 24
        PictureBox8.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = Color.FromArgb(CByte(75), CByte(43), CByte(28))
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(8, 521)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(43, 40)
        PictureBox7.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox7.TabIndex = 23
        PictureBox7.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = Color.FromArgb(CByte(75), CByte(43), CByte(28))
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(8, 475)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(43, 40)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 22
        PictureBox6.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.FromArgb(CByte(75), CByte(43), CByte(28))
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(8, 401)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(43, 40)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 21
        PictureBox5.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.FromArgb(CByte(75), CByte(43), CByte(28))
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(8, 355)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(43, 40)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 20
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.FromArgb(CByte(75), CByte(43), CByte(28))
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(8, 309)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(43, 40)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 19
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.FromArgb(CByte(75), CByte(43), CByte(28))
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(8, 263)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(43, 40)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 18
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(75), CByte(43), CByte(28))
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(8, 219)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(43, 40)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 17
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
        btnLogout.TabIndex = 16
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnMembership
        ' 
        btnMembership.FlatAppearance.BorderSize = 0
        btnMembership.FlatStyle = FlatStyle.Flat
        btnMembership.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnMembership.ForeColor = SystemColors.Control
        btnMembership.Location = New Point(57, 735)
        btnMembership.Name = "btnMembership"
        btnMembership.Size = New Size(210, 40)
        btnMembership.TabIndex = 15
        btnMembership.Text = "Membership"
        btnMembership.TextAlign = ContentAlignment.MiddleLeft
        btnMembership.UseVisualStyleBackColor = True
        ' 
        ' btnProduct
        ' 
        btnProduct.FlatAppearance.BorderSize = 0
        btnProduct.FlatStyle = FlatStyle.Flat
        btnProduct.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnProduct.ForeColor = SystemColors.Control
        btnProduct.Location = New Point(57, 689)
        btnProduct.Name = "btnProduct"
        btnProduct.Size = New Size(210, 40)
        btnProduct.TabIndex = 14
        btnProduct.Text = "Product"
        btnProduct.TextAlign = ContentAlignment.MiddleLeft
        btnProduct.UseVisualStyleBackColor = True
        ' 
        ' btnBoardingVideos
        ' 
        btnBoardingVideos.FlatAppearance.BorderSize = 0
        btnBoardingVideos.FlatStyle = FlatStyle.Flat
        btnBoardingVideos.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBoardingVideos.ForeColor = SystemColors.Control
        btnBoardingVideos.Location = New Point(57, 613)
        btnBoardingVideos.Name = "btnBoardingVideos"
        btnBoardingVideos.Size = New Size(210, 40)
        btnBoardingVideos.TabIndex = 13
        btnBoardingVideos.Text = "Boarding Videos"
        btnBoardingVideos.TextAlign = ContentAlignment.MiddleLeft
        btnBoardingVideos.UseVisualStyleBackColor = True
        ' 
        ' btnGroomingServices
        ' 
        btnGroomingServices.FlatAppearance.BorderSize = 0
        btnGroomingServices.FlatStyle = FlatStyle.Flat
        btnGroomingServices.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnGroomingServices.ForeColor = SystemColors.Control
        btnGroomingServices.Location = New Point(57, 521)
        btnGroomingServices.Name = "btnGroomingServices"
        btnGroomingServices.Size = New Size(210, 40)
        btnGroomingServices.TabIndex = 12
        btnGroomingServices.Text = "Grooming Service"
        btnGroomingServices.TextAlign = ContentAlignment.MiddleLeft
        btnGroomingServices.UseVisualStyleBackColor = True
        ' 
        ' btnPayments
        ' 
        btnPayments.FlatAppearance.BorderSize = 0
        btnPayments.FlatStyle = FlatStyle.Flat
        btnPayments.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPayments.ForeColor = SystemColors.Control
        btnPayments.Location = New Point(57, 401)
        btnPayments.Name = "btnPayments"
        btnPayments.Size = New Size(210, 40)
        btnPayments.TabIndex = 11
        btnPayments.Text = "Payments"
        btnPayments.TextAlign = ContentAlignment.MiddleLeft
        btnPayments.UseVisualStyleBackColor = True
        ' 
        ' btnBoardingServices
        ' 
        btnBoardingServices.FlatAppearance.BorderSize = 0
        btnBoardingServices.FlatStyle = FlatStyle.Flat
        btnBoardingServices.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBoardingServices.ForeColor = SystemColors.Control
        btnBoardingServices.Location = New Point(57, 567)
        btnBoardingServices.Name = "btnBoardingServices"
        btnBoardingServices.Size = New Size(210, 40)
        btnBoardingServices.TabIndex = 10
        btnBoardingServices.Text = "Boarding Services"
        btnBoardingServices.TextAlign = ContentAlignment.MiddleLeft
        btnBoardingServices.UseVisualStyleBackColor = True
        ' 
        ' btnServices
        ' 
        btnServices.FlatAppearance.BorderSize = 0
        btnServices.FlatStyle = FlatStyle.Flat
        btnServices.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnServices.ForeColor = SystemColors.Control
        btnServices.Location = New Point(57, 475)
        btnServices.Name = "btnServices"
        btnServices.Size = New Size(210, 40)
        btnServices.TabIndex = 8
        btnServices.Text = "Services"
        btnServices.TextAlign = ContentAlignment.MiddleLeft
        btnServices.UseVisualStyleBackColor = True
        ' 
        ' btnOrders
        ' 
        btnOrders.FlatAppearance.BorderSize = 0
        btnOrders.FlatStyle = FlatStyle.Flat
        btnOrders.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnOrders.ForeColor = SystemColors.Control
        btnOrders.Location = New Point(57, 355)
        btnOrders.Name = "btnOrders"
        btnOrders.Size = New Size(210, 40)
        btnOrders.TabIndex = 7
        btnOrders.Text = "Orders"
        btnOrders.TextAlign = ContentAlignment.MiddleLeft
        btnOrders.UseVisualStyleBackColor = True
        ' 
        ' btnAppointments
        ' 
        btnAppointments.FlatAppearance.BorderSize = 0
        btnAppointments.FlatStyle = FlatStyle.Flat
        btnAppointments.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAppointments.ForeColor = SystemColors.Control
        btnAppointments.Location = New Point(57, 309)
        btnAppointments.Name = "btnAppointments"
        btnAppointments.Size = New Size(210, 40)
        btnAppointments.TabIndex = 6
        btnAppointments.Text = "Appointments"
        btnAppointments.TextAlign = ContentAlignment.MiddleLeft
        btnAppointments.UseVisualStyleBackColor = True
        ' 
        ' btnPet
        ' 
        btnPet.FlatAppearance.BorderSize = 0
        btnPet.FlatStyle = FlatStyle.Flat
        btnPet.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPet.ForeColor = SystemColors.Control
        btnPet.Location = New Point(57, 263)
        btnPet.Name = "btnPet"
        btnPet.Size = New Size(210, 40)
        btnPet.TabIndex = 5
        btnPet.Text = "Pet"
        btnPet.TextAlign = ContentAlignment.MiddleLeft
        btnPet.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(114, 256)
        Button3.Name = "Button3"
        Button3.Size = New Size(0, 0)
        Button3.TabIndex = 4
        Button3.Text = "Button3"
        Button3.UseVisualStyleBackColor = True
        Button3.Visible = False
        ' 
        ' btnProfile
        ' 
        btnProfile.BackColor = Color.FromArgb(CByte(75), CByte(43), CByte(28))
        btnProfile.FlatAppearance.BorderSize = 0
        btnProfile.FlatStyle = FlatStyle.Flat
        btnProfile.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnProfile.ForeColor = SystemColors.Control
        btnProfile.Location = New Point(57, 217)
        btnProfile.Name = "btnProfile"
        btnProfile.Size = New Size(210, 40)
        btnProfile.TabIndex = 3
        btnProfile.Text = "Profile"
        btnProfile.TextAlign = ContentAlignment.MiddleLeft
        btnProfile.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(196), CByte(106), CByte(43))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(11, 141)
        Button1.Name = "Button1"
        Button1.Size = New Size(220, 45)
        Button1.TabIndex = 2
        Button1.Text = "Dashboard"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(99, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(151, 56)
        Label1.TabIndex = 1
        Label1.Text = "PET CARE" & vbCrLf & "AND SERVICES"
        Label1.Visible = False
        ' 
        ' picLogo
        ' 
        picLogo.BackColor = Color.Transparent
        picLogo.Image = CType(resources.GetObject("picLogo.Image"), Image)
        picLogo.Location = New Point(1, 39)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(92, 85)
        picLogo.SizeMode = PictureBoxSizeMode.Zoom
        picLogo.TabIndex = 0
        picLogo.TabStop = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1382, 28)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(46, 24)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' lblSidebarTitle
        ' 
        lblSidebarTitle.AutoSize = True
        lblSidebarTitle.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSidebarTitle.ForeColor = Color.White
        lblSidebarTitle.Location = New Point(99, 40)
        lblSidebarTitle.Name = "lblSidebarTitle"
        lblSidebarTitle.Size = New Size(151, 56)
        lblSidebarTitle.TabIndex = 30
        lblSidebarTitle.Text = "PET CARE " & vbCrLf & "AND SERVICES"
        lblSidebarTitle.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblSidebarSubtitle
        ' 
        lblSidebarSubtitle.AutoSize = True
        lblSidebarSubtitle.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSidebarSubtitle.ForeColor = Color.FromArgb(CByte(245), CByte(230), CByte(209))
        lblSidebarSubtitle.Location = New Point(99, 104)
        lblSidebarSubtitle.Name = "lblSidebarSubtitle"
        lblSidebarSubtitle.Size = New Size(168, 20)
        lblSidebarSubtitle.TabIndex = 31
        lblSidebarSubtitle.Text = "MANAGEMENT SYSTEM"
        lblSidebarSubtitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' frmCustomerDashboard
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(245), CByte(230), CByte(209))
        ClientSize = New Size(1382, 901)
        Controls.Add(MenuStrip1)
        Controls.Add(pnlMain)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = SystemColors.ControlText
        MainMenuStrip = MenuStrip1
        Name = "frmCustomerDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Customer Dashboard"
        pnlMain.ResumeLayout(False)
        pnlSummaryCards.ResumeLayout(False)
        tlpSummaryCards.ResumeLayout(False)
        pnlPets.ResumeLayout(False)
        pnlPets.PerformLayout()
        CType(picPets, ComponentModel.ISupportInitialize).EndInit()
        pnlAppointments.ResumeLayout(False)
        pnlAppointments.PerformLayout()
        CType(picAppointment, ComponentModel.ISupportInitialize).EndInit()
        pnlOrders.ResumeLayout(False)
        pnlOrders.PerformLayout()
        CType(picOrder, ComponentModel.ISupportInitialize).EndInit()
        pnlQuickActions.ResumeLayout(False)
        pnlQuickActions.PerformLayout()
        CType(PictureBox15, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox14, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox13, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox16, ComponentModel.ISupportInitialize).EndInit()
        pnlRecentAppointments.ResumeLayout(False)
        pnlRecentAppointments.PerformLayout()
        CType(dgvRecentAppointments, ComponentModel.ISupportInitialize).EndInit()
        pnlWelcome.ResumeLayout(False)
        pnlWelcome.PerformLayout()
        CType(PictureBox17, ComponentModel.ISupportInitialize).EndInit()
        CType(picPets2, ComponentModel.ISupportInitialize).EndInit()
        pnlTopBar.ResumeLayout(False)
        pnlTopBar.PerformLayout()
        CType(PictureBox12, ComponentModel.ISupportInitialize).EndInit()
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

    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnProfile As Button
    Friend WithEvents btnServices As Button
    Friend WithEvents btnOrders As Button
    Friend WithEvents btnAppointments As Button
    Friend WithEvents btnPet As Button
    Friend WithEvents btnGroomingServices As Button
    Friend WithEvents btnPayments As Button
    Friend WithEvents btnBoardingServices As Button
    Friend WithEvents btnMembership As Button
    Friend WithEvents btnProduct As Button
    Friend WithEvents btnBoardingVideos As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents pnlTopBar As Panel
    Friend WithEvents btnDropdown As Button
    Friend WithEvents lblEmployee As Label
    Friend WithEvents btnMenu As Button
    Friend WithEvents lblWelcome As Label
    Friend WithEvents picEmployee As PictureBox
    Friend WithEvents btnNotification As Button
    Friend WithEvents picPaw As PictureBox
    Friend WithEvents lblDashboardTitle As Label
    Friend WithEvents lblCustomer As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents pnlWelcome As Panel
    Friend WithEvents picPets2 As PictureBox
    Friend WithEvents lblWelcomeBack As Label
    Friend WithEvents pnlSummaryCards As Panel
    Friend WithEvents tlpSummaryCards As TableLayoutPanel
    Friend WithEvents pnlAppointments As Panel
    Friend WithEvents picAppointment As PictureBox
    Friend WithEvents lblAppointmentSubtitle As Label
    Friend WithEvents lblAppointmentCount As Label
    Friend WithEvents lblAppointmentTitle As Label
    Friend WithEvents pnlPets As Panel
    Friend WithEvents picPets As PictureBox
    Friend WithEvents lblPetSubtitle As Label
    Friend WithEvents lblPetCount As Label
    Friend WithEvents lblPetTitle As Label
    Friend WithEvents pnlOrders As Panel
    Friend WithEvents picOrder As PictureBox
    Friend WithEvents lblOrderSubtitle As Label
    Friend WithEvents lblOrderCount As Label
    Friend WithEvents lblOrderTitle As Label
    Friend WithEvents pnlQuickActions As Panel
    Friend WithEvents PictureBox15 As PictureBox
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents PictureBox16 As PictureBox
    Friend WithEvents btnAddService As Button
    Friend WithEvents btnAddPet As Button
    Friend WithEvents btnAddCustomer As Button
    Friend WithEvents btnNewAppointmnet As Button
    Friend WithEvents lblQuickActions As Label
    Friend WithEvents pnlRecentAppointments As Panel
    Friend WithEvents dgvRecentAppointments As DataGridView
    Friend WithEvents lblRecentTitle As Label
    Friend WithEvents PictureBox17 As PictureBox
    Friend WithEvents lblSidebarTitle As Label
    Friend WithEvents lblSidebarSubtitle As Label
End Class
