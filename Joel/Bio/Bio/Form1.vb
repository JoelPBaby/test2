Public Class Form1

    Public Shared a, b, c, d, gen, f, g As String

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim gen As String
        a = b1.Text
        b = b2.Text
        c = b3.Text
        d = b4.Text
        If r1.Checked = True Then
            gen = "Male"
        End If
        If r2.Checked = True Then
            gen = "Female"
        End If
        f = b5.Text
        g = b6.Text
        l6.Show()

    End Sub
End Class
