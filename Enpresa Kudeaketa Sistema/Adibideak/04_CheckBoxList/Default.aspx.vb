
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'MODU 1
        Dim aaa As ListItem
        Dim acum As String = Nothing
        For Each aaa In Me.CheckBoxList1.Items
            If aaa.Selected Then
                acum &= aaa.Text & "<br>"
            End If
        Next

        Me.Label1.Text = acum

        'MODU 2
        acum = Nothing
        For x = 0 To Me.CheckBoxList1.Items.Count - 1
            If Me.CheckBoxList1.Items(x).Selected Then
                acum &= Me.CheckBoxList1.Items(x).Text & "<br>"
            End If
        Next
        Me.Label1.Text = acum

    End Sub

    Protected Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If Me.CheckBox1.Checked Then
            Me.CheckBoxList1.RepeatDirection = RepeatDirection.Horizontal
        Else
            Me.CheckBoxList1.RepeatDirection = RepeatDirection.Vertical
        End If
    End Sub

    Protected Sub CheckBoxList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckBoxList1.SelectedIndexChanged

    End Sub
End Class
