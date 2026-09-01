Imports System.Windows.Forms
Imports System.Drawing
Imports MySql.Data.MySqlClient

' ============================================================
' frmLogin.vb — 第二步：Login Form
' 選擇身分 (Customer / Employee) + 輸入 Username / Password
' 沒有帳號時可以連到 frmRegister
' ============================================================
Public Class frmLogin
    Inherits Form

    Private WithEvents rdoCustomer As New RadioButton()
    Private WithEvents rdoEmployee As New RadioButton()
    Private WithEvents txtUsername As New TextBox()
    Private WithEvents txtPassword As New TextBox()
    Private WithEvents btnLogin As New Button()
    Private WithEvents lnkRegister As New LinkLabel()
    Private WithEvents chkShowPassword As New CheckBox()

    Private ReadOnly colorBackground As Color = Color.FromArgb(245, 230, 209)
    Private ReadOnly colorHeader As Color = Color.FromArgb(139, 58, 27)
    Private ReadOnly colorDarkBrown As Color = Color.FromArgb(96, 52, 16)
    Private ReadOnly colorCream As Color = Color.FromArgb(250, 240, 222)

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()

        Me.Text = "Login - Pet Care and Services Management System"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Size = New Size(480, 500)
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.BackColor = colorBackground

        ' 標題
        Dim lblTitle As New Label()
        lblTitle.Text = "PET CARE AND SERVICES" & vbCrLf & "MANAGEMENT SYSTEM"
        lblTitle.Font = New Font("Georgia", 15, FontStyle.Bold)
        lblTitle.ForeColor = colorHeader
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        lblTitle.Size = New Size(440, 55)
        lblTitle.Location = New Point(10, 15)
        Me.Controls.Add(lblTitle)

        Dim pnlLine As New Panel()
        pnlLine.BackColor = colorHeader
        pnlLine.Size = New Size(400, 2)
        pnlLine.Location = New Point(30, 72)
        Me.Controls.Add(pnlLine)

        ' Login As 群組
        Dim grpRole As New GroupBox()
        grpRole.Text = "Login As"
        grpRole.ForeColor = colorDarkBrown
        grpRole.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        grpRole.Location = New Point(80, 90)
        grpRole.Size = New Size(300, 55)
        Me.Controls.Add(grpRole)

        rdoCustomer.Text = "Customer"
        rdoCustomer.Location = New Point(20, 22)
        rdoCustomer.AutoSize = True
        rdoCustomer.Checked = True
        rdoCustomer.Font = New Font("Segoe UI", 10)
        grpRole.Controls.Add(rdoCustomer)

        rdoEmployee.Text = "Employee"
        rdoEmployee.Location = New Point(150, 22)
        rdoEmployee.AutoSize = True
        rdoEmployee.Font = New Font("Segoe UI", 10)
        grpRole.Controls.Add(rdoEmployee)

        ' Username
        Dim lblUsername As New Label()
        lblUsername.Text = "Username"
        lblUsername.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        lblUsername.ForeColor = colorDarkBrown
        lblUsername.Location = New Point(80, 165)
        lblUsername.AutoSize = True
        Me.Controls.Add(lblUsername)

        txtUsername.Location = New Point(80, 190)
        txtUsername.Size = New Size(300, 26)
        txtUsername.Font = New Font("Segoe UI", 10)
        Me.Controls.Add(txtUsername)

        ' Password
        Dim lblPassword As New Label()
        lblPassword.Text = "Password"
        lblPassword.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        lblPassword.ForeColor = colorDarkBrown
        lblPassword.Location = New Point(80, 230)
        lblPassword.AutoSize = True
        Me.Controls.Add(lblPassword)

        txtPassword.Location = New Point(80, 255)
        txtPassword.Size = New Size(300, 26)
        txtPassword.Font = New Font("Segoe UI", 10)
        txtPassword.PasswordChar = "*"c
        Me.Controls.Add(txtPassword)

        ' Show Password
        chkShowPassword.Text = "Show Password"
        chkShowPassword.Font = New Font("Segoe UI", 9)
        chkShowPassword.ForeColor = colorDarkBrown
        chkShowPassword.AutoSize = True
        chkShowPassword.Location = New Point(80, 285)
        Me.Controls.Add(chkShowPassword)

        ' Login 按鈕
        btnLogin.Text = "Login"
        btnLogin.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        btnLogin.BackColor = colorDarkBrown
        btnLogin.ForeColor = colorCream
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.Size = New Size(300, 40)
        btnLogin.Location = New Point(80, 320)
        Me.Controls.Add(btnLogin)

        ' Register 連結
        Dim lblNoAccount As New Label()
        lblNoAccount.Text = "Don't have an account?"
        lblNoAccount.Font = New Font("Segoe UI", 9)
        lblNoAccount.ForeColor = colorDarkBrown
        lblNoAccount.AutoSize = True
        lblNoAccount.Location = New Point(115, 385)
        Me.Controls.Add(lblNoAccount)

        lnkRegister.Text = "Register here"
        lnkRegister.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lnkRegister.LinkColor = colorHeader
        lnkRegister.AutoSize = True
        lnkRegister.Location = New Point(255, 385)
        Me.Controls.Add(lnkRegister)

        Me.AcceptButton = btnLogin
        Me.ResumeLayout(False)
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged

        If chkShowPassword.Checked Then
            txtPassword.PasswordChar = ControlChars.NullChar
        Else
            txtPassword.PasswordChar = "*"c
        End If

    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim uname As String = txtUsername.Text.Trim()
        Dim pword As String = txtPassword.Text

        If uname = "" OrElse pword = "" Then
            MessageBox.Show("Please enter both username and password.", "Missing Information",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim tableName As String = If(rdoCustomer.Checked, "customers", "employees")
        Dim idColumn As String = If(rdoCustomer.Checked, "CustomerID", "EmployeeID")

        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim sql As String =
                    $"SELECT {idColumn}, FullName FROM {tableName} WHERE Username = @u AND Password = @p"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@u", uname)
                    cmd.Parameters.AddWithValue("@p", pword)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            CurrentUserID = Convert.ToInt32(reader(idColumn))
                            CurrentUserName = reader("FullName").ToString()
                            CurrentUserRole = If(rdoCustomer.Checked, "Customer", "Employee")

                            MessageBox.Show($"Welcome, {CurrentUserName}!", "Login Successful",
                                             MessageBoxButtons.OK, MessageBoxIcon.Information)

                            If CurrentUserRole = "Employee" Then
                                Dim employeeForm As New frmEmployeeDashboard()
                                employeeForm.Show()
                            End If
                            Me.Hide()
                        Else
                            MessageBox.Show("Invalid username or password.", "Login Failed",
                                             MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Database connection error: " & ex.Message, "Error",
                             MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub lnkRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) _
        Handles lnkRegister.LinkClicked
        Dim registerForm As New frmRegister()
        registerForm.Show()
        Me.Hide()
    End Sub

    Private Sub frmLogin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

End Class
