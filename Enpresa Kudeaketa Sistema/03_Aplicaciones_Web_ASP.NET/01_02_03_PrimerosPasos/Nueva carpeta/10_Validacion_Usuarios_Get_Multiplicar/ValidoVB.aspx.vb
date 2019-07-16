
Partial Class ValidoVB
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim acum As String = "Valido <br>"
        acum += Me.Request.QueryString("aaa")
        acum += " --- " + Me.Request.QueryString("bbb")
        Me.Label1.Text = acum

        'Tabla Multiplicar
        Dim tabla As String = "<table border='1'>"
        Dim i, k As Integer
        k = Convert.ToInt32(Me.Request.QueryString("ccc"))
        For i = 1 To 10
            tabla &= "<tr>"
            tabla &= "<td>" & k & "*" & i & "= " & "</td>"
            tabla &= "<td>" & i * k & "</td>"
            tabla &= "</tr>"
        Next i
        tabla += "</table>"
        Me.Label2.Text = tabla

    End Sub
End Class
