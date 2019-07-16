Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim fecha1 As Date = Convert.ToDateTime(Me.TextBox1.Text)
        Dim fecha2 As Date = Convert.ToDateTime(Me.TextBox2.Text)
        Me.Label3.Text = DateDiff(DateInterval.Day, fecha1, fecha2) & " dias."
    End Sub




    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TextBox1.Text = DateTime.Now().ToShortDateString()
        Me.TextBox3.Text = DateTime.Now().ToShortDateString()

        'textBox1.Text = DateTime.Now() // "2009-06-16 09:50:20.000 am"
        'textBox1.Text = Datetime.Now().ToShortDateString() // "2009/06/16"
        'textBox1.Text = Datetime.Now().ToShortTimeString() // "09:50:00 am"
        'textBox1.Text = Datetime.Now().ToString("dd/MM/yyyy hh:mm:ss tt") // "2009-06-16 09:50:20 am"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim fecha3 As Date = Convert.ToDateTime(Me.TextBox3.Text)
        Me.Label6.Text = DateAdd(DateInterval.Day, 28, fecha3)
    End Sub
End Class