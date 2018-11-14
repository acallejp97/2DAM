Imports System.Data.OleDb

Partial Class Ejercicio_3
    Inherits System.Web.UI.Page

    Protected Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged  

        Dim conexion As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\curso.mdb;Persist Security Info=True")
        Dim sentencia As String = "SELECT nombre, direccion From clientes where id = @id"
        Dim comando As New OleDbCommand(sentencia, conexion)
        comando.Parameters.AddWithValue("@id", Me.TextBox1.Text)

        Dim resultado As OleDbDataReader = Nothing

        Dim acum As String = Nothing
        Try
            conexion.Open()
            resultado = comando.ExecuteReader

            If resultado.Read Then
                Me.TextBox2.Text = resultado.Item("nombre").ToString
                Me.TextBox3.Text = resultado.Item("direccion").ToString
                If resultado.Item("direccion").ToString = Nothing Then
                    Me.TextBox3.Text = "CAMPO NULO "
                End If
            Else
                Me.TextBox2.Text = "Se ha producido una excepción "
                Me.TextBox3.Text = "Se ha producido una excepción "
            End If

            comando.Dispose()

        Catch ex As Exception
            Me.TextBox2.Text = "Se ha producido una excepción: " & ex.Message
            Me.TextBox3.Text = "Se ha producido una excepción: " & ex.Message
        Finally
            If Not resultado.IsClosed Then resultado.Close()
            If conexion.State = Data.ConnectionState.Open Then conexion.Close()
        End Try
    End Sub
End Class
