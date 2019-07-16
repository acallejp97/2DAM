<%@ Page Language="VB" AutoEventWireup="false" CodeFile="DefaultBAI.aspx.vb" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <br />
        <br />
        <asp:Menu ID="Menu1" runat="server" ForeColor="MediumSeaGreen" Font-Bold="true">
            <Items>
                <asp:MenuItem Text="Home" ToolTip="Home">
                    <asp:MenuItem Text="Section 1" ToolTip="Section 1">
                        <asp:MenuItem Text="Item 1" ToolTip="Item 1" />
                        <asp:MenuItem Text="Item 2" ToolTip="Item 2" />
                        <asp:MenuItem Text="Item 3" ToolTip="Item 3" />
                    </asp:MenuItem>
                    <asp:MenuItem Text="Section 2" ToolTip="Section 2">
                        <asp:MenuItem Text="Item 1" ToolTip="Item 1" />
                        <asp:MenuItem Text="Item 2" ToolTip="Item 2">
                            <asp:MenuItem Text="Subitem 1" />
                            <asp:MenuItem Text="Subitem 2" />
                        </asp:MenuItem>
                        <asp:MenuItem Text="Item 3" ToolTip="Item 3" />
                    </asp:MenuItem>
                    <asp:MenuItem Text="Section 3" Value="Section 3">
                        <asp:MenuItem Text="Item 1" Value="Item 1"></asp:MenuItem>
                    </asp:MenuItem>
                </asp:MenuItem>
            </Items>
        </asp:Menu>
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" 
            ForeColor="#0066FF" 
            Text="Menuari itemak ipiniko dizkiogu laguntzailea erabiliz"></asp:Label>
    </div>
    </form>
</body>
</html>
