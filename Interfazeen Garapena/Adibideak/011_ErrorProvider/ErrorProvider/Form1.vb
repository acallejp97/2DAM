Public Class Form1

    Private Sub TextBox1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TextBox1.Validating
        'Tb funciona

        If Not IsNumeric(Me.TextBox1.Text) Then
            Me.ErrorProvider1.BlinkRate = 200     '
            Me.ErrorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            Me.ErrorProvider1.SetError(TextBox1, "Sartu duzun datua ez da egokia.")
            e.Cancel = True 'Fokoa ez galtzeko
        Else
            Me.Label1.Text = "Ondo eginda!"
            Me.ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
