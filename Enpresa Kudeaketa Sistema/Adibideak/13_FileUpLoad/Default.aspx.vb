
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.FileUpload1.HasFile Then
            Me.FileUpload1.SaveAs(Server.MapPath(Me.FileUpload1.FileName))
            Me.Label1.Text = Me.FileUpload1.FileName & " " & Server.MapPath(Me.FileUpload1.FileName) & "n igo da. Tamaina: " & Me.FileUpload1.PostedFile.ContentLength & " bytes."

            Me.FileUpload1.SaveAs("G:\" & Me.FileUpload1.FileName)
            Me.Label2.Text = Me.FileUpload1.FileName & " G:en gorde da. Tamaina: " & Me.FileUpload1.PostedFile.ContentLength & " bytes."
        Else
            Me.Label1.Text = "Aukeratu zerbait."
            Me.Label2.Text = ""
        End If

    End Sub
End Class
