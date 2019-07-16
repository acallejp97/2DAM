
Partial Class Default2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Me.Label2.Text = Session("AAA")
        Catch ex As Exception
            Response.Redirect("Default.aspx")
        End Try
    End Sub
End Class
