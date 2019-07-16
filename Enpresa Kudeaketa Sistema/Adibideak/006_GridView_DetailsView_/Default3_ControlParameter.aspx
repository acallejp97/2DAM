<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default3_ControlParameter.aspx.vb" Inherits="Default3_ControlParameter" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="ID (autonumerico)"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Button ID="btnBorrar" runat="server" Text="BORRAR" />
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </asp:ToolkitScriptManager>
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Nombre"></asp:Label>
&nbsp;<asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label4" runat="server" Text="Telefono"></asp:Label>
        <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Foto"></asp:Label>
        <asp:TextBox ID="txtFoto" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label6" runat="server" Text="Cuota"></asp:Label>
        <asp:TextBox ID="txtCuota" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="CheckBox1" runat="server" Text="Carnet" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label7" runat="server" Text="Fecha de Nacimiento"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtFecha" runat="server"></asp:TextBox>
        <asp:CalendarExtender ID="txtFecha_CalendarExtender" runat="server" Enabled="True" Format="dd/MM/yyyy" TargetControlID="txtFecha">
        </asp:CalendarExtender>
&nbsp;
        <asp:Label ID="Label8" runat="server" Text="He añadido un AJAX_CalendarExtender"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Button ID="btnInsertar" runat="server" Text="INSERTAR" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnModificar" runat="server" Text="MODIFICAR" />
        <br />
        <br />
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/Amigos.accdb" 
            DeleteCommand="DELETE FROM [Contactos_local] WHERE [Id] = ?" 
            InsertCommand="INSERT INTO [Contactos_local] ( [Nombre], [Telefono], [FechaNacimiento], [Carnet], [Cuota], [Foto]) VALUES ( ?, ?, ?, ?, ?, ?)" 
            SelectCommand="SELECT * FROM [Contactos_local]" 
            UpdateCommand="UPDATE [Contactos_local] SET [Nombre] = ?, [Telefono] = ?, [FechaNacimiento] = ?, [Carnet] = ?, [Cuota] = ?, [Foto] = ? WHERE [Id] = ?">
            <DeleteParameters>
                <asp:ControlParameter Name="Id" Type="Int32" ControlID="txtID" />
            </DeleteParameters>
            <InsertParameters>
                <asp:ControlParameter Name="Nombre" Type="String" ControlID="txtNombre" />
                <asp:ControlParameter Name="Telefono" Type="String" ControlID="txtTelefono" />
                <asp:ControlParameter Name="FechaNacimiento" Type="DateTime" ControlID="txtFecha" />
                <asp:ControlParameter Name="Carnet" Type="Boolean" ControlID="checkbox1" />
                <asp:ControlParameter Name="Cuota" Type="Double" ControlID="txtCuota" />
                <asp:ControlParameter Name="Foto" Type="String" ControlID="txtFoto" />
             </InsertParameters>
            <UpdateParameters>
                <asp:ControlParameter Name="Nombre" Type="String" ControlID="txtNombre" />
                <asp:ControlParameter Name="Telefono" Type="String" ControlID="txtTelefono" />
                <asp:ControlParameter Name="FechaNacimiento" Type="DateTime" ControlID="txtFecha" />
                <asp:ControlParameter Name="Carnet" Type="Boolean" ControlID="checkbox1" />
                <asp:ControlParameter Name="Cuota" Type="Double" ControlID="txtCuota" />
                <asp:ControlParameter Name="Foto" Type="String" ControlID="txtFoto" />
                <asp:ControlParameter Name="Id" Type="Int32" ControlID="txtId" />
            </UpdateParameters>
        </asp:AccessDataSource>
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="AccessDataSource1">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                <asp:BoundField DataField="Telefono" HeaderText="Telefono" SortExpression="Telefono" />
                <asp:BoundField DataField="FechaNacimiento" DataFormatString="{0:d}" HeaderText="FechaNacimiento" SortExpression="FechaNacimiento" />
                <asp:CheckBoxField DataField="Carnet" HeaderText="Carnet" SortExpression="Carnet" />
                <asp:BoundField DataField="Cuota" HeaderText="Cuota" SortExpression="Cuota" />
                <asp:BoundField DataField="Foto" HeaderText="Foto" SortExpression="Foto" />
                <asp:BoundField DataField="Url" HeaderText="Url" SortExpression="Url" />
            </Columns>
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
