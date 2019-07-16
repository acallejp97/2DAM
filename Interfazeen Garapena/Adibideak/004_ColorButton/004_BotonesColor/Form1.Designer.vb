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
        Me.btnMensaje = New System.Windows.Forms.Button()
        Me.btnRojo = New System.Windows.Forms.Button()
        Me.btnVerde = New System.Windows.Forms.Button()
        Me.btnAzul = New System.Windows.Forms.Button()
        Me.btnRestablecer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnMensaje
        '
        Me.btnMensaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMensaje.ForeColor = System.Drawing.Color.Blue
        Me.btnMensaje.Location = New System.Drawing.Point(39, 34)
        Me.btnMensaje.Name = "btnMensaje"
        Me.btnMensaje.Size = New System.Drawing.Size(136, 31)
        Me.btnMensaje.TabIndex = 0
        Me.btnMensaje.Text = "Mezua"
        Me.btnMensaje.UseVisualStyleBackColor = True
        '
        'btnRojo
        '
        Me.btnRojo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRojo.Location = New System.Drawing.Point(39, 94)
        Me.btnRojo.Name = "btnRojo"
        Me.btnRojo.Size = New System.Drawing.Size(136, 31)
        Me.btnRojo.TabIndex = 1
        Me.btnRojo.Text = "Gorria"
        Me.btnRojo.UseVisualStyleBackColor = True
        '
        'btnVerde
        '
        Me.btnVerde.Location = New System.Drawing.Point(39, 154)
        Me.btnVerde.Name = "btnVerde"
        Me.btnVerde.Size = New System.Drawing.Size(136, 31)
        Me.btnVerde.TabIndex = 2
        Me.btnVerde.Text = "Berdea"
        Me.btnVerde.UseVisualStyleBackColor = True
        '
        'btnAzul
        '
        Me.btnAzul.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAzul.Location = New System.Drawing.Point(39, 210)
        Me.btnAzul.Name = "btnAzul"
        Me.btnAzul.Size = New System.Drawing.Size(136, 31)
        Me.btnAzul.TabIndex = 3
        Me.btnAzul.Text = "Urdina"
        Me.btnAzul.UseVisualStyleBackColor = True
        '
        'btnRestablecer
        '
        Me.btnRestablecer.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnRestablecer.Location = New System.Drawing.Point(210, 146)
        Me.btnRestablecer.Name = "btnRestablecer"
        Me.btnRestablecer.Size = New System.Drawing.Size(107, 46)
        Me.btnRestablecer.TabIndex = 5
        Me.btnRestablecer.Text = "Koloreak berriz hasi"
        Me.btnRestablecer.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 300)
        Me.Controls.Add(Me.btnRestablecer)
        Me.Controls.Add(Me.btnAzul)
        Me.Controls.Add(Me.btnVerde)
        Me.Controls.Add(Me.btnRojo)
        Me.Controls.Add(Me.btnMensaje)
        Me.Name = "Form1"
        Me.Text = "Form1nnnggg"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnMensaje As System.Windows.Forms.Button
    Friend WithEvents btnRojo As System.Windows.Forms.Button
    Friend WithEvents btnVerde As System.Windows.Forms.Button
    Friend WithEvents btnAzul As System.Windows.Forms.Button
    Friend WithEvents btnRestablecer As System.Windows.Forms.Button

End Class
