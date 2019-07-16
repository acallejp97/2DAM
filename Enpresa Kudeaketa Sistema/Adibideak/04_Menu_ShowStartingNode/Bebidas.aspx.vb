
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub rbErroa_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RbErroaBai.CheckedChanged, RbErroaEz.CheckedChanged
        If RbErroaBai.Checked Then
            Me.SiteMapDataSource1.ShowStartingNode = True
        Else
            Me.SiteMapDataSource1.ShowStartingNode = False
        End If
    End Sub

    Protected Sub rbNodoa_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RbNodoaBai.CheckedChanged
        If RbNodoaBai.Checked Then
            Me.SiteMapDataSource1.StartFromCurrentNode = True
        ElseIf rbNodoaEz.Checked Then
            Me.SiteMapDataSource1.StartFromCurrentNode = False
        End If
    End Sub
End Class
