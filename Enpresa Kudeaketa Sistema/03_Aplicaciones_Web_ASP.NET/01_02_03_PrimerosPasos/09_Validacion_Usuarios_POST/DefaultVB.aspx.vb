
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub AAA(sender As Object, e As EventArgs) Handles botonAceptar.Click
        If Me.txtUsuario.Text = "Loren" And _
            Me.txtPassword.Text = "1234" Then
            Me.Server.Transfer("ValidoVB.aspx")
        Else
            Me.Server.Transfer("ErrorVB.aspx")
        End If
    End Sub
End Class
