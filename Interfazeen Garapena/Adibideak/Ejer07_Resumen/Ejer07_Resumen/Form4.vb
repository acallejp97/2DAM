Imports System.Data.OleDb
Public Class Form4
    Dim acum As String = Nothing
    Dim adap1 As OleDbDataAdapter
    Dim das1 As DataSet
    ' Dim cnn1 As New OleDbConnection(KonexioKatea )
    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim sql As String = "SELECT * FROM Shippers"
        Dim cmd1 As New OleDbCommand(sql, cnn1)
        adap1 = New OleDbDataAdapter(cmd1)

        das1 = New DataSet
        adap1.Fill(das1, "aaa")

        Me.DataGridView1.DataSource = das1.Tables(0)
        Me.DataGridView1.Columns(0).Width = 60
        Me.DataGridView1.Columns(1).Width = 180
        Me.DataGridView1.Columns(2).Width = 140
        Me.DataGridView1.Size = New Size(380, Me.DataGridView1.Height)

        Dim cmb As New OleDbCommandBuilder(adap1)
        ' cmb SOLO lo he utilizado para visualizar los comandos.

        acum = "UPDATE: " & vbNewLine & cmb.GetUpdateCommand.CommandText & vbNewLine & vbNewLine
        acum &= "DELETE: " & vbNewLine & cmb.GetDeleteCommand.CommandText & vbNewLine & vbNewLine
        acum &= "INSERT: " & vbNewLine & cmb.GetInsertCommand.CommandText
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'CARGAR 'Clear dataset contents
        das1.Tables("aaa").Clear()
        adap1.Fill(das1, "aaa")
    End Sub

    Private Sub UPDATE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        adap1.Update(das1, "aaa")
    End Sub

    Private Sub AÑADIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Update second column of first row in Shippers table 
        'within das1 with trailing x
        Dim lerroa As Integer
        lerroa = DataGridView1.CurrentCellAddress.Y

        das1.Tables("aaa").Rows(lerroa)(1) &= "X"
        'das1.Tables("aaa").Rows(0)(1) &= "x"
        adap1.Update(das1, "aaa")
    End Sub

    Private Sub ELIMINAR_X(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Eliminar el último caracter de la fila seleccionada si es una X
        'Remove last character from second column of first row in Shippers table within das1 
        Dim lerroa As Integer
        lerroa = DataGridView1.CurrentCellAddress.Y

        Dim str1 As String = das1.Tables("aaa").Rows(lerroa)(1)
        Dim car As String
        car = Mid(str1, str1.Length - 1, 1) 'str(str1.count-1)
        If car = "X" Then
            das1.Tables("aaa").Rows(lerroa)(1) = Mid(str1, 1, str1.Length - 1) 'substring(0,str1.count-1)
            adap1.Update(das1, "aaa")
        End If
    End Sub

    Private Sub VER_COMANDOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        MsgBox(acum)
    End Sub

    Private Sub btnGuardarXML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarXML.Click
        das1.WriteXml("DataSet.xml")
        '\bin\Debug\ karpetan gordetzen da
    End Sub

    Private Sub btnVerXML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerXML.Click
        System.Diagnostics.Process.Start("DataSet.xml")
    End Sub

    Private Sub CARGAR_DAS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargarXML.Click
        'MsgBox(das1.GetXml())
        das1.ReadXml("DataSet.xml")
    End Sub

    Private Sub BORRAR_DAS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        das1.Tables("aaa").Clear() 'Clear dataset contents
    End Sub
End Class