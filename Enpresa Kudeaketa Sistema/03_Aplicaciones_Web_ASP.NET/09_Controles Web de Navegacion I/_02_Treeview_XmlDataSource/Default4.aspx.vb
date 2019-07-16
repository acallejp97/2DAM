
Partial Class Default4
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        micolor(Me.TreeView1.Nodes)
        'le paso todos los nodos
    End Sub

    Protected Sub micolor(ByVal nodes As TreeNodeCollection)

        Dim x As TreeNode
        For Each x In nodes
            If x.ChildNodes.Count = 0 Then
                If x.Text.StartsWith("Pa") Then
                    x.Text = "<span style='color: red'>" + x.Text + "</span>"
                End If
            Else
                micolor(x.ChildNodes)
                'RECURSIVA Se necesita para recorrer
            End If
        Next
    End Sub
End Class
