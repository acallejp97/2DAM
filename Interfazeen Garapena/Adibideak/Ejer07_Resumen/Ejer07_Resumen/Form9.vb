Imports System.Data.OleDb
Public Class Form9
    Dim cnn1 As New OleDbConnection(KonexioKatea)
    Dim sql As String
    Private Sub Form9_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
    'Transacciones

    'Básicamente podemos decir que una transacción es una serie de acciones que deben realizarse en conjunto, 
    'a "todo o nada". Esto significa que las transacciones son atómicas, todos los pasos deben llevarse a cabo correctamente o 
    'volver todos los cambios realizados hacia atrás. 
    'De esta forma nos aseguraremos que los datos no queden en estado inconsistente. 
    'El ejemplo clásico es el de una transferencia bancaria: Si queremos transferir $100 de la Cuenta A a la Cuenta B 
    'tendremos primero que quitar $100 de A y agregar $100 a B, si se produce algún problema en el medio del proceso 
    'habremos sacado $100 de A que nunca se agregarán a B y habrán desaparecido $100. 

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'Se tienen que realizar las dos o ninguna
        ' Apertura de la conexión

        cnn1.Open()

        Dim Commando As New OleDbCommand
        Dim Transaccion As OleDbTransaction

        ' Inicio de la transaccion
        Transaccion = cnn1.BeginTransaction()
        Commando.Connection = cnn1
        Commando.Transaction = Transaccion
        Try
            ' Comando para descontar $100 de la Cuenta A
            Commando.CommandText = "UPDATE Products SET UnitPrice = UnitPrice + 3.99  WHERE ProductID = 3"
            Commando.ExecuteNonQuery()

            ' Comando para aumentar $100 de la Cuenta B
            Commando.CommandText = "UPDATE Products SET UnitPrice = UnitPrice - 3.99  WHERE ProductID = 4"
            Commando.ExecuteNonQuery()

            ' Finalización exitosa de la transacción
            Transaccion.Commit()
            Label1.Text = "El Dinero fue transferido con éxito"
        Catch ex As Exception
            ' Cancela toda la transacción
            Transaccion.Rollback()
            Label1.Text = "Se produjo un error al procesar la transferencia.Detalle:" & ex.ToString()
        Finally
            cnn1.Close()
        End Try

    End Sub
End Class