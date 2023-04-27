Public Class Form1
    Function temp(ByVal c As Double)
        Return (c * 9 / 5) + 32
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, f As Double
        a = b1.Text
        f = temp(a)
        l2.Text = "Temperature in Fahrenheit is :" & f & " °F"
    End Sub
End Class
