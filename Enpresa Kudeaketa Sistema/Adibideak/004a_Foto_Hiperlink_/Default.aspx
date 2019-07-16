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
    
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/Amigos.accdb" SelectCommand="SELECT * FROM [Contactos_local]"></asp:AccessDataSource>
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="AccessDataSource1">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                <asp:BoundField DataField="Telefono" HeaderText="Telefono" SortExpression="Telefono" />
                <asp:BoundField DataField="FechaNacimiento" DataFormatString="{0:d}" HeaderText="FechaNacimiento" SortExpression="FechaNacimiento" />
                <asp:CheckBoxField DataField="Carnet" HeaderText="Carnet" SortExpression="Carnet" />
                <asp:BoundField DataField="Cuota" DataFormatString="{0:c}" HeaderText="Cuota" SortExpression="Cuota" />
                <asp:ImageField DataImageUrlField="Foto" DataImageUrlFormatString="~/Imagenes/{0}" HeaderText="Argazkiak">
                    <ControlStyle Height="30px" Width="30px" />
                    <ItemStyle HorizontalAlign="Center" />
                </asp:ImageField>
                <asp:HyperLinkField DataNavigateUrlFields="Url" DataTextField="Url" HeaderText="Pag Web" />
            </Columns>
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
