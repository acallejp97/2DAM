
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub CustomValidator1_ServerValidate(source As Object, args As ServerValidateEventArgs) Handles CustomValidator1.ServerValidate
        Dim a, b, c, d, e As Boolean
        Me.BulletedList1.Items.Clear()
        ' TERMINA EN 7

        Dim irati As String = Convert.ToString(Me.TextBox1.Text)

        'Termina en 7
        If irati.EndsWith(27) Then
            a = True
        Else
            a = False
            Me.BulletedList1.Items.Add("No termina en 7")
        End If

        ' Los dos ultimos numeros son multiplos de 3
        If Right(irati, 2) Mod 3 = 0 Then
            b = True
        Else
            b = False
            Me.BulletedList1.Items.Add("2 ultimos no multiplos de 3")
        End If

        ' El segundo numero es un 5
        If irati(1) = "5" Then
            c = True
        Else
            c = False
            Me.BulletedList1.Items.Add("No segundo 5")
        End If

        ' Tres letras en cualquier posicion
        Dim cont As Integer

        For x = 0 To irati.Length - 1
            If Char.IsLetter(irati(x)) = True Then
                cont += 1
            End If
        Next

        If cont = 3 Then
            d = True
        Else
            d = False
            Me.BulletedList1.Items.Add("No 3 letras")
        End If

        ' Que contenga 4 numeros
        Dim cont2 As Integer

        For x = 0 To irati.Length - 1
            If Char.IsNumber(irati(x)) = True Then
                cont2 += 1
            End If
        Next

        If cont2 = 4 Then
            e = True
        Else
            e = False
            Me.BulletedList1.Items.Add("No 4 numeros")
        End If

        'Comprobacion de todos
        If a And b And c And d And e Then
            args.IsValid = True
        Else
            args.IsValid = False
        End If
    End Sub


    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Page.IsValid Then
            Me.Label1.Text = "Validada"
        Else
            Me.Label1.Text = "NO Validada"
        End If
    End Sub
End Class
