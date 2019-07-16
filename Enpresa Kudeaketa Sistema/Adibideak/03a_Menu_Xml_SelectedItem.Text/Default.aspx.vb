
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Menu_MenuItemClick(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.MenuEventArgs) Handles Menu.MenuItemClick
        '<LevelMenuItemStyles> eta  <levelselectedstyles> erabiliko ditugu
        'LevelMenuItemStyles bilduma erabili, DynamicMenuItemStyle eta antzekoen ordez, maila oso kontrolatzeko
        'bilduma horretan dauden estiloak mailaren arabera ezartzen dira. (1., 2. eta abar)

        If e.Item.ChildItems.Count = 0 Then
            Me.seleccion.Text = "Aukeratu duzu: " & e.Item.Text
        Else
            Me.seleccion.Text = ""
        End If
    End Sub
   
End Class
