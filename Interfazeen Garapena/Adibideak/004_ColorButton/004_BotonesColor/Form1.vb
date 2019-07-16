Public Class Form1
    Dim micolor As Color

    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        MsgBox("Agur", , "FormClosed")
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim resp As MsgBoxResult
        resp = MsgBox("Irten nahi duzu", MsgBoxStyle.YesNo, "FormClosing")
        If resp = MsgBoxResult.No Then
            'Hay que cancelar el evento de cerrar el formulario.
            e.Cancel = True
        End If
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MsgBox("Kaixo")
        micolor = Me.BackColor
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        Me.Text = e.Location.ToString
    End Sub

    Private Sub btnRojo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRojo.Click
        Me.btnRojo.BackColor = Color.Red
    End Sub

    Private Sub btnVerde_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerde.Click
        Me.btnVerde.BackColor = Color.Green
    End Sub

    Private Sub btnAzul_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAzul.Click
        Me.btnAzul.BackColor = Color.Blue
    End Sub

    Private Sub btnRestablecer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestablecer.Click
        Me.btnRojo.BackColor = micolor
        Me.btnVerde.BackColor = micolor
        Me.btnAzul.ResetBackColor()
    End Sub

    Private Sub btnMensaje_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMensaje.MouseEnter
        Me.btnMensaje.BackColor = Color.Gold
    End Sub

    Private Sub btnMensaje_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMensaje.MouseHover
        Me.btnMensaje.BackColor = Color.DarkKhaki
        'Gainean egon behar da segundo pare bat
    End Sub

    Private Sub btnMensaje_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMensaje.MouseLeave
        Me.btnMensaje.ResetBackColor()
    End Sub

  
    Private Sub btnMensaje_Click(sender As Object, e As EventArgs) Handles btnMensaje.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
