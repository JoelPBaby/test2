Public Class Form1
    Dim second As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        second = second + 1
        txt1.Text = second
        If second = 1 Then
            Me.BackColor = Color.Black

        ElseIf second = 2 Then
            Me.BackColor = Color.Blue

        ElseIf second = 3 Then
            Me.BackColor = Color.Green
        ElseIf second = 4 Then
            Me.BackColor = Color.Yellow
        ElseIf second = 5 Then
            Me.BackColor = Color.Violet
        ElseIf second = 6 Then
            Me.BackColor = Color.Red
        ElseIf second = 7 Then
            Me.BackColor = Color.Green
        ElseIf second = 8 Then
            Me.BackColor = Color.Pink
        Else
            Me.BackColor = Color.Orange
        End If
        If second > 10 Then
            Timer1.Stop()
            MsgBox("Timer close")
        End If

    End Sub
End Class
