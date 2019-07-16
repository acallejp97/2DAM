
Partial Class ErrorVB
    Inherits System.Web.UI.Page

    

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim acum As String
        acum = Me.Request.QueryString("aaaa")
        acum += " --- " + Me.Request.QueryString("bbbb")
        Me.Label2.Text = acum
    End Sub
End Class
