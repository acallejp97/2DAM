<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventario
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
        Me.gbCritBusqInventa = New System.Windows.Forms.GroupBox()
        Me.cbEstadoIncidencias = New System.Windows.Forms.ComboBox()
        Me.cbAulaIncidencias = New System.Windows.Forms.ComboBox()
        Me.tbHZequipoInventario = New System.Windows.Forms.TextBox()
        Me.cbArrancaIncidencias = New System.Windows.Forms.ComboBox()
        Me.cbPabellonIncidencias = New System.Windows.Forms.ComboBox()
        Me.tbIDIncidencias = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnNuevoEquipo = New System.Windows.Forms.Button()
        Me.btnSalirIncidencias = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.gbCritBusqInventa.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbCritBusqInventa
        '
        Me.gbCritBusqInventa.Controls.Add(Me.cbEstadoIncidencias)
        Me.gbCritBusqInventa.Controls.Add(Me.cbAulaIncidencias)
        Me.gbCritBusqInventa.Controls.Add(Me.tbHZequipoInventario)
        Me.gbCritBusqInventa.Controls.Add(Me.cbArrancaIncidencias)
        Me.gbCritBusqInventa.Controls.Add(Me.cbPabellonIncidencias)
        Me.gbCritBusqInventa.Controls.Add(Me.tbIDIncidencias)
        Me.gbCritBusqInventa.Controls.Add(Me.Label6)
        Me.gbCritBusqInventa.Controls.Add(Me.Label5)
        Me.gbCritBusqInventa.Controls.Add(Me.Label4)
        Me.gbCritBusqInventa.Controls.Add(Me.Label3)
        Me.gbCritBusqInventa.Controls.Add(Me.Label2)
        Me.gbCritBusqInventa.Controls.Add(Me.Label1)
        Me.gbCritBusqInventa.Location = New System.Drawing.Point(30, 37)
        Me.gbCritBusqInventa.Name = "gbCritBusqInventa"
        Me.gbCritBusqInventa.Size = New System.Drawing.Size(484, 205)
        Me.gbCritBusqInventa.TabIndex = 0
        Me.gbCritBusqInventa.TabStop = False
        Me.gbCritBusqInventa.Text = "Criterios de Busqueda"
        '
        'cbEstadoIncidencias
        '
        Me.cbEstadoIncidencias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstadoIncidencias.FormattingEnabled = True
        Me.cbEstadoIncidencias.Items.AddRange(New Object() {"Alta", "Baja"})
        Me.cbEstadoIncidencias.Location = New System.Drawing.Point(304, 124)
        Me.cbEstadoIncidencias.Name = "cbEstadoIncidencias"
        Me.cbEstadoIncidencias.Size = New System.Drawing.Size(121, 21)
        Me.cbEstadoIncidencias.TabIndex = 11
        '
        'cbAulaIncidencias
        '
        Me.cbAulaIncidencias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAulaIncidencias.FormattingEnabled = True
        Me.cbAulaIncidencias.Location = New System.Drawing.Point(304, 93)
        Me.cbAulaIncidencias.Name = "cbAulaIncidencias"
        Me.cbAulaIncidencias.Size = New System.Drawing.Size(121, 21)
        Me.cbAulaIncidencias.TabIndex = 10
        '
        'tbHZequipoInventario
        '
        Me.tbHZequipoInventario.Location = New System.Drawing.Point(304, 54)
        Me.tbHZequipoInventario.Name = "tbHZequipoInventario"
        Me.tbHZequipoInventario.Size = New System.Drawing.Size(121, 20)
        Me.tbHZequipoInventario.TabIndex = 9
        '
        'cbArrancaIncidencias
        '
        Me.cbArrancaIncidencias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbArrancaIncidencias.FormattingEnabled = True
        Me.cbArrancaIncidencias.Items.AddRange(New Object() {"Si", "No"})
        Me.cbArrancaIncidencias.Location = New System.Drawing.Point(96, 121)
        Me.cbArrancaIncidencias.Name = "cbArrancaIncidencias"
        Me.cbArrancaIncidencias.Size = New System.Drawing.Size(121, 21)
        Me.cbArrancaIncidencias.TabIndex = 8
        '
        'cbPabellonIncidencias
        '
        Me.cbPabellonIncidencias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPabellonIncidencias.FormattingEnabled = True
        Me.cbPabellonIncidencias.Location = New System.Drawing.Point(97, 87)
        Me.cbPabellonIncidencias.Name = "cbPabellonIncidencias"
        Me.cbPabellonIncidencias.Size = New System.Drawing.Size(121, 21)
        Me.cbPabellonIncidencias.TabIndex = 7
        '
        'tbIDIncidencias
        '
        Me.tbIDIncidencias.Location = New System.Drawing.Point(97, 58)
        Me.tbIDIncidencias.Name = "tbIDIncidencias"
        Me.tbIDIncidencias.Size = New System.Drawing.Size(100, 20)
        Me.tbIDIncidencias.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(255, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Estado:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(267, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Aula:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(238, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "HZ equipo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Arranca:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Pabellón:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID:"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(202, 264)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(300, 264)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 2
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnNuevoEquipo
        '
        Me.btnNuevoEquipo.Location = New System.Drawing.Point(397, 264)
        Me.btnNuevoEquipo.Name = "btnNuevoEquipo"
        Me.btnNuevoEquipo.Size = New System.Drawing.Size(117, 23)
        Me.btnNuevoEquipo.TabIndex = 3
        Me.btnNuevoEquipo.Text = "Nuevo Equipo"
        Me.btnNuevoEquipo.UseVisualStyleBackColor = True
        '
        'btnSalirIncidencias
        '
        Me.btnSalirIncidencias.Location = New System.Drawing.Point(439, 503)
        Me.btnSalirIncidencias.Name = "btnSalirIncidencias"
        Me.btnSalirIncidencias.Size = New System.Drawing.Size(75, 23)
        Me.btnSalirIncidencias.TabIndex = 5
        Me.btnSalirIncidencias.Text = "Salir"
        Me.btnSalirIncidencias.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(30, 293)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(484, 232)
        Me.DataGridView1.TabIndex = 6
        '
        'Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(553, 550)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnSalirIncidencias)
        Me.Controls.Add(Me.btnNuevoEquipo)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.gbCritBusqInventa)
        Me.Name = "Inventario"
        Me.Text = "Inventario"
        Me.gbCritBusqInventa.ResumeLayout(False)
        Me.gbCritBusqInventa.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbCritBusqInventa As System.Windows.Forms.GroupBox
    Friend WithEvents cbEstadoIncidencias As System.Windows.Forms.ComboBox
    Friend WithEvents cbAulaIncidencias As System.Windows.Forms.ComboBox
    Friend WithEvents tbHZequipoInventario As System.Windows.Forms.TextBox
    Friend WithEvents cbArrancaIncidencias As System.Windows.Forms.ComboBox
    Friend WithEvents cbPabellonIncidencias As System.Windows.Forms.ComboBox
    Friend WithEvents tbIDIncidencias As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnNuevoEquipo As System.Windows.Forms.Button
    Friend WithEvents btnSalirIncidencias As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView

End Class
