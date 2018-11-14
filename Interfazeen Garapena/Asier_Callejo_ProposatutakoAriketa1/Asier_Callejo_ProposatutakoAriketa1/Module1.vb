Module Module1

    Sub Main()

        Dim a1, a2, a3, a4, e As Double
        System.Console.WriteLine("Ariketa 1")
        Console.WriteLine("Sartu lehenengo datua")
        a1 = Console.ReadLine()

        Console.WriteLine("Sartu bigarren datua")
        a2 = Console.ReadLine()

        Console.WriteLine("Sartu hirugarren datua")
        a3 = Console.ReadLine()

        Console.WriteLine("Sartu laugarren datua")
        a4 = Console.ReadLine()

        e = a1 + a2
        Console.WriteLine(a1 & " + " & a2 & " = " & e)

        e = a3 * a4
        Console.WriteLine(a3 & " * " & a4 & " = " & e)

        Console.WriteLine("Sakatu Enter hurrengo ariketara pasatzeko")
        Console.ReadLine()
        Ariketa2()
        Ariketa3()

    End Sub

    Sub Ariketa2()
        Dim a1, a2, a3, a4, e As Double
        System.Console.WriteLine("Ariketa 2")
        Console.WriteLine("Sartu lehenengo datua")
        a1 = Console.ReadLine()

        Console.WriteLine("Sartu bigarren datua")
        a2 = Console.ReadLine()

        Console.WriteLine("Sartu hirugarren datua")
        a3 = Console.ReadLine()

        Console.WriteLine("Sartu laugarren datua")
        a4 = Console.ReadLine()

        e = (a1 + a2 + a3 + a4) / 4
        Console.WriteLine("( " & a1 & " + " & a2 & " + " & a3 & " + " & a4 & " )/4 = " & e)
        Console.WriteLine("Sakatu Enter hurrengo ariketara pasatzeko")
        Console.ReadLine()

    End Sub

    Sub Ariketa3()
        Dim p, k, e As Double
        System.Console.WriteLine("Ariketa 3")
        Console.WriteLine("Sartu prezioa")
        p = Console.ReadLine()

        Console.WriteLine("Sartu zenbat erosiko dituzun")
        k = Console.ReadLine()

        e = p * k
        Console.WriteLine(p & " * " & k & " = " & e & "E")
        Console.WriteLine("Sakatu Enter amaitzeko")
        Console.ReadLine()
    End Sub
End Module
