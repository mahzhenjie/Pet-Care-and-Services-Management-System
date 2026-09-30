Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmEditBoardingService
    ' DATABASE CONNECTION
    Private connectionString As String = "Server=localhost;Database=pet_care_and_services_management_system;Uid=root;Pwd=;"
    ' SERVICE ID
    Private serviceID As Integer
    ' SELECTED PHOTO
    Private selectedPhoto() As Byte = Nothing

    ' FORM CONSTRUCTOR
    Public Sub New(serviceID As Integer)
        InitializeComponent()
        Me.serviceID = serviceID
    End Sub

    ' FORM LOAD
    Private Sub frmEditBoardingService_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBoardingService()
    End Sub

    ' LOAD BOARDING SERVICE FROM DATABASE
    Private Sub LoadBoardingService()
        Try
            Dim query As String = "SELECT ServiceName, Description, Price, Duration, ServicePhoto FROM BoardingServices WHERE ServiceID = @ServiceID"
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@ServiceID", serviceID)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            txtServiceName.Text = reader("ServiceName").ToString()
                            txtDescription.Text = reader("Description").ToString()
                            txtPrice.Text = Convert.ToDecimal(reader("Price")).ToString("0.00")
                            txtDuration.Text = reader("Duration").ToString()

                            ' LOAD SERVICE PHOTO
                            If Not IsDBNull(reader("ServicePhoto")) Then
                                Dim imageBytes() As Byte = DirectCast(reader("ServicePhoto"), Byte())
                                If imageBytes IsNot Nothing AndAlso imageBytes.Length > 0 Then
                                    Using memoryStream As New MemoryStream(imageBytes)
                                        Using tempImage As Image = Image.FromStream(memoryStream)
                                            picServicePhoto.Image = New Bitmap(tempImage)
                                        End Using
                                    End Using
                                    picServicePhoto.SizeMode = PictureBoxSizeMode.Zoom
                                End If
                            End If
                        Else
                            MessageBox.Show("Boarding service not found.", "Edit Service", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Me.Close()
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading boarding service: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' BROWSE SERVICE PHOTO
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Title = "Select Boarding Service Photo"
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Try
                    selectedPhoto = File.ReadAllBytes(openFileDialog.FileName)
                    Using memoryStream As New MemoryStream(selectedPhoto)
                        Using tempImage As Image = Image.FromStream(memoryStream)
                            picServicePhoto.Image = New Bitmap(tempImage)
                        End Using
                    End Using
                    picServicePhoto.SizeMode = PictureBoxSizeMode.Zoom
                Catch ex As Exception
                    MessageBox.Show("Unable to load the selected photo: " & ex.Message, "Photo Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    selectedPhoto = Nothing
                    picServicePhoto.Image = Nothing
                End Try
            End If
        End Using
    End Sub

    ' UPDATE BOARDING SERVICE
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' VALIDATE SERVICE NAME
        If txtServiceName.Text.Trim() = "" Then
            MessageBox.Show("Please enter the service name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtServiceName.Focus()
            Return
        End If

        ' VALIDATE DESCRIPTION
        If txtDescription.Text.Trim() = "" Then
            MessageBox.Show("Please enter the service description.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDescription.Focus()
            Return
        End If

        ' VALIDATE PRICE
        Dim price As Decimal
        If Not Decimal.TryParse(txtPrice.Text.Trim(), price) Then
            MessageBox.Show("Please enter a valid price.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPrice.Focus()
            Return
        End If
        If price < 0 Then
            MessageBox.Show("Price cannot be negative.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPrice.Focus()
            Return
        End If

        ' VALIDATE DURATION
        Dim duration As Integer
        If Not Integer.TryParse(txtDuration.Text.Trim(), duration) Then
            MessageBox.Show("Please enter a valid duration.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDuration.Focus()
            Return
        End If
        If duration <= 0 Then
            MessageBox.Show("Duration must be greater than 0.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDuration.Focus()
            Return
        End If

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String
                If selectedPhoto IsNot Nothing AndAlso selectedPhoto.Length > 0 Then
                    query = "UPDATE BoardingServices SET ServiceName = @ServiceName, Description = @Description, Price = @Price, Duration = @Duration, ServicePhoto = @ServicePhoto WHERE ServiceID = @ServiceID"
                Else
                    query = "UPDATE BoardingServices SET ServiceName = @ServiceName, Description = @Description, Price = @Price, Duration = @Duration WHERE ServiceID = @ServiceID"
                End If

                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@ServiceName", txtServiceName.Text.Trim())
                    command.Parameters.AddWithValue("@Description", txtDescription.Text.Trim())
                    command.Parameters.AddWithValue("@Price", price)
                    command.Parameters.AddWithValue("@Duration", duration)
                    command.Parameters.AddWithValue("@ServiceID", serviceID)

                    If selectedPhoto IsNot Nothing AndAlso selectedPhoto.Length > 0 Then
                        command.Parameters.Add("@ServicePhoto", MySqlDbType.LongBlob).Value = selectedPhoto
                    End If

                    Dim result As Integer = command.ExecuteNonQuery()
                    If result > 0 Then
                        MessageBox.Show("Boarding service updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.DialogResult = DialogResult.OK
                        Me.Close()
                    Else
                        MessageBox.Show("Boarding service was not found.", "Update Service", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error updating boarding service: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error updating boarding service: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' CANCEL
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class