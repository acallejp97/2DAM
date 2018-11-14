Imports System.IO

Module Module1

    Sub Main()
        Dim BilatzekoHitzak() As String = Nothing
        Dim fs As FileStream = Nothing
        Dim sr As StreamReader = Nothing
        Dim linea As String = Nothing
        Dim cont As Integer = 0

        Try



            fs = New FileStream("..\..\..\Hitzak.txt", FileMode.Open, FileAccess.Read)
            sr = New StreamReader(fs)

            linea = sr.ReadLine
            While linea <> Nothing
                ReDim Preserve BilatzekoHitzak(cont)
                BilatzekoHitzak(cont) = linea
                cont = cont + 1
                linea = sr.ReadLine
            End While

            fs = Nothing
            sr = Nothing
            linea = Nothing

            fs = New FileStream("..\..\..\Salda.txt", FileMode.Open, FileAccess.Read)
            sr = New StreamReader(fs)
            linea = sr.ReadLine
            cont = 0
            Dim lineCount = File.ReadAllLines("..\..\..\Salda.txt").Length
            Dim salda(lineCount, Len(linea)) As String
            While linea <> Nothing
                For i = 1 To Len(linea)
                    salda(cont, i - 1) = Mid(linea, i, 1)
                Next i
                cont = cont + 1
                linea = sr.ReadLine
            End While
            Dim Norabideak = {"Iparralde", "ipar-ekialde", "ipar-mendebalde", "hegoalde", "hego-ekialde", "hego-mendebalde",
                         "ekialde", "mendebalde"}
            Dim LerroZk As Integer = UBound(salda, 1)
            Dim ZutabeZk As Integer = UBound(salda, 2) - 1

            SaldaInprimatu(salda, LerroZk, ZutabeZk + 1)

            For i = 0 To LerroZk
                For j = 0 To ZutabeZk + 1
                    For k = 0 To BilatzekoHitzak.Length - 1
                        Dim luzera = BilatzekoHitzak(k).Length - 1
                        For Each norantz In Norabideak
                            If Bilatu(salda, BilatzekoHitzak(k), i, j, norantz, luzera, LerroZk, ZutabeZk) Then
                                aldatu(salda, BilatzekoHitzak(k), i, j, norantz, luzera)
                            End If
                        Next
                    Next
                Next
            Next

            SaldaInprimatu(salda, LerroZk + 1, ZutabeZk + 1)
            Console.ReadLine()
        Catch ex As Exception
            Console.WriteLine("Errorea: " & ex.ToString)
        Finally
            If Not sr Is Nothing Then sr.Close()
            If Not sr Is Nothing Then fs.Close()
        End Try
    End Sub

    Sub aldatu(ByRef salda, ByVal BilatzekoHitza, ByVal Lerroa, ByVal Zutabea, ByVal norantz, ByVal luzera)
        For i = 0 To luzera
            salda(Lerroa, Zutabea) = salda(Lerroa, Zutabea).ToLower
            Select Case norantz
                Case "Iparralde", "ipar-ekialde", "ipar-mendebalde"
                    Lerroa = Lerroa - 1
                Case "hegoalde", "hego-ekialde", "hego-mendebalde"
                    Lerroa = Lerroa + 1
            End Select
            Select Case norantz
                Case "ekialde", "ipar-ekialde", "hego-ekialde"
                    Zutabea = Zutabea - 1
                Case "ipar-mendebalde", "hego-mendebalde", "mendebalde"
                    Zutabea = Zutabea + 1
            End Select
        Next
    End Sub

    Function Bilatu(ByRef Salda, ByVal BilatzekoHitza, ByVal Lerroa, ByVal Zutabea, ByVal norantz, ByVal luzera, ByVal LerroZk, ByVal ZutabeZk)

        Dim jarraitu = False
        For i = 0 To luzera
            If UCase(Salda(Lerroa, Zutabea)) = UCase(BilatzekoHitza.Substring(i, 1)) Then
                jarraitu = True
                Select Case norantz
                    Case "Iparralde", "ipar-ekialde", "ipar-mendebalde"
                        Lerroa = Lerroa - 1
                    Case "hegoalde", "hego-ekialde", "hego-mendebalde"
                        Lerroa = Lerroa + 1
                End Select
                Select Case norantz
                    Case "ekialde", "ipar-ekialde", "hego-ekialde"
                        Zutabea = Zutabea - 1
                    Case "ipar-mendebalde", "hego-mendebalde", "mendebalde"
                        Zutabea = Zutabea + 1
                End Select
                If (Lerroa < 0 Or Zutabea < 0 Or Lerroa > LerroZk Or Zutabea > ZutabeZk + 1) And luzera <> i Then
                    jarraitu = False
                    Exit For
                End If
            Else
                jarraitu = False
                Exit For
            End If
        Next

        Return jarraitu

    End Function

    Sub SaldaInprimatu(ByVal salda, ByVal LerroZk, ByVal ZutabeZk)

        For i = 0 To LerroZk - 1
            For j = 0 To ZutabeZk
                If Asc(salda(i, j)) > 90 And salda(i, j) <> "Ñ" Then
                    Console.ForegroundColor = ConsoleColor.Red
                Else
                    Console.ForegroundColor = ConsoleColor.White
                End If
                Console.Write(UCase(salda(i, j)) & " ")
            Next
            Console.WriteLine()
        Next
        Console.WriteLine()

    End Sub

End Module


