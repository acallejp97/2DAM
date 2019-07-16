
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Menu1_MenuItemClick(sender As Object, e As MenuEventArgs) Handles Menu1.MenuItemClick
        If Me.Menu1.SelectedItem.ChildItems.Count = 0 Then
            Me.Label3.Text = Me.Menu1.SelectedItem.Text
        Else
            Me.Label3.Text = ""
        End If


    End Sub
End Class
