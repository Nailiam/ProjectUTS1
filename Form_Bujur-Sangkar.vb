Public Class Form_Bujur_Sangkar
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.Text = ""
        TextBox2.Text = Val(TextBox1.Text) * Val(TextBox1.Text)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox3.Text = ""
        TextBox3.Text = Val(TextBox1.Text) * 4
    End Sub
End Class