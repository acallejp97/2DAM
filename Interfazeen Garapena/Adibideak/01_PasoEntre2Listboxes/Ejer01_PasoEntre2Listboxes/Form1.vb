Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ListBox1.Items.Add("A01")
        Me.ListBox1.Items.Add("A02")
        Me.ListBox1.Items.Add("A03")
        Me.ListBox1.Items.Add("A04")
        Me.ListBox1.Items.Add("A05")
        Me.ListBox1.Items.Add("A06")
        Me.ListBox1.Items.Add("A07")
        Me.ListBox1.Items.Add("A08")
        Me.ListBox1.Items.Add("A09")
        Me.ListBox1.Items.Add("A10")
        Me.ListBox1.Items.Add("A11")
        Me.ListBox1.Items.Add("A12")

        Me.TextBox1.TabIndex = 0
        Me.AcceptButton = Me.btnAgregar
        aukeratutakendu()
    End Sub

    Sub aukeratutakendu()
        If Me.ListBox1.Items.Count > 0 Then
            Me.ListBox1.SelectedIndex = 0
        End If
        If Me.ListBox2.Items.Count > 0 Then
            Me.ListBox2.SelectedIndex = 0
        End If
        Me.Label1.Text = Me.ListBox1.Items.Count & " items."
        Me.Label2.Text = Me.ListBox2.Items.Count & " items."
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If Me.TextBox1.Text <> "" Then
            Me.ListBox1.Items.Add(Me.TextBox1.Text)
            Me.TextBox1.Clear()
            Me.TextBox1.Focus()
        End If
        aukeratutakendu()
    End Sub
    Private Sub btnSort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSort.Click
        Me.ListBox2.Sorted = Not Me.ListBox2.Sorted
    End Sub

    Private Sub btnUnoDcha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnoDcha.Click
        If Me.ListBox1.SelectedIndex <> -1 Then
            Me.ListBox2.Items.Add(Me.ListBox1.SelectedItem)
            Me.ListBox1.Items.Remove(Me.ListBox1.SelectedItem)
        End If
        aukeratutakendu()
    End Sub

    Private Sub btnUnoIzqda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnoIzqda.Click
        If Me.ListBox2.SelectedIndex >= 0 Then
            Me.ListBox1.Items.Add(Me.ListBox2.SelectedItem)
            Me.ListBox2.Items.Remove(Me.ListBox2.SelectedItem)
        End If
        aukeratutakendu()
    End Sub

    Private Sub btnTodoDcha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTodoDcha.Click
        ' Modo 1.
        'For x = 0 To Me.ListBox1.Items.Count - 1
        '    Me.ListBox1.SelectedIndex = 0
        '    Me.ListBox2.Items.Add(Me.ListBox1.SelectedItem)
        '    Me.ListBox1.Items.RemoveAt(0)
        'Next

        ' Modo 2.
        'While Me.ListBox2.Items.Count > 0
        '    Me.ListBox2.SelectedIndex = 0
        '    Me.ListBox1.Items.Add(Me.ListBox2.SelectedItem)
        '    Me.ListBox2.Items.RemoveAt(0)
        'End While


        ' Modo 3.
        Me.ListBox2.Items.AddRange(Me.ListBox1.Items)
        Me.ListBox1.Items.Clear()

        aukeratutakendu()
    End Sub
    Private Sub btnTodoIzqda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTodoIzqda.Click
        Me.ListBox1.Items.AddRange(Me.ListBox2.Items)
        Me.ListBox2.Items.Clear()

        aukeratutakendu()
    End Sub

End Class

