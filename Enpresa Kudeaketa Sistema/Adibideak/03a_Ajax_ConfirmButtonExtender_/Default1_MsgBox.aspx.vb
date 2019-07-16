
Partial Class Default1_MsgBox
    Inherits System.Web.UI.Page

    Protected Sub GridView1_RowDeleted(sender As Object, e As GridViewDeletedEventArgs) Handles GridView1.RowDeleted
        If e.Exception Is Nothing Then
            Me.Label3.Text = "Lerroa ezabatu"
        Else
            Me.Label3.Text = "Errorea"
        End If
    End Sub

    Protected Sub GridView1_RowDeleting(sender As Object, e As GridViewDeleteEventArgs) Handles GridView1.RowDeleting
        Me.Label3.Text = Nothing
        If MsgBox("Ezabatu nahi duzu?", MsgBoxStyle.YesNo + _
            MsgBoxStyle.DefaultButton2, "Kontuz") = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class
