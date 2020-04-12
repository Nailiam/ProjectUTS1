<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_segitiga_siku_siku
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Alas = New System.Windows.Forms.TextBox()
        Me.Tinggi = New System.Windows.Forms.TextBox()
        Me.Sisimiring = New System.Windows.Forms.TextBox()
        Me.Luas = New System.Windows.Forms.TextBox()
        Me.Keliling = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(128, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Segitiga siku-siku"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Alas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tinggi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(58, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Sisi miring"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(58, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Luas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(58, 221)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Keliling"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(63, 263)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 30)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Hitung luas"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(213, 263)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 30)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Hitung Keliling"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Alas
        '
        Me.Alas.Location = New System.Drawing.Point(132, 58)
        Me.Alas.Name = "Alas"
        Me.Alas.Size = New System.Drawing.Size(104, 20)
        Me.Alas.TabIndex = 8
        '
        'Tinggi
        '
        Me.Tinggi.Location = New System.Drawing.Point(132, 103)
        Me.Tinggi.Name = "Tinggi"
        Me.Tinggi.Size = New System.Drawing.Size(104, 20)
        Me.Tinggi.TabIndex = 9
        '
        'Sisimiring
        '
        Me.Sisimiring.Location = New System.Drawing.Point(132, 143)
        Me.Sisimiring.Name = "Sisimiring"
        Me.Sisimiring.Size = New System.Drawing.Size(104, 20)
        Me.Sisimiring.TabIndex = 10
        '
        'Luas
        '
        Me.Luas.Location = New System.Drawing.Point(132, 180)
        Me.Luas.Name = "Luas"
        Me.Luas.Size = New System.Drawing.Size(104, 20)
        Me.Luas.TabIndex = 11
        '
        'Keliling
        '
        Me.Keliling.Location = New System.Drawing.Point(132, 214)
        Me.Keliling.Name = "Keliling"
        Me.Keliling.Size = New System.Drawing.Size(104, 20)
        Me.Keliling.TabIndex = 12
        '
        'Form_segitiga_siku_siku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 321)
        Me.Controls.Add(Me.Keliling)
        Me.Controls.Add(Me.Luas)
        Me.Controls.Add(Me.Sisimiring)
        Me.Controls.Add(Me.Tinggi)
        Me.Controls.Add(Me.Alas)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_segitiga_siku_siku"
        Me.Text = "Form_segitiga_siku_siku"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Alas As TextBox
    Friend WithEvents Tinggi As TextBox
    Friend WithEvents Sisimiring As TextBox
    Friend WithEvents Luas As TextBox
    Friend WithEvents Keliling As TextBox
End Class
