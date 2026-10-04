<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAppointments
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer.
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAppointments))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        btnDashboard = New Button()
        btnAddAppointment = New Button()
        Refreshbtn = New Button()
        pnlHeader = New Panel()
        PictureBox2 = New PictureBox()
        lblMyAppointments = New Label()
        dgvAppointments = New DataGridView()
        txtSearch = New TextBox()
        Panel1.SuspendLayout()
        pnlHeader.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvAppointments, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.BackColor = Color.FromArgb(CByte(245), CByte(230), CByte(209))
        Panel1.Controls.Add(btnDashboard)
        Panel1.Controls.Add(btnAddAppointment)
        Panel1.Controls.Add(Refreshbtn)
        Panel1.Controls.Add(pnlHeader)
        Panel1.Controls.Add(dgvAppointments)
        Panel1.Controls.Add(txtSearch)
        Panel1.Location = New Point(15, 15)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(20)
        Panel1.Size = New Size(1130, 770)
        Panel1.TabIndex = 0
        ' 
        ' btnDashboard
        ' 
        btnDashboard.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnDashboard.BackColor = Color.SaddleBrown
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnDashboard.ForeColor = Color.WhiteSmoke
        btnDashboard.Location = New Point(624, 98)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(145, 38)
        btnDashboard.TabIndex = 8
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
        btnAddAppointment.Location = New Point(932, 98)
        btnAddAppointment.Name = "btnAddAppointment"
        btnAddAppointment.Size = New Size(160, 38)
        btnAddAppointment.TabIndex = 7
        btnAddAppointment.Text = "+ Add Appointment"
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
        Refreshbtn.Location = New Point(784, 98)
        Refreshbtn.Name = "Refreshbtn"
        Refreshbtn.Size = New Size(130, 38)
        Refreshbtn.TabIndex = 3
        Refreshbtn.Text = "Refresh"
        Refreshbtn.UseVisualStyleBackColor = False
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(55), CByte(32), CByte(20))
        pnlHeader.Controls.Add(PictureBox2)
        pnlHeader.Controls.Add(lblMyAppointments)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(20, 20)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1090, 65)
        pnlHeader.TabIndex = 0
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(3, 6)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(70, 53)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' lblMyAppointments
        ' 
        lblMyAppointments.AutoSize = True
        lblMyAppointments.Font = New Font("Georgia", 20.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMyAppointments.ForeColor = Color.FromArgb(CByte(255), CByte(243), CByte(222))
        lblMyAppointments.Location = New Point(70, 13)
        lblMyAppointments.Name = "lblMyAppointments"
        lblMyAppointments.Size = New Size(389, 39)
        lblMyAppointments.TabIndex = 0
        lblMyAppointments.Text = "MY APPOINTMENTS"
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
        dgvAppointments.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvAppointments.ColumnHeadersHeight = 42
        dgvAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvAppointments.GridColor = Color.FromArgb(CByte(225), CByte(211), CByte(192))
        dgvAppointments.Location = New Point(17, 155)
        dgvAppointments.MultiSelect = False
        dgvAppointments.Name = "dgvAppointments"
        dgvAppointments.ReadOnly = True
        dgvAppointments.RowHeadersVisible = False
        dgvAppointments.RowHeadersWidth = 51
        dgvAppointments.RowTemplate.Height = 38
        dgvAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAppointments.Size = New Size(1090, 590)
        dgvAppointments.TabIndex = 3
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = Color.White
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Font = New Font("Segoe UI", 10.0F)
        txtSearch.ForeColor = Color.FromArgb(CByte(107), CByte(98), CByte(91))
        txtSearch.Location = New Point(20, 104)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(575, 30)
        txtSearch.TabIndex = 1
        txtSearch.Text = "Search appointment..."
        ' 
        ' FrmAppointments
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(235), CByte(221), CByte(202))
        ClientSize = New Size(1160, 800)
        Controls.Add(Panel1)
        MinimumSize = New Size(1050, 700)
        Name = "FrmAppointments"
        StartPosition = FormStartPosition.CenterScreen
        Text = "My Appointments"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvAppointments, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblMyAppointments As System.Windows.Forms.Label
    Friend WithEvents dgvAppointments As System.Windows.Forms.DataGridView
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnDashboard As System.Windows.Forms.Button
    Friend WithEvents btnAddAppointment As System.Windows.Forms.Button
    Friend WithEvents Refreshbtn As System.Windows.Forms.Button

End Class