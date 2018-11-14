Module Module1

    Sub Main()
        Dim a, b, c As Integer
        Console.WriteLine("Sartu a aldagaia")
        a = Console.ReadLine()
        Console.WriteLine("Sartu b aldagaia")
        b = Console.ReadLine()
        c = a
        a = b
        b = c
        Console.WriteLine("a: " & a & " b: " & b)
        Console.ReadLine()
    End Sub

End Module
