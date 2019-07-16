
Partial Class Default3_ListBox_Servidor
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Zerbitzarian egiten da balidazioa
        If Me.IsValid Then
            Me.Label1.Text = Me.ListBox1.SelectedItem.Text
        Else
            'Bezeroan egiten bada balidazioa ez du hemendik pasatzen inoiz ere ez.
            Me.Label1.Text = "Ez du balio."
        End If

    End Sub
End Class
