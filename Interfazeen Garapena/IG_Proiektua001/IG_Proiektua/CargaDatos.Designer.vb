<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CargaDatos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.ButtonCargarDatos = New System.Windows.Forms.Button()
        Me.ButtonExaminar = New System.Windows.Forms.Button()
        Me.TextBoxFichero = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonSalir)
        Me.GroupBox1.Controls.Add(Me.ButtonCargarDatos)
        Me.GroupBox1.Controls.Add(Me.ButtonExaminar)
        Me.GroupBox1.Controls.Add(Me.TextBoxFichero)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(537, 186)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Migración datos"
        '
        'ButtonSalir
        '
        Me.ButtonSalir.Location = New System.Drawing.Point(252, 144)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(90, 23)
        Me.ButtonSalir.TabIndex = 6
        Me.ButtonSalir.Text = "Salir"
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'ButtonCargarDatos
        '
        Me.ButtonCargarDatos.Enabled = False
        Me.ButtonCargarDatos.Location = New System.Drawing.Point(156, 144)
        Me.ButtonCargarDatos.Name = "ButtonCargarDatos"
        Me.ButtonCargarDatos.Size = New System.Drawing.Size(90, 23)
        Me.ButtonCargarDatos.TabIndex = 5
        Me.ButtonCargarDatos.Text = "Cargar Datos"
        Me.ButtonCargarDatos.UseVisualStyleBackColor = True
        '
        'ButtonExaminar
        '
        Me.ButtonExaminar.Location = New System.Drawing.Point(396, 94)
        Me.ButtonExaminar.Name = "ButtonExaminar"
        Me.ButtonExaminar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonExaminar.TabIndex = 4
        Me.ButtonExaminar.Text = "Examinar..."
        Me.ButtonExaminar.UseVisualStyleBackColor = True
        '
        'TextBoxFichero
        '
        Me.TextBoxFichero.Location = New System.Drawing.Point(156, 98)
        Me.TextBoxFichero.Name = "TextBoxFichero"
        Me.TextBoxFichero.Size = New System.Drawing.Size(233, 20)
        Me.TextBoxFichero.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(156, 45)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "* Fichero de carga:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha de carga:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(18, 208)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(531, 212)
        Me.ListBox1.TabIndex = 2
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(18, 427)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(0, 13)
        Me.lblEstado.TabIndex = 3
        '
        'CargaDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 452)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "CargaDatos"
        Me.Text = "CargaDatos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FileSystemWatcher1 As System.IO.FileSystemWatcher
    Friend WithEvents TextBoxFichero As System.Windows.Forms.TextBox
    Friend WithEvents ButtonExaminar As System.Windows.Forms.Button
    Friend WithEvents ButtonSalir As System.Windows.Forms.Button
    Friend WithEvents ButtonCargarDatos As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents lblEstado As System.Windows.Forms.Label
End Class
