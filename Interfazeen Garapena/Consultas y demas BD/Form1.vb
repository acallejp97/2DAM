Imports System.Data.OleDb

Public Class Form1
    Dim acum As String = Nothing 'Esto es para pruebas
    Dim adap1 As OleDbDataAdapter 'El adaptador para la BD
    Dim das1 As DataSet   'Se encargara de llenar las tablas
    Public sql As String = ""  'La sentencia


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        llenarcomboBox()
    End Sub

    Private Sub btn_Consulta_Click(sender As Object, e As EventArgs) Handles btn_Consulta.Click

        llenarTabla() 'Realmente esto dberia de ir en el Load, pero meh
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles updateCampos.Click
        Try
            adap1.Update(das1, "aaa") 'Esto sirve para cuando haces click en el gridview y le cambias algo.
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Algo ha salido mal, que no cunda el panico")
        End Try

    End Sub


    Private Sub contar_Click(sender As Object, e As EventArgs) Handles contar.Click
        sql = "Select count(*) from Customers" 'Comando para seleccionar a todos, usando el COUNT
        Dim cmd1 As New OleDbCommand(sql, cnn1)
        Try
            Konektatu() ' Ya que vamos a realizar una consulta abrimos la conexion
            Dim resul As Integer = cmd1.ExecuteScalar 'Creamos una variable para almacenar el resultado (es opcional) y ejecutamos el comando Scalar
            MsgBox(resul & " customers daude") 'Sacamos cuantos existen
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Deskonektatu() 'Importante cerrar la conexion
        End Try
    End Sub

    'METODO PARA INSERTAR MEDIANTE PARAMETROS
    Private Sub btn_insertar_Click(sender As Object, e As EventArgs) Handles btn_insertar.Click

        sql = "Insert into Customers(CustomerID,CompanyName) VALUES (@bat, @bi)" ' para poner los valores que queramos lo declaramos de la siguente manera (@cualquiernombre)
        Dim resul As Integer
        Dim cmd1 As New OleDbCommand(sql, cnn1)
        cmd1.Parameters.AddWithValue("@bat", txt_id.Text) 'Aqui lo que hacemos es asignar valores a los @cualquiernombre, hay que hacerlo de 1 en 1
        cmd1.Parameters.AddWithValue("@bi", txt_empresa.Text)
        Try
            Konektatu()
            cmd1.ExecuteNonQuery() 'Importante, si no ponemos esto no inserta
            MsgBox("Cliente ingresado")
        Catch ex As Exception
            sql = "Delete * from Customers WHERE CustomerID=@tres"
            Dim cmd2 As New OleDbCommand(sql, cnn1)
            cmd2.Parameters.AddWithValue("@tres", "Manol")
            resul = cmd2.ExecuteNonQuery 'esto sigue sin ser necesario
            MsgBox(resul & "Lerroa ezabaturik")
        Finally
            Deskonektatu()
            llenarTabla()
            'If cnn1.State = ConnectionState.Open Then cnn1.Close()
        End Try


    End Sub


    'Para borrar
    Private Sub Btn_eliminarClick(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        sql = "Delete * from customers where CustomerID LIKE (@bat)" 'mismo funcionamiento que arriba
        Dim cmd1 As New OleDbCommand(sql, cnn1)
        cmd1.Parameters.AddWithValue("@bat", txt_idBorrar.Text)

        Try
            Konektatu()
            cmd1.ExecuteNonQuery()
            MsgBox("Cliente borrado")
        Catch ex As Exception
            MsgBox("Error al borrar el cliente" & ex.ToString)
        Finally
            Deskonektatu()
            llenarTabla()
        End Try


    End Sub

    'Consulta custom via ID
    Private Sub btn_Selec_Custom_Click(sender As Object, e As EventArgs) Handles btn_Selec_Custom.Click
        sql = "Select CustomerID, CompanyName,Address  from Customers where CustomerID Like (@bat)"
        Dim filtro As String = txt_idSelec.Text.ToUpper

        consultaCustom(sql, filtro)

    End Sub


    'Un select Nomral
    Private Sub btn_selec_normal_Click(sender As Object, e As EventArgs) Handles btn_selec_normal.Click
        sql = "Select CustomerID, CompanyName,Address  from Customers where Region like 'SP'"
        Dim cmd1 As New OleDbCommand(sql, cnn1)
        adap1 = New OleDbDataAdapter(cmd1)

        das1 = New DataSet
        adap1.Fill(das1, "aaa")

        Me.DataGridView1.DataSource = das1.Tables(0)  'Hacemos que llene el gridview
    End Sub

    'Este metodo sirve para cargar la tabla
    Sub llenarTabla()
        Dim sql As String = "SELECT * FROM Customers"
        Dim cmd1 As New OleDbCommand(sql, cnn1) 'Creamos el comando, para esto le pasamos el texto sql y el connector el cual esta definido en el Module1
        adap1 = New OleDbDataAdapter(cmd1) 'Ponemos el adaptador

        das1 = New DataSet 'Iniciamos el adaptador
        adap1.Fill(das1, "aaa") 'Llenamos la tabla

        Me.DataGridView1.DataSource = das1.Tables(0)  'Hacemos que llene el gridview

    End Sub

    Sub consultaCustom(ByVal sql As String, ByVal filtro As String)
        Dim cmd1 As New OleDbCommand(sql, cnn1)
        cmd1.Parameters.AddWithValue("@bat", filtro)

        adap1 = New OleDbDataAdapter(cmd1)
        das1 = New DataSet
        adap1.Fill(das1, "aaa")

        Me.DataGridView1.DataSource = das1.Tables(0)
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub


    Sub llenarcomboBox()
        Konektatu() 'Importante abrir la conexion
        Dim dr As OleDb.OleDbDataReader
        Dim cmd As New OleDb.OleDbCommand
        Me.combobox.Items.Clear()
        sql = "Select CustomerID from Customers"
        cmd.CommandType = CommandType.Text
        cmd.Connection = cnn1
        cmd.CommandText = sql
        dr = cmd.ExecuteReader
        If dr.HasRows = True Then
            While dr.Read

                Me.combobox.Items.Add(dr.GetValue(0))
            End While
        End If
        dr.Close()  'Importante cerrar el reader o se queda en el limbo
        Deskonektatu() 'Lo mismo con la conexion

    End Sub

    Private Sub combobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combobox.SelectedIndexChanged
        Konektatu()
        Dim dr As OleDb.OleDbDataReader
        Dim cmd As New OleDb.OleDbCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = cnn1
        cmd.CommandText = "Select * from customers where CustomerID LIKE(@bat)"
        cmd.Parameters.AddWithValue("@bat", combobox.SelectedItem.ToString)
        'cmd.CommandText = "Select * from customers where CustomerID LIKE '"& combobox.SelectedItem.ToString & "'" tambien podriais hacerlo asi, pero recordad las ''
        dr = cmd.ExecuteReader


        If dr.HasRows Then
            dr.Read()
            TextBox_llenarDireccion.Text = dr(4).ToString
            txt_llenarCiudad.Text = dr(5).ToString
        Else
            MsgBox("No existe el registro en la base de datos")
        End If
        dr.Close()

        Deskonektatu()

    End Sub
End Class
