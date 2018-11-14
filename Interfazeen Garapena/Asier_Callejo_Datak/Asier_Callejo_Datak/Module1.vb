Module Module1

    Sub Main()
        Dim data As Date = "11/09/2014" 'Data eta ordua, zeroekin.

        Console.WriteLine("DATA..: " & data) 'Zerorik ez
        Console.WriteLine(data)       'zeroekin
        Console.WriteLine(data.Date)  'zeroekin
        Console.WriteLine(data.ToString & vbNewLine) '  zeroekin
        Console.WriteLine()



        Console.WriteLine("DATA ETA ORDUA " & Now)
        Console.WriteLine()

        '===============prozedurak erabiliz===============================
        Console.WriteLine("Data luzea " & data.ToLongDateString)
        Console.WriteLine("Data laburra " & data.ToShortDateString) 'zero barik
        Console.WriteLine()

        '================propietateak erabiliz==================================
        Console.WriteLine("Date osagaia : " & data.Date)
        Console.WriteLine("Day osagaia : " & data.Day)
        Console.WriteLine("DateOfWeek osagaia : " & data.DayOfWeek)
        Console.WriteLine("Hour osagaia : " & data.Hour)
        Console.WriteLine("Month osagaia : " & data.Month)


        Console.ReadLine()

    End Sub

End Module