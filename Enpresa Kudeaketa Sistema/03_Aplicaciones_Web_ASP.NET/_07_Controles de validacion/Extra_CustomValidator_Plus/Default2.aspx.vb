
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Validate()
        If CompareValidator1.IsValid Then
            Label2.Text = "La pagina es valida"
        Else
            Label2.Text = "La pagina NO es valida"
        End If
    End Sub
End Class
