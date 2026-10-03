Imports System.Runtime.Intrinsics
Imports MySql.Data.MySqlClient

Public Class frmCustomerDashboard

    ' DATABASE CONNECTION
    Private connectionString As String = "Server=localhost;Database=pet_care_and_services_management_system;Uid=root;Pwd=;"

    ' FORM LOAD
    Private Sub frmCustomerDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCustomer.Text = CurrentUserName
        LoadDashboardData()
        LoadRecentAppointments()
    End Sub

    ' LOAD DASHBOARD DATA
    Private Sub LoadDashboardData()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                ' LOAD TOTAL PETS
                Dim petSql As String = "SELECT COUNT(*) FROM Pets WHERE CustomerID = @CustomerID"

                Using petCmd As New MySqlCommand(petSql, conn)
                    petCmd.Parameters.AddWithValue("@CustomerID", CurrentUserID)
                    lblPetCount.Text = Convert.ToInt32(petCmd.ExecuteScalar()).ToString()
                End Using

                ' LOAD TODAY'S APPOINTMENTS
                Dim appointmentSql As String = "SELECT COUNT(*) FROM (SELECT gb.GroomingBookingID FROM GroomingBookings gb INNER JOIN Pets p ON gb.PetID = p.PetID WHERE p.CustomerID = @CustomerID1 AND gb.BookingDate = CURDATE() UNION ALL SELECT bb.BoardingBookingID FROM BoardingBookings bb INNER JOIN Pets p ON bb.PetID = p.PetID WHERE p.CustomerID = @CustomerID2 AND CURDATE() BETWEEN bb.StartDate AND bb.EndDate) AS Appointments"

                Using appointmentCmd As New MySqlCommand(appointmentSql, conn)
                    appointmentCmd.Parameters.AddWithValue("@CustomerID1", CurrentUserID)
                    appointmentCmd.Parameters.AddWithValue("@CustomerID2", CurrentUserID)
                    lblAppointmentCount.Text = Convert.ToInt32(appointmentCmd.ExecuteScalar()).ToString()
                End Using

                ' LOAD PENDING ORDERS
                Dim orderSql As String = "SELECT COUNT(*) FROM Orders WHERE CustomerID = @CustomerID AND OrderStatus = 'Pending'"

                Using orderCmd As New MySqlCommand(orderSql, conn)
                    orderCmd.Parameters.AddWithValue("@CustomerID", CurrentUserID)
                    lblOrderCount.Text = Convert.ToInt32(orderCmd.ExecuteScalar()).ToString()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Unable to load dashboard data." & Environment.NewLine & Environment.NewLine & ex.Message, "Dashboard Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' LOAD RECENT APPOINTMENTS
    Private Sub LoadRecentAppointments()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim sql As String = "SELECT * FROM (SELECT gb.BookingDate AS AppointmentDate, gb.BookingTime AS AppointmentTime, p.PetName AS PetName, gs.ServiceName AS ServiceName, gb.Status AS Status FROM GroomingBookings gb INNER JOIN Pets p ON gb.PetID = p.PetID INNER JOIN GroomingServices gs ON gb.ServiceID = gs.ServiceID WHERE p.CustomerID = @CustomerID1 UNION ALL SELECT bb.StartDate AS AppointmentDate, NULL AS AppointmentTime, p.PetName AS PetName, CONCAT('Boarding - ', br.RoomType) AS ServiceName, bb.Status AS Status FROM BoardingBookings bb INNER JOIN Pets p ON bb.PetID = p.PetID INNER JOIN BoardingRooms br ON bb.RoomID = br.RoomID WHERE p.CustomerID = @CustomerID2) AS RecentAppointments ORDER BY AppointmentDate DESC LIMIT 10"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@CustomerID1", CurrentUserID)
                    cmd.Parameters.AddWithValue("@CustomerID2", CurrentUserID)

                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim table As New DataTable()
                        adapter.Fill(table)
                        dgvRecentAppointments.DataSource = table
                    End Using
                End Using
            End Using

            dgvRecentAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvRecentAppointments.ReadOnly = True
            dgvRecentAppointments.AllowUserToAddRows = False
            dgvRecentAppointments.AllowUserToDeleteRows = False
            dgvRecentAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvRecentAppointments.RowHeadersVisible = False
        Catch ex As Exception
            MessageBox.Show("Unable to load recent appointments." & Environment.NewLine & Environment.NewLine & ex.Message, "Appointment Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' REFRESH DASHBOARD
    Private Sub RefreshDashboard()
        LoadDashboardData()
        LoadRecentAppointments()
    End Sub

    ' PROFILE
    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        Dim frm As New FrmMyProfile()
        frm.ShowDialog()
    End Sub

    ' PET
    Private Sub btnPet_Click(sender As Object, e As EventArgs) Handles btnPet.Click
        Dim frm As New FrmMyPets()
        frm.ShowDialog()

    End Sub

    ' APPOINTMENTS
    Private Sub btnAppointments_Click(sender As Object, e As EventArgs) Handles btnAppointments.Click
        Dim frm As New FrmAppointments()
        frm.ShowDialog()
    End Sub

    ' ORDERS
    Private Sub btnOrders_Click(sender As Object, e As EventArgs) Handles btnOrders.Click
        Dim frm As New FrmMyOrders()
        frm.ShowDialog()
    End Sub

    ' GROOMING SERVICES
    Private Sub btnGroomingServices_Click(sender As Object, e As EventArgs) Handles btnGroomingServices.Click
        Dim frm As New FrmGroomingService()
        frm.ShowDialog()
    End Sub

    ' BOARDING SERVICES
    Private Sub btnBoardingServices_Click(sender As Object, e As EventArgs) Handles btnBoardingServices.Click
        Dim frm As New FrmBoardingService()
        frm.ShowDialog()
    End Sub

    ' PAYMENTS
    Private Sub btnPayments_Click(sender As Object, e As EventArgs) Handles btnPayments.Click
        Dim frm As New FrmMyPayment()
        frm.ShowDialog()
    End Sub

    ' BOARDING VIDEOS
    Private Sub btnBoardingVideos_Click(sender As Object, e As EventArgs) Handles btnBoardingVideos.Click
        Dim frm As New FrmBoardingVideos()
        frm.ShowDialog()
    End Sub

    ' PRODUCT
    Private Sub btnProduct_Click(sender As Object, e As EventArgs) Handles btnProduct.Click
        Try
            Dim productForm As New frmCustomerProduct()
            productForm.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("Unable to open Products." & Environment.NewLine & Environment.NewLine & ex.Message, "Navigation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' MEMBERSHIP
    Private Sub btnMembership_Click(sender As Object, e As EventArgs) Handles btnMembership.Click
        Try
            Using membershipForm As New frmCustomerMembership()
                membershipForm.ShowDialog()
            End Using

            LoadDashboardData()
        Catch ex As Exception
            MessageBox.Show("Unable to open Membership." & Environment.NewLine & Environment.NewLine & ex.Message, "Navigation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' QUICK ACTION - NEW APPOINTMENT
    Private Sub btnNewAppointmnet_Click(sender As Object, e As EventArgs) Handles btnNewAppointmnet.Click
        Try
            Using appointmentForm As New FrmBookingGroomingService()
                appointmentForm.ShowDialog()
            End Using

            LoadDashboardData()
            LoadRecentAppointments()
        Catch ex As Exception
            MessageBox.Show("Unable to open New Appointment." & Environment.NewLine & Environment.NewLine & ex.Message, "Navigation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' QUICK ACTION - ADD CUSTOMER
    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Add Customer button is working.", "Testing", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' QUICK ACTION - ADD PET
    Private Sub btnAddPet_Click(sender As Object, e As EventArgs) Handles btnAddPet.Click
        Try
            Using petForm As New frmAddPet()
                petForm.ShowDialog()
            End Using

            LoadDashboardData()
        Catch ex As Exception
            MessageBox.Show("Unable to open Add Pet." & Environment.NewLine & Environment.NewLine & ex.Message, "Navigation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' QUICK ACTION - ADD SERVICE
    Private Sub btnAddService_Click(sender As Object, e As EventArgs) Handles btnAddService.Click
        MessageBox.Show("Add Service button is working.", "Testing", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' LOGOUT
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult
        result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            CurrentUserID = 0
            CurrentUserName = ""
            CurrentUserRole = ""

            Dim loginForm As New frmLogin()
            Me.Close()
            loginForm.Show()

        End If
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        MessageBox.Show("You are already on the Customer Dashboard.",
                    "Dashboard",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information)
    End Sub
End Class