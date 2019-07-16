<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default2_AJAX.aspx.vb" Inherits="Default2_AJAX" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/Northwind_Compacta.mdb" 
            DeleteCommand="DELETE FROM [Customers] WHERE [CustomerID] = ?" InsertCommand="INSERT INTO [Customers] ([CustomerID], [CompanyName], [City], [Country]) VALUES (?, ?, ?, ?)" SelectCommand="SELECT [CustomerID], [CompanyName], [City], [Country] FROM [Customers]" UpdateCommand="UPDATE [Customers] SET [CompanyName] = ?, [City] = ?, [Country] = ? WHERE (([CustomerID] = ?) OR ([CustomerID] IS NULL AND ? IS NULL))">
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
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </asp:ToolkitScriptManager>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="CustomerID" DataSourceID="AccessDataSource1">
            <Columns>
                <asp:TemplateField ShowHeader="False">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete" Text="EZABATU"></asp:LinkButton>
                   
                        <asp:ConfirmButtonExtender 
                            ID="ConfirmButtonExtender1" 
                            runat="server" 
                            TargetControlID="LinkButton1" 
                            ConfirmText="Desea Borrar la Fila?">
                        </asp:ConfirmButtonExtender> 
                     </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" ReadOnly="True" SortExpression="CustomerID" />
                <asp:BoundField DataField="CompanyName" HeaderText="CompanyName" SortExpression="CompanyName" />
                <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                <asp:BoundField DataField="Country" HeaderText="Country" SortExpression="Country" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    
    </div>
    </form>
</body>
</html>
