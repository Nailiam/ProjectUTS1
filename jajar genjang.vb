Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        hasil.Text = ""
        hasil.Text = Val(bil1.Text) * Val(bil2.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        hasil.Text = ""
        hasil.Text = (Val(bil1.Text) + Val(bil2.Text)) * 2
    End Sub

    Private Sub bil1_TextChanged(sender As Object, e As EventArgs) Handles bil1.TextChanged

    End Sub
End Class
