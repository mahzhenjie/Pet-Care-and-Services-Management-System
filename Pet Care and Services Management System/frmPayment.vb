Imports MySql.Data.MySqlClient

Public Class frmPayment

    ' DATABASE CONNECTION
    Private connectionString As String = "Server=localhost;Database=pet_care_and_services_management_system;Uid=root;Pwd=;"

    ' FORM LOAD
    Private Sub frmPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPaymentData()
        LoadPaymentMethod()
        LoadPaymentStatus()
    End Sub

    ' LOAD PAYMENT DATA FROM DATABASE
    Private Sub LoadPaymentData()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT PaymentID, CustomerID, PaymentDate, Amount, PaymentMethod, PaymentType, PaymentStatus FROM Payments ORDER BY PaymentID DESC"

                Using command As New MySqlCommand(query, connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        dgvPayment.Rows.Clear()

                        While reader.Read()
                            dgvPayment.Rows.Add(
                                reader("PaymentID").ToString(),
                                reader("CustomerID").ToString(),
                                Convert.ToDateTime(reader("PaymentDate")).ToString("dd/MM/yyyy"),
                                Convert.ToDecimal(reader("Amount")).ToString("0.00"),
                                reader("PaymentMethod").ToString(),
                                reader("PaymentType").ToString(),
                                reader("PaymentStatus").ToString(),
                                "[Edit]",
                                "[Delete]"
                            )
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading payment data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' LOAD PAYMENT METHOD
    Private Sub LoadPaymentMethod()
        cboMethod.Items.Clear()
        cboMethod.Items.Add("All")
        cboMethod.Items.Add("Cash")
        cboMethod.Items.Add("Credit Card")
        cboMethod.Items.Add("Debit Card")
        cboMethod.Items.Add("Online Banking")
        cboMethod.Items.Add("E-Wallet")
        cboMethod.SelectedIndex = 0
    End Sub

    ' LOAD PAYMENT STATUS
    Private Sub LoadPaymentStatus()
        cboStatus.Items.Clear()
        cboStatus.Items.Add("All")
        cboStatus.Items.Add("Pending")
        cboStatus.Items.Add("Paid")
        cboStatus.Items.Add("Failed")
        cboStatus.Items.Add("Refunded")
        cboStatus.SelectedIndex = 0
    End Sub

    ' GO BACK TO DASHBOARD
    Private Sub btnGoBackDashboard_Click(sender As Object, e As EventArgs) Handles btnGoBackDashboard.Click
        frmEmployeeDashboard.Show()
        Me.Close()
    End Sub

    ' REFRESH
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtSearch.Clear()
        cboMethod.SelectedIndex = 0
        cboStatus.SelectedIndex = 0
        LoadPaymentData()
    End Sub

    ' SEARCH PAYMENT
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text = "Search customer..." Then
            Exit Sub
        End If

        SearchPayment()
    End Sub

    ' SEARCH PAYMENT DATA
    Private Sub SearchPayment()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT PaymentID, CustomerID, PaymentDate, Amount, PaymentMethod, PaymentType, PaymentStatus FROM Payments WHERE PaymentID LIKE @Search OR CustomerID LIKE @Search OR PaymentMethod LIKE @Search OR PaymentType LIKE @Search OR PaymentStatus LIKE @Search ORDER BY PaymentID DESC"

                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Search", "%" & txtSearch.Text.Trim() & "%")

                    Using reader As MySqlDataReader = command.ExecuteReader()
                        dgvPayment.Rows.Clear()

                        While reader.Read()
                            dgvPayment.Rows.Add(
                                reader("PaymentID").ToString(),
                                reader("CustomerID").ToString(),
                                Convert.ToDateTime(reader("PaymentDate")).ToString("dd/MM/yyyy"),
                                Convert.ToDecimal(reader("Amount")).ToString("0.00"),
                                reader("PaymentMethod").ToString(),
                                reader("PaymentType").ToString(),
                                reader("PaymentStatus").ToString(),
                                "[Edit]",
                                "[Delete]"
                            )
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error searching payment: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' PAYMENT METHOD FILTER
    Private Sub cboMethod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMethod.SelectedIndexChanged
        FilterPayment()
    End Sub

    ' PAYMENT STATUS FILTER
    Private Sub cboStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStatus.SelectedIndexChanged
        FilterPayment()
    End Sub

    ' FILTER PAYMENT
    Private Sub FilterPayment()
        If cboMethod.SelectedIndex = -1 OrElse cboStatus.SelectedIndex = -1 Then
            Exit Sub
        End If

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT PaymentID, CustomerID, PaymentDate, Amount, PaymentMethod, PaymentType, PaymentStatus FROM Payments WHERE (@Method = 'All' OR PaymentMethod = @Method) AND (@Status = 'All' OR PaymentStatus = @Status) ORDER BY PaymentID DESC"

                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Method", cboMethod.Text)
                    command.Parameters.AddWithValue("@Status", cboStatus.Text)

                    Using reader As MySqlDataReader = command.ExecuteReader()
                        dgvPayment.Rows.Clear()

                        While reader.Read()
                            dgvPayment.Rows.Add(
                                reader("PaymentID").ToString(),
                                reader("CustomerID").ToString(),
                                Convert.ToDateTime(reader("PaymentDate")).ToString("dd/MM/yyyy"),
                                Convert.ToDecimal(reader("Amount")).ToString("0.00"),
                                reader("PaymentMethod").ToString(),
                                reader("PaymentType").ToString(),
                                reader("PaymentStatus").ToString(),
                                "[Edit]",
                                "[Delete]"
                            )
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error filtering payment: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' EDIT / DELETE BUTTON
    Private Sub dgvPayment_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPayment.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        If e.ColumnIndex = colEdit.Index Then
            Dim paymentID As String = dgvPayment.Rows(e.RowIndex).Cells(colPaymentID.Index).Value.ToString()

            Dim editForm As New frmEditPayment(paymentID)
            editForm.ShowDialog()

            LoadPaymentData()

        ElseIf e.ColumnIndex = colDelete.Index Then
            Dim paymentID As String = dgvPayment.Rows(e.RowIndex).Cells(colPaymentID.Index).Value.ToString()

            DeletePayment(paymentID)
        End If
    End Sub

    ' DELETE PAYMENT FROM DATABASE
    Private Sub DeletePayment(ByVal paymentID As String)
        If MessageBox.Show("Are you sure you want to delete this payment?", "Delete Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                Using connection As New MySqlConnection(connectionString)
                    connection.Open()

                    Dim query As String = "DELETE FROM Payments WHERE PaymentID = @PaymentID"

                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@PaymentID", paymentID)
                        command.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show("Payment deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                LoadPaymentData()

            Catch ex As Exception
                MessageBox.Show("Error deleting payment: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

End Class