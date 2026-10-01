Imports MySql.Data.MySqlClient

Public Class frmAddPet

    ' DATABASE CONNECTION
    Private connectionString As String = "Server=localhost;Database=pet_care_and_services_management_system;Uid=root;Pwd=;"

    ' FORM LOAD
    Private Sub frmAddPet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCustomerID.Focus()
    End Sub

    ' SAVE PET
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

        If weight <= 0 Then
            MessageBox.Show("Weight must be greater than 0.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtWeight.Focus()
            Exit Sub
        End If

        ' INSERT PET INTO DATABASE
        Try
            Dim conn As New MySqlConnection(connectionString)
            conn.Open()

            Dim sql As String = "INSERT INTO Pets (CustomerID, PetName, Gender, Breed, weight, Temperament) VALUES (@CustomerID, @PetName, @Gender, @Breed, @weight, @Temperament)"
            Dim cmd As New MySqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@CustomerID", txtCustomerID.Text.Trim())
            cmd.Parameters.AddWithValue("@PetName", txtPetName.Text.Trim())
            cmd.Parameters.AddWithValue("@Gender", txtGender.Text.Trim())
            cmd.Parameters.AddWithValue("@Breed", txtBreed.Text.Trim())
            cmd.Parameters.AddWithValue("@weight", weight)
            cmd.Parameters.AddWithValue("@Temperament", txtTemperament.Text.Trim())

            If cmd.ExecuteNonQuery() > 0 Then
                MessageBox.Show("Pet added successfully!", "Add Pet", MessageBoxButtons.OK, MessageBoxIcon.Information)

                cmd.Dispose()
                conn.Close()
                conn.Dispose()

                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MessageBox.Show("Pet could not be added.", "Add Pet", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                cmd.Dispose()
                conn.Close()
                conn.Dispose()
            End If

        Catch ex As Exception
            MessageBox.Show("Unable to add pet." & Environment.NewLine & Environment.NewLine & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' CANCEL
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class