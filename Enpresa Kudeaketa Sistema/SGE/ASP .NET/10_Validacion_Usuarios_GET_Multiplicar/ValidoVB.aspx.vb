
Partial Class ValidoVB
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim acum As String
        acum = Me.Request.QueryString("aaaa")
        acum += " --- " + Me.Request.QueryString("bbbb")
        Me.Label2.Text = acum
        'Me.Label2.Text = Me.Request.QueryString("USUARIO: " + "aaaa")
        'Me.Label3.Text = Me.Request.QueryString("PASSWORD: " + "bbbb")
        Dim tabla As String = "<table border='1'>"
        Dim i As Integer
        Dim num As Integer
        num = Me.Request.QueryString("cccc")

        For i = 1 To 10
            tabla += "<tr>"
            tabla &= "<td>" & i & " x " & num & "</td>"
            tabla &= "<td>" & i * num & "</td>"

            tabla &= "</tr>"
        Next i
        tabla &= "</table>"
        txtNumero.Text = tabla
    End Sub
End Class
