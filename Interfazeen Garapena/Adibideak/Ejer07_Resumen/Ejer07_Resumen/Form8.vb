Imports System.Data.OleDb
Public Class Form8
    Dim fila As Integer
    Dim cnn1 As OleDbConnection
    Dim dasemp As New DataSet
    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cnn1 = New OleDbConnection(KonexioKatea)

        'VINCULACION COMPLEJA
        Dim adap1 As New OleDbDataAdapter("select distinct OrderID from [Order Details]", cnn1)
        Dim das1 As New DataSet
        Try
            adap1.Fill(das1, "OrderDetails")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.ComboBox1.DataSource = das1.Tables(0) '
        Me.ComboBox1.DisplayMember = "OrderID"

      
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim sql1 As String = "select Orderid,productid,unitprice,quantity from [Order Details]"
        Dim adap1 As New OleDbDataAdapter(sql1, cnn1)
        Dim das As New DataSet
        Try
            adap1.Fill(das, "OrderDetails")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim dv As New DataView
        dv.Table = das.Tables("OrderDetails")
        dv.RowFilter = "OrderID =" & Me.ComboBox1.SelectedItem(0) 'Vinculacion Compleja

        Me.Label2.Text = "Filtrado por " & Me.ComboBox1.SelectedItem(0)
        Me.DataGridView1.DataSource = dv


        ' SUMA del precio * cantidad
        Dim adap2 As New OleDb.OleDbDataAdapter( _
    "Select * from [Order Details] where OrderId=" & Me.ComboBox1.SelectedItem(0), cnn1)
        Dim das2 As New DataSet
        adap2.Fill(das2, "hijos")
        Dim fila As DataRow
        Dim cant As Decimal
        ' 1- MODO
        For Each fila In das2.Tables("hijos").Rows
            If fila(0) <> 0 Then
                cant += fila(2) * fila(3) '* (1 - fila(4))
                'precio * cantidad '*(1-desc)
            End If
        Next
        Me.Label3.Text = " 1- MODO " & cant.ToString("C") ' Moneda
        

        ' 2- MODO
        cant = 0
        For x = 0 To das2.Tables(0).Rows.Count - 1
            cant += das2.Tables(0).Rows(x)(2) * das2.Tables(0).Rows(x)(3) '* (1 - das2.Tables(0).Rows(x)(4))
            'cant += das2.Tables(0).Rows(x).Items(2) * das2.Tables(0).Rows(x).Items(3) '* (1 - das2.Tables(0).Rows(x)(4))
        Next
        Me.Label5.Text = " 2- MODO " & cant.ToString("C") ' Moneda
        'Me.Label5.Text= cant.ToString("##,##0.00 €")
        'Me.Label5.Text= String.Format("{0,6:f2}", cant)
    End Sub

    Private Sub DataGridView1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.CurrentCellChanged
        fila = Me.DataGridView1.CurrentCellAddress.Y
        If fila >= 0 Then 'hasieran akatsa ez emoteko
            Me.TextBox1.Text = Me.DataGridView1.CurrentRow.Cells("quantity").Value
            Me.TextBox2.Text = Me.DataGridView1.CurrentRow.Cells(1).Value
            Me.TextBox3.Text = Me.DataGridView1.CurrentRow.Cells(2).Value
        End If
    End Sub

    
    Private Sub BtnIr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIr.Click

        'IR A LA FILA DE UN DATAGRIDVIEW
        Dim Columna As Integer = 0, Fila As Integer = Me.TextBox4.Text - 1
        Me.DataGridView1.CurrentCell = Me.DataGridView1(Columna, Fila)


        'Me.DataGridView1.Rows(Me.TextBox4.Text).Selected = True
        'Me.DataGridView1.CurrentCell = _
        'Me.DataGridView1.Rows(Me.TextBox4.Text).Cells(0)
    End Sub

  
End Class