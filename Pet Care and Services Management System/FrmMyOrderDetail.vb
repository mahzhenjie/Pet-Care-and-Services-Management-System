Imports MySql.Data.MySqlClient
Imports System.Data

Public Class FrmMyOrderDetail
    Private connectionString As String = "Server=127.0.0.1;Database=pet_care_and_services_management_system;Uid=root;Pwd=;"
    Private currentOrderID As Integer

    ' Modify the constructor (New) to accept the OrderID from FrmMyOrders
    Public Sub New(orderID As Integer)
        InitializeComponent()
        currentOrderID = orderID
    End Sub

    Private Sub FrmOrderDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Use an INNER JOIN to get the Product Name alongside the order details
        Dim query As String = "
            SELECT 
                p.ProductName, 
                od.Quantity, 
                od.UnitPrice, 
                od.Subtotal 
            FROM orderdetails od 
            INNER JOIN products p ON od.ProductID = p.ProductID 
            WHERE od.OrderID = @OrderID"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@OrderID", currentOrderID)

                Try
                    connection.Open()
                    Dim adapter As New MySqlDataAdapter(command)
                    Dim dtDetails As New DataTable()
                    adapter.Fill(dtDetails)

                    ' Bind to a DataGridView in your FrmOrderDetail UI
                    dgvOrderDetails.DataSource = dtDetails
                Catch ex As Exception
                    MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    Private Sub dgvOrderDetails_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrderDetails.CellContentClick

    End Sub
End Class