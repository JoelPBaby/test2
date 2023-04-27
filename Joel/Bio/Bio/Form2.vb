Public Class l6
    Public Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub UserDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserDetailsToolStripMenuItem.Click
        l1.Text = Form1.a
        l2.Text = Form1.b
        l3.Text = Form1.c
        l4.Text = Form1.d
        l5.Text = Form1.f
        Label6.Text = Form1.g
    End Sub

    Private Sub ContactToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactToolStripMenuItem.Click
        Label1.Text = "Contact Details"
        Label1.Text = "Name"
        Label2.Text = "Phone Number"
        Label3.Text = "Email"
        Label4.Text = "Address"
        l1.Text = Form1.a
        l2.Text = Form1.b
        l3.Text = Form1.c
        l4.Text = Form1.d
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class