Public Class Form1

    Private Sub btnEjecutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEjecutar.Click
        'InStr("<non bilatu>", "<Zer bilatu>")
        ' Replace("<non bilatu>", "<Zer bilatu>", "<karaktere berriak>")
        If InStr(Me.TextBox1.Text, Me.TextBox2.Text) > 0 Then
            Me.Label4.Text = InStr(Me.TextBox1.Text, Me.TextBox2.Text)
            Me.Label5.Text = Replace(Me.TextBox1.Text, Me.TextBox2.Text, Me.TextBox3.Text)
        End If
    End Sub
End Class
