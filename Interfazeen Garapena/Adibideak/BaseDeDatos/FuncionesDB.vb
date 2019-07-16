Module FuncionesDB
    Public conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= bd1.mdb;Persist Security Info=False")
    Public cmd As New OleDb.OleDbCommand
    Public dr As OleDb.OleDbDataReader
    Public sql As String = ""

    Public Sub conectarse()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                'MsgBox("Conexión exitosa")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub desconectarse()
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
                'MsgBox("Desconexión exitosa")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub consultar(ByRef identificacion As Double)
        Dim acum As String = Nothing
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        If identificacion > 0 Then
            cmd.CommandText = "Select * from Products where ProductID=" & identificacion
        Else
            cmd.CommandText = "Select * from Products"
        End If

        Try
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read
                    acum += dr(0).ToString + " " + dr(1).ToString + vbNewLine
                End While
                MsgBox(acum)
            Else
                MsgBox("Ez dago informaziorik")
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Module
