<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCustomer
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
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pnlCustomer = New Panel()
        btnAddCustomer = New Button()
        btnRefresh = New Button()
        dgvCustomer = New DataGridView()
        colCustomerID = New DataGridViewTextBoxColumn()
        colFullName = New DataGridViewTextBoxColumn()
        colUsername = New DataGridViewTextBoxColumn()
        colEmail = New DataGridViewTextBoxColumn()
        colPhoneNumber = New DataGridViewTextBoxColumn()
        colAddress = New DataGridViewTextBoxColumn()
        colEdit = New DataGridViewButtonColumn()
        colDelete = New DataGridViewButtonColumn()
        txtSearch = New TextBox()
        lblTitle = New Label()
        btnGoBackDashboard = New Button()
        pnlCustomer.SuspendLayout()
        CType(dgvCustomer, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlCustomer
        ' 
        pnlCustomer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        pnlCustomer.BackColor = Color.FromArgb(CByte(232), CByte(216), CByte(194))
        pnlCustomer.Controls.Add(btnGoBackDashboard)
        pnlCustomer.Controls.Add(btnAddCustomer)
        pnlCustomer.Controls.Add(btnRefresh)
        pnlCustomer.Controls.Add(dgvCustomer)
        pnlCustomer.Controls.Add(txtSearch)
        pnlCustomer.Controls.Add(lblTitle)
        pnlCustomer.ForeColor = Color.SaddleBrown
        pnlCustomer.Location = New Point(12, 15)
        pnlCustomer.Margin = New Padding(3, 4, 3, 4)
        pnlCustomer.Name = "pnlCustomer"
        pnlCustomer.Size = New Size(920, 725)
        pnlCustomer.TabIndex = 0
        ' 
        ' btnAddCustomer
        ' 
        btnAddCustomer.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnAddCustomer.BackColor = Color.SaddleBrown
        btnAddCustomer.Font = New Font("Lucida Sans Unicode", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAddCustomer.ForeColor = Color.WhiteSmoke
        btnAddCustomer.Location = New Point(611, 80)
        btnAddCustomer.Margin = New Padding(3, 4, 3, 4)
        btnAddCustomer.Name = "btnAddCustomer"
        btnAddCustomer.Size = New Size(137, 34)
        btnAddCustomer.TabIndex = 7
        btnAddCustomer.Text = "+Add Customer"
        btnAddCustomer.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnRefresh.BackColor = Color.SaddleBrown
        btnRefresh.Font = New Font("Lucida Sans Unicode", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRefresh.ForeColor = Color.WhiteSmoke
        btnRefresh.Location = New Point(754, 80)
        btnRefresh.Margin = New Padding(3, 4, 3, 4)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(137, 34)
        btnRefresh.TabIndex = 3
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' dgvCustomer
        ' 
        dgvCustomer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvCustomer.BackgroundColor = Color.FromArgb(CByte(244), CByte(239), CByte(227))
        dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCustomer.Columns.AddRange(New DataGridViewColumn() {colCustomerID, colFullName, colUsername, colEmail, colPhoneNumber, colAddress, colEdit, colDelete})
        dgvCustomer.GridColor = Color.Sienna
        dgvCustomer.Location = New Point(24, 121)
        dgvCustomer.Margin = New Padding(3, 4, 3, 4)
        dgvCustomer.Name = "dgvCustomer"
        dgvCustomer.RightToLeft = RightToLeft.No
        dgvCustomer.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        dgvCustomer.RowHeadersWidth = 51
        dgvCustomer.RowTemplate.Height = 24
        dgvCustomer.Size = New Size(868, 569)
        dgvCustomer.TabIndex = 3
        ' 
        ' colCustomerID
        ' 
        colCustomerID.FillWeight = 110.0F
        colCustomerID.HeaderText = "Customer ID"
        colCustomerID.MinimumWidth = 6
        colCustomerID.Name = "colCustomerID"
        ' 
        ' colFullName
        ' 
        colFullName.FillWeight = 150.0F
        colFullName.HeaderText = "Full Name"
        colFullName.MinimumWidth = 6
        colFullName.Name = "colFullName"
        ' 
        ' colUsername
        ' 
        colUsername.HeaderText = "Username"
        colUsername.MinimumWidth = 6
        colUsername.Name = "colUsername"
        ' 
        ' colEmail
        ' 
        colEmail.HeaderText = "Email"
        colEmail.MinimumWidth = 6
        colEmail.Name = "colEmail"
        ' 
        ' colPhoneNumber
        ' 
        colPhoneNumber.FillWeight = 70.0F
        colPhoneNumber.HeaderText = "Phone Number"
        colPhoneNumber.MinimumWidth = 6
        colPhoneNumber.Name = "colPhoneNumber"
        ' 
        ' colAddress
        ' 
        colAddress.HeaderText = "Address"
        colAddress.MinimumWidth = 6
        colAddress.Name = "colAddress"
        ' 
        ' colEdit
        ' 
        colEdit.HeaderText = "Edit"
        colEdit.MinimumWidth = 6
        colEdit.Name = "colEdit"
        colEdit.Resizable = DataGridViewTriState.True
        colEdit.SortMode = DataGridViewColumnSortMode.Automatic
        colEdit.Text = "[Edit]"
        colEdit.UseColumnTextForButtonValue = True
        ' 
        ' colDelete
        ' 
        colDelete.HeaderText = "Delete"
        colDelete.MinimumWidth = 6
        colDelete.Name = "colDelete"
        colDelete.Resizable = DataGridViewTriState.True
        colDelete.SortMode = DataGridViewColumnSortMode.Automatic
        colDelete.Text = "[Delete]"
        colDelete.UseColumnTextForButtonValue = True
        ' 
        ' txtSearch
        ' 
        txtSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        txtSearch.Font = New Font("Lucida Sans Unicode", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearch.ForeColor = Color.Sienna
        txtSearch.Location = New Point(24, 80)
        txtSearch.Margin = New Padding(3, 4, 3, 4)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(398, 27)
        txtSearch.TabIndex = 1
        txtSearch.Text = "Search customer..."
        ' 
        ' lblTitle
        ' 
        lblTitle.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Lucida Sans Unicode", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(20, 19)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(346, 34)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Customer Management"
        ' 
        ' btnGoBackDashboard
        ' 
        btnGoBackDashboard.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnGoBackDashboard.BackColor = Color.SaddleBrown
        btnGoBackDashboard.Font = New Font("Lucida Sans Unicode", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnGoBackDashboard.ForeColor = Color.WhiteSmoke
        btnGoBackDashboard.Location = New Point(468, 79)
        btnGoBackDashboard.Margin = New Padding(3, 4, 3, 4)
        btnGoBackDashboard.Name = "btnGoBackDashboard"
        btnGoBackDashboard.Size = New Size(137, 34)
        btnGoBackDashboard.TabIndex = 8
        btnGoBackDashboard.Text = "Dashboard"
        btnGoBackDashboard.UseVisualStyleBackColor = False
        ' 
        ' frmCustomer
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(942, 754)
        Controls.Add(pnlCustomer)
        Margin = New Padding(3, 4, 3, 4)
        MinimumSize = New Size(950, 800)
        Name = "frmCustomer"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Customer Management"
        pnlCustomer.ResumeLayout(False)
        pnlCustomer.PerformLayout()
        CType(dgvCustomer, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlCustomer As System.Windows.Forms.Panel
    Friend WithEvents dgvCustomer As System.Windows.Forms.DataGridView
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnAddCustomer As System.Windows.Forms.Button
    Friend WithEvents colCustomerID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFullName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colUsername As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEmail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPhoneNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAddress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEdit As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colDelete As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents btnGoBackDashboard As Button

End Class