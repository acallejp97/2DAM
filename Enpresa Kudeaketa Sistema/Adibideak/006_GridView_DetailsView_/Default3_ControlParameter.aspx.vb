
Partial Class Default3_ControlParameter
    Inherits System.Web.UI.Page

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged
        Me.txtID.Text = Me.GridView1.SelectedRow.Cells(1).Text
        Me.txtNombre.Text = Me.GridView1.SelectedRow.Cells(2).Text.Replace("&nbsp;", "")
        Me.txtTelefono.Text = Me.GridView1.SelectedRow.Cells(3).Text.Replace("&nbsp;", "")
        Me.txtFoto.Text = Me.GridView1.SelectedRow.Cells(7).Text.Replace("&nbsp;", "")
        Me.txtCuota.Text = Me.GridView1.SelectedRow.Cells(6).Text.Replace("&nbsp;", "")
        Me.txtFecha.Text = Me.GridView1.SelectedRow.Cells(4).Text.Replace("&nbsp;", "")

        Dim cb As CheckBox = Me.GridView1.SelectedRow.Cells(5).Controls(0)
        Me.CheckBox1.Checked = cb.Checked
    End Sub


    Protected Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Try
            Me.AccessDataSource1.Delete()
            Me.Label2.Text = "Fila borrada"
        Catch ex As Exception
            Me.Label2.Text = "Error " & ex.Message
        End Try
    End Sub

    Protected Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        Try
            Me.AccessDataSource1.Insert()
            Me.Label2.Text = "Fila insertada"
        Catch ex As Exception
            Me.Label2.Text = "Error " & ex.Message
        End Try
    End Sub

    Protected Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            Me.AccessDataSource1.Update()
            Me.Label2.Text = "Fila modificada"
        Catch ex As Exception
            Me.Label2.Text = "Error " & ex.Message
        End Try
    End Sub
End Class
