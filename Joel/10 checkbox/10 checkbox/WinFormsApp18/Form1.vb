Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim message As String = ""

        If CheckBox1.Checked Then
            message += "Age is under 15" & Environment.NewLine
        End If

        If CheckBox2.Checked Then
            message += "Age is under 25" & Environment.NewLine
        End If

        If CheckBox3.Checked Then
            message += "Age is above 25" & Environment.NewLine
        End If

        MessageBox.Show(message)

        If CheckBox3.Checked Then
            GroupBox1.Visible = False
            GroupBox2.Visible = True
        Else
            GroupBox1.Visible = True
            GroupBox2.Visible = False
        End If

    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Button1.Enabled = Not RadioButton1.Checked
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Button1.Enabled = Not RadioButton2.Checked
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Button1.Enabled = Not RadioButton3.Checked
    End Sub
End Class
