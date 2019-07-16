
Partial Class Default3
    Inherits System.Web.UI.Page

   

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged
        Me.TextBox1.Text = Me.GridView1.SelectedRow.Cells(3).Text
        Me.TextBox2.Text = Me.GridView1.SelectedRow.Cells(4).Text
        Me.TextBox3.Text = Me.GridView1.SelectedRow.Cells(2).Text
    End Sub
End Class
