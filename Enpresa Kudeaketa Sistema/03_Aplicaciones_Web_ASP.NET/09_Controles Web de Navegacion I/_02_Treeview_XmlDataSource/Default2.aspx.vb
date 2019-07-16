
Partial Class Default2
    Inherits System.Web.UI.Page

    Protected Sub TreeView1_PreRender(sender As Object, e As EventArgs) Handles TreeView1.PreRender
        Me.TreeView1.RootNodeStyle.BackColor = Drawing.Color.AliceBlue
        Me.TreeView1.ParentNodeStyle.BackColor = Drawing.Color.GreenYellow

        Me.TreeView1.ShowCheckBoxes = TreeNodeTypes.All
    End Sub

    Protected Sub TreeView1_SelectedNodeChanged(sender As Object, e As EventArgs) Handles TreeView1.SelectedNodeChanged
        Me.Label1.Text = Me.TreeView1.SelectedNode.ValuePath
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.TreeView1.SelectedNode.Parent.ChildNodes.Remove(Me.TreeView1.SelectedNode)
        Catch ex As Exception

        End Try
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim x As TreeNode
        BulletedList1.Items.Clear()
        For Each x In Me.TreeView1.CheckedNodes

            BulletedList1.Items.Add(x.Text)
        Next

    End Sub

    Protected Sub ButtonContraer_Click(sender As Object, e As EventArgs) Handles ButtonContraer.Click
        'CONTRAER
        Me.TreeView1.CollapseAll()
    End Sub

    Protected Sub ButtonExpandir_Click(sender As Object, e As EventArgs) Handles ButtonExpandir.Click
        'EXPANDIR TODO
        Me.TreeView1.ExpandAll()
    End Sub

    Protected Sub ButtonRestablecer_Click(sender As Object, e As EventArgs) Handles ButtonRestablecer.Click
        'EXPANDIR ROOT-PARENTS
        Me.TreeView1.CollapseAll()
        Me.TreeView1.Nodes(0).Expand()
    End Sub

    Protected Sub abc(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged
        Try
            Me.TextBox1.BackColor = Drawing.Color.AliceBlue
            If Me.RadioButton2.Checked Then
                Me.TreeView1.FindNode(Me.TextBox1.Text).Collapse()
            Else
                Me.TreeView1.FindNode(Me.TextBox1.Text).Expand()
            End If
        Catch ex As Exception
            Me.TextBox1.BackColor = Drawing.Color.Chocolate
            Me.TextBox1.Focus()
        End Try
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim x As New TreeNode

            x.Text = TextBox1.Text
            Me.TreeView1.FindNode(Me.TextBox1.Text).ChildNodes.Add(x)
        Catch ex As Exception
            Me.TextBox1.BackColor = Drawing.Color.Yellow
            Me.TextBox1.Focus()
        End Try
    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Me.TreeView1.FindNode(Me.TextBox3.Text).Checked = Not Me.TreeView1.FindNode(Me.TextBox3.Text).Checked
        Catch ex As Exception
            Me.TextBox3.Focus()
        End Try
    End Sub
End Class
