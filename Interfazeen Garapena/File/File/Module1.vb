Imports System.IO
Module Module1
    Sub main()
        Dim fs As FileStream = Nothing
        Dim sr As StreamReader = Nothing
        Dim linea As String = Nothing
        Try
            fs = New FileStream("..\..\..\datuak.txt", FileMode.Open, FileAccess.Read)
            sr = New StreamReader(fs)
            'METODO - 1,  Lerroz lerro
            linea = sr.ReadLine
            While linea <> Nothing
                Console.WriteLine("Metodo 1: " & linea)
                linea = sr.ReadLine
            End While
            'METODO - 2,  Fitxategi osoa irakurri (erabili bata ala bestea, ez biak)
            'Console.WriteLine("Metodo 2: " & sr.ReadToEnd())
            'Console.ReadLine()
        Catch ex As Exception
            Console.WriteLine("Errorea:" & ex.ToString)
        Finally
            If Not sr Is Nothing Then sr.Close()
            If Not sr Is Nothing Then fs.Close()
        End Try
        Console.ReadLine()
    End Sub
End Module

