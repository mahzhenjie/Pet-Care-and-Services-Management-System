<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMyProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMyProfile))
        pnlHeader = New Panel()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        lblTitle = New Label()
        lblCustomerID = New Label()
        lblFullName = New Label()
        lblUsername = New Label()
        lblEmail = New Label()
        lblPhone = New Label()
        lblAddress = New Label()
        txtFullName = New TextBox()
        txtUsername = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtAddress = New TextBox()
        btnEdit = New Button()
        btnSave = New Button()
        btnCancel = New Button()
        txtCustomerID = New TextBox()
        Label1 = New Label()
        txtPassword = New TextBox()
        pnlHeader.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(96, 52, 16)
        pnlHeader.Controls.Add(PictureBox2)
        pnlHeader.Controls.Add(PictureBox1)
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(700, 70)
        pnlHeader.TabIndex = 0
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(610, 9)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(70, 53)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(18, 9)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(70, 53)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Georgia", 20.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(255, 243, 222)
        lblTitle.Location = New Point(95, 14)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(290, 38)
        lblTitle.TabIndex = 0
        lblTitle.Text = "MY PROFILE"
        ' 
        ' lblCustomerID
        ' 
        lblCustomerID.AutoSize = True
        lblCustomerID.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblCustomerID.ForeColor = Color.FromArgb(61, 40, 27)
        lblCustomerID.Location = New Point(60, 105)
        lblCustomerID.Name = "lblCustomerID"
        lblCustomerID.Size = New Size(112, 23)
        lblCustomerID.TabIndex = 1
        lblCustomerID.Text = "Customer ID:"
        ' 
        ' lblFullName
        ' 
        lblFullName.AutoSize = True
        lblFullName.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblFullName.ForeColor = Color.FromArgb(61, 40, 27)
        lblFullName.Location = New Point(60, 157)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(89, 23)
        lblFullName.TabIndex = 2
        lblFullName.Text = "Full Name:"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblUsername.ForeColor = Color.FromArgb(61, 40, 27)
        lblUsername.Location = New Point(60, 209)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(91, 23)
        lblUsername.TabIndex = 3
        lblUsername.Text = "Username:"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblEmail.ForeColor = Color.FromArgb(61, 40, 27)
        lblEmail.Location = New Point(60, 313)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(54, 23)
        lblEmail.TabIndex = 4
        lblEmail.Text = "Email:"
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblPhone.ForeColor = Color.FromArgb(61, 40, 27)
        lblPhone.Location = New Point(60, 365)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(60, 23)
        lblPhone.TabIndex = 5
        lblPhone.Text = "Phone:"
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblAddress.ForeColor = Color.FromArgb(61, 40, 27)
        lblAddress.Location = New Point(60, 417)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(76, 23)
        lblAddress.TabIndex = 6
        lblAddress.Text = "Address:"
        ' 
        ' txtFullName
        ' 
        txtFullName.BackColor = Color.White
        txtFullName.BorderStyle = BorderStyle.FixedSingle
        txtFullName.Font = New Font("Segoe UI", 10.0F)
        txtFullName.ForeColor = Color.FromArgb(61, 40, 27)
        txtFullName.Location = New Point(205, 153)
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(360, 30)
        txtFullName.TabIndex = 7
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.White
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Font = New Font("Segoe UI", 10.0F)
        txtUsername.ForeColor = Color.FromArgb(61, 40, 27)
        txtUsername.Location = New Point(205, 205)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(360, 30)
        txtUsername.TabIndex = 8
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.White
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.Font = New Font("Segoe UI", 10.0F)
        txtEmail.ForeColor = Color.FromArgb(61, 40, 27)
        txtEmail.Location = New Point(205, 309)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(360, 30)
        txtEmail.TabIndex = 9
        ' 
        ' txtPhone
        ' 
        txtPhone.BackColor = Color.White
        txtPhone.BorderStyle = BorderStyle.FixedSingle
        txtPhone.Font = New Font("Segoe UI", 10.0F)
        txtPhone.ForeColor = Color.FromArgb(61, 40, 27)
        txtPhone.Location = New Point(205, 361)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(360, 30)
        txtPhone.TabIndex = 10
        ' 
        ' txtAddress
        ' 
        txtAddress.BackColor = Color.White
        txtAddress.BorderStyle = BorderStyle.FixedSingle
        txtAddress.Font = New Font("Segoe UI", 10.0F)
        txtAddress.ForeColor = Color.FromArgb(61, 40, 27)
        txtAddress.Location = New Point(205, 413)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(360, 30)
        txtAddress.TabIndex = 11
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.FromArgb(96, 52, 16)
        btnEdit.FlatAppearance.BorderSize = 0
        btnEdit.FlatStyle = FlatStyle.Flat
        btnEdit.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnEdit.ForeColor = Color.WhiteSmoke
        btnEdit.Location = New Point(60, 490)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(175, 45)
        btnEdit.TabIndex = 12
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.Sienna
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnSave.ForeColor = Color.WhiteSmoke
        btnSave.Location = New Point(260, 490)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(175, 45)
        btnSave.TabIndex = 13
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(244, 220, 204)
        btnCancel.FlatAppearance.BorderColor = Color.Sienna
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnCancel.ForeColor = Color.SaddleBrown
        btnCancel.Location = New Point(460, 490)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(175, 45)
        btnCancel.TabIndex = 14
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' txtCustomerID
        ' 
        txtCustomerID.BackColor = Color.FromArgb(238, 228, 214)
        txtCustomerID.BorderStyle = BorderStyle.FixedSingle
        txtCustomerID.Font = New Font("Segoe UI", 10.0F)
        txtCustomerID.ForeColor = Color.FromArgb(107, 98, 91)
        txtCustomerID.Location = New Point(205, 101)
        txtCustomerID.Name = "txtCustomerID"
        txtCustomerID.ReadOnly = True
        txtCustomerID.Size = New Size(360, 30)
        txtCustomerID.TabIndex = 15
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(61, 40, 27)
        Label1.Location = New Point(60, 261)
        Label1.Name = "Label1"
        Label1.Size = New Size(88, 23)
        Label1.TabIndex = 16
        Label1.Text = "Password:"
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.White
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Font = New Font("Segoe UI", 10.0F)
        txtPassword.ForeColor = Color.FromArgb(61, 40, 27)
        txtPassword.Location = New Point(205, 257)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(360, 30)
        txtPassword.TabIndex = 17
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' FrmMyProfile
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(245, 230, 209)
        ClientSize = New Size(700, 575)
        Controls.Add(txtPassword)
        Controls.Add(Label1)
        Controls.Add(txtCustomerID)
        Controls.Add(btnCancel)
        Controls.Add(btnSave)
        Controls.Add(btnEdit)
        Controls.Add(txtAddress)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtUsername)
        Controls.Add(txtFullName)
        Controls.Add(lblAddress)
        Controls.Add(lblPhone)
        Controls.Add(lblEmail)
        Controls.Add(lblUsername)
        Controls.Add(lblFullName)
        Controls.Add(lblCustomerID)
        Controls.Add(pnlHeader)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "FrmMyProfile"
        StartPosition = FormStartPosition.CenterScreen
        Text = "My Profile"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblCustomerID As System.Windows.Forms.Label
    Friend WithEvents lblFullName As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents txtFullName As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtCustomerID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox

End Class