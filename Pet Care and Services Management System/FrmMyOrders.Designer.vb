<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMyOrders
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMyOrders))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlProduct = New Panel()
        btnDashboard = New Button()
        Refreshbtn = New Button()
        pnlHeader = New Panel()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        Button1 = New Button()
        dgvOrders = New DataGridView()
        Button3 = New Button()
        btnGoBackDashboard = New Button()
        btnAddProduct = New Button()
        btnRefresh = New Button()
        txtSearch = New TextBox()
        pnlProduct.SuspendLayout()
        pnlHeader.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvOrders, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlProduct
        ' 
        pnlProduct.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlProduct.BackColor = Color.FromArgb(CByte(245), CByte(230), CByte(209))
        pnlProduct.Controls.Add(btnDashboard)
        pnlProduct.Controls.Add(Refreshbtn)
        pnlProduct.Controls.Add(pnlHeader)
        pnlProduct.Controls.Add(Button1)
        pnlProduct.Controls.Add(dgvOrders)
        pnlProduct.Controls.Add(Button3)
        pnlProduct.Controls.Add(btnGoBackDashboard)
        pnlProduct.Controls.Add(btnAddProduct)
        pnlProduct.Controls.Add(btnRefresh)
        pnlProduct.Controls.Add(txtSearch)
        pnlProduct.Location = New Point(1, 1)
        pnlProduct.Margin = New Padding(4)
        pnlProduct.Name = "pnlProduct"
        pnlProduct.Padding = New Padding(30)
        pnlProduct.Size = New Size(1104, 1155)
        pnlProduct.TabIndex = 5
        ' 
        ' btnDashboard
        ' 
        btnDashboard.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnDashboard.BackColor = Color.SaddleBrown
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnDashboard.ForeColor = Color.WhiteSmoke
        btnDashboard.Location = New Point(846, 103)
        btnDashboard.Margin = New Padding(4)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(218, 57)
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
        Refreshbtn.Location = New Point(627, 103)
        Refreshbtn.Margin = New Padding(4)
        Refreshbtn.Name = "Refreshbtn"
        Refreshbtn.Size = New Size(195, 57)
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Georgia", 22F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(255), CByte(243), CByte(222))
        Label1.Location = New Point(95, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(314, 51)
        Label1.TabIndex = 0
        Label1.Text = "MY ORDERS"
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.BackColor = Color.SaddleBrown
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        Button1.ForeColor = Color.WhiteSmoke
        Button1.Location = New Point(1810, 146)
        Button1.Margin = New Padding(4)
        Button1.Name = "Button1"
        Button1.Size = New Size(218, 57)
        Button1.TabIndex = 16
        Button1.Text = "Dashboard"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' dgvOrders
        ' 
        dgvOrders.AllowUserToAddRows = False
        dgvOrders.AllowUserToDeleteRows = False
        dgvOrders.AllowUserToResizeRows = False
        dgvOrders.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvOrders.BackgroundColor = Color.FromArgb(CByte(250), CByte(247), CByte(240))
        dgvOrders.BorderStyle = BorderStyle.None
        dgvOrders.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvOrders.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvOrders.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvOrders.ColumnHeadersHeight = 42
        dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvOrders.GridColor = Color.FromArgb(CByte(225), CByte(211), CByte(192))
        dgvOrders.Location = New Point(30, 185)
        dgvOrders.Margin = New Padding(4)
        dgvOrders.MultiSelect = False
        dgvOrders.Name = "dgvOrders"
        dgvOrders.ReadOnly = True
        dgvOrders.RightToLeft = RightToLeft.No
        dgvOrders.RowHeadersVisible = False
        dgvOrders.RowHeadersWidth = 62
        dgvOrders.RowTemplate.Height = 70
        dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvOrders.Size = New Size(1034, 853)
        dgvOrders.TabIndex = 7
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button3.BackColor = Color.Sienna
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        Button3.ForeColor = Color.WhiteSmoke
        Button3.Location = New Point(2050, 146)
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
        btnGoBackDashboard.Location = New Point(3277, 183)
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
        btnAddProduct.Location = New Point(3734, 183)
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
        btnRefresh.Location = New Point(3517, 183)
        btnRefresh.Margin = New Padding(4)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(195, 57)
        btnRefresh.TabIndex = 3
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = Color.White
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Font = New Font("Segoe UI", 10F)
        txtSearch.ForeColor = Color.FromArgb(CByte(107), CByte(98), CByte(91))
        txtSearch.Location = New Point(30, 114)
        txtSearch.Margin = New Padding(4)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(532, 34)
        txtSearch.TabIndex = 1
        txtSearch.Text = "Search order..."
        ' 
        ' FrmMyOrders
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1106, 1065)
        Controls.Add(pnlProduct)
        Name = "FrmMyOrders"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FrmMyOrders"
        pnlProduct.ResumeLayout(False)
        pnlProduct.PerformLayout()
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvOrders, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlProduct As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents dgvOrders As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents btnGoBackDashboard As Button
    Friend WithEvents btnAddProduct As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnDashboard As Button
    Friend WithEvents Refreshbtn As Button
End Class
