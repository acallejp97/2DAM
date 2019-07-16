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
        Me.btnMsgbox1 = New System.Windows.Forms.Button()
        Me.btnMsgbox2 = New System.Windows.Forms.Button()
        Me.btnInputbox = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnMsgbox1
        '
        Me.btnMsgbox1.Location = New System.Drawing.Point(41, 39)
        Me.btnMsgbox1.Name = "btnMsgbox1"
        Me.btnMsgbox1.Size = New System.Drawing.Size(225, 47)
        Me.btnMsgbox1.TabIndex = 0
        Me.btnMsgbox1.Text = "MSGBOX BAI/EZ"
        Me.btnMsgbox1.UseVisualStyleBackColor = True
        '
        'btnMsgbox2
        '
        Me.btnMsgbox2.Location = New System.Drawing.Point(41, 129)
        Me.btnMsgbox2.Name = "btnMsgbox2"
        Me.btnMsgbox2.Size = New System.Drawing.Size(225, 51)
        Me.btnMsgbox2.TabIndex = 1
        Me.btnMsgbox2.Text = "MSGBOX  BAI/EZ/EZEZTATU"
        Me.btnMsgbox2.UseVisualStyleBackColor = True
        '
        'btnInputbox
        '
        Me.btnInputbox.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnInputbox.Location = New System.Drawing.Point(41, 227)
        Me.btnInputbox.Name = "btnInputbox"
        Me.btnInputbox.Size = New System.Drawing.Size(225, 50)
        Me.btnInputbox.TabIndex = 2
        Me.btnInputbox.Text = "INPUTBOX"
        Me.btnInputbox.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.btnMsgbox1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnInputbox
        Me.ClientSize = New System.Drawing.Size(434, 354)
        Me.Controls.Add(Me.btnInputbox)
        Me.Controls.Add(Me.btnMsgbox2)
        Me.Controls.Add(Me.btnMsgbox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnMsgbox1 As System.Windows.Forms.Button
    Friend WithEvents btnMsgbox2 As System.Windows.Forms.Button
    Friend WithEvents btnInputbox As System.Windows.Forms.Button

End Class
