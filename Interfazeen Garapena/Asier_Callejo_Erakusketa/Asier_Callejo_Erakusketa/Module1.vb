Module Module1

    Sub Main()
        Dim b As Integer = 9
        ab("Elorrieta", b)
        ab("Errekamari", 8, "13/10/2017")
        ab("Bilbo", 35, "10/11/2014")

        bc("Elorrieta", b, "11/09/2013")
        bc("Errekamari", 8, "13/10/2017")
        bc("Bilbo", 35, "10/11/2014")
        Console.ReadLine()
    End Sub
    Sub ab(izena As String, ByRef b As Integer, Optional Dat As Date = #10/5/1956#)
        Console.WriteLine(izena)
        b = b + 1
        Console.WriteLine(b)
        Console.WriteLine(Dat)
        Console.WriteLine()
    End Sub
    Function bc(izena As String, ByRef b As Integer, Dat As Date)
        Console.WriteLine(izena & vbLf & b & vbLf & Dat & vbLf)
        Return 0
    End Function
End Module
