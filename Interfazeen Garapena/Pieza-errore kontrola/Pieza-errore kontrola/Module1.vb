Module Module1

    Sub Main()

        Dim Altuera = 0, Zabalera As Double = 0
        Dim Kodea As String = 0

        Console.WriteLine("Piezaren altuera:  (7/9)")
        Altuera = Console.ReadLine()
        While Altuera < 7 Or Altuera > 9
            Console.WriteLine("PIEZA ONARGAITZA")
            Console.ReadLine()
        End While

        Console.WriteLine("Piezaren zabalera: (2.5-8.5)(EZ 3-3.5)")
        Zabalera = Console.ReadLine()
        While Zabalera < 2.5 Or Zabalera > 8.5 Or Zabalera = 3 Or Zabalera = 3.5
            Console.WriteLine("PIEZA ONARGAITZA")
            Zabalera = Console.ReadLine()

        End While

        Console.WriteLine("Sartu kodea: A, B, C, D")
        Kodea = Console.ReadLine()
        Kodea = UCase(Kodea)
        While Kodea <> "A" And Kodea <> "B" And Kodea <> "C" And Kodea <> "D"
            Console.WriteLine("PIEZA ONARGAITZA")
            Kodea = Console.ReadLine()
            Kodea = UCase(Kodea)
        End While

        Console.WriteLine("PIEZA ONARGARRIA")
        Console.WriteLine("Zabalera: " & Zabalera)
        Console.WriteLine("Altuera: " & Altuera)
        Console.WriteLine("Kodea: " & Kodea)
        Console.ReadLine()
    End Sub

End Module
