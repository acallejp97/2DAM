
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Wizard1_FinishButtonClick(sender As Object, e As WizardNavigationEventArgs) Handles Wizard1.FinishButtonClick
        Me.Label1.Text = Me.TextBox1.Text & " " & Me.TextBox2.Text
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
End Class
