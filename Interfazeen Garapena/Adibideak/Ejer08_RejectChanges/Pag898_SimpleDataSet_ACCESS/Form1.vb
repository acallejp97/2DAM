Imports System.Data.OleDb
Public Class Form1

    Dim adap1 As OleDbDataAdapter 'NUEVO
    Dim das1 As DataSet
    Private Sub Cargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cnn1 As New OleDbConnection(strconexion)
        das1 = New DataSet  'NUEVO

        Dim cmd1 As OleDbCommand


        Try
            cnn1.Open()
            cmd1 = New OleDbCommand("Select * from employees", cnn1)
            adap1 = New OleDbDataAdapter(cmd1)
            Dim cmb As New OleDbCommandBuilder(adap1)

            das1.Clear() ' Para que se refresque bien el DataGrid
            adap1.Fill(das1, "tele")

            Me.DataGridView1.DataSource = das1.Tables("tele")               ' Me.DataGridView1.DataSource = das1.Tables(0)
            Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Aquamarine
        Catch ex As Exception
            MsgBox(ex.Message)
            'Finally
            cnn1.Close()
        End Try

    End Sub

    Private Sub bttnShow_Click(sender As System.Object, e As System.EventArgs) Handles bttnShow.Click
        Dim fila As DataRow
        Dim msg As String = ""
       
        For Each fila In das1.Tables("tele").Rows
            If fila.RowState = DataRowState.Added Then
                msg &= "ADDED fila: " & fila.Item("EmployeeID") & _
                    " ---> " & fila.Item("FirstName") & vbCrLf
            End If
            If fila.RowState = DataRowState.Modified Then
                msg &= "MODIFIED employee: Original: " & fila.Item("FirstName", DataRowVersion.Original) & _
                    " ---> " & fila.Item("FirstName") & vbCrLf
            End If
            If fila.RowState = DataRowState.Deleted Then
                msg &= "DELETED employee: " & fila.Item("EmployeeID") & vbCrLf
            End If
        Next
        If msg.Length > 0 Then
            MsgBox(msg)
        Else
            MsgBox("There are no changes in the dataset")
        End If
    End Sub

    Private Sub bttnRejectChanges_Click(sender As System.Object, e As System.EventArgs) Handles bttnRejectChanges.Click
        das1.RejectChanges()
    End Sub

    Private Sub bttnSubmit_Click(sender As System.Object, e As System.EventArgs) Handles bttnSubmit.Click
        Try
            Me.adap1.Update(das1.Tables("tele"))

        Catch ex As Exception
            MsgBox(ex.Message)

            If das1.Tables("tele").HasErrors Then
                Dim row As DataRow
                Dim msg As String = ""
                For Each row In das1.Tables("tele").GetErrors
                    If row.HasErrors Then
                        Select Case row.RowState
                            Case DataRowState.Added
                                msg &= "FAILED TO ADD EMPLOYEE WITH ID = " & row.Item("EmployeeID").ToString & vbCrLf & _
                                                                row.RowError & vbCrLf
                            Case DataRowState.Modified
                                msg &= "FAILED TO MODIFY EMPLOYEE WITH ID = " & row.Item("EmployeeID").ToString & vbCrLf & _
                                                                row.RowError & vbCrLf
                            Case DataRowState.Deleted
                                msg &= "FAILED TO DELETE EMPLOYEE WITH ID = " & Convert.ToString(row.Item("EmployeeID", DataRowVersion.Original) & vbCrLf & _
                                                                row.RowError)
                        End Select
                        msg &= vbCrLf
                    End If
                Next
                MsgBox(msg)
            End If
        End Try
    End Sub


End Class