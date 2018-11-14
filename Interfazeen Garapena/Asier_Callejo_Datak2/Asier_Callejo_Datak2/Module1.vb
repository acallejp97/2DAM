Imports System.IO

Module Module1

    Sub Main()
        Dim BilatzekoDatak() As String = Nothing
        Dim fs As FileStream = Nothing
        Dim sr As StreamReader = Nothing
        Dim linea As String = Nothing
        Dim cont As Integer = 0

        fs = New FileStream("..\..\..\Datak.txt", FileMode.Open, FileAccess.Read)
        sr = New StreamReader(fs)

        linea = sr.ReadLine
        While linea <> Nothing
            ReDim Preserve BilatzekoDatak(cont)
            BilatzekoDatak(cont) = linea
            cont = cont + 1
            linea = sr.ReadLine
        End While
        cont = 0

        For cont = 0 To BilatzekoDatak.Length - 1
            linea = BilatzekoDatak(cont)
            linea.Split("/")
            BilatzekoDatak(cont) = linea
        Next



        'Inprimatu
        For i = 0 To BilatzekoDatak.Length - 1
            Console.WriteLine(BilatzekoDatak(i))
        Next



        Console.ReadLine()

    End Sub

End Module
