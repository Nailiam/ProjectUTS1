<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Lingkaran
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.r = New System.Windows.Forms.TextBox()
        Me.hasilk = New System.Windows.Forms.TextBox()
        Me.hasill = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lingkaran"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Jari-jari"
        '
        'r
        '
        Me.r.Location = New System.Drawing.Point(118, 55)
        Me.r.Name = "r"
        Me.r.Size = New System.Drawing.Size(82, 20)
        Me.r.TabIndex = 2
        '
        'hasilk
        '
        Me.hasilk.Location = New System.Drawing.Point(154, 148)
        Me.hasilk.Name = "hasilk"
        Me.hasilk.Size = New System.Drawing.Size(93, 20)
        Me.hasilk.TabIndex = 3
        '
        'hasill
        '
        Me.hasill.Location = New System.Drawing.Point(154, 202)
        Me.hasill.Name = "hasill"
        Me.hasill.Size = New System.Drawing.Size(93, 20)
        Me.hasill.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(39, 141)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 32)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Hitung Keliling"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(39, 190)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 32)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Hitung Luas"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form_Lingkaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 304)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.hasill)
        Me.Controls.Add(Me.hasilk)
        Me.Controls.Add(Me.r)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_Lingkaran"
        Me.Text = "Form_Lingkaran"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents r As TextBox
    Friend WithEvents hasilk As TextBox
    Friend WithEvents hasill As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
