<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAbout
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        pnlAbout = New Panel()
        btnClose = New Button()
        lblTechnology = New Label()
        lblTechnologyTitle = New Label()
        lblDevelopedBy = New Label()
        lblDevelopedByTitle = New Label()
        lblVersion = New Label()
        lblDescription = New Label()
        lblSystemName = New Label()
        picLogo = New PictureBox()
        pnlAbout.SuspendLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlAbout
        ' 
        pnlAbout.BackColor = Color.FromArgb(CByte(235), CByte(218), CByte(191))
        pnlAbout.Controls.Add(btnClose)
        pnlAbout.Controls.Add(lblTechnology)
        pnlAbout.Controls.Add(lblTechnologyTitle)
        pnlAbout.Controls.Add(lblDevelopedBy)
        pnlAbout.Controls.Add(lblDevelopedByTitle)
        pnlAbout.Controls.Add(lblVersion)
        pnlAbout.Controls.Add(lblDescription)
        pnlAbout.Controls.Add(lblSystemName)
        pnlAbout.Controls.Add(picLogo)
        pnlAbout.Location = New Point(14, 20)
        pnlAbout.Margin = New Padding(3, 4, 3, 4)
        pnlAbout.Name = "pnlAbout"
        pnlAbout.Size = New Size(743, 760)
        pnlAbout.TabIndex = 0
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.SaddleBrown
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Lucida Sans Unicode", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.ForeColor = Color.WhiteSmoke
        btnClose.Location = New Point(286, 667)
        btnClose.Margin = New Padding(3, 4, 3, 4)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(171, 53)
        btnClose.TabIndex = 8
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' lblTechnology
        ' 
        lblTechnology.Font = New Font("Lucida Sans Unicode", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTechnology.ForeColor = Color.SaddleBrown
        lblTechnology.Location = New Point(211, 560)
        lblTechnology.Name = "lblTechnology"
        lblTechnology.Size = New Size(480, 40)
        lblTechnology.TabIndex = 7
        lblTechnology.Text = "VB.NET • Windows Forms • MySQL"
        lblTechnology.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblTechnologyTitle
        ' 
        lblTechnologyTitle.AutoSize = True
        lblTechnologyTitle.Font = New Font("Lucida Sans Unicode", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTechnologyTitle.ForeColor = Color.SaddleBrown
        lblTechnologyTitle.Location = New Point(51, 567)
        lblTechnologyTitle.Name = "lblTechnologyTitle"
        lblTechnologyTitle.Size = New Size(117, 21)
        lblTechnologyTitle.TabIndex = 6
        lblTechnologyTitle.Text = "Technology"
        ' 
        ' lblDevelopedBy
        ' 
        lblDevelopedBy.Font = New Font("Lucida Sans Unicode", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDevelopedBy.ForeColor = Color.SaddleBrown
        lblDevelopedBy.Location = New Point(211, 440)
        lblDevelopedBy.Name = "lblDevelopedBy"
        lblDevelopedBy.Size = New Size(480, 93)
        lblDevelopedBy.TabIndex = 5
        lblDevelopedBy.Text = "Mah Zhen Jie" & vbCrLf & "Chang Man Yin" & vbCrLf & "Yeo Kai Mi" & vbCrLf & "Wong Jing En"
        ' 
        ' lblDevelopedByTitle
        ' 
        lblDevelopedByTitle.AutoSize = True
        lblDevelopedByTitle.Font = New Font("Lucida Sans Unicode", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDevelopedByTitle.ForeColor = Color.SaddleBrown
        lblDevelopedByTitle.Location = New Point(51, 447)
        lblDevelopedByTitle.Name = "lblDevelopedByTitle"
        lblDevelopedByTitle.Size = New Size(136, 21)
        lblDevelopedByTitle.TabIndex = 4
        lblDevelopedByTitle.Text = "Developed By"
        ' 
        ' lblVersion
        ' 
        lblVersion.AutoSize = True
        lblVersion.Font = New Font("Lucida Sans Unicode", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblVersion.ForeColor = Color.SaddleBrown
        lblVersion.Location = New Point(305, 360)
        lblVersion.Name = "lblVersion"
        lblVersion.Size = New Size(104, 21)
        lblVersion.TabIndex = 3
        lblVersion.Text = "Version 1.0"
        ' 
        ' lblDescription
        ' 
        lblDescription.Font = New Font("Lucida Sans Unicode", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDescription.ForeColor = Color.SaddleBrown
        lblDescription.Location = New Point(80, 287)
        lblDescription.Name = "lblDescription"
        lblDescription.Size = New Size(583, 60)
        lblDescription.TabIndex = 2
        lblDescription.Text = "A management system designed to manage pet care services, customers, pets, bookings, products and payments."
        lblDescription.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblSystemName
        ' 
        lblSystemName.AutoSize = True
        lblSystemName.Font = New Font("Lucida Sans Unicode", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSystemName.ForeColor = Color.SaddleBrown
        lblSystemName.Location = New Point(37, 230)
        lblSystemName.Name = "lblSystemName"
        lblSystemName.Size = New Size(678, 37)
        lblSystemName.TabIndex = 1
        lblSystemName.Text = "Pet Care and Services Management System"
        lblSystemName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' picLogo
        ' 
        picLogo.BackColor = Color.FromArgb(CByte(235), CByte(218), CByte(191))
        picLogo.BorderStyle = BorderStyle.FixedSingle
        picLogo.Image = CType(resources.GetObject("picLogo.Image"), Image)
        picLogo.Location = New Point(309, 47)
        picLogo.Margin = New Padding(3, 4, 3, 4)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(125, 146)
        picLogo.SizeMode = PictureBoxSizeMode.Zoom
        picLogo.TabIndex = 0
        picLogo.TabStop = False
        ' 
        ' frmAbout
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(247), CByte(232), CByte(213))
        ClientSize = New Size(770, 800)
        Controls.Add(pnlAbout)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        Name = "frmAbout"
        StartPosition = FormStartPosition.CenterScreen
        Text = "About Pet Care System"
        pnlAbout.ResumeLayout(False)
        pnlAbout.PerformLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlAbout As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents lblTechnology As Label
    Friend WithEvents lblTechnologyTitle As Label
    Friend WithEvents lblDevelopedBy As Label
    Friend WithEvents lblDevelopedByTitle As Label
    Friend WithEvents lblVersion As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblSystemName As Label
    Friend WithEvents picLogo As PictureBox

End Class