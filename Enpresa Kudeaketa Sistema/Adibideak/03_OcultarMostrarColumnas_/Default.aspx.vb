﻿
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged
        Me.Label2.Text = Me.GridView1.SelectedRow.Cells(1).Text
    End Sub

    Protected Sub aaaaaa(sender As Object, e As EventArgs) Handles LinkButton1.Click, LinkButton2.Click, LinkButton3.Click
        Me.Label3.Text = sender.id
        If sender.id = "LinkButton1" Then
            Me.GridView1.Columns(0).Visible = Not Me.GridView1.Columns(0).Visible
            If Me.GridView1.Columns(0).Visible = True Then
                Me.LinkButton1.Text = "Aukeratzeko lotura ezkutatu"
            Else
                Me.LinkButton1.Text = "Aukeratzeko lotura erakutsi"
            End If
        End If
        If sender.id = "LinkButton2" Then
            Me.GridView1.Columns(1).Visible = Not Me.GridView1.Columns(1).Visible
            If Me.GridView1.Columns(1).Visible = True Then
                Me.LinkButton2.Text = "CustomerID ezkutatu"
            Else
                Me.LinkButton2.Text = "CustomerID erakutsi"
            End If
        End If
        If sender.id = "LinkButton3" Then
            Me.GridView1.Columns(2).Visible = Not Me.GridView1.Columns(2).Visible
            If Me.GridView1.Columns(2).Visible = True Then
                Me.LinkButton3.Text = "CompanyName ezkutatu"
            Else
                Me.LinkButton3.Text = "CompanyName erakutsi"
            End If
        End If
    End Sub

End Class
