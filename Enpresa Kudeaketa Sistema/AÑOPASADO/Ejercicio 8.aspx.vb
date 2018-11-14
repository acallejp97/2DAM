Imports Microsoft.Reporting.WebForms

Partial Class Ejercicio_8
    Inherits System.Web.UI.Page

    Protected Sub DropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownList1.SelectedIndexChanged
        Dim a As New ReportParameter("pais", DropDownList1.SelectedValue)
        ReportViewer1.LocalReport.SetParameters(a)
        ReportViewer1.LocalReport.Refresh()
    End Sub
End Class
