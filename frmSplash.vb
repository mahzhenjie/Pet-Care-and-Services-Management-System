Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D

' ============================================================
' frmSplash.vb — 第一步：Splash Screen（美化版，含动画 / 爪印 / 进度条）
' 全部用向量绘图 (GDI+) 手绘爪印，不需要额外图片档案
' 把这个表单设成专案的启动表单 (My Project > Application > Startup form)
' ============================================================

' 自订面板：开启双缓冲，画动画时才不会闪烁
Friend Class BufferedPanel
    Inherits Panel
    Public Sub New()
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or
                     ControlStyles.OptimizedDoubleBuffer Or ControlStyles.ResizeRedraw, True)
    End Sub
End Class

Public Class frmSplash
    Inherits Form

    ' ---- 计时器 ----
    Private WithEvents tmrProgress As New Timer()   ' 控制进度条 + 结束流程
    Private WithEvents tmrAnimate As New Timer()     ' 控制爪印弹跳 / 省略号动画
    Private WithEvents tmrFadeIn As New Timer()      ' 开场淡入
    Private WithEvents tmrFadeOut As New Timer()     ' 结束淡出

    ' ---- 状态变数 ----
    Private progressValue As Integer = 0
    Private bounceAngle As Double = 0
    Private dotFrame As Integer = 0
    Private Const PawCount As Integer = 5
    Private pawAlpha(PawCount - 1) As Integer        ' 每个小爪印目前的透明度 0~255

    ' ---- 画布 / 控件 ----
    Private WithEvents pnlCanvas As New BufferedPanel()
    Private lblStatus As New Label()

    ' ---- 配色 (跟主选单一致：奶茶底 + 深咖啡) ----
    Private ReadOnly colorBackground As Color = Color.FromArgb(250, 240, 224)
    Private ReadOnly colorCard As Color = Color.FromArgb(245, 230, 209)
    Private ReadOnly colorHeader As Color = Color.FromArgb(139, 58, 27)
    Private ReadOnly colorDarkBrown As Color = Color.FromArgb(96, 52, 16)
    Private ReadOnly colorAccent As Color = Color.FromArgb(196, 132, 74)

    Private statusMessages As String() = {
        "Loading pet profiles", "Preparing services", "Almost ready"
    }

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()

        Me.Text = "Loading..."
        Me.FormBorderStyle = FormBorderStyle.None
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Size = New Size(560, 400)
        Me.BackColor = colorBackground
        Me.DoubleBuffered = True
        Me.Opacity = 0                          ' 一开始透明，用来做淡入动画

        ' 圆角外框
        Me.Region = New Region(RoundedRect(New Rectangle(0, 0, Me.Width, Me.Height), 24))

        ' ---- 画布 (爪印动画 + 标题都画在这上面) ----
        pnlCanvas.Dock = DockStyle.Fill
        pnlCanvas.BackColor = colorBackground
        Me.Controls.Add(pnlCanvas)

        ' ---- 状态文字 ----
        lblStatus.Text = "Loading"
        lblStatus.Font = New Font("Segoe UI", 9.5F)
        lblStatus.ForeColor = colorDarkBrown
        lblStatus.BackColor = Color.Transparent
        lblStatus.TextAlign = ContentAlignment.MiddleCenter
        lblStatus.Size = New Size(400, 20)
        lblStatus.Location = New Point((Me.Width - 400) \ 2, 330)
        pnlCanvas.Controls.Add(lblStatus)

        ' ---- 计时器设定 ----
        tmrProgress.Interval = 45
        tmrAnimate.Interval = 40
        tmrFadeIn.Interval = 15
        tmrFadeOut.Interval = 15

        Me.ResumeLayout(False)
    End Sub

    ' 画出圆角矩形路径
    Private Function RoundedRect(rect As Rectangle, radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()
        Dim d As Integer = radius * 2
        path.StartFigure()
        path.AddArc(rect.X, rect.Y, d, d, 180, 90)
        path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90)
        path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90)
        path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90)
        path.CloseFigure()
        Return path
    End Function

    ' 手绘一个爪印 (中心点 cx,cy；scale 缩放；alpha 透明度)
    Private Sub DrawPawPrint(g As Graphics, cx As Single, cy As Single, scale As Single, alpha As Integer, col As Color)
        If alpha <= 0 Then Return
        Dim state = g.Save()
        g.SmoothingMode = SmoothingMode.AntiAlias
        g.TranslateTransform(cx, cy)
        g.ScaleTransform(scale, scale)
        Using br As New SolidBrush(Color.FromArgb(Math.Min(alpha, 255), col))
            g.FillEllipse(br, -22, -8, 44, 36)     ' 掌垫
            g.FillEllipse(br, -32, -30, 16, 20)    ' 外侧脚趾(左)
            g.FillEllipse(br, -14, -38, 16, 20)    ' 内侧脚趾(左)
            g.FillEllipse(br, -2, -38, 16, 20)     ' 内侧脚趾(右)
            g.FillEllipse(br, 16, -30, 16, 20)     ' 外侧脚趾(右)
        End Using
        g.Restore(state)
    End Sub

    Private Sub pnlCanvas_Paint(sender As Object, e As PaintEventArgs) Handles pnlCanvas.Paint
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias
        g.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit

        Dim w As Integer = pnlCanvas.Width

        ' ---- 分隔线 ----
        Using pen As New Pen(colorAccent, 2)
            g.DrawLine(pen, 60, 78, w - 60, 78)
        End Using

        ' ---- 标题 ----
        Using fTitle As New Font("Georgia", 19, FontStyle.Bold)
            Dim titleText As String = "PET CARE AND SERVICES" & vbCrLf & "MANAGEMENT SYSTEM"
            Dim sf As New StringFormat() With {.Alignment = StringAlignment.Center}
            Using br As New SolidBrush(colorHeader)
                g.DrawString(titleText, fTitle, br, New RectangleF(0, 15, w, 60), sf)
            End Using
        End Using

        Using fSub As New Font("Segoe UI", 10, FontStyle.Italic)
            Dim sf As New StringFormat() With {.Alignment = StringAlignment.Center}
            Using br As New SolidBrush(colorDarkBrown)
                g.DrawString("Caring for your pets, one paw at a time", fSub, br,
                             New RectangleF(0, 90, w, 22), sf)
            End Using
        End Using

        ' ---- 中央大爪印 (会上下弹跳 + 微微摇摆) ----
        Dim bounceY As Single = CSng(8 * Math.Sin(bounceAngle))
        Dim wobble As Single = CSng(4 * Math.Sin(bounceAngle * 0.7))
        Dim stateBig = g.Save()
        g.TranslateTransform(w \ 2 + wobble, 155 + bounceY)
        g.RotateTransform(CSng(3 * Math.Sin(bounceAngle * 0.5)))
        DrawPawPrint(g, 0, 0, 1.6F, 255, colorDarkBrown)
        g.Restore(stateBig)

        ' ---- 底下一排小爪印 (随进度逐一淡入，像脚印走过去) ----
        Dim startX As Single = (w - (PawCount - 1) * 55) \ 2
        For i As Integer = 0 To PawCount - 1
            Dim px As Single = startX + i * 55
            Dim py As Single = 250 + If(i Mod 2 = 0, 6, -6)   ' 交错高低，像走路脚印
            DrawPawPrint(g, px, py, 0.55F, pawAlpha(i), colorAccent)
        Next

        ' ---- 自订圆角进度条 ----
        Dim barRect As New Rectangle(80, 290, w - 160, 20)
        Using barPath As GraphicsPath = RoundedRect(barRect, 10)
            Using bgBrush As New SolidBrush(Color.FromArgb(230, 210, 185))
                g.FillPath(bgBrush, barPath)
            End Using
        End Using

        Dim fillWidth As Integer = CInt((barRect.Width - 4) * (progressValue / 100.0))
        If fillWidth > 0 Then
            Dim fillRect As New Rectangle(barRect.X + 2, barRect.Y + 2, fillWidth, barRect.Height - 4)
            Using fillPath As GraphicsPath = RoundedRect(fillRect, 8)
                Using gradBrush As New LinearGradientBrush(fillRect, colorAccent, colorDarkBrown, 0.0F)
                    g.FillPath(gradBrush, fillPath)
                End Using
            End Using
        End If

        ' ---- 百分比文字 ----
        Using fPct As New Font("Segoe UI", 9, FontStyle.Bold)
            Dim sf As New StringFormat() With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center}
            Using br As New SolidBrush(Color.White)
                g.DrawString($"{progressValue}%", fPct, br, New RectangleF(barRect.X, barRect.Y, barRect.Width, barRect.Height), sf)
            End Using
        End Using
    End Sub

    Private Sub frmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrFadeIn.Start()
        tmrProgress.Start()
        tmrAnimate.Start()
    End Sub

    ' 淡入动画
    Private Sub tmrFadeIn_Tick(sender As Object, e As EventArgs) Handles tmrFadeIn.Tick
        Me.Opacity = Math.Min(Me.Opacity + 0.08, 1.0)
        If Me.Opacity >= 1.0 Then tmrFadeIn.Stop()
    End Sub

    ' 爪印弹跳 + 省略号动画
    Private Sub tmrAnimate_Tick(sender As Object, e As EventArgs) Handles tmrAnimate.Tick
        bounceAngle += 0.18
        If bounceAngle > Math.PI * 2 Then bounceAngle -= Math.PI * 2

        dotFrame = (dotFrame + 1) Mod 40
        Dim dots As String = New String("."c, (dotFrame \ 10) + 1)
        Dim phase As Integer = Math.Min(progressValue \ 34, statusMessages.Length - 1)
        lblStatus.Text = statusMessages(phase) & dots

        pnlCanvas.Invalidate()
    End Sub

    ' 进度条 + 结尾流程
    Private Sub tmrProgress_Tick(sender As Object, e As EventArgs) Handles tmrProgress.Tick
        progressValue = Math.Min(progressValue + 2, 100)

        ' 每跨过 100/PawCount 的门槛，就让下一个小爪印淡入
        Dim threshold As Integer = 100 \ PawCount
        For i As Integer = 0 To PawCount - 1
            If progressValue >= (i + 1) * threshold Then
                pawAlpha(i) = Math.Min(pawAlpha(i) + 30, 255)
            End If
        Next

        If progressValue >= 100 Then
            tmrProgress.Stop()
            tmrFadeOut.Start()
        End If
    End Sub

    ' 淡出后切换到登入画面
    Private Sub tmrFadeOut_Tick(sender As Object, e As EventArgs) Handles tmrFadeOut.Tick
        Me.Opacity = Math.Max(Me.Opacity - 0.08, 0)
        If Me.Opacity <= 0 Then
            tmrFadeOut.Stop()
            tmrAnimate.Stop()
            Dim loginForm As New frmLogin()
            loginForm.Show()
            Me.Hide()
            Me.Close()
        End If
    End Sub

End Class
