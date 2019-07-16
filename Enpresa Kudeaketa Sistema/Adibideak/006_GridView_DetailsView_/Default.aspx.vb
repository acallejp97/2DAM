
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub DetailsView1_ItemDeleted(sender As Object, e As DetailsViewDeletedEventArgs) Handles DetailsView1.ItemDeleted
        Me.GridView1.DataBind()
        'se vuelve a cargar el gridview
        Me.GridView1.SelectRow(-1)
        'no se selecciona ninguna fila
    End Sub

    Protected Sub DetailsView1_ItemInserted(sender As Object, e As DetailsViewInsertedEventArgs) Handles DetailsView1.ItemInserted
        Me.GridView1.DataBind()
        'se vuelve a cargar el gridview
        Me.GridView1.SelectRow(-1)
        'no se selecciona ninguna fila
    End Sub

    
    Protected Sub DetailsView1_ItemUpdated(sender As Object, e As DetailsViewUpdatedEventArgs) Handles DetailsView1.ItemUpdated
        Me.GridView1.DataBind()
        'se vuelve a cargar el gridview
        Me.GridView1.SelectRow(-1)
        'no se selecciona ninguna fila
    End Sub

  
    Protected Sub Page_PreRender(sender As Object, e As EventArgs) Handles Me.PreRender
        'En el DetailView he puesto formato automatico: azucar moreno
        If Me.GridView1.SelectedIndex > -1 Then
            Me.DetailsView1.Visible = True
        Else
            Me.DetailsView1.Visible = False
        End If
    End Sub

   
 
End Class
