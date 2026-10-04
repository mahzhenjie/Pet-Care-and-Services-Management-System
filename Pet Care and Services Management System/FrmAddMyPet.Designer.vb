<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAddMyPet
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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

    'NOTE: The following procedure is required by the Windows Form Designer.
    'It can be modified using the code editor.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
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
        pnlAddPet.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlAddPet.BackColor = Color.FromArgb(245, 230, 209)
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
        pnlAddPet.Location = New Point(40, 90)
        pnlAddPet.Name = "pnlAddPet"
        pnlAddPet.Padding = New Padding(20)
        pnlAddPet.Size = New Size(770, 660)
        pnlAddPet.TabIndex = 1
        ' 
        ' cmbGender
        ' 
        cmbGender.BackColor = Color.White
        cmbGender.DropDownStyle = ComboBoxStyle.DropDownList
        cmbGender.Font = New Font("Segoe UI", 10.0F)
        cmbGender.ForeColor = Color.FromArgb(61, 40, 27)
        cmbGender.FormattingEnabled = True
        cmbGender.Items.AddRange(New Object() {"Male", "Female", "Others"})
        cmbGender.Location = New Point(220, 175)
        cmbGender.Name = "cmbGender"
        cmbGender.Size = New Size(420, 31)
        cmbGender.TabIndex = 15
        ' 
        ' btnCancel
        ' 
        btnCancel.Anchor = AnchorStyles.Bottom
        btnCancel.BackColor = Color.FromArgb(244, 220, 204)
        btnCancel.FlatAppearance.BorderColor = Color.Sienna
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnCancel.ForeColor = Color.SaddleBrown
        btnCancel.Location = New Point(425, 570)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(180, 48)
        btnCancel.TabIndex = 14
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.Anchor = AnchorStyles.Bottom
        btnSave.BackColor = Color.SaddleBrown
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnSave.ForeColor = Color.WhiteSmoke
        btnSave.Location = New Point(220, 570)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(180, 48)
        btnSave.TabIndex = 13
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' txtTemperament
        ' 
        txtTemperament.BackColor = Color.White
        txtTemperament.BorderStyle = BorderStyle.FixedSingle
        txtTemperament.Font = New Font("Segoe UI", 10.0F)
        txtTemperament.ForeColor = Color.FromArgb(61, 40, 27)
        txtTemperament.Location = New Point(220, 370)
        txtTemperament.Multiline = True
        txtTemperament.Name = "txtTemperament"
        txtTemperament.Size = New Size(420, 100)
        txtTemperament.TabIndex = 12
        ' 
        ' txtWeight
        ' 
        txtWeight.BackColor = Color.White
        txtWeight.BorderStyle = BorderStyle.FixedSingle
        txtWeight.Font = New Font("Segoe UI", 10.0F)
        txtWeight.ForeColor = Color.FromArgb(61, 40, 27)
        txtWeight.Location = New Point(220, 305)
        txtWeight.Name = "txtWeight"
        txtWeight.Size = New Size(420, 30)
        txtWeight.TabIndex = 10
        ' 
        ' txtBreed
        ' 
        txtBreed.BackColor = Color.White
        txtBreed.BorderStyle = BorderStyle.FixedSingle
        txtBreed.Font = New Font("Segoe UI", 10.0F)
        txtBreed.ForeColor = Color.FromArgb(61, 40, 27)
        txtBreed.Location = New Point(220, 240)
        txtBreed.Name = "txtBreed"
        txtBreed.Size = New Size(420, 30)
        txtBreed.TabIndex = 8
        ' 
        ' txtPetName
        ' 
        txtPetName.BackColor = Color.White
        txtPetName.BorderStyle = BorderStyle.FixedSingle
        txtPetName.Font = New Font("Segoe UI", 10.0F)
        txtPetName.ForeColor = Color.FromArgb(61, 40, 27)
        txtPetName.Location = New Point(220, 110)
        txtPetName.Name = "txtPetName"
        txtPetName.Size = New Size(420, 30)
        txtPetName.TabIndex = 4
        ' 
        ' lblTemperament
        ' 
        lblTemperament.AutoSize = True
        lblTemperament.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblTemperament.ForeColor = Color.FromArgb(61, 40, 27)
        lblTemperament.Location = New Point(70, 370)
        lblTemperament.Name = "lblTemperament"
        lblTemperament.Size = New Size(112, 23)
        lblTemperament.TabIndex = 11
        lblTemperament.Text = "Temperament:"
        ' 
        ' lblWeight
        ' 
        lblWeight.AutoSize = True
        lblWeight.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblWeight.ForeColor = Color.FromArgb(61, 40, 27)
        lblWeight.Location = New Point(105, 308)
        lblWeight.Name = "lblWeight"
        lblWeight.Size = New Size(74, 23)
        lblWeight.TabIndex = 9
        lblWeight.Text = "Weight:"
        ' 
        ' lblBreed
        ' 
        lblBreed.AutoSize = True
        lblBreed.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblBreed.ForeColor = Color.FromArgb(61, 40, 27)
        lblBreed.Location = New Point(117, 243)
        lblBreed.Name = "lblBreed"
        lblBreed.Size = New Size(62, 23)
        lblBreed.TabIndex = 7
        lblBreed.Text = "Breed:"
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblGender.ForeColor = Color.FromArgb(61, 40, 27)
        lblGender.Location = New Point(105, 178)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(74, 23)
        lblGender.TabIndex = 5
        lblGender.Text = "Gender:"
        ' 
        ' lblPetName
        ' 
        lblPetName.AutoSize = True
        lblPetName.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblPetName.ForeColor = Color.FromArgb(61, 40, 27)
        lblPetName.Location = New Point(82, 113)
        lblPetName.Name = "lblPetName"
        lblPetName.Size = New Size(97, 23)
        lblPetName.TabIndex = 3
        lblPetName.Text = "Pet Name:"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Georgia", 20.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(61, 40, 27)
        lblTitle.Location = New Point(30, 30)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(241, 39)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Add New Pet"
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(96, 52, 16)
        pnlHeader.Controls.Add(PictureBox2)
        pnlHeader.Controls.Add(Label1)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(850, 65)
        pnlHeader.TabIndex = 16
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(18, 7)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(60, 50)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Georgia", 20.0F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(255, 243, 222)
        Label1.Location = New Point(90, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(180, 38)
        Label1.TabIndex = 0
        Label1.Text = "MY PETS"
        ' 
        ' FrmAddMyPet
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(235, 221, 202)
        ClientSize = New Size(850, 780)
        Controls.Add(pnlHeader)
        Controls.Add(pnlAddPet)
        MinimumSize = New Size(850, 780)
        Name = "FrmAddMyPet"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add New Pet"
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