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
        Me.btnEjecutar = New System.Windows.Forms.Button()
        Me.lblDateDiff = New System.Windows.Forms.Label()
        Me.lblDatePart = New System.Windows.Forms.Label()
        Me.lbldateadd = New System.Windows.Forms.Label()
        Me.lbltimeofday = New System.Windows.Forms.Label()
        Me.lblToday = New System.Windows.Forms.Label()
        Me.lblNow = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnEjecutar
        '
        Me.btnEjecutar.Location = New System.Drawing.Point(315, 201)
        Me.btnEjecutar.Name = "btnEjecutar"
        Me.btnEjecutar.Size = New System.Drawing.Size(75, 23)
        Me.btnEjecutar.TabIndex = 36
        Me.btnEjecutar.Text = "&Ejecutar"
        Me.btnEjecutar.UseVisualStyleBackColor = True
        '
        'lblDateDiff
        '
        Me.lblDateDiff.BackColor = System.Drawing.Color.White
        Me.lblDateDiff.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDateDiff.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateDiff.Location = New System.Drawing.Point(132, 161)
        Me.lblDateDiff.Name = "lblDateDiff"
        Me.lblDateDiff.Size = New System.Drawing.Size(634, 19)
        Me.lblDateDiff.TabIndex = 35
        '
        'lblDatePart
        '
        Me.lblDatePart.BackColor = System.Drawing.Color.White
        Me.lblDatePart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDatePart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatePart.Location = New System.Drawing.Point(132, 135)
        Me.lblDatePart.Name = "lblDatePart"
        Me.lblDatePart.Size = New System.Drawing.Size(634, 19)
        Me.lblDatePart.TabIndex = 34
        '
        'lbldateadd
        '
        Me.lbldateadd.BackColor = System.Drawing.Color.White
        Me.lbldateadd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbldateadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldateadd.Location = New System.Drawing.Point(132, 109)
        Me.lbldateadd.Name = "lbldateadd"
        Me.lbldateadd.Size = New System.Drawing.Size(634, 19)
        Me.lbldateadd.TabIndex = 33
        '
        'lbltimeofday
        '
        Me.lbltimeofday.BackColor = System.Drawing.Color.White
        Me.lbltimeofday.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbltimeofday.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltimeofday.Location = New System.Drawing.Point(132, 83)
        Me.lbltimeofday.Name = "lbltimeofday"
        Me.lbltimeofday.Size = New System.Drawing.Size(634, 19)
        Me.lbltimeofday.TabIndex = 32
        '
        'lblToday
        '
        Me.lblToday.BackColor = System.Drawing.Color.White
        Me.lblToday.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblToday.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToday.Location = New System.Drawing.Point(132, 58)
        Me.lblToday.Name = "lblToday"
        Me.lblToday.Size = New System.Drawing.Size(634, 19)
        Me.lblToday.TabIndex = 31
        '
        'lblNow
        '
        Me.lblNow.BackColor = System.Drawing.Color.White
        Me.lblNow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNow.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNow.Location = New System.Drawing.Point(132, 32)
        Me.lblNow.Name = "lblNow"
        Me.lblNow.Size = New System.Drawing.Size(634, 19)
        Me.lblNow.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(54, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 19)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "DateDiff:"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(54, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 19)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "DatePart:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 19)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "DateAdd:"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 19)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "TimeOfDay:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(68, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 19)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Today:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(78, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 19)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Now:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 271)
        Me.Controls.Add(Me.btnEjecutar)
        Me.Controls.Add(Me.lblDateDiff)
        Me.Controls.Add(Me.lblDatePart)
        Me.Controls.Add(Me.lbldateadd)
        Me.Controls.Add(Me.lbltimeofday)
        Me.Controls.Add(Me.lblToday)
        Me.Controls.Add(Me.lblNow)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnEjecutar As System.Windows.Forms.Button
    Friend WithEvents lblDateDiff As System.Windows.Forms.Label
    Friend WithEvents lblDatePart As System.Windows.Forms.Label
    Friend WithEvents lbldateadd As System.Windows.Forms.Label
    Friend WithEvents lbltimeofday As System.Windows.Forms.Label
    Friend WithEvents lblToday As System.Windows.Forms.Label
    Friend WithEvents lblNow As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
