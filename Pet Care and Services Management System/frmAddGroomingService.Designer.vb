<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddGroomingService
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pnlMain = New Panel()
        btnCancel = New Button()
        btnSave = New Button()
        btnBrowse = New Button()
        picServicePhoto = New PictureBox()
        txtDuration = New TextBox()
        txtPrice = New TextBox()
        txtDescription = New TextBox()
        txtServiceName = New TextBox()
        lblPhoto = New Label()
        lblDuration = New Label()
        lblPrice = New Label()
        lblDescription = New Label()
        lblServiceName = New Label()
        lblTitle = New Label()
        pnlMain.SuspendLayout()
        CType(picServicePhoto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlMain
        ' 
        pnlMain.BackColor = Color.FromArgb(CByte(247), CByte(232), CByte(213))
        pnlMain.Controls.Add(btnCancel)
        pnlMain.Controls.Add(btnSave)
        pnlMain.Controls.Add(btnBrowse)
        pnlMain.Controls.Add(picServicePhoto)
        pnlMain.Controls.Add(txtDuration)
        pnlMain.Controls.Add(txtPrice)
        pnlMain.Controls.Add(txtDescription)
        pnlMain.Controls.Add(txtServiceName)
        pnlMain.Controls.Add(lblPhoto)
        pnlMain.Controls.Add(lblDuration)
        pnlMain.Controls.Add(lblPrice)
        pnlMain.Controls.Add(lblDescription)
        pnlMain.Controls.Add(lblServiceName)
        pnlMain.Controls.Add(lblTitle)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(0, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(700, 620)
        pnlMain.TabIndex = 0
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.SaddleBrown
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Lucida Sans Unicode", 10.0F, FontStyle.Bold)
        btnCancel.ForeColor = Color.WhiteSmoke
        btnCancel.Location = New Point(365, 550)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(140, 40)
        btnCancel.TabIndex = 12
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(96), CByte(52), CByte(16))
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Lucida Sans Unicode", 10.0F, FontStyle.Bold)
        btnSave.ForeColor = Color.WhiteSmoke
        btnSave.Location = New Point(515, 550)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(140, 40)
        btnSave.TabIndex = 11
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = Color.Sienna
        btnBrowse.FlatAppearance.BorderSize = 0
        btnBrowse.FlatStyle = FlatStyle.Flat
        btnBrowse.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Bold)
        btnBrowse.ForeColor = Color.WhiteSmoke
        btnBrowse.Location = New Point(500, 476)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(155, 35)
        btnBrowse.TabIndex = 10
        btnBrowse.Text = "Browse Photo"
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' picServicePhoto
        ' 
        picServicePhoto.BackColor = Color.FromArgb(CByte(232), CByte(216), CByte(194))
        picServicePhoto.BorderStyle = BorderStyle.FixedSingle
        picServicePhoto.Location = New Point(365, 261)
        picServicePhoto.Name = "picServicePhoto"
        picServicePhoto.Size = New Size(290, 195)
        picServicePhoto.SizeMode = PictureBoxSizeMode.Zoom
        picServicePhoto.TabIndex = 9
        picServicePhoto.TabStop = False
        ' 
        ' txtDuration
        ' 
        txtDuration.Font = New Font("Lucida Sans Unicode", 10.0F)
        txtDuration.Location = New Point(365, 195)
        txtDuration.Name = "txtDuration"
        txtDuration.Size = New Size(290, 33)
        txtDuration.TabIndex = 8
        ' 
        ' txtPrice
        ' 
        txtPrice.Font = New Font("Lucida Sans Unicode", 10.0F)
        txtPrice.Location = New Point(365, 145)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(290, 33)
        txtPrice.TabIndex = 7
        ' 
        ' txtDescription
        ' 
        txtDescription.Font = New Font("Lucida Sans Unicode", 10.0F)
        txtDescription.Location = New Point(25, 311)
        txtDescription.Multiline = True
        txtDescription.Name = "txtDescription"
        txtDescription.ScrollBars = ScrollBars.Vertical
        txtDescription.Size = New Size(300, 145)
        txtDescription.TabIndex = 6
        ' 
        ' txtServiceName
        ' 
        txtServiceName.Font = New Font("Lucida Sans Unicode", 10.0F)
        txtServiceName.Location = New Point(25, 145)
        txtServiceName.Name = "txtServiceName"
        txtServiceName.Size = New Size(300, 33)
        txtServiceName.TabIndex = 5
        ' 
        ' lblPhoto
        ' 
        lblPhoto.AutoSize = True
        lblPhoto.Font = New Font("Lucida Sans Unicode", 10.0F, FontStyle.Bold)
        lblPhoto.ForeColor = Color.SaddleBrown
        lblPhoto.Location = New Point(365, 237)
        lblPhoto.Name = "lblPhoto"
        lblPhoto.Size = New Size(134, 21)
        lblPhoto.TabIndex = 4
        lblPhoto.Text = "Service Photo"
        ' 
        ' lblDuration
        ' 
        lblDuration.AutoSize = True
        lblDuration.Font = New Font("Lucida Sans Unicode", 10.0F, FontStyle.Bold)
        lblDuration.ForeColor = Color.SaddleBrown
        lblDuration.Location = New Point(365, 120)
        lblDuration.Name = "lblDuration"
        lblDuration.Size = New Size(90, 21)
        lblDuration.TabIndex = 3
        lblDuration.Text = "Duration"
        ' 
        ' lblPrice
        ' 
        lblPrice.AutoSize = True
        lblPrice.Font = New Font("Lucida Sans Unicode", 10.0F, FontStyle.Bold)
        lblPrice.ForeColor = Color.SaddleBrown
        lblPrice.Location = New Point(365, 70)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(55, 21)
        lblPrice.TabIndex = 2
        lblPrice.Text = "Price"
        ' 
        ' lblDescription
        ' 
        lblDescription.AutoSize = True
        lblDescription.Font = New Font("Lucida Sans Unicode", 10.0F, FontStyle.Bold)
        lblDescription.ForeColor = Color.SaddleBrown
        lblDescription.Location = New Point(25, 270)
        lblDescription.Name = "lblDescription"
        lblDescription.Size = New Size(116, 21)
        lblDescription.TabIndex = 1
        lblDescription.Text = "Description"
        ' 
        ' lblServiceName
        ' 
        lblServiceName.AutoSize = True
        lblServiceName.Font = New Font("Lucida Sans Unicode", 10.0F, FontStyle.Bold)
        lblServiceName.ForeColor = Color.SaddleBrown
        lblServiceName.Location = New Point(25, 120)
        lblServiceName.Name = "lblServiceName"
        lblServiceName.Size = New Size(135, 21)
        lblServiceName.TabIndex = 0
        lblServiceName.Text = "Service Name"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Lucida Sans Unicode", 18.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(CByte(61), CByte(40), CByte(27))
        lblTitle.Location = New Point(25, 25)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(361, 37)
        lblTitle.TabIndex = 13
        lblTitle.Text = "Add Grooming Service"
        ' 
        ' frmAddGroomingService
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(247), CByte(232), CByte(213))
        ClientSize = New Size(700, 620)
        Controls.Add(pnlMain)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmAddGroomingService"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add Grooming Service"
        pnlMain.ResumeLayout(False)
        pnlMain.PerformLayout()
        CType(picServicePhoto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblServiceName As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblDuration As Label
    Friend WithEvents lblPhoto As Label
    Friend WithEvents txtServiceName As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtDuration As TextBox
    Friend WithEvents picServicePhoto As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button

End Class