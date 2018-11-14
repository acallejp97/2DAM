Module Module1

    Sub Main()
        Dim data As Date = "2/1/1"
        Dim egu, hil, urt, tot, zen As Integer
        While data <> "1/1/1"
            zen = 0
            tot = 0
            Console.WriteLine("Sartu data bat (itxi egiteko 1/1/1)")
            data = Console.ReadLine()
            egu = data.Day
            hil = data.Month
            urt = data.Year
            tot = egu + urt + hil
            Console.WriteLine(egu & " + " & hil & " + " & urt & " = " & tot)
            If tot >= 0 Then
                Do
                    zen = zen + (tot Mod 10)
                    tot = tot \ 10
                    Console.WriteLine(" zen: " & zen & " tot: " & tot)
                Loop While tot > 0
            End If
            Console.WriteLine("Zure tarot zenbakia " & (zen Mod 10) + (zen \ 10) & " da")
        End While
    End Sub

End Module
