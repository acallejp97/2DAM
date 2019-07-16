
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub GridView1_RowDeleted(sender As Object, e As GridViewDeletedEventArgs) Handles GridView1.RowDeleted
        'DESPUES DE BORRAR
        If e.Exception Is Nothing Then
            Me.Label2.Text = "Fila borrada"
        Else
            Me.Label2.Text = "Error"
            'no entra nunca
        End If
    End Sub

    Protected Sub GridView1_RowDeleting(sender As Object, e As GridViewDeleteEventArgs) Handles GridView1.RowDeleting
        'ANTES DE BORRAR
        If MsgBox("Desea borrar", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Cuidado") = MsgBoxResult.No Then
            'CANCELAR EL EVENTO
            e.Cancel = True
        End If
    End Sub
End Class
