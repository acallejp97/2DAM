
Partial Class DefaultVB
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim suma As Double
        suma = Me.DropDownList1.SelectedItem.Value
        Me.lblResultado.Text = suma
        Dim item As ListItem
        For Each item In Me.CheckBoxList1.Items
            If item.Selected Then
                suma += item.Value
            End If
        Next
        Me.lblResultado.Text = "PRECIO FINAL: " & suma & " €"
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'con LINQ
        Dim suma As Double

        suma = Me.DropDownList1.SelectedItem.Value
        suma += (From item In Me.CheckBoxList1.Items
              Where item.Selected
              Select Integer.Parse(item.value)).Sum()

        Me.lblResultado.Text = "PRECIO FINAL: " & suma & " €"
    End Sub
End Class
