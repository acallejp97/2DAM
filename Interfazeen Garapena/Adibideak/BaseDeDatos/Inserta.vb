Public Class Inserta

    Private Sub Inserta_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        conectarse()
        llenacombo()
    End Sub

    Private Sub llenacombo()
        Me.cmbEliminar.Items.Clear()
        sql = "Select EmployeeID from employees"
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        cmd.CommandText = sql

        dr = cmd.ExecuteReader
        If dr.HasRows = True Then
            While dr.Read
                ' Me.cmbEliminar.Items.Add(dr(0).ToString)
                Me.cmbEliminar.Items.Add(dr.GetValue(0))
            End While
        End If
        dr.Close()
    End Sub
    Private Sub btninsertar_Click(sender As System.Object, e As System.EventArgs) Handles btninsertar.Click
        conectarse()

        Dim lastname As String = ""
        Dim firstname As String = ""

        lastname = Me.txtLastname.Text
        firstname = Me.txtFirstname.Text

        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        sql = "Insert into employees (LastName,FirstName) values ('" & lastname & "','" & firstname & "')"
        'MsgBox(sql)
        cmd.CommandText = sql
        Try
            cmd.ExecuteNonQuery()
            MsgBox("Insertado")
            desconectarse()
        Catch ex As Exception
            If ex.ToString.Contains("Valores Duplicados") Then
                MsgBox("El registro ya existe en la base de datos")
            Else
                MsgBox(ex.ToString)
            End If
        End Try

    End Sub

    Private Sub btnActualizar_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizar.Click
        conectarse()
        Dim id As Double
        Dim lastname As String = ""
        Dim firstname As String = ""

        id = Me.txtId1.Text
        lastname = Me.txtLast1.Text
        firstname = Me.txtFirst1.Text

        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        sql = "update employees  set "
        sql += "LastName = '" & lastname & "', "
        sql += "firstname = '" & firstname & "' "
        sql += "Where EmployeeID= " & id
        'MsgBox(sql)
        cmd.CommandText = sql
        Try
            cmd.ExecuteNonQuery()
            MsgBox("actualizado")
            desconectarse()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
        conectarse()
        Dim id As Double
       
        id = Me.txtid2.Text

        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        sql = "Delete from employees "
        sql += "Where EmployeeID= " & id
        'MsgBox(sql)
        cmd.CommandText = sql
        Try
            cmd.ExecuteNonQuery()
            MsgBox("eliminado")
            desconectarse()
            Me.txtid2.Text = ""
            Me.txtLast2.Text = ""
            Me.txtFirst2.Text = ""
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub txtId1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtId1.TextChanged
        conectarse()
        If Me.txtId1.Text <> "" Then
            consultarpersona(Me.txtId1.Text)

            If dr.Read Then
                Me.txtLast1.Text = dr(1).ToString
                Me.txtFirst1.Text = dr(2).ToString

                Me.btnActualizar.Enabled = True
            Else
                MsgBox("No existe el registroen la base de datos")
                Me.txtLast1.Text = ""
                Me.txtFirst1.Text = ""
                Me.btnActualizar.Enabled = False
            End If
            dr.Close()
        Else
            Me.btnActualizar.Enabled = False
        End If
    End Sub

    Public Sub consultarpersona(ByRef identificacion As Double)
        Dim acum As String = Nothing
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select * from employees where EmployeeID=" & identificacion

        Try
            dr = cmd.ExecuteReader
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub txtid2_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtid2.TextChanged
        conectarse()
        If Me.txtid2.Text <> "" Then
            consultarpersona(Me.txtid2.Text)

            If dr.Read Then
                Me.txtLast2.Text = dr(1).ToString
                Me.txtFirst2.Text = dr(2).ToString

                Me.btnEliminar.Enabled = True
            Else
                MsgBox("No existe el registro en la base de datos")
                Me.txtLast2.Text = ""
                Me.txtFirst2.Text = ""
                Me.btnEliminar.Enabled = False
            End If
            dr.Close()
        Else
            Me.btnEliminar.Enabled = False
        End If
    End Sub

    Private Sub TabPage3_Click(sender As System.Object, e As System.EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub cmbEliminar_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cmbEliminar.SelectedValueChanged
        Me.txtid2.Text = Me.cmbEliminar.SelectedItem.ToString
    End Sub
End Class