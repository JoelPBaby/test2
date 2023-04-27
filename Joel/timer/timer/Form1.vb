Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub FeedbackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FeedbackToolStripMenuItem.Click
        Form3.Show()
    End Sub
End Class
