<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPayment
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
        pnlPayment = New Panel()
        cboMethod = New ComboBox()
        cboStatus = New ComboBox()
        txtSearch = New TextBox()
        btnRefresh = New Button()
        dgvPayment = New DataGridView()
        colPaymentID = New DataGridViewTextBoxColumn()
        colCustomerID = New DataGridViewTextBoxColumn()
        colPaymentDate = New DataGridViewTextBoxColumn()
        colAmount = New DataGridViewTextBoxColumn()
        colPaymentMethod = New DataGridViewTextBoxColumn()
        colPaymentType = New DataGridViewTextBoxColumn()
        colPaymentStatus = New DataGridViewTextBoxColumn()
        colEdit = New DataGridViewButtonColumn()
        colDelete = New DataGridViewButtonColumn()
        lblTitle = New Label()
        btnGoBackDashboard = New Button()
        pnlPayment.SuspendLayout()
        CType(dgvPayment, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlPayment
        ' 
        pnlPayment.Anchor = CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles)
        pnlPayment.BackColor = Color.FromArgb(245, 230, 209)
        pnlPayment.Controls.Add(btnGoBackDashboard)
        pnlPayment.Controls.Add(cboMethod)
        pnlPayment.Controls.Add(cboStatus)
        pnlPayment.Controls.Add(txtSearch)
        pnlPayment.Controls.Add(btnRefresh)
        pnlPayment.Controls.Add(dgvPayment)
        pnlPayment.Controls.Add(lblTitle)
        pnlPayment.Location = New Point(15, 15)
        pnlPayment.Name = "pnlPayment"
        pnlPayment.Padding = New Padding(20)
        pnlPayment.Size = New Size(1130, 770)
        pnlPayment.TabIndex = 2
        ' 
        ' cboMethod
        ' 
        cboMethod.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        cboMethod.BackColor = Color.White
        cboMethod.DropDownStyle = ComboBoxStyle.DropDownList
        cboMethod.Font = New Font("Segoe UI", 10.0F)
        cboMethod.ForeColor = Color.FromArgb(61, 40, 27)
        cboMethod.FormattingEnabled = True
        cboMethod.Location = New Point(520, 84)
        cboMethod.Name = "cboMethod"
        cboMethod.Size = New Size(120, 31)
        cboMethod.TabIndex = 14
        ' 
        ' cboStatus
        ' 
        cboStatus.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        cboStatus.BackColor = Color.White
        cboStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cboStatus.Font = New Font("Segoe UI", 10.0F)
        cboStatus.ForeColor = Color.FromArgb(61, 40, 27)
        cboStatus.FormattingEnabled = True
        cboStatus.Location = New Point(390, 84)
        cboStatus.Name = "cboStatus"
        cboStatus.Size = New Size(120, 31)
        cboStatus.TabIndex = 13
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
        txtSearch.Size = New Size(355, 30)
        txtSearch.TabIndex = 7
        txtSearch.Text = "Search payment..."
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
        ' dgvPayment
        ' 
        dgvPayment.AllowUserToAddRows = False
        dgvPayment.AllowUserToDeleteRows = False
        dgvPayment.AllowUserToResizeRows = False
        dgvPayment.Anchor = CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles)
        dgvPayment.AutoGenerateColumns = False
        dgvPayment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPayment.BackgroundColor = Color.FromArgb(250, 247, 240)
        dgvPayment.BorderStyle = BorderStyle.None
        dgvPayment.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvPayment.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvPayment.ColumnHeadersDefaultCellStyle = New DataGridViewCellStyle With {
            .BackColor = Color.FromArgb(96, 52, 16),
            .ForeColor = Color.WhiteSmoke,
            .Font = New Font("Segoe UI", 9.5F, FontStyle.Bold),
            .Alignment = DataGridViewContentAlignment.MiddleLeft,
            .SelectionBackColor = Color.FromArgb(96, 52, 16),
            .SelectionForeColor = Color.WhiteSmoke
        }
        dgvPayment.ColumnHeadersHeight = 42
        dgvPayment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvPayment.Columns.AddRange(New DataGridViewColumn() {
            colPaymentID,
            colCustomerID,
            colPaymentDate,
            colAmount,
            colPaymentMethod,
            colPaymentType,
            colPaymentStatus,
            colEdit,
            colDelete
        })
        dgvPayment.DefaultCellStyle = New DataGridViewCellStyle With {
            .BackColor = Color.White,
            .ForeColor = Color.FromArgb(61, 40, 27),
            .Font = New Font("Segoe UI", 9.0F),
            .SelectionBackColor = Color.FromArgb(232, 216, 194),
            .SelectionForeColor = Color.FromArgb(61, 40, 27),
            .Alignment = DataGridViewContentAlignment.MiddleLeft
        }
        dgvPayment.GridColor = Color.FromArgb(225, 211, 192)
        dgvPayment.Location = New Point(20, 140)
        dgvPayment.MultiSelect = False
        dgvPayment.Name = "dgvPayment"
        dgvPayment.ReadOnly = True
        dgvPayment.RightToLeft = RightToLeft.No
        dgvPayment.RowHeadersVisible = False
        dgvPayment.RowTemplate.Height = 38
        dgvPayment.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPayment.Size = New Size(1090, 605)
        dgvPayment.TabIndex = 3
        ' 
        ' colPaymentID
        ' 
        colPaymentID.FillWeight = 90.0F
        colPaymentID.HeaderText = "Payment ID"
        colPaymentID.MinimumWidth = 6
        colPaymentID.Name = "colPaymentID"
        colPaymentID.ReadOnly = True
        ' 
        ' colCustomerID
        ' 
        colCustomerID.FillWeight = 100.0F
        colCustomerID.HeaderText = "Customer ID"
        colCustomerID.MinimumWidth = 6
        colCustomerID.Name = "colCustomerID"
        colCustomerID.ReadOnly = True
        ' 
        ' colPaymentDate
        ' 
        colPaymentDate.FillWeight = 115.0F
        colPaymentDate.HeaderText = "Payment Date"
        colPaymentDate.MinimumWidth = 6
        colPaymentDate.Name = "colPaymentDate"
        colPaymentDate.ReadOnly = True
        ' 
        ' colAmount
        ' 
        colAmount.FillWeight = 90.0F
        colAmount.HeaderText = "Amount"
        colAmount.MinimumWidth = 6
        colAmount.Name = "colAmount"
        colAmount.ReadOnly = True
        ' 
        ' colPaymentMethod
        ' 
        colPaymentMethod.FillWeight = 115.0F
        colPaymentMethod.HeaderText = "Payment Method"
        colPaymentMethod.MinimumWidth = 6
        colPaymentMethod.Name = "colPaymentMethod"
        colPaymentMethod.ReadOnly = True
        ' 
        ' colPaymentType
        ' 
        colPaymentType.FillWeight = 105.0F
        colPaymentType.HeaderText = "Payment Type"
        colPaymentType.MinimumWidth = 6
        colPaymentType.Name = "colPaymentType"
        colPaymentType.ReadOnly = True
        ' 
        ' colPaymentStatus
        ' 
        colPaymentStatus.FillWeight = 115.0F
        colPaymentStatus.HeaderText = "Payment Status"
        colPaymentStatus.MinimumWidth = 6
        colPaymentStatus.Name = "colPaymentStatus"
        colPaymentStatus.ReadOnly = True
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
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Georgia", 20.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(61, 40, 27)
        lblTitle.Location = New Point(20, 20)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(330, 39)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Payment Management"
        ' 
        ' btnGoBackDashboard
        ' 
        btnGoBackDashboard.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnGoBackDashboard.BackColor = Color.SaddleBrown
        btnGoBackDashboard.FlatAppearance.BorderSize = 0
        btnGoBackDashboard.FlatStyle = FlatStyle.Flat
        btnGoBackDashboard.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnGoBackDashboard.ForeColor = Color.WhiteSmoke
        btnGoBackDashboard.Location = New Point(640, 82)
        btnGoBackDashboard.Name = "btnGoBackDashboard"
        btnGoBackDashboard.Size = New Size(145, 38)
        btnGoBackDashboard.TabIndex = 15
        btnGoBackDashboard.Text = "Dashboard"
        btnGoBackDashboard.UseVisualStyleBackColor = False
        ' 
        ' frmPayment
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(235, 221, 202)
        ClientSize = New Size(1160, 800)
        Controls.Add(pnlPayment)
        MinimumSize = New Size(1050, 700)
        Name = "frmPayment"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Payment Management"
        pnlPayment.ResumeLayout(False)
        pnlPayment.PerformLayout()
        CType(dgvPayment, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlPayment As System.Windows.Forms.Panel
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents dgvPayment As System.Windows.Forms.DataGridView
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents colPaymentID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCustomerID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPaymentDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPaymentMethod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPaymentType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPaymentStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEdit As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colDelete As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents cboMethod As System.Windows.Forms.ComboBox
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents btnGoBackDashboard As Button

End Class