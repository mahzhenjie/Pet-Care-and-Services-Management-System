Imports MySql.Data.MySqlClient

Public Class frmEditMembership

    ' DATABASE CONNECTION
    Private connectionString As String = "Server=localhost;Database=pet_care_and_services_management_system;Uid=root;Pwd=;"
    Private membershipID As String

    ' CONSTRUCTOR
    Public Sub New(ByVal id As String)
        InitializeComponent()
        membershipID = id
    End Sub

    ' FORM LOAD
    Private Sub frmEditMembership_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMembershipType()
        LoadMembershipStatus()
        LoadMembershipData()
    End Sub

    ' LOAD MEMBERSHIP TYPE
    Private Sub LoadMembershipType()
        cboMembershipType.Items.Clear()
        cboMembershipType.Items.Add("Basic")
        cboMembershipType.Items.Add("Premium")
        cboMembershipType.Items.Add("VIP")
    End Sub

    ' LOAD MEMBERSHIP STATUS
    Private Sub LoadMembershipStatus()
        cboStatus.Items.Clear()
        cboStatus.Items.Add("Active")
        cboStatus.Items.Add("Expired")
        cboStatus.Items.Add("Pending")
    End Sub

    ' LOAD MEMBERSHIP DATA FROM DATABASE
    Private Sub LoadMembershipData()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT MembershipID, CustomerID, MembershipType, StartDate, EndDate, Status FROM Memberships WHERE MembershipID = @MembershipID"

                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@MembershipID", membershipID)

                    Using reader As MySqlDataReader = command.ExecuteReader()

                        If reader.Read() Then
                            txtMembershipID.Text = reader("MembershipID").ToString()
                            txtCustomerID.Text = reader("CustomerID").ToString()
                            cboMembershipType.Text = reader("MembershipType").ToString()
                            dtpStartDate.Value = Convert.ToDateTime(reader("StartDate"))
                            dtpEndDate.Value = Convert.ToDateTime(reader("EndDate"))
                            cboStatus.Text = reader("Status").ToString()
                        End If

                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading membership data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' SAVE MEMBERSHIP
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtCustomerID.Text.Trim() = "" Then
            MessageBox.Show("Please enter Customer ID.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCustomerID.Focus()
            Exit Sub
        End If

        If cboMembershipType.SelectedIndex = -1 Then
            MessageBox.Show("Please select Membership Type.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cboMembershipType.Focus()
            Exit Sub
        End If

        If cboStatus.SelectedIndex = -1 Then
            MessageBox.Show("Please select Status.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cboStatus.Focus()
            Exit Sub
        End If

        If dtpEndDate.Value.Date < dtpStartDate.Value.Date Then
            MessageBox.Show("End Date cannot be earlier than Start Date.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "UPDATE Memberships SET CustomerID = @CustomerID, MembershipType = @MembershipType, StartDate = @StartDate, EndDate = @EndDate, Status = @Status WHERE MembershipID = @MembershipID"

                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@CustomerID", txtCustomerID.Text.Trim())
                    command.Parameters.AddWithValue("@MembershipType", cboMembershipType.Text)
                    command.Parameters.AddWithValue("@StartDate", dtpStartDate.Value.Date)
                    command.Parameters.AddWithValue("@EndDate", dtpEndDate.Value.Date)
                    command.Parameters.AddWithValue("@Status", cboStatus.Text)
                    command.Parameters.AddWithValue("@MembershipID", membershipID)

                    command.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Membership updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error updating membership: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' CANCEL
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class