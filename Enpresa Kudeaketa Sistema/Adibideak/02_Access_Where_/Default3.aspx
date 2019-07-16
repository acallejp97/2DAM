<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default3.aspx.vb" Inherits="Default3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="Herriak:"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="AccessDataSource1" DataTextField="Country" DataValueField="Country" Font-Size="X-Large">
        </asp:DropDownList>
        <br />
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/Northwind_Compacta.mdb" SelectCommand="SELECT DISTINCT [Country] FROM [Customers] ORDER BY [Country]"></asp:AccessDataSource>
        <br />
        <asp:Label ID="Label2" runat="server" Font-Size="X-Large" Text="Hiriak:"></asp:Label>
        <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" DataSourceID="AccessDataSource2" DataTextField="City" DataValueField="City" Font-Size="X-Large" style="margin-bottom: 0px">
        </asp:DropDownList>
        <br />
        <asp:AccessDataSource ID="AccessDataSource2" runat="server" DataFile="~/App_Data/Northwind_Compacta.mdb" SelectCommand="SELECT DISTINCT [City] FROM [Customers] WHERE ([Country] LIKE '%' + ? + '%') ORDER BY [City]">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" Name="Country" PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
        </asp:AccessDataSource>
        <br />
        <asp:AccessDataSource ID="AccessDataSource4" runat="server" DataFile="~/App_Data/Northwind_Compacta.mdb" SelectCommand="SELECT [CustomerID], [CompanyName], [City], [Country] FROM [Customers] WHERE (([Country] LIKE '%' + ? + '%') AND ([City] LIKE '%' + ? + '%'))">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" Name="Country" PropertyName="SelectedValue" Type="String" />
                <asp:ControlParameter ControlID="DropDownList2" Name="City" PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
        </asp:AccessDataSource>
        <br />
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="CustomerID" DataSourceID="AccessDataSource4">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" ReadOnly="True" SortExpression="CustomerID" />
                <asp:BoundField DataField="CompanyName" HeaderText="CompanyName" HtmlEncode="False" SortExpression="CompanyName" />
                <asp:BoundField DataField="City" HeaderText="City" HtmlEncode="False" SortExpression="City" />
                <asp:BoundField DataField="Country" HeaderText="Country" HtmlEncode="False" SortExpression="Country" />
            </Columns>
            <SelectedRowStyle BackColor="#CCFF99" />
        </asp:GridView>
    
    </div>
        <p>
            <asp:Label ID="Label3" runat="server" Text="City"></asp:Label>
            :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="Label4" runat="server" Text="Country:"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;<p>
            <asp:Label ID="Label5" runat="server" Text="Company Name:"></asp:Label>
&nbsp;
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </p>
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
