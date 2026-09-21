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
        Me.pnlProduct = New System.Windows.Forms.Panel()
        Me.dgvProduct = New System.Windows.Forms.DataGridView()
        Me.btnAddProduct = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.colProductID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStockQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEdit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.cboCategory = New System.Windows.Forms.ComboBox()
        Me.pnlProduct.SuspendLayout()
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlProduct
        '
        Me.pnlProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.pnlProduct.Controls.Add(Me.cboCategory)
        Me.pnlProduct.Controls.Add(Me.dgvProduct)
        Me.pnlProduct.Controls.Add(Me.btnAddProduct)
        Me.pnlProduct.Controls.Add(Me.btnRefresh)
        Me.pnlProduct.Controls.Add(Me.txtSearch)
        Me.pnlProduct.Controls.Add(Me.lblTitle)
        Me.pnlProduct.ForeColor = System.Drawing.Color.SaddleBrown
        Me.pnlProduct.Location = New System.Drawing.Point(12, 12)
        Me.pnlProduct.Name = "pnlProduct"
        Me.pnlProduct.Size = New System.Drawing.Size(920, 580)
        Me.pnlProduct.TabIndex = 3
        '
        'dgvProduct
        '
        Me.dgvProduct.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProduct.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {
            Me.colProductID,
            Me.colProductName,
            Me.colCategory,
            Me.colDescription,
            Me.colPrice,
            Me.colStockQuantity,
            Me.colEdit,
            Me.colDelete
        })
        Me.dgvProduct.GridColor = System.Drawing.Color.Sienna
        Me.dgvProduct.Location = New System.Drawing.Point(24, 97)
        Me.dgvProduct.Name = "dgvProduct"
        Me.dgvProduct.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgvProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvProduct.RowTemplate.Height = 24
        Me.dgvProduct.Size = New System.Drawing.Size(868, 455)
        Me.dgvProduct.TabIndex = 7
        '
        'btnAddProduct
        '
        Me.btnAddProduct.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnAddProduct.Font = New System.Drawing.Font("Lucida Sans Unicode", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddProduct.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddProduct.Location = New System.Drawing.Point(736, 67)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New System.Drawing.Size(156, 27)
        Me.btnAddProduct.TabIndex = 6
        Me.btnAddProduct.Text = "+Product"
        Me.btnAddProduct.UseVisualStyleBackColor = False
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnRefresh.Font = New System.Drawing.Font("Lucida Sans Unicode", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnRefresh.Location = New System.Drawing.Point(593, 67)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(137, 27)
        Me.btnRefresh.TabIndex = 3
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Lucida Sans Unicode", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Sienna
        Me.txtSearch.Location = New System.Drawing.Point(24, 64)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(398, 27)
        Me.txtSearch.TabIndex = 1
        Me.txtSearch.Text = "Search product..."
        Me.txtSearch.UseWaitCursor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Lucida Sans Unicode", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(20, 15)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(317, 34)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Product Management"
        '
        'colProductID
        '
        Me.colProductID.FillWeight = 135.0!
        Me.colProductID.HeaderText = "Product ID"
        Me.colProductID.Name = "colProductID"
        Me.colProductID.Width = 135
        '
        'colProductName
        '
        Me.colProductName.HeaderText = "Product Name"
        Me.colProductName.Name = "colProductName"
        '
        'colCategory
        '
        Me.colCategory.FillWeight = 85.0!
        Me.colCategory.HeaderText = "Category"
        Me.colCategory.Name = "colCategory"
        Me.colCategory.Width = 85
        '
        'colDescription
        '
        Me.colDescription.FillWeight = 200.0!
        Me.colDescription.HeaderText = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Width = 200
        '
        'colPrice
        '
        Me.colPrice.HeaderText = "Price"
        Me.colPrice.Name = "colPrice"
        '
        'colStockQuantity
        '
        Me.colStockQuantity.FillWeight = 85.0!
        Me.colStockQuantity.HeaderText = "Stock Quantity"
        Me.colStockQuantity.Name = "colStockQuantity"
        Me.colStockQuantity.Width = 85
        '
        'colEdit
        '
        Me.colEdit.HeaderText = "Edit"
        Me.colEdit.Name = "colEdit"
        Me.colEdit.Width = 60
        '
        'colDelete
        '
        Me.colDelete.HeaderText = "Delete"
        Me.colDelete.Name = "colDelete"
        Me.colDelete.Text = "[Delete]"
        Me.colDelete.Width = 60
        '
        'cboCategory
        '
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Location = New System.Drawing.Point(500, 67)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(87, 24)
        Me.cboCategory.TabIndex = 12
        Me.cboCategory.Text = "Category"
        '
        'frmProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 603)
        Me.Controls.Add(Me.pnlProduct)
        Me.Name = "frmProduct"
        Me.Text = "Porduct"
        Me.pnlProduct.ResumeLayout(False)
        Me.pnlProduct.PerformLayout()
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
    Friend WithEvents colEdit As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colDelete As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents cboCategory As System.Windows.Forms.ComboBox

End Class