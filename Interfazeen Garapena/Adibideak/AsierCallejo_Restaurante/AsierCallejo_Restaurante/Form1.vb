Public Class Form1
    Public lehenengoa As Double = 0
    Public bigarrena As Double = 0
    Public postrea As Double = 0
    Public ogia As Double = 0
    Public kafea As Double = 0


    'RadioButtonak
    ''Lehenengoak
    Private Sub rbSarrera_CheckedChanged(sender As Object, e As EventArgs) Handles rbSarrera.CheckedChanged
        lblPrezioLehen.Text = "5"
        lblPrezioLehen.Visible = True
        lehenengoa = Double.Parse(lblPrezioLehen.Text)
        btnEntsalada.Enabled = False
        btnEntsalada.BackColor = Color.Gray
        tbPrezioa.Text = (lehenengoa + bigarrena + postrea + ogia + kafea)
    End Sub

    Private Sub rbEntsalada_CheckedChanged(sender As Object, e As EventArgs) Handles rbEntsalada.CheckedChanged
        lblPrezioLehen.Text = "6"
        lblPrezioLehen.Visible = True
        lehenengoa = Double.Parse(lblPrezioLehen.Text)
        btnEntsalada.Enabled = True
        btnEntsalada.BackColor = Color.Green
        tbPrezioa.Text = (lehenengoa + bigarrena + postrea + ogia + kafea)
    End Sub

    ''Bigarrenak
    Private Sub rbArraina_CheckedChanged(sender As Object, e As EventArgs) Handles rbArraina.CheckedChanged, rbHaragia.CheckedChanged, rbItsaskia.CheckedChanged
        lblPrezioBigarren.Text = "6"
        lblPrezioBigarren.Visible = True
        bigarrena = Double.Parse(lblPrezioBigarren.Text)
        tbPrezioa.Text = (lehenengoa + bigarrena + postrea + ogia + kafea)
    End Sub

    Private Sub rbBarazkia_CheckedChanged(sender As Object, e As EventArgs) Handles rbBarazkia.CheckedChanged
        lblPrezioBigarren.Text = "5"
        lblPrezioBigarren.Visible = True
        bigarrena = Double.Parse(lblPrezioBigarren.Text)
        tbPrezioa.Text = (lehenengoa + bigarrena + postrea + ogia + kafea)
    End Sub

    ''Postrea
    Private Sub rbIzozkia_CheckedChanged(sender As Object, e As EventArgs) Handles rbIzozkia.CheckedChanged, rbFruta.CheckedChanged, rbGoxokia.CheckedChanged
        lblPrezioPostre.Text = "3"
        lblPrezioPostre.Visible = True
        postrea = Double.Parse(lblPrezioPostre.Text)
        tbPrezioa.Text = (lehenengoa + bigarrena + postrea + ogia + kafea)
    End Sub

    'CheckBoxak
    Private Sub cbOgiArdo_CheckedChanged(sender As Object, e As EventArgs) Handles cbOgiArdo.CheckedChanged
        lblOgiArdo.Visible = cbOgiArdo.Checked
        ogia = IIf(cbOgiArdo.Checked, 2, 0)
        kafea = IIf(cbKafe.Checked, 2, 0)
        tbPrezioa.Text = (lehenengoa + bigarrena + postrea + ogia + kafea)
    End Sub

    Private Sub cbKafe_CheckedChanged(sender As Object, e As EventArgs) Handles cbKafe.CheckedChanged
        lblKafe.Visible = cbKafe.Checked
        ogia = IIf(cbOgiArdo.Checked, 2, 0)
        kafea = IIf(cbKafe.Checked, 2, 0)
        tbPrezioa.Text = (lehenengoa + bigarrena + postrea + ogia + kafea)
    End Sub

    'Botoiak
    Private Sub btnGomendioa_Click(sender As Object, e As EventArgs) Handles btnGomendioa.Click
        rbSarrera.Checked = True
        rbArraina.Checked = True
        rbIzozkia.Checked = True
        cbOgiArdo.Checked = True
        cbKafe.Checked = True
    End Sub

    Private Sub btnHasiBerriro_Click(sender As Object, e As EventArgs) Handles btnHasiBerriro.Click
        rbArraina.Checked = False
        rbBarazkia.Checked = False
        rbEntsalada.Checked = False
        rbFruta.Checked = False
        rbGoxokia.Checked = False
        rbHaragia.Checked = False
        rbItsaskia.Checked = False
        rbIzozkia.Checked = False
        rbSarrera.Checked = False

        btnEntsalada.Enabled = False
        btnEntsalada.BackColor = Color.Gray

        lblPrezioPostre.Visible = False
        lblPrezioBigarren.Visible = False
        lblPrezioLehen.Visible = False

        lehenengoa = 0
        bigarrena = 0
        postrea = 0
        ogia = 0
        kafea = 0
        tbPrezioa.Text = 0
    End Sub

    'Comprobar si se han seleccionado todos los platos del menú
    Private Function konprobazioa() As Boolean
        Dim lSelec As Boolean = rbSarrera.Checked Or rbEntsalada.Checked
        Dim bSelec As Boolean = rbHaragia.Checked Or rbItsaskia.Checked Or rbArraina.Checked Or rbBarazkia.Checked
        Dim posSelec As Boolean = rbIzozkia.Checked Or rbFruta.Checked Or rbGoxokia.Checked()

        Return lSelec And bSelec And posSelec
    End Function

    Private Sub btnOnartu_Click(sender As Object, e As EventArgs) Handles btnOnartu.Click
        If konprobazioa() = True Then
            MsgBox("Totala: " & tbTotala.Text & "€.Eskerrik asko etortzeagatik!", MsgBoxStyle.Information, "Menuaren prezioa")
        Else
            MessageBox.Show("Menua ez dago osatuta", "Hautatzeko elementuak falta dira", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnIrten_Click(sender As Object, e As EventArgs) Handles btnIrten.Click
        Me.Close()
    End Sub

    Private Sub btnEntsalada_Click(sender As Object, e As EventArgs) Handles btnEntsalada.Click
        Form2.Show()
        Me.Hide()
    End Sub

    'Totala
    Private Sub tbPrezioa_TextChanged(sender As Object, e As EventArgs) Handles tbPrezioa.TextChanged
        tbTotala.Text = Convert.ToDouble(tbPrezioa.Text) * 1.18
    End Sub
End Class
