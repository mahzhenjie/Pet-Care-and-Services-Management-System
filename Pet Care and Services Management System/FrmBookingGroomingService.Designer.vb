<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBookingGroomingService
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBookingGroomingService))
        pnlHeader = New Panel()
        PictureBox2 = New PictureBox()
        lblMyAppointment = New Label()
        pnlAddPet = New Panel()
        txtPrice = New TextBox()
        lblPrice = New Label()
        txtServiceDescription = New TextBox()
        dtpTime = New DateTimePicker()
        dtpDate = New DateTimePicker()
        cmbPetName = New ComboBox()
        cmbServiceName = New ComboBox()
        btnCancel = New Button()
        btnBooking = New Button()
        lblTime = New Label()
        lblDate = New Label()
        lblService = New Label()
        lblServiceName = New Label()
        lblPetName = New Label()
        lblNewAppoinment = New Label()
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
        pnlHeader.Margin = New Padding(2, 2, 2, 2)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(631, 54)
        pnlHeader.TabIndex = 22
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(2, 6)
        PictureBox2.Margin = New Padding(2, 2, 2, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(61, 35)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' lblMyAppointment
        ' 
        lblMyAppointment.AutoSize = True
        lblMyAppointment.Font = New Font("Georgia", 22F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMyAppointment.ForeColor = Color.FromArgb(CByte(255), CByte(243), CByte(222))
        lblMyAppointment.Location = New Point(59, 7)
        lblMyAppointment.Margin = New Padding(2, 0, 2, 0)
        lblMyAppointment.Name = "lblMyAppointment"
        lblMyAppointment.Size = New Size(443, 43)
        lblMyAppointment.TabIndex = 0
        lblMyAppointment.Text = "GROOMING SERVICE"
        ' 
        ' pnlAddPet
        ' 
        pnlAddPet.BackColor = Color.FromArgb(CByte(232), CByte(216), CByte(194))
        pnlAddPet.Controls.Add(txtPrice)
        pnlAddPet.Controls.Add(lblPrice)
        pnlAddPet.Controls.Add(txtServiceDescription)
        pnlAddPet.Controls.Add(dtpTime)
        pnlAddPet.Controls.Add(dtpDate)
        pnlAddPet.Controls.Add(cmbPetName)
        pnlAddPet.Controls.Add(cmbServiceName)
        pnlAddPet.Controls.Add(btnCancel)
        pnlAddPet.Controls.Add(btnBooking)
        pnlAddPet.Controls.Add(lblTime)
        pnlAddPet.Controls.Add(lblDate)
        pnlAddPet.Controls.Add(lblService)
        pnlAddPet.Controls.Add(lblServiceName)
        pnlAddPet.Controls.Add(lblPetName)
        pnlAddPet.Controls.Add(lblNewAppoinment)
        pnlAddPet.Location = New Point(9, 59)
        pnlAddPet.Name = "pnlAddPet"
        pnlAddPet.Size = New Size(613, 568)
        pnlAddPet.TabIndex = 21
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(221, 292)
        txtPrice.Margin = New Padding(2, 2, 2, 2)
        txtPrice.Name = "txtPrice"
        txtPrice.ReadOnly = True
        txtPrice.Size = New Size(132, 27)
        txtPrice.TabIndex = 21
        ' 
        ' lblPrice
        ' 
        lblPrice.AutoSize = True
        lblPrice.Font = New Font("Lucida Sans Unicode", 11F)
        lblPrice.ForeColor = Color.SaddleBrown
        lblPrice.Location = New Point(59, 292)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(56, 23)
        lblPrice.TabIndex = 20
        lblPrice.Text = "Price"
        ' 
        ' txtServiceDescription
        ' 
        txtServiceDescription.Location = New Point(221, 161)
        txtServiceDescription.Margin = New Padding(2, 2, 2, 2)
        txtServiceDescription.Multiline = True
        txtServiceDescription.Name = "txtServiceDescription"
        txtServiceDescription.ReadOnly = True
        txtServiceDescription.Size = New Size(240, 116)
        txtServiceDescription.TabIndex = 19
        ' 
        ' dtpTime
        ' 
        dtpTime.CustomFormat = "hh:mm tt"
        dtpTime.Font = New Font("Segoe UI", 10F)
        dtpTime.Format = DateTimePickerFormat.Custom
        dtpTime.Location = New Point(221, 381)
        dtpTime.Name = "dtpTime"
        dtpTime.ShowUpDown = True
        dtpTime.Size = New Size(320, 30)
        dtpTime.TabIndex = 18
        ' 
        ' dtpDate
        ' 
        dtpDate.Format = DateTimePickerFormat.Short
        dtpDate.Location = New Point(221, 337)
        dtpDate.Margin = New Padding(2, 2, 2, 2)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(134, 27)
        dtpDate.TabIndex = 8
        ' 
        ' cmbPetName
        ' 
        cmbPetName.FormattingEnabled = True
        cmbPetName.Items.AddRange(New Object() {"Male", "Female", "Others"})
        cmbPetName.Location = New Point(221, 71)
        cmbPetName.Margin = New Padding(2, 2, 2, 2)
        cmbPetName.Name = "cmbPetName"
        cmbPetName.Size = New Size(132, 28)
        cmbPetName.TabIndex = 16
        ' 
        ' cmbServiceName
        ' 
        cmbServiceName.FormattingEnabled = True
        cmbServiceName.Location = New Point(221, 117)
        cmbServiceName.Margin = New Padding(2, 2, 2, 2)
        cmbServiceName.Name = "cmbServiceName"
        cmbServiceName.Size = New Size(132, 28)
        cmbServiceName.TabIndex = 15
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(244), CByte(220), CByte(204))
        btnCancel.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.SaddleBrown
        btnCancel.Location = New Point(310, 459)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(150, 45)
        btnCancel.TabIndex = 14
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnBooking
        ' 
        btnBooking.BackColor = Color.SaddleBrown
        btnBooking.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBooking.ForeColor = Color.WhiteSmoke
        btnBooking.Location = New Point(141, 459)
        btnBooking.Name = "btnBooking"
        btnBooking.Size = New Size(150, 45)
        btnBooking.TabIndex = 13
        btnBooking.Text = "Booking"
        btnBooking.UseVisualStyleBackColor = False
        ' 
        ' lblTime
        ' 
        lblTime.AutoSize = True
        lblTime.Font = New Font("Lucida Sans Unicode", 11F)
        lblTime.ForeColor = Color.SaddleBrown
        lblTime.Location = New Point(59, 386)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(57, 23)
        lblTime.TabIndex = 11
        lblTime.Text = "Time"
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.Font = New Font("Lucida Sans Unicode", 11F)
        lblDate.ForeColor = Color.SaddleBrown
        lblDate.Location = New Point(59, 341)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(53, 23)
        lblDate.TabIndex = 9
        lblDate.Text = "Date"
        ' 
        ' lblService
        ' 
        lblService.AutoSize = True
        lblService.Font = New Font("Lucida Sans Unicode", 11F)
        lblService.ForeColor = Color.SaddleBrown
        lblService.Location = New Point(59, 165)
        lblService.Name = "lblService"
        lblService.Size = New Size(190, 23)
        lblService.TabIndex = 7
        lblService.Text = "Service Description"
        ' 
        ' lblServiceName
        ' 
        lblServiceName.AutoSize = True
        lblServiceName.Font = New Font("Lucida Sans Unicode", 11F)
        lblServiceName.ForeColor = Color.SaddleBrown
        lblServiceName.Location = New Point(59, 121)
        lblServiceName.Name = "lblServiceName"
        lblServiceName.Size = New Size(136, 23)
        lblServiceName.TabIndex = 5
        lblServiceName.Text = "Service Name"
        ' 
        ' lblPetName
        ' 
        lblPetName.AutoSize = True
        lblPetName.Font = New Font("Lucida Sans Unicode", 11F)
        lblPetName.ForeColor = Color.SaddleBrown
        lblPetName.Location = New Point(59, 75)
        lblPetName.Name = "lblPetName"
        lblPetName.Size = New Size(99, 23)
        lblPetName.TabIndex = 3
        lblPetName.Text = "Pet Name"
        ' 
        ' lblNewAppoinment
        ' 
        lblNewAppoinment.AutoSize = True
        lblNewAppoinment.Font = New Font("Lucida Sans Unicode", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNewAppoinment.ForeColor = Color.SaddleBrown
        lblNewAppoinment.Location = New Point(9, 10)
        lblNewAppoinment.Name = "lblNewAppoinment"
        lblNewAppoinment.Size = New Size(217, 37)
        lblNewAppoinment.TabIndex = 0
        lblNewAppoinment.Text = "New Booking"
        ' 
        ' FrmBookingGroomingService
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(631, 629)
        Controls.Add(pnlHeader)
        Controls.Add(pnlAddPet)
        Margin = New Padding(2, 2, 2, 2)
        Name = "FrmBookingGroomingService"
        Text = "FrmBookingGroomingService"
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
    Friend WithEvents dtpTime As DateTimePicker
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents cmbService As ComboBox
    Friend WithEvents cmbPetName As ComboBox
    Friend WithEvents cmbServiceName As ComboBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnBooking As Button
    Friend WithEvents lblTime As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblService As Label
    Friend WithEvents lblServiceName As Label
    Friend WithEvents lblPetName As Label
    Friend WithEvents lblNewAppoinment As Label
    Friend WithEvents txtServiceDescription As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents lblPrice As Label
End Class
