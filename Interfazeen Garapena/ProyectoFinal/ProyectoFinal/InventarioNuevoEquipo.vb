Imports MySql.Data.MySqlClient

Public Class InventarioNuevoEquipo

    Dim conex As MySqlConnection = New MySqlConnection("server=10.22.23.66; user= pilar; password=12345; database=pilar; port=3306")
    'Para permitir establecer y modificar las propiedades de la conexión a la BBDD

    '''''''''''''''''''''''''''''''''''''OnLoad
    Private Sub InventarioNuevoEquipo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cogerID()
        Try
            conex.Open()
            If conex.State = ConnectionState.Open Then
                Dim sentencia1 As New MySqlCommand("SELECT NumeroAula FROM AulaTaller", conex)
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
        cbEstadoIncidencias.Text = "Alta"
        Try
            conex.Open()
            If conex.State = ConnectionState.Open Then
                Dim sentencia1 As New MySqlCommand("SELECT Nombre, Apellidos FROM Tecnicos", conex)
                Dim dr As MySqlDataReader = sentencia1.ExecuteReader
                While dr.Read
                    Dim Nombre As String = dr("Nombre").ToString
                    Dim Apellido As String = dr("Apellidos").ToString
                    cbTecnicoIncidencias.Items.Add(Nombre & " " & Apellido)
                End While
            End If
        Catch ex As Exception
        Finally
            If conex.State = ConnectionState.Open Then
                conex.Close()
            End If

        End Try
    End Sub

    '''''''''''''''''''''''''''''''''''''''OnClicks
    Private Sub btnGuardarIncidencias_Click(sender As Object, e As EventArgs) Handles btnGuardarIncidencias.Click
        If tbHZEquipoIncidencias.Text.ToString.Equals("") Or cbAulaIncidencias.Text.ToString.Equals("") Or cbTecnicoIncidencias.Text.ToString.Equals("") Then
            MsgBox("Por favor, rellene los campos que contengan (*)" & vbCrLf)
        Else
            Dim pabellon As String = cogerPabellon(cbAulaIncidencias.Text.ToString)
            Dim aula As String = cogerAula(cbAulaIncidencias.Text.ToString)
            Dim arranca As String = ""
            Select Case (cbArrancaIncidencias.Text.ToString.ToUpper)
                Case "SI"
                    arranca = 1
                Case "NO"
                    arranca = 0
                Case ""
                    arranca = "null"
            End Select
            Dim testRAM As String = 0
            Select Case (cbTestRAMIncidencias.Text.ToString.ToUpper)
                Case "SI"
                    testRAM = 1
                Case "NO"
                    testRAM = 0
                Case ""
                    testRAM = "null"
            End Select
            Dim testHD As String = ""
            Select Case (cbTestHDIncidencias.Text.ToString.ToUpper)
                Case "SI"
                    testHD = 1
                Case "NO"
                    testHD = 0
                Case ""
                    testHD = "null"
            End Select
            Dim tecnico As String = cogerTecnico(cbTecnicoIncidencias.Text.ToString)

            For Each c In gbNuevoEquipo.Controls()
                If TypeOf c Is TextBox Or TypeOf c Is ComboBox Then
                    If c.Text.ToString = "" Then
                        c.Text = "null"
                    Else
                        c.Text = "'" & c.Text & "'"
                    End If
                End If
            Next


            Dim sentencia As String = "INSERT INTO Inventario (IdEquipo, ETIQUETA, Arranca, Aula, Ubicacion, PlacaBase, Manual, Procesador, TipoNumModulosRAM, TesteoRAM, DiscoDuro, TesteoHD, Tecnico, Pabellon,FechaUltimoTesteo, Estado) " &
            "VALUES (" & tbIDIncidencias.Text.ToString & ", " & tbHZEquipoIncidencias.Text.ToString & ", " & arranca & ", " & aula & ", " & tbUbicacionIncidencias.Text.ToString & ", " &
            tbPlacaBaseIncidencias.Text.ToString & ", " & tbEnlaceManualIncidencias.Text.ToString & ", " & tbProcesadorIncidencias.Text.ToString & ", " & tbRAMIncidencias.Text.ToString & ", " & testRAM & ", " &
            tbDiscoDuroIncidencias.Text.ToString & ", " & testHD & ", " & tecnico & ", " & pabellon & ", '" & ordenarFecha(tbFechaUltTestIncidencias.Value.ToString) & "', 1" & " )"
            Dim sentenciaBusqueda As New MySqlCommand(sentencia, conex)

            Try
                conex.Open()
                If conex.State = ConnectionState.Open Then
                    sentenciaBusqueda.ExecuteNonQuery()
                End If
                MsgBox("Guardado correctamente" & vbCrLf)
                For Each c In gbNuevoEquipo.Controls()
                    If TypeOf c Is TextBox Or TypeOf c Is ComboBox Then
                        c.Text = ""
                    End If
                Next
            Catch ex As Exception
                MsgBox("No se pudo conectar a la BBDD " & vbCrLf & ex.Message)
            Finally
                If conex.State = ConnectionState.Open Then
                    conex.Close()
                End If
            End Try


            cogerID()
        End If
    End Sub


    Private Sub btnSalirIncidencias_Click(sender As Object, e As EventArgs) Handles btnSalirIncidencias.Click
        Dim Usado As Boolean = False
        For Each c In gbNuevoEquipo.Controls()
            If c.Text.ToString <> Nothing And (TypeOf c Is TextBox Or TypeOf c Is ComboBox) And c IsNot tbIDIncidencias And c IsNot cbEstadoIncidencias Then
                Usado = True
            End If
        Next
        If Usado = True Then
            Dim result As Integer = MessageBox.Show("¿Está seguro que desea salir?" + vbNewLine + "(Se perderán los datos)", "Cerrar Nuevo Equipo", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Yes Then
                Me.Close()
                Inventario.Enabled = True
                Inventario.Show()
                Inventario.BringToFront()
            End If
        Else
            Me.Close()
            Inventario.Enabled = True
            Inventario.Show()
            Inventario.BringToFront()
        End If
    End Sub

    '''''''''''''''''''''''''''Funciones para coger algunos valores de la base de datos
    Private Function ordenarFecha(fechaHora)

        Dim formatoFinal As String
        Dim dividido As String()
        Dim fecha As String()
        dividido = fechaHora.Split(" ")
        fecha = dividido(0).Split("/")
        formatoFinal = fecha(2) & "-" & fecha(0) & "-" & fecha(1) & " " & dividido(1)
        Return formatoFinal

    End Function
    Private Function cogerTecnico(tecnico)
        Dim numeroTecnico As String = ""
        Dim nombre As String()
        nombre = tecnico.Split(" ")

        Dim sentenciaTecnico = "Select IdTecnico from Tecnicos where Nombre like '" & nombre(0) & "' and Apellidos like '" & nombre(1) & "'"
        Dim sentenciaBusqueda As New MySqlCommand(sentenciaTecnico, conex)

        Try
            conex.Open()
            If conex.State = ConnectionState.Open Then
                numeroTecnico = sentenciaBusqueda.ExecuteScalar
            End If
        Catch ex As Exception
            MsgBox("No se pudo conectar a la BBDD " & vbCrLf & ex.Message)
        Finally
            If conex.State = ConnectionState.Open Then
                conex.Close()
            End If
        End Try
        Console.WriteLine(sentenciaTecnico)
        Return numeroTecnico
    End Function

    Private Function cogerPabellon(aula)
        Dim numeroPabellon As Integer = 0

        Dim sentenciaNumero As String = "Select Pabellon from AulaTaller Where NumeroAula like '" & aula & "'"
        Dim sentenciaBusqueda As New MySqlCommand(sentenciaNumero, conex)

        Try
            conex.Open()
            If conex.State = ConnectionState.Open Then
                numeroPabellon = sentenciaBusqueda.ExecuteScalar
            End If
        Catch ex As Exception
            MsgBox("No se pudo conectar a la BBDD " & vbCrLf & ex.Message)
        Finally
            If conex.State = ConnectionState.Open Then
                conex.Close()
            End If
        End Try
        Return numeroPabellon
    End Function
    Private Function cogerAula(Aula)
        Dim numeroAula As Integer = 0

        Dim sentenciaNumero As String = "Select IdAula from AulaTaller Where NumeroAula like '" & Aula & "'"
        Dim sentenciaBusqueda As New MySqlCommand(sentenciaNumero, conex)

        Try
            conex.Open()
            If conex.State = ConnectionState.Open Then
                numeroAula = sentenciaBusqueda.ExecuteScalar
            End If
        Catch ex As Exception
            MsgBox("No se pudo conectar a la BBDD " & vbCrLf & ex.Message)
        Finally
            If conex.State = ConnectionState.Open Then
                conex.Close()
            End If
        End Try
        Return numeroAula
    End Function

    Private Sub cogerID()
        Try

            conex.Open()
            If conex.State = ConnectionState.Open Then
                Dim sentenciaID As String = "SELECT MAX(IdEquipo) FROM Inventario"
                Dim sentenciaBusqueda As New MySqlCommand(sentenciaID, conex)
                tbIDIncidencias.Text = sentenciaBusqueda.ExecuteScalar + 1
            End If
        Catch ex As Exception
            MsgBox("No se pudo conectar a la BBDD " & vbCrLf & ex.Message)
        Finally
            If conex.State = ConnectionState.Open Then
                conex.Close()
            End If
        End Try

    End Sub
End Class