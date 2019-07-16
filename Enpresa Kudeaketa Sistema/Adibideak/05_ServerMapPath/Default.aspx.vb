
Partial Class _Default
    Inherits System.Web.UI.Page

    
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Label1.Text = "Non dago irudia? " & Server.MapPath("Koala.jpg")
        Me.Label2.Text = "Non dago karpeta? " & Server.MapPath("micarpeta")
        Dim AppPath As String = System.AppDomain.CurrentDomain.BaseDirectory
        Me.Label3.Text = "Non dago aplikazioa? " & AppPath
        Me.Label4.Text = "Zein da nire ordenagailuaren host izena" & System.Net.Dns.GetHostName()
        Me.Label5.Text = "Zein da nire ordenagailuaren host izena" & Server.MachineName
    End Sub
End Class
