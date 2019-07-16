Public Class Form1
    Dim esvisible As Boolean = False
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtcantidad.TabIndex = 0
        'me.txtcantidad.focus NO FUNCIONA EN EL LOAD
        Me.btn7.TabIndex = 1
        Me.btn21.TabIndex = 2
        Me.btn33.TabIndex = 3

        Me.CancelButton = Me.btnSalir 'AL PULSAR LA TECLA ESC
    End Sub

    Private Sub Calcular(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7.Click, btn21.Click, btn33.Click
        Try
            Dim a As Double = Convert.ToDouble(Me.txtcantidad.Text)
            Dim iva As Integer = Val(sender.text)
            Dim total As Double

            Me.lbliva.Text = sender.text
            total = a * iva / 100
            txtiva.Text = total.ToString("#,###,##0.00")
            total = a + a * iva / 100
            txttotal.Text = total.ToString("#,###,##0.00€")
        Catch ex As Exception
            limpiar()
        End Try
    End Sub
    Private Sub limpiar()
        Me.txtcantidad.Clear()
        Me.txtiva.Clear()
        Me.txttotal.Clear()
        Me.txtcantidad.Focus()
    End Sub

    Private Sub txtcantidad_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcantidad.GotFocus
        Me.txtcantidad.SelectAll()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Application.Exit()
    End Sub

    Private Sub txtcantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcantidad.TextChanged
        If esvisible = False And Me.txtcantidad.Text > 100000 Then
            Dim b1 As New Button
            b1.Name = "miboton"
            b1.Text = "54%"
            b1.Width = Me.btn33.Width
            b1.Height = Me.btn33.Height
            b1.Left = Me.btn33.Left
            b1.Top = Me.btn33.Top + Me.btn33.Height + 30
            b1.TabIndex = 4
            Me.Controls.Add(b1)
            AddHandler b1.Click, AddressOf Calcular
            esvisible = True
        End If
        If esvisible = True And Me.txtcantidad.Text <= 100000 Then
            esvisible = False


            Me.Controls.RemoveByKey("miboton")

            ' 1. MODO   ' Borro el último control que he añadido
            'Me.Controls.RemoveAt(Me.Controls.Count - 1)               

            ' 2. MODO
            'For x = 0 To Me.Controls.Count - 1
            '    If Me.Controls(x).Name = "btn54" Then
            '        Me.Controls.RemoveAt(x)
            '    End If
            'Next   

            ' 3. MODO
            'For Each a In Me.Controls
            '    If a.name = "miboton" Then
            '        Me.Controls.Remove(a)
            '    End If
            'Next
        End If
    End Sub
End Class
