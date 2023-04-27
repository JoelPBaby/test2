<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.l1 = New System.Windows.Forms.Label()
        Me.b1 = New System.Windows.Forms.TextBox()
        Me.b2 = New System.Windows.Forms.TextBox()
        Me.b3 = New System.Windows.Forms.TextBox()
        Me.b4 = New System.Windows.Forms.TextBox()
        Me.l2 = New System.Windows.Forms.Label()
        Me.l3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(373, 220)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Click"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(280, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter Name : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(280, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter Mark 1 :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(280, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Enter mark 2 : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(282, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Enter Mark : 3"
        '
        'l1
        '
        Me.l1.AutoSize = True
        Me.l1.Location = New System.Drawing.Point(356, 273)
        Me.l1.Name = "l1"
        Me.l1.Size = New System.Drawing.Size(0, 13)
        Me.l1.TabIndex = 1
        '
        'b1
        '
        Me.b1.Location = New System.Drawing.Point(373, 62)
        Me.b1.Name = "b1"
        Me.b1.Size = New System.Drawing.Size(100, 20)
        Me.b1.TabIndex = 2
        '
        'b2
        '
        Me.b2.Location = New System.Drawing.Point(373, 102)
        Me.b2.Name = "b2"
        Me.b2.Size = New System.Drawing.Size(100, 20)
        Me.b2.TabIndex = 2
        '
        'b3
        '
        Me.b3.Location = New System.Drawing.Point(373, 136)
        Me.b3.Name = "b3"
        Me.b3.Size = New System.Drawing.Size(100, 20)
        Me.b3.TabIndex = 2
        '
        'b4
        '
        Me.b4.Location = New System.Drawing.Point(373, 176)
        Me.b4.Name = "b4"
        Me.b4.Size = New System.Drawing.Size(100, 20)
        Me.b4.TabIndex = 2
        '
        'l2
        '
        Me.l2.AutoSize = True
        Me.l2.Location = New System.Drawing.Point(356, 300)
        Me.l2.Name = "l2"
        Me.l2.Size = New System.Drawing.Size(0, 13)
        Me.l2.TabIndex = 1
        '
        'l3
        '
        Me.l3.AutoSize = True
        Me.l3.Location = New System.Drawing.Point(356, 324)
        Me.l3.Name = "l3"
        Me.l3.Size = New System.Drawing.Size(0, 13)
        Me.l3.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 422)
        Me.Controls.Add(Me.b4)
        Me.Controls.Add(Me.b3)
        Me.Controls.Add(Me.b2)
        Me.Controls.Add(Me.b1)
        Me.Controls.Add(Me.l2)
        Me.Controls.Add(Me.l1)
        Me.Controls.Add(Me.l3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents l1 As Label
    Friend WithEvents b1 As TextBox
    Friend WithEvents b2 As TextBox
    Friend WithEvents b3 As TextBox
    Friend WithEvents b4 As TextBox
    Friend WithEvents l2 As Label
    Friend WithEvents l3 As Label
End Class
