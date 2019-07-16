
Partial Class _Default
    Inherits System.Web.UI.Page
    'KONTUZ, letra larriak eta xeheak desberdinak dira
    Protected Sub TreeView1_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeView1.PreRender
        Me.TreeView1.ShowCheckBoxes = TreeNodeTypes.Leaf

        'chek ikusi ahal izateko
        Dim Nodo As TreeNode
        TreeView1.RootNodeStyle.BackColor = System.Drawing.Color.Yellow
        TreeView1.RootNodeStyle.ForeColor = System.Drawing.Color.Aqua
        TreeView1.ParentNodeStyle.BackColor = System.Drawing.Color.Blue
        TreeView1.ParentNodeStyle.ForeColor = System.Drawing.Color.White
        'FRUTERIA Nodoa - ezin da aukeratu
        TreeView1.Nodes(0).SelectAction = TreeNodeSelectAction.None
        'FRUTERIAren seme guztiak - ezin dira aukeratu
        For Each Nodo In TreeView1.Nodes(0).ChildNodes
            Nodo.SelectAction = TreeNodeSelectAction.None
        Next

    End Sub

    Protected Sub TreeView1_SelectedNodeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeView1.SelectedNodeChanged
        ' Dim Nodo As TreeNode = CType(sender, TreeView).SelectedNode
        Dim Nodoa As TreeNode = Me.TreeView1.SelectedNode
        Lbl_Nodoak.Text = Nodoa.Text & " (" & Nodoa.ValuePath & ")"
    End Sub

    Protected Sub btnAukeratuak_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Aukeratuak.Click
        Dim nodoa As TreeNode
        Lbl_Aukeraturik.Text = ""
        For Each nodoa In TreeView1.CheckedNodes ' Nodo guztiak aukeraturik
            Lbl_Aukeraturik.Text &= nodoa.Text & "<br>"
        Next
    End Sub

    Protected Sub btnHedatuDena_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHedatuDena.Click
        Me.TreeView1.ExpandAll()
    End Sub

    Protected Sub btnUzkurtuDena_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUzkurtuDena.Click
        Me.TreeView1.CollapseAll()
    End Sub

    Protected Sub btnBerrezarri_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBerrezarri.Click
        Me.TreeView1.CollapseAll()
        TreeView1.Nodes(0).Expand()
    End Sub


    Protected Sub xxxx_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rb_Hedatu.CheckedChanged, Rb_Uzkurtu.CheckedChanged
        Try
            If Me.Rb_Hedatu.Checked Then
                Me.TreeView1.FindNode(Me.Txt_Nodoa.Text).Expand()
            Else
                Me.TreeView1.FindNode(Me.Txt_Nodoa.Text).Collapse()
            End If
        Catch ex As Exception
            Me.Txt_Nodoa.Text = ""
        End Try
    End Sub

    Protected Sub btnGehitu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGehitu.Click
        Dim NodoBerria As New TreeNode
        NodoBerria.Text = Me.txtGehitu.Text
        Try
            Me.TreeView1.FindNode(Me.Txt_Nodoa.Text).ChildNodes.Add(NodoBerria)
        Catch ex As Exception
            Me.Txt_Nodoa.Text = ""
        End Try
    End Sub

    Protected Sub btnChecked_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnChecked.Click
        Try
            Me.TreeView1.FindNode(Me.txtChecked.Text).Checked = True
        Catch ex As Exception
            Me.txtChecked.Text = ""
        End Try
    End Sub

    Protected Sub btrEzabatu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Ezabatu.Click
        EzabatuCheckedNodes(Me.TreeView1.Nodes)

        'Nodoa = Me.TreeView1.SelectedNode
        'Me.TreeView1.SelectedNode.Parent.ChildNodes.Remove(Nodoa)  'akats ematen du

        'Dim nodo As TreeNode

        'For Each nodo In TreeView1.CheckedNodes ' Nodo guztiak aukeraturik

        '    Me.TreeView1.SelectedNode.Parent.ChildNodes.Remove(nodo)
        '    Me.TreeView1.Nodes.Remove(nodo)

        'Next

    End Sub
    Dim CheckedNodes As New List(Of TreeNode)
    
    Protected Sub EzabatuCheckedNodes(ByVal nodes As TreeNodeCollection)
        Dim node As TreeNode
        For Each node In nodes
            If node.Checked Then
                CheckedNodes.Add(node) 'nodoa gehitzen diogu listari
            Else
                EzabatuCheckedNodes(node.ChildNodes)
            End If
        Next
        For Each node In CheckedNodes
            nodes.Remove(node)
        Next
    End Sub

    Protected Sub TreeView1_TreeNodeCheckChanged(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.TreeNodeEventArgs) Handles TreeView1.TreeNodeCheckChanged
        
    End Sub
End Class


