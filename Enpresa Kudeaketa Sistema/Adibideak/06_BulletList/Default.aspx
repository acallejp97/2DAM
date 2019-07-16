<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:BulletedList ID="Lista" runat="server" Width="229px" 
            DisplayMode="LinkButton">
            <asp:ListItem Value="pag1.aspx">Elemento 1</asp:ListItem>
            <asp:ListItem Value="pag2.aspx">Elemento 2</asp:ListItem>
            <asp:ListItem Value="pag3.aspx">Elemento 3</asp:ListItem>
        </asp:BulletedList>
    
    </div>
    <asp:Label ID="etiqueta" runat="server"></asp:Label>
    <br />
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="#0066FF" 
        Text=" Me.Lista.BulletStyle="></asp:Label>
    <br />
    <br />
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
        <asp:ListItem Value="Numbered">numerada</asp:ListItem>
        <asp:ListItem Value="LowerAlpha">Letras minúsculas</asp:ListItem>
        <asp:ListItem Value="UpperAlpha">Letras mayúsculas</asp:ListItem>
        <asp:ListItem Value="Circle">circulo</asp:ListItem>
        <asp:ListItem Value="Disc">punto</asp:ListItem>
        <asp:ListItem Value="Square">cuadrado</asp:ListItem>
        <asp:ListItem>Image</asp:ListItem>
        <asp:ListItem>NotSet</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="#0066FF" 
        Text="ME.Lista.DisplayMode="></asp:Label>
    <br />
    <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" 
        Height="20px" Width="137px">
        <asp:ListItem Value="texto" Selected="True">texto</asp:ListItem>
        <asp:ListItem Value="HyperLink">Enlace</asp:ListItem>
        <asp:ListItem Value="LinkButton">Boton</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Font-Bold="True" ForeColor="#0066FF" Text=" SOLO CAMBIO LA PROPIEDAD BULLETIMAGEURL:"></asp:Label>
    <br />
    <asp:BulletedList ID="BulletedList1" runat="server" BulletImageUrl="~/4.gif" 
        BulletStyle="CustomImage">
        <asp:ListItem>uno</asp:ListItem>
        <asp:ListItem>dos</asp:ListItem>
        <asp:ListItem>tres</asp:ListItem>
    </asp:BulletedList>
    </form>
</body>
</html>
