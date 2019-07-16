Imports System.Data.OleDb
Public Class Form5a
    Dim cnn1 As New OleDbConnection(KonexioKatea)
    Dim das1 As New DataSet
    Private Sub Form5a_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim sql As String = "select *  from Customers order by contactname"
        Dim cmd1 As New OleDbCommand(sql, cnn1)
        Dim adap1 As New OleDbDataAdapter(cmd1)
        adap1.Fill(das1, "aaa")

        Me.DataGridView1.DataSource = das1.Tables(0)
    End Sub

    Private Sub IrFila_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'IR A LA CELDA DE UN DATAGRIDVIEW  
        Dim num As Integer = Me.MaskedTextBox1.Text

        If num >= 1 And num < das1.Tables(0).Rows.Count Then

            Dim Columna As Integer = 0, Fila As Integer = num - 1

            Me.DataGridView1.CurrentCell = Me.DataGridView1(Columna, Fila)

            Me.TextBox2.Text = Me.das1.Tables(0).Rows(Fila)(0).ToString
            Me.TextBox3.Text = Me.das1.Tables(0).Rows(Fila)(1).ToString
            Me.TextBox4.Text = Me.das1.Tables(0).Rows(Fila)(2).ToString
            Me.MaskedTextBox1.Select(0, MaskedTextBox1.TextLength)
            Me.MaskedTextBox1.Focus()
        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click

        Me.DataGridView1.Rows(Me.MaskedTextBox1.Text - 1).Cells(0).Style.ForeColor = Color.Blue
        Me.DataGridView1.Rows(Me.MaskedTextBox1.Text - 1).Cells(1).Style.BackColor = Color.Cyan
        Me.DataGridView1.Rows(Me.MaskedTextBox1.Text - 1).Cells(2).Style.BackColor = Color.BlueViolet

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If Me.DataGridView1.Rows(Me.MaskedTextBox1.Text - 1).Selected = True Then
            Me.DataGridView1.Rows(Me.MaskedTextBox1.Text - 1).Selected = False
        Else
            Me.DataGridView1.Rows(Me.MaskedTextBox1.Text - 1).Selected = True
        End If

        'Realmente estamos seleccionando la celda (0,0) pero si el modo de selección del DataGridView 
        'es de filas completas, se realizará lo que deseamos.
        'Nota: Cabe destacar que la segunda coordenada (la correspondiente a la columna) debe ser 
        'el valor de una columna visible.
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Me.TextBox2.Text = Me.DataGridView1.CurrentRow.Cells.Item(0).Value
        Me.TextBox3.Text = Me.DataGridView1.CurrentRow.Cells.Item(1).Value
        Try
            Me.TextBox4.Text = Me.DataGridView1.CurrentRow.Cells.Item(2).Value
        Catch ex As Exception
            Me.TextBox4.Text = ""
        End Try
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Dim encontrado As Boolean = False

        Dim acum1 As String = InputBox("Introduce un companyname", "Buscar por companyname", Me.das1.Tables(0).Rows(6)(1).ToString)
        If acum1 <> "" Then
            For x = 0 To Me.das1.Tables(0).Rows.Count - 1
                If acum1 = Me.das1.Tables(0).Rows(x)(1).ToString.Trim Then
                    Me.DataGridView1.Rows(x).Selected = True
                    encontrado = True
                End If
            Next
            If Not encontrado Then MsgBox("No encontrado")
        End If
    End Sub


End Class