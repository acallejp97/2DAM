
Partial Class Ejercicio_4
    Inherits System.Web.UI.Page

    Protected Sub CheckBoxList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBoxList1.SelectedIndexChanged
        Dim aaa As ListItem
        Dim acum As String = Nothing
        Dim count As Integer = 0
        ListBox1.Items.Clear()
        For Each aaa In Me.CheckBoxList1.Items
            If aaa.Selected Then
                acum &= aaa.Text & " "
                count += 1
            End If
        Next
        ListBox1.Items.Add(acum)
        Label1.Text = count & " Items"
    End Sub
End Class
