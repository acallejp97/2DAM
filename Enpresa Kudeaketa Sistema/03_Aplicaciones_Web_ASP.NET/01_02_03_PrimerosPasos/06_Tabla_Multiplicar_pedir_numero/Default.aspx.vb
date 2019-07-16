
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tabla As String = "<table border='1'>"
        Dim i As Integer
        Dim k As String

        k = TextBox1.Text

        For i = 1 To 10
            tabla += "<tr>"

            tabla &= "<td>" & i & " * " & k & " = " & "</td>"
            tabla &= "<td>" & i * k & "</td>"

            tabla &= "</tr>"
        Next
        tabla &= "</table>"
        Label1.Text = tabla
    End Sub
End Class
