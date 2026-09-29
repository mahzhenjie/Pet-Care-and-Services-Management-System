<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEditBoardingService
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

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

        ' pnlMain
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CByte(247), CByte(232), CByte(213))
        Me.pnlMain.Controls.Add(Me.btnCancel)
        Me.pnlMain.Controls.Add(Me.btnUpdate)
        Me.pnlMain.Controls.Add(Me.btnBrowse)
        Me.pnlMain.Controls.Add(Me.picServicePhoto)
        Me.pnlMain.Controls.Add(Me.txtDuration)
        Me.pnlMain.Controls.Add(Me.txtPrice)
        Me.pnlMain.Controls.Add(Me.txtDescription)
        Me.pnlMain.Controls.Add(Me.txtServiceName)
        Me.pnlMain.Controls.Add(Me.lblPhoto)
        Me.pnlMain.Controls.Add(Me.lblDuration)
        Me.pnlMain.Controls.Add(Me.lblPrice)
        Me.pnlMain.Controls.Add(Me.lblDescription)
        Me.pnlMain.Controls.Add(Me.lblServiceName)
        Me.pnlMain.Controls.Add(Me.lblTitle)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(700, 620)
        Me.pnlMain.TabIndex = 0

        ' lblTitle
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Lucida Sans Unicode", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblTitle.Location = New System.Drawing.Point(30, 25)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(326, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Edit Boarding Service"

        ' lblServiceName
        Me.lblServiceName.AutoSize = True
        Me.lblServiceName.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblServiceName.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblServiceName.Location = New System.Drawing.Point(35, 90)
        Me.lblServiceName.Name = "lblServiceName"
        Me.lblServiceName.Size = New System.Drawing.Size(107, 17)
        Me.lblServiceName.TabIndex = 1
        Me.lblServiceName.Text = "Service Name"

        ' txtServiceName
        Me.txtServiceName.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!)
        Me.txtServiceName.Location = New System.Drawing.Point(35, 115)
        Me.txtServiceName.Name = "txtServiceName"
        Me.txtServiceName.Size = New System.Drawing.Size(300, 27)
        Me.txtServiceName.TabIndex = 2

        ' lblDescription
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblDescription.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblDescription.Location = New System.Drawing.Point(35, 160)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(91, 17)
        Me.lblDescription.TabIndex = 3
        Me.lblDescription.Text = "Description"

        ' txtDescription
        Me.txtDescription.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!)
        Me.txtDescription.Location = New System.Drawing.Point(35, 185)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescription.Size = New System.Drawing.Size(300, 100)
        Me.txtDescription.TabIndex = 4

        ' lblPrice
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblPrice.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblPrice.Location = New System.Drawing.Point(35, 305)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(43, 17)
        Me.lblPrice.TabIndex = 5
        Me.lblPrice.Text = "Price"

        ' txtPrice
        Me.txtPrice.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!)
        Me.txtPrice.Location = New System.Drawing.Point(35, 330)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(300, 27)
        Me.txtPrice.TabIndex = 6

        ' lblDuration
        Me.lblDuration.AutoSize = True
        Me.lblDuration.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblDuration.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblDuration.Location = New System.Drawing.Point(35, 375)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(74, 17)
        Me.lblDuration.TabIndex = 7
        Me.lblDuration.Text = "Duration"

        ' txtDuration
        Me.txtDuration.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!)
        Me.txtDuration.Location = New System.Drawing.Point(35, 400)
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.Size = New System.Drawing.Size(300, 27)
        Me.txtDuration.TabIndex = 8

        ' lblPhoto
        Me.lblPhoto.AutoSize = True
        Me.lblPhoto.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblPhoto.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblPhoto.Location = New System.Drawing.Point(380, 90)
        Me.lblPhoto.Name = "lblPhoto"
        Me.lblPhoto.Size = New System.Drawing.Size(48, 17)
        Me.lblPhoto.TabIndex = 9
        Me.lblPhoto.Text = "Photo"

        ' picServicePhoto
        Me.picServicePhoto.BackColor = System.Drawing.Color.White
        Me.picServicePhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picServicePhoto.Location = New System.Drawing.Point(380, 115)
        Me.picServicePhoto.Name = "picServicePhoto"
        Me.picServicePhoto.Size = New System.Drawing.Size(280, 180)
        Me.picServicePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picServicePhoto.TabIndex = 10
        Me.picServicePhoto.TabStop = False

        ' btnBrowse
        Me.btnBrowse.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowse.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnBrowse.ForeColor = System.Drawing.Color.White
        Me.btnBrowse.Location = New System.Drawing.Point(380, 315)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(280, 40)
        Me.btnBrowse.TabIndex = 11
        Me.btnBrowse.Text = "Browse Photo"
        Me.btnBrowse.UseVisualStyleBackColor = False

        ' btnUpdate
        Me.btnUpdate.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(380, 400)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(135, 45)
        Me.btnUpdate.TabIndex = 12
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False

        ' btnCancel
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CByte(139), CByte(69), CByte(19))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(525, 400)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(135, 45)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False

        ' FORM
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(700, 620)
        Me.Controls.Add(Me.pnlMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEditBoardingService"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Boarding Service"

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