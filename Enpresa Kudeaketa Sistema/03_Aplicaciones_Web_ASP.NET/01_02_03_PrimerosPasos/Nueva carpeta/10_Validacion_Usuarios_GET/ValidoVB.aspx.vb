
Partial Class ValidoVB
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim acum As String = "Valido <br>"
        acum += Me.Request.QueryString("aaa")
        acum += " --- " + Me.Request.QueryString("bbb")
        Me.Label1.Text = acum

    End Sub
End Class
