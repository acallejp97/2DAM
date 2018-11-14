
Partial Class Ejercicio_7
    Inherits System.Web.UI.Page

    Protected Sub TreeView1_SelectedNodeChanged(sender As Object, e As EventArgs) Handles TreeView1.SelectedNodeChanged
        Me.Label1.Text = "RUTA --> " & Me.TreeView1.SelectedNode.Text & " --> " & Me.TreeView1.SelectedNode.ValuePath
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Visualizar los chequeados en el label 2
        Dim acum As String = Nothing

        For Each nodo In Me.TreeView1.CheckedNodes
            acum &= nodo.Text & " "
        Next

        Me.Label2.Text = acum

    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Borrar el nodo seleccionado
        Me.TreeView1.SelectedNode.Parent.ChildNodes.Remove(Me.TreeView1.SelectedNode)
    End Sub
End Class
