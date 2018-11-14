Imports System.Data.OleDb
Imports System.Data

Partial Class Ejercicio_2
    Inherits System.Web.UI.Page
    Dim das As DataSet
    Dim conexion As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Northwind_Compacta.mdb;Persist Security Info=True")

    Protected Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

        Dim sql As String = "Select companyname, country from customers where companyname like '" & Me.TextBox1.Text.ToUpper & "%'"
        Dim comando As New OleDbCommand(sql, conexion)
        Dim adap1 As New OleDbDataAdapter(comando)

        Dim das1 As New DataSet()
        Dim contador As Integer

        Try
            contador = adap1.Fill(das1, "Libros")
            GridView1.DataSource = das1.Tables("Libros")
            GridView1.DataBind()
        Catch ex As Exception
            Response.Write("se ha producido una excepción: " & ex.Message)
        Finally
            conexion.Close()
        End Try

        Label5.Text = "En la tabla hay " & contador & " registros"
    End Sub

    Protected Sub TextBox2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

        Dim sql As String = "Select companyname, country from customers where companyname like @cname"
        Dim comando As New OleDbCommand(sql, conexion)
        comando.Parameters.AddWithValue("@cname", TextBox2.Text.ToUpper & "%")
        Dim adap1 As New OleDbDataAdapter(comando)

        Dim das1 As New DataSet()
        Dim contador As Integer

        Try
            contador = adap1.Fill(das1, "Libros")
            GridView1.DataSource = das1.Tables("Libros")
            GridView1.DataBind()
        Catch ex As Exception
            Response.Write("se ha producido una excepción: " & ex.Message)
        Finally
            conexion.Close()
        End Try

        Label5.Text = "En la tabla hay " & contador & " registros"
    End Sub
End Class
