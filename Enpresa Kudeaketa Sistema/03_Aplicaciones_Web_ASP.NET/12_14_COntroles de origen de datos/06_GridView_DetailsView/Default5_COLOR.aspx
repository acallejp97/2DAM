<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default5_COLOR.aspx.vb" Inherits="Default5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/Northwind_Compacta.mdb" SelectCommand="SELECT [OrderID], [ProductID], [UnitPrice], [Quantity] FROM [Order Details]"></asp:AccessDataSource>
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="OrderID,ProductID" DataSourceID="AccessDataSource1">
            <Columns>
                <asp:BoundField DataField="OrderID" HeaderText="OrderID" ReadOnly="True" SortExpression="OrderID" />
                <asp:BoundField DataField="ProductID" HeaderText="ProductID" ReadOnly="True" SortExpression="ProductID" />
                <asp:BoundField DataField="UnitPrice" HeaderText="UnitPrice" SortExpression="UnitPrice" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
                <asp:TemplateField HeaderText="TOTAL">
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("UnitPrice") * Eval("Quantity") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="IMAGEN">
                    <ItemTemplate>
                        <asp:Image ID="Image1" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
