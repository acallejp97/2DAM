<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
            DataFile="~/App_Data/Northwind_Compacta.mdb" 
            DeleteCommand="DELETE FROM [Customers] WHERE (([CustomerID] = ?) OR ([CustomerID] IS NULL AND ? IS NULL))" 
            InsertCommand="INSERT INTO [Customers] ([CustomerID], [CompanyName], [Country], [City]) VALUES (?, ?, ?, ?)" 
            SelectCommand="SELECT [CustomerID], [CompanyName], [Country], [City] FROM [Customers]" 
            UpdateCommand="UPDATE [Customers] SET [CompanyName] = ?, [Country] = ?, [City] = ? WHERE (([CustomerID] = ?) OR ([CustomerID] IS NULL AND ? IS NULL))">
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
        <asp:Label ID="Label3" runat="server" Text="BD, Editar Plantillas."></asp:Label>
        <br />
        <asp:Label ID="Label4" runat="server" 
            Text="SELECT [CustomerID], [CompanyName], [Country], [City] FROM [Customers]"></asp:Label>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Solo podemos VER"></asp:Label>
        <br />
        <br />
        <br />
        <asp:FormView ID="FormView1" runat="server" AllowPaging="True" 
            DataKeyNames="CustomerID" DataSourceID="AccessDataSource1">
            <EditItemTemplate>
                CustomerID:
                <asp:Label ID="CustomerIDLabel1" runat="server" 
                    Text='<%# Eval("CustomerID") %>' />
                <br />
                CompanyName:
                <asp:TextBox ID="CompanyNameTextBox" runat="server" 
                    Text='<%# Bind("CompanyName") %>' />
                <br />
                Country:
                <asp:TextBox ID="CountryTextBox" runat="server" Text='<%# Bind("Country") %>' />
                <br />
                City:
                <asp:TextBox ID="CityTextBox" runat="server" Text='<%# Bind("City") %>' />
                <br />
                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" 
                    CommandName="Update" Text="Actualizar" />
                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" 
                    CausesValidation="False" CommandName="Cancel" Text="Cancelar" />
            </EditItemTemplate>
            <FooterTemplate>
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Italic="True" 
                    ForeColor="#FF6600" Text="Elorrieta"></asp:Label>
            </FooterTemplate>
            <HeaderTemplate>
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" 
                    ForeColor="#000099" Text="2ºDAM-SGE"></asp:Label>
            </HeaderTemplate>
            <InsertItemTemplate>
                CustomerID:
                <asp:TextBox ID="CustomerIDTextBox" runat="server" 
                    Text='<%# Bind("CustomerID") %>' />
                <br />
                CompanyName:
                <asp:TextBox ID="CompanyNameTextBox" runat="server" 
                    Text='<%# Bind("CompanyName") %>' />
                <br />
                Country:
                <asp:TextBox ID="CountryTextBox" runat="server" Text='<%# Bind("Country") %>' />
                <br />
                City:
                <asp:TextBox ID="CityTextBox" runat="server" Text='<%# Bind("City") %>' />
                <br />
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" 
                    CommandName="Insert" Text="Insertar" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" 
                    CausesValidation="False" CommandName="Cancel" Text="Cancelar" />
            </InsertItemTemplate>
            <ItemTemplate>
                CustomerID.....:
                <asp:Label ID="CustomerIDLabel" runat="server" Font-Bold="True" 
                    ForeColor="#00CC00" Text='<%# Eval("CustomerID") %>' />
                <br />
                CompanyName:
                <asp:Label ID="CompanyNameLabel" runat="server" 
                    Text='<%# Bind("CompanyName") %>' ForeColor="#000099" />
                <br />
                Country............:
                <asp:Label ID="CountryLabel" runat="server" Text='<%# Bind("Country") %>' />
                <br />
                City..................:
                <asp:Label ID="CityLabel" runat="server" Text='<%# Bind("City") %>' />
                <br />

            </ItemTemplate>
        </asp:FormView>
    
    </div>
    </form>
</body>
</html>
