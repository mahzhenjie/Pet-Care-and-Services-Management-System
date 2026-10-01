Imports MySql.Data.MySqlClient

Public Class frmPet

    ' DATABASE CONNECTION
    Private connectionString As String = "Server=localhost;Database=pet_care_and_services_management_system;Uid=root;Pwd=;"

    ' FORM LOAD
    Private Sub frmPet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupDataGridView()
        LoadPetData()
    End Sub

    ' SETUP DATAGRIDVIEW
    Private Sub SetupDataGridView()
        dgvPet.AutoGenerateColumns = False

        colPetID.DataPropertyName = "PetID"
        colCustomerID.DataPropertyName = "CustomerID"
        colPetName.DataPropertyName = "PetName"
        colGender.DataPropertyName = "Gender"
        colBreed.DataPropertyName = "Breed"
        colWeight.DataPropertyName = "weight"
        colTemperament.DataPropertyName = "Temperament"
    End Sub

    ' LOAD PET DATA FROM DATABASE
    Private Sub LoadPetData()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim sql As String = "SELECT PetID, CustomerID, PetName, Gender, Breed, weight, Temperament FROM Pets ORDER BY PetID"

                Using cmd As New MySqlCommand(sql, conn)
                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim table As New DataTable()
                        adapter.Fill(table)

                        dgvPet.DataSource = Nothing
                        dgvPet.DataSource = table
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Unable to load pet data." & Environment.NewLine & Environment.NewLine & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' GO BACK TO DASHBOARD
    Private Sub btnGoBackDashboard_Click(sender As Object, e As EventArgs) Handles btnGoBackDashboard.Click
        frmEmployeeDashboard.Show()
        Me.Hide()
    End Sub

    ' ADD PET
    Private Sub btnAddPet_Click(sender As Object, e As EventArgs) Handles btnAddPet.Click
        Dim frm As New frmAddPet()

        If frm.ShowDialog() = DialogResult.OK Then
            LoadPetData()
        End If
    End Sub

    ' REFRESH
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtSearch.Text = ""
        LoadPetData()
    End Sub

    ' SEARCH PET
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim searchText As String = txtSearch.Text.Trim()

        If searchText = "" OrElse searchText = "Search customer..." Then
            LoadPetData()
            Exit Sub
        End If

        SearchPet(searchText)
    End Sub

    ' SEARCH PET FROM DATABASE
    Private Sub SearchPet(searchText As String)
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim sql As String = "SELECT PetID, CustomerID, PetName, Gender, Breed, weight, Temperament FROM Pets WHERE PetID LIKE @search OR CustomerID LIKE @search OR PetName LIKE @search OR Gender LIKE @search OR Breed LIKE @search OR weight LIKE @search OR Temperament LIKE @search ORDER BY PetID"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@search", "%" & searchText & "%")

                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim table As New DataTable()
                        adapter.Fill(table)

                        dgvPet.DataSource = Nothing
                        dgvPet.DataSource = table
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Search failed." & Environment.NewLine & Environment.NewLine & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' EDIT / DELETE BUTTON
    Private Sub dgvPet_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPet.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        If dgvPet.Rows(e.RowIndex).IsNewRow Then
            Exit Sub
        End If

        ' EDIT PET
        If e.ColumnIndex = colEdit.Index Then
            Dim petID As String = dgvPet.Rows(e.RowIndex).Cells("colPetID").Value.ToString()

            Dim frm As New frmEditPet(petID)

            If frm.ShowDialog() = DialogResult.OK Then
                LoadPetData()
            End If
        End If

        ' DELETE PET
        If e.ColumnIndex = colDelete.Index Then
            Dim petID As String = dgvPet.Rows(e.RowIndex).Cells("colPetID").Value.ToString()
            Dim petName As String = dgvPet.Rows(e.RowIndex).Cells("colPetName").Value.ToString()

            If MessageBox.Show("Are you sure you want to delete:" & Environment.NewLine & Environment.NewLine & petName & " (" & petID & ")?", "Delete Pet", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                DeletePet(petID)
            End If
        End If
    End Sub

    ' DELETE PET FROM DATABASE
    Private Sub DeletePet(petID As String)
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim sql As String = "DELETE FROM Pets WHERE PetID = @PetID"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@PetID", petID)

                    Dim result As Integer = cmd.ExecuteNonQuery()

                    If result > 0 Then
                        MessageBox.Show("Pet deleted successfully.", "Delete Pet", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LoadPetData()
                    Else
                        MessageBox.Show("Pet was not found.", "Delete Pet", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Unable to delete pet." & Environment.NewLine & Environment.NewLine & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class