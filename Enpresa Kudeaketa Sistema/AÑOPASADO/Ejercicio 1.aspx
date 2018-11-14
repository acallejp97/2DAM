<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Ejercicio 1.aspx.vb" Inherits="Ejercicio_1" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    <br />
</p>
<p>
    <asp:Label ID="Label1" runat="server" Text="Paises: "></asp:Label>
    <asp:DropDownList ID="DropDownList1" runat="server" 
        DataSourceID="AccessDataSource1" DataTextField="Country" 
        DataValueField="Country" AutoPostBack="True">
    </asp:DropDownList>
    <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
        DataFile="~/App_Data/Northwind_Compacta.mdb" 
        
        SelectCommand="SELECT DISTINCT [Country] FROM [Customers] ORDER BY [Country]">
    </asp:AccessDataSource>
</p>
<p>
    <asp:Label ID="Label2" runat="server" Text="Ciudad: "></asp:Label>
    <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" 
        DataSourceID="AccessDataSource2" DataTextField="City" DataValueField="City">
    </asp:DropDownList>
    <asp:AccessDataSource ID="AccessDataSource2" runat="server" 
        DataFile="~/App_Data/Northwind_Compacta.mdb" 
        
        SelectCommand="SELECT DISTINCT [City] FROM [Customers] WHERE ([Country] = ?) ORDER BY [City]">
        <SelectParameters>
            <asp:ControlParameter ControlID="DropDownList1" Name="Country" 
                PropertyName="SelectedValue" Type="String" />
        </SelectParameters>
    </asp:AccessDataSource>
</p>
<p>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="CustomerID" DataSourceID="AccessDataSource3" CellPadding="4" 
        ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" 
                ShowSelectButton="True" />
            <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" ReadOnly="True" 
                SortExpression="CustomerID" />
            <asp:BoundField DataField="CompanyName" HeaderText="CompanyName" 
                SortExpression="CompanyName" HtmlEncode="False" />
            <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" 
                HtmlEncode="False" />
            <asp:BoundField DataField="Country" HeaderText="Country" 
                SortExpression="Country" HtmlEncode="False" />
        </Columns>
        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
        <SortedAscendingCellStyle BackColor="#FDF5AC" />
        <SortedAscendingHeaderStyle BackColor="#4D0000" />
        <SortedDescendingCellStyle BackColor="#FCF6C0" />
        <SortedDescendingHeaderStyle BackColor="#820000" />
    </asp:GridView>
    <asp:AccessDataSource ID="AccessDataSource3" runat="server" 
        DataFile="~/App_Data/Northwind_Compacta.mdb" 
        DeleteCommand="DELETE FROM [Customers] WHERE (([CustomerID] = ?) OR ([CustomerID] IS NULL AND ? IS NULL))" 
        InsertCommand="INSERT INTO [Customers] ([CustomerID], [CompanyName], [City], [Country]) VALUES (?, ?, ?, ?)" 
        SelectCommand="SELECT [CustomerID], [CompanyName], [City], [Country] FROM [Customers] WHERE ([City] = ?)" 
        
        UpdateCommand="UPDATE [Customers] SET [CompanyName] = ?, [City] = ?, [Country] = ? WHERE (([CustomerID] = ?) OR ([CustomerID] IS NULL AND ? IS NULL))">
        <DeleteParameters>
            <asp:Parameter Name="CustomerID" Type="String" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="CustomerID" Type="String" />
            <asp:Parameter Name="CompanyName" Type="String" />
            <asp:Parameter Name="City" Type="String" />
            <asp:Parameter Name="Country" Type="String" />
        </InsertParameters>
        <SelectParameters>
            <asp:ControlParameter ControlID="DropDownList2" DefaultValue="0" Name="City" 
                PropertyName="SelectedValue" Type="String" />
        </SelectParameters>
        <UpdateParameters>
            <asp:Parameter Name="CompanyName" Type="String" />
            <asp:Parameter Name="City" Type="String" />
            <asp:Parameter Name="Country" Type="String" />
            <asp:Parameter Name="CustomerID" Type="String" />
        </UpdateParameters>
    </asp:AccessDataSource>
</p>
<p>
    <asp:Label ID="Label3" runat="server" Text="City:"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Label ID="Label4" runat="server" Text="Country:"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Label ID="Label5" runat="server" Text="CompanyName:"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
</p>
</asp:Content>

