<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Klase css bat eman label_server bati</title>

    <style type="text/css">
        .clase01
        {
            font: 18pt verdana;
            background-color:black;
            color:green;
         }
    </style>

</head>

<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" 
            Text="Estiloa ematen web kontrolei CssClass erabiltzen" 
            CssClass="clase01"></asp:Label>
    
    </div>
    </form>
</body>
</html>
