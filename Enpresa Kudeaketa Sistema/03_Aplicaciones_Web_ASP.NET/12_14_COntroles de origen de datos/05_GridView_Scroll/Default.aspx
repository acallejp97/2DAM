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
    
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/Northwind_Compacta.mdb" SelectCommand="SELECT * FROM [Customers]"></asp:AccessDataSource>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Añado un div, coloco dentro el GridView,"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Utilizo la propiedad Styles del DIV"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="(Overflow:auto, Height:Width)"></asp:Label>
        <br />
        <br />
        <div style="width: 500px; height: 400px; overflow: auto">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="CustomerID" DataSourceID="AccessDataSource1">
                <Columns>
                    <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" ReadOnly="True" SortExpression="CustomerID" />
                    <asp:BoundField DataField="CompanyName" HeaderText="CompanyName" SortExpression="CompanyName" />
                    <asp:BoundField DataField="ContactName" HeaderText="ContactName" SortExpression="ContactName" />
                    <asp:BoundField DataField="ContactTitle" HeaderText="ContactTitle" SortExpression="ContactTitle" />
                    <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
                    <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                    <asp:BoundField DataField="Region" HeaderText="Region" SortExpression="Region" />
                    <asp:BoundField DataField="PostalCode" HeaderText="PostalCode" SortExpression="PostalCode" />
                    <asp:BoundField DataField="Country" HeaderText="Country" SortExpression="Country" />
                    <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" />
                    <asp:BoundField DataField="Fax" HeaderText="Fax" SortExpression="Fax" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
    </form>
</body>
</html>
