
Partial Class Default2
    Inherits System.Web.UI.Page

    Protected Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Panel1.Visible = True
        Else
            Panel1.Visible = False
        End If
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Panel1.Visible = False
        End If
        Label1.Visible = False
    End Sub
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel1.Visible = True
        Dim uno, dos As String
        uno = TextBox1.Text
        dos = TextBox2.Text

        Label1.Text = uno & ".." & dos
        Label1.Visible = True
    End Sub
End Class
