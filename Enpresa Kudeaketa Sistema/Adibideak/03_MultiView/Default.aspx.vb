
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        'Me.MultiView1.ActiveViewIndex = Me.DropDownList1.SelectedIndex
        'Me.Label4.Text = Me.DropDownList1.SelectedItem.Text
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' If Not Page.IsPostBack Then
        Me.MultiView1.ActiveViewIndex = Me.DropDownList1.SelectedIndex
        Me.Label4.Text = Me.DropDownList1.SelectedItem.Text
        ' End If
    End Sub
End Class
