Imports System.Xml

Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Dim acum As String = Nothing
        Dim camino As String = AppDomain.CurrentDomain.BaseDirectory & "XMLPrueba.xml"
        Dim m_xmlr As XmlTextReader
        'TextReader Sortu
        m_xmlr = New XmlTextReader(camino)

        'Hutsik dauden lerroak kendu
        m_xmlr.WhitespaceHandling = WhitespaceHandling.None

        'Fitxategia irakurri 
        m_xmlr.Read()

        'Tag usuarios irakurri
        m_xmlr.Read()

        'Fitxategia bukatzen ez den bitartean
        While Not m_xmlr.EOF
            'Hurrengo tag
            m_xmlr.Read()

            'Ez badago bukatu
            If Not m_xmlr.IsStartElement() Then
                Exit While
            End If


            Dim mCodigo = m_xmlr.GetAttribute("codigo")
            m_xmlr.Read()
            Dim mNombre = m_xmlr.ReadElementString("nombre")
            Dim mApellido = m_xmlr.ReadElementString("apellido")

            'Pantailan idazten dugu emaitza
            acum &= "Codigo usuario: " & mCodigo & "<br>" _
              & " Nombre: " & mNombre & "<br>" _
              & " Apellido: " & mApellido & "<br>" & "<br>"
        End While

        'Fitxategia itxi
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

            '"Document" Sortu
            m_xmld = New XmlDocument()

            'Fitxategia kargatu
            m_xmld.Load(camino)

            'Nodo "name" hartu
            m_nodelist = m_xmld.SelectNodes("/usuarios/name")

            'Fitxategia bukatzen ez den bitartean
            For Each m_node In m_nodelist

                Dim mCodigo = m_node.Attributes.GetNamedItem("codigo").Value
                Dim mNombre = m_node.ChildNodes.Item(0).InnerText
                Dim mApellido = m_node.ChildNodes.Item(1).InnerText

                'Pantailan idazten dugu emaitza
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
