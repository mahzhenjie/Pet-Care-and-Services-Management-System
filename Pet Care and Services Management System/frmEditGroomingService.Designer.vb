<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEditGroomingService
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblServiceName = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.lblPhoto = New System.Windows.Forms.Label()
        Me.txtServiceName = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtDuration = New System.Windows.Forms.TextBox()
        Me.picServicePhoto = New System.Windows.Forms.PictureBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.pnlMain.SuspendLayout()
        CType(Me.picServicePhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        ' pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CByte(232), CByte(216), CByte(194))
        Me.pnlMain.Controls.Add(Me.lblTitle)
        Me.pnlMain.Controls.Add(Me.lblServiceName)
        Me.pnlMain.Controls.Add(Me.lblDescription)
        Me.pnlMain.Controls.Add(Me.lblPrice)
        Me.pnlMain.Controls.Add(Me.lblDuration)
        Me.pnlMain.Controls.Add(Me.lblPhoto)
        Me.pnlMain.Controls.Add(Me.txtServiceName)
        Me.pnlMain.Controls.Add(Me.txtDescription)
        Me.pnlMain.Controls.Add(Me.txtPrice)
        Me.pnlMain.Controls.Add(Me.txtDuration)
        Me.pnlMain.Controls.Add(Me.picServicePhoto)
        Me.pnlMain.Controls.Add(Me.btnBrowse)
        Me.pnlMain.Controls.Add(Me.btnUpdate)
        Me.pnlMain.Controls.Add(Me.btnCancel)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(700, 620)
        Me.pnlMain.TabIndex = 0
        '
        ' lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Lucida Sans Unicode", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblTitle.Location = New System.Drawing.Point(25, 25)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(298, 36)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Edit Grooming Service"
        '
        ' lblServiceName
        '
        Me.lblServiceName.AutoSize = True
        Me.lblServiceName.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblServiceName.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblServiceName.Location = New System.Drawing.Point(25, 100)
        Me.lblServiceName.Name = "lblServiceName"
        Me.lblServiceName.Size = New System.Drawing.Size(125, 21)
        Me.lblServiceName.TabIndex = 1
        Me.lblServiceName.Text = "Service Name"
        '
        ' lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblDescription.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblDescription.Location = New System.Drawing.Point(25, 250)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(108, 21)
        Me.lblDescription.TabIndex = 2
        Me.lblDescription.Text = "Description"
        '
        ' lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblPrice.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblPrice.Location = New System.Drawing.Point(365, 100)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(49, 21)
        Me.lblPrice.TabIndex = 3
        Me.lblPrice.Text = "Price"
        '
        ' lblDuration
        '
        Me.lblDuration.AutoSize = True
        Me.lblDuration.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblDuration.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblDuration.Location = New System.Drawing.Point(365, 175)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(84, 21)
        Me.lblDuration.TabIndex = 4
        Me.lblDuration.Text = "Duration"
        '
        ' lblPhoto
        '
        Me.lblPhoto.AutoSize = True
        Me.lblPhoto.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblPhoto.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblPhoto.Location = New System.Drawing.Point(365, 250)
        Me.lblPhoto.Name = "lblPhoto"
        Me.lblPhoto.Size = New System.Drawing.Size(56, 21)
        Me.lblPhoto.TabIndex = 5
        Me.lblPhoto.Text = "Photo"
        '
        ' txtServiceName
        '
        Me.txtServiceName.BackColor = System.Drawing.Color.White
        Me.txtServiceName.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!)
        Me.txtServiceName.Location = New System.Drawing.Point(25, 125)
        Me.txtServiceName.Name = "txtServiceName"
        Me.txtServiceName.Size = New System.Drawing.Size(300, 28)
        Me.txtServiceName.TabIndex = 6
        '
        ' txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.Color.White
        Me.txtDescription.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!)
        Me.txtDescription.Location = New System.Drawing.Point(25, 275)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescription.Size = New System.Drawing.Size(300, 195)
        Me.txtDescription.TabIndex = 7
        '
        ' txtPrice
        '
        Me.txtPrice.BackColor = System.Drawing.Color.White
        Me.txtPrice.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!)
        Me.txtPrice.Location = New System.Drawing.Point(365, 125)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(300, 28)
        Me.txtPrice.TabIndex = 8
        '
        ' txtDuration
        '
        Me.txtDuration.BackColor = System.Drawing.Color.White
        Me.txtDuration.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!)
        Me.txtDuration.Location = New System.Drawing.Point(365, 200)
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.Size = New System.Drawing.Size(300, 28)
        Me.txtDuration.TabIndex = 9
        '
        ' picServicePhoto
        '
        Me.picServicePhoto.BackColor = System.Drawing.Color.White
        Me.picServicePhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picServicePhoto.Location = New System.Drawing.Point(365, 275)
        Me.picServicePhoto.Name = "picServicePhoto"
        Me.picServicePhoto.Size = New System.Drawing.Size(300, 180)
        Me.picServicePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picServicePhoto.TabIndex = 10
        Me.picServicePhoto.TabStop = False
        '
        ' btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnBrowse.FlatAppearance.BorderSize = 0
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowse.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnBrowse.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnBrowse.Location = New System.Drawing.Point(365, 470)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(120, 40)
        Me.btnBrowse.TabIndex = 11
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        ' btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnUpdate.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnUpdate.Location = New System.Drawing.Point(385, 550)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(130, 45)
        Me.btnUpdate.TabIndex = 12
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        ' btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Gray
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnCancel.Location = New System.Drawing.Point(535, 550)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(130, 45)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        ' frmEditGroomingService
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CByte(247), CByte(232), CByte(213))
        Me.ClientSize = New System.Drawing.Size(700, 620)
        Me.Controls.Add(Me.pnlMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEditGroomingService"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Grooming Service"
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        CType(Me.picServicePhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnCancel As Button

End Class