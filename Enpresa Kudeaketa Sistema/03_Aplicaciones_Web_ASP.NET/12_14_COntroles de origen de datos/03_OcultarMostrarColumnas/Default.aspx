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
    
        <asp:Label ID="Label1" runat="server" Text="GridView1.Colums(0).Visible"></asp:Label>
        <br />
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/Northwind_Compacta.mdb" SelectCommand="SELECT [CustomerID], [CompanyName], [Country], [City] FROM [Customers] ORDER BY [CustomerID]"></asp:AccessDataSource>
        <br />
        <asp:LinkButton ID="LinkButton1" runat="server" Font-Size="X-Large">Ocultar Seleccion</asp:LinkButton>
&nbsp;&nbsp;&nbsp;
        <br />
        <asp:LinkButton ID="LinkButton2" runat="server" Font-Size="X-Large">Ocultar CustomerID</asp:LinkButton>
&nbsp;&nbsp;
        <br />
        <asp:LinkButton ID="LinkButton3" runat="server" Font-Size="X-Large">Ocultar CompanyName</asp:LinkButton>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="CustomerID" DataSourceID="AccessDataSource1">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" ReadOnly="True" SortExpression="CustomerID" />
                <asp:BoundField DataField="CompanyName" HeaderText="CompanyName" SortExpression="CompanyName" />
                <asp:BoundField DataField="Country" HeaderText="Country" SortExpression="Country" />
                <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
            </Columns>
        </asp:GridView>
        <br />
    
    </div>
    </form>
</body>
</html>
