
Partial Class Default4
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Me.Calendar1.Visible = False
            Me.Calendar1.VisibleDate = "01/10/2017"
        End If
    End Sub

    Protected Sub ImageButton1_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton1.Click
        Me.Calendar1.Visible = Not Me.Calendar1.Visible
    End Sub

    Protected Sub Calendar1_DayRender(sender As Object, e As DayRenderEventArgs) Handles Calendar1.DayRender
        'Si es un fin de semana  no es seleccionable.
        If e.Day.Date.Day = 1 Then
            e.Cell.Text = "X" ' la celda no es seleccionable
            ' e.Day.IsSelectable = False
        End If
        If (e.Day.IsWeekend Or e.Day.Date.Day Mod 2 = 0) Then
            e.Cell.BackColor = Drawing.Color.Green
            e.Cell.Text = "X" ' la celda no es seleccionable
            ' e.Day.IsSelectable = False  ' NO HACE FALTA
        End If
    End Sub

    Protected Sub Calendar1_SelectionChanged(sender As Object, e As EventArgs) Handles Calendar1.SelectionChanged
        Me.Label1.Text = Me.Calendar1.SelectedDate.ToShortDateString
        Me.Calendar1.Visible = False
    End Sub
End Class
