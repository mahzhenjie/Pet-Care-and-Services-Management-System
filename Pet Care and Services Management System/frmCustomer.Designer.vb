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
        btnGoBackDashboard = New Button()
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
        pnlCustomer.SuspendLayout()
        CType(dgvCustomer, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlCustomer
        ' 
        pnlCustomer.Anchor = CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles)
        pnlCustomer.BackColor = Color.FromArgb(245, 230, 209)
        pnlCustomer.Controls.Add(btnGoBackDashboard)
        pnlCustomer.Controls.Add(btnAddCustomer)
        pnlCustomer.Controls.Add(btnRefresh)
        pnlCustomer.Controls.Add(dgvCustomer)
        pnlCustomer.Controls.Add(txtSearch)
        pnlCustomer.Controls.Add(lblTitle)
        pnlCustomer.Location = New Point(15, 15)
        pnlCustomer.Name = "pnlCustomer"
        pnlCustomer.Padding = New Padding(20)
        pnlCustomer.Size = New Size(1130, 770)
        pnlCustomer.TabIndex = 0
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
        ' btnAddCustomer
        ' 
        btnAddCustomer.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnAddCustomer.BackColor = Color.FromArgb(96, 52, 16)
        btnAddCustomer.FlatAppearance.BorderSize = 0
        btnAddCustomer.FlatStyle = FlatStyle.Flat
        btnAddCustomer.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnAddCustomer.ForeColor = Color.WhiteSmoke
        btnAddCustomer.Location = New Point(930, 82)
        btnAddCustomer.Name = "btnAddCustomer"
        btnAddCustomer.Size = New Size(160, 38)
        btnAddCustomer.TabIndex = 7
        btnAddCustomer.Text = "+ Add Customer"
        btnAddCustomer.UseVisualStyleBackColor = False
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
        ' dgvCustomer
        ' 
        dgvCustomer.AllowUserToAddRows = False
        dgvCustomer.AllowUserToDeleteRows = False
        dgvCustomer.AllowUserToResizeRows = False
        dgvCustomer.Anchor = CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles)
        dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvCustomer.BackgroundColor = Color.FromArgb(250, 247, 240)
        dgvCustomer.BorderStyle = BorderStyle.None
        dgvCustomer.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvCustomer.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvCustomer.ColumnHeadersDefaultCellStyle = New DataGridViewCellStyle With {
            .BackColor = Color.FromArgb(96, 52, 16),
            .ForeColor = Color.WhiteSmoke,
            .Font = New Font("Segoe UI", 9.5F, FontStyle.Bold),
            .Alignment = DataGridViewContentAlignment.MiddleLeft,
            .SelectionBackColor = Color.FromArgb(96, 52, 16),
            .SelectionForeColor = Color.WhiteSmoke
        }
        dgvCustomer.ColumnHeadersHeight = 42
        dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvCustomer.Columns.AddRange(New DataGridViewColumn() {
            colCustomerID,
            colFullName,
            colUsername,
            colEmail,
            colPhoneNumber,
            colAddress,
            colEdit,
            colDelete
        })
        dgvCustomer.DefaultCellStyle = New DataGridViewCellStyle With {
            .BackColor = Color.White,
            .ForeColor = Color.FromArgb(61, 40, 27),
            .Font = New Font("Segoe UI", 9.0F),
            .SelectionBackColor = Color.FromArgb(232, 216, 194),
            .SelectionForeColor = Color.FromArgb(61, 40, 27),
            .Alignment = DataGridViewContentAlignment.MiddleLeft
        }
        dgvCustomer.GridColor = Color.FromArgb(225, 211, 192)
        dgvCustomer.Location = New Point(20, 140)
        dgvCustomer.MultiSelect = False
        dgvCustomer.Name = "dgvCustomer"
        dgvCustomer.ReadOnly = True
        dgvCustomer.RowHeadersVisible = False
        dgvCustomer.RowTemplate.Height = 38
        dgvCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCustomer.Size = New Size(1090, 605)
        dgvCustomer.TabIndex = 3
        ' 
        ' colCustomerID
        ' 
        colCustomerID.FillWeight = 80.0F
        colCustomerID.HeaderText = "Customer ID"
        colCustomerID.MinimumWidth = 6
        colCustomerID.Name = "colCustomerID"
        colCustomerID.ReadOnly = True
        ' 
        ' colFullName
        ' 
        colFullName.FillWeight = 125.0F
        colFullName.HeaderText = "Full Name"
        colFullName.MinimumWidth = 6
        colFullName.Name = "colFullName"
        colFullName.ReadOnly = True
        ' 
        ' colUsername
        ' 
        colUsername.FillWeight = 105.0F
        colUsername.HeaderText = "Username"
        colUsername.MinimumWidth = 6
        colUsername.Name = "colUsername"
        colUsername.ReadOnly = True
        ' 
        ' colEmail
        ' 
        colEmail.FillWeight = 145.0F
        colEmail.HeaderText = "Email"
        colEmail.MinimumWidth = 6
        colEmail.Name = "colEmail"
        colEmail.ReadOnly = True
        ' 
        ' colPhoneNumber
        ' 
        colPhoneNumber.FillWeight = 100.0F
        colPhoneNumber.HeaderText = "Phone Number"
        colPhoneNumber.MinimumWidth = 6
        colPhoneNumber.Name = "colPhoneNumber"
        colPhoneNumber.ReadOnly = True
        ' 
        ' colAddress
        ' 
        colAddress.FillWeight = 145.0F
        colAddress.HeaderText = "Address"
        colAddress.MinimumWidth = 6
        colAddress.Name = "colAddress"
        colAddress.ReadOnly = True
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
        colDelete.FillWeight = 70.0F
        colDelete.HeaderText = "Delete"
        colDelete.MinimumWidth = 6
        colDelete.Name = "colDelete"
        colDelete.ReadOnly = True
        colDelete.Resizable = DataGridViewTriState.True
        colDelete.SortMode = DataGridViewColumnSortMode.Automatic
        colDelete.Text = "Delete"
        colDelete.UseColumnTextForButtonValue = True
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
        txtSearch.Text = "Search customer..."
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Georgia", 20.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(61, 40, 27)
        lblTitle.Location = New Point(20, 20)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(340, 39)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Customer Management"
        ' 
        ' frmCustomer
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(235, 221, 202)
        ClientSize = New Size(1160, 800)
        Controls.Add(pnlCustomer)
        MinimumSize = New Size(1050, 700)
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