
Partial Class Default2
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.IsValid Then
            Me.Label1.Text = "Todo correcto"
        Else
            Me.Label1.Text = "Algo esta mal"
        End If
    End Sub


    Protected Sub CustomValidator1_ServerValidate(source As Object, args As ServerValidateEventArgs) Handles CustomValidator1.ServerValidate
        Dim a, b, c, d, e As Boolean
        Try
            Dim x As String = Convert.ToString(Me.TextBox1.Text)

            If x.Length = 8 Then
                a = True
            Else
                a = False
            End If

            If x.StartsWith("8") Then
                b = True
            Else
                b = False
            End If

            If x(2) = "8" Then
                c = True
            Else
                c = False
            End If

            If x Mod 2 = 0 Then
                d = True
            Else
                d = False
            End If

            If IsNumeric(x) Then
                e = True
            Else
                e = False
            End If

            If a And b And c And d And e Then
                args.IsValid = True
            Else
                args.IsValid = False
            End If
        Catch ex As Exception
            args.IsValid = False
        End Try
    End Sub

End Class
