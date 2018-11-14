Module Module1

    Sub Main()
        Dim t As Integer = 78125
        Dim hor, min, seg As Integer
        hor = (t / 3600)
        min = ((t - hor * 3600) / 60)
        seg = t - (hor * 3600 + min * 60)
        Console.WriteLine(hor & " h " & -min & " min " & seg & " seg")
        Console.ReadLine()
    End Sub

End Module
