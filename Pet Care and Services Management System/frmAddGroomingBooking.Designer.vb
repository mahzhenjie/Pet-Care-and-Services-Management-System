<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddGroomingBooking
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        pnlAddGroomingBooking = New Panel()
        btnCancel = New Button()
        btnSave = New Button()
        cboStatus = New ComboBox()
        dtpBookingTime = New DateTimePicker()
        dtpBookingDate = New DateTimePicker()
        txtServiceID = New TextBox()
        txtPetID = New TextBox()
        lblStatus = New Label()
        lblBookingTime = New Label()
        lblBookingDate = New Label()
        lblServiceID = New Label()
        lblPetID = New Label()
        lblTitle = New Label()
        pnlAddGroomingBooking.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlAddGroomingBooking
        ' 
        pnlAddGroomingBooking.BackColor = Color.FromArgb(CByte(235), CByte(218), CByte(191))
        pnlAddGroomingBooking.BorderStyle = BorderStyle.FixedSingle
        pnlAddGroomingBooking.Controls.Add(btnCancel)
        pnlAddGroomingBooking.Controls.Add(btnSave)
        pnlAddGroomingBooking.Controls.Add(cboStatus)
        pnlAddGroomingBooking.Controls.Add(dtpBookingTime)
        pnlAddGroomingBooking.Controls.Add(dtpBookingDate)
        pnlAddGroomingBooking.Controls.Add(txtServiceID)
        pnlAddGroomingBooking.Controls.Add(txtPetID)
        pnlAddGroomingBooking.Controls.Add(lblStatus)
        pnlAddGroomingBooking.Controls.Add(lblBookingTime)
        pnlAddGroomingBooking.Controls.Add(lblBookingDate)
        pnlAddGroomingBooking.Controls.Add(lblServiceID)
        pnlAddGroomingBooking.Controls.Add(lblPetID)
        pnlAddGroomingBooking.Controls.Add(lblTitle)
        pnlAddGroomingBooking.Location = New Point(30, 30)
        pnlAddGroomingBooking.Margin = New Padding(4, 4, 4, 4)
        pnlAddGroomingBooking.Name = "pnlAddGroomingBooking"
        pnlAddGroomingBooking.Size = New Size(839, 974)
        pnlAddGroomingBooking.TabIndex = 0
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(244), CByte(218), CByte(207))
        btnCancel.FlatAppearance.BorderColor = Color.White
        btnCancel.FlatAppearance.BorderSize = 2
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnCancel.ForeColor = Color.FromArgb(CByte(148), CByte(72), CByte(23))
        btnCancel.Location = New Point(540, 742)
        btnCancel.Margin = New Padding(4, 4, 4, 4)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(218, 63)
        btnCancel.TabIndex = 12
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(148), CByte(72), CByte(23))
        btnSave.FlatAppearance.BorderColor = Color.White
        btnSave.FlatAppearance.BorderSize = 2
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(285, 742)
        btnSave.Margin = New Padding(4, 4, 4, 4)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(218, 63)
        btnSave.TabIndex = 11
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' cboStatus
        ' 
        cboStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cboStatus.Font = New Font("Segoe UI", 10F)
        cboStatus.FormattingEnabled = True
        cboStatus.Items.AddRange(New Object() {"Pending", "Confirmed", "Completed", "Cancelled"})
        cboStatus.Location = New Point(285, 608)
        cboStatus.Margin = New Padding(4, 4, 4, 4)
        cboStatus.Name = "cboStatus"
        cboStatus.Size = New Size(478, 36)
        cboStatus.TabIndex = 10
        ' 
        ' dtpBookingTime
        ' 
        dtpBookingTime.CustomFormat = "hh:mm tt"
        dtpBookingTime.Font = New Font("Segoe UI", 10F)
        dtpBookingTime.Format = DateTimePickerFormat.Custom
        dtpBookingTime.Location = New Point(285, 525)
        dtpBookingTime.Margin = New Padding(4, 4, 4, 4)
        dtpBookingTime.Name = "dtpBookingTime"
        dtpBookingTime.ShowUpDown = True
        dtpBookingTime.Size = New Size(478, 34)
        dtpBookingTime.TabIndex = 9
        ' 
        ' dtpBookingDate
        ' 
        dtpBookingDate.Font = New Font("Segoe UI", 10F)
        dtpBookingDate.Format = DateTimePickerFormat.Short
        dtpBookingDate.Location = New Point(285, 442)
        dtpBookingDate.Margin = New Padding(4, 4, 4, 4)
        dtpBookingDate.Name = "dtpBookingDate"
        dtpBookingDate.Size = New Size(478, 34)
        dtpBookingDate.TabIndex = 8
        ' 
        ' txtServiceID
        ' 
        txtServiceID.Font = New Font("Segoe UI", 10F)
        txtServiceID.Location = New Point(285, 360)
        txtServiceID.Margin = New Padding(4, 4, 4, 4)
        txtServiceID.Name = "txtServiceID"
        txtServiceID.Size = New Size(478, 34)
        txtServiceID.TabIndex = 7
        ' 
        ' txtPetID
        ' 
        txtPetID.Font = New Font("Segoe UI", 10F)
        txtPetID.Location = New Point(285, 278)
        txtPetID.Margin = New Padding(4, 4, 4, 4)
        txtPetID.Name = "txtPetID"
        txtPetID.Size = New Size(478, 34)
        txtPetID.TabIndex = 6
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Segoe UI", 10F)
        lblStatus.ForeColor = Color.FromArgb(CByte(148), CByte(72), CByte(23))
        lblStatus.Location = New Point(56, 615)
        lblStatus.Margin = New Padding(4, 0, 4, 0)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(65, 28)
        lblStatus.TabIndex = 5
        lblStatus.Text = "Status"
        ' 
        ' lblBookingTime
        ' 
        lblBookingTime.AutoSize = True
        lblBookingTime.Font = New Font("Segoe UI", 10F)
        lblBookingTime.ForeColor = Color.FromArgb(CByte(148), CByte(72), CByte(23))
        lblBookingTime.Location = New Point(56, 532)
        lblBookingTime.Margin = New Padding(4, 0, 4, 0)
        lblBookingTime.Name = "lblBookingTime"
        lblBookingTime.Size = New Size(132, 28)
        lblBookingTime.TabIndex = 4
        lblBookingTime.Text = "Booking Time"
        ' 
        ' lblBookingDate
        ' 
        lblBookingDate.AutoSize = True
        lblBookingDate.Font = New Font("Segoe UI", 10F)
        lblBookingDate.ForeColor = Color.FromArgb(CByte(148), CByte(72), CByte(23))
        lblBookingDate.Location = New Point(56, 450)
        lblBookingDate.Margin = New Padding(4, 0, 4, 0)
        lblBookingDate.Name = "lblBookingDate"
        lblBookingDate.Size = New Size(131, 28)
        lblBookingDate.TabIndex = 3
        lblBookingDate.Text = "Booking Date"
        ' 
        ' lblServiceID
        ' 
        lblServiceID.AutoSize = True
        lblServiceID.Font = New Font("Segoe UI", 10F)
        lblServiceID.ForeColor = Color.FromArgb(CByte(148), CByte(72), CByte(23))
        lblServiceID.Location = New Point(56, 368)
        lblServiceID.Margin = New Padding(4, 0, 4, 0)
        lblServiceID.Name = "lblServiceID"
        lblServiceID.Size = New Size(98, 28)
        lblServiceID.TabIndex = 2
        lblServiceID.Text = "Service ID"
        ' 
        ' lblPetID
        ' 
        lblPetID.AutoSize = True
        lblPetID.Font = New Font("Segoe UI", 10F)
        lblPetID.ForeColor = Color.FromArgb(CByte(148), CByte(72), CByte(23))
        lblPetID.Location = New Point(56, 285)
        lblPetID.Margin = New Padding(4, 0, 4, 0)
        lblPetID.Name = "lblPetID"
        lblPetID.Size = New Size(63, 28)
        lblPetID.TabIndex = 1
        lblPetID.Text = "Pet ID"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(CByte(148), CByte(72), CByte(23))
        lblTitle.Location = New Point(56, 45)
        lblTitle.Margin = New Padding(4, 0, 4, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(565, 54)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Add New Grooming Booking"
        ' 
        ' frmAddGroomingBooking
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(240), CByte(240), CByte(240))
        ClientSize = New Size(900, 1035)
        Controls.Add(pnlAddGroomingBooking)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(4, 4, 4, 4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmAddGroomingBooking"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add Grooming Booking"
        pnlAddGroomingBooking.ResumeLayout(False)
        pnlAddGroomingBooking.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlAddGroomingBooking As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblPetID As Label
    Friend WithEvents lblServiceID As Label
    Friend WithEvents lblBookingDate As Label
    Friend WithEvents lblBookingTime As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents txtPetID As TextBox
    Friend WithEvents txtServiceID As TextBox
    Friend WithEvents dtpBookingDate As DateTimePicker
    Friend WithEvents dtpBookingTime As DateTimePicker
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button

End Class