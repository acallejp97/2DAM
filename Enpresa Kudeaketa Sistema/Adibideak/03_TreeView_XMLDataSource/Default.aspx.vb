
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub TreeView1_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeView1.PreRender
        TreeView1.RootNodeStyle.BackColor = System.Drawing.Color.Yellow
        TreeView1.RootNodeStyle.ForeColor = System.Drawing.Color.Aqua
        TreeView1.ParentNodeStyle.BackColor = System.Drawing.Color.Blue
        TreeView1.ParentNodeStyle.ForeColor = System.Drawing.Color.White

        'Nodo FRUTERIA - ezin da aukeratu
        TreeView1.Nodes(0).SelectAction = TreeNodeSelectAction.None
        'FRUTERIA nodo guztiak - ezin dira aukeratu


        Dim Nodo As TreeNode
        For Each Nodo In TreeView1.Nodes(0).ChildNodes
            Nodo.SelectAction = TreeNodeSelectAction.None
        Next
    End Sub

    Protected Sub TreeView1_SelectedNodeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeView1.SelectedNodeChanged
        'Dim Nodo As TreeNode = CType(sender, TreeView).SelectedNode
        'Seleccion.Text = Nodo.Text & " (" & Nodo.ValuePath & ")"

        'Dim Nodo As TreeNode = Me.TreeView1.SelectedNode
        'Seleccion.Text = Nodo.Text & " (" & Nodo.ValuePath & ")"
        '                   aukeraturik dagoena
        Etiketa.Text = Me.TreeView1.SelectedNode.Text & _
            " (" & Me.TreeView1.SelectedNode.ValuePath & ")"
        '              erruta osoa
    End Sub
End Class
