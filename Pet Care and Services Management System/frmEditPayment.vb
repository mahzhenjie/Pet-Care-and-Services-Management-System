Imports MySql.Data.MySqlClient

Public Class frmEditPayment

    ' DATABASE CONNECTION
    Private connectionString As String = "Server=localhost;Database=pet_care_and_services_management_system;Uid=root;Pwd=;"
    Private paymentID As String

    ' CONSTRUCTOR
    Public Sub New(ByVal id As String)
        InitializeComponent()
        paymentID = id
    End Sub

    ' FORM LOAD
    Private Sub frmEditPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPaymentMethod()
        LoadPaymentType()
        LoadPaymentStatus()
        LoadPaymentData()
    End Sub

    ' LOAD PAYMENT METHOD
    Private Sub LoadPaymentMethod()
        cboPaymentMethod.Items.Clear()
        cboPaymentMethod.Items.Add("Cash")
        cboPaymentMethod.Items.Add("Credit Card")
        cboPaymentMethod.Items.Add("Debit Card")
        cboPaymentMethod.Items.Add("Online Banking")
        cboPaymentMethod.Items.Add("E-Wallet")
    End Sub

    ' LOAD PAYMENT TYPE
    Private Sub LoadPaymentType()
        cboPaymentType.Items.Clear()
        cboPaymentType.Items.Add("Membership")
        cboPaymentType.Items.Add("Grooming")
        cboPaymentType.Items.Add("Boarding")
        cboPaymentType.Items.Add("Product")
    End Sub

    ' LOAD PAYMENT STATUS
    Private Sub LoadPaymentStatus()
        cboPaymentStatus.Items.Clear()
        cboPaymentStatus.Items.Add("Pending")
        cboPaymentStatus.Items.Add("Paid")
        cboPaymentStatus.Items.Add("Failed")
        cboPaymentStatus.Items.Add("Refunded")
    End Sub

    ' LOAD PAYMENT DATA FROM DATABASE
    Private Sub LoadPaymentData()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT PaymentID, CustomerID, PaymentDate, Amount, PaymentMethod, PaymentType, PaymentStatus FROM Payments WHERE PaymentID = @PaymentID"

                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@PaymentID", paymentID)

                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            txtPaymentID.Text = reader("PaymentID").ToString()
                            txtCustomerID.Text = reader("CustomerID").ToString()
                            dtpPaymentDate.Value = Convert.ToDateTime(reader("PaymentDate"))
                            txtAmount.Text = Convert.ToDecimal(reader("Amount")).ToString("0.00")
                            cboPaymentMethod.Text = reader("PaymentMethod").ToString()
                            cboPaymentType.Text = reader("PaymentType").ToString()
                            cboPaymentStatus.Text = reader("PaymentStatus").ToString()
                        End If
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading payment data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' SAVE PAYMENT
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim amount As Decimal

        If txtCustomerID.Text.Trim() = "" Then
            MessageBox.Show("Please enter Customer ID.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCustomerID.Focus()
            Exit Sub
        End If

        If txtAmount.Text.Trim() = "" Then
            MessageBox.Show("Please enter Amount.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAmount.Focus()
            Exit Sub
        End If

        If Not Decimal.TryParse(txtAmount.Text.Trim(), amount) Then
            MessageBox.Show("Please enter a valid Amount.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAmount.Focus()
            Exit Sub
        End If

        If amount < 0 Then
            MessageBox.Show("Amount cannot be negative.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAmount.Focus()
            Exit Sub
        End If

        If cboPaymentMethod.SelectedIndex = -1 Then
            MessageBox.Show("Please select Payment Method.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cboPaymentMethod.Focus()
            Exit Sub
        End If

        If cboPaymentType.SelectedIndex = -1 Then
            MessageBox.Show("Please select Payment Type.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cboPaymentType.Focus()
            Exit Sub
        End If

        If cboPaymentStatus.SelectedIndex = -1 Then
            MessageBox.Show("Please select Payment Status.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cboPaymentStatus.Focus()
            Exit Sub
        End If

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "UPDATE Payments SET CustomerID = @CustomerID, PaymentDate = @PaymentDate, Amount = @Amount, PaymentMethod = @PaymentMethod, PaymentType = @PaymentType, PaymentStatus = @PaymentStatus WHERE PaymentID = @PaymentID"

                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@CustomerID", txtCustomerID.Text.Trim())
                    command.Parameters.AddWithValue("@PaymentDate", dtpPaymentDate.Value.Date)
                    command.Parameters.AddWithValue("@Amount", amount)
                    command.Parameters.AddWithValue("@PaymentMethod", cboPaymentMethod.Text)
                    command.Parameters.AddWithValue("@PaymentType", cboPaymentType.Text)
                    command.Parameters.AddWithValue("@PaymentStatus", cboPaymentStatus.Text)
                    command.Parameters.AddWithValue("@PaymentID", paymentID)
                    command.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Payment updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error updating payment: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' CANCEL
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class