Public Class Form1
    Private Sub IrtenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IrtenToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem9.Click
        Dim kolore As New ColorDialog
        If kolore.ShowDialog() = DialogResult.OK Then
            Button1.BackColor = kolore.Color
        End If
    End Sub

    Private Sub ToolStripMenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem10.Click
        Dim kolore As New ColorDialog
        If kolore.ShowDialog() = DialogResult.OK Then
            Button1.ForeColor = kolore.Color
        End If
    End Sub

    Private Sub ToolStripMenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem11.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub ToolStripMenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem12.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub ToolStripMenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem13.Click
        RichTextBox1.Paste()
    End Sub
End Class
