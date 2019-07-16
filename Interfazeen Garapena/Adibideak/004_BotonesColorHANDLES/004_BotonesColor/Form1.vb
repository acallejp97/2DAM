Public Class Form1
    Dim micolor As Color

    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        MsgBox("Agur", , "Closed")
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim resp As MsgBoxResult
        resp = MsgBox("Irten nahi duzu?", MsgBoxStyle.YesNo, "Closing")
        If resp = MsgBoxResult.No Then
            'Ebento ezeztatu behar da formulario ixten duzunean.
            e.Cancel = True
        End If
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MsgBox("KAIXO BERRIRO")
        micolor = Me.BackColor
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        Me.Text = e.X & " - " & e.Y
        'Saguaren koordenadak.
    End Sub

    Private Sub COMUN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRojo.Click, btnVerde.Click, btnAzul.Click
        Select Case sender.TEXT
            Case "Gorria"
                Me.btnRojo.BackColor = Color.Red
            Case "Berdea"
                Me.btnVerde.BackColor = Color.Green
            Case "Urdina"
                Me.btnAzul.BackColor = Color.Blue
        End Select
    End Sub







    Private Sub btnRestablecer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestablecer.Click
        Me.btnRojo.BackColor = micolor
        Me.btnVerde.BackColor = micolor
        Me.btnAzul.BackColor = micolor
    End Sub

    Private Sub btnMensaje_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMezua.MouseEnter
        Me.btnMezua.BackColor = Color.Gold
    End Sub

    Private Sub btnMensaje_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMezua.MouseHover
        Me.btnMezua.BackColor = Color.Gold
        'Apur bat geratu behar da gainean.
    End Sub

    Private Sub btnMensaje_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMezua.MouseLeave
        Me.btnMezua.ResetBackColor()
    End Sub
End Class
