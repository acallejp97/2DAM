<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menua
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menua))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OPCA1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OPCA2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OPcBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.B1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GruposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionAToolStripMenuItem, Me.OPcBToolStripMenuItem, Me.InventarioToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(837, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionAToolStripMenuItem
        '
        Me.OpcionAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OPCA1ToolStripMenuItem, Me.OPCA2ToolStripMenuItem})
        Me.OpcionAToolStripMenuItem.Name = "OpcionAToolStripMenuItem"
        Me.OpcionAToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.OpcionAToolStripMenuItem.Text = "Incidencias"
        '
        'OPCA1ToolStripMenuItem
        '
        Me.OPCA1ToolStripMenuItem.Name = "OPCA1ToolStripMenuItem"
        Me.OPCA1ToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.OPCA1ToolStripMenuItem.Text = "Gestión"
        '
        'OPCA2ToolStripMenuItem
        '
        Me.OPCA2ToolStripMenuItem.Name = "OPCA2ToolStripMenuItem"
        Me.OPCA2ToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.OPCA2ToolStripMenuItem.Text = "Carga Datos"
        '
        'OPcBToolStripMenuItem
        '
        Me.OPcBToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.B1ToolStripMenuItem, Me.GruposToolStripMenuItem})
        Me.OPcBToolStripMenuItem.Name = "OPcBToolStripMenuItem"
        Me.OPcBToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.OPcBToolStripMenuItem.Text = "Técnicos"
        '
        'B1ToolStripMenuItem
        '
        Me.B1ToolStripMenuItem.Name = "B1ToolStripMenuItem"
        Me.B1ToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.B1ToolStripMenuItem.Text = "Gestión"
        '
        'GruposToolStripMenuItem
        '
        Me.GruposToolStripMenuItem.Name = "GruposToolStripMenuItem"
        Me.GruposToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.GruposToolStripMenuItem.Text = "Grupos"
        '
        'InventarioToolStripMenuItem
        '
        Me.InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        Me.InventarioToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.InventarioToolStripMenuItem.Text = "Inventario"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(208, 208)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(651, 485)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(186, 99)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 448)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "2017/2018"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label2.Location = New System.Drawing.Point(38, 485)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Autores:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(236, 222)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(589, 236)
        Me.DataGridView1.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 579)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Gestión Incidencias"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OpcionAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OPCA1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OPCA2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OPcBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents B1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GruposToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView

End Class
