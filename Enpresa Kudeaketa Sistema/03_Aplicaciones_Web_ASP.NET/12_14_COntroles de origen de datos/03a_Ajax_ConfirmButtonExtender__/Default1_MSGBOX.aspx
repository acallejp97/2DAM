<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default1_MSGBOX.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" Text="CUIDADO, el msgbox sale por detrás"></asp:Label>
        <br />
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
            DataFile="~/App_Data/Northwind_Compacta.mdb" 
            DeleteCommand="DELETE FROM [Customers] WHERE [CustomerID] = ?" 
            InsertCommand="INSERT INTO [Customers] ([CustomerID], [CompanyName], [City], [Country]) VALUES (?, ?, ?, ?)" 
            SelectCommand="SELECT [CustomerID], [CompanyName], [City], [Country] FROM [Customers]" UpdateCommand="UPDATE [Customers] SET [CompanyName] = ?, [City] = ?, [Country] = ? WHERE (([CustomerID] = ?) OR ([CustomerID] IS NULL AND ? IS NULL))">
            <DeleteParameters>
                <asp:Parameter Name="CustomerID" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="CustomerID" Type="String" />
                <asp:Parameter Name="CompanyName" Type="String" />
                <asp:Parameter Name="City" Type="String" />
                <asp:Parameter Name="Country" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="CompanyName" Type="String" />
                <asp:Parameter Name="City" Type="String" />
                <asp:Parameter Name="Country" Type="String" />
                <asp:Parameter Name="CustomerID" Type="String" />
            </UpdateParameters>
        </asp:AccessDataSource>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="CustomerID" DataSourceID="AccessDataSource1">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" />
                <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" ReadOnly="True" SortExpression="CustomerID" />
                <asp:BoundField DataField="CompanyName" HeaderText="CompanyName" SortExpression="CompanyName" />
                <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                <asp:BoundField DataField="Country" HeaderText="Country" SortExpression="Country" />
            </Columns>
        </asp:GridView>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    
    </div>
    </form>
</body>
</html>
