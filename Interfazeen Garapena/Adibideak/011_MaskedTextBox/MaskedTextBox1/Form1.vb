Public Class Form1

    'Textboxen "Mask" erabiliko dugu onartutako karaktereak zehazteko:

    '0' zenbakia zero eta bederatzi artean
    '9' Zenbakia edo tartea
    'L' Hizkia
    '?' Hizkia edo tartea
    ',' Zenbaki bereizlea
    '.' Zenbaki bereizlea
    ':' ordua, minutua, segundoa
    '/' eguna, hilabetea, urtea
    '$' Moneta

    'Datu bat egokia ez bada MaskInputRejected martxan jartzen da.
    'beepOnError ezaugarria erabilita soinua botako du.

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ToolTip1.IsBalloon = True ' activa el dialogo de información con el mensage de error
        Me.ToolTip1.BackColor = Color.Blue

        Me.MaskedTextBox1.Mask = "?????????????????"
        Me.MaskedTextBox2.Mask = "000-000-000"
        Me.MaskedTextBox3.Mask = "00"
        Me.MaskedTextBox4.Mask = "00/00/0000" 'data
        Me.MaskedTextBox5.Mask = "0,000.00€" 'moneta
        Me.MaskedTextBox6.Mask = "0 0 0 0 0"

    End Sub
    Private Sub MaskedTextBox1_MaskInputRejected(ByVal sender As Object, ByVal e As MaskInputRejectedEventArgs) _
     Handles MaskedTextBox1.MaskInputRejected

        Dim messageBoxVB As New System.Text.StringBuilder()
        messageBoxVB.AppendFormat("{0} = {1}", "Errorea: ", e.RejectionHint)
        messageBoxVB.AppendLine()
        MessageBox.Show(messageBoxVB.ToString(), "MaskInputRejected Event")

    End Sub

    Private Sub Todos(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected, MaskedTextBox2.MaskInputRejected, MaskedTextBox3.MaskInputRejected, MaskedTextBox4.MaskInputRejected, MaskedTextBox5.MaskInputRejected, MaskedTextBox6.MaskInputRejected
        ToolTip1.Show("ERROR. Karakter hau ez dago onartuta.", sender, 4000)
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        MsgBox("Izena:" & vbTab & MaskedTextBox2.Text & vbNewLine &
               "Telefonoa:" & vbTab & MaskedTextBox1.Text & vbNewLine &
               "Adina:" & vbTab & MaskedTextBox3.Text & vbNewLine &
               "Jaiotze data:" & vbTab & MaskedTextBox4.Text & vbNewLine &
               "Soldata: " & vbTab & MaskedTextBox5.Text & vbNewLine &
               "Posta kodea:" & vbTab & MaskedTextBox6.Text)
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
