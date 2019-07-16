
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        Me.MultiView1.ActiveViewIndex = Me.DropDownList1.SelectedIndex
        Me.Label4.Text = "Propiedad TEXT:" & Me.DropDownList1.SelectedItem.Text
    End Sub
End Class
