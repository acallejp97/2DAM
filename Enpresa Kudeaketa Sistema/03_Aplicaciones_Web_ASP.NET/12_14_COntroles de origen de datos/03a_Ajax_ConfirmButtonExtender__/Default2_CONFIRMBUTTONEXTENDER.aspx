<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default2_CONFIRMBUTTONEXTENDER.aspx.vb" Inherits="_Default" %><%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/Northwind_Compacta.mdb" DeleteCommand="DELETE FROM [Customers] WHERE [CustomerID] = ?" InsertCommand="INSERT INTO [Customers] ([CustomerID], [Country], [City], [CompanyName]) VALUES (?, ?, ?, ?)" SelectCommand="SELECT [CustomerID], [Country], [City], [CompanyName] FROM [Customers] ORDER BY [CustomerID]" UpdateCommand="UPDATE [Customers] SET [Country] = ?, [City] = ?, [CompanyName] = ? WHERE (([CustomerID] = ?) OR ([CustomerID] IS NULL AND ? IS NULL))">
            <DeleteParameters>
                <asp:Parameter Name="CustomerID" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="CustomerID" Type="String" />
                <asp:Parameter Name="Country" Type="String" />
                <asp:Parameter Name="City" Type="String" />
                <asp:Parameter Name="CompanyName" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Country" Type="String" />
                <asp:Parameter Name="City" Type="String" />
                <asp:Parameter Name="CompanyName" Type="String" />
                <asp:Parameter Name="CustomerID" Type="String" />
            </UpdateParameters>
        </asp:AccessDataSource>
        <br />
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </asp:ToolkitScriptManager>
        <br />
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="CustomerID" DataSourceID="AccessDataSource1">
            <Columns>
                <asp:TemplateField ShowHeader="False">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete" Text="Eliminar" TargetControlID="LinkButton1"></asp:LinkButton>
                        <asp:ConfirmButtonExtender ID="ConfirmButtonExtender1" runat="server" ConfirmText="¿Desea usted borrar?" TargetControlID="LinkButton1"></asp:ConfirmButtonExtender>



                    </ItemTemplate>
                </asp:TemplateField>
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
