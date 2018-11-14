Module Module1

    Sub Main()
        Dim katea As String
        katea = "ZYXWVTSRQPONMLKJIHGFEDCBA"
        For i = 0 To katea.Length
            Console.WriteLine(katea.Substring(i, katea.Length - i))
        Next
        Console.ReadLine()
    End Sub

End Module
