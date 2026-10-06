<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMyOrderDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMyOrderDetail))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlProduct = New Panel()
        btnDashboard = New Button()
        Refreshbtn = New Button()
        pnlHeader = New Panel()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        Button1 = New Button()
        dgvOrderDetails = New DataGridView()
        Button3 = New Button()
        btnGoBackDashboard = New Button()
        btnAddProduct = New Button()
        btnRefresh = New Button()
        pnlProduct.SuspendLayout()
        pnlHeader.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvOrderDetails, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlProduct
        ' 
        pnlProduct.BackColor = Color.FromArgb(CByte(245), CByte(230), CByte(209))
        pnlProduct.Controls.Add(btnDashboard)
        pnlProduct.Controls.Add(Refreshbtn)
        pnlProduct.Controls.Add(pnlHeader)
        pnlProduct.Controls.Add(Button1)
        pnlProduct.Controls.Add(dgvOrderDetails)
        pnlProduct.Controls.Add(Button3)
        pnlProduct.Controls.Add(btnGoBackDashboard)
        pnlProduct.Controls.Add(btnAddProduct)
        pnlProduct.Controls.Add(btnRefresh)
        pnlProduct.Dock = DockStyle.Fill
        pnlProduct.Location = New Point(0, 0)
        pnlProduct.Name = "pnlProduct"
        pnlProduct.Padding = New Padding(20, 20, 20, 20)
        pnlProduct.Size = New Size(699, 442)
        pnlProduct.TabIndex = 6
        ' 
        ' btnDashboard
        ' 
        btnDashboard.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnDashboard.BackColor = Color.SaddleBrown
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnDashboard.ForeColor = Color.WhiteSmoke
        btnDashboard.Location = New Point(1135, 89)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(145, 38)
        btnDashboard.TabIndex = 19
        btnDashboard.Text = "Dashboard"
        btnDashboard.UseVisualStyleBackColor = False
        ' 
        ' Refreshbtn
        ' 
        Refreshbtn.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Refreshbtn.BackColor = Color.Sienna
        Refreshbtn.FlatAppearance.BorderSize = 0
        Refreshbtn.FlatStyle = FlatStyle.Flat
        Refreshbtn.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        Refreshbtn.ForeColor = Color.WhiteSmoke
        Refreshbtn.Location = New Point(989, 89)
        Refreshbtn.Name = "Refreshbtn"
        Refreshbtn.Size = New Size(130, 38)
        Refreshbtn.TabIndex = 18
        Refreshbtn.Text = "Refresh"
        Refreshbtn.UseVisualStyleBackColor = False
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(55), CByte(32), CByte(20))
        pnlHeader.Controls.Add(PictureBox2)
        pnlHeader.Controls.Add(Label1)
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Margin = New Padding(2, 2, 2, 2)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1117, 47)
        pnlHeader.TabIndex = 17
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(2, 6)
        PictureBox2.Margin = New Padding(2, 2, 2, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(61, 35)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Georgia", 22F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(255), CByte(243), CByte(222))
        Label1.Location = New Point(63, 6)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(329, 43)
        Label1.TabIndex = 0
        Label1.Text = "ORDER DETAIL"
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.BackColor = Color.SaddleBrown
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        Button1.ForeColor = Color.WhiteSmoke
        Button1.Location = New Point(1777, 117)
        Button1.Name = "Button1"
        Button1.Size = New Size(145, 38)
        Button1.TabIndex = 16
        Button1.Text = "Dashboard"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' dgvOrderDetails
        ' 
        dgvOrderDetails.AllowUserToAddRows = False
        dgvOrderDetails.AllowUserToDeleteRows = False
        dgvOrderDetails.AllowUserToResizeRows = False
        dgvOrderDetails.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvOrderDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvOrderDetails.BackgroundColor = Color.FromArgb(CByte(250), CByte(247), CByte(240))
        dgvOrderDetails.BorderStyle = BorderStyle.None
        dgvOrderDetails.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvOrderDetails.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvOrderDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvOrderDetails.ColumnHeadersHeight = 42
        dgvOrderDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvOrderDetails.GridColor = Color.FromArgb(CByte(225), CByte(211), CByte(192))
        dgvOrderDetails.Location = New Point(20, 61)
        dgvOrderDetails.MultiSelect = False
        dgvOrderDetails.Name = "dgvOrderDetails"
        dgvOrderDetails.ReadOnly = True
        dgvOrderDetails.RightToLeft = RightToLeft.No
        dgvOrderDetails.RowHeadersVisible = False
        dgvOrderDetails.RowHeadersWidth = 62
        dgvOrderDetails.RowTemplate.Height = 70
        dgvOrderDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvOrderDetails.Size = New Size(657, 358)
        dgvOrderDetails.TabIndex = 7
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button3.BackColor = Color.Sienna
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        Button3.ForeColor = Color.WhiteSmoke
        Button3.Location = New Point(1937, 117)
        Button3.Name = "Button3"
        Button3.Size = New Size(130, 38)
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
        btnGoBackDashboard.Location = New Point(2755, 142)
        btnGoBackDashboard.Name = "btnGoBackDashboard"
        btnGoBackDashboard.Size = New Size(145, 38)
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
        btnAddProduct.Location = New Point(3060, 142)
        btnAddProduct.Name = "btnAddProduct"
        btnAddProduct.Size = New Size(160, 38)
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
        btnRefresh.Location = New Point(2915, 142)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(130, 38)
        btnRefresh.TabIndex = 3
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' FrmMyOrderDetail
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(699, 442)
        Controls.Add(pnlProduct)
        Margin = New Padding(2, 2, 2, 2)
        Name = "FrmMyOrderDetail"
        StartPosition = FormStartPosition.CenterScreen
        Text = "My Order Detail"
        pnlProduct.ResumeLayout(False)
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvOrderDetails, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlProduct As Panel
    Friend WithEvents btnDashboard As Button
    Friend WithEvents Refreshbtn As Button
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents dgvOrderDetails As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents btnGoBackDashboard As Button
    Friend WithEvents btnAddProduct As Button
    Friend WithEvents btnRefresh As Button
End Class
