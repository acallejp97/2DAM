
Partial Class Default1
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Botoia.Click
        If Me.IsValid Then
            Me.Label2.Text = Page.Validators.Count & " balidatuak."
        Else
            Me.Label2.Text = "Erroreak daude"
        End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
End Class
