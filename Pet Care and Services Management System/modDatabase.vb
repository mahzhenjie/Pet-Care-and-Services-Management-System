Imports MySql.Data.MySqlClient

Module modDatabase

    Public Const DB_SERVER As String = "127.0.0.1"
    Public Const DB_NAME As String = "pet_care_and_services_management_system"
    Public Const DB_USER As String = "root"
    Public Const DB_PASSWORD As String = ""

    Public Function GetConnection() As MySqlConnection
        Dim connStr As String =
            $"Server={DB_SERVER};Database={DB_NAME};Uid={DB_USER};Pwd={DB_PASSWORD};"
        Return New MySqlConnection(connStr)
    End Function

    Public CurrentUserID As Integer
    Public CurrentUserName As String
    Public CurrentUserRole As String  ' "Customer" 或 "Employee"

End Module
