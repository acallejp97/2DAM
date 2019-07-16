
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged, RadioButton3.CheckedChanged
        'sender es el evento que genera el objeto
        Me.Label1.Text = sender.ID
    End Sub

    Protected Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged, RadioButton5.CheckedChanged
        Me.Label2.Text = sender.ID
    End Sub
End Class
