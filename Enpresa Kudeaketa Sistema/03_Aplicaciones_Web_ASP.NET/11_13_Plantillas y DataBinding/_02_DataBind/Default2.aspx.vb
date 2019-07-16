Imports System.Data

Partial Class Default2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Dim bbb(1) As String
            bbb(0) = "Elorrieta"
            bbb(1) = "Erreka-Mari"
            Array.Sort(bbb)
            Me.RadioButtonList1.DataSource = bbb
            Me.RadioButtonList1.DataBind()

            Dim ccc As New ArrayList
            ccc.Add("blanco")
            ccc.Add("negro")
            ccc.Sort()
            Me.RadioButtonList2.DataSource = ccc
            Me.RadioButtonList2.DataBind()

            Dim guardar As New DataSet
            guardar.ReadXml(Server.MapPath("countries.xml"))
            Me.RadioButtonList3.DataSource = guardar
            Me.RadioButtonList3.DataTextField = "aaa"
            Me.RadioButtonList3.DataValueField = "bbb"
            Me.RadioButtonList3.DataBind()
        End If
    End Sub

    Protected Sub RadioButtonList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioButtonList1.SelectedIndexChanged
        Me.Label3.Text = sender.text
    End Sub

    Protected Sub RadioButtonList2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioButtonList2.SelectedIndexChanged
        Me.Label4.Text = sender.text
    End Sub

    Protected Sub RadioButtonList3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioButtonList3.SelectedIndexChanged
        Me.Label5.Text = Me.RadioButtonList3.SelectedItem.Value & " - " & Me.RadioButtonList3.SelectedItem.Text
    End Sub
End Class
