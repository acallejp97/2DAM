
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim label1 As New Label
        label1.Text = "Creado en tiempo de ejecucion"
        label1.BackColor = Drawing.Color.AliceBlue
        Me.PlaceHolder1.Controls.Add(label1)

        Dim textbox1 As New TextBox
        textbox1.ID = "txt1"
        textbox1.BackColor = Drawing.Color.AntiqueWhite
        Me.PlaceHolder1.Controls.Add(textbox1)

        Dim textbox2 As New TextBox
        textbox2.ID = "txt2"
        textbox2.BackColor = Drawing.Color.AntiqueWhite
        Me.PlaceHolder1.Controls.Add(textbox2)

        Dim button1 As New Button
        button1.Text = "SUMAR"
        Me.PlaceHolder1.Controls.Add(button1)

        Dim button2 As New Button
        button2.Text = "RESTAR"
        Me.PlaceHolder1.Controls.Add(button2)

        Dim label2 As New Label
        label2.ID = "lbl2"
        label2.Text = "Resultado"
        label2.BackColor = Drawing.Color.Coral
        Me.PlaceHolder1.Controls.Add(label2)

        AddHandler button1.Click, AddressOf sumar
        AddHandler button2.Click, AddressOf restar

    End Sub

    Protected Sub sumar()

        Dim ttt As TextBox = Me.PlaceHolder1.FindControl("txt1")
        Dim ttt2 As TextBox = Me.PlaceHolder1.FindControl("txt2")
        Dim lll As Label = Me.PlaceHolder1.FindControl("lbl2")

        Dim num1, num2 As Double

        num1 = Convert.ToDouble(ttt.Text)
        num2 = Convert.ToDouble(ttt2.Text)

        lll.Text = num1 + num2
        'MsgBox(ttt.Text)

    End Sub

    Protected Sub restar()

        Dim ttt As TextBox = Me.PlaceHolder1.FindControl("txt1")
        Dim ttt2 As TextBox = Me.PlaceHolder1.FindControl("txt2")
        Dim lll As Label = Me.PlaceHolder1.FindControl("lbl2")

        Dim num1, num2 As Double

        num1 = Convert.ToDouble(ttt.Text)
        num2 = Convert.ToDouble(ttt2.Text)

        lll.Text = num1 - num2
        'MsgBox(ttt.Text)

    End Sub
End Class
