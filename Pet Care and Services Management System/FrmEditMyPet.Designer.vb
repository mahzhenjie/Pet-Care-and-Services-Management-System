<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEditMyPet
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEditMyPet))
        pnlEditPet = New Panel()
        cmbGender = New ComboBox()
        btnCancel = New Button()
        btnSave = New Button()
        txtTemperament = New TextBox()
        txtWeight = New TextBox()
        txtBreed = New TextBox()
        txtPetName = New TextBox()
        txtCustomerID = New TextBox()
        txtPetID = New TextBox()
        lblTemperament = New Label()
        lblWeight = New Label()
        lblBreed = New Label()
        lblGender = New Label()
        lblPetName = New Label()
        lblCustomerID = New Label()
        lblPetID = New Label()
        lblTitle = New Label()
        Label1 = New Label()
        PictureBox2 = New PictureBox()
        pnlHeader = New Panel()
        pnlEditPet.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlEditPet
        ' 
        pnlEditPet.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlEditPet.BackColor = Color.FromArgb(CByte(245), CByte(230), CByte(209))
        pnlEditPet.Controls.Add(cmbGender)
        pnlEditPet.Controls.Add(btnCancel)
        pnlEditPet.Controls.Add(btnSave)
        pnlEditPet.Controls.Add(txtTemperament)
        pnlEditPet.Controls.Add(txtWeight)
        pnlEditPet.Controls.Add(txtBreed)
        pnlEditPet.Controls.Add(txtPetName)
        pnlEditPet.Controls.Add(txtCustomerID)
        pnlEditPet.Controls.Add(txtPetID)
        pnlEditPet.Controls.Add(lblTemperament)
        pnlEditPet.Controls.Add(lblWeight)
        pnlEditPet.Controls.Add(lblBreed)
        pnlEditPet.Controls.Add(lblGender)
        pnlEditPet.Controls.Add(lblPetName)
        pnlEditPet.Controls.Add(lblCustomerID)
        pnlEditPet.Controls.Add(lblPetID)
        pnlEditPet.Controls.Add(lblTitle)
        pnlEditPet.Location = New Point(30, 90)
        pnlEditPet.Name = "pnlEditPet"
        pnlEditPet.Size = New Size(640, 540)
        pnlEditPet.TabIndex = 1
        ' 
        ' cmbGender
        ' 
        cmbGender.DropDownStyle = ComboBoxStyle.DropDownList
        cmbGender.Font = New Font("Segoe UI", 10.0F)
        cmbGender.FormattingEnabled = True
        cmbGender.Items.AddRange(New Object() {"Male", "Female", "Others"})
        cmbGender.Location = New Point(190, 225)
        cmbGender.Name = "cmbGender"
        cmbGender.Size = New Size(400, 31)
        cmbGender.TabIndex = 17
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(244), CByte(220), CByte(204))
        btnCancel.FlatAppearance.BorderColor = Color.SaddleBrown
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnCancel.ForeColor = Color.SaddleBrown
        btnCancel.Location = New Point(400, 465)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(190, 45)
        btnCancel.TabIndex = 16
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.SaddleBrown
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnSave.ForeColor = Color.WhiteSmoke
        btnSave.Location = New Point(190, 465)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(190, 45)
        btnSave.TabIndex = 15
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' txtTemperament
        ' 
        txtTemperament.Font = New Font("Segoe UI", 10.0F)
        txtTemperament.Location = New Point(190, 350)
        txtTemperament.Multiline = True
        txtTemperament.Name = "txtTemperament"
        txtTemperament.Size = New Size(400, 80)
        txtTemperament.TabIndex = 14
        ' 
        ' txtWeight
        ' 
        txtWeight.Font = New Font("Segoe UI", 10.0F)
        txtWeight.Location = New Point(190, 300)
        txtWeight.Name = "txtWeight"
        txtWeight.Size = New Size(400, 30)
        txtWeight.TabIndex = 12
        ' 
        ' txtBreed
        ' 
        txtBreed.Font = New Font("Segoe UI", 10.0F)
        txtBreed.Location = New Point(190, 265)
        txtBreed.Name = "txtBreed"
        txtBreed.Size = New Size(400, 30)
        txtBreed.TabIndex = 10
        ' 
        ' txtPetName
        ' 
        txtPetName.Font = New Font("Segoe UI", 10.0F)
        txtPetName.Location = New Point(190, 190)
        txtPetName.Name = "txtPetName"
        txtPetName.Size = New Size(400, 30)
        txtPetName.TabIndex = 6
        ' 
        ' txtCustomerID
        ' 
        txtCustomerID.BackColor = Color.Gainsboro
        txtCustomerID.Font = New Font("Segoe UI", 10.0F)
        txtCustomerID.Location = New Point(190, 155)
        txtCustomerID.Name = "txtCustomerID"
        txtCustomerID.ReadOnly = True
        txtCustomerID.Size = New Size(400, 30)
        txtCustomerID.TabIndex = 4
        ' 
        ' txtPetID
        ' 
        txtPetID.BackColor = Color.Gainsboro
        txtPetID.Font = New Font("Segoe UI", 10.0F)
        txtPetID.Location = New Point(190, 120)
        txtPetID.Name = "txtPetID"
        txtPetID.ReadOnly = True
        txtPetID.Size = New Size(400, 30)
        txtPetID.TabIndex = 2
        ' 
        ' lblTemperament
        ' 
        lblTemperament.AutoSize = True
        lblTemperament.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblTemperament.ForeColor = Color.SaddleBrown
        lblTemperament.Location = New Point(35, 355)
        lblTemperament.Name = "lblTemperament"
        lblTemperament.Size = New Size(126, 23)
        lblTemperament.TabIndex = 13
        lblTemperament.Text = "Temperament:"
        ' 
        ' lblWeight
        ' 
        lblWeight.AutoSize = True
        lblWeight.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblWeight.ForeColor = Color.SaddleBrown
        lblWeight.Location = New Point(35, 305)
        lblWeight.Name = "lblWeight"
        lblWeight.Size = New Size(74, 23)
        lblWeight.TabIndex = 11
        lblWeight.Text = "Weight:"
        ' 
        ' lblBreed
        ' 
        lblBreed.AutoSize = True
        lblBreed.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblBreed.ForeColor = Color.SaddleBrown
        lblBreed.Location = New Point(35, 270)
        lblBreed.Name = "lblBreed"
        lblBreed.Size = New Size(62, 23)
        lblBreed.TabIndex = 9
        lblBreed.Text = "Breed:"
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblGender.ForeColor = Color.SaddleBrown
        lblGender.Location = New Point(35, 230)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(74, 23)
        lblGender.TabIndex = 7
        lblGender.Text = "Gender:"
        ' 
        ' lblPetName
        ' 
        lblPetName.AutoSize = True
        lblPetName.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblPetName.ForeColor = Color.SaddleBrown
        lblPetName.Location = New Point(35, 195)
        lblPetName.Name = "lblPetName"
        lblPetName.Size = New Size(92, 23)
        lblPetName.TabIndex = 5
        lblPetName.Text = "Pet Name:"
        ' 
        ' lblCustomerID
        ' 
        lblCustomerID.AutoSize = True
        lblCustomerID.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblCustomerID.ForeColor = Color.SaddleBrown
        lblCustomerID.Location = New Point(35, 160)
        lblCustomerID.Name = "lblCustomerID"
        lblCustomerID.Size = New Size(115, 23)
        lblCustomerID.TabIndex = 3
        lblCustomerID.Text = "Customer ID:"
        ' 
        ' lblPetID
        ' 
        lblPetID.AutoSize = True
        lblPetID.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblPetID.ForeColor = Color.SaddleBrown
        lblPetID.Location = New Point(35, 125)
        lblPetID.Name = "lblPetID"
        lblPetID.Size = New Size(63, 23)
        lblPetID.TabIndex = 1
        lblPetID.Text = "Pet ID:"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Georgia", 18.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.SaddleBrown
        lblTitle.Location = New Point(30, 30)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(138, 35)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Edit Pet"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Georgia", 20.0F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(255), CByte(243), CByte(222))
        Label1.Location = New Point(90, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(180, 39)
        Label1.TabIndex = 0
        Label1.Text = "MY PETS"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(10, 6)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(65, 53)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(55), CByte(32), CByte(20))
        pnlHeader.Controls.Add(PictureBox2)
        pnlHeader.Controls.Add(Label1)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(700, 70)
        pnlHeader.TabIndex = 17
        ' 
        ' FrmEditMyPet
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(235), CByte(221), CByte(202))
        ClientSize = New Size(700, 660)
        Controls.Add(pnlHeader)
        Controls.Add(pnlEditPet)
        MinimumSize = New Size(700, 660)
        Name = "FrmEditMyPet"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Edit Pet"
        pnlEditPet.ResumeLayout(False)
        pnlEditPet.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlEditPet As Panel
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtTemperament As TextBox
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents txtBreed As TextBox
    Friend WithEvents txtPetName As TextBox
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents txtPetID As TextBox
    Friend WithEvents lblTemperament As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents lblBreed As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblPetName As Label
    Friend WithEvents lblCustomerID As Label
    Friend WithEvents lblPetID As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents pnlHeader As Panel

End Class