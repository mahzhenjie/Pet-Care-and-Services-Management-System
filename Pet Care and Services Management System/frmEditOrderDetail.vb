Imports MySql.Data.MySqlClient

Public Class frmEditOrderDetail

    ' DATABASE CONNECTION
    Private connectionString As String = "Server=localhost;Database=pet_care_and_services_management_system;Uid=root;Pwd=;"
    Private orderDetailID As String

    ' CONSTRUCTOR
    Public Sub New(ByVal id As String)
        InitializeComponent()
        orderDetailID = id
    End Sub

    ' FORM LOAD
    Private Sub frmEditOrderDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOrderDetailData()
    End Sub

    ' LOAD ORDER DETAIL DATA FROM DATABASE
    Private Sub LoadOrderDetailData()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim query As String = "SELECT OrderDetailID, OrderID, ProductID, Quantity, UnitPrice, Subtotal FROM OrderDetails WHERE OrderDetailID = @OrderDetailID"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@OrderDetailID", orderDetailID)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtOrderDetailID.Text = reader("OrderDetailID").ToString()
                            txtOrderID.Text = reader("OrderID").ToString()
                            txtProductID.Text = reader("ProductID").ToString()
                            txtQuantity.Text = reader("Quantity").ToString()
                            txtUnitPrice.Text = reader("UnitPrice").ToString()
                            txtSubtotal.Text = Convert.ToDecimal(reader("Subtotal")).ToString("0.00")
                        End If
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading order detail: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' CALCULATE SUBTOTAL
    Private Sub CalculateSubtotal()
        Dim quantity As Integer
        Dim unitPrice As Decimal

        If Integer.TryParse(txtQuantity.Text, quantity) AndAlso Decimal.TryParse(txtUnitPrice.Text, unitPrice) Then
            If quantity >= 0 AndAlso unitPrice >= 0 Then
                txtSubtotal.Text = (quantity * unitPrice).ToString("0.00")
            Else
                txtSubtotal.Text = "0.00"
            End If
        Else
            txtSubtotal.Text = "0.00"
        End If
    End Sub

    ' QUANTITY / UNIT PRICE CHANGED
    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged
        CalculateSubtotal()
    End Sub

    Private Sub txtUnitPrice_TextChanged(sender As Object, e As EventArgs) Handles txtUnitPrice.TextChanged
        CalculateSubtotal()
    End Sub

    ' SAVE ORDER DETAIL
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtProductID.Text.Trim() = "" Then
            MessageBox.Show("Please enter Product ID.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtProductID.Focus()
            Return
        End If

        Dim quantity As Integer

        If Not Integer.TryParse(txtQuantity.Text.Trim(), quantity) OrElse quantity <= 0 Then
            MessageBox.Show("Please enter a valid quantity.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtQuantity.Focus()
            Return
        End If

        Dim unitPrice As Decimal

        If Not Decimal.TryParse(txtUnitPrice.Text.Trim(), unitPrice) OrElse unitPrice < 0 Then
            MessageBox.Show("Please enter a valid unit price.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUnitPrice.Focus()
            Return
        End If

        Dim subtotal As Decimal = quantity * unitPrice

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim query As String = "UPDATE OrderDetails SET ProductID = @ProductID, Quantity = @Quantity, UnitPrice = @UnitPrice, Subtotal = @Subtotal WHERE OrderDetailID = @OrderDetailID"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ProductID", txtProductID.Text.Trim())
                    cmd.Parameters.AddWithValue("@Quantity", quantity)
                    cmd.Parameters.AddWithValue("@UnitPrice", unitPrice)
                    cmd.Parameters.AddWithValue("@Subtotal", subtotal)
                    cmd.Parameters.AddWithValue("@OrderDetailID", orderDetailID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Order detail updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error updating order detail: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' CANCEL
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class