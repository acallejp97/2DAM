Imports System.Drawing

Partial Class Default2
    Inherits System.Web.UI.Page
    ' XML erabili barik menuak ezartzen ditugu
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        '1.MAILAKO menu item "Inicio"
        Menu1.StaticHoverStyle.BackColor = Color.Crimson
        Menu1.StaticHoverStyle.ForeColor = Color.Snow
        Menu1.StaticHoverStyle.Font.Size = FontUnit.Large
        Menu1.StaticHoverStyle.Font.Name = "Comic Sans MS"
        '2. eta 3. mailako orriak
        Menu1.DynamicHoverStyle.BackColor = Color.Chocolate
    End Sub
End Class
