Imports System.Data.OleDb
Public Class Form2
    ' Dim cnn1 As New OleDbConnection(KonexioKatea )  
    'moduloan deklaraturik dago
    Dim sql As String
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Konektatu()
    End Sub

    Private Sub CategoriakZenbatu(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Devuelve un valor.
        sql = "Select count(*) from Customers"
        Dim cmd1 As New OleDbCommand(sql, cnn1)
        Try
            Konektatu()
            Dim resul As Integer = cmd1.ExecuteScalar
            MsgBox(resul & " customers daude")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Deskonektatu()
            ' If cnn1.State = ConnectionState.Open Then cnn1.Close()
        End Try
    End Sub

    Private Sub GehituParametroBarik(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        sql = "INSERT INTO Customers (CustomerID, CompanyName)  Values " & _
            "('MYCOM', 'ProgrammingMSAccess.com')"
        Dim resul As Integer
        Dim cmd1 As New OleDbCommand(sql, cnn1)
        Try
            Konektatu() 'cnn1.Open()
            resul = cmd1.ExecuteNonQuery
            MsgBox(resul & " Lerroa gehiturik")
        Catch ex As Exception
            sql = "Delete * from Customers WHERE CustomerID='MYCOM'"
            Dim cmd2 As New OleDbCommand(sql, cnn1)
            resul = cmd2.ExecuteNonQuery
            MsgBox(resul & "Lerroa ezabaturik")
        Finally
            Deskonektatu()
            'If cnn1.State = ConnectionState.Open Then cnn1.Close()
        End Try
    End Sub

    Private Sub GehituParametroekin(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        sql = "INSERT INTO Customers (CustomerID, CompanyName)  Values (@bat, @bi)"
        Dim resul As Integer
        Dim cmd1 As New OleDbCommand(sql, cnn1)
        cmd1.Parameters.AddWithValue("@bat", TextBox1.Text)
        cmd1.Parameters.AddWithValue("@bi", TextBox2.Text)
        Try
            Konektatu() 'cnn1.Open()
            resul = cmd1.ExecuteNonQuery
            MsgBox(resul & " Lerroa gehiturik")
        Catch ex As Exception
            sql = "Delete * from Customers WHERE CustomerID=@tres"
            Dim cmd2 As New OleDbCommand(sql, cnn1)
            cmd2.Parameters.AddWithValue("@tres", "MYCOM")
            resul = cmd2.ExecuteNonQuery
            MsgBox(resul & "Lerroa ezabaturik")
        Finally
            Deskonektatu()
            'If cnn1.State = ConnectionState.Open Then cnn1.Close()
        End Try
    End Sub
End Class