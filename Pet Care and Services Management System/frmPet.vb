Imports MySql.Data.MySqlClient

Public Class frmPet

    Private connectionString As String = "Server=localhost;Database=pet_care_and_services_management_system;Uid=root;Pwd=;"

    Private Sub frmPet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPetData()
    End Sub

    Private Sub LoadPetData()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim sql As String =
                    "SELECT PetID, CustomerID, PetName, Gender, Breed, weight, Temperament " &
                    "FROM Pets"
                Using cmd As New MySqlCommand(sql, conn)
                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim table As New DataTable()
                        adapter.Fill(table)
                        dgvPet.Rows.Clear()
                        For Each row As DataRow In table.Rows
                            dgvPet.Rows.Add(
                                row("PetID").ToString(),
                                row("CustomerID").ToString(),
                                row("PetName").ToString(),
                                row("Gender").ToString(),
                                row("Breed").ToString(),
                                row("weight").ToString(),
                                row("Temperament").ToString()
                            )
                        Next
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(
                "Unable to load pet data." &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "Database Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        End Try
    End Sub

    Private Sub btnGoBackDashboard_Click(sender As Object, e As EventArgs) Handles btnGoBackDashboard.Click
        Dim frm As New frmEmployeeDashboard()
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub btnAddPet_Click(sender As Object, e As EventArgs) Handles btnAddPet.Click
        Dim frm As New frmAddPet()
        frm.ShowDialog()
        LoadPetData()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtSearch.Text = ""
        LoadPetData()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim searchText As String = txtSearch.Text.Trim()
        If searchText = "" OrElse
            searchText = "Search customer..." Then
            LoadPetData()
            Exit Sub
        End If
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim sql As String =
                    "SELECT PetID, CustomerID, PetName, Gender, Breed, weight, Temperament " &
                    "FROM Pets " &
                    "WHERE PetID LIKE @search " &
                    "OR CustomerID LIKE @search " &
                    "OR PetName LIKE @search " &
                    "OR Gender LIKE @search " &
                    "OR Breed LIKE @search " &
                    "OR weight LIKE @search " &
                    "OR Temperament LIKE @search"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue(
                        "@search",
                        "%" & searchText & "%"
                    )
                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim table As New DataTable()
                        adapter.Fill(table)
                        dgvPet.Rows.Clear()
                        For Each row As DataRow In table.Rows
                            dgvPet.Rows.Add(
                                row("PetID").ToString(),
                                row("CustomerID").ToString(),
                                row("PetName").ToString(),
                                row("Gender").ToString(),
                                row("Breed").ToString(),
                                row("weight").ToString(),
                                row("Temperament").ToString()
                            )
                        Next
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(
                "Search failed." &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "Database Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        End Try
    End Sub

    Private Sub dgvPet_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPet.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        If dgvPet.Rows(e.RowIndex).IsNewRow Then
            Exit Sub
        End If

        ' EDIT PET
        If e.ColumnIndex = dgvPet.Columns("colEdit").Index Then
            Dim petID As String =
                dgvPet.Rows(e.RowIndex).
                Cells("colPetID").
                Value.ToString()

            Dim frm As New frmEditPet(petID)
            If frm.ShowDialog() = DialogResult.OK Then
                LoadPetData()
            End If
        End If

        ' DELETE PET
        If e.ColumnIndex = dgvPet.Columns("colDelete").Index Then
            Dim petID As String =
                dgvPet.Rows(e.RowIndex).
                Cells("colPetID").
                Value.ToString()

            Dim petName As String =
                dgvPet.Rows(e.RowIndex).
                Cells("colPetName").
                Value.ToString()

            Dim result As DialogResult =
                MessageBox.Show(
                    "Are you sure you want to delete:" &
                    Environment.NewLine &
                    Environment.NewLine &
                    petName &
                    " (" & petID & ")?",
                    "Delete Pet",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                )
            If result = DialogResult.Yes Then
                DeletePet(petID)
            End If
        End If
    End Sub

    ' DELETE PET FROM DATABASE
    Private Sub DeletePet(petID As String)
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim sql As String =
                    "DELETE FROM Pets " &
                    "WHERE PetID = @PetID"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue(
                        "@PetID",
                        petID
                    )

                    Dim result As Integer =
                        cmd.ExecuteNonQuery()
                    If result > 0 Then
                        MessageBox.Show(
                            "Pet deleted successfully.",
                            "Delete Pet",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        )
                        LoadPetData()

                    Else
                        MessageBox.Show(
                            "Pet was not found.",
                            "Delete Pet",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        )
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(
                "Unable to delete pet." &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "Database Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        End Try
    End Sub
End Class