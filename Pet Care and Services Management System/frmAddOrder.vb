Imports MySql.Data.MySqlClient

Public Class frmAddOrder

    ' DATABASE CONNECTION
    Private connectionString As String = "Server=localhost;Database=pet_care_and_services_management_system;Uid=root;Pwd=;"

    ' FORM LOAD
    Private Sub frmAddOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpOrderDate.Value = DateTime.Today
        cboOrderStatus.SelectedIndex = 0
    End Sub

    ' SAVE ORDER
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtCustomerID.Text.Trim() = "" Then
            MessageBox.Show("Please enter Customer ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCustomerID.Focus()
            Exit Sub
        End If

        If txtTotalAmount.Text.Trim() = "" Then
            MessageBox.Show("Please enter Total Amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTotalAmount.Focus()
            Exit Sub
        End If

        Dim totalAmount As Decimal

        If Not Decimal.TryParse(txtTotalAmount.Text.Trim(), totalAmount) Then
            MessageBox.Show("Please enter a valid Total Amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTotalAmount.Focus()
            Exit Sub
        End If

        If totalAmount < 0 Then
            MessageBox.Show("Total Amount cannot be negative.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTotalAmount.Focus()
            Exit Sub
        End If

        If cboOrderStatus.SelectedIndex = -1 Then
            MessageBox.Show("Please select Order Status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cboOrderStatus.Focus()
            Exit Sub
        End If

        Try
            Dim conn As New MySqlConnection(connectionString)
            conn.Open()

            Dim sql As String = "INSERT INTO Orders (CustomerID, OrderDate, TotalAmount, OrderStatus) VALUES (@CustomerID, @OrderDate, @TotalAmount, @OrderStatus)"
            Dim cmd As New MySqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@CustomerID", txtCustomerID.Text.Trim())
            cmd.Parameters.AddWithValue("@OrderDate", dtpOrderDate.Value.Date)
            cmd.Parameters.AddWithValue("@TotalAmount", totalAmount)
            cmd.Parameters.AddWithValue("@OrderStatus", cboOrderStatus.Text)

            If cmd.ExecuteNonQuery() > 0 Then
                MessageBox.Show("Order added successfully.", "Add Order", MessageBoxButtons.OK, MessageBoxIcon.Information)

                cmd.Dispose()
                conn.Close()
                conn.Dispose()

                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MessageBox.Show("Order was not added.", "Add Order", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                cmd.Dispose()
                conn.Close()
                conn.Dispose()
            End If

        Catch ex As Exception
            MessageBox.Show("Unable to add order." & Environment.NewLine & Environment.NewLine & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' CANCEL
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class