
Partial Class Default_VB
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Label1.Text = "Prezioa " & Me.DropDownList1.SelectedItem.Text & _
            "rako <b>" & Me.DropDownList1.SelectedItem.Value & "</b> eurokoa da."
    End Sub
End Class
