Imports System.Data.OleDb
Public Class Form6_NO
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button5 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(109, 179)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(147, 23)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Púlseme el quinto"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(109, 143)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(147, 23)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Púlseme el cuarto"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(109, 107)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(147, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Púlseme el segundo"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(109, 71)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(187, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Púlseme el primero y el tercero"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(56, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(320, 24)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Relations, un DataSet con dos tablas."
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(112, 224)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(144, 24)
        Me.Button5.TabIndex = 13
        Me.Button5.Text = "Ultimo Pulse   Order ID: "
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 296)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(440, 24)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Hay dos Adaptadores, cada uno con un selectcommand (sql) diferente."
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 328)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(440, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Ambos adaptadores llenan un DataSet que va a  tener 2 tablas."
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 352)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(440, 16)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Funciona aunque la Tabla de northwind esté abierta."
        '
        'Form6
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(640, 390)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form6"
        Me.Text = "Form6"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim das1 As New DataSet
    Dim cnn1 As New OleDbConnection

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Tabla Orders
        cnn1.ConnectionString = KonexioKatea
        Dim sql1 As String = "SELECT OrderID, OrderDate FROM Orders "
        Dim dap1 As New OleDbDataAdapter(sql1, cnn1)
        dap1.Fill(das1, "Orders")
        'Dim cmd1 As New OleDbCommand(sql1, cnn1) 'TB funciona
        'dap1.SelectCommand = cmd1 'TB funciona
        'dap1.Fill(das1, "Orders")

        Button1.Size = New Size(225, Button1.Height)
        Button1.Left = 85

        Button2.Size = New System.Drawing.Size(Button1.Width, Button2.Height)
        Button2.Left = Button1.Left
        Button3.Size = New System.Drawing.Size(Button1.Width, Button3.Height)
        Button3.Left = Button1.Left
        Button4.Size = New System.Drawing.Size(Button1.Width, Button4.Height)
        Button4.Left = Button1.Left
        Button5.Size = New System.Drawing.Size(Button1.Width, Button4.Height)
        Button5.Left = Button1.Left
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim tbl1 As DataTable
        For Each tbl1 In das1.Tables
            MsgBox(tbl1.TableName & " tiene " & _
                tbl1.Columns.Count.ToString & " columnas" & _
                " and " & tbl1.Rows.Count & " filas.", , "Metadatos de Das1")
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Tabla Order Details
        Dim sql1 As String = _
        "SELECT OrderID, ProductID, UnitPrice, Quantity, Discount FROM [Order Details]"
        Dim dap2 As OleDbDataAdapter
        dap2 = New OleDbDataAdapter(sql1, cnn1)
        dap2.Fill(das1, "OrderDetails")
        'Dim cmd1 As New OleDbCommand(sql1, cnn1)
        'dap2.SelectCommand = cmd1
        'dap2.Fill(das1, "OrderDetails")
        ' Tenemos un das1 DataSet con dos tablas: "Orders" y "OrderDetails"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim parentcol As DataColumn = das1.Tables("Orders").Columns("OrderID")
        Dim childcol As DataColumn = das1.Tables("OrderDetails").Columns("OrderID")

        Dim drl1 As DataRelation
        drl1 = New DataRelation("OrdersOrderDetails", parentcol, childcol)

        das1.Relations.Add(drl1)
        'Define las columnas padre e hijo de un objeto DataRelation
        'Creamos un nuevo objeto DataRelation  llamado  "OrdersOrderDetails"
        'Añade el objeto DataRelation a la colección Relations de das1
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim drl1 As DataRelation = das1.Relations("OrdersOrderDetails")

        Dim tbl1 As DataTable = drl1.ParentTable 'Apunta a la tabla padre ("Orders")

        Dim drw1 As DataRow
        Dim ary_Rows() As DataRow
        Dim x, y, z As Double

        drw1 = tbl1.Rows(1) 'Fila del segundo registro Ver pagina 268 drw1=10249 y ...
        'MessageBox.Show(drw1(0) & " " & drw1(1)) 'campos  OrderID, OrderDate
        'Dim str1 As String = "SELECT OrderID, OrderDate FROM Orders " 'en LOAD

        MessageBox.Show("Número de filas de Orders (Padre): " & tbl1.Rows.Count)

        'Buscamos los reg HIJOS DE DRW1 ...
        ary_Rows = drw1.GetChildRows(tbl1.ChildRelations("OrdersOrderDetails"))

        For x = 0 To ary_Rows.GetUpperBound(0)
            z += ary_Rows(x)(2) * ary_Rows(x)(3) * (1 - ary_Rows(x)(4))
        Next
        'ary_Rows(x)(2) el campo UnitPrice
        'ary_Rows(x)(3) el campo Quantity
        'ary_Rows(x)(4) el campo Discount

        y = drw1(0) ' y = drw1("OrderID")

        MsgBox("Precio extendido = " & String.Format("{0:#,###,##0.00}", z) & " para Order ID " & _
            y.ToString & ".", , "Valor calculado de la tabla hijo.")

    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim drl1 As DataRelation = das1.Relations("OrdersOrderDetails")
        Dim tbl1 As DataTable = drl1.ParentTable 'Apunta a la tabla padre ("Orders")

        Dim drw1 As DataRow = Nothing
        Dim ary_Rows() As DataRow
        Dim int1, int2, orderid, x As Integer
        Dim dec1 As Decimal
        Dim existe As Boolean = False

        orderid = InputBox("Introduce un Order ID", "Precio", 10249)
        For x = 0 To tbl1.Rows.Count - 1
            drw1 = tbl1.Rows(x) 'por cada fila
            If drw1("OrderID") = orderid Then 'recorro la relacion hija
                ary_Rows = drw1.GetChildRows(tbl1.ChildRelations(0))
                For int1 = 0 To ary_Rows.GetUpperBound(0)
                    dec1 += ary_Rows(int1)(2) * _
                        ary_Rows(int1)(3) * (1 - ary_Rows(int1)(4))
                Next
                existe = True
                Exit For
            End If
        Next

        'Dim str1 As String = 
        '"SELECT OrderID-0, ProductID-1, UnitPrice-2, Quantity-3, Discount-4 
        'FROM [Order Details]" Campos del For anterior.

        If existe Then
            int2 = drw1(0)   ' int2 = drw1("OrderID")
            MsgBox("Extended Price = " & dec1.ToString & " for Order ID " & _
                int2.ToString & ".", , "Computed value from Child Table")
        Else
            MsgBox("No existe ese OrderID")
        End If

    End Sub
End Class
