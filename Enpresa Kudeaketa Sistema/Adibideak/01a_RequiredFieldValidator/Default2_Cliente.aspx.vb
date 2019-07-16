
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Bezeroan egiten da balidazioa
        'EnableClientScript = "True"
        If Me.IsValid Then
            Me.Label1.Text = "Sartu duzu " & Me.TextBox1.Text
        Else
            Me.Label1.Text = "nunca sale por aqui"  'NUNCA SALE POR AQUI
        End If


        'Errorea ez emateko hau jarri behar da Web.config-en
        '      <appSettings>
        '  <add key="ValidationSettings:UnobtrusiveValidationMode" value="None" />
        '</appSettings>


    End Sub
End Class
