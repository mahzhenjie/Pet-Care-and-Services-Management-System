<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMembership
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlMembership = New Panel()
        btnGoBackDashboard = New Button()
        cboType = New ComboBox()
        cboStatus = New ComboBox()
        dgvMembership = New DataGridView()
        colMembershipID = New DataGridViewTextBoxColumn()
        colCustomerID = New DataGridViewTextBoxColumn()
        colMembershipType = New DataGridViewTextBoxColumn()
        colStartDate = New DataGridViewTextBoxColumn()
        colEndDate = New DataGridViewTextBoxColumn()
        colStatus = New DataGridViewTextBoxColumn()
        colEdit = New DataGridViewButtonColumn()
        colDelete = New DataGridViewButtonColumn()
        btnRefresh = New Button()
        txtSearch = New TextBox()
        lblTitle = New Label()
        pnlMembership.SuspendLayout()
        CType(dgvMembership, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlMembership
        ' 
        pnlMembership.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlMembership.BackColor = Color.FromArgb(CByte(245), CByte(230), CByte(209))
        pnlMembership.Controls.Add(btnGoBackDashboard)
        pnlMembership.Controls.Add(cboType)
        pnlMembership.Controls.Add(cboStatus)
        pnlMembership.Controls.Add(dgvMembership)
        pnlMembership.Controls.Add(btnRefresh)
        pnlMembership.Controls.Add(txtSearch)
        pnlMembership.Controls.Add(lblTitle)
        pnlMembership.Location = New Point(15, 15)
        pnlMembership.Name = "pnlMembership"
        pnlMembership.Padding = New Padding(20)
        pnlMembership.Size = New Size(1130, 770)
        pnlMembership.TabIndex = 4
        ' 
        ' btnGoBackDashboard
        ' 
        btnGoBackDashboard.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnGoBackDashboard.BackColor = Color.SaddleBrown
        btnGoBackDashboard.FlatAppearance.BorderSize = 0
        btnGoBackDashboard.FlatStyle = FlatStyle.Flat
        btnGoBackDashboard.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnGoBackDashboard.ForeColor = Color.WhiteSmoke
        btnGoBackDashboard.Location = New Point(815, 82)
        btnGoBackDashboard.Name = "btnGoBackDashboard"
        btnGoBackDashboard.Size = New Size(145, 38)
        btnGoBackDashboard.TabIndex = 17
        btnGoBackDashboard.Text = "Dashboard"
        btnGoBackDashboard.UseVisualStyleBackColor = False
        ' 
        ' cboType
        ' 
        cboType.BackColor = Color.White
        cboType.DropDownStyle = ComboBoxStyle.DropDownList
        cboType.Font = New Font("Segoe UI", 10.0F)
        cboType.ForeColor = Color.FromArgb(CByte(61), CByte(40), CByte(27))
        cboType.FormattingEnabled = True
        cboType.Location = New Point(390, 84)
        cboType.Name = "cboType"
        cboType.Size = New Size(120, 31)
        cboType.TabIndex = 16
        ' 
        ' cboStatus
        ' 
        cboStatus.BackColor = Color.White
        cboStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cboStatus.Font = New Font("Segoe UI", 10.0F)
        cboStatus.ForeColor = Color.FromArgb(CByte(61), CByte(40), CByte(27))
        cboStatus.FormattingEnabled = True
        cboStatus.Location = New Point(520, 84)
        cboStatus.Name = "cboStatus"
        cboStatus.Size = New Size(120, 31)
        cboStatus.TabIndex = 15
        ' 
        ' dgvMembership
        ' 
        dgvMembership.AllowUserToAddRows = False
        dgvMembership.AllowUserToDeleteRows = False
        dgvMembership.AllowUserToResizeRows = False
        dgvMembership.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvMembership.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvMembership.BackgroundColor = Color.FromArgb(CByte(250), CByte(247), CByte(240))
        dgvMembership.BorderStyle = BorderStyle.None
        dgvMembership.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvMembership.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvMembership.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvMembership.ColumnHeadersHeight = 42
        dgvMembership.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvMembership.Columns.AddRange(New DataGridViewColumn() {colMembershipID, colCustomerID, colMembershipType, colStartDate, colEndDate, colStatus, colEdit, colDelete})
        dgvMembership.GridColor = Color.FromArgb(CByte(225), CByte(211), CByte(192))
        dgvMembership.Location = New Point(20, 140)
        dgvMembership.MultiSelect = False
        dgvMembership.Name = "dgvMembership"
        dgvMembership.ReadOnly = True
        dgvMembership.RightToLeft = RightToLeft.No
        dgvMembership.RowHeadersVisible = False
        dgvMembership.RowHeadersWidth = 51
        dgvMembership.RowTemplate.Height = 38
        dgvMembership.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMembership.Size = New Size(1090, 605)
        dgvMembership.TabIndex = 7
        ' 
        ' colMembershipID
        ' 
        colMembershipID.HeaderText = "Membership ID"
        colMembershipID.MinimumWidth = 6
        colMembershipID.Name = "colMembershipID"
        colMembershipID.ReadOnly = True
        ' 
        ' colCustomerID
        ' 
        colCustomerID.HeaderText = "Customer ID"
        colCustomerID.MinimumWidth = 6
        colCustomerID.Name = "colCustomerID"
        colCustomerID.ReadOnly = True
        ' 
        ' colMembershipType
        ' 
        colMembershipType.FillWeight = 120.0F
        colMembershipType.HeaderText = "Membership Type"
        colMembershipType.MinimumWidth = 6
        colMembershipType.Name = "colMembershipType"
        colMembershipType.ReadOnly = True
        ' 
        ' colStartDate
        ' 
        colStartDate.FillWeight = 110.0F
        colStartDate.HeaderText = "Start Date"
        colStartDate.MinimumWidth = 6
        colStartDate.Name = "colStartDate"
        colStartDate.ReadOnly = True
        ' 
        ' colEndDate
        ' 
        colEndDate.FillWeight = 110.0F
        colEndDate.HeaderText = "End Date"
        colEndDate.MinimumWidth = 6
        colEndDate.Name = "colEndDate"
        colEndDate.ReadOnly = True
        ' 
        ' colStatus
        ' 
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
        ' btnRefresh
        ' 
        btnRefresh.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnRefresh.BackColor = Color.Sienna
        btnRefresh.FlatAppearance.BorderSize = 0
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnRefresh.ForeColor = Color.WhiteSmoke
        btnRefresh.Location = New Point(980, 82)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(130, 38)
        btnRefresh.TabIndex = 3
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = Color.White
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Font = New Font("Segoe UI", 10.0F)
        txtSearch.ForeColor = Color.FromArgb(CByte(107), CByte(98), CByte(91))
        txtSearch.Location = New Point(20, 84)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(355, 30)
        txtSearch.TabIndex = 1
        txtSearch.Text = "Search membership..."
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Georgia", 20.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(CByte(61), CByte(40), CByte(27))
        lblTitle.Location = New Point(20, 20)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(476, 39)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Membership Management"
        ' 
        ' frmMembership
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(235), CByte(221), CByte(202))
        ClientSize = New Size(1160, 800)
        Controls.Add(pnlMembership)
        MinimumSize = New Size(1050, 700)
        Name = "frmMembership"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Membership Management"
        pnlMembership.ResumeLayout(False)
        pnlMembership.PerformLayout()
        CType(dgvMembership, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMembership As System.Windows.Forms.Panel
    Friend WithEvents dgvMembership As System.Windows.Forms.DataGridView
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents colMembershipID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCustomerID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMembershipType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStartDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEndDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEdit As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colDelete As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents cboType As System.Windows.Forms.ComboBox
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents btnGoBackDashboard As Button

End Class