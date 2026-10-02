<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOrderDetail
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
        pnlOrderDetail = New Panel()
        dgvOrderDetail = New DataGridView()
        colOrderDetailID = New DataGridViewTextBoxColumn()
        colOrderID = New DataGridViewTextBoxColumn()
        colProductID = New DataGridViewTextBoxColumn()
        colQuantity = New DataGridViewTextBoxColumn()
        colUnitPrice = New DataGridViewTextBoxColumn()
        colSubtotal = New DataGridViewTextBoxColumn()
        colEdit = New DataGridViewButtonColumn()
        colDelete = New DataGridViewButtonColumn()
        btnAddOrderDetail = New Button()
        btnRefresh = New Button()
        txtSearch = New TextBox()
        lblTitle = New Label()
        btnGoBackDashboard = New Button()
        pnlOrderDetail.SuspendLayout()
        CType(dgvOrderDetail, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlOrderDetail
        ' 
        pnlOrderDetail.Anchor = CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles)
        pnlOrderDetail.BackColor = Color.FromArgb(245, 230, 209)
        pnlOrderDetail.Controls.Add(btnGoBackDashboard)
        pnlOrderDetail.Controls.Add(dgvOrderDetail)
        pnlOrderDetail.Controls.Add(btnAddOrderDetail)
        pnlOrderDetail.Controls.Add(btnRefresh)
        pnlOrderDetail.Controls.Add(txtSearch)
        pnlOrderDetail.Controls.Add(lblTitle)
        pnlOrderDetail.Location = New Point(15, 15)
        pnlOrderDetail.Name = "pnlOrderDetail"
        pnlOrderDetail.Padding = New Padding(20)
        pnlOrderDetail.Size = New Size(1130, 770)
        pnlOrderDetail.TabIndex = 3
        ' 
        ' dgvOrderDetail
        ' 
        dgvOrderDetail.AllowUserToAddRows = False
        dgvOrderDetail.AllowUserToDeleteRows = False
        dgvOrderDetail.AllowUserToResizeRows = False
        dgvOrderDetail.Anchor = CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles)
        dgvOrderDetail.AutoGenerateColumns = False
        dgvOrderDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvOrderDetail.BackgroundColor = Color.FromArgb(250, 247, 240)
        dgvOrderDetail.BorderStyle = BorderStyle.None
        dgvOrderDetail.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvOrderDetail.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvOrderDetail.ColumnHeadersDefaultCellStyle = New DataGridViewCellStyle With {
            .BackColor = Color.FromArgb(96, 52, 16),
            .ForeColor = Color.WhiteSmoke,
            .Font = New Font("Segoe UI", 9.5F, FontStyle.Bold),
            .Alignment = DataGridViewContentAlignment.MiddleLeft,
            .SelectionBackColor = Color.FromArgb(96, 52, 16),
            .SelectionForeColor = Color.WhiteSmoke
        }
        dgvOrderDetail.ColumnHeadersHeight = 42
        dgvOrderDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvOrderDetail.Columns.AddRange(New DataGridViewColumn() {
            colOrderDetailID,
            colOrderID,
            colProductID,
            colQuantity,
            colUnitPrice,
            colSubtotal,
            colEdit,
            colDelete
        })
        dgvOrderDetail.DefaultCellStyle = New DataGridViewCellStyle With {
            .BackColor = Color.White,
            .ForeColor = Color.FromArgb(61, 40, 27),
            .Font = New Font("Segoe UI", 9.0F),
            .SelectionBackColor = Color.FromArgb(232, 216, 194),
            .SelectionForeColor = Color.FromArgb(61, 40, 27),
            .Alignment = DataGridViewContentAlignment.MiddleLeft
        }
        dgvOrderDetail.GridColor = Color.FromArgb(225, 211, 192)
        dgvOrderDetail.Location = New Point(20, 140)
        dgvOrderDetail.MultiSelect = False
        dgvOrderDetail.Name = "dgvOrderDetail"
        dgvOrderDetail.ReadOnly = True
        dgvOrderDetail.RightToLeft = RightToLeft.No
        dgvOrderDetail.RowHeadersVisible = False
        dgvOrderDetail.RowTemplate.Height = 38
        dgvOrderDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvOrderDetail.Size = New Size(1090, 605)
        dgvOrderDetail.TabIndex = 7
        ' 
        ' colOrderDetailID
        ' 
        colOrderDetailID.FillWeight = 115.0F
        colOrderDetailID.HeaderText = "Order Detail ID"
        colOrderDetailID.MinimumWidth = 6
        colOrderDetailID.Name = "colOrderDetailID"
        colOrderDetailID.ReadOnly = True
        ' 
        ' colOrderID
        ' 
        colOrderID.FillWeight = 90.0F
        colOrderID.HeaderText = "Order ID"
        colOrderID.MinimumWidth = 6
        colOrderID.Name = "colOrderID"
        colOrderID.ReadOnly = True
        ' 
        ' colProductID
        ' 
        colProductID.FillWeight = 95.0F
        colProductID.HeaderText = "Product ID"
        colProductID.MinimumWidth = 6
        colProductID.Name = "colProductID"
        colProductID.ReadOnly = True
        ' 
        ' colQuantity
        ' 
        colQuantity.FillWeight = 85.0F
        colQuantity.HeaderText = "Quantity"
        colQuantity.MinimumWidth = 6
        colQuantity.Name = "colQuantity"
        colQuantity.ReadOnly = True
        ' 
        ' colUnitPrice
        ' 
        colUnitPrice.FillWeight = 105.0F
        colUnitPrice.HeaderText = "Unit Price"
        colUnitPrice.MinimumWidth = 6
        colUnitPrice.Name = "colUnitPrice"
        colUnitPrice.ReadOnly = True
        ' 
        ' colSubtotal
        ' 
        colSubtotal.FillWeight = 105.0F
        colSubtotal.HeaderText = "Subtotal"
        colSubtotal.MinimumWidth = 6
        colSubtotal.Name = "colSubtotal"
        colSubtotal.ReadOnly = True
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
        ' btnAddOrderDetail
        ' 
        btnAddOrderDetail.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnAddOrderDetail.BackColor = Color.FromArgb(96, 52, 16)
        btnAddOrderDetail.FlatAppearance.BorderSize = 0
        btnAddOrderDetail.FlatStyle = FlatStyle.Flat
        btnAddOrderDetail.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnAddOrderDetail.ForeColor = Color.WhiteSmoke
        btnAddOrderDetail.Location = New Point(930, 82)
        btnAddOrderDetail.Name = "btnAddOrderDetail"
        btnAddOrderDetail.Size = New Size(160, 38)
        btnAddOrderDetail.TabIndex = 6
        btnAddOrderDetail.Text = "+ Add Order Detail"
        btnAddOrderDetail.UseVisualStyleBackColor = False
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
        txtSearch.Text = "Search order detail..."
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Georgia", 20.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(61, 40, 27)
        lblTitle.Location = New Point(20, 20)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(390, 39)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Order Detail Management"
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
        ' frmOrderDetail
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(235, 221, 202)
        ClientSize = New Size(1160, 800)
        Controls.Add(pnlOrderDetail)
        MinimumSize = New Size(1050, 700)
        Name = "frmOrderDetail"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Order Detail Management"
        pnlOrderDetail.ResumeLayout(False)
        pnlOrderDetail.PerformLayout()
        CType(dgvOrderDetail, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlOrderDetail As System.Windows.Forms.Panel
    Friend WithEvents dgvOrderDetail As System.Windows.Forms.DataGridView
    Friend WithEvents btnAddOrderDetail As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents colOrderDetailID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colOrderID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colProductID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colUnitPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSubtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEdit As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colDelete As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents btnGoBackDashboard As Button

End Class