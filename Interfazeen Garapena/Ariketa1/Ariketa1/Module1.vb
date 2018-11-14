Module Module1
    Sub Main()
        Dim d1, d2, e As Double
        Console.WriteLine("Lehenengo datua")
        d1 = Console.ReadLine()
        Console.WriteLine("Bigarren datua")
        d2 = Console.ReadLine()
        'Gehiketa
        e = d1 + d2
        Console.WriteLine(d1 & " + " & d2 & " = " & e)
        'Kenketa
        e = d1 - d2
        Console.WriteLine(d1 & " - " & d2 & " = " & e)
        'Biderketa
        e = d1 * d2
        Console.WriteLine(d1 & " * " & d2 & "= " & e)
        'Zatiketa
        e = d1 / d2
        Console.WriteLine(d1 & " / " & d2 & "= " & e)

        Console.ReadLine()

    End Sub
End Module