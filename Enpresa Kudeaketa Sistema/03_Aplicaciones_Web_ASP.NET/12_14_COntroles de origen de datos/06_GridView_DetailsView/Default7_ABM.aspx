<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default7_ABM.aspx.vb" Inherits="Default7_ABM" %>

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
    
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="ID autonumerico:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxID" runat="server"></asp:TextBox>
        <asp:Button ID="ButtonBorrar" runat="server" Text="Borrar" />
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Nombre"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxNombre" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label4" runat="server" Text="Telefono"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxTelefono" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Foto"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxFoto" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label6" runat="server" Text="Cuota"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxCuota" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:CheckBox ID="CheckBoxCarnet" runat="server" Text="Carnet" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label7" runat="server" Text="Fecha de nacimientro"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxFechNac" runat="server"></asp:TextBox>
        <asp:CalendarExtender ID="TextBoxFechNac_CalendarExtender" runat="server" Enabled="True" TargetControlID="TextBoxFechNac">
        </asp:CalendarExtender>
        <br />
        <br />
        <asp:Button ID="ButtonInsertar" runat="server" Text="Insertar" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonModificar" runat="server" Text="Modificar" />
        <br />
        <br />
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </asp:ToolkitScriptManager>
        <br />
        <br />
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/Amigos.accdb" DeleteCommand="DELETE FROM [Contactos_local] WHERE [Id] = ?" InsertCommand="INSERT INTO [Contactos_local] ([Nombre], [Telefono], [FechaNacimiento], [Carnet], [Cuota], [Foto]) VALUES (?, ?, ?, ?, ?, ?)" SelectCommand="SELECT * FROM [Contactos_local]" UpdateCommand="UPDATE [Contactos_local] SET [Nombre] = ?, [Telefono] = ?, [FechaNacimiento] = ?, [Carnet] = ?, [Cuota] = ?, [Foto] = ? WHERE [Id] = ?">
            <DeleteParameters>
                <asp:ControlParameter Name="Id" Type="Int32" ControlID="TextBoxID" />
            </DeleteParameters>
            <InsertParameters>
                <asp:ControlParameter Name="Nombre" Type="String" ControlID="TextBoxNombre" />
                <asp:ControlParameter Name="Telefono" Type="String" ControlID="TextBoxTelefono" />
                <asp:ControlParameter Name="FechaNacimiento" ControlID="TextBoxFechNac" />
                <asp:ControlParameter Name="Carnet" Type="Boolean" ControlID="CheckBoxCarnet" />
                <asp:ControlParameter Name="Cuota" Type="Double" ControlID="TextBoxCuota"/>
                <asp:ControlParameter Name="Foto" Type="String" ControlID="TextBoxFoto"/>
            </InsertParameters>
            <UpdateParameters>
                <asp:ControlParameter Name="Nombre" Type="String" ControlID="TextBoxNombre" />
                <asp:ControlParameter Name="Telefono" Type="String" ControlID="TextBoxTelefono" />
                <asp:ControlParameter Name="FechaNacimiento" ControlID="TextBoxFechNac" />
                <asp:ControlParameter Name="Carnet" Type="Boolean" ControlID="CheckBoxCarnet" />
                <asp:ControlParameter Name="Cuota" Type="Double" ControlID="TextBoxCuota"/>
                <asp:ControlParameter Name="Foto" Type="String" ControlID="TextBoxFoto"/>
                <asp:ControlParameter Name="Id" Type="Int32" ControlID="TextBoxID"/>
            </UpdateParameters>
        </asp:AccessDataSource>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="AccessDataSource1">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                <asp:BoundField DataField="Telefono" HeaderText="Telefono" SortExpression="Telefono" />
                <asp:BoundField DataField="FechaNacimiento" HeaderText="FechaNacimiento" SortExpression="FechaNacimiento" DataFormatString="{0:d}" />
                <asp:CheckBoxField DataField="Carnet" HeaderText="Carnet" SortExpression="Carnet" />
                <asp:BoundField DataField="Cuota" HeaderText="Cuota" SortExpression="Cuota" />
                <asp:BoundField DataField="Foto" HeaderText="Foto" SortExpression="Foto" />
                <asp:BoundField DataField="Url" HeaderText="Url" SortExpression="Url" />
            </Columns>
        </asp:GridView>
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
