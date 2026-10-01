Imports MySql.Data.MySqlClient

Public Class frmMembership

    ' DATABASE CONNECTION
    Private connectionString As String = "Server=localhost;Database=pet_care_and_services_management_system;Uid=root;Pwd=;"

    ' FORM LOAD
    Private Sub frmMembership_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMembershipData()
        LoadMembershipType()
        LoadMembershipStatus()
    End Sub

    ' LOAD MEMBERSHIP DATA FROM DATABASE
    Private Sub LoadMembershipData()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT MembershipID, CustomerID, MembershipType, StartDate, EndDate, Status FROM Membership ORDER BY MembershipID DESC"

                Using command As New MySqlCommand(query, connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        dgvMembership.Rows.Clear()

                        While reader.Read()
                            dgvMembership.Rows.Add(
                                reader("MembershipID").ToString(),
                                reader("CustomerID").ToString(),
                                reader("MembershipType").ToString(),
                                Convert.ToDateTime(reader("StartDate")).ToString("dd/MM/yyyy"),
                                Convert.ToDateTime(reader("EndDate")).ToString("dd/MM/yyyy"),
                                reader("Status").ToString(),
                                "[Edit]",
                                "[Delete]"
                            )
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading membership data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' LOAD MEMBERSHIP TYPE
    Private Sub LoadMembershipType()
        cboType.Items.Clear()
        cboType.Items.Add("All")
        cboType.Items.Add("Basic")
        cboType.Items.Add("Premium")
        cboType.Items.Add("VIP")
        cboType.SelectedIndex = 0
    End Sub

    ' LOAD MEMBERSHIP STATUS
    Private Sub LoadMembershipStatus()
        cboStatus.Items.Clear()
        cboStatus.Items.Add("All")
        cboStatus.Items.Add("Active")
        cboStatus.Items.Add("Expired")
        cboStatus.Items.Add("Pending")
        cboStatus.SelectedIndex = 0
    End Sub

    ' GO BACK TO DASHBOARD
    Private Sub btnGoBackDashboard_Click(sender As Object, e As EventArgs) Handles btnGoBackDashboard.Click
        frmEmployeeDashboard.Show()
        Me.Close()
    End Sub

    ' REFRESH
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtSearch.Clear()
        cboType.SelectedIndex = 0
        cboStatus.SelectedIndex = 0
        LoadMembershipData()
    End Sub

    ' SEARCH MEMBERSHIP
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text = "Search booking..." Then
            Exit Sub
        End If

        SearchMembership()
    End Sub

    ' SEARCH MEMBERSHIP DATA
    Private Sub SearchMembership()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT MembershipID, CustomerID, MembershipType, StartDate, EndDate, Status FROM Membership WHERE MembershipID LIKE @Search OR CustomerID LIKE @Search OR MembershipType LIKE @Search OR Status LIKE @Search ORDER BY MembershipID DESC"

                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Search", "%" & txtSearch.Text.Trim() & "%")

                    Using reader As MySqlDataReader = command.ExecuteReader()
                        dgvMembership.Rows.Clear()

                        While reader.Read()
                            dgvMembership.Rows.Add(
                                reader("MembershipID").ToString(),
                                reader("CustomerID").ToString(),
                                reader("MembershipType").ToString(),
                                Convert.ToDateTime(reader("StartDate")).ToString("dd/MM/yyyy"),
                                Convert.ToDateTime(reader("EndDate")).ToString("dd/MM/yyyy"),
                                reader("Status").ToString(),
                                "[Edit]",
                                "[Delete]"
                            )
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error searching membership: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' MEMBERSHIP TYPE FILTER
    Private Sub cboType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboType.SelectedIndexChanged
        FilterMembership()
    End Sub

    ' MEMBERSHIP STATUS FILTER
    Private Sub cboStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStatus.SelectedIndexChanged
        FilterMembership()
    End Sub

    ' FILTER MEMBERSHIP
    Private Sub FilterMembership()
        If cboType.SelectedIndex = -1 OrElse cboStatus.SelectedIndex = -1 Then
            Exit Sub
        End If

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT MembershipID, CustomerID, MembershipType, StartDate, EndDate, Status FROM Membership WHERE (@Type = 'All' OR MembershipType = @Type) AND (@Status = 'All' OR Status = @Status) ORDER BY MembershipID DESC"

                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Type", cboType.Text)
                    command.Parameters.AddWithValue("@Status", cboStatus.Text)

                    Using reader As MySqlDataReader = command.ExecuteReader()
                        dgvMembership.Rows.Clear()

                        While reader.Read()
                            dgvMembership.Rows.Add(
                                reader("MembershipID").ToString(),
                                reader("CustomerID").ToString(),
                                reader("MembershipType").ToString(),
                                Convert.ToDateTime(reader("StartDate")).ToString("dd/MM/yyyy"),
                                Convert.ToDateTime(reader("EndDate")).ToString("dd/MM/yyyy"),
                                reader("Status").ToString(),
                                "[Edit]",
                                "[Delete]"
                            )
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error filtering membership: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' EDIT / DELETE BUTTON
    Private Sub dgvMembership_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMembership.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        If e.ColumnIndex = colEdit.Index Then
            Dim membershipID As String = dgvMembership.Rows(e.RowIndex).Cells(colMembershipID.Index).Value.ToString()

            Dim editForm As New frmEditMembership(membershipID)
            editForm.ShowDialog()

            LoadMembershipData()

        ElseIf e.ColumnIndex = colDelete.Index Then
            Dim membershipID As String = dgvMembership.Rows(e.RowIndex).Cells(colMembershipID.Index).Value.ToString()

            DeleteMembership(membershipID)
        End If
    End Sub

    ' DELETE MEMBERSHIP FROM DATABASE
    Private Sub DeleteMembership(ByVal membershipID As String)
        If MessageBox.Show("Are you sure you want to delete this membership?", "Delete Membership", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                Using connection As New MySqlConnection(connectionString)
                    connection.Open()

                    Dim query As String = "DELETE FROM Membership WHERE MembershipID = @MembershipID"

                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@MembershipID", membershipID)
                        command.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show("Membership deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                LoadMembershipData()

            Catch ex As Exception
                MessageBox.Show("Error deleting membership: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

End Class