
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub ImageButton1_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton1.Click
        Me.Label1.Text = Me.TextBox1.Text & " / " & Me.TextBox2.Text
    End Sub


    Protected Sub LinkButton1_Click(sender As Object, e As EventArgs) Handles LinkButton1.Click
        Me.Label1.Text = Convert.ToInt32(Me.TextBox1.Text) + Convert.ToInt32(Me.TextBox2.Text)
    End Sub
End Class
