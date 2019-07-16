
Partial Class Default2
    Inherits System.Web.UI.Page

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        Me.CompareValidator1.Operator = Me.DropDownList1.SelectedIndex
    End Sub
End Class
