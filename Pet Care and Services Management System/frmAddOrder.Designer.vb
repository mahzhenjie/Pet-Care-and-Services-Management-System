<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddOrder
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
        pnlAddOrder = New Panel()
        btnCancel = New Button()
        btnSave = New Button()
        cboOrderStatus = New ComboBox()
        dtpOrderDate = New DateTimePicker()
        txtTotalAmount = New TextBox()
        txtCustomerID = New TextBox()
        lblOrderStatus = New Label()
        lblOrderDate = New Label()
        lblTotalAmount = New Label()
        lblCustomerID = New Label()
        lblTitle = New Label()
        pnlAddOrder.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlAddOrder
        ' 
        pnlAddOrder.BackColor = Color.FromArgb(CByte(232), CByte(216), CByte(194))
        pnlAddOrder.BorderStyle = BorderStyle.FixedSingle
        pnlAddOrder.Controls.Add(btnCancel)
        pnlAddOrder.Controls.Add(btnSave)
        pnlAddOrder.Controls.Add(cboOrderStatus)
        pnlAddOrder.Controls.Add(dtpOrderDate)
        pnlAddOrder.Controls.Add(txtTotalAmount)
        pnlAddOrder.Controls.Add(txtCustomerID)
        pnlAddOrder.Controls.Add(lblOrderStatus)
        pnlAddOrder.Controls.Add(lblOrderDate)
        pnlAddOrder.Controls.Add(lblTotalAmount)
        pnlAddOrder.Controls.Add(lblCustomerID)
        pnlAddOrder.Controls.Add(lblTitle)
        pnlAddOrder.Location = New Point(20, 20)
        pnlAddOrder.Name = "pnlAddOrder"
        pnlAddOrder.Size = New Size(560, 590)
        pnlAddOrder.TabIndex = 0
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(244), CByte(218), CByte(207))
        btnCancel.FlatAppearance.BorderColor = Color.White
        btnCancel.FlatAppearance.BorderSize = 2
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Lucida Sans Unicode", 8.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.SaddleBrown
        btnCancel.Location = New Point(360, 470)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(145, 42)
        btnCancel.TabIndex = 10
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.SaddleBrown
        btnSave.FlatAppearance.BorderColor = Color.White
        btnSave.FlatAppearance.BorderSize = 2
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Lucida Sans Unicode", 8.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = Color.WhiteSmoke
        btnSave.Location = New Point(190, 470)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(145, 42)
        btnSave.TabIndex = 9
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' cboOrderStatus
        ' 
        cboOrderStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cboOrderStatus.Font = New Font("Lucida Sans Unicode", 8.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cboOrderStatus.FormattingEnabled = True
        cboOrderStatus.Items.AddRange(New Object() {"Pending", "Confirmed", "Completed", "Cancelled"})
        cboOrderStatus.Location = New Point(190, 370)
        cboOrderStatus.Name = "cboOrderStatus"
        cboOrderStatus.Size = New Size(320, 28)
        cboOrderStatus.TabIndex = 8
        ' 
        ' dtpOrderDate
        ' 
        dtpOrderDate.Font = New Font("Lucida Sans Unicode", 8.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpOrderDate.Format = DateTimePickerFormat.Short
        dtpOrderDate.Location = New Point(190, 310)
        dtpOrderDate.Name = "dtpOrderDate"
        dtpOrderDate.Size = New Size(320, 27)
        dtpOrderDate.TabIndex = 7
        ' 
        ' txtTotalAmount
        ' 
        txtTotalAmount.Font = New Font("Lucida Sans Unicode", 8.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtTotalAmount.ForeColor = Color.Sienna
        txtTotalAmount.Location = New Point(190, 250)
        txtTotalAmount.Name = "txtTotalAmount"
        txtTotalAmount.Size = New Size(320, 27)
        txtTotalAmount.TabIndex = 6
        txtTotalAmount.Text = "0.00"
        ' 
        ' txtCustomerID
        ' 
        txtCustomerID.Font = New Font("Lucida Sans Unicode", 8.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCustomerID.ForeColor = Color.Sienna
        txtCustomerID.Location = New Point(190, 190)
        txtCustomerID.Name = "txtCustomerID"
        txtCustomerID.Size = New Size(320, 27)
        txtCustomerID.TabIndex = 5
        ' 
        ' lblOrderStatus
        ' 
        lblOrderStatus.AutoSize = True
        lblOrderStatus.Font = New Font("Lucida Sans Unicode", 8.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblOrderStatus.ForeColor = Color.SaddleBrown
        lblOrderStatus.Location = New Point(37, 375)
        lblOrderStatus.Name = "lblOrderStatus"
        lblOrderStatus.Size = New Size(91, 18)
        lblOrderStatus.TabIndex = 4
        lblOrderStatus.Text = "Order Status"
        ' 
        ' lblOrderDate
        ' 
        lblOrderDate.AutoSize = True
        lblOrderDate.Font = New Font("Lucida Sans Unicode", 8.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblOrderDate.ForeColor = Color.SaddleBrown
        lblOrderDate.Location = New Point(37, 315)
        lblOrderDate.Name = "lblOrderDate"
        lblOrderDate.Size = New Size(79, 18)
        lblOrderDate.TabIndex = 3
        lblOrderDate.Text = "Order Date"
        ' 
        ' lblTotalAmount
        ' 
        lblTotalAmount.AutoSize = True
        lblTotalAmount.Font = New Font("Lucida Sans Unicode", 8.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotalAmount.ForeColor = Color.SaddleBrown
        lblTotalAmount.Location = New Point(37, 255)
        lblTotalAmount.Name = "lblTotalAmount"
        lblTotalAmount.Size = New Size(95, 18)
        lblTotalAmount.TabIndex = 2
        lblTotalAmount.Text = "Total Amount"
        ' 
        ' lblCustomerID
        ' 
        lblCustomerID.AutoSize = True
        lblCustomerID.Font = New Font("Lucida Sans Unicode", 8.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCustomerID.ForeColor = Color.SaddleBrown
        lblCustomerID.Location = New Point(37, 195)
        lblCustomerID.Name = "lblCustomerID"
        lblCustomerID.Size = New Size(91, 18)
        lblCustomerID.TabIndex = 1
        lblCustomerID.Text = "Customer ID"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Lucida Sans Unicode", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.SaddleBrown
        lblTitle.Location = New Point(37, 30)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(247, 34)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Add New Order"
        ' 
        ' frmAddOrder
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(240), CByte(240), CByte(240))
        ClientSize = New Size(600, 630)
        Controls.Add(pnlAddOrder)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmAddOrder"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add Order"
        pnlAddOrder.ResumeLayout(False)
        pnlAddOrder.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlAddOrder As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblCustomerID As System.Windows.Forms.Label
    Friend WithEvents lblTotalAmount As System.Windows.Forms.Label
    Friend WithEvents lblOrderDate As System.Windows.Forms.Label
    Friend WithEvents lblOrderStatus As System.Windows.Forms.Label
    Friend WithEvents txtCustomerID As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalAmount As System.Windows.Forms.TextBox
    Friend WithEvents dtpOrderDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboOrderStatus As System.Windows.Forms.ComboBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button

End Class