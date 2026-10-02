<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGroomingBooking
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

    'NOTE: The following procedure is required by the Windows Form Designer.
    'It can be modified using the code editor.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pnlGroomingBooking = New Panel()
        dgvGroomingBooking = New DataGridView()
        colGroomingBookingID = New DataGridViewTextBoxColumn()
        colPetID = New DataGridViewTextBoxColumn()
        colServiceID = New DataGridViewTextBoxColumn()
        colBookingDate = New DataGridViewTextBoxColumn()
        colBookingTime = New DataGridViewTextBoxColumn()
        colStatus = New DataGridViewTextBoxColumn()
        colEdit = New DataGridViewButtonColumn()
        colDelete = New DataGridViewButtonColumn()
        btnAddGroomingBooking = New Button()
        btnRefresh = New Button()
        txtSearch = New TextBox()
        lblTitle = New Label()
        btnGoBackDashboard = New Button()
        pnlGroomingBooking.SuspendLayout()
        CType(dgvGroomingBooking, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlGroomingBooking
        ' 
        pnlGroomingBooking.Anchor = CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles)
        pnlGroomingBooking.BackColor = Color.FromArgb(245, 230, 209)
        pnlGroomingBooking.Controls.Add(btnGoBackDashboard)
        pnlGroomingBooking.Controls.Add(dgvGroomingBooking)
        pnlGroomingBooking.Controls.Add(btnAddGroomingBooking)
        pnlGroomingBooking.Controls.Add(btnRefresh)
        pnlGroomingBooking.Controls.Add(txtSearch)
        pnlGroomingBooking.Controls.Add(lblTitle)
        pnlGroomingBooking.Location = New Point(15, 15)
        pnlGroomingBooking.Name = "pnlGroomingBooking"
        pnlGroomingBooking.Padding = New Padding(20)
        pnlGroomingBooking.Size = New Size(1130, 770)
        pnlGroomingBooking.TabIndex = 2
        ' 
        ' dgvGroomingBooking
        ' 
        dgvGroomingBooking.AllowUserToAddRows = False
        dgvGroomingBooking.AllowUserToDeleteRows = False
        dgvGroomingBooking.AllowUserToResizeRows = False
        dgvGroomingBooking.Anchor = CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles)
        dgvGroomingBooking.AutoGenerateColumns = False
        dgvGroomingBooking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvGroomingBooking.BackgroundColor = Color.FromArgb(250, 247, 240)
        dgvGroomingBooking.BorderStyle = BorderStyle.None
        dgvGroomingBooking.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvGroomingBooking.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvGroomingBooking.ColumnHeadersDefaultCellStyle = New DataGridViewCellStyle With {
            .BackColor = Color.FromArgb(96, 52, 16),
            .ForeColor = Color.WhiteSmoke,
            .Font = New Font("Segoe UI", 9.5F, FontStyle.Bold),
            .Alignment = DataGridViewContentAlignment.MiddleLeft,
            .SelectionBackColor = Color.FromArgb(96, 52, 16),
            .SelectionForeColor = Color.WhiteSmoke
        }
        dgvGroomingBooking.ColumnHeadersHeight = 42
        dgvGroomingBooking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvGroomingBooking.Columns.AddRange(New DataGridViewColumn() {
            colGroomingBookingID,
            colPetID,
            colServiceID,
            colBookingDate,
            colBookingTime,
            colStatus,
            colEdit,
            colDelete
        })
        dgvGroomingBooking.DefaultCellStyle = New DataGridViewCellStyle With {
            .BackColor = Color.White,
            .ForeColor = Color.FromArgb(61, 40, 27),
            .Font = New Font("Segoe UI", 9.0F),
            .SelectionBackColor = Color.FromArgb(232, 216, 194),
            .SelectionForeColor = Color.FromArgb(61, 40, 27),
            .Alignment = DataGridViewContentAlignment.MiddleLeft
        }
        dgvGroomingBooking.GridColor = Color.FromArgb(225, 211, 192)
        dgvGroomingBooking.Location = New Point(20, 140)
        dgvGroomingBooking.MultiSelect = False
        dgvGroomingBooking.Name = "dgvGroomingBooking"
        dgvGroomingBooking.ReadOnly = True
        dgvGroomingBooking.RightToLeft = RightToLeft.No
        dgvGroomingBooking.RowHeadersVisible = False
        dgvGroomingBooking.RowTemplate.Height = 38
        dgvGroomingBooking.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvGroomingBooking.Size = New Size(1090, 605)
        dgvGroomingBooking.TabIndex = 7
        ' 
        ' colGroomingBookingID
        ' 
        colGroomingBookingID.FillWeight = 125.0F
        colGroomingBookingID.HeaderText = "Booking ID"
        colGroomingBookingID.MinimumWidth = 6
        colGroomingBookingID.Name = "colGroomingBookingID"
        colGroomingBookingID.ReadOnly = True
        ' 
        ' colPetID
        ' 
        colPetID.FillWeight = 75.0F
        colPetID.HeaderText = "Pet ID"
        colPetID.MinimumWidth = 6
        colPetID.Name = "colPetID"
        colPetID.ReadOnly = True
        ' 
        ' colServiceID
        ' 
        colServiceID.FillWeight = 85.0F
        colServiceID.HeaderText = "Service ID"
        colServiceID.MinimumWidth = 6
        colServiceID.Name = "colServiceID"
        colServiceID.ReadOnly = True
        ' 
        ' colBookingDate
        ' 
        colBookingDate.FillWeight = 120.0F
        colBookingDate.HeaderText = "Booking Date"
        colBookingDate.MinimumWidth = 6
        colBookingDate.Name = "colBookingDate"
        colBookingDate.ReadOnly = True
        ' 
        ' colBookingTime
        ' 
        colBookingTime.FillWeight = 120.0F
        colBookingTime.HeaderText = "Booking Time"
        colBookingTime.MinimumWidth = 6
        colBookingTime.Name = "colBookingTime"
        colBookingTime.ReadOnly = True
        ' 
        ' colStatus
        ' 
        colStatus.FillWeight = 105.0F
        colStatus.HeaderText = "Status"
        colStatus.MinimumWidth = 6
        colStatus.Name = "colStatus"
        colStatus.ReadOnly = True
        ' 
        ' colEdit
        ' 
        colEdit.FillWeight = 70.0F
        colEdit.HeaderText = "Edit"
        colEdit.MinimumWidth = 6
        colEdit.Name = "colEdit"
        colEdit.ReadOnly = True
        colEdit.Resizable = DataGridViewTriState.True
        colEdit.SortMode = DataGridViewColumnSortMode.Automatic
        colEdit.Text = "Edit"
        colEdit.UseColumnTextForButtonValue = True
        ' 
        ' colDelete
        ' 
        colDelete.FillWeight = 75.0F
        colDelete.HeaderText = "Delete"
        colDelete.MinimumWidth = 6
        colDelete.Name = "colDelete"
        colDelete.ReadOnly = True
        colDelete.Resizable = DataGridViewTriState.True
        colDelete.SortMode = DataGridViewColumnSortMode.Automatic
        colDelete.Text = "Delete"
        colDelete.UseColumnTextForButtonValue = True
        ' 
        ' btnAddGroomingBooking
        ' 
        btnAddGroomingBooking.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnAddGroomingBooking.BackColor = Color.FromArgb(96, 52, 16)
        btnAddGroomingBooking.FlatAppearance.BorderSize = 0
        btnAddGroomingBooking.FlatStyle = FlatStyle.Flat
        btnAddGroomingBooking.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnAddGroomingBooking.ForeColor = Color.WhiteSmoke
        btnAddGroomingBooking.Location = New Point(930, 82)
        btnAddGroomingBooking.Name = "btnAddGroomingBooking"
        btnAddGroomingBooking.Size = New Size(160, 38)
        btnAddGroomingBooking.TabIndex = 6
        btnAddGroomingBooking.Text = "+ Add Booking"
        btnAddGroomingBooking.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnRefresh.BackColor = Color.Sienna
        btnRefresh.FlatAppearance.BorderSize = 0
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnRefresh.ForeColor = Color.WhiteSmoke
        btnRefresh.Location = New Point(785, 82)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(130, 38)
        btnRefresh.TabIndex = 3
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        txtSearch.BackColor = Color.White
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Font = New Font("Segoe UI", 10.0F)
        txtSearch.ForeColor = Color.FromArgb(107, 98, 91)
        txtSearch.Location = New Point(20, 84)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(575, 30)
        txtSearch.TabIndex = 1
        txtSearch.Text = "Search booking..."
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Georgia", 20.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(61, 40, 27)
        lblTitle.Location = New Point(20, 20)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(460, 39)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Grooming Booking Management"
        ' 
        ' btnGoBackDashboard
        ' 
        btnGoBackDashboard.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnGoBackDashboard.BackColor = Color.SaddleBrown
        btnGoBackDashboard.FlatAppearance.BorderSize = 0
        btnGoBackDashboard.FlatStyle = FlatStyle.Flat
        btnGoBackDashboard.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnGoBackDashboard.ForeColor = Color.WhiteSmoke
        btnGoBackDashboard.Location = New Point(625, 82)
        btnGoBackDashboard.Name = "btnGoBackDashboard"
        btnGoBackDashboard.Size = New Size(145, 38)
        btnGoBackDashboard.TabIndex = 8
        btnGoBackDashboard.Text = "Dashboard"
        btnGoBackDashboard.UseVisualStyleBackColor = False
        ' 
        ' frmGroomingBooking
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(235, 221, 202)
        ClientSize = New Size(1160, 800)
        Controls.Add(pnlGroomingBooking)
        MinimumSize = New Size(1050, 700)
        Name = "frmGroomingBooking"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Grooming Booking Management"
        pnlGroomingBooking.ResumeLayout(False)
        pnlGroomingBooking.PerformLayout()
        CType(dgvGroomingBooking, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlGroomingBooking As System.Windows.Forms.Panel
    Friend WithEvents btnAddGroomingBooking As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents dgvGroomingBooking As System.Windows.Forms.DataGridView
    Friend WithEvents colGroomingBookingID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPetID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colServiceID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colBookingDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colBookingTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEdit As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colDelete As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents btnGoBackDashboard As Button

End Class