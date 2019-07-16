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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmdCerrar As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdCerrar = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.Location = New System.Drawing.Point(107, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Izena"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(160, 40)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(295, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(379, 72)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "&Gehitu"
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmdCerrar.Location = New System.Drawing.Point(169, 72)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(88, 24)
        Me.cmdCerrar.TabIndex = 3
        Me.cmdCerrar.Text = "&Irten"
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.Location = New System.Drawing.Point(24, 131)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBox1.Size = New System.Drawing.Size(483, 108)
        Me.ListBox1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(16, 248)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(354, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "SelectionMode Multiextended"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 272)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(344, 32)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "DEL sakatzen baduzu aukeratuta dauden guztiak ezabatzen dira."
        '
        'Form1
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(523, 336)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        ' MsgBox(e.KeyChar)  'Solo coge los caracteres
        'If e.KeyChar = Keys.Escape Then
        '    'NO FUNCIONA
        'End If
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.ListBox1.Items.Clear()      
        'Me.ListBox1.SelectionMode = SelectionMode.MultiSimple 'No funcionan las flechas para seleccionar
        Me.ListBox1.SelectionMode = SelectionMode.MultiExtended 'No funcionan las flechas para seleccionar

        Me.KeyPreview = True
        Me.TextBox1.Text = ""
        Me.ListBox1.Items.Add("Bilbo")
        Me.ListBox1.Items.Add("Elorrieta")
        Me.ListBox1.Items.Add("Erreka-Mari")
        Me.ListBox1.Items.Add("Txurdinaga")
        Me.ListBox1.Items.Add("Tartanga")
    End Sub

    Private Sub AÑADIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.ListBox1.Items.Add(TextBox1.Text)
        Me.TextBox1.Text = ""
        Me.TextBox1.Focus()
    End Sub

    Private Sub ListBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ListBox1.KeyDown
        'MULTISELECTION   Item batzuk aukeratu ahal dira.
        Dim i As Integer
        If e.KeyCode = Keys.Delete Then

            For i = 0 To ListBox1.SelectedItems.Count - 1
                ListBox1.Items.Remove(ListBox1.SelectedItem)
            Next
        End If
        Me.TextBox1.Text = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Application.Exit()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        TextBox1.Text = ListBox1.SelectedIndex & " " & ListBox1.SelectedItem()
    End Sub
End Class
