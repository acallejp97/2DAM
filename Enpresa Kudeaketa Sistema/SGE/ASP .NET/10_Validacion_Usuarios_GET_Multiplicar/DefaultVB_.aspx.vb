
Partial Class DefaultVB_
    Inherits System.Web.UI.Page

    Protected Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        'Metodo GET, se ve en la barra de direcciones 
        If Me.txtusuario.Text = "admin" And Me.txtPassword.Text = "1234" Then
            Me.Response.Redirect("ValidoVB.aspx?aaaa=" + Me.txtusuario.Text + "&bbbb=" + Me.txtPassword.Text + "&cccc=" + Me.txtNumero.Text)
            
        Else
            Me.Response.Redirect("ErrorVB.aspx?aaaa=" + Me.txtusuario.Text + "&bbbb=" + Me.txtPassword.Text)
        End If
    End Sub


End Class
