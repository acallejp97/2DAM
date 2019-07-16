<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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

    'Requerido por el Dise�ador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Dise�ador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Dise�ador de Windows Forms.  
    'No lo modifique con el editor de c�digo.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbOsagaiak = New System.Windows.Forms.ListBox()
        Me.lbtotal = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBatSartu = New System.Windows.Forms.Button()
        Me.btnBatKendu = New System.Windows.Forms.Button()
        Me.btnGuztiaSartu = New System.Windows.Forms.Button()
        Me.btnGuztiaKendu = New System.Windows.Forms.Button()
        Me.btnOnartu = New System.Windows.Forms.Button()
        Me.tbEntsalada = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbTotala = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout
        '
        'lbOsagaiak
        '
        Me.lbOsagaiak.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbOsagaiak.FormattingEnabled = true
        Me.lbOsagaiak.ItemHeight = 16
        Me.lbOsagaiak.Location = New System.Drawing.Point(64, 92)
        Me.lbOsagaiak.Name = "lbOsagaiak"
        Me.lbOsagaiak.Size = New System.Drawing.Size(120, 180)
        Me.lbOsagaiak.TabIndex = 0
        '
        'lbtotal
        '
        Me.lbtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbtotal.FormattingEnabled = true
        Me.lbtotal.ItemHeight = 16
        Me.lbtotal.Location = New System.Drawing.Point(324, 92)
        Me.lbtotal.Name = "lbtotal"
        Me.lbtotal.Size = New System.Drawing.Size(120, 180)
        Me.lbtotal.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Osagaiak"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(321, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Entsalada"
        '
        'btnBatSartu
        '
        Me.btnBatSartu.Location = New System.Drawing.Point(219, 136)
        Me.btnBatSartu.Name = "btnBatSartu"
        Me.btnBatSartu.Size = New System.Drawing.Size(72, 34)
        Me.btnBatSartu.TabIndex = 6
        Me.btnBatSartu.Text = ">"
        Me.btnBatSartu.UseVisualStyleBackColor = True
        '
        'btnBatKendu
        '
        Me.btnBatKendu.Location = New System.Drawing.Point(219, 192)
        Me.btnBatKendu.Name = "btnBatKendu"
        Me.btnBatKendu.Size = New System.Drawing.Size(72, 34)
        Me.btnBatKendu.TabIndex = 7
        Me.btnBatKendu.Text = "<"
        Me.btnBatKendu.UseVisualStyleBackColor = True
        '
        'btnGuztiaSartu
        '
        Me.btnGuztiaSartu.Location = New System.Drawing.Point(219, 92)
        Me.btnGuztiaSartu.Name = "btnGuztiaSartu"
        Me.btnGuztiaSartu.Size = New System.Drawing.Size(72, 34)
        Me.btnGuztiaSartu.TabIndex = 8
        Me.btnGuztiaSartu.Text = ">>"
        Me.btnGuztiaSartu.UseVisualStyleBackColor = True
        '
        'btnGuztiaKendu
        '
        Me.btnGuztiaKendu.Location = New System.Drawing.Point(219, 238)
        Me.btnGuztiaKendu.Name = "btnGuztiaKendu"
        Me.btnGuztiaKendu.Size = New System.Drawing.Size(72, 34)
        Me.btnGuztiaKendu.TabIndex = 9
        Me.btnGuztiaKendu.Text = "<<"
        Me.btnGuztiaKendu.UseVisualStyleBackColor = True
        '
        'btnOnartu
        '
        Me.btnOnartu.BackColor = System.Drawing.Color.Lime
        Me.btnOnartu.Location = New System.Drawing.Point(324, 433)
        Me.btnOnartu.Name = "btnOnartu"
        Me.btnOnartu.Size = New System.Drawing.Size(120, 34)
        Me.btnOnartu.TabIndex = 10
        Me.btnOnartu.Text = "Onartu"
        Me.btnOnartu.UseVisualStyleBackColor = False
        '
        'tbEntsalada
        '
        Me.tbEntsalada.Enabled = False
        Me.tbEntsalada.Location = New System.Drawing.Point(321, 323)
        Me.tbEntsalada.Name = "tbEntsalada"
        Me.tbEntsalada.Size = New System.Drawing.Size(103, 20)
        Me.tbEntsalada.TabIndex = 11
        Me.tbEntsalada.Text = "6.00€"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(318, 307)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Entsaladaren prezioa"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Enabled = False
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(321, 360)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 24)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Totala"
        '
        'tbTotala
        '
        Me.tbTotala.Enabled = False
        Me.tbTotala.Location = New System.Drawing.Point(321, 385)
        Me.tbTotala.Name = "tbTotala"
        Me.tbTotala.Size = New System.Drawing.Size(100, 20)
        Me.tbTotala.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(286, 25)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Gehitu osagaiak entsaladari:"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 487)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbTotala)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbEntsalada)
        Me.Controls.Add(Me.btnOnartu)
        Me.Controls.Add(Me.btnGuztiaKendu)
        Me.Controls.Add(Me.btnGuztiaSartu)
        Me.Controls.Add(Me.btnBatKendu)
        Me.Controls.Add(Me.btnBatSartu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbtotal)
        Me.Controls.Add(Me.lbOsagaiak)
        Me.Name = "Form2"
        Me.Text = "Entsalada"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents lbOsagaiak As System.Windows.Forms.ListBox
    Friend WithEvents lbtotal As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnBatSartu As System.Windows.Forms.Button
    Friend WithEvents btnBatKendu As System.Windows.Forms.Button
    Friend WithEvents btnGuztiaSartu As System.Windows.Forms.Button
    Friend WithEvents btnGuztiaKendu As System.Windows.Forms.Button
    Friend WithEvents btnOnartu As System.Windows.Forms.Button
    Friend WithEvents tbEntsalada As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbTotala As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class

