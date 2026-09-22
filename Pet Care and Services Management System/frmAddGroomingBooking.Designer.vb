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
        pnlAddGroomingBooking.BackColor = Color.FromArgb(235, 218, 191)
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
        pnlAddGroomingBooking.Location = New Point(20, 20)
        pnlAddGroomingBooking.Name = "pnlAddGroomingBooking"
        pnlAddGroomingBooking.Size = New Size(560, 650)
        pnlAddGroomingBooking.TabIndex = 0
        '
        ' btnCancel
        '
        btnCancel.BackColor = Color.FromArgb(244, 218, 207)
        btnCancel.FlatAppearance.BorderColor = Color.White
        btnCancel.FlatAppearance.BorderSize = 2
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnCancel.ForeColor = Color.FromArgb(148, 72, 23)
        btnCancel.Location = New Point(360, 495)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(145, 42)
        btnCancel.TabIndex = 12
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        '
        ' btnSave
        '
        btnSave.BackColor = Color.FromArgb(148, 72, 23)
        btnSave.FlatAppearance.BorderColor = Color.White
        btnSave.FlatAppearance.BorderSize = 2
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(190, 495)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(145, 42)
        btnSave.TabIndex = 11
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        '
        ' cboStatus
        '
        cboStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cboStatus.Font = New Font("Segoe UI", 10.0F)
        cboStatus.FormattingEnabled = True
        cboStatus.Items.AddRange(New Object() {"Pending", "Confirmed", "Completed", "Cancelled"})
        cboStatus.Location = New Point(190, 405)
        cboStatus.Name = "cboStatus"
        cboStatus.Size = New Size(320, 31)
        cboStatus.TabIndex = 10
        '
        ' dtpBookingTime
        '
        dtpBookingTime.CustomFormat = "hh:mm tt"
        dtpBookingTime.Font = New Font("Segoe UI", 10.0F)
        dtpBookingTime.Format = DateTimePickerFormat.Custom
        dtpBookingTime.Location = New Point(190, 350)
        dtpBookingTime.Name = "dtpBookingTime"
        dtpBookingTime.ShowUpDown = True
        dtpBookingTime.Size = New Size(320, 30)
        dtpBookingTime.TabIndex = 9
        '
        ' dtpBookingDate
        '
        dtpBookingDate.Font = New Font("Segoe UI", 10.0F)
        dtpBookingDate.Format = DateTimePickerFormat.Short
        dtpBookingDate.Location = New Point(190, 295)
        dtpBookingDate.Name = "dtpBookingDate"
        dtpBookingDate.Size = New Size(320, 30)
        dtpBookingDate.TabIndex = 8
        '
        ' txtServiceID
        '
        txtServiceID.Font = New Font("Segoe UI", 10.0F)
        txtServiceID.Location = New Point(190, 240)
        txtServiceID.Name = "txtServiceID"
        txtServiceID.Size = New Size(320, 30)
        txtServiceID.TabIndex = 7
        '
        ' txtPetID
        '
        txtPetID.Font = New Font("Segoe UI", 10.0F)
        txtPetID.Location = New Point(190, 185)
        txtPetID.Name = "txtPetID"
        txtPetID.Size = New Size(320, 30)
        txtPetID.TabIndex = 6
        '
        ' lblStatus
        '
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Segoe UI", 10.0F)
        lblStatus.ForeColor = Color.FromArgb(148, 72, 23)
        lblStatus.Location = New Point(37, 410)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(60, 23)
        lblStatus.TabIndex = 5
        lblStatus.Text = "Status"
        '
        ' lblBookingTime
        '
        lblBookingTime.AutoSize = True
        lblBookingTime.Font = New Font("Segoe UI", 10.0F)
        lblBookingTime.ForeColor = Color.FromArgb(148, 72, 23)
        lblBookingTime.Location = New Point(37, 355)
        lblBookingTime.Name = "lblBookingTime"
        lblBookingTime.Size = New Size(125, 23)
        lblBookingTime.TabIndex = 4
        lblBookingTime.Text = "Booking Time"
        '
        ' lblBookingDate
        '
        lblBookingDate.AutoSize = True
        lblBookingDate.Font = New Font("Segoe UI", 10.0F)
        lblBookingDate.ForeColor = Color.FromArgb(148, 72, 23)
        lblBookingDate.Location = New Point(37, 300)
        lblBookingDate.Name = "lblBookingDate"
        lblBookingDate.Size = New Size(126, 23)
        lblBookingDate.TabIndex = 3
        lblBookingDate.Text = "Booking Date"
        '
        ' lblServiceID
        '
        lblServiceID.AutoSize = True
        lblServiceID.Font = New Font("Segoe UI", 10.0F)
        lblServiceID.ForeColor = Color.FromArgb(148, 72, 23)
        lblServiceID.Location = New Point(37, 245)
        lblServiceID.Name = "lblServiceID"
        lblServiceID.Size = New Size(100, 23)
        lblServiceID.TabIndex = 2
        lblServiceID.Text = "Service ID"
        '
        ' lblPetID
        '
        lblPetID.AutoSize = True
        lblPetID.Font = New Font("Segoe UI", 10.0F)
        lblPetID.ForeColor = Color.FromArgb(148, 72, 23)
        lblPetID.Location = New Point(37, 190)
        lblPetID.Name = "lblPetID"
        lblPetID.Size = New Size(70, 23)
        lblPetID.TabIndex = 1
        lblPetID.Text = "Pet ID"
        '
        ' lblTitle
        '
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(148, 72, 23)
        lblTitle.Location = New Point(37, 30)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(390, 46)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Add New Grooming Booking"
        '
        ' frmAddGroomingBooking
        '
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(240, 240, 240)
        ClientSize = New Size(600, 690)
        Controls.Add(pnlAddGroomingBooking)
        FormBorderStyle = FormBorderStyle.FixedSingle
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