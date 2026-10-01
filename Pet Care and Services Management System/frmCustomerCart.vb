Imports MySql.Data.MySqlClient

Public Class frmCustomerCart

    ' FORM LOAD
    Private Sub frmCustomerCart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCart()
    End Sub

    ' LOAD CART
    Private Sub LoadCart()
        dgvCart.Columns.Clear()
        dgvCart.Rows.Clear()

        Dim imageColumn As New DataGridViewImageColumn()
        imageColumn.Name = "Photo"
        imageColumn.HeaderText = "Photo"
        imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom
        imageColumn.Width = 100

        dgvCart.Columns.Add(imageColumn)

        dgvCart.Columns.Add("ProductID", "Product ID")
        dgvCart.Columns.Add("ProductName", "Product")
        dgvCart.Columns.Add("UnitPrice", "Price")
        dgvCart.Columns.Add("Quantity", "Quantity")
        dgvCart.Columns.Add("Subtotal", "Subtotal")

        dgvCart.Columns("ProductID").Visible = False
        dgvCart.Columns("Photo").Width = 100
        dgvCart.RowTemplate.Height = 90

        Dim total As Decimal = 0

        For Each item As CartItem In CustomerCart.Values
            Dim rowIndex As Integer =
                dgvCart.Rows.Add(
                    item.ProductImage,
                    item.ProductID,
                    item.ProductName,
                    "RM " & item.UnitPrice.ToString("0.00"),
                    item.Quantity,
                    "RM " & item.Subtotal.ToString("0.00")
                )

            dgvCart.Rows(rowIndex).Height = 90
            total += item.Subtotal
        Next

        lblTotal.Text = "Total: RM " & total.ToString("0.00")
    End Sub

    ' CHECKOUT
    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        If CustomerCart.Count = 0 Then
            MessageBox.Show(
                "Your cart is empty.",
                "Shopping Cart",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            Return
        End If

        Dim total As Decimal = 0

        For Each item As CartItem In CustomerCart.Values
            total += item.Subtotal
        Next

        Using paymentForm As New frmCustomerPayment(total)
            If paymentForm.ShowDialog() = DialogResult.OK Then
                CustomerCart.Clear()
                LoadCart()

                MessageBox.Show(
                    "Your order has been completed successfully.",
                    "Order Completed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )

                Me.Close()
            End If
        End Using
    End Sub

    ' CONTINUE SHOPPING
    Private Sub btnContinueShopping_Click(sender As Object, e As EventArgs) Handles btnContinueShopping.Click
        Me.Close()
    End Sub

End Class