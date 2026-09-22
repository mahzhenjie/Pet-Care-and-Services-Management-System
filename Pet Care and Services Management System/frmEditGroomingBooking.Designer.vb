<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEditGroomingBooking
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
        pnlEditGroomingBooking = New Panel()
        btnCancel = New Button()
        btnSave = New Button()
        cboStatus = New ComboBox()
        dtpBookingTime = New DateTimePicker()
        dtpBookingDate = New DateTimePicker()
        txtServiceID = New TextBox()
        txtPetID = New TextBox()
        txtGroomingBookingID = New TextBox()
        lblStatus = New Label()
        lblBookingTime = New Label()
        lblBookingDate = New Label()
        lblServiceID = New Label()
        lblPetID = New Label()
        lblGroomingBookingID = New Label()
        lblTitle = New Label()
        pnlEditGroomingBooking.SuspendLayout()
        SuspendLayout()
        '
        ' pnlEditGroomingBooking
        '
        pnlEditGroomingBooking.BackColor = Color.FromArgb(235, 218, 191)
        pnlEditGroomingBooking.BorderStyle = BorderStyle.FixedSingle
        pnlEditGroomingBooking.Controls.Add(btnCancel)
        pnlEditGroomingBooking.Controls.Add(btnSave)
        pnlEditGroomingBooking.Controls.Add(cboStatus)
        pnlEditGroomingBooking.Controls.Add(dtpBookingTime)
        pnlEditGroomingBooking.Controls.Add(dtpBookingDate)
        pnlEditGroomingBooking.Controls.Add(txtServiceID)
        pnlEditGroomingBooking.Controls.Add(txtPetID)
        pnlEditGroomingBooking.Controls.Add(txtGroomingBookingID)
        pnlEditGroomingBooking.Controls.Add(lblStatus)
        pnlEditGroomingBooking.Controls.Add(lblBookingTime)
        pnlEditGroomingBooking.Controls.Add(lblBookingDate)
        pnlEditGroomingBooking.Controls.Add(lblServiceID)
        pnlEditGroomingBooking.Controls.Add(lblPetID)
        pnlEditGroomingBooking.Controls.Add(lblGroomingBookingID)
        pnlEditGroomingBooking.Controls.Add(lblTitle)
        pnlEditGroomingBooking.Location = New Point(20, 20)
        pnlEditGroomingBooking.Name = "pnlEditGroomingBooking"
        pnlEditGroomingBooking.Size = New Size(560, 700)
        pnlEditGroomingBooking.TabIndex = 0
        '
        ' btnCancel
        '
        btnCancel.BackColor = Color.FromArgb(244, 218, 207)
        btnCancel.FlatAppearance.BorderColor = Color.White
        btnCancel.FlatAppearance.BorderSize = 2
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnCancel.ForeColor = Color.FromArgb(148, 72, 23)
        btnCancel.Location = New Point(360, 550)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(145, 42)
        btnCancel.TabIndex = 14
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
        btnSave.Location = New Point(190, 550)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(145, 42)
        btnSave.TabIndex = 13
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        '
        ' cboStatus
        '
        cboStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cboStatus.Font = New Font("Segoe UI", 10.0F)
        cboStatus.FormattingEnabled = True
        cboStatus.Items.AddRange(New Object() {"Pending", "Confirmed", "Completed", "Cancelled"})
        cboStatus.Location = New Point(190, 460)
        cboStatus.Name = "cboStatus"
        cboStatus.Size = New Size(320, 31)
        cboStatus.TabIndex = 12
        '
        ' dtpBookingTime
        '
        dtpBookingTime.CustomFormat = "hh:mm tt"
        dtpBookingTime.Font = New Font("Segoe UI", 10.0F)
        dtpBookingTime.Format = DateTimePickerFormat.Custom
        dtpBookingTime.Location = New Point(190, 405)
        dtpBookingTime.Name = "dtpBookingTime"
        dtpBookingTime.ShowUpDown = True
        dtpBookingTime.Size = New Size(320, 30)
        dtpBookingTime.TabIndex = 11
        '
        ' dtpBookingDate
        '
        dtpBookingDate.Font = New Font("Segoe UI", 10.0F)
        dtpBookingDate.Format = DateTimePickerFormat.Short
        dtpBookingDate.Location = New Point(190, 350)
        dtpBookingDate.Name = "dtpBookingDate"
        dtpBookingDate.Size = New Size(320, 30)
        dtpBookingDate.TabIndex = 10
        '
        ' txtServiceID
        '
        txtServiceID.Font = New Font("Segoe UI", 10.0F)
        txtServiceID.Location = New Point(190, 295)
        txtServiceID.Name = "txtServiceID"
        txtServiceID.Size = New Size(320, 30)
        txtServiceID.TabIndex = 9
        '
        ' txtPetID
        '
        txtPetID.Font = New Font("Segoe UI", 10.0F)
        txtPetID.Location = New Point(190, 240)
        txtPetID.Name = "txtPetID"
        txtPetID.Size = New Size(320, 30)
        txtPetID.TabIndex = 8
        '
        ' txtGroomingBookingID
        '
        txtGroomingBookingID.BackColor = Color.WhiteSmoke
        txtGroomingBookingID.Font = New Font("Segoe UI", 10.0F)
        txtGroomingBookingID.Location = New Point(190, 185)
        txtGroomingBookingID.Name = "txtGroomingBookingID"
        txtGroomingBookingID.ReadOnly = True
        txtGroomingBookingID.Size = New Size(320, 30)
        txtGroomingBookingID.TabIndex = 7
        '
        ' lblStatus
        '
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Segoe UI", 10.0F)
        lblStatus.ForeColor = Color.FromArgb(148, 72, 23)
        lblStatus.Location = New Point(37, 465)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(60, 23)
        lblStatus.TabIndex = 6
        lblStatus.Text = "Status"
        '
        ' lblBookingTime
        '
        lblBookingTime.AutoSize = True
        lblBookingTime.Font = New Font("Segoe UI", 10.0F)
        lblBookingTime.ForeColor = Color.FromArgb(148, 72, 23)
        lblBookingTime.Location = New Point(37, 410)
        lblBookingTime.Name = "lblBookingTime"
        lblBookingTime.Size = New Size(125, 23)
        lblBookingTime.TabIndex = 5
        lblBookingTime.Text = "Booking Time"
        '
        ' lblBookingDate
        '
        lblBookingDate.AutoSize = True
        lblBookingDate.Font = New Font("Segoe UI", 10.0F)
        lblBookingDate.ForeColor = Color.FromArgb(148, 72, 23)
        lblBookingDate.Location = New Point(37, 355)
        lblBookingDate.Name = "lblBookingDate"
        lblBookingDate.Size = New Size(126, 23)
        lblBookingDate.TabIndex = 4
        lblBookingDate.Text = "Booking Date"
        '
        ' lblServiceID
        '
        lblServiceID.AutoSize = True
        lblServiceID.Font = New Font("Segoe UI", 10.0F)
        lblServiceID.ForeColor = Color.FromArgb(148, 72, 23)
        lblServiceID.Location = New Point(37, 300)
        lblServiceID.Name = "lblServiceID"
        lblServiceID.Size = New Size(100, 23)
        lblServiceID.TabIndex = 3
        lblServiceID.Text = "Service ID"
        '
        ' lblPetID
        '
        lblPetID.AutoSize = True
        lblPetID.Font = New Font("Segoe UI", 10.0F)
        lblPetID.ForeColor = Color.FromArgb(148, 72, 23)
        lblPetID.Location = New Point(37, 245)
        lblPetID.Name = "lblPetID"
        lblPetID.Size = New Size(70, 23)
        lblPetID.TabIndex = 2
        lblPetID.Text = "Pet ID"
        '
        ' lblGroomingBookingID
        '
        lblGroomingBookingID.AutoSize = True
        lblGroomingBookingID.Font = New Font("Segoe UI", 10.0F)
        lblGroomingBookingID.ForeColor = Color.FromArgb(148, 72, 23)
        lblGroomingBookingID.Location = New Point(37, 190)
        lblGroomingBookingID.Name = "lblGroomingBookingID"
        lblGroomingBookingID.Size = New Size(145, 23)
        lblGroomingBookingID.TabIndex = 1
        lblGroomingBookingID.Text = "Booking ID"
        '
        ' lblTitle
        '
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(148, 72, 23)
        lblTitle.Location = New Point(37, 30)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(365, 46)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Edit Grooming Booking"
        '
        ' frmEditGroomingBooking
        '
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(240, 240, 240)
        ClientSize = New Size(600, 740)
        Controls.Add(pnlEditGroomingBooking)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmEditGroomingBooking"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Edit Grooming Booking"
        pnlEditGroomingBooking.ResumeLayout(False)
        pnlEditGroomingBooking.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlEditGroomingBooking As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblGroomingBookingID As Label
    Friend WithEvents lblPetID As Label
    Friend WithEvents lblServiceID As Label
    Friend WithEvents lblBookingDate As Label
    Friend WithEvents lblBookingTime As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents txtGroomingBookingID As TextBox
    Friend WithEvents txtPetID As TextBox
    Friend WithEvents txtServiceID As TextBox
    Friend WithEvents dtpBookingDate As DateTimePicker
    Friend WithEvents dtpBookingTime As DateTimePicker
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button

End Class