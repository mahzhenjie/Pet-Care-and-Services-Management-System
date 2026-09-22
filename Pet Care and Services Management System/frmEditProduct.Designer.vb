<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEditProduct
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pnlEditProduct = New Panel()
        btnChoosePhoto = New Button()
        picProduct = New PictureBox()
        btnCancel = New Button()
        btnSave = New Button()
        txtStockQuantity = New TextBox()
        txtPrice = New TextBox()
        txtDescription = New TextBox()
        cboCategory = New ComboBox()
        txtProductName = New TextBox()
        txtProductID = New TextBox()
        lblPhoto = New Label()
        lblStockQuantity = New Label()
        lblPrice = New Label()
        lblDescription = New Label()
        lblCategory = New Label()
        lblProductName = New Label()
        lblProductID = New Label()
        lblTitle = New Label()
        pnlEditProduct.SuspendLayout()
        CType(picProduct, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlEditProduct
        ' 
        pnlEditProduct.BackColor = Color.FromArgb(CByte(235), CByte(218), CByte(191))
        pnlEditProduct.Controls.Add(btnChoosePhoto)
        pnlEditProduct.Controls.Add(picProduct)
        pnlEditProduct.Controls.Add(btnCancel)
        pnlEditProduct.Controls.Add(btnSave)
        pnlEditProduct.Controls.Add(txtStockQuantity)
        pnlEditProduct.Controls.Add(txtPrice)
        pnlEditProduct.Controls.Add(txtDescription)
        pnlEditProduct.Controls.Add(cboCategory)
        pnlEditProduct.Controls.Add(txtProductName)
        pnlEditProduct.Controls.Add(txtProductID)
        pnlEditProduct.Controls.Add(lblPhoto)
        pnlEditProduct.Controls.Add(lblStockQuantity)
        pnlEditProduct.Controls.Add(lblPrice)
        pnlEditProduct.Controls.Add(lblDescription)
        pnlEditProduct.Controls.Add(lblCategory)
        pnlEditProduct.Controls.Add(lblProductName)
        pnlEditProduct.Controls.Add(lblProductID)
        pnlEditProduct.Controls.Add(lblTitle)
        pnlEditProduct.Location = New Point(12, 15)
        pnlEditProduct.Name = "pnlEditProduct"
        pnlEditProduct.Size = New Size(720, 650)
        pnlEditProduct.TabIndex = 0
        ' 
        ' btnChoosePhoto
        ' 
        btnChoosePhoto.BackColor = Color.SaddleBrown
        btnChoosePhoto.Font = New Font("Lucida Sans Unicode", 8.5F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnChoosePhoto.ForeColor = Color.WhiteSmoke
        btnChoosePhoto.Location = New Point(500, 455)
        btnChoosePhoto.Name = "btnChoosePhoto"
        btnChoosePhoto.Size = New Size(150, 38)
        btnChoosePhoto.TabIndex = 16
        btnChoosePhoto.Text = "Choose Photo"
        btnChoosePhoto.UseVisualStyleBackColor = False
        ' 
        ' picProduct
        ' 
        picProduct.BackColor = Color.FromArgb(CByte(244), CByte(239), CByte(227))
        picProduct.BorderStyle = BorderStyle.FixedSingle
        picProduct.Location = New Point(500, 190)
        picProduct.Name = "picProduct"
        picProduct.Size = New Size(150, 240)
        picProduct.SizeMode = PictureBoxSizeMode.Zoom
        picProduct.TabIndex = 15
        picProduct.TabStop = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(242), CByte(215), CByte(215))
        btnCancel.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.SaddleBrown
        btnCancel.Location = New Point(385, 565)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(120, 40)
        btnCancel.TabIndex = 14
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.SaddleBrown
        btnSave.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = Color.WhiteSmoke
        btnSave.Location = New Point(235, 565)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(120, 40)
        btnSave.TabIndex = 13
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' txtStockQuantity
        ' 
        txtStockQuantity.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtStockQuantity.ForeColor = Color.Sienna
        txtStockQuantity.Location = New Point(245, 455)
        txtStockQuantity.Name = "txtStockQuantity"
        txtStockQuantity.Size = New Size(220, 30)
        txtStockQuantity.TabIndex = 12
        ' 
        ' txtPrice
        ' 
        txtPrice.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPrice.ForeColor = Color.Sienna
        txtPrice.Location = New Point(245, 400)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(220, 30)
        txtPrice.TabIndex = 11
        ' 
        ' txtDescription
        ' 
        txtDescription.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDescription.ForeColor = Color.Sienna
        txtDescription.Location = New Point(245, 300)
        txtDescription.Multiline = True
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(220, 75)
        txtDescription.TabIndex = 10
        ' 
        ' cboCategory
        ' 
        cboCategory.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cboCategory.ForeColor = Color.Sienna
        cboCategory.FormattingEnabled = True
        cboCategory.Items.AddRange(New Object() {"Food", "Toy", "Accessories", "Grooming", "Health", "Other"})
        cboCategory.Location = New Point(245, 245)
        cboCategory.Name = "cboCategory"
        cboCategory.Size = New Size(220, 28)
        cboCategory.TabIndex = 9
        ' 
        ' txtProductName
        ' 
        txtProductName.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtProductName.ForeColor = Color.Sienna
        txtProductName.Location = New Point(245, 190)
        txtProductName.Name = "txtProductName"
        txtProductName.Size = New Size(220, 30)
        txtProductName.TabIndex = 8
        ' 
        ' txtProductID
        ' 
        txtProductID.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtProductID.ForeColor = Color.Sienna
        txtProductID.Location = New Point(245, 135)
        txtProductID.Name = "txtProductID"
        txtProductID.ReadOnly = True
        txtProductID.Size = New Size(220, 30)
        txtProductID.TabIndex = 7
        ' 
        ' lblPhoto
        ' 
        lblPhoto.AutoSize = True
        lblPhoto.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPhoto.ForeColor = Color.SaddleBrown
        lblPhoto.Location = New Point(500, 160)
        lblPhoto.Name = "lblPhoto"
        lblPhoto.Size = New Size(60, 20)
        lblPhoto.TabIndex = 6
        lblPhoto.Text = "Photo:"
        ' 
        ' lblStockQuantity
        ' 
        lblStockQuantity.AutoSize = True
        lblStockQuantity.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblStockQuantity.ForeColor = Color.SaddleBrown
        lblStockQuantity.Location = New Point(70, 460)
        lblStockQuantity.Name = "lblStockQuantity"
        lblStockQuantity.Size = New Size(130, 20)
        lblStockQuantity.TabIndex = 5
        lblStockQuantity.Text = "Stock Quantity:"
        ' 
        ' lblPrice
        ' 
        lblPrice.AutoSize = True
        lblPrice.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPrice.ForeColor = Color.SaddleBrown
        lblPrice.Location = New Point(70, 405)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(55, 20)
        lblPrice.TabIndex = 4
        lblPrice.Text = "Price:"
        ' 
        ' lblDescription
        ' 
        lblDescription.AutoSize = True
        lblDescription.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDescription.ForeColor = Color.SaddleBrown
        lblDescription.Location = New Point(70, 305)
        lblDescription.Name = "lblDescription"
        lblDescription.Size = New Size(115, 20)
        lblDescription.TabIndex = 3
        lblDescription.Text = "Description:"
        ' 
        ' lblCategory
        ' 
        lblCategory.AutoSize = True
        lblCategory.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCategory.ForeColor = Color.SaddleBrown
        lblCategory.Location = New Point(70, 250)
        lblCategory.Name = "lblCategory"
        lblCategory.Size = New Size(90, 20)
        lblCategory.TabIndex = 2
        lblCategory.Text = "Category:"
        ' 
        ' lblProductName
        ' 
        lblProductName.AutoSize = True
        lblProductName.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblProductName.ForeColor = Color.SaddleBrown
        lblProductName.Location = New Point(70, 195)
        lblProductName.Name = "lblProductName"
        lblProductName.Size = New Size(125, 20)
        lblProductName.TabIndex = 1
        lblProductName.Text = "Product Name:"
        ' 
        ' lblProductID
        ' 
        lblProductID.AutoSize = True
        lblProductID.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblProductID.ForeColor = Color.SaddleBrown
        lblProductID.Location = New Point(70, 140)
        lblProductID.Name = "lblProductID"
        lblProductID.Size = New Size(100, 20)
        lblProductID.TabIndex = 0
        lblProductID.Text = "Product ID:"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Lucida Sans Unicode", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.SaddleBrown
        lblTitle.Location = New Point(70, 45)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(300, 34)
        lblTitle.TabIndex = 17
        lblTitle.Text = "Edit Product"
        ' 
        ' frmEditProduct
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(235), CByte(218), CByte(191))
        ClientSize = New Size(744, 680)
        Controls.Add(pnlEditProduct)
        Name = "frmEditProduct"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Edit Product"
        pnlEditProduct.ResumeLayout(False)
        pnlEditProduct.PerformLayout()
        CType(picProduct, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlEditProduct As System.Windows.Forms.Panel
    Friend WithEvents btnChoosePhoto As System.Windows.Forms.Button
    Friend WithEvents picProduct As System.Windows.Forms.PictureBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtStockQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents cboCategory As System.Windows.Forms.ComboBox
    Friend WithEvents txtProductName As System.Windows.Forms.TextBox
    Friend WithEvents txtProductID As System.Windows.Forms.TextBox
    Friend WithEvents lblPhoto As System.Windows.Forms.Label
    Friend WithEvents lblStockQuantity As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents lblCategory As System.Windows.Forms.Label
    Friend WithEvents lblProductName As System.Windows.Forms.Label
    Friend WithEvents lblProductID As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label

End Class