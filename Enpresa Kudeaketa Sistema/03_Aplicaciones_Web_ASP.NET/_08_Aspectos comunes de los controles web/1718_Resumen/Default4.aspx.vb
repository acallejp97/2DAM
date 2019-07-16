
Partial Class Default4
    Inherits System.Web.UI.Page

    Private Sub form1_Load(sender As Object, e As EventArgs) Handles form1.Load
        'Label1.Text = Request.Form("Textbox1")
        Label1.Text = Request.QueryString("aaa")
    End Sub
End Class
