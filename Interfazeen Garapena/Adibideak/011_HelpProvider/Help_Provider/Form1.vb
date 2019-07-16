Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        HelpProvider1.SetHelpString(Me.TextBox1, "Sartu zure izena")
        HelpProvider1.SetHelpString(Me.TextBox2, "Sartu zure pasahitza")
        HelpProvider1.SetHelpString(Me.Button1, "Sakatu bakarrik beste bi datuak beteta daudenean")
        HelpProvider1.SetShowHelp(Me.TextBox1, True)

        Me.HelpButton = True  ' Bestela ez da ikusten ?
        Me.MaximizeBox = False
        Me.MinimizeBox = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("Sartu zara." & vbCrLf & "Egun on pasa!")
    End Sub
End Class
