Imports System.Data.OleDb
Public Class Form7a
    Dim cnn1 As New OleDbConnection(KonexioKatea)
    Dim das1 As New DataSet
    Dim dasemp As New DataSet
    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'VINCULACION COMPLEJA
        Konektatu()
        Dim sql As String = "select distinct OrderID from [Order Details]"
        Dim adap1 As New OleDbDataAdapter(sql, cnn1)
        adap1.Fill(das1, "aaa")

        Me.ComboBox1.DataSource = das1.Tables(0)
        Me.ComboBox1.DisplayMember = "OrderID"

        'NAVEGAR por la tabla de empleados
        Dim adap2 As New OleDbDataAdapter(
            "select Firstname, title from Employees", cnn1)
        Try
            adap2.Fill(dasemp, "bbb")
            'Debug.WriteLine("Num: " & Me.dasemp.Tables(0).Rows.Count) 'Ventana inmediato Ctrl + Alt + I
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.DataGridView2.DataSource = dasemp.Tables(0)



        'Employees, kasu honetan, ez da taularen izena baizik eta datasetaren izena.
        Me.TextBox4.DataBindings.Add("Text", dasemp, "bbb.FirstName")
        Me.TextBox5.DataBindings.Add("Text", dasemp, "bbb.Title")
        Erakutsi()
        Deskonektatu()
    End Sub

    Private Sub PRIMERO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        '<<
        Me.BindingContext(dasemp, "bbb").Position = 0
        Erakutsi()
    End Sub

    Private Sub ANTERIOR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.BindingContext(dasemp, "bbb").Position -= 1
        Erakutsi()
    End Sub

    Private Sub SIGUIENTE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.BindingContext(dasemp, "bbb").Position += 1
        Erakutsi()
    End Sub

    Private Sub ULTIMO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.BindingContext(dasemp, "bbb").Position = _
       Me.BindingContext(dasemp, "bbb").Count - 1
        Erakutsi()
    End Sub

    Public Sub Erakutsi()
        Label4.Text = _
        Me.BindingContext(dasemp, "bbb").Position + 1 & _
        " de " & Me.BindingContext(dasemp, "bbb").Count
        Dim fila As Integer = Me.BindingContext(dasemp, "bbb").Position
        Me.DataGridView2.CurrentCell = Me.DataGridView2(0, fila)   'Columna,fila

        'Me.DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        'Me.DataGridView2.ClearSelection()
        'Me.DataGridView2.Rows(fila).Selected = True
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'Me.TextBox1.Text = Me.DataGridView1.CurrentRow.Cells.Item(1).Value
        'Me.TextBox2.Text = Me.DataGridView1.CurrentRow.Cells.Item(2).Value
        'Me.TextBox3.Text = Me.DataGridView1.CurrentRow.Cells.Item(3).Value

    End Sub


    Private Sub DataGridView2_CurrentCellChanged(sender As Object, e As System.EventArgs) Handles DataGridView2.CurrentCellChanged
        Me.BindingContext(dasemp, "bbb").Position = Me.DataGridView2.CurrentCellAddress.Y
        Label4.Text = _
        Me.BindingContext(dasemp, "bbb").Position + 1 & _
        " de " & Me.BindingContext(dasemp, "bbb").Count
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        'Por tener VINCULACION COMPLEJA ComboBox1.SelectedItem(0)
        Dim sql As String = "select * from [Order Details] where OrderID=" & _
                Me.ComboBox1.SelectedItem(0)
        Label2.Text = sql

        Dim adap2 As New OleDbDataAdapter(sql, cnn1)
        Dim das2 As New DataSet
        adap2.Fill(das2, "aaa")

        Me.DataGridView1.DataSource = das2.Tables("aaa")
        Me.Label3.Text = das2.Tables(0).Rows.Count & " filas." 'Debug.Write(das2.Tables(0).Rows.Count & " filas.")

    End Sub















    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' EJECUTAR la consulta "Order Subtotals" 
        ' ya hecha en la BD.

        Dim cmd1 As New OleDbCommand
        Konektatu()

        cmd1.Connection = cnn1
        cmd1.CommandType = CommandType.StoredProcedure 'Va a coger una consulta
        cmd1.CommandText = "[Order Subtotals]" 'Nombre de la consulta
        Dim adap1 As New OleDbDataAdapter(cmd1)

        Dim das1 As New DataSet
        adap1.Fill(das1, "aa")

        Me.DataGridView3.DataSource = das1.Tables("aa")
        Deskonektatu()
    End Sub

   
    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub
End Class












