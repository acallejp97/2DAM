
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Label1.Text = Server.MapPath("Koala.jpg")
        Me.Label2.Text = Server.MapPath("micarpeta")

        'NO ENTRA

        Dim AppPath As String = System.AppDomain.CurrentDomain.BaseDirectory
        Me.Label3.Text = AppPath 'C:\Users\infjgonzalez\desktop\aaa

        Me.Label4.Text = System.Net.Dns.GetHostName() 'B075829

    End Sub
End Class
