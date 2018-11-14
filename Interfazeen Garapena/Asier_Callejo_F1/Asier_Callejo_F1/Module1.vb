Module Module1

    Sub Main()
        Dim pilotoak(), zirkuituak() As String
        Dim sailkapena(6, 7) As Double
        pilotoak = {"Vettel", "Alonso", "Raikkonen", "Hamilton", "Button", "Webber", "Massa"}
        zirkuituak = {"Austria", "Malasia", "China", "Bahrein", "Montmeló", "Mónaco", "Canada", "Silverstone"}
        
        Dim aukera As Integer = 0
        While aukera <> 4
            Console.WriteLine("Aukeratu bat")
            Console.WriteLine("1.- Sailkapena sartu")
            Console.WriteLine("2.- Informazioa erakutsi")
            Console.WriteLine("3.- Sailkapena erakutsi")
            Console.WriteLine("4.- Irten")
            aukera = Console.ReadLine
            Select Case aukera
                Case 1
                    sailkapena = sartu(zirkuituak, pilotoak, sailkapena)
                Case 2
                    informazioa(zirkuituak, pilotoak, sailkapena)
                Case 3
                    podium(zirkuituak, pilotoak, sailkapena)
            End Select
        End While
        Console.WriteLine("Irtetzen")
        Console.ReadLine()
    End Sub

    Function sartu(zirkuituak, pilotoak, sailkapena)
        Dim aukera As String
        For i = 0 To zirkuituak.length - 1 Step +1
            Console.WriteLine(zirkuituak(i))
            For j = 0 To pilotoak.length - 1 Step +1
                Console.WriteLine(pilotoak(j))
                sailkapena(i, j) = Console.ReadLine()
                While sailkapena(i, j) < 0 Or sailkapena(i, j) > 7
                    Console.WriteLine("Sartu bakarrik 0 eta 7 bitarteko zenbakiak")
                    sailkapena(i, j) = Console.ReadLine()
                End While
                
            Next
            Console.WriteLine("Jarraitu? B/E")
            aukera = Console.ReadLine().ToUpper
            While aukera <> "B" And aukera <> "E"
                Console.WriteLine("Sartu bakarrik B/E")
                aukera = Console.ReadLine().ToUpper
            End While
            If aukera = "E" Then
                i = zirkuituak.length - 1
            End If
        Next
        Console.ReadLine()
        Return sailkapena
    End Function

    Sub informazioa(zirkuituak, pilotoak, sailkapena)
        Console.WriteLine("Sailkapena ateratzen")
        Console.WriteLine()
        For i = 0 To zirkuituak.length - 1 Step +1
            Console.Write(vbTab & zirkuituak(i).subString(0, 2).toUpper)
        Next
        Console.WriteLine()
        For i = 0 To pilotoak.length - 1 Step +1
            Console.Write(pilotoak(i) & vbTab)
            For j = 0 To zirkuituak.length - 1 Step +1
                Console.Write(sailkapena(i, j) & vbTab)
            Next
            Console.WriteLine()
        Next
    End Sub

    Sub podium(zirkuituak, pilotoak, sailkapena)
        Dim puntuak(6) As Integer
        Dim gehiketa As Integer
        For i = 0 To pilotoak.Length - 1
            For j = 0 To sailkapena.GetUpperBound(1) - 1
                gehiketa = puntuak(i)
                If sailkapena(j, i) = 1 Then
                    gehiketa = gehiketa + 12
                ElseIf sailkapena(j, i) = 2 Then
                    gehiketa = gehiketa + 8
                ElseIf sailkapena(j, i) = 3 Then
                    gehiketa = gehiketa + 6
                ElseIf sailkapena(j, i) = 4 Then
                    gehiketa = gehiketa + 4
                ElseIf sailkapena(j, i) = 5 Then
                    gehiketa = gehiketa + 3
                ElseIf sailkapena(j, i) = 6 Then
                    gehiketa = gehiketa + 2
                ElseIf sailkapena(j, i) = 7 Then
                    gehiketa = gehiketa + 1
                ElseIf sailkapena(j, i) = 0 Then
                End If
                puntuak(i) = gehiketa
            Next
        Next
        Dim num, oNum As Integer
        Dim letrak, oLetrak As String
        For i = 0 To puntuak.Length - 1
            For j = 1 To puntuak.Length - 1
                num = puntuak(j - 1)
                letrak = pilotoak(j - 1)
                If num < puntuak(j) Then
                    oNum = num
                    num = puntuak(j)
                    puntuak(j) = oNum
                    puntuak(j - 1) = num

                    oLetrak = pilotoak(j - 1)
                    letrak = pilotoak(j)
                    pilotoak(j) = oLetrak
                    pilotoak(j - 1) = letrak
                End If

            Next
        Next
        For i = 0 To puntuak.Length - 1
            Console.Write(pilotoak(i))
            Console.WriteLine(vbTab & puntuak(i))
        Next
        Console.WriteLine()
    End Sub
End Module