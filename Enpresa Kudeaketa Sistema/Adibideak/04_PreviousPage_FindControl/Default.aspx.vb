
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Session("aaa") = TextBox1.Text
        Response.Redirect("Default2.aspx")
        'Hay que utilizar Response.Redirect para que funcionen las variables Session
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
