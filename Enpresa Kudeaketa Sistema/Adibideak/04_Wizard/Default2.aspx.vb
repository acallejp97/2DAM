
Partial Class Default2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Me.Wizard1.ActiveStepIndex = 0
        End If
    End Sub

   
    Protected Sub Wizard1_FinishButtonClick(sender As Object, e As WizardNavigationEventArgs) Handles Wizard1.FinishButtonClick
        Me.Label1.Text = Me.TextBox1.Text & " -" & _
     Me.TextBox2.Text & " -" & _
     Me.TextBox3.Text

        Me.TextBox1.Text = ""
        Me.TextBox2.Text = ""
        Me.TextBox3.Text = ""
        Me.Wizard1.ActiveStepIndex = 0
    End Sub


    Protected Sub Page_PreRender(sender As Object, e As EventArgs) Handles Me.PreRender
        'Page_PreRender: coge el valor de las variables.
        'Despues del Load y antes de visualizar el Wizard
        If Me.Wizard1.ActiveStepIndex = 0 Then
            Me.TextBox1.Focus()
            Me.Wizard1.HeaderText = "Pagina 1"
        ElseIf Me.Wizard1.ActiveStepIndex = 1 Then
            Me.TextBox2.Focus()
            Me.Wizard1.HeaderText = "Pagina 2"
        Else
            Me.TextBox3.Focus()
            Me.Wizard1.HeaderText = "Pagina 3"
        End If
    End Sub
End Class
