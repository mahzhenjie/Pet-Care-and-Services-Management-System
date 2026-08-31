Imports System.Windows.Forms
Imports System.Drawing
Imports MySql.Data.MySqlClient

' ============================================================
' frmRegister.vb — Register Form (新客戶註冊)
' 欄位：FullName, Username, Email, Phone, Password, Confirm Password
' 按鈕：Register / Clear
' 底下有 "Already have an account? Back to Login" 連結
' 註冊只開放給 Customer；Employee 帳號通常由管理員後台建立
' ============================================================
Public Class frmRegister
    Inherits Form

    Private WithEvents txtFullName As New TextBox()
    Private WithEvents txtUsername As New TextBox()
    Private WithEvents txtEmail As New TextBox()
    Private WithEvents txtPhone As New TextBox()
    Private WithEvents txtPassword As New TextBox()
    Private WithEvents txtConfirmPassword As New TextBox()
    Private WithEvents btnRegister As New Button()
    Private WithEvents btnClear As New Button()
    Private WithEvents lnkBackToLogin As New LinkLabel()

    Private ReadOnly colorBackground As Color = Color.FromArgb(245, 230, 209)
    Private ReadOnly colorHeader As Color = Color.FromArgb(139, 58, 27)
    Private ReadOnly colorDarkBrown As Color = Color.FromArgb(96, 52, 16)
    Private ReadOnly colorCream As Color = Color.FromArgb(250, 240, 222)

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()

        Me.Text = "Register - Pet Care and Services Management System"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Size = New Size(480, 620)
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.BackColor = colorBackground

        ' 標題
        Dim lblTitle As New Label()
        lblTitle.Text = "CREATE AN ACCOUNT"
        lblTitle.Font = New Font("Georgia", 16, FontStyle.Bold)
        lblTitle.ForeColor = colorHeader
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        lblTitle.Size = New Size(440, 40)
        lblTitle.Location = New Point(10, 20)
        Me.Controls.Add(lblTitle)

        Dim pnlLine As New Panel()
        pnlLine.BackColor = colorHeader
        pnlLine.Size = New Size(400, 2)
        pnlLine.Location = New Point(30, 65)
        Me.Controls.Add(pnlLine)

        Dim yPos As Integer = 85
        Dim gap As Integer = 65

        AddField("Full Name", txtFullName, yPos) : yPos += gap
        AddField("Username", txtUsername, yPos) : yPos += gap
        AddField("Email", txtEmail, yPos) : yPos += gap
        AddField("Phone Number", txtPhone, yPos) : yPos += gap
        AddField("Password", txtPassword, yPos, isPassword:=True) : yPos += gap
        AddField("Confirm Password", txtConfirmPassword, yPos, isPassword:=True) : yPos += gap + 15

        ' Register 按鈕
        btnRegister.Text = "Register"
        btnRegister.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        btnRegister.BackColor = colorDarkBrown
        btnRegister.ForeColor = colorCream
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.FlatAppearance.BorderSize = 0
        btnRegister.Size = New Size(145, 40)
        btnRegister.Location = New Point(80, yPos)
        Me.Controls.Add(btnRegister)

        ' Clear 按鈕
        btnClear.Text = "Clear"
        btnClear.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        btnClear.BackColor = colorCream
        btnClear.ForeColor = colorDarkBrown
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.FlatAppearance.BorderColor = colorDarkBrown
        btnClear.FlatAppearance.BorderSize = 1
        btnClear.Size = New Size(145, 40)
        btnClear.Location = New Point(235, yPos)
        Me.Controls.Add(btnClear)

        yPos += 60

        ' Back to Login 連結
        Dim lblHaveAccount As New Label()
        lblHaveAccount.Text = "Already have an account?"
        lblHaveAccount.Font = New Font("Segoe UI", 9)
        lblHaveAccount.ForeColor = colorDarkBrown
        lblHaveAccount.AutoSize = True
        lblHaveAccount.TextAlign = ContentAlignment.MiddleCenter
        lblHaveAccount.Location = New Point(115, yPos)
        Me.Controls.Add(lblHaveAccount)

        lnkBackToLogin.Text = "Back to Login"
        lnkBackToLogin.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lnkBackToLogin.LinkColor = colorHeader
        lnkBackToLogin.AutoSize = True
        lnkBackToLogin.Location = New Point(265, yPos)
        Me.Controls.Add(lnkBackToLogin)

        Me.AcceptButton = btnRegister
        Me.ResumeLayout(False)
    End Sub

    ' 建立一組 Label + TextBox 的小工具方法
    Private Sub AddField(labelText As String, textBox As TextBox, y As Integer,
                          Optional isPassword As Boolean = False)
        Dim lbl As New Label()
        lbl.Text = labelText
        lbl.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        lbl.ForeColor = colorDarkBrown
        lbl.AutoSize = True
        lbl.Location = New Point(80, y)
        Me.Controls.Add(lbl)

        textBox.Location = New Point(80, y + 22)
        textBox.Size = New Size(300, 26)
        textBox.Font = New Font("Segoe UI", 10)
        If isPassword Then textBox.PasswordChar = "*"c
        Me.Controls.Add(textBox)
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim fullName As String = txtFullName.Text.Trim()
        Dim uname As String = txtUsername.Text.Trim()
        Dim email As String = txtEmail.Text.Trim()
        Dim phone As String = txtPhone.Text.Trim()
        Dim pword As String = txtPassword.Text
        Dim confirmPword As String = txtConfirmPassword.Text

        If fullName = "" OrElse uname = "" OrElse email = "" OrElse
           phone = "" OrElse pword = "" OrElse confirmPword = "" Then
            MessageBox.Show("Please fill in all fields.", "Missing Information",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If pword <> confirmPword Then
            MessageBox.Show("Password and Confirm Password do not match.", "Password Mismatch",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                ' 檢查 Username 是否已被使用
                Using checkCmd As New MySqlCommand(
                    "SELECT COUNT(*) FROM customers WHERE Username = @u", conn)
                    checkCmd.Parameters.AddWithValue("@u", uname)
                    Dim count As Long = Convert.ToInt64(checkCmd.ExecuteScalar())
                    If count > 0 Then
                        MessageBox.Show("This username is already taken.", "Registration Failed",
                                         MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If
                End Using

                ' Address 為必填欄位，但註冊表單沒有這個欄位，先存空白，之後可在個人資料頁補填
                Dim sql As String = "INSERT INTO customers (FullName, Username, Password, Email, PhoneNumber, Address) " &
                                     "VALUES (@fn, @un, @pw, @em, @ph, @addr)"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@fn", fullName)
                    cmd.Parameters.AddWithValue("@un", uname)
                    cmd.Parameters.AddWithValue("@pw", pword)
                    cmd.Parameters.AddWithValue("@em", email)
                    cmd.Parameters.AddWithValue("@ph", phone)
                    cmd.Parameters.AddWithValue("@addr", "")
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Registration successful! Please log in.", "Success",
                             MessageBoxButtons.OK, MessageBoxIcon.Information)
            GoBackToLogin()

        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message, "Error",
                             MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFullName.Clear()
        txtUsername.Clear()
        txtEmail.Clear()
        txtPhone.Clear()
        txtPassword.Clear()
        txtConfirmPassword.Clear()
        txtFullName.Focus()
    End Sub

    Private Sub lnkBackToLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) _
        Handles lnkBackToLogin.LinkClicked
        GoBackToLogin()
    End Sub

    Private Sub GoBackToLogin()
        Dim loginForm As New frmLogin()
        loginForm.Show()
        Me.Close()
    End Sub

End Class
