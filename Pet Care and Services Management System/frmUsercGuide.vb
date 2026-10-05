Public Class frmUserGuide

    ' FORM LOAD
    Private Sub frmUserGuide_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        rtbGuide.Text = "USER GUIDE" & vbCrLf & vbCrLf &
                        "Welcome to the Smart Staff Training Management System." & vbCrLf &
                        "This guide provides a simple overview of the system menu and its functions." & vbCrLf & vbCrLf &
                        "1. FILE" & vbCrLf &
                        "• Logout - Log out from the current employee account." & vbCrLf &
                        "• Exit - Close the application." & vbCrLf & vbCrLf &
                        "2. MANAGEMENT" & vbCrLf &
                        "• Customers - Manage customer information." & vbCrLf &
                        "• Pets - Manage pet information." & vbCrLf &
                        "• Bookings - Manage grooming and boarding bookings." & vbCrLf &
                        "• Orders - Manage customer orders." & vbCrLf &
                        "• Payments - View and manage payment records." & vbCrLf & vbCrLf &
                        "3. SERVICES" & vbCrLf &
                        "• Grooming Services - Manage available grooming services." & vbCrLf & vbCrLf &
                        "4. VIEW" & vbCrLf &
                        "• Dashboard - Return to the employee dashboard." & vbCrLf &
                        "• Refresh - Refresh the dashboard information." & vbCrLf & vbCrLf &
                        "5. HELP" & vbCrLf &
                        "• About - View information about the system." & vbCrLf &
                        "• User Guide - Open this user guide." & vbCrLf & vbCrLf &
                        "GENERAL INSTRUCTIONS" & vbCrLf &
                        "Use the menu bar at the top of the dashboard to access different functions." & vbCrLf &
                        "Use the Back to Dashboard button to return to the employee dashboard." & vbCrLf &
                        "Use Refresh when you want to display the latest available information."

    End Sub


    ' GO BACK TO DASHBOARD
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        frmEmployeeDashboard.Show()
        Me.Hide()

    End Sub

End Class