
Partial Class Default3
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.IsValid Then
            Me.Label1.Text = Page.Validators.Count & " validados."
        Else
            Me.Label1.Text = "Hay errores"
        End If
    End Sub
End Class
