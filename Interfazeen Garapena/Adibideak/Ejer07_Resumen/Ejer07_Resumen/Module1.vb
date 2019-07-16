Module Module1

    Public KonexioKatea As String = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source=Northwind.mdb"

    'METODOS NO USADOS
    Public cnn1 As New OleDb.OleDbConnection(KonexioKatea)
    'Public cmd As New OleDb.OleDbCommand
    'Public dr As OleDb.OleDbDataReader
    'Public sql As String = ""


    Public Sub Konektatu()
        Try
            If cnn1.State = ConnectionState.Closed Then
                cnn1.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub Deskonektatu()
        Try
            If cnn1.State = ConnectionState.Open Then
                cnn1.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    'Public KonexioKatea As String = "Provider = Microsoft.Jet.OLEDB.4.0; " & "Data Source=..\..\..\..\..\..\Northwind.mdb"

End Module
