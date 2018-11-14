
Partial Class Ejercicio_6
    Inherits System.Web.UI.Page

  
    Protected Sub GridView1_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GridView1.RowDataBound
        Try
            If IsNumeric(e.Row.Cells(4).Text) Then
                If e.Row.Cells(4).Text Mod 2 = 0 Then
                    e.Row.BackColor = Drawing.Color.Magenta
                Else
                    e.Row.BackColor = Drawing.Color.LimeGreen
                End If
            Else
                e.Row.BackColor = Drawing.Color.Tomato
            End If


        Catch ex As Exception

        End Try
        If e.Row.Cells(4).Text = "PostalCode" Then
            e.Row.BackColor = Drawing.Color.White
        End If
    End Sub

    Protected Sub GridView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.SelectedIndexChanged

    End Sub
End Class
