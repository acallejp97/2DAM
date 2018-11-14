
Module Module1

    Sub Main()
        Dim orden(9) As String
        Dim l As String
        For i As Integer = 0 To orden.Length - 1 Step +1
            l = letrak(i)
            orden(i) = l
        Next

        ordenatu(orden)
        Console.ReadLine()

    End Sub

    Function letrak(zenbat)
        Dim letra As String
        Console.WriteLine("Sartu letra (" & zenbat + 1 & ")")
        letra = Console.ReadLine()
        While letra.Length <> 1
            Console.WriteLine("Sartu bakarrik letra bat")
            letra = Console.ReadLine()
        End While
        Return letra
    End Function

    Function ordenatu(orden)
        Array.Sort(orden)
        Array.Reverse(orden)
        Console.WriteLine("")
        For i As Integer = 0 To orden.Length - 1 Step +1
            Console.WriteLine(orden(i) & "   " & Asc(orden(i)))
        Next
        Return ""
    End Function

End Module
