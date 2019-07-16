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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NorthwindDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NorthwindDataSet = New Consultas_y_demas_BD.NorthwindDataSet()
        Me.btn_Consulta = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.updateCampos = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.contar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_insertar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_empresa = New System.Windows.Forms.TextBox()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_idBorrar = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_idSelec = New System.Windows.Forms.TextBox()
        Me.btn_Selec_Custom = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btn_selec_normal = New System.Windows.Forms.Button()
        Me.combobox = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox_llenarDireccion = New System.Windows.Forms.TextBox()
        Me.txt_llenarCiudad = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.NorthwindDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NorthwindDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NorthwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.NorthwindDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(1, 271)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1148, 206)
        Me.DataGridView1.TabIndex = 0
        '
        'NorthwindDataSetBindingSource
        '
        Me.NorthwindDataSetBindingSource.DataSource = Me.NorthwindDataSet
        Me.NorthwindDataSetBindingSource.Position = 0
        '
        'NorthwindDataSet
        '
        Me.NorthwindDataSet.DataSetName = "NorthwindDataSet"
        Me.NorthwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btn_Consulta
        '
        Me.btn_Consulta.Location = New System.Drawing.Point(41, 51)
        Me.btn_Consulta.Name = "btn_Consulta"
        Me.btn_Consulta.Size = New System.Drawing.Size(75, 23)
        Me.btn_Consulta.TabIndex = 1
        Me.btn_Consulta.Text = "Consulta"
        Me.btn_Consulta.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Carga el Gridview"
        '
        'updateCampos
        '
        Me.updateCampos.Location = New System.Drawing.Point(27, 148)
        Me.updateCampos.Name = "updateCampos"
        Me.updateCampos.Size = New System.Drawing.Size(121, 23)
        Me.updateCampos.TabIndex = 3
        Me.updateCampos.Text = "UpdateClick"
        Me.updateCampos.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(213, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Update cambiando las cosas desde la tabla"
        '
        'contar
        '
        Me.contar.Location = New System.Drawing.Point(199, 51)
        Me.contar.Name = "contar"
        Me.contar.Size = New System.Drawing.Size(75, 23)
        Me.contar.TabIndex = 5
        Me.contar.Text = "contar"
        Me.contar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(196, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Contar cuantos hay"
        '
        'btn_insertar
        '
        Me.btn_insertar.Location = New System.Drawing.Point(388, 113)
        Me.btn_insertar.Name = "btn_insertar"
        Me.btn_insertar.Size = New System.Drawing.Size(75, 23)
        Me.btn_insertar.TabIndex = 7
        Me.btn_insertar.Text = "Insertar"
        Me.btn_insertar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(361, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Insertar con parametros"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(361, 61)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(21, 13)
        Me.label5.TabIndex = 9
        Me.label5.Text = "ID:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(334, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Empresa"
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(388, 58)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(100, 20)
        Me.txt_id.TabIndex = 11
        '
        'txt_empresa
        '
        Me.txt_empresa.Location = New System.Drawing.Point(388, 87)
        Me.txt_empresa.Name = "txt_empresa"
        Me.txt_empresa.Size = New System.Drawing.Size(100, 20)
        Me.txt_empresa.TabIndex = 12
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(576, 113)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_eliminar.TabIndex = 13
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(547, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Eliminar con parametros"
        '
        'txt_idBorrar
        '
        Me.txt_idBorrar.Location = New System.Drawing.Point(566, 73)
        Me.txt_idBorrar.Name = "txt_idBorrar"
        Me.txt_idBorrar.Size = New System.Drawing.Size(100, 20)
        Me.txt_idBorrar.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(539, 76)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "ID:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1161, 24)
        Me.MenuStrip1.TabIndex = 17
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(736, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(165, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Un select custom con parametros"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(736, 76)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(21, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "ID:"
        '
        'txt_idSelec
        '
        Me.txt_idSelec.Location = New System.Drawing.Point(763, 69)
        Me.txt_idSelec.Name = "txt_idSelec"
        Me.txt_idSelec.Size = New System.Drawing.Size(100, 20)
        Me.txt_idSelec.TabIndex = 20
        '
        'btn_Selec_Custom
        '
        Me.btn_Selec_Custom.Location = New System.Drawing.Point(763, 113)
        Me.btn_Selec_Custom.Name = "btn_Selec_Custom"
        Me.btn_Selec_Custom.Size = New System.Drawing.Size(75, 23)
        Me.btn_Selec_Custom.TabIndex = 21
        Me.btn_Selec_Custom.Text = "Selec Custom"
        Me.btn_Selec_Custom.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(934, 35)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(123, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Un select sin parametros"
        '
        'btn_selec_normal
        '
        Me.btn_selec_normal.Location = New System.Drawing.Point(955, 67)
        Me.btn_selec_normal.Name = "btn_selec_normal"
        Me.btn_selec_normal.Size = New System.Drawing.Size(75, 23)
        Me.btn_selec_normal.TabIndex = 23
        Me.btn_selec_normal.Text = "Selec Custom"
        Me.btn_selec_normal.UseVisualStyleBackColor = True
        '
        'combobox
        '
        Me.combobox.FormattingEnabled = True
        Me.combobox.Location = New System.Drawing.Point(41, 219)
        Me.combobox.Name = "combobox"
        Me.combobox.Size = New System.Drawing.Size(121, 21)
        Me.combobox.TabIndex = 24
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(41, 200)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(174, 13)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "llenar combobox, lo hace en el load"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(265, 200)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(368, 13)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Una vez que hayas seleccionado algo del texbox saldran algunos datos aqui"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(265, 222)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 13)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Direccion"
        '
        'TextBox_llenarDireccion
        '
        Me.TextBox_llenarDireccion.Location = New System.Drawing.Point(324, 219)
        Me.TextBox_llenarDireccion.Name = "TextBox_llenarDireccion"
        Me.TextBox_llenarDireccion.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_llenarDireccion.TabIndex = 28
        '
        'txt_llenarCiudad
        '
        Me.txt_llenarCiudad.Location = New System.Drawing.Point(508, 222)
        Me.txt_llenarCiudad.Name = "txt_llenarCiudad"
        Me.txt_llenarCiudad.Size = New System.Drawing.Size(100, 20)
        Me.txt_llenarCiudad.TabIndex = 30
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(449, 225)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 13)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Ciudad"
        '
        'NorthwindDataSet1
        '
        '
        'NorthwindDataSet1BindingSource
        '
        Me.NorthwindDataSet1BindingSource.Position = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1161, 489)
        Me.Controls.Add(Me.txt_llenarCiudad)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TextBox_llenarDireccion)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.combobox)
        Me.Controls.Add(Me.btn_selec_normal)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btn_Selec_Custom)
        Me.Controls.Add(Me.txt_idSelec)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_idBorrar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.txt_empresa)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_insertar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.contar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.updateCampos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_Consulta)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NorthwindDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NorthwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.NorthwindDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btn_Consulta As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents updateCampos As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents contar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_insertar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents txt_empresa As System.Windows.Forms.TextBox
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_idBorrar As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_idSelec As System.Windows.Forms.TextBox
    Friend WithEvents btn_Selec_Custom As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btn_selec_normal As System.Windows.Forms.Button
    Friend WithEvents combobox As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TextBox_llenarDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txt_llenarCiudad As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents NorthwindDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NorthwindDataSet As Consultas_y_demas_BD.NorthwindDataSet
    Friend WithEvents NorthwindDataSet1BindingSource As System.Windows.Forms.BindingSource

End Class
