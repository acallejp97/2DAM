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
    
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
            DataFile="~/App_Data/Northwind_Compacta.mdb" 
            SelectCommand="SELECT [CustomerID], [CompanyName], [Country], [City] FROM [Customers] ORDER BY [CustomerID]">

        </asp:AccessDataSource>
    
        <br />
        <asp:Label ID="Label1" runat="server" Text="Form View - SOLO PODEMOS VER LOS REGISTROS"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="BD, Editar Plantillas"></asp:Label>
        <br />
        <br />
        <asp:FormView ID="FormView1" runat="server" AllowPaging="True" DataKeyNames="CustomerID" DataSourceID="AccessDataSource1">
            <EditItemTemplate>
                CustomerID:
                <asp:Label ID="CustomerIDLabel1" runat="server" Text='<%# Eval("CustomerID") %>' />
                <br />
                CompanyName:
                <asp:TextBox ID="CompanyNameTextBox" runat="server" Text='<%# Bind("CompanyName") %>' />
                <br />
                Country:
                <asp:TextBox ID="CountryTextBox" runat="server" Text='<%# Bind("Country") %>' />
                <br />
                City:
                <asp:TextBox ID="CityTextBox" runat="server" Text='<%# Bind("City") %>' />
                <br />
                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Actualizar" />
                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancelar" />
            </EditItemTemplate>
            <FooterTemplate>
                <asp:Label ID="Label3" runat="server" BackColor="#FF66FF" Text="Elorrieta"></asp:Label>
            </FooterTemplate>
            <HeaderTemplate>
                <asp:Label ID="Label4" runat="server" BackColor="#00CCFF" Text="2ºDAM"></asp:Label>
            </HeaderTemplate>
            <InsertItemTemplate>
                CustomerID:
                <asp:TextBox ID="CustomerIDTextBox" runat="server" Text='<%# Bind("CustomerID") %>' />
                <br />
                CompanyName:
                <asp:TextBox ID="CompanyNameTextBox" runat="server" Text='<%# Bind("CompanyName") %>' />
                <br />
                Country:
                <asp:TextBox ID="CountryTextBox" runat="server" Text='<%# Bind("Country") %>' />
                <br />
                City:
                <asp:TextBox ID="CityTextBox" runat="server" Text='<%# Bind("City") %>' />
                <br />
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insertar" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancelar" />
            </InsertItemTemplate>
            <ItemTemplate>
                CustomerID:
                <asp:Label ID="CustomerIDLabel" runat="server" BackColor="#0066FF" Text='<%# Eval("CustomerID") %>' />
                <br />
                CompanyName:
                <asp:Label ID="CompanyNameLabel" runat="server" Text='<%# Bind("CompanyName") %>' />
                <br />
                Country:
                <asp:Label ID="CountryLabel" runat="server" Text='<%# Bind("Country") %>' />
                <br />
                City:
                <asp:Label ID="CityLabel" runat="server" Text='<%# Bind("City") %>' />
                <br />

            </ItemTemplate>
        </asp:FormView>
    
    </div>
    </form>
</body>
</html>
