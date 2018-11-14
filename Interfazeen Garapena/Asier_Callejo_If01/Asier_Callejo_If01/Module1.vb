Module Module1

    Sub Main()
        Dim Adina As Integer
        Dim Mezua As String = ""
        Console.WriteLine("Idatzi pertsonaren adina")
        Adina = Console.ReadLine()
        While Adina < 0 Or Adina > 150
            Console.WriteLine("Sartu adin zuzen bat")
            Adina = Console.ReadLine()
        End While
        If Adina >= 0 And Adina <= 5 Then
            Mezua = "Umea"
        ElseIf Adina > 5 And 18 >= Adina Then
            Mezua = "Gaztea"
        ElseIf Adina > 18 And 66 >= Adina Then
            Mezua = "Heldua"
        ElseIf 66 < Adina Then
            Mezua = "Zaharra"
        End If
            Console.WriteLine("Pertsonaren adina: " & Adina & " Pertsonaren kategoria:" & Mezua)
            Console.ReadLine()
    End Sub

End Module
