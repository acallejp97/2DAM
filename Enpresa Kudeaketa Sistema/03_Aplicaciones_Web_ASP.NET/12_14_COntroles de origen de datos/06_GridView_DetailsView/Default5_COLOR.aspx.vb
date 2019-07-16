
Partial Class Default5
    Inherits System.Web.UI.Page
    Protected Sub GridView1_RowDataBound(sender As Object, e As GridViewRowEventArgs) Handles GridView1.RowDataBound
        'El evento PRERENDER no tiene e.row
        'Se lanza cuando una fila de datos
        'se enlaza al GridView
        'EL DATO ESTA EN EL LABEL1 = TOTAL
        'La imagen es IMAGE1
        Try
            Dim aaa As Label = e.Row.FindControl("Label1")
            Dim cant As Double
            Dim bbb As Image = e.Row.FindControl("Image1")
            cant = Convert.ToDouble(aaa.Text)
            Select Case cant
                Case Is < 200
                    'e.Row.BackColor = Drawing.Color.AntiqueWhite 'FILA ENTERA
                    e.Row.Cells(4).BackColor = Drawing.Color.AntiqueWhite ' UNA CELDA
                    bbb.ImageUrl = "2.ICO"
                Case Is < 500
                    'e.Row.BackColor = Drawing.Color.Crimson
                    bbb.ImageUrl = "3.ICO"
                Case Else
                    'e.Row.BackColor = Drawing.Color.LightPink
                    bbb.ImageUrl = "4.ICO"
            End Select
        Catch ex As Exception

        End Try
    End Sub
End Class
