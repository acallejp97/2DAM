Imports System.Drawing
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim estilo, estilo2 As New Style()

        estilo.BorderColor = Color.Green
        estilo.BorderStyle = BorderStyle.Dashed
        estilo.ForeColor = Color.Blue
        estilo.BackColor = Color.Pink
        estilo.Font.Name = "Courier"
        estilo.Font.Size = 14
        estilo.Font.Italic = True

        Me.Label1.ApplyStyle(estilo)

        estilo2.BorderColor = Color.Red
        estilo2.BorderStyle = BorderStyle.Dotted
        estilo2.ForeColor = Color.Green
        estilo2.BackColor = Color.Blue
        estilo2.Font.Name = "verdana"
        estilo2.Font.Size = 12
        estilo2.Font.Italic = False
        Me.Label2.ApplyStyle(estilo2)

    End Sub
End Class
