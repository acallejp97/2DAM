
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tabla As String = "<table border='1'>"
        Dim i, k As Integer
        For i = 1 To 10
            tabla += "<tr>"
            For k = 1 To 10
                tabla &= "<td>" & i * k & "<td>"

            Next k
            tabla &= "<tr>"
        Next i
        tabla &= "</table>"
        lblTabla.Text = tabla
    End Sub
End Class
