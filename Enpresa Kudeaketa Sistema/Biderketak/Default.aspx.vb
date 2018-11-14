
Partial Class _Default
    Inherits System.Web.UI.Page


    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim cont As Integer = 0
        Dim num As Integer = TextBox1.Text
        Dim texto As String


        For cont = 0 To 10
            Dim Trow1 As New TableRow
            Dim celda1 As New TableCell()
            Dim celda2 As New TableCell()
            texto = cont & " x " & num & " = "
            celda1.Text = texto
            Trow1.Cells.Add(celda1)
            texto = cont * num
            celda2.Text = texto
            Trow1.Cells.Add(celda2)
            Tablamulti.Rows.Add(Trow1)
        Next
    End Sub
End Class
