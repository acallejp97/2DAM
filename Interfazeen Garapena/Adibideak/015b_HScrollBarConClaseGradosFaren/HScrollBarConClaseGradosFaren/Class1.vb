Public Class CGrados
    Private gradosC As Single ' grados cent�grados

    Public Sub AsignarCent�grados(ByVal gC As Single)
        gradosC = gC
    End Sub

    Public Function ObtenerFahrenheit() As Single
        Return 9 / 5 * gradosC + 32         ' Fahrenheit bueltatu
    End Function
End Class
