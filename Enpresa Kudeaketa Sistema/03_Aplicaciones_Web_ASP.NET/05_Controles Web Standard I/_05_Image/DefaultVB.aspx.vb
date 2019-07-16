
Partial Class DefaultVB
    Inherits System.Web.UI.Page

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        Me.Image1.ImageUrl = Me.DropDownList1.SelectedItem.Value
        'en caso de que no lo encuentre la imagen
        Me.Image1.AlternateText = "NO ENCONTRADO"
    End Sub
End Class
