Public Class Form1

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Me.txtEntrada.Text = "Ongi etorri"
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.txtEntrada.Clear()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AcceptButton = Me.btnAceptar
        Me.CancelButton = Me.btnCancelar
    End Sub
End Class
