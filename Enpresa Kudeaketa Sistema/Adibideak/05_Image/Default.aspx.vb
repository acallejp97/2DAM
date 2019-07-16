
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        Me.Image1.ImageUrl = Me.DropDownList1.SelectedItem.Value
        ' Irudia aurkitzen ez ba du
        Me.Image1.AlternateText = Me.DropDownList1.SelectedItem.Text & " ez dago."
    End Sub
End Class
