
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Prezioa_Click(sender As Object, e As EventArgs) Handles Prezioa.Click
        Dim prezio As Double = 0


        If Helmuga.SelectedValue = "Isla de Pascua" Then
            prezio = 3620
        ElseIf Helmuga.SelectedValue = "Morea" Then
            prezio = 6000
        ElseIf Helmuga.SelectedValue = "Papeete" Then
            prezio = 2000
        ElseIf Helmuga.SelectedValue = "Bora-Bora" Then
            prezio = 6450
        ElseIf Helmuga.SelectedValue = "Bermudas" Then
            prezio = 10000
        ElseIf Helmuga.SelectedValue = "Elorrieta" Then
            prezio = 0.88
        End If

        lblPrezio.Text = "Prezioa " & Helmuga.SelectedValue & "-ra joateko " & prezio & "€ dira"
    End Sub
End Class
