

Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Label2.Text = Now
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Me.Label1.Text = "Behin baino ez da kargatu orrialdea."
        Else
            
            Me.Label1.Text = "Behin baino gehiagotan kargatu da orrialdea"
        End If
    End Sub
End Class
