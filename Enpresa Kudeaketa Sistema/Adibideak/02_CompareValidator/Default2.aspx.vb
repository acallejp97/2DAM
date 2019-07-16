
Partial Class Default2
    Inherits System.Web.UI.Page

    Protected Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Me.CompareValidator1.Operator = Me.ListBox1.SelectedIndex
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Botoia.Click
        If Me.IsValid Then
            Me.Label1.Text = "Balidatua"
        Else
            Me.Label1.Text = "Errorea"
        End If
    End Sub
End Class
