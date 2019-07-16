


Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub kaixo(ByVal sender As Object, ByVal e As System.EventArgs) Handles opc1.CheckedChanged, opc2.CheckedChanged, opc3.CheckedChanged
        seleccion.Text = sender.Text & " aukeratu da."
    End Sub


    Protected Sub agur(ByVal sender As Object, ByVal e As System.EventArgs) Handles opc4.CheckedChanged, opc5.CheckedChanged
        Label1.Text = sender.Text & " aukeratu da. "
    End Sub
End Class
