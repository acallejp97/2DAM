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
    
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="CUIDADO, el msgbox sale por detrás"></asp:Label>
        <br />
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/Northwind_Compacta.mdb" 
            DeleteCommand="DELETE FROM [Customers] WHERE [CustomerID] = ?"
            InsertCommand="INSERT INTO [Customers] ([CustomerID], [CompanyName], [Country], [City]) VALUES (?, ?, ?, ?)" 
            SelectCommand="SELECT [CustomerID], [CompanyName], [Country], [City] FROM [Customers]" UpdateCommand="UPDATE [Customers] SET [CompanyName] = ?, [Country] = ?, [City] = ? WHERE (([CustomerID] = ?) OR ([CustomerID] IS NULL AND ? IS NULL))">
            <DeleteParameters>
                <asp:Parameter Name="CustomerID" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="CustomerID" Type="String" />
                <asp:Parameter Name="CompanyName" Type="String" />
                <asp:Parameter Name="Country" Type="String" />
                <asp:Parameter Name="City" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="CompanyName" Type="String" />
                <asp:Parameter Name="Country" Type="String" />
                <asp:Parameter Name="City" Type="String" />
                <asp:Parameter Name="CustomerID" Type="String" />
            </UpdateParameters>
        </asp:AccessDataSource>
        <br />
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="CustomerID" DataSourceID="AccessDataSource1">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" />
                <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" ReadOnly="True" SortExpression="CustomerID" />
                <asp:BoundField DataField="CompanyName" HeaderText="CompanyName" SortExpression="CompanyName" />
                <asp:BoundField DataField="Country" HeaderText="Country" SortExpression="Country" />
                <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    
    </div>
    </form>
</body>
</html>
