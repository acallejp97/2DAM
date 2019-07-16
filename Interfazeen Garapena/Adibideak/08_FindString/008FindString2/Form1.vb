Public Class Form1
    Dim contpalabras As Integer = 0
    Dim t1 As System.DateTime
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.ListBox1.Items.Clear()
        t1 = Now()
        Dim palabra As String = ""
        Dim rnd As New Random
        Randomize()

        ListBox1.BeginUpdate()
        For i = 1 To 20000
            Dim n As Integer
            n = rnd.Next(1, 21)
            For j = 0 To n
                palabra = palabra & Convert.ToChar(rnd.Next(65, 91))
            Next
            ListBox1.Items.Add(palabra)
            palabra = ""
        Next
        ListBox1.Sorted = True
        ListBox1.EndUpdate() ' Refresh the ListBox control

        MsgBox(Now.Subtract(t1).TotalSeconds & " segundu.")
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim pos As Integer = ListBox1.FindString(TextBox1.Text)
        ListBox1.TopIndex = pos
        ListBox1.SelectedIndex = pos
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.ListBox1.Sorted = True
    End Sub
End Class
