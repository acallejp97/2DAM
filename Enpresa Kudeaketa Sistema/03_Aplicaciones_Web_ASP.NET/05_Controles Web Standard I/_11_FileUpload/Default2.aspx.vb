
Partial Class Default2
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
     
        If Me.FileUpload1.HasFile Then
            Me.FileUpload1.SaveAs(Server.MapPath(Me.FileUpload1.FileName))
            Me.FileUpload1.SaveAs("e:\" & Me.FileUpload1.FileName)
        End If

        Label1.Text = Me.FileUpload1.FileName & ": " & Me.FileUpload1.FileBytes.Length & "Bytes"

        Label2.Text = Me.FileUpload1.FileName & ": " & Me.FileUpload1.FileBytes.Length & "Bytes"

        'PostedFile.ContentLenght

    End Sub
End Class
