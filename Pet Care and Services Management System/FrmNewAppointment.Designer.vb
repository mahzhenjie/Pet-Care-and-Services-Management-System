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
        txtDescription = New TextBox()
        Label1 = New Label()
        dtpTime = New DateTimePicker()
        dtpDate = New DateTimePicker()
        cmbService = New ComboBox()
        cmbPetName = New ComboBox()
        cmbServiceType = New ComboBox()
        btnCancel = New Button()
        btnBookAppointment = New Button()
        lblTime = New Label()
        lblDate = New Label()
        lblService = New Label()
        lblServiceType = New Label()
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
        pnlHeader.Size = New Size(591, 56)
        pnlHeader.TabIndex = 18
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(2, 11)
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
        lblMyAppointment.Size = New Size(397, 43)
        lblMyAppointment.TabIndex = 0
        lblMyAppointment.Text = "MY APPOINTMENT"
        ' 
        ' pnlAddPet
        ' 
        pnlAddPet.BackColor = Color.FromArgb(CByte(232), CByte(216), CByte(194))
        pnlAddPet.Controls.Add(txtDescription)
        pnlAddPet.Controls.Add(Label1)
        pnlAddPet.Controls.Add(dtpTime)
        pnlAddPet.Controls.Add(dtpDate)
        pnlAddPet.Controls.Add(cmbService)
        pnlAddPet.Controls.Add(cmbPetName)
        pnlAddPet.Controls.Add(cmbServiceType)
        pnlAddPet.Controls.Add(btnCancel)
        pnlAddPet.Controls.Add(btnBookAppointment)
        pnlAddPet.Controls.Add(lblTime)
        pnlAddPet.Controls.Add(lblDate)
        pnlAddPet.Controls.Add(lblService)
        pnlAddPet.Controls.Add(lblServiceType)
        pnlAddPet.Controls.Add(lblPetName)
        pnlAddPet.Controls.Add(lblNewAppoinment)
        pnlAddPet.Location = New Point(16, 61)
        pnlAddPet.Name = "pnlAddPet"
        pnlAddPet.Size = New Size(560, 482)
        pnlAddPet.TabIndex = 17
        ' 
        ' txtDescription
        ' 
        txtDescription.Location = New Point(187, 209)
        txtDescription.Margin = New Padding(2, 2, 2, 2)
        txtDescription.Multiline = True
        txtDescription.Name = "txtDescription"
        txtDescription.ReadOnly = True
        txtDescription.Size = New Size(317, 69)
        txtDescription.TabIndex = 20
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Lucida Sans Unicode", 11F)
        Label1.ForeColor = Color.SaddleBrown
        Label1.Location = New Point(59, 209)
        Label1.Name = "Label1"
        Label1.Size = New Size(118, 23)
        Label1.TabIndex = 19
        Label1.Text = "Description"
        ' 
        ' dtpTime
        ' 
        dtpTime.CustomFormat = "hh:mm tt"
        dtpTime.Font = New Font("Segoe UI", 10F)
        dtpTime.Format = DateTimePickerFormat.Custom
        dtpTime.Location = New Point(187, 341)
        dtpTime.Name = "dtpTime"
        dtpTime.ShowUpDown = True
        dtpTime.Size = New Size(320, 30)
        dtpTime.TabIndex = 18
        ' 
        ' dtpDate
        ' 
        dtpDate.Format = DateTimePickerFormat.Short
        dtpDate.Location = New Point(187, 299)
        dtpDate.Margin = New Padding(2, 2, 2, 2)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(134, 27)
        dtpDate.TabIndex = 8
        ' 
        ' cmbService
        ' 
        cmbService.FormattingEnabled = True
        cmbService.Location = New Point(189, 161)
        cmbService.Margin = New Padding(2, 2, 2, 2)
        cmbService.Name = "cmbService"
        cmbService.Size = New Size(132, 28)
        cmbService.TabIndex = 17
        ' 
        ' cmbPetName
        ' 
        cmbPetName.FormattingEnabled = True
        cmbPetName.Location = New Point(189, 71)
        cmbPetName.Margin = New Padding(2, 2, 2, 2)
        cmbPetName.Name = "cmbPetName"
        cmbPetName.Size = New Size(132, 28)
        cmbPetName.TabIndex = 16
        ' 
        ' cmbServiceType
        ' 
        cmbServiceType.FormattingEnabled = True
        cmbServiceType.Location = New Point(189, 117)
        cmbServiceType.Margin = New Padding(2, 2, 2, 2)
        cmbServiceType.Name = "cmbServiceType"
        cmbServiceType.Size = New Size(132, 28)
        cmbServiceType.TabIndex = 15
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(244), CByte(220), CByte(204))
        btnCancel.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.SaddleBrown
        btnCancel.Location = New Point(287, 413)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(150, 45)
        btnCancel.TabIndex = 14
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnBookAppointment
        ' 
        btnBookAppointment.BackColor = Color.SaddleBrown
        btnBookAppointment.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBookAppointment.ForeColor = Color.WhiteSmoke
        btnBookAppointment.Location = New Point(119, 413)
        btnBookAppointment.Name = "btnBookAppointment"
        btnBookAppointment.Size = New Size(150, 45)
        btnBookAppointment.TabIndex = 13
        btnBookAppointment.Text = "Book Appointment"
        btnBookAppointment.UseVisualStyleBackColor = False
        ' 
        ' lblTime
        ' 
        lblTime.AutoSize = True
        lblTime.Font = New Font("Lucida Sans Unicode", 11F)
        lblTime.ForeColor = Color.SaddleBrown
        lblTime.Location = New Point(59, 345)
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
        lblDate.Location = New Point(59, 303)
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
        lblService.Size = New Size(76, 23)
        lblService.TabIndex = 7
        lblService.Text = "Service"
        ' 
        ' lblServiceType
        ' 
        lblServiceType.AutoSize = True
        lblServiceType.Font = New Font("Lucida Sans Unicode", 11F)
        lblServiceType.ForeColor = Color.SaddleBrown
        lblServiceType.Location = New Point(59, 121)
        lblServiceType.Name = "lblServiceType"
        lblServiceType.Size = New Size(127, 23)
        lblServiceType.TabIndex = 5
        lblServiceType.Text = "Service Type"
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
        lblNewAppoinment.Size = New Size(282, 37)
        lblNewAppoinment.TabIndex = 0
        lblNewAppoinment.Text = "New Appoinment"
        ' 
        ' FrmNewAppointment
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(591, 559)
        Controls.Add(pnlHeader)
        Controls.Add(pnlAddPet)
        Margin = New Padding(2, 2, 2, 2)
        Name = "FrmNewAppointment"
        Text = "Add New Appointment"
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
    Friend WithEvents cmbPetName As ComboBox
    Friend WithEvents cmbServiceType As ComboBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnBookAppointment As Button
    Friend WithEvents lblTime As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblService As Label
    Friend WithEvents lblServiceType As Label
    Friend WithEvents lblPetName As Label
    Friend WithEvents lblNewAppoinment As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents dtpTime As DateTimePicker
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label1 As Label
End Class
