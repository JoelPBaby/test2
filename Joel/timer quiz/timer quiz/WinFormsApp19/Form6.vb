Public Class Form6
    Public second As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then
            Form1.score = Form1.score + 1
            Timer1.Stop()
            Form7.Show()
        Else
            Timer1.Stop()
            Form7.Show()

        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        second = second + 1
        txt1.text = second
        If second > 10 Then
            Timer1.Stop()
            MsgBox("time out")

        End If
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class