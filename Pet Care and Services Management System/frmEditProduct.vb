Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmEditProduct

    ' DATABASE CONNECTION
    Private connectionString As String = "Server=localhost;Database=pet_care_and_services_management_system;Uid=root;Pwd=;"

    Private productID As String
    Private selectedPhoto As Byte() = Nothing

    ' CONSTRUCTOR
    Public Sub New(ByVal id As String)
        InitializeComponent()
        productID = id
    End Sub

    ' FORM LOAD
    Private Sub frmEditProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProductData()
    End Sub

    ' LOAD PRODUCT DATA FROM DATABASE
    Private Sub LoadProductData()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim query As String = "SELECT ProductID, ProductName, Category, Description, Price, StockQuantity, Photo FROM Products WHERE ProductID = @ProductID"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ProductID", productID)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtProductID.Text = reader("ProductID").ToString()
                            txtProductName.Text = reader("ProductName").ToString()
                            cboCategory.Text = reader("Category").ToString()
                            txtDescription.Text = reader("Description").ToString()
                            txtPrice.Text = reader("Price").ToString()
                            txtStockQuantity.Text = reader("StockQuantity").ToString()

                            If Not IsDBNull(reader("Photo")) Then
                                selectedPhoto = CType(reader("Photo"), Byte())

                                If selectedPhoto.Length > 0 Then
                                    Using ms As New MemoryStream(selectedPhoto)
                                        Using tempImage As Image = Image.FromStream(ms)
                                            picProduct.Image = New Bitmap(tempImage)
                                        End Using
                                    End Using
                                End If
                            Else
                                selectedPhoto = Nothing
                                picProduct.Image = Nothing
                            End If
                        End If
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading product: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' CHOOSE PHOTO
    Private Sub btnChoosePhoto_Click(sender As Object, e As EventArgs) Handles btnChoosePhoto.Click
        Using openFile As New OpenFileDialog()
            openFile.Title = "Select Product Photo"
            openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*"

            If openFile.ShowDialog() = DialogResult.OK Then
                Try
                    selectedPhoto = File.ReadAllBytes(openFile.FileName)

                    Using ms As New MemoryStream(selectedPhoto)
                        Using tempImage As Image = Image.FromStream(ms)
                            picProduct.Image = New Bitmap(tempImage)
                        End Using
                    End Using

                Catch ex As Exception
                    MessageBox.Show("Unable to load photo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

    ' SAVE PRODUCT
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtProductName.Text.Trim() = "" Then
            MessageBox.Show("Please enter Product Name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtProductName.Focus()
            Return
        End If

        If cboCategory.Text.Trim() = "" Then
            MessageBox.Show("Please select Category.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cboCategory.Focus()
            Return
        End If

        Dim price As Decimal

        If Not Decimal.TryParse(txtPrice.Text.Trim(), price) OrElse price < 0 Then
            MessageBox.Show("Please enter a valid price.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPrice.Focus()
            Return
        End If

        Dim stockQuantity As Integer

        If Not Integer.TryParse(txtStockQuantity.Text.Trim(), stockQuantity) OrElse stockQuantity < 0 Then
            MessageBox.Show("Please enter a valid stock quantity.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtStockQuantity.Focus()
            Return
        End If

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim query As String = "UPDATE Products SET ProductName = @ProductName, Category = @Category, Description = @Description, Price = @Price, StockQuantity = @StockQuantity, Photo = @Photo WHERE ProductID = @ProductID"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text.Trim())
                    cmd.Parameters.AddWithValue("@Category", cboCategory.Text.Trim())
                    cmd.Parameters.AddWithValue("@Description", txtDescription.Text.Trim())
                    cmd.Parameters.AddWithValue("@Price", price)
                    cmd.Parameters.AddWithValue("@StockQuantity", stockQuantity)
                    cmd.Parameters.AddWithValue("@ProductID", productID)

                    If selectedPhoto Is Nothing Then
                        cmd.Parameters.Add("@Photo", MySqlDbType.LongBlob).Value = DBNull.Value
                    Else
                        cmd.Parameters.Add("@Photo", MySqlDbType.LongBlob).Value = selectedPhoto
                    End If

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Product updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error updating product: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' CANCEL
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class