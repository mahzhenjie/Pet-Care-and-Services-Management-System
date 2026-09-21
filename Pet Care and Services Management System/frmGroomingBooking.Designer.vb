<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGroomingBooking
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
        pnlGroomingBooking = New Panel()
        dgvGroomingBooking = New DataGridView()
        colGroomingBookingID = New DataGridViewTextBoxColumn()
        colPetID = New DataGridViewTextBoxColumn()
        colServiceID = New DataGridViewTextBoxColumn()
        colBookingDate = New DataGridViewTextBoxColumn()
        colBookingTime = New DataGridViewTextBoxColumn()
        colStatus = New DataGridViewTextBoxColumn()
        colEdit = New DataGridViewButtonColumn()
        colDelete = New DataGridViewButtonColumn()
        btnAddGroomingBooking = New Button()
        btnRefresh = New Button()
        txtSearch = New TextBox()
        lblTitle = New Label()
        pnlGroomingBooking.SuspendLayout()
        CType(dgvGroomingBooking, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlGroomingBooking
        ' 
        pnlGroomingBooking.BackColor = Color.FromArgb(CByte(232), CByte(216), CByte(194))
        pnlGroomingBooking.Controls.Add(dgvGroomingBooking)
        pnlGroomingBooking.Controls.Add(btnAddGroomingBooking)
        pnlGroomingBooking.Controls.Add(btnRefresh)
        pnlGroomingBooking.Controls.Add(txtSearch)
        pnlGroomingBooking.Controls.Add(lblTitle)
        pnlGroomingBooking.ForeColor = Color.SaddleBrown
        pnlGroomingBooking.Location = New Point(12, 15)
        pnlGroomingBooking.Margin = New Padding(3, 4, 3, 4)
        pnlGroomingBooking.Name = "pnlGroomingBooking"
        pnlGroomingBooking.Size = New Size(920, 725)
        pnlGroomingBooking.TabIndex = 2
        ' 
        ' dgvGroomingBooking
        ' 
        dgvGroomingBooking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvGroomingBooking.BackgroundColor = Color.FromArgb(CByte(244), CByte(239), CByte(227))
        dgvGroomingBooking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvGroomingBooking.Columns.AddRange(New DataGridViewColumn() {colGroomingBookingID, colPetID, colServiceID, colBookingDate, colBookingTime, colStatus, colEdit, colDelete})
        dgvGroomingBooking.GridColor = Color.Sienna
        dgvGroomingBooking.Location = New Point(24, 121)
        dgvGroomingBooking.Margin = New Padding(3, 4, 3, 4)
        dgvGroomingBooking.Name = "dgvGroomingBooking"
        dgvGroomingBooking.RightToLeft = RightToLeft.No
        dgvGroomingBooking.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        dgvGroomingBooking.RowHeadersWidth = 51
        dgvGroomingBooking.RowTemplate.Height = 24
        dgvGroomingBooking.Size = New Size(868, 569)
        dgvGroomingBooking.TabIndex = 7
        ' 
        ' colGroomingBookingID
        ' 
        colGroomingBookingID.HeaderText = "Grooming Booking ID"
        colGroomingBookingID.MinimumWidth = 6
        colGroomingBookingID.Name = "colGroomingBookingID"
        ' 
        ' colPetID
        ' 
        colPetID.HeaderText = "Pet ID"
        colPetID.MinimumWidth = 6
        colPetID.Name = "colPetID"
        ' 
        ' colServiceID
        ' 
        colServiceID.HeaderText = "Service ID"
        colServiceID.MinimumWidth = 6
        colServiceID.Name = "colServiceID"
        ' 
        ' colBookingDate
        ' 
        colBookingDate.FillWeight = 150F
        colBookingDate.HeaderText = "Booking Date"
        colBookingDate.MinimumWidth = 6
        colBookingDate.Name = "colBookingDate"
        ' 
        ' colBookingTime
        ' 
        colBookingTime.HeaderText = "Booking Time"
        colBookingTime.MinimumWidth = 6
        colBookingTime.Name = "colBookingTime"
        ' 
        ' colStatus
        ' 
        colStatus.HeaderText = "Status"
        colStatus.MinimumWidth = 6
        colStatus.Name = "colStatus"
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
        ' btnAddGroomingBooking
        ' 
        btnAddGroomingBooking.BackColor = Color.SaddleBrown
        btnAddGroomingBooking.Font = New Font("Lucida Sans Unicode", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAddGroomingBooking.ForeColor = Color.WhiteSmoke
        btnAddGroomingBooking.Location = New Point(603, 80)
        btnAddGroomingBooking.Margin = New Padding(3, 4, 3, 4)
        btnAddGroomingBooking.Name = "btnAddGroomingBooking"
        btnAddGroomingBooking.Size = New Size(156, 34)
        btnAddGroomingBooking.TabIndex = 6
        btnAddGroomingBooking.Text = "+Grooming Booking"
        btnAddGroomingBooking.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.SaddleBrown
        btnRefresh.Font = New Font("Lucida Sans Unicode", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRefresh.ForeColor = Color.WhiteSmoke
        btnRefresh.Location = New Point(765, 80)
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
        txtSearch.Text = "Search booking..."
        txtSearch.UseWaitCursor = True
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Lucida Sans Unicode", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(20, 19)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(474, 34)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Grooming Booking Management"
        ' 
        ' frmGroomingBooking
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(942, 754)
        Controls.Add(pnlGroomingBooking)
        Margin = New Padding(3, 4, 3, 4)
        Name = "frmGroomingBooking"
        Text = "Gromming Booking Management"
        pnlGroomingBooking.ResumeLayout(False)
        pnlGroomingBooking.PerformLayout()
        CType(dgvGroomingBooking, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlGroomingBooking As System.Windows.Forms.Panel
    Friend WithEvents btnAddGroomingBooking As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents dgvGroomingBooking As System.Windows.Forms.DataGridView
    Friend WithEvents colGroomingBookingID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPetID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colServiceID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colBookingDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colBookingTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEdit As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colDelete As System.Windows.Forms.DataGridViewButtonColumn
End Class
