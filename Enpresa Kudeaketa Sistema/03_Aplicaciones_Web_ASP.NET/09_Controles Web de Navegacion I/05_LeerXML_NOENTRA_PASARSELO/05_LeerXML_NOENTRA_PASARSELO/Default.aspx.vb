Imports System.Xml

Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Dim acum As String = Nothing
        Dim camino As String = AppDomain.CurrentDomain.BaseDirectory & "XMLPrueba.xml"
        Dim m_xmlr As XmlTextReader
        'Creamos el TextReader
        m_xmlr = New XmlTextReader(camino)

        'Desabilitamos las lineas en blanco,
        'ya no las necesitamos
        m_xmlr.WhitespaceHandling = WhitespaceHandling.None

        'Leemos el archivo y avanzamos al tag de usuarios
        m_xmlr.Read()

        'Leemos el tag usuarios
        m_xmlr.Read()

        'Creamos la secuancia que nos permite
        'leer el archivo
        While Not m_xmlr.EOF
            'Avanzamos al siguiente tag
            m_xmlr.Read()

            'si no tenemos el elemento inicial
            'debemos salir del ciclo
            If Not m_xmlr.IsStartElement() Then
                Exit While
            End If

            'Obtenemos el elemento codigo
            Dim mCodigo = m_xmlr.GetAttribute("codigo")
            'Read elements firstname and lastname

            m_xmlr.Read()
            'Obtenemos el elemento del Nombre del Usuario
            Dim mNombre = m_xmlr.ReadElementString("nombre")

            'Obtenemos el elemento del Apellido del Usuario
            Dim mApellido = m_xmlr.ReadElementString("apellido")

            'Escribimos el resultado en la consola,
            'pero tambien podriamos utilizarlos en
            'donde deseemos    
            acum &= "Codigo usuario: " & mCodigo & "<br>" _
              & " Nombre: " & mNombre & "<br>" _
              & " Apellido: " & mApellido & "<br>" & "<br>"
        End While

        'Cerramos la lactura del archivo
        m_xmlr.Close()
        Me.Label1.Text = acum
    End Sub

    Protected Sub Button2_Click(sender As Object, e As System.EventArgs) Handles Button2.Click
        Dim acum As String = Nothing
        Dim camino As String = AppDomain.CurrentDomain.BaseDirectory & "XMLPrueba.xml"

        Try
            Dim m_xmld As XmlDocument
            Dim m_nodelist As XmlNodeList
            Dim m_node As XmlNode

            'Creamos el "Document"
            m_xmld = New XmlDocument()

            'Cargamos el archivo
            m_xmld.Load(camino)

            'Obtenemos la lista de los nodos "name"
            m_nodelist = m_xmld.SelectNodes("/usuarios/name")

            'Iniciamos el ciclo de lectura
            For Each m_node In m_nodelist
                'Obtenemos el atributo del codigo
                Dim mCodigo = m_node.Attributes.GetNamedItem("codigo").Value

                'Obtenemos el Elemento nombre
                Dim mNombre = m_node.ChildNodes.Item(0).InnerText

                'Obtenemos el Elemento apellido
                Dim mApellido = m_node.ChildNodes.Item(1).InnerText

                'Escribimos el resultado en la consola,
                'pero tambien podriamos utilizarlos en
                'donde deseemos
                acum &= "Codigo usuario: " & mCodigo & "<br>" _
            & " Nombre: " & mNombre & "<br>" _
            & " Apellido: " & mApellido & "<br>" & "<br>"

            Next
        Catch ex As Exception
            'Error trapping
            Console.Write(ex.ToString())
        Finally
            Me.Label2.Text = acum
        End Try

    End Sub
End Class
