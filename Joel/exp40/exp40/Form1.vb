Imports System.Reflection.Emit
Imports System.Threading

Public Class Form1
    Dim Second As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        Timer1.Start()
        Label1.Text = Second
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Second = Second + 1
        Label1.Text = Second

        If Second >= 2 And Second < 4 Then
            PictureBox1.Image = Image.FromFile("C:\Users\sarin\Downloads\Wallpaper11.jpg")

        ElseIf Second >= 4 And Second < 6 Then
            PictureBox1.Image = Image.FromFile("C:\Users\sarin\Downloads\Wallpaper12.jpg")

        ElseIf Second >= 6 And Second < 8 Then
            PictureBox1.Image = Image.FromFile("C:\Users\sarin\Downloads\Wallpaper1.jpg")

        ElseIf Second >= 8 And Second < 10 Then
            PictureBox1.Image = Image.FromFile("C:\Users\sarin\Downloads\Wallpaper3.jpg")

        ElseIf Second >= 10 And Second < 12 Then
            PictureBox1.Image = Image.FromFile("C:\Users\sarin\Downloads\Wallpaper3.jpg")

        ElseIf Second > 12 Then
            Timer1.Stop()
            Me.Close()

        End If

    End Sub
End Class
