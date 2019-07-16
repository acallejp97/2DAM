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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbPrezioa = New System.Windows.Forms.TextBox()
        Me.tbTotala = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnOnartu = New System.Windows.Forms.Button()
        Me.btnHasiBerriro = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbEntsalada = New System.Windows.Forms.RadioButton()
        Me.rbSarrera = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbBarazkia = New System.Windows.Forms.RadioButton()
        Me.rbItsaskia = New System.Windows.Forms.RadioButton()
        Me.rbHaragia = New System.Windows.Forms.RadioButton()
        Me.rbArraina = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rbGoxokia = New System.Windows.Forms.RadioButton()
        Me.rbFruta = New System.Windows.Forms.RadioButton()
        Me.rbIzozkia = New System.Windows.Forms.RadioButton()
        Me.btnEntsalada = New System.Windows.Forms.Button()
        Me.btnGomendioa = New System.Windows.Forms.Button()
        Me.btnIrten = New System.Windows.Forms.Button()
        Me.cbOgiArdo = New System.Windows.Forms.CheckBox()
        Me.cbKafe = New System.Windows.Forms.CheckBox()
        Me.lblPrezioLehen = New System.Windows.Forms.Label()
        Me.lblPrezioBigarren = New System.Windows.Forms.Label()
        Me.lblPrezioPostre = New System.Windows.Forms.Label()
        Me.lblOgiArdo = New System.Windows.Forms.Label()
        Me.lblKafe = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label1.Location = New System.Drawing.Point(34, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Menua"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(378, 268)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Prezioa:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Aqua
        Me.Label3.Location = New System.Drawing.Point(378, 302)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "BEZ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(378, 337)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "TOTALA:"
        '
        'tbPrezioa
        '
        Me.tbPrezioa.Location = New System.Drawing.Point(443, 265)
        Me.tbPrezioa.Name = "tbPrezioa"
        Me.tbPrezioa.Size = New System.Drawing.Size(100, 20)
        Me.tbPrezioa.TabIndex = 4
        '
        'tbTotala
        '
        Me.tbTotala.Location = New System.Drawing.Point(443, 330)
        Me.tbTotala.Name = "tbTotala"
        Me.tbTotala.Size = New System.Drawing.Size(100, 20)
        Me.tbTotala.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(443, 297)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "%18"
        '
        'btnOnartu
        '
        Me.btnOnartu.BackColor = System.Drawing.Color.Gray
        Me.btnOnartu.Location = New System.Drawing.Point(392, 379)
        Me.btnOnartu.Name = "btnOnartu"
        Me.btnOnartu.Size = New System.Drawing.Size(75, 23)
        Me.btnOnartu.TabIndex = 7
        Me.btnOnartu.Text = "Onartu"
        Me.btnOnartu.UseVisualStyleBackColor = False
        '
        'btnHasiBerriro
        '
        Me.btnHasiBerriro.BackColor = System.Drawing.Color.Gray
        Me.btnHasiBerriro.Location = New System.Drawing.Point(516, 379)
        Me.btnHasiBerriro.Name = "btnHasiBerriro"
        Me.btnHasiBerriro.Size = New System.Drawing.Size(75, 23)
        Me.btnHasiBerriro.TabIndex = 8
        Me.btnHasiBerriro.Text = "Hasi berriro"
        Me.btnHasiBerriro.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbEntsalada)
        Me.GroupBox1.Controls.Add(Me.rbSarrera)
        Me.GroupBox1.Location = New System.Drawing.Point(37, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(126, 100)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lehenengoa"
        '
        'rbEntsalada
        '
        Me.rbEntsalada.AutoSize = True
        Me.rbEntsalada.Location = New System.Drawing.Point(6, 64)
        Me.rbEntsalada.Name = "rbEntsalada"
        Me.rbEntsalada.Size = New System.Drawing.Size(72, 17)
        Me.rbEntsalada.TabIndex = 1
        Me.rbEntsalada.TabStop = True
        Me.rbEntsalada.Text = "Entsalada"
        Me.rbEntsalada.UseVisualStyleBackColor = True
        '
        'rbSarrera
        '
        Me.rbSarrera.AutoSize = True
        Me.rbSarrera.Location = New System.Drawing.Point(7, 30)
        Me.rbSarrera.Name = "rbSarrera"
        Me.rbSarrera.Size = New System.Drawing.Size(65, 17)
        Me.rbSarrera.TabIndex = 0
        Me.rbSarrera.TabStop = True
        Me.rbSarrera.Tag = "5"
        Me.rbSarrera.Text = "Sarrerak"
        Me.rbSarrera.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbBarazkia)
        Me.GroupBox2.Controls.Add(Me.rbItsaskia)
        Me.GroupBox2.Controls.Add(Me.rbHaragia)
        Me.GroupBox2.Controls.Add(Me.rbArraina)
        Me.GroupBox2.Location = New System.Drawing.Point(205, 85)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(138, 166)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Bigarrena"
        '
        'rbBarazkia
        '
        Me.rbBarazkia.AutoSize = True
        Me.rbBarazkia.Location = New System.Drawing.Point(5, 131)
        Me.rbBarazkia.Name = "rbBarazkia"
        Me.rbBarazkia.Size = New System.Drawing.Size(72, 17)
        Me.rbBarazkia.TabIndex = 3
        Me.rbBarazkia.TabStop = True
        Me.rbBarazkia.Text = "Barazkiak"
        Me.rbBarazkia.UseVisualStyleBackColor = True
        '
        'rbItsaskia
        '
        Me.rbItsaskia.AutoSize = True
        Me.rbItsaskia.Location = New System.Drawing.Point(6, 97)
        Me.rbItsaskia.Name = "rbItsaskia"
        Me.rbItsaskia.Size = New System.Drawing.Size(61, 17)
        Me.rbItsaskia.TabIndex = 2
        Me.rbItsaskia.TabStop = True
        Me.rbItsaskia.Text = "Itsaskia"
        Me.rbItsaskia.UseVisualStyleBackColor = True
        '
        'rbHaragia
        '
        Me.rbHaragia.AutoSize = True
        Me.rbHaragia.Location = New System.Drawing.Point(6, 64)
        Me.rbHaragia.Name = "rbHaragia"
        Me.rbHaragia.Size = New System.Drawing.Size(62, 17)
        Me.rbHaragia.TabIndex = 1
        Me.rbHaragia.TabStop = True
        Me.rbHaragia.Text = "Haragia"
        Me.rbHaragia.UseVisualStyleBackColor = True
        '
        'rbArraina
        '
        Me.rbArraina.AutoSize = True
        Me.rbArraina.Location = New System.Drawing.Point(7, 30)
        Me.rbArraina.Name = "rbArraina"
        Me.rbArraina.Size = New System.Drawing.Size(58, 17)
        Me.rbArraina.TabIndex = 0
        Me.rbArraina.TabStop = True
        Me.rbArraina.Text = "Arraina"
        Me.rbArraina.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbGoxokia)
        Me.GroupBox3.Controls.Add(Me.rbFruta)
        Me.GroupBox3.Controls.Add(Me.rbIzozkia)
        Me.GroupBox3.Location = New System.Drawing.Point(388, 85)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(89, 130)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Postrea"
        '
        'rbGoxokia
        '
        Me.rbGoxokia.AutoSize = True
        Me.rbGoxokia.Location = New System.Drawing.Point(6, 97)
        Me.rbGoxokia.Name = "rbGoxokia"
        Me.rbGoxokia.Size = New System.Drawing.Size(70, 17)
        Me.rbGoxokia.TabIndex = 2
        Me.rbGoxokia.TabStop = True
        Me.rbGoxokia.Text = "Goxokiak"
        Me.rbGoxokia.UseVisualStyleBackColor = True
        '
        'rbFruta
        '
        Me.rbFruta.AutoSize = True
        Me.rbFruta.Location = New System.Drawing.Point(6, 64)
        Me.rbFruta.Name = "rbFruta"
        Me.rbFruta.Size = New System.Drawing.Size(49, 17)
        Me.rbFruta.TabIndex = 1
        Me.rbFruta.TabStop = True
        Me.rbFruta.Text = "Fruta"
        Me.rbFruta.UseVisualStyleBackColor = True
        '
        'rbIzozkia
        '
        Me.rbIzozkia.AutoSize = True
        Me.rbIzozkia.Location = New System.Drawing.Point(7, 30)
        Me.rbIzozkia.Name = "rbIzozkia"
        Me.rbIzozkia.Size = New System.Drawing.Size(58, 17)
        Me.rbIzozkia.TabIndex = 0
        Me.rbIzozkia.TabStop = True
        Me.rbIzozkia.Text = "Izozkia"
        Me.rbIzozkia.UseVisualStyleBackColor = True
        '
        'btnEntsalada
        '
        Me.btnEntsalada.BackColor = System.Drawing.Color.Gray
        Me.btnEntsalada.Enabled = False
        Me.btnEntsalada.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEntsalada.Location = New System.Drawing.Point(37, 250)
        Me.btnEntsalada.Name = "btnEntsalada"
        Me.btnEntsalada.Size = New System.Drawing.Size(75, 23)
        Me.btnEntsalada.TabIndex = 12
        Me.btnEntsalada.Text = "Entsalada"
        Me.btnEntsalada.UseVisualStyleBackColor = False
        '
        'btnGomendioa
        '
        Me.btnGomendioa.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnGomendioa.ForeColor = System.Drawing.SystemColors.Control
        Me.btnGomendioa.Location = New System.Drawing.Point(37, 318)
        Me.btnGomendioa.Name = "btnGomendioa"
        Me.btnGomendioa.Size = New System.Drawing.Size(126, 43)
        Me.btnGomendioa.TabIndex = 13
        Me.btnGomendioa.Text = "Gomendioa"
        Me.btnGomendioa.UseVisualStyleBackColor = False
        '
        'btnIrten
        '
        Me.btnIrten.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnIrten.ForeColor = System.Drawing.SystemColors.Control
        Me.btnIrten.Location = New System.Drawing.Point(37, 390)
        Me.btnIrten.Name = "btnIrten"
        Me.btnIrten.Size = New System.Drawing.Size(75, 23)
        Me.btnIrten.TabIndex = 14
        Me.btnIrten.Text = "Irten"
        Me.btnIrten.UseVisualStyleBackColor = False
        '
        'cbOgiArdo
        '
        Me.cbOgiArdo.AutoSize = True
        Me.cbOgiArdo.Location = New System.Drawing.Point(205, 318)
        Me.cbOgiArdo.Name = "cbOgiArdo"
        Me.cbOgiArdo.Size = New System.Drawing.Size(96, 17)
        Me.cbOgiArdo.TabIndex = 15
        Me.cbOgiArdo.Text = "Ogia eta ardoa"
        Me.cbOgiArdo.UseVisualStyleBackColor = True
        '
        'cbKafe
        '
        Me.cbKafe.AutoSize = True
        Me.cbKafe.Location = New System.Drawing.Point(205, 356)
        Me.cbKafe.Name = "cbKafe"
        Me.cbKafe.Size = New System.Drawing.Size(54, 17)
        Me.cbKafe.TabIndex = 16
        Me.cbKafe.Text = "Kafea"
        Me.cbKafe.UseVisualStyleBackColor = True
        '
        'lblPrezioLehen
        '
        Me.lblPrezioLehen.AutoSize = True
        Me.lblPrezioLehen.Location = New System.Drawing.Point(37, 188)
        Me.lblPrezioLehen.Name = "lblPrezioLehen"
        Me.lblPrezioLehen.Size = New System.Drawing.Size(36, 13)
        Me.lblPrezioLehen.TabIndex = 17
        Me.lblPrezioLehen.Text = " Label"
        Me.lblPrezioLehen.Visible = False
        '
        'lblPrezioBigarren
        '
        Me.lblPrezioBigarren.AutoSize = True
        Me.lblPrezioBigarren.Location = New System.Drawing.Point(202, 254)
        Me.lblPrezioBigarren.Name = "lblPrezioBigarren"
        Me.lblPrezioBigarren.Size = New System.Drawing.Size(36, 13)
        Me.lblPrezioBigarren.TabIndex = 18
        Me.lblPrezioBigarren.Text = " Label"
        Me.lblPrezioBigarren.Visible = False
        '
        'lblPrezioPostre
        '
        Me.lblPrezioPostre.AutoSize = True
        Me.lblPrezioPostre.Location = New System.Drawing.Point(389, 220)
        Me.lblPrezioPostre.Name = "lblPrezioPostre"
        Me.lblPrezioPostre.Size = New System.Drawing.Size(36, 13)
        Me.lblPrezioPostre.TabIndex = 19
        Me.lblPrezioPostre.Text = " Label"
        Me.lblPrezioPostre.Visible = False
        '
        'lblOgiArdo
        '
        Me.lblOgiArdo.AutoSize = True
        Me.lblOgiArdo.Location = New System.Drawing.Point(296, 319)
        Me.lblOgiArdo.Name = "lblOgiArdo"
        Me.lblOgiArdo.Size = New System.Drawing.Size(25, 13)
        Me.lblOgiArdo.TabIndex = 20
        Me.lblOgiArdo.Text = "(2€)"
        Me.lblOgiArdo.Visible = False
        '
        'lblKafe
        '
        Me.lblKafe.AutoSize = True
        Me.lblKafe.Location = New System.Drawing.Point(296, 357)
        Me.lblKafe.Name = "lblKafe"
        Me.lblKafe.Size = New System.Drawing.Size(25, 13)
        Me.lblKafe.TabIndex = 21
        Me.lblKafe.Text = "(2€)"
        Me.lblKafe.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 471)
        Me.Controls.Add(Me.lblKafe)
        Me.Controls.Add(Me.lblOgiArdo)
        Me.Controls.Add(Me.lblPrezioPostre)
        Me.Controls.Add(Me.lblPrezioBigarren)
        Me.Controls.Add(Me.lblPrezioLehen)
        Me.Controls.Add(Me.cbKafe)
        Me.Controls.Add(Me.cbOgiArdo)
        Me.Controls.Add(Me.btnIrten)
        Me.Controls.Add(Me.btnGomendioa)
        Me.Controls.Add(Me.btnEntsalada)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnHasiBerriro)
        Me.Controls.Add(Me.btnOnartu)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbTotala)
        Me.Controls.Add(Me.tbPrezioa)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Elorrietako karta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbPrezioa As System.Windows.Forms.TextBox
    Friend WithEvents tbTotala As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnOnartu As System.Windows.Forms.Button
    Friend WithEvents btnHasiBerriro As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbEntsalada As System.Windows.Forms.RadioButton
    Friend WithEvents rbSarrera As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbBarazkia As System.Windows.Forms.RadioButton
    Friend WithEvents rbItsaskia As System.Windows.Forms.RadioButton
    Friend WithEvents rbHaragia As System.Windows.Forms.RadioButton
    Friend WithEvents rbArraina As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rbGoxokia As System.Windows.Forms.RadioButton
    Friend WithEvents rbFruta As System.Windows.Forms.RadioButton
    Friend WithEvents rbIzozkia As System.Windows.Forms.RadioButton
    Friend WithEvents btnEntsalada As System.Windows.Forms.Button
    Friend WithEvents btnGomendioa As System.Windows.Forms.Button
    Friend WithEvents btnIrten As System.Windows.Forms.Button
    Friend WithEvents cbOgiArdo As System.Windows.Forms.CheckBox
    Friend WithEvents cbKafe As System.Windows.Forms.CheckBox
    Friend WithEvents lblPrezioLehen As System.Windows.Forms.Label
    Friend WithEvents lblPrezioBigarren As System.Windows.Forms.Label
    Friend WithEvents lblPrezioPostre As System.Windows.Forms.Label
    Friend WithEvents lblOgiArdo As System.Windows.Forms.Label
    Friend WithEvents lblKafe As System.Windows.Forms.Label

End Class
