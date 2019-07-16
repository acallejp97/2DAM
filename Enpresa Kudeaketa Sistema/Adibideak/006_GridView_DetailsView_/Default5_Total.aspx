<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default5_Total.aspx.vb" Inherits="Default5_Total" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/Northwind.mdb" SelectCommand="SELECT [OrderID], [ProductID], [UnitPrice], [Quantity] FROM [Order Details]"></asp:AccessDataSource>
        <br />
        <asp:Label ID="Label1" runat="server" Text="SELECT [OrderID], [ProductID], [UnitPrice], [Quantity] FROM [Order Details]"></asp:Label>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="OrderID,ProductID" DataSourceID="AccessDataSource1">
            <Columns>
                <asp:BoundField DataField="OrderID" HeaderText="OrderID" ReadOnly="True" SortExpression="OrderID" />
                <asp:BoundField DataField="ProductID" HeaderText="ProductID" ReadOnly="True" SortExpression="ProductID" />
                <asp:BoundField DataField="UnitPrice" HeaderText="UnitPrice" SortExpression="UnitPrice" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
                <asp:TemplateField HeaderText="TOTAL">
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" 
             Text='<%#String.Format("{0:C}", Eval("UnitPrice") * Eval("Quantity"))%>'></asp:Label>
                    </ItemTemplate>
                    <ItemStyle BackColor="#CC99FF" ForeColor="#009933" HorizontalAlign="Right" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="IVA%">
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" 
                         Text='<%#String.Format("{0:C}", Eval("UnitPrice") * Eval("Quantity") * (21 / 100))%>'></asp:Label>
                    </ItemTemplate>
                    <ItemStyle ForeColor="#FF0066" HorizontalAlign="Right" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="TOTAL+IVA%">
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" 
                            Text='<%#String.Format("{0:C}", Eval("UnitPrice") * Eval("Quantity") * (121 / 100))%>'></asp:Label>
                    </ItemTemplate>
                    <ItemStyle ForeColor="Maroon" HorizontalAlign="Right" />
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <br />
    
    </div>
    </form>
</body>
</html>
