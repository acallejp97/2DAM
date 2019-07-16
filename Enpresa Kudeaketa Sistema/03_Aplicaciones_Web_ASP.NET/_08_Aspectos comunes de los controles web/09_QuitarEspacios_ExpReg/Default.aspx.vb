
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Label1.Text =
            New Regex("\s*").Replace(TextBox1.Text, String.Empty)
        ' Label1.Text =New Regex(@"s*").Replace(TextBox1.Text, String.Empty);   C#
    End Sub
End Class
