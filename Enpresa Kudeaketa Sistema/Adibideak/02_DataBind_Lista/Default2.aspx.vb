
Partial Class _Default
    Inherits System.Web.UI.Page
    'DataBind_Lista_Button_PageDataBind



    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim datos As New ArrayList
        datos.Add("Uno")
        datos.Add("Dos")
        datos.Add("Tres")
        datos.Add("Cuatro")
        datos.Add("Cinco")

        Me.Lista.DataSource = datos
        'Me.Lista.DataBind()

        Dim datosDos() As String = {"Bora-bora", "Morea", "Pascua", "Papeete", "Santiago de Chile"}
        Me.listados.DataSource = datosDos
        'Me.listados.DataBind()

        Dim datos1(4) As String
        datos1(0) = "Bora-bora"
        datos1(1) = "Morea"
        datos1(2) = "Pascua"
        datos1(3) = "Papeete"
        datos1(4) = "Santiago de Chile"
        Me.ListBox1.DataSource = datos1
        'Me.ListBox1.DataBind()

        Me.hora.Text = DateTime.Now
        Me.caja.Text = Page.Request.Browser.Browser
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Page.DataBind()
        'He tenido que quitar el if porque se tiene que volver a 
        'cargar la página.
    End Sub
End Class
