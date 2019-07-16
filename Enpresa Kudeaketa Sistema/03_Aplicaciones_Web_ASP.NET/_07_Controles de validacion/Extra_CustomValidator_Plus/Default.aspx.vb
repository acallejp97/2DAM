
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.IsValid Then
            Me.Label2.Text = "Todo correcto"
        Else
            Me.Label2.Text = "Algo esta mal"
        End If
    End Sub


    Protected Sub CustomValidator1_ServerValidate(source As Object, args As ServerValidateEventArgs) Handles CustomValidator1.ServerValidate

        If TextBox1.Text = "Pepe" Then
            args.IsValid = False
        Else
            args.IsValid = True
        End If


    End Sub
End Class
