
Partial Class _Default
    Inherits System.Web.UI.Page

    Private Sub Control1_GotFocus(sender As Object, e As EventArgs) _
     Handles Control1.GotFocus

        Console.WriteLine("You are in the Control.GotFocus event.")

    End Sub
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGorria.Click
        lblKaixo.ForeColor = Drawing.Color.Red
    End Sub

    Protected Sub btnUrdina_Click(sender As Object, e As EventArgs) Handles btnUrdina.Click
        lblKaixo.ForeColor = Drawing.Color.Blue
    End Sub

    Protected Sub btnBerdea_Click(sender As Object, e As EventArgs) Handles btnBerdea.Click
        lblKaixo.ForeColor = Drawing.Color.Green
    End Sub
End Class
