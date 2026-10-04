<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMyPayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMyPayment))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlProduct = New Panel()
        pnlHeader = New Panel()
        PictureBox2 = New PictureBox()
        lblTitle = New Label()
        Button4 = New Button()
        dgvPayments = New DataGridView()
        pnlProduct.SuspendLayout()
        pnlHeader.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvPayments, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlProduct
        ' 
        pnlProduct.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlProduct.BackColor = Color.FromArgb(CByte(245), CByte(230), CByte(209))
        pnlProduct.Controls.Add(pnlHeader)
        pnlProduct.Controls.Add(Button4)
        pnlProduct.Controls.Add(dgvPayments)
        pnlProduct.Location = New Point(15, 15)
        pnlProduct.Name = "pnlProduct"
        pnlProduct.Padding = New Padding(20)
        pnlProduct.Size = New Size(1130, 770)
        pnlProduct.TabIndex = 6
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(55), CByte(32), CByte(20))
        pnlHeader.Controls.Add(PictureBox2)
        pnlHeader.Controls.Add(lblTitle)
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
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Georgia", 20.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(CByte(255), CByte(243), CByte(222))
        lblTitle.Location = New Point(78, 14)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(295, 39)
        lblTitle.TabIndex = 0
        lblTitle.Text = "MY PAYMENTS"
        ' 
        ' Button4
        ' 
        Button4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button4.BackColor = Color.Sienna
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        Button4.ForeColor = Color.WhiteSmoke
        Button4.Location = New Point(945, 102)
        Button4.Name = "Button4"
        Button4.Size = New Size(145, 38)
        Button4.TabIndex = 18
        Button4.Text = "Refresh"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' dgvPayments
        ' 
        dgvPayments.AllowUserToAddRows = False
        dgvPayments.AllowUserToDeleteRows = False
        dgvPayments.AllowUserToResizeRows = False
        dgvPayments.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvPayments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPayments.BackgroundColor = Color.FromArgb(CByte(250), CByte(247), CByte(240))
        dgvPayments.BorderStyle = BorderStyle.None
        dgvPayments.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvPayments.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(96), CByte(52), CByte(16))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.WhiteSmoke
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(96), CByte(52), CByte(16))
        DataGridViewCellStyle1.SelectionForeColor = Color.WhiteSmoke
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        dgvPayments.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvPayments.ColumnHeadersHeight = 42
        dgvPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvPayments.GridColor = Color.FromArgb(CByte(225), CByte(211), CByte(192))
        dgvPayments.Location = New Point(20, 155)
        dgvPayments.MultiSelect = False
        dgvPayments.Name = "dgvPayments"
        dgvPayments.ReadOnly = True
        dgvPayments.RightToLeft = RightToLeft.No
        dgvPayments.RowHeadersVisible = False
        dgvPayments.RowHeadersWidth = 51
        dgvPayments.RowTemplate.Height = 38
        dgvPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPayments.Size = New Size(1090, 590)
        dgvPayments.TabIndex = 7
        ' 
        ' FrmMyPayment
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(235), CByte(221), CByte(202))
        ClientSize = New Size(1160, 800)
        Controls.Add(pnlProduct)
        MinimumSize = New Size(1050, 700)
        Name = "FrmMyPayment"
        StartPosition = FormStartPosition.CenterScreen
        Text = "My Payments"
        pnlProduct.ResumeLayout(False)
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvPayments, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlProduct As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents dgvPayments As DataGridView

End Class