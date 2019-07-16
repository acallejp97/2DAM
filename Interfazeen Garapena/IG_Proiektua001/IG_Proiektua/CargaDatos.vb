Imports Microsoft.Office.Interop.Excel
Imports MySql.Data.MySqlClient

'Lo que falta:
'   AulaTaller, no se encuentra bien por el salto de linea y se inserta cada vez.
'   Tratar los saltos de linea en la descripcion, nombre de Aula

Public Class CargaDatos
    Public conn As New MySqlConnection("server=10.22.23.66; user= pilar; password=12345; database=pilar; port=3306")
    'Public conn As New MySqlConnection("server=localhost; user=root; password=elorrieta; database=pilar; port=3306")
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader

    Public Sub conectar()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                'MsgBox("Conexión exitosa")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Dim tablaAulaTaller As String = "AulaTaller"
    Dim tablaInventario As String = "Inventario"
    Dim tablaTecnicos As String = "Tecnicos"
    Dim tablaIntzidentziak As String = "Intzidentziak"
    Dim tablaAsignaciones As String = "Asignaciones"

    'Uso arrays de hasta 200 para almacenar los datos, se pueden usar vars simples y sobreescribirlas pero... no creo que haya mas de 200
    Dim max As Integer = 200

    Dim creada(0 To max) As String 'A
    Dim email(0 To max) As String 'B
    Dim equipo(0 To max) As String 'C
    Dim IDequipo As String

    Dim aula(0 To max) As String 'D
    Dim IDaula As String
    Dim IDpabellon As String
    'Dim urgente(0 To 200) As String 'E
    Dim deskribapena(0 To max) As String 'E
    Dim fechaEntrega(0 To max) As String 'F
    Dim oharrak(0 To max) As String 'G
    Dim tekniko(0 To max) As String 'H
    Dim tratamientoIncid(0 To max) As String 'I
    'J 'K 'L
    Dim fechaCierre(0 To max) As String 'M

    Dim IDteknikoa As String
    Dim extra As String
    Dim IDintzidentzia As String

    'Abrir Fichero Excel
    Dim fd As OpenFileDialog = New OpenFileDialog()
    Dim strFileName As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonExaminar.Click
        AbrirFichero()
    End Sub
    Sub AbrirFichero()
        fd.Title = "Abrir archivo de datos de incidencias"
        fd.InitialDirectory = "C:\"
        fd.Filter = "Fichero de Excel (*.xlsx)|*.xlsx"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
            TextBoxFichero.Text = strFileName
            ButtonCargarDatos.Enabled = True
        End If
    End Sub

    Private Sub ButtonCargarDatos_Click(sender As Object, e As EventArgs) Handles ButtonCargarDatos.Click
        ButtonExaminar.Enabled = False
        TextBox1.Text = DateTime.Now.ToString("yyyy/MM/dd")
        LeerExcel()
    End Sub

    Sub LeerExcel()
        Dim oExcel As Application = CreateObject("Excel.Application")
        Dim oBook As Workbook = oExcel.Workbooks.Open(strFileName, , False)
        Dim oSheet As Worksheet
        oSheet = oBook.Worksheets("Respuestas de formulario 1")

        'Dim creadaRegistros As Integer = WorksheetFunction.Count(Range("A1:A200"))
        Dim usedRowsCount As Integer
        'usedRowsCount = oSheet.UsedRange.Rows.Count
        usedRowsCount = 3

        While (oBook.ActiveSheet.Cells(usedRowsCount, 1).Value IsNot Nothing)
            usedRowsCount = usedRowsCount + 1
        End While

        conectar() 'para Inserts

        'Recorremos cada una de las celdas y guardamos su contenido en el array correspondiente
        For fila As Integer = 2 To usedRowsCount - 1
            Dim columna As Char
            Dim temp As String
            For col As Integer = 1 To 13
                Select Case col
                    Case 1
                        columna = "A"
                        creada(fila - 2) = oSheet.Range(columna & fila).Text
                    Case 2
                        columna = "B"
                        email(fila - 2) = oSheet.Range(columna & fila).Text
                    Case 3
                        columna = "C"
                        equipo(fila - 2) = oSheet.Range(columna & fila).Text
                        'Buscar equipo en tabla inventario.ETIQUETA, sino insertarlo ETIQUETA, Ubicacion, ...
                        '   Aula_IdAula (Buscar en tabla aulataller. NumeroAula, Descripcion) sino Pabellon, Pabellones_IdPabellon = 0, 0 edo 1, 1?
                        Dim ds As New DataSet
                        Dim select1 As String = "SELECT * FROM " & tablaInventario & " WHERE ETIQUETA = '" & equipo(fila - 2) & "';"
                        Dim adp As New MySqlDataAdapter(select1, conn)
                        ds.Tables.Add("Bilaketa_Equipo")
                        adp.Fill(ds.Tables("Bilaketa_Equipo"))

                        If ds.Tables("Bilaketa_Equipo").Rows.Count > 0 Then
                            'Ekipoa aurkitu da
                            IDequipo = CInt(ds.Tables("Bilaketa_Equipo").Rows(0).Item("IdEquipo"))
                        Else
                            'Ez da Ekipoa aurkitu, sortu hurrengo datuarekin 
                            IDequipo = 0
                        End If
                        'MsgBox("IDequipo: " & IDequipo)
                    Case 4
                        columna = "D" 'Ubicación del ordenador
                        aula(fila - 2) = oSheet.Range(columna & fila).Text
                        'IDaula, buscar tal cual
                        Dim ds2 As New DataSet
                        Dim select2 As String = "SELECT * FROM " & tablaAulaTaller & " WHERE NumeroAula = '" & aula(fila - 2) & "' or Descripcion = '" & aula(fila - 2) & "';"
                        Dim adp2 As New MySqlDataAdapter(select2, conn)
                        ds2.Tables.Add("Bilaketa_Aula")
                        adp2.Fill(ds2.Tables("Bilaketa_Aula"))
                        If ds2.Tables("Bilaketa_Aula").Rows.Count > 0 Then
                            'Gela aurkitu da
                            IDaula = CInt(ds2.Tables("Bilaketa_Aula").Rows(0).Item("IdAula"))
                            IDpabellon = CInt(ds2.Tables("Bilaketa_Aula").Rows(0).Item("Pabellon"))
                            'MsgBox("IDaula: " & IDaula)
                        Else
                            'Ez da Gela aurkitu, sortu hurrengo datuarekin 
                            insertAula(fila)
                        End If

                        ' ^^Ekipoa berria sortu behar den ikusi
                        If IDequipo = 0 Then
                            IDaula = 3 '!!Desconocida ?
                            insertPC(fila)
                        End If
                    Case 5
                        columna = "E"
                        deskribapena(fila - 2) = oSheet.Range(columna & fila).Text
                        '! Falta tratar 'Intros', en que formato hay que guardarlos?      

                    Case 6
                        columna = "F" 'Fecha de entrega (urgencia) =? Noizko
                        '•	La columna 'Fecha de entrega' se corresponde con la 'Fecha de necesidad' =? Noizko
                        '   Corregir formato fecha
                        If oSheet.Range(columna & fila).Text.Equals("") Then
                            '"0000-00-00 00:00:00"
                            'fechaEntrega(fila - 2) = oSheet.Range(columna & fila).Text
                            fechaEntrega(fila - 2) = "0000-00-00 00:00:00"
                        Else
                            'fechaEntrega(fila - 2) = dataBihurtu(oSheet.Range(columna & fila).Text) -> X '23-2018-01
                            temp = oSheet.Range(columna & fila).Text
                            fechaEntrega(fila - 2) = temp.Replace("/", "-")
                        End If
                    Case 7
                        columna = "G"
                        oharrak(fila - 2) = oSheet.Range(columna & fila).Text
                        '! Falta tratar 'Intros', en que formato hay que guardarlos?
                    Case 8
                        columna = "H" 'Técnico Asignado
                        tekniko(fila - 2) = oSheet.Range(columna & fila).Text
                        'Buscar 'tal cual' o crear
                        Dim ds3 As New DataSet
                        Dim select3 As String = "SELECT * FROM " & tablaTecnicos & " WHERE Nombre = '" & tekniko(fila - 2) & "';"
                        Dim adp3 As New MySqlDataAdapter(select3, conn)
                        ds3.Tables.Add("Bilaketa_Teknikoa")
                        adp3.Fill(ds3.Tables("Bilaketa_Teknikoa"))
                        If ds3.Tables("Bilaketa_Teknikoa").Rows.Count > 0 Then
                            'Teknikoa aurkitu da
                            IDteknikoa = CInt(ds3.Tables("Bilaketa_Teknikoa").Rows(0).Item("IdTecnico"))
                            'MsgBox("IDteknikoa: " & IDteknikoa)
                        Else
                            'Ez da Teknikoa aurkitu, sortu hurrengo datuarekin 
                            insertTekni(fila)
                        End If
                    Case 9
                        columna = "I" 'Tratamiento de la incidencia
                        tratamientoIncid(fila - 2) = oSheet.Range(columna & fila).Text
                    Case 10
                        'J
                    Case 11
                        'K
                    Case 12
                        'L
                    Case 13
                        columna = "M" ''Fecha de cierre
                        '   Corregir formato fecha
                        If oSheet.Range(columna & fila).Text.Equals("") Then
                            'fechaCierre(fila - 2) = oSheet.Range(columna & fila).Text
                            fechaCierre(fila - 2) = "0000-00-00 00:00:00"
                        Else
                            fechaCierre(fila - 2) = dataBihurtu(oSheet.Range(columna & fila).Text)
                        End If
                    Case Else
                        MsgBox("Error en la columna")
                End Select
            Next col
            'Mostramos algo en la pantalla, para verificar la carga
            ListBox1.Items.Add(oharrak(fila - 2))

            '   Corregir formato fecha
            Dim sortze As String = dataBihurtu(creada(fila - 2))

            '•	Estado de la incidencia/asignación a guardar:
            Dim Egoera As String = "" 'Incidencia
            Dim Estado As String = "" 'Asignacion
            Dim cumple As Boolean = False
            '   o	Si la fecha de cierre viene informada, la incidencia se debe guardar con el estado Finalizada. Si el técnico está asignado, el estado de la asignación será también Finalizada.
            If fechaCierre(fila - 2) <> "0000-00-00 00:00:00" Then
                Egoera = "Finalizada"
                cumple = True
            End If
            If tekniko(fila - 2) <> "" Then
                Estado = "Finalizada"
                cumple = True
            End If
            '   o	Si el técnico viene informado pero sin descripción de trabajo: Incidencia Procesando / Asignación Asignada.
            If tekniko(fila - 2) <> "" And deskribapena(fila - 2) = "" Then
                Egoera = "Procesando"
                Estado = "Asignada"
                cumple = True
            End If
            '   o	Si el técnico viene informado y también la descripción de trabajo: Incidencia Procesando / Asignación Procesando.
            If tekniko(fila - 2) <> "" And deskribapena(fila - 2) <> "" Then
                Egoera = "Procesando"
                Estado = "Procesando"
                cumple = True
            End If
            '   o	Si no se cumple ninguna de las condiciones anteriores, el estado a guardar será Iniciada.
            If cumple = False Then
                Egoera = "Iniciada"
                Estado = "Iniciada"
            End If

            'Insertamos la fila con los datos en la BD INTZIDENTZIAK
            Dim insert_intzidentziak As String = ""
            If fechaEntrega(fila - 2) = "0000-00-00 00:00:00" Then
                insert_intzidentziak = ("INSERT INTO " & tablaIntzidentziak & " (Creada, email, Equipo, Pabellon, AulaTaller, ArazoenDeskribapena, Oharrak, Estado) VALUES ('" & sortze & "', '" & email(fila - 2) & "', " & IDequipo & ", " & IDpabellon & ", " & IDaula & ", '" & deskribapena(fila - 2) & "', '" & oharrak(fila - 2) & "', '" & Egoera & "'); SELECT LAST_INSERT_ID()")
            Else
                insert_intzidentziak = ("INSERT INTO " & tablaIntzidentziak & " (Creada, email, Equipo, Pabellon, AulaTaller, ArazoenDeskribapena, Noizko, Oharrak, Estado) VALUES ('" & sortze & "', '" & email(fila - 2) & "', " & IDequipo & ", " & IDpabellon & ", " & IDaula & ", '" & deskribapena(fila - 2) & "', '" & fechaEntrega(fila - 2) & "' , '" & oharrak(fila - 2) & "', '" & Egoera & "'); SELECT LAST_INSERT_ID()")
            End If
            Dim cmd_query As New MySqlCommand(insert_intzidentziak, conn)
            IDintzidentzia = CInt(cmd_query.ExecuteScalar())

            'Insertamos la fila asiganciones BD ASIGNACIONES Incidencia, Tecnico, Estado, Tecnicos_IdTecnico(IDteknikoa), Intzidentziak_IdIntzidentzia(IDintzidentzia)
            Using Command3 As MySqlCommand = conn.CreateCommand
                If tratamientoIncid(fila - 2) = "" Then
                    Command3.CommandText = "INSERT INTO " & tablaAsignaciones & " (Incidencia, Tecnico, Estado) VALUES (" & IDintzidentzia & ", " & IDteknikoa & ", '" & Estado & "');"
                Else
                    '+DescTrabajo
                    Command3.CommandText = "INSERT INTO " & tablaAsignaciones & " (Incidencia, Tecnico, Estado, DescTrabajo) VALUES (" & IDintzidentzia & ", " & IDteknikoa & ", '" & Estado & "', '" & tratamientoIncid(fila - 2) & "');"
                End If
                Command3.ExecuteNonQuery()
            End Using
        Next fila

        lblEstado.Text = "Datos leídos correctamente."
        oBook.Close() 'Cerramos el libro y la conexion BD
        conn.Close()
    End Sub

    Function dataBihurtu(ByRef dataStr As String)
        'Corregir formato fecha
        Dim str As String = dataStr
        Dim strarr() As String
        strarr = str.Split(" ")

        Dim strarrDMA() As String
        strarrDMA = strarr(0).ToString.Split("/")
        Dim sortze As String
        If strarr.Length > 1 Then
            sortze = strarrDMA(2) & "-" & strarrDMA(0) & "-" & strarrDMA(1) & " " & strarr(1).ToString
        Else
            sortze = strarrDMA(2) & "-" & strarrDMA(0) & "-" & strarrDMA(1)
        End If
        Return sortze
    End Function

    Sub insertAula(ByRef fila As Integer) 'Ez da Gela aurkitu, sortu hurrengo datuarekin 
        '!!? IdAula -> AutoIcrement
        '   ALTER TABLE `aulataller`   CHANGE COLUMN `IdAula` `IdAula` INT(11) NOT NULL AUTO_INCREMENT FIRST;
        Dim insert_query As String = ("INSERT INTO " & tablaAulaTaller & " (NumeroAula, Descripcion, Pabellon) VALUES ('" & aula(fila - 2) & "', '" & aula(fila - 2) & "', 1); SELECT LAST_INSERT_ID()")
        Dim cmd_query As New MySqlCommand(insert_query, conn)
        IDaula = CInt(cmd_query.ExecuteScalar())
        IDpabellon = 1 'Informatica Elorrieta
        'MsgBox("IDaula new: " & IDaula)
    End Sub

    Sub insertPC(ByRef fila As Integer)
        Dim insert_queryPC As String = ("INSERT INTO " & tablaInventario & " (ETIQUETA, Ubicacion, Aula, Pabellon) VALUES ('" & equipo(fila - 2) & "', '" & aula(fila - 2) & "', '" & IDaula & "', '" & IDpabellon & "'); SELECT LAST_INSERT_ID()")
        Dim cmd_query As New MySqlCommand(insert_queryPC, conn)
        IDequipo = CInt(cmd_query.ExecuteScalar())
        'MsgBox("IDequipo new: " & IDequipo)
    End Sub

    Sub insertTekni(ByRef fila As Integer)
        '!!? IdTecnico -> AutoIcrement
        'ALTER TABLE `tecnicos`
        'CHANGE COLUMN `IdTecnico` `IdTecnico` INT(11) NOT NULL AUTO_INCREMENT FIRST;
        Dim insert_queryTekni As String = ("INSERT INTO " & tablaTecnicos & " (Nombre, Apellidos, Email, Estado) VALUES ('" & tekniko(fila - 2) & "', ' ', '" & email(fila - 2) & "', 'Alta'); SELECT LAST_INSERT_ID()")
        Dim cmd_query As New MySqlCommand(insert_queryTekni, conn)
        IDteknikoa = CInt(cmd_query.ExecuteScalar())
        'MsgBox("IDteknikoa new: " & IDteknikoa)
    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Close()
    End Sub

End Class