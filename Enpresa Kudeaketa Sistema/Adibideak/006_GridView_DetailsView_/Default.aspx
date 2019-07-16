<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

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
    
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/Amigos.accdb" SelectCommand="SELECT * FROM [Contactos_local]"></asp:AccessDataSource>
        <br />
        GRIDVIEW, propiedad SelectedRowStyle.BackColor=Yellow<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="AccessDataSource1" AllowSorting="True">
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
            <SelectedRowStyle BackColor="Yellow" />
        </asp:GridView>
        <br />
        DetailsView<br />
        <asp:AccessDataSource ID="AccessDataSource2" runat="server" 
            DataFile="~/App_Data/Amigos.accdb" 
            DeleteCommand="DELETE FROM [Contactos_local] WHERE [Id] = ?" 
            InsertCommand="INSERT INTO [Contactos_local] ( [Nombre], [Telefono], [FechaNacimiento], [Carnet], [Cuota], [Foto], [Url]) VALUES ( ?, ?, ?, ?, ?, ?, ?)" SelectCommand="SELECT * FROM [Contactos_local] WHERE ([Id] = ?)" UpdateCommand="UPDATE [Contactos_local] SET [Nombre] = ?, [Telefono] = ?, [FechaNacimiento] = ?, [Carnet] = ?, [Cuota] = ?, [Foto] = ?, [Url] = ? WHERE [Id] = ?">
            <DeleteParameters>
                <asp:Parameter Name="Id" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Nombre" Type="String" />
                <asp:Parameter Name="Telefono" Type="String" />
                <asp:Parameter Name="FechaNacimiento" Type="DateTime" />
                <asp:Parameter Name="Carnet" Type="Boolean" />
                <asp:Parameter Name="Cuota" Type="Double" />
                <asp:Parameter Name="Foto" Type="String" />
                <asp:Parameter Name="Url" Type="String" />
            </InsertParameters>
            <SelectParameters>
                <asp:ControlParameter ControlID="GridView1" Name="Id" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="Nombre" Type="String" />
                <asp:Parameter Name="Telefono" Type="String" />
                <asp:Parameter Name="FechaNacimiento" Type="DateTime" />
                <asp:Parameter Name="Carnet" Type="Boolean" />
                <asp:Parameter Name="Cuota" Type="Double" />
                <asp:Parameter Name="Foto" Type="String" />
                <asp:Parameter Name="Url" Type="String" />
                <asp:Parameter Name="Id" Type="Int32" />
            </UpdateParameters>
        </asp:AccessDataSource>
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataKeyNames="Id" DataSourceID="AccessDataSource2" Height="50px" Width="125px">
            <EditRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <Fields>
                <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                <asp:BoundField DataField="Telefono" HeaderText="Telefono" SortExpression="Telefono" />
                <asp:BoundField DataField="FechaNacimiento" HeaderText="FechaNacimiento" SortExpression="FechaNacimiento" />
                <asp:CheckBoxField DataField="Carnet" HeaderText="Carnet" SortExpression="Carnet" />
                <asp:BoundField DataField="Cuota" HeaderText="Cuota" SortExpression="Cuota" />
                <asp:BoundField DataField="Foto" HeaderText="Foto" SortExpression="Foto" />
                <asp:BoundField DataField="Url" HeaderText="Url" SortExpression="Url" />
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True" />
                <asp:HyperLinkField NavigateUrl="~/Default2.aspx" Text="Ir al Default2" />
                <asp:HyperLinkField NavigateUrl="~/Default2.aspx" Text="Ir a default 2 again" />
            </Fields>
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
        </asp:DetailsView>
    
        <br />
        <asp:Label ID="Label4" runat="server" Text="CUIDADO: Hay que modificar InsertCommand"></asp:Label>
        <br />
        <asp:Label ID="Label5" runat="server" Text="pq, añade el campo Id que es autonumérico"></asp:Label>
        <br />
        <asp:Label ID="Label6" runat="server" Text="y hay que borrarlo."></asp:Label>
    
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </asp:ToolkitScriptManager>
    
    </div>
    </form>
</body>
</html>
