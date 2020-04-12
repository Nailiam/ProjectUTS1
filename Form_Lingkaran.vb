Public Class Form_Lingkaran
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        hasilk.Text = ""
        hasilk.Text = 2 * 3.14 * Val(r.Text)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        hasill.Text = ""
        hasill.Text = 3.14 * (Val(r.Text) ^ 2)
    End Sub
End Class