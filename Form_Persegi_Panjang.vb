Public Class Form_Persegi_Panjang
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Luas.Text = Val(Panjang.Text) * Val(Lebar.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Keliling.Text = 2 * Val(Panjang.Text) + 2 * Val(Lebar.Text)
    End Sub
End Class