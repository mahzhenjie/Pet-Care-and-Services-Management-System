<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMyOrders
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMyOrders))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlProduct = New Panel()
        btnDashboard = New Button()
        Refreshbtn = New Button()
        pnlHeader = New Panel()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        dgvOrders = New DataGridView()
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
        pnlProduct.Controls.Add(dgvOrders)
        pnlProduct.Controls.Add(txtSearch)
        pnlProduct.Location = New Point(15, 15)
        pnlProduct.Name = "pnlProduct"
        pnlProduct.Padding = New Padding(20)
        pnlProduct.Size = New Size(1130, 770)
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
        btnDashboard.Location = New Point(962, 98)
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
        Refreshbtn.Location = New Point(812, 98)
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
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(20, 20)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1090, 65)
        pnlHeader.TabIndex = 17
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(8, 6)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(65, 53)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Georgia", 20.0F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(255), CByte(243), CByte(222))
        Label1.Location = New Point(78, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(243, 39)
        Label1.TabIndex = 0
        Label1.Text = "MY ORDERS"
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
        dgvOrders.Location = New Point(20, 155)
        dgvOrders.MultiSelect = False
        dgvOrders.Name = "dgvOrders"
        dgvOrders.ReadOnly = True
        dgvOrders.RightToLeft = RightToLeft.No
        dgvOrders.RowHeadersVisible = False
        dgvOrders.RowHeadersWidth = 51
        dgvOrders.RowTemplate.Height = 38
        dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvOrders.Size = New Size(1090, 590)
        dgvOrders.TabIndex = 7
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
        txtSearch.Text = "Search order..."
        ' 
        ' FrmMyOrders
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(235), CByte(221), CByte(202))
        ClientSize = New Size(1160, 800)
        Controls.Add(pnlProduct)
        MinimumSize = New Size(1050, 700)
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
    Friend WithEvents dgvOrders As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnDashboard As Button
    Friend WithEvents Refreshbtn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnGoBackDashboard As Button
    Friend WithEvents btnAddProduct As Button
    Friend WithEvents btnRefresh As Button

End Class