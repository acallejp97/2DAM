
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim aaa() As String = {"hola", "adios"}

        Me.ListBox1.DataSource = aaa
        Me.ListBox1.DataBind()

        Dim bbb(1) As String
        bbb(0) = "Elorrieta"
        bbb(1) = "Erreka-Mari"
        Me.ListBox2.DataSource = bbb
        Me.ListBox2.DataBind()

        Dim ccc As New ArrayList
        ccc.Add("blanco")
        ccc.Add("negro")
        Me.ListBox3.DataSource = ccc
        Me.ListBox3.DataBind()

    End Sub
End Class
