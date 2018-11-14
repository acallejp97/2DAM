Module Module1

    Sub Main()
        Try
            Console.WriteLine("Vamos a dividir 10 entre 0 y ver lo que ocurre...")
            Console.WriteLine()
            Dim i As Integer = 10
            Dim j As Integer = "a"
            Dim k As Integer
            k = i / j

        Catch
            Console.WriteLine("Error")
        Finally
            Console.WriteLine("Este mensaje se escribe siempre")
            Console.ReadLine()
        End Try

    End Sub

End Module
