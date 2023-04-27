Public Class Form1
    Public Shared a, b, c, d, f, g, h, i, j, k, l, m, n, o, p As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        a = TextBox1.Text
        b = TextBox2.Text
        c = TextBox3.Text
        d = TextBox4.Text
        f = TextBox5.Text
        g = TextBox6.Text
        h = TextBox7.Text

        Form2.Show()
    End Sub
End Class

