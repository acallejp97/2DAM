
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Me.Label1.Text = "Hola Elorrieta"
            'La PRIMERA VEZ
        Else
            Me.Label1.Text = Now
            ' las SIGUIENTES
        End If

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Label2.Text = "Hello Word"
    End Sub
End Class
