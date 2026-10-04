Imports MySql.Data.MySqlClient
Imports System.Data

Public Class FrmMyOrders

    Private connectionString As String = "Server=127.0.0.1;Database=pet_care_and_services_management_system;Uid=root;Pwd=;"
    Private dtOrders As DataTable

    ' -----------------------------------------------------------
    ' FORM LOAD
    ' -----------------------------------------------------------
    Private Sub FrmMyOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If GlobalVariables.LoggedInCustomerID <= 0 Then
            MessageBox.Show("Error: You must be logged in to view your orders.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If

        LoadOrders()
    End Sub

    ' -----------------------------------------------------------
    ' LOAD ORDERS FROM DATABASE
    ' -----------------------------------------------------------
    Private Sub LoadOrders()
        ' Select data from the orders table
        Dim query As String = "SELECT OrderID, OrderDate, TotalAmount, OrderStatus FROM orders WHERE CustomerID = @CustomerID ORDER BY OrderDate DESC"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@CustomerID", GlobalVariables.LoggedInCustomerID)

                Try
                    connection.Open()
                    Dim adapter As New MySqlDataAdapter(command)
                    dtOrders = New DataTable()
                    adapter.Fill(dtOrders)

                    ' Add the View Details button column before binding data
                    AddViewDetailsButton()

                    ' Bind data and apply any search filters
                    ApplySearchFilter()

                Catch ex As Exception
                    MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    ' -----------------------------------------------------------
    ' ADD VIEW DETAILS BUTTON COLUMN
    ' -----------------------------------------------------------
    Private Sub AddViewDetailsButton()
        If dgvOrders.Columns("ViewColumn") Is Nothing Then
            Dim viewBtn As New DataGridViewButtonColumn()
            viewBtn.Name = "ViewColumn"
            viewBtn.HeaderText = "View Details"
            viewBtn.Text = "View"
            viewBtn.UseColumnTextForButtonValue = True
            viewBtn.DefaultCellStyle.ForeColor = Color.Blue
            dgvOrders.Columns.Add(viewBtn)
        End If
    End Sub

    ' -----------------------------------------------------------
    ' SEARCH FUNCTIONALITY
    ' -----------------------------------------------------------
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        ApplySearchFilter()
    End Sub

    Private Sub ApplySearchFilter()
        If dtOrders IsNot Nothing Then
            Dim searchText As String = txtSearch.Text.Trim().Replace("'", "''")

            ' Ignore default placeholder text
            If String.IsNullOrWhiteSpace(searchText) OrElse searchText = "Search order..." Then
                dtOrders.DefaultView.RowFilter = ""
            Else
                ' Convert OrderID to a string to allow searching by ID, or search by Status
                dtOrders.DefaultView.RowFilter = String.Format("Convert(OrderID, 'System.String') LIKE '%{0}%' OR OrderStatus LIKE '%{0}%'", searchText)
            End If

            dgvOrders.DataSource = dtOrders

            ' Force the View Details button to the far right
            If dgvOrders.Columns.Contains("ViewColumn") Then
                dgvOrders.Columns("ViewColumn").DisplayIndex = dgvOrders.Columns.Count - 1
            End If
        End If
    End Sub

    ' -----------------------------------------------------------
    ' HANDLE BUTTON CLICKS IN THE DATAGRIDVIEW
    ' -----------------------------------------------------------
    Private Sub dgvOrders_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrders.CellContentClick
        If e.RowIndex < 0 Then Return

        Dim clickedColumn As String = dgvOrders.Columns(e.ColumnIndex).Name

        If clickedColumn = "ViewColumn" Then
            ' Retrieve the OrderID from the clicked row
            Dim selectedOrderID As Integer = Convert.ToInt32(dgvOrders.Rows(e.RowIndex).Cells("OrderID").Value)

            ' Open the Order Details form and pass the specific OrderID
            Dim detailForm As New FrmMyOrderDetail(selectedOrderID)
            detailForm.ShowDialog()
        End If
    End Sub

    ' -----------------------------------------------------------
    ' UI BUTTONS
    ' -----------------------------------------------------------
    Private Sub Refreshbtn_Click(sender As Object, e As EventArgs) Handles Refreshbtn.Click
        txtSearch.Clear()
        LoadOrders()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Me.Close()
    End Sub

End Class