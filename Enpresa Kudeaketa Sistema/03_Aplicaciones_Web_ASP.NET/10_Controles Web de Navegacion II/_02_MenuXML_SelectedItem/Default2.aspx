<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default2.aspx.vb" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Menu ID="Menu1" runat="server">
            <Items>
                <asp:MenuItem Text="HOME" Value="HOME">
                    <asp:MenuItem Text="SECCION 1" Value="SECCION 1">
                        <asp:MenuItem Text="ITEM 1" Value="ITEM 1"></asp:MenuItem>
                        <asp:MenuItem Text="ITEM 2" Value="ITEM 2"></asp:MenuItem>
                        <asp:MenuItem Text="ITEM 3" Value="ITEM 3"></asp:MenuItem>
                    </asp:MenuItem>
                    <asp:MenuItem Text="SECCION 2" Value="SECCION 2">
                        <asp:MenuItem Text="ITEM 4" Value="ITEM 4"></asp:MenuItem>
                        <asp:MenuItem Text="ITEM 5" Value="ITEM 5"></asp:MenuItem>
                    </asp:MenuItem>
                </asp:MenuItem>
            </Items>
        </asp:Menu>
        <br />
        <asp:Label ID="Label1" runat="server" Text="BD, Editar elementos del menu"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Cambiar ESTILOS" />
    
    </div>
    </form>
</body>
</html>
