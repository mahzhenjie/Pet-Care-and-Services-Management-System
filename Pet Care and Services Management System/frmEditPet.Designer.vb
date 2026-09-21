<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEditPet
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

        pnlEditPet = New Panel()
        btnCancel = New Button()
        btnSave = New Button()
        txtTemperament = New TextBox()
        txtWeight = New TextBox()
        txtBreed = New TextBox()
        txtGender = New TextBox()
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

        pnlEditPet.SuspendLayout()
        SuspendLayout()

        ' 
        ' pnlEditPet
        ' 
        pnlEditPet.BackColor = Color.FromArgb(CByte(232), CByte(216), CByte(194))
        pnlEditPet.Controls.Add(btnCancel)
        pnlEditPet.Controls.Add(btnSave)
        pnlEditPet.Controls.Add(txtTemperament)
        pnlEditPet.Controls.Add(txtWeight)
        pnlEditPet.Controls.Add(txtBreed)
        pnlEditPet.Controls.Add(txtGender)
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
        pnlEditPet.Location = New Point(12, 15)
        pnlEditPet.Name = "pnlEditPet"
        pnlEditPet.Size = New Size(560, 700)
        pnlEditPet.TabIndex = 0

        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Lucida Sans Unicode", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.SaddleBrown
        lblTitle.Location = New Point(30, 25)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(220, 37)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Edit Pet"

        ' 
        ' lblPetID
        ' 
        lblPetID.AutoSize = True
        lblPetID.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPetID.ForeColor = Color.SaddleBrown
        lblPetID.Location = New Point(35, 90)
        lblPetID.Name = "lblPetID"
        lblPetID.Size = New Size(56, 19)
        lblPetID.TabIndex = 1
        lblPetID.Text = "Pet ID"

        ' 
        ' txtPetID
        ' 
        txtPetID.BackColor = Color.Gainsboro
        txtPetID.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPetID.Location = New Point(190, 86)
        txtPetID.Name = "txtPetID"
        txtPetID.ReadOnly = True
        txtPetID.Size = New Size(320, 27)
        txtPetID.TabIndex = 2

        ' 
        ' lblCustomerID
        ' 
        lblCustomerID.AutoSize = True
        lblCustomerID.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCustomerID.ForeColor = Color.SaddleBrown
        lblCustomerID.Location = New Point(35, 145)
        lblCustomerID.Name = "lblCustomerID"
        lblCustomerID.Size = New Size(101, 19)
        lblCustomerID.TabIndex = 3
        lblCustomerID.Text = "Customer ID"

        ' 
        ' txtCustomerID
        ' 
        txtCustomerID.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCustomerID.Location = New Point(190, 141)
        txtCustomerID.Name = "txtCustomerID"
        txtCustomerID.Size = New Size(320, 27)
        txtCustomerID.TabIndex = 4

        ' 
        ' lblPetName
        ' 
        lblPetName.AutoSize = True
        lblPetName.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPetName.ForeColor = Color.SaddleBrown
        lblPetName.Location = New Point(35, 200)
        lblPetName.Name = "lblPetName"
        lblPetName.Size = New Size(76, 19)
        lblPetName.TabIndex = 5
        lblPetName.Text = "Pet Name"

        ' 
        ' txtPetName
        ' 
        txtPetName.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPetName.Location = New Point(190, 196)
        txtPetName.Name = "txtPetName"
        txtPetName.Size = New Size(320, 27)
        txtPetName.TabIndex = 6

        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblGender.ForeColor = Color.SaddleBrown
        lblGender.Location = New Point(35, 255)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(61, 19)
        lblGender.TabIndex = 7
        lblGender.Text = "Gender"

        ' 
        ' txtGender
        ' 
        txtGender.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtGender.Location = New Point(190, 251)
        txtGender.Name = "txtGender"
        txtGender.Size = New Size(320, 27)
        txtGender.TabIndex = 8

        ' 
        ' lblBreed
        ' 
        lblBreed.AutoSize = True
        lblBreed.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblBreed.ForeColor = Color.SaddleBrown
        lblBreed.Location = New Point(35, 310)
        lblBreed.Name = "lblBreed"
        lblBreed.Size = New Size(51, 19)
        lblBreed.TabIndex = 9
        lblBreed.Text = "Breed"

        ' 
        ' txtBreed
        ' 
        txtBreed.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBreed.Location = New Point(190, 306)
        txtBreed.Name = "txtBreed"
        txtBreed.Size = New Size(320, 27)
        txtBreed.TabIndex = 10

        ' 
        ' lblWeight
        ' 
        lblWeight.AutoSize = True
        lblWeight.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblWeight.ForeColor = Color.SaddleBrown
        lblWeight.Location = New Point(35, 365)
        lblWeight.Name = "lblWeight"
        lblWeight.Size = New Size(60, 19)
        lblWeight.TabIndex = 11
        lblWeight.Text = "Weight"

        ' 
        ' txtWeight
        ' 
        txtWeight.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtWeight.Location = New Point(190, 361)
        txtWeight.Name = "txtWeight"
        txtWeight.Size = New Size(320, 27)
        txtWeight.TabIndex = 12

        ' 
        ' lblTemperament
        ' 
        lblTemperament.AutoSize = True
        lblTemperament.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTemperament.ForeColor = Color.SaddleBrown
        lblTemperament.Location = New Point(35, 420)
        lblTemperament.Name = "lblTemperament"
        lblTemperament.Size = New Size(117, 19)
        lblTemperament.TabIndex = 13
        lblTemperament.Text = "Temperament"

        ' 
        ' txtTemperament
        ' 
        txtTemperament.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtTemperament.Location = New Point(190, 416)
        txtTemperament.Multiline = True
        txtTemperament.Name = "txtTemperament"
        txtTemperament.Size = New Size(320, 80)
        txtTemperament.TabIndex = 14

        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.SaddleBrown
        btnSave.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = Color.WhiteSmoke
        btnSave.Location = New Point(190, 545)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(150, 45)
        btnSave.TabIndex = 15
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False

        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(244), CByte(220), CByte(204))
        btnCancel.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.SaddleBrown
        btnCancel.Location = New Point(360, 545)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(150, 45)
        btnCancel.TabIndex = 16
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False

        ' 
        ' frmEditPet
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(584, 730)
        Controls.Add(pnlEditPet)
        Name = "frmEditPet"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Edit Pet"

        pnlEditPet.ResumeLayout(False)
        pnlEditPet.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlEditPet As System.Windows.Forms.Panel

    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblPetID As System.Windows.Forms.Label
    Friend WithEvents lblCustomerID As System.Windows.Forms.Label
    Friend WithEvents lblPetName As System.Windows.Forms.Label
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents lblBreed As System.Windows.Forms.Label
    Friend WithEvents lblWeight As System.Windows.Forms.Label
    Friend WithEvents lblTemperament As System.Windows.Forms.Label

    Friend WithEvents txtPetID As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerID As System.Windows.Forms.TextBox
    Friend WithEvents txtPetName As System.Windows.Forms.TextBox
    Friend WithEvents txtGender As System.Windows.Forms.TextBox
    Friend WithEvents txtBreed As System.Windows.Forms.TextBox
    Friend WithEvents txtWeight As System.Windows.Forms.TextBox
    Friend WithEvents txtTemperament As System.Windows.Forms.TextBox

    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button

End Class