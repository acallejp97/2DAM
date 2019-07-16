
Partial Class Default3
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.Calendar1.SelectedDate = "13/11/2017"
        Me.Calendar1.SelectedDayStyle.BackColor = Drawing.Color.Aquamarine
        Me.Calendar1.SelectedDayStyle.ForeColor = Drawing.Color.BlanchedAlmond

        Me.Calendar1.SelectedDates.Add("20/11/2017")
        Me.Calendar1.SelectedDates.Add("21/11/2017")

        Me.Calendar2.SelectedDates.SelectRange("27/11/2017", "30/11/2017")

        Dim fechas(2) As Date
        fechas(0) = "14/11/2017"
        fechas(1) = "16/11/2017"
        fechas(2) = "17/11/2017"

        For Each x In fechas
            Me.Calendar3.SelectedDates.Add(x)
        Next

    End Sub
End Class
