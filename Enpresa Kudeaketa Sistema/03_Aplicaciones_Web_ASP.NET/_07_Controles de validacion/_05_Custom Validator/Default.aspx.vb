
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.IsValid Then
            Me.Label1.Text = "Todo correcto"
        Else
            Me.Label1.Text = "Algo esta mal"
        End If
    End Sub


    Protected Sub CustomValidator1_ServerValidate(source As Object, args As ServerValidateEventArgs) Handles CustomValidator1.ServerValidate
        Try
            Dim x As Integer = Convert.ToInt32(Me.TextBox1.Text)
            If x Mod 2 = 0 Then
                args.IsValid = True
            Else
                args.IsValid = False
            End If
        Catch ex As Exception
            args.IsValid = False
        End Try
    End Sub
End Class
