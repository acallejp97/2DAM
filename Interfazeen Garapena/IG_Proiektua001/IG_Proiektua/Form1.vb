'ODBC connector para MySQL que funciona con VS2013
'https://cdn.mysql.com/Downloads/MySQLInstaller/mysql-visualstudio-plugin-1.1.1.msi
'Herramientas > Conectar con Base de Datos (Una vez instalado aparecerá MySQL como opción)

Imports System.IO
Imports System.Data.OleDb ' MDac (Microsoft Data Access Tool) and OleDb
'Imports Microsoft.Office.Interop.Excel ' Add ref to COM-object Microsoft.Office.Interop.Excel

Imports System.Data.Odbc
Imports System.Data.Sql
Imports System.Data.SqlClient
'Imports MySql.Data
'Imports MySql.Data.MySqlClient

Public Class Form1
    'Public Sub Connexion()
    '    Dim connStr As String = "SERVER=localhost;DATABASE=GestionDuPersonnel;UID=test;PASSWORD=test"
    '    Dim connection As New MySqlConnection(connStr)
    '    connection.Open()
    'End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub OPCA2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OPCA2ToolStripMenuItem.Click
        CargaDatos.Show()
    End Sub
End Class


