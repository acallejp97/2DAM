
Partial Class _Default
    Inherits System.Web.UI.Page


    Protected Sub ImageButton1_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton1.Click
        Dim a, b As Double
        Dim c As String
        If TextBox1.Text = Nothing Then
            TextBox1.Text = 0
            a = 0
        Else
            a = TextBox1.Text
        End If
        If TextBox2.Text = Nothing Then
            TextBox2.Text = 0
            b = 0
        Else
            b = TextBox2.Text
        End If
        If b = 0 Then
            c = "∞"
        Else
            c = (a / b)
        End If

        Result.Text = c
    End Sub

    Protected Sub LinkButton1_Click(sender As Object, e As EventArgs) Handles LinkButton1.Click
        Dim a, b, c As Double
        If TextBox1.Text = Nothing Then
            TextBox1.Text = 0
            a = 0
        Else
            a = TextBox1.Text
        End If
        If TextBox2.Text = Nothing Then
            TextBox2.Text = 0
            b = 0
        Else
            b = TextBox2.Text
        End If
        c = a + b
        Result.Text = c
    End Sub

End Class
