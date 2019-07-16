
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Page.SetFocus("TextBox3") 'cuidado con las mayusculas y minusculas
        'Me.TextBox3.Focus()
    End Sub
End Class
