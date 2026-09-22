Imports MySql.Data.MySqlClient

Public Class frmAddCustomers

    ' DATABASE CONNECTION
    Private connectionString As String = "Server=localhost;Database=pet_care_and_services_management_system;Uid=root;Pwd=;"

    ' FORM LOAD
    Private Sub frmAddCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFullName.Focus()
    End Sub

    ' SAVE CUSTOMER
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        ' VALIDATION
        If txtFullName.Text.Trim() = "" Then
            MessageBox.Show(
                "Please enter Full Name.",
                "Validation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            txtFullName.Focus()
            Exit Sub
        End If

        If txtUsername.Text.Trim() = "" Then
            MessageBox.Show(
                "Please enter Username.",
                "Validation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            txtUsername.Focus()
            Exit Sub
        End If

        If txtPassword.Text.Trim() = "" Then
            MessageBox.Show(
                "Please enter Password.",
                "Validation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            txtPassword.Focus()
            Exit Sub
        End If

        If txtEmail.Text.Trim() = "" Then
            MessageBox.Show(
                "Please enter Email.",
                "Validation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            txtEmail.Focus()
            Exit Sub
        End If

        If txtPhoneNumber.Text.Trim() = "" Then
            MessageBox.Show(
                "Please enter Phone Number.",
                "Validation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            txtPhoneNumber.Focus()
            Exit Sub
        End If

        If txtAddress.Text.Trim() = "" Then

            MessageBox.Show(
                "Please enter Address.",
                "Validation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            txtAddress.Focus()
            Exit Sub
        End If

        ' INSERT CUSTOMER INTO DATABASE
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim sql As String =
                    "INSERT INTO Customers " &
                    "(FullName, Username, Password, Email, PhoneNumber, Address) " &
                    "VALUES " &
                    "(@FullName, @Username, @Password, @Email, @PhoneNumber, @Address)"

                Using cmd As New MySqlCommand(sql, conn)

                    cmd.Parameters.AddWithValue(
                        "@FullName",
                        txtFullName.Text.Trim()
                    )

                    cmd.Parameters.AddWithValue(
                        "@Username",
                        txtUsername.Text.Trim()
                    )

                    cmd.Parameters.AddWithValue(
                        "@Password",
                        txtPassword.Text.Trim()
                    )

                    cmd.Parameters.AddWithValue(
                        "@Email",
                        txtEmail.Text.Trim()
                    )

                    cmd.Parameters.AddWithValue(
                        "@PhoneNumber",
                        txtPhoneNumber.Text.Trim()
                    )

                    cmd.Parameters.AddWithValue(
                        "@Address",
                        txtAddress.Text.Trim()
                    )

                    Dim result As Integer = cmd.ExecuteNonQuery()

                    If result > 0 Then
                        MessageBox.Show(
                            "Customer added successfully!",
                            "Add Customer",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        )
                        Me.DialogResult = DialogResult.OK
                        Me.Close()
                    Else
                        MessageBox.Show(
                            "Customer could not be added.",
                            "Add Customer",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        )
                    End If
                End Using
            End Using
        Catch ex As MySqlException

            ' CHECK DUPLICATE USERNAME
            If ex.Number = 1062 Then
                MessageBox.Show(
                    "Username already exists. Please use another username.",
                    "Add Customer",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

            Else
                MessageBox.Show(
                    "Unable to add customer." &
                    Environment.NewLine &
                    Environment.NewLine &
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                )
            End If

        Catch ex As Exception
            MessageBox.Show(
                "Unable to add customer." &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        End Try
    End Sub

    ' CANCEL
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class