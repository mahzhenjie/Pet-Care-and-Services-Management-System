<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEditMembership
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
        pnlEditMembership = New Panel()
        btnCancel = New Button()
        btnSave = New Button()
        cboStatus = New ComboBox()
        dtpEndDate = New DateTimePicker()
        dtpStartDate = New DateTimePicker()
        cboMembershipType = New ComboBox()
        txtCustomerID = New TextBox()
        txtMembershipID = New TextBox()
        lblStatus = New Label()
        lblEndDate = New Label()
        lblStartDate = New Label()
        lblMembershipType = New Label()
        lblCustomerID = New Label()
        lblMembershipID = New Label()
        lblTitle = New Label()
        pnlEditMembership.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlEditMembership
        ' 
        pnlEditMembership.BackColor = Color.FromArgb(CByte(235), CByte(218), CByte(191))
        pnlEditMembership.Controls.Add(btnCancel)
        pnlEditMembership.Controls.Add(btnSave)
        pnlEditMembership.Controls.Add(cboStatus)
        pnlEditMembership.Controls.Add(dtpEndDate)
        pnlEditMembership.Controls.Add(dtpStartDate)
        pnlEditMembership.Controls.Add(cboMembershipType)
        pnlEditMembership.Controls.Add(txtCustomerID)
        pnlEditMembership.Controls.Add(txtMembershipID)
        pnlEditMembership.Controls.Add(lblStatus)
        pnlEditMembership.Controls.Add(lblEndDate)
        pnlEditMembership.Controls.Add(lblStartDate)
        pnlEditMembership.Controls.Add(lblMembershipType)
        pnlEditMembership.Controls.Add(lblCustomerID)
        pnlEditMembership.Controls.Add(lblMembershipID)
        pnlEditMembership.Controls.Add(lblTitle)
        pnlEditMembership.Location = New Point(12, 15)
        pnlEditMembership.Name = "pnlEditMembership"
        pnlEditMembership.Size = New Size(700, 500)
        pnlEditMembership.TabIndex = 0
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(242), CByte(220), CByte(220))
        btnCancel.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.SaddleBrown
        btnCancel.Location = New Point(370, 408)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(130, 40)
        btnCancel.TabIndex = 15
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.SaddleBrown
        btnSave.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = Color.WhiteSmoke
        btnSave.Location = New Point(220, 408)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(130, 40)
        btnSave.TabIndex = 14
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' cboStatus
        ' 
        cboStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cboStatus.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cboStatus.FormattingEnabled = True
        cboStatus.Location = New Point(300, 335)
        cboStatus.Name = "cboStatus"
        cboStatus.Size = New Size(250, 28)
        cboStatus.TabIndex = 13
        ' 
        ' dtpEndDate
        ' 
        dtpEndDate.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpEndDate.Format = DateTimePickerFormat.Short
        dtpEndDate.Location = New Point(300, 285)
        dtpEndDate.Name = "dtpEndDate"
        dtpEndDate.Size = New Size(250, 26)
        dtpEndDate.TabIndex = 12
        ' 
        ' dtpStartDate
        ' 
        dtpStartDate.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpStartDate.Format = DateTimePickerFormat.Short
        dtpStartDate.Location = New Point(300, 235)
        dtpStartDate.Name = "dtpStartDate"
        dtpStartDate.Size = New Size(250, 26)
        dtpStartDate.TabIndex = 11
        ' 
        ' cboMembershipType
        ' 
        cboMembershipType.DropDownStyle = ComboBoxStyle.DropDownList
        cboMembershipType.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cboMembershipType.FormattingEnabled = True
        cboMembershipType.Location = New Point(300, 185)
        cboMembershipType.Name = "cboMembershipType"
        cboMembershipType.Size = New Size(250, 28)
        cboMembershipType.TabIndex = 10
        ' 
        ' txtCustomerID
        ' 
        txtCustomerID.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCustomerID.Location = New Point(300, 135)
        txtCustomerID.Name = "txtCustomerID"
        txtCustomerID.Size = New Size(250, 26)
        txtCustomerID.TabIndex = 9
        ' 
        ' txtMembershipID
        ' 
        txtMembershipID.BackColor = Color.LightGray
        txtMembershipID.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtMembershipID.Location = New Point(300, 85)
        txtMembershipID.Name = "txtMembershipID"
        txtMembershipID.ReadOnly = True
        txtMembershipID.Size = New Size(250, 26)
        txtMembershipID.TabIndex = 8
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblStatus.ForeColor = Color.SaddleBrown
        lblStatus.Location = New Point(100, 338)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(55, 20)
        lblStatus.TabIndex = 7
        lblStatus.Text = "Status:"
        ' 
        ' lblEndDate
        ' 
        lblEndDate.AutoSize = True
        lblEndDate.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEndDate.ForeColor = Color.SaddleBrown
        lblEndDate.Location = New Point(100, 288)
        lblEndDate.Name = "lblEndDate"
        lblEndDate.Size = New Size(82, 20)
        lblEndDate.TabIndex = 6
        lblEndDate.Text = "End Date:"
        ' 
        ' lblStartDate
        ' 
        lblStartDate.AutoSize = True
        lblStartDate.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblStartDate.ForeColor = Color.SaddleBrown
        lblStartDate.Location = New Point(100, 238)
        lblStartDate.Name = "lblStartDate"
        lblStartDate.Size = New Size(91, 20)
        lblStartDate.TabIndex = 5
        lblStartDate.Text = "Start Date:"
        ' 
        ' lblMembershipType
        ' 
        lblMembershipType.AutoSize = True
        lblMembershipType.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblMembershipType.ForeColor = Color.SaddleBrown
        lblMembershipType.Location = New Point(100, 188)
        lblMembershipType.Name = "lblMembershipType"
        lblMembershipType.Size = New Size(151, 20)
        lblMembershipType.TabIndex = 4
        lblMembershipType.Text = "Membership Type:"
        ' 
        ' lblCustomerID
        ' 
        lblCustomerID.AutoSize = True
        lblCustomerID.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCustomerID.ForeColor = Color.SaddleBrown
        lblCustomerID.Location = New Point(100, 138)
        lblCustomerID.Name = "lblCustomerID"
        lblCustomerID.Size = New Size(108, 20)
        lblCustomerID.TabIndex = 3
        lblCustomerID.Text = "Customer ID:"
        ' 
        ' lblMembershipID
        ' 
        lblMembershipID.AutoSize = True
        lblMembershipID.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblMembershipID.ForeColor = Color.SaddleBrown
        lblMembershipID.Location = New Point(100, 88)
        lblMembershipID.Name = "lblMembershipID"
        lblMembershipID.Size = New Size(124, 20)
        lblMembershipID.TabIndex = 2
        lblMembershipID.Text = "Membership ID:"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Lucida Sans Unicode", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.SaddleBrown
        lblTitle.Location = New Point(100, 30)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(278, 34)
        lblTitle.TabIndex = 1
        lblTitle.Text = "Edit Membership"
        ' 
        ' frmEditMembership
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(724, 530)
        Controls.Add(pnlEditMembership)
        Name = "frmEditMembership"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Edit Membership"
        pnlEditMembership.ResumeLayout(False)
        pnlEditMembership.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlEditMembership As Panel
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents cboMembershipType As ComboBox
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents txtMembershipID As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblEndDate As Label
    Friend WithEvents lblStartDate As Label
    Friend WithEvents lblMembershipType As Label
    Friend WithEvents lblCustomerID As Label
    Friend WithEvents lblMembershipID As Label
    Friend WithEvents lblTitle As Label

End Class