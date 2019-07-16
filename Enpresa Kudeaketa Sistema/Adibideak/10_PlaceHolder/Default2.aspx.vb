
Partial Class Default2
    Inherits System.Web.UI.Page
    'El control Placeholder de servidor Web permite colocar un control contenedor vacío dentro de la página
    ' y, a continuación, agregar, quitar o recorrer dinámicamente elementos secundarios en tiempo de ejecución. 
    'El control sólo representa sus elementos secundarios: carece por sí mismo de resultados en HTML.
    'Como ejemplo, supongamos desea hacer que aparezca un número variable de botones en una página Web, 
    'en función de las opciones utilizadas por los usuarios. 
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim label1 As New Label
        label1.Text = "Creado en tiempo de ejecucion"
        label1.BackColor = System.Drawing.Color.FromArgb(100, 200, 130)
        Me.PlaceHolder1.Controls.Add(label1)

        Dim textbox1 As New TextBox
        textbox1.ID = "txt1"
        textbox1.BackColor = Drawing.Color.Bisque
        Me.PlaceHolder1.Controls.Add(textbox1)

        Dim button1 As New Button
        button1.Text = "Aceptar"
        Me.PlaceHolder1.Controls.Add(button1)

        Dim label2 As New Label
        label2.ID = "lbl2"
        label2.Text = "Resultado"
        label2.BackColor = Drawing.Color.Coral
        Me.PlaceHolder1.Controls.Add(label2)

        AddHandler button1.Click, AddressOf aaa
    End Sub

    Protected Sub aaa()
        Dim ttt As TextBox = Me.PlaceHolder1.FindControl("txt1")
        Dim lll As Label = Me.PlaceHolder1.FindControl("lbl2")
        lll.Text = ttt.Text & " Kaixo mundua."
    End Sub
End Class
