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
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlOrder = New Panel()
        btnGoBackDashboard = New Button()
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
        pnlOrder.SuspendLayout()
        CType(dgvOrder, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlOrder
        ' 
        pnlOrder.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlOrder.BackColor = Color.FromArgb(CByte(245), CByte(230), CByte(209))
        pnlOrder.Controls.Add(btnGoBackDashboard)
        pnlOrder.Controls.Add(cboOrderStatus)
        pnlOrder.Controls.Add(btnAddOrder)
        pnlOrder.Controls.Add(dgvOrder)
        pnlOrder.Controls.Add(btnRefresh)
        pnlOrder.Controls.Add(txtSearch)
        pnlOrder.Controls.Add(lblTitle)
        pnlOrder.Location = New Point(15, 15)
        pnlOrder.Name = "pnlOrder"
        pnlOrder.Padding = New Padding(20)
        pnlOrder.Size = New Size(1130, 770)
        pnlOrder.TabIndex = 6
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
        ' cboOrderStatus
        ' 
        cboOrderStatus.BackColor = Color.White
        cboOrderStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cboOrderStatus.Font = New Font("Segoe UI", 10F)
        cboOrderStatus.ForeColor = Color.FromArgb(CByte(61), CByte(40), CByte(27))
        cboOrderStatus.FormattingEnabled = True
        cboOrderStatus.Location = New Point(449, 87)
        cboOrderStatus.Name = "cboOrderStatus"
        cboOrderStatus.Size = New Size(155, 31)
        cboOrderStatus.TabIndex = 10
        ' 
        ' btnAddOrder
        ' 
        btnAddOrder.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnAddOrder.BackColor = Color.FromArgb(CByte(96), CByte(52), CByte(16))
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
        dgvOrder.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvOrder.BackgroundColor = Color.FromArgb(CByte(250), CByte(247), CByte(240))
        dgvOrder.BorderStyle = BorderStyle.None
        dgvOrder.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvOrder.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvOrder.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvOrder.ColumnHeadersHeight = 42
        dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvOrder.Columns.AddRange(New DataGridViewColumn() {colOrderID, colCustomerID, colOrderDate, colTotalAmount, colOrderStatus, colView, colDelete})
        dgvOrder.GridColor = Color.FromArgb(CByte(225), CByte(211), CByte(192))
        dgvOrder.Location = New Point(20, 140)
        dgvOrder.MultiSelect = False
        dgvOrder.Name = "dgvOrder"
        dgvOrder.ReadOnly = True
        dgvOrder.RightToLeft = RightToLeft.No
        dgvOrder.RowHeadersVisible = False
        dgvOrder.RowHeadersWidth = 51
        dgvOrder.RowTemplate.Height = 38
        dgvOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvOrder.Size = New Size(1090, 605)
        dgvOrder.TabIndex = 7
        ' 
        ' colOrderID
        ' 
        colOrderID.FillWeight = 90F
        colOrderID.HeaderText = "Order ID"
        colOrderID.MinimumWidth = 6
        colOrderID.Name = "colOrderID"
        colOrderID.ReadOnly = True
        ' 
        ' colCustomerID
        ' 
        colCustomerID.HeaderText = "Customer ID"
        colCustomerID.MinimumWidth = 6
        colCustomerID.Name = "colCustomerID"
        colCustomerID.ReadOnly = True
        ' 
        ' colOrderDate
        ' 
        colOrderDate.FillWeight = 120F
        colOrderDate.HeaderText = "Order Date"
        colOrderDate.MinimumWidth = 6
        colOrderDate.Name = "colOrderDate"
        colOrderDate.ReadOnly = True
        ' 
        ' colTotalAmount
        ' 
        colTotalAmount.FillWeight = 120F
        colTotalAmount.HeaderText = "Total Amount"
        colTotalAmount.MinimumWidth = 6
        colTotalAmount.Name = "colTotalAmount"
        colTotalAmount.ReadOnly = True
        ' 
        ' colOrderStatus
        ' 
        colOrderStatus.FillWeight = 110F
        colOrderStatus.HeaderText = "Order Status"
        colOrderStatus.MinimumWidth = 6
        colOrderStatus.Name = "colOrderStatus"
        colOrderStatus.ReadOnly = True
        ' 
        ' colView
        ' 
        colView.FillWeight = 75F
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
        colDelete.FillWeight = 75F
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
        txtSearch.BackColor = Color.White
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Font = New Font("Segoe UI", 10F)
        txtSearch.ForeColor = Color.FromArgb(CByte(107), CByte(98), CByte(91))
        txtSearch.Location = New Point(20, 84)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(395, 30)
        txtSearch.TabIndex = 1
        txtSearch.Text = "Search order..."
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Georgia", 20F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(CByte(61), CByte(40), CByte(27))
        lblTitle.Location = New Point(20, 20)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(360, 39)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Order Management"
        ' 
        ' frmOrder
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(235), CByte(221), CByte(202))
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