Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim x, y As Integer
            x = InputBox("Sartu zenbaki bat", , 5)
            y = InputBox("Sartu beste zenbaki bat", , 0)
            x = x / y
        Catch aaa As Exception
            MsgBox(aaa.Message & vbNewLine & StrDup(80, "-") & vbNewLine)
        Finally
            MsgBox("Gero arte")
            Me.Close()
        End Try

    End Sub
End Class
