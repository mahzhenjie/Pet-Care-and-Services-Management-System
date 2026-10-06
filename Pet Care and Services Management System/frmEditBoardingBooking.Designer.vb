<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEditBoardingBooking
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
        Me.pnlEditBoardingBooking = New System.Windows.Forms.Panel()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.lblEndDate = New System.Windows.Forms.Label()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.lblStartDate = New System.Windows.Forms.Label()
        Me.cmbRoomID = New System.Windows.Forms.ComboBox()
        Me.lblRoomID = New System.Windows.Forms.Label()
        Me.cmbPetID = New System.Windows.Forms.ComboBox()
        Me.lblPetID = New System.Windows.Forms.Label()
        Me.txtBookingID = New System.Windows.Forms.TextBox()
        Me.lblBookingID = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.pnlEditBoardingBooking.SuspendLayout()
        Me.SuspendLayout()

        '
        ' pnlEditBoardingBooking
        '
        Me.pnlEditBoardingBooking.BackColor = System.Drawing.Color.FromArgb(CByte(235), CByte(218), CByte(191))
        Me.pnlEditBoardingBooking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlEditBoardingBooking.Controls.Add(Me.btnCancel)
        Me.pnlEditBoardingBooking.Controls.Add(Me.btnSave)
        Me.pnlEditBoardingBooking.Controls.Add(Me.txtStatus)
        Me.pnlEditBoardingBooking.Controls.Add(Me.lblStatus)
        Me.pnlEditBoardingBooking.Controls.Add(Me.dtpEndDate)
        Me.pnlEditBoardingBooking.Controls.Add(Me.lblEndDate)
        Me.pnlEditBoardingBooking.Controls.Add(Me.dtpStartDate)
        Me.pnlEditBoardingBooking.Controls.Add(Me.lblStartDate)
        Me.pnlEditBoardingBooking.Controls.Add(Me.cmbRoomID)
        Me.pnlEditBoardingBooking.Controls.Add(Me.lblRoomID)
        Me.pnlEditBoardingBooking.Controls.Add(Me.cmbPetID)
        Me.pnlEditBoardingBooking.Controls.Add(Me.lblPetID)
        Me.pnlEditBoardingBooking.Controls.Add(Me.txtBookingID)
        Me.pnlEditBoardingBooking.Controls.Add(Me.lblBookingID)
        Me.pnlEditBoardingBooking.Controls.Add(Me.lblTitle)
        Me.pnlEditBoardingBooking.Location = New System.Drawing.Point(20, 20)
        Me.pnlEditBoardingBooking.Name = "pnlEditBoardingBooking"
        Me.pnlEditBoardingBooking.Size = New System.Drawing.Size(560, 700)
        Me.pnlEditBoardingBooking.TabIndex = 0

        '
        ' txtStatus
        '
        Me.txtStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtStatus.Location = New System.Drawing.Point(190, 460)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(320, 30)
        Me.txtStatus.TabIndex = 11

        '
        ' lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CByte(148), CByte(72), CByte(23))
        Me.lblStatus.Location = New System.Drawing.Point(37, 465)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(60, 23)
        Me.lblStatus.TabIndex = 10
        Me.lblStatus.Text = "Status"

        '
        ' dtpEndDate
        '
        Me.dtpEndDate.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpEndDate.Location = New System.Drawing.Point(190, 405)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(320, 30)
        Me.dtpEndDate.TabIndex = 9

        '
        ' lblEndDate
        '
        Me.lblEndDate.AutoSize = True
        Me.lblEndDate.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblEndDate.ForeColor = System.Drawing.Color.FromArgb(CByte(148), CByte(72), CByte(23))
        Me.lblEndDate.Location = New System.Drawing.Point(37, 410)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(80, 23)
        Me.lblEndDate.TabIndex = 8
        Me.lblEndDate.Text = "End Date"

        '
        ' dtpStartDate
        '
        Me.dtpStartDate.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpStartDate.Location = New System.Drawing.Point(190, 350)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(320, 30)
        Me.dtpStartDate.TabIndex = 7

        '
        ' lblStartDate
        '
        Me.lblStartDate.AutoSize = True
        Me.lblStartDate.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblStartDate.ForeColor = System.Drawing.Color.FromArgb(CByte(148), CByte(72), CByte(23))
        Me.lblStartDate.Location = New System.Drawing.Point(37, 355)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(90, 23)
        Me.lblStartDate.TabIndex = 6
        Me.lblStartDate.Text = "Start Date"

        '
        ' cmbRoomID
        '
        Me.cmbRoomID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRoomID.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbRoomID.FormattingEnabled = True
        Me.cmbRoomID.Location = New System.Drawing.Point(190, 295)
        Me.cmbRoomID.Name = "cmbRoomID"
        Me.cmbRoomID.Size = New System.Drawing.Size(320, 31)
        Me.cmbRoomID.TabIndex = 5

        '
        ' lblRoomID
        '
        Me.lblRoomID.AutoSize = True
        Me.lblRoomID.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblRoomID.ForeColor = System.Drawing.Color.FromArgb(CByte(148), CByte(72), CByte(23))
        Me.lblRoomID.Location = New System.Drawing.Point(37, 300)
        Me.lblRoomID.Name = "lblRoomID"
        Me.lblRoomID.Size = New System.Drawing.Size(75, 23)
        Me.lblRoomID.TabIndex = 4
        Me.lblRoomID.Text = "Room ID"

        '
        ' cmbPetID
        '
        Me.cmbPetID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPetID.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbPetID.FormattingEnabled = True
        Me.cmbPetID.Location = New System.Drawing.Point(190, 240)
        Me.cmbPetID.Name = "cmbPetID"
        Me.cmbPetID.Size = New System.Drawing.Size(320, 31)
        Me.cmbPetID.TabIndex = 3

        '
        ' lblPetID
        '
        Me.lblPetID.AutoSize = True
        Me.lblPetID.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblPetID.ForeColor = System.Drawing.Color.FromArgb(CByte(148), CByte(72), CByte(23))
        Me.lblPetID.Location = New System.Drawing.Point(37, 245)
        Me.lblPetID.Name = "lblPetID"
        Me.lblPetID.Size = New System.Drawing.Size(60, 23)
        Me.lblPetID.TabIndex = 2
        Me.lblPetID.Text = "Pet ID"

        '
        ' txtBookingID
        '
        Me.txtBookingID.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtBookingID.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtBookingID.Location = New System.Drawing.Point(190, 185)
        Me.txtBookingID.Name = "txtBookingID"
        Me.txtBookingID.ReadOnly = True
        Me.txtBookingID.Size = New System.Drawing.Size(320, 30)
        Me.txtBookingID.TabIndex = 1

        '
        ' lblBookingID
        '
        Me.lblBookingID.AutoSize = True
        Me.lblBookingID.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblBookingID.ForeColor = System.Drawing.Color.FromArgb(CByte(148), CByte(72), CByte(23))
        Me.lblBookingID.Location = New System.Drawing.Point(37, 190)
        Me.lblBookingID.Name = "lblBookingID"
        Me.lblBookingID.Size = New System.Drawing.Size(90, 23)
        Me.lblBookingID.TabIndex = 0
        Me.lblBookingID.Text = "Booking ID"

        '
        ' lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CByte(148), CByte(72), CByte(23))
        Me.lblTitle.Location = New System.Drawing.Point(37, 30)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(370, 46)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Edit Boarding Booking"

        '
        ' btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CByte(148), CByte(72), CByte(23))
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSave.FlatAppearance.BorderSize = 2
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(190, 550)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(145, 42)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False

        '
        ' btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CByte(244), CByte(218), CByte(207))
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCancel.FlatAppearance.BorderSize = 2
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CByte(148), CByte(72), CByte(23))
        Me.btnCancel.Location = New System.Drawing.Point(360, 550)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(145, 42)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False

        '
        ' frmEditBoardingBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CByte(240), CByte(240), CByte(240))
        Me.ClientSize = New System.Drawing.Size(600, 740)
        Me.Controls.Add(Me.pnlEditBoardingBooking)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEditBoardingBooking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Boarding Booking"
        Me.pnlEditBoardingBooking.ResumeLayout(False)
        Me.pnlEditBoardingBooking.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlEditBoardingBooking As Panel
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents lblEndDate As Label
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents lblStartDate As Label
    Friend WithEvents cmbRoomID As ComboBox
    Friend WithEvents lblRoomID As Label
    Friend WithEvents cmbPetID As ComboBox
    Friend WithEvents lblPetID As Label
    Friend WithEvents txtBookingID As TextBox
    Friend WithEvents lblBookingID As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button

End Class