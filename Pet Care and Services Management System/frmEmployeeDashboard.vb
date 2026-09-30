Imports MySql.Data.MySqlClient

Public Class frmEmployeeDashboard
    Private Sub frmEmployeeDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDashboardData()
        LoadRecentAppointments()
    End Sub

    Private Sub LoadDashboardData()
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                ' Customers
                Using cmd As New MySqlCommand(
                    "SELECT COUNT(*) FROM customers", conn)
                    lblCustomerCount.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString()
                End Using

                ' Pets
                Using cmd As New MySqlCommand(
                    "SELECT COUNT(*) FROM pets", conn)
                    lblPetCount.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString()
                End Using

                ' Appointments
                ' Grooming + Boarding
                Using cmd As New MySqlCommand(
                    "SELECT " &
                    "(SELECT COUNT(*) FROM groomingbookings) + " &
                    "(SELECT COUNT(*) FROM boardingbookings)", conn)
                    lblAppointmentCount.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString()
                End Using

                ' Orders
                Using cmd As New MySqlCommand(
                    "SELECT COUNT(*) FROM orders", conn)
                    lblOrderCount.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString()
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show(
                "Unable to load dashboard data." &
                vbCrLf & ex.Message,
                "Dashboard Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)
        End Try
    End Sub

    ' Recent Appointments
    Private Sub LoadRecentAppointments()
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim sql As String =
                    "SELECT * FROM (" &
                    "SELECT " &
                "c.FullName AS Customer, " &
                "p.PetName AS Pet, " &
                "'Grooming' AS Service, " &
                "CONCAT(DATE_FORMAT(g.BookingDate, '%d/%m/%Y'), ' ', " &
                "TIME_FORMAT(g.BookingTime, '%h:%i %p')) AS DateTime, " &
                "g.Status AS Status " &
                "FROM groomingbookings g " &
                "INNER JOIN pets p ON g.PetID = p.PetID " &
                "INNER JOIN customers c ON p.CustomerID = c.CustomerID " &
                "UNION ALL " &
                "SELECT " &
                "c.FullName AS Customer, " &
                "p.PetName AS Pet, " &
                "'Boarding' AS Service, " &
                "DATE_FORMAT(b.StartDate, '%d/%m/%Y') AS DateTime, " &
                "b.Status AS Status " &
                "FROM boardingbookings b " &
                "INNER JOIN pets p ON b.PetID = p.PetID " &
                "INNER JOIN customers c ON p.CustomerID = c.CustomerID " &
                ") AS RecentBookings " &
                "ORDER BY DateTime DESC " &
                "LIMIT 5"
                Using cmd As New MySqlCommand(sql, conn)
                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        adapter.Fill(dt)
                        dgvRecentAppointments.DataSource = dt
                        ' DataGridView UI
                        With dgvRecentAppointments
                            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
                            .RowTemplate.Height = 38

                            ' Automatically fill all columns
                            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                            For Each col As DataGridViewColumn In .Columns
                                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                                col.Resizable = DataGridViewTriState.False
                            Next

                            ' Give DateTime more space
                            If .Columns.Contains("DateTime") Then
                                .Columns("DateTime").FillWeight = 150
                            End If

                            For Each row As DataGridViewRow In .Rows
                                row.Height = 38
                            Next

                            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(139, 58, 27)
                            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)

                            .DefaultCellStyle.Font = New Font("Segoe UI", 10)
                            .DefaultCellStyle.SelectionBackColor = Color.FromArgb(190, 105, 55)
                            .DefaultCellStyle.SelectionForeColor = Color.White

                            .EnableHeadersVisualStyles = False
                        End With
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(
                "Unable to load appointments." &
                vbCrLf & ex.Message,
                "Appointment Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Me.Show()
    End Sub

    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        Dim frm As New frmCustomer()
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub btnPets_Click(sender As Object, e As EventArgs) Handles btnPets.Click
        Dim frm As New frmPet()
        frm.Show()
        Me.Hide()
    End Sub


    Private Sub btnBookings_Click(sender As Object, e As EventArgs) Handles btnBookings.Click
        Dim frm As New frmGroomingBooking()
        frm.Show()
        Me.Hide()
    End Sub


    Private Sub btnOrders_Click(sender As Object, e As EventArgs) Handles btnOrders.Click
        Dim frm As New frmOrder()
        frm.Show()
        Me.Hide()
    End Sub


    Private Sub btnPayments_Click(sender As Object, e As EventArgs) Handles btnPayments.Click
        Dim frm As New frmPayment()
        frm.Show()
        Me.Hide()
    End Sub


    Private Sub btnGroomingServices_Click(sender As Object, e As EventArgs) Handles btnGroomingServices.Click
        Dim frm As New frmGrommingServices()
        frm.Show()
        Me.Hide()
    End Sub


    Private Sub btnBoardingServices_Click(sender As Object, e As EventArgs) Handles btnBoardingServices.Click
        Dim frm As New frmBoardingServices()
        frm.Show()
        Me.Hide()
    End Sub


    Private Sub btnBoardingRooms_Click(sender As Object, e As EventArgs) Handles btnBoardingRooms.Click
        Dim frm As New frmBoardingRoom()
        frm.Show()
        Me.Hide()
    End Sub


    Private Sub btnBoardingVideos_Click(sender As Object, e As EventArgs) Handles btnBoardingVideos.Click
        Dim frm As New frmPetVideos()
        frm.Show()
        Me.Hide()
    End Sub


    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
        Dim frm As New frmProduct()
        frm.Show()
        Me.Hide()
    End Sub


    Private Sub btnMembership_Click(sender As Object, e As EventArgs) Handles btnMembership.Click
        Dim frm As New frmMembership()
        frm.Show()
        Me.Hide()
    End Sub


    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult
        result = MessageBox.Show(
            "Are you sure you want to logout?",
            "Logout",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Using aboutForm As New frmAbout()
            aboutForm.ShowDialog()
        End Using
    End Sub

End Class