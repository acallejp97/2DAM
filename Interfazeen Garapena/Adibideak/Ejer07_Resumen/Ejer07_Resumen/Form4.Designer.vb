<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnGuardarXML = New System.Windows.Forms.Button()
        Me.btnVerXML = New System.Windows.Forms.Button()
        Me.btnCargarXML = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(45, 174)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(550, 169)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(281, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "OleDbCommandBuilder"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(45, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 35)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Cargar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(45, 51)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(139, 35)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Añadir X"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(45, 92)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(139, 35)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Eliminar X"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(45, 133)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(139, 35)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Update"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(384, 108)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(211, 35)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "VER COMANDOS"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'btnGuardarXML
        '
        Me.btnGuardarXML.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarXML.Location = New System.Drawing.Point(45, 349)
        Me.btnGuardarXML.Name = "btnGuardarXML"
        Me.btnGuardarXML.Size = New System.Drawing.Size(211, 35)
        Me.btnGuardarXML.TabIndex = 7
        Me.btnGuardarXML.Text = "Guardar XML"
        Me.btnGuardarXML.UseVisualStyleBackColor = True
        '
        'btnVerXML
        '
        Me.btnVerXML.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerXML.Location = New System.Drawing.Point(306, 349)
        Me.btnVerXML.Name = "btnVerXML"
        Me.btnVerXML.Size = New System.Drawing.Size(211, 35)
        Me.btnVerXML.TabIndex = 8
        Me.btnVerXML.Text = "Ver XML"
        Me.btnVerXML.UseVisualStyleBackColor = True
        '
        'btnCargarXML
        '
        Me.btnCargarXML.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargarXML.Location = New System.Drawing.Point(202, 431)
        Me.btnCargarXML.Name = "btnCargarXML"
        Me.btnCargarXML.Size = New System.Drawing.Size(298, 35)
        Me.btnCargarXML.TabIndex = 9
        Me.btnCargarXML.Text = "2.- Cargar Dataset del XML"
        Me.btnCargarXML.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(202, 390)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(211, 35)
        Me.Button6.TabIndex = 10
        Me.Button6.Text = "1.- Borrar Dataset"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(286, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "SELECT * FROM Shippers"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(190, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(278, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Gehitu X/Kendu X 2.zutabean eta db-an gorde aldaketak"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 493)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.btnCargarXML)
        Me.Controls.Add(Me.btnVerXML)
        Me.Controls.Add(Me.btnGuardarXML)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents btnGuardarXML As System.Windows.Forms.Button
    Friend WithEvents btnVerXML As System.Windows.Forms.Button
    Friend WithEvents btnCargarXML As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
