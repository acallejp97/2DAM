
Partial Class Default7_ABM
    Inherits System.Web.UI.Page

    Protected Sub ButtonBorrar_Click(sender As Object, e As EventArgs) Handles ButtonBorrar.Click
        Try
            Me.AccessDataSource1.Delete()
            Me.Label2.Text = "Fila borrada"
        Catch ex As Exception
            Me.Label2.Text = "Error " & ex.Message
        End Try
    End Sub

    Protected Sub ButtonModificar_Click(sender As Object, e As EventArgs) Handles ButtonModificar.Click
        Try
            Me.AccessDataSource1.Update()
            Me.Label2.Text = "Fila Modificada"
        Catch ex As Exception
            Me.Label2.Text = "Error " & ex.Message
        End Try
    End Sub

    Protected Sub ButtonInsertar_Click(sender As Object, e As EventArgs) Handles ButtonInsertar.Click
        Try
            Me.AccessDataSource1.Insert()
            Me.Label2.Text = "Fila Insertada"
        Catch ex As Exception
            Me.Label2.Text = "Error " & ex.Message
        End Try
    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged
        Me.TextBoxID.Text = Me.GridView1.SelectedRow.Cells(1).Text.Replace("&nbsp;", "")
        Me.TextBoxNombre.Text = Me.GridView1.SelectedRow.Cells(2).Text.Replace("&nbsp;", "")
        Me.TextBoxTelefono.Text = Me.GridView1.SelectedRow.Cells(3).Text.Replace("&nbsp;", "")
        Me.TextBoxFechNac.Text = Me.GridView1.SelectedRow.Cells(4).Text.Replace("&nbsp;", "")
        Dim aaa As CheckBox = Me.GridView1.SelectedRow.Cells(5).Controls(0)
        Me.TextBoxCuota.Text = Me.GridView1.SelectedRow.Cells(6).Text.Replace("&nbsp;", "")
        Me.TextBoxFoto.Text = Me.GridView1.SelectedRow.Cells(7).Text.Replace("&nbsp;", "")

        Me.CheckBoxCarnet.Checked = aaa.Checked
    End Sub
End Class
