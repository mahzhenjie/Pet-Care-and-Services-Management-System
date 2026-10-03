<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewAppointment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNewAppointment))
        pnlHeader = New Panel()
        PictureBox2 = New PictureBox()
        lblMyAppointment = New Label()
        pnlAddPet = New Panel()
        cmbGender = New ComboBox()
        btnCancel = New Button()
        btnBookAppointment = New Button()
        lblTime = New Label()
        lblDate = New Label()
        lblService = New Label()
        lblServiceType = New Label()
        lblPetName = New Label()
        lblNewAppoinment = New Label()
        cmbPet = New ComboBox()
        cmbService = New ComboBox()
        dtpAppointmentDate = New DateTimePicker()
        dtpBookingTime = New DateTimePicker()
        pnlHeader.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        pnlAddPet.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(55), CByte(32), CByte(20))
        pnlHeader.Controls.Add(PictureBox2)
        pnlHeader.Controls.Add(lblMyAppointment)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(887, 70)
        pnlHeader.TabIndex = 18
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(3, 9)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(91, 53)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' lblMyAppointment
        ' 
        lblMyAppointment.AutoSize = True
        lblMyAppointment.Font = New Font("Georgia", 22F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMyAppointment.ForeColor = Color.FromArgb(CByte(255), CByte(243), CByte(222))
        lblMyAppointment.Location = New Point(88, 11)
        lblMyAppointment.Name = "lblMyAppointment"
        lblMyAppointment.Size = New Size(472, 51)
        lblMyAppointment.TabIndex = 0
        lblMyAppointment.Text = "MY APPOINTMENT"
        ' 
        ' pnlAddPet
        ' 
        pnlAddPet.BackColor = Color.FromArgb(CByte(232), CByte(216), CByte(194))
        pnlAddPet.Controls.Add(dtpBookingTime)
        pnlAddPet.Controls.Add(dtpAppointmentDate)
        pnlAddPet.Controls.Add(cmbService)
        pnlAddPet.Controls.Add(cmbPet)
        pnlAddPet.Controls.Add(cmbGender)
        pnlAddPet.Controls.Add(btnCancel)
        pnlAddPet.Controls.Add(btnBookAppointment)
        pnlAddPet.Controls.Add(lblTime)
        pnlAddPet.Controls.Add(lblDate)
        pnlAddPet.Controls.Add(lblService)
        pnlAddPet.Controls.Add(lblServiceType)
        pnlAddPet.Controls.Add(lblPetName)
        pnlAddPet.Controls.Add(lblNewAppoinment)
        pnlAddPet.Location = New Point(24, 92)
        pnlAddPet.Margin = New Padding(4)
        pnlAddPet.Name = "pnlAddPet"
        pnlAddPet.Size = New Size(840, 638)
        pnlAddPet.TabIndex = 17
        ' 
        ' cmbGender
        ' 
        cmbGender.FormattingEnabled = True
        cmbGender.Items.AddRange(New Object() {"Male", "Female", "Others"})
        cmbGender.Location = New Point(284, 176)
        cmbGender.Name = "cmbGender"
        cmbGender.Size = New Size(196, 38)
        cmbGender.TabIndex = 15
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(244), CByte(220), CByte(204))
        btnCancel.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.SaddleBrown
        btnCancel.Location = New Point(431, 477)
        btnCancel.Margin = New Padding(4)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(225, 68)
        btnCancel.TabIndex = 14
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnBookAppointment
        ' 
        btnBookAppointment.BackColor = Color.SaddleBrown
        btnBookAppointment.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBookAppointment.ForeColor = Color.WhiteSmoke
        btnBookAppointment.Location = New Point(178, 477)
        btnBookAppointment.Margin = New Padding(4)
        btnBookAppointment.Name = "btnBookAppointment"
        btnBookAppointment.Size = New Size(225, 68)
        btnBookAppointment.TabIndex = 13
        btnBookAppointment.Text = "Book Appointment"
        btnBookAppointment.UseVisualStyleBackColor = False
        ' 
        ' lblTime
        ' 
        lblTime.AutoSize = True
        lblTime.Font = New Font("Lucida Sans Unicode", 11F)
        lblTime.ForeColor = Color.SaddleBrown
        lblTime.Location = New Point(88, 375)
        lblTime.Margin = New Padding(4, 0, 4, 0)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(65, 27)
        lblTime.TabIndex = 11
        lblTime.Text = "Time"
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.Font = New Font("Lucida Sans Unicode", 11F)
        lblDate.ForeColor = Color.SaddleBrown
        lblDate.Location = New Point(88, 312)
        lblDate.Margin = New Padding(4, 0, 4, 0)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(60, 27)
        lblDate.TabIndex = 9
        lblDate.Text = "Date"
        ' 
        ' lblService
        ' 
        lblService.AutoSize = True
        lblService.Font = New Font("Lucida Sans Unicode", 11F)
        lblService.ForeColor = Color.SaddleBrown
        lblService.Location = New Point(88, 247)
        lblService.Margin = New Padding(4, 0, 4, 0)
        lblService.Name = "lblService"
        lblService.Size = New Size(85, 27)
        lblService.TabIndex = 7
        lblService.Text = "Service"
        ' 
        ' lblServiceType
        ' 
        lblServiceType.AutoSize = True
        lblServiceType.Font = New Font("Lucida Sans Unicode", 11F)
        lblServiceType.ForeColor = Color.SaddleBrown
        lblServiceType.Location = New Point(88, 181)
        lblServiceType.Margin = New Padding(4, 0, 4, 0)
        lblServiceType.Name = "lblServiceType"
        lblServiceType.Size = New Size(144, 27)
        lblServiceType.TabIndex = 5
        lblServiceType.Text = "Service Type"
        ' 
        ' lblPetName
        ' 
        lblPetName.AutoSize = True
        lblPetName.Font = New Font("Lucida Sans Unicode", 11F)
        lblPetName.ForeColor = Color.SaddleBrown
        lblPetName.Location = New Point(88, 112)
        lblPetName.Margin = New Padding(4, 0, 4, 0)
        lblPetName.Name = "lblPetName"
        lblPetName.Size = New Size(112, 27)
        lblPetName.TabIndex = 3
        lblPetName.Text = "Pet Name"
        ' 
        ' lblNewAppoinment
        ' 
        lblNewAppoinment.AutoSize = True
        lblNewAppoinment.Font = New Font("Lucida Sans Unicode", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNewAppoinment.ForeColor = Color.SaddleBrown
        lblNewAppoinment.Location = New Point(14, 15)
        lblNewAppoinment.Margin = New Padding(4, 0, 4, 0)
        lblNewAppoinment.Name = "lblNewAppoinment"
        lblNewAppoinment.Size = New Size(333, 44)
        lblNewAppoinment.TabIndex = 0
        lblNewAppoinment.Text = "New Appoinment"
        ' 
        ' cmbPet
        ' 
        cmbPet.FormattingEnabled = True
        cmbPet.Items.AddRange(New Object() {"Male", "Female", "Others"})
        cmbPet.Location = New Point(284, 107)
        cmbPet.Name = "cmbPet"
        cmbPet.Size = New Size(196, 38)
        cmbPet.TabIndex = 16
        ' 
        ' cmbService
        ' 
        cmbService.FormattingEnabled = True
        cmbService.Items.AddRange(New Object() {"Male", "Female", "Others"})
        cmbService.Location = New Point(284, 242)
        cmbService.Name = "cmbService"
        cmbService.Size = New Size(196, 38)
        cmbService.TabIndex = 17
        ' 
        ' dtpAppointmentDate
        ' 
        dtpAppointmentDate.Format = DateTimePickerFormat.Short
        dtpAppointmentDate.Location = New Point(281, 306)
        dtpAppointmentDate.Name = "dtpAppointmentDate"
        dtpAppointmentDate.Size = New Size(199, 35)
        dtpAppointmentDate.TabIndex = 8
        ' 
        ' dtpBookingTime
        ' 
        dtpBookingTime.CustomFormat = "hh:mm tt"
        dtpBookingTime.Font = New Font("Segoe UI", 10F)
        dtpBookingTime.Format = DateTimePickerFormat.Custom
        dtpBookingTime.Location = New Point(281, 369)
        dtpBookingTime.Margin = New Padding(4)
        dtpBookingTime.Name = "dtpBookingTime"
        dtpBookingTime.ShowUpDown = True
        dtpBookingTime.Size = New Size(478, 34)
        dtpBookingTime.TabIndex = 18
        ' 
        ' FrmNewAppointment
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(887, 770)
        Controls.Add(pnlHeader)
        Controls.Add(pnlAddPet)
        Name = "FrmNewAppointment"
        Text = "FrmNewAppointment"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        pnlAddPet.ResumeLayout(False)
        pnlAddPet.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblMyAppointment As Label
    Friend WithEvents pnlAddPet As Panel
    Friend WithEvents cmbService As ComboBox
    Friend WithEvents cmbPet As ComboBox
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnBookAppointment As Button
    Friend WithEvents lblTime As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblService As Label
    Friend WithEvents lblServiceType As Label
    Friend WithEvents lblPetName As Label
    Friend WithEvents lblNewAppoinment As Label
    Friend WithEvents dtpAppointmentDate As DateTimePicker
    Friend WithEvents dtpBookingTime As DateTimePicker
End Class
