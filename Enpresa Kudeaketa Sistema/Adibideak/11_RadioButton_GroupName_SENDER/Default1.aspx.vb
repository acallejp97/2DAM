


Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub hola(ByVal sender As Object, ByVal e As System.EventArgs) Handles opc1.CheckedChanged, opc2.CheckedChanged, opc3.CheckedChanged
        If opc1.Checked Then
            seleccion.Text = opc1.Text + " sakatu duzu."
        ElseIf opc2.Checked Then
            seleccion.Text = opc2.Text + " sakatu duzu."
        Else
            seleccion.Text = opc3.Text + " sakatu duzu."
        End If
    End Sub

    Protected Sub adios(ByVal sender As Object, ByVal e As System.EventArgs) Handles opc4.CheckedChanged, opc5.CheckedChanged
        If opc4.Checked Then
            Label1.Text = opc4.Text + " sakatu duzu."
        Else
            Label1.Text = opc5.Text + " sakatu duzu."
        End If
    End Sub
End Class
