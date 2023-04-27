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
        Me.b2 = New System.Windows.Forms.Button()
        Me.r1 = New System.Windows.Forms.RadioButton()
        Me.r2 = New System.Windows.Forms.RadioButton()
        Me.l2 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.b1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'b2
        '
        Me.b2.Font = New System.Drawing.Font("Microsoft Uighur", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b2.Location = New System.Drawing.Point(323, 218)
        Me.b2.Name = "b2"
        Me.b2.Size = New System.Drawing.Size(82, 34)
        Me.b2.TabIndex = 0
        Me.b2.Text = "Submit"
        Me.b2.UseVisualStyleBackColor = True
        '
        'r1
        '
        Me.r1.AutoSize = True
        Me.r1.Font = New System.Drawing.Font("Microsoft Uighur", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r1.Location = New System.Drawing.Point(299, 169)
        Me.r1.Name = "r1"
        Me.r1.Size = New System.Drawing.Size(60, 27)
        Me.r1.TabIndex = 1
        Me.r1.Text = "Square"
        Me.r1.UseVisualStyleBackColor = True
        '
        'r2
        '
        Me.r2.AutoSize = True
        Me.r2.Font = New System.Drawing.Font("Microsoft Uighur", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r2.Location = New System.Drawing.Point(381, 169)
        Me.r2.Name = "r2"
        Me.r2.Size = New System.Drawing.Size(53, 27)
        Me.r2.TabIndex = 2
        Me.r2.Text = "Cube"
        Me.r2.UseVisualStyleBackColor = True
        '
        'l2
        '
        Me.l2.AutoSize = True
        Me.l2.Location = New System.Drawing.Point(320, 275)
        Me.l2.Name = "l2"
        Me.l2.Size = New System.Drawing.Size(0, 13)
        Me.l2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Uighur", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(277, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Enter Number : "
        '
        'b1
        '
        Me.b1.Location = New System.Drawing.Point(366, 108)
        Me.b1.Name = "b1"
        Me.b1.Size = New System.Drawing.Size(100, 20)
        Me.b1.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 444)
        Me.Controls.Add(Me.b1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.l2)
        Me.Controls.Add(Me.r2)
        Me.Controls.Add(Me.r1)
        Me.Controls.Add(Me.b2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents b2 As Button
    Friend WithEvents r1 As RadioButton
    Friend WithEvents r2 As RadioButton
    Friend WithEvents l2 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents b1 As TextBox
End Class
