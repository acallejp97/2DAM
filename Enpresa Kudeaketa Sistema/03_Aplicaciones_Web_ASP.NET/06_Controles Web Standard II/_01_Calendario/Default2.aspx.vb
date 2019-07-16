
Partial Class Default2
    Inherits System.Web.UI.Page

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        Select Case Me.DropDownList1.SelectedIndex
            Case 0
                Me.Calendar1.SelectionMode = CalendarSelectionMode.None
            Case 1
                Me.Calendar1.SelectionMode = CalendarSelectionMode.Day
            Case 2
                Me.Calendar1.SelectionMode = CalendarSelectionMode.DayWeek
            Case 3
                Me.Calendar1.SelectionMode = CalendarSelectionMode.DayWeekMonth
        End Select


    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim acum As String = ""
        Dim x As Date
        For Each x In Me.Calendar1.SelectedDates
            acum &= x & "" & "</br>"
        Next
        Me.lblResultado.Text = acum

    End Sub
End Class
