
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Wizard1_FinishButtonClick(sender As Object, e As WizardNavigationEventArgs) Handles Wizard1.FinishButtonClick
        Me.Label1.Text = Me.TextBox1.Text & "<br/>" &
        Me.TextBox2.Text & "<br/>" &
        Me.TextBox3.Text
    End Sub




    Private Sub TextBox1_PreRender(sender As Object, e As EventArgs) Handles TextBox1.PreRender
        TextBox1.Focus()
    End Sub

    Private Sub TextBox2_PreRender(sender As Object, e As EventArgs) Handles TextBox2.PreRender
        TextBox2.Focus()
    End Sub

    Private Sub TextBox3_PreRender(sender As Object, e As EventArgs) Handles TextBox3.PreRender
        TextBox3.Focus()
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Cuando carga el sitio el paso por defecto es 0
        'If Not Page.IsPostBack Then
        'Me.Wizard1.ActiveStepIndex = 0
        'End If
    End Sub

    Protected Sub Page_PreRender(sender As Object, e As EventArgs) Handles Me.PreRender
        'Page_PreRender: Coge el valor de las variabvles.
        'Despues del Load y antes de visualizar el Wizard
        'If Me.Wizard1.ActiveStepIndex = 0 Then
        '    Me.TextBox1.Focus()
        '    Me.Wizard1.HeaderText = "Pagina 1"
        'ElseIf Me.Wizard1.ActiveStepIndex = 1 Then
        '    Me.TextBox1.Focus()
        '    Me.Wizard1.HeaderText = "Pagina 2"
        'Else
        '    Me.TextBox1.Focus()
        '    Me.Wizard1.HeaderText = "Pagina 3"
        'End If
    End Sub
End Class
