Imports System.Data.OleDb

Public Class frmUntypedNE
    Dim DS As DataSet
    Dim DACategories As OleDbDataAdapter
    Dim DAProducts As OleDbDataAdapter
    Dim regularFont, boldFont As Font

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Width = 1200
        Me.Height = 600

        boldFont = New Font(Rtb.Font.Name, Rtb.Font.Size, FontStyle.Bold)
        regularFont = New Font(Rtb.Font.Name, Rtb.Font.Size, FontStyle.Regular)

        Dim cnn1 As New OleDbConnection(strconexion)

        Dim cmd1 As New OleDbCommand("SELECT CategoryID, CategoryName, Description FROM Categories", cnn1)
        DACategories = New OleDbDataAdapter(cmd1)
        Dim CategoriesCB As New OleDbCommandBuilder(DACategories)


        Dim cmd2 As New OleDbCommand("SELECT ProductID, ProductName, CategoryID, UnitPrice, UnitsInStock, UnitsOnOrder FROM Products ", cnn1)
        DAProducts = New OleDbDataAdapter(cmd2)
        Dim ProductsCB As New OleDbCommandBuilder(DAProducts)


        Dim tabs() As Integer = {150, 400}
        Rtb.SelectionTabs = tabs 'Posición del 1.vbTab y del  2.vbTab
        Rtb.AppendText("Jorge" & vbTab & "Elorrieta" & " - 2º DAI" & vbCrLf)

        Rtb.SelectionFont = boldFont
        Rtb.AppendText("Command for the CATEGORIES Table" & vbCrLf)
        Rtb.SelectionFont = regularFont
        Rtb.AppendText("UPDATE COMMAND " & vbCrLf)
        Rtb.AppendText(vbTab & CategoriesCB.GetUpdateCommand.CommandText & vbCrLf)
        Rtb.AppendText("INSERT COMMAND " & vbCrLf)
        Rtb.AppendText(vbTab & CategoriesCB.GetInsertCommand.CommandText & vbCrLf)
        Rtb.AppendText("DELETE COMMAND " & vbCrLf)
        Rtb.AppendText(vbTab & CategoriesCB.GetDeleteCommand.CommandText & vbCrLf)

        Rtb.SelectionFont = boldFont
        Rtb.AppendText("PRODUCTS Table" & vbCrLf)
        Rtb.SelectionFont = regularFont
        Rtb.AppendText("UPDATE COMMAND " & vbCrLf)
        Rtb.AppendText(vbTab & ProductsCB.GetUpdateCommand.CommandText & vbCrLf)
        Rtb.AppendText("INSERT COMMAND " & vbCrLf)
        Rtb.AppendText(vbTab & ProductsCB.GetInsertCommand.CommandText & vbCrLf)
        Rtb.AppendText("DELETE COMMAND " & vbCrLf)
        Rtb.AppendText(vbTab & ProductsCB.GetDeleteCommand.CommandText & vbCrLf)

    End Sub

    Private Sub bttnCreateDataSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnCreateDataSet.Click
        DS = New DataSet
        DACategories.Fill(DS, "Categories")
        DAProducts.Fill(DS, "Products")

        DS.Relations.Clear()   'NO necesario.
        Dim ca As DataColumn = DS.Tables("Categories").Columns("CategoryID")
        Dim pro As DataColumn = DS.Tables("Products").Columns("CategoryID")
        DS.Relations.Add(New DataRelation("David", ca, pro))

        'UTILIZO LA RELACION  "David"

        Rtb.Clear()
        Dim filaCat As DataRow
        For Each filaCat In DS.Tables("Categories").Rows
            Rtb.SelectionFont = boldFont
            Rtb.AppendText(filaCat.Item("CategoryName") & vbCrLf)
            Rtb.SelectionFont = regularFont
            Dim filaPro As DataRow
            For Each filaPro In filaCat.GetChildRows("David")
                Rtb.AppendText(filaPro.Item("ProductID") & vbTab & _
                            filaPro.Item("ProductName") & vbTab & _
                            Convert.ToDecimal(filaPro.Item("UnitPrice")).ToString("#.00") & vbCrLf)
            Next
        Next
    End Sub
    Private Sub bttnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnEdit.Click
        'Edit DataSet
        Dim RND As New Random
        Randomize()
        Dim a As Integer = RND.Next(1, 7)

        Try
            MsgBox(DS.Tables("Categories").Rows(a).Item("CategoryName"))
            DS.Tables("Categories").Rows(a).Item("CategoryName") &= "*"
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MsgBox(DS.Tables("Categories").Rows(a).Item("CategoryName"))
        End Try
    End Sub

    Private Sub bttnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnSubmit.Click
        Try
            DAProducts.Update(DS.Tables("Products"))
            DACategories.Update(DS.Tables("Categories"))
        Catch ex As Exception
            MsgBox(ex.Message)

            If DS.Tables("Products").HasErrors Then
                Dim row As DataRow
                Dim msg As String = ""
                For Each row In DS.Tables("Products").GetErrors
                    If row.HasErrors Then
                        Select Case row.RowState
                            Case DataRowState.Added
                                msg &= "FAILED TO ADD PRODUCT WITH ID = " & row.Item("ProductID").ToString & vbCrLf & _
                                                                row.RowError & vbCrLf
                            Case DataRowState.Modified
                                msg &= "FAILED TO MODIFY PRODUCT WITH ID = " & row.Item("ProductID").ToString & vbCrLf & _
                                                                row.RowError & vbCrLf
                            Case DataRowState.Deleted
                                msg &= "FAILED TO DELETE PRODUCT WITH ID = " & Convert.ToString(row.Item("ProductID", DataRowVersion.Original) & vbCrLf & _
                                                                row.RowError)
                        End Select
                        msg &= vbCrLf
                    End If
                Next
                MsgBox(msg)
            End If

            If DS.Tables("Categories").HasErrors Then
                Dim row As DataRow
                Dim msg As String = ""
                For Each row In DS.Tables("Categories").GetErrors
                    If row.HasErrors Then
                        Select Case row.RowState
                            Case DataRowState.Added
                                msg &= "FAILED TO ADD CATEGORY WITH ID = " & Convert.ToString(row.Item("CategoryID") & vbCrLf & _
                                                                row.RowError & vbCrLf)
                            Case DataRowState.Modified
                                msg &= "FAILED TO MODIFY CATEGORY WITH ID = " & Convert.ToString(row.Item("CategoryID") & vbCrLf & _
                                                                row.RowError & vbCrLf)
                            Case DataRowState.Deleted
                                msg &= "FAILED TO DELETE CATEGORY WITH ID = " & Convert.ToString(row.Item("CategoryID", DataRowVersion.Original) & vbCrLf & _
                                                                row.RowError)
                        End Select
                        msg &= vbCrLf
                    End If
                Next
                MsgBox(msg)
            End If

        End Try

    End Sub

    Private Sub bttnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnShow.Click
        Dim fila As DataRow
        Dim msg As String = ""
        For Each fila In DS.Tables("Products").Rows
            If fila.RowState = DataRowState.Added Then
                msg &= "ADDED fila: " & fila.Item("ProductName") & vbTab & fila.Item("UnitPrice").ToString & vbCrLf
            End If
            If fila.RowState = DataRowState.Modified Then
                msg &= "MODIFIED fila: " & fila.Item("ProductName") & vbTab & fila.Item("UnitPrice").ToString & vbCrLf
            End If
            If fila.RowState = DataRowState.Deleted Then
                msg &= "DELETED fila: " & fila.Item("ProductName") & vbTab & fila.Item("UnitPrice").ToString & vbCrLf
            End If
        Next
        'Dim category As DataRow
        For Each fila In DS.Tables("Categories").Rows
            If fila.RowState = DataRowState.Added Then
                msg &= "ADDED fila: " & fila.Item("CategoryName") & vbCrLf
            End If
            If fila.RowState = DataRowState.Modified Then
                msg &= "MODIFIED PRODUCT: Original: " & fila.Item("CategoryName", DataRowVersion.Original) & _
                    " ---> " & fila.Item("CategoryName") & vbCrLf
            End If
            If fila.RowState = DataRowState.Deleted Then
                msg &= "DELETED PRODUCT: " & fila.Item("CategoryID") & vbCrLf
            End If
        Next
        If msg.Length > 0 Then
            MsgBox(msg)
        Else
            MsgBox("There are no changes in the dataset")
        End If
    End Sub

    Private Sub bttnRejectChanges_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnRejectChanges.Click
        DS.RejectChanges()
    End Sub

End Class
