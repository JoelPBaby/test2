Public Class Form1
    Public score As Integer

    Dim second As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (RadioButton2.Checked) Then
            score = score + 1
            Timer1.Stop()
            Form2.Show()
        Else
            Form2.Show()
            Timer1.Stop()
        End If
    End Sub

    Private Sub txt1_TextChanged(sender As Object, e As EventArgs) Handles txt1.TextChanged

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        second = second + 1
        txt1.Text = second
        If second >= 10 Then

            Timer1.Stop()
            MsgBox("time out")

        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class
