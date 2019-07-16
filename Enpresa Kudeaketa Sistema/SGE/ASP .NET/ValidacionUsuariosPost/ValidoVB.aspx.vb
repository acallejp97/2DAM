
Partial Class ValidoVB
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim acum As String
        acum = "Bienvenido: "
        acum += Me.Request.Form("txtUsuario")
        acum += " has entrado con el password: "
        acum += Me.Request.Form("txtPassword")
        Me.Label1.Text = Me.Request.Form("txtUsuario")
        Me.Label1.Text = acum
    End Sub
End Class
