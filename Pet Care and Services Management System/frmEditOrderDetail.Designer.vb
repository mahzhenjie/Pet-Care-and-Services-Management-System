<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEditOrderDetail
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
        pnlEditOrderDetail = New Panel()
        btnCancel = New Button()
        btnSave = New Button()
        txtSubtotal = New TextBox()
        txtUnitPrice = New TextBox()
        txtQuantity = New TextBox()
        txtProductID = New TextBox()
        txtOrderID = New TextBox()
        txtOrderDetailID = New TextBox()
        lblSubtotal = New Label()
        lblUnitPrice = New Label()
        lblQuantity = New Label()
        lblProductID = New Label()
        lblOrderID = New Label()
        lblOrderDetailID = New Label()
        lblTitle = New Label()
        pnlEditOrderDetail.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlEditOrderDetail
        ' 
        pnlEditOrderDetail.BackColor = Color.FromArgb(CByte(235), CByte(218), CByte(191))
        pnlEditOrderDetail.Controls.Add(btnCancel)
        pnlEditOrderDetail.Controls.Add(btnSave)
        pnlEditOrderDetail.Controls.Add(txtSubtotal)
        pnlEditOrderDetail.Controls.Add(txtUnitPrice)
        pnlEditOrderDetail.Controls.Add(txtQuantity)
        pnlEditOrderDetail.Controls.Add(txtProductID)
        pnlEditOrderDetail.Controls.Add(txtOrderID)
        pnlEditOrderDetail.Controls.Add(txtOrderDetailID)
        pnlEditOrderDetail.Controls.Add(lblSubtotal)
        pnlEditOrderDetail.Controls.Add(lblUnitPrice)
        pnlEditOrderDetail.Controls.Add(lblQuantity)
        pnlEditOrderDetail.Controls.Add(lblProductID)
        pnlEditOrderDetail.Controls.Add(lblOrderID)
        pnlEditOrderDetail.Controls.Add(lblOrderDetailID)
        pnlEditOrderDetail.Controls.Add(lblTitle)
        pnlEditOrderDetail.Location = New Point(12, 15)
        pnlEditOrderDetail.Name = "pnlEditOrderDetail"
        pnlEditOrderDetail.Size = New Size(600, 550)
        pnlEditOrderDetail.TabIndex = 0
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(242), CByte(215), CByte(215))
        btnCancel.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.SaddleBrown
        btnCancel.Location = New Point(315, 450)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(120, 40)
        btnCancel.TabIndex = 13
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.SaddleBrown
        btnSave.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = Color.WhiteSmoke
        btnSave.Location = New Point(165, 450)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(120, 40)
        btnSave.TabIndex = 12
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' txtSubtotal
        ' 
        txtSubtotal.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSubtotal.ForeColor = Color.Sienna
        txtSubtotal.Location = New Point(245, 375)
        txtSubtotal.Name = "txtSubtotal"
        txtSubtotal.ReadOnly = True
        txtSubtotal.Size = New Size(250, 30)
        txtSubtotal.TabIndex = 11
        ' 
        ' txtUnitPrice
        ' 
        txtUnitPrice.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUnitPrice.ForeColor = Color.Sienna
        txtUnitPrice.Location = New Point(245, 320)
        txtUnitPrice.Name = "txtUnitPrice"
        txtUnitPrice.Size = New Size(250, 30)
        txtUnitPrice.TabIndex = 10
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtQuantity.ForeColor = Color.Sienna
        txtQuantity.Location = New Point(245, 265)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(250, 30)
        txtQuantity.TabIndex = 9
        ' 
        ' txtProductID
        ' 
        txtProductID.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtProductID.ForeColor = Color.Sienna
        txtProductID.Location = New Point(245, 210)
        txtProductID.Name = "txtProductID"
        txtProductID.Size = New Size(250, 30)
        txtProductID.TabIndex = 8
        ' 
        ' txtOrderID
        ' 
        txtOrderID.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtOrderID.ForeColor = Color.Sienna
        txtOrderID.Location = New Point(245, 155)
        txtOrderID.Name = "txtOrderID"
        txtOrderID.ReadOnly = True
        txtOrderID.Size = New Size(250, 30)
        txtOrderID.TabIndex = 7
        ' 
        ' txtOrderDetailID
        ' 
        txtOrderDetailID.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtOrderDetailID.ForeColor = Color.Sienna
        txtOrderDetailID.Location = New Point(245, 100)
        txtOrderDetailID.Name = "txtOrderDetailID"
        txtOrderDetailID.ReadOnly = True
        txtOrderDetailID.Size = New Size(250, 30)
        txtOrderDetailID.TabIndex = 6
        ' 
        ' lblSubtotal
        ' 
        lblSubtotal.AutoSize = True
        lblSubtotal.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSubtotal.ForeColor = Color.SaddleBrown
        lblSubtotal.Location = New Point(85, 380)
        lblSubtotal.Name = "lblSubtotal"
        lblSubtotal.Size = New Size(85, 20)
        lblSubtotal.TabIndex = 5
        lblSubtotal.Text = "Subtotal:"
        ' 
        ' lblUnitPrice
        ' 
        lblUnitPrice.AutoSize = True
        lblUnitPrice.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUnitPrice.ForeColor = Color.SaddleBrown
        lblUnitPrice.Location = New Point(85, 325)
        lblUnitPrice.Name = "lblUnitPrice"
        lblUnitPrice.Size = New Size(100, 20)
        lblUnitPrice.TabIndex = 4
        lblUnitPrice.Text = "Unit Price:"
        ' 
        ' lblQuantity
        ' 
        lblQuantity.AutoSize = True
        lblQuantity.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblQuantity.ForeColor = Color.SaddleBrown
        lblQuantity.Location = New Point(85, 270)
        lblQuantity.Name = "lblQuantity"
        lblQuantity.Size = New Size(90, 20)
        lblQuantity.TabIndex = 3
        lblQuantity.Text = "Quantity:"
        ' 
        ' lblProductID
        ' 
        lblProductID.AutoSize = True
        lblProductID.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblProductID.ForeColor = Color.SaddleBrown
        lblProductID.Location = New Point(85, 215)
        lblProductID.Name = "lblProductID"
        lblProductID.Size = New Size(105, 20)
        lblProductID.TabIndex = 2
        lblProductID.Text = "Product ID:"
        ' 
        ' lblOrderID
        ' 
        lblOrderID.AutoSize = True
        lblOrderID.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblOrderID.ForeColor = Color.SaddleBrown
        lblOrderID.Location = New Point(85, 160)
        lblOrderID.Name = "lblOrderID"
        lblOrderID.Size = New Size(90, 20)
        lblOrderID.TabIndex = 1
        lblOrderID.Text = "Order ID:"
        ' 
        ' lblOrderDetailID
        ' 
        lblOrderDetailID.AutoSize = True
        lblOrderDetailID.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblOrderDetailID.ForeColor = Color.SaddleBrown
        lblOrderDetailID.Location = New Point(85, 105)
        lblOrderDetailID.Name = "lblOrderDetailID"
        lblOrderDetailID.Size = New Size(135, 20)
        lblOrderDetailID.TabIndex = 0
        lblOrderDetailID.Text = "Order Detail ID:"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Lucida Sans Unicode", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.SaddleBrown
        lblTitle.Location = New Point(80, 35)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(360, 34)
        lblTitle.TabIndex = 14
        lblTitle.Text = "Edit Order Detail"
        ' 
        ' frmEditOrderDetail
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(235), CByte(218), CByte(191))
        ClientSize = New Size(624, 580)
        Controls.Add(pnlEditOrderDetail)
        Name = "frmEditOrderDetail"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Edit Order Detail"
        pnlEditOrderDetail.ResumeLayout(False)
        pnlEditOrderDetail.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlEditOrderDetail As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents txtUnitPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtProductID As System.Windows.Forms.TextBox
    Friend WithEvents txtOrderID As System.Windows.Forms.TextBox
    Friend WithEvents txtOrderDetailID As System.Windows.Forms.TextBox
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents lblUnitPrice As System.Windows.Forms.Label
    Friend WithEvents lblQuantity As System.Windows.Forms.Label
    Friend WithEvents lblProductID As System.Windows.Forms.Label
    Friend WithEvents lblOrderID As System.Windows.Forms.Label
    Friend WithEvents lblOrderDetailID As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label

End Class