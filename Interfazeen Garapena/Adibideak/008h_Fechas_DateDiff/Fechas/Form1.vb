Public Class Form1

    Private Sub btnEjecutar_Click(sender As System.Object, e As System.EventArgs) Handles btnEjecutar.Click
        _FuncionesFecha()
    End Sub
    Sub _FuncionesFecha()
        lblNow.Text = Now 'Data eta ordua
        lblToday.Text = Today 'Data
        lbltimeofday.Text = TimeOfDay 'Ordua
        _DateAdd()
        _DatePart()
        _DateDiff()
    End Sub

    Sub _DateAdd()
        Dim Numero, cad, FechaInicio As String   'Aldagaien deklarazioa
        Dim Meses As Double
        Dim FechaInicio2 As Date

        FechaInicio = InputBox("Sartu data bat era honetan:  ee/hh/uuuu : ", _
                    " Función DateAdd")
        FechaInicio2 = CDate(FechaInicio)
        Numero = InputBox("Sartu zenbat hilabete gehitu nahi duzu data horretara : ", _
                                        "Hilabeteak gehitu")
        Meses = Val(Numero)
        cad = "Hasiera data : " & FechaInicio & ", gehitzeko hilabeteak: " & Numero & _
                                         ", Data berria: "
        lbldateadd.Text = cad & DateAdd(DateInterval.Month, Meses, FechaInicio2)
    End Sub

    Sub _DatePart()
        Dim FechaFinal As Date
        FechaFinal = InputBox("Sartu gaur baino beranduago den data era honetan: ee/hh/uuuu: ", _
                                             " gaur baino egun gehiago.")
        lblDatePart.Text = "" & Now & " - " & FechaFinal & _
                    " " & DateDiff(DateInterval.Day, Now, FechaFinal) & " egun daude."
    End Sub

    Sub _DateDiff()
        Dim cad$
        Dim FechaInicio, FechaFinal As String
        FechaInicio = InputBox("Sartu hasiera data era honetan: ee/hh/uuuu: ", _
                                             " DateDiff funtzioa")
        FechaFinal = InputBox("Sartu bukaera data era honetan: ee/hh/uuuu: ", _
                                             " DateDiff funtzioa")
        cad = " " & FechaInicio & " eta " & FechaFinal & " artean, "

        lblDateDiff.Text = cad & DateDiff(DateInterval.Day, CDate(FechaInicio), CDate(FechaFinal)) & " egun daude."
    End Sub
End Class
