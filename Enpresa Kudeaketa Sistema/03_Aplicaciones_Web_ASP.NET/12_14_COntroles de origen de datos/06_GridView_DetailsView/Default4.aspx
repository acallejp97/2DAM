<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default4.aspx.vb" Inherits="Default4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="TABLA ORDER DETAILS"></asp:Label>
        <br />
        <br />
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/Northwind_Compacta.mdb" DeleteCommand="DELETE FROM [OrderDetails] WHERE (([OrderID] = ?) OR ([OrderID] IS NULL AND ? IS NULL)) AND [ProductID] = ?" InsertCommand="INSERT INTO [OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity]) VALUES (?, ?, ?, ?)" SelectCommand="SELECT [OrderID], [ProductID], [UnitPrice], [Quantity] FROM [OrderDetails]" UpdateCommand="UPDATE [OrderDetails] SET [UnitPrice] = ?, [Quantity] = ? WHERE (([OrderID] = ?) OR ([OrderID] IS NULL AND ? IS NULL)) AND [ProductID] = ?">
            <DeleteParameters>
                <asp:Parameter Name="OrderID" Type="Int32" />
                <asp:Parameter Name="ProductID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="OrderID" Type="Int32" />
                <asp:Parameter Name="ProductID" Type="Int32" />
                <asp:Parameter Name="UnitPrice" Type="Decimal" />
                <asp:Parameter Name="Quantity" Type="Int16" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="UnitPrice" Type="Decimal" />
                <asp:Parameter Name="Quantity" Type="Int16" />
                <asp:Parameter Name="OrderID" Type="Int32" />
                <asp:Parameter Name="ProductID" Type="Int32" />
            </UpdateParameters>
        </asp:AccessDataSource>
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="OrderID,ProductID" DataSourceID="AccessDataSource1">
            <Columns>
                <asp:BoundField DataField="OrderID" HeaderText="OrderID" ReadOnly="True" SortExpression="OrderID" />
                <asp:BoundField DataField="ProductID" HeaderText="ProductID" ReadOnly="True" SortExpression="ProductID" />
                <asp:BoundField DataField="UnitPrice" HeaderText="UnitPrice" SortExpression="UnitPrice" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
                <asp:TemplateField HeaderText="TOTAL">
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("UnitPrice")* Eval("Quantity") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Dentro de la cabecera TOTAL tenemos el label3"></asp:Label>
    
    </div>
    </form>
</body>
</html>
