Public Class Form1
    Dim second As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        second = second + 1
        txt1.Text = second
        If second = 1 Then
            PictureBox1.Image = Image.FromFile("D:\xampp\htdocs\mathew\miniproject-s6\img\1.jpg")

        ElseIf second = 2 Then
            PictureBox1.Image = Image.FromFile("D:\xampp\htdocs\mathew\miniproject-s6\img\2.jpg")

        ElseIf second = 3 Then
            PictureBox1.Image = Image.FromFile("D:\xampp\htdocs\mathew\miniproject-s6\img\3.jpg")
        ElseIf second = 4 Then
            PictureBox1.Image = Image.FromFile("D:\xampp\htdocs\mathew\miniproject-s6\img\4.jpg")
        ElseIf second = 5 Then
            PictureBox1.Image = Image.FromFile("D:\xampp\htdocs\mathew\miniproject-s6\img\5.jpg")
        ElseIf second = 6 Then
            PictureBox1.Image = Image.FromFile("D:\xampp\htdocs\mathew\miniproject-s6\img\6.jpg")
        ElseIf second = 7 Then
            PictureBox1.Image = Image.FromFile("D:\xampp\htdocs\mathew\miniproject-s6\img\7.jpg")
        ElseIf second = 8 Then
            PictureBox1.Image = Image.FromFile("D:\xampp\htdocs\mathew\miniproject-s6\img\8.jpg")
        Else
            PictureBox1.Image = Image.FromFile("D:\xampp\htdocs\mathew\miniproject-s6\img\9.jpg")
        End If
        If second > 10 Then
            Timer1.Stop()
            MsgBox("Timer close")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class
