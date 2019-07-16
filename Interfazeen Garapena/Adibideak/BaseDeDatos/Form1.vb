Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conectarse()
        llenaGrid()
    End Sub

    Private Sub llenaGrid()
        Dim ds As New DataSet
        'Dim dt As New DataTable
        Dim strSql As String = "Select * from Employees"
        Dim adp As New OleDb.OleDbDataAdapter(strSql, conn)

        ds.Tables.Add("tabla")
        adp.Fill(ds.Tables("tabla"))

        Me.DataGridView1.DataSource = ds.Tables("tabla")
        Me.DataGridView1.Columns(0).HeaderText = "Identi"
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim id As Double
        id = Val(Me.TextBox1.Text)
        consultar(id)
    End Sub
End Class
