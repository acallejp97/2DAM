<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DefaultCS.aspx.cs" Inherits="DefaultCS" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 54%;
            border: 8px solid #FF00FF;
            background-color: #00FFFF;
        }
        .auto-style2 {
            width: 147px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
<div>
    
        <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" Text="ELIJA SU CONFIGURACION CS"></asp:Label>
        <br />
        <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Seleccione memoria </td>
                <td>Seleccione accesorios</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem Value="12">8 GB</asp:ListItem>
                        <asp:ListItem Value="20">16 GB</asp:ListItem>
                        <asp:ListItem Value="25">32 GB</asp:ListItem>
                        <asp:ListItem Value="50">64 GB</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                        <asp:ListItem Value="220">MONITOR</asp:ListItem>
                        <asp:ListItem Value="100">SSD 256 GB</asp:ListItem>
                        <asp:ListItem Value="90">RATON</asp:ListItem>
                    </asp:CheckBoxList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="Button1" runat="server" Text="CALCULAR PRECIO" OnClick="Button1_Click" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
        <br />
        <br />
        <asp:Label ID="lblResultado" runat="server" Font-Size="XX-Large" Text="Label"></asp:Label>
    </form>
</body>
</html>
