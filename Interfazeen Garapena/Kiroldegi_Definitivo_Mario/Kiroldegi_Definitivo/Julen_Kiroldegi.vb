Imports System.IO
Module Julen_Kiroldegi

    Sub Main()

        Dim opcion As Integer = 0
        Dim fitx As String = "..\..\..\FitxAbonuHileko.txt"
        Dim lista(), aux(), datuEgokiak() As String
        Dim linea As String = Nothing
        Dim kargatuta As Boolean = False 'variable con la que controlamos si esta cargado el fitxero
        Dim fs As FileStream = Nothing
        Dim sr As StreamReader = Nothing
        Dim sw As StreamWriter
        Dim cont As Integer

        Do While (opcion <> 4)
            Try

                Console.WriteLine("******ELORRIETAKO KIROLDEGIA******")
                Console.WriteLine("")
                Console.WriteLine("1. Abonu indibiduala kalkulatu")
                Console.WriteLine("2. Hileko fitxategia kargatu")
                Console.WriteLine("3. Hileko abonu zerrenda atera")
                Console.WriteLine("4. Atera")
                opcion = 0 'Bariableari 0 balioa ematen diogu,  bigarren bueltan errorerik ez gertatzeko.
                Console.ForegroundColor = ConsoleColor.Green
                opcion = Console.ReadLine()
                Console.ForegroundColor = ConsoleColor.Gray

            Catch e As Exception
                Console.ForegroundColor = ConsoleColor.Gray
                Console.WriteLine("Sartutako karaterea ez du balio, saiatu berriro.")

            End Try


            Select Case opcion

                Case 1
                    abonuIndibiduala()

                Case 2

                    If System.IO.File.Exists(fitx) Then
                        Dim errkoph = File.ReadAllLines("..\..\..\FitxAbonuHileko.txt").Length
                        ReDim lista(errkoph - 1)
                        ReDim aux(errkoph - 1)
                        cont = 0
                        kargatuta = True ' Hemen esaten dugu fitxeroa kargatu egin dela
                        Try
                            fs = New FileStream("..\..\..\FitxAbonuHileko.txt", FileMode.Open, FileAccess.Read)
                            sr = New StreamReader(fs)

                            linea = sr.ReadLine 'Irakurtzen ditugu fitxeroaren lerroak
                            While linea <> Nothing
                                lista(cont) = linea
                                cont += 1
                                linea = sr.ReadLine
                            End While

                            datuEgokiak = kargatu(lista, aux) 'baliozko datuak zein diren sailkatzeko metodoa.

                            Console.ForegroundColor = ConsoleColor.Red
                            Console.WriteLine("Kargatuta dago. Informazio gehiago lortzeko begiratu errore fitxategia.")
                            Console.ForegroundColor = ConsoleColor.Gray

                        Catch ex As Exception
                            Console.WriteLine("Errorea:" & ex.ToString)
                        Finally
                            If Not sr Is Nothing Then sr.Close()
                            If Not sr Is Nothing Then fs.Close()
                        End Try
                    Else
                        Console.ForegroundColor = ConsoleColor.Red
                        Console.WriteLine("Ez da aurkitu fitxategia.")
                        Console.ForegroundColor = ConsoleColor.Gray
                    End If


                Case 3
                    If kargatuta = True Then
                        erakutsi(datuEgokiak)
                    Else
                        Console.ForegroundColor = ConsoleColor.Red
                        Console.WriteLine("Fitxeroa ez da kargatu")
                        Console.ForegroundColor = ConsoleColor.Gray
                    End If

                Case 4
                    Console.WriteLine("Programa amaitzen.")

            End Select
        Loop 'Amaitzen dugu loop-a eta hortaz programa.



        Console.ReadLine()
    End Sub

    Sub abonuIndibiduala()
        Dim izena, abonua
        Dim gaur As Date = Today
        Dim hilabeteak() As String = {"Urtarrila", "Otsaila", "Martxoa", "Apirila", "Maiatza", "Ekaina", "Uztaila", "Abuztua", "Iraila", "Urria", "Azaroa", "Abendua"}
        Dim prezioa As Integer

        Do While izena = ""
            Console.WriteLine("Izena:")
            Console.ForegroundColor = ConsoleColor.Green
            izena = Console.ReadLine()
            Console.ForegroundColor = ConsoleColor.Gray
        Loop

        While abonua <> "P" And abonua <> "J" And abonua <> "FM" And abonua <> "E" And abonua <> "SN"
            Console.WriteLine("Abonua: P,J,FM,E,SN") '(P) Langabezian -> 75% (J) Erretiratuta -> 90% (FM) Famili anitza -> 50%    (E) Erroldatuta -> 20%    (SN) Normala -> 0%
            Console.ForegroundColor = ConsoleColor.Green
            abonua = Console.ReadLine().ToUpper
            Console.ForegroundColor = ConsoleColor.Gray
        End While

        prezioa = prezioaKalkulatu(abonua) 'Prezioa kalkulatzeko metodo honi dei egiten diogu, eta abonu mota pasatu.
        Console.ForegroundColor = ConsoleColor.Red
        If gaur.Month <> 12 Then 'Filtro txiki bat egiten dugu, datak ondo agertzeko
            Console.WriteLine("Abonu hilabetea, " & gaur.Year & "ko " & hilabeteak(gaur.Month) & "n hasten da.")
        Else
            Console.WriteLine("Abonu hilabetea, " & gaur.Year + 1 & "ko " & hilabeteak(0) & "n hasten da.")
        End If

        Console.WriteLine(izena & "<e>k " & prezioa & " euro ordaindu behar du")
        Console.ForegroundColor = ConsoleColor.Gray
    End Sub

    Function prezioaKalkulatu(a As String) 'prezioa kalkulatu eta bere balioa bueltatzen du.
        Dim total As Integer

        Select Case a

            Case "P"
                total = 350 * 0.75
                total = 350 - total
            Case "J"
                total = 350 * 0.9
                total = 350 - total
            Case "FM"
                total = 350 * 0.5
            Case "E"
                total = 350 * 0.2
                total = 350 - total
            Case "SN"
                total = 350
        End Select

        Return total
    End Function

    Function kargatu(ByVal lista(), ByVal aux()) 'Fitxeroa kargatzen du, baliozko datuak array batean sartzen ditu eta bueltatu, baita datu txarrak txt  batean sartzen ditu.
        Dim arraya(), datosError(1) As String
        Dim a As Integer
        Dim ErrorFitx As String = "..\..\..\KargaErrore.txt"
        Dim datuOndo() As String
        Dim fs As FileStream = Nothing
        Dim sw As StreamWriter = Nothing

        Try

            fs = New FileStream(ErrorFitx, FileMode.Create, FileAccess.Write)
            sw = New StreamWriter(fs)

            For i = 0 To lista.GetUpperBound(0)

                arraya = lista(i).Split(";")
                If arraya(0) = "" Then
                    datosError(0) = arraya(0) + ";" + arraya(1) + ";" + arraya(2)
                    sw.WriteLine(datosError(0))

                ElseIf arraya(2).ToUpper = "P" Or arraya(2).ToUpper = "J" Or arraya(2).ToUpper = "FM" Or arraya(2).ToUpper = "E" Or arraya(2).ToUpper = "SN" Or arraya(2).ToUpper = "" Then
                    If arraya(2) = "" Then
                        arraya(2) = "SN"
                    End If
                    aux(a) = arraya(0) + ";" + arraya(1) + ";" + arraya(2).ToUpper ' a bariablea sartzen diogu, datuak 1 posiziotik hazteko
                    ReDim Preserve datuOndo(a)
                    datuOndo(a) = aux(a)
                    a += 1
                Else
                    datosError(0) = arraya(0) + ";" + arraya(1) + ";" + arraya(2)
                    sw.WriteLine(datosError(0))

                End If

            Next
        Catch ex As IndexOutOfRangeException
            datosError(0) = arraya(0) + ";" + arraya(1)
            sw.WriteLine(datosError(0))
        Catch ex As Exception
            Console.WriteLine("Errorea:" & ex.Message)

        Finally
            If Not sw Is Nothing Then sw.Close()
            If Not sw Is Nothing Then fs.Close()
        End Try


        Return datuOndo
    End Function

    Sub erakutsi(ByVal datuak()) 'Datuak ikuskatzeko.
        Dim array(), datuformatu() As String
        ReDim datuformatu(datuak.GetUpperBound(0))
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("BAZKIDEA     NAN      ABONU MOTA     PREZIOA")

        For x = 0 To datuak.GetUpperBound(0)
            array = datuak(x).Split(";")
            Console.WriteLine(array(0) & vbTab & "   " & array(1) & "   " & vbTab & array(2) & vbTab & "     " & Str(prezioaKalkulatu(array(2).ToUpper)))
            'datuformatu(x) = array(0) + "     " + array(1) + "        " + array(2) + "            " + Str(prezioaKalkulatu(array(2)))
            'Console.WriteLine(datuformatu(x))
        Next

        Console.ForegroundColor = ConsoleColor.Gray

    End Sub
End Module