<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Ejercicio 2.aspx.vb" Inherits="Ejercicio_2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" 
            Text="Introduce la primera letra en mayusculas del companyname:"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text="SIN parametros"></asp:Label>
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" 
            Text="&quot;select companyname,country from customers&quot;"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" AutoPostBack="True"></asp:TextBox>
        <asp:Label ID="Label4" runat="server" Text="Con parametros"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </p>
</asp:Content>

