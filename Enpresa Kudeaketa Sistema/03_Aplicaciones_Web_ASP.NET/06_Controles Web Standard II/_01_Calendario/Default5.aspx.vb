
Partial Class Default5
    Inherits System.Web.UI.Page

    Protected Sub Calendar1_DayRender(sender As Object, e As DayRenderEventArgs) Handles Calendar1.DayRender

        If e.Day.Date.Day = 1 Then
            e.Cell.Text = "X"
            e.Day.IsSelectable = False
        End If

        If (e.Day.IsWeekend Or e.Day.Date.Day Mod 2 = 0) Then
            e.Cell.BackColor = Drawing.Color.Green
            e.Cell.Text = "X" 'la celda no es seleccionable
            'e.Day.IsSelectable= False  - NO HACE FALTA
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
