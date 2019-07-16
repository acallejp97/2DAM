
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles form1.Load
        If Not Me.IsPostBack Then
            CheckBoxList1.DataSourceID = "XmlDataSource1"
            CheckBoxList1.DataTextField = "Categoria"
            CheckBoxList1.DataValueField = "id" ' XML fitxategian dago, baina ariketa honetan ez da beharrezkoa

            'CheckBoxList1.DataTextField = "Seleccion" '2.mailako etiketekin ez du lanik egiten
            CheckBoxList1.RepeatColumns = 3  'zenbat zutabe ikusiko dira
            CheckBoxList1.BorderWidth = 2
            CheckBoxList1.BorderColor = System.Drawing.Color.DarkGreen
            CheckBoxList1.BackColor = System.Drawing.Color.Green
            CheckBoxList1.ForeColor = System.Drawing.Color.White
        End If
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim s As String
        Dim i As Integer
        s = "Modo 1- Aukeratutako elementuak:<br>"
        For i = 0 To Me.CheckBoxList1.Items.Count - 1
            If Me.CheckBoxList1.Items(i).Selected Then
                s = s & Me.CheckBoxList1.Items(i).Text & " -- " & _
                    Me.CheckBoxList1.Items(i).Value & "<br>"
            End If
        Next
        Me.Label1.Text = s
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Label1.Text = "Modo 2- Aukeratutako elementuak:<br>"
        For Each item In CheckBoxList1.Items
            If item.Selected Then
                Label1.Text = Label1.Text + "<br>" + item.Text + _
                    " -- " + item.value
            End If
        Next
    End Sub

    Protected Sub CheckBoxList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBoxList1.SelectedIndexChanged

    End Sub
End Class
