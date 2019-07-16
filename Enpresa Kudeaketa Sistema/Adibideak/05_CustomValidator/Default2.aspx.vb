
Partial Class Default2
    Inherits System.Web.UI.Page

    Protected Sub CustomValidator1_ServerValidate(source As Object, args As ServerValidateEventArgs) Handles CustomValidator1.ServerValidate
        Try
            Dim x As Integer = Convert.ToInt32(Me.TextBox1.Text)
            If x Mod 2 = 0 Then
                args.IsValid = True 'Balidatuta dago. Zenbakia da.
            Else
                args.IsValid = False
            End If

        Catch ex As Exception
            args.IsValid = False 'Ez dago balidatuta
        End Try
    End Sub
End Class
