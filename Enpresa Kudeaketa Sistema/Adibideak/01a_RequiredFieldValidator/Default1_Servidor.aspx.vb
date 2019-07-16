
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Zerbitzarian egiten da balidazioa
        If Me.IsValid Then
            Me.Label1.Text = "Sartu duzu " & Me.TextBox1.Text
        Else
            Me.Label1.Text = ""
        End If
    End Sub
End Class
