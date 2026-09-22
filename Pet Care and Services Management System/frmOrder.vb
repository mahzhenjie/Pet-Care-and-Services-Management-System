Imports MySql.Data.MySqlClient

Public Class frmOrder

    ' DATABASE CONNECTION
    Private connectionString As String = "Server=localhost;Database=pet_care_and_services_management_system;Uid=root;Pwd=;"

    ' FORM LOAD
    Private Sub frmOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboOrderStatus.Items.Clear()
        cboOrderStatus.Items.Add("All")
        cboOrderStatus.Items.Add("Pending")
        cboOrderStatus.Items.Add("Confirmed")
        cboOrderStatus.Items.Add("Completed")
        cboOrderStatus.Items.Add("Cancelled")
        cboOrderStatus.SelectedIndex = 0

        LoadOrderData()
    End Sub

    ' LOAD ORDER DATA FROM DATABASE
    Private Sub LoadOrderData()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim sql As String =
                    "SELECT OrderID, CustomerID, OrderDate, TotalAmount, OrderStatus " &
                    "FROM Orders"

                Using cmd As New MySqlCommand(sql, conn)
                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim table As New DataTable()
                        adapter.Fill(table)

                        dgvOrder.Rows.Clear()

                        For Each row As DataRow In table.Rows
                            dgvOrder.Rows.Add(
                                row("OrderID").ToString(),
                                row("CustomerID").ToString(),
                                row("OrderDate").ToString(),
                                row("TotalAmount").ToString(),
                                row("OrderStatus").ToString()
                            )
                        Next
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(
                "Unable to load order data." &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "Database Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        End Try
    End Sub

    ' GO BACK TO DASHBOARD
    Private Sub btnGoBackDashboard_Click(sender As Object, e As EventArgs) Handles btnGoBackDashboard.Click
        Dim frm As New frmEmployeeDashboard()
        frm.Show()
        Me.Hide()
    End Sub

    ' ADD ORDER
    Private Sub btnAddOrder_Click(sender As Object, e As EventArgs) Handles btnAddOrder.Click
        Dim frm As New frmAddOrder()

        If frm.ShowDialog() = DialogResult.OK Then
            LoadOrderData()
        End If
    End Sub

    ' REFRESH
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtSearch.Text = ""
        cboOrderStatus.SelectedIndex = 0
        LoadOrderData()
    End Sub

    ' SEARCH ORDER
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim searchText As String = txtSearch.Text.Trim()

        If searchText = "" Or searchText = "Search order..." Then
            LoadOrderData()
            Exit Sub
        End If

        SearchOrder(searchText)
    End Sub

    ' SEARCH ORDER FROM DATABASE
    Private Sub SearchOrder(searchText As String)
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim sql As String =
                    "SELECT OrderID, CustomerID, OrderDate, TotalAmount, OrderStatus " &
                    "FROM Orders " &
                    "WHERE OrderID LIKE @search " &
                    "OR CustomerID LIKE @search " &
                    "OR OrderDate LIKE @search " &
                    "OR TotalAmount LIKE @search " &
                    "OR OrderStatus LIKE @search"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@search", "%" & searchText & "%")

                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim table As New DataTable()
                        adapter.Fill(table)

                        dgvOrder.Rows.Clear()

                        For Each row As DataRow In table.Rows
                            dgvOrder.Rows.Add(
                                row("OrderID").ToString(),
                                row("CustomerID").ToString(),
                                row("OrderDate").ToString(),
                                row("TotalAmount").ToString(),
                                row("OrderStatus").ToString()
                            )
                        Next
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(
                "Search failed." &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "Database Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        End Try
    End Sub

    ' FILTER ORDER STATUS
    Private Sub cboOrderStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOrderStatus.SelectedIndexChanged
        If cboOrderStatus.SelectedIndex <= 0 Then
            LoadOrderData()
            Exit Sub
        End If

        Dim status As String = cboOrderStatus.Text

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim sql As String =
                    "SELECT OrderID, CustomerID, OrderDate, TotalAmount, OrderStatus " &
                    "FROM Orders " &
                    "WHERE OrderStatus = @OrderStatus"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@OrderStatus", status)

                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim table As New DataTable()
                        adapter.Fill(table)

                        dgvOrder.Rows.Clear()

                        For Each row As DataRow In table.Rows
                            dgvOrder.Rows.Add(
                                row("OrderID").ToString(),
                                row("CustomerID").ToString(),
                                row("OrderDate").ToString(),
                                row("TotalAmount").ToString(),
                                row("OrderStatus").ToString()
                            )
                        Next
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(
                "Unable to filter order data." &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "Database Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        End Try
    End Sub

    ' VIEW / DELETE BUTTON
    Private Sub dgvOrder_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrder.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        If dgvOrder.Rows(e.RowIndex).IsNewRow Then
            Exit Sub
        End If

        ' VIEW ORDER DETAIL
        If e.ColumnIndex = dgvOrder.Columns("colView").Index Then
            Dim orderID As String = dgvOrder.Rows(e.RowIndex).Cells("colOrderID").Value.ToString()
            Dim frm As New frmOrderDetail(orderID)
            frm.ShowDialog()
        End If

        ' DELETE ORDER
        If e.ColumnIndex = dgvOrder.Columns("colDelete").Index Then
            Dim orderID As String = dgvOrder.Rows(e.RowIndex).Cells("colOrderID").Value.ToString()
            Dim customerID As String = dgvOrder.Rows(e.RowIndex).Cells("colCustomerID").Value.ToString()

            Dim result As DialogResult =
                MessageBox.Show(
                    "Are you sure you want to delete this order?" &
                    Environment.NewLine &
                    Environment.NewLine &
                    "Order ID: " & orderID &
                    Environment.NewLine &
                    "Customer ID: " & customerID,
                    "Delete Order",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                )

            If result = DialogResult.Yes Then
                DeleteOrder(orderID)
            End If
        End If
    End Sub

    ' DELETE ORDER FROM DATABASE
    Private Sub DeleteOrder(orderID As String)
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim deleteDetailSql As String =
                    "DELETE FROM OrderDetails " &
                    "WHERE OrderID = @OrderID"

                Using detailCmd As New MySqlCommand(deleteDetailSql, conn)
                    detailCmd.Parameters.AddWithValue("@OrderID", orderID)
                    detailCmd.ExecuteNonQuery()
                End Using

                Dim sql As String =
                    "DELETE FROM Orders " &
                    "WHERE OrderID = @OrderID"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@OrderID", orderID)

                    Dim result As Integer = cmd.ExecuteNonQuery()

                    If result > 0 Then
                        MessageBox.Show(
                            "Order deleted successfully.",
                            "Delete Order",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        )

                        LoadOrderData()
                    Else
                        MessageBox.Show(
                            "Order was not found.",
                            "Delete Order",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        )
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(
                "Unable to delete order." &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "Database Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        End Try
    End Sub

End Class