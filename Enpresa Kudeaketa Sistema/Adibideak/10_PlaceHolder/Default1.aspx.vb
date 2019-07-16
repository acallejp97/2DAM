
Partial Class Default1
    Inherits System.Web.UI.Page

    Protected Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If Me.CheckBox1.Checked Then
            Dim textbox1 As New TextBox
            textbox1.BackColor = Drawing.Color.Azure
            Me.PlaceHolder1.Controls.Add(textbox1)

            Dim textbox2 As New TextBox
            textbox2.BackColor = Drawing.Color.Beige
            Me.PlaceHolder1.Controls.Add(textbox2)

            Me.PlaceHolder1.Visible = True
        Else
            Me.PlaceHolder1.Visible = False
        End If
    End Sub


    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Me.PlaceHolder1.Visible = False
        End If
    End Sub
End Class
