
Partial Class Default2
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If IsNumeric(TextBox1.Text) Then
            Dim numero As Double = Convert.ToDouble(TextBox1.Text)

            If numero > 0 Then
                RequiredFieldValidator1.IsValid = True
            Else
                RequiredFieldValidator1.IsValid = False
            End If
        Else
            RequiredFieldValidator1.IsValid = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox2.Text = TextBox3.Text And TextBox2.Text <> "Pepe" And TextBox3.Text <> "Pepe" Then
            CompareValidator1.IsValid = True
        Else
            CompareValidator1.IsValid = False
        End If
    End Sub

    Private Sub Button3_Load(sender As Object, e As EventArgs) Handles Button3.Load

    End Sub
End Class