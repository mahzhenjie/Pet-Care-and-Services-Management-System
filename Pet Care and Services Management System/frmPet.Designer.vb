<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPet
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
        pnlPet = New Panel()
        btnGoBackDashboard = New Button()
        txtSearch = New TextBox()
        btnAddPet = New Button()
        btnRefresh = New Button()
        dgvPet = New DataGridView()
        colPetID = New DataGridViewTextBoxColumn()
        colCustomerID = New DataGridViewTextBoxColumn()
        colPetName = New DataGridViewTextBoxColumn()
        colGender = New DataGridViewTextBoxColumn()
        colBreed = New DataGridViewTextBoxColumn()
        colWeight = New DataGridViewTextBoxColumn()
        colTemperament = New DataGridViewTextBoxColumn()
        colEdit = New DataGridViewButtonColumn()
        colDelete = New DataGridViewButtonColumn()
        lblTitle = New Label()
        pnlPet.SuspendLayout()
        CType(dgvPet, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlPet
        ' 
        pnlPet.Anchor = CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles)
        pnlPet.BackColor = Color.FromArgb(245, 230, 209)
        pnlPet.Controls.Add(btnGoBackDashboard)
        pnlPet.Controls.Add(txtSearch)
        pnlPet.Controls.Add(btnAddPet)
        pnlPet.Controls.Add(btnRefresh)
        pnlPet.Controls.Add(dgvPet)
        pnlPet.Controls.Add(lblTitle)
        pnlPet.Location = New Point(15, 15)
        pnlPet.Name = "pnlPet"
        pnlPet.Padding = New Padding(20)
        pnlPet.Size = New Size(1130, 770)
        pnlPet.TabIndex = 1
        ' 
        ' btnGoBackDashboard
        ' 
        btnGoBackDashboard.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnGoBackDashboard.BackColor = Color.SaddleBrown
        btnGoBackDashboard.FlatAppearance.BorderSize = 0
        btnGoBackDashboard.FlatStyle = FlatStyle.Flat
        btnGoBackDashboard.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnGoBackDashboard.ForeColor = Color.WhiteSmoke
        btnGoBackDashboard.Location = New Point(625, 82)
        btnGoBackDashboard.Name = "btnGoBackDashboard"
        btnGoBackDashboard.Size = New Size(145, 38)
        btnGoBackDashboard.TabIndex = 8
        btnGoBackDashboard.Text = "Dashboard"
        btnGoBackDashboard.UseVisualStyleBackColor = False
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
        txtSearch.TabIndex = 7
        txtSearch.Text = "Search customer..."
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
        btnAddPet.TabIndex = 6
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
        btnRefresh.TabIndex = 3
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' dgvPet
        ' 
        dgvPet.AllowUserToAddRows = False
        dgvPet.AllowUserToDeleteRows = False
        dgvPet.AllowUserToResizeRows = False
        dgvPet.Anchor = CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles)
        dgvPet.AutoGenerateColumns = False
        dgvPet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPet.BackgroundColor = Color.FromArgb(250, 247, 240)
        dgvPet.BorderStyle = BorderStyle.None
        dgvPet.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvPet.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvPet.ColumnHeadersDefaultCellStyle = New DataGridViewCellStyle With {
            .BackColor = Color.FromArgb(96, 52, 16),
            .ForeColor = Color.WhiteSmoke,
            .Font = New Font("Segoe UI", 9.5F, FontStyle.Bold),
            .Alignment = DataGridViewContentAlignment.MiddleLeft,
            .SelectionBackColor = Color.FromArgb(96, 52, 16),
            .SelectionForeColor = Color.WhiteSmoke
        }
        dgvPet.ColumnHeadersHeight = 42
        dgvPet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvPet.Columns.AddRange(New DataGridViewColumn() {
            colPetID,
            colCustomerID,
            colPetName,
            colGender,
            colBreed,
            colWeight,
            colTemperament,
            colEdit,
            colDelete
        })
        dgvPet.DefaultCellStyle = New DataGridViewCellStyle With {
            .BackColor = Color.White,
            .ForeColor = Color.FromArgb(61, 40, 27),
            .Font = New Font("Segoe UI", 9.0F),
            .SelectionBackColor = Color.FromArgb(232, 216, 194),
            .SelectionForeColor = Color.FromArgb(61, 40, 27),
            .Alignment = DataGridViewContentAlignment.MiddleLeft
        }
        dgvPet.GridColor = Color.FromArgb(225, 211, 192)
        dgvPet.Location = New Point(20, 140)
        dgvPet.MultiSelect = False
        dgvPet.Name = "dgvPet"
        dgvPet.ReadOnly = True
        dgvPet.RowHeadersVisible = False
        dgvPet.RowTemplate.Height = 38
        dgvPet.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPet.Size = New Size(1090, 605)
        dgvPet.TabIndex = 3
        ' 
        ' colPetID
        ' 
        colPetID.FillWeight = 80.0F
        colPetID.HeaderText = "Pet ID"
        colPetID.MinimumWidth = 6
        colPetID.Name = "colPetID"
        colPetID.ReadOnly = True
        ' 
        ' colCustomerID
        ' 
        colCustomerID.FillWeight = 90.0F
        colCustomerID.HeaderText = "Customer ID"
        colCustomerID.MinimumWidth = 6
        colCustomerID.Name = "colCustomerID"
        colCustomerID.ReadOnly = True
        ' 
        ' colPetName
        ' 
        colPetName.FillWeight = 105.0F
        colPetName.HeaderText = "Pet Name"
        colPetName.MinimumWidth = 6
        colPetName.Name = "colPetName"
        colPetName.ReadOnly = True
        ' 
        ' colGender
        ' 
        colGender.FillWeight = 80.0F
        colGender.HeaderText = "Gender"
        colGender.MinimumWidth = 6
        colGender.Name = "colGender"
        colGender.ReadOnly = True
        ' 
        ' colBreed
        ' 
        colBreed.FillWeight = 110.0F
        colBreed.HeaderText = "Breed"
        colBreed.MinimumWidth = 6
        colBreed.Name = "colBreed"
        colBreed.ReadOnly = True
        ' 
        ' colWeight
        ' 
        colWeight.FillWeight = 80.0F
        colWeight.HeaderText = "Weight"
        colWeight.MinimumWidth = 6
        colWeight.Name = "colWeight"
        colWeight.ReadOnly = True
        ' 
        ' colTemperament
        ' 
        colTemperament.FillWeight = 115.0F
        colTemperament.HeaderText = "Temperament"
        colTemperament.MinimumWidth = 6
        colTemperament.Name = "colTemperament"
        colTemperament.ReadOnly = True
        ' 
        ' colEdit
        ' 
        colEdit.FillWeight = 70.0F
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
        colDelete.FillWeight = 70.0F
        colDelete.HeaderText = "Delete"
        colDelete.MinimumWidth = 6
        colDelete.Name = "colDelete"
        colDelete.ReadOnly = True
        colDelete.Resizable = DataGridViewTriState.True
        colDelete.SortMode = DataGridViewColumnSortMode.Automatic
        colDelete.Text = "Delete"
        colDelete.UseColumnTextForButtonValue = True
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Georgia", 20.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(61, 40, 27)
        lblTitle.Location = New Point(20, 20)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(280, 39)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Pet Management"
        ' 
        ' frmPet
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(235, 221, 202)
        ClientSize = New Size(1160, 800)
        Controls.Add(pnlPet)
        MinimumSize = New Size(1050, 700)
        Name = "frmPet"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pet Management"
        pnlPet.ResumeLayout(False)
        pnlPet.PerformLayout()
        CType(dgvPet, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlPet As System.Windows.Forms.Panel
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnAddPet As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents dgvPet As System.Windows.Forms.DataGridView
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents colPetID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCustomerID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPetName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colGender As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colBreed As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colWeight As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTemperament As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEdit As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colDelete As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents btnGoBackDashboard As Button

End Class