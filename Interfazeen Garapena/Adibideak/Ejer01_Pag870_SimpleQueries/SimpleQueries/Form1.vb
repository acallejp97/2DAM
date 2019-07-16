'Imports System.Data.SqlClient 'SqlServer
Imports System.Data.OleDb 'Access

Public Class Form1
    Dim cnn1 As OleDbConnection
    Private Sub bttnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnConnectCN.Click
        Dim path As String = Application.StartupPath
        Dim cn As String = path(0) & ":\"
        Me.Ofd.InitialDirectory = cn
        Me.Ofd.Filter = "Datu basean dauden taula guztiak (*.mdb)|*.mdb"
        Me.Ofd.FilterIndex = 1
        Me.Ofd.FileName = "Northwind.mdb"
        If Me.Ofd.ShowDialog() = DialogResult.OK Then
            cn = Me.Ofd.FileName 'ruta osoa
        End If
        '"Provider=Microsoft.JET.OLEDB.4.0;Data Source=NombreBD.accdb" 'access 2003
        Dim CNstring As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & cn  'access 2010

        CNstring = InputBox("Please enter a cnn1 String", "CONNECTION STRING", CNstring)
        If CNstring.Trim = "" Then Exit Sub
        cnn1 = New OleDbConnection(CNstring)
        Try
            cnn1.Open()
            If cnn1.State = ConnectionState.Open Then
                MsgBox("Workstation " & cnn1.State & " connected to database " & cnn1.DataSource)
            End If
        Catch ex As Exception
            MsgBox("FAILED TO OPEN CONNECTION TO DATABASE" & vbCrLf & ex.Message)
        Finally
            If cnn1.State = ConnectionState.Open Then cnn1.Close()
        End Try
    End Sub

    Private Sub bttnCount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnCount.Click

        'EXECUTESCALAR- balio bakar bat bueltatzen du. 
        'Executes the query, and returns the first column of the first row in the result set returned by the query. Additional columns or rows are ignored.
        Dim count As Integer
        Dim cmd1 As New OleDbCommand("SELECT Count(CustomerID) FROM Customers WHERE Country = 'Italy'", cnn1)
        'try catch egiaztatzeko countd
        Try
            cnn1.Open()
            count = cmd1.ExecuteScalar
            cnn1.Close()
            MsgBox("There are " & count.ToString & " customers from Italy")

        Catch ex As Exception
            MsgBox("FAILED TO execute SQL sentence" & vbNewLine & ex.Message)
        Finally
            MsgBox("Dena eginda")

        End Try
    End Sub


    Private Sub bttnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnInsert.Click

        'EXECUTENONQUERY - aldatutako lerro kopurua bueltatzen du 
        'You can use the ExecuteNonQuery to perform catalog operations by executing UPDATE, INSERT, or DELETE statements.
        'For UPDATE, INSERT, and DELETE statements, the return value is the number of rows affected by the command. 
        'When a trigger exists on a table being inserted or updated, the return value includes the number of rows affected by both the insert or update operation and the number of rows affected by the trigger or triggers. 
        'For all other types of statements, the return value is -1.
        '
        Dim cmd1 As New OleDbCommand("INSERT INTO Customers (CustomerID, CompanyName,Country) VALUES ('NEW01', 'New Company', 'Italy')", cnn1)
        cnn1.Open()
        Dim rows As Integer
        Try
            rows = cmd1.ExecuteNonQuery()
            MsgBox("New customer inserted successfully! " & rows & " rows")
        Catch ex As Exception
            MsgBox("Failed to insert new customer!" & vbCrLf & ex.Message)
        Finally
            cnn1.Close()
        End Try
    End Sub


    Private Sub bttnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnDelete.Click

        'EXECUTENONQUERY - aldatutako lerro kopurua bueltatzen du 
        Dim cmd1 As New OleDbCommand("DELETE * FROM Customers WHERE CustomerID='NEW01'", cnn1)
        Dim rows As Integer
        Try
            cnn1.Open()
            rows = cmd1.ExecuteNonQuery()
            If rows = 1 Then
                MsgBox("Customer ondo ezabaturik")
            ElseIf rows = 0 Then
                MsgBox("Customer ez ezabaturik" & "Jadanik ezabaturik egon daiteke")
            Else
                MsgBox("Multiple deletions! Please check the database!")
            End If
        Catch ex As Exception
            'Ez badago ezer ezabatzeko ez da pasatzen hemendik bakarrik: akatsen bat dagoenean
            MsgBox("Error customer ezabatzerakoan" & vbNewLine & ex.Message)
        Finally
            If cnn1.State = ConnectionState.Open Then cnn1.Close()
        End Try
    End Sub

    Private Sub bttnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnUpdate.Click
        ' This event handler updates the price of all items with a SupplierID = 3.
        ' Then it restores the values of the same products
        'EXECUTENONQUERY - Zenbat lerro ikututa egon diren bueltatzen du. Datu basearen kontra egiten du. 
        
        Dim cmd1 As OleDbCommand
        cmd1 = New OleDbCommand("UPDATE Products SET UnitPrice = UnitPrice + 3.99  WHERE SupplierID = 3", cnn1)
        Dim rows As Integer
        Try
            cnn1.Open()
            rows = cmd1.ExecuteNonQuery
            MsgBox("Updated " & rows.ToString & " product prices")
        Catch
            MsgBox("ERROR")
        Finally
            If cnn1.State = ConnectionState.Open Then cnn1.Close()
        End Try

        cmd1 = New OleDbCommand("UPDATE Products SET UnitPrice = UnitPrice - 3.99 WHERE SupplierID = 3", cnn1)
        cnn1.Open()
        rows = cmd1.ExecuteNonQuery
        If cnn1.State = ConnectionState.Open Then cnn1.Close()
        MsgBox("Restored " & rows.ToString & " product prices")
    End Sub

    Private Sub bttnRetrieveEmployees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnRetrieveEmployees.Click
        'EXECUTEREADER - Aurrera bakarrik irakurtzen du. Ez du NEWrik.
       
        Dim SQL As String = "SELECT LastName + ' ' + FirstName, Title, " & "Extension, HomePhone FROM Employees"
        Dim cmd1 As New OleDbCommand(SQL, cnn1)
        cnn1.Open()

        Dim dr As OleDbDataReader
        dr = cmd1.ExecuteReader
        ListView1.Clear()

        'ListViiew configurazioa
        ListView1.Columns.Add("Izena", 130, HorizontalAlignment.Right)
        ListView1.Columns.Add(dr.GetName(1), 200, HorizontalAlignment.Right)
        ListView1.Columns.Add(dr.GetName(2), 100, HorizontalAlignment.Right)
        ListView1.Columns.Add("Etxeko telefonoa", 120, HorizontalAlignment.Right)
        '
        Dim z As Integer
        While dr.Read
            ListView1.Items.Add(dr.Item(0))    'lerro bat gehitzen dut - Items
            ListView1.Items(z).SubItems.Add(dr.Item(1)) 'zutabe bat gehitzen dut- SubItems
            ListView1.Items(z).SubItems.Add(dr.Item("Extension"))     'zutabe bat gehitzen dut- subitems
            ListView1.Items(z).SubItems.Add(dr.Item("HomePhone")) 'zutabe bat gehitzen dut- subitems
            If z Mod 2 = 0 Then
                'ListView1.Items(z).Font = New Font("Verdana", 10, FontStyle.Regular)
                ListView1.Items(z).BackColor = Color.DarkGray
                ' ez da ikusten bonbilagatik:Color.Aquamarine
            End If
            z += 1 'z = z + 1
        End While
        MsgBox("Read " & Me.ListView1.Items.Count & " Employee rows")
        dr.Close()
        cnn1.Close()
        '
        '
    End Sub


    Private Sub bttnRetrieveProducts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnRetrieveProducts.Click
        Dim cmd1 As New OleDbCommand
        cmd1.Connection = cnn1
        
        cmd1.CommandText = "SELECT ProductName AS Product, CategoryName AS Category, " & _
                               "CompanyName AS Supplier, UnitPrice AS Price " & _
                               "FROM Products,Categories,Suppliers WHERE " & _
                               "Products.CategoryID = Categories.CategoryID " & _
                               "and  Products.SupplierID = Suppliers.SupplierID"
        'honekin Supplier eta Categorien deskribapena lortzen dugu
        cnn1.Open()
        Dim z As Integer
        Dim dr As OleDbDataReader
        dr = cmd1.ExecuteReader
        ListView1.Clear()

        For i = 0 To dr.FieldCount - 1
            ListView1.Columns.Add(dr.GetName(i), 130, HorizontalAlignment.Right)
            ' The headers of the columns read from the database
        Next
        While dr.Read
            z = Me.ListView1.Items.Count
            ListView1.Items.Add(dr.Item("Product"))    'Lerro bat gehitzeko - Items
            ListView1.Items(z).SubItems.Add(dr.Item(1)) 'Zutabe bat gehitzeko - SubItems
            ListView1.Items(z).SubItems.Add(dr.Item("Supplier"))
            ListView1.Items(z).SubItems.Add(dr.Item("Price"))
            If z Mod 2 = 0 Then
                ListView1.Items(z).Font = New Font("Verdana", 10, FontStyle.Regular)
                ListView1.Items(z).BackColor = Color.DarkGray
            End If
        End While
        MsgBox("Read " & Me.ListView1.Items.Count & " Product rows")
        dr.Close()
        cnn1.Close()

        'While dr.Read
        '    Dim LI As New ListViewItem
        '    LI.Text = Convert.ToString(dr.Item("Product"))
        '    LI.SubItems.Add(Convert.ToString(dr.Item("Category")))
        '    LI.SubItems.Add(Convert.ToString(dr.Item("Supplier")))
        '    LI.SubItems.Add(Convert.ToString(dr.Item("Price")))
        '    ListView1.Items.Add(LI)
        '    count += 1
        'End While
        'MsgBox("Read " & count.ToString & " Product rows")
        'cnn1.Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ListView1.View = View.Details
        Me.ListView1.GridLines = True

        Me.ListView1.Anchor = AnchorStyles.Bottom + AnchorStyles.Left + _
            AnchorStyles.Right + AnchorStyles.Top
    End Sub

    Private Sub BtnParametros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnParametros.Click
        Dim cmd1 As New OleDbCommand
        cmd1.Connection = cnn1
        cmd1.CommandText = "SELECT Count(CustomerID) FROM Customers WHERE Country = @Country"
        Dim Herrialdea As String
        Herrialdea = InputBox("Sartu Herrialdea")
        cmd1.Parameters.Add("@Country", OleDbType.VarChar).Value = Herrialdea '"Italy"
        'cmd1.Parameters.AddWithValue("@Country", "Italy") 'Tb funciona con B's Beverages
        cnn1.Open()
        Dim count As Integer

        count = cmd1.ExecuteScalar
        cnn1.Close()
        MsgBox("There are " & count.ToString & " customers from " & Herrialdea)

        Dim cmd2 As New OleDbCommand
        cmd2.Connection = cnn1
        cmd2.CommandText = "SELECT Count(CustomerID) FROM Customers WHERE City = @Herria"
        Dim Herria As String
        Herria = InputBox("Sartu Herria")
        cmd2.Parameters.Add("@Herria", OleDbType.VarChar).Value = Herria '"Madrid"

        cnn1.Open()
        count = cmd2.ExecuteScalar
        cnn1.Close()
        MsgBox(count.ToString & " erregistro daude " & Herria & "  -rekin")

    End Sub

    Private Sub BtnVarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVarios.Click

        Dim i, count As Integer
        Dim cmd1 As New OleDbCommand
        cmd1.Connection = cnn1
        cmd1.CommandText = "SELECT CustomerID FROM  Customers; SELECT EmployeeID FROM Employees"
        Dim dr As OleDbDataReader = Nothing
        Try
            cnn1.Open()
            dr = cmd1.ExecuteReader
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If dr.NextResult Then
            ListView1.Clear()
            For i = 0 To dr.FieldCount - 1
                ListView1.Columns.Add(dr.GetName(i), 150, HorizontalAlignment.Right)
            Next

            While dr.Read
                Dim LI As New ListViewItem                                         ' Lerro berria gehitzeko
                LI.Text = Convert.ToString(dr.Item("CustomerID"))
                ListView1.Items.Add(LI)
                count += 1
            End While
            MsgBox("Read " & count.ToString & " rows")
            Debug.WriteLine("Read " & count.ToString & " Employee rows")
        End If
        cnn1.Close()
    End Sub

    Private Sub bttnExecSP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnExecSP.Click
        Dim customerID As String = InputBox("Please a customer's ID", "CustomerTotals Stored Procedure", "ALFKI")
        If customerID.Trim.Length = 0 Then Exit Sub
        Dim cmd1 As New OleDbCommand
        cmd1.Connection = cnn1
        ' The name of the stored procedure we want to execute through the cmd1 object
        cmd1.CommandText = "CustomerTotals"
        cmd1.CommandType = CommandType.StoredProcedure
        ' Add the appropriate parameters to the cmd1 object that will be used to
        ' execute the stored procedure.
        ' @customerID is an input parameters, which is the default parameter direction.
        cmd1.Parameters.Add("@customerID", CType(SqlDbType.VarChar, OleDbType), 5).Value = customerID
        ' @customerTotal is an output parameter
        cmd1.Parameters.AddWithValue("@customerTotal", OleDbType.Currency)
        cmd1.Parameters("@customerTotal").Direction = ParameterDirection.Output
        ' @customerItems is an output parameter
        cmd1.Parameters.AddWithValue("@customerItems", OleDbType.Integer)
        cmd1.Parameters("@customerItems").Direction = ParameterDirection.Output
        ' @orders is the stored procedure's return value
        cmd1.Parameters.AddWithValue("@orders", OleDbType.Integer)
        cmd1.Parameters("@orders").Direction = ParameterDirection.ReturnValue
        cnn1.Open()
        cmd1.ExecuteNonQuery()
        cnn1.Close()
        ' read the OUTPUT parameters and the RETURN VALUE of the stored prccedure we just executed.
        Dim orders As Integer
        Dim total As Double, items As Integer
        orders = Convert.ToInt32(cmd1.Parameters("@orders").Value)
        total = Math.Round(Convert.ToDouble(cmd1.Parameters("@customerTotal").Value), 2)
        items = Convert.ToInt32(cmd1.Parameters("@customerItems").Value)
        ' and display their values
        MsgBox("Customer BLAUS has placed " & orders.ToString & " orders " & _
                        "totaling $" & total.ToString("#,###.00") & " and " & _
                        items.ToString & " items")
    End Sub

End Class
