<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnUnoDcha = New System.Windows.Forms.Button()
        Me.btnUnoIzqda = New System.Windows.Forms.Button()
        Me.btnTodoDcha = New System.Windows.Forms.Button()
        Me.btnTodoIzqda = New System.Windows.Forms.Button()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(59, 48)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 180)
        Me.ListBox1.TabIndex = 0
        '
        'ListBox2
        '
        Me.ListBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 16
        Me.ListBox2.Location = New System.Drawing.Point(319, 48)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(120, 180)
        Me.ListBox2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(319, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Label2"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(59, 247)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(120, 20)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(59, 282)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(120, 23)
        Me.btnAgregar.TabIndex = 5
        Me.btnAgregar.Text = "Gehitu"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnUnoDcha
        '
        Me.btnUnoDcha.Location = New System.Drawing.Point(214, 92)
        Me.btnUnoDcha.Name = "btnUnoDcha"
        Me.btnUnoDcha.Size = New System.Drawing.Size(72, 34)
        Me.btnUnoDcha.TabIndex = 6
        Me.btnUnoDcha.Text = ">"
        Me.btnUnoDcha.UseVisualStyleBackColor = True
        '
        'btnUnoIzqda
        '
        Me.btnUnoIzqda.Location = New System.Drawing.Point(214, 148)
        Me.btnUnoIzqda.Name = "btnUnoIzqda"
        Me.btnUnoIzqda.Size = New System.Drawing.Size(72, 34)
        Me.btnUnoIzqda.TabIndex = 7
        Me.btnUnoIzqda.Text = "<"
        Me.btnUnoIzqda.UseVisualStyleBackColor = True
        '
        'btnTodoDcha
        '
        Me.btnTodoDcha.Location = New System.Drawing.Point(214, 48)
        Me.btnTodoDcha.Name = "btnTodoDcha"
        Me.btnTodoDcha.Size = New System.Drawing.Size(72, 34)
        Me.btnTodoDcha.TabIndex = 8
        Me.btnTodoDcha.Text = ">>"
        Me.btnTodoDcha.UseVisualStyleBackColor = True
        '
        'btnTodoIzqda
        '
        Me.btnTodoIzqda.Location = New System.Drawing.Point(214, 194)
        Me.btnTodoIzqda.Name = "btnTodoIzqda"
        Me.btnTodoIzqda.Size = New System.Drawing.Size(72, 34)
        Me.btnTodoIzqda.TabIndex = 9
        Me.btnTodoIzqda.Text = "<<"
        Me.btnTodoIzqda.UseVisualStyleBackColor = True
        '
        'btnSort
        '
        Me.btnSort.Location = New System.Drawing.Point(322, 282)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(120, 34)
        Me.btnSort.TabIndex = 10
        Me.btnSort.Text = "Ordenatu"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 365)
        Me.Controls.Add(Me.btnSort)
        Me.Controls.Add(Me.btnTodoIzqda)
        Me.Controls.Add(Me.btnTodoDcha)
        Me.Controls.Add(Me.btnUnoIzqda)
        Me.Controls.Add(Me.btnUnoDcha)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnUnoDcha As System.Windows.Forms.Button
    Friend WithEvents btnUnoIzqda As System.Windows.Forms.Button
    Friend WithEvents btnTodoDcha As System.Windows.Forms.Button
    Friend WithEvents btnTodoIzqda As System.Windows.Forms.Button
    Friend WithEvents btnSort As System.Windows.Forms.Button

End Class
