Imports System.Data
Partial Class _Default
    Inherits System.Web.UI.Page
    'Ejercicio del Cap13_03
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Dim a As New DataSet
            'a.ReadXml("countries.xml") 'ERROR No se pudo encontrar el archivo 

            a.ReadXml(Server.MapPath("countries.xml")) 'a.ReadXml(MapPath("countries.xml"))
            rb1.DataSource = a
            rb1.DataValueField = "aaa"
            rb1.DataTextField = "bbb"
            rb1.DataBind()
        End If
    End Sub

    Protected Sub rb_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rb1.SelectedIndexChanged
        lbl1.Text = "Your favorite country is: " & _
        rb1.SelectedItem.Text & " - " & rb1.SelectedItem.Value
    End Sub
End Class
