
Partial Class _Default
    Inherits System.Web.UI.Page
    Dim orden As Integer
    'En vista CODIGO
    'Tenamos la página  y dentro tenemos el formulario
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Response.Write("Button1 -----> Click<br>")
    End Sub
    Protected Sub form1_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles form1.Init
        orden += 1
        Response.Write(orden & "Form1-Init <br>")
    End Sub

    Protected Sub form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles form1.Load
        orden += 1
        Response.Write(orden & "Form1-Load <br>")
    End Sub

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        orden += 1
        Response.Write(orden & "Page-Init <br>")
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        orden += 1
        Response.Write(orden & "Page-Load <br>")
    End Sub

    Protected Sub Page_LoadComplete(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LoadComplete
        orden += 1
        Response.Write(orden & "Page-LoadComplete <br>")
    End Sub
End Class
