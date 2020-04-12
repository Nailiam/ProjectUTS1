<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_segitiga_sembarang
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.alas = New System.Windows.Forms.TextBox()
        Me.tinggi = New System.Windows.Forms.TextBox()
        Me.a = New System.Windows.Forms.TextBox()
        Me.b = New System.Windows.Forms.TextBox()
        Me.Luas = New System.Windows.Forms.TextBox()
        Me.keliling = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(115, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Segitiga sembarang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Alas (c)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(67, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tinggi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(67, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Panjang a"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(67, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Panjang b"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(45, 200)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 25)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Hitung Luas"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(45, 247)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 25)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Hitung Keliling"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'alas
        '
        Me.alas.Location = New System.Drawing.Point(143, 45)
        Me.alas.Name = "alas"
        Me.alas.Size = New System.Drawing.Size(96, 20)
        Me.alas.TabIndex = 7
        '
        'tinggi
        '
        Me.tinggi.Location = New System.Drawing.Point(143, 78)
        Me.tinggi.Name = "tinggi"
        Me.tinggi.Size = New System.Drawing.Size(96, 20)
        Me.tinggi.TabIndex = 8
        '
        'a
        '
        Me.a.Location = New System.Drawing.Point(143, 116)
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(96, 20)
        Me.a.TabIndex = 9
        '
        'b
        '
        Me.b.Location = New System.Drawing.Point(143, 152)
        Me.b.Name = "b"
        Me.b.Size = New System.Drawing.Size(96, 20)
        Me.b.TabIndex = 10
        '
        'Luas
        '
        Me.Luas.Location = New System.Drawing.Point(160, 203)
        Me.Luas.Name = "Luas"
        Me.Luas.Size = New System.Drawing.Size(106, 20)
        Me.Luas.TabIndex = 11
        '
        'keliling
        '
        Me.keliling.Location = New System.Drawing.Point(160, 250)
        Me.keliling.Name = "keliling"
        Me.keliling.Size = New System.Drawing.Size(106, 20)
        Me.keliling.TabIndex = 12
        '
        'Form_segitiga_sembarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 310)
        Me.Controls.Add(Me.keliling)
        Me.Controls.Add(Me.Luas)
        Me.Controls.Add(Me.b)
        Me.Controls.Add(Me.a)
        Me.Controls.Add(Me.tinggi)
        Me.Controls.Add(Me.alas)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_segitiga_sembarang"
        Me.Text = "Form_segitiga_sembarang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents alas As TextBox
    Friend WithEvents tinggi As TextBox
    Friend WithEvents a As TextBox
    Friend WithEvents b As TextBox
    Friend WithEvents Luas As TextBox
    Friend WithEvents keliling As TextBox
End Class
