Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Male" Then
            ComboBox2.Items.AddRange({"mark", "peter", "kurian", "aby", "sebastian", "sarin", "Philip"})
        ElseIf ComboBox1.SelectedItem = "Female" Then
            ComboBox2.Items.AddRange({"Lena", "jessy", "Lizy", "sisily"})
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedItem = "choose Gender"
        ComboBox2.SelectedItem = "select"

    End Sub
End Class
