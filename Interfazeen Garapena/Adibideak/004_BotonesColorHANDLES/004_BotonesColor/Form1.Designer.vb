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
        Me.btnMezua = New System.Windows.Forms.Button()
        Me.btnRojo = New System.Windows.Forms.Button()
        Me.btnVerde = New System.Windows.Forms.Button()
        Me.btnAzul = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRestablecer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnMezua
        '
        Me.btnMezua.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMezua.ForeColor = System.Drawing.Color.Blue
        Me.btnMezua.Location = New System.Drawing.Point(39, 34)
        Me.btnMezua.Name = "btnMezua"
        Me.btnMezua.Size = New System.Drawing.Size(136, 31)
        Me.btnMezua.TabIndex = 0
        Me.btnMezua.Text = "Mezua"
        Me.btnMezua.UseVisualStyleBackColor = True
        '
        'btnRojo
        '
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
        Me.btnAzul.Location = New System.Drawing.Point(39, 210)
        Me.btnAzul.Name = "btnAzul"
        Me.btnAzul.Size = New System.Drawing.Size(136, 31)
        Me.btnAzul.TabIndex = 3
        Me.btnAzul.Text = "Urdina"
        Me.btnAzul.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(191, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "FlatStyle=Flat"
        '
        'btnRestablecer
        '
        Me.btnRestablecer.AllowDrop = True
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
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAzul)
        Me.Controls.Add(Me.btnVerde)
        Me.Controls.Add(Me.btnRojo)
        Me.Controls.Add(Me.btnMezua)
        Me.Name = "Form1"
        Me.Text = "Form1nnnggg"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMezua As System.Windows.Forms.Button
    Friend WithEvents btnRojo As System.Windows.Forms.Button
    Friend WithEvents btnVerde As System.Windows.Forms.Button
    Friend WithEvents btnAzul As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnRestablecer As System.Windows.Forms.Button

End Class
