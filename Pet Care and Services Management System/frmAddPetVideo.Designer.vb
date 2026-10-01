<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddPetVideo
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
        pnlMain = New Panel()
        pnlHeader = New Panel()
        lblTitle = New Label()
        lblSubtitle = New Label()
        pnlContent = New Panel()
        lblBookingID = New Label()
        txtBookingID = New TextBox()
        lblVideoURL = New Label()
        txtVideoURL = New TextBox()
        lblDescription = New Label()
        txtDescription = New TextBox()
        lblUploadDate = New Label()
        dtpUploadDate = New DateTimePicker()
        btnAdd = New Button()
        btnCancel = New Button()
        pnlMain.SuspendLayout()
        pnlHeader.SuspendLayout()
        pnlContent.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlMain
        ' 
        pnlMain.BackColor = Color.FromArgb(247, 232, 213)
        pnlMain.Controls.Add(pnlHeader)
        pnlMain.Controls.Add(pnlContent)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(0, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Padding = New Padding(20)
        pnlMain.Size = New Size(800, 500)
        pnlMain.TabIndex = 0
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(74, 44, 26)
        pnlHeader.Controls.Add(lblSubtitle)
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(20, 20)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(760, 90)
        pnlHeader.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 22.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(25, 12)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(210, 41)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Add Pet Video"
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.Font = New Font("Segoe UI", 10.0F)
        lblSubtitle.ForeColor = Color.FromArgb(247, 232, 213)
        lblSubtitle.Location = New Point(29, 55)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(270, 19)
        lblSubtitle.TabIndex = 1
        lblSubtitle.Text = "Add a new CCTV video record"
        ' 
        ' pnlContent
        ' 
        pnlContent.BackColor = Color.White
        pnlContent.Controls.Add(btnCancel)
        pnlContent.Controls.Add(btnAdd)
        pnlContent.Controls.Add(dtpUploadDate)
        pnlContent.Controls.Add(lblUploadDate)
        pnlContent.Controls.Add(txtDescription)
        pnlContent.Controls.Add(lblDescription)
        pnlContent.Controls.Add(txtVideoURL)
        pnlContent.Controls.Add(lblVideoURL)
        pnlContent.Controls.Add(txtBookingID)
        pnlContent.Controls.Add(lblBookingID)
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(20, 110)
        pnlContent.Name = "pnlContent"
        pnlContent.Padding = New Padding(35)
        pnlContent.Size = New Size(760, 370)
        pnlContent.TabIndex = 1
        ' 
        ' lblBookingID
        ' 
        lblBookingID.AutoSize = True
        lblBookingID.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblBookingID.ForeColor = Color.FromArgb(74, 44, 26)
        lblBookingID.Location = New Point(35, 30)
        lblBookingID.Name = "lblBookingID"
        lblBookingID.Size = New Size(150, 19)
        lblBookingID.TabIndex = 0
        lblBookingID.Text = "Boarding Booking ID"
        ' 
        ' txtBookingID
        ' 
        txtBookingID.Font = New Font("Segoe UI", 11.0F)
        txtBookingID.Location = New Point(35, 55)
        txtBookingID.Name = "txtBookingID"
        txtBookingID.Size = New Size(690, 27)
        txtBookingID.TabIndex = 1
        ' 
        ' lblVideoURL
        ' 
        lblVideoURL.AutoSize = True
        lblVideoURL.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblVideoURL.ForeColor = Color.FromArgb(74, 44, 26)
        lblVideoURL.Location = New Point(35, 95)
        lblVideoURL.Name = "lblVideoURL"
        lblVideoURL.Size = New Size(78, 19)
        lblVideoURL.TabIndex = 2
        lblVideoURL.Text = "Video URL"
        ' 
        ' txtVideoURL
        ' 
        txtVideoURL.Font = New Font("Segoe UI", 11.0F)
        txtVideoURL.Location = New Point(35, 120)
        txtVideoURL.Name = "txtVideoURL"
        txtVideoURL.Size = New Size(690, 27)
        txtVideoURL.TabIndex = 3
        ' 
        ' lblDescription
        ' 
        lblDescription.AutoSize = True
        lblDescription.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblDescription.ForeColor = Color.FromArgb(74, 44, 26)
        lblDescription.Location = New Point(35, 160)
        lblDescription.Name = "lblDescription"
        lblDescription.Size = New Size(88, 19)
        lblDescription.TabIndex = 4
        lblDescription.Text = "Description"
        ' 
        ' txtDescription
        ' 
        txtDescription.Font = New Font("Segoe UI", 11.0F)
        txtDescription.Location = New Point(35, 185)
        txtDescription.Multiline = True
        txtDescription.Name = "txtDescription"
        txtDescription.ScrollBars = ScrollBars.Vertical
        txtDescription.Size = New Size(690, 60)
        txtDescription.TabIndex = 5
        ' 
        ' lblUploadDate
        ' 
        lblUploadDate.AutoSize = True
        lblUploadDate.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblUploadDate.ForeColor = Color.FromArgb(74, 44, 26)
        lblUploadDate.Location = New Point(35, 260)
        lblUploadDate.Name = "lblUploadDate"
        lblUploadDate.Size = New Size(90, 19)
        lblUploadDate.TabIndex = 6
        lblUploadDate.Text = "Upload Date"
        ' 
        ' dtpUploadDate
        ' 
        dtpUploadDate.CustomFormat = "dd/MM/yyyy HH:mm:ss"
        dtpUploadDate.Font = New Font("Segoe UI", 10.0F)
        dtpUploadDate.Format = DateTimePickerFormat.Custom
        dtpUploadDate.Location = New Point(145, 256)
        dtpUploadDate.Name = "dtpUploadDate"
        dtpUploadDate.Size = New Size(250, 25)
        dtpUploadDate.TabIndex = 7
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.FromArgb(111, 78, 55)
        btnAdd.FlatAppearance.BorderSize = 0
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnAdd.ForeColor = Color.White
        btnAdd.Location = New Point(505, 305)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(105, 40)
        btnAdd.TabIndex = 8
        btnAdd.Text = "Add Video"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(180, 150, 120)
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(620, 305)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(105, 40)
        btnCancel.TabIndex = 9
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' frmAddPetVideo
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(247, 232, 213)
        ClientSize = New Size(800, 500)
        Controls.Add(pnlMain)
        MinimumSize = New Size(800, 500)
        Name = "frmAddPetVideo"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add Pet Video"
        pnlMain.ResumeLayout(False)
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlContent.ResumeLayout(False)
        pnlContent.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents pnlContent As Panel
    Friend WithEvents lblBookingID As Label
    Friend WithEvents txtBookingID As TextBox
    Friend WithEvents lblVideoURL As Label
    Friend WithEvents txtVideoURL As TextBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents lblUploadDate As Label
    Friend WithEvents dtpUploadDate As DateTimePicker
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnCancel As Button
End Class