Imports System.Data
Partial Class _Default
    Inherits System.Web.UI.Page
    'Ejercicio del Cap13_03
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load   
        If Not Page.IsPostBack Then
            'Es obligatorio ponerlo para que no se vuelva a cargar la pagina 
            'y se pierdan los valores seleccionados.
            '
            Dim mycountries = New ArrayList
            mycountries.Add("Norway")
            mycountries.Add("Sweden")
            mycountries.Add("France")
            mycountries.Add("Italy")

            mycountries.Sort()
            rb.DataSource = mycountries
            rb.DataBind()


            Dim datos(4) As String
            datos(0) = "Bora-bora"
            datos(1) = "Morea"
            datos(2) = "Pascua"
            datos(3) = "Papeete"
            datos(4) = "Santiago de Chile"
            Array.Sort(datos)
            rb2.DataSource = datos
            rb2.DataBind()

        End If
        'The ArrayList object is a collection of items containing a single data value.
        'Items are added to the ArrayList with the Add() method.
    End Sub

    Protected Sub rb_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rb.SelectedIndexChanged
        Label1.Text = "Your favorite country is: " & sender.Text
    End Sub

    Protected Sub rb2_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles rb2.SelectedIndexChanged
        Label2.Text = "Your favorite destiny is: " & sender.Text
        'Label2.Text = "Your favorite destiny is: " & rb2.SelectedItem.Text
    End Sub
End Class
