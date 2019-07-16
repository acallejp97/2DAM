
Partial Class _Default
    Inherits System.Web.UI.Page
    Protected Sub Lista_Click(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.BulletedListEventArgs) Handles Lista.Click
        'Es para el caso de que seleccionemos el modo BOTON.
        Me.etiqueta.Text = e.Index + 1 & " - " & Me.Lista.Items(e.Index).Text
    End Sub

    Protected Sub estilo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownList1.SelectedIndexChanged
        Select Case DropDownList1.SelectedValue
            Case "NotSet"
                Me.Lista.BulletStyle = BulletStyle.NotSet
            Case "Numbered"
                Me.Lista.BulletStyle = BulletStyle.Numbered
            Case "LowerAlpha"
                Lista.BulletStyle = BulletStyle.LowerAlpha
            Case "UpperAlpha"
                Lista.BulletStyle = BulletStyle.UpperAlpha
            Case "LowerRoman"
                Lista.BulletStyle = BulletStyle.LowerRoman
            Case "UpperRoman"
                Lista.BulletStyle = BulletStyle.UpperRoman
            Case "Disc"
                Lista.BulletStyle = BulletStyle.Disc
            Case "Circle"
                Lista.BulletStyle = BulletStyle.Circle
            Case "Square"
                Lista.BulletStyle = BulletStyle.Square
            Case "Image"
                Lista.BulletImageUrl = "4.gif"
                Lista.BulletStyle = BulletStyle.CustomImage
        End Select
    End Sub

    Protected Sub DropDownList2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownList2.SelectedIndexChanged
        Select Case DropDownList2.SelectedValue
            Case "texto"
                Me.Lista.DisplayMode = BulletedListDisplayMode.Text
            Case "LinkButton"
                Me.Lista.DisplayMode = BulletedListDisplayMode.LinkButton
                'Para que funcione como un botón
            Case "HyperLink"
                Me.Lista.DisplayMode = BulletedListDisplayMode.HyperLink
                'Para que funcione el link a la pag1,2,3.
        End Select
    End Sub

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.Lista.DisplayMode = BulletedListDisplayMode.Text
        Me.Lista.BulletStyle = BulletStyle.Numbered
        'Lista.DisplayMode = BulletedListDisplayMode.Text
    End Sub
End Class
