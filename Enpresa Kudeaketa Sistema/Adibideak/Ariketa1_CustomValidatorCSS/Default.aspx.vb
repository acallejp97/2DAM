
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub CustomValidator1_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles CustomValidator1.ServerValidate
        If Me.TextBox1.Text.ToLower = "pepe" Then
            Me.Label1.ForeColor = Drawing.Color.Red
            args.IsValid = False
        Else
            Me.Label1.ForeColor = Drawing.Color.Black
            args.IsValid = True
        End If
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Page.IsValid Then
            Me.Label2.Text = "Orria ondo dago."
        Else
            Me.Label2.Text = "Orria ez dago ondo."
        End If
    End Sub
End Class
