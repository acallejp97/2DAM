
Partial Class Default2
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Validate()
        If CompareValidator1.IsValid Then
            Label2.Text = "Orria ondo dago"
        Else
            Label2.Text = "Orria ez dago ondo"
        End If
    End Sub
End Class
