Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing

Public Class frmProduct

    ' DATABASE CONNECTION
    Private connectionString As String = "Server=localhost;Database=pet_care_and_services_management_system;Uid=root;Pwd=;"

    ' FORM LOAD
    Private Sub frmProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategory()
        LoadProductData()
    End Sub

    ' LOAD CATEGORY
    Private Sub LoadCategory()
        Try
            cboCategory.Items.Clear()
            cboCategory.Items.Add("All")

            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim query As String = "SELECT DISTINCT Category FROM Products WHERE Category IS NOT NULL AND Category <> '' ORDER BY Category"

                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            cboCategory.Items.Add(reader("Category").ToString())
                        End While
                    End Using
                End Using
            End Using

            cboCategory.SelectedIndex = 0

        Catch ex As Exception
            MessageBox.Show("Error loading category: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' LOAD PRODUCT DATA FROM DATABASE
    Private Sub LoadProductData()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim query As String = "SELECT ProductID, ProductName, Category, Description, Price, StockQuantity, Photo FROM Products ORDER BY ProductID"

                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        dgvProduct.Rows.Clear()

                        While reader.Read()
                            Dim photo As Image = LoadProductImage(reader("Photo"))

                            Dim rowIndex As Integer = dgvProduct.Rows.Add(
                                reader("ProductID").ToString(),
                                reader("ProductName").ToString(),
                                reader("Category").ToString(),
                                reader("Description").ToString(),
                                reader("Price").ToString(),
                                reader("StockQuantity").ToString(),
                                photo,
                                "[Edit]",
                                "[Delete]"
                            )

                            If photo IsNot Nothing Then
                                dgvProduct.Rows(rowIndex).Height = 80
                            End If
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading product: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' LOAD PRODUCT IMAGE
    Private Function LoadProductImage(photoData As Object) As Image
        Try
            If photoData Is Nothing OrElse IsDBNull(photoData) Then
                Return Nothing
            End If

            Dim photoBytes() As Byte = CType(photoData, Byte())

            If photoBytes Is Nothing OrElse photoBytes.Length = 0 Then
                Return Nothing
            End If

            Using ms As New MemoryStream(photoBytes)
                Using tempImage As Image = Image.FromStream(ms)
                    Return New Bitmap(tempImage)
                End Using
            End Using

        Catch
            Return Nothing
        End Try
    End Function

    ' ADD PRODUCT
    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        Using frm As New frmAddProduct
            If frm.ShowDialog() = DialogResult.OK Then
                LoadCategory()
                LoadProductData()
            End If
        End Using
    End Sub

    ' REFRESH
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadCategory()
        LoadProductData()
    End Sub

    ' SEARCH PRODUCT
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text = "Search product..." Then
            Return
        End If

        SearchProduct()
    End Sub

    ' CATEGORY FILTER
    Private Sub cboCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCategory.SelectedIndexChanged
        If cboCategory.SelectedIndex >= 0 Then
            SearchProduct()
        End If
    End Sub

    ' SEARCH PRODUCT DATA
    Private Sub SearchProduct()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim query As String = "SELECT ProductID, ProductName, Category, Description, Price, StockQuantity, Photo FROM Products WHERE (ProductID LIKE @Search OR ProductName LIKE @Search OR Category LIKE @Search OR Description LIKE @Search)"

                If cboCategory.SelectedIndex > 0 AndAlso cboCategory.Text <> "Category" Then
                    query &= " AND Category = @Category"
                End If

                query &= " ORDER BY ProductID"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Search", "%" & txtSearch.Text.Trim() & "%")

                    If cboCategory.SelectedIndex > 0 AndAlso cboCategory.Text <> "Category" Then
                        cmd.Parameters.AddWithValue("@Category", cboCategory.Text)
                    End If

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        dgvProduct.Rows.Clear()

                        While reader.Read()
                            Dim photo As Image = LoadProductImage(reader("Photo"))

                            Dim rowIndex As Integer = dgvProduct.Rows.Add(
                                reader("ProductID").ToString(),
                                reader("ProductName").ToString(),
                                reader("Category").ToString(),
                                reader("Description").ToString(),
                                reader("Price").ToString(),
                                reader("StockQuantity").ToString(),
                                photo,
                                "[Edit]",
                                "[Delete]"
                            )

                            If photo IsNot Nothing Then
                                dgvProduct.Rows(rowIndex).Height = 80
                            End If
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error searching product: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' EDIT / DELETE BUTTON
    Private Sub dgvProduct_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProduct.CellContentClick
        If e.RowIndex < 0 Then
            Return
        End If

        If e.ColumnIndex = colEdit.Index Then
            Dim productID As String = dgvProduct.Rows(e.RowIndex).Cells(colProductID.Index).Value.ToString()

            Using frm As New frmEditProduct(productID)
                If frm.ShowDialog() = DialogResult.OK Then
                    LoadCategory()
                    LoadProductData()
                End If
            End Using

        ElseIf e.ColumnIndex = colDelete.Index Then
            Dim productID As String = dgvProduct.Rows(e.RowIndex).Cells(colProductID.Index).Value.ToString()

            Dim productName As String = dgvProduct.Rows(e.RowIndex).Cells(colProductName.Index).Value.ToString()

            If MessageBox.Show(
                "Are you sure you want to delete product '" & productName & "'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            ) = DialogResult.Yes Then

                DeleteProduct(productID)
            End If
        End If
    End Sub

    ' DELETE PRODUCT FROM DATABASE
    Private Sub DeleteProduct(ByVal productID As String)
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim query As String = "DELETE FROM Products WHERE ProductID = @ProductID"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ProductID", productID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Product deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            LoadCategory()
            LoadProductData()

        Catch ex As Exception
            MessageBox.Show("Error deleting product: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' GO BACK TO DASHBOARD
    Private Sub btnGoBackDashboard_Click(sender As Object, e As EventArgs) Handles btnGoBackDashboard.Click
        frmEmployeeDashboard.Show()
        Me.Close()
    End Sub

End Class