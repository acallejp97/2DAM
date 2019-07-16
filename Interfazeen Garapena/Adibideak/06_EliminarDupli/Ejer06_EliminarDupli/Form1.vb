Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ListBox1.Items.Add("1")
        Me.ListBox1.Items.Add("3")
        Me.ListBox1.Items.Add("2")
        Me.ListBox1.Items.Add("1")
        Me.ListBox1.Items.Add("6")
        Me.ListBox1.Items.Add("1")
        Me.ListBox1.Items.Add("3")
        Me.ListBox1.Items.Add("5")
        Me.ListBox1.Items.Add("2")
        Me.ListBox1.Items.Add("3")
        Me.ListBox1.Items.Add("5")
        Me.ListBox1.Items.Add("3")
        Me.ListBox1.Items.Add("2")
        Me.ListBox1.Items.Add("1")
        Me.ListBox1.Items.Add("8")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim x, y, n As Integer

        For x = 0 To ListBox1.Items.Count - 1
            For y = ListBox1.Items.Count - 1 To x + 1 Step -1
                If ListBox1.Items(x).ToString = ListBox1.Items(y).ToString Then
                    ListBox1.Items.RemoveAt(y)
                    n += 1
                End If
            Next
        Next
        MsgBox("" & n & " items ezabatu dira.")
    End Sub

End Class
