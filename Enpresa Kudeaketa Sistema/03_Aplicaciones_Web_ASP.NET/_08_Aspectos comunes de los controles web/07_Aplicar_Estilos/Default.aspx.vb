
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim aaa As New Style
        aaa.BackColor = Drawing.Color.AliceBlue
        aaa.ForeColor = Drawing.Color.Bisque
        aaa.Font.Size = 18
        aaa.Font.Name = "Courier"

        Me.Label1.ApplyStyle(aaa)
    End Sub
End Class
