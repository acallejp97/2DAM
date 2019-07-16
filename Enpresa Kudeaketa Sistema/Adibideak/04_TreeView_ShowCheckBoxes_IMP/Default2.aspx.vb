
Partial Class Default2
    Inherits System.Web.UI.Page

    Dim CheckedNodes As New List(Of TreeNode)
    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        EzabatuNodoAukeraturik(Me.TreeView1.Nodes)
    End Sub
    Protected Sub EzabatuNodoAukeraturik(ByVal nodes As TreeNodeCollection)
        'funtzio errekurtsiba

        Dim Nodoa As TreeNode
        For Each Nodoa In nodes
            If Nodoa.Checked Then
                CheckedNodes.Add(Nodoa) 'nodoa gehitzen diogu listari
            Else
                EzabatuNodoAukeraturik(Nodoa.ChildNodes)
            End If
        Next
        For Each Nodoa In CheckedNodes
            nodes.Remove(Nodoa)
        Next
    End Sub
End Class
