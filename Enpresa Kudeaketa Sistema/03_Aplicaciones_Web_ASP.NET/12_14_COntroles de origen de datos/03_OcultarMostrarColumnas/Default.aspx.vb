
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub aaa(sender As Object, e As EventArgs) Handles LinkButton1.Click, LinkButton2.Click, LinkButton3.Click

        Me.Label2.Text = sender.id

        If sender.id = "LinkButton1" Then
            Me.GridView1.Columns(0).Visible = Not Me.GridView1.Columns(0).Visible
            If Me.GridView1.Columns(0).Visible = True Then
                Me.LinkButton1.Text = "Ocultar seleccion"
            Else
                Me.LinkButton1.Text = "Mostrar seleccion"
            End If
        ElseIf sender.id = "LinkButton2" Then
            Me.GridView1.Columns(1).Visible = Not Me.GridView1.Columns(1).Visible
            If Me.GridView1.Columns(1).Visible = True Then
                Me.LinkButton2.Text = "Ocultar seleccion"
            Else
                Me.LinkButton2.Text = "Mostrar seleccion"
            End If
        ElseIf sender.id = "LinkButton3" Then
            Me.GridView1.Columns(2).Visible = Not Me.GridView1.Columns(2).Visible
            If Me.GridView1.Columns(2).Visible = True Then
                Me.LinkButton3.Text = "Ocultar seleccion"
            Else
                Me.LinkButton3.Text = "Mostrar seleccion"
            End If
        End If
    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged
        Me.Label2.Text = Me.GridView1.SelectedRow.Cells(1).Text
    End Sub
End Class
