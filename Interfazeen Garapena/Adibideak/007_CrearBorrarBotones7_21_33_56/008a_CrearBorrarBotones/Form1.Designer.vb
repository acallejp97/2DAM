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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.txtiva = New System.Windows.Forms.TextBox()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.lbliva = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.btn33 = New System.Windows.Forms.Button()
        Me.btn21 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(27, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(216, 37)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "USABILIDAD"
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(240, 278)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(103, 33)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(452, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Enabled=False"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(452, 217)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Enabled=False"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(312, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Menu Ver / Orden de Tabulación"
        '
        'txttotal
        '
        Me.txttotal.Enabled = False
        Me.txttotal.Location = New System.Drawing.Point(302, 214)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(144, 20)
        Me.txttotal.TabIndex = 2
        Me.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtiva
        '
        Me.txtiva.Enabled = False
        Me.txtiva.Location = New System.Drawing.Point(302, 174)
        Me.txtiva.Name = "txtiva"
        Me.txtiva.Size = New System.Drawing.Size(144, 20)
        Me.txtiva.TabIndex = 1
        Me.txtiva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(302, 134)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(144, 20)
        Me.txtcantidad.TabIndex = 0
        Me.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbltotal
        '
        Me.lbltotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbltotal.Location = New System.Drawing.Point(222, 214)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(64, 24)
        Me.lbltotal.TabIndex = 25
        Me.lbltotal.Text = "Total"
        '
        'lbliva
        '
        Me.lbliva.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbliva.Location = New System.Drawing.Point(222, 174)
        Me.lbliva.Name = "lbliva"
        Me.lbliva.Size = New System.Drawing.Size(64, 24)
        Me.lbliva.TabIndex = 24
        '
        'lblCantidad
        '
        Me.lblCantidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCantidad.Location = New System.Drawing.Point(222, 134)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(64, 24)
        Me.lblCantidad.TabIndex = 6
        Me.lblCantidad.Text = "Cantidad"
        '
        'btn33
        '
        Me.btn33.Location = New System.Drawing.Point(38, 214)
        Me.btn33.Name = "btn33"
        Me.btn33.Size = New System.Drawing.Size(120, 40)
        Me.btn33.TabIndex = 5
        Me.btn33.Text = "33%"
        '
        'btn21
        '
        Me.btn21.Location = New System.Drawing.Point(38, 158)
        Me.btn21.Name = "btn21"
        Me.btn21.Size = New System.Drawing.Size(120, 40)
        Me.btn21.TabIndex = 4
        Me.btn21.Text = "21%"
        '
        'btn7
        '
        Me.btn7.Location = New System.Drawing.Point(38, 102)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(120, 40)
        Me.btn7.TabIndex = 3
        Me.btn7.Text = "7%"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 367)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.txtiva)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.lbliva)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.btn33)
        Me.Controls.Add(Me.btn21)
        Me.Controls.Add(Me.btn7)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents txtiva As System.Windows.Forms.TextBox
    Friend WithEvents txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents lbliva As System.Windows.Forms.Label
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents btn33 As System.Windows.Forms.Button
    Friend WithEvents btn21 As System.Windows.Forms.Button
    Friend WithEvents btn7 As System.Windows.Forms.Button

End Class
