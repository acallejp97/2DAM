
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub CheckBoxList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBoxList1.SelectedIndexChanged

        Me.ListBox1.Items.Clear()
        For Each li As ListItem In CheckBoxList1.Items
            If li.Selected Then
                Me.ListBox1.Items.Add(li.Text)
            End If
        Next

        If Me.CheckBoxList1.SelectedIndex = -1 Then
            Me.Label1.ForeColor = System.Drawing.Color.Green
        Else
            Me.Label1.ForeColor = System.Drawing.Color.Red
        End If

        Me.Label1.Text = Me.ListBox1.Items.Count & " items"
    End Sub

    Protected Sub ListBox1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Me.Label2.Text = Me.ListBox1.SelectedItem.Text
    End Sub
End Class
