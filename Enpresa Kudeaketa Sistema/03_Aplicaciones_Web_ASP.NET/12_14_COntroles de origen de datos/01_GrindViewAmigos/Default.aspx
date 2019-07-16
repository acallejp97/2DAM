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
             DataFile="~/App_Data/Amigos1718.accdb" DeleteCommand="DELETE FROM [Contactos] WHERE [Id] = ?"
             InsertCommand="INSERT INTO [Contactos] ([Id], [Nombre], [Telefono], [FechaNacimiento], [Carnet], [Cuota], [Foto]) VALUES (?, ?, ?, ?, ?, ?, ?)" 
            SelectCommand="SELECT * FROM [Contactos] ORDER BY [Nombre]" 
            UpdateCommand="UPDATE [Contactos] SET [Nombre] = ?, [Telefono] = ?, [FechaNacimiento] = ?, [Carnet] = ?, [Cuota] = ?, [Foto] = ? WHERE [Id] = ?">
            <DeleteParameters>
                <asp:Parameter Name="Id" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Id" Type="Int32" />
                <asp:Parameter Name="Nombre" Type="String" />
                <asp:Parameter Name="Telefono" Type="String" />
                <asp:Parameter Name="FechaNacimiento" Type="DateTime" />
                <asp:Parameter Name="Carnet" Type="Boolean" />
                <asp:Parameter Name="Cuota" Type="Int32" />
                <asp:Parameter Name="Foto" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Nombre" Type="String" />
                <asp:Parameter Name="Telefono" Type="String" />
                <asp:Parameter Name="FechaNacimiento" Type="DateTime" />
                <asp:Parameter Name="Carnet" Type="Boolean" />
                <asp:Parameter Name="Cuota" Type="Int32" />
                <asp:Parameter Name="Foto" Type="String" />
                <asp:Parameter Name="Id" Type="Int32" />
            </UpdateParameters>
        </asp:AccessDataSource>
        <asp:Label ID="Label1" runat="server" Text="CUIDADO,Eliminar lo hace sin preguntar nada"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Con el Gridiew no podemos añadir nada"></asp:Label>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="AccessDataSource1">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                <asp:BoundField DataField="Telefono" HeaderText="Telefono" SortExpression="Telefono" />
                <asp:BoundField DataField="FechaNacimiento" HeaderText="FechaNacimiento" SortExpression="FechaNacimiento" />
                <asp:CheckBoxField DataField="Carnet" HeaderText="Carnet" SortExpression="Carnet" />
                <asp:BoundField DataField="Cuota" HeaderText="Cuota" SortExpression="Cuota" />
                <asp:BoundField DataField="Foto" HeaderText="Foto" SortExpression="Foto" />
            </Columns>
        </asp:GridView>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
