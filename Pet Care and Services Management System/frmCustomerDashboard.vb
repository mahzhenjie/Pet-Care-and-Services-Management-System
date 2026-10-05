Imports System.Runtime.Intrinsics
Imports MySql.Data.MySqlClient

Public Class frmCustomerDashboard

    ' DATABASE CONNECTION
    Private connectionString As String = "Server=localhost;Database=pet_care_and_services_management_system;Uid=root;Pwd=;"

    Private sidebarCollapsed As Boolean = False

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
        If MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            CurrentUserID = 0
            CurrentUserName = ""
            CurrentUserRole = ""

            Me.Close()
            frmLogin.Show()
        End If
    End Sub

    ' DASHBOARD
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        MessageBox.Show("You are already on the Customer Dashboard.", "Dashboard", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' COLLAPSE / EXPAND SIDEBAR
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click

        If sidebarCollapsed = False Then

            ' COLLAPSE SIDEBAR
            pnlSidebar.Width = 70

            ' HIDE SIDEBAR TEXT
            lblSidebarTitle.Visible = False
            lblSidebarSubtitle.Visible = False
            picLogo.Visible = False
            lblManagement.Visible = False
            lblServices.Visible = False
            lblShopAndMembership.Visible = False

            ' DASHBOARD
            btnDashboard.Location = New Point(8, 141)
            btnDashboard.Size = New Size(54, 45)
            btnDashboard.Text = "⌂"

            ' PROFILE
            btnProfile.Location = New Point(8, 217)
            btnProfile.Size = New Size(54, 40)
            btnProfile.Text = ""

            ' PETS
            btnPet.Location = New Point(8, 263)
            btnPet.Size = New Size(54, 40)
            btnPet.Text = ""

            ' APPOINTMENTS
            btnAppointments.Location = New Point(8, 309)
            btnAppointments.Size = New Size(54, 40)
            btnAppointments.Text = ""

            ' ORDERS
            btnOrders.Location = New Point(8, 355)
            btnOrders.Size = New Size(54, 40)
            btnOrders.Text = ""

            ' PAYMENTS
            btnPayments.Location = New Point(8, 401)
            btnPayments.Size = New Size(54, 40)
            btnPayments.Text = ""

            ' GROOMING SERVICES
            btnGroomingServices.Location = New Point(8, 475)
            btnGroomingServices.Size = New Size(54, 40)
            btnGroomingServices.Text = ""

            ' BOARDING VIDEOS
            btnBoardingVideos.Location = New Point(8, 642)
            btnBoardingVideos.Size = New Size(54, 40)
            btnBoardingVideos.Text = ""

            ' PRODUCTS
            btnProduct.Location = New Point(8, 720)
            btnProduct.Size = New Size(54, 40)
            btnProduct.Text = ""

            ' MEMBERSHIP
            btnMembership.Location = New Point(8, 766)
            btnMembership.Size = New Size(54, 40)
            btnMembership.Text = ""

            ' LOGOUT
            btnLogout.Location = New Point(8, 848)
            btnLogout.Size = New Size(54, 41)
            btnLogout.Text = "↪"

            ' SIDEBAR ICONS
            PictureBox1.Visible = True
            PictureBox2.Visible = True
            PictureBox3.Visible = True
            PictureBox4.Visible = True
            PictureBox5.Visible = True
            PictureBox7.Visible = True
            PictureBox8.Visible = True
            PictureBox9.Visible = True
            PictureBox10.Visible = True
            PictureBox11.Visible = True

            ' MOVE MAIN CONTENT
            pnlWelcome.Location = New Point(98, 132)
            pnlWelcome.Width = 1265

            pnlSummaryCards.Location = New Point(82, 308)
            pnlSummaryCards.Width = 1282

            pnlRecentAppointments.Location = New Point(99, 495)
            pnlRecentAppointments.Width = 958

            sidebarCollapsed = True

        Else

            ' EXPAND SIDEBAR
            pnlSidebar.Width = 280

            ' SHOW SIDEBAR TEXT
            lblSidebarTitle.Visible = True
            lblSidebarSubtitle.Visible = True
            picLogo.Visible = True
            lblManagement.Visible = True
            lblServices.Visible = True
            lblShopAndMembership.Visible = True

            ' DASHBOARD
            btnDashboard.Location = New Point(11, 141)
            btnDashboard.Size = New Size(220, 45)
            btnDashboard.Text = "Dashboard"

            ' PROFILE
            btnProfile.Location = New Point(57, 217)
            btnProfile.Size = New Size(210, 40)
            btnProfile.Text = "Profile"

            ' PETS
            btnPet.Location = New Point(57, 263)
            btnPet.Size = New Size(210, 40)
            btnPet.Text = "Pets"

            ' APPOINTMENTS
            btnAppointments.Location = New Point(57, 309)
            btnAppointments.Size = New Size(210, 40)
            btnAppointments.Text = "Appointments"

            ' ORDERS
            btnOrders.Location = New Point(57, 355)
            btnOrders.Size = New Size(210, 40)
            btnOrders.Text = "Orders"

            ' PAYMENTS
            btnPayments.Location = New Point(57, 401)
            btnPayments.Size = New Size(210, 40)
            btnPayments.Text = "Payments"

            ' GROOMING SERVICES
            btnGroomingServices.Location = New Point(57, 475)
            btnGroomingServices.Size = New Size(210, 40)
            btnGroomingServices.Text = "Grooming Services"

            ' BOARDING VIDEOS
            btnBoardingVideos.Location = New Point(57, 642)
            btnBoardingVideos.Size = New Size(210, 40)
            btnBoardingVideos.Text = "Boarding Videos"

            ' PRODUCTS
            btnProduct.Location = New Point(57, 720)
            btnProduct.Size = New Size(210, 40)
            btnProduct.Text = "Products"

            ' MEMBERSHIP
            btnMembership.Location = New Point(57, 766)
            btnMembership.Size = New Size(210, 40)
            btnMembership.Text = "Membership"

            ' LOGOUT
            btnLogout.Location = New Point(19, 848)
            btnLogout.Size = New Size(212, 41)
            btnLogout.Text = "Logout"

            ' MOVE MAIN CONTENT BACK
            pnlWelcome.Location = New Point(308, 132)
            pnlWelcome.Width = 1055

            pnlSummaryCards.Location = New Point(292, 308)
            pnlSummaryCards.Width = 1072

            pnlRecentAppointments.Location = New Point(309, 495)
            pnlRecentAppointments.Width = 748

            sidebarCollapsed = False
        End If
    End Sub

    ' MENU - LOGOUT
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        btnLogout.PerformClick()
    End Sub

    ' MENU - EXIT
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    ' MENU - MY PROFILE
    Private Sub MyProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MyProfileToolStripMenuItem.Click
        btnProfile.PerformClick()
    End Sub

    ' MENU - MY PETS
    Private Sub MyPetsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MyPetsToolStripMenuItem1.Click
        btnPet.PerformClick()
    End Sub

    ' MENU - MY APPOINTMENTS
    Private Sub MyAppointmentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MyAppointmentsToolStripMenuItem.Click
        btnAppointments.PerformClick()
    End Sub

    ' MENU - MY ORDERS
    Private Sub MyOrdersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MyOrdersToolStripMenuItem.Click
        btnOrders.PerformClick()
    End Sub

    ' MENU - MY PAYMENTS
    Private Sub MyPaymentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MyPaymentsToolStripMenuItem.Click
        btnPayments.PerformClick()
    End Sub

    ' MENU - GROOMING SERVICES
    Private Sub GroomingServicesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GroomingServicesToolStripMenuItem.Click
        btnGroomingServices.PerformClick()
    End Sub

    ' MENU - DASHBOARD
    Private Sub DashboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DashboardToolStripMenuItem.Click
        btnDashboard.PerformClick()
    End Sub

    ' MENU - REFRESH
    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        RefreshDashboard()
    End Sub

    ' MENU - ABOUT
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Using aboutForm As New frmAbout()
            aboutForm.ShowDialog()
        End Using
    End Sub

    ' MENU - USER GUIDE
    Private Sub UserGuideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserGuideToolStripMenuItem.Click
        Using userGuideForm As New frmUserGuide()
            userGuideForm.ShowDialog()
        End Using
    End Sub

End Class