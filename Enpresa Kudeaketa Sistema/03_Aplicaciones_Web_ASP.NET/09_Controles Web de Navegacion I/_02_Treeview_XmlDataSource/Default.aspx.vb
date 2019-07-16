
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub TreeView1_PreRender(sender As Object, e As EventArgs) Handles TreeView1.PreRender
        'antes de que se dibuje el treeview hace esto
        'cambio los colores
        Me.TreeView1.RootNodeStyle.BackColor = Drawing.Color.Green
        Me.TreeView1.ParentNodeStyle.BackColor = Drawing.Color.Yellow

        'no puedo seleccionar FRUTERIA
        Me.TreeView1.Nodes(0).SelectAction = TreeNodeSelectAction.None
        'recorro todos los nodos hijos de fruteria

        Dim x As TreeNode

        For Each x In Me.TreeView1.Nodes(0).ChildNodes
            x.SelectAction = TreeNodeSelectAction.None
        Next

    End Sub



    Private Sub TreeView1_SelectedNodeChanged(sender As Object, e As EventArgs) Handles TreeView1.SelectedNodeChanged
        Me.Label2.Text = TreeView1.SelectedNode.Text & " - " & Me.TreeView1.SelectedNode.ValuePath
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As TreeNode
        Dim acum As String

        For Each x In Me.TreeView1.Nodes(0).ChildNodes
            acum += "<br>" & x.Text
        Next

        Label3.Text = acum
    End Sub
End Class
