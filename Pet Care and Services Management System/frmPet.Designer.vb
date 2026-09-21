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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
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
        pnlPet.BackColor = Color.FromArgb(CByte(232), CByte(216), CByte(194))
        pnlPet.Controls.Add(btnGoBackDashboard)
        pnlPet.Controls.Add(txtSearch)
        pnlPet.Controls.Add(btnAddPet)
        pnlPet.Controls.Add(btnRefresh)
        pnlPet.Controls.Add(dgvPet)
        pnlPet.Controls.Add(lblTitle)
        pnlPet.ForeColor = Color.SaddleBrown
        pnlPet.Location = New Point(12, 12)
        pnlPet.Name = "pnlPet"
        pnlPet.Size = New Size(920, 580)
        pnlPet.TabIndex = 1
        ' 
        ' btnGoBackDashboard
        ' 
        btnGoBackDashboard.BackColor = Color.SaddleBrown
        btnGoBackDashboard.Font = New Font("Lucida Sans Unicode", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnGoBackDashboard.ForeColor = Color.WhiteSmoke
        btnGoBackDashboard.Location = New Point(469, 44)
        btnGoBackDashboard.Name = "btnGoBackDashboard"
        btnGoBackDashboard.Size = New Size(137, 34)
        btnGoBackDashboard.TabIndex = 8
        btnGoBackDashboard.Text = "Dashboard"
        btnGoBackDashboard.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Lucida Sans Unicode", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearch.ForeColor = Color.Sienna
        txtSearch.Location = New Point(24, 64)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(398, 27)
        txtSearch.TabIndex = 7
        txtSearch.Text = "Search customer..."
        ' 
        ' btnAddPet
        ' 
        btnAddPet.BackColor = Color.SaddleBrown
        btnAddPet.Font = New Font("Lucida Sans Unicode", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAddPet.ForeColor = Color.WhiteSmoke
        btnAddPet.Location = New Point(612, 44)
        btnAddPet.Name = "btnAddPet"
        btnAddPet.Size = New Size(137, 34)
        btnAddPet.TabIndex = 6
        btnAddPet.Text = "+Add Pet"
        btnAddPet.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.SaddleBrown
        btnRefresh.Font = New Font("Lucida Sans Unicode", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRefresh.ForeColor = Color.WhiteSmoke
        btnRefresh.Location = New Point(755, 44)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(137, 34)
        btnRefresh.TabIndex = 3
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' dgvPet
        ' 
        dgvPet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPet.BackgroundColor = Color.FromArgb(CByte(244), CByte(239), CByte(227))
        dgvPet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPet.Columns.AddRange(New DataGridViewColumn() {colPetID, colCustomerID, colPetName, colGender, colBreed, colWeight, colTemperament, colEdit, colDelete})
        dgvPet.GridColor = Color.Sienna
        dgvPet.Location = New Point(24, 97)
        dgvPet.Name = "dgvPet"
        dgvPet.RightToLeft = RightToLeft.No
        dgvPet.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        dgvPet.RowHeadersWidth = 51
        dgvPet.RowTemplate.Height = 24
        dgvPet.Size = New Size(868, 455)
        dgvPet.TabIndex = 3
        ' 
        ' colPetID
        ' 
        colPetID.FillWeight = 135F
        colPetID.HeaderText = "Pet ID"
        colPetID.MinimumWidth = 6
        colPetID.Name = "colPetID"
        ' 
        ' colCustomerID
        ' 
        colCustomerID.FillWeight = 135F
        colCustomerID.HeaderText = "CustomerID"
        colCustomerID.MinimumWidth = 6
        colCustomerID.Name = "colCustomerID"
        ' 
        ' colPetName
        ' 
        colPetName.HeaderText = "Pet Name"
        colPetName.MinimumWidth = 6
        colPetName.Name = "colPetName"
        ' 
        ' colGender
        ' 
        colGender.HeaderText = "Gender"
        colGender.MinimumWidth = 6
        colGender.Name = "colGender"
        ' 
        ' colBreed
        ' 
        colBreed.HeaderText = "Breed"
        colBreed.MinimumWidth = 6
        colBreed.Name = "colBreed"
        ' 
        ' colWeight
        ' 
        colWeight.HeaderText = "Wieght"
        colWeight.MinimumWidth = 6
        colWeight.Name = "colWeight"
        ' 
        ' colTemperament
        ' 
        colTemperament.HeaderText = "Temperament"
        colTemperament.MinimumWidth = 6
        colTemperament.Name = "colTemperament"
        ' 
        ' colEdit
        ' 
        colEdit.HeaderText = "Edit"
        colEdit.MinimumWidth = 6
        colEdit.Name = "colEdit"
        ' 
        ' colDelete
        ' 
        colDelete.HeaderText = "Delete"
        colDelete.MinimumWidth = 6
        colDelete.Name = "colDelete"
        colDelete.Text = "[Delete]"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Lucida Sans Unicode", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(20, 15)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(252, 34)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Pet Management"
        ' 
        ' frmPet
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(942, 603)
        Controls.Add(pnlPet)
        Name = "frmPet"
        Text = "Form1"
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