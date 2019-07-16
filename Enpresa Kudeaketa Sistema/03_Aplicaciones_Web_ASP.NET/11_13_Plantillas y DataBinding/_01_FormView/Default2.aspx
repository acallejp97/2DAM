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
    
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/Northwind_Compacta.mdb" SelectCommand="SELECT [ProductID], [CategoryID], [ProductName], [UnitPrice] FROM [Products]"></asp:AccessDataSource>
        <br />
        <asp:FormView ID="FormView1" runat="server" AllowPaging="True" DataKeyNames="ProductID" DataSourceID="AccessDataSource1">
            <EditItemTemplate>
                ProductID:
                <asp:Label ID="ProductIDLabel1" runat="server" Text='<%# Eval("ProductID") %>' />
                <br />
                CategoryID:
                <asp:TextBox ID="CategoryIDTextBox" runat="server" Text='<%# Bind("CategoryID") %>' />
                <br />
                ProductName:
                <asp:TextBox ID="ProductNameTextBox" runat="server" Text='<%# Bind("ProductName") %>' />
                <br />
                UnitPrice:
                <asp:TextBox ID="UnitPriceTextBox" runat="server" Text='<%# Bind("UnitPrice") %>' />
                <br />
                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Actualizar" />
                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancelar" />
            </EditItemTemplate>
            <FooterTemplate>
                <asp:Label ID="Label1" runat="server" BackColor="#CC33FF" Text="Elorrieta"></asp:Label>
            </FooterTemplate>
            <HeaderTemplate>
                <asp:Label ID="Label2" runat="server" BackColor="#66FF66" Text="Buenos dias"></asp:Label>
            </HeaderTemplate>
            <InsertItemTemplate>
                CategoryID:
                <asp:TextBox ID="CategoryIDTextBox" runat="server" Text='<%# Bind("CategoryID") %>' />
                <br />
                ProductName:
                <asp:TextBox ID="ProductNameTextBox" runat="server" Text='<%# Bind("ProductName") %>' />
                <br />
                UnitPrice:
                <asp:TextBox ID="UnitPriceTextBox" runat="server" Text='<%# Bind("UnitPrice") %>' />
                <br />
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insertar" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancelar" />
            </InsertItemTemplate>
            <ItemTemplate>
                ProductID:
                <asp:Label ID="ProductIDLabel" runat="server" BackColor="#3366FF" Text='<%# Eval("ProductID") %>' />
                <br />
                CategoryID:
                <asp:Label ID="CategoryIDLabel" runat="server" BackColor="#FFCC66" Text='<%# Bind("CategoryID") %>' />
                <br />
                ProductName:
                <asp:Label ID="ProductNameLabel" runat="server" BackColor="#CC0000" Text='<%# Bind("ProductName") %>' />
                <br />
                UnitPrice:
                <asp:Label ID="UnitPriceLabel" runat="server" BackColor="#3333FF" Text='<%# Bind("UnitPrice") %>' />
                <br />

            </ItemTemplate>
        </asp:FormView>
    
    </div>
    </form>
</body>
</html>
