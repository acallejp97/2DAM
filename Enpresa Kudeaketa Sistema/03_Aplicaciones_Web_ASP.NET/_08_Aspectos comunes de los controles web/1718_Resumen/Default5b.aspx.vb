
Partial Class Default5b
    Inherits System.Web.UI.Page

    Protected Sub form1_Load(sender As Object, e As EventArgs) Handles form1.Load
        Me.Label1.Text = Session("aaa")
    End Sub
End Class
