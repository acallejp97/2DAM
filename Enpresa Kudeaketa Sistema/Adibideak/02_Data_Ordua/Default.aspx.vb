
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Label1.Text = Date.Now.ToShortDateString
        Me.Label2.Text = Date.Now.ToLongDateString

        Me.Label3.Text = Date.Now.ToShortTimeString
        Me.Label4.Text = Date.Now.ToLongTimeString ' Segundoekin

        Me.Label5.Text = Date.Now.ToString 'Data eta ordua
        Me.Label6.Text = Date.Now.ToString("MM/dd/yyyy")
        Me.Label7.Text = Date.Now.ToString("hh:mm:ss")

    End Sub
End Class
