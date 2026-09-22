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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
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
        pnlOrder.BackColor = Color.FromArgb(CByte(232), CByte(216), CByte(194))
        pnlOrder.Controls.Add(btnGoBackDashboard)
        pnlOrder.Controls.Add(cboOrderStatus)
        pnlOrder.Controls.Add(btnAddOrder)
        pnlOrder.Controls.Add(dgvOrder)
        pnlOrder.Controls.Add(btnRefresh)
        pnlOrder.Controls.Add(txtSearch)
        pnlOrder.Controls.Add(lblTitle)
        pnlOrder.Enabled = False
        pnlOrder.ForeColor = Color.SaddleBrown
        pnlOrder.Location = New Point(12, 15)
        pnlOrder.Margin = New Padding(3, 4, 3, 4)
        pnlOrder.Name = "pnlOrder"
        pnlOrder.Size = New Size(920, 725)
        pnlOrder.TabIndex = 6
        ' 
        ' cboOrderStatus
        ' 
        cboOrderStatus.FormattingEnabled = True
        cboOrderStatus.Location = New Point(326, 83)
        cboOrderStatus.Margin = New Padding(3, 4, 3, 4)
        cboOrderStatus.Name = "cboOrderStatus"
        cboOrderStatus.Size = New Size(137, 28)
        cboOrderStatus.TabIndex = 10
        cboOrderStatus.Text = "Order Status"
        ' 
        ' btnAddOrder
        ' 
        btnAddOrder.BackColor = Color.SaddleBrown
        btnAddOrder.Font = New Font("Lucida Sans Unicode", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAddOrder.ForeColor = Color.WhiteSmoke
        btnAddOrder.Location = New Point(755, 80)
        btnAddOrder.Margin = New Padding(3, 4, 3, 4)
        btnAddOrder.Name = "btnAddOrder"
        btnAddOrder.Size = New Size(137, 34)
        btnAddOrder.TabIndex = 9
        btnAddOrder.Text = "+Order"
        btnAddOrder.UseVisualStyleBackColor = False
        ' 
        ' dgvOrder
        ' 
        dgvOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvOrder.BackgroundColor = Color.FromArgb(CByte(244), CByte(239), CByte(227))
        dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvOrder.Columns.AddRange(New DataGridViewColumn() {colOrderID, colCustomerID, colOrderDate, colTotalAmount, colOrderStatus, colView, colDelete})
        dgvOrder.GridColor = Color.Sienna
        dgvOrder.Location = New Point(24, 121)
        dgvOrder.Margin = New Padding(3, 4, 3, 4)
        dgvOrder.Name = "dgvOrder"
        dgvOrder.RightToLeft = RightToLeft.No
        dgvOrder.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        dgvOrder.RowHeadersWidth = 51
        dgvOrder.RowTemplate.Height = 24
        dgvOrder.Size = New Size(868, 569)
        dgvOrder.TabIndex = 7
        ' 
        ' colOrderID
        ' 
        colOrderID.FillWeight = 135F
        colOrderID.HeaderText = "Order ID"
        colOrderID.MinimumWidth = 6
        colOrderID.Name = "colOrderID"
        ' 
        ' colCustomerID
        ' 
        colCustomerID.FillWeight = 135F
        colCustomerID.HeaderText = "Customer ID"
        colCustomerID.MinimumWidth = 6
        colCustomerID.Name = "colCustomerID"
        ' 
        ' colOrderDate
        ' 
        colOrderDate.FillWeight = 135F
        colOrderDate.HeaderText = "Order Date"
        colOrderDate.MinimumWidth = 6
        colOrderDate.Name = "colOrderDate"
        ' 
        ' colTotalAmount
        ' 
        colTotalAmount.FillWeight = 150F
        colTotalAmount.HeaderText = "Total Amount"
        colTotalAmount.MinimumWidth = 6
        colTotalAmount.Name = "colTotalAmount"
        ' 
        ' colOrderStatus
        ' 
        colOrderStatus.HeaderText = "Order Status"
        colOrderStatus.MinimumWidth = 6
        colOrderStatus.Name = "colOrderStatus"
        ' 
        ' colView
        ' 
        colView.HeaderText = "View"
        colView.MinimumWidth = 6
        colView.Name = "colView"
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
        btnRefresh.Location = New Point(612, 80)
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
        txtSearch.Size = New Size(296, 27)
        txtSearch.TabIndex = 1
        txtSearch.Text = "Search order..."
        txtSearch.UseWaitCursor = True
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Lucida Sans Unicode", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(20, 19)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(291, 34)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Order Management"
        ' 
        ' btnGoBackDashboard
        ' 
        btnGoBackDashboard.BackColor = Color.SaddleBrown
        btnGoBackDashboard.Font = New Font("Lucida Sans Unicode", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnGoBackDashboard.ForeColor = Color.WhiteSmoke
        btnGoBackDashboard.Location = New Point(469, 80)
        btnGoBackDashboard.Margin = New Padding(3, 4, 3, 4)
        btnGoBackDashboard.Name = "btnGoBackDashboard"
        btnGoBackDashboard.Size = New Size(137, 34)
        btnGoBackDashboard.TabIndex = 11
        btnGoBackDashboard.Text = "Dashboard"
        btnGoBackDashboard.UseVisualStyleBackColor = False
        ' 
        ' frmOrder
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(942, 754)
        Controls.Add(pnlOrder)
        Margin = New Padding(3, 4, 3, 4)
        Name = "frmOrder"
        Text = "Order "
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