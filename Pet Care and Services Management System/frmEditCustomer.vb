Imports MySql.Data.MySqlClient

Public Class frmEditCustomer
    Private connectionString As String = "Server=localhost;Database=pet_care_and_services_management_system;Uid=root;Pwd=;"
    Private customerID As String

    Public Sub New(ByVal id As String)
        InitializeComponent()
        customerID = id
    End Sub

    Private Sub frmEditCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomerData()
    End Sub

    Private Sub LoadCustomerData()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim sql As String =
                    "SELECT CustomerID, FullName, Username, Email, PhoneNumber, Address " &
                    "FROM Customers " &
                    "WHERE CustomerID = @CustomerID"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue(
                        "@CustomerID",
                        customerID
                    )
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtCustomerID.Text =
                                reader("CustomerID").ToString()
                            txtFullName.Text =
                                reader("FullName").ToString()
                            txtUsername.Text =
                                reader("Username").ToString()
                            txtEmail.Text =
                                reader("Email").ToString()
                            txtPhoneNumber.Text =
                                reader("PhoneNumber").ToString()
                            txtAddress.Text =
                                reader("Address").ToString()
                        Else
                            MessageBox.Show(
                                "Customer not found.",
                                "Edit Customer",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            )
                            Me.Close()
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(
                "Unable to load customer data." &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "Database Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtFullName.Text.Trim() = "" Then
            MessageBox.Show(
                "Please enter the full name.",
                "Validation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            txtFullName.Focus()
            Exit Sub
        End If

        If txtUsername.Text.Trim() = "" Then
            MessageBox.Show(
                "Please enter the username.",
                "Validation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            txtUsername.Focus()
            Exit Sub
        End If

        If txtEmail.Text.Trim() = "" Then
            MessageBox.Show(
                "Please enter the email.",
                "Validation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            txtEmail.Focus()
            Exit Sub
        End If

        If txtPhoneNumber.Text.Trim() = "" Then
            MessageBox.Show(
                "Please enter the phone number.",
                "Validation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            txtPhoneNumber.Focus()
            Exit Sub
        End If

        If txtAddress.Text.Trim() = "" Then
            MessageBox.Show(
                "Please enter the address.",
                "Validation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            txtAddress.Focus()
            Exit Sub
        End If

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim sql As String =
                    "UPDATE Customers SET " &
                    "FullName = @FullName, " &
                    "Username = @Username, " &
                    "Email = @Email, " &
                    "PhoneNumber = @PhoneNumber, " &
                    "Address = @Address " &
                    "WHERE CustomerID = @CustomerID"
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

                    cmd.Parameters.AddWithValue(
                        "@CustomerID",
                        customerID
                    )

                    Dim result As Integer =
                        cmd.ExecuteNonQuery()

                    If result > 0 Then
                        MessageBox.Show(
                            "Customer updated successfully!",
                            "Edit Customer",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        )
                        Me.DialogResult = DialogResult.OK
                        Me.Close()
                    Else
                        MessageBox.Show(
                            "No changes were made.",
                            "Edit Customer",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        )
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(
                "Unable to update customer." &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "Database Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class