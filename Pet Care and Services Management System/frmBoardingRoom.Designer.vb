<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBoardingRoom
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBoardingRoom))
        pnlMain = New Panel()
        lblTitle = New Label()
        lblSubtitle = New Label()
        txtSearch = New TextBox()
        cboStatus = New ComboBox()
        btnRefresh = New Button()
        btnAddRoom = New Button()
        flpRooms = New FlowLayoutPanel()
        pnlRoom1 = New Panel()
        picRoom1 = New PictureBox()
        lblStatus1 = New Label()
        lblRoomID1 = New Label()
        lblRoomType1 = New Label()
        lblPrice1 = New Label()
        lblDescription1 = New Label()
        btnEdit1 = New Button()
        btnDelete1 = New Button()
        pnlRoom2 = New Panel()
        picRoom2 = New PictureBox()
        lblStatus2 = New Label()
        lblRoomID2 = New Label()
        lblRoomType2 = New Label()
        lblPrice2 = New Label()
        lblDescription2 = New Label()
        btnEdit2 = New Button()
        btnDelete2 = New Button()
        pnlRoom3 = New Panel()
        picRoom3 = New PictureBox()
        lblStatus3 = New Label()
        lblRoomID3 = New Label()
        lblRoomType3 = New Label()
        lblPrice3 = New Label()
        lblDescription3 = New Label()
        btnEdit3 = New Button()
        btnDelete3 = New Button()
        pnlRoom4 = New Panel()
        picRoom4 = New PictureBox()
        lblStatus4 = New Label()
        lblRoomID4 = New Label()
        lblRoomType4 = New Label()
        lblPrice4 = New Label()
        lblDescription4 = New Label()
        btnEdit4 = New Button()
        btnDelete4 = New Button()
        pnlRoom5 = New Panel()
        picRoom5 = New PictureBox()
        lblStatus5 = New Label()
        lblRoomID5 = New Label()
        lblRoomType5 = New Label()
        lblPrice5 = New Label()
        lblDescription5 = New Label()
        btnEdit5 = New Button()
        btnDelete5 = New Button()
        pnlRoom6 = New Panel()
        picRoom6 = New PictureBox()
        lblStatus6 = New Label()
        lblRoomID6 = New Label()
        lblRoomType6 = New Label()
        lblPrice6 = New Label()
        lblDescription6 = New Label()
        btnEdit6 = New Button()
        btnDelete6 = New Button()
        pnlRoom7 = New Panel()
        picRoom7 = New PictureBox()
        lblStatus7 = New Label()
        lblRoomID7 = New Label()
        lblRoomType7 = New Label()
        lblPrice7 = New Label()
        lblDescription7 = New Label()
        btnEdit7 = New Button()
        btnDelete7 = New Button()
        pnlRoom8 = New Panel()
        picRoom8 = New PictureBox()
        lblStatus8 = New Label()
        lblRoomID8 = New Label()
        lblRoomType8 = New Label()
        lblPrice8 = New Label()
        lblDescription8 = New Label()
        btnEdit8 = New Button()
        btnDelete8 = New Button()
        btnGoBackDashboard = New Button()
        pnlMain.SuspendLayout()
        flpRooms.SuspendLayout()
        pnlRoom1.SuspendLayout()
        CType(picRoom1, ComponentModel.ISupportInitialize).BeginInit()
        pnlRoom2.SuspendLayout()
        CType(picRoom2, ComponentModel.ISupportInitialize).BeginInit()
        pnlRoom3.SuspendLayout()
        CType(picRoom3, ComponentModel.ISupportInitialize).BeginInit()
        pnlRoom4.SuspendLayout()
        CType(picRoom4, ComponentModel.ISupportInitialize).BeginInit()
        pnlRoom5.SuspendLayout()
        CType(picRoom5, ComponentModel.ISupportInitialize).BeginInit()
        pnlRoom6.SuspendLayout()
        CType(picRoom6, ComponentModel.ISupportInitialize).BeginInit()
        pnlRoom7.SuspendLayout()
        CType(picRoom7, ComponentModel.ISupportInitialize).BeginInit()
        pnlRoom8.SuspendLayout()
        CType(picRoom8, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlMain
        ' 
        pnlMain.BackColor = Color.FromArgb(CByte(247), CByte(232), CByte(213))
        pnlMain.Controls.Add(btnGoBackDashboard)
        pnlMain.Controls.Add(lblTitle)
        pnlMain.Controls.Add(lblSubtitle)
        pnlMain.Controls.Add(txtSearch)
        pnlMain.Controls.Add(cboStatus)
        pnlMain.Controls.Add(btnRefresh)
        pnlMain.Controls.Add(btnAddRoom)
        pnlMain.Controls.Add(flpRooms)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(0, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(1400, 850)
        pnlMain.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(CByte(105), CByte(55), CByte(25))
        lblTitle.Location = New Point(55, 35)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(580, 54)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Boarding Room Management"
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.Font = New Font("Segoe UI", 11F)
        lblSubtitle.ForeColor = Color.FromArgb(CByte(125), CByte(85), CByte(55))
        lblSubtitle.Location = New Point(58, 82)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(348, 25)
        lblSubtitle.TabIndex = 1
        lblSubtitle.Text = "Manage your pet boarding rooms easily"
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Segoe UI", 11F)
        txtSearch.Location = New Point(55, 125)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(500, 32)
        txtSearch.TabIndex = 2
        txtSearch.Text = "Search boarding room..."
        ' 
        ' cboStatus
        ' 
        cboStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cboStatus.Font = New Font("Segoe UI", 10F)
        cboStatus.FormattingEnabled = True
        cboStatus.Items.AddRange(New Object() {"All Status", "Available", "Occupied"})
        cboStatus.Location = New Point(575, 123)
        cboStatus.Name = "cboStatus"
        cboStatus.Size = New Size(170, 31)
        cboStatus.TabIndex = 3
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.FromArgb(CByte(143), CByte(91), CByte(51))
        btnRefresh.FlatAppearance.BorderSize = 0
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnRefresh.ForeColor = Color.White
        btnRefresh.Location = New Point(1010, 119)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(140, 35)
        btnRefresh.TabIndex = 4
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' btnAddRoom
        ' 
        btnAddRoom.BackColor = Color.FromArgb(CByte(139), CByte(78), CByte(28))
        btnAddRoom.FlatAppearance.BorderSize = 0
        btnAddRoom.FlatStyle = FlatStyle.Flat
        btnAddRoom.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnAddRoom.ForeColor = Color.White
        btnAddRoom.Location = New Point(1170, 119)
        btnAddRoom.Name = "btnAddRoom"
        btnAddRoom.Size = New Size(170, 35)
        btnAddRoom.TabIndex = 5
        btnAddRoom.Text = "+ Add Room"
        btnAddRoom.UseVisualStyleBackColor = False
        ' 
        ' flpRooms
        ' 
        flpRooms.AutoScroll = True
        flpRooms.BackColor = Color.Transparent
        flpRooms.Controls.Add(pnlRoom1)
        flpRooms.Controls.Add(pnlRoom2)
        flpRooms.Controls.Add(pnlRoom3)
        flpRooms.Controls.Add(pnlRoom4)
        flpRooms.Controls.Add(pnlRoom5)
        flpRooms.Controls.Add(pnlRoom6)
        flpRooms.Controls.Add(pnlRoom7)
        flpRooms.Controls.Add(pnlRoom8)
        flpRooms.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        flpRooms.Location = New Point(55, 175)
        flpRooms.Name = "flpRooms"
        flpRooms.Size = New Size(1320, 620)
        flpRooms.TabIndex = 6
        ' 
        ' pnlRoom1
        ' 
        pnlRoom1.BackColor = Color.White
        pnlRoom1.Controls.Add(picRoom1)
        pnlRoom1.Controls.Add(lblStatus1)
        pnlRoom1.Controls.Add(lblRoomID1)
        pnlRoom1.Controls.Add(lblRoomType1)
        pnlRoom1.Controls.Add(lblPrice1)
        pnlRoom1.Controls.Add(lblDescription1)
        pnlRoom1.Controls.Add(btnEdit1)
        pnlRoom1.Controls.Add(btnDelete1)
        pnlRoom1.Location = New Point(0, 0)
        pnlRoom1.Margin = New Padding(0, 0, 15, 15)
        pnlRoom1.Name = "pnlRoom1"
        pnlRoom1.Size = New Size(310, 285)
        pnlRoom1.TabIndex = 0
        ' 
        ' picRoom1
        ' 
        picRoom1.BackColor = Color.FromArgb(CByte(232), CByte(215), CByte(190))
        picRoom1.Image = CType(resources.GetObject("picRoom1.Image"), Image)
        picRoom1.Location = New Point(10, 10)
        picRoom1.Name = "picRoom1"
        picRoom1.Size = New Size(290, 115)
        picRoom1.SizeMode = PictureBoxSizeMode.Zoom
        picRoom1.TabIndex = 0
        picRoom1.TabStop = False
        ' 
        ' lblStatus1
        ' 
        lblStatus1.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        lblStatus1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblStatus1.ForeColor = Color.White
        lblStatus1.Location = New Point(20, 20)
        lblStatus1.Name = "lblStatus1"
        lblStatus1.Size = New Size(85, 25)
        lblStatus1.TabIndex = 1
        lblStatus1.Text = "Available"
        lblStatus1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblRoomID1
        ' 
        lblRoomID1.AutoSize = True
        lblRoomID1.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        lblRoomID1.ForeColor = Color.FromArgb(CByte(105), CByte(55), CByte(25))
        lblRoomID1.Location = New Point(15, 135)
        lblRoomID1.Name = "lblRoomID1"
        lblRoomID1.Size = New Size(73, 35)
        lblRoomID1.TabIndex = 2
        lblRoomID1.Text = "R001"
        ' 
        ' lblRoomType1
        ' 
        lblRoomType1.AutoSize = True
        lblRoomType1.Location = New Point(205, 140)
        lblRoomType1.Name = "lblRoomType1"
        lblRoomType1.Size = New Size(90, 20)
        lblRoomType1.TabIndex = 3
        lblRoomType1.Text = "Small Room"
        ' 
        ' lblPrice1
        ' 
        lblPrice1.AutoSize = True
        lblPrice1.Location = New Point(15, 168)
        lblPrice1.Name = "lblPrice1"
        lblPrice1.Size = New Size(91, 20)
        lblPrice1.TabIndex = 4
        lblPrice1.Text = "RM 30 / Day"
        ' 
        ' lblDescription1
        ' 
        lblDescription1.AutoSize = True
        lblDescription1.Location = New Point(15, 195)
        lblDescription1.Name = "lblDescription1"
        lblDescription1.Size = New Size(159, 20)
        lblDescription1.TabIndex = 5
        lblDescription1.Text = "Comfortable and cozy."
        ' 
        ' btnEdit1
        ' 
        btnEdit1.BackColor = Color.FromArgb(CByte(244), CByte(231), CByte(212))
        btnEdit1.FlatAppearance.BorderSize = 0
        btnEdit1.FlatStyle = FlatStyle.Flat
        btnEdit1.Location = New Point(15, 230)
        btnEdit1.Name = "btnEdit1"
        btnEdit1.Size = New Size(135, 35)
        btnEdit1.TabIndex = 0
        btnEdit1.Text = "Edit"
        btnEdit1.UseVisualStyleBackColor = False
        ' 
        ' btnDelete1
        ' 
        btnDelete1.BackColor = Color.FromArgb(CByte(249), CByte(215), CByte(207))
        btnDelete1.FlatAppearance.BorderSize = 0
        btnDelete1.FlatStyle = FlatStyle.Flat
        btnDelete1.ForeColor = Color.FromArgb(CByte(180), CByte(55), CByte(35))
        btnDelete1.Location = New Point(160, 230)
        btnDelete1.Name = "btnDelete1"
        btnDelete1.Size = New Size(135, 35)
        btnDelete1.TabIndex = 1
        btnDelete1.Text = "Delete"
        btnDelete1.UseVisualStyleBackColor = False
        ' 
        ' pnlRoom2
        ' 
        pnlRoom2.BackColor = Color.White
        pnlRoom2.Controls.Add(picRoom2)
        pnlRoom2.Controls.Add(lblStatus2)
        pnlRoom2.Controls.Add(lblRoomID2)
        pnlRoom2.Controls.Add(lblRoomType2)
        pnlRoom2.Controls.Add(lblPrice2)
        pnlRoom2.Controls.Add(lblDescription2)
        pnlRoom2.Controls.Add(btnEdit2)
        pnlRoom2.Controls.Add(btnDelete2)
        pnlRoom2.Location = New Point(325, 0)
        pnlRoom2.Margin = New Padding(0, 0, 15, 15)
        pnlRoom2.Name = "pnlRoom2"
        pnlRoom2.Size = New Size(310, 285)
        pnlRoom2.TabIndex = 1
        ' 
        ' picRoom2
        ' 
        picRoom2.BackColor = Color.FromArgb(CByte(232), CByte(215), CByte(190))
        picRoom2.Image = CType(resources.GetObject("picRoom2.Image"), Image)
        picRoom2.Location = New Point(10, 10)
        picRoom2.Name = "picRoom2"
        picRoom2.Size = New Size(290, 115)
        picRoom2.SizeMode = PictureBoxSizeMode.Zoom
        picRoom2.TabIndex = 0
        picRoom2.TabStop = False
        ' 
        ' lblStatus2
        ' 
        lblStatus2.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        lblStatus2.ForeColor = Color.White
        lblStatus2.Location = New Point(20, 20)
        lblStatus2.Name = "lblStatus2"
        lblStatus2.Size = New Size(85, 25)
        lblStatus2.TabIndex = 1
        lblStatus2.Text = "Available"
        lblStatus2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblRoomID2
        ' 
        lblRoomID2.AutoSize = True
        lblRoomID2.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        lblRoomID2.ForeColor = Color.FromArgb(CByte(105), CByte(55), CByte(25))
        lblRoomID2.Location = New Point(15, 135)
        lblRoomID2.Name = "lblRoomID2"
        lblRoomID2.Size = New Size(73, 35)
        lblRoomID2.TabIndex = 2
        lblRoomID2.Text = "R002"
        ' 
        ' lblRoomType2
        ' 
        lblRoomType2.AutoSize = True
        lblRoomType2.Location = New Point(195, 140)
        lblRoomType2.Name = "lblRoomType2"
        lblRoomType2.Size = New Size(108, 20)
        lblRoomType2.TabIndex = 3
        lblRoomType2.Text = "Medium Room"
        ' 
        ' lblPrice2
        ' 
        lblPrice2.AutoSize = True
        lblPrice2.Location = New Point(15, 168)
        lblPrice2.Name = "lblPrice2"
        lblPrice2.Size = New Size(91, 20)
        lblPrice2.TabIndex = 4
        lblPrice2.Text = "RM 45 / Day"
        ' 
        ' lblDescription2
        ' 
        lblDescription2.AutoSize = True
        lblDescription2.Location = New Point(15, 195)
        lblDescription2.Name = "lblDescription2"
        lblDescription2.Size = New Size(186, 20)
        lblDescription2.TabIndex = 5
        lblDescription2.Text = "Spacious and comfortable."
        ' 
        ' btnEdit2
        ' 
        btnEdit2.BackColor = Color.FromArgb(CByte(244), CByte(231), CByte(212))
        btnEdit2.FlatAppearance.BorderSize = 0
        btnEdit2.FlatStyle = FlatStyle.Flat
        btnEdit2.Location = New Point(15, 230)
        btnEdit2.Name = "btnEdit2"
        btnEdit2.Size = New Size(135, 35)
        btnEdit2.TabIndex = 6
        btnEdit2.Text = "Edit"
        btnEdit2.UseVisualStyleBackColor = False
        ' 
        ' btnDelete2
        ' 
        btnDelete2.BackColor = Color.FromArgb(CByte(249), CByte(215), CByte(207))
        btnDelete2.FlatAppearance.BorderSize = 0
        btnDelete2.FlatStyle = FlatStyle.Flat
        btnDelete2.ForeColor = Color.FromArgb(CByte(180), CByte(55), CByte(35))
        btnDelete2.Location = New Point(160, 230)
        btnDelete2.Name = "btnDelete2"
        btnDelete2.Size = New Size(135, 35)
        btnDelete2.TabIndex = 7
        btnDelete2.Text = "Delete"
        btnDelete2.UseVisualStyleBackColor = False
        ' 
        ' pnlRoom3
        ' 
        pnlRoom3.BackColor = Color.White
        pnlRoom3.Controls.Add(picRoom3)
        pnlRoom3.Controls.Add(lblStatus3)
        pnlRoom3.Controls.Add(lblRoomID3)
        pnlRoom3.Controls.Add(lblRoomType3)
        pnlRoom3.Controls.Add(lblPrice3)
        pnlRoom3.Controls.Add(lblDescription3)
        pnlRoom3.Controls.Add(btnEdit3)
        pnlRoom3.Controls.Add(btnDelete3)
        pnlRoom3.Location = New Point(650, 0)
        pnlRoom3.Margin = New Padding(0, 0, 15, 15)
        pnlRoom3.Name = "pnlRoom3"
        pnlRoom3.Size = New Size(310, 285)
        pnlRoom3.TabIndex = 2
        ' 
        ' picRoom3
        ' 
        picRoom3.BackColor = Color.FromArgb(CByte(232), CByte(215), CByte(190))
        picRoom3.Image = CType(resources.GetObject("picRoom3.Image"), Image)
        picRoom3.Location = New Point(10, 10)
        picRoom3.Name = "picRoom3"
        picRoom3.Size = New Size(290, 115)
        picRoom3.SizeMode = PictureBoxSizeMode.Zoom
        picRoom3.TabIndex = 0
        picRoom3.TabStop = False
        ' 
        ' lblStatus3
        ' 
        lblStatus3.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        lblStatus3.ForeColor = Color.White
        lblStatus3.Location = New Point(20, 20)
        lblStatus3.Name = "lblStatus3"
        lblStatus3.Size = New Size(85, 25)
        lblStatus3.TabIndex = 1
        lblStatus3.Text = "Available"
        lblStatus3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblRoomID3
        ' 
        lblRoomID3.AutoSize = True
        lblRoomID3.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        lblRoomID3.ForeColor = Color.FromArgb(CByte(105), CByte(55), CByte(25))
        lblRoomID3.Location = New Point(15, 135)
        lblRoomID3.Name = "lblRoomID3"
        lblRoomID3.Size = New Size(73, 35)
        lblRoomID3.TabIndex = 2
        lblRoomID3.Text = "R003"
        ' 
        ' lblRoomType3
        ' 
        lblRoomType3.AutoSize = True
        lblRoomType3.Location = New Point(200, 140)
        lblRoomType3.Name = "lblRoomType3"
        lblRoomType3.Size = New Size(90, 20)
        lblRoomType3.TabIndex = 3
        lblRoomType3.Text = "Large Room"
        ' 
        ' lblPrice3
        ' 
        lblPrice3.AutoSize = True
        lblPrice3.Location = New Point(15, 168)
        lblPrice3.Name = "lblPrice3"
        lblPrice3.Size = New Size(91, 20)
        lblPrice3.TabIndex = 4
        lblPrice3.Text = "RM 60 / Day"
        ' 
        ' lblDescription3
        ' 
        lblDescription3.AutoSize = True
        lblDescription3.Location = New Point(15, 195)
        lblDescription3.Name = "lblDescription3"
        lblDescription3.Size = New Size(155, 20)
        lblDescription3.TabIndex = 5
        lblDescription3.Text = "Perfect for larger pets."
        ' 
        ' btnEdit3
        ' 
        btnEdit3.BackColor = Color.FromArgb(CByte(244), CByte(231), CByte(212))
        btnEdit3.FlatAppearance.BorderSize = 0
        btnEdit3.FlatStyle = FlatStyle.Flat
        btnEdit3.Location = New Point(15, 230)
        btnEdit3.Name = "btnEdit3"
        btnEdit3.Size = New Size(135, 35)
        btnEdit3.TabIndex = 6
        btnEdit3.Text = "Edit"
        btnEdit3.UseVisualStyleBackColor = False
        ' 
        ' btnDelete3
        ' 
        btnDelete3.BackColor = Color.FromArgb(CByte(249), CByte(215), CByte(207))
        btnDelete3.FlatAppearance.BorderSize = 0
        btnDelete3.FlatStyle = FlatStyle.Flat
        btnDelete3.ForeColor = Color.FromArgb(CByte(180), CByte(55), CByte(35))
        btnDelete3.Location = New Point(160, 230)
        btnDelete3.Name = "btnDelete3"
        btnDelete3.Size = New Size(135, 35)
        btnDelete3.TabIndex = 7
        btnDelete3.Text = "Delete"
        btnDelete3.UseVisualStyleBackColor = False
        ' 
        ' pnlRoom4
        ' 
        pnlRoom4.BackColor = Color.White
        pnlRoom4.Controls.Add(picRoom4)
        pnlRoom4.Controls.Add(lblStatus4)
        pnlRoom4.Controls.Add(lblRoomID4)
        pnlRoom4.Controls.Add(lblRoomType4)
        pnlRoom4.Controls.Add(lblPrice4)
        pnlRoom4.Controls.Add(lblDescription4)
        pnlRoom4.Controls.Add(btnEdit4)
        pnlRoom4.Controls.Add(btnDelete4)
        pnlRoom4.Location = New Point(975, 0)
        pnlRoom4.Margin = New Padding(0, 0, 15, 15)
        pnlRoom4.Name = "pnlRoom4"
        pnlRoom4.Size = New Size(310, 285)
        pnlRoom4.TabIndex = 3
        ' 
        ' picRoom4
        ' 
        picRoom4.BackColor = Color.FromArgb(CByte(232), CByte(215), CByte(190))
        picRoom4.Image = CType(resources.GetObject("picRoom4.Image"), Image)
        picRoom4.Location = New Point(10, 10)
        picRoom4.Name = "picRoom4"
        picRoom4.Size = New Size(290, 115)
        picRoom4.SizeMode = PictureBoxSizeMode.Zoom
        picRoom4.TabIndex = 0
        picRoom4.TabStop = False
        ' 
        ' lblStatus4
        ' 
        lblStatus4.BackColor = Color.FromArgb(CByte(220), CByte(90), CByte(80))
        lblStatus4.ForeColor = Color.White
        lblStatus4.Location = New Point(20, 20)
        lblStatus4.Name = "lblStatus4"
        lblStatus4.Size = New Size(85, 25)
        lblStatus4.TabIndex = 1
        lblStatus4.Text = "Occupied"
        lblStatus4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblRoomID4
        ' 
        lblRoomID4.AutoSize = True
        lblRoomID4.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        lblRoomID4.ForeColor = Color.FromArgb(CByte(105), CByte(55), CByte(25))
        lblRoomID4.Location = New Point(15, 135)
        lblRoomID4.Name = "lblRoomID4"
        lblRoomID4.Size = New Size(73, 35)
        lblRoomID4.TabIndex = 2
        lblRoomID4.Text = "R004"
        ' 
        ' lblRoomType4
        ' 
        lblRoomType4.AutoSize = True
        lblRoomType4.Location = New Point(205, 140)
        lblRoomType4.Name = "lblRoomType4"
        lblRoomType4.Size = New Size(90, 20)
        lblRoomType4.TabIndex = 3
        lblRoomType4.Text = "Small Room"
        ' 
        ' lblPrice4
        ' 
        lblPrice4.AutoSize = True
        lblPrice4.Location = New Point(15, 168)
        lblPrice4.Name = "lblPrice4"
        lblPrice4.Size = New Size(91, 20)
        lblPrice4.TabIndex = 4
        lblPrice4.Text = "RM 30 / Day"
        ' 
        ' lblDescription4
        ' 
        lblDescription4.AutoSize = True
        lblDescription4.Location = New Point(15, 195)
        lblDescription4.Name = "lblDescription4"
        lblDescription4.Size = New Size(136, 20)
        lblDescription4.TabIndex = 5
        lblDescription4.Text = "Currently occupied."
        ' 
        ' btnEdit4
        ' 
        btnEdit4.BackColor = Color.FromArgb(CByte(244), CByte(231), CByte(212))
        btnEdit4.FlatAppearance.BorderSize = 0
        btnEdit4.FlatStyle = FlatStyle.Flat
        btnEdit4.Location = New Point(15, 230)
        btnEdit4.Name = "btnEdit4"
        btnEdit4.Size = New Size(135, 35)
        btnEdit4.TabIndex = 6
        btnEdit4.Text = "Edit"
        btnEdit4.UseVisualStyleBackColor = False
        ' 
        ' btnDelete4
        ' 
        btnDelete4.BackColor = Color.FromArgb(CByte(249), CByte(215), CByte(207))
        btnDelete4.FlatAppearance.BorderSize = 0
        btnDelete4.FlatStyle = FlatStyle.Flat
        btnDelete4.ForeColor = Color.FromArgb(CByte(180), CByte(55), CByte(35))
        btnDelete4.Location = New Point(160, 230)
        btnDelete4.Name = "btnDelete4"
        btnDelete4.Size = New Size(135, 35)
        btnDelete4.TabIndex = 7
        btnDelete4.Text = "Delete"
        btnDelete4.UseVisualStyleBackColor = False
        ' 
        ' pnlRoom5
        ' 
        pnlRoom5.BackColor = Color.White
        pnlRoom5.Controls.Add(picRoom5)
        pnlRoom5.Controls.Add(lblStatus5)
        pnlRoom5.Controls.Add(lblRoomID5)
        pnlRoom5.Controls.Add(lblRoomType5)
        pnlRoom5.Controls.Add(lblPrice5)
        pnlRoom5.Controls.Add(lblDescription5)
        pnlRoom5.Controls.Add(btnEdit5)
        pnlRoom5.Controls.Add(btnDelete5)
        pnlRoom5.Location = New Point(0, 300)
        pnlRoom5.Margin = New Padding(0, 0, 15, 15)
        pnlRoom5.Name = "pnlRoom5"
        pnlRoom5.Size = New Size(310, 285)
        pnlRoom5.TabIndex = 4
        ' 
        ' picRoom5
        ' 
        picRoom5.BackColor = Color.FromArgb(CByte(232), CByte(215), CByte(190))
        picRoom5.Image = CType(resources.GetObject("picRoom5.Image"), Image)
        picRoom5.Location = New Point(10, 10)
        picRoom5.Name = "picRoom5"
        picRoom5.Size = New Size(290, 115)
        picRoom5.SizeMode = PictureBoxSizeMode.Zoom
        picRoom5.TabIndex = 0
        picRoom5.TabStop = False
        ' 
        ' lblStatus5
        ' 
        lblStatus5.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        lblStatus5.ForeColor = Color.White
        lblStatus5.Location = New Point(20, 20)
        lblStatus5.Name = "lblStatus5"
        lblStatus5.Size = New Size(85, 25)
        lblStatus5.TabIndex = 1
        lblStatus5.Text = "Available"
        lblStatus5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblRoomID5
        ' 
        lblRoomID5.AutoSize = True
        lblRoomID5.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        lblRoomID5.ForeColor = Color.FromArgb(CByte(105), CByte(55), CByte(25))
        lblRoomID5.Location = New Point(15, 135)
        lblRoomID5.Name = "lblRoomID5"
        lblRoomID5.Size = New Size(73, 35)
        lblRoomID5.TabIndex = 2
        lblRoomID5.Text = "R005"
        ' 
        ' lblRoomType5
        ' 
        lblRoomType5.AutoSize = True
        lblRoomType5.Location = New Point(195, 140)
        lblRoomType5.Name = "lblRoomType5"
        lblRoomType5.Size = New Size(108, 20)
        lblRoomType5.TabIndex = 3
        lblRoomType5.Text = "Medium Room"
        ' 
        ' lblPrice5
        ' 
        lblPrice5.AutoSize = True
        lblPrice5.Location = New Point(15, 168)
        lblPrice5.Name = "lblPrice5"
        lblPrice5.Size = New Size(91, 20)
        lblPrice5.TabIndex = 4
        lblPrice5.Text = "RM 45 / Day"
        ' 
        ' lblDescription5
        ' 
        lblDescription5.AutoSize = True
        lblDescription5.Location = New Point(15, 195)
        lblDescription5.Name = "lblDescription5"
        lblDescription5.Size = New Size(164, 20)
        lblDescription5.TabIndex = 5
        lblDescription5.Text = "Clean and comfortable."
        ' 
        ' btnEdit5
        ' 
        btnEdit5.BackColor = Color.FromArgb(CByte(244), CByte(231), CByte(212))
        btnEdit5.FlatAppearance.BorderSize = 0
        btnEdit5.FlatStyle = FlatStyle.Flat
        btnEdit5.Location = New Point(15, 230)
        btnEdit5.Name = "btnEdit5"
        btnEdit5.Size = New Size(135, 35)
        btnEdit5.TabIndex = 6
        btnEdit5.Text = "Edit"
        btnEdit5.UseVisualStyleBackColor = False
        ' 
        ' btnDelete5
        ' 
        btnDelete5.BackColor = Color.FromArgb(CByte(249), CByte(215), CByte(207))
        btnDelete5.FlatAppearance.BorderSize = 0
        btnDelete5.FlatStyle = FlatStyle.Flat
        btnDelete5.ForeColor = Color.FromArgb(CByte(180), CByte(55), CByte(35))
        btnDelete5.Location = New Point(160, 230)
        btnDelete5.Name = "btnDelete5"
        btnDelete5.Size = New Size(135, 35)
        btnDelete5.TabIndex = 7
        btnDelete5.Text = "Delete"
        btnDelete5.UseVisualStyleBackColor = False
        ' 
        ' pnlRoom6
        ' 
        pnlRoom6.BackColor = Color.White
        pnlRoom6.Controls.Add(picRoom6)
        pnlRoom6.Controls.Add(lblStatus6)
        pnlRoom6.Controls.Add(lblRoomID6)
        pnlRoom6.Controls.Add(lblRoomType6)
        pnlRoom6.Controls.Add(lblPrice6)
        pnlRoom6.Controls.Add(lblDescription6)
        pnlRoom6.Controls.Add(btnEdit6)
        pnlRoom6.Controls.Add(btnDelete6)
        pnlRoom6.Location = New Point(325, 300)
        pnlRoom6.Margin = New Padding(0, 0, 15, 15)
        pnlRoom6.Name = "pnlRoom6"
        pnlRoom6.Size = New Size(310, 285)
        pnlRoom6.TabIndex = 5
        ' 
        ' picRoom6
        ' 
        picRoom6.BackColor = Color.FromArgb(CByte(232), CByte(215), CByte(190))
        picRoom6.Image = CType(resources.GetObject("picRoom6.Image"), Image)
        picRoom6.Location = New Point(10, 10)
        picRoom6.Name = "picRoom6"
        picRoom6.Size = New Size(290, 115)
        picRoom6.SizeMode = PictureBoxSizeMode.Zoom
        picRoom6.TabIndex = 0
        picRoom6.TabStop = False
        ' 
        ' lblStatus6
        ' 
        lblStatus6.BackColor = Color.FromArgb(CByte(220), CByte(90), CByte(80))
        lblStatus6.ForeColor = Color.White
        lblStatus6.Location = New Point(20, 20)
        lblStatus6.Name = "lblStatus6"
        lblStatus6.Size = New Size(85, 25)
        lblStatus6.TabIndex = 1
        lblStatus6.Text = "Occupied"
        lblStatus6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblRoomID6
        ' 
        lblRoomID6.AutoSize = True
        lblRoomID6.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        lblRoomID6.ForeColor = Color.FromArgb(CByte(105), CByte(55), CByte(25))
        lblRoomID6.Location = New Point(15, 135)
        lblRoomID6.Name = "lblRoomID6"
        lblRoomID6.Size = New Size(73, 35)
        lblRoomID6.TabIndex = 2
        lblRoomID6.Text = "R006"
        ' 
        ' lblRoomType6
        ' 
        lblRoomType6.AutoSize = True
        lblRoomType6.Location = New Point(200, 140)
        lblRoomType6.Name = "lblRoomType6"
        lblRoomType6.Size = New Size(90, 20)
        lblRoomType6.TabIndex = 3
        lblRoomType6.Text = "Large Room"
        ' 
        ' lblPrice6
        ' 
        lblPrice6.AutoSize = True
        lblPrice6.Location = New Point(15, 168)
        lblPrice6.Name = "lblPrice6"
        lblPrice6.Size = New Size(91, 20)
        lblPrice6.TabIndex = 4
        lblPrice6.Text = "RM 60 / Day"
        ' 
        ' lblDescription6
        ' 
        lblDescription6.AutoSize = True
        lblDescription6.Location = New Point(15, 195)
        lblDescription6.Name = "lblDescription6"
        lblDescription6.Size = New Size(136, 20)
        lblDescription6.TabIndex = 5
        lblDescription6.Text = "Currently occupied."
        ' 
        ' btnEdit6
        ' 
        btnEdit6.BackColor = Color.FromArgb(CByte(244), CByte(231), CByte(212))
        btnEdit6.FlatAppearance.BorderSize = 0
        btnEdit6.FlatStyle = FlatStyle.Flat
        btnEdit6.Location = New Point(15, 230)
        btnEdit6.Name = "btnEdit6"
        btnEdit6.Size = New Size(135, 35)
        btnEdit6.TabIndex = 6
        btnEdit6.Text = "Edit"
        btnEdit6.UseVisualStyleBackColor = False
        ' 
        ' btnDelete6
        ' 
        btnDelete6.BackColor = Color.FromArgb(CByte(249), CByte(215), CByte(207))
        btnDelete6.FlatAppearance.BorderSize = 0
        btnDelete6.FlatStyle = FlatStyle.Flat
        btnDelete6.ForeColor = Color.FromArgb(CByte(180), CByte(55), CByte(35))
        btnDelete6.Location = New Point(160, 230)
        btnDelete6.Name = "btnDelete6"
        btnDelete6.Size = New Size(135, 35)
        btnDelete6.TabIndex = 7
        btnDelete6.Text = "Delete"
        btnDelete6.UseVisualStyleBackColor = False
        ' 
        ' pnlRoom7
        ' 
        pnlRoom7.BackColor = Color.White
        pnlRoom7.Controls.Add(picRoom7)
        pnlRoom7.Controls.Add(lblStatus7)
        pnlRoom7.Controls.Add(lblRoomID7)
        pnlRoom7.Controls.Add(lblRoomType7)
        pnlRoom7.Controls.Add(lblPrice7)
        pnlRoom7.Controls.Add(lblDescription7)
        pnlRoom7.Controls.Add(btnEdit7)
        pnlRoom7.Controls.Add(btnDelete7)
        pnlRoom7.Location = New Point(650, 300)
        pnlRoom7.Margin = New Padding(0, 0, 15, 15)
        pnlRoom7.Name = "pnlRoom7"
        pnlRoom7.Size = New Size(310, 285)
        pnlRoom7.TabIndex = 6
        ' 
        ' picRoom7
        ' 
        picRoom7.BackColor = Color.FromArgb(CByte(232), CByte(215), CByte(190))
        picRoom7.Image = CType(resources.GetObject("picRoom7.Image"), Image)
        picRoom7.Location = New Point(10, 10)
        picRoom7.Name = "picRoom7"
        picRoom7.Size = New Size(290, 115)
        picRoom7.SizeMode = PictureBoxSizeMode.Zoom
        picRoom7.TabIndex = 0
        picRoom7.TabStop = False
        ' 
        ' lblStatus7
        ' 
        lblStatus7.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        lblStatus7.ForeColor = Color.White
        lblStatus7.Location = New Point(20, 20)
        lblStatus7.Name = "lblStatus7"
        lblStatus7.Size = New Size(85, 25)
        lblStatus7.TabIndex = 1
        lblStatus7.Text = "Available"
        lblStatus7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblRoomID7
        ' 
        lblRoomID7.AutoSize = True
        lblRoomID7.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        lblRoomID7.ForeColor = Color.FromArgb(CByte(105), CByte(55), CByte(25))
        lblRoomID7.Location = New Point(15, 135)
        lblRoomID7.Name = "lblRoomID7"
        lblRoomID7.Size = New Size(73, 35)
        lblRoomID7.TabIndex = 2
        lblRoomID7.Text = "R007"
        ' 
        ' lblRoomType7
        ' 
        lblRoomType7.AutoSize = True
        lblRoomType7.Location = New Point(205, 140)
        lblRoomType7.Name = "lblRoomType7"
        lblRoomType7.Size = New Size(90, 20)
        lblRoomType7.TabIndex = 3
        lblRoomType7.Text = "Small Room"
        ' 
        ' lblPrice7
        ' 
        lblPrice7.AutoSize = True
        lblPrice7.Location = New Point(15, 168)
        lblPrice7.Name = "lblPrice7"
        lblPrice7.Size = New Size(91, 20)
        lblPrice7.TabIndex = 4
        lblPrice7.Text = "RM 30 / Day"
        ' 
        ' lblDescription7
        ' 
        lblDescription7.AutoSize = True
        lblDescription7.Location = New Point(15, 195)
        lblDescription7.Name = "lblDescription7"
        lblDescription7.Size = New Size(168, 20)
        lblDescription7.TabIndex = 5
        lblDescription7.Text = "Cozy space for your pet."
        ' 
        ' btnEdit7
        ' 
        btnEdit7.BackColor = Color.FromArgb(CByte(244), CByte(231), CByte(212))
        btnEdit7.FlatAppearance.BorderSize = 0
        btnEdit7.FlatStyle = FlatStyle.Flat
        btnEdit7.Location = New Point(15, 230)
        btnEdit7.Name = "btnEdit7"
        btnEdit7.Size = New Size(135, 35)
        btnEdit7.TabIndex = 6
        btnEdit7.Text = "Edit"
        btnEdit7.UseVisualStyleBackColor = False
        ' 
        ' btnDelete7
        ' 
        btnDelete7.BackColor = Color.FromArgb(CByte(249), CByte(215), CByte(207))
        btnDelete7.FlatAppearance.BorderSize = 0
        btnDelete7.FlatStyle = FlatStyle.Flat
        btnDelete7.ForeColor = Color.FromArgb(CByte(180), CByte(55), CByte(35))
        btnDelete7.Location = New Point(160, 230)
        btnDelete7.Name = "btnDelete7"
        btnDelete7.Size = New Size(135, 35)
        btnDelete7.TabIndex = 7
        btnDelete7.Text = "Delete"
        btnDelete7.UseVisualStyleBackColor = False
        ' 
        ' pnlRoom8
        ' 
        pnlRoom8.BackColor = Color.White
        pnlRoom8.Controls.Add(picRoom8)
        pnlRoom8.Controls.Add(lblStatus8)
        pnlRoom8.Controls.Add(lblRoomID8)
        pnlRoom8.Controls.Add(lblRoomType8)
        pnlRoom8.Controls.Add(lblPrice8)
        pnlRoom8.Controls.Add(lblDescription8)
        pnlRoom8.Controls.Add(btnEdit8)
        pnlRoom8.Controls.Add(btnDelete8)
        pnlRoom8.Location = New Point(975, 300)
        pnlRoom8.Margin = New Padding(0, 0, 15, 15)
        pnlRoom8.Name = "pnlRoom8"
        pnlRoom8.Size = New Size(310, 285)
        pnlRoom8.TabIndex = 7
        ' 
        ' picRoom8
        ' 
        picRoom8.BackColor = Color.FromArgb(CByte(232), CByte(215), CByte(190))
        picRoom8.Image = CType(resources.GetObject("picRoom8.Image"), Image)
        picRoom8.Location = New Point(10, 10)
        picRoom8.Name = "picRoom8"
        picRoom8.Size = New Size(290, 115)
        picRoom8.SizeMode = PictureBoxSizeMode.Zoom
        picRoom8.TabIndex = 0
        picRoom8.TabStop = False
        ' 
        ' lblStatus8
        ' 
        lblStatus8.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        lblStatus8.ForeColor = Color.White
        lblStatus8.Location = New Point(20, 20)
        lblStatus8.Name = "lblStatus8"
        lblStatus8.Size = New Size(85, 25)
        lblStatus8.TabIndex = 1
        lblStatus8.Text = "Available"
        lblStatus8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblRoomID8
        ' 
        lblRoomID8.AutoSize = True
        lblRoomID8.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        lblRoomID8.ForeColor = Color.FromArgb(CByte(105), CByte(55), CByte(25))
        lblRoomID8.Location = New Point(15, 135)
        lblRoomID8.Name = "lblRoomID8"
        lblRoomID8.Size = New Size(73, 35)
        lblRoomID8.TabIndex = 2
        lblRoomID8.Text = "R008"
        ' 
        ' lblRoomType8
        ' 
        lblRoomType8.AutoSize = True
        lblRoomType8.Location = New Point(195, 140)
        lblRoomType8.Name = "lblRoomType8"
        lblRoomType8.Size = New Size(108, 20)
        lblRoomType8.TabIndex = 3
        lblRoomType8.Text = "Medium Room"
        ' 
        ' lblPrice8
        ' 
        lblPrice8.AutoSize = True
        lblPrice8.Location = New Point(15, 168)
        lblPrice8.Name = "lblPrice8"
        lblPrice8.Size = New Size(91, 20)
        lblPrice8.TabIndex = 4
        lblPrice8.Text = "RM 45 / Day"
        ' 
        ' lblDescription8
        ' 
        lblDescription8.AutoSize = True
        lblDescription8.Location = New Point(15, 195)
        lblDescription8.Name = "lblDescription8"
        lblDescription8.Size = New Size(214, 20)
        lblDescription8.TabIndex = 5
        lblDescription8.Text = "Safe and relaxing environment."
        ' 
        ' btnEdit8
        ' 
        btnEdit8.BackColor = Color.FromArgb(CByte(244), CByte(231), CByte(212))
        btnEdit8.FlatAppearance.BorderSize = 0
        btnEdit8.FlatStyle = FlatStyle.Flat
        btnEdit8.Location = New Point(15, 230)
        btnEdit8.Name = "btnEdit8"
        btnEdit8.Size = New Size(135, 35)
        btnEdit8.TabIndex = 6
        btnEdit8.Text = "Edit"
        btnEdit8.UseVisualStyleBackColor = False
        ' 
        ' btnDelete8
        ' 
        btnDelete8.BackColor = Color.FromArgb(CByte(249), CByte(215), CByte(207))
        btnDelete8.FlatAppearance.BorderSize = 0
        btnDelete8.FlatStyle = FlatStyle.Flat
        btnDelete8.ForeColor = Color.FromArgb(CByte(180), CByte(55), CByte(35))
        btnDelete8.Location = New Point(160, 230)
        btnDelete8.Name = "btnDelete8"
        btnDelete8.Size = New Size(135, 35)
        btnDelete8.TabIndex = 7
        btnDelete8.Text = "Delete"
        btnDelete8.UseVisualStyleBackColor = False
        ' 
        ' btnGoBackDashboard
        ' 
        btnGoBackDashboard.BackColor = Color.FromArgb(CByte(139), CByte(78), CByte(28))
        btnGoBackDashboard.FlatAppearance.BorderSize = 0
        btnGoBackDashboard.FlatStyle = FlatStyle.Flat
        btnGoBackDashboard.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnGoBackDashboard.ForeColor = Color.White
        btnGoBackDashboard.Location = New Point(825, 119)
        btnGoBackDashboard.Name = "btnGoBackDashboard"
        btnGoBackDashboard.Size = New Size(170, 35)
        btnGoBackDashboard.TabIndex = 7
        btnGoBackDashboard.Text = "Dashboard"
        btnGoBackDashboard.UseVisualStyleBackColor = False
        ' 
        ' frmBoardingRoom
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1400, 850)
        Controls.Add(pnlMain)
        Name = "frmBoardingRoom"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Boarding Room Management"
        pnlMain.ResumeLayout(False)
        pnlMain.PerformLayout()
        flpRooms.ResumeLayout(False)
        pnlRoom1.ResumeLayout(False)
        pnlRoom1.PerformLayout()
        CType(picRoom1, ComponentModel.ISupportInitialize).EndInit()
        pnlRoom2.ResumeLayout(False)
        pnlRoom2.PerformLayout()
        CType(picRoom2, ComponentModel.ISupportInitialize).EndInit()
        pnlRoom3.ResumeLayout(False)
        pnlRoom3.PerformLayout()
        CType(picRoom3, ComponentModel.ISupportInitialize).EndInit()
        pnlRoom4.ResumeLayout(False)
        pnlRoom4.PerformLayout()
        CType(picRoom4, ComponentModel.ISupportInitialize).EndInit()
        pnlRoom5.ResumeLayout(False)
        pnlRoom5.PerformLayout()
        CType(picRoom5, ComponentModel.ISupportInitialize).EndInit()
        pnlRoom6.ResumeLayout(False)
        pnlRoom6.PerformLayout()
        CType(picRoom6, ComponentModel.ISupportInitialize).EndInit()
        pnlRoom7.ResumeLayout(False)
        pnlRoom7.PerformLayout()
        CType(picRoom7, ComponentModel.ISupportInitialize).EndInit()
        pnlRoom8.ResumeLayout(False)
        pnlRoom8.PerformLayout()
        CType(picRoom8, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnAddRoom As Button
    Friend WithEvents flpRooms As FlowLayoutPanel

    Friend WithEvents pnlRoom1 As Panel
    Friend WithEvents picRoom1 As PictureBox
    Friend WithEvents lblRoomID1 As Label
    Friend WithEvents lblRoomType1 As Label
    Friend WithEvents lblPrice1 As Label
    Friend WithEvents lblStatus1 As Label
    Friend WithEvents lblDescription1 As Label
    Friend WithEvents btnEdit1 As Button
    Friend WithEvents btnDelete1 As Button

    Friend WithEvents pnlRoom2 As Panel
    Friend WithEvents picRoom2 As PictureBox
    Friend WithEvents lblRoomID2 As Label
    Friend WithEvents lblRoomType2 As Label
    Friend WithEvents lblPrice2 As Label
    Friend WithEvents lblStatus2 As Label
    Friend WithEvents lblDescription2 As Label
    Friend WithEvents btnEdit2 As Button
    Friend WithEvents btnDelete2 As Button

    Friend WithEvents pnlRoom3 As Panel
    Friend WithEvents picRoom3 As PictureBox
    Friend WithEvents lblRoomID3 As Label
    Friend WithEvents lblRoomType3 As Label
    Friend WithEvents lblPrice3 As Label
    Friend WithEvents lblStatus3 As Label
    Friend WithEvents lblDescription3 As Label
    Friend WithEvents btnEdit3 As Button
    Friend WithEvents btnDelete3 As Button

    Friend WithEvents pnlRoom4 As Panel
    Friend WithEvents picRoom4 As PictureBox
    Friend WithEvents lblRoomID4 As Label
    Friend WithEvents lblRoomType4 As Label
    Friend WithEvents lblPrice4 As Label
    Friend WithEvents lblStatus4 As Label
    Friend WithEvents lblDescription4 As Label
    Friend WithEvents btnEdit4 As Button
    Friend WithEvents btnDelete4 As Button

    Friend WithEvents pnlRoom5 As Panel
    Friend WithEvents picRoom5 As PictureBox
    Friend WithEvents lblRoomID5 As Label
    Friend WithEvents lblRoomType5 As Label
    Friend WithEvents lblPrice5 As Label
    Friend WithEvents lblStatus5 As Label
    Friend WithEvents lblDescription5 As Label
    Friend WithEvents btnEdit5 As Button
    Friend WithEvents btnDelete5 As Button

    Friend WithEvents pnlRoom6 As Panel
    Friend WithEvents picRoom6 As PictureBox
    Friend WithEvents lblRoomID6 As Label
    Friend WithEvents lblRoomType6 As Label
    Friend WithEvents lblPrice6 As Label
    Friend WithEvents lblStatus6 As Label
    Friend WithEvents lblDescription6 As Label
    Friend WithEvents btnEdit6 As Button
    Friend WithEvents btnDelete6 As Button

    Friend WithEvents pnlRoom7 As Panel
    Friend WithEvents picRoom7 As PictureBox
    Friend WithEvents lblRoomID7 As Label
    Friend WithEvents lblRoomType7 As Label
    Friend WithEvents lblPrice7 As Label
    Friend WithEvents lblStatus7 As Label
    Friend WithEvents lblDescription7 As Label
    Friend WithEvents btnEdit7 As Button
    Friend WithEvents btnDelete7 As Button

    Friend WithEvents pnlRoom8 As Panel
    Friend WithEvents picRoom8 As PictureBox
    Friend WithEvents lblRoomID8 As Label
    Friend WithEvents lblRoomType8 As Label
    Friend WithEvents lblPrice8 As Label
    Friend WithEvents lblStatus8 As Label
    Friend WithEvents lblDescription8 As Label
    Friend WithEvents btnEdit8 As Button
    Friend WithEvents btnDelete8 As Button
    Friend WithEvents btnGoBackDashboard As Button

End Class
