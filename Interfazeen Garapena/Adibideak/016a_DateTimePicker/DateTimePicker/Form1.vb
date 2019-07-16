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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.Container

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lblaños As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label

    Friend WithEvents Label7 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblaños = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(32, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Control DateTimePicker1"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(32, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Propiedad Value = now"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(48, 200)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(168, 32)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Baieztatu"
        '
        'lblaños
        '
        Me.lblaños.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblaños.ForeColor = System.Drawing.Color.Blue
        Me.lblaños.Location = New System.Drawing.Point(168, 144)
        Me.lblaños.Name = "lblaños"
        Me.lblaños.Size = New System.Drawing.Size(72, 32)
        Me.lblaños.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(112, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "URTE"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(248, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 24)
        Me.Label4.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(32, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(176, 24)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Sartu zure jaiotze data:"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(304, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 24)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "EGUN"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(35, 100)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(256, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Label5"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(482, 267)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblaños)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.DateTimePicker1.Value = Now
        Me.DateTimePicker1.Value = "#29/10/1967#"
    End Sub

    Private Sub Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MessageBox.Show( _
        vbCrLf & "Gaur da ......" & Date.Now.ToString() & vbNewLine & _
        vbCrLf & "ZURE JAIOTZE EGUNA IZAN ZEN " & Me.DateTimePicker1.Value & _
        vbCrLf & "Asteko eguna: " & Me.DateTimePicker1.Value.DayOfWeek.ToString & _
        vbNewLine & "Urteko eguna: " & Me.DateTimePicker1.Value.DayOfYear.ToString())
        'el domingo es cero.
    End Sub

    Private Sub DateTimePicker1_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        Dim fecha As Date = Me.DateTimePicker1.Value

        Me.Label4.Text = Now.Subtract(fecha).Days
        Me.lblaños.Text = Decimal.Truncate(Now.Subtract(fecha).Days / 365.25)

        Select Case fecha.DayOfWeek
            Case DayOfWeek.Friday
                Me.Label5.Text = "OSTIRALA"
            Case DayOfWeek.Monday
                Me.Label5.Text = "ASTELEHENA"
            Case DayOfWeek.Saturday
                Me.Label5.Text = "LARUNBATA"
            Case DayOfWeek.Sunday
                Me.Label5.Text = "IGANDEA"
            Case DayOfWeek.Thursday
                Me.Label5.Text = "OSTEGUNA"
            Case DayOfWeek.Tuesday
                Me.Label5.Text = "ASTEARTEA"
            Case DayOfWeek.Wednesday
                Me.Label5.Text = "ASTEAZKENA"
        End Select

    End Sub

End Class
