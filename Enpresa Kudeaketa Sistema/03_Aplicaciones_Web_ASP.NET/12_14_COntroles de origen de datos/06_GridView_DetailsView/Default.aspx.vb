
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_PreRender(sender As Object, e As EventArgs) Handles Me.PreRender
        If Me.GridView1.SelectedIndex >= 0 Then
            Me.DetailsView1.Visible = True
        Else
            Me.DetailsView1.Visible = False
        End If
    End Sub

    Protected Sub DetailsView1_ItemDeleted(sender As Object, e As DetailsViewDeletedEventArgs) Handles DetailsView1.ItemDeleted
        Me.GridView1.DataBind()
        'DESELECCIONAR FILA
        Me.GridView1.SelectRow(-1)
    End Sub

    Protected Sub DetailsView1_ItemInserted(sender As Object, e As DetailsViewInsertedEventArgs) Handles DetailsView1.ItemInserted
        Me.GridView1.DataBind()
        'DESELECCIONAR FILA
        Me.GridView1.SelectRow(-1)
    End Sub

    Protected Sub DetailsView1_ItemUpdated(sender As Object, e As DetailsViewUpdatedEventArgs) Handles DetailsView1.ItemUpdated
        Me.GridView1.DataBind()
        'DESELECCIONAR FILA
        Me.GridView1.SelectRow(-1)
    End Sub


End Class
