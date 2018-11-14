<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Ejercicio 4.aspx.vb" Inherits="Ejercicio_4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    <br />
    <asp:CheckBoxList ID="CheckBoxList1" runat="server" AutoPostBack="True" 
        RepeatDirection="Horizontal">
        <asp:ListItem>Diplomado</asp:ListItem>
        <asp:ListItem>Graduado</asp:ListItem>
        <asp:ListItem>PostGraduado</asp:ListItem>
        <asp:ListItem>Doctorado</asp:ListItem>
    </asp:CheckBoxList>
</p>
<p>
    <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
</p>
<p>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</p>
</asp:Content>

