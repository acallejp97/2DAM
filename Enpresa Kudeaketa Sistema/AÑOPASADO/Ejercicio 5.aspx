<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Ejercicio 5.aspx.vb" Inherits="Ejercicio_5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
&nbsp;<asp:Button ID="Button1" runat="server" Text="Contar Registros" />
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Nombre del Producto"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Precio Producto"></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="Button2" runat="server" Text="Añadir Regristro" />
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Text="ID Producto"></asp:Label>
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="Button3" runat="server" Text="Borrar Registro" />
    <br />
    <br />
    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    <br />
    <br />
    <br />
</asp:Content>

