Imports MySql.Data.MySqlClient

Public Class frmCustomerPayment

    ' DATABASE CONNECTION
    Private connectionString As String = "Server=localhost;Database=pet_care_and_services_management_system;Uid=root;Pwd=;"
    Private totalAmount As Decimal

    ' CONSTRUCTOR
    Public Sub New(amount As Decimal)
        InitializeComponent()
        totalAmount = amount
    End Sub

    ' FORM LOAD
    Private Sub frmCustomerPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCustomerName.Text = CurrentUserName
        lblAmount.Text = "RM " & totalAmount.ToString("0.00")
        txtPaymentType.Text = "Product"
        txtPaymentStatus.Text = "Paid"

        If cboPaymentMethod.Items.Count > 0 Then
            cboPaymentMethod.SelectedIndex = 0
        End If
    End Sub

    ' PAY NOW
    Private Sub btnPayNow_Click(sender As Object, e As EventArgs) Handles btnPayNow.Click
        If CurrentUserID <= 0 Then
            MessageBox.Show("Customer information could not be found. Please login again.", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If cboPaymentMethod.SelectedIndex < 0 Then
            MessageBox.Show("Please select a payment method.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If CustomerCart.Count = 0 Then
            MessageBox.Show("Your cart is empty.", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to pay RM " & totalAmount.ToString("0.00") & "?", "Confirm Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result <> DialogResult.Yes Then
            Return
        End If

        ProcessPayment()
    End Sub

    ' PROCESS PAYMENT
    Private Sub ProcessPayment()
        Using conn As New MySqlConnection(connectionString)
            conn.Open()

            Using transaction As MySqlTransaction = conn.BeginTransaction()
                Try
                    ' CREATE ORDER
                    Dim orderID As Integer
                    Dim orderSQL As String = "INSERT INTO orders (CustomerID, OrderDate, TotalAmount, OrderStatus) VALUES (@CustomerID, @OrderDate, @TotalAmount, @OrderStatus)"

                    Using orderCmd As New MySqlCommand(orderSQL, conn, transaction)
                        orderCmd.Parameters.AddWithValue("@CustomerID", CurrentUserID)
                        orderCmd.Parameters.AddWithValue("@OrderDate", DateTime.Now)
                        orderCmd.Parameters.AddWithValue("@TotalAmount", totalAmount)
                        orderCmd.Parameters.AddWithValue("@OrderStatus", "Paid")
                        orderCmd.ExecuteNonQuery()
                        orderID = Convert.ToInt32(orderCmd.LastInsertedId)
                    End Using

                    ' CREATE ORDER DETAILS
                    For Each item As CartItem In CustomerCart.Values
                        Dim currentStock As Integer
                        Dim stockSQL As String = "SELECT StockQuantity FROM products WHERE ProductID = @ProductID FOR UPDATE"

                        Using stockCmd As New MySqlCommand(stockSQL, conn, transaction)
                            stockCmd.Parameters.AddWithValue("@ProductID", item.ProductID)

                            Dim stockResult As Object = stockCmd.ExecuteScalar()

                            If stockResult Is Nothing OrElse IsDBNull(stockResult) Then
                                Throw New Exception("Product ID " & item.ProductID.ToString() & " could not be found.")
                            End If

                            currentStock = Convert.ToInt32(stockResult)
                        End Using

                        If item.Quantity > currentStock Then
                            Throw New Exception(item.ProductName & " does not have enough stock. Available stock: " & currentStock.ToString())
                        End If

                        Dim detailSQL As String = "INSERT INTO orderdetails (OrderID, ProductID, Quantity, UnitPrice, Subtotal) VALUES (@OrderID, @ProductID, @Quantity, @UnitPrice, @Subtotal)"

                        Using detailCmd As New MySqlCommand(detailSQL, conn, transaction)
                            detailCmd.Parameters.AddWithValue("@OrderID", orderID)
                            detailCmd.Parameters.AddWithValue("@ProductID", item.ProductID)
                            detailCmd.Parameters.AddWithValue("@Quantity", item.Quantity)
                            detailCmd.Parameters.AddWithValue("@UnitPrice", item.UnitPrice)
                            detailCmd.Parameters.AddWithValue("@Subtotal", item.Subtotal)
                            detailCmd.ExecuteNonQuery()
                        End Using

                        ' UPDATE PRODUCT STOCK
                        Dim updateStockSQL As String = "UPDATE products SET StockQuantity = StockQuantity - @Quantity WHERE ProductID = @ProductID"

                        Using updateStockCmd As New MySqlCommand(updateStockSQL, conn, transaction)
                            updateStockCmd.Parameters.AddWithValue("@Quantity", item.Quantity)
                            updateStockCmd.Parameters.AddWithValue("@ProductID", item.ProductID)
                            updateStockCmd.ExecuteNonQuery()
                        End Using
                    Next

                    ' CREATE PAYMENT
                    Dim paymentSQL As String = "INSERT INTO payments (CustomerID, PaymentDate, Amount, PaymentMethod, PaymentType, PaymentStatus) VALUES (@CustomerID, @PaymentDate, @Amount, @PaymentMethod, @PaymentType, @PaymentStatus)"

                    Using paymentCmd As New MySqlCommand(paymentSQL, conn, transaction)
                        paymentCmd.Parameters.AddWithValue("@CustomerID", CurrentUserID)
                        paymentCmd.Parameters.AddWithValue("@PaymentDate", DateTime.Now)
                        paymentCmd.Parameters.AddWithValue("@Amount", totalAmount)
                        paymentCmd.Parameters.AddWithValue("@PaymentMethod", cboPaymentMethod.Text)
                        paymentCmd.Parameters.AddWithValue("@PaymentType", "Product")
                        paymentCmd.Parameters.AddWithValue("@PaymentStatus", "Paid")
                        paymentCmd.ExecuteNonQuery()
                    End Using

                    transaction.Commit()

                    MessageBox.Show("Payment successful!" & Environment.NewLine & Environment.NewLine & "Order ID: " & orderID.ToString() & Environment.NewLine & "Amount Paid: RM " & totalAmount.ToString("0.00") & Environment.NewLine & "Payment Method: " & cboPaymentMethod.Text, "Payment Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Me.DialogResult = DialogResult.OK
                    Me.Close()

                Catch ex As Exception
                    Try
                        transaction.Rollback()
                    Catch
                    End Try

                    MessageBox.Show("Payment failed." & Environment.NewLine & Environment.NewLine & ex.Message, "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    ' CANCEL
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class