<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCustomerPayment
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pnlMain = New Panel()
        pnlContent = New Panel()
        btnCancel = New Button()
        btnPayNow = New Button()
        txtPaymentStatus = New TextBox()
        lblPaymentStatus = New Label()
        txtPaymentType = New TextBox()
        lblPaymentType = New Label()
        cboPaymentMethod = New ComboBox()
        lblPaymentMethod = New Label()
        lblAmount = New Label()
        lblAmountTitle = New Label()
        lblCustomerName = New Label()
        lblCustomerNameTitle = New Label()
        pnlHeader = New Panel()
        lblSubtitle = New Label()
        lblTitle = New Label()
        pnlMain.SuspendLayout()
        pnlContent.SuspendLayout()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlMain
        ' 
        pnlMain.BackColor = Color.FromArgb(CByte(247), CByte(232), CByte(213))
        pnlMain.Controls.Add(pnlContent)
        pnlMain.Controls.Add(pnlHeader)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(0, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Padding = New Padding(20)
        pnlMain.Size = New Size(600, 620)
        pnlMain.TabIndex = 0
        ' 
        ' pnlContent
        ' 
        pnlContent.Controls.Add(btnCancel)
        pnlContent.Controls.Add(btnPayNow)
        pnlContent.Controls.Add(txtPaymentStatus)
        pnlContent.Controls.Add(lblPaymentStatus)
        pnlContent.Controls.Add(txtPaymentType)
        pnlContent.Controls.Add(lblPaymentType)
        pnlContent.Controls.Add(cboPaymentMethod)
        pnlContent.Controls.Add(lblPaymentMethod)
        pnlContent.Controls.Add(lblAmount)
        pnlContent.Controls.Add(lblAmountTitle)
        pnlContent.Controls.Add(lblCustomerName)
        pnlContent.Controls.Add(lblCustomerNameTitle)
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(20, 110)
        pnlContent.Name = "pnlContent"
        pnlContent.Size = New Size(560, 490)
        pnlContent.TabIndex = 1
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(112), CByte(78), CByte(51))
        btnCancel.DialogResult = DialogResult.Cancel
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(128, 375)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(270, 40)
        btnCancel.TabIndex = 11
        btnCancel.Text = "CANCEL"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnPayNow
        ' 
        btnPayNow.BackColor = Color.FromArgb(CByte(74), CByte(44), CByte(26))
        btnPayNow.FlatStyle = FlatStyle.Flat
        btnPayNow.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnPayNow.ForeColor = Color.White
        btnPayNow.Location = New Point(128, 324)
        btnPayNow.Name = "btnPayNow"
        btnPayNow.Size = New Size(270, 45)
        btnPayNow.TabIndex = 10
        btnPayNow.Text = "PAY NOW"
        btnPayNow.UseVisualStyleBackColor = False
        ' 
        ' txtPaymentStatus
        ' 
        txtPaymentStatus.Font = New Font("Segoe UI", 10F)
        txtPaymentStatus.Location = New Point(220, 252)
        txtPaymentStatus.Name = "txtPaymentStatus"
        txtPaymentStatus.ReadOnly = True
        txtPaymentStatus.Size = New Size(270, 30)
        txtPaymentStatus.TabIndex = 9
        txtPaymentStatus.Text = "Paid"
        ' 
        ' lblPaymentStatus
        ' 
        lblPaymentStatus.AutoSize = True
        lblPaymentStatus.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblPaymentStatus.ForeColor = Color.FromArgb(CByte(74), CByte(44), CByte(26))
        lblPaymentStatus.Location = New Point(50, 255)
        lblPaymentStatus.Name = "lblPaymentStatus"
        lblPaymentStatus.Size = New Size(140, 23)
        lblPaymentStatus.TabIndex = 8
        lblPaymentStatus.Text = "Payment Status:"
        ' 
        ' txtPaymentType
        ' 
        txtPaymentType.Font = New Font("Segoe UI", 10F)
        txtPaymentType.Location = New Point(220, 197)
        txtPaymentType.Name = "txtPaymentType"
        txtPaymentType.ReadOnly = True
        txtPaymentType.Size = New Size(270, 30)
        txtPaymentType.TabIndex = 7
        txtPaymentType.Text = "Product"
        ' 
        ' lblPaymentType
        ' 
        lblPaymentType.AutoSize = True
        lblPaymentType.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblPaymentType.ForeColor = Color.FromArgb(CByte(74), CByte(44), CByte(26))
        lblPaymentType.Location = New Point(50, 200)
        lblPaymentType.Name = "lblPaymentType"
        lblPaymentType.Size = New Size(128, 23)
        lblPaymentType.TabIndex = 6
        lblPaymentType.Text = "Payment Type:"
        ' 
        ' cboPaymentMethod
        ' 
        cboPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList
        cboPaymentMethod.Font = New Font("Segoe UI", 10F)
        cboPaymentMethod.FormattingEnabled = True
        cboPaymentMethod.Items.AddRange(New Object() {"Cash", "Credit Card", "Debit Card", "Online Banking", "E-Wallet"})
        cboPaymentMethod.Location = New Point(220, 137)
        cboPaymentMethod.Name = "cboPaymentMethod"
        cboPaymentMethod.Size = New Size(270, 31)
        cboPaymentMethod.TabIndex = 5
        ' 
        ' lblPaymentMethod
        ' 
        lblPaymentMethod.AutoSize = True
        lblPaymentMethod.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblPaymentMethod.ForeColor = Color.FromArgb(CByte(74), CByte(44), CByte(26))
        lblPaymentMethod.Location = New Point(50, 145)
        lblPaymentMethod.Name = "lblPaymentMethod"
        lblPaymentMethod.Size = New Size(153, 23)
        lblPaymentMethod.TabIndex = 4
        lblPaymentMethod.Text = "Payment Method:"
        ' 
        ' lblAmount
        ' 
        lblAmount.AutoSize = True
        lblAmount.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        lblAmount.ForeColor = Color.FromArgb(CByte(112), CByte(78), CByte(51))
        lblAmount.Location = New Point(180, 85)
        lblAmount.Name = "lblAmount"
        lblAmount.Size = New Size(111, 35)
        lblAmount.TabIndex = 3
        lblAmount.Text = "RM 0.00"
        ' 
        ' lblAmountTitle
        ' 
        lblAmountTitle.AutoSize = True
        lblAmountTitle.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblAmountTitle.ForeColor = Color.FromArgb(CByte(74), CByte(44), CByte(26))
        lblAmountTitle.Location = New Point(50, 90)
        lblAmountTitle.Name = "lblAmountTitle"
        lblAmountTitle.Size = New Size(124, 23)
        lblAmountTitle.TabIndex = 2
        lblAmountTitle.Text = "Total Amount:"
        ' 
        ' lblCustomerName
        ' 
        lblCustomerName.AutoSize = True
        lblCustomerName.Font = New Font("Segoe UI", 10F)
        lblCustomerName.Location = New Point(180, 45)
        lblCustomerName.Name = "lblCustomerName"
        lblCustomerName.Size = New Size(84, 23)
        lblCustomerName.TabIndex = 1
        lblCustomerName.Text = "Customer"
        ' 
        ' lblCustomerNameTitle
        ' 
        lblCustomerNameTitle.AutoSize = True
        lblCustomerNameTitle.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblCustomerNameTitle.ForeColor = Color.FromArgb(CByte(74), CByte(44), CByte(26))
        lblCustomerNameTitle.Location = New Point(50, 45)
        lblCustomerNameTitle.Name = "lblCustomerNameTitle"
        lblCustomerNameTitle.Size = New Size(93, 23)
        lblCustomerNameTitle.TabIndex = 0
        lblCustomerNameTitle.Text = "Customer:"
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(74), CByte(44), CByte(26))
        pnlHeader.Controls.Add(lblSubtitle)
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(20, 20)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(560, 90)
        pnlHeader.TabIndex = 0
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.Font = New Font("Segoe UI", 10F)
        lblSubtitle.ForeColor = Color.FromArgb(CByte(247), CByte(232), CByte(213))
        lblSubtitle.Location = New Point(29, 58)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(262, 23)
        lblSubtitle.TabIndex = 1
        lblSubtitle.Text = "Complete your product purchase"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 22F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(25, 15)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(174, 50)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Payment"
        ' 
        ' frmCustomerPayment
        ' 
        AcceptButton = btnPayNow
        AutoScaleMode = AutoScaleMode.None
        CancelButton = btnCancel
        ClientSize = New Size(600, 620)
        Controls.Add(pnlMain)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmCustomerPayment"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Payment"
        pnlMain.ResumeLayout(False)
        pnlContent.ResumeLayout(False)
        pnlContent.PerformLayout()
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents pnlContent As Panel
    Friend WithEvents lblCustomerNameTitle As Label
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents lblAmountTitle As Label
    Friend WithEvents lblAmount As Label
    Friend WithEvents lblPaymentMethod As Label
    Friend WithEvents cboPaymentMethod As ComboBox
    Friend WithEvents lblPaymentType As Label
    Friend WithEvents txtPaymentType As TextBox
    Friend WithEvents lblPaymentStatus As Label
    Friend WithEvents txtPaymentStatus As TextBox
    Friend WithEvents btnPayNow As Button
    Friend WithEvents btnCancel As Button
End Class