Imports System.Text.RegularExpressions

Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Espresio erregularrak erabili ahal dira. Hots, javascript
        ' Bi modu desberdinetan definitu ahal da:
        '  - var re = /ab+c/;
        '  - var re = new RegExp ( "ab + c");
        ' Erabiltzen da espresio zein izango den ez dakigunean exekutatu arte.
        ' Kasu honetan \s edozein zuriune da
        Me.Label1.Text = New Regex("\s*").Replace(TextBox1.Text, String.Empty)

    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
End Class
