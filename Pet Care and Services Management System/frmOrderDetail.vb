Imports MySql.Data.MySqlClient

Public Class frmOrderDetail

    ' DATABASE CONNECTION
    Private connectionString As String = "Server=localhost;Database=pet_care_and_services_management_system;Uid=root;Pwd=;"

    Private orderID As String

    ' FORM LOAD
    Private Sub frmOrderDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOrderDetailData()
    End Sub

    ' CONSTRUCTOR
    Public Sub New(ByVal id As String)
        InitializeComponent()
        orderID = id
    End Sub

    ' LOAD ORDER DETAIL DATA FROM DATABASE
    Private Sub LoadOrderDetailData()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim query As String = "SELECT OrderDetailID, OrderID, ProductID, Quantity, UnitPrice, Subtotal FROM OrderDetails WHERE OrderID = @OrderID"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@OrderID", orderID)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        dgvOrderDetail.Rows.Clear()

                        While reader.Read()
                            dgvOrderDetail.Rows.Add(
                                reader("OrderDetailID").ToString(),
                                reader("OrderID").ToString(),
                                reader("ProductID").ToString(),
                                reader("Quantity").ToString(),
                                reader("UnitPrice").ToString(),
                                reader("Subtotal").ToString(),
                                "[Edit]",
                                "[Delete]"
                            )
                        End While
                    End Using
                End Using
            End Using

            lblTitle.Text = "Order Detail Management - Order ID: " & orderID

        Catch ex As Exception
            MessageBox.Show("Error loading order detail: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ADD ORDER DETAIL
    Private Sub btnAddOrderDetail_Click(sender As Object, e As EventArgs) Handles btnAddOrderDetail.Click
        Dim frm As New frmAddOrderDetail(orderID)

        If frm.ShowDialog() = DialogResult.OK Then
            LoadOrderDetailData()
        End If
    End Sub

    ' REFRESH
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadOrderDetailData()
    End Sub

    ' SEARCH ORDER DETAIL
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text = "Search order detail..." Then
            Return
        End If

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim query As String = "SELECT OrderDetailID, OrderID, ProductID, Quantity, UnitPrice, Subtotal FROM OrderDetails WHERE OrderID = @OrderID AND (OrderDetailID LIKE @Search OR ProductID LIKE @Search OR Quantity LIKE @Search)"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@OrderID", orderID)
                    cmd.Parameters.AddWithValue("@Search", "%" & txtSearch.Text & "%")

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        dgvOrderDetail.Rows.Clear()

                        While reader.Read()
                            dgvOrderDetail.Rows.Add(
                                reader("OrderDetailID").ToString(),
                                reader("OrderID").ToString(),
                                reader("ProductID").ToString(),
                                reader("Quantity").ToString(),
                                reader("UnitPrice").ToString(),
                                reader("Subtotal").ToString(),
                                "[Edit]",
                                "[Delete]"
                            )
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error searching order detail: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' EDIT / DELETE BUTTON
    Private Sub dgvOrderDetail_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrderDetail.CellContentClick
        If e.RowIndex < 0 Then
            Return
        End If

        If e.ColumnIndex = colEdit.Index Then
            Dim orderDetailID As String = dgvOrderDetail.Rows(e.RowIndex).Cells(colOrderDetailID.Index).Value.ToString()

            Dim frm As New frmEditOrderDetail(orderDetailID)

            If frm.ShowDialog() = DialogResult.OK Then
                LoadOrderDetailData()
            End If

        ElseIf e.ColumnIndex = colDelete.Index Then
            Dim orderDetailID As String = dgvOrderDetail.Rows(e.RowIndex).Cells(colOrderDetailID.Index).Value.ToString()

            Dim result As DialogResult = MessageBox.Show(
                "Are you sure you want to delete Order Detail ID " & orderDetailID & "?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            )

            If result = DialogResult.Yes Then
                DeleteOrderDetail(orderDetailID)
            End If
        End If
    End Sub

    ' DELETE ORDER DETAIL FROM DATABASE
    Private Sub DeleteOrderDetail(ByVal orderDetailID As String)
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim query As String = "DELETE FROM OrderDetails WHERE OrderDetailID = @OrderDetailID"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@OrderDetailID", orderDetailID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Order detail deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            LoadOrderDetailData()

        Catch ex As Exception
            MessageBox.Show("Error deleting order detail: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' GO BACK TO DASHBOARD
    Private Sub btnGoBackDashboard_Click(sender As Object, e As EventArgs) Handles btnGoBackDashboard.Click
        Dim frm As New frmEmployeeDashboard
        frm.Show()
        Me.Close()
    End Sub

End Class