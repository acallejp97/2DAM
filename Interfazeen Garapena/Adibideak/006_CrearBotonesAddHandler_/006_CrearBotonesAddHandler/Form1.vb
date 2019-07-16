Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler Button1.Click, AddressOf Calcular
        AddHandler Button2.Click, AddressOf Calcular
        AddHandler Button3.Click, AddressOf Calcular
    End Sub

    Private Sub Calcular(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim a As Double = Convert.ToDouble(Me.TextBox1.Text)
        Dim b As Double = Convert.ToDouble(Me.TextBox2.Text)
        Dim c As Double
        Select Case sender.text
            Case "Batuketa"
                c = a + b
                Me.Label1.Text = "+"
            Case "Kenketa"
                c = a - b
                Me.Label1.Text = "-"
            Case "Biderketa"
                c = a * b
                Me.Label1.Text = "*"
            Case "Zatiketa"
                c = a / b
                Me.Label1.Text = "/"
        End Select
        Me.TextBox3.Text = c.ToString("#,###,##0.00")
        'Me.TextBox3.Text = String.Format("{0,6:f2}", c)  ' f es con 2 decimales
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Try
            If Me.TextBox1.Text > 99 Then
                Dim b1 As New Button
                b1.Name = "NireBotoia"
                b1.Text = "Zatiketa"
                ' b1.Size = New Size(120, 40)
                b1.Top = Me.Button1.Top + Me.Button1.Height + 30
                b1.Left = Me.Button1.Left
                b1.Width = Me.Button1.Width
                b1.Height = Me.Button1.Height
                Me.Controls.Add(b1)
                AddHandler b1.Click, AddressOf Calcular
                'Me.Label4.Text = "Número de controles: " & Me.Controls.Count
            End If
        Catch ex As Exception
            Me.TextBox1.Clear()
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
