Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmCustomerProduct

    ' DATABASE CONNECTION
    Private connectionString As String = "Server=localhost;Database=pet_care_and_services_management_system;Uid=root;Pwd=;"

    ' FORM LOAD
    Private Sub frmCustomerProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProducts()
    End Sub

    ' LOAD PRODUCTS FROM DATABASE
    Private Sub LoadProducts()
        flpProducts.Controls.Clear()

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim sql As String = "SELECT ProductID, ProductName, Category, Description, Price, StockQuantity, Photo FROM products ORDER BY ProductID"

                Using cmd As New MySqlCommand(sql, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim productID As Integer = Convert.ToInt32(reader("ProductID"))
                            Dim productName As String = reader("ProductName").ToString()
                            Dim category As String = reader("Category").ToString()
                            Dim description As String = reader("Description").ToString()
                            Dim price As Decimal = Convert.ToDecimal(reader("Price"))
                            Dim stock As Integer = Convert.ToInt32(reader("StockQuantity"))
                            Dim productImage As Image = Nothing

                            ' LOAD PRODUCT PHOTO
                            If Not IsDBNull(reader("Photo")) Then
                                Try
                                    Dim imageBytes() As Byte = DirectCast(reader("Photo"), Byte())

                                    Using ms As New MemoryStream(imageBytes)
                                        Using tempImage As Image = Image.FromStream(ms)
                                            productImage = New Bitmap(tempImage)
                                        End Using
                                    End Using
                                Catch
                                    productImage = Nothing
                                End Try
                            End If

                            ' PRODUCT CARD
                            Dim card As New Panel()
                            card.Width = 250
                            card.Height = 370
                            card.BackColor = Color.White
                            card.BorderStyle = BorderStyle.FixedSingle
                            card.Margin = New Padding(10)

                            ' PRODUCT PHOTO
                            Dim pic As New PictureBox()
                            pic.Width = 228
                            pic.Height = 150
                            pic.Location = New Point(10, 10)
                            pic.SizeMode = PictureBoxSizeMode.Zoom
                            pic.BackColor = Color.FromArgb(245, 245, 245)

                            If productImage IsNot Nothing Then
                                pic.Image = productImage
                            End If

                            ' PRODUCT NAME
                            Dim lblName As New Label()
                            lblName.Text = productName
                            lblName.Font = New Font("Segoe UI", 12.0!, FontStyle.Bold)
                            lblName.ForeColor = Color.FromArgb(74, 44, 26)
                            lblName.Location = New Point(10, 170)
                            lblName.Size = New Size(228, 30)
                            lblName.AutoEllipsis = True
                            lblName.Tag = productName

                            ' CATEGORY
                            Dim lblCategory As New Label()
                            lblCategory.Text = "Category: " & category
                            lblCategory.Font = New Font("Segoe UI", 9.0!)
                            lblCategory.Location = New Point(10, 202)
                            lblCategory.Size = New Size(228, 22)

                            ' PRICE
                            Dim lblPrice As New Label()
                            lblPrice.Text = "RM " & price.ToString("0.00")
                            lblPrice.Font = New Font("Segoe UI", 11.0!, FontStyle.Bold)
                            lblPrice.ForeColor = Color.FromArgb(112, 78, 51)
                            lblPrice.Location = New Point(10, 225)
                            lblPrice.Size = New Size(110, 25)

                            ' STOCK
                            Dim lblStock As New Label()
                            lblStock.Text = "Stock: " & stock.ToString()
                            lblStock.Font = New Font("Segoe UI", 9.0!)
                            lblStock.Location = New Point(120, 228)
                            lblStock.Size = New Size(110, 22)

                            ' DESCRIPTION
                            Dim lblDescription As New Label()
                            lblDescription.Text = description
                            lblDescription.Font = New Font("Segoe UI", 8.0!)
                            lblDescription.Location = New Point(10, 253)
                            lblDescription.Size = New Size(228, 35)
                            lblDescription.AutoEllipsis = True

                            ' ADD TO CART BUTTON
                            Dim btnAdd As New Button()
                            btnAdd.Text = "ADD TO CART"
                            btnAdd.Tag = productID
                            btnAdd.Width = 228
                            btnAdd.Height = 38
                            btnAdd.Location = New Point(10, 310)
                            btnAdd.BackColor = Color.FromArgb(74, 44, 26)
                            btnAdd.ForeColor = Color.White
                            btnAdd.FlatStyle = FlatStyle.Flat
                            btnAdd.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)

                            If stock <= 0 Then
                                btnAdd.Enabled = False
                                btnAdd.Text = "OUT OF STOCK"
                            Else
                                AddHandler btnAdd.Click, AddressOf AddToCart_Click
                            End If

                            card.Controls.Add(pic)
                            card.Controls.Add(lblName)
                            card.Controls.Add(lblCategory)
                            card.Controls.Add(lblPrice)
                            card.Controls.Add(lblStock)
                            card.Controls.Add(lblDescription)
                            card.Controls.Add(btnAdd)

                            flpProducts.Controls.Add(card)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Unable to load products." & Environment.NewLine & Environment.NewLine & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ADD PRODUCT TO CART
    Private Sub AddToCart_Click(sender As Object, e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        Dim productID As Integer = Convert.ToInt32(btn.Tag)

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim sql As String = "SELECT ProductID, ProductName, Category, Price, StockQuantity, Photo FROM products WHERE ProductID = @ProductID"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@ProductID", productID)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim productName As String = reader("ProductName").ToString()
                            Dim category As String = reader("Category").ToString()
                            Dim price As Decimal = Convert.ToDecimal(reader("Price"))
                            Dim stock As Integer = Convert.ToInt32(reader("StockQuantity"))
                            Dim productImage As Image = Nothing

                            If Not IsDBNull(reader("Photo")) Then
                                Try
                                    Dim imageBytes() As Byte = DirectCast(reader("Photo"), Byte())

                                    Using ms As New MemoryStream(imageBytes)
                                        Using tempImage As Image = Image.FromStream(ms)
                                            productImage = New Bitmap(tempImage)
                                        End Using
                                    End Using
                                Catch
                                    productImage = Nothing
                                End Try
                            End If

                            If stock <= 0 Then
                                MessageBox.Show("This product is out of stock.", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Return
                            End If

                            Dim currentQuantity As Integer = 0

                            If CustomerCart.ContainsKey(productID) Then
                                currentQuantity = CustomerCart(productID).Quantity
                            End If

                            Dim availableQuantity As Integer = stock - currentQuantity

                            If availableQuantity <= 0 Then
                                MessageBox.Show("You already added the maximum available stock to your cart.", "Stock Limit", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Return
                            End If

                            Dim quantityText As String = InputBox("Enter quantity for " & productName & ":" & Environment.NewLine & "Available Stock: " & availableQuantity.ToString(), "Add To Cart", "1")

                            If String.IsNullOrWhiteSpace(quantityText) Then
                                Return
                            End If

                            Dim quantity As Integer

                            If Not Integer.TryParse(quantityText, quantity) OrElse quantity <= 0 Then
                                MessageBox.Show("Please enter a valid quantity.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Return
                            End If

                            If quantity > availableQuantity Then
                                MessageBox.Show("The requested quantity is greater than the available stock.", "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Return
                            End If

                            AddToCart(productID, productName, category, price, quantity, productImage)

                            MessageBox.Show(productName & " has been added to your cart.", "Cart", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Unable to add product to cart." & Environment.NewLine & Environment.NewLine & ex.Message, "Cart Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ADD ITEM INTO CART
    Private Sub AddToCart(productID As Integer, productName As String, category As String, price As Decimal, quantity As Integer, productImage As Image)
        If Not CustomerCart.ContainsKey(productID) Then
            CustomerCart.Add(productID, New CartItem With {
                .ProductID = productID,
                .ProductName = productName,
                .Category = category,
                .UnitPrice = price,
                .Quantity = quantity,
                .ProductImage = productImage
            })
        Else
            CustomerCart(productID).Quantity += quantity

            If CustomerCart(productID).ProductImage Is Nothing AndAlso productImage IsNot Nothing Then
                CustomerCart(productID).ProductImage = productImage
            End If
        End If
    End Sub

    ' SEARCH PRODUCTS
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        SearchProducts()
    End Sub

    ' SEARCH
    Private Sub SearchProducts()
        Dim searchText As String = txtSearch.Text.Trim().ToLower()

        For Each card As Control In flpProducts.Controls
            If TypeOf card Is Panel Then
                Dim productName As String = ""

                For Each control As Control In card.Controls
                    If TypeOf control Is Label AndAlso control.Tag IsNot Nothing Then
                        productName = control.Tag.ToString().ToLower()
                        Exit For
                    End If
                Next

                card.Visible = String.IsNullOrWhiteSpace(searchText) OrElse productName.Contains(searchText)
            End If
        Next
    End Sub

    ' REFRESH
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtSearch.Clear()
        LoadProducts()
    End Sub

    ' VIEW CART
    Private Sub btnViewCart_Click(sender As Object, e As EventArgs) Handles btnViewCart.Click
        frmCustomerCart.ShowDialog()
    End Sub

    ' GO BACK TO DASHBOARD
    Private Sub btnGoBackDashboard_Click(sender As Object, e As EventArgs) Handles btnGoBackDashboard.Click
        frmCustomerDashboard.Show()
        Me.Close()
    End Sub

End Class