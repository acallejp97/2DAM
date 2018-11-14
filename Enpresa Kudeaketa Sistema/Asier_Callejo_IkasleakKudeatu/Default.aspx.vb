Imports System.IO

Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub tbAdina_TextChanged(sender As Object, e As EventArgs) Handles tbAdina.TextChanged
        Try


            Dim adina As Integer = 0

            adina = tbAdina.Text
            If adina < 18 Then
                lblAdinaOndo.Text = "Adina ezin da 18 baino gutxiago izan"
                lblAdinaOndo.Visible = True
            Else
                lblAdinaOndo.Visible = False
            End If
        Catch ex As Exception
            tbAdina.Text = ""
        End Try


    End Sub

    Protected Sub btnGorde_Click(sender As Object, e As EventArgs) Handles btnGorde.Click
        Dim fs As FileStream
        If File.Exists("C:\Users\PC\Desktop\Visual Basic\Web Projects\Asier_Callejo_IkasleakKudeatu\Ikasleak.txt") Then
            fs = New FileStream("C:\Users\PC\Desktop\Visual Basic\Web Projects\Asier_Callejo_IkasleakKudeatu\Ikasleak.txt", FileMode.Append, FileAccess.Write)
        Else
            fs = New FileStream("C:\Users\PC\Desktop\Visual Basic\Web Projects\Asier_Callejo_IkasleakKudeatu\Ikasleak.txt", FileMode.Create, FileAccess.Write)
        End If
        'Ez zidan usten ..\..\..\Ikasleak.txt erabiltzen
        Dim sw As StreamWriter = New StreamWriter(fs)
        Dim linea As String
        Dim izena As String = tbIzena.Text
        Dim abizena As String = tbAbizena.Text
        Dim adina As String = tbAdina.Text
        Dim taldea As String = ddTaldeak.SelectedValue
        Dim irudia As String = ""
        Dim eguna As String
        Dim hizkuntza1 As String = Nothing
        Dim hizkuntza2 As String = Nothing

        If tbIzena.Text = Nothing Or tbAbizena.Text = Nothing Or tbAdina.Text = Nothing Or (rbEuskera.Checked = False And rbGaztelania.Checked = False) Or Calendar.SelectedDate = Nothing Then

            lblAdinaOndo.Text = "Sartu kanpo guztiak"
            lblAdinaOndo.Visible = True
        Else
            If rbEuskera.Checked Then
                hizkuntza1 = rbEuskera.Text
            End If
            If rbGaztelania.Checked Then
                hizkuntza1 = rbGaztelania.Text
            End If

            If cbAlemana.Checked Then
                hizkuntza2 = hizkuntza2 + cbAlemana.Text + "_"
            End If
            If cbFrantsesa.Checked Then
                hizkuntza2 = hizkuntza2 + cbFrantsesa.Text + "_"
            End If
            If cbIngelesa.Checked Then
                hizkuntza2 = hizkuntza2 + cbIngelesa.Text + "_"
            End If
            If cbItaliera.Checked Then
                hizkuntza2 = hizkuntza2 + cbItaliera.Text + "_"
            End If

            eguna = Calendar.SelectedDate
            irudia = IrudiHau.ImageUrl

            linea = izena & ";" & abizena & ";" & adina & ";" & taldea & ";" & hizkuntza1 & ";" & hizkuntza2 & ";" & eguna & ";" & irudia
            sw.WriteLine(linea)
        End If
        sw.Close()
        fs.Close()
    End Sub

    Protected Sub btnIgo_Click(sender As Object, e As EventArgs) Handles btnIgo.Click
        If Me.fuAutatu.HasFile Then
            Me.fuAutatu.SaveAs(Server.MapPath(Me.fuAutatu.FileName))
            Me.IrudiHau.ImageUrl = Me.fuAutatu.FileName
            IrudiHau.Visible = True
        End If
    End Sub

    Protected Sub btnHurrengoa_Click(sender As Object, e As EventArgs) Handles btnHurrengoa.Click
        tbIzena.Text = Nothing
        tbAbizena.Text = Nothing
        tbAdina.Text = Nothing
        lblAdinaOndo.Visible = False
        ddTaldeak.ClearSelection()
        rbEuskera.Checked = False
        rbGaztelania.Checked = False
        cbAlemana.Checked = False
        cbFrantsesa.Checked = False
        cbIngelesa.Checked = False
        cbItaliera.Checked = False
        IrudiHau.Visible = False
        IrudiHau.ImageUrl = Nothing
        fuAutatu.Attributes.Clear()
        Calendar.SelectedDate = Nothing

    End Sub



    Protected Sub Calendar1_SelectionChanged(sender As Object, e As DayRenderEventArgs)
        e.Day.IsSelectable = Not e.Day.IsWeekend
    End Sub

End Class
