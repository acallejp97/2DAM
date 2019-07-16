
Partial Class Default4
    Inherits System.Web.UI.Page

    Protected Sub GridView1_RowDataBound(sender As Object, e As GridViewRowEventArgs) Handles GridView1.RowDataBound
        'El evento PRERENDER no tiene e.row
        'Se lanza cuando una fila de datos
        'se enlaza al GridView
        'EL DATO ESTA EN EL LABEL3
        Try
            Dim aaa As Label = e.Row.FindControl("Label3")
            Dim cant As Double
            cant = Convert.ToDouble(aaa.Text)
            Select Case cant
                Case Is < 200
                    e.Row.BackColor = Drawing.Color.AntiqueWhite
                Case Is < 500
                    e.Row.BackColor = Drawing.Color.Crimson
                Case Else
                    e.Row.BackColor = Drawing.Color.LightPink
            End Select
        Catch ex As Exception

        End Try
    End Sub
End Class
