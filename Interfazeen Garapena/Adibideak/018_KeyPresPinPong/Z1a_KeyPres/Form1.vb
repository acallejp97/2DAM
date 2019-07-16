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
  Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
  Friend WithEvents Timer1 As System.Windows.Forms.Timer
  Friend WithEvents Button1 As System.Windows.Forms.Button
  Friend WithEvents Button2 As System.Windows.Forms.Button
  Private components As System.ComponentModel.IContainer

  'Required by the Windows Form Designer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(264, 56)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(8, 56)
        Me.Button2.TabIndex = 1
        Me.Button2.TabStop = False
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'RadioButton1
        '
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(64, 64)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(16, 24)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(16, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(8, 56)
        Me.Button1.TabIndex = 1
        Me.Button1.TabStop = False
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 262)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RadioButton1)
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.Text = "Koordenatuak"
        Me.ResumeLayout(False)

    End Sub

#End Region

    ' RadioButton norantz joango den. Hasteko eskumatara eta behera
    Dim dx As Integer = 1
    Dim dy As Integer = 1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        Me.Text = Me.ClientSize.Width & "  -- " & Me.ClientSize.Height
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        Button2.Top = e.Y    ' Bigarren botoia saguaren batera mugituko da
        'MUGAK        
        If Me.Button2.Top < 0 Then Me.Button2.Top = 0
        If (Me.Button2.Top + Me.Button2.Height) > Me.ClientSize.Height Then
            Me.Button2.Top = Me.ClientSize.Height - Me.Button2.Height
        End If
    End Sub


    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        ' RadioButtonen mugimendua hasi edo eten
        If e.Button = MouseButtons.Left Then Timer1.Enabled = True
        If e.Button = MouseButtons.Right Then Timer1.Enabled = False
    End Sub


    Private Sub Form1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Button1.Top -= IIf(Char.ToUpper(e.KeyChar) = "Q", 10, 0)
        If Char.ToUpper(e.KeyChar) = "Z" Then
            Button1.Top += 10
        End If

        'LIMITES        
        If Me.Button1.Top < 0 Then Me.Button1.Top = 0
        If (Me.Button1.Top + Me.Button1.Height) > Me.ClientSize.Height Then
            Me.Button1.Top = Me.ClientSize.Height - Me.Button1.Height
        End If
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        RadioButton1.Left += dx
        RadioButton1.Top += dy
        dx = IIf(RadioButton1.Location.X >= Me.ClientSize.Width - RadioButton1.Width, -1, dx)
        dx = IIf(RadioButton1.Location.X = 0, 1, dx)
        dy = IIf(RadioButton1.Location.Y >= Me.ClientSize.Height - RadioButton1.Height, -1, dy)
        dy = IIf(RadioButton1.Location.Y = 0, 1, dy)

        ' RadioButtonen posizioa eguneratzen da, eta horren arabera mugimendu kontrolatzen duten aldagaiak aldatzen dira
        ' Horrela, errebotea egiten da toperaino ailegatzen denean
        ' Mugan ailegatzen denean dx/dy=-1 atzerantz joateko
        ' Posizioa 0 bada dx/dy= +1 aurrerantz joateko.
    End Sub
   
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        'Sagua sakatzen bada
        'Dim a As String = Nothing
        'Select Case e.Button
        '    Case MouseButtons.Left
        '        a = "L"
        '    Case MouseButtons.Right
        '        a = "R"
        '    Case MouseButtons.Middle
        '        a = "M"
        'End Select
    End Sub

    Private Sub Form1_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        Me.Text = Me.ClientSize.Width & "  -- " & Me.ClientSize.Height
    End Sub
End Class
