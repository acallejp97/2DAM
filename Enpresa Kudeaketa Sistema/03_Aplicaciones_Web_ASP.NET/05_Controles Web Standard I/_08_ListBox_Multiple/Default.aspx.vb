
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim x As ListItem
        Dim acum As String = Nothing

        For Each x In Me.ListBox1.Items
            If x.Selected Then
                acum &= x.Text & "<br/>"
            End If
        Next
        Me.Label2.Text = acum

        acum = Nothing

        For i = 0 To Me.ListBox1.Items.Count - 1
            If Me.ListBox1.Items(i).Selected Then
                acum &= Me.ListBox1.Items(i).Text + "<br/>"
            End If
        Next
        Me.Label2.Text = acum

    End Sub
End Class
