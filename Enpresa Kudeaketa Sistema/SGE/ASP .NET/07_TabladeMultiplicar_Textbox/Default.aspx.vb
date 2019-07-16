
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tabla As String = "<table border='1'>"
        Dim i As Integer
        Dim num As Integer
        num = TextBox1.Text

        For i = 1 To 10
            tabla += "<tr>"
            tabla &= "<td>" & i & " x " & num & "<td>"
            tabla &= "<td>" & i * num & "<td>"

            tabla &= "<tr>"
        Next i
        tabla &= "</table>"
        lblTabla.Text = tabla
    End Sub
End Class
