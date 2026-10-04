Imports MySql.Data.MySqlClient
Imports System.Data

Public Class FrmMyPets

    Private connectionString As String = "Server=127.0.0.1;Database=pet_care_and_services_management_system;Uid=root;Pwd=;"

    Private Sub FrmMyPets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If GlobalVariables.LoggedInCustomerID <= 0 Then
            MessageBox.Show("Error: You must be logged in to view your pets.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If

        LoadPets()
    End Sub

    ' -----------------------------------------------------------
    ' Load Pets Data and Add Action Buttons
    ' -----------------------------------------------------------
    Private Sub LoadPets(Optional searchText As String = "")
        Dim query As String = "SELECT PetID, PetName, Gender, Breed, Weight, Temperament FROM pets WHERE CustomerID = @CustomerID"

        If Not String.IsNullOrWhiteSpace(searchText) Then
            query &= " AND (PetName LIKE @SearchText OR Breed LIKE @SearchText)"
        End If

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@CustomerID", GlobalVariables.LoggedInCustomerID)

                If Not String.IsNullOrWhiteSpace(searchText) Then
                    command.Parameters.AddWithValue("@SearchText", "%" & searchText & "%")
                End If

                Try
                    connection.Open()
                    Dim adapter As New MySqlDataAdapter(command)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)

                    dgvPets.DataSource = dataTable

                    ' Add Edit and Delete button columns dynamically if they do not exist
                    AddActionButtons()

                Catch ex As Exception
                    MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    Private Sub AddActionButtons()
        ' Add Edit Button Column if it does not exist
        If dgvPets.Columns("EditColumn") Is Nothing Then
            Dim editBtn As New DataGridViewButtonColumn()
            editBtn.Name = "EditColumn"
            editBtn.HeaderText = "Edit"
            editBtn.Text = "Edit"
            editBtn.UseColumnTextForButtonValue = True
            dgvPets.Columns.Add(editBtn)
        End If

        ' Add Delete Button Column if it does not exist
        If dgvPets.Columns("DeleteColumn") Is Nothing Then
            Dim deleteBtn As New DataGridViewButtonColumn()
            deleteBtn.Name = "DeleteColumn"
            deleteBtn.HeaderText = "Delete"
            deleteBtn.Text = "Delete"
            deleteBtn.UseColumnTextForButtonValue = True
            deleteBtn.DefaultCellStyle.ForeColor = Color.Red
            dgvPets.Columns.Add(deleteBtn)
        End If

        ' CRITICAL FIX: Force the columns to the end (right side) every time the data loads.
        ' We do this outside the If blocks because re-binding data resets the positions.
        If dgvPets.Columns.Contains("EditColumn") AndAlso dgvPets.Columns.Contains("DeleteColumn") Then
            dgvPets.Columns("EditColumn").DisplayIndex = dgvPets.Columns.Count - 1
            dgvPets.Columns("DeleteColumn").DisplayIndex = dgvPets.Columns.Count - 1
        End If
    End Sub

    ' -----------------------------------------------------------
    ' Handle Clicks on DataGridView Buttons
    ' -----------------------------------------------------------
    Private Sub dgvPets_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPets.CellContentClick
        ' Ignore clicks on the column headers
        If e.RowIndex < 0 Then Return

        ' Identify which column was clicked
        Dim clickedColumn As String = dgvPets.Columns(e.ColumnIndex).Name

        ' Retrieve the PetID from the clicked row (Assuming the column is named "PetID")
        Dim petId As Integer = Convert.ToInt32(dgvPets.Rows(e.RowIndex).Cells("PetID").Value)

        ' 1. If Edit Button Clicked
        If clickedColumn = "EditColumn" Then
            ' Pass the PetID to the form so it knows which pet to load
            Dim editForm As New FrmEditMyPet(petId)
            editForm.ShowDialog()

            ' Refresh the grid after the edit form is closed
            LoadPets()
        End If

        ' 2. If Delete Button Clicked
        If clickedColumn = "DeleteColumn" Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this pet?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                DeletePet(petId)
                LoadPets() ' Refresh grid after deletion
            End If
        End If
    End Sub

    ' -----------------------------------------------------------
    ' Delete Pet Database Logic
    ' -----------------------------------------------------------
    Private Sub DeletePet(petId As Integer)
        Dim query As String = "DELETE FROM pets WHERE PetID = @PetID"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@PetID", petId)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Pet deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Error deleting pet: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    ' -----------------------------------------------------------
    ' Existing Button Controls
    ' -----------------------------------------------------------
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtSearch.Clear()
        LoadPets()
    End Sub

    Private Sub btnAddPet_Click(sender As Object, e As EventArgs) Handles btnAddPet.Click
        Dim addPetForm As New FrmAddMyPet()
        addPetForm.ShowDialog()
        LoadPets()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadPets(txtSearch.Text.Trim())
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Me.Close()
    End Sub

End Class