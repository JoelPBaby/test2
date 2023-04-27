Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim m1, m2, m3, avg, sum, perc As Integer
        Dim a As String
        a = b1.Text
        m1 = b2.Text
        m2 = b3.Text
        m3 = b4.Text
        sum = m1 + m2 + m3
        avg = sum / 3
        perc = (sum / 300) * 100
        l1.Text = "Average mark is: " & avg
        l3.Text = "Percentage is: " & perc & "%"
        If avg > 90 Then
            l2.Text = a & "'s" & " Grade is A "
        ElseIf avg > 80 Then
            l2.Text = a & "'s" & " Grade is B "
        ElseIf avg > 70 Then
            l2.Text = a & "'s" & " Grade is C "
        ElseIf avg > 60 Then
            l2.Text = a & "'s" & " Grade is D "
        Else
            l2.Text = a & " Succesfully Failed !"
        End If

    End Sub
End Class
