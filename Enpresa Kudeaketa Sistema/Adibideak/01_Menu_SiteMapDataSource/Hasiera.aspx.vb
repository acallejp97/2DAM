
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub DropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownList1.SelectedIndexChanged
        Me.Menu1.Orientation = Me.DropDownList1.SelectedValue
        ' COLORINES
        Me.Menu1.StaticPopOutImageUrl = "Gezia.gif"
        Me.Menu1.DynamicPopOutImageUrl = "Down.gif"

        Me.Menu1.DynamicBottomSeparatorImageUrl = "marra2.png"
    End Sub

    'DynamicPopOutImageUrl: dinamiko den elementu batek submenuak dituela adierazteko 
    'StaticPopOutImageUrl: estatiko den elementu batek submenuak dituela adierazteko 
    'DynamicBottomSeparatorImageUrl/StaticBottomSeparatorImageUrl: elementuen azpian agertzen da besteetatik banatzeko

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.Menu1.Orientation = Orientation.Vertical
    End Sub
End Class
