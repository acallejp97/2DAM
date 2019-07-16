
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.IsValid Then
            Me.Label2.Text = Me.Validators.Count & " validados."
        Else
            Me.Label2.Text = "Hay errores"
        End If
    End Sub
End Class
