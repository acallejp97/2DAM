<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default3_CSS.aspx.vb" Inherits="Default3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .level1
        {
            color: White;
            background-color: Black;
            font-variant: small-caps;
            font-size: large;
            font-weight: bold;
        }

        .level2
        {
            color: Blue;
            background-color: Gray;        
            font-family: Gill Sans MT;
            font-size: medium;
    
        }

        .level3
        {
            color: black;
            background-color: Red;
            font-family: Gill Sans MT;
            font-size: small;
        }
        
   
      </style>
</head>
<body>
    <form id="form1" runat="server">
    
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
            <LevelMenuItemStyles>
                <asp:MenuItemStyle CssClass="level1" Font-Underline="False" />
                <asp:MenuItemStyle CssClass="level2" Font-Underline="False" />
                <asp:MenuItemStyle CssClass="level3" Font-Underline="False" />
            </LevelMenuItemStyles>
        </asp:Menu>
        <br />
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Propiedad LevelMenuItemStyles"></asp:Label>
    
    </div>
    </form>
</body>
</html>
