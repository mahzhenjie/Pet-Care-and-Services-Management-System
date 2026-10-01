<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCustomerProduct
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlMain = New Panel()
        Me.pnlContent = New Panel()
        Me.flpProducts = New FlowLayoutPanel()
        Me.pnlToolbar = New Panel()
        Me.btnGoBackDashboard = New Button()
        Me.btnViewCart = New Button()
        Me.btnRefresh = New Button()
        Me.txtSearch = New TextBox()
        Me.lblSearch = New Label()
        Me.pnlHeader = New Panel()
        Me.lblSubtitle = New Label()
        Me.lblTitle = New Label()
        Me.pnlMain.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        Me.pnlToolbar.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        ' pnlMain
        '
        Me.pnlMain.BackColor = Color.FromArgb(247, 232, 213)
        Me.pnlMain.Controls.Add(Me.pnlContent)
        Me.pnlMain.Controls.Add(Me.pnlToolbar)
        Me.pnlMain.Controls.Add(Me.pnlHeader)
        Me.pnlMain.Dock = DockStyle.Fill
        Me.pnlMain.Padding = New Padding(20)
        Me.pnlMain.Location = New Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New Size(1184, 800)
        Me.pnlMain.TabIndex = 0
        '
        ' pnlHeader
        '
        Me.pnlHeader.BackColor = Color.FromArgb(74, 44, 26)
        Me.pnlHeader.Controls.Add(Me.lblSubtitle)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = DockStyle.Top
        Me.pnlHeader.Location = New Point(20, 20)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New Size(1144, 90)
        Me.pnlHeader.TabIndex = 0
        '
        ' lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New Font("Segoe UI", 22.0!, FontStyle.Bold)
        Me.lblTitle.ForeColor = Color.White
        Me.lblTitle.Location = New Point(25, 15)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New Size(230, 41)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Our Products"
        '
        ' lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New Font("Segoe UI", 10.0!)
        Me.lblSubtitle.ForeColor = Color.FromArgb(247, 232, 213)
        Me.lblSubtitle.Location = New Point(29, 58)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New Size(330, 19)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Browse products and add them to your cart"
        '
        ' pnlToolbar
        '
        Me.pnlToolbar.BackColor = Color.FromArgb(224, 200, 170)
        Me.pnlToolbar.Controls.Add(Me.btnGoBackDashboard)
        Me.pnlToolbar.Controls.Add(Me.btnViewCart)
        Me.pnlToolbar.Controls.Add(Me.btnRefresh)
        Me.pnlToolbar.Controls.Add(Me.txtSearch)
        Me.pnlToolbar.Controls.Add(Me.lblSearch)
        Me.pnlToolbar.Dock = DockStyle.Top
        Me.pnlToolbar.Location = New Point(20, 110)
        Me.pnlToolbar.Name = "pnlToolbar"
        Me.pnlToolbar.Size = New Size(1144, 60)
        Me.pnlToolbar.TabIndex = 1
        '
        ' lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
        Me.lblSearch.ForeColor = Color.FromArgb(74, 44, 26)
        Me.lblSearch.Location = New Point(20, 20)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New Size(53, 19)
        Me.lblSearch.TabIndex = 0
        Me.lblSearch.Text = "Search:"
        '
        ' txtSearch
        '
        Me.txtSearch.Font = New Font("Segoe UI", 10.0!)
        Me.txtSearch.Location = New Point(80, 16)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New Size(260, 25)
        Me.txtSearch.TabIndex = 1
        '
        ' btnRefresh
        '
        Me.btnRefresh.BackColor = Color.FromArgb(112, 78, 51)
        Me.btnRefresh.FlatStyle = FlatStyle.Flat
        Me.btnRefresh.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
        Me.btnRefresh.ForeColor = Color.White
        Me.btnRefresh.Location = New Point(355, 12)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New Size(100, 35)
        Me.btnRefresh.TabIndex = 2
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        ' btnViewCart
        '
        Me.btnViewCart.BackColor = Color.FromArgb(74, 44, 26)
        Me.btnViewCart.FlatStyle = FlatStyle.Flat
        Me.btnViewCart.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
        Me.btnViewCart.ForeColor = Color.White
        Me.btnViewCart.Location = New Point(470, 12)
        Me.btnViewCart.Name = "btnViewCart"
        Me.btnViewCart.Size = New Size(120, 35)
        Me.btnViewCart.TabIndex = 3
        Me.btnViewCart.Text = "View Cart"
        Me.btnViewCart.UseVisualStyleBackColor = False
        '
        ' btnGoBackDashboard
        '
        Me.btnGoBackDashboard.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Me.btnGoBackDashboard.BackColor = Color.FromArgb(112, 78, 51)
        Me.btnGoBackDashboard.FlatStyle = FlatStyle.Flat
        Me.btnGoBackDashboard.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
        Me.btnGoBackDashboard.ForeColor = Color.White
        Me.btnGoBackDashboard.Location = New Point(1000, 12)
        Me.btnGoBackDashboard.Name = "btnGoBackDashboard"
        Me.btnGoBackDashboard.Size = New Size(120, 35)
        Me.btnGoBackDashboard.TabIndex = 4
        Me.btnGoBackDashboard.Text = "Back"
        Me.btnGoBackDashboard.UseVisualStyleBackColor = False
        '
        ' pnlContent
        '
        Me.pnlContent.BackColor = Color.FromArgb(247, 232, 213)
        Me.pnlContent.Controls.Add(Me.flpProducts)
        Me.pnlContent.Dock = DockStyle.Fill
        Me.pnlContent.Location = New Point(20, 170)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Padding = New Padding(15)
        Me.pnlContent.Size = New Size(1144, 610)
        Me.pnlContent.TabIndex = 2
        '
        ' flpProducts
        '
        Me.flpProducts.AutoScroll = True
        Me.flpProducts.Dock = DockStyle.Fill
        Me.flpProducts.FlowDirection = FlowDirection.LeftToRight
        Me.flpProducts.Location = New Point(15, 15)
        Me.flpProducts.Name = "flpProducts"
        Me.flpProducts.Padding = New Padding(5)
        Me.flpProducts.Size = New Size(1114, 580)
        Me.flpProducts.TabIndex = 0
        Me.flpProducts.WrapContents = True
        '
        ' frmCustomerProduct
        '
        Me.AutoScaleMode = AutoScaleMode.None
        Me.ClientSize = New Size(1184, 800)
        Me.Controls.Add(Me.pnlMain)
        Me.MinimumSize = New Size(1050, 650)
        Me.Name = "frmCustomerProduct"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "Products"
        Me.pnlMain.ResumeLayout(False)
        Me.pnlContent.ResumeLayout(False)
        Me.pnlToolbar.ResumeLayout(False)
        Me.pnlToolbar.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents pnlToolbar As Panel
    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnViewCart As Button
    Friend WithEvents btnGoBackDashboard As Button
    Friend WithEvents pnlContent As Panel
    Friend WithEvents flpProducts As FlowLayoutPanel
End Class