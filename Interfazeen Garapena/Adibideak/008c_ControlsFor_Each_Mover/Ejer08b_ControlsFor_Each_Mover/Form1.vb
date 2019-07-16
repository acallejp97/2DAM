Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.Container
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(76, 72)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 24)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Eskumara"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(76, 114)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Eskerrera"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(76, 157)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Hasieran kokatu"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(234, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(394, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "ERABILI BEHAR DA:    For Each c In Me.Controls"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(234, 223)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 28)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "If TypeOf c Is Button Then"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(235, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Etiketa"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(238, 97)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 8
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(238, 10)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(69, 17)
        Me.RadioButton1.TabIndex = 9
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Euskeraz"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(238, 33)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(61, 17)
        Me.RadioButton2.TabIndex = 10
        Me.RadioButton2.Text = "Erderaz"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(54, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Botoiak"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(547, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Beste kontrolak"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(569, 157)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "Hasieran kokatu"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(569, 114)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "Eskerrera"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(569, 72)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(72, 24)
        Me.Button6.TabIndex = 13
        Me.Button6.Text = "Eskumara"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(705, 307)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Dim c As Control ' Kontrol motako aldagai bat deklaratu 

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        For Each Me.c In Me.Controls
            If TypeOf c Is Button Then
                c.Left = c.Left + 10
            End If
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        For Each Me.c In Controls
            If TypeOf c Is Button Then
                c.Left = c.Left - 10
            End If
        Next
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        For Each Me.c In Controls
            If TypeOf c Is Button Then
                If c.Name = "Button1" Or c.Name = "Button2" Or c.Name = "Button3" Then
                    c.Left = 76
                Else
                    c.Left = 569
                End If
            End If
        Next
        ' Beste modu batean. Button3 izango balitz
        'For Each Me.c In Controls
        '   If TypeOf c Is Button And Not c.Equals(sender) Then
        '      c.Left = c.Left + 25
        '   End If
        'Next

        'Zuzenean eginda
        'Me.Button1.Left += 25
        'Me.Button2.Left += 25
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Button1.Text = "Eskumara"
        Button2.Text = "Eskerrera"
        Button3.Text = "Hasieran"
        Button6.Text = "Eskumara"
        Button5.Text = "Eskerrera"
        Button4.Text = "Hasieran"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Button1.Text = "Derecha"
        Button2.Text = "Izquierda"
        Button3.Text = "Inicio"
        Button6.Text = "Derecha"
        Button5.Text = "Izquierda"
        Button4.Text = "Inicio"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        For Each Me.c In Me.Controls
            If Not TypeOf c Is Button And Not TypeOf c Is Label Then
                c.Left = c.Left + 10
            End If
        Next
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        For Each Me.c In Me.Controls
            If Not TypeOf c Is Button And Not TypeOf c Is Label Then
                c.Left = c.Left - 10
            End If
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For Each Me.c In Me.Controls
            If Not TypeOf c Is Button And Not TypeOf c Is Label Then
                c.Left = 234
            End If
        Next
    End Sub
End Class
