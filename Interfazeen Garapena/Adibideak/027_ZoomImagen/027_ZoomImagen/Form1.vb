Public Class Form1
    Dim ancho As Integer
    Dim alto As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OFD1.InitialDirectory = Application.StartupPath
        OFD1.Filter = "Png|*.png|Bmp|*.bmp|Gif|*.gif|jpg|*.jpg|*.*|*.*"
        OFD1.FilterIndex = 3
        OFD1.ShowDialog()
        PictureBox1.Image = Image.FromFile(OFD1.FileName)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize 'Beharrezkoa

        ancho = PictureBox1.Width
        alto = PictureBox1.Height
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.Width = NumericUpDown1.Value * ancho
        PictureBox1.Height = NumericUpDown1.Value * alto
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        With NumericUpDown1
            .Maximum = 10
            .Minimum = 0
            .Value = 1
            .Increment = 0.1
            .DecimalPlaces = 1
        End With
    End Sub
End Class
