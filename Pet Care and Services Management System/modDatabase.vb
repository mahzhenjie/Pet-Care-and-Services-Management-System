Imports MySql.Data.MySqlClient

' ============================================================
' modDatabase.vb
' 共用的資料庫連線模組
' 請依照你自己的 MySQL / phpMyAdmin (XAMPP) 設定修改下面的常數
' 記得在專案中透過 NuGet 安裝 "MySql.Data" 套件
' ============================================================
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

    ' 登入成功後，記錄目前使用者的資訊，方便其他表單使用
    Public CurrentUserID As Integer
    Public CurrentUserName As String
    Public CurrentUserRole As String  ' "Customer" 或 "Employee"

End Module
