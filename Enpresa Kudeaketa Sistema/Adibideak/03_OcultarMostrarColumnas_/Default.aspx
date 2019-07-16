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
    
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/Northwind_Compacta.mdb" SelectCommand="SELECT [CustomerID], [CompanyName], [City], [Country] FROM [Customers]"></asp:AccessDataSource>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="GridView1.Columns(0).Visible"></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server"></asp:Label>
        <br />
        <asp:Label ID="Label3" runat="server"></asp:Label>
        <br />
        <br />
        <asp:LinkButton ID="LinkButton1" runat="server">Aukeratzeko lotura erakutsi</asp:LinkButton>
&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton2" runat="server">CustomerID erakutsi</asp:LinkButton>
&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton3" runat="server">CompanyName erakutsi</asp:LinkButton>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="CustomerID" DataSourceID="AccessDataSource1">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" ReadOnly="True" SortExpression="CustomerID" />
                <asp:BoundField DataField="CompanyName" HeaderText="CompanyName" SortExpression="CompanyName" />
                <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                <asp:BoundField DataField="Country" HeaderText="Country" SortExpression="Country" />
            </Columns>
        </asp:GridView>
        <br />
    
    </div>
    </form>
</body>
</html>
