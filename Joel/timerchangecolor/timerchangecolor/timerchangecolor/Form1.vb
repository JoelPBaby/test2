Imports System.Diagnostics.Eventing.Reader
Public Class Form1
    Dim second As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        second = second + 1
        txt1.Text = second
        If second = 1 Then
            txt2.ForeColor = Color.Black

        ElseIf second = 2 Then
            txt2.ForeColor = Color.Blue

        ElseIf second = 3 Then
            txt2.ForeColor = Color.Green
        ElseIf second = 4 Then
            txt2.ForeColor = Color.Yellow
        ElseIf second = 5 Then
            txt2.ForeColor = Color.Violet
        ElseIf second = 6 Then
            txt2.ForeColor = Color.Red
        ElseIf second = 7 Then
            txt2.ForeColor = Color.Green
        Else
            txt2.ForeColor = Color.Orange
        End If
        If second > 10 Then
            Timer1.Stop()
            MsgBox("Timer box")
        End If

    End Sub
End Class
