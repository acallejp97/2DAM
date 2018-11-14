
Partial Class Ejercicio_1
    Inherits System.Web.UI.Page

    Protected Sub GridView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.SelectedIndexChanged
        Me.TextBox1.Text = Me.GridView1.SelectedRow.Cells(3).Text.Replace("&nbsp;", "")
        Me.TextBox2.Text = Me.GridView1.SelectedRow.Cells(4).Text.Replace("&nbsp;", "")
        Me.TextBox3.Text = Me.GridView1.SelectedRow.Cells(2).Text.Replace("&nbsp;", "")

    End Sub
End Class
