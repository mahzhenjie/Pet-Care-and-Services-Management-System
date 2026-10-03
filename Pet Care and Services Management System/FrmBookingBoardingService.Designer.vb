<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBookingBoardingService
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBookingBoardingService))
        pnlHeader = New Panel()
        PictureBox2 = New PictureBox()
        lblMyAppointment = New Label()
        pnlAddPet = New Panel()
        txtPrice = New TextBox()
        lblPrice = New Label()
        TextBox1 = New TextBox()
        dtpBookingTime = New DateTimePicker()
        dtpAppointmentDate = New DateTimePicker()
        cmbPet = New ComboBox()
        cmbGender = New ComboBox()
        btnCancel = New Button()
        btnBookBoarding = New Button()
        lblTime = New Label()
        lblDate = New Label()
        lblService = New Label()
        lblRoom = New Label()
        lblPetName = New Label()
        lblBookBoarding = New Label()
        Label1 = New Label()
        TextBox2 = New TextBox()
        Label2 = New Label()
        txtTotal = New TextBox()
        lblRM = New Label()
        Label3 = New Label()
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
        pnlHeader.Size = New Size(948, 70)
        pnlHeader.TabIndex = 24
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
        lblMyAppointment.Size = New Size(513, 51)
        lblMyAppointment.TabIndex = 0
        lblMyAppointment.Text = "BOARDING SERVICE"
        ' 
        ' pnlAddPet
        ' 
        pnlAddPet.BackColor = Color.FromArgb(CByte(232), CByte(216), CByte(194))
        pnlAddPet.Controls.Add(Label3)
        pnlAddPet.Controls.Add(lblRM)
        pnlAddPet.Controls.Add(txtTotal)
        pnlAddPet.Controls.Add(Label2)
        pnlAddPet.Controls.Add(TextBox2)
        pnlAddPet.Controls.Add(Label1)
        pnlAddPet.Controls.Add(txtPrice)
        pnlAddPet.Controls.Add(lblPrice)
        pnlAddPet.Controls.Add(TextBox1)
        pnlAddPet.Controls.Add(dtpBookingTime)
        pnlAddPet.Controls.Add(dtpAppointmentDate)
        pnlAddPet.Controls.Add(cmbPet)
        pnlAddPet.Controls.Add(cmbGender)
        pnlAddPet.Controls.Add(btnCancel)
        pnlAddPet.Controls.Add(btnBookBoarding)
        pnlAddPet.Controls.Add(lblTime)
        pnlAddPet.Controls.Add(lblDate)
        pnlAddPet.Controls.Add(lblService)
        pnlAddPet.Controls.Add(lblRoom)
        pnlAddPet.Controls.Add(lblPetName)
        pnlAddPet.Controls.Add(lblBookBoarding)
        pnlAddPet.Location = New Point(13, 60)
        pnlAddPet.Margin = New Padding(4)
        pnlAddPet.Name = "pnlAddPet"
        pnlAddPet.Size = New Size(920, 933)
        pnlAddPet.TabIndex = 23
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(384, 654)
        txtPrice.Name = "txtPrice"
        txtPrice.ReadOnly = True
        txtPrice.Size = New Size(196, 35)
        txtPrice.TabIndex = 21
        ' 
        ' lblPrice
        ' 
        lblPrice.AutoSize = True
        lblPrice.Font = New Font("Lucida Sans Unicode", 11F)
        lblPrice.ForeColor = Color.SaddleBrown
        lblPrice.Location = New Point(88, 654)
        lblPrice.Margin = New Padding(4, 0, 4, 0)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(128, 27)
        lblPrice.TabIndex = 20
        lblPrice.Text = "Price / Day"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(332, 305)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(358, 172)
        TextBox1.TabIndex = 19
        ' 
        ' dtpBookingTime
        ' 
        dtpBookingTime.CustomFormat = "hh:mm tt"
        dtpBookingTime.Font = New Font("Segoe UI", 10F)
        dtpBookingTime.Format = DateTimePickerFormat.Custom
        dtpBookingTime.Location = New Point(332, 583)
        dtpBookingTime.Margin = New Padding(4)
        dtpBookingTime.Name = "dtpBookingTime"
        dtpBookingTime.ShowUpDown = True
        dtpBookingTime.Size = New Size(478, 34)
        dtpBookingTime.TabIndex = 18
        ' 
        ' dtpAppointmentDate
        ' 
        dtpAppointmentDate.Format = DateTimePickerFormat.Short
        dtpAppointmentDate.Location = New Point(332, 516)
        dtpAppointmentDate.Name = "dtpAppointmentDate"
        dtpAppointmentDate.Size = New Size(199, 35)
        dtpAppointmentDate.TabIndex = 8
        ' 
        ' cmbPet
        ' 
        cmbPet.FormattingEnabled = True
        cmbPet.Items.AddRange(New Object() {"Male", "Female", "Others"})
        cmbPet.Location = New Point(332, 107)
        cmbPet.Name = "cmbPet"
        cmbPet.Size = New Size(196, 38)
        cmbPet.TabIndex = 16
        ' 
        ' cmbGender
        ' 
        cmbGender.FormattingEnabled = True
        cmbGender.Location = New Point(332, 176)
        cmbGender.Name = "cmbGender"
        cmbGender.Size = New Size(196, 38)
        cmbGender.TabIndex = 15
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(244), CByte(220), CByte(204))
        btnCancel.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.SaddleBrown
        btnCancel.Location = New Point(465, 817)
        btnCancel.Margin = New Padding(4)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(225, 68)
        btnCancel.TabIndex = 14
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnBookBoarding
        ' 
        btnBookBoarding.BackColor = Color.SaddleBrown
        btnBookBoarding.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBookBoarding.ForeColor = Color.WhiteSmoke
        btnBookBoarding.Location = New Point(212, 817)
        btnBookBoarding.Margin = New Padding(4)
        btnBookBoarding.Name = "btnBookBoarding"
        btnBookBoarding.Size = New Size(225, 68)
        btnBookBoarding.TabIndex = 13
        btnBookBoarding.Text = "Book Boarding"
        btnBookBoarding.UseVisualStyleBackColor = False
        ' 
        ' lblTime
        ' 
        lblTime.AutoSize = True
        lblTime.Font = New Font("Lucida Sans Unicode", 11F)
        lblTime.ForeColor = Color.SaddleBrown
        lblTime.Location = New Point(88, 590)
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
        lblDate.Location = New Point(88, 522)
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
        lblService.Location = New Point(88, 310)
        lblService.Margin = New Padding(4, 0, 4, 0)
        lblService.Name = "lblService"
        lblService.Size = New Size(203, 27)
        lblService.TabIndex = 7
        lblService.Text = "Room Description"
        ' 
        ' lblRoom
        ' 
        lblRoom.AutoSize = True
        lblRoom.Font = New Font("Lucida Sans Unicode", 11F)
        lblRoom.ForeColor = Color.SaddleBrown
        lblRoom.Location = New Point(88, 181)
        lblRoom.Margin = New Padding(4, 0, 4, 0)
        lblRoom.Name = "lblRoom"
        lblRoom.Size = New Size(75, 27)
        lblRoom.TabIndex = 5
        lblRoom.Text = "Room"
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
        ' lblBookBoarding
        ' 
        lblBookBoarding.AutoSize = True
        lblBookBoarding.Font = New Font("Lucida Sans Unicode", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBookBoarding.ForeColor = Color.SaddleBrown
        lblBookBoarding.Location = New Point(14, 15)
        lblBookBoarding.Margin = New Padding(4, 0, 4, 0)
        lblBookBoarding.Name = "lblBookBoarding"
        lblBookBoarding.Size = New Size(424, 44)
        lblBookBoarding.TabIndex = 0
        lblBookBoarding.Text = "Book Boarding Service"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Lucida Sans Unicode", 11F)
        Label1.ForeColor = Color.SaddleBrown
        Label1.Location = New Point(88, 245)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(134, 27)
        Label1.TabIndex = 22
        Label1.Text = "Room Type"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(332, 240)
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(196, 35)
        TextBox2.TabIndex = 23
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Lucida Sans Unicode", 11F)
        Label2.ForeColor = Color.SaddleBrown
        Label2.Location = New Point(88, 725)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 27)
        Label2.TabIndex = 24
        Label2.Text = "Total"
        ' 
        ' txtTotal
        ' 
        txtTotal.Location = New Point(384, 720)
        txtTotal.Name = "txtTotal"
        txtTotal.ReadOnly = True
        txtTotal.Size = New Size(196, 35)
        txtTotal.TabIndex = 25
        ' 
        ' lblRM
        ' 
        lblRM.AutoSize = True
        lblRM.Font = New Font("Lucida Sans Unicode", 11F)
        lblRM.ForeColor = Color.SaddleBrown
        lblRM.Location = New Point(332, 659)
        lblRM.Margin = New Padding(4, 0, 4, 0)
        lblRM.Name = "lblRM"
        lblRM.Size = New Size(45, 27)
        lblRM.TabIndex = 26
        lblRM.Text = "RM"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Lucida Sans Unicode", 11F)
        Label3.ForeColor = Color.SaddleBrown
        Label3.Location = New Point(332, 722)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(45, 27)
        Label3.TabIndex = 27
        Label3.Text = "RM"
        ' 
        ' FrmBookingBoardingService
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(948, 1006)
        Controls.Add(pnlHeader)
        Controls.Add(pnlAddPet)
        Name = "FrmBookingBoardingService"
        Text = "FrmBookingBoardingService"
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
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents dtpBookingTime As DateTimePicker
    Friend WithEvents dtpAppointmentDate As DateTimePicker
    Friend WithEvents cmbPet As ComboBox
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnBookBoarding As Button
    Friend WithEvents lblTime As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblService As Label
    Friend WithEvents lblRoom As Label
    Friend WithEvents lblPetName As Label
    Friend WithEvents lblBookBoarding As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblRM As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label2 As Label
End Class
