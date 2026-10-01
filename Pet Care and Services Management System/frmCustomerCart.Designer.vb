<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCustomerCart
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
        Me.dgvCart = New DataGridView()
        Me.pnlBottom = New Panel()
        Me.btnContinueShopping = New Button()
        Me.btnCheckout = New Button()
        Me.lblTotal = New Label()
        Me.pnlHeader = New Panel()
        Me.lblSubtitle = New Label()
        Me.lblTitle = New Label()
        Me.pnlMain.SuspendLayout()
        CType(Me.dgvCart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBottom.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        ' pnlMain
        '
        Me.pnlMain.BackColor = Color.FromArgb(247, 232, 213)
        Me.pnlMain.Controls.Add(Me.dgvCart)
        Me.pnlMain.Controls.Add(Me.pnlBottom)
        Me.pnlMain.Controls.Add(Me.pnlHeader)
        Me.pnlMain.Dock = DockStyle.Fill
        Me.pnlMain.Padding = New Padding(20)
        Me.pnlMain.Location = New Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New Size(1000, 650)
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
        Me.pnlHeader.Size = New Size(960, 90)
        Me.pnlHeader.TabIndex = 0
        '
        ' lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New Font("Segoe UI", 22.0!, FontStyle.Bold)
        Me.lblTitle.ForeColor = Color.White
        Me.lblTitle.Location = New Point(25, 15)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New Size(170, 41)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "My Cart"
        '
        ' lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New Font("Segoe UI", 10.0!)
        Me.lblSubtitle.ForeColor = Color.FromArgb(247, 232, 213)
        Me.lblSubtitle.Location = New Point(29, 58)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New Size(250, 19)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Review your selected products"
        '
        ' dgvCart
        '
        Me.dgvCart.AllowUserToAddRows = False
        Me.dgvCart.AllowUserToDeleteRows = False
        Me.dgvCart.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        Me.dgvCart.BackgroundColor = Color.White
        Me.dgvCart.BorderStyle = BorderStyle.None
        Me.dgvCart.Dock = DockStyle.Fill
        Me.dgvCart.Location = New Point(20, 110)
        Me.dgvCart.MultiSelect = False
        Me.dgvCart.Name = "dgvCart"
        Me.dgvCart.ReadOnly = True
        Me.dgvCart.RowHeadersVisible = False
        Me.dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.dgvCart.Size = New Size(960, 425)
        Me.dgvCart.TabIndex = 1
        '
        ' pnlBottom
        '
        Me.pnlBottom.BackColor = Color.FromArgb(224, 200, 170)
        Me.pnlBottom.Controls.Add(Me.btnContinueShopping)
        Me.pnlBottom.Controls.Add(Me.btnCheckout)
        Me.pnlBottom.Controls.Add(Me.lblTotal)
        Me.pnlBottom.Dock = DockStyle.Bottom
        Me.pnlBottom.Location = New Point(20, 535)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New Size(960, 95)
        Me.pnlBottom.TabIndex = 2
        '
        ' lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New Font("Segoe UI", 15.0!, FontStyle.Bold)
        Me.lblTotal.ForeColor = Color.FromArgb(74, 44, 26)
        Me.lblTotal.Location = New Point(20, 30)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New Size(150, 28)
        Me.lblTotal.TabIndex = 0
        Me.lblTotal.Text = "Total: RM 0.00"
        '
        ' btnContinueShopping
        '
        Me.btnContinueShopping.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Me.btnContinueShopping.BackColor = Color.FromArgb(112, 78, 51)
        Me.btnContinueShopping.FlatStyle = FlatStyle.Flat
        Me.btnContinueShopping.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
        Me.btnContinueShopping.ForeColor = Color.White
        Me.btnContinueShopping.Location = New Point(650, 25)
        Me.btnContinueShopping.Name = "btnContinueShopping"
        Me.btnContinueShopping.Size = New Size(135, 45)
        Me.btnContinueShopping.TabIndex = 1
        Me.btnContinueShopping.Text = "CONTINUE"
        Me.btnContinueShopping.UseVisualStyleBackColor = False
        '
        ' btnCheckout
        '
        Me.btnCheckout.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Me.btnCheckout.BackColor = Color.FromArgb(74, 44, 26)
        Me.btnCheckout.FlatStyle = FlatStyle.Flat
        Me.btnCheckout.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
        Me.btnCheckout.ForeColor = Color.White
        Me.btnCheckout.Location = New Point(800, 25)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New Size(135, 45)
        Me.btnCheckout.TabIndex = 2
        Me.btnCheckout.Text = "CHECKOUT"
        Me.btnCheckout.UseVisualStyleBackColor = False
        '
        ' frmCustomerCart
        '
        Me.AutoScaleMode = AutoScaleMode.None
        Me.ClientSize = New Size(1000, 650)
        Me.Controls.Add(Me.pnlMain)
        Me.MinimumSize = New Size(850, 550)
        Me.Name = "frmCustomerCart"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "Shopping Cart"
        Me.pnlMain.ResumeLayout(False)
        CType(Me.dgvCart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBottom.ResumeLayout(False)
        Me.pnlBottom.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents dgvCart As DataGridView
    Friend WithEvents pnlBottom As Panel
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnContinueShopping As Button
    Friend WithEvents btnCheckout As Button
End Class