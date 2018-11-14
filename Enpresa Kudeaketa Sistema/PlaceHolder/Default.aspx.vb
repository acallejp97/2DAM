
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub RadioButtonList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioButtonList1.SelectedIndexChanged
        Label1.Text = RadioButtonList1.SelectedValue
    End Sub
End Class
