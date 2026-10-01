Imports MySql.Data.MySqlClient

Public Class frmCustomerMembership

    ' DATABASE CONNECTION
    Private connectionString As String = "Server=localhost;Database=pet_care_and_services_management_system;Uid=root;Pwd=;"

    ' FORM LOAD
    Private Sub frmCustomerMembership_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCustomerID.Text = CurrentUserID.ToString()
        lblCustomerName.Text = CurrentUserName
        dtpStartDate.Value = Date.Today
        dtpEndDate.Value = Date.Today.AddYears(1)
        txtStatus.Text = "Active"

        If cboMembershipType.Items.Count > 0 Then
            cboMembershipType.SelectedIndex = 0
        End If
    End Sub

    ' MEMBERSHIP TYPE CHANGED
    Private Sub cboMembershipType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMembershipType.SelectedIndexChanged
        If cboMembershipType.SelectedIndex >= 0 Then
            dtpEndDate.Value = dtpStartDate.Value.AddYears(1)
        End If
    End Sub

    ' START DATE CHANGED
    Private Sub dtpStartDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpStartDate.ValueChanged
        dtpEndDate.Value = dtpStartDate.Value.AddYears(1)
    End Sub

    ' REGISTER MEMBERSHIP
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If CurrentUserID <= 0 Then
            MessageBox.Show("Customer information could not be found. Please login again.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If cboMembershipType.SelectedIndex < 0 Then
            MessageBox.Show("Please select a membership type.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If dtpEndDate.Value.Date <= dtpStartDate.Value.Date Then
            MessageBox.Show("End date must be later than start date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If CheckExistingMembership() Then
            MessageBox.Show("You already have an active membership.", "Membership Registration", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If MessageBox.Show(
            "Are you sure you want to register for the " & cboMembershipType.Text & " membership?",
            "Confirm Membership",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        ) <> DialogResult.Yes Then
            Return
        End If

        RegisterMembership()
    End Sub

    ' CHECK EXISTING MEMBERSHIP
    Private Function CheckExistingMembership() As Boolean
        Try
            Dim conn As New MySqlConnection(connectionString)
            conn.Open()

            Dim sql As String = "SELECT COUNT(*) FROM membership WHERE CustomerID = @CustomerID AND Status = 'Active'"
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@CustomerID", CurrentUserID)

            If Convert.ToInt32(cmd.ExecuteScalar()) > 0 Then
                conn.Close()
                Return True
            End If

            conn.Close()
            Return False
        Catch ex As Exception
            MessageBox.Show("Unable to check membership." & Environment.NewLine & Environment.NewLine & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End Try
    End Function

    ' INSERT MEMBERSHIP INTO DATABASE
    Private Sub RegisterMembership()
        Try
            Dim conn As New MySqlConnection(connectionString)
            conn.Open()

            Dim sql As String = "INSERT INTO membership (CustomerID, MembershipType, StartDate, EndDate, Status) VALUES (@CustomerID, @MembershipType, @StartDate, @EndDate, @Status)"
            Dim cmd As New MySqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@CustomerID", CurrentUserID)
            cmd.Parameters.AddWithValue("@MembershipType", cboMembershipType.Text)
            cmd.Parameters.AddWithValue("@StartDate", dtpStartDate.Value.Date)
            cmd.Parameters.AddWithValue("@EndDate", dtpEndDate.Value.Date)
            cmd.Parameters.AddWithValue("@Status", "Active")

            If cmd.ExecuteNonQuery() > 0 Then
                conn.Close()

                MessageBox.Show(
                    "Membership registered successfully." & Environment.NewLine & Environment.NewLine &
                    "Membership Type: " & cboMembershipType.Text & Environment.NewLine &
                    "Start Date: " & dtpStartDate.Value.ToString("dd/MM/yyyy") & Environment.NewLine &
                    "End Date: " & dtpEndDate.Value.ToString("dd/MM/yyyy"),
                    "Registration Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )

                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                conn.Close()

                MessageBox.Show("Membership registration failed.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As MySqlException
            MessageBox.Show(
                "Unable to register membership." & Environment.NewLine & Environment.NewLine & ex.Message,
                "Database Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        Catch ex As Exception
            MessageBox.Show(
                "An unexpected error occurred." & Environment.NewLine & Environment.NewLine & ex.Message,
                "Registration Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        End Try
    End Sub

    ' CANCEL
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class