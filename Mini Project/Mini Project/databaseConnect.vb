Imports System.Data.OleDb
Module databaseConnect
    Public cn As New OleDb.OleDbConnection
    Public cmd As New OleDbCommand
    Public da As New OleDbDataAdapter
    Public ds As New DataSet
    Public ds1 As New DataSet
    Public ds2 As New DataSet
    Public str As String
    Public IsUserLoggedIn As Boolean = False

    Public Sub conn()
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\accounts.accdb;"
    End Sub

End Module
