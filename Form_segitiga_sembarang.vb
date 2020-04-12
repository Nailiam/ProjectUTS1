Public Class Form_segitiga_sembarang
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Luas.Text = ""
        Luas.Text = 1 / 2 * Val(alas.Text) * Val(tinggi.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        keliling.Text = ""
        keliling.Text = Val(alas.Text) + Val(a.Text) + Val(b.Text)
    End Sub
End Class