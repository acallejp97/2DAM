Module Module1


    Sub Main()


        Dim n As Integer
        Dim i As Integer


        Console.Write("Sartu zenbakia: ")
        n = Console.ReadLine
        Console.Write("Noren multiploa izan behar da: ")
        i = Console.ReadLine
        If balidatu(i, n) = True Then
            Console.WriteLine("Bai, multiploak dira")
        Else
            Console.WriteLine("Ez, ez dira multiploak")
        End If
        Console.ReadLine()
    End Sub

    Function balidatu(i, n)
        Return (n Mod i = 0)
    End Function

End Module
