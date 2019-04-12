Imports System.Data.OleDb

Public Class Registration
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub Registration_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\accounts.accdb")
        Dim cmd As OleDbCommand = New OleDbCommand("INSERT INTO users([name],[surname],[email], [phone], [username],[password]) Values('" & txtName.Text & "','" & txtLast.Text & "','" & txtEmail.Text & "','" & txtPhone.Text & "','" & txtUser.Text & "','" & txtPass.Text & "')  ", con)
        con.Open()
        Dim r As Integer
        r = cmd.ExecuteNonQuery()
        If r > 0 Then
            MsgBox("New user record has been saved!")
            Login.Show()
            Me.Hide()
            txtEmail.Clear()
            txtName.Clear()
            txtPass.Clear()
            txtPhone.Clear()
            txtLast.Clear()
            txtUser.Clear()
        Else
            MsgBox("No user record has been saved!")


        End If
        con.Close()
    End Sub
End Class