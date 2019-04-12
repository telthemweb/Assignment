Imports System.Data.OleDb

Public Class Login
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\accounts.accdb")
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM users WHERE [username] = '" & txtUser.Text & "' AND [password] = '" & txtPass.Text & "'  ", con)

        con.Open()
        Dim sdr As OleDbDataReader = cmd.ExecuteReader()
        If (sdr.Read() = True) Then
            MsgBox("You logged in successfully!", MsgBoxStyle.Information)
            HomePage.Show()
            Me.Hide()

            IsUserLoggedIn = True
        Else
            MessageBox.Show("Invalid username or password!")
        End If
        con.Close()
    End Sub
End Class
