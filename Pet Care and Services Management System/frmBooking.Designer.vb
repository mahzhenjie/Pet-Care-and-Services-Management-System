<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBooking
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()

        Me.pnlGroomingBooking = New System.Windows.Forms.Panel()

        Me.btnGoBackDashboard = New System.Windows.Forms.Button()
        Me.btnAddGroomingBooking = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()

        Me.lblGroomingBookings = New System.Windows.Forms.Label()
        Me.dgvGroomingBooking = New System.Windows.Forms.DataGridView()
        Me.colGroomingBookingID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPetID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colServiceID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBookingDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBookingTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEdit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colDelete = New System.Windows.Forms.DataGridViewButtonColumn()

        Me.lblBoardingBookings = New System.Windows.Forms.Label()
        Me.dgvBoardingBooking = New System.Windows.Forms.DataGridView()
        Me.colBoardingBookingID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBoardingPetID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBoardingRoomID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBoardingStartDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBoardingEndDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBoardingStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBoardingEdit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colBoardingDelete = New System.Windows.Forms.DataGridViewButtonColumn()

        Me.pnlGroomingBooking.SuspendLayout()
        CType(Me.dgvGroomingBooking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBoardingBooking, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        '
        'pnlGroomingBooking
        '
        Me.pnlGroomingBooking.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
        Me.pnlGroomingBooking.BackColor = System.Drawing.Color.FromArgb(CByte(245), CByte(230), CByte(209))
        Me.pnlGroomingBooking.Controls.Add(Me.btnGoBackDashboard)
        Me.pnlGroomingBooking.Controls.Add(Me.btnAddGroomingBooking)
        Me.pnlGroomingBooking.Controls.Add(Me.btnRefresh)
        Me.pnlGroomingBooking.Controls.Add(Me.txtSearch)
        Me.pnlGroomingBooking.Controls.Add(Me.lblTitle)
        Me.pnlGroomingBooking.Controls.Add(Me.lblGroomingBookings)
        Me.pnlGroomingBooking.Controls.Add(Me.dgvGroomingBooking)
        Me.pnlGroomingBooking.Controls.Add(Me.lblBoardingBookings)
        Me.pnlGroomingBooking.Controls.Add(Me.dgvBoardingBooking)
        Me.pnlGroomingBooking.Location = New System.Drawing.Point(15, 15)
        Me.pnlGroomingBooking.Name = "pnlGroomingBooking"
        Me.pnlGroomingBooking.Padding = New System.Windows.Forms.Padding(20)
        Me.pnlGroomingBooking.Size = New System.Drawing.Size(1130, 770)
        Me.pnlGroomingBooking.TabIndex = 2

        '
        'btnGoBackDashboard
        '
        Me.btnGoBackDashboard.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
        Me.btnGoBackDashboard.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnGoBackDashboard.FlatAppearance.BorderSize = 0
        Me.btnGoBackDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGoBackDashboard.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
        Me.btnGoBackDashboard.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnGoBackDashboard.Location = New System.Drawing.Point(625, 82)
        Me.btnGoBackDashboard.Name = "btnGoBackDashboard"
        Me.btnGoBackDashboard.Size = New System.Drawing.Size(145, 38)
        Me.btnGoBackDashboard.TabIndex = 8
        Me.btnGoBackDashboard.Text = "Dashboard"
        Me.btnGoBackDashboard.UseVisualStyleBackColor = False

        '
        'btnAddGroomingBooking
        '
        Me.btnAddGroomingBooking.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
        Me.btnAddGroomingBooking.BackColor = System.Drawing.Color.FromArgb(CByte(96), CByte(52), CByte(16))
        Me.btnAddGroomingBooking.FlatAppearance.BorderSize = 0
        Me.btnAddGroomingBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddGroomingBooking.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
        Me.btnAddGroomingBooking.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddGroomingBooking.Location = New System.Drawing.Point(930, 82)
        Me.btnAddGroomingBooking.Name = "btnAddGroomingBooking"
        Me.btnAddGroomingBooking.Size = New System.Drawing.Size(160, 38)
        Me.btnAddGroomingBooking.TabIndex = 6
        Me.btnAddGroomingBooking.Text = "+ Add Booking"
        Me.btnAddGroomingBooking.UseVisualStyleBackColor = False

        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
        Me.btnRefresh.BackColor = System.Drawing.Color.Sienna
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
        Me.btnRefresh.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnRefresh.Location = New System.Drawing.Point(785, 82)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(130, 38)
        Me.btnRefresh.TabIndex = 3
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False

        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.White
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
        Me.txtSearch.ForeColor = System.Drawing.Color.FromArgb(CByte(107), CByte(98), CByte(91))
        Me.txtSearch.Location = New System.Drawing.Point(20, 84)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(575, 27)
        Me.txtSearch.TabIndex = 1
        Me.txtSearch.Text = "Search booking..."

        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Lucida Sans Unicode", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CByte(61), CByte(40), CByte(27))
        Me.lblTitle.Location = New System.Drawing.Point(20, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(320, 33)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Booking Management"

        '
        'lblGroomingBookings
        '
        Me.lblGroomingBookings.AutoSize = True
        Me.lblGroomingBookings.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
        Me.lblGroomingBookings.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblGroomingBookings.Location = New System.Drawing.Point(20, 125)
        Me.lblGroomingBookings.Name = "lblGroomingBookings"
        Me.lblGroomingBookings.Size = New System.Drawing.Size(180, 18)
        Me.lblGroomingBookings.TabIndex = 9
        Me.lblGroomingBookings.Text = "GROOMING BOOKINGS"

        '
        'dgvGroomingBooking
        '
        Me.dgvGroomingBooking.AllowUserToAddRows = False
        Me.dgvGroomingBooking.AllowUserToDeleteRows = False
        Me.dgvGroomingBooking.AllowUserToResizeRows = False
        Me.dgvGroomingBooking.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
        Me.dgvGroomingBooking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvGroomingBooking.BackgroundColor = System.Drawing.Color.FromArgb(CByte(250), CByte(247), CByte(240))
        Me.dgvGroomingBooking.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvGroomingBooking.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvGroomingBooking.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvGroomingBooking.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvGroomingBooking.ColumnHeadersHeight = 38
        Me.dgvGroomingBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvGroomingBooking.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {
            Me.colGroomingBookingID,
            Me.colPetID,
            Me.colServiceID,
            Me.colBookingDate,
            Me.colBookingTime,
            Me.colStatus,
            Me.colEdit,
            Me.colDelete
        })
        Me.dgvGroomingBooking.GridColor = System.Drawing.Color.FromArgb(CByte(225), CByte(211), CByte(192))
        Me.dgvGroomingBooking.Location = New System.Drawing.Point(20, 150)
        Me.dgvGroomingBooking.MultiSelect = False
        Me.dgvGroomingBooking.Name = "dgvGroomingBooking"
        Me.dgvGroomingBooking.ReadOnly = True
        Me.dgvGroomingBooking.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgvGroomingBooking.RowHeadersVisible = False
        Me.dgvGroomingBooking.RowTemplate.Height = 38
        Me.dgvGroomingBooking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGroomingBooking.Size = New System.Drawing.Size(1090, 260)
        Me.dgvGroomingBooking.TabIndex = 10

        '
        'colGroomingBookingID
        '
        Me.colGroomingBookingID.FillWeight = 125.0!
        Me.colGroomingBookingID.HeaderText = "Booking ID"
        Me.colGroomingBookingID.MinimumWidth = 6
        Me.colGroomingBookingID.Name = "colGroomingBookingID"
        Me.colGroomingBookingID.ReadOnly = True

        '
        'colPetID
        '
        Me.colPetID.FillWeight = 75.0!
        Me.colPetID.HeaderText = "Pet ID"
        Me.colPetID.MinimumWidth = 6
        Me.colPetID.Name = "colPetID"
        Me.colPetID.ReadOnly = True

        '
        'colServiceID
        '
        Me.colServiceID.FillWeight = 85.0!
        Me.colServiceID.HeaderText = "Service ID"
        Me.colServiceID.MinimumWidth = 6
        Me.colServiceID.Name = "colServiceID"
        Me.colServiceID.ReadOnly = True

        '
        'colBookingDate
        '
        Me.colBookingDate.FillWeight = 120.0!
        Me.colBookingDate.HeaderText = "Booking Date"
        Me.colBookingDate.MinimumWidth = 6
        Me.colBookingDate.Name = "colBookingDate"
        Me.colBookingDate.ReadOnly = True

        '
        'colBookingTime
        '
        Me.colBookingTime.FillWeight = 120.0!
        Me.colBookingTime.HeaderText = "Booking Time"
        Me.colBookingTime.MinimumWidth = 6
        Me.colBookingTime.Name = "colBookingTime"
        Me.colBookingTime.ReadOnly = True

        '
        'colStatus
        '
        Me.colStatus.FillWeight = 105.0!
        Me.colStatus.HeaderText = "Status"
        Me.colStatus.MinimumWidth = 6
        Me.colStatus.Name = "colStatus"
        Me.colStatus.ReadOnly = True

        '
        'colEdit
        '
        Me.colEdit.FillWeight = 70.0!
        Me.colEdit.HeaderText = "Edit"
        Me.colEdit.MinimumWidth = 6
        Me.colEdit.Name = "colEdit"
        Me.colEdit.ReadOnly = True
        Me.colEdit.Text = "Edit"
        Me.colEdit.UseColumnTextForButtonValue = True

        '
        'colDelete
        '
        Me.colDelete.FillWeight = 75.0!
        Me.colDelete.HeaderText = "Delete"
        Me.colDelete.MinimumWidth = 6
        Me.colDelete.Name = "colDelete"
        Me.colDelete.ReadOnly = True
        Me.colDelete.Text = "Delete"
        Me.colDelete.UseColumnTextForButtonValue = True

        '
        'lblBoardingBookings
        '
        Me.lblBoardingBookings.AutoSize = True
        Me.lblBoardingBookings.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
        Me.lblBoardingBookings.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblBoardingBookings.Location = New System.Drawing.Point(20, 425)
        Me.lblBoardingBookings.Name = "lblBoardingBookings"
        Me.lblBoardingBookings.Size = New System.Drawing.Size(175, 18)
        Me.lblBoardingBookings.TabIndex = 11
        Me.lblBoardingBookings.Text = "BOARDING BOOKINGS"

        '
        'dgvBoardingBooking
        '
        Me.dgvBoardingBooking.AllowUserToAddRows = False
        Me.dgvBoardingBooking.AllowUserToDeleteRows = False
        Me.dgvBoardingBooking.AllowUserToResizeRows = False
        Me.dgvBoardingBooking.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
        Me.dgvBoardingBooking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBoardingBooking.BackgroundColor = System.Drawing.Color.FromArgb(CByte(250), CByte(247), CByte(240))
        Me.dgvBoardingBooking.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvBoardingBooking.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvBoardingBooking.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvBoardingBooking.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvBoardingBooking.ColumnHeadersHeight = 38
        Me.dgvBoardingBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvBoardingBooking.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {
            Me.colBoardingBookingID,
            Me.colBoardingPetID,
            Me.colBoardingRoomID,
            Me.colBoardingStartDate,
            Me.colBoardingEndDate,
            Me.colBoardingStatus,
            Me.colBoardingEdit,
            Me.colBoardingDelete
        })
        Me.dgvBoardingBooking.GridColor = System.Drawing.Color.FromArgb(CByte(225), CByte(211), CByte(192))
        Me.dgvBoardingBooking.Location = New System.Drawing.Point(20, 450)
        Me.dgvBoardingBooking.MultiSelect = False
        Me.dgvBoardingBooking.Name = "dgvBoardingBooking"
        Me.dgvBoardingBooking.ReadOnly = True
        Me.dgvBoardingBooking.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgvBoardingBooking.RowHeadersVisible = False
        Me.dgvBoardingBooking.RowTemplate.Height = 38
        Me.dgvBoardingBooking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBoardingBooking.Size = New System.Drawing.Size(1090, 295)
        Me.dgvBoardingBooking.TabIndex = 12

        '
        'colBoardingBookingID
        '
        Me.colBoardingBookingID.FillWeight = 125.0!
        Me.colBoardingBookingID.HeaderText = "Booking ID"
        Me.colBoardingBookingID.MinimumWidth = 6
        Me.colBoardingBookingID.Name = "colBoardingBookingID"
        Me.colBoardingBookingID.ReadOnly = True

        '
        'colBoardingPetID
        '
        Me.colBoardingPetID.FillWeight = 75.0!
        Me.colBoardingPetID.HeaderText = "Pet ID"
        Me.colBoardingPetID.MinimumWidth = 6
        Me.colBoardingPetID.Name = "colBoardingPetID"
        Me.colBoardingPetID.ReadOnly = True

        '
        'colBoardingRoomID
        '
        Me.colBoardingRoomID.FillWeight = 85.0!
        Me.colBoardingRoomID.HeaderText = "Room ID"
        Me.colBoardingRoomID.MinimumWidth = 6
        Me.colBoardingRoomID.Name = "colBoardingRoomID"
        Me.colBoardingRoomID.ReadOnly = True

        '
        'colBoardingStartDate
        '
        Me.colBoardingStartDate.FillWeight = 120.0!
        Me.colBoardingStartDate.HeaderText = "Start Date"
        Me.colBoardingStartDate.MinimumWidth = 6
        Me.colBoardingStartDate.Name = "colBoardingStartDate"
        Me.colBoardingStartDate.ReadOnly = True

        '
        'colBoardingEndDate
        '
        Me.colBoardingEndDate.FillWeight = 120.0!
        Me.colBoardingEndDate.HeaderText = "End Date"
        Me.colBoardingEndDate.MinimumWidth = 6
        Me.colBoardingEndDate.Name = "colBoardingEndDate"
        Me.colBoardingEndDate.ReadOnly = True

        '
        'colBoardingStatus
        '
        Me.colBoardingStatus.FillWeight = 105.0!
        Me.colBoardingStatus.HeaderText = "Status"
        Me.colBoardingStatus.MinimumWidth = 6
        Me.colBoardingStatus.Name = "colBoardingStatus"
        Me.colBoardingStatus.ReadOnly = True

        '
        'colBoardingEdit
        '
        Me.colBoardingEdit.FillWeight = 70.0!
        Me.colBoardingEdit.HeaderText = "Edit"
        Me.colBoardingEdit.MinimumWidth = 6
        Me.colBoardingEdit.Name = "colBoardingEdit"
        Me.colBoardingEdit.ReadOnly = True
        Me.colBoardingEdit.Text = "Edit"
        Me.colBoardingEdit.UseColumnTextForButtonValue = True

        '
        'colBoardingDelete
        '
        Me.colBoardingDelete.FillWeight = 75.0!
        Me.colBoardingDelete.HeaderText = "Delete"
        Me.colBoardingDelete.MinimumWidth = 6
        Me.colBoardingDelete.Name = "colBoardingDelete"
        Me.colBoardingDelete.ReadOnly = True
        Me.colBoardingDelete.Text = "Delete"
        Me.colBoardingDelete.UseColumnTextForButtonValue = True

        '
        'frmBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CByte(247), CByte(232), CByte(213))
        Me.ClientSize = New System.Drawing.Size(1160, 800)
        Me.Controls.Add(Me.pnlGroomingBooking)
        Me.MinimumSize = New System.Drawing.Size(1050, 700)
        Me.Name = "frmBooking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Booking Management"
        Me.pnlGroomingBooking.ResumeLayout(False)
        Me.pnlGroomingBooking.PerformLayout()
        CType(Me.dgvGroomingBooking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBoardingBooking, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlGroomingBooking As Panel
    Friend WithEvents btnAddGroomingBooking As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblTitle As Label

    Friend WithEvents lblGroomingBookings As Label
    Friend WithEvents dgvGroomingBooking As DataGridView
    Friend WithEvents colGroomingBookingID As DataGridViewTextBoxColumn
    Friend WithEvents colPetID As DataGridViewTextBoxColumn
    Friend WithEvents colServiceID As DataGridViewTextBoxColumn
    Friend WithEvents colBookingDate As DataGridViewTextBoxColumn
    Friend WithEvents colBookingTime As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents colEdit As DataGridViewButtonColumn
    Friend WithEvents colDelete As DataGridViewButtonColumn

    Friend WithEvents lblBoardingBookings As Label
    Friend WithEvents dgvBoardingBooking As DataGridView
    Friend WithEvents colBoardingBookingID As DataGridViewTextBoxColumn
    Friend WithEvents colBoardingPetID As DataGridViewTextBoxColumn
    Friend WithEvents colBoardingRoomID As DataGridViewTextBoxColumn
    Friend WithEvents colBoardingStartDate As DataGridViewTextBoxColumn
    Friend WithEvents colBoardingEndDate As DataGridViewTextBoxColumn
    Friend WithEvents colBoardingStatus As DataGridViewTextBoxColumn
    Friend WithEvents colBoardingEdit As DataGridViewButtonColumn
    Friend WithEvents colBoardingDelete As DataGridViewButtonColumn

    Friend WithEvents btnGoBackDashboard As Button

End Class