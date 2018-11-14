Module Module1

    Sub Main()
        Console.WriteLine("Sartu zenbat zenbaki sartuko dituzun")
        Dim zenbat As Integer = Console.ReadLine()
        Dim nummax, nummin, num As Integer
        nummax = -99999
        nummin = 99999
        For i = zenbat To 1 Step -1
            Console.WriteLine("Sartu zenbakia")
            num = Console.ReadLine()
            nummax = handiena(num, nummax)
            nummin = txikiena(num, nummin)
            handi(num, nummax)
            txiki(num, nummin)
        Next
        Console.ReadLine()
    End Sub

    Function handiena(num As Integer, hand As Integer)
        If num > hand Then
            hand = num
        End If
        Console.WriteLine("Handiena " & hand)
        Return hand
    End Function

    Function txikiena(num As Integer, txik As Integer)
        If num < txik Then
            txik = num
        End If
        Console.WriteLine("Txikiena " & txik)
        Return txik
    End Function

    Sub handi(ByRef num As Integer, ByRef hand As Integer)
        If num > hand Then
            hand = num
        End If
        Console.WriteLine("Oraingoz zenbakirik handiena " & hand & " da")
    End Sub
    Sub txiki(ByRef num As Integer, ByRef txik As Integer)
        If num < txik Then
            txik = num
        End If
        Console.WriteLine("Oraingoz zenbakirik txikiena " & txik & " da")
    End Sub
End Module
