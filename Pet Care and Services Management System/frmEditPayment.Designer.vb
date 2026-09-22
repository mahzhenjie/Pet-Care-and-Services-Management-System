<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEditPayment
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
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pnlEditPayment = New Panel()
        btnCancel = New Button()
        btnSave = New Button()
        cboPaymentStatus = New ComboBox()
        cboPaymentType = New ComboBox()
        cboPaymentMethod = New ComboBox()
        txtAmount = New TextBox()
        dtpPaymentDate = New DateTimePicker()
        txtCustomerID = New TextBox()
        txtPaymentID = New TextBox()
        lblPaymentStatus = New Label()
        lblPaymentType = New Label()
        lblPaymentMethod = New Label()
        lblAmount = New Label()
        lblPaymentDate = New Label()
        lblCustomerID = New Label()
        lblPaymentID = New Label()
        lblTitle = New Label()
        pnlEditPayment.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlEditPayment
        ' 
        pnlEditPayment.BackColor = Color.FromArgb(CByte(235), CByte(218), CByte(191))
        pnlEditPayment.Controls.Add(btnCancel)
        pnlEditPayment.Controls.Add(btnSave)
        pnlEditPayment.Controls.Add(cboPaymentStatus)
        pnlEditPayment.Controls.Add(cboPaymentType)
        pnlEditPayment.Controls.Add(cboPaymentMethod)
        pnlEditPayment.Controls.Add(txtAmount)
        pnlEditPayment.Controls.Add(dtpPaymentDate)
        pnlEditPayment.Controls.Add(txtCustomerID)
        pnlEditPayment.Controls.Add(txtPaymentID)
        pnlEditPayment.Controls.Add(lblPaymentStatus)
        pnlEditPayment.Controls.Add(lblPaymentType)
        pnlEditPayment.Controls.Add(lblPaymentMethod)
        pnlEditPayment.Controls.Add(lblAmount)
        pnlEditPayment.Controls.Add(lblPaymentDate)
        pnlEditPayment.Controls.Add(lblCustomerID)
        pnlEditPayment.Controls.Add(lblPaymentID)
        pnlEditPayment.Controls.Add(lblTitle)
        pnlEditPayment.Location = New Point(12, 15)
        pnlEditPayment.Name = "pnlEditPayment"
        pnlEditPayment.Size = New Size(700, 550)
        pnlEditPayment.TabIndex = 0
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(242), CByte(220), CByte(220))
        btnCancel.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.SaddleBrown
        btnCancel.Location = New Point(370, 460)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(130, 40)
        btnCancel.TabIndex = 16
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.SaddleBrown
        btnSave.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = Color.WhiteSmoke
        btnSave.Location = New Point(220, 460)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(130, 40)
        btnSave.TabIndex = 15
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' cboPaymentStatus
        ' 
        cboPaymentStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cboPaymentStatus.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cboPaymentStatus.FormattingEnabled = True
        cboPaymentStatus.Location = New Point(300, 385)
        cboPaymentStatus.Name = "cboPaymentStatus"
        cboPaymentStatus.Size = New Size(250, 28)
        cboPaymentStatus.TabIndex = 14
        ' 
        ' cboPaymentType
        ' 
        cboPaymentType.DropDownStyle = ComboBoxStyle.DropDownList
        cboPaymentType.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cboPaymentType.FormattingEnabled = True
        cboPaymentType.Location = New Point(300, 335)
        cboPaymentType.Name = "cboPaymentType"
        cboPaymentType.Size = New Size(250, 28)
        cboPaymentType.TabIndex = 13
        ' 
        ' cboPaymentMethod
        ' 
        cboPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList
        cboPaymentMethod.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cboPaymentMethod.FormattingEnabled = True
        cboPaymentMethod.Location = New Point(300, 285)
        cboPaymentMethod.Name = "cboPaymentMethod"
        cboPaymentMethod.Size = New Size(250, 28)
        cboPaymentMethod.TabIndex = 12
        ' 
        ' txtAmount
        ' 
        txtAmount.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAmount.Location = New Point(300, 235)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(250, 26)
        txtAmount.TabIndex = 11
        ' 
        ' dtpPaymentDate
        ' 
        dtpPaymentDate.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpPaymentDate.Format = DateTimePickerFormat.Short
        dtpPaymentDate.Location = New Point(300, 185)
        dtpPaymentDate.Name = "dtpPaymentDate"
        dtpPaymentDate.Size = New Size(250, 26)
        dtpPaymentDate.TabIndex = 10
        ' 
        ' txtCustomerID
        ' 
        txtCustomerID.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCustomerID.Location = New Point(300, 135)
        txtCustomerID.Name = "txtCustomerID"
        txtCustomerID.Size = New Size(250, 26)
        txtCustomerID.TabIndex = 9
        ' 
        ' txtPaymentID
        ' 
        txtPaymentID.BackColor = Color.LightGray
        txtPaymentID.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPaymentID.Location = New Point(300, 85)
        txtPaymentID.Name = "txtPaymentID"
        txtPaymentID.ReadOnly = True
        txtPaymentID.Size = New Size(250, 26)
        txtPaymentID.TabIndex = 8
        ' 
        ' lblPaymentStatus
        ' 
        lblPaymentStatus.AutoSize = True
        lblPaymentStatus.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPaymentStatus.ForeColor = Color.SaddleBrown
        lblPaymentStatus.Location = New Point(100, 388)
        lblPaymentStatus.Name = "lblPaymentStatus"
        lblPaymentStatus.Size = New Size(132, 20)
        lblPaymentStatus.TabIndex = 7
        lblPaymentStatus.Text = "Payment Status:"
        ' 
        ' lblPaymentType
        ' 
        lblPaymentType.AutoSize = True
        lblPaymentType.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPaymentType.ForeColor = Color.SaddleBrown
        lblPaymentType.Location = New Point(100, 338)
        lblPaymentType.Name = "lblPaymentType"
        lblPaymentType.Size = New Size(116, 20)
        lblPaymentType.TabIndex = 6
        lblPaymentType.Text = "Payment Type:"
        ' 
        ' lblPaymentMethod
        ' 
        lblPaymentMethod.AutoSize = True
        lblPaymentMethod.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPaymentMethod.ForeColor = Color.SaddleBrown
        lblPaymentMethod.Location = New Point(100, 288)
        lblPaymentMethod.Name = "lblPaymentMethod"
        lblPaymentMethod.Size = New Size(143, 20)
        lblPaymentMethod.TabIndex = 5
        lblPaymentMethod.Text = "Payment Method:"
        ' 
        ' lblAmount
        ' 
        lblAmount.AutoSize = True
        lblAmount.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAmount.ForeColor = Color.SaddleBrown
        lblAmount.Location = New Point(100, 238)
        lblAmount.Name = "lblAmount"
        lblAmount.Size = New Size(72, 20)
        lblAmount.TabIndex = 4
        lblAmount.Text = "Amount:"
        ' 
        ' lblPaymentDate
        ' 
        lblPaymentDate.AutoSize = True
        lblPaymentDate.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPaymentDate.ForeColor = Color.SaddleBrown
        lblPaymentDate.Location = New Point(100, 188)
        lblPaymentDate.Name = "lblPaymentDate"
        lblPaymentDate.Size = New Size(121, 20)
        lblPaymentDate.TabIndex = 3
        lblPaymentDate.Text = "Payment Date:"
        ' 
        ' lblCustomerID
        ' 
        lblCustomerID.AutoSize = True
        lblCustomerID.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCustomerID.ForeColor = Color.SaddleBrown
        lblCustomerID.Location = New Point(100, 138)
        lblCustomerID.Name = "lblCustomerID"
        lblCustomerID.Size = New Size(108, 20)
        lblCustomerID.TabIndex = 2
        lblCustomerID.Text = "Customer ID:"
        ' 
        ' lblPaymentID
        ' 
        lblPaymentID.AutoSize = True
        lblPaymentID.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPaymentID.ForeColor = Color.SaddleBrown
        lblPaymentID.Location = New Point(100, 88)
        lblPaymentID.Name = "lblPaymentID"
        lblPaymentID.Size = New Size(104, 20)
        lblPaymentID.TabIndex = 1
        lblPaymentID.Text = "Payment ID:"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Lucida Sans Unicode", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.SaddleBrown
        lblTitle.Location = New Point(100, 30)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(238, 34)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Edit Payment"
        ' 
        ' frmEditPayment
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(724, 580)
        Controls.Add(pnlEditPayment)
        Name = "frmEditPayment"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Edit Payment"
        pnlEditPayment.ResumeLayout(False)
        pnlEditPayment.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlEditPayment As Panel
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents cboPaymentStatus As ComboBox
    Friend WithEvents cboPaymentType As ComboBox
    Friend WithEvents cboPaymentMethod As ComboBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents dtpPaymentDate As DateTimePicker
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents txtPaymentID As TextBox
    Friend WithEvents lblPaymentStatus As Label
    Friend WithEvents lblPaymentType As Label
    Friend WithEvents lblPaymentMethod As Label
    Friend WithEvents lblAmount As Label
    Friend WithEvents lblPaymentDate As Label
    Friend WithEvents lblCustomerID As Label
    Friend WithEvents lblPaymentID As Label
    Friend WithEvents lblTitle As Label

End Class