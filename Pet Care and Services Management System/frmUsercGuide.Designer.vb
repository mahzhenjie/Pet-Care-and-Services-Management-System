<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUserGuide
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents rtbGuide As RichTextBox
    Friend WithEvents btnBack As Button

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlMain = New Panel()
        Me.pnlHeader = New Panel()
        Me.lblTitle = New Label()
        Me.lblSubtitle = New Label()
        Me.rtbGuide = New RichTextBox()
        Me.btnBack = New Button()
        Me.pnlMain.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()

        ' FORM
        Me.AutoScaleMode = AutoScaleMode.None
        Me.BackColor = Color.FromArgb(235, 221, 202)
        Me.ClientSize = New Size(1100, 750)
        Me.MinimumSize = New Size(950, 650)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "User Guide"

        ' MAIN PANEL
        Me.pnlMain.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Me.pnlMain.BackColor = Color.FromArgb(245, 230, 209)
        Me.pnlMain.Location = New Point(15, 15)
        Me.pnlMain.Padding = New Padding(20)
        Me.pnlMain.Size = New Size(1070, 720)

        ' HEADER
        Me.pnlHeader.BackColor = Color.FromArgb(55, 32, 20)
        Me.pnlHeader.Dock = DockStyle.Top
        Me.pnlHeader.Height = 90

        ' TITLE
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New Font("Georgia", 22.0!, FontStyle.Bold)
        Me.lblTitle.ForeColor = Color.FromArgb(255, 243, 222)
        Me.lblTitle.Location = New Point(25, 18)
        Me.lblTitle.Text = "USER GUIDE"

        ' SUBTITLE
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New Font("Segoe UI", 10.0!)
        Me.lblSubtitle.ForeColor = Color.FromArgb(235, 221, 202)
        Me.lblSubtitle.Location = New Point(27, 55)
        Me.lblSubtitle.Text = "Smart Staff Training Management System"

        ' GUIDE
        Me.rtbGuide.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Me.rtbGuide.BackColor = Color.FromArgb(255, 250, 242)
        Me.rtbGuide.BorderStyle = BorderStyle.None
        Me.rtbGuide.Font = New Font("Segoe UI", 11.0!)
        Me.rtbGuide.ForeColor = Color.FromArgb(55, 32, 20)
        Me.rtbGuide.Location = New Point(20, 110)
        Me.rtbGuide.ReadOnly = True
        Me.rtbGuide.Size = New Size(1030, 530)
        Me.rtbGuide.TabStop = False

        ' BACK BUTTON
        Me.btnBack.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Me.btnBack.BackColor = Color.SaddleBrown
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = FlatStyle.Flat
        Me.btnBack.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
        Me.btnBack.ForeColor = Color.White
        Me.btnBack.Location = New Point(870, 660)
        Me.btnBack.Size = New Size(180, 40)
        Me.btnBack.Text = "Back to Dashboard"
        Me.btnBack.UseVisualStyleBackColor = False

        ' ADD CONTROLS
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Controls.Add(Me.lblSubtitle)

        Me.pnlMain.Controls.Add(Me.rtbGuide)
        Me.pnlMain.Controls.Add(Me.btnBack)
        Me.pnlMain.Controls.Add(Me.pnlHeader)

        Me.Controls.Add(Me.pnlMain)

        Me.pnlMain.ResumeLayout(False)
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

End Class