Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmAddProduct

    ' DATABASE CONNECTION
    Private connectionString As String = "Server=localhost;Database=pet_care_and_services_management_system;Uid=root;Pwd=;"

    Private selectedPhoto As Byte() = Nothing

    ' FORM LOAD
    Private Sub frmAddProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboCategory.SelectedIndex = -1
        picProduct.Image = Nothing
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
                    selectedPhoto = Nothing
                    picProduct.Image = Nothing
                    MessageBox.Show("Unable to load photo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

    ' SAVE PRODUCT
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtProductID.Text.Trim() = "" Then
            MessageBox.Show("Please enter Product ID.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtProductID.Focus()
            Return
        End If

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

                Dim query As String = "INSERT INTO Products (ProductID, ProductName, Category, Description, Price, StockQuantity, Photo) VALUES (@ProductID, @ProductName, @Category, @Description, @Price, @StockQuantity, @Photo)"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ProductID", txtProductID.Text.Trim())
                    cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text.Trim())
                    cmd.Parameters.AddWithValue("@Category", cboCategory.Text.Trim())
                    cmd.Parameters.AddWithValue("@Description", txtDescription.Text.Trim())
                    cmd.Parameters.AddWithValue("@Price", price)
                    cmd.Parameters.AddWithValue("@StockQuantity", stockQuantity)

                    If selectedPhoto Is Nothing Then
                        cmd.Parameters.Add("@Photo", MySqlDbType.LongBlob).Value = DBNull.Value
                    Else
                        cmd.Parameters.Add("@Photo", MySqlDbType.LongBlob).Value = selectedPhoto
                    End If

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Product added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MessageBox.Show("This Product ID already exists. Please enter a different Product ID.", "Duplicate Product ID", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Error adding product: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error adding product: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' CANCEL
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class