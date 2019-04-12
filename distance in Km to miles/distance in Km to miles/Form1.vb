Public Class Form1

    Dim convertedMiles As Double
    Dim convertedkm As Double
    'Compute miles.  There are 0.621 miles In a kilometer.
    ' miles = kilometers * 0.621
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtUnity.TextChanged
        If cboUnit.Text = "Kilometers" Then
            convertedkm = Val(txtUnity.Text) / 0.621
            lblKilo.Text = convertedkm & " km"

        ElseIf cboUnit.Text = "Miles" Then
            convertedMiles = Val(txtUnity.Text) * 0.621

            lblMile.Text = convertedMiles & " miles"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub
End Class
