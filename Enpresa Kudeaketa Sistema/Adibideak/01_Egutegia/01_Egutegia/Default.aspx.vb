
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Calendar1_SelectionChanged(sender As Object, e As EventArgs) Handles Calendar1.SelectionChanged
        Me.Label1.Text = Me.Calendar1.SelectedDate.ToShortDateString
    End Sub
End Class
