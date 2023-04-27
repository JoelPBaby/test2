Public Class Form1
    Private Sub b2_Click(sender As Object, e As EventArgs) Handles b2.Click
        Dim a, b As Integer
        a = b1.Text
        If r1.Checked = True Then
            b = a * a
            l2.Text = "Square of the number is :" & b
        End If
        If r2.Checked = True Then
            b = a * a * a
            l2.Text = "Cube of the number is : " & b
        End If
    End Sub
End Class
