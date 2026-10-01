<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCustomerMembership
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents pnlContent As Panel
    Friend WithEvents lblMembershipTitle As Label
    Friend WithEvents lblMembershipType As Label
    Friend WithEvents cboMembershipType As ComboBox
    Friend WithEvents lblStartDate As Label
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents lblEndDate As Label
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents lblStatus As Label
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblCustomerNameTitle As Label
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents lblCustomerIDTitle As Label
    Friend WithEvents lblCustomerID As Label

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlMain = New Panel()
        Me.pnlHeader = New Panel()
        Me.lblSubtitle = New Label()
        Me.lblTitle = New Label()
        Me.pnlContent = New Panel()
        Me.lblCustomerID = New Label()
        Me.lblCustomerIDTitle = New Label()
        Me.lblCustomerName = New Label()
        Me.lblCustomerNameTitle = New Label()
        Me.txtStatus = New TextBox()
        Me.lblStatus = New Label()
        Me.dtpEndDate = New DateTimePicker()
        Me.lblEndDate = New Label()
        Me.dtpStartDate = New DateTimePicker()
        Me.lblStartDate = New Label()
        Me.cboMembershipType = New ComboBox()
        Me.lblMembershipType = New Label()
        Me.lblMembershipTitle = New Label()
        Me.btnCancel = New Button()
        Me.btnRegister = New Button()
        Me.pnlMain.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        Me.SuspendLayout()
        '
        ' pnlMain
        '
        Me.pnlMain.BackColor = Color.FromArgb(247, 232, 213)
        Me.pnlMain.Controls.Add(Me.pnlContent)
        Me.pnlMain.Controls.Add(Me.pnlHeader)
        Me.pnlMain.Dock = DockStyle.Fill
        Me.pnlMain.Location = New Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Padding = New Padding(20)
        Me.pnlMain.Size = New Size(760, 650)
        Me.pnlMain.TabIndex = 0
        '
        ' pnlHeader
        '
        Me.pnlHeader.BackColor = Color.FromArgb(74, 44, 26)
        Me.pnlHeader.Controls.Add(Me.lblSubtitle)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = DockStyle.Top
        Me.pnlHeader.Location = New Point(20, 20)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New Size(720, 100)
        Me.pnlHeader.TabIndex = 0
        '
        ' lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New Font("Georgia", 20.0!, FontStyle.Bold)
        Me.lblTitle.ForeColor = Color.White
        Me.lblTitle.Location = New Point(25, 18)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New Size(284, 32)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Membership"
        '
        ' lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New Font("Segoe UI", 10.0!)
        Me.lblSubtitle.ForeColor = Color.FromArgb(247, 232, 213)
        Me.lblSubtitle.Location = New Point(28, 58)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New Size(333, 19)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Register for a membership plan"
        '
        ' pnlContent
        '
        Me.pnlContent.BackColor = Color.White
        Me.pnlContent.Controls.Add(Me.btnCancel)
        Me.pnlContent.Controls.Add(Me.btnRegister)
        Me.pnlContent.Controls.Add(Me.txtStatus)
        Me.pnlContent.Controls.Add(Me.lblStatus)
        Me.pnlContent.Controls.Add(Me.dtpEndDate)
        Me.pnlContent.Controls.Add(Me.lblEndDate)
        Me.pnlContent.Controls.Add(Me.dtpStartDate)
        Me.pnlContent.Controls.Add(Me.lblStartDate)
        Me.pnlContent.Controls.Add(Me.cboMembershipType)
        Me.pnlContent.Controls.Add(Me.lblMembershipType)
        Me.pnlContent.Controls.Add(Me.lblMembershipTitle)
        Me.pnlContent.Controls.Add(Me.lblCustomerID)
        Me.pnlContent.Controls.Add(Me.lblCustomerIDTitle)
        Me.pnlContent.Controls.Add(Me.lblCustomerName)
        Me.pnlContent.Controls.Add(Me.lblCustomerNameTitle)
        Me.pnlContent.Dock = DockStyle.Fill
        Me.pnlContent.Location = New Point(20, 120)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Padding = New Padding(40)
        Me.pnlContent.Size = New Size(720, 510)
        Me.pnlContent.TabIndex = 1
        '
        ' lblMembershipTitle
        '
        Me.lblMembershipTitle.AutoSize = True
        Me.lblMembershipTitle.Font = New Font("Segoe UI", 15.0!, FontStyle.Bold)
        Me.lblMembershipTitle.ForeColor = Color.FromArgb(74, 44, 26)
        Me.lblMembershipTitle.Location = New Point(40, 30)
        Me.lblMembershipTitle.Name = "lblMembershipTitle"
        Me.lblMembershipTitle.Size = New Size(239, 28)
        Me.lblMembershipTitle.TabIndex = 0
        Me.lblMembershipTitle.Text = "Membership Registration"
        '
        ' lblCustomerNameTitle
        '
        Me.lblCustomerNameTitle.AutoSize = True
        Me.lblCustomerNameTitle.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
        Me.lblCustomerNameTitle.ForeColor = Color.FromArgb(74, 44, 26)
        Me.lblCustomerNameTitle.Location = New Point(40, 85)
        Me.lblCustomerNameTitle.Name = "lblCustomerNameTitle"
        Me.lblCustomerNameTitle.Size = New Size(104, 19)
        Me.lblCustomerNameTitle.TabIndex = 1
        Me.lblCustomerNameTitle.Text = "Customer Name"
        '
        ' lblCustomerName
        '
        Me.lblCustomerName.BackColor = Color.FromArgb(248, 248, 248)
        Me.lblCustomerName.BorderStyle = BorderStyle.FixedSingle
        Me.lblCustomerName.Font = New Font("Segoe UI", 10.0!)
        Me.lblCustomerName.Location = New Point(220, 80)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Padding = New Padding(8, 4, 8, 4)
        Me.lblCustomerName.Size = New Size(400, 30)
        Me.lblCustomerName.TabIndex = 2
        Me.lblCustomerName.Text = "-"
        '
        ' lblCustomerIDTitle
        '
        Me.lblCustomerIDTitle.AutoSize = True
        Me.lblCustomerIDTitle.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
        Me.lblCustomerIDTitle.ForeColor = Color.FromArgb(74, 44, 26)
        Me.lblCustomerIDTitle.Location = New Point(40, 130)
        Me.lblCustomerIDTitle.Name = "lblCustomerIDTitle"
        Me.lblCustomerIDTitle.Size = New Size(84, 19)
        Me.lblCustomerIDTitle.TabIndex = 3
        Me.lblCustomerIDTitle.Text = "Customer ID"
        '
        ' lblCustomerID
        '
        Me.lblCustomerID.BackColor = Color.FromArgb(248, 248, 248)
        Me.lblCustomerID.BorderStyle = BorderStyle.FixedSingle
        Me.lblCustomerID.Font = New Font("Segoe UI", 10.0!)
        Me.lblCustomerID.Location = New Point(220, 125)
        Me.lblCustomerID.Name = "lblCustomerID"
        Me.lblCustomerID.Padding = New Padding(8, 4, 8, 4)
        Me.lblCustomerID.Size = New Size(400, 30)
        Me.lblCustomerID.TabIndex = 4
        Me.lblCustomerID.Text = "-"
        '
        ' lblMembershipType
        '
        Me.lblMembershipType.AutoSize = True
        Me.lblMembershipType.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
        Me.lblMembershipType.ForeColor = Color.FromArgb(74, 44, 26)
        Me.lblMembershipType.Location = New Point(40, 190)
        Me.lblMembershipType.Name = "lblMembershipType"
        Me.lblMembershipType.Size = New Size(128, 19)
        Me.lblMembershipType.TabIndex = 5
        Me.lblMembershipType.Text = "Membership Type"
        '
        ' cboMembershipType
        '
        Me.cboMembershipType.DropDownStyle = ComboBoxStyle.DropDownList
        Me.cboMembershipType.Font = New Font("Segoe UI", 10.0!)
        Me.cboMembershipType.FormattingEnabled = True
        Me.cboMembershipType.Items.AddRange(New Object() {"Basic", "Premium", "VIP"})
        Me.cboMembershipType.Location = New Point(220, 185)
        Me.cboMembershipType.Name = "cboMembershipType"
        Me.cboMembershipType.Size = New Size(400, 27)
        Me.cboMembershipType.TabIndex = 6
        '
        ' lblStartDate
        '
        Me.lblStartDate.AutoSize = True
        Me.lblStartDate.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
        Me.lblStartDate.ForeColor = Color.FromArgb(74, 44, 26)
        Me.lblStartDate.Location = New Point(40, 245)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New Size(72, 19)
        Me.lblStartDate.TabIndex = 7
        Me.lblStartDate.Text = "Start Date"
        '
        ' dtpStartDate
        '
        Me.dtpStartDate.Font = New Font("Segoe UI", 10.0!)
        Me.dtpStartDate.Format = DateTimePickerFormat.Short
        Me.dtpStartDate.Location = New Point(220, 240)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New Size(400, 25)
        Me.dtpStartDate.TabIndex = 8
        '
        ' lblEndDate
        '
        Me.lblEndDate.AutoSize = True
        Me.lblEndDate.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
        Me.lblEndDate.ForeColor = Color.FromArgb(74, 44, 26)
        Me.lblEndDate.Location = New Point(40, 295)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New Size(66, 19)
        Me.lblEndDate.TabIndex = 9
        Me.lblEndDate.Text = "End Date"
        '
        ' dtpEndDate
        '
        Me.dtpEndDate.Font = New Font("Segoe UI", 10.0!)
        Me.dtpEndDate.Format = DateTimePickerFormat.Short
        Me.dtpEndDate.Location = New Point(220, 290)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New Size(400, 25)
        Me.dtpEndDate.TabIndex = 10
        '
        ' lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
        Me.lblStatus.ForeColor = Color.FromArgb(74, 44, 26)
        Me.lblStatus.Location = New Point(40, 345)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New Size(47, 19)
        Me.lblStatus.TabIndex = 11
        Me.lblStatus.Text = "Status"
        '
        ' txtStatus
        '
        Me.txtStatus.BackColor = Color.FromArgb(248, 248, 248)
        Me.txtStatus.Font = New Font("Segoe UI", 10.0!)
        Me.txtStatus.Location = New Point(220, 340)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New Size(400, 25)
        Me.txtStatus.TabIndex = 12
        Me.txtStatus.Text = "Active"
        '
        ' btnRegister
        '
        Me.btnRegister.BackColor = Color.FromArgb(96, 52, 16)
        Me.btnRegister.FlatAppearance.BorderSize = 0
        Me.btnRegister.FlatStyle = FlatStyle.Flat
        Me.btnRegister.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
        Me.btnRegister.ForeColor = Color.White
        Me.btnRegister.Location = New Point(220, 405)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New Size(190, 42)
        Me.btnRegister.TabIndex = 13
        Me.btnRegister.Text = "Register Membership"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        ' btnCancel
        '
        Me.btnCancel.BackColor = Color.FromArgb(130, 130, 130)
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = FlatStyle.Flat
        Me.btnCancel.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
        Me.btnCancel.ForeColor = Color.White
        Me.btnCancel.Location = New Point(430, 405)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New Size(190, 42)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        ' frmCustomerMembership
        '
        Me.AutoScaleDimensions = New SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.BackColor = Color.FromArgb(247, 232, 213)
        Me.ClientSize = New Size(760, 650)
        Me.Controls.Add(Me.pnlMain)
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCustomerMembership"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "Membership Registration"
        Me.pnlMain.ResumeLayout(False)
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlContent.ResumeLayout(False)
        Me.pnlContent.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

End Class