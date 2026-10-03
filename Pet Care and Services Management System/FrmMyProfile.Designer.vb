<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMyProfile
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
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
        pnlHeader.BackColor = Color.FromArgb(CByte(55), CByte(32), CByte(20))
        pnlHeader.Controls.Add(PictureBox2)
        pnlHeader.Controls.Add(PictureBox1)
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(646, 70)
        pnlHeader.TabIndex = 0
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(545, 9)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(91, 53)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-2, 9)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(78, 53)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Georgia", 22F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.FromArgb(CByte(255), CByte(243), CByte(222))
        lblTitle.Location = New Point(70, 11)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(324, 51)
        lblTitle.TabIndex = 0
        lblTitle.Text = "MY PROFILE"
        ' 
        ' lblCustomerID
        ' 
        lblCustomerID.AutoSize = True
        lblCustomerID.Font = New Font("Georgia", 12F, FontStyle.Bold)
        lblCustomerID.ForeColor = Color.FromArgb(CByte(55), CByte(32), CByte(20))
        lblCustomerID.Location = New Point(43, 108)
        lblCustomerID.Name = "lblCustomerID"
        lblCustomerID.Size = New Size(192, 29)
        lblCustomerID.TabIndex = 1
        lblCustomerID.Text = "Customer ID : "
        ' 
        ' lblFullName
        ' 
        lblFullName.AutoSize = True
        lblFullName.Font = New Font("Georgia", 12F, FontStyle.Bold)
        lblFullName.ForeColor = Color.FromArgb(CByte(55), CByte(32), CByte(20))
        lblFullName.Location = New Point(43, 167)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(161, 29)
        lblFullName.TabIndex = 2
        lblFullName.Text = "Full Name : "
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Georgia", 12F, FontStyle.Bold)
        lblUsername.ForeColor = Color.FromArgb(CByte(55), CByte(32), CByte(20))
        lblUsername.Location = New Point(43, 228)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(161, 29)
        lblUsername.TabIndex = 3
        lblUsername.Text = "Username : "
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Georgia", 12F, FontStyle.Bold)
        lblEmail.ForeColor = Color.FromArgb(CByte(55), CByte(32), CByte(20))
        lblEmail.Location = New Point(99, 349)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(105, 29)
        lblEmail.TabIndex = 4
        lblEmail.Text = "Email : "
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Font = New Font("Georgia", 12F, FontStyle.Bold)
        lblPhone.ForeColor = Color.FromArgb(CByte(55), CByte(32), CByte(20))
        lblPhone.Location = New Point(91, 410)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(113, 29)
        lblPhone.TabIndex = 5
        lblPhone.Text = "Phone : "
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Font = New Font("Georgia", 12F, FontStyle.Bold)
        lblAddress.ForeColor = Color.FromArgb(CByte(55), CByte(32), CByte(20))
        lblAddress.Location = New Point(70, 471)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(134, 29)
        lblAddress.TabIndex = 6
        lblAddress.Text = "Address : "
        ' 
        ' txtFullName
        ' 
        txtFullName.Location = New Point(254, 167)
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(250, 35)
        txtFullName.TabIndex = 7
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(254, 224)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(250, 35)
        txtUsername.TabIndex = 8
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(254, 345)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(250, 35)
        txtEmail.TabIndex = 9
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(254, 406)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(250, 35)
        txtPhone.TabIndex = 10
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(254, 467)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(250, 35)
        txtAddress.TabIndex = 11
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(92, 553)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(145, 47)
        btnEdit.TabIndex = 12
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(275, 553)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(145, 47)
        btnSave.TabIndex = 13
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(462, 553)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(145, 47)
        btnCancel.TabIndex = 14
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' txtCustomerID
        ' 
        txtCustomerID.Location = New Point(254, 108)
        txtCustomerID.Name = "txtCustomerID"
        txtCustomerID.ReadOnly = True
        txtCustomerID.Size = New Size(250, 35)
        txtCustomerID.TabIndex = 15
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Georgia", 12F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(55), CByte(32), CByte(20))
        Label1.Location = New Point(43, 289)
        Label1.Name = "Label1"
        Label1.Size = New Size(153, 29)
        Label1.TabIndex = 16
        Label1.Text = "Password : "
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(254, 285)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(250, 35)
        txtPassword.TabIndex = 17
        ' 
        ' FrmMyProfile
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(243), CByte(222))
        ClientSize = New Size(646, 658)
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

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblCustomerID As Label
    Friend WithEvents lblFullName As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPassword As TextBox
End Class
