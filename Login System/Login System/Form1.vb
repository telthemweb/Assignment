Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtUser.Text = "" Then
            MsgBox("Username is required", MsgBoxStyle.Critical)
        ElseIf txtPass.Text = "" Then
            MsgBox("Password is required", MsgBoxStyle.Critical)
        Else
            If txtUser.Text = "muyambo" And txtPass.Text = "1234" Then
                MsgBox("Logged in successfully", MsgBoxStyle.Information)
                GroupBox2.Visible = True
                btnLogout.Text = "HI " & txtUser.Text & " logout"
                GroupBox1.Visible = False
                txtUser.Clear()
                txtPass.Clear()
            Else
                MsgBox("Username or password is incorrect", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        GroupBox1.Visible = True
        GroupBox2.Visible = False
    End Sub
End Class
