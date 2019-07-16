<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

    <style type="text/css">
        .clase01
        {
            font: 14pt verdana;
            background-color:aqua;
            color:purple;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <asp:Label ID="Label1" runat="server" 
            Text="Aplicando estilos sobre una Web" CssClass="clase01"></asp:Label>
        
    </div>
    </form>
</body>
</html>
