Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents HScrollBar1 As System.Windows.Forms.HScrollBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(64, 80)
        Me.HScrollBar1.Minimum = -30
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(184, 32)
        Me.HScrollBar1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(352, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 32)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "º Fahrenheit"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(120, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 40)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Celsius"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(352, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 32)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(136, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(288, 24)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Fahrenheit eta Celsiusen arteko baliokidetza"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(135, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(345, 24)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Grados_Faren=9 / 5  * gradosC + 32"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(563, 237)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.HScrollBar1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim grados As New CGrados

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.HScrollBar1.Value = 20
    End Sub

    Private Sub HScrollBar1_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles HScrollBar1.Scroll
        Dim resul As Double
        grados.AsignarCentígrados(Me.HScrollBar1.Value)
        Label3.Text = Me.HScrollBar1.Value & " ºC"

        resul = grados.ObtenerFahrenheit
        Label4.Text = resul.ToString("##0.00") & " ºF"  'Decimal.Truncate()
    End Sub
End Class
