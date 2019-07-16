Imports System.IO

Module Module1

    Sub Main()
        Dim aukera As String = Nothing
        Dim prezio As Integer = 350
        Dim ondo() As String

        While aukera <> 4
            Console.ForegroundColor = ConsoleColor.Gray
            Console.WriteLine("ELORRIETAKO POLIKIROLDEGIA" & vbNewLine)
            Console.WriteLine("1. Abonu indibiduala kalkulatu" & vbNewLine &
                              "2. Hileko fitxategia kargatu" & vbNewLine &
                              "3. Hileko abonu zerrenda atera" & vbNewLine &
                              "4. Atera")
            Console.ForegroundColor = ConsoleColor.Green
            aukera = Console.ReadLine()
            Console.WriteLine()
            Console.ForegroundColor = ConsoleColor.White
            Select Case aukera
                Case 1
                    indibidual(prezio)
                Case 2

                    ondo = fitxeroaKargatu()

                Case 3
                    kargatu(ondo, prezio)
            End Select


        End While
    End Sub

    Sub indibidual(ByVal prezioa)
        Dim izena As String = Nothing
        Dim abono As String = Nothing
        Dim hila As String = Nothing
        Dim totala As Double = 0.0
        Dim urte, hil As Integer
        Dim hilabeteak() As String = {"Urtarrila", "Otsaila", "Martxoa", "Apirila", "Maiatza", "Ekaina", "Uztaila", "Abuztua", "Iraila", "Urria", "Azaroa", "Abendua"}
        Dim motak() As String = {"P", "J", "FM", "E", "SN"}

        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("Izena:")
        Console.ForegroundColor = ConsoleColor.Green
        izena = Console.ReadLine
        While validateLetra(abono, motak) = False
            Console.ForegroundColor = ConsoleColor.White
            Console.WriteLine("Tipo abono:")
            Console.ForegroundColor = ConsoleColor.Green
            abono = Console.ReadLine().ToUpper
        End While
        Select Case abono
            Case "P"
                totala = prezioa * (25 / 100)
            Case "J"
                totala = prezioa * (10 / 100)
            Case "FM"
                totala = prezioa * (50 / 100)
            Case "E"
                totala = prezioa * (80 / 100)
            Case "SN"
                totala = prezioa
        End Select
        urte = Today.Year
        hil = Today.Month - 1
        If hil = 12 Then
            hil = 1
            urte = urte + 1
        End If

        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine(vbNewLine & "Abonu hilabetea " & urte & "ko " & hilabeteak(hil + 1) & "n hasten da" & vbNewLine &
                          izena & "<e>k " & totala & " euro ordaindu behar du" & vbNewLine)
    End Sub

    Function fitxeroaKargatu()
        Dim motak() As String = {"P", "J", "FM", "E", "SN"}
        Dim fs As FileStream = Nothing
        Dim fs2 As FileStream = Nothing
        Dim sr As StreamReader = Nothing
        Dim sw As StreamWriter = Nothing
        Dim izena As String = Nothing
        Dim dni As String = Nothing
        Dim mota As String = Nothing
        Dim ondo() As String
        Dim txarto As String
        Dim direk As String = "..\..\..\FitxAbonuHileko.txt"
        Dim usuario(2) As String
        Dim linea As String = Nothing
        Dim cont As Integer = 0
        Dim cont1 As Integer = 0


        If File.Exists("..\..\..\Erroreak.txt") = False Then
            Dim crear As FileStream = File.Create("..\..\..\Erroreak.txt")
            crear.Close()
        End If
        fs2 = New FileStream("..\..\..\Erroreak.txt", FileMode.Open, FileAccess.Write)
        sw = New StreamWriter(fs2)
        fs = New FileStream(direk, FileMode.Open, FileAccess.Read)
        sr = New StreamReader(fs)
        linea = sr.ReadLine
        While linea <> Nothing

            ReDim Preserve ondo(cont1)
            usuario = linea.Split(";")
            If usuario(1).Length = 9 Then
                izena = usuario(0)
                dni = usuario(1)
                mota = usuario(2).ToUpper
                If mota = "" Then
                    mota = "SN"
                End If
            End If
            If izena = "" Or validateLetra(mota, motak) = False Then
                txarto = izena & ";" & dni & ";" & mota
                sw.WriteLine(txarto)
            Else
                ondo(cont1) = izena & ";" & dni & ";" & mota
                cont1 = cont1 + 1
            End If
            linea = sr.ReadLine
            cont = cont + 1
        End While
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("Kargatuta dago.Informazio gehiago lortzeko irakurri errore fitxategia")
        Console.WriteLine()
        sr.Close()
        fs.Close()
        sw.Close()
        fs2.Close()


        Return ondo
    End Function

    Sub kargatu(ByVal ondo, ByVal prezioa)

        Dim izena() As String
        Dim dni() As String
        Dim mota() As String
        Dim linea As String
        Dim usuario(2) As String
        Dim totala As Integer = 0

        If ondo Is Nothing Then
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("Fitxategia ez dago kargatuta")
        Else
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("Bazkidea" & vbTab & "NAN" & vbTab & vbTab & "Abonu mota" & vbTab & "Prezioa")

            For i = 0 To ondo.Length - 2 Step +1
                ReDim Preserve izena(i + 1)
                ReDim Preserve dni(i + 1)
                ReDim Preserve mota(i + 1)

                linea = ondo(i)
                usuario = linea.Split(";")
                izena(i) = usuario(0)
                dni(i) = usuario(1)
                mota(i) = usuario(2)
                Select Case mota(i).ToUpper
                    Case "P"
                        totala = prezioa * (25 / 100)
                    Case "J"
                        totala = prezioa * (10 / 100)
                    Case "FM"
                        totala = prezioa * (50 / 100)
                    Case "E"
                        totala = prezioa * (80 / 100)
                    Case "SN"
                        totala = prezioa
                End Select

                Console.WriteLine(izena(i) & vbTab & vbTab & dni(i) & vbTab & mota(i) & vbTab & vbTab & totala)
            Next

        End If
        Console.WriteLine()


    End Sub

    Function validateLetra(ByVal comparar, ByVal Array())
        Dim a As Boolean = False
        Dim n As Integer = 0

        For i = 0 To Array.Length - 1 Step +1
            If Array(i).Equals(comparar) Then
                n = 1
            End If
        Next
        If n = 1 Then
            a = True
        End If
        Return a
    End Function


End Module
