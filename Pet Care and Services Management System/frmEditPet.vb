Imports MySql.Data.MySqlClient

Public Class frmEditPet

    ' DATABASE CONNECTION
    Private connectionString As String = "Server=localhost;Database=pet_care_and_services_management_system;Uid=root;Pwd=;"

    ' PET ID
    Private petID As String

    ' FORM CONSTRUCTOR
    Public Sub New(ByVal id As String)
        InitializeComponent()
        petID = id
    End Sub

    ' FORM LOAD
    Private Sub frmEditPet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPetData()
    End Sub

    ' LOAD PET DATA FROM DATABASE
    Private Sub LoadPetData()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim sql As String = "SELECT PetID, CustomerID, PetName, Gender, Breed, weight, Temperament FROM Pets WHERE PetID = @PetID"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@PetID", petID)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtPetID.Text = reader("PetID").ToString()
                            txtCustomerID.Text = reader("CustomerID").ToString()
                            txtPetName.Text = reader("PetName").ToString()
                            txtGender.Text = reader("Gender").ToString()
                            txtBreed.Text = reader("Breed").ToString()
                            txtWeight.Text = reader("weight").ToString()
                            txtTemperament.Text = reader("Temperament").ToString()

                        Else
                            MessageBox.Show("Pet not found.", "Edit Pet", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Me.Close()
                        End If
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Unable to load pet data." & Environment.NewLine & Environment.NewLine & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' SAVE CHANGES
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        ' VALIDATION
        If txtCustomerID.Text.Trim() = "" Then
            MessageBox.Show("Please enter Customer ID.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCustomerID.Focus()
            Exit Sub
        End If

        If txtPetName.Text.Trim() = "" Then
            MessageBox.Show("Please enter Pet Name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPetName.Focus()
            Exit Sub
        End If

        If txtGender.Text.Trim() = "" Then
            MessageBox.Show("Please enter Gender.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtGender.Focus()
            Exit Sub
        End If

        If txtBreed.Text.Trim() = "" Then
            MessageBox.Show("Please enter Breed.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtBreed.Focus()
            Exit Sub
        End If

        If txtWeight.Text.Trim() = "" Then
            MessageBox.Show("Please enter Weight.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtWeight.Focus()
            Exit Sub
        End If

        If txtTemperament.Text.Trim() = "" Then
            MessageBox.Show("Please enter Temperament.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTemperament.Focus()
            Exit Sub
        End If

        ' CHECK WEIGHT
        Dim weight As Decimal

        If Not Decimal.TryParse(txtWeight.Text.Trim(), weight) Then
            MessageBox.Show("Please enter a valid weight.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtWeight.Focus()
            Exit Sub
        End If

        ' UPDATE PET DATA
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim sql As String = "UPDATE Pets SET CustomerID = @CustomerID, PetName = @PetName, Gender = @Gender, Breed = @Breed, weight = @weight, Temperament = @Temperament WHERE PetID = @PetID"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@CustomerID", txtCustomerID.Text.Trim())
                    cmd.Parameters.AddWithValue("@PetName", txtPetName.Text.Trim())
                    cmd.Parameters.AddWithValue("@Gender", txtGender.Text.Trim())
                    cmd.Parameters.AddWithValue("@Breed", txtBreed.Text.Trim())
                    cmd.Parameters.AddWithValue("@weight", weight)
                    cmd.Parameters.AddWithValue("@Temperament", txtTemperament.Text.Trim())
                    cmd.Parameters.AddWithValue("@PetID", petID)

                    Dim result As Integer = cmd.ExecuteNonQuery()

                    If result > 0 Then
                        MessageBox.Show("Pet updated successfully!", "Edit Pet", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Me.DialogResult = DialogResult.OK
                        Me.Close()

                    Else
                        MessageBox.Show("Pet was not found.", "Edit Pet", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Unable to update pet." & Environment.NewLine & Environment.NewLine & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' CANCEL
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class