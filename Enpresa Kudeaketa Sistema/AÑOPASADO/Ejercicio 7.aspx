<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Ejercicio 7.aspx.vb" Inherits="Ejercicio_7" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:TreeView ID="TreeView1" runat="server" DataSourceID="XmlDataSource1" 
    ShowCheckBoxes="Leaf" style="margin-right: 0px">
    <DataBindings>
        <asp:TreeNodeBinding DataMember="Fruteria" TextField="#Name" />
        <asp:TreeNodeBinding DataMember="Elemento" TextField="Categoria" />
        <asp:TreeNodeBinding DataMember="Opcion" TextField="Seleccion" />
    </DataBindings>
</asp:TreeView>
<br />
<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
<br />
<br />
<asp:Button ID="Button1" runat="server" Text="Visualizar nodos Chequeados" />
    <br />
<br />
<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
<br />
    <br />
<asp:Button ID="Button2" runat="server" 
    Text="Borrar el nodo Seleccionado(no chequeado)" />
<br />
<br />
<asp:XmlDataSource ID="XmlDataSource1" runat="server" 
    DataFile="~/App_Data/Tienda.xml"></asp:XmlDataSource>
</asp:Content>

