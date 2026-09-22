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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
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
        pnlProduct.BackColor = Color.FromArgb(CByte(232), CByte(216), CByte(194))
        pnlProduct.Controls.Add(btnGoBackDashboard)
        pnlProduct.Controls.Add(cboCategory)
        pnlProduct.Controls.Add(dgvProduct)
        pnlProduct.Controls.Add(btnAddProduct)
        pnlProduct.Controls.Add(btnRefresh)
        pnlProduct.Controls.Add(txtSearch)
        pnlProduct.Controls.Add(lblTitle)
        pnlProduct.ForeColor = Color.SaddleBrown
        pnlProduct.Location = New Point(12, 15)
        pnlProduct.Margin = New Padding(3, 4, 3, 4)
        pnlProduct.Name = "pnlProduct"
        pnlProduct.Size = New Size(920, 725)
        pnlProduct.TabIndex = 3
        ' 
        ' cboCategory
        ' 
        cboCategory.Font = New Font("Lucida Sans Unicode", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cboCategory.ForeColor = Color.Sienna
        cboCategory.FormattingEnabled = True
        cboCategory.Location = New Point(369, 87)
        cboCategory.Margin = New Padding(3, 4, 3, 4)
        cboCategory.Name = "cboCategory"
        cboCategory.Size = New Size(87, 28)
        cboCategory.TabIndex = 12
        cboCategory.Text = "Category"
        ' 
        ' dgvProduct
        ' 
        dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvProduct.BackgroundColor = Color.FromArgb(CByte(244), CByte(239), CByte(227))
        dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProduct.Columns.AddRange(New DataGridViewColumn() {colProductID, colProductName, colCategory, colDescription, colPrice, colStockQuantity, colPhoto, colEdit, colDelete})
        dgvProduct.GridColor = Color.Sienna
        dgvProduct.Location = New Point(24, 121)
        dgvProduct.Margin = New Padding(3, 4, 3, 4)
        dgvProduct.Name = "dgvProduct"
        dgvProduct.RightToLeft = RightToLeft.No
        dgvProduct.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        dgvProduct.RowHeadersWidth = 51
        dgvProduct.RowTemplate.Height = 80
        dgvProduct.Size = New Size(868, 569)
        dgvProduct.TabIndex = 7
        ' 
        ' colProductID
        ' 
        colProductID.FillWeight = 100.0F
        colProductID.HeaderText = "Product ID"
        colProductID.MinimumWidth = 6
        colProductID.Name = "colProductID"
        ' 
        ' colProductName
        ' 
        colProductName.FillWeight = 125.0F
        colProductName.HeaderText = "Product Name"
        colProductName.MinimumWidth = 6
        colProductName.Name = "colProductName"
        ' 
        ' colCategory
        ' 
        colCategory.FillWeight = 85.0F
        colCategory.HeaderText = "Category"
        colCategory.MinimumWidth = 6
        colCategory.Name = "colCategory"
        ' 
        ' colDescription
        ' 
        colDescription.FillWeight = 180.0F
        colDescription.HeaderText = "Description"
        colDescription.MinimumWidth = 6
        colDescription.Name = "colDescription"
        ' 
        ' colPrice
        ' 
        colPrice.FillWeight = 80.0F
        colPrice.HeaderText = "Price"
        colPrice.MinimumWidth = 6
        colPrice.Name = "colPrice"
        ' 
        ' colStockQuantity
        ' 
        colStockQuantity.FillWeight = 90.0F
        colStockQuantity.HeaderText = "Stock Quantity"
        colStockQuantity.MinimumWidth = 6
        colStockQuantity.Name = "colStockQuantity"
        ' 
        ' colPhoto
        ' 
        colPhoto.FillWeight = 100.0F
        colPhoto.HeaderText = "Photo"
        colPhoto.ImageLayout = DataGridViewImageCellLayout.Zoom
        colPhoto.MinimumWidth = 6
        colPhoto.Name = "colPhoto"
        ' 
        ' colEdit
        ' 
        colEdit.FillWeight = 70.0F
        colEdit.HeaderText = "Edit"
        colEdit.MinimumWidth = 6
        colEdit.Name = "colEdit"
        colEdit.Text = "[Edit]"
        ' 
        ' colDelete
        ' 
        colDelete.FillWeight = 70.0F
        colDelete.HeaderText = "Delete"
        colDelete.MinimumWidth = 6
        colDelete.Name = "colDelete"
        colDelete.Text = "[Delete]"
        ' 
        ' btnAddProduct
        ' 
        btnAddProduct.BackColor = Color.SaddleBrown
        btnAddProduct.Font = New Font("Lucida Sans Unicode", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAddProduct.ForeColor = Color.WhiteSmoke
        btnAddProduct.Location = New Point(748, 84)
        btnAddProduct.Margin = New Padding(3, 4, 3, 4)
        btnAddProduct.Name = "btnAddProduct"
        btnAddProduct.Size = New Size(144, 34)
        btnAddProduct.TabIndex = 6
        btnAddProduct.Text = "+Product"
        btnAddProduct.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.SaddleBrown
        btnRefresh.Font = New Font("Lucida Sans Unicode", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRefresh.ForeColor = Color.WhiteSmoke
        btnRefresh.Location = New Point(605, 84)
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
        txtSearch.Size = New Size(313, 27)
        txtSearch.TabIndex = 1
        txtSearch.Text = "Search product..."
        txtSearch.UseWaitCursor = True
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Lucida Sans Unicode", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(20, 19)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(317, 34)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Product Management"
        ' 
        ' btnGoBackDashboard
        ' 
        btnGoBackDashboard.BackColor = Color.SaddleBrown
        btnGoBackDashboard.Font = New Font("Lucida Sans Unicode", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnGoBackDashboard.ForeColor = Color.WhiteSmoke
        btnGoBackDashboard.Location = New Point(462, 85)
        btnGoBackDashboard.Margin = New Padding(3, 4, 3, 4)
        btnGoBackDashboard.Name = "btnGoBackDashboard"
        btnGoBackDashboard.Size = New Size(137, 34)
        btnGoBackDashboard.TabIndex = 13
        btnGoBackDashboard.Text = "Dashboard"
        btnGoBackDashboard.UseVisualStyleBackColor = False
        ' 
        ' frmProduct
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(942, 754)
        Controls.Add(pnlProduct)
        Margin = New Padding(3, 4, 3, 4)
        Name = "frmProduct"
        Text = "Product"
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