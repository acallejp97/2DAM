Imports System.Data.OleDb
Public Class Form5_NO
    Dim cnn1 As New OleDbConnection(KonexioKatea)
    Dim das1 As New DataSet
    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ListView1.Columns.Add("Compañia", 140, HorizontalAlignment.Right)
        Me.ListView1.Columns.Add("Responsable", 140, HorizontalAlignment.Right)
        Me.ListView1.Columns.Add("Región", 140, HorizontalAlignment.Right)
        Me.ListView1.View = View.Details
        Me.ListView1.GridLines = True
        Me.ListView1.Size = New Size(400, Me.ListView1.Height)
    End Sub

    Private Sub CARGAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sql As String = "select *  from Customers order by contactname"
        Dim cmd1 As New OleDbCommand(sql, cnn1)
        Dim adap1 As New OleDbDataAdapter(cmd1)
        adap1.Fill(das1, "aaa")

        Me.DataGridView1.DataSource = das1.Tables(0)

        For x = 0 To das1.Tables(0).Rows.Count - 1
            Me.ListView1.Items.Add(Me.das1.Tables(0).Rows(x)(0).ToString)
            Me.ListView1.Items(x).SubItems.Add(Me.das1.Tables(0).Rows(x)(1).ToString)
            Me.ListView1.Items(x).SubItems.Add(Me.das1.Tables(0).Rows(x)(2).ToString)
            ' Debo añadir .ToString porque tiene valores nulos.
        Next



        Me.DataGrid1.DataSource = das1.Tables(0)
    End Sub

    Private Sub IRaFILA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim num As Integer = Me.TextBox1.Text
        If num >= 1 And num < das1.Tables(0).Rows.Count Then
            'IR A LA CELDA DE UN DATAGRIDVIEW
            Dim Columna As Integer = 0, Fila As Integer = num - 1

            Me.DataGridView1.CurrentCell = Me.DataGridView1(Columna, Fila)

            Me.TextBox2.Text = Me.das1.Tables(0).Rows(Fila)(0).ToString
            Me.TextBox3.Text = Me.das1.Tables(0).Rows(Fila)(1).ToString
            Me.TextBox4.Text = Me.das1.Tables(0).Rows(Fila)(2).ToString
            Me.TextBox1.Select(0, Me.TextBox1.MaxLength)
            Me.TextBox1.Focus()


            'NO DARLO
            'IR A LA FILA DE UN LISTVIEW
            ' Son obligatorias todas estas líneas de propiedades.
            Me.ListView1.FullRowSelect = True
            Me.ListView1.GridLines = True
            Me.ListView1.HideSelection = False
            Me.ListView1.MultiSelect = False

            ListView1.Items(num - 1).Selected = True
            ListView1.Items(num - 1).EnsureVisible()
            ListView1.Focus()

            'IR A LA FILA DE UN DATAGRID
            Me.DataGrid1.CurrentRowIndex = num - 1
        End If
    End Sub



    Private Sub SELECCIONAR_FILA(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.DataGridView1.Rows(Me.TextBox1.Text - 1).Selected = True
        'Me.DataGridView1.CurrentCell = Me.DataGridView1.Rows(Me.TextBox1.Text - 1).Cells(0)

        'Dim a As DataGridViewRow = Me.DataGridView1.CurrentRow
        'Me.TextBox2.Text = a.Cells.Item(0).ToString
        'Me.TextBox3.Text = a.Cells.Item(1).ToString
        'Me.TextBox4.Text = a.Cells.Item(2).ToString

        'Realmente estamos seleccionando la celda (0,0) pero si el modo de selección del DataGridView 
        'es de filas completas, se realizará lo que deseamos.
        'Nota: Cabe destacar que la segunda coordenada (la correspondiente a la columna) debe ser 
        'el valor de una columna visible.

    End Sub

    Private Sub CAMBIAR_COLOR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If IsNumeric(Me.TextBox1.Text) Then
            Me.DataGridView1.Rows(Me.TextBox1.Text - 1).Cells(0).Style.ForeColor = Color.Blue
            Me.DataGridView1.Rows(Me.TextBox1.Text - 1).Cells(1).Style.BackColor = Color.Cyan
            Me.DataGridView1.Rows(Me.TextBox1.Text - 1).Cells(2).Style.BackColor = Color.BlueViolet
            ' NO FUNCIONA
            'Me.DataGrid1(Me.TextBox1.Text - 1, 0).style.backcolor = Color.Blue
            'Me.DataGrid1(Me.TextBox1.Text - 1, 1).style.backcolor = Color.Cyan
            'Me.DataGrid1(Me.TextBox1.Text - 1, 2).style.backcolor = Color.BlueViolet
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Me.TextBox2.Text = Me.DataGridView1.CurrentRow.Cells.Item(0).Value
        Me.TextBox3.Text = Me.DataGridView1.CurrentRow.Cells.Item(1).Value
        Try
            Me.TextBox4.Text = Me.DataGridView1.CurrentRow.Cells.Item(2).Value
        Catch ex As Exception
            Me.TextBox4.Text = ""
        End Try


        'OTRA FORMA
        'Me.TextBox1.Text = Me.DataGridView1.Item(Me.DataGridView1.CurrentCell.ColumnIndex, Me.DataGridView1.CurrentCell.RowIndex).Value.ToString()
        'Me.TextBox2.Text = Me.DataGridView1.Item(Me.DataGridView1.CurrentCell.ColumnIndex + 1, Me.DataGridView1.CurrentCell.RowIndex).Value.ToString()
        'Me.TextBox3.Text = Me.DataGridView1.Item(Me.DataGridView1.CurrentCell.ColumnIndex + 2, Me.DataGridView1.CurrentCell.RowIndex).Value.ToString()
    End Sub

    Private Sub BUSCAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim acum1 As String = InputBox("Introduce un companyname", "Buscar por companyname", "Tortuga Restaurante")
        'SeerchPosLista(acum, 2, ListView1)
        Dim acum2 As String
        For x = 0 To Me.ListView1.Items.Count - 1
            acum2 = Me.ListView1.Items.Item(x).SubItems(1).ToString.ToLower
            If acum2.IndexOf(acum1.ToLower) <> -1 Then
                Me.ListView1.FullRowSelect = True
                Me.ListView1.GridLines = True
                Me.ListView1.HideSelection = False
                Me.ListView1.MultiSelect = False
                ListView1.Items(x).Selected = True
                ListView1.Items(x).EnsureVisible()
                ListView1.Focus()
                Exit For
            End If
        Next

    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        'Al seleccionar una fila del listview1 se llenan los textboxes
        Dim indexes As ListView.SelectedIndexCollection = _
         Me.ListView1.SelectedIndices
        Dim index As Integer
        For Each index In indexes
            Me.TextBox2.Text = Me.ListView1.Items(index).SubItems(0).Text
            Me.TextBox3.Text = Me.ListView1.Items(index).SubItems(1).Text
            Me.TextBox4.Text = Me.ListView1.Items(index).SubItems(2).Text
        Next
    End Sub


    Private Sub DataGrid1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.CurrentCellChanged
        'Me.TextBox2.Text = Me.DataGrid1(Me.DataGrid1.CurrentCell.RowNumber, 0).ToString
        'Me.TextBox3.Text = Me.DataGrid1(Me.DataGrid1.CurrentCell.RowNumber, 1).ToString
        'Me.TextBox4.Text = Me.DataGrid1(Me.DataGrid1.CurrentCell.RowNumber, 2).ToString
    End Sub


    Private Sub DataGrid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DataGrid1.Navigate
        'CUIDADO, no es el evento predeterminado
    End Sub
End Class