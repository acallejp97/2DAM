
Partial Class Default3
    Inherits System.Web.UI.Page

    Protected Sub CheckBoxList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckBoxList1.SelectedIndexChanged
        Dim x As ListItem
        Dim count As Integer
        ListBox1.Items.Clear()

        For Each x In Me.CheckBoxList1.Items
            If x.Selected Then
                ListBox1.Items.Add(x.Text)
                count += 1
            End If
        Next

        Label3.Text = count & " Items"

        If count = 0 Then
            Label3.ForeColor = Drawing.Color.Green
        Else
            Label3.ForeColor = Drawing.Color.Red
        End If

    End Sub

    Protected Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Label4.Text = sender.text
    End Sub

End Class
