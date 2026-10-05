Imports MySql.Data.MySqlClient

Public Class frmEmployeeDashboard

    Private sidebarCollapsed As Boolean = False

    ' FORM LOAD
    Private Sub frmEmployeeDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDashboardData()
        LoadRecentAppointments()
    End Sub

    ' LOAD DASHBOARD DATA
    Private Sub LoadDashboardData()
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                ' Customers
                Using cmd As New MySqlCommand("SELECT COUNT(*) FROM customers", conn)
                    lblCustomerCount.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString()
                End Using

                ' Pets
                Using cmd As New MySqlCommand("SELECT COUNT(*) FROM pets", conn)
                    lblPetCount.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString()
                End Using

                ' Appointments
                ' Grooming + Boarding
                Using cmd As New MySqlCommand("SELECT " & "(SELECT COUNT(*) FROM groomingbookings) + " & "(SELECT COUNT(*) FROM boardingbookings)", conn)
                    lblAppointmentCount.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString()
                End Using

                ' Orders
                Using cmd As New MySqlCommand("SELECT COUNT(*) FROM orders", conn)
                    lblOrderCount.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString()
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Unable to load dashboard data." & vbCrLf & ex.Message, "Dashboard Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' LOAD RECENT APPOINTMENTS
    Private Sub LoadRecentAppointments()
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Dim sql As String = "SELECT * FROM (" &
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
            MessageBox.Show("Unable to load appointments." & vbCrLf & ex.Message, "Appointment Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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
            lblFacility.Visible = False
            lblShopAndMembership.Visible = False

            ' DASHBOARD
            btnDashboard.Location = New Point(8, 141)
            btnDashboard.Size = New Size(54, 45)
            btnDashboard.Text = "⌂"

            ' CUSTOMERS
            btnCustomers.Location = New Point(8, 217)
            btnCustomers.Size = New Size(54, 40)
            btnCustomers.Text = ""

            ' PETS
            btnPets.Location = New Point(8, 263)
            btnPets.Size = New Size(54, 40)
            btnPets.Text = ""

            ' BOOKINGS
            btnBookings.Location = New Point(8, 309)
            btnBookings.Size = New Size(54, 40)
            btnBookings.Text = ""

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

            ' BOARDING ROOMS
            btnBoardingRooms.Location = New Point(8, 596)
            btnBoardingRooms.Size = New Size(54, 40)
            btnBoardingRooms.Text = ""

            ' BOARDING VIDEOS
            btnBoardingVideos.Location = New Point(8, 642)
            btnBoardingVideos.Size = New Size(54, 40)
            btnBoardingVideos.Text = ""

            ' PRODUCTS
            btnProducts.Location = New Point(8, 720)
            btnProducts.Size = New Size(54, 40)
            btnProducts.Text = ""

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
            PictureBox6.Visible = True
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
            lblFacility.Visible = True
            lblShopAndMembership.Visible = True

            ' DASHBOARD
            btnDashboard.Location = New Point(11, 141)
            btnDashboard.Size = New Size(220, 45)
            btnDashboard.Text = "Dashboard"

            ' CUSTOMERS
            btnCustomers.Location = New Point(57, 217)
            btnCustomers.Size = New Size(210, 40)
            btnCustomers.Text = "Customers"

            ' PETS
            btnPets.Location = New Point(57, 263)
            btnPets.Size = New Size(210, 40)
            btnPets.Text = "Pets"

            ' BOOKINGS
            btnBookings.Location = New Point(57, 309)
            btnBookings.Size = New Size(210, 40)
            btnBookings.Text = "Bookings"

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

            ' BOARDING ROOMS
            btnBoardingRooms.Location = New Point(57, 547)
            btnBoardingRooms.Size = New Size(210, 40)
            btnBoardingRooms.Text = "Boarding Rooms"

            ' BOARDING VIDEOS
            btnBoardingVideos.Location = New Point(57, 593)
            btnBoardingVideos.Size = New Size(210, 40)
            btnBoardingVideos.Text = "Boarding Videos"

            ' PRODUCTS
            btnProducts.Location = New Point(57, 671)
            btnProducts.Size = New Size(210, 40)
            btnProducts.Text = "Products"

            ' MEMBERSHIP
            btnMembership.Location = New Point(57, 717)
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

    ' DASHBOARD
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Me.Show()
    End Sub

    ' CUSTOMERS
    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        frmCustomer.Show()
        Me.Hide()
    End Sub

    ' PETS
    Private Sub btnPets_Click(sender As Object, e As EventArgs) Handles btnPets.Click
        frmPet.Show()
        Me.Hide()
    End Sub

    ' BOOKINGS
    Private Sub btnBookings_Click(sender As Object, e As EventArgs) Handles btnBookings.Click
        frmBooking.Show()
        Me.Hide()
    End Sub

    ' ORDERS
    Private Sub btnOrders_Click(sender As Object, e As EventArgs) Handles btnOrders.Click
        frmOrder.Show()
        Me.Hide()
    End Sub

    ' PAYMENTS
    Private Sub btnPayments_Click(sender As Object, e As EventArgs) Handles btnPayments.Click
        frmPayment.Show()
        Me.Hide()
    End Sub

    ' GROOMING SERVICES
    Private Sub btnGroomingServices_Click(sender As Object, e As EventArgs) Handles btnGroomingServices.Click
        frmGrommingServices.Show()
        Me.Hide()
    End Sub

    ' BOARDING ROOMS
    Private Sub btnBoardingRooms_Click(sender As Object, e As EventArgs) Handles btnBoardingRooms.Click
        frmBoardingRoom.Show()
        Me.Hide()
    End Sub

    ' BOARDING VIDEOS
    Private Sub btnBoardingVideos_Click(sender As Object, e As EventArgs) Handles btnBoardingVideos.Click
        frmPetVideos.Show()
        Me.Hide()
    End Sub

    ' PRODUCTS
    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
        frmProduct.Show()
        Me.Hide()
    End Sub

    ' MEMBERSHIP
    Private Sub btnMembership_Click(sender As Object, e As EventArgs) Handles btnMembership.Click
        frmMembership.Show()
        Me.Hide()
    End Sub

    ' LOGOUT
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            frmLogin.Show()
            Me.Hide()
        End If
    End Sub

    ' FILE - LOGOUT
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            frmLogin.Show()
            Me.Hide()
        End If
    End Sub

    ' FILE - EXIT
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to exit the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    ' MANAGEMENT - CUSTOMERS
    Private Sub CustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomersToolStripMenuItem.Click
        frmCustomer.Show()
        Me.Hide()
    End Sub

    ' MANAGEMENT - PETS
    Private Sub PetsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PetsToolStripMenuItem.Click
        frmPet.Show()
        Me.Hide()
    End Sub

    ' MANAGEMENT - BOOKINGS
    Private Sub BookingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookingsToolStripMenuItem.Click
        frmBooking.Show()
        Me.Hide()
    End Sub

    ' MANAGEMENT - ORDERS
    Private Sub OrdersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdersToolStripMenuItem.Click
        frmOrder.Show()
        Me.Hide()
    End Sub

    ' MANAGEMENT - PAYMENTS
    Private Sub PaymentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaymentsToolStripMenuItem.Click
        frmPayment.Show()
        Me.Hide()
    End Sub

    ' SERVICES - GROOMING SERVICES
    Private Sub GroomingServicesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GroomingServicesToolStripMenuItem.Click
        frmGrommingServices.Show()
        Me.Hide()
    End Sub

    ' VIEW - DASHBOARD
    Private Sub DashboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DashboardToolStripMenuItem.Click
        Me.Show()
        LoadDashboardData()
        LoadRecentAppointments()
    End Sub

    ' VIEW - REFRESH
    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadDashboardData()
        LoadRecentAppointments()
    End Sub

    ' ABOUT
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Using aboutForm As New frmAbout()
            aboutForm.ShowDialog()
        End Using
    End Sub

    ' USER GUIDE
    Private Sub UserGuideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserGuideToolStripMenuItem.Click
        frmUserGuide.Show()
        Me.Hide()
    End Sub

    ' QUICK ACTION - NEW APPOINTMENT
    Private Sub btnNewAppointmnet_Click(sender As Object, e As EventArgs) Handles btnNewAppointmnet.Click
        frmBooking.Show()
        Me.Hide()
    End Sub

    ' QUICK ACTION - ADD CUSTOMER
    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        frmCustomer.Show()
        Me.Hide()
    End Sub

    ' QUICK ACTION - ADD PET
    Private Sub btnAddPet_Click(sender As Object, e As EventArgs) Handles btnAddPet.Click
        frmPet.Show()
        Me.Hide()
    End Sub

    ' QUICK ACTION - ADD SERVICE
    Private Sub btnAddService_Click(sender As Object, e As EventArgs) Handles btnAddService.Click
        frmGrommingServices.Show()
        Me.Hide()
    End Sub
End Class