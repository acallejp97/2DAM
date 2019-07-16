
Partial Class Default3
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Calendar1.SelectedDate = "01/10/2017"
        Me.Calendar1.SelectedDayStyle.BackColor = Drawing.Color.Green
        Me.Calendar1.SelectedDayStyle.ForeColor = Drawing.Color.Red

        Me.Calendar2.SelectedDates.Add("03/10/2017")
        Me.Calendar2.SelectedDates.Add("04/10/2017")
        Me.Calendar2.SelectedDates.Add("05/10/2017")
        Me.Calendar2.SelectedDayStyle.BackColor = Drawing.Color.Green
        Me.Calendar2.SelectedDayStyle.ForeColor = Drawing.Color.Red

        Me.Calendar3.SelectedDates.SelectRange("07/10/2017", "16/10/2017")
        Me.Calendar3.SelectedDayStyle.BackColor = Drawing.Color.Green
        Me.Calendar3.SelectedDayStyle.ForeColor = Drawing.Color.Red

        Dim fechas(2) As Date
        fechas(0) = "02/10/2017"
        fechas(1) = "03/10/2017"
        fechas(2) = "04/10/2017"

        For Each x In fechas
            Me.Calendar3.SelectedDates.Add(x)
        Next

    End Sub
End Class
