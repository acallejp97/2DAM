
Partial Class Default6
    Inherits System.Web.UI.Page

    
    
    Protected Sub GridView1_RowDataBound(sender As Object, e As GridViewRowEventArgs) Handles GridView1.RowDataBound
        'El evento PRERENDER no tiene e.row
        'Se lanza cuando una fila de datos
        'se enlaza al GridView
        'EL DATO ESTA EN EL LABEL1 = TOTAL
        'La imagen es IMAGE1


        Try
            Dim postalCode As Integer = e.Row.Cells(4).Text
            If postalCode Mod 2 = 0 Then
                e.Row.BackColor = Drawing.Color.Yellow 'FILA ENTERA
            Else
                e.Row.BackColor = Drawing.Color.Red
            End If
        Catch ex As Exception
            e.Row.BackColor = Drawing.Color.Blue
        End Try
    End Sub
End Class
