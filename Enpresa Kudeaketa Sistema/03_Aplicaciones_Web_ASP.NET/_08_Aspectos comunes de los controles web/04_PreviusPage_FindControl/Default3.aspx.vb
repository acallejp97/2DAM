
Partial Class Default2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Dim abc As TextBox = Me.Page.PreviousPage.FindControl("TextBox1")
            Me.Label2.Text = abc.Text
        Catch ex As Exception
            Response.Redirect("Default.aspx")
        End Try
    End Sub
End Class
