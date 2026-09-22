<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPayment
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
        pnlPayment = New Panel()
        cboMethod = New ComboBox()
        cboStatus = New ComboBox()
        txtSearch = New TextBox()
        btnRefresh = New Button()
        dgvPayment = New DataGridView()
        colPaymentID = New DataGridViewTextBoxColumn()
        colCustomerID = New DataGridViewTextBoxColumn()
        colPaymentDate = New DataGridViewTextBoxColumn()
        colAmount = New DataGridViewTextBoxColumn()
        colPaymentMethod = New DataGridViewTextBoxColumn()
        colPaymentType = New DataGridViewTextBoxColumn()
        colPaymentStatus = New DataGridViewTextBoxColumn()
        colEdit = New DataGridViewButtonColumn()
        colDelete = New DataGridViewButtonColumn()
        lblTitle = New Label()
        btnGoBackDashboard = New Button()
        pnlPayment.SuspendLayout()
        CType(dgvPayment, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlPayment
        ' 
        pnlPayment.BackColor = Color.FromArgb(CByte(232), CByte(216), CByte(194))
        pnlPayment.Controls.Add(btnGoBackDashboard)
        pnlPayment.Controls.Add(cboMethod)
        pnlPayment.Controls.Add(cboStatus)
        pnlPayment.Controls.Add(txtSearch)
        pnlPayment.Controls.Add(btnRefresh)
        pnlPayment.Controls.Add(dgvPayment)
        pnlPayment.Controls.Add(lblTitle)
        pnlPayment.ForeColor = Color.SaddleBrown
        pnlPayment.Location = New Point(12, 15)
        pnlPayment.Margin = New Padding(3, 4, 3, 4)
        pnlPayment.Name = "pnlPayment"
        pnlPayment.Size = New Size(920, 725)
        pnlPayment.TabIndex = 2
        ' 
        ' cboMethod
        ' 
        cboMethod.FormattingEnabled = True
        cboMethod.Location = New Point(520, 83)
        cboMethod.Margin = New Padding(3, 4, 3, 4)
        cboMethod.Name = "cboMethod"
        cboMethod.Size = New Size(87, 28)
        cboMethod.TabIndex = 14
        cboMethod.Text = "Method"
        ' 
        ' cboStatus
        ' 
        cboStatus.FormattingEnabled = True
        cboStatus.Location = New Point(428, 83)
        cboStatus.Margin = New Padding(3, 4, 3, 4)
        cboStatus.Name = "cboStatus"
        cboStatus.Size = New Size(87, 28)
        cboStatus.TabIndex = 13
        cboStatus.Text = "Status"
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Lucida Sans Unicode", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearch.ForeColor = Color.Sienna
        txtSearch.Location = New Point(24, 80)
        txtSearch.Margin = New Padding(3, 4, 3, 4)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(379, 27)
        txtSearch.TabIndex = 7
        txtSearch.Text = "Search payment..."
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.SaddleBrown
        btnRefresh.Font = New Font("Lucida Sans Unicode", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRefresh.ForeColor = Color.WhiteSmoke
        btnRefresh.Location = New Point(756, 80)
        btnRefresh.Margin = New Padding(3, 4, 3, 4)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(137, 34)
        btnRefresh.TabIndex = 3
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' dgvPayment
        ' 
        dgvPayment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPayment.BackgroundColor = Color.FromArgb(CByte(244), CByte(239), CByte(227))
        dgvPayment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPayment.Columns.AddRange(New DataGridViewColumn() {colPaymentID, colCustomerID, colPaymentDate, colAmount, colPaymentMethod, colPaymentType, colPaymentStatus, colEdit, colDelete})
        dgvPayment.GridColor = Color.Sienna
        dgvPayment.Location = New Point(24, 121)
        dgvPayment.Margin = New Padding(3, 4, 3, 4)
        dgvPayment.Name = "dgvPayment"
        dgvPayment.RightToLeft = RightToLeft.No
        dgvPayment.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        dgvPayment.RowHeadersWidth = 51
        dgvPayment.RowTemplate.Height = 24
        dgvPayment.Size = New Size(868, 569)
        dgvPayment.TabIndex = 3
        ' 
        ' colPaymentID
        ' 
        colPaymentID.FillWeight = 135F
        colPaymentID.HeaderText = "Payment ID"
        colPaymentID.MinimumWidth = 6
        colPaymentID.Name = "colPaymentID"
        ' 
        ' colCustomerID
        ' 
        colCustomerID.FillWeight = 135F
        colCustomerID.HeaderText = "CustomerID"
        colCustomerID.MinimumWidth = 6
        colCustomerID.Name = "colCustomerID"
        ' 
        ' colPaymentDate
        ' 
        colPaymentDate.HeaderText = "Payment Date"
        colPaymentDate.MinimumWidth = 6
        colPaymentDate.Name = "colPaymentDate"
        ' 
        ' colAmount
        ' 
        colAmount.FillWeight = 90F
        colAmount.HeaderText = "Amount"
        colAmount.MinimumWidth = 6
        colAmount.Name = "colAmount"
        ' 
        ' colPaymentMethod
        ' 
        colPaymentMethod.HeaderText = "Payment Method"
        colPaymentMethod.MinimumWidth = 6
        colPaymentMethod.Name = "colPaymentMethod"
        ' 
        ' colPaymentType
        ' 
        colPaymentType.HeaderText = "Payment Type"
        colPaymentType.MinimumWidth = 6
        colPaymentType.Name = "colPaymentType"
        ' 
        ' colPaymentStatus
        ' 
        colPaymentStatus.FillWeight = 150F
        colPaymentStatus.HeaderText = "Payment Status"
        colPaymentStatus.MinimumWidth = 6
        colPaymentStatus.Name = "colPaymentStatus"
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
        lblTitle.Location = New Point(20, 19)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(329, 34)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Payment Management"
        ' 
        ' btnGoBackDashboard
        ' 
        btnGoBackDashboard.BackColor = Color.SaddleBrown
        btnGoBackDashboard.Font = New Font("Lucida Sans Unicode", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnGoBackDashboard.ForeColor = Color.WhiteSmoke
        btnGoBackDashboard.Location = New Point(613, 80)
        btnGoBackDashboard.Margin = New Padding(3, 4, 3, 4)
        btnGoBackDashboard.Name = "btnGoBackDashboard"
        btnGoBackDashboard.Size = New Size(137, 34)
        btnGoBackDashboard.TabIndex = 15
        btnGoBackDashboard.Text = "Dashboard"
        btnGoBackDashboard.UseVisualStyleBackColor = False
        ' 
        ' frmPayment
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(942, 754)
        Controls.Add(pnlPayment)
        Margin = New Padding(3, 4, 3, 4)
        Name = "frmPayment"
        Text = "Form1"
        pnlPayment.ResumeLayout(False)
        pnlPayment.PerformLayout()
        CType(dgvPayment, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlPayment As System.Windows.Forms.Panel
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents dgvPayment As System.Windows.Forms.DataGridView
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents colPaymentID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCustomerID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPaymentDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPaymentMethod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPaymentType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPaymentStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEdit As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colDelete As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents cboMethod As System.Windows.Forms.ComboBox
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents btnGoBackDashboard As Button

End Class