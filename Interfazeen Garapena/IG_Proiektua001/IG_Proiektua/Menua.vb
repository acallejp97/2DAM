'ODBC connector para MySQL que funciona con VS2013
'https://cdn.mysql.com/Downloads/MySQLInstaller/mysql-visualstudio-plugin-1.1.1.msi
'Herramientas > Conectar con Base de Datos (Una vez instalado aparecerá MySQL como opción)

Imports System.IO
Imports System.Data.OleDb ' MDac (Microsoft Data Access Tool) and OleDb
'Imports Microsoft.Office.Interop.Excel ' Add ref to COM-object Microsoft.Office.Interop.Excel
'..................... comentarios aparte ^


Imports MySql.Data.MySqlClient

Public Class Menua
    'Public conn As New MySqlConnection("server=localhost; user=root; password=elorrieta; database=pilar; port=3306")
    Public conn As New MySqlConnection("server=10.22.23.66; user=pilar; password=12345; database=pilar; port=3306")
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader

    Public Sub conectar()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                'MsgBox("Conexión exitosa")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub rellenar()
        Dim ds As New DataSet
        Dim select1 As String = "SELECT * FROM Intzidentziak"

        Dim adp As New MySqlDataAdapter(select1, conn)
        ds.Tables.Add("Intzidentziak")
        adp.Fill(ds.Tables("Intzidentziak"))

        Me.DataGridView1.DataSource = ds.Tables("Intzidentziak")
        'Me.DataGridView1.Columns(0).HeaderText = "IDa"
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        'Confirmación del usuario
        Dim resp As DialogResult
        resp = MessageBox.Show("¿Seguro que desea salir?", "SALIR DE LA APLICACIÓN", MessageBoxButtons.YesNo)
        If resp = vbYes Then
            Close()
        End If
    End Sub

    Private Sub OPCA2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OPCA2ToolStripMenuItem.Click
        CargaDatos.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        conectar()
        rellenar()
    End Sub
End Class


