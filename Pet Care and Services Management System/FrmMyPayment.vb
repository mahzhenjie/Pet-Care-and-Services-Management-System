Imports MySql.Data.MySqlClient
Imports System.Data

Public Class FrmMyPayment

    Private connectionString As String = "Server=127.0.0.1;Database=pet_care_and_services_management_system;Uid=root;Pwd=;"

    ' -----------------------------------------------------------
    ' FORM LOAD
    ' -----------------------------------------------------------
    Private Sub FrmMyPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If GlobalVariables.LoggedInCustomerID <= 0 Then
            MessageBox.Show("Error: You must be logged in to view your payments.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If

        LoadPayments()
    End Sub

    ' -----------------------------------------------------------
    ' LOAD PAYMENTS FROM DATABASE
    ' -----------------------------------------------------------
    Private Sub LoadPayments()

        Dim query As String = "SELECT PaymentID, PaymentDate, Amount, PaymentMethod, PaymentType, PaymentStatus FROM payments WHERE CustomerID = @CustomerID ORDER BY PaymentDate DESC"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                ' Bind to the currently logged-in customer
                command.Parameters.AddWithValue("@CustomerID", GlobalVariables.LoggedInCustomerID)

                Try
                    connection.Open()
                    Dim adapter As New MySqlDataAdapter(command)
                    Dim dtPayments As New DataTable()
                    adapter.Fill(dtPayments)

                    dgvPayments.DataSource = dtPayments

                Catch ex As Exception
                    MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

End Class