Imports System.Data.OleDb
Public Class Form3
    'Dim cnn1 As New OleDbConnection(KonexioKatea )
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim acum As String = Nothing
        Dim sql As String = "Select * from shippers"
        Dim cmd1 As New OleDbCommand(sql, cnn1)
        Dim dr As OleDbDataReader = Nothing
        Try
            Konektatu() 'cnn1.Open()
            dr = cmd1.ExecuteReader

            For x = 0 To dr.FieldCount - 1
                acum &= dr.GetName(x) & " - " & dr.GetFieldType(x).ToString & vbNewLine
            Next

            acum &= StrDup(40, "-") & vbNewLine

            While dr.Read
                acum &= dr.Item(0) & "-" & dr.Item(1) & "-" & dr.Item(2) & vbNewLine
            End While
            MsgBox(acum, , "Select * from shippers")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dr.Close()
            'If cnn1.State = ConnectionState.Open Then cnn1.Close()
            desKonektatu()
        End Try
    End Sub

    Private Sub Taldeka_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim x As Integer
        Dim acum As String = Nothing

        'Dim cnn1 As New OleDbConnection(KonexioKatea )
        Konektatu() 'cnn1.Open()

        Dim dr As OleDbDataReader
        Dim cmd1 As New OleDbCommand("SELECT * FROM customers", cnn1)

        dr = cmd1.ExecuteReader

        While dr.Read 'Hurrengo irakurtzen ...
            x += 1
            acum += x & "-" & dr.GetValue(0) & " " & dr.GetValue(1) & vbNewLine
            If x Mod 30 = 0 Then
                MsgBox(acum, , "Select * from Customers")
                acum = ""
            End If
        End While
        If x Mod 30 <> 0 Then MsgBox(acum, , "Select * from Customers")
        dr.Close()
        Deskonektatu() 'cnn1.Close()
    End Sub
End Class