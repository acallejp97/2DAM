Module Module1
    Sub main()
        Dim salda(19, 19) As String
        salda = {{"S", "D", "A", "R", "T", "Q", "P", "R", "O", "T", "O", "T", "I", "P", "O", "R", "S", "R", "H", "K"},
{"F", "I", "C", "H", "E", "R", "O", "Q", "U", "D", "F", "B", "S", "D", "E", "T", "R", "R", "O", "H"},
{"T", "U", "V", "L", "Q", "E", "F", "G", "J", "A", "S", "D", "A", "P", "U", "N", "T", "E", "R", "O"},
{"B", "H", "N", "J", "T", "F", "D", "S", "C", "C", "G", "Y", "U", "I", "K", "N", "Q", "C", "R", "G"},
{"O", "V", "B", "C", "T", "F", "X", "E", "S", "T", "A", "T", "I", "C", "A", "M", "A", "U", "D", "J"},
{"I", "X", "N", "C", "I", "S", "T", "A", "S", "D", "R", "T", "L", "K", "A", "J", "S", "R", "S", "B"},
{"P", "N", "A", "G", "L", "O", "B", "A", "L", "G", "F", "P", "W", "I", "H", "Y", "D", "S", "E", "Q"},
{"Q", "J", "C", "O", "I", "F", "N", "U", "E", "H", "A", "S", "R", "H", "K", "R", "C", "I", "G", "S"},
{"E", "D", "S", "L", "P", "L", "Ñ", "O", "W", "O", "J", "O", "G", "I", "L", "E", "V", "V", "Y", "D"},
{"W", "S", "B", "A", "U", "S", "I", "Q", "W", "E", "M", "R", "T", "Y", "N", "Y", "I", "I", "E", "F"},
{"U", "I", "S", "D", "F", "D", "O", "Q", "R", "E", "T", "U", "R", "N", "G", "T", "Y", "D", "Q", "G"},
{"B", "A", "S", "D", "T", "H", "E", "T", "M", "Z", "X", "C", "V", "B", "N", "M", "F", "A", "U", "N"},
{"D", "W", "H", "S", "H", "J", "F", "G", "D", "S", "A", "V", "T", "R", "E", "W", "Q", "D", "I", "K"},
{"A", "D", "F", "P", "A", "R", "A", "M", "E", "T", "R", "O", "A", "Y", "U", "I", "O", "P", "Y", "U"},
{"Ñ", "A", "S", "D", "F", "G", "D", "S", "A", "Q", "W", "I", "R", "R", "U", "I", "P", "F", "R", "W"},
{"E", "O", "K", "J", "A", "W", "E", "R", "T", "Y", "Q", "D", "T", "Y", "I", "D", "N", "S", "E", "R"},
{"A", "R", "G", "U", "M", "E", "N", "T", "O", "S", "F", "A", "L", "O", "C", "A", "L", "E", "S", "G"},
{"E", "E", "R", "Y", "A", "O", "H", "T", "R", "F", "V", "S", "D", "S", "C", "Q", "B", "D", "W", "H"},
{"T", "E", "N", "C", "A", "B", "E", "Z", "A", "D", "O", "W", "R", "S", "O", "T", "I", "L", "A", "S"},
{"S", "J", "L", "U", "R", "E", "B", "D", "T", "U", "W", "U", "R", "Y", "O", "P", "B", "V", "E", "X"}}
        Dim lista() As String = {"Variable", "encabezado", "scanf", "recursividad", "parametro", "puntero", "funcion", "include", "memoria", "printf", "global", "fichero", "return", "prototipo", "biblioteca", "argumento", "studio", "locales", "estatica", "void"}


        For zutabe = 0 To 19
            For lerro = 0 To 19
                Console.Write(salda(zutabe, lerro) & " ")
            Next
            Console.WriteLine()
        Next
        Console.ReadLine()
        bilaketahorizontal(lista, salda)
        bilaketabertikal(lista, salda)
    End Sub

    Sub bilaketahorizontal(lista, salda)
        For letra = 0 To lista.Length - 1
            For zutabea = 0 To 19
                For lerroa = 0 To 19
                    If salda(zutabea, lerroa) = lista(letra).ToUpper.Substring(0, 1) And lerroa + lista(letra).Length - 1 < 20 Then
                        Dim aurkitua As Boolean = True
                        For d = 0 To lista(letra).Length - 1
                            If salda(zutabea, lerroa + d) <> lista(letra).ToUpper.Substring(d, 1) Then
                                aurkitua = False
                            End If
                        Next
                        If aurkitua Then
                            For d = 0 To lista(letra).Length - 1
                                salda(zutabea, lerroa + d) = salda(zutabea, lerroa + d).ToLower
                            Next
                        End If
                    End If
                Next
            Next
        Next
        Console.WriteLine()
        For letra = 0 To 19
            For zutabea = 0 To 19
                If Asc(salda(letra, zutabea)) > 90 And salda(letra, zutabea) <> "Ñ" Then
                    Console.ForegroundColor = ConsoleColor.Red
                Else
                    Console.ForegroundColor = ConsoleColor.White
                End If
                Console.Write(salda(letra, zutabea).ToUpper & " ")
            Next
            Console.WriteLine()
        Next
        Console.ReadLine()

    End Sub

    Sub bilaketabertikal(lista, salda)
        For letra = 0 To lista.Length - 1
            For zutabea = 0 To 19
                For lerroa = 0 To 19
                    If salda(lerroa, zutabea) = lista(letra).ToUpper.Substring(0, 1) And zutabea + lista(letra).Length - 1 < 20 Then
                        Dim aurkitua As Boolean = True
                        For d = 0 To lista(letra).Length - 1
                            If salda(lerroa, zutabea + d) <> lista(letra).ToUpper.Substring(d, 1) Then
                                aurkitua = False
                            End If
                        Next
                        If aurkitua Then
                            For i = 0 To lista(letra).Length - 1
                                salda(lerroa, zutabea + i) = salda(lerroa, zutabea + i).ToLower
                            Next
                        End If
                    End If
                Next
            Next
        Next
        Console.WriteLine()
        For letra = 0 To 19
                For lerroa = 0 To 19
                If Asc(salda(lerroa, letra)) > 90 And salda(lerroa, letra) <> "Ñ" Then
                    Console.ForegroundColor = ConsoleColor.Red
                Else
                    Console.ForegroundColor = ConsoleColor.White
                End If
                Console.Write(salda(letra, lerroa).ToUpper & " ")
            Next

                Console.WriteLine()
            Next
        Console.ReadLine()
    End Sub

End Module


    