Friend Class Form1
    Inherits System.Windows.Forms.Form
#Region "Código generado por el Diseñador de Windows Forms "
    Public Sub New()
        MyBase.New()
        If m_vb6FormDefInstance Is Nothing Then
            If m_InitializingDefInstance Then
                m_vb6FormDefInstance = Me
            Else
                Try
                    'Para el formulario de inicio, la primera instancia creada es la instancia predeterminada.
                    If System.Reflection.Assembly.GetExecutingAssembly.EntryPoint.DeclaringType Is Me.GetType Then
                        m_vb6FormDefInstance = Me
                    End If
                Catch
                End Try
            End If
        End If
        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
    End Sub
    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub
    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer
    Public WithEvents btnSalir As System.Windows.Forms.Button
    Public WithEvents btnMostrar As System.Windows.Forms.Button
    Public WithEvents txtMensaje As System.Windows.Forms.TextBox
    Public WithEvents txtTitulo As System.Windows.Forms.TextBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Frame3 As System.Windows.Forms.GroupBox
    Public WithEvents Text1 As System.Windows.Forms.TextBox
    Public WithEvents _obBotones_5 As System.Windows.Forms.RadioButton
    Public WithEvents _obBotones_4 As System.Windows.Forms.RadioButton
    Public WithEvents _obBotones_3 As System.Windows.Forms.RadioButton
    Public WithEvents _obBotones_2 As System.Windows.Forms.RadioButton
    Public WithEvents _obBotones_1 As System.Windows.Forms.RadioButton
    Public WithEvents _obBotones_0 As System.Windows.Forms.RadioButton
    Public WithEvents GBox1 As System.Windows.Forms.GroupBox
    Public WithEvents _obIconos_4 As System.Windows.Forms.RadioButton
    Public WithEvents _obIconos_3 As System.Windows.Forms.RadioButton
    Public WithEvents _obIconos_2 As System.Windows.Forms.RadioButton
    Public WithEvents _obIconos_1 As System.Windows.Forms.RadioButton
    Public WithEvents _obIconos_0 As System.Windows.Forms.RadioButton
    Public WithEvents GBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    'NOTA: el siguiente procedimiento es necesario para el Diseñador de Windows Forms
    'Se puede modificar mediante el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.Frame3 = New System.Windows.Forms.GroupBox()
        Me.txtMensaje = New System.Windows.Forms.TextBox()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Text1 = New System.Windows.Forms.TextBox()
        Me.GBox1 = New System.Windows.Forms.GroupBox()
        Me._obBotones_5 = New System.Windows.Forms.RadioButton()
        Me._obBotones_4 = New System.Windows.Forms.RadioButton()
        Me._obBotones_3 = New System.Windows.Forms.RadioButton()
        Me._obBotones_2 = New System.Windows.Forms.RadioButton()
        Me._obBotones_1 = New System.Windows.Forms.RadioButton()
        Me._obBotones_0 = New System.Windows.Forms.RadioButton()
        Me.GBox2 = New System.Windows.Forms.GroupBox()
        Me._obIconos_4 = New System.Windows.Forms.RadioButton()
        Me._obIconos_3 = New System.Windows.Forms.RadioButton()
        Me._obIconos_2 = New System.Windows.Forms.RadioButton()
        Me._obIconos_1 = New System.Windows.Forms.RadioButton()
        Me._obIconos_0 = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Frame3.SuspendLayout()
        Me.GBox1.SuspendLayout()
        Me.GBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.Control
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSalir.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSalir.Location = New System.Drawing.Point(560, 472)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSalir.Size = New System.Drawing.Size(89, 49)
        Me.btnSalir.TabIndex = 16
        Me.btnSalir.Text = "Irten"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnMostrar
        '
        Me.btnMostrar.BackColor = System.Drawing.SystemColors.Control
        Me.btnMostrar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnMostrar.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnMostrar.Location = New System.Drawing.Point(120, 472)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnMostrar.Size = New System.Drawing.Size(169, 49)
        Me.btnMostrar.TabIndex = 15
        Me.btnMostrar.Text = "MsgBox erakutsi"
        Me.btnMostrar.UseVisualStyleBackColor = False
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.SystemColors.Control
        Me.Frame3.Controls.Add(Me.txtMensaje)
        Me.Frame3.Controls.Add(Me.txtTitulo)
        Me.Frame3.Controls.Add(Me.Label2)
        Me.Frame3.Controls.Add(Me.Label1)
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(120, 336)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(529, 129)
        Me.Frame3.TabIndex = 14
        Me.Frame3.TabStop = False
        Me.Frame3.Text = "Lehioaren testuak"
        '
        'txtMensaje
        '
        Me.txtMensaje.AcceptsReturn = True
        Me.txtMensaje.BackColor = System.Drawing.SystemColors.Window
        Me.txtMensaje.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMensaje.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMensaje.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMensaje.Location = New System.Drawing.Point(96, 80)
        Me.txtMensaje.MaxLength = 0
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMensaje.Size = New System.Drawing.Size(416, 25)
        Me.txtMensaje.TabIndex = 18
        Me.txtMensaje.Text = "Ondo ezagutzen duzu MsgBox?"
        '
        'txtTitulo
        '
        Me.txtTitulo.AcceptsReturn = True
        Me.txtTitulo.BackColor = System.Drawing.SystemColors.Window
        Me.txtTitulo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTitulo.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitulo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTitulo.Location = New System.Drawing.Point(96, 32)
        Me.txtTitulo.MaxLength = 0
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTitulo.Size = New System.Drawing.Size(416, 25)
        Me.txtTitulo.TabIndex = 17
        Me.txtTitulo.Text = "Elorrieta"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(16, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(73, 41)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Mezua"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(8, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(81, 38)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Lehioaren izenburua"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Text1
        '
        Me.Text1.AcceptsReturn = True
        Me.Text1.BackColor = System.Drawing.SystemColors.Window
        Me.Text1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text1.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text1.Location = New System.Drawing.Point(120, 12)
        Me.Text1.MaxLength = 0
        Me.Text1.Name = "Text1"
        Me.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text1.Size = New System.Drawing.Size(529, 44)
        Me.Text1.TabIndex = 13
        Me.Text1.Text = "MsgBox Funtzioa. Mezu kutxak"
        Me.Text1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GBox1
        '
        Me.GBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GBox1.Controls.Add(Me._obBotones_5)
        Me.GBox1.Controls.Add(Me._obBotones_4)
        Me.GBox1.Controls.Add(Me._obBotones_3)
        Me.GBox1.Controls.Add(Me._obBotones_2)
        Me.GBox1.Controls.Add(Me._obBotones_1)
        Me.GBox1.Controls.Add(Me._obBotones_0)
        Me.GBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GBox1.Location = New System.Drawing.Point(74, 96)
        Me.GBox1.Name = "GBox1"
        Me.GBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GBox1.Size = New System.Drawing.Size(307, 225)
        Me.GBox1.TabIndex = 1
        Me.GBox1.TabStop = False
        Me.GBox1.Text = "Botoiak"
        '
        '_obBotones_5
        '
        Me._obBotones_5.BackColor = System.Drawing.SystemColors.Control
        Me._obBotones_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._obBotones_5.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._obBotones_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._obBotones_5.Location = New System.Drawing.Point(16, 184)
        Me._obBotones_5.Name = "_obBotones_5"
        Me._obBotones_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._obBotones_5.Size = New System.Drawing.Size(233, 25)
        Me._obBotones_5.TabIndex = 7
        Me._obBotones_5.Text = "5 - Saiatu berririo eta Utzi (5)"
        Me._obBotones_5.UseVisualStyleBackColor = False
        '
        '_obBotones_4
        '
        Me._obBotones_4.BackColor = System.Drawing.SystemColors.Control
        Me._obBotones_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._obBotones_4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._obBotones_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._obBotones_4.Location = New System.Drawing.Point(16, 152)
        Me._obBotones_4.Name = "_obBotones_4"
        Me._obBotones_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._obBotones_4.Size = New System.Drawing.Size(161, 25)
        Me._obBotones_4.TabIndex = 6
        Me._obBotones_4.Text = "4 -Bai eta Ez (4)"
        Me._obBotones_4.UseVisualStyleBackColor = False
        '
        '_obBotones_3
        '
        Me._obBotones_3.BackColor = System.Drawing.SystemColors.Control
        Me._obBotones_3.Cursor = System.Windows.Forms.Cursors.PanSW
        Me._obBotones_3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._obBotones_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._obBotones_3.Location = New System.Drawing.Point(16, 120)
        Me._obBotones_3.Name = "_obBotones_3"
        Me._obBotones_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._obBotones_3.Size = New System.Drawing.Size(184, 25)
        Me._obBotones_3.TabIndex = 5
        Me._obBotones_3.Text = "3 - Bai, Ez eta Utzi (3)"
        Me._obBotones_3.UseVisualStyleBackColor = False
        '
        '_obBotones_2
        '
        Me._obBotones_2.BackColor = System.Drawing.SystemColors.Control
        Me._obBotones_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._obBotones_2.Font = New System.Drawing.Font("Times New Roman", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._obBotones_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._obBotones_2.Location = New System.Drawing.Point(16, 83)
        Me._obBotones_2.Name = "_obBotones_2"
        Me._obBotones_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._obBotones_2.Size = New System.Drawing.Size(290, 35)
        Me._obBotones_2.TabIndex = 4
        Me._obBotones_2.Text = "2 - Etzi, Saiatu berriro, Bazterrean utzi (2)"
        Me._obBotones_2.UseVisualStyleBackColor = False
        '
        '_obBotones_1
        '
        Me._obBotones_1.BackColor = System.Drawing.SystemColors.Control
        Me._obBotones_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._obBotones_1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._obBotones_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._obBotones_1.Location = New System.Drawing.Point(16, 56)
        Me._obBotones_1.Name = "_obBotones_1"
        Me._obBotones_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._obBotones_1.Size = New System.Drawing.Size(200, 25)
        Me._obBotones_1.TabIndex = 3
        Me._obBotones_1.Text = "1 - Onartu eta Utzi (1)"
        Me._obBotones_1.UseVisualStyleBackColor = False
        '
        '_obBotones_0
        '
        Me._obBotones_0.BackColor = System.Drawing.SystemColors.Control
        Me._obBotones_0.Checked = True
        Me._obBotones_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._obBotones_0.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._obBotones_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._obBotones_0.Location = New System.Drawing.Point(16, 24)
        Me._obBotones_0.Name = "_obBotones_0"
        Me._obBotones_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._obBotones_0.Size = New System.Drawing.Size(161, 25)
        Me._obBotones_0.TabIndex = 2
        Me._obBotones_0.TabStop = True
        Me._obBotones_0.Text = "0 - Onartu (0)"
        Me._obBotones_0.UseVisualStyleBackColor = False
        '
        'GBox2
        '
        Me.GBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GBox2.Controls.Add(Me._obIconos_4)
        Me.GBox2.Controls.Add(Me._obIconos_3)
        Me.GBox2.Controls.Add(Me._obIconos_2)
        Me.GBox2.Controls.Add(Me._obIconos_1)
        Me.GBox2.Controls.Add(Me._obIconos_0)
        Me.GBox2.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GBox2.Location = New System.Drawing.Point(399, 96)
        Me.GBox2.Name = "GBox2"
        Me.GBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GBox2.Size = New System.Drawing.Size(250, 225)
        Me.GBox2.TabIndex = 0
        Me.GBox2.TabStop = False
        Me.GBox2.Text = "Ikonoak"
        '
        '_obIconos_4
        '
        Me._obIconos_4.BackColor = System.Drawing.SystemColors.Control
        Me._obIconos_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._obIconos_4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._obIconos_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._obIconos_4.Location = New System.Drawing.Point(8, 152)
        Me._obIconos_4.Name = "_obIconos_4"
        Me._obIconos_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._obIconos_4.Size = New System.Drawing.Size(192, 25)
        Me._obIconos_4.TabIndex = 12
        Me._obIconos_4.TabStop = True
        Me._obIconos_4.Text = "4 - INFORMAZIOA (64)"
        Me._obIconos_4.UseVisualStyleBackColor = False
        '
        '_obIconos_3
        '
        Me._obIconos_3.BackColor = System.Drawing.SystemColors.Control
        Me._obIconos_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._obIconos_3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._obIconos_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._obIconos_3.Location = New System.Drawing.Point(8, 120)
        Me._obIconos_3.Name = "_obIconos_3"
        Me._obIconos_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._obIconos_3.Size = New System.Drawing.Size(242, 25)
        Me._obIconos_3.TabIndex = 11
        Me._obIconos_3.TabStop = True
        Me._obIconos_3.Text = "3 - HARRIDURA-MARKA (48)"
        Me._obIconos_3.UseVisualStyleBackColor = False
        '
        '_obIconos_2
        '
        Me._obIconos_2.BackColor = System.Drawing.SystemColors.Control
        Me._obIconos_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._obIconos_2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._obIconos_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._obIconos_2.Location = New System.Drawing.Point(8, 88)
        Me._obIconos_2.Name = "_obIconos_2"
        Me._obIconos_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._obIconos_2.Size = New System.Drawing.Size(216, 25)
        Me._obIconos_2.TabIndex = 10
        Me._obIconos_2.TabStop = True
        Me._obIconos_2.Text = "2- GALDERA-MARKA  (32)"
        Me._obIconos_2.UseVisualStyleBackColor = False
        '
        '_obIconos_1
        '
        Me._obIconos_1.BackColor = System.Drawing.SystemColors.Control
        Me._obIconos_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._obIconos_1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._obIconos_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._obIconos_1.Location = New System.Drawing.Point(8, 56)
        Me._obIconos_1.Name = "_obIconos_1"
        Me._obIconos_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._obIconos_1.Size = New System.Drawing.Size(120, 25)
        Me._obIconos_1.TabIndex = 9
        Me._obIconos_1.TabStop = True
        Me._obIconos_1.Text = "1 - STOP (16)"
        Me._obIconos_1.UseVisualStyleBackColor = False
        '
        '_obIconos_0
        '
        Me._obIconos_0.BackColor = System.Drawing.SystemColors.Control
        Me._obIconos_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._obIconos_0.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._obIconos_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._obIconos_0.Location = New System.Drawing.Point(8, 24)
        Me._obIconos_0.Name = "_obIconos_0"
        Me._obIconos_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._obIconos_0.Size = New System.Drawing.Size(136, 25)
        Me._obIconos_0.TabIndex = 8
        Me._obIconos_0.TabStop = True
        Me._obIconos_0.Text = "0 - Ikono barik"
        Me._obIconos_0.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(93, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(202, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Val erabiltzeko, lehenengo karakterea zenbaki bat izan behar da."
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(22, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 20)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "2 GroupBox"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(7, 368)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 25)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Label.Autosize=False"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(768, 578)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.Frame3)
        Me.Controls.Add(Me.Text1)
        Me.Controls.Add(Me.GBox1)
        Me.Controls.Add(Me.GBox2)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(4, 23)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Funcion MsgBox"
        Me.Frame3.ResumeLayout(False)
        Me.Frame3.PerformLayout()
        Me.GBox1.ResumeLayout(False)
        Me.GBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region
#Region "Soporte para la actualización "
    Private Shared m_vb6FormDefInstance As Form1
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As Form1
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New Form1
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As Form1)
            m_vb6FormDefInstance = Value
        End Set
    End Property
#End Region
    Dim boton, icono As Integer
    Private Sub _obBotonesXX_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _obBotones_0.CheckedChanged, _obBotones_1.CheckedChanged, _obBotones_2.CheckedChanged, _obBotones_3.CheckedChanged, _obBotones_4.CheckedChanged, _obBotones_5.CheckedChanged
        boton = Val(sender.text)
    End Sub

    Private Sub _obIconos_0_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _obIconos_0.CheckedChanged, _obIconos_1.CheckedChanged, _obIconos_2.CheckedChanged, _obIconos_3.CheckedChanged, _obIconos_4.CheckedChanged
        icono = Val(sender.text) * 16
    End Sub

    Private Sub btnMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostrar.Click
        MsgBox(Me.txtMensaje.Text, boton + icono, Me.txtTitulo.Text)
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
        'Application.exit
    End Sub

    Private Sub Text1_TextChanged(sender As Object, e As EventArgs) Handles Text1.TextChanged

    End Sub
End Class