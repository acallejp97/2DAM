
Partial Class Default1_SERVIDOR
    Inherits System.Web.UI.Page

    Protected Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If Me.IsValid Then
            Me.Label2.Text = "BIEN"
        Else
            Me.Label2.Text = "MAL"
        End If
    End Sub
End Class
