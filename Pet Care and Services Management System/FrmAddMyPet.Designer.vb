<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddMyPet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAddMyPet))
        pnlAddPet = New Panel()
        cmbGender = New ComboBox()
        btnCancel = New Button()
        btnSave = New Button()
        txtTemperament = New TextBox()
        txtWeight = New TextBox()
        txtBreed = New TextBox()
        txtPetName = New TextBox()
        lblTemperament = New Label()
        lblWeight = New Label()
        lblBreed = New Label()
        lblGender = New Label()
        lblPetName = New Label()
        lblTitle = New Label()
        pnlHeader = New Panel()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        pnlAddPet.SuspendLayout()
        pnlHeader.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlAddPet
        ' 
        pnlAddPet.BackColor = Color.FromArgb(CByte(232), CByte(216), CByte(194))
        pnlAddPet.Controls.Add(cmbGender)
        pnlAddPet.Controls.Add(btnCancel)
        pnlAddPet.Controls.Add(btnSave)
        pnlAddPet.Controls.Add(txtTemperament)
        pnlAddPet.Controls.Add(txtWeight)
        pnlAddPet.Controls.Add(txtBreed)
        pnlAddPet.Controls.Add(txtPetName)
        pnlAddPet.Controls.Add(lblTemperament)
        pnlAddPet.Controls.Add(lblWeight)
        pnlAddPet.Controls.Add(lblBreed)
        pnlAddPet.Controls.Add(lblGender)
        pnlAddPet.Controls.Add(lblPetName)
        pnlAddPet.Controls.Add(lblTitle)
        pnlAddPet.Location = New Point(42, 97)
        pnlAddPet.Margin = New Padding(4)
        pnlAddPet.Name = "pnlAddPet"
        pnlAddPet.Size = New Size(840, 741)
        pnlAddPet.TabIndex = 1
        ' 
        ' cmbGender
        ' 
        cmbGender.FormattingEnabled = True
        cmbGender.Items.AddRange(New Object() {"Male", "Female", "Others"})
        cmbGender.Location = New Point(285, 187)
        cmbGender.Name = "cmbGender"
        cmbGender.Size = New Size(196, 38)
        cmbGender.TabIndex = 15
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(244), CByte(220), CByte(204))
        btnCancel.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.SaddleBrown
        btnCancel.Location = New Point(538, 597)
        btnCancel.Margin = New Padding(4)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(225, 68)
        btnCancel.TabIndex = 14
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.SaddleBrown
        btnSave.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = Color.WhiteSmoke
        btnSave.Location = New Point(285, 597)
        btnSave.Margin = New Padding(4)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(225, 68)
        btnSave.TabIndex = 13
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' txtTemperament
        ' 
        txtTemperament.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtTemperament.Location = New Point(285, 392)
        txtTemperament.Margin = New Padding(4)
        txtTemperament.Multiline = True
        txtTemperament.Name = "txtTemperament"
        txtTemperament.Size = New Size(478, 118)
        txtTemperament.TabIndex = 12
        ' 
        ' txtWeight
        ' 
        txtWeight.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtWeight.Location = New Point(285, 321)
        txtWeight.Margin = New Padding(4)
        txtWeight.Name = "txtWeight"
        txtWeight.Size = New Size(478, 35)
        txtWeight.TabIndex = 10
        ' 
        ' txtBreed
        ' 
        txtBreed.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBreed.Location = New Point(285, 258)
        txtBreed.Margin = New Padding(4)
        txtBreed.Name = "txtBreed"
        txtBreed.Size = New Size(478, 35)
        txtBreed.TabIndex = 8
        ' 
        ' txtPetName
        ' 
        txtPetName.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPetName.Location = New Point(285, 125)
        txtPetName.Margin = New Padding(4)
        txtPetName.Name = "txtPetName"
        txtPetName.Size = New Size(478, 35)
        txtPetName.TabIndex = 4
        ' 
        ' lblTemperament
        ' 
        lblTemperament.AutoSize = True
        lblTemperament.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTemperament.ForeColor = Color.SaddleBrown
        lblTemperament.Location = New Point(44, 392)
        lblTemperament.Margin = New Padding(4, 0, 4, 0)
        lblTemperament.Name = "lblTemperament"
        lblTemperament.Size = New Size(131, 22)
        lblTemperament.TabIndex = 11
        lblTemperament.Text = "Temperament"
        ' 
        ' lblWeight
        ' 
        lblWeight.AutoSize = True
        lblWeight.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblWeight.ForeColor = Color.SaddleBrown
        lblWeight.Location = New Point(106, 324)
        lblWeight.Margin = New Padding(4, 0, 4, 0)
        lblWeight.Name = "lblWeight"
        lblWeight.Size = New Size(69, 22)
        lblWeight.TabIndex = 9
        lblWeight.Text = "Weight"
        ' 
        ' lblBreed
        ' 
        lblBreed.AutoSize = True
        lblBreed.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblBreed.ForeColor = Color.SaddleBrown
        lblBreed.Location = New Point(117, 261)
        lblBreed.Margin = New Padding(4, 0, 4, 0)
        lblBreed.Name = "lblBreed"
        lblBreed.Size = New Size(58, 22)
        lblBreed.TabIndex = 7
        lblBreed.Text = "Breed"
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblGender.ForeColor = Color.SaddleBrown
        lblGender.Location = New Point(103, 196)
        lblGender.Margin = New Padding(4, 0, 4, 0)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(72, 22)
        lblGender.TabIndex = 5
        lblGender.Text = "Gender"
        ' 
        ' lblPetName
        ' 
        lblPetName.AutoSize = True
        lblPetName.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPetName.ForeColor = Color.SaddleBrown
        lblPetName.Location = New Point(82, 128)
        lblPetName.Margin = New Padding(4, 0, 4, 0)
        lblPetName.Name = "lblPetName"
        lblPetName.Size = New Size(93, 22)
        lblPetName.TabIndex = 3
        lblPetName.Text = "Pet Name"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Lucida Sans Unicode", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.SaddleBrown
        lblTitle.Location = New Point(45, 38)
        lblTitle.Margin = New Padding(4, 0, 4, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(251, 44)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Add New Pet"
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(55), CByte(32), CByte(20))
        pnlHeader.Controls.Add(PictureBox2)
        pnlHeader.Controls.Add(Label1)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(923, 70)
        pnlHeader.TabIndex = 16
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Georgia", 22F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(255), CByte(243), CByte(222))
        Label1.Location = New Point(88, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(232, 51)
        Label1.TabIndex = 0
        Label1.Text = "MY PETS"
        ' 
        ' FrmAddMyPet
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(923, 862)
        Controls.Add(pnlHeader)
        Controls.Add(pnlAddPet)
        Name = "FrmAddMyPet"
        Text = "FrmAddMyPet"
        pnlAddPet.ResumeLayout(False)
        pnlAddPet.PerformLayout()
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlAddPet As Panel
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtTemperament As TextBox
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents txtBreed As TextBox
    Friend WithEvents txtPetName As TextBox
    Friend WithEvents lblTemperament As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents lblBreed As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblPetName As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbGender As ComboBox
End Class
