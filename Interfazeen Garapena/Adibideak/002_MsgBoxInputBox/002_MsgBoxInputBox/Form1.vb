Public Class Form1

    Private Sub btnMsgbox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMsgbox1.Click
        Dim resp As MsgBoxResult
        resp = MsgBox("Athleticek liga irabaziko du?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton2, "Liga 2016-17")
        If resp = MsgBoxResult.Yes Then
            MsgBox("Txapeldun", , "Liga 2016-17")
        Else
            MsgBox("Agian beste urte batean.", , "Liga 2016-17")
        End If
    End Sub



    Private Sub btnMsgbox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMsgbox2.Click
        Dim resp As MsgBoxResult
        resp = MsgBox("Athleticek liga irabaziko du?", _
        MsgBoxStyle.YesNoCancel + MsgBoxStyle.Information + MsgBoxStyle.DefaultButton2, "Liga 2016-17")
        If resp = MsgBoxResult.Yes Then
            MsgBox("Txapeldun", , "Liga 2016-17")
        ElseIf resp = MsgBoxResult.No Then
            MsgBox("Agian beste urte batean.", , "Liga 2016-17")
        Else
            MsgBox("Ez zaude ziur, ezta?", , "Liga 2016-17")
        End If
    End Sub

    Private Sub btnInputbox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInputbox.Click
        Dim resp As String
        resp = InputBox("Sartu zure izena", "Ikaslearen izena", "Pilar")
        MsgBox(resp, , "Ikaslearen izena")
    End Sub

End Class
