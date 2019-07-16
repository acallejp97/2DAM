Module Module1
    Public path As String = Application.ExecutablePath
    'EXISTE
    'Public strconexion As String = _
    '"Provider = Microsoft.Jet.OLEDB.4.0;" & _
    '"Data Source = ..\..\..\..\..\..\Northwind.mdb"
    '"Data Source = " & path.Chars(0) & ":\Microsoft Press Books\Northwind.mdb"

    Public strconexion As String = _
    "Provider = Microsoft.ACE.OLEDB.12.0;" & _
    "Data Source = ..\..\..\..\..\..\Northwind.mdb"
End Module
