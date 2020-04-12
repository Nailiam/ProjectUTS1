Public Class form1
    Dim segitiga As Form_Segitiga = New Form_Segitiga
    Dim bujursangkar As Form_Bujur_Sangkar = New Form_Bujur_Sangkar
    Dim persegipanjang As Form_Persegi_Panjang = New Form_Persegi_Panjang
    Dim Lingkaran As Form_Lingkaran = New Form_Lingkaran
    Dim jajargenjang As Form_Jajargenjang = New Form_Jajargenjang

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form_Segitiga.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form_Bujur_Sangkar.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form_Persegi_Panjang.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form_Lingkaran.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Form_Jajargenjang.Show()
    End Sub

End Class