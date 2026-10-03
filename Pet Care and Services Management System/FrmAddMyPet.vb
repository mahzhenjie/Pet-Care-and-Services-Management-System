Imports MySql.Data.MySqlClient

Public Class FrmAddMyPet

    ' Define the database connection string
    Private connectionString As String = "Server=127.0.0.1;Database=pet_care_and_services_management_system;Uid=root;Pwd=;"

    ' -----------------------------------------------------------
    ' Form Load Event
    ' -----------------------------------------------------------
    Private Sub FrmAddMyPet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Check if a user is logged in before allowing them to add a pet
        If GlobalVariables.LoggedInCustomerID <= 0 Then
            MessageBox.Show("Error: You must be logged in to add a pet.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If

        ' Optional: Set default selection for Gender ComboBox
        If cmbGender.Items.Count > 0 Then
            cmbGender.SelectedIndex = 0
        End If
    End Sub

    ' -----------------------------------------------------------
    ' Save Button: Insert new pet into the database
    ' -----------------------------------------------------------
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' 1. Validate inputs
        If String.IsNullOrWhiteSpace(txtPetName.Text) OrElse
           cmbGender.SelectedItem Is Nothing OrElse
           String.IsNullOrWhiteSpace(txtBreed.Text) OrElse
           String.IsNullOrWhiteSpace(txtWeight.Text) Then

            MessageBox.Show("Please fill in all required fields (Name, Gender, Breed, Weight).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validate if Weight is a valid number
        Dim petWeight As Decimal
        If Not Decimal.TryParse(txtWeight.Text.Trim(), petWeight) Then
            MessageBox.Show("Please enter a valid number for Weight.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' 2. Prepare the SQL INSERT statement
        ' Note: PetID is omitted because the database auto-generates it.
        Dim query As String = "INSERT INTO pets (CustomerID, PetName, Gender, Breed, Weight, Temperament) VALUES (@CustomerID, @PetName, @Gender, @Breed, @Weight, @Temperament)"

        ' 3. Execute database operation
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)

                ' Bind parameters
                ' Link the pet to the currently logged-in customer
                command.Parameters.AddWithValue("@CustomerID", GlobalVariables.LoggedInCustomerID)

                command.Parameters.AddWithValue("@PetName", txtPetName.Text.Trim())
                command.Parameters.AddWithValue("@Gender", cmbGender.SelectedItem.ToString())
                command.Parameters.AddWithValue("@Breed", txtBreed.Text.Trim())
                command.Parameters.AddWithValue("@Weight", petWeight)

                ' Temperament can be optional, handle accordingly
                command.Parameters.AddWithValue("@Temperament", txtTemperament.Text.Trim())

                Try
                    connection.Open()
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("New pet added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ' Close the form after successful insertion
                        Me.Close()
                    Else
                        MessageBox.Show("Failed to add the pet. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    ' -----------------------------------------------------------
    ' Cancel Button: Close the form
    ' -----------------------------------------------------------
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class