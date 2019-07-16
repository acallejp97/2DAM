
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '1. moduan
        Dim x As ListItem
        Dim cadena As String = Nothing
        For Each x In ListBox1.Items
            If x.Selected Then
                cadena += x.Text & "<br>"
            End If
        Next
        Label2.Text = cadena


        '2. moduan
        cadena = Nothing
        Dim y As Integer
        For y = 0 To Me.ListBox1.Items.Count - 1
            If Me.ListBox1.Items(y).Selected Then
                cadena += Me.ListBox1.Items(y).Text & "<br>"
            End If
        Next
        Label3.Text = cadena
    End Sub

End Class
