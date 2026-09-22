<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMembership
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
        pnlMembership = New Panel()
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
        btnGoBackDashboard = New Button()
        pnlMembership.SuspendLayout()
        CType(dgvMembership, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlMembership
        ' 
        pnlMembership.BackColor = Color.FromArgb(CByte(232), CByte(216), CByte(194))
        pnlMembership.Controls.Add(btnGoBackDashboard)
        pnlMembership.Controls.Add(cboType)
        pnlMembership.Controls.Add(cboStatus)
        pnlMembership.Controls.Add(dgvMembership)
        pnlMembership.Controls.Add(btnRefresh)
        pnlMembership.Controls.Add(txtSearch)
        pnlMembership.Controls.Add(lblTitle)
        pnlMembership.ForeColor = Color.SaddleBrown
        pnlMembership.Location = New Point(12, 15)
        pnlMembership.Margin = New Padding(3, 4, 3, 4)
        pnlMembership.Name = "pnlMembership"
        pnlMembership.Size = New Size(920, 725)
        pnlMembership.TabIndex = 4
        ' 
        ' cboType
        ' 
        cboType.FormattingEnabled = True
        cboType.Location = New Point(385, 83)
        cboType.Margin = New Padding(3, 4, 3, 4)
        cboType.Name = "cboType"
        cboType.Size = New Size(87, 28)
        cboType.TabIndex = 16
        cboType.Text = "Method"
        ' 
        ' cboStatus
        ' 
        cboStatus.FormattingEnabled = True
        cboStatus.Location = New Point(488, 83)
        cboStatus.Margin = New Padding(3, 4, 3, 4)
        cboStatus.Name = "cboStatus"
        cboStatus.Size = New Size(87, 28)
        cboStatus.TabIndex = 15
        cboStatus.Text = "Status"
        ' 
        ' dgvMembership
        ' 
        dgvMembership.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvMembership.BackgroundColor = Color.FromArgb(CByte(244), CByte(239), CByte(227))
        dgvMembership.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMembership.Columns.AddRange(New DataGridViewColumn() {colMembershipID, colCustomerID, colMembershipType, colStartDate, colEndDate, colStatus, colEdit, colDelete})
        dgvMembership.GridColor = Color.Sienna
        dgvMembership.Location = New Point(24, 121)
        dgvMembership.Margin = New Padding(3, 4, 3, 4)
        dgvMembership.Name = "dgvMembership"
        dgvMembership.RightToLeft = RightToLeft.No
        dgvMembership.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        dgvMembership.RowHeadersWidth = 51
        dgvMembership.RowTemplate.Height = 24
        dgvMembership.Size = New Size(868, 569)
        dgvMembership.TabIndex = 7
        ' 
        ' colMembershipID
        ' 
        colMembershipID.HeaderText = "Membership ID"
        colMembershipID.MinimumWidth = 6
        colMembershipID.Name = "colMembershipID"
        ' 
        ' colCustomerID
        ' 
        colCustomerID.HeaderText = "Customer ID"
        colCustomerID.MinimumWidth = 6
        colCustomerID.Name = "colCustomerID"
        ' 
        ' colMembershipType
        ' 
        colMembershipType.HeaderText = "Membership Type"
        colMembershipType.MinimumWidth = 6
        colMembershipType.Name = "colMembershipType"
        ' 
        ' colStartDate
        ' 
        colStartDate.FillWeight = 150F
        colStartDate.HeaderText = "Start Date"
        colStartDate.MinimumWidth = 6
        colStartDate.Name = "colStartDate"
        ' 
        ' colEndDate
        ' 
        colEndDate.HeaderText = "End Date"
        colEndDate.MinimumWidth = 6
        colEndDate.Name = "colEndDate"
        ' 
        ' colStatus
        ' 
        colStatus.HeaderText = "Status"
        colStatus.MinimumWidth = 6
        colStatus.Name = "colStatus"
        ' 
        ' colEdit
        ' 
        colEdit.HeaderText = "Edit"
        colEdit.MinimumWidth = 6
        colEdit.Name = "colEdit"
        ' 
        ' colDelete
        ' 
        colDelete.HeaderText = "Delete"
        colDelete.MinimumWidth = 6
        colDelete.Name = "colDelete"
        colDelete.Text = "[Delete]"
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.SaddleBrown
        btnRefresh.Font = New Font("Lucida Sans Unicode", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRefresh.ForeColor = Color.WhiteSmoke
        btnRefresh.Location = New Point(757, 80)
        btnRefresh.Margin = New Padding(3, 4, 3, 4)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(137, 34)
        btnRefresh.TabIndex = 3
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Lucida Sans Unicode", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearch.ForeColor = Color.Sienna
        txtSearch.Location = New Point(24, 80)
        txtSearch.Margin = New Padding(3, 4, 3, 4)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(326, 27)
        txtSearch.TabIndex = 1
        txtSearch.Text = "Search booking..."
        txtSearch.UseWaitCursor = True
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Lucida Sans Unicode", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(20, 19)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(386, 34)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Membership Management"
        ' 
        ' btnGoBackDashboard
        ' 
        btnGoBackDashboard.BackColor = Color.SaddleBrown
        btnGoBackDashboard.Font = New Font("Lucida Sans Unicode", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnGoBackDashboard.ForeColor = Color.WhiteSmoke
        btnGoBackDashboard.Location = New Point(614, 80)
        btnGoBackDashboard.Margin = New Padding(3, 4, 3, 4)
        btnGoBackDashboard.Name = "btnGoBackDashboard"
        btnGoBackDashboard.Size = New Size(137, 34)
        btnGoBackDashboard.TabIndex = 17
        btnGoBackDashboard.Text = "Dashboard"
        btnGoBackDashboard.UseVisualStyleBackColor = False
        ' 
        ' frmMembership
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(942, 754)
        Controls.Add(pnlMembership)
        Margin = New Padding(3, 4, 3, 4)
        Name = "frmMembership"
        Text = "Membership management"
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
