<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBoardingRoom
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
        btnGoBackDashboard = New Button()
        btnAddRoom = New Button()
        btnRefresh = New Button()
        cboStatus = New ComboBox()
        txtSearch = New TextBox()
        lblSearch = New Label()
        pnlHeader = New Panel()
        lblSubtitle = New Label()
        lblTitle = New Label()
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
        pnlMain.SuspendLayout()
        pnlContent.SuspendLayout()
        flpRooms.SuspendLayout()
        pnlToolbar.SuspendLayout()
        pnlHeader.SuspendLayout()
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
        pnlContent.Controls.Add(flpRooms)
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(20, 175)
        pnlContent.Name = "pnlContent"
        pnlContent.Padding = New Padding(0, 15, 0, 0)
        pnlContent.Size = New Size(1144, 836)
        pnlContent.TabIndex = 2
        '
        ' flpRooms
        '
        flpRooms.AutoScroll = True
        flpRooms.BackColor = Color.FromArgb(CByte(245), CByte(230), CByte(209))
        flpRooms.Controls.Add(pnlRoom1)
        flpRooms.Controls.Add(pnlRoom2)
        flpRooms.Controls.Add(pnlRoom3)
        flpRooms.Controls.Add(pnlRoom4)
        flpRooms.Controls.Add(pnlRoom5)
        flpRooms.Controls.Add(pnlRoom6)
        flpRooms.Controls.Add(pnlRoom7)
        flpRooms.Controls.Add(pnlRoom8)
        flpRooms.Dock = DockStyle.Fill
        flpRooms.FlowDirection = FlowDirection.LeftToRight
        flpRooms.Location = New Point(0, 15)
        flpRooms.Name = "flpRooms"
        flpRooms.Padding = New Padding(5)
        flpRooms.Size = New Size(1144, 821)
        flpRooms.TabIndex = 0
        flpRooms.WrapContents = True
        ' pnlRoom1
        '
        pnlRoom1.BackColor = Color.White
        pnlRoom1.BorderStyle = BorderStyle.FixedSingle
        pnlRoom1.Controls.Add(picRoom1)
        pnlRoom1.Controls.Add(lblStatus1)
        pnlRoom1.Controls.Add(lblRoomID1)
        pnlRoom1.Controls.Add(lblRoomType1)
        pnlRoom1.Controls.Add(lblPrice1)
        pnlRoom1.Controls.Add(lblDescription1)
        pnlRoom1.Controls.Add(btnEdit1)
        pnlRoom1.Controls.Add(btnDelete1)
        pnlRoom1.Location = New Point(15, 15)
        pnlRoom1.Margin = New Padding(10)
        pnlRoom1.Name = "pnlRoom1"
        pnlRoom1.Size = New Size(330, 390)
        pnlRoom1.TabIndex = 0
        '
        ' picRoom1
        '
        picRoom1.BackColor = Color.FromArgb(CByte(232), CByte(216), CByte(194))
        picRoom1.Location = New Point(15, 15)
        picRoom1.Name = "picRoom1"
        picRoom1.Size = New Size(298, 180)
        picRoom1.SizeMode = PictureBoxSizeMode.StretchImage
        picRoom1.TabIndex = 0
        picRoom1.TabStop = False
        '
        ' lblStatus1
        '
        lblStatus1.AutoSize = False
        lblStatus1.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        lblStatus1.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        lblStatus1.ForeColor = Color.White
        lblStatus1.Location = New Point(205, 22)
        lblStatus1.Name = "lblStatus1"
        lblStatus1.Size = New Size(108, 25)
        lblStatus1.TabIndex = 1
        lblStatus1.Text = "Available"
        lblStatus1.TextAlign = ContentAlignment.MiddleCenter
        '
        ' lblRoomID1
        '
        lblRoomID1.AutoEllipsis = True
        lblRoomID1.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        lblRoomID1.ForeColor = Color.FromArgb(CByte(61), CByte(40), CByte(27))
        lblRoomID1.Location = New Point(15, 207)
        lblRoomID1.Name = "lblRoomID1"
        lblRoomID1.Size = New Size(298, 30)
        lblRoomID1.TabIndex = 2
        lblRoomID1.Text = "Room 001"
        '
        ' lblRoomType1
        '
        lblRoomType1.AutoEllipsis = True
        lblRoomType1.Font = New Font("Segoe UI", 9.5F)
        lblRoomType1.ForeColor = Color.DimGray
        lblRoomType1.Location = New Point(15, 242)
        lblRoomType1.Name = "lblRoomType1"
        lblRoomType1.Size = New Size(298, 21)
        lblRoomType1.TabIndex = 3
        lblRoomType1.Text = "Standard Room"
        '
        ' lblPrice1
        '
        lblPrice1.AutoSize = True
        lblPrice1.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        lblPrice1.ForeColor = Color.SaddleBrown
        lblPrice1.Location = New Point(15, 270)
        lblPrice1.Name = "lblPrice1"
        lblPrice1.Size = New Size(100, 25)
        lblPrice1.TabIndex = 4
        lblPrice1.Text = "RM 40.00"
        '
        ' lblDescription1
        '
        lblDescription1.AutoEllipsis = True
        lblDescription1.Font = New Font("Segoe UI", 9.0F)
        lblDescription1.ForeColor = Color.DimGray
        lblDescription1.Location = New Point(15, 296)
        lblDescription1.Name = "lblDescription1"
        lblDescription1.Size = New Size(298, 38)
        lblDescription1.TabIndex = 5
        lblDescription1.Text = "Comfortable boarding room for pets."
        '
        ' btnEdit1
        '
        btnEdit1.BackColor = Color.Sienna
        btnEdit1.FlatAppearance.BorderSize = 0
        btnEdit1.FlatStyle = FlatStyle.Flat
        btnEdit1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnEdit1.ForeColor = Color.WhiteSmoke
        btnEdit1.Location = New Point(15, 345)
        btnEdit1.Name = "btnEdit1"
        btnEdit1.Size = New Size(140, 30)
        btnEdit1.TabIndex = 6
        btnEdit1.Text = "Edit"
        btnEdit1.UseVisualStyleBackColor = False
        '
        ' btnDelete1
        '
        btnDelete1.BackColor = Color.FromArgb(CByte(96), CByte(52), CByte(16))
        btnDelete1.FlatAppearance.BorderSize = 0
        btnDelete1.FlatStyle = FlatStyle.Flat
        btnDelete1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnDelete1.ForeColor = Color.WhiteSmoke
        btnDelete1.Location = New Point(173, 345)
        btnDelete1.Name = "btnDelete1"
        btnDelete1.Size = New Size(140, 30)
        btnDelete1.TabIndex = 7
        btnDelete1.Text = "Delete"
        btnDelete1.UseVisualStyleBackColor = False
        ' pnlRoom2
        '
        pnlRoom2.BackColor = Color.White
        pnlRoom2.BorderStyle = BorderStyle.FixedSingle
        pnlRoom2.Controls.Add(picRoom2)
        pnlRoom2.Controls.Add(lblStatus2)
        pnlRoom2.Controls.Add(lblRoomID2)
        pnlRoom2.Controls.Add(lblRoomType2)
        pnlRoom2.Controls.Add(lblPrice2)
        pnlRoom2.Controls.Add(lblDescription2)
        pnlRoom2.Controls.Add(btnEdit2)
        pnlRoom2.Controls.Add(btnDelete2)
        pnlRoom2.Location = New Point(365, 15)
        pnlRoom2.Margin = New Padding(10)
        pnlRoom2.Name = "pnlRoom2"
        pnlRoom2.Size = New Size(330, 390)
        pnlRoom2.TabIndex = 1
        '
        ' picRoom2
        '
        picRoom2.BackColor = Color.FromArgb(CByte(232), CByte(216), CByte(194))
        picRoom2.Location = New Point(15, 15)
        picRoom2.Name = "picRoom2"
        picRoom2.Size = New Size(298, 180)
        picRoom2.SizeMode = PictureBoxSizeMode.StretchImage
        picRoom2.TabIndex = 0
        picRoom2.TabStop = False
        '
        ' lblStatus2
        '
        lblStatus2.AutoSize = False
        lblStatus2.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        lblStatus2.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        lblStatus2.ForeColor = Color.White
        lblStatus2.Location = New Point(205, 22)
        lblStatus2.Name = "lblStatus2"
        lblStatus2.Size = New Size(108, 25)
        lblStatus2.TabIndex = 1
        lblStatus2.Text = "Available"
        lblStatus2.TextAlign = ContentAlignment.MiddleCenter
        '
        ' lblRoomID2
        '
        lblRoomID2.AutoEllipsis = True
        lblRoomID2.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        lblRoomID2.ForeColor = Color.FromArgb(CByte(61), CByte(40), CByte(27))
        lblRoomID2.Location = New Point(15, 207)
        lblRoomID2.Name = "lblRoomID2"
        lblRoomID2.Size = New Size(298, 30)
        lblRoomID2.TabIndex = 2
        lblRoomID2.Text = "Room 001"
        '
        ' lblRoomType2
        '
        lblRoomType2.AutoEllipsis = True
        lblRoomType2.Font = New Font("Segoe UI", 9.5F)
        lblRoomType2.ForeColor = Color.DimGray
        lblRoomType2.Location = New Point(15, 242)
        lblRoomType2.Name = "lblRoomType2"
        lblRoomType2.Size = New Size(298, 21)
        lblRoomType2.TabIndex = 3
        lblRoomType2.Text = "Standard Room"
        '
        ' lblPrice2
        '
        lblPrice2.AutoSize = True
        lblPrice2.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        lblPrice2.ForeColor = Color.SaddleBrown
        lblPrice2.Location = New Point(15, 270)
        lblPrice2.Name = "lblPrice2"
        lblPrice2.Size = New Size(100, 25)
        lblPrice2.TabIndex = 4
        lblPrice2.Text = "RM 40.00"
        '
        ' lblDescription2
        '
        lblDescription2.AutoEllipsis = True
        lblDescription2.Font = New Font("Segoe UI", 9.0F)
        lblDescription2.ForeColor = Color.DimGray
        lblDescription2.Location = New Point(15, 296)
        lblDescription2.Name = "lblDescription2"
        lblDescription2.Size = New Size(298, 38)
        lblDescription2.TabIndex = 5
        lblDescription2.Text = "Comfortable boarding room for pets."
        '
        ' btnEdit2
        '
        btnEdit2.BackColor = Color.Sienna
        btnEdit2.FlatAppearance.BorderSize = 0
        btnEdit2.FlatStyle = FlatStyle.Flat
        btnEdit2.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnEdit2.ForeColor = Color.WhiteSmoke
        btnEdit2.Location = New Point(15, 345)
        btnEdit2.Name = "btnEdit2"
        btnEdit2.Size = New Size(140, 30)
        btnEdit2.TabIndex = 6
        btnEdit2.Text = "Edit"
        btnEdit2.UseVisualStyleBackColor = False
        '
        ' btnDelete2
        '
        btnDelete2.BackColor = Color.FromArgb(CByte(96), CByte(52), CByte(16))
        btnDelete2.FlatAppearance.BorderSize = 0
        btnDelete2.FlatStyle = FlatStyle.Flat
        btnDelete2.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnDelete2.ForeColor = Color.WhiteSmoke
        btnDelete2.Location = New Point(173, 345)
        btnDelete2.Name = "btnDelete2"
        btnDelete2.Size = New Size(140, 30)
        btnDelete2.TabIndex = 7
        btnDelete2.Text = "Delete"
        btnDelete2.UseVisualStyleBackColor = False
        ' pnlRoom3
        '
        pnlRoom3.BackColor = Color.White
        pnlRoom3.BorderStyle = BorderStyle.FixedSingle
        pnlRoom3.Controls.Add(picRoom3)
        pnlRoom3.Controls.Add(lblStatus3)
        pnlRoom3.Controls.Add(lblRoomID3)
        pnlRoom3.Controls.Add(lblRoomType3)
        pnlRoom3.Controls.Add(lblPrice3)
        pnlRoom3.Controls.Add(lblDescription3)
        pnlRoom3.Controls.Add(btnEdit3)
        pnlRoom3.Controls.Add(btnDelete3)
        pnlRoom3.Location = New Point(715, 15)
        pnlRoom3.Margin = New Padding(10)
        pnlRoom3.Name = "pnlRoom3"
        pnlRoom3.Size = New Size(330, 390)
        pnlRoom3.TabIndex = 2
        '
        ' picRoom3
        '
        picRoom3.BackColor = Color.FromArgb(CByte(232), CByte(216), CByte(194))
        picRoom3.Location = New Point(15, 15)
        picRoom3.Name = "picRoom3"
        picRoom3.Size = New Size(298, 180)
        picRoom3.SizeMode = PictureBoxSizeMode.StretchImage
        picRoom3.TabIndex = 0
        picRoom3.TabStop = False
        '
        ' lblStatus3
        '
        lblStatus3.AutoSize = False
        lblStatus3.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        lblStatus3.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        lblStatus3.ForeColor = Color.White
        lblStatus3.Location = New Point(205, 22)
        lblStatus3.Name = "lblStatus3"
        lblStatus3.Size = New Size(108, 25)
        lblStatus3.TabIndex = 1
        lblStatus3.Text = "Available"
        lblStatus3.TextAlign = ContentAlignment.MiddleCenter
        '
        ' lblRoomID3
        '
        lblRoomID3.AutoEllipsis = True
        lblRoomID3.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        lblRoomID3.ForeColor = Color.FromArgb(CByte(61), CByte(40), CByte(27))
        lblRoomID3.Location = New Point(15, 207)
        lblRoomID3.Name = "lblRoomID3"
        lblRoomID3.Size = New Size(298, 30)
        lblRoomID3.TabIndex = 2
        lblRoomID3.Text = "Room 001"
        '
        ' lblRoomType3
        '
        lblRoomType3.AutoEllipsis = True
        lblRoomType3.Font = New Font("Segoe UI", 9.5F)
        lblRoomType3.ForeColor = Color.DimGray
        lblRoomType3.Location = New Point(15, 242)
        lblRoomType3.Name = "lblRoomType3"
        lblRoomType3.Size = New Size(298, 21)
        lblRoomType3.TabIndex = 3
        lblRoomType3.Text = "Standard Room"
        '
        ' lblPrice3
        '
        lblPrice3.AutoSize = True
        lblPrice3.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        lblPrice3.ForeColor = Color.SaddleBrown
        lblPrice3.Location = New Point(15, 270)
        lblPrice3.Name = "lblPrice3"
        lblPrice3.Size = New Size(100, 25)
        lblPrice3.TabIndex = 4
        lblPrice3.Text = "RM 40.00"
        '
        ' lblDescription3
        '
        lblDescription3.AutoEllipsis = True
        lblDescription3.Font = New Font("Segoe UI", 9.0F)
        lblDescription3.ForeColor = Color.DimGray
        lblDescription3.Location = New Point(15, 296)
        lblDescription3.Name = "lblDescription3"
        lblDescription3.Size = New Size(298, 38)
        lblDescription3.TabIndex = 5
        lblDescription3.Text = "Comfortable boarding room for pets."
        '
        ' btnEdit3
        '
        btnEdit3.BackColor = Color.Sienna
        btnEdit3.FlatAppearance.BorderSize = 0
        btnEdit3.FlatStyle = FlatStyle.Flat
        btnEdit3.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnEdit3.ForeColor = Color.WhiteSmoke
        btnEdit3.Location = New Point(15, 345)
        btnEdit3.Name = "btnEdit3"
        btnEdit3.Size = New Size(140, 30)
        btnEdit3.TabIndex = 6
        btnEdit3.Text = "Edit"
        btnEdit3.UseVisualStyleBackColor = False
        '
        ' btnDelete3
        '
        btnDelete3.BackColor = Color.FromArgb(CByte(96), CByte(52), CByte(16))
        btnDelete3.FlatAppearance.BorderSize = 0
        btnDelete3.FlatStyle = FlatStyle.Flat
        btnDelete3.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnDelete3.ForeColor = Color.WhiteSmoke
        btnDelete3.Location = New Point(173, 345)
        btnDelete3.Name = "btnDelete3"
        btnDelete3.Size = New Size(140, 30)
        btnDelete3.TabIndex = 7
        btnDelete3.Text = "Delete"
        btnDelete3.UseVisualStyleBackColor = False
        ' pnlRoom4
        '
        pnlRoom4.BackColor = Color.White
        pnlRoom4.BorderStyle = BorderStyle.FixedSingle
        pnlRoom4.Controls.Add(picRoom4)
        pnlRoom4.Controls.Add(lblStatus4)
        pnlRoom4.Controls.Add(lblRoomID4)
        pnlRoom4.Controls.Add(lblRoomType4)
        pnlRoom4.Controls.Add(lblPrice4)
        pnlRoom4.Controls.Add(lblDescription4)
        pnlRoom4.Controls.Add(btnEdit4)
        pnlRoom4.Controls.Add(btnDelete4)
        pnlRoom4.Location = New Point(15, 425)
        pnlRoom4.Margin = New Padding(10)
        pnlRoom4.Name = "pnlRoom4"
        pnlRoom4.Size = New Size(330, 390)
        pnlRoom4.TabIndex = 3
        '
        ' picRoom4
        '
        picRoom4.BackColor = Color.FromArgb(CByte(232), CByte(216), CByte(194))
        picRoom4.Location = New Point(15, 15)
        picRoom4.Name = "picRoom4"
        picRoom4.Size = New Size(298, 180)
        picRoom4.SizeMode = PictureBoxSizeMode.StretchImage
        picRoom4.TabIndex = 0
        picRoom4.TabStop = False
        '
        ' lblStatus4
        '
        lblStatus4.AutoSize = False
        lblStatus4.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        lblStatus4.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        lblStatus4.ForeColor = Color.White
        lblStatus4.Location = New Point(205, 22)
        lblStatus4.Name = "lblStatus4"
        lblStatus4.Size = New Size(108, 25)
        lblStatus4.TabIndex = 1
        lblStatus4.Text = "Available"
        lblStatus4.TextAlign = ContentAlignment.MiddleCenter
        '
        ' lblRoomID4
        '
        lblRoomID4.AutoEllipsis = True
        lblRoomID4.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        lblRoomID4.ForeColor = Color.FromArgb(CByte(61), CByte(40), CByte(27))
        lblRoomID4.Location = New Point(15, 207)
        lblRoomID4.Name = "lblRoomID4"
        lblRoomID4.Size = New Size(298, 30)
        lblRoomID4.TabIndex = 2
        lblRoomID4.Text = "Room 001"
        '
        ' lblRoomType4
        '
        lblRoomType4.AutoEllipsis = True
        lblRoomType4.Font = New Font("Segoe UI", 9.5F)
        lblRoomType4.ForeColor = Color.DimGray
        lblRoomType4.Location = New Point(15, 242)
        lblRoomType4.Name = "lblRoomType4"
        lblRoomType4.Size = New Size(298, 21)
        lblRoomType4.TabIndex = 3
        lblRoomType4.Text = "Standard Room"
        '
        ' lblPrice4
        '
        lblPrice4.AutoSize = True
        lblPrice4.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        lblPrice4.ForeColor = Color.SaddleBrown
        lblPrice4.Location = New Point(15, 270)
        lblPrice4.Name = "lblPrice4"
        lblPrice4.Size = New Size(100, 25)
        lblPrice4.TabIndex = 4
        lblPrice4.Text = "RM 40.00"
        '
        ' lblDescription4
        '
        lblDescription4.AutoEllipsis = True
        lblDescription4.Font = New Font("Segoe UI", 9.0F)
        lblDescription4.ForeColor = Color.DimGray
        lblDescription4.Location = New Point(15, 296)
        lblDescription4.Name = "lblDescription4"
        lblDescription4.Size = New Size(298, 38)
        lblDescription4.TabIndex = 5
        lblDescription4.Text = "Comfortable boarding room for pets."
        '
        ' btnEdit4
        '
        btnEdit4.BackColor = Color.Sienna
        btnEdit4.FlatAppearance.BorderSize = 0
        btnEdit4.FlatStyle = FlatStyle.Flat
        btnEdit4.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnEdit4.ForeColor = Color.WhiteSmoke
        btnEdit4.Location = New Point(15, 345)
        btnEdit4.Name = "btnEdit4"
        btnEdit4.Size = New Size(140, 30)
        btnEdit4.TabIndex = 6
        btnEdit4.Text = "Edit"
        btnEdit4.UseVisualStyleBackColor = False
        '
        ' btnDelete4
        '
        btnDelete4.BackColor = Color.FromArgb(CByte(96), CByte(52), CByte(16))
        btnDelete4.FlatAppearance.BorderSize = 0
        btnDelete4.FlatStyle = FlatStyle.Flat
        btnDelete4.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnDelete4.ForeColor = Color.WhiteSmoke
        btnDelete4.Location = New Point(173, 345)
        btnDelete4.Name = "btnDelete4"
        btnDelete4.Size = New Size(140, 30)
        btnDelete4.TabIndex = 7
        btnDelete4.Text = "Delete"
        btnDelete4.UseVisualStyleBackColor = False
        ' pnlRoom5
        '
        pnlRoom5.BackColor = Color.White
        pnlRoom5.BorderStyle = BorderStyle.FixedSingle
        pnlRoom5.Controls.Add(picRoom5)
        pnlRoom5.Controls.Add(lblStatus5)
        pnlRoom5.Controls.Add(lblRoomID5)
        pnlRoom5.Controls.Add(lblRoomType5)
        pnlRoom5.Controls.Add(lblPrice5)
        pnlRoom5.Controls.Add(lblDescription5)
        pnlRoom5.Controls.Add(btnEdit5)
        pnlRoom5.Controls.Add(btnDelete5)
        pnlRoom5.Location = New Point(365, 425)
        pnlRoom5.Margin = New Padding(10)
        pnlRoom5.Name = "pnlRoom5"
        pnlRoom5.Size = New Size(330, 390)
        pnlRoom5.TabIndex = 4
        '
        ' picRoom5
        '
        picRoom5.BackColor = Color.FromArgb(CByte(232), CByte(216), CByte(194))
        picRoom5.Location = New Point(15, 15)
        picRoom5.Name = "picRoom5"
        picRoom5.Size = New Size(298, 180)
        picRoom5.SizeMode = PictureBoxSizeMode.StretchImage
        picRoom5.TabIndex = 0
        picRoom5.TabStop = False
        '
        ' lblStatus5
        '
        lblStatus5.AutoSize = False
        lblStatus5.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        lblStatus5.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        lblStatus5.ForeColor = Color.White
        lblStatus5.Location = New Point(205, 22)
        lblStatus5.Name = "lblStatus5"
        lblStatus5.Size = New Size(108, 25)
        lblStatus5.TabIndex = 1
        lblStatus5.Text = "Available"
        lblStatus5.TextAlign = ContentAlignment.MiddleCenter
        '
        ' lblRoomID5
        '
        lblRoomID5.AutoEllipsis = True
        lblRoomID5.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        lblRoomID5.ForeColor = Color.FromArgb(CByte(61), CByte(40), CByte(27))
        lblRoomID5.Location = New Point(15, 207)
        lblRoomID5.Name = "lblRoomID5"
        lblRoomID5.Size = New Size(298, 30)
        lblRoomID5.TabIndex = 2
        lblRoomID5.Text = "Room 001"
        '
        ' lblRoomType5
        '
        lblRoomType5.AutoEllipsis = True
        lblRoomType5.Font = New Font("Segoe UI", 9.5F)
        lblRoomType5.ForeColor = Color.DimGray
        lblRoomType5.Location = New Point(15, 242)
        lblRoomType5.Name = "lblRoomType5"
        lblRoomType5.Size = New Size(298, 21)
        lblRoomType5.TabIndex = 3
        lblRoomType5.Text = "Standard Room"
        '
        ' lblPrice5
        '
        lblPrice5.AutoSize = True
        lblPrice5.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        lblPrice5.ForeColor = Color.SaddleBrown
        lblPrice5.Location = New Point(15, 270)
        lblPrice5.Name = "lblPrice5"
        lblPrice5.Size = New Size(100, 25)
        lblPrice5.TabIndex = 4
        lblPrice5.Text = "RM 40.00"
        '
        ' lblDescription5
        '
        lblDescription5.AutoEllipsis = True
        lblDescription5.Font = New Font("Segoe UI", 9.0F)
        lblDescription5.ForeColor = Color.DimGray
        lblDescription5.Location = New Point(15, 296)
        lblDescription5.Name = "lblDescription5"
        lblDescription5.Size = New Size(298, 38)
        lblDescription5.TabIndex = 5
        lblDescription5.Text = "Comfortable boarding room for pets."
        '
        ' btnEdit5
        '
        btnEdit5.BackColor = Color.Sienna
        btnEdit5.FlatAppearance.BorderSize = 0
        btnEdit5.FlatStyle = FlatStyle.Flat
        btnEdit5.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnEdit5.ForeColor = Color.WhiteSmoke
        btnEdit5.Location = New Point(15, 345)
        btnEdit5.Name = "btnEdit5"
        btnEdit5.Size = New Size(140, 30)
        btnEdit5.TabIndex = 6
        btnEdit5.Text = "Edit"
        btnEdit5.UseVisualStyleBackColor = False
        '
        ' btnDelete5
        '
        btnDelete5.BackColor = Color.FromArgb(CByte(96), CByte(52), CByte(16))
        btnDelete5.FlatAppearance.BorderSize = 0
        btnDelete5.FlatStyle = FlatStyle.Flat
        btnDelete5.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnDelete5.ForeColor = Color.WhiteSmoke
        btnDelete5.Location = New Point(173, 345)
        btnDelete5.Name = "btnDelete5"
        btnDelete5.Size = New Size(140, 30)
        btnDelete5.TabIndex = 7
        btnDelete5.Text = "Delete"
        btnDelete5.UseVisualStyleBackColor = False
        ' pnlRoom6
        '
        pnlRoom6.BackColor = Color.White
        pnlRoom6.BorderStyle = BorderStyle.FixedSingle
        pnlRoom6.Controls.Add(picRoom6)
        pnlRoom6.Controls.Add(lblStatus6)
        pnlRoom6.Controls.Add(lblRoomID6)
        pnlRoom6.Controls.Add(lblRoomType6)
        pnlRoom6.Controls.Add(lblPrice6)
        pnlRoom6.Controls.Add(lblDescription6)
        pnlRoom6.Controls.Add(btnEdit6)
        pnlRoom6.Controls.Add(btnDelete6)
        pnlRoom6.Location = New Point(715, 425)
        pnlRoom6.Margin = New Padding(10)
        pnlRoom6.Name = "pnlRoom6"
        pnlRoom6.Size = New Size(330, 390)
        pnlRoom6.TabIndex = 5
        '
        ' picRoom6
        '
        picRoom6.BackColor = Color.FromArgb(CByte(232), CByte(216), CByte(194))
        picRoom6.Location = New Point(15, 15)
        picRoom6.Name = "picRoom6"
        picRoom6.Size = New Size(298, 180)
        picRoom6.SizeMode = PictureBoxSizeMode.StretchImage
        picRoom6.TabIndex = 0
        picRoom6.TabStop = False
        '
        ' lblStatus6
        '
        lblStatus6.AutoSize = False
        lblStatus6.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        lblStatus6.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        lblStatus6.ForeColor = Color.White
        lblStatus6.Location = New Point(205, 22)
        lblStatus6.Name = "lblStatus6"
        lblStatus6.Size = New Size(108, 25)
        lblStatus6.TabIndex = 1
        lblStatus6.Text = "Available"
        lblStatus6.TextAlign = ContentAlignment.MiddleCenter
        '
        ' lblRoomID6
        '
        lblRoomID6.AutoEllipsis = True
        lblRoomID6.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        lblRoomID6.ForeColor = Color.FromArgb(CByte(61), CByte(40), CByte(27))
        lblRoomID6.Location = New Point(15, 207)
        lblRoomID6.Name = "lblRoomID6"
        lblRoomID6.Size = New Size(298, 30)
        lblRoomID6.TabIndex = 2
        lblRoomID6.Text = "Room 001"
        '
        ' lblRoomType6
        '
        lblRoomType6.AutoEllipsis = True
        lblRoomType6.Font = New Font("Segoe UI", 9.5F)
        lblRoomType6.ForeColor = Color.DimGray
        lblRoomType6.Location = New Point(15, 242)
        lblRoomType6.Name = "lblRoomType6"
        lblRoomType6.Size = New Size(298, 21)
        lblRoomType6.TabIndex = 3
        lblRoomType6.Text = "Standard Room"
        '
        ' lblPrice6
        '
        lblPrice6.AutoSize = True
        lblPrice6.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        lblPrice6.ForeColor = Color.SaddleBrown
        lblPrice6.Location = New Point(15, 270)
        lblPrice6.Name = "lblPrice6"
        lblPrice6.Size = New Size(100, 25)
        lblPrice6.TabIndex = 4
        lblPrice6.Text = "RM 40.00"
        '
        ' lblDescription6
        '
        lblDescription6.AutoEllipsis = True
        lblDescription6.Font = New Font("Segoe UI", 9.0F)
        lblDescription6.ForeColor = Color.DimGray
        lblDescription6.Location = New Point(15, 296)
        lblDescription6.Name = "lblDescription6"
        lblDescription6.Size = New Size(298, 38)
        lblDescription6.TabIndex = 5
        lblDescription6.Text = "Comfortable boarding room for pets."
        '
        ' btnEdit6
        '
        btnEdit6.BackColor = Color.Sienna
        btnEdit6.FlatAppearance.BorderSize = 0
        btnEdit6.FlatStyle = FlatStyle.Flat
        btnEdit6.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnEdit6.ForeColor = Color.WhiteSmoke
        btnEdit6.Location = New Point(15, 345)
        btnEdit6.Name = "btnEdit6"
        btnEdit6.Size = New Size(140, 30)
        btnEdit6.TabIndex = 6
        btnEdit6.Text = "Edit"
        btnEdit6.UseVisualStyleBackColor = False
        '
        ' btnDelete6
        '
        btnDelete6.BackColor = Color.FromArgb(CByte(96), CByte(52), CByte(16))
        btnDelete6.FlatAppearance.BorderSize = 0
        btnDelete6.FlatStyle = FlatStyle.Flat
        btnDelete6.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnDelete6.ForeColor = Color.WhiteSmoke
        btnDelete6.Location = New Point(173, 345)
        btnDelete6.Name = "btnDelete6"
        btnDelete6.Size = New Size(140, 30)
        btnDelete6.TabIndex = 7
        btnDelete6.Text = "Delete"
        btnDelete6.UseVisualStyleBackColor = False
        ' pnlRoom7
        '
        pnlRoom7.BackColor = Color.White
        pnlRoom7.BorderStyle = BorderStyle.FixedSingle
        pnlRoom7.Controls.Add(picRoom7)
        pnlRoom7.Controls.Add(lblStatus7)
        pnlRoom7.Controls.Add(lblRoomID7)
        pnlRoom7.Controls.Add(lblRoomType7)
        pnlRoom7.Controls.Add(lblPrice7)
        pnlRoom7.Controls.Add(lblDescription7)
        pnlRoom7.Controls.Add(btnEdit7)
        pnlRoom7.Controls.Add(btnDelete7)
        pnlRoom7.Location = New Point(15, 835)
        pnlRoom7.Margin = New Padding(10)
        pnlRoom7.Name = "pnlRoom7"
        pnlRoom7.Size = New Size(330, 390)
        pnlRoom7.TabIndex = 6
        '
        ' picRoom7
        '
        picRoom7.BackColor = Color.FromArgb(CByte(232), CByte(216), CByte(194))
        picRoom7.Location = New Point(15, 15)
        picRoom7.Name = "picRoom7"
        picRoom7.Size = New Size(298, 180)
        picRoom7.SizeMode = PictureBoxSizeMode.StretchImage
        picRoom7.TabIndex = 0
        picRoom7.TabStop = False
        '
        ' lblStatus7
        '
        lblStatus7.AutoSize = False
        lblStatus7.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        lblStatus7.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        lblStatus7.ForeColor = Color.White
        lblStatus7.Location = New Point(205, 22)
        lblStatus7.Name = "lblStatus7"
        lblStatus7.Size = New Size(108, 25)
        lblStatus7.TabIndex = 1
        lblStatus7.Text = "Available"
        lblStatus7.TextAlign = ContentAlignment.MiddleCenter
        '
        ' lblRoomID7
        '
        lblRoomID7.AutoEllipsis = True
        lblRoomID7.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        lblRoomID7.ForeColor = Color.FromArgb(CByte(61), CByte(40), CByte(27))
        lblRoomID7.Location = New Point(15, 207)
        lblRoomID7.Name = "lblRoomID7"
        lblRoomID7.Size = New Size(298, 30)
        lblRoomID7.TabIndex = 2
        lblRoomID7.Text = "Room 001"
        '
        ' lblRoomType7
        '
        lblRoomType7.AutoEllipsis = True
        lblRoomType7.Font = New Font("Segoe UI", 9.5F)
        lblRoomType7.ForeColor = Color.DimGray
        lblRoomType7.Location = New Point(15, 242)
        lblRoomType7.Name = "lblRoomType7"
        lblRoomType7.Size = New Size(298, 21)
        lblRoomType7.TabIndex = 3
        lblRoomType7.Text = "Standard Room"
        '
        ' lblPrice7
        '
        lblPrice7.AutoSize = True
        lblPrice7.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        lblPrice7.ForeColor = Color.SaddleBrown
        lblPrice7.Location = New Point(15, 270)
        lblPrice7.Name = "lblPrice7"
        lblPrice7.Size = New Size(100, 25)
        lblPrice7.TabIndex = 4
        lblPrice7.Text = "RM 40.00"
        '
        ' lblDescription7
        '
        lblDescription7.AutoEllipsis = True
        lblDescription7.Font = New Font("Segoe UI", 9.0F)
        lblDescription7.ForeColor = Color.DimGray
        lblDescription7.Location = New Point(15, 296)
        lblDescription7.Name = "lblDescription7"
        lblDescription7.Size = New Size(298, 38)
        lblDescription7.TabIndex = 5
        lblDescription7.Text = "Comfortable boarding room for pets."
        '
        ' btnEdit7
        '
        btnEdit7.BackColor = Color.Sienna
        btnEdit7.FlatAppearance.BorderSize = 0
        btnEdit7.FlatStyle = FlatStyle.Flat
        btnEdit7.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnEdit7.ForeColor = Color.WhiteSmoke
        btnEdit7.Location = New Point(15, 345)
        btnEdit7.Name = "btnEdit7"
        btnEdit7.Size = New Size(140, 30)
        btnEdit7.TabIndex = 6
        btnEdit7.Text = "Edit"
        btnEdit7.UseVisualStyleBackColor = False
        '
        ' btnDelete7
        '
        btnDelete7.BackColor = Color.FromArgb(CByte(96), CByte(52), CByte(16))
        btnDelete7.FlatAppearance.BorderSize = 0
        btnDelete7.FlatStyle = FlatStyle.Flat
        btnDelete7.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnDelete7.ForeColor = Color.WhiteSmoke
        btnDelete7.Location = New Point(173, 345)
        btnDelete7.Name = "btnDelete7"
        btnDelete7.Size = New Size(140, 30)
        btnDelete7.TabIndex = 7
        btnDelete7.Text = "Delete"
        btnDelete7.UseVisualStyleBackColor = False
        ' pnlRoom8
        '
        pnlRoom8.BackColor = Color.White
        pnlRoom8.BorderStyle = BorderStyle.FixedSingle
        pnlRoom8.Controls.Add(picRoom8)
        pnlRoom8.Controls.Add(lblStatus8)
        pnlRoom8.Controls.Add(lblRoomID8)
        pnlRoom8.Controls.Add(lblRoomType8)
        pnlRoom8.Controls.Add(lblPrice8)
        pnlRoom8.Controls.Add(lblDescription8)
        pnlRoom8.Controls.Add(btnEdit8)
        pnlRoom8.Controls.Add(btnDelete8)
        pnlRoom8.Location = New Point(365, 835)
        pnlRoom8.Margin = New Padding(10)
        pnlRoom8.Name = "pnlRoom8"
        pnlRoom8.Size = New Size(330, 390)
        pnlRoom8.TabIndex = 7
        '
        ' picRoom8
        '
        picRoom8.BackColor = Color.FromArgb(CByte(232), CByte(216), CByte(194))
        picRoom8.Location = New Point(15, 15)
        picRoom8.Name = "picRoom8"
        picRoom8.Size = New Size(298, 180)
        picRoom8.SizeMode = PictureBoxSizeMode.StretchImage
        picRoom8.TabIndex = 0
        picRoom8.TabStop = False
        '
        ' lblStatus8
        '
        lblStatus8.AutoSize = False
        lblStatus8.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        lblStatus8.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        lblStatus8.ForeColor = Color.White
        lblStatus8.Location = New Point(205, 22)
        lblStatus8.Name = "lblStatus8"
        lblStatus8.Size = New Size(108, 25)
        lblStatus8.TabIndex = 1
        lblStatus8.Text = "Available"
        lblStatus8.TextAlign = ContentAlignment.MiddleCenter
        '
        ' lblRoomID8
        '
        lblRoomID8.AutoEllipsis = True
        lblRoomID8.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        lblRoomID8.ForeColor = Color.FromArgb(CByte(61), CByte(40), CByte(27))
        lblRoomID8.Location = New Point(15, 207)
        lblRoomID8.Name = "lblRoomID8"
        lblRoomID8.Size = New Size(298, 30)
        lblRoomID8.TabIndex = 2
        lblRoomID8.Text = "Room 001"
        '
        ' lblRoomType8
        '
        lblRoomType8.AutoEllipsis = True
        lblRoomType8.Font = New Font("Segoe UI", 9.5F)
        lblRoomType8.ForeColor = Color.DimGray
        lblRoomType8.Location = New Point(15, 242)
        lblRoomType8.Name = "lblRoomType8"
        lblRoomType8.Size = New Size(298, 21)
        lblRoomType8.TabIndex = 3
        lblRoomType8.Text = "Standard Room"
        '
        ' lblPrice8
        '
        lblPrice8.AutoSize = True
        lblPrice8.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        lblPrice8.ForeColor = Color.SaddleBrown
        lblPrice8.Location = New Point(15, 270)
        lblPrice8.Name = "lblPrice8"
        lblPrice8.Size = New Size(100, 25)
        lblPrice8.TabIndex = 4
        lblPrice8.Text = "RM 40.00"
        '
        ' lblDescription8
        '
        lblDescription8.AutoEllipsis = True
        lblDescription8.Font = New Font("Segoe UI", 9.0F)
        lblDescription8.ForeColor = Color.DimGray
        lblDescription8.Location = New Point(15, 296)
        lblDescription8.Name = "lblDescription8"
        lblDescription8.Size = New Size(298, 38)
        lblDescription8.TabIndex = 5
        lblDescription8.Text = "Comfortable boarding room for pets."
        '
        ' btnEdit8
        '
        btnEdit8.BackColor = Color.Sienna
        btnEdit8.FlatAppearance.BorderSize = 0
        btnEdit8.FlatStyle = FlatStyle.Flat
        btnEdit8.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnEdit8.ForeColor = Color.WhiteSmoke
        btnEdit8.Location = New Point(15, 345)
        btnEdit8.Name = "btnEdit8"
        btnEdit8.Size = New Size(140, 30)
        btnEdit8.TabIndex = 6
        btnEdit8.Text = "Edit"
        btnEdit8.UseVisualStyleBackColor = False
        '
        ' btnDelete8
        '
        btnDelete8.BackColor = Color.FromArgb(CByte(96), CByte(52), CByte(16))
        btnDelete8.FlatAppearance.BorderSize = 0
        btnDelete8.FlatStyle = FlatStyle.Flat
        btnDelete8.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnDelete8.ForeColor = Color.WhiteSmoke
        btnDelete8.Location = New Point(173, 345)
        btnDelete8.Name = "btnDelete8"
        btnDelete8.Size = New Size(140, 30)
        btnDelete8.TabIndex = 7
        btnDelete8.Text = "Delete"
        btnDelete8.UseVisualStyleBackColor = False

        '
        ' pnlToolbar
        '
        pnlToolbar.BackColor = Color.FromArgb(CByte(232), CByte(216), CByte(194))
        pnlToolbar.Controls.Add(btnGoBackDashboard)
        pnlToolbar.Controls.Add(btnAddRoom)
        pnlToolbar.Controls.Add(btnRefresh)
        pnlToolbar.Controls.Add(cboStatus)
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
        ' btnAddRoom
        '
        btnAddRoom.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnAddRoom.BackColor = Color.FromArgb(CByte(96), CByte(52), CByte(16))
        btnAddRoom.FlatAppearance.BorderSize = 0
        btnAddRoom.FlatStyle = FlatStyle.Flat
        btnAddRoom.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnAddRoom.ForeColor = Color.WhiteSmoke
        btnAddRoom.Location = New Point(725, 15)
        btnAddRoom.Name = "btnAddRoom"
        btnAddRoom.Size = New Size(190, 40)
        btnAddRoom.TabIndex = 1
        btnAddRoom.Text = "+ Add Boarding Room"
        btnAddRoom.UseVisualStyleBackColor = False
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
        ' cboStatus
        '
        cboStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cboStatus.Font = New Font("Segoe UI", 10.0F)
        cboStatus.FormattingEnabled = True
        cboStatus.Items.AddRange(New Object() {"All Status", "Available", "Occupied"})
        cboStatus.Location = New Point(395, 20)
        cboStatus.Name = "cboStatus"
        cboStatus.Size = New Size(140, 29)
        cboStatus.TabIndex = 3
        '
        ' txtSearch
        '
        txtSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtSearch.Font = New Font("Segoe UI", 10.0F)
        txtSearch.Location = New Point(90, 18)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(285, 30)
        txtSearch.TabIndex = 4
        txtSearch.Text = "Search boarding room..."
        '
        ' lblSearch
        '
        lblSearch.AutoSize = True
        lblSearch.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblSearch.ForeColor = Color.SaddleBrown
        lblSearch.Location = New Point(15, 22)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(63, 23)
        lblSearch.TabIndex = 5
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
        lblSubtitle.Size = New Size(420, 21)
        lblSubtitle.TabIndex = 0
        lblSubtitle.Text = "Manage boarding rooms, availability and room pricing."
        '
        ' lblTitle
        '
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Georgia", 20.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(CByte(61), CByte(40), CByte(27))
        lblTitle.Location = New Point(18, 12)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(550, 39)
        lblTitle.TabIndex = 1
        lblTitle.Text = "Boarding Room Management"
        '
        ' frmBoardingRoom
        '
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(245), CByte(230), CByte(209))
        ClientSize = New Size(1184, 1031)
        Controls.Add(pnlMain)
        MinimumSize = New Size(1050, 650)
        Name = "frmBoardingRoom"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Boarding Room Management"
        pnlMain.ResumeLayout(False)
        pnlContent.ResumeLayout(False)
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
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnAddRoom As Button
    Friend WithEvents btnGoBackDashboard As Button
    Friend WithEvents pnlContent As Panel
    Friend WithEvents flpRooms As FlowLayoutPanel

    Friend WithEvents pnlRoom1 As Panel
    Friend WithEvents picRoom1 As PictureBox
    Friend WithEvents lblStatus1 As Label
    Friend WithEvents lblRoomID1 As Label
    Friend WithEvents lblRoomType1 As Label
    Friend WithEvents lblPrice1 As Label
    Friend WithEvents lblDescription1 As Label
    Friend WithEvents btnEdit1 As Button
    Friend WithEvents btnDelete1 As Button
    Friend WithEvents pnlRoom2 As Panel
    Friend WithEvents picRoom2 As PictureBox
    Friend WithEvents lblStatus2 As Label
    Friend WithEvents lblRoomID2 As Label
    Friend WithEvents lblRoomType2 As Label
    Friend WithEvents lblPrice2 As Label
    Friend WithEvents lblDescription2 As Label
    Friend WithEvents btnEdit2 As Button
    Friend WithEvents btnDelete2 As Button
    Friend WithEvents pnlRoom3 As Panel
    Friend WithEvents picRoom3 As PictureBox
    Friend WithEvents lblStatus3 As Label
    Friend WithEvents lblRoomID3 As Label
    Friend WithEvents lblRoomType3 As Label
    Friend WithEvents lblPrice3 As Label
    Friend WithEvents lblDescription3 As Label
    Friend WithEvents btnEdit3 As Button
    Friend WithEvents btnDelete3 As Button
    Friend WithEvents pnlRoom4 As Panel
    Friend WithEvents picRoom4 As PictureBox
    Friend WithEvents lblStatus4 As Label
    Friend WithEvents lblRoomID4 As Label
    Friend WithEvents lblRoomType4 As Label
    Friend WithEvents lblPrice4 As Label
    Friend WithEvents lblDescription4 As Label
    Friend WithEvents btnEdit4 As Button
    Friend WithEvents btnDelete4 As Button
    Friend WithEvents pnlRoom5 As Panel
    Friend WithEvents picRoom5 As PictureBox
    Friend WithEvents lblStatus5 As Label
    Friend WithEvents lblRoomID5 As Label
    Friend WithEvents lblRoomType5 As Label
    Friend WithEvents lblPrice5 As Label
    Friend WithEvents lblDescription5 As Label
    Friend WithEvents btnEdit5 As Button
    Friend WithEvents btnDelete5 As Button
    Friend WithEvents pnlRoom6 As Panel
    Friend WithEvents picRoom6 As PictureBox
    Friend WithEvents lblStatus6 As Label
    Friend WithEvents lblRoomID6 As Label
    Friend WithEvents lblRoomType6 As Label
    Friend WithEvents lblPrice6 As Label
    Friend WithEvents lblDescription6 As Label
    Friend WithEvents btnEdit6 As Button
    Friend WithEvents btnDelete6 As Button
    Friend WithEvents pnlRoom7 As Panel
    Friend WithEvents picRoom7 As PictureBox
    Friend WithEvents lblStatus7 As Label
    Friend WithEvents lblRoomID7 As Label
    Friend WithEvents lblRoomType7 As Label
    Friend WithEvents lblPrice7 As Label
    Friend WithEvents lblDescription7 As Label
    Friend WithEvents btnEdit7 As Button
    Friend WithEvents btnDelete7 As Button
    Friend WithEvents pnlRoom8 As Panel
    Friend WithEvents picRoom8 As PictureBox
    Friend WithEvents lblStatus8 As Label
    Friend WithEvents lblRoomID8 As Label
    Friend WithEvents lblRoomType8 As Label
    Friend WithEvents lblPrice8 As Label
    Friend WithEvents lblDescription8 As Label
    Friend WithEvents btnEdit8 As Button
    Friend WithEvents btnDelete8 As Button
End Class
