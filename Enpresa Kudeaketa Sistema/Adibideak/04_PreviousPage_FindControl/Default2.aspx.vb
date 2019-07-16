
Partial Class Default2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            '1.- MODO
            ' Dim a As TextBox = Me.Page.PreviousPage.FindControl("textbox1")
            ' Me.Label1.Text = a.Text
            '2.- MODO
            Me.Label1.Text = Session("aaa")
         
        Catch ex As Exception
            Response.Redirect("Default.aspx")
        End Try
        'Para recuperar los valores de los campos del formulario desde la página ASPX de destino, 
        'haremos uso de la propiedad PreviousPage del objeto Page. 
        'Esta propiedad nos devuelve una referencia a la página ASPX que contenía el formulario, 
        'y sobre esta propiedad se lanzará el método FindControl(), 
        'al que pasaremos por parámetro el nombre del control del formulario 
        'cuyo valor deseamos recuperar. 
        'El valor devuelto por el método FindControl() es un objeto genérico de la clase Object, 
        'sobre esto objeto haremos una conversión de tipos para poder acceder a 
        'las propiedades del control correspondiente.
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
