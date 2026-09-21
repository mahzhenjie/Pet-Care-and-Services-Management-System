<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderDetail
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
        pnlOrderDetail = New Panel()
        dgvOrderDetail = New DataGridView()
        colOrderDetailID = New DataGridViewTextBoxColumn()
        colOrderID = New DataGridViewTextBoxColumn()
        colProductID = New DataGridViewTextBoxColumn()
        colQuantity = New DataGridViewTextBoxColumn()
        colUnitPrice = New DataGridViewTextBoxColumn()
        colSubtotal = New DataGridViewTextBoxColumn()
        colEdit = New DataGridViewButtonColumn()
        colDelete = New DataGridViewButtonColumn()
        btnAddOrderDetail = New Button()
        btnRefresh = New Button()
        txtSearch = New TextBox()
        lblTitle = New Label()
        pnlOrderDetail.SuspendLayout()
        CType(dgvOrderDetail, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlOrderDetail
        ' 
        pnlOrderDetail.BackColor = Color.FromArgb(CByte(232), CByte(216), CByte(194))
        pnlOrderDetail.Controls.Add(dgvOrderDetail)
        pnlOrderDetail.Controls.Add(btnAddOrderDetail)
        pnlOrderDetail.Controls.Add(btnRefresh)
        pnlOrderDetail.Controls.Add(txtSearch)
        pnlOrderDetail.Controls.Add(lblTitle)
        pnlOrderDetail.ForeColor = Color.SaddleBrown
        pnlOrderDetail.Location = New Point(12, 15)
        pnlOrderDetail.Margin = New Padding(3, 4, 3, 4)
        pnlOrderDetail.Name = "pnlOrderDetail"
        pnlOrderDetail.Size = New Size(920, 725)
        pnlOrderDetail.TabIndex = 3
        ' 
        ' dgvOrderDetail
        ' 
        dgvOrderDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvOrderDetail.BackgroundColor = Color.FromArgb(CByte(244), CByte(239), CByte(227))
        dgvOrderDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvOrderDetail.Columns.AddRange(New DataGridViewColumn() {colOrderDetailID, colOrderID, colProductID, colQuantity, colUnitPrice, colSubtotal, colEdit, colDelete})
        dgvOrderDetail.GridColor = Color.Sienna
        dgvOrderDetail.Location = New Point(24, 121)
        dgvOrderDetail.Margin = New Padding(3, 4, 3, 4)
        dgvOrderDetail.Name = "dgvOrderDetail"
        dgvOrderDetail.RightToLeft = RightToLeft.No
        dgvOrderDetail.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        dgvOrderDetail.RowHeadersWidth = 51
        dgvOrderDetail.RowTemplate.Height = 24
        dgvOrderDetail.Size = New Size(868, 569)
        dgvOrderDetail.TabIndex = 7
        ' 
        ' colOrderDetailID
        ' 
        colOrderDetailID.FillWeight = 135F
        colOrderDetailID.HeaderText = "Order Detail ID"
        colOrderDetailID.MinimumWidth = 6
        colOrderDetailID.Name = "colOrderDetailID"
        ' 
        ' colOrderID
        ' 
        colOrderID.FillWeight = 135F
        colOrderID.HeaderText = "Order ID"
        colOrderID.MinimumWidth = 6
        colOrderID.Name = "colOrderID"
        ' 
        ' colProductID
        ' 
        colProductID.FillWeight = 135F
        colProductID.HeaderText = "Product ID"
        colProductID.MinimumWidth = 6
        colProductID.Name = "colProductID"
        ' 
        ' colQuantity
        ' 
        colQuantity.FillWeight = 150F
        colQuantity.HeaderText = "Quantity"
        colQuantity.MinimumWidth = 6
        colQuantity.Name = "colQuantity"
        ' 
        ' colUnitPrice
        ' 
        colUnitPrice.HeaderText = "Unit Price"
        colUnitPrice.MinimumWidth = 6
        colUnitPrice.Name = "colUnitPrice"
        ' 
        ' colSubtotal
        ' 
        colSubtotal.HeaderText = "Subtotal"
        colSubtotal.MinimumWidth = 6
        colSubtotal.Name = "colSubtotal"
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
        ' btnAddOrderDetail
        ' 
        btnAddOrderDetail.BackColor = Color.SaddleBrown
        btnAddOrderDetail.Font = New Font("Lucida Sans Unicode", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAddOrderDetail.ForeColor = Color.WhiteSmoke
        btnAddOrderDetail.Location = New Point(736, 80)
        btnAddOrderDetail.Margin = New Padding(3, 4, 3, 4)
        btnAddOrderDetail.Name = "btnAddOrderDetail"
        btnAddOrderDetail.Size = New Size(156, 34)
        btnAddOrderDetail.TabIndex = 6
        btnAddOrderDetail.Text = "+Order Detail"
        btnAddOrderDetail.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.SaddleBrown
        btnRefresh.Font = New Font("Lucida Sans Unicode", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRefresh.ForeColor = Color.WhiteSmoke
        btnRefresh.Location = New Point(593, 80)
        btnRefresh.Margin = New Padding(3, 4, 3, 4)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(137, 34)
        btnRefresh.TabIndex = 3
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Lucida Sans Unicode", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearch.ForeColor = Color.Sienna
        txtSearch.Location = New Point(24, 80)
        txtSearch.Margin = New Padding(3, 4, 3, 4)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(398, 27)
        txtSearch.TabIndex = 1
        txtSearch.Text = "Search order detail..."
        txtSearch.UseWaitCursor = True
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Lucida Sans Unicode", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(20, 19)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(385, 34)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Order Detail Management"
        ' 
        ' frmOrderDetail
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(942, 754)
        Controls.Add(pnlOrderDetail)
        Margin = New Padding(3, 4, 3, 4)
        Name = "frmOrderDetail"
        Text = "Order Detail Management"
        pnlOrderDetail.ResumeLayout(False)
        pnlOrderDetail.PerformLayout()
        CType(dgvOrderDetail, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlOrderDetail As System.Windows.Forms.Panel
    Friend WithEvents dgvOrderDetail As System.Windows.Forms.DataGridView
    Friend WithEvents btnAddOrderDetail As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents colOrderDetailID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colOrderID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colProductID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colUnitPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSubtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEdit As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colDelete As System.Windows.Forms.DataGridViewButtonColumn
End Class
