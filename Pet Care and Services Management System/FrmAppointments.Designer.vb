<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAppointments
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAppointments))
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        btnDashboard = New Button()
        btnAddAppointment = New Button()
        Refreshbtn = New Button()
        pnlHeader = New Panel()
        PictureBox2 = New PictureBox()
        lblMyAppointments = New Label()
        btnGoBackDashboard = New Button()
        dgvAppointments = New DataGridView()
        btnAddPet = New Button()
        btnRefresh = New Button()
        txtSearch = New TextBox()
        Panel1.SuspendLayout()
        pnlHeader.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvAppointments, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(243), CByte(222))
        Panel1.Controls.Add(btnDashboard)
        Panel1.Controls.Add(btnAddAppointment)
        Panel1.Controls.Add(Refreshbtn)
        Panel1.Controls.Add(pnlHeader)
        Panel1.Controls.Add(btnGoBackDashboard)
        Panel1.Controls.Add(dgvAppointments)
        Panel1.Controls.Add(btnAddPet)
        Panel1.Controls.Add(btnRefresh)
        Panel1.Controls.Add(txtSearch)
        Panel1.Location = New Point(-2, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1716, 1008)
        Panel1.TabIndex = 16
        ' 
        ' btnDashboard
        ' 
        btnDashboard.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnDashboard.BackColor = Color.SaddleBrown
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnDashboard.ForeColor = Color.WhiteSmoke
        btnDashboard.Location = New Point(867, 77)
        btnDashboard.Margin = New Padding(4)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(218, 57)
        btnDashboard.TabIndex = 18
        btnDashboard.Text = "Dashboard"
        btnDashboard.UseVisualStyleBackColor = False
        ' 
        ' btnAddAppointment
        ' 
        btnAddAppointment.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnAddAppointment.BackColor = Color.FromArgb(CByte(96), CByte(52), CByte(16))
        btnAddAppointment.FlatAppearance.BorderSize = 0
        btnAddAppointment.FlatStyle = FlatStyle.Flat
        btnAddAppointment.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnAddAppointment.ForeColor = Color.WhiteSmoke
        btnAddAppointment.Location = New Point(1391, 77)
        btnAddAppointment.Margin = New Padding(4)
        btnAddAppointment.Name = "btnAddAppointment"
        btnAddAppointment.Size = New Size(240, 57)
        btnAddAppointment.TabIndex = 17
        btnAddAppointment.Text = "+ Add Appoinment"
        btnAddAppointment.UseVisualStyleBackColor = False
        ' 
        ' Refreshbtn
        ' 
        Refreshbtn.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Refreshbtn.BackColor = Color.Sienna
        Refreshbtn.FlatAppearance.BorderSize = 0
        Refreshbtn.FlatStyle = FlatStyle.Flat
        Refreshbtn.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        Refreshbtn.ForeColor = Color.WhiteSmoke
        Refreshbtn.Location = New Point(1141, 77)
        Refreshbtn.Margin = New Padding(4)
        Refreshbtn.Name = "Refreshbtn"
        Refreshbtn.Size = New Size(195, 57)
        Refreshbtn.TabIndex = 16
        Refreshbtn.Text = "Refresh"
        Refreshbtn.UseVisualStyleBackColor = False
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(55), CByte(32), CByte(20))
        pnlHeader.Controls.Add(PictureBox2)
        pnlHeader.Controls.Add(lblMyAppointments)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1716, 70)
        pnlHeader.TabIndex = 15
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
        ' lblMyAppointments
        ' 
        lblMyAppointments.AutoSize = True
        lblMyAppointments.Font = New Font("Georgia", 22F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMyAppointments.ForeColor = Color.FromArgb(CByte(255), CByte(243), CByte(222))
        lblMyAppointments.Location = New Point(88, 11)
        lblMyAppointments.Name = "lblMyAppointments"
        lblMyAppointments.Size = New Size(501, 51)
        lblMyAppointments.TabIndex = 0
        lblMyAppointments.Text = "MY APPOINTMENTS"
        ' 
        ' btnGoBackDashboard
        ' 
        btnGoBackDashboard.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnGoBackDashboard.BackColor = Color.SaddleBrown
        btnGoBackDashboard.FlatAppearance.BorderSize = 0
        btnGoBackDashboard.FlatStyle = FlatStyle.Flat
        btnGoBackDashboard.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnGoBackDashboard.ForeColor = Color.WhiteSmoke
        btnGoBackDashboard.Location = New Point(2411, 77)
        btnGoBackDashboard.Margin = New Padding(4)
        btnGoBackDashboard.Name = "btnGoBackDashboard"
        btnGoBackDashboard.Size = New Size(218, 57)
        btnGoBackDashboard.TabIndex = 14
        btnGoBackDashboard.Text = "Dashboard"
        btnGoBackDashboard.UseVisualStyleBackColor = False
        ' 
        ' dgvAppointments
        ' 
        dgvAppointments.AllowUserToAddRows = False
        dgvAppointments.AllowUserToDeleteRows = False
        dgvAppointments.AllowUserToResizeRows = False
        dgvAppointments.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvAppointments.BackgroundColor = Color.FromArgb(CByte(250), CByte(247), CByte(240))
        dgvAppointments.BorderStyle = BorderStyle.None
        dgvAppointments.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvAppointments.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvAppointments.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvAppointments.ColumnHeadersHeight = 42
        dgvAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvAppointments.GridColor = Color.FromArgb(CByte(225), CByte(211), CByte(192))
        dgvAppointments.Location = New Point(34, 154)
        dgvAppointments.Margin = New Padding(4)
        dgvAppointments.MultiSelect = False
        dgvAppointments.Name = "dgvAppointments"
        dgvAppointments.ReadOnly = True
        dgvAppointments.RightToLeft = RightToLeft.No
        dgvAppointments.RowHeadersVisible = False
        dgvAppointments.RowHeadersWidth = 62
        dgvAppointments.RowTemplate.Height = 38
        dgvAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAppointments.Size = New Size(1646, 840)
        dgvAppointments.TabIndex = 13
        ' 
        ' btnAddPet
        ' 
        btnAddPet.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnAddPet.BackColor = Color.FromArgb(CByte(96), CByte(52), CByte(16))
        btnAddPet.FlatAppearance.BorderSize = 0
        btnAddPet.FlatStyle = FlatStyle.Flat
        btnAddPet.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnAddPet.ForeColor = Color.WhiteSmoke
        btnAddPet.Location = New Point(2935, 77)
        btnAddPet.Margin = New Padding(4)
        btnAddPet.Name = "btnAddPet"
        btnAddPet.Size = New Size(240, 57)
        btnAddPet.TabIndex = 12
        btnAddPet.Text = "+ Add Pet"
        btnAddPet.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnRefresh.BackColor = Color.Sienna
        btnRefresh.FlatAppearance.BorderSize = 0
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnRefresh.ForeColor = Color.WhiteSmoke
        btnRefresh.Location = New Point(2685, 77)
        btnRefresh.Margin = New Padding(4)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(195, 57)
        btnRefresh.TabIndex = 11
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = Color.White
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Font = New Font("Segoe UI", 10F)
        txtSearch.ForeColor = Color.FromArgb(CByte(107), CByte(98), CByte(91))
        txtSearch.Location = New Point(34, 88)
        txtSearch.Margin = New Padding(4)
        txtSearch.Multiline = True
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(782, 46)
        txtSearch.TabIndex = 10
        txtSearch.Text = "Search appointment..."
        ' 
        ' FrmAppointments
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1712, 1006)
        Controls.Add(Panel1)
        Name = "FrmAppointments"
        Text = "FrmAppointments"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvAppointments, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblMyAppointments As Label
    Friend WithEvents btnGoBackDashboard As Button
    Friend WithEvents dgvAppointments As DataGridView
    Friend WithEvents btnAddPet As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnAddAppointment As Button
    Friend WithEvents Refreshbtn As Button
End Class
