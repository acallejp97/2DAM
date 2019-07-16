
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If Me.CheckBox1.Checked Then
            Me.Label2.Text = "Aukeratuta"
        Else
            Me.Label2.Text = "Ez aukeratuta"
        End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.CheckBox1.Checked Then
            Me.Label1.Text = "Aukeratuta"
        Else
            Me.Label1.Text = "Ez aukeratuta"
        End If
    End Sub
End Class
