Public Class Form2
    Public guztira As Double

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lbOsagaiak.Items.Add("Arrautza 0,5")
        Me.lbOsagaiak.Items.Add("Erremolatxa 0,6")
        Me.lbOsagaiak.Items.Add("Azenarioa 0,7")
        Me.lbOsagaiak.Items.Add("Gazta 0,8")
        Me.lbOsagaiak.Items.Add("Sagarra 0,9")
    End Sub

    Private Sub btnOnartu_Click(sender As Object, e As EventArgs) Handles btnOnartu.Click
        Form1.lehenengoa = guztira
        Form1.lblPrezioLehen.Text = guztira
        Form1.tbPrezioa.Text = (Form1.lehenengoa + Form1.bigarrena + Form1.postrea + Form1.ogia + Form1.kafea)
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub btnBatSartu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatSartu.Click
        If Me.lbOsagaiak.SelectedIndex <> -1 Then
            Me.lbtotal.Items.Add(Me.lbOsagaiak.SelectedItem)
            Me.lbOsagaiak.Items.Remove(Me.lbOsagaiak.SelectedItem)
        End If
        SartuKendu()
    End Sub

    Private Sub btnBatKendu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatKendu.Click
        If Me.lbtotal.SelectedIndex >= 0 Then
            Me.lbOsagaiak.Items.Add(Me.lbtotal.SelectedItem)
            Me.lbtotal.Items.Remove(Me.lbtotal.SelectedItem)
        End If
        SartuKendu()
    End Sub

    Private Sub btnGuztiaSartu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuztiaSartu.Click
        Me.lbtotal.Items.AddRange(Me.lbOsagaiak.Items)
        Me.lbOsagaiak.Items.Clear()
        SartuKendu()
    End Sub

    Private Sub btnGuztiaKendu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuztiaKendu.Click
        Me.lbOsagaiak.Items.AddRange(Me.lbtotal.Items)
        Me.lbtotal.Items.Clear()
        SartuKendu()
    End Sub

    Sub SartuKendu()
        If Me.lbOsagaiak.Items.Count > 0 Then
            Me.lbOsagaiak.SelectedIndex = 0
        End If
        If Me.lbtotal.Items.Count > 0 Then
            Me.lbtotal.SelectedIndex = 0
        End If
        guztira = 6
        For Each i As String In lbtotal.Items
            guztira = guztira + Convert.ToDouble(i.Substring(i.IndexOf(" ")))
        Next
        Me.tbTotala.Text = guztira & "€"
    End Sub

End Class

