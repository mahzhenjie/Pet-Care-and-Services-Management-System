<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEditCustomer
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

        pnlEditCustomer = New Panel()
        btnCancel = New Button()
        btnSave = New Button()
        txtAddress = New TextBox()
        txtPhoneNumber = New TextBox()
        txtEmail = New TextBox()
        txtUsername = New TextBox()
        txtFullName = New TextBox()
        txtCustomerID = New TextBox()
        lblAddress = New Label()
        lblPhoneNumber = New Label()
        lblEmail = New Label()
        lblUsername = New Label()
        lblFullName = New Label()
        lblCustomerID = New Label()
        lblTitle = New Label()

        pnlEditCustomer.SuspendLayout()
        SuspendLayout()

        ' 
        ' pnlEditCustomer
        ' 
        pnlEditCustomer.BackColor = Color.FromArgb(CByte(232), CByte(216), CByte(194))
        pnlEditCustomer.Controls.Add(btnCancel)
        pnlEditCustomer.Controls.Add(btnSave)
        pnlEditCustomer.Controls.Add(txtAddress)
        pnlEditCustomer.Controls.Add(txtPhoneNumber)
        pnlEditCustomer.Controls.Add(txtEmail)
        pnlEditCustomer.Controls.Add(txtUsername)
        pnlEditCustomer.Controls.Add(txtFullName)
        pnlEditCustomer.Controls.Add(txtCustomerID)
        pnlEditCustomer.Controls.Add(lblAddress)
        pnlEditCustomer.Controls.Add(lblPhoneNumber)
        pnlEditCustomer.Controls.Add(lblEmail)
        pnlEditCustomer.Controls.Add(lblUsername)
        pnlEditCustomer.Controls.Add(lblFullName)
        pnlEditCustomer.Controls.Add(lblCustomerID)
        pnlEditCustomer.Controls.Add(lblTitle)
        pnlEditCustomer.Location = New Point(12, 15)
        pnlEditCustomer.Name = "pnlEditCustomer"
        pnlEditCustomer.Size = New Size(560, 650)
        pnlEditCustomer.TabIndex = 0

        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Lucida Sans Unicode", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.SaddleBrown
        lblTitle.Location = New Point(30, 25)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(280, 37)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Edit Customer"

        ' 
        ' lblCustomerID
        ' 
        lblCustomerID.AutoSize = True
        lblCustomerID.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCustomerID.ForeColor = Color.SaddleBrown
        lblCustomerID.Location = New Point(35, 90)
        lblCustomerID.Name = "lblCustomerID"
        lblCustomerID.Size = New Size(101, 19)
        lblCustomerID.TabIndex = 1
        lblCustomerID.Text = "Customer ID"

        ' 
        ' txtCustomerID
        ' 
        txtCustomerID.BackColor = Color.Gainsboro
        txtCustomerID.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCustomerID.Location = New Point(190, 86)
        txtCustomerID.Name = "txtCustomerID"
        txtCustomerID.ReadOnly = True
        txtCustomerID.Size = New Size(320, 27)
        txtCustomerID.TabIndex = 2

        ' 
        ' lblFullName
        ' 
        lblFullName.AutoSize = True
        lblFullName.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblFullName.ForeColor = Color.SaddleBrown
        lblFullName.Location = New Point(35, 145)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(79, 19)
        lblFullName.TabIndex = 3
        lblFullName.Text = "Full Name"

        ' 
        ' txtFullName
        ' 
        txtFullName.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtFullName.Location = New Point(190, 141)
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(320, 27)
        txtFullName.TabIndex = 4

        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUsername.ForeColor = Color.SaddleBrown
        lblUsername.Location = New Point(35, 200)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(81, 19)
        lblUsername.TabIndex = 5
        lblUsername.Text = "Username"

        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(190, 196)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(320, 27)
        txtUsername.TabIndex = 6

        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEmail.ForeColor = Color.SaddleBrown
        lblEmail.Location = New Point(35, 255)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(49, 19)
        lblEmail.TabIndex = 7
        lblEmail.Text = "Email"

        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEmail.Location = New Point(190, 251)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(320, 27)
        txtEmail.TabIndex = 8

        ' 
        ' lblPhoneNumber
        ' 
        lblPhoneNumber.AutoSize = True
        lblPhoneNumber.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPhoneNumber.ForeColor = Color.SaddleBrown
        lblPhoneNumber.Location = New Point(35, 310)
        lblPhoneNumber.Name = "lblPhoneNumber"
        lblPhoneNumber.Size = New Size(121, 19)
        lblPhoneNumber.TabIndex = 9
        lblPhoneNumber.Text = "Phone Number"

        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPhoneNumber.Location = New Point(190, 306)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(320, 27)
        txtPhoneNumber.TabIndex = 10

        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAddress.ForeColor = Color.SaddleBrown
        lblAddress.Location = New Point(35, 365)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(69, 19)
        lblAddress.TabIndex = 11
        lblAddress.Text = "Address"

        ' 
        ' txtAddress
        ' 
        txtAddress.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAddress.Location = New Point(190, 361)
        txtAddress.Multiline = True
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(320, 80)
        txtAddress.TabIndex = 12

        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.SaddleBrown
        btnSave.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = Color.WhiteSmoke
        btnSave.Location = New Point(190, 490)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(150, 45)
        btnSave.TabIndex = 13
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False

        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(244), CByte(220), CByte(204))
        btnCancel.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.SaddleBrown
        btnCancel.Location = New Point(360, 490)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(150, 45)
        btnCancel.TabIndex = 14
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False

        ' 
        ' frmEditCustomer
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(584, 680)
        Controls.Add(pnlEditCustomer)
        Name = "frmEditCustomer"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Edit Customer"

        pnlEditCustomer.ResumeLayout(False)
        pnlEditCustomer.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlEditCustomer As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblCustomerID As System.Windows.Forms.Label
    Friend WithEvents lblFullName As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblPhoneNumber As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label

    Friend WithEvents txtCustomerID As System.Windows.Forms.TextBox
    Friend WithEvents txtFullName As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtPhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox

    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button

End Class
