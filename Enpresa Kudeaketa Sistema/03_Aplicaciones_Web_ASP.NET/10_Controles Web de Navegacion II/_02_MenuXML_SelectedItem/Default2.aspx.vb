
Partial Class Default2
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Menu1.StaticHoverStyle.BackColor = Drawing.Color.DarkRed

        Me.Menu1.DynamicHoverStyle.BackColor = Drawing.Color.Chartreuse
    End Sub
End Class
