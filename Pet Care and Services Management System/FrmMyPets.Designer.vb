<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMyPets
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMyPets))
        btnGoBackDashboard = New Button()
        dgvPets = New DataGridView()
        colPetID = New DataGridViewTextBoxColumn()
        colPetName = New DataGridViewTextBoxColumn()
        colGender = New DataGridViewTextBoxColumn()
        colBreed = New DataGridViewTextBoxColumn()
        colWeight = New DataGridViewTextBoxColumn()
        Temperament = New DataGridViewTextBoxColumn()
        colEdit = New DataGridViewButtonColumn()
        colDelete = New DataGridViewButtonColumn()
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
        ' btnGoBackDashboard
        ' 
        btnGoBackDashboard.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnGoBackDashboard.BackColor = Color.SaddleBrown
        btnGoBackDashboard.FlatAppearance.BorderSize = 0
        btnGoBackDashboard.FlatStyle = FlatStyle.Flat
        btnGoBackDashboard.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnGoBackDashboard.ForeColor = Color.WhiteSmoke
        btnGoBackDashboard.Location = New Point(895, 77)
        btnGoBackDashboard.Margin = New Padding(4)
        btnGoBackDashboard.Name = "btnGoBackDashboard"
        btnGoBackDashboard.Size = New Size(218, 57)
        btnGoBackDashboard.TabIndex = 14
        btnGoBackDashboard.Text = "Dashboard"
        btnGoBackDashboard.UseVisualStyleBackColor = False
        ' 
        ' dgvPets
        ' 
        dgvPets.AllowUserToAddRows = False
        dgvPets.AllowUserToDeleteRows = False
        dgvPets.AllowUserToResizeRows = False
        dgvPets.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvPets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPets.BackgroundColor = Color.FromArgb(CByte(250), CByte(247), CByte(240))
        dgvPets.BorderStyle = BorderStyle.None
        dgvPets.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvPets.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvPets.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvPets.ColumnHeadersHeight = 42
        dgvPets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvPets.Columns.AddRange(New DataGridViewColumn() {colPetID, colPetName, colGender, colBreed, colWeight, Temperament, colEdit, colDelete})
        dgvPets.GridColor = Color.FromArgb(CByte(225), CByte(211), CByte(192))
        dgvPets.Location = New Point(34, 151)
        dgvPets.Margin = New Padding(4)
        dgvPets.MultiSelect = False
        dgvPets.Name = "dgvPets"
        dgvPets.ReadOnly = True
        dgvPets.RightToLeft = RightToLeft.No
        dgvPets.RowHeadersVisible = False
        dgvPets.RowHeadersWidth = 62
        dgvPets.RowTemplate.Height = 38
        dgvPets.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPets.Size = New Size(1649, 824)
        dgvPets.TabIndex = 13
        ' 
        ' colPetID
        ' 
        colPetID.FillWeight = 75F
        colPetID.HeaderText = "Pet ID"
        colPetID.MinimumWidth = 6
        colPetID.Name = "colPetID"
        colPetID.ReadOnly = True
        ' 
        ' colPetName
        ' 
        colPetName.FillWeight = 85F
        colPetName.HeaderText = "Pet Name"
        colPetName.MinimumWidth = 6
        colPetName.Name = "colPetName"
        colPetName.ReadOnly = True
        ' 
        ' colGender
        ' 
        colGender.FillWeight = 120F
        colGender.HeaderText = "Gender"
        colGender.MinimumWidth = 6
        colGender.Name = "colGender"
        colGender.ReadOnly = True
        ' 
        ' colBreed
        ' 
        colBreed.FillWeight = 120F
        colBreed.HeaderText = "Breed"
        colBreed.MinimumWidth = 6
        colBreed.Name = "colBreed"
        colBreed.ReadOnly = True
        ' 
        ' colWeight
        ' 
        colWeight.FillWeight = 105F
        colWeight.HeaderText = "Weight"
        colWeight.MinimumWidth = 6
        colWeight.Name = "colWeight"
        colWeight.ReadOnly = True
        ' 
        ' Temperament
        ' 
        Temperament.HeaderText = "Temperament"
        Temperament.MinimumWidth = 8
        Temperament.Name = "Temperament"
        Temperament.ReadOnly = True
        ' 
        ' colEdit
        ' 
        colEdit.FillWeight = 70F
        colEdit.HeaderText = "Edit"
        colEdit.MinimumWidth = 6
        colEdit.Name = "colEdit"
        colEdit.ReadOnly = True
        colEdit.Resizable = DataGridViewTriState.True
        colEdit.SortMode = DataGridViewColumnSortMode.Automatic
        colEdit.Text = "Edit"
        colEdit.UseColumnTextForButtonValue = True
        ' 
        ' colDelete
        ' 
        colDelete.FillWeight = 75F
        colDelete.HeaderText = "Delete"
        colDelete.MinimumWidth = 6
        colDelete.Name = "colDelete"
        colDelete.ReadOnly = True
        colDelete.Resizable = DataGridViewTriState.True
        colDelete.SortMode = DataGridViewColumnSortMode.Automatic
        colDelete.Text = "Delete"
        colDelete.UseColumnTextForButtonValue = True
        ' 
        ' btnAddPet
        ' 
        btnAddPet.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnAddPet.BackColor = Color.FromArgb(CByte(96), CByte(52), CByte(16))
        btnAddPet.FlatAppearance.BorderSize = 0
        btnAddPet.FlatStyle = FlatStyle.Flat
        btnAddPet.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnAddPet.ForeColor = Color.WhiteSmoke
        btnAddPet.Location = New Point(1419, 77)
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
        btnRefresh.Location = New Point(1169, 77)
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
        txtSearch.Text = "Search booking..."
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(243), CByte(222))
        Panel1.Controls.Add(pnlHeader)
        Panel1.Controls.Add(btnGoBackDashboard)
        Panel1.Controls.Add(dgvPets)
        Panel1.Controls.Add(btnAddPet)
        Panel1.Controls.Add(btnRefresh)
        Panel1.Controls.Add(txtSearch)
        Panel1.Location = New Point(0, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1716, 1008)
        Panel1.TabIndex = 15
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(55), CByte(32), CByte(20))
        pnlHeader.Controls.Add(PictureBox2)
        pnlHeader.Controls.Add(Label1)
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Georgia", 22F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(255), CByte(243), CByte(222))
        Label1.Location = New Point(88, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(232, 51)
        Label1.TabIndex = 0
        Label1.Text = "MY PETS"
        ' 
        ' FrmMyPets
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(235), CByte(221), CByte(202))
        ClientSize = New Size(1712, 1006)
        Controls.Add(Panel1)
        Name = "FrmMyPets"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FrmMyPets"
        CType(dgvPets, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnGoBackDashboard As Button
    Friend WithEvents dgvPets As DataGridView
    Friend WithEvents btnAddPet As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents colPetID As DataGridViewTextBoxColumn
    Friend WithEvents colPetName As DataGridViewTextBoxColumn
    Friend WithEvents colGender As DataGridViewTextBoxColumn
    Friend WithEvents colBreed As DataGridViewTextBoxColumn
    Friend WithEvents colWeight As DataGridViewTextBoxColumn
    Friend WithEvents Temperament As DataGridViewTextBoxColumn
    Friend WithEvents colEdit As DataGridViewButtonColumn
    Friend WithEvents colDelete As DataGridViewButtonColumn
End Class
