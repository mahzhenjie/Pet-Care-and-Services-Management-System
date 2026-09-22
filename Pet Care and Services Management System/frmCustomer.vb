Imports MySql.Data.MySqlClient

Public Class frmCustomer

    ' DATABASE CONNECTION
    Private connectionString As String = "Server=localhost;Database=pet_care_and_services_management_system;Uid=root;Pwd=;"

    ' FORM LOAD
    Private Sub frmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomerData()
    End Sub

    ' LOAD CUSTOMER DATA FROM DATABASE
    Private Sub LoadCustomerData()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim sql As String =
                    "SELECT CustomerID, FullName, Username, Email, PhoneNumber, Address " &
                    "FROM Customers"

                Using cmd As New MySqlCommand(sql, conn)
                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim table As New DataTable()
                        adapter.Fill(table)
                        dgvCustomer.Rows.Clear()
                        For Each row As DataRow In table.Rows
                            dgvCustomer.Rows.Add(
                                row("CustomerID").ToString(),
                                row("FullName").ToString(),
                                row("Username").ToString(),
                                row("Email").ToString(),
                                row("PhoneNumber").ToString(),
                                row("Address").ToString()
                            )
                        Next
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

    ' GO BACK TO DASHBOARD
    Private Sub btnGoBackDashboard_Click(sender As Object, e As EventArgs) Handles btnGoBackDashboard.Click
        Dim frm As New frmEmployeeDashboard()
        frm.Show()
        Me.Hide()
    End Sub

    ' ADD CUSTOMER
    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        'Open Add Customer Form
        Dim frm As New frmAddCustomers()
        frm.ShowDialog()

        'Reload data after adding
        LoadCustomerData()
    End Sub

    ' REFRESH
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtSearch.Text = ""
        LoadCustomerData()
    End Sub

    ' SEARCH CUSTOMER
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim searchText As String = txtSearch.Text.Trim()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim sql As String =
                    "SELECT CustomerID, FullName, Username, Email, PhoneNumber, Address " &
                    "FROM Customers " &
                    "WHERE CustomerID LIKE @search " &
                    "OR FullName LIKE @search " &
                    "OR Username LIKE @search " &
                    "OR Email LIKE @search " &
                    "OR PhoneNumber LIKE @search " &
                    "OR Address LIKE @search"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue(
                        "@search",
                        "%" & searchText & "%"
                    )
                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim table As New DataTable()
                        adapter.Fill(table)
                        dgvCustomer.Rows.Clear()
                        For Each row As DataRow In table.Rows
                            dgvCustomer.Rows.Add(
                                row("CustomerID").ToString(),
                                row("FullName").ToString(),
                                row("Username").ToString(),
                                row("Email").ToString(),
                                row("PhoneNumber").ToString(),
                                row("Address").ToString()
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

    ' EDIT / DELETE BUTTON
    Private Sub dgvCustomer_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomer.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        If dgvCustomer.Rows(e.RowIndex).IsNewRow Then
            Exit Sub
        End If

        ' EDIT CUSTOMER
        If e.ColumnIndex = dgvCustomer.Columns("colEdit").Index Then
            Dim customerID As String = dgvCustomer.Rows(e.RowIndex).Cells("colCustomerID").Value.ToString()
            Dim frm As New frmEditCustomer(customerID)
            If frm.ShowDialog() = DialogResult.OK Then
                LoadCustomerData()
            End If
        End If

        ' DELETE CUSTOMER
        If e.ColumnIndex = dgvCustomer.Columns("colDelete").Index Then
            Dim customerID As String =
                dgvCustomer.Rows(e.RowIndex).
                Cells("colCustomerID").
                Value.ToString()
            Dim customerName As String =
                dgvCustomer.Rows(e.RowIndex).
                Cells("colFullName").
                Value.ToString()
            Dim result As DialogResult =
                MessageBox.Show(
                    "Are you sure you want to delete:" &
                    Environment.NewLine &
                    Environment.NewLine &
                    customerName &
                    " (" & customerID & ")?",
                    "Delete Customer",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                )

            If result = DialogResult.Yes Then
                DeleteCustomer(customerID)
            End If
        End If
    End Sub

    ' DELETE CUSTOMER FROM DATABASE
    Private Sub DeleteCustomer(customerID As String)
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim sql As String =
                    "DELETE FROM Customers " &
                    "WHERE CustomerID = @CustomerID"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue(
                        "@CustomerID",
                        customerID
                    )
                    Dim result As Integer =
                        cmd.ExecuteNonQuery()

                    If result > 0 Then
                        MessageBox.Show(
                            "Customer deleted successfully.",
                            "Delete Customer",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        )

                        LoadCustomerData()

                    Else
                        MessageBox.Show(
                            "Customer was not found.",
                            "Delete Customer",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        )
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(
                "Unable to delete customer." &
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