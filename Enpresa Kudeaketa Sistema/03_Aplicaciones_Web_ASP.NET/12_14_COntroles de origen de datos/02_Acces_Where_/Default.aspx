<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="PAIS: "></asp:Label>
        <asp:TextBox ID="txtPais" runat="server"></asp:TextBox>
        <br />
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/Northwind_Compacta.mdb" SelectCommand="SELECT [CustomerID], [CompanyName], [City], [Country] FROM [Customers] WHERE ([Country] LIKE '%' + ? + '%') ORDER BY [Country], [City], [CompanyName]">
            <SelectParameters>
                <asp:ControlParameter ControlID="txtPais" DefaultValue="%" Name="Country" PropertyName="Text" Type="String" />
            </SelectParameters>
        </asp:AccessDataSource>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="CustomerID" DataSourceID="AccessDataSource1">
            <Columns>
                <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" ReadOnly="True" SortExpression="CustomerID" />
                <asp:BoundField DataField="CompanyName" HeaderText="CompanyName" SortExpression="CompanyName" />
                <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                <asp:BoundField DataField="Country" HeaderText="Country" SortExpression="Country" />
            </Columns>
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
