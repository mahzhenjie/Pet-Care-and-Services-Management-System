<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddOrderDetail
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
        pnlAddOrderDetail = New Panel()
        btnCancel = New Button()
        btnSave = New Button()
        txtSubtotal = New TextBox()
        txtUnitPrice = New TextBox()
        txtQuantity = New TextBox()
        txtProductID = New TextBox()
        txtOrderID = New TextBox()
        lblSubtotal = New Label()
        lblUnitPrice = New Label()
        lblQuantity = New Label()
        lblProductID = New Label()
        lblOrderID = New Label()
        lblTitle = New Label()
        pnlAddOrderDetail.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlAddOrderDetail
        ' 
        pnlAddOrderDetail.BackColor = Color.FromArgb(CByte(235), CByte(218), CByte(191))
        pnlAddOrderDetail.Controls.Add(btnCancel)
        pnlAddOrderDetail.Controls.Add(btnSave)
        pnlAddOrderDetail.Controls.Add(txtSubtotal)
        pnlAddOrderDetail.Controls.Add(txtUnitPrice)
        pnlAddOrderDetail.Controls.Add(txtQuantity)
        pnlAddOrderDetail.Controls.Add(txtProductID)
        pnlAddOrderDetail.Controls.Add(txtOrderID)
        pnlAddOrderDetail.Controls.Add(lblSubtotal)
        pnlAddOrderDetail.Controls.Add(lblUnitPrice)
        pnlAddOrderDetail.Controls.Add(lblQuantity)
        pnlAddOrderDetail.Controls.Add(lblProductID)
        pnlAddOrderDetail.Controls.Add(lblOrderID)
        pnlAddOrderDetail.Controls.Add(lblTitle)
        pnlAddOrderDetail.Location = New Point(12, 15)
        pnlAddOrderDetail.Name = "pnlAddOrderDetail"
        pnlAddOrderDetail.Size = New Size(600, 500)
        pnlAddOrderDetail.TabIndex = 0
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(242), CByte(215), CByte(215))
        btnCancel.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.SaddleBrown
        btnCancel.Location = New Point(315, 400)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(120, 40)
        btnCancel.TabIndex = 11
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.SaddleBrown
        btnSave.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = Color.WhiteSmoke
        btnSave.Location = New Point(165, 400)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(120, 40)
        btnSave.TabIndex = 10
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' txtSubtotal
        ' 
        txtSubtotal.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSubtotal.ForeColor = Color.Sienna
        txtSubtotal.Location = New Point(245, 330)
        txtSubtotal.Name = "txtSubtotal"
        txtSubtotal.ReadOnly = True
        txtSubtotal.Size = New Size(250, 30)
        txtSubtotal.TabIndex = 9
        ' 
        ' txtUnitPrice
        ' 
        txtUnitPrice.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUnitPrice.ForeColor = Color.Sienna
        txtUnitPrice.Location = New Point(245, 275)
        txtUnitPrice.Name = "txtUnitPrice"
        txtUnitPrice.Size = New Size(250, 30)
        txtUnitPrice.TabIndex = 8
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtQuantity.ForeColor = Color.Sienna
        txtQuantity.Location = New Point(245, 220)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(250, 30)
        txtQuantity.TabIndex = 7
        ' 
        ' txtProductID
        ' 
        txtProductID.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtProductID.ForeColor = Color.Sienna
        txtProductID.Location = New Point(245, 165)
        txtProductID.Name = "txtProductID"
        txtProductID.Size = New Size(250, 30)
        txtProductID.TabIndex = 6
        ' 
        ' txtOrderID
        ' 
        txtOrderID.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtOrderID.ForeColor = Color.Sienna
        txtOrderID.Location = New Point(245, 110)
        txtOrderID.Name = "txtOrderID"
        txtOrderID.ReadOnly = True
        txtOrderID.Size = New Size(250, 30)
        txtOrderID.TabIndex = 5
        ' 
        ' lblSubtotal
        ' 
        lblSubtotal.AutoSize = True
        lblSubtotal.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSubtotal.ForeColor = Color.SaddleBrown
        lblSubtotal.Location = New Point(85, 335)
        lblSubtotal.Name = "lblSubtotal"
        lblSubtotal.Size = New Size(85, 20)
        lblSubtotal.TabIndex = 4
        lblSubtotal.Text = "Subtotal:"
        ' 
        ' lblUnitPrice
        ' 
        lblUnitPrice.AutoSize = True
        lblUnitPrice.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUnitPrice.ForeColor = Color.SaddleBrown
        lblUnitPrice.Location = New Point(85, 280)
        lblUnitPrice.Name = "lblUnitPrice"
        lblUnitPrice.Size = New Size(100, 20)
        lblUnitPrice.TabIndex = 3
        lblUnitPrice.Text = "Unit Price:"
        ' 
        ' lblQuantity
        ' 
        lblQuantity.AutoSize = True
        lblQuantity.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblQuantity.ForeColor = Color.SaddleBrown
        lblQuantity.Location = New Point(85, 225)
        lblQuantity.Name = "lblQuantity"
        lblQuantity.Size = New Size(90, 20)
        lblQuantity.TabIndex = 2
        lblQuantity.Text = "Quantity:"
        ' 
        ' lblProductID
        ' 
        lblProductID.AutoSize = True
        lblProductID.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblProductID.ForeColor = Color.SaddleBrown
        lblProductID.Location = New Point(85, 170)
        lblProductID.Name = "lblProductID"
        lblProductID.Size = New Size(105, 20)
        lblProductID.TabIndex = 1
        lblProductID.Text = "Product ID:"
        ' 
        ' lblOrderID
        ' 
        lblOrderID.AutoSize = True
        lblOrderID.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblOrderID.ForeColor = Color.SaddleBrown
        lblOrderID.Location = New Point(85, 115)
        lblOrderID.Name = "lblOrderID"
        lblOrderID.Size = New Size(90, 20)
        lblOrderID.TabIndex = 0
        lblOrderID.Text = "Order ID:"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Lucida Sans Unicode", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.SaddleBrown
        lblTitle.Location = New Point(80, 35)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(350, 34)
        lblTitle.TabIndex = 12
        lblTitle.Text = "Add New Order Detail"
        ' 
        ' frmAddOrderDetail
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(235), CByte(218), CByte(191))
        ClientSize = New Size(624, 530)
        Controls.Add(pnlAddOrderDetail)
        Name = "frmAddOrderDetail"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add New Order Detail"
        pnlAddOrderDetail.ResumeLayout(False)
        pnlAddOrderDetail.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlAddOrderDetail As Panel
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents txtUnitPrice As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtProductID As TextBox
    Friend WithEvents txtOrderID As TextBox
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblUnitPrice As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblProductID As Label
    Friend WithEvents lblOrderID As Label
    Friend WithEvents lblTitle As Label

End Class