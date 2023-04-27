<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txt2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txt2
        '
        Me.txt2.AutoSize = True
        Me.txt2.Location = New System.Drawing.Point(211, 146)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(103, 25)
        Me.txt2.TabIndex = 0
        Me.txt2.Text = "Hallo world"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(570, 44)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(150, 31)
        Me.txt1.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.txt2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txt1 As TextBox
End Class
