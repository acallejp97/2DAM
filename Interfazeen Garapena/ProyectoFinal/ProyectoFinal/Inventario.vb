Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient


Public Class Inventario


    Dim conex As MySqlConnection = New MySqlConnection("server=10.22.23.66; user= pilar; password=12345; database=pilar; port=3306")
    Dim cmd As New MySqlCommand
    Dim Numero As ArrayList
    Dim arranca As Double = 0
    Dim ANDA As Integer

    'OnLoad
    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sentencia1 As New MySqlCommand("SELECT Nombre FROM Pabellones", conex)
        Try
            conex.Open()
            If conex.State = ConnectionState.Open Then
                MsgBox("Conectado a " & conex.Database & " (IP: " & conex.DataSource & ")")
                Dim dr As MySqlDataReader = sentencia1.ExecuteReader
                While dr.Read
                    Dim Pabellon As String = dr("Nombre").ToString
                    cbPabellonIncidencias.Items.Add(Pabellon)
                End While
            End If
            cbPabellonIncidencias.Items.Add("")
        Catch ex As Exception
            MsgBox("No se puedo conectar a la BBDD " & vbCrLf & ex.Message)
        Finally
            If conex.State = ConnectionState.Open Then
                conex.Close()
            End If
        End Try
    End Sub

    'Checked
    Private Sub cbPabellonIncidencias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPabellonIncidencias.SelectedIndexChanged
        Dim numeroPabellon As String
        Dim sentencia2 As String = "SELECT IdPabellon FROM Pabellones where Nombre like '" + cbPabellonIncidencias.Text.ToString + "'"
        Dim sentenciaBusqueda As New MySqlCommand(sentencia2, conex)
        Try
            conex.Open()
            If conex.State = ConnectionState.Open Then
                numeroPabellon = sentenciaBusqueda.ExecuteScalar()
                Dim sentencia1 As New MySqlCommand("SELECT NumeroAula FROM AulaTaller WHERE Pabellon = " & numeroPabellon, conex)
                cbAulaIncidencias.Items.Clear()
                Dim dr As MySqlDataReader = sentencia1.ExecuteReader
                While dr.Read
                    Dim Aulas As String = dr("NumeroAula").ToString
                    cbAulaIncidencias.Items.Add(Aulas)
                End While
            End If
        Catch ex As Exception
            MsgBox("No se puedo conectar a la BBDD " & vbCrLf & ex.Message)
        Finally
            If conex.State = ConnectionState.Open Then
                conex.Close()
            End If
        End Try
    End Sub

    'Buttons
    Private Sub btnNuevoEquipo_Click(sender As Object, e As EventArgs) Handles btnNuevoEquipo.Click
        Me.Enabled = False
        InventarioNuevoEquipo.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Dim a As Control
        For Each a In gbCritBusqInventa.Controls()
            If TypeOf a Is TextBox Then
                a.Text = ""
            End If
            If TypeOf a Is ComboBox Then
                a.Text = ""
            End If
        Next
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        ANDA = 0
        Dim numeroPabellon As String = 0
        Dim numeroAula As String = 0
        If (cbArrancaIncidencias.Text.ToUpper.Equals("SI")) Then
            arranca = 1
        Else
            arranca = 0
        End If



        If (cbPabellonIncidencias.Text.ToString <> "") Then

            Dim sentenciaPabellon As String = "SELECT IdPabellon FROM Pabellones where Nombre like '" + cbPabellonIncidencias.Text.ToString + "'"
            Dim sentenciaBusqueda As New MySqlCommand(sentenciaPabellon, conex)
            Try
                conex.Open()
                If conex.State = ConnectionState.Open Then
                    numeroPabellon = sentenciaBusqueda.ExecuteScalar()
                    If cbAulaIncidencias.Text.ToString <> Nothing Then
                        Dim sentenciaAula As String = "SELECT IdAula FROM AulaTaller WHERE  NumeroAula like '" & cbAulaIncidencias.Text.ToString + "'"
                        sentenciaBusqueda = New MySqlCommand(sentenciaAula, conex)
                        numeroAula = sentenciaBusqueda.ExecuteScalar
                    End If
                End If
            Catch ex As Exception
                MsgBox("No se pudo conectar a la BBDD " & vbCrLf & ex.Message)
            Finally
                If conex.State = ConnectionState.Open Then
                    conex.Close()
                End If
            End Try
        End If



        Dim sentencia1 As String = "SELECT IdEquipo, ETIQUETA, Estado, Pabellon, Aula, Arranca FROM Inventario "
        If (tbIDIncidencias.Text.ToString <> Nothing Or
            tbHZequipoInventario.Text.ToString <> Nothing Or
            cbEstadoIncidencias.Text.ToString <> Nothing Or
            cbPabellonIncidencias.Text.ToString <> Nothing Or
            cbAulaIncidencias.Text.ToString <> Nothing Or
            cbArrancaIncidencias.Text.ToString <> Nothing
            ) Then
            sentencia1 = sentencia1 + "WHERE "

            For Each c In gbCritBusqInventa.Controls()
                If c.Text.ToString <> Nothing And (TypeOf c Is TextBox Or TypeOf c Is ComboBox) Then
                    ANDA = ANDA + 1
                End If
            Next

            If (tbIDIncidencias.Text.ToString <> "") Then
                sentencia1 = sentencia1 + "IdEquipo like '" + tbIDIncidencias.Text + "'"
                If ANDA > 1 Then
                    sentencia1 = sentencia1 + " AND "
                    ANDA = ANDA - 1
                End If
            End If

            If (tbHZequipoInventario.Text.ToString <> Nothing) Then
                sentencia1 = sentencia1 + "ETIQUETA like '" + tbHZequipoInventario.Text + "'"
                If ANDA > 1 Then
                    sentencia1 = sentencia1 + " AND "
                    ANDA = ANDA - 1
                End If
            End If

            If (cbEstadoIncidencias.Text.ToString <> Nothing) Then
                sentencia1 = sentencia1 + "Estado like '" + cbEstadoIncidencias.Text.ToString.ToUpper + "'"
                If ANDA > 1 Then
                    sentencia1 = sentencia1 + " AND "
                    ANDA = ANDA - 1
                End If
            End If


            If (cbPabellonIncidencias.Text.ToString <> Nothing) Then
                sentencia1 = sentencia1 + "Pabellon = " + numeroPabellon
                If ANDA > 1 Then
                    sentencia1 = sentencia1 + " AND "
                    ANDA = ANDA - 1
                End If
            End If


            If (cbAulaIncidencias.Text.ToString <> Nothing) Then
                sentencia1 = sentencia1 + "Aula = " & numeroAula
                If ANDA > 1 Then
                    sentencia1 = sentencia1 + " AND "
                    ANDA = ANDA - 1
                End If
            End If


            If (cbArrancaIncidencias.Text.ToString <> Nothing) Then
                sentencia1 = sentencia1 + "Arranca = " & arranca

            End If

        End If
        Dim sentencia As New MySqlCommand(sentencia1, conex)
        Dim busqueda As New MySqlDataAdapter(sentencia)
        Dim dataTable As New DataTable
        Try
            busqueda.Fill(dataTable)
            Me.DataGridView1.DataSource = dataTable
        Catch ex As Exception
            MessageBox.Show("Error al realizar la consulta" & ex.Message)

        End Try


    End Sub
End Class
