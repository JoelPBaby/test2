Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Black
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.BackColor = Color.Black
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.BackColor = Color.Chocolate
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.BackColor = Color.Chartreuse

    End Sub
    Private Sub Form1_close(sender As Object, e As EventArgs) Handles MyBase.Closing
        MsgBox("form is closing")
    End Sub
    Private Sub Form1_mousedown(sender As Object, e As EventArgs) Handles MyBase.MouseDown
        TextBox1.BackColor = Color.Red
    End Sub
    Private Sub Form1_mouseup(sender As Object, e As EventArgs) Handles MyBase.MouseUp

        TextBox1.BackColor = Color.Green
    End Sub
    Private Sub Form1_mouseclick(sender As Object, e As EventArgs) Handles MyBase.MouseClick

        TextBox1.BackColor = Color.White
    End Sub
End Class

