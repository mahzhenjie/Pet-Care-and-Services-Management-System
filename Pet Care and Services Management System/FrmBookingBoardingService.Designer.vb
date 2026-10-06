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
        dtpEndDate = New DateTimePicker()
        lblEndDate = New Label()
        Label3 = New Label()
        lblRM = New Label()
        txtTotal = New TextBox()
        Label2 = New Label()
        txtRoomType = New TextBox()
        Label1 = New Label()
        txtPricePerDay = New TextBox()
        lblPrice = New Label()
        txtRoomDescription = New TextBox()
        dtpTime = New DateTimePicker()
        dtpStartDate = New DateTimePicker()
        cmbPetName = New ComboBox()
        cmbRoom = New ComboBox()
        btnCancel = New Button()
        btnBookBoarding = New Button()
        lblTime = New Label()
        lblStartDate = New Label()
        lblService = New Label()
        lblRoom = New Label()
        lblPetName = New Label()
        lblBookBoarding = New Label()
        pnlHeader.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        pnlAddPet.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(55), CByte(32), CByte(10))
        pnlHeader.Controls.Add(PictureBox2)
        pnlHeader.Controls.Add(lblMyAppointment)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Margin = New Padding(2)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(632, 54)
        pnlHeader.TabIndex = 24
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(2, 6)
        PictureBox2.Margin = New Padding(2)
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
        lblMyAppointment.Size = New Size(432, 43)
        lblMyAppointment.TabIndex = 0
        lblMyAppointment.Text = "BOARDING SERVICE"
        ' 
        ' pnlAddPet
        ' 
        pnlAddPet.BackColor = Color.FromArgb(CByte(232), CByte(216), CByte(194))
        pnlAddPet.Controls.Add(dtpEndDate)
        pnlAddPet.Controls.Add(lblEndDate)
        pnlAddPet.Controls.Add(Label3)
        pnlAddPet.Controls.Add(lblRM)
        pnlAddPet.Controls.Add(txtTotal)
        pnlAddPet.Controls.Add(Label2)
        pnlAddPet.Controls.Add(txtRoomType)
        pnlAddPet.Controls.Add(Label1)
        pnlAddPet.Controls.Add(txtPricePerDay)
        pnlAddPet.Controls.Add(lblPrice)
        pnlAddPet.Controls.Add(txtRoomDescription)
        pnlAddPet.Controls.Add(dtpTime)
        pnlAddPet.Controls.Add(dtpStartDate)
        pnlAddPet.Controls.Add(cmbPetName)
        pnlAddPet.Controls.Add(cmbRoom)
        pnlAddPet.Controls.Add(btnCancel)
        pnlAddPet.Controls.Add(btnBookBoarding)
        pnlAddPet.Controls.Add(lblTime)
        pnlAddPet.Controls.Add(lblStartDate)
        pnlAddPet.Controls.Add(lblService)
        pnlAddPet.Controls.Add(lblRoom)
        pnlAddPet.Controls.Add(lblPetName)
        pnlAddPet.Controls.Add(lblBookBoarding)
        pnlAddPet.Location = New Point(10, 59)
        pnlAddPet.Name = "pnlAddPet"
        pnlAddPet.Size = New Size(613, 661)
        pnlAddPet.TabIndex = 23
        ' 
        ' dtpEndDate
        ' 
        dtpEndDate.Format = DateTimePickerFormat.Short
        dtpEndDate.Location = New Point(262, 387)
        dtpEndDate.Margin = New Padding(2)
        dtpEndDate.Name = "dtpEndDate"
        dtpEndDate.Size = New Size(134, 27)
        dtpEndDate.TabIndex = 29
        ' 
        ' lblEndDate
        ' 
        lblEndDate.AutoSize = True
        lblEndDate.Font = New Font("Lucida Sans Unicode", 11F)
        lblEndDate.ForeColor = Color.SaddleBrown
        lblEndDate.Location = New Point(59, 388)
        lblEndDate.Name = "lblEndDate"
        lblEndDate.Size = New Size(53, 23)
        lblEndDate.TabIndex = 28
        lblEndDate.Text = "Date"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Lucida Sans Unicode", 11F)
        Label3.ForeColor = Color.SaddleBrown
        Label3.Location = New Point(262, 528)
        Label3.Name = "Label3"
        Label3.Size = New Size(38, 23)
        Label3.TabIndex = 27
        Label3.Text = "RM"
        ' 
        ' lblRM
        ' 
        lblRM.AutoSize = True
        lblRM.Font = New Font("Lucida Sans Unicode", 11F)
        lblRM.ForeColor = Color.SaddleBrown
        lblRM.Location = New Point(262, 486)
        lblRM.Name = "lblRM"
        lblRM.Size = New Size(38, 23)
        lblRM.TabIndex = 26
        lblRM.Text = "RM"
        ' 
        ' txtTotal
        ' 
        txtTotal.Location = New Point(297, 527)
        txtTotal.Margin = New Padding(2)
        txtTotal.Name = "txtTotal"
        txtTotal.ReadOnly = True
        txtTotal.Size = New Size(132, 27)
        txtTotal.TabIndex = 25
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Lucida Sans Unicode", 11F)
        Label2.ForeColor = Color.SaddleBrown
        Label2.Location = New Point(59, 527)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 23)
        Label2.TabIndex = 24
        Label2.Text = "Total"
        ' 
        ' txtRoomType
        ' 
        txtRoomType.Location = New Point(262, 163)
        txtRoomType.Margin = New Padding(2)
        txtRoomType.Name = "txtRoomType"
        txtRoomType.ReadOnly = True
        txtRoomType.Size = New Size(132, 27)
        txtRoomType.TabIndex = 23
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Lucida Sans Unicode", 11F)
        Label1.ForeColor = Color.SaddleBrown
        Label1.Location = New Point(59, 163)
        Label1.Name = "Label1"
        Label1.Size = New Size(115, 23)
        Label1.TabIndex = 22
        Label1.Text = "Room Type"
        ' 
        ' txtPricePerDay
        ' 
        txtPricePerDay.Location = New Point(297, 483)
        txtPricePerDay.Margin = New Padding(2)
        txtPricePerDay.Name = "txtPricePerDay"
        txtPricePerDay.ReadOnly = True
        txtPricePerDay.Size = New Size(132, 27)
        txtPricePerDay.TabIndex = 21
        ' 
        ' lblPrice
        ' 
        lblPrice.AutoSize = True
        lblPrice.Font = New Font("Lucida Sans Unicode", 11F)
        lblPrice.ForeColor = Color.SaddleBrown
        lblPrice.Location = New Point(59, 480)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(113, 23)
        lblPrice.TabIndex = 20
        lblPrice.Text = "Price / Day"
        ' 
        ' txtRoomDescription
        ' 
        txtRoomDescription.Location = New Point(262, 206)
        txtRoomDescription.Margin = New Padding(2)
        txtRoomDescription.Multiline = True
        txtRoomDescription.Name = "txtRoomDescription"
        txtRoomDescription.Size = New Size(240, 116)
        txtRoomDescription.TabIndex = 19
        ' 
        ' dtpTime
        ' 
        dtpTime.CustomFormat = "hh:mm tt"
        dtpTime.Font = New Font("Segoe UI", 10F)
        dtpTime.Format = DateTimePickerFormat.Custom
        dtpTime.Location = New Point(262, 436)
        dtpTime.Name = "dtpTime"
        dtpTime.ShowUpDown = True
        dtpTime.Size = New Size(320, 30)
        dtpTime.TabIndex = 18
        ' 
        ' dtpStartDate
        ' 
        dtpStartDate.Format = DateTimePickerFormat.Short
        dtpStartDate.Location = New Point(262, 342)
        dtpStartDate.Margin = New Padding(2)
        dtpStartDate.Name = "dtpStartDate"
        dtpStartDate.Size = New Size(134, 27)
        dtpStartDate.TabIndex = 8
        ' 
        ' cmbPetName
        ' 
        cmbPetName.FormattingEnabled = True
        cmbPetName.Items.AddRange(New Object() {"Male", "Female", "Others"})
        cmbPetName.Location = New Point(262, 74)
        cmbPetName.Margin = New Padding(2)
        cmbPetName.Name = "cmbPetName"
        cmbPetName.Size = New Size(132, 28)
        cmbPetName.TabIndex = 16
        ' 
        ' cmbRoom
        ' 
        cmbRoom.FormattingEnabled = True
        cmbRoom.Location = New Point(262, 120)
        cmbRoom.Margin = New Padding(2)
        cmbRoom.Name = "cmbRoom"
        cmbRoom.Size = New Size(132, 28)
        cmbRoom.TabIndex = 15
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(244), CByte(220), CByte(204))
        btnCancel.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.SaddleBrown
        btnCancel.Location = New Point(310, 589)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(150, 45)
        btnCancel.TabIndex = 14
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnBookBoarding
        ' 
        btnBookBoarding.BackColor = Color.SaddleBrown
        btnBookBoarding.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBookBoarding.ForeColor = Color.WhiteSmoke
        btnBookBoarding.Location = New Point(141, 589)
        btnBookBoarding.Name = "btnBookBoarding"
        btnBookBoarding.Size = New Size(150, 45)
        btnBookBoarding.TabIndex = 13
        btnBookBoarding.Text = "Book Boarding"
        btnBookBoarding.UseVisualStyleBackColor = False
        ' 
        ' lblTime
        ' 
        lblTime.AutoSize = True
        lblTime.Font = New Font("Lucida Sans Unicode", 11F)
        lblTime.ForeColor = Color.SaddleBrown
        lblTime.Location = New Point(59, 437)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(57, 23)
        lblTime.TabIndex = 11
        lblTime.Text = "Time"
        ' 
        ' lblStartDate
        ' 
        lblStartDate.AutoSize = True
        lblStartDate.Font = New Font("Lucida Sans Unicode", 11F)
        lblStartDate.ForeColor = Color.SaddleBrown
        lblStartDate.Location = New Point(59, 343)
        lblStartDate.Name = "lblStartDate"
        lblStartDate.Size = New Size(53, 23)
        lblStartDate.TabIndex = 9
        lblStartDate.Text = "Date"
        ' 
        ' lblService
        ' 
        lblService.AutoSize = True
        lblService.Font = New Font("Lucida Sans Unicode", 11F)
        lblService.ForeColor = Color.SaddleBrown
        lblService.Location = New Point(59, 207)
        lblService.Name = "lblService"
        lblService.Size = New Size(178, 23)
        lblService.TabIndex = 7
        lblService.Text = "Room Description"
        ' 
        ' lblRoom
        ' 
        lblRoom.AutoSize = True
        lblRoom.Font = New Font("Lucida Sans Unicode", 11F)
        lblRoom.ForeColor = Color.SaddleBrown
        lblRoom.Location = New Point(59, 121)
        lblRoom.Name = "lblRoom"
        lblRoom.Size = New Size(64, 23)
        lblRoom.TabIndex = 5
        lblRoom.Text = "Room"
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
        ' lblBookBoarding
        ' 
        lblBookBoarding.AutoSize = True
        lblBookBoarding.Font = New Font("Lucida Sans Unicode", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBookBoarding.ForeColor = Color.SaddleBrown
        lblBookBoarding.Location = New Point(9, 21)
        lblBookBoarding.Name = "lblBookBoarding"
        lblBookBoarding.Size = New Size(359, 37)
        lblBookBoarding.TabIndex = 0
        lblBookBoarding.Text = "Book Boarding Service"
        ' 
        ' FrmBookingBoardingService
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Bisque
        ClientSize = New Size(632, 729)
        Controls.Add(pnlHeader)
        Controls.Add(pnlAddPet)
        Margin = New Padding(2)
        Name = "FrmBookingBoardingService"
        Text = "Booking Boarding Service"
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
    Friend WithEvents txtRoomType As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPricePerDay As TextBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents txtRoomDescription As TextBox
    Friend WithEvents dtpTime As DateTimePicker
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents cmbPetName As ComboBox
    Friend WithEvents cmbRoom As ComboBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnBookBoarding As Button
    Friend WithEvents lblTime As Label
    Friend WithEvents lblStartDate As Label
    Friend WithEvents lblService As Label
    Friend WithEvents lblRoom As Label
    Friend WithEvents lblPetName As Label
    Friend WithEvents lblBookBoarding As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblRM As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents lblEndDate As Label
End Class
