Imports MySql.Data.MySqlClient

Public Class frmMyProfile

    ' Define the database connection string
    Private connectionString As String = "Server=127.0.0.1;Database=pet_care_and_services_management_system;Uid=root;Pwd=;"

    ' -----------------------------------------------------------
    ' Form Load: Load data based on the dynamically logged-in user
    ' -----------------------------------------------------------
    Private Sub frmMyProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Check if a user is actually logged in
        If GlobalVariables.LoggedInCustomerID <= 0 Then
            MessageBox.Show("Error: No user is currently logged in.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If

        LoadCustomerData()

        ' Optionally: Disable textboxes until the "Edit" button is clicked
        SetTextBoxState(True) ' True means ReadOnly
    End Sub

    ' -----------------------------------------------------------
    ' Method to fetch and bind data from the database
    ' -----------------------------------------------------------
    Private Sub LoadCustomerData()
        ' Include CustomerID in the SELECT statement
        Dim query As String = "SELECT CustomerID, FullName, Username, Password, Email, PhoneNumber, Address FROM customers WHERE CustomerID = @CustomerID"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                ' Use the dynamically stored logged-in Customer ID
                command.Parameters.AddWithValue("@CustomerID", GlobalVariables.LoggedInCustomerID)

                Try
                    connection.Open()
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            ' Bind data to UI (Make sure these names match your Form controls)
                            txtCustomerID.Text = reader("CustomerID").ToString()
                            txtFullName.Text = reader("FullName").ToString()
                            txtUsername.Text = reader("Username").ToString()
                            txtPassword.Text = reader("Password").ToString()
                            txtEmail.Text = reader("Email").ToString()
                            txtPhone.Text = reader("PhoneNumber").ToString()
                            txtAddress.Text = reader("Address").ToString()
                        Else
                            MessageBox.Show("Customer data not found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error reading data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    ' -----------------------------------------------------------
    ' Edit Button: Enable textboxes for modification
    ' -----------------------------------------------------------
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        SetTextBoxState(False) ' False means Not ReadOnly, user can edit
        txtFullName.Focus()
    End Sub

    ' -----------------------------------------------------------
    ' Save Button: Update the database with modified info
    ' -----------------------------------------------------------
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Validation: Ensure mandatory fields are not empty
        If String.IsNullOrWhiteSpace(txtFullName.Text) OrElse
           String.IsNullOrWhiteSpace(txtUsername.Text) OrElse
           String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Full Name, Username, and Password cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim query As String = "UPDATE customers SET FullName = @FullName, Username = @Username, Password = @Password, Email = @Email, PhoneNumber = @PhoneNumber, Address = @Address WHERE CustomerID = @CustomerID"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                ' Bind parameters from textboxes
                command.Parameters.AddWithValue("@FullName", txtFullName.Text.Trim())
                command.Parameters.AddWithValue("@Username", txtUsername.Text.Trim())
                command.Parameters.AddWithValue("@Password", txtPassword.Text.Trim())
                command.Parameters.AddWithValue("@Email", txtEmail.Text.Trim())
                command.Parameters.AddWithValue("@PhoneNumber", txtPhone.Text.Trim())
                command.Parameters.AddWithValue("@Address", txtAddress.Text.Trim())

                ' IMPORTANT: Use the global variable for the WHERE clause
                command.Parameters.AddWithValue("@CustomerID", GlobalVariables.LoggedInCustomerID)

                Try
                    connection.Open()
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ' Lock textboxes again after saving
                        SetTextBoxState(True)
                    Else
                        MessageBox.Show("Update failed. Customer record not found.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error updating data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    ' -----------------------------------------------------------
    ' Cancel Button: Close the form
    ' -----------------------------------------------------------
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    ' -----------------------------------------------------------
    ' Helper Method: Toggle ReadOnly state of textboxes
    ' -----------------------------------------------------------
    Private Sub SetTextBoxState(isReadOnly As Boolean)
        txtFullName.ReadOnly = isReadOnly
        txtUsername.ReadOnly = isReadOnly
        txtPassword.ReadOnly = isReadOnly
        txtEmail.ReadOnly = isReadOnly
        txtPhone.ReadOnly = isReadOnly
        txtAddress.ReadOnly = isReadOnly

        ' Customer ID should ALWAYS be ReadOnly
        txtCustomerID.ReadOnly = True
    End Sub

End Class