<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEditBoardingRoom
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlEditBoardingRoom = New System.Windows.Forms.Panel()
        Me.btnChoosePhoto = New System.Windows.Forms.Button()
        Me.picRoom = New System.Windows.Forms.PictureBox()
        Me.lblPhoto = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.cboRoomType = New System.Windows.Forms.ComboBox()
        Me.lblRoomType = New System.Windows.Forms.Label()
        Me.txtRoomID = New System.Windows.Forms.TextBox()
        Me.lblRoomID = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.pnlEditBoardingRoom.SuspendLayout()
        CType(Me.picRoom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlEditBoardingRoom
        '
        Me.pnlEditBoardingRoom.BackColor = System.Drawing.Color.FromArgb(CByte(235), CByte(218), CByte(191))
        Me.pnlEditBoardingRoom.Controls.Add(Me.btnChoosePhoto)
        Me.pnlEditBoardingRoom.Controls.Add(Me.picRoom)
        Me.pnlEditBoardingRoom.Controls.Add(Me.lblPhoto)
        Me.pnlEditBoardingRoom.Controls.Add(Me.txtDescription)
        Me.pnlEditBoardingRoom.Controls.Add(Me.lblDescription)
        Me.pnlEditBoardingRoom.Controls.Add(Me.cboStatus)
        Me.pnlEditBoardingRoom.Controls.Add(Me.lblStatus)
        Me.pnlEditBoardingRoom.Controls.Add(Me.txtPrice)
        Me.pnlEditBoardingRoom.Controls.Add(Me.lblPrice)
        Me.pnlEditBoardingRoom.Controls.Add(Me.cboRoomType)
        Me.pnlEditBoardingRoom.Controls.Add(Me.lblRoomType)
        Me.pnlEditBoardingRoom.Controls.Add(Me.txtRoomID)
        Me.pnlEditBoardingRoom.Controls.Add(Me.lblRoomID)
        Me.pnlEditBoardingRoom.Controls.Add(Me.lblTitle)
        Me.pnlEditBoardingRoom.Controls.Add(Me.btnSave)
        Me.pnlEditBoardingRoom.Controls.Add(Me.btnCancel)
        Me.pnlEditBoardingRoom.Location = New System.Drawing.Point(12, 15)
        Me.pnlEditBoardingRoom.Name = "pnlEditBoardingRoom"
        Me.pnlEditBoardingRoom.Size = New System.Drawing.Size(720, 620)
        Me.pnlEditBoardingRoom.TabIndex = 0
        '
        'btnChoosePhoto
        '
        Me.btnChoosePhoto.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnChoosePhoto.FlatAppearance.BorderSize = 0
        Me.btnChoosePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChoosePhoto.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
        Me.btnChoosePhoto.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnChoosePhoto.Location = New System.Drawing.Point(485, 435)
        Me.btnChoosePhoto.Name = "btnChoosePhoto"
        Me.btnChoosePhoto.Size = New System.Drawing.Size(150, 35)
        Me.btnChoosePhoto.TabIndex = 14
        Me.btnChoosePhoto.Text = "Choose Photo"
        Me.btnChoosePhoto.UseVisualStyleBackColor = False
        '
        'picRoom
        '
        Me.picRoom.BackColor = System.Drawing.Color.WhiteSmoke
        Me.picRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picRoom.Location = New System.Drawing.Point(485, 270)
        Me.picRoom.Name = "picRoom"
        Me.picRoom.Size = New System.Drawing.Size(150, 150)
        Me.picRoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picRoom.TabIndex = 13
        Me.picRoom.TabStop = False
        '
        'lblPhoto
        '
        Me.lblPhoto.AutoSize = True
        Me.lblPhoto.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
        Me.lblPhoto.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblPhoto.Location = New System.Drawing.Point(390, 275)
        Me.lblPhoto.Name = "lblPhoto"
        Me.lblPhoto.Size = New System.Drawing.Size(49, 16)
        Me.lblPhoto.TabIndex = 12
        Me.lblPhoto.Text = "Photo"
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
        Me.txtDescription.Location = New System.Drawing.Point(185, 270)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(180, 120)
        Me.txtDescription.TabIndex = 11
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
        Me.lblDescription.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblDescription.Location = New System.Drawing.Point(35, 275)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(94, 16)
        Me.lblDescription.TabIndex = 10
        Me.lblDescription.Text = "Description"
        '
        'cboStatus
        '
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Available", "Occupied"})
        Me.cboStatus.Location = New System.Drawing.Point(185, 225)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(180, 24)
        Me.cboStatus.TabIndex = 9
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
        Me.lblStatus.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblStatus.Location = New System.Drawing.Point(35, 230)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(52, 16)
        Me.lblStatus.TabIndex = 8
        Me.lblStatus.Text = "Status"
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
        Me.txtPrice.Location = New System.Drawing.Point(185, 180)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(180, 27)
        Me.txtPrice.TabIndex = 7
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
        Me.lblPrice.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblPrice.Location = New System.Drawing.Point(35, 185)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(46, 16)
        Me.lblPrice.TabIndex = 6
        Me.lblPrice.Text = "Price"
        '
        'cboRoomType
        '
        Me.cboRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRoomType.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
        Me.cboRoomType.FormattingEnabled = True
        Me.cboRoomType.Items.AddRange(New Object() {"Standard", "Deluxe", "Premium", "VIP"})
        Me.cboRoomType.Location = New System.Drawing.Point(185, 135)
        Me.cboRoomType.Name = "cboRoomType"
        Me.cboRoomType.Size = New System.Drawing.Size(180, 24)
        Me.cboRoomType.TabIndex = 5
        '
        'lblRoomType
        '
        Me.lblRoomType.AutoSize = True
        Me.lblRoomType.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
        Me.lblRoomType.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblRoomType.Location = New System.Drawing.Point(35, 140)
        Me.lblRoomType.Name = "lblRoomType"
        Me.lblRoomType.Size = New System.Drawing.Size(82, 16)
        Me.lblRoomType.TabIndex = 4
        Me.lblRoomType.Text = "Room Type"
        '
        'txtRoomID
        '
        Me.txtRoomID.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
        Me.txtRoomID.Location = New System.Drawing.Point(185, 90)
        Me.txtRoomID.Name = "txtRoomID"
        Me.txtRoomID.ReadOnly = True
        Me.txtRoomID.Size = New System.Drawing.Size(180, 27)
        Me.txtRoomID.TabIndex = 3
        '
        'lblRoomID
        '
        Me.lblRoomID.AutoSize = True
        Me.lblRoomID.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
        Me.lblRoomID.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblRoomID.Location = New System.Drawing.Point(35, 95)
        Me.lblRoomID.Name = "lblRoomID"
        Me.lblRoomID.Size = New System.Drawing.Size(66, 16)
        Me.lblRoomID.TabIndex = 2
        Me.lblRoomID.Text = "Room ID"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Lucida Sans Unicode", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
        Me.lblTitle.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblTitle.Location = New System.Drawing.Point(30, 25)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(254, 28)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Edit Boarding Room"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
        Me.btnSave.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnSave.Location = New System.Drawing.Point(485, 515)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(150, 40)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.MistyRose
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
        Me.btnCancel.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnCancel.Location = New System.Drawing.Point(305, 515)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(150, 40)
        Me.btnCancel.TabIndex = 16
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'frmEditBoardingRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CByte(247), CByte(232), CByte(213))
        Me.ClientSize = New System.Drawing.Size(744, 650)
        Me.Controls.Add(Me.pnlEditBoardingRoom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmEditBoardingRoom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Boarding Room"
        Me.pnlEditBoardingRoom.ResumeLayout(False)
        Me.pnlEditBoardingRoom.PerformLayout()
        CType(Me.picRoom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlEditBoardingRoom As Panel
    Friend WithEvents btnChoosePhoto As Button
    Friend WithEvents picRoom As PictureBox
    Friend WithEvents lblPhoto As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents cboRoomType As ComboBox
    Friend WithEvents lblRoomType As Label
    Friend WithEvents txtRoomID As TextBox
    Friend WithEvents lblRoomID As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button

End Class