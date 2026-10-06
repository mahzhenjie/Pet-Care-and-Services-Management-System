<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddBooking
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
        cmbRoomID = New ComboBox()
        txtServiceID = New TextBox()
        txtPetID = New TextBox()
        cboBookingType = New ComboBox()
        lblStatus = New Label()
        lblBookingTime = New Label()
        lblBookingDate = New Label()
        lblRoomID = New Label()
        lblServiceID = New Label()
        lblPetID = New Label()
        lblBookingType = New Label()
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
        pnlAddGroomingBooking.Controls.Add(cmbRoomID)
        pnlAddGroomingBooking.Controls.Add(txtServiceID)
        pnlAddGroomingBooking.Controls.Add(txtPetID)
        pnlAddGroomingBooking.Controls.Add(cboBookingType)
        pnlAddGroomingBooking.Controls.Add(lblStatus)
        pnlAddGroomingBooking.Controls.Add(lblBookingTime)
        pnlAddGroomingBooking.Controls.Add(lblBookingDate)
        pnlAddGroomingBooking.Controls.Add(lblRoomID)
        pnlAddGroomingBooking.Controls.Add(lblServiceID)
        pnlAddGroomingBooking.Controls.Add(lblPetID)
        pnlAddGroomingBooking.Controls.Add(lblBookingType)
        pnlAddGroomingBooking.Controls.Add(lblTitle)
        pnlAddGroomingBooking.Location = New Point(20, 20)
        pnlAddGroomingBooking.Name = "pnlAddGroomingBooking"
        pnlAddGroomingBooking.Size = New Size(560, 700)
        pnlAddGroomingBooking.TabIndex = 0
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(244), CByte(218), CByte(207))
        btnCancel.FlatAppearance.BorderColor = Color.White
        btnCancel.FlatAppearance.BorderSize = 2
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnCancel.ForeColor = Color.FromArgb(CByte(148), CByte(72), CByte(23))
        btnCancel.Location = New Point(360, 585)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(145, 42)
        btnCancel.TabIndex = 15
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(148), CByte(72), CByte(23))
        btnSave.FlatAppearance.BorderColor = Color.White
        btnSave.FlatAppearance.BorderSize = 2
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(190, 585)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(145, 42)
        btnSave.TabIndex = 14
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' cboStatus
        ' 
        cboStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cboStatus.Font = New Font("Segoe UI", 10.0F)
        cboStatus.FormattingEnabled = True
        cboStatus.Items.AddRange(New Object() {"Pending", "Confirmed", "Completed", "Cancelled"})
        cboStatus.Location = New Point(190, 520)
        cboStatus.Name = "cboStatus"
        cboStatus.Size = New Size(320, 31)
        cboStatus.TabIndex = 13
        ' 
        ' dtpBookingTime
        ' 
        dtpBookingTime.CustomFormat = "hh:mm tt"
        dtpBookingTime.Font = New Font("Segoe UI", 10.0F)
        dtpBookingTime.Format = DateTimePickerFormat.Custom
        dtpBookingTime.Location = New Point(190, 465)
        dtpBookingTime.Name = "dtpBookingTime"
        dtpBookingTime.ShowUpDown = True
        dtpBookingTime.Size = New Size(320, 30)
        dtpBookingTime.TabIndex = 12
        ' 
        ' dtpBookingDate
        ' 
        dtpBookingDate.Font = New Font("Segoe UI", 10.0F)
        dtpBookingDate.Format = DateTimePickerFormat.Short
        dtpBookingDate.Location = New Point(190, 410)
        dtpBookingDate.Name = "dtpBookingDate"
        dtpBookingDate.Size = New Size(320, 30)
        dtpBookingDate.TabIndex = 11
        ' 
        ' cmbRoomID
        ' 
        cmbRoomID.DropDownStyle = ComboBoxStyle.DropDownList
        cmbRoomID.Font = New Font("Segoe UI", 10.0F)
        cmbRoomID.FormattingEnabled = True
        cmbRoomID.Location = New Point(190, 355)
        cmbRoomID.Name = "cmbRoomID"
        cmbRoomID.Size = New Size(320, 31)
        cmbRoomID.TabIndex = 10
        ' 
        ' txtServiceID
        ' 
        txtServiceID.Font = New Font("Segoe UI", 10.0F)
        txtServiceID.Location = New Point(190, 300)
        txtServiceID.Name = "txtServiceID"
        txtServiceID.Size = New Size(320, 30)
        txtServiceID.TabIndex = 9
        ' 
        ' txtPetID
        ' 
        txtPetID.Font = New Font("Segoe UI", 10.0F)
        txtPetID.Location = New Point(190, 245)
        txtPetID.Name = "txtPetID"
        txtPetID.Size = New Size(320, 30)
        txtPetID.TabIndex = 8
        ' 
        ' cboBookingType
        ' 
        cboBookingType.DropDownStyle = ComboBoxStyle.DropDownList
        cboBookingType.Font = New Font("Segoe UI", 10.0F)
        cboBookingType.FormattingEnabled = True
        cboBookingType.Items.AddRange(New Object() {"Grooming", "Boarding"})
        cboBookingType.Location = New Point(190, 190)
        cboBookingType.Name = "cboBookingType"
        cboBookingType.Size = New Size(320, 31)
        cboBookingType.TabIndex = 7
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Segoe UI", 10.0F)
        lblStatus.ForeColor = Color.FromArgb(CByte(148), CByte(72), CByte(23))
        lblStatus.Location = New Point(37, 525)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(56, 23)
        lblStatus.TabIndex = 6
        lblStatus.Text = "Status"
        ' 
        ' lblBookingTime
        ' 
        lblBookingTime.AutoSize = True
        lblBookingTime.Font = New Font("Segoe UI", 10.0F)
        lblBookingTime.ForeColor = Color.FromArgb(CByte(148), CByte(72), CByte(23))
        lblBookingTime.Location = New Point(37, 470)
        lblBookingTime.Name = "lblBookingTime"
        lblBookingTime.Size = New Size(114, 23)
        lblBookingTime.TabIndex = 5
        lblBookingTime.Text = "Booking Time"
        ' 
        ' lblBookingDate
        ' 
        lblBookingDate.AutoSize = True
        lblBookingDate.Font = New Font("Segoe UI", 10.0F)
        lblBookingDate.ForeColor = Color.FromArgb(CByte(148), CByte(72), CByte(23))
        lblBookingDate.Location = New Point(37, 415)
        lblBookingDate.Name = "lblBookingDate"
        lblBookingDate.Size = New Size(113, 23)
        lblBookingDate.TabIndex = 4
        lblBookingDate.Text = "Booking Date"
        ' 
        ' lblRoomID
        ' 
        lblRoomID.AutoSize = True
        lblRoomID.Font = New Font("Segoe UI", 10.0F)
        lblRoomID.ForeColor = Color.FromArgb(CByte(148), CByte(72), CByte(23))
        lblRoomID.Location = New Point(37, 360)
        lblRoomID.Name = "lblRoomID"
        lblRoomID.Size = New Size(77, 23)
        lblRoomID.TabIndex = 3
        lblRoomID.Text = "Room ID"
        ' 
        ' lblServiceID
        ' 
        lblServiceID.AutoSize = True
        lblServiceID.Font = New Font("Segoe UI", 10.0F)
        lblServiceID.ForeColor = Color.FromArgb(CByte(148), CByte(72), CByte(23))
        lblServiceID.Location = New Point(37, 305)
        lblServiceID.Name = "lblServiceID"
        lblServiceID.Size = New Size(85, 23)
        lblServiceID.TabIndex = 2
        lblServiceID.Text = "Service ID"
        ' 
        ' lblPetID
        ' 
        lblPetID.AutoSize = True
        lblPetID.Font = New Font("Segoe UI", 10.0F)
        lblPetID.ForeColor = Color.FromArgb(CByte(148), CByte(72), CByte(23))
        lblPetID.Location = New Point(37, 250)
        lblPetID.Name = "lblPetID"
        lblPetID.Size = New Size(56, 23)
        lblPetID.TabIndex = 1
        lblPetID.Text = "Pet ID"
        ' 
        ' lblBookingType
        ' 
        lblBookingType.AutoSize = True
        lblBookingType.Font = New Font("Segoe UI", 10.0F)
        lblBookingType.ForeColor = Color.FromArgb(CByte(148), CByte(72), CByte(23))
        lblBookingType.Location = New Point(37, 195)
        lblBookingType.Name = "lblBookingType"
        lblBookingType.Size = New Size(112, 23)
        lblBookingType.TabIndex = 0
        lblBookingType.Text = "Booking Type"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(CByte(148), CByte(72), CByte(23))
        lblTitle.Location = New Point(37, 30)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(311, 46)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Add New Booking"
        ' 
        ' frmAddBooking
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(240), CByte(240), CByte(240))
        ClientSize = New Size(600, 740)
        Controls.Add(pnlAddGroomingBooking)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmAddBooking"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add Booking"
        pnlAddGroomingBooking.ResumeLayout(False)
        pnlAddGroomingBooking.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlAddGroomingBooking As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblBookingType As Label
    Friend WithEvents lblPetID As Label
    Friend WithEvents lblServiceID As Label
    Friend WithEvents lblRoomID As Label
    Friend WithEvents lblBookingDate As Label
    Friend WithEvents lblBookingTime As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents cboBookingType As ComboBox
    Friend WithEvents txtPetID As TextBox
    Friend WithEvents txtServiceID As TextBox
    Friend WithEvents cmbRoomID As ComboBox
    Friend WithEvents dtpBookingDate As DateTimePicker
    Friend WithEvents dtpBookingTime As DateTimePicker
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button

End Class