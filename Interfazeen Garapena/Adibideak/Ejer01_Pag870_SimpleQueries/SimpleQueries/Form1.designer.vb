<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.bttnCount = New System.Windows.Forms.Button()
        Me.bttnUpdate = New System.Windows.Forms.Button()
        Me.bttnRetrieveEmployees = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bttnInsert = New System.Windows.Forms.Button()
        Me.bttnDelete = New System.Windows.Forms.Button()
        Me.bttnRetrieveProducts = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.bttnConnectCN = New System.Windows.Forms.Button()
        Me.bttnExecSP = New System.Windows.Forms.Button()
        Me.Ofd = New System.Windows.Forms.OpenFileDialog()
        Me.BtnParametros = New System.Windows.Forms.Button()
        Me.BtnVarios = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bttnCount
        '
        Me.bttnCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnCount.Location = New System.Drawing.Point(2, 118)
        Me.bttnCount.Name = "bttnCount"
        Me.bttnCount.Size = New System.Drawing.Size(351, 36)
        Me.bttnCount.TabIndex = 0
        Me.bttnCount.Text = "Count Customers                           [ExecuteScalar]"
        Me.bttnCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttnCount.UseVisualStyleBackColor = True
        '
        'bttnUpdate
        '
        Me.bttnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnUpdate.Location = New System.Drawing.Point(2, 232)
        Me.bttnUpdate.Name = "bttnUpdate"
        Me.bttnUpdate.Size = New System.Drawing.Size(351, 36)
        Me.bttnUpdate.TabIndex = 1
        Me.bttnUpdate.Text = "Update Prices                            [ExecuteNonQuery]"
        Me.bttnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttnUpdate.UseVisualStyleBackColor = True
        '
        'bttnRetrieveEmployees
        '
        Me.bttnRetrieveEmployees.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnRetrieveEmployees.Location = New System.Drawing.Point(2, 270)
        Me.bttnRetrieveEmployees.Name = "bttnRetrieveEmployees"
        Me.bttnRetrieveEmployees.Size = New System.Drawing.Size(351, 36)
        Me.bttnRetrieveEmployees.TabIndex = 2
        Me.bttnRetrieveEmployees.Text = "Eskuratu Employees                     [ExecuteReader]"
        Me.bttnRetrieveEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttnRetrieveEmployees.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-121, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(909, 33)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Executing Basic Queries with the Command Object"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bttnInsert
        '
        Me.bttnInsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnInsert.Location = New System.Drawing.Point(2, 156)
        Me.bttnInsert.Name = "bttnInsert"
        Me.bttnInsert.Size = New System.Drawing.Size(351, 36)
        Me.bttnInsert.TabIndex = 4
        Me.bttnInsert.Text = "Insert New Customers             [ExecuteNonQuery]"
        Me.bttnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttnInsert.UseVisualStyleBackColor = True
        '
        'bttnDelete
        '
        Me.bttnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnDelete.Location = New System.Drawing.Point(2, 194)
        Me.bttnDelete.Name = "bttnDelete"
        Me.bttnDelete.Size = New System.Drawing.Size(351, 36)
        Me.bttnDelete.TabIndex = 5
        Me.bttnDelete.Text = "Delete Customers                    [ExecuteNonQuery]"
        Me.bttnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttnDelete.UseVisualStyleBackColor = True
        '
        'bttnRetrieveProducts
        '
        Me.bttnRetrieveProducts.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnRetrieveProducts.Location = New System.Drawing.Point(2, 308)
        Me.bttnRetrieveProducts.Name = "bttnRetrieveProducts"
        Me.bttnRetrieveProducts.Size = New System.Drawing.Size(351, 36)
        Me.bttnRetrieveProducts.TabIndex = 6
        Me.bttnRetrieveProducts.Text = "Eskuratu Products                        [ExecuteReader]"
        Me.bttnRetrieveProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttnRetrieveProducts.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.BackColor = System.Drawing.Color.Azure
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.ForeColor = System.Drawing.Color.Maroon
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(377, 42)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(609, 467)
        Me.ListView1.TabIndex = 7
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'bttnConnectCN
        '
        Me.bttnConnectCN.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnConnectCN.Location = New System.Drawing.Point(2, 42)
        Me.bttnConnectCN.Name = "bttnConnectCN"
        Me.bttnConnectCN.Size = New System.Drawing.Size(351, 36)
        Me.bttnConnectCN.TabIndex = 8
        Me.bttnConnectCN.Text = "Connect to Database                  [ConnectionString]"
        Me.bttnConnectCN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttnConnectCN.UseVisualStyleBackColor = True
        '
        'bttnExecSP
        '
        Me.bttnExecSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnExecSP.Location = New System.Drawing.Point(2, 427)
        Me.bttnExecSP.Name = "bttnExecSP"
        Me.bttnExecSP.Size = New System.Drawing.Size(351, 36)
        Me.bttnExecSP.TabIndex = 10
        Me.bttnExecSP.Text = "Execute Stored Procedure       [ExecuteNonQuery]"
        Me.bttnExecSP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttnExecSP.UseVisualStyleBackColor = True
        '
        'Ofd
        '
        Me.Ofd.FileName = "OpenFileDialog1"
        '
        'BtnParametros
        '
        Me.BtnParametros.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnParametros.Location = New System.Drawing.Point(2, 350)
        Me.BtnParametros.Name = "BtnParametros"
        Me.BtnParametros.Size = New System.Drawing.Size(351, 33)
        Me.BtnParametros.TabIndex = 11
        Me.BtnParametros.Text = "Count Customers - Parametroekin"
        Me.BtnParametros.UseVisualStyleBackColor = True
        '
        'BtnVarios
        '
        Me.BtnVarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVarios.Location = New System.Drawing.Point(2, 469)
        Me.BtnVarios.Name = "BtnVarios"
        Me.BtnVarios.Size = New System.Drawing.Size(351, 33)
        Me.BtnVarios.TabIndex = 12
        Me.BtnVarios.Text = "Irakurri datu multzo batzuk"
        Me.BtnVarios.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 514)
        Me.Controls.Add(Me.BtnVarios)
        Me.Controls.Add(Me.BtnParametros)
        Me.Controls.Add(Me.bttnExecSP)
        Me.Controls.Add(Me.bttnConnectCN)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.bttnRetrieveProducts)
        Me.Controls.Add(Me.bttnDelete)
        Me.Controls.Add(Me.bttnInsert)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bttnRetrieveEmployees)
        Me.Controls.Add(Me.bttnUpdate)
        Me.Controls.Add(Me.bttnCount)
        Me.Name = "Form1"
        Me.Text = "Executing Simple Queries"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bttnCount As System.Windows.Forms.Button
    Friend WithEvents bttnUpdate As System.Windows.Forms.Button
    Friend WithEvents bttnRetrieveEmployees As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bttnInsert As System.Windows.Forms.Button
    Friend WithEvents bttnDelete As System.Windows.Forms.Button
    Friend WithEvents bttnRetrieveProducts As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents bttnConnectCN As System.Windows.Forms.Button
    Friend WithEvents bttnExecSP As System.Windows.Forms.Button
    Friend WithEvents Ofd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BtnParametros As System.Windows.Forms.Button
    Friend WithEvents BtnVarios As System.Windows.Forms.Button

End Class
