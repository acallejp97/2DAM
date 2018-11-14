Module Module1

    Sub Main()
        Dim zenbakiak() As Integer = {21, 5, 3, 12, 65, 9, 36, 7, 2}
        Dim kopia() As Integer
        inprimatu(zenbakiak)
        tamaina(zenbakiak)
        bilatu(zenbakiak)
        ordenatu(zenbakiak)
        kopia = zenbakiak
        Array.Sort(kopia)
        Array.Reverse(kopia)
        Array.Resize(kopia, kopia.Length + 1)
        kopia(kopia.Length - 1) = 8
        Array.Sort(kopia)
        For o As Integer = 0 To kopia.Length - 1 Step +1
            Console.Write(kopia(o) & " ")
        Next

        Console.ReadLine()
    End Sub

    Sub inprimatu(zenbakiak)
        For o As Integer = 0 To zenbakiak.Length - 1 Step +1
            Console.Write(zenbakiak(o) & " ")
        Next
        Console.WriteLine()
    End Sub

    Sub tamaina(zenbakiak)
        Dim max As Integer = -99999
        Dim min As Integer = 9999
        For o As Integer = 0 To zenbakiak.Length - 1 Step +1
            If max < zenbakiak(o) Then
                max = zenbakiak(o)
            End If
        Next
        For o As Integer = 0 To zenbakiak.Length - 1 Step +1
            If min > zenbakiak(o) Then
                min = zenbakiak(o)
            End If
        Next

        Console.WriteLine("Max: " & max)
        Console.WriteLine("Min: " & min)
    End Sub

    Sub bilatu(zenbakiak)
        Dim i, e As Integer
        Dim a As Boolean = False
        Console.Write("Sartu zenbaki bat: ")
        i = Console.ReadLine()
        For o As Integer = 0 To zenbakiak.Length - 1 Step +1
            If i = zenbakiak(o) Then
                a = True
                e = o
            End If
        Next
        If a = True Then
            Console.WriteLine(i & " zenbakia array-aren barruan dago " & e + 1 & " posizioan")
        Else
            Console.WriteLine(i & " zenbakia ez dago array-aren barruan")
        End If
    End Sub

    Sub ordenatu(zenbakiak)
        Array.Sort(zenbakiak)
        For o As Integer = 0 To zenbakiak.Length - 1 Step +1
            Console.Write(zenbakiak(o) & " ")
        Next
        Console.WriteLine()
    End Sub
End Module
