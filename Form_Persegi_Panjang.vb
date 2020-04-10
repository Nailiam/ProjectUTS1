Public Class Form_Persegi_Panjang
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Luas.Text = (Panjang.Text) * (Lebar.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Keliling.Text = 2 * (Panjang.Text) + 2 * (Lebar.Text)
    End Sub
End Class