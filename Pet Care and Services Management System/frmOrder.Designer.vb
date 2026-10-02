<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOrder
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
        pnlOrder = New Panel()
        cboOrderStatus = New ComboBox()
        btnAddOrder = New Button()
        dgvOrder = New DataGridView()
        colOrderID = New DataGridViewTextBoxColumn()
        colCustomerID = New DataGridViewTextBoxColumn()
        colOrderDate = New DataGridViewTextBoxColumn()
        colTotalAmount = New DataGridViewTextBoxColumn()
        colOrderStatus = New DataGridViewTextBoxColumn()
        colView = New DataGridViewButtonColumn()
        colDelete = New DataGridViewButtonColumn()
        btnRefresh = New Button()
        txtSearch = New TextBox()
        lblTitle = New Label()
        btnGoBackDashboard = New Button()
        pnlOrder.SuspendLayout()
        CType(dgvOrder, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlOrder
        ' 
        pnlOrder.Anchor = CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles)
        pnlOrder.BackColor = Color.FromArgb(245, 230, 209)
        pnlOrder.Controls.Add(btnGoBackDashboard)
        pnlOrder.Controls.Add(cboOrderStatus)
        pnlOrder.Controls.Add(btnAddOrder)
        pnlOrder.Controls.Add(dgvOrder)
        pnlOrder.Controls.Add(btnRefresh)
        pnlOrder.Controls.Add(txtSearch)
        pnlOrder.Controls.Add(lblTitle)
        pnlOrder.Enabled = True
        pnlOrder.Location = New Point(15, 15)
        pnlOrder.Name = "pnlOrder"
        pnlOrder.Padding = New Padding(20)
        pnlOrder.Size = New Size(1130, 770)
        pnlOrder.TabIndex = 6
        ' 
        ' cboOrderStatus
        ' 
        cboOrderStatus.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        cboOrderStatus.BackColor = Color.White
        cboOrderStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cboOrderStatus.Font = New Font("Segoe UI", 10.0F)
        cboOrderStatus.ForeColor = Color.FromArgb(61, 40, 27)
        cboOrderStatus.FormattingEnabled = True
        cboOrderStatus.Location = New Point(615, 84)
        cboOrderStatus.Name = "cboOrderStatus"
        cboOrderStatus.Size = New Size(155, 31)
        cboOrderStatus.TabIndex = 10
        ' 
        ' btnAddOrder
        ' 
        btnAddOrder.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnAddOrder.BackColor = Color.FromArgb(96, 52, 16)
        btnAddOrder.FlatAppearance.BorderSize = 0
        btnAddOrder.FlatStyle = FlatStyle.Flat
        btnAddOrder.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnAddOrder.ForeColor = Color.WhiteSmoke
        btnAddOrder.Location = New Point(930, 82)
        btnAddOrder.Name = "btnAddOrder"
        btnAddOrder.Size = New Size(160, 38)
        btnAddOrder.TabIndex = 9
        btnAddOrder.Text = "+ Add Order"
        btnAddOrder.UseVisualStyleBackColor = False
        ' 
        ' dgvOrder
        ' 
        dgvOrder.AllowUserToAddRows = False
        dgvOrder.AllowUserToDeleteRows = False
        dgvOrder.AllowUserToResizeRows = False
        dgvOrder.Anchor = CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles)
        dgvOrder.AutoGenerateColumns = False
        dgvOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvOrder.BackgroundColor = Color.FromArgb(250, 247, 240)
        dgvOrder.BorderStyle = BorderStyle.None
        dgvOrder.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvOrder.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvOrder.ColumnHeadersDefaultCellStyle = New DataGridViewCellStyle With {
            .BackColor = Color.FromArgb(96, 52, 16),
            .ForeColor = Color.WhiteSmoke,
            .Font = New Font("Segoe UI", 9.5F, FontStyle.Bold),
            .Alignment = DataGridViewContentAlignment.MiddleLeft,
            .SelectionBackColor = Color.FromArgb(96, 52, 16),
            .SelectionForeColor = Color.WhiteSmoke
        }
        dgvOrder.ColumnHeadersHeight = 42
        dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvOrder.Columns.AddRange(New DataGridViewColumn() {
            colOrderID,
            colCustomerID,
            colOrderDate,
            colTotalAmount,
            colOrderStatus,
            colView,
            colDelete
        })
        dgvOrder.DefaultCellStyle = New DataGridViewCellStyle With {
            .BackColor = Color.White,
            .ForeColor = Color.FromArgb(61, 40, 27),
            .Font = New Font("Segoe UI", 9.0F),
            .SelectionBackColor = Color.FromArgb(232, 216, 194),
            .SelectionForeColor = Color.FromArgb(61, 40, 27),
            .Alignment = DataGridViewContentAlignment.MiddleLeft
        }
        dgvOrder.GridColor = Color.FromArgb(225, 211, 192)
        dgvOrder.Location = New Point(20, 140)
        dgvOrder.MultiSelect = False
        dgvOrder.Name = "dgvOrder"
        dgvOrder.ReadOnly = True
        dgvOrder.RightToLeft = RightToLeft.No
        dgvOrder.RowHeadersVisible = False
        dgvOrder.RowTemplate.Height = 38
        dgvOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvOrder.Size = New Size(1090, 605)
        dgvOrder.TabIndex = 7
        ' 
        ' colOrderID
        ' 
        colOrderID.FillWeight = 90.0F
        colOrderID.HeaderText = "Order ID"
        colOrderID.MinimumWidth = 6
        colOrderID.Name = "colOrderID"
        colOrderID.ReadOnly = True
        ' 
        ' colCustomerID
        ' 
        colCustomerID.FillWeight = 100.0F
        colCustomerID.HeaderText = "Customer ID"
        colCustomerID.MinimumWidth = 6
        colCustomerID.Name = "colCustomerID"
        colCustomerID.ReadOnly = True
        ' 
        ' colOrderDate
        ' 
        colOrderDate.FillWeight = 120.0F
        colOrderDate.HeaderText = "Order Date"
        colOrderDate.MinimumWidth = 6
        colOrderDate.Name = "colOrderDate"
        colOrderDate.ReadOnly = True
        ' 
        ' colTotalAmount
        ' 
        colTotalAmount.FillWeight = 120.0F
        colTotalAmount.HeaderText = "Total Amount"
        colTotalAmount.MinimumWidth = 6
        colTotalAmount.Name = "colTotalAmount"
        colTotalAmount.ReadOnly = True
        ' 
        ' colOrderStatus
        ' 
        colOrderStatus.FillWeight = 110.0F
        colOrderStatus.HeaderText = "Order Status"
        colOrderStatus.MinimumWidth = 6
        colOrderStatus.Name = "colOrderStatus"
        colOrderStatus.ReadOnly = True
        ' 
        ' colView
        ' 
        colView.FillWeight = 75.0F
        colView.HeaderText = "View"
        colView.MinimumWidth = 6
        colView.Name = "colView"
        colView.ReadOnly = True
        colView.Resizable = DataGridViewTriState.True
        colView.SortMode = DataGridViewColumnSortMode.Automatic
        colView.Text = "View"
        colView.UseColumnTextForButtonValue = True
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
        txtSearch.Text = "Search order..."
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Georgia", 20.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(61, 40, 27)
        lblTitle.Location = New Point(20, 20)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(300, 39)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Order Management"
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
        btnGoBackDashboard.TabIndex = 11
        btnGoBackDashboard.Text = "Dashboard"
        btnGoBackDashboard.UseVisualStyleBackColor = False
        ' 
        ' frmOrder
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(235, 221, 202)
        ClientSize = New Size(1160, 800)
        Controls.Add(pnlOrder)
        MinimumSize = New Size(1050, 700)
        Name = "frmOrder"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Order Management"
        pnlOrder.ResumeLayout(False)
        pnlOrder.PerformLayout()
        CType(dgvOrder, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlOrder As System.Windows.Forms.Panel
    Friend WithEvents dgvOrder As System.Windows.Forms.DataGridView
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnAddOrder As System.Windows.Forms.Button
    Friend WithEvents colOrderID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCustomerID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colOrderDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTotalAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colOrderStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colView As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colDelete As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents cboOrderStatus As System.Windows.Forms.ComboBox
    Friend WithEvents btnGoBackDashboard As Button

End Class