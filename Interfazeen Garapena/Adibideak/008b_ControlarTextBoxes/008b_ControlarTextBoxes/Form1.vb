Public Class Form1

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress

        If InStr("0123456789.,-", e.KeyChar) = 0 Then
            e.Handled = True
        Else
            'Onartuta ez dago. Ezabatu sartutako karakterea
            SendKeys.Send(Chr(8))
        End If

        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            ' Me.TextBox2.Focus()
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False 'Onartuta
        ElseIf Char.IsNumber(e.KeyChar) Then
            e.Handled = False 'Onartuta
        ElseIf Char.IsControl(e.KeyChar) Then
            'Atzerantz joan
            e.Handled = False 'Onartuta
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False ''Onartuta
        Else
            e.Handled = True 'Ez dago onartuta
            Exit Sub
        End If
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            ' Me.TextBox2.Focus()
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        'Hizki larrietan
        Me.TextBox3.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TextBox1.Text = ""
        Me.TextBox2.Text = ""
        Me.TextBox3.Text = ""
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        For Each c In Me.Controls
            If TypeOf c Is TextBox Then
                c.clear()
            End If
        Next
    End Sub

End Class
