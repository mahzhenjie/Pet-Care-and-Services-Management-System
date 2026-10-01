Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmEditGroomingService

    ' DATABASE CONNECTION
    Private connectionString As String = "Server=localhost;Database=pet_care_and_services_management_system;Uid=root;Pwd=;"

    ' SERVICE ID
    Private serviceID As Integer

    ' PHOTO DATA
    Private servicePhotoBytes() As Byte = Nothing

    ' FORM CONSTRUCTOR
    Public Sub New(serviceID As Integer)
        InitializeComponent()
        Me.serviceID = serviceID
    End Sub

    ' FORM LOAD
    Private Sub frmEditGroomingService_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGroomingService()
    End Sub

    ' LOAD GROOMING SERVICE FROM DATABASE
    Private Sub LoadGroomingService()
        Try
            Dim query As String = "SELECT ServiceName, Description, Price, Duration, ServicePhoto FROM GroomingServices WHERE ServiceID = @ServiceID"

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

                            If Not IsDBNull(reader("ServicePhoto")) Then
                                servicePhotoBytes = DirectCast(reader("ServicePhoto"), Byte())

                                If servicePhotoBytes IsNot Nothing AndAlso servicePhotoBytes.Length > 0 Then
                                    Using memoryStream As New MemoryStream(servicePhotoBytes)
                                        Using tempImage As Image = Image.FromStream(memoryStream)
                                            picServicePhoto.Image = New Bitmap(tempImage)
                                        End Using
                                    End Using
                                End If
                            End If
                        Else
                            MessageBox.Show("Grooming service not found.", "Edit Service", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Me.Close()
                        End If
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading grooming service: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' BROWSE PHOTO
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Title = "Select Grooming Service Photo"
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            openFileDialog.Multiselect = False

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Try
                    servicePhotoBytes = File.ReadAllBytes(openFileDialog.FileName)

                    Using memoryStream As New MemoryStream(servicePhotoBytes)
                        Using tempImage As Image = Image.FromStream(memoryStream)
                            picServicePhoto.Image = New Bitmap(tempImage)
                        End Using
                    End Using

                Catch ex As Exception
                    MessageBox.Show("Error loading photo: " & ex.Message, "Photo Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

    ' UPDATE GROOMING SERVICE
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtServiceName.Text.Trim() = "" Then
            MessageBox.Show("Please enter service name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtServiceName.Focus()
            Return
        End If

        If txtDescription.Text.Trim() = "" Then
            MessageBox.Show("Please enter description.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDescription.Focus()
            Return
        End If

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
            Dim query As String

            If servicePhotoBytes IsNot Nothing Then
                query = "UPDATE GroomingServices SET ServiceName = @ServiceName, Description = @Description, Price = @Price, Duration = @Duration, ServicePhoto = @ServicePhoto WHERE ServiceID = @ServiceID"
            Else
                query = "UPDATE GroomingServices SET ServiceName = @ServiceName, Description = @Description, Price = @Price, Duration = @Duration WHERE ServiceID = @ServiceID"
            End If

            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@ServiceName", txtServiceName.Text.Trim())
                    command.Parameters.AddWithValue("@Description", txtDescription.Text.Trim())
                    command.Parameters.AddWithValue("@Price", price)
                    command.Parameters.AddWithValue("@Duration", duration)
                    command.Parameters.AddWithValue("@ServiceID", serviceID)

                    If servicePhotoBytes IsNot Nothing Then
                        command.Parameters.Add("@ServicePhoto", MySqlDbType.LongBlob).Value = servicePhotoBytes
                    End If

                    command.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Grooming service updated successfully.", "Update Service", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error updating grooming service: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' CANCEL
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class