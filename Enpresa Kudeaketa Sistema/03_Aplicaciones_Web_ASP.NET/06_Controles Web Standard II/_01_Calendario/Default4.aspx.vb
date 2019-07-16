
Partial Class Default4
    Inherits System.Web.UI.Page

    Protected Sub Calendar1_DayRender(sender As Object, e As DayRenderEventArgs) Handles Calendar1.DayRender
        If e.Day.IsWeekend Then
            e.Cell.BackColor = Drawing.Color.Green
            e.Day.IsSelectable = False
        End If

    End Sub

    Protected Sub ImageButton1_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton1.Click
        Calendar1.Visible = True
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Calendar1.Visible = False
    End Sub

    Protected Sub Calendar1_SelectionChanged(sender As Object, e As EventArgs) Handles Calendar1.SelectionChanged
        Label1.Text = Me.Calendar1.SelectedDate.ToShortDateString
    End Sub


End Class
