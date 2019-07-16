
Partial Class ValidoVB
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim acum As String
        acum = "Bienvenido "
        acum += "<b>" + Me.Request.Form("txtUsuario") + "</b>"
        acum += " has entrado con el password "
        acum += "<b>" + Me.Request.Form("txtPassword") + "</b>"
        Me.Label1.Text = acum
    End Sub
End Class
