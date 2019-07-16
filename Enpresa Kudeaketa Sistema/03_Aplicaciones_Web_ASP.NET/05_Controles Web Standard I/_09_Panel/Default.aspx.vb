
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Me.Panel1.Visible = False
            Me.Panel2.Visible = False
        End If

    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged


        If DropDownList1.SelectedItem.Text = "Administrador" Then
            Me.Panel1.Visible = True
            Me.Panel2.Visible = False
        ElseIf DropDownList1.SelectedItem.Text = "Usuario" Then
            Me.Panel1.Visible = False
            Me.Panel2.Visible = True
        Else
            Me.Panel1.Visible = False
            Me.Panel2.Visible = False
        End If
    End Sub
End Class
