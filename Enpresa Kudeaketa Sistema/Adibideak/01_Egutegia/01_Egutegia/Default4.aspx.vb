
Partial Class Default4
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Me.Calendar1.Visible = False
        End If
    End Sub

    Protected Sub ImageButton1_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton1.Click
        Me.Calendar1.Visible = Not Me.Calendar1.Visible
    End Sub

    Protected Sub Calendar1_DayRender(sender As Object, e As DayRenderEventArgs) Handles Calendar1.DayRender
        'Si es un fin de semana  no es seleccionable.
        If e.Day.IsWeekend Then
            e.Cell.BackColor = Drawing.Color.Green
            e.Day.IsSelectable = False
        End If
    End Sub

    Protected Sub Calendar1_SelectionChanged(sender As Object, e As EventArgs) Handles Calendar1.SelectionChanged
        Me.Label1.Text = Me.Calendar1.SelectedDate.ToShortDateString
        Me.Calendar1.Visible = False
    End Sub
End Class
