
Partial Class _Default
    Inherits System.Web.UI.Page
   
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not Page.IsPostBack Then
            Dim datosDos() As String =
                {"Bora-bora", "Morea", "Pascua",
                    "Papeete", "Santiago de Chile"}
            Me.ListBox1.DataSource = datosDos
            Me.ListBox1.DataBind()


            Dim datos1(4) As String
            datos1(0) = "Bora-bora"
            datos1(1) = "Morea"
            datos1(2) = "Pascua"
            datos1(3) = "Papeete"
            datos1(4) = "Santiago de Chile"
            Me.ListBox2.DataSource = datos1
            Me.ListBox2.DataBind()


            Dim datos As New ArrayList
            datos.Add("Uno")
            datos.Add("Dos")
            datos.Add("Tres")
            datos.Add("Cuatro")
            datos.Add("Cinco")
            Me.DropDownList1.DataSource = datos
            Me.DropDownList1.DataBind()





            Me.hora.Text = DateTime.Now.ToShortTimeString
            Me.Label3.Text = Page.Request.Browser.Browser
        End If

        ' Si lo pongo en Page_PreRender no hace  falta poner el IF,
        ' pero el control DropDownList no funciona bien porque se recarga,
        ' se selecciona bien, pero luego se recarga y siempre sale con Uno.
    End Sub

    Protected Sub ListBox1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Me.Label4.Text = Me.ListBox1.SelectedItem.Text
    End Sub

    Protected Sub ListBox2_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ListBox2.SelectedIndexChanged
        Me.Label5.Text = Me.ListBox2.SelectedItem.Text
    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles DropDownList1.SelectedIndexChanged
        Me.Label2.Text = Me.DropDownList1.SelectedItem.Text
    End Sub

    Protected Sub Page_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreRender
      
    End Sub
End Class
