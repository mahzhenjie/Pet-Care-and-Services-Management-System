<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProduct
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
        pnlProduct = New Panel()
        cboCategory = New ComboBox()
        dgvProduct = New DataGridView()
        colProductID = New DataGridViewTextBoxColumn()
        colProductName = New DataGridViewTextBoxColumn()
        colCategory = New DataGridViewTextBoxColumn()
        colDescription = New DataGridViewTextBoxColumn()
        colPrice = New DataGridViewTextBoxColumn()
        colStockQuantity = New DataGridViewTextBoxColumn()
        colPhoto = New DataGridViewImageColumn()
        colEdit = New DataGridViewButtonColumn()
        colDelete = New DataGridViewButtonColumn()
        btnAddProduct = New Button()
        btnRefresh = New Button()
        txtSearch = New TextBox()
        lblTitle = New Label()
        btnGoBackDashboard = New Button()
        pnlProduct.SuspendLayout()
        CType(dgvProduct, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlProduct
        ' 
        pnlProduct.Anchor = CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles)
        pnlProduct.BackColor = Color.FromArgb(245, 230, 209)
        pnlProduct.Controls.Add(btnGoBackDashboard)
        pnlProduct.Controls.Add(cboCategory)
        pnlProduct.Controls.Add(dgvProduct)
        pnlProduct.Controls.Add(btnAddProduct)
        pnlProduct.Controls.Add(btnRefresh)
        pnlProduct.Controls.Add(txtSearch)
        pnlProduct.Controls.Add(lblTitle)
        pnlProduct.Location = New Point(15, 15)
        pnlProduct.Name = "pnlProduct"
        pnlProduct.Padding = New Padding(20)
        pnlProduct.Size = New Size(1130, 770)
        pnlProduct.TabIndex = 3
        ' 
        ' cboCategory
        ' 
        cboCategory.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        cboCategory.BackColor = Color.White
        cboCategory.DropDownStyle = ComboBoxStyle.DropDownList
        cboCategory.Font = New Font("Segoe UI", 10.0F)
        cboCategory.ForeColor = Color.FromArgb(61, 40, 27)
        cboCategory.FormattingEnabled = True
        cboCategory.Location = New Point(390, 84)
        cboCategory.Name = "cboCategory"
        cboCategory.Size = New Size(150, 31)
        cboCategory.TabIndex = 12
        ' 
        ' dgvProduct
        ' 
        dgvProduct.AllowUserToAddRows = False
        dgvProduct.AllowUserToDeleteRows = False
        dgvProduct.AllowUserToResizeRows = False
        dgvProduct.Anchor = CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles)
        dgvProduct.AutoGenerateColumns = False
        dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvProduct.BackgroundColor = Color.FromArgb(250, 247, 240)
        dgvProduct.BorderStyle = BorderStyle.None
        dgvProduct.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvProduct.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvProduct.ColumnHeadersDefaultCellStyle = New DataGridViewCellStyle With {
            .BackColor = Color.FromArgb(96, 52, 16),
            .ForeColor = Color.WhiteSmoke,
            .Font = New Font("Segoe UI", 9.5F, FontStyle.Bold),
            .Alignment = DataGridViewContentAlignment.MiddleLeft,
            .SelectionBackColor = Color.FromArgb(96, 52, 16),
            .SelectionForeColor = Color.WhiteSmoke
        }
        dgvProduct.ColumnHeadersHeight = 42
        dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvProduct.Columns.AddRange(New DataGridViewColumn() {
            colProductID,
            colProductName,
            colCategory,
            colDescription,
            colPrice,
            colStockQuantity,
            colPhoto,
            colEdit,
            colDelete
        })
        dgvProduct.DefaultCellStyle = New DataGridViewCellStyle With {
            .BackColor = Color.White,
            .ForeColor = Color.FromArgb(61, 40, 27),
            .Font = New Font("Segoe UI", 9.0F),
            .SelectionBackColor = Color.FromArgb(232, 216, 194),
            .SelectionForeColor = Color.FromArgb(61, 40, 27),
            .Alignment = DataGridViewContentAlignment.MiddleLeft
        }
        dgvProduct.GridColor = Color.FromArgb(225, 211, 192)
        dgvProduct.Location = New Point(20, 140)
        dgvProduct.MultiSelect = False
        dgvProduct.Name = "dgvProduct"
        dgvProduct.ReadOnly = True
        dgvProduct.RightToLeft = RightToLeft.No
        dgvProduct.RowHeadersVisible = False
        dgvProduct.RowTemplate.Height = 70
        dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvProduct.Size = New Size(1090, 605)
        dgvProduct.TabIndex = 7
        ' 
        ' colProductID
        ' 
        colProductID.FillWeight = 80.0F
        colProductID.HeaderText = "Product ID"
        colProductID.MinimumWidth = 6
        colProductID.Name = "colProductID"
        colProductID.ReadOnly = True
        ' 
        ' colProductName
        ' 
        colProductName.FillWeight = 120.0F
        colProductName.HeaderText = "Product Name"
        colProductName.MinimumWidth = 6
        colProductName.Name = "colProductName"
        colProductName.ReadOnly = True
        ' 
        ' colCategory
        ' 
        colCategory.FillWeight = 85.0F
        colCategory.HeaderText = "Category"
        colCategory.MinimumWidth = 6
        colCategory.Name = "colCategory"
        colCategory.ReadOnly = True
        ' 
        ' colDescription
        ' 
        colDescription.FillWeight = 160.0F
        colDescription.HeaderText = "Description"
        colDescription.MinimumWidth = 6
        colDescription.Name = "colDescription"
        colDescription.ReadOnly = True
        ' 
        ' colPrice
        ' 
        colPrice.FillWeight = 75.0F
        colPrice.HeaderText = "Price"
        colPrice.MinimumWidth = 6
        colPrice.Name = "colPrice"
        colPrice.ReadOnly = True
        ' 
        ' colStockQuantity
        ' 
        colStockQuantity.FillWeight = 95.0F
        colStockQuantity.HeaderText = "Stock Quantity"
        colStockQuantity.MinimumWidth = 6
        colStockQuantity.Name = "colStockQuantity"
        colStockQuantity.ReadOnly = True
        ' 
        ' colPhoto
        ' 
        colPhoto.FillWeight = 95.0F
        colPhoto.HeaderText = "Photo"
        colPhoto.ImageLayout = DataGridViewImageCellLayout.Zoom
        colPhoto.MinimumWidth = 6
        colPhoto.Name = "colPhoto"
        colPhoto.ReadOnly = True
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
        ' btnAddProduct
        ' 
        btnAddProduct.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnAddProduct.BackColor = Color.SaddleBrown
        btnAddProduct.FlatAppearance.BorderSize = 0
        btnAddProduct.FlatStyle = FlatStyle.Flat
        btnAddProduct.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnAddProduct.ForeColor = Color.WhiteSmoke
        btnAddProduct.Location = New Point(930, 82)
        btnAddProduct.Name = "btnAddProduct"
        btnAddProduct.Size = New Size(160, 38)
        btnAddProduct.TabIndex = 6
        btnAddProduct.Text = "+ Add Product"
        btnAddProduct.UseVisualStyleBackColor = False
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
        txtSearch.Size = New Size(355, 30)
        txtSearch.TabIndex = 1
        txtSearch.Text = "Search product..."
        txtSearch.UseWaitCursor = False
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
        lblTitle.Text = "Product Management"
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
        btnGoBackDashboard.TabIndex = 13
        btnGoBackDashboard.Text = "Dashboard"
        btnGoBackDashboard.UseVisualStyleBackColor = False
        ' 
        ' frmProduct
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(235, 221, 202)
        ClientSize = New Size(1160, 800)
        Controls.Add(pnlProduct)
        MinimumSize = New Size(1050, 700)
        Name = "frmProduct"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Product Management"
        pnlProduct.ResumeLayout(False)
        pnlProduct.PerformLayout()
        CType(dgvProduct, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlProduct As System.Windows.Forms.Panel
    Friend WithEvents dgvProduct As System.Windows.Forms.DataGridView
    Friend WithEvents btnAddProduct As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents colProductID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colProductName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCategory As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStockQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPhoto As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colEdit As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colDelete As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents cboCategory As System.Windows.Forms.ComboBox
    Friend WithEvents btnGoBackDashboard As Button

End Class