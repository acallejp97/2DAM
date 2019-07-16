<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default2.aspx.vb" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="Paises:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="AccessDataSource1" DataTextField="Country" DataValueField="Country" Font-Size="X-Large">
        </asp:DropDownList>
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/Northwind_Compacta.mdb" SelectCommand="SELECT DISTINCT [Country] FROM [Customers] ORDER BY [Country]"></asp:AccessDataSource>
        <br />
        <asp:Label ID="Label2" runat="server" Font-Size="X-Large" Text="Ciudades que empiecen por:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:AccessDataSource ID="AccessDataSource2" runat="server" DataFile="~/App_Data/Northwind_Compacta.mdb" SelectCommand="SELECT [CustomerID], [CompanyName], [City], [Country] FROM [Customers] WHERE (([Country] LIKE '%' + ? + '%') AND ([City] LIKE ? + '%')) ORDER BY [CompanyName]">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" DefaultValue="%" Name="Country" PropertyName="SelectedValue" Type="String" />
                <asp:ControlParameter ControlID="TextBox1" DefaultValue="%" Name="City" PropertyName="Text" Type="String" />
            </SelectParameters>
        </asp:AccessDataSource>
        <br />
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="CustomerID" DataSourceID="AccessDataSource2">
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
