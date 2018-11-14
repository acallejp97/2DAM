Imports System.Data.OleDb
Imports System.Data

Partial Class Ejercicio_5

    Inherits System.Web.UI.Page
    Dim das As DataSet
    Dim conexion As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Northwind_Compacta.mdb;Persist Security Info=True")

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        Dim adapter1 As New OleDbDataAdapter("Select productid, productname, unitprice from products", conexion)
        das = New DataSet

        Try
            adapter1.Fill(das, "uno")
            Me.GridView1.DataSource = das.Tables("uno")
            DataBind()
            Label1.Text = das.Tables(0).Rows.Count & " Registros"
        Catch ex As Exception
            Response.Write("Se ha producido una excepción: " & ex.Message)
        End Try

    End Sub


    Protected Sub GridView1_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles GridView1.PageIndexChanging
        Me.GridView1.PageIndex = e.NewPageIndex
        DataBind()
    End Sub

    Protected Sub Buttoncontar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim adapter1 As New OleDbDataAdapter("Select productid, productname, unitprice from products order by productid", conexion)
        das = New DataSet

        Try
            adapter1.Fill(das, "uno")
            Me.GridView1.DataSource = das.Tables("uno")
            DataBind()
            Label1.Text = das.Tables(0).Rows.Count & " Registros"
        Catch ex As Exception
            Response.Write("Se ha producido una excepción: " & ex.Message)
        End Try
    End Sub

    Protected Sub Buttonañadir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim sentencia As String = "Insert into products (productname,unitprice) values (@name,@price)"
        Dim comando As New OleDbCommand(sentencia, conexion)
        comando.Parameters.AddWithValue("@name", Me.TextBox1.Text)
        comando.Parameters.AddWithValue("@price", Me.TextBox2.Text)
        Dim resultado As Integer = Nothing

        Try
            conexion.Open()
            resultado = comando.ExecuteNonQuery
            Label5.Text = resultado.ToString & " registro añadido"
        Catch ex As Exception
            Label5.Text = ex.Message
        Finally
            conexion.Close()

        End Try
        cargar()
    End Sub

    Protected Sub Buttoneliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim sentencia As String = "delete * from products where productid = @id"
        Dim comando As New OleDbCommand(sentencia, conexion)
        comando.Parameters.AddWithValue("@id", Me.TextBox3.Text)

        Dim resultado As Integer = Nothing

        Try
            conexion.Open()
            resultado = comando.ExecuteNonQuery
            Label5.Text = resultado.ToString & " registro borrado"
        Catch ex As Exception
            Label5.Text = ex.Message
        Finally
            conexion.Close()

        End Try
        cargar()
    End Sub

    Protected Sub cargar()
        Dim adapter1 As New OleDbDataAdapter("Select productid, productname, unitprice from products order by productid", conexion)
        das = New DataSet

        Try
            adapter1.Fill(das, "uno")
            Me.GridView1.DataSource = das.Tables("uno")
            DataBind()
            Label1.Text = das.Tables(0).Rows.Count & " Registros"
        Catch ex As Exception
            Response.Write("Se ha producido una excepción: " & ex.Message)
        End Try
    End Sub

End Class
