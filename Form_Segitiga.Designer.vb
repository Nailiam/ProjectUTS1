<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Segitiga
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
        Me.Alas = New System.Windows.Forms.TextBox()
        Me.Tinggi = New System.Windows.Forms.TextBox()
        Me.Luas = New System.Windows.Forms.TextBox()
        Me.Keliling = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(200, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SEGITIGA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(95, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Alas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(95, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tinggi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(95, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Luas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(95, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Keliling"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(98, 260)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Hitung Luas"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(251, 260)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(107, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Hitung Keliling"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Alas
        '
        Me.Alas.Location = New System.Drawing.Point(203, 97)
        Me.Alas.Name = "Alas"
        Me.Alas.Size = New System.Drawing.Size(123, 20)
        Me.Alas.TabIndex = 7
        '
        'Tinggi
        '
        Me.Tinggi.Location = New System.Drawing.Point(203, 134)
        Me.Tinggi.Name = "Tinggi"
        Me.Tinggi.Size = New System.Drawing.Size(123, 20)
        Me.Tinggi.TabIndex = 8
        '
        'Luas
        '
        Me.Luas.Location = New System.Drawing.Point(203, 172)
        Me.Luas.Name = "Luas"
        Me.Luas.Size = New System.Drawing.Size(123, 20)
        Me.Luas.TabIndex = 9
        '
        'Keliling
        '
        Me.Keliling.Location = New System.Drawing.Point(203, 207)
        Me.Keliling.Name = "Keliling"
        Me.Keliling.Size = New System.Drawing.Size(123, 20)
        Me.Keliling.TabIndex = 10
        '
        'Form_Segitiga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 323)
        Me.Controls.Add(Me.Keliling)
        Me.Controls.Add(Me.Luas)
        Me.Controls.Add(Me.Tinggi)
        Me.Controls.Add(Me.Alas)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_Segitiga"
        Me.Text = "Form_Segitiga"
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
    Friend WithEvents Alas As TextBox
    Friend WithEvents Tinggi As TextBox
    Friend WithEvents Luas As TextBox
    Friend WithEvents Keliling As TextBox
End Class
