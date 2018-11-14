Module Module1

    Sub Main()
        Dim i, j, x, n As Integer
        Console.WriteLine("Sartu lerroak")
        n=CInt(Console.ReadLine)
        For i = 1 To n
            For x = n - i To 1 Step -1
                Console.Write(" ")
            Next
            For j = 1 To i Step +1                
                    Console.Write(j)
            Next
            For j = i - 1 To 1 Step -1
                Console.Write(j)
            Next
            Console.WriteLine()
        Next
        Console.ReadLine()
    End Sub

End Module
