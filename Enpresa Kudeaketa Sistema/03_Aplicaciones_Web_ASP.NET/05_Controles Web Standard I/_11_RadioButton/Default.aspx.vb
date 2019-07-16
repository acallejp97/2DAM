
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged, RadioButton3.CheckedChanged
        If Me.RadioButton1.Checked Then
            Me.Label1.Text = Me.RadioButton1.ID
        ElseIf Me.RadioButton2.Checked Then
            Me.Label1.Text = Me.RadioButton2.ID
        Else
            Me.Label1.Text = Me.RadioButton3.ID
        End If
    End Sub

    Protected Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged, RadioButton5.CheckedChanged
        If Me.RadioButton4.Checked Then
            Me.Label2.Text = Me.RadioButton4.ID
        Else
            Me.Label2.Text = Me.RadioButton5.ID
        End If
    End Sub
End Class
