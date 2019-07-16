
Partial Class DefaultVB_
    Inherits System.Web.UI.Page

    Protected Sub btnaceptar_Click(sender As Object, e As EventArgs) Handles btnaceptar.Click
        'Metodo Get ,se ve en la barra de direccion
        If Me.txtusuario.Text = "admin" And Me.txtpassword.Text = "123" Then
            'para pasar el valor por la barra de direcciones
            Me.Response.Redirect("ValidoVB.aspx?aaa=" + Me.txtusuario.Text + "&bbb=" + Me.txtpassword.Text)
        Else
          
            Me.Response.Redirect("ErrorVB.aspx?aaa=" + Me.txtusuario.Text + "&bbb=" + Me.txtpassword.Text)
            End If


    End Sub
End Class
