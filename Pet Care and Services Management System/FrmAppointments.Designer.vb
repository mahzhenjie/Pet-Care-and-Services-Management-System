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
        pnlHeader = New Panel()
        PictureBox2 = New PictureBox()
        lblMyAppointments = New Label()
        btnGoBackDashboard = New Button()
        dgvPets = New DataGridView()
        btnAddPet = New Button()
        btnRefresh = New Button()
        txtSearch = New TextBox()
        btnBackToDashboard = New Button()
        btnAddAppointment = New Button()
        Button3 = New Button()
        colCancel = New DataGridViewButtonColumn()
        colStatus = New DataGridViewTextBoxColumn()
        colType = New DataGridViewTextBoxColumn()
        colService = New DataGridViewTextBoxColumn()
        colPet = New DataGridViewTextBoxColumn()
        colTime = New DataGridViewTextBoxColumn()
        colDate = New DataGridViewTextBoxColumn()
        Panel1.SuspendLayout()
        pnlHeader.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvPets, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(243), CByte(222))
        Panel1.Controls.Add(btnBackToDashboard)
        Panel1.Controls.Add(btnAddAppointment)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(pnlHeader)
        Panel1.Controls.Add(btnGoBackDashboard)
        Panel1.Controls.Add(dgvPets)
        Panel1.Controls.Add(btnAddPet)
        Panel1.Controls.Add(btnRefresh)
        Panel1.Controls.Add(txtSearch)
        Panel1.Location = New Point(-2, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1716, 1008)
        Panel1.TabIndex = 16
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
        dgvPets.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvPets.ColumnHeadersHeight = 42
        dgvPets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvPets.Columns.AddRange(New DataGridViewColumn() {colDate, colTime, colPet, colService, colType, colStatus, colCancel})
        dgvPets.GridColor = Color.FromArgb(CByte(225), CByte(211), CByte(192))
        dgvPets.Location = New Point(34, 154)
        dgvPets.Margin = New Padding(4)
        dgvPets.MultiSelect = False
        dgvPets.Name = "dgvPets"
        dgvPets.ReadOnly = True
        dgvPets.RightToLeft = RightToLeft.No
        dgvPets.RowHeadersVisible = False
        dgvPets.RowHeadersWidth = 62
        dgvPets.RowTemplate.Height = 38
        dgvPets.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPets.Size = New Size(1646, 840)
        dgvPets.TabIndex = 13
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
        txtSearch.Text = "Search booking..."
        ' 
        ' btnBackToDashboard
        ' 
        btnBackToDashboard.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnBackToDashboard.BackColor = Color.SaddleBrown
        btnBackToDashboard.FlatAppearance.BorderSize = 0
        btnBackToDashboard.FlatStyle = FlatStyle.Flat
        btnBackToDashboard.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnBackToDashboard.ForeColor = Color.WhiteSmoke
        btnBackToDashboard.Location = New Point(867, 77)
        btnBackToDashboard.Margin = New Padding(4)
        btnBackToDashboard.Name = "btnBackToDashboard"
        btnBackToDashboard.Size = New Size(218, 57)
        btnBackToDashboard.TabIndex = 18
        btnBackToDashboard.Text = "Dashboard"
        btnBackToDashboard.UseVisualStyleBackColor = False
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
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button3.BackColor = Color.Sienna
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        Button3.ForeColor = Color.WhiteSmoke
        Button3.Location = New Point(1141, 77)
        Button3.Margin = New Padding(4)
        Button3.Name = "Button3"
        Button3.Size = New Size(195, 57)
        Button3.TabIndex = 16
        Button3.Text = "Refresh"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' colCancel
        ' 
        colCancel.FillWeight = 70F
        colCancel.HeaderText = "Cancel Appointment"
        colCancel.MinimumWidth = 2
        colCancel.Name = "colCancel"
        colCancel.ReadOnly = True
        colCancel.Resizable = DataGridViewTriState.True
        colCancel.SortMode = DataGridViewColumnSortMode.Automatic
        colCancel.Text = ""
        colCancel.UseColumnTextForButtonValue = True
        ' 
        ' colStatus
        ' 
        colStatus.HeaderText = "Status"
        colStatus.MinimumWidth = 8
        colStatus.Name = "colStatus"
        colStatus.ReadOnly = True
        ' 
        ' colType
        ' 
        colType.FillWeight = 105F
        colType.HeaderText = "Type"
        colType.MinimumWidth = 6
        colType.Name = "colType"
        colType.ReadOnly = True
        ' 
        ' colService
        ' 
        colService.FillWeight = 120F
        colService.HeaderText = "Service"
        colService.MinimumWidth = 6
        colService.Name = "colService"
        colService.ReadOnly = True
        ' 
        ' colPet
        ' 
        colPet.FillWeight = 120F
        colPet.HeaderText = "Pet"
        colPet.MinimumWidth = 6
        colPet.Name = "colPet"
        colPet.ReadOnly = True
        ' 
        ' colTime
        ' 
        colTime.FillWeight = 85F
        colTime.HeaderText = "Time"
        colTime.MinimumWidth = 6
        colTime.Name = "colTime"
        colTime.ReadOnly = True
        ' 
        ' colDate
        ' 
        colDate.FillWeight = 75F
        colDate.HeaderText = "Date"
        colDate.MinimumWidth = 6
        colDate.Name = "colDate"
        colDate.ReadOnly = True
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
        CType(dgvPets, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblMyAppointments As Label
    Friend WithEvents btnGoBackDashboard As Button
    Friend WithEvents dgvPets As DataGridView
    Friend WithEvents btnAddPet As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnBackToDashboard As Button
    Friend WithEvents btnAddAppointment As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents colDate As DataGridViewTextBoxColumn
    Friend WithEvents colTime As DataGridViewTextBoxColumn
    Friend WithEvents colPet As DataGridViewTextBoxColumn
    Friend WithEvents colService As DataGridViewTextBoxColumn
    Friend WithEvents colType As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents colCancel As DataGridViewButtonColumn
End Class
