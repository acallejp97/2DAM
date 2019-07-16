<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" Text="Leer XML_XMLTextReader" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Leer XML_XMLDocument" />
        <br />
        <br />
        <table class="style1">
            <tr>
                <td bgcolor="#FFCC66" width="100">
                    XMLTextReader</td>
                <td bgcolor="#FFCC66" width="100">
                    XMLDocument</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
        </table>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
