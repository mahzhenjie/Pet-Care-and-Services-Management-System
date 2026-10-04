<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMyPets
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
    'It can be modified using the code editor.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMyPets))
        btnDashboard = New Button()
        dgvPets = New DataGridView()
        btnAddPet = New Button()
        btnRefresh = New Button()
        txtSearch = New TextBox()
        Panel1 = New Panel()
        pnlHeader = New Panel()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        CType(dgvPets, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        pnlHeader.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnDashboard
        ' 
        btnDashboard.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnDashboard.BackColor = Color.SaddleBrown
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnDashboard.ForeColor = Color.WhiteSmoke
        btnDashboard.Location = New Point(625, 82)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(145, 38)
        btnDashboard.TabIndex = 14
        btnDashboard.Text = "Dashboard"
        btnDashboard.UseVisualStyleBackColor = False
        ' 
        ' dgvPets
        ' 
        dgvPets.AllowUserToAddRows = False
        dgvPets.AllowUserToDeleteRows = False
        dgvPets.AllowUserToResizeRows = False
        dgvPets.Anchor = CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles)
        dgvPets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPets.BackgroundColor = Color.FromArgb(250, 247, 240)
        dgvPets.BorderStyle = BorderStyle.None
        dgvPets.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvPets.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.BackColor = Color.FromArgb(96, 52, 16)
        DataGridViewCellStyle1.ForeColor = Color.WhiteSmoke
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(96, 52, 16)
        DataGridViewCellStyle1.SelectionForeColor = Color.WhiteSmoke
        dgvPets.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvPets.ColumnHeadersHeight = 42
        dgvPets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvPets.DefaultCellStyle = New DataGridViewCellStyle With {
            .BackColor = Color.White,
            .ForeColor = Color.FromArgb(61, 40, 27),
            .Font = New Font("Segoe UI", 9.0F),
            .SelectionBackColor = Color.FromArgb(232, 216, 194),
            .SelectionForeColor = Color.FromArgb(61, 40, 27),
            .Alignment = DataGridViewContentAlignment.MiddleLeft
        }
        dgvPets.GridColor = Color.FromArgb(225, 211, 192)
        dgvPets.Location = New Point(20, 140)
        dgvPets.MultiSelect = False
        dgvPets.Name = "dgvPets"
        dgvPets.ReadOnly = True
        dgvPets.RightToLeft = RightToLeft.No
        dgvPets.RowHeadersVisible = False
        dgvPets.RowTemplate.Height = 38
        dgvPets.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPets.Size = New Size(1090, 605)
        dgvPets.TabIndex = 13
        ' 
        ' btnAddPet
        ' 
        btnAddPet.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnAddPet.BackColor = Color.FromArgb(96, 52, 16)
        btnAddPet.FlatAppearance.BorderSize = 0
        btnAddPet.FlatStyle = FlatStyle.Flat
        btnAddPet.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnAddPet.ForeColor = Color.WhiteSmoke
        btnAddPet.Location = New Point(930, 82)
        btnAddPet.Name = "btnAddPet"
        btnAddPet.Size = New Size(160, 38)
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
        btnRefresh.Location = New Point(785, 82)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(130, 38)
        btnRefresh.TabIndex = 11
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        txtSearch.BackColor = Color.White
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Font = New Font("Segoe UI", 10.0F)
        txtSearch.ForeColor = Color.FromArgb(107, 98, 91)
        txtSearch.Location = New Point(20, 84)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(575, 30)
        txtSearch.TabIndex = 10
        txtSearch.Text = "Search Pet Name..."
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles)
        Panel1.BackColor = Color.FromArgb(245, 230, 209)
        Panel1.Controls.Add(pnlHeader)
        Panel1.Controls.Add(btnDashboard)
        Panel1.Controls.Add(dgvPets)
        Panel1.Controls.Add(btnAddPet)
        Panel1.Controls.Add(btnRefresh)
        Panel1.Controls.Add(txtSearch)
        Panel1.Location = New Point(15, 15)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(20)
        Panel1.Size = New Size(1130, 770)
        Panel1.TabIndex = 15
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(96, 52, 16)
        pnlHeader.Controls.Add(PictureBox2)
        pnlHeader.Controls.Add(Label1)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(20, 20)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1090, 55)
        pnlHeader.TabIndex = 15
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(10, 4)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(70, 48)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Georgia", 20.0F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(255, 243, 222)
        Label1.Location = New Point(88, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(210, 38)
        Label1.TabIndex = 0
        Label1.Text = "MY PETS"
        ' 
        ' FrmMyPets
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(235, 221, 202)
        ClientSize = New Size(1160, 800)
        Controls.Add(Panel1)
        MinimumSize = New Size(1050, 700)
        Name = "FrmMyPets"
        StartPosition = FormStartPosition.CenterScreen
        Text = "My Pets"
        CType(dgvPets, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents btnDashboard As Button
    Friend WithEvents dgvPets As DataGridView
    Friend WithEvents btnAddPet As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label

End Class