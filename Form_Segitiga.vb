Public Class Form_Segitiga
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Luas.Text = ""
        Luas.Text = 1 / 2 * Val(Alas.Text) * Val(Tinggi.Text)
    End Sub

    Private Sub Button2_Click(Byvalsender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Keliling.Text = ""
        Keliling.Text = Val(Alas.Text) + Val(Alas.Text) + Val(Alas.Text)
    End Sub
End Class