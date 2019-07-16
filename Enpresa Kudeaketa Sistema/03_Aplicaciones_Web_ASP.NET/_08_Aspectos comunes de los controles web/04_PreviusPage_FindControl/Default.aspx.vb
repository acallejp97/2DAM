
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Session("AAA") = Me.TextBox1.Text
        Response.Redirect("Default2.aspx")
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Response.Redirect("Default3.aspx")
        'con lo anterior NO FUNCIONA
        'Hay que ir a las propiedades del boton postbackURL

        'Con Server.transfer SI FUNCIONA
    End Sub
End Class
