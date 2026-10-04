<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditMyPet
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
        pnlEditPet.BackColor = Color.FromArgb(CByte(232), CByte(216), CByte(194))
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
        pnlEditPet.Location = New Point(0, 69)
        pnlEditPet.Margin = New Padding(4)
        pnlEditPet.Name = "pnlEditPet"
        pnlEditPet.Size = New Size(840, 958)
        pnlEditPet.TabIndex = 1
        ' 
        ' cmbGender
        ' 
        cmbGender.FormattingEnabled = True
        cmbGender.Items.AddRange(New Object() {"Male", "Female", "Others"})
        cmbGender.Location = New Point(285, 373)
        cmbGender.Name = "cmbGender"
        cmbGender.Size = New Size(269, 38)
        cmbGender.TabIndex = 17
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(244), CByte(220), CByte(204))
        btnCancel.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.SaddleBrown
        btnCancel.Location = New Point(540, 818)
        btnCancel.Margin = New Padding(4)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(225, 68)
        btnCancel.TabIndex = 16
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.SaddleBrown
        btnSave.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = Color.WhiteSmoke
        btnSave.Location = New Point(285, 818)
        btnSave.Margin = New Padding(4)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(225, 68)
        btnSave.TabIndex = 15
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' txtTemperament
        ' 
        txtTemperament.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtTemperament.Location = New Point(285, 624)
        txtTemperament.Margin = New Padding(4)
        txtTemperament.Multiline = True
        txtTemperament.Name = "txtTemperament"
        txtTemperament.Size = New Size(478, 118)
        txtTemperament.TabIndex = 14
        ' 
        ' txtWeight
        ' 
        txtWeight.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtWeight.Location = New Point(285, 542)
        txtWeight.Margin = New Padding(4)
        txtWeight.Name = "txtWeight"
        txtWeight.Size = New Size(478, 35)
        txtWeight.TabIndex = 12
        ' 
        ' txtBreed
        ' 
        txtBreed.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBreed.Location = New Point(285, 459)
        txtBreed.Margin = New Padding(4)
        txtBreed.Name = "txtBreed"
        txtBreed.Size = New Size(478, 35)
        txtBreed.TabIndex = 10
        ' 
        ' txtPetName
        ' 
        txtPetName.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPetName.Location = New Point(285, 294)
        txtPetName.Margin = New Padding(4)
        txtPetName.Name = "txtPetName"
        txtPetName.Size = New Size(478, 35)
        txtPetName.TabIndex = 6
        ' 
        ' txtCustomerID
        ' 
        txtCustomerID.BackColor = Color.Gainsboro
        txtCustomerID.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCustomerID.Location = New Point(285, 212)
        txtCustomerID.Margin = New Padding(4)
        txtCustomerID.Name = "txtCustomerID"
        txtCustomerID.ReadOnly = True
        txtCustomerID.Size = New Size(478, 35)
        txtCustomerID.TabIndex = 4
        ' 
        ' txtPetID
        ' 
        txtPetID.BackColor = Color.Gainsboro
        txtPetID.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPetID.Location = New Point(285, 129)
        txtPetID.Margin = New Padding(4)
        txtPetID.Name = "txtPetID"
        txtPetID.ReadOnly = True
        txtPetID.Size = New Size(478, 35)
        txtPetID.TabIndex = 2
        ' 
        ' lblTemperament
        ' 
        lblTemperament.AutoSize = True
        lblTemperament.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTemperament.ForeColor = Color.SaddleBrown
        lblTemperament.Location = New Point(52, 630)
        lblTemperament.Margin = New Padding(4, 0, 4, 0)
        lblTemperament.Name = "lblTemperament"
        lblTemperament.Size = New Size(131, 22)
        lblTemperament.TabIndex = 13
        lblTemperament.Text = "Temperament"
        ' 
        ' lblWeight
        ' 
        lblWeight.AutoSize = True
        lblWeight.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblWeight.ForeColor = Color.SaddleBrown
        lblWeight.Location = New Point(52, 548)
        lblWeight.Margin = New Padding(4, 0, 4, 0)
        lblWeight.Name = "lblWeight"
        lblWeight.Size = New Size(69, 22)
        lblWeight.TabIndex = 11
        lblWeight.Text = "Weight"
        ' 
        ' lblBreed
        ' 
        lblBreed.AutoSize = True
        lblBreed.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblBreed.ForeColor = Color.SaddleBrown
        lblBreed.Location = New Point(52, 465)
        lblBreed.Margin = New Padding(4, 0, 4, 0)
        lblBreed.Name = "lblBreed"
        lblBreed.Size = New Size(58, 22)
        lblBreed.TabIndex = 9
        lblBreed.Text = "Breed"
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblGender.ForeColor = Color.SaddleBrown
        lblGender.Location = New Point(52, 382)
        lblGender.Margin = New Padding(4, 0, 4, 0)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(72, 22)
        lblGender.TabIndex = 7
        lblGender.Text = "Gender"
        ' 
        ' lblPetName
        ' 
        lblPetName.AutoSize = True
        lblPetName.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPetName.ForeColor = Color.SaddleBrown
        lblPetName.Location = New Point(52, 300)
        lblPetName.Margin = New Padding(4, 0, 4, 0)
        lblPetName.Name = "lblPetName"
        lblPetName.Size = New Size(93, 22)
        lblPetName.TabIndex = 5
        lblPetName.Text = "Pet Name"
        ' 
        ' lblCustomerID
        ' 
        lblCustomerID.AutoSize = True
        lblCustomerID.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCustomerID.ForeColor = Color.SaddleBrown
        lblCustomerID.Location = New Point(52, 218)
        lblCustomerID.Margin = New Padding(4, 0, 4, 0)
        lblCustomerID.Name = "lblCustomerID"
        lblCustomerID.Size = New Size(118, 22)
        lblCustomerID.TabIndex = 3
        lblCustomerID.Text = "Customer ID"
        ' 
        ' lblPetID
        ' 
        lblPetID.AutoSize = True
        lblPetID.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPetID.ForeColor = Color.SaddleBrown
        lblPetID.Location = New Point(52, 135)
        lblPetID.Margin = New Padding(4, 0, 4, 0)
        lblPetID.Name = "lblPetID"
        lblPetID.Size = New Size(61, 22)
        lblPetID.TabIndex = 1
        lblPetID.Text = "Pet ID"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Lucida Sans Unicode", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.SaddleBrown
        lblTitle.Location = New Point(45, 38)
        lblTitle.Margin = New Padding(4, 0, 4, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(157, 44)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Edit Pet"
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
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(55), CByte(32), CByte(20))
        pnlHeader.Controls.Add(PictureBox2)
        pnlHeader.Controls.Add(Label1)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(837, 70)
        pnlHeader.TabIndex = 17
        ' 
        ' FrmEditMyPet
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(837, 1028)
        Controls.Add(pnlHeader)
        Controls.Add(pnlEditPet)
        Name = "FrmEditMyPet"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FrmEditMyPet"
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
