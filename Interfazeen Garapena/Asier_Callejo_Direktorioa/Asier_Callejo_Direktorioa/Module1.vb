Imports System.IO

Module Module1

    Sub Main()
        Dim direk As String = "C:\MyDir"
        Dim erantzuna As String
        If Directory.Exists(direk) Then
            Console.WriteLine("Direktorioa existitzen da")
        Else
            Console.WriteLine("Direktorioa ez da existitzen,oraindik...")
            My.Computer.FileSystem.CreateDirectory(direk)
        End If
        Console.ReadLine()
        Console.WriteLine("Direktorioa sortu zen " & Directory.GetCreationTime(direk))
        Console.WriteLine("Direktorioan" & Directory.GetLastWriteTime(direk))
        Console.WriteLine("Direktorioan" & Directory.GetLastAccessTime(direk))
        Console.WriteLine("Ezabatu nahi duzu? Bai/Ez")
        erantzuna = Console.ReadLine()
        While erantzuna.ToLower <> "bai" And erantzuna.ToLower <> "ez"
            Console.WriteLine("Sartu bakarrik bai edo ez")
            erantzuna = Console.ReadLine
        End While
        If erantzuna.ToLower = "bai" Then
            Console.WriteLine("Ezabatzen")
            Directory.Delete(direk)
        Else
            Console.WriteLine("Ez ezabatzen")
        End If
        Console.ReadLine()
    End Sub

End Module
