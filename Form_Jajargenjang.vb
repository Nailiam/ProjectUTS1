﻿Public Class Form_Jajargenjang
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        hasilk.Text = ""
        hasilk.Text = 2 * (Val(a.Text) + Val(b.Text))
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        hasill.Text = ""
        hasill.Text = Val(a.Text) * Val(t.Text)
    End Sub
End Class