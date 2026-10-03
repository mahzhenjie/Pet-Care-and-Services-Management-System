<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMyPayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMyPayment))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlProduct = New Panel()
        Button2 = New Button()
        Button4 = New Button()
        pnlHeader = New Panel()
        PictureBox2 = New PictureBox()
        lblTitle = New Label()
        Button1 = New Button()
        dgvProduct = New DataGridView()
        Button3 = New Button()
        btnGoBackDashboard = New Button()
        btnAddProduct = New Button()
        btnRefresh = New Button()
        colPaymentID = New DataGridViewTextBoxColumn()
        colDate = New DataGridViewTextBoxColumn()
        colAmount = New DataGridViewTextBoxColumn()
        colMethod = New DataGridViewTextBoxColumn()
        colType = New DataGridViewTextBoxColumn()
        colStatus = New DataGridViewTextBoxColumn()
        pnlProduct.SuspendLayout()
        pnlHeader.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvProduct, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlProduct
        ' 
        pnlProduct.BackColor = Color.FromArgb(CByte(245), CByte(230), CByte(209))
        pnlProduct.Controls.Add(Button2)
        pnlProduct.Controls.Add(Button4)
        pnlProduct.Controls.Add(pnlHeader)
        pnlProduct.Controls.Add(Button1)
        pnlProduct.Controls.Add(dgvProduct)
        pnlProduct.Controls.Add(Button3)
        pnlProduct.Controls.Add(btnGoBackDashboard)
        pnlProduct.Controls.Add(btnAddProduct)
        pnlProduct.Controls.Add(btnRefresh)
        pnlProduct.Dock = DockStyle.Fill
        pnlProduct.Location = New Point(0, 0)
        pnlProduct.Margin = New Padding(4)
        pnlProduct.Name = "pnlProduct"
        pnlProduct.Padding = New Padding(30)
        pnlProduct.Size = New Size(1037, 659)
        pnlProduct.TabIndex = 6
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button2.BackColor = Color.SaddleBrown
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        Button2.ForeColor = Color.WhiteSmoke
        Button2.Location = New Point(1653, 133)
        Button2.Margin = New Padding(4)
        Button2.Name = "Button2"
        Button2.Size = New Size(218, 57)
        Button2.TabIndex = 19
        Button2.Text = "Dashboard"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button4.BackColor = Color.Sienna
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        Button4.ForeColor = Color.WhiteSmoke
        Button4.Location = New Point(1434, 133)
        Button4.Margin = New Padding(4)
        Button4.Name = "Button4"
        Button4.Size = New Size(195, 57)
        Button4.TabIndex = 18
        Button4.Text = "Refresh"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(55), CByte(32), CByte(20))
        pnlHeader.Controls.Add(PictureBox2)
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1675, 70)
        pnlHeader.TabIndex = 17
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
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Georgia", 22F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.FromArgb(CByte(255), CByte(243), CByte(222))
        lblTitle.Location = New Point(95, 9)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(379, 51)
        lblTitle.TabIndex = 0
        lblTitle.Text = "MY PAYMENTS"
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.BackColor = Color.SaddleBrown
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        Button1.ForeColor = Color.WhiteSmoke
        Button1.Location = New Point(2617, 176)
        Button1.Margin = New Padding(4)
        Button1.Name = "Button1"
        Button1.Size = New Size(218, 57)
        Button1.TabIndex = 16
        Button1.Text = "Dashboard"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' dgvProduct
        ' 
        dgvProduct.AllowUserToAddRows = False
        dgvProduct.AllowUserToDeleteRows = False
        dgvProduct.AllowUserToResizeRows = False
        dgvProduct.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvProduct.BackgroundColor = Color.FromArgb(CByte(250), CByte(247), CByte(240))
        dgvProduct.BorderStyle = BorderStyle.None
        dgvProduct.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvProduct.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvProduct.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvProduct.ColumnHeadersHeight = 42
        dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvProduct.Columns.AddRange(New DataGridViewColumn() {colPaymentID, colDate, colAmount, colMethod, colType, colStatus})
        dgvProduct.GridColor = Color.FromArgb(CByte(225), CByte(211), CByte(192))
        dgvProduct.Location = New Point(34, 93)
        dgvProduct.Margin = New Padding(4)
        dgvProduct.MultiSelect = False
        dgvProduct.Name = "dgvProduct"
        dgvProduct.ReadOnly = True
        dgvProduct.RightToLeft = RightToLeft.No
        dgvProduct.RowHeadersVisible = False
        dgvProduct.RowHeadersWidth = 62
        dgvProduct.RowTemplate.Height = 70
        dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvProduct.Size = New Size(972, 532)
        dgvProduct.TabIndex = 7
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button3.BackColor = Color.Sienna
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        Button3.ForeColor = Color.WhiteSmoke
        Button3.Location = New Point(2857, 176)
        Button3.Margin = New Padding(4)
        Button3.Name = "Button3"
        Button3.Size = New Size(195, 57)
        Button3.TabIndex = 14
        Button3.Text = "Refresh"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' btnGoBackDashboard
        ' 
        btnGoBackDashboard.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnGoBackDashboard.BackColor = Color.SaddleBrown
        btnGoBackDashboard.FlatAppearance.BorderSize = 0
        btnGoBackDashboard.FlatStyle = FlatStyle.Flat
        btnGoBackDashboard.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnGoBackDashboard.ForeColor = Color.WhiteSmoke
        btnGoBackDashboard.Location = New Point(4084, 213)
        btnGoBackDashboard.Margin = New Padding(4)
        btnGoBackDashboard.Name = "btnGoBackDashboard"
        btnGoBackDashboard.Size = New Size(218, 57)
        btnGoBackDashboard.TabIndex = 13
        btnGoBackDashboard.Text = "Dashboard"
        btnGoBackDashboard.UseVisualStyleBackColor = False
        ' 
        ' btnAddProduct
        ' 
        btnAddProduct.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnAddProduct.BackColor = Color.SaddleBrown
        btnAddProduct.FlatAppearance.BorderSize = 0
        btnAddProduct.FlatStyle = FlatStyle.Flat
        btnAddProduct.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnAddProduct.ForeColor = Color.WhiteSmoke
        btnAddProduct.Location = New Point(4541, 213)
        btnAddProduct.Margin = New Padding(4)
        btnAddProduct.Name = "btnAddProduct"
        btnAddProduct.Size = New Size(240, 57)
        btnAddProduct.TabIndex = 6
        btnAddProduct.Text = "+ Add Product"
        btnAddProduct.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnRefresh.BackColor = Color.Sienna
        btnRefresh.FlatAppearance.BorderSize = 0
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnRefresh.ForeColor = Color.WhiteSmoke
        btnRefresh.Location = New Point(4324, 213)
        btnRefresh.Margin = New Padding(4)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(195, 57)
        btnRefresh.TabIndex = 3
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' colPaymentID
        ' 
        colPaymentID.FillWeight = 97.9212F
        colPaymentID.HeaderText = "Payment ID"
        colPaymentID.MinimumWidth = 6
        colPaymentID.Name = "colPaymentID"
        colPaymentID.ReadOnly = True
        ' 
        ' colDate
        ' 
        colDate.FillWeight = 146.8818F
        colDate.HeaderText = "Date"
        colDate.MinimumWidth = 6
        colDate.Name = "colDate"
        colDate.ReadOnly = True
        ' 
        ' colAmount
        ' 
        colAmount.FillWeight = 75.9943161F
        colAmount.HeaderText = "Amount"
        colAmount.MinimumWidth = 6
        colAmount.Name = "colAmount"
        colAmount.ReadOnly = True
        ' 
        ' colMethod
        ' 
        colMethod.FillWeight = 91.80114F
        colMethod.HeaderText = "Method"
        colMethod.MinimumWidth = 6
        colMethod.Name = "colMethod"
        colMethod.ReadOnly = True
        ' 
        ' colType
        ' 
        colType.FillWeight = 122.401512F
        colType.HeaderText = "Type"
        colType.MinimumWidth = 8
        colType.Name = "colType"
        colType.ReadOnly = True
        ' 
        ' colStatus
        ' 
        colStatus.HeaderText = "Status"
        colStatus.MinimumWidth = 8
        colStatus.Name = "colStatus"
        colStatus.ReadOnly = True
        ' 
        ' FrmMyPayment
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1037, 659)
        Controls.Add(pnlProduct)
        Name = "FrmMyPayment"
        Text = "FrmMyPayment"
        pnlProduct.ResumeLayout(False)
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvProduct, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlProduct As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents dgvProduct As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents btnGoBackDashboard As Button
    Friend WithEvents btnAddProduct As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents colPaymentID As DataGridViewTextBoxColumn
    Friend WithEvents colDate As DataGridViewTextBoxColumn
    Friend WithEvents colAmount As DataGridViewTextBoxColumn
    Friend WithEvents colMethod As DataGridViewTextBoxColumn
    Friend WithEvents colType As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
End Class
