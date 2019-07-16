
Partial Class Default3
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Server.Transfer("Default4.aspx")
        Response.Redirect("Default4.aspx?aaa=" + Me.TextBox1.Text)
    End Sub
End Class
