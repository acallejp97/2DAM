Public Class CGrados
    Private gradosC As Single ' grados centígrados

    Public Sub AsignarCentígrados(ByVal gC As Single)
        gradosC = gC
    End Sub

    Public Function ObtenerFahrenheit() As Single
        Return 9 / 5 * gradosC + 32         ' Fahrenheit bueltatu
    End Function
End Class
