
Partial Class DefaultVB
    Inherits System.Web.UI.Page

    Protected Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If Me.txtUsuario.Text = "admin" And Me.txtPassword.Text = "1234" Then
            Me.Server.Transfer("ValidoVB.aspx")
        Else
            Me.Server.Transfer("ErrorVB.aspx")
        End If
    End Sub
End Class
