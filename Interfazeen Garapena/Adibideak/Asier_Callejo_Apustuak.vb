﻿Imports System.IO

Module Module1

    Sub Main()
        Randomize()
        Dim fs As FileStream = Nothing
        Dim sr As StreamReader = Nothing
        Dim jokalariak(0) As String
        jokalariak(0) = Nothing '--------->Garrantzitsuak
        Dim zenbakiak(,) As String = Nothing '--------->Garrantzitsuak
        Dim linea As String
        Dim rnd As New Random
        Dim cont1 = 0
        Dim usuario(1) As String
        Dim numeros(5) As String

        Dim seleccionado As String = "z"
        Dim zenbakia(5) As String
        zenbakia(0) = Nothing

        Dim zenb As Integer

        While seleccionado <> "x"
            seleccionado = menu()
            Console.ForegroundColor = ConsoleColor.Red
            Select Case seleccionado
                Case "a"
                    For i = 0 To zenbakia.Length - 1
                        zenb = rnd.Next(1, 101)
                        For j = 0 To zenbakia.Length - 1
                            If zenbakia(j) = zenb Then
                                zenb = rnd.Next(1, 101)
                                zenbakia(j) = zenb
                            End If

                        Next
                        zenbakia(i) = zenb
                    Next
                    Console.WriteLine("Zozketa ondo egin da")
                Case "b"

                    If File.Exists("..\..\..\FitxApustu.txt") Then
                        fs = New FileStream("..\..\..\FitxApustu.txt", FileMode.Open, FileAccess.Read)
                        sr = New StreamReader(fs)
                        linea = sr.ReadLine
                        While linea <> Nothing
                            ReDim Preserve jokalariak(cont1)
                            usuario = linea.Split(" ")
                            jokalariak(cont1) = usuario(0)
                            ReDim Preserve zenbakiak(5, cont1)
                            numeros = usuario(1).Split("*")
                            For i = 0 To numeros.Length - 1
                                zenbakiak(i, cont1) = numeros(i)
                            Next


                            cont1 = cont1 + 1
                            linea = sr.ReadLine
                        End While

                        Console.WriteLine("Fitxategia kargatuta dago")

                    Else
                        Console.WriteLine("Fitxategia ezin izan da kargatu")

                    End If



                Case "d"
                    'jokalariak()
                    'zenbakia()
                    'zenbakiak(5,)
                    Dim irabazleak(0) As String
                    irabazleak(0) = Nothing
                    Dim irabaz As Integer = 0
                    Dim tot As Integer = 0
                    '
                    '


                    If jokalariak(0) = Nothing Then
                        Console.WriteLine("Apostu fitxategia ez dago kargatuta")
                    ElseIf zenbakia(0) = Nothing Then
                        Console.WriteLine("Zenbakiak ez dira kargatu")
                    Else
                        For i = 0 To jokalariak.Length - 1
                            For j = 0 To 5 Step +1
                                If zenbakiak(j, i) = zenbakia(j) Then
                                    tot = tot + 1
                                End If
                                If tot = 6 Then
                                    ReDim Preserve irabazleak(irabaz)
                                    irabazleak(irabaz) = jokalariak(i)
                                    irabaz = irabaz + 1
                                    tot = 0
                                End If
                            Next
                        Next
                        Console.WriteLine("Zenbaki irabazleak hauek dira")
                        For k = 0 To zenbakia.Length - 1
                            Console.WriteLine(zenbakia(k))
                        Next
                        If irabazleak(0) <> Nothing Then
                            Console.WriteLine("Eta irabazleak hauek dira:")
                            For i = 0 To irabazleak.Length - 1
                                Console.WriteLine(irabazleak(i))
                            Next
                        End If
                    End If

                Case "x"
            End Select


        End While
        sr.Close()
        fs.Close()

    End Sub

    Function menu()
        Dim letra As String = "k"
        Console.ForegroundColor = ConsoleColor.White
        While letra <> "a" And letra <> "b" And letra <> "d" And letra <> "x"
            Console.WriteLine("ZOZKETA" & vbNewLine & vbNewLine &
                              "a. Zenbakiak kalkulatu" & vbNewLine &
                              "b. Apustu fitxategia kargatu " & vbNewLine &
                              "d. Irabazleak kalkulatu " & vbNewLine &
                              "x. Atera")
            Console.ForegroundColor = ConsoleColor.Cyan
            letra = Console.ReadLine
        End While
        Return letra
    End Function

End Module

