<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            height: 236px;
        }
    </style>
</head>
<body style="height: 429px">
    <form id="form1" runat="server">
        
        <asp:Label ID="Label1" runat="server" Text="IKASLEAK KUDEATZEKO APLIKAZIOA"></asp:Label>
            <br />
            <asp:Table ID="Table1" runat="server" HorizontalAlign="Left" Width="432px" Height="196px">
                <asp:TableRow runat="server" ID="trIzena">
                    <asp:TableCell runat="server">
                        <asp:Label ID="Label2" runat="server" Text="Izena:"></asp:Label>             
                    


</asp:TableCell>

                    <asp:TableCell runat="server">
                        <asp:TextBox ID="tbIzena" runat="server"></asp:TextBox>
                    


</asp:TableCell>

                </asp:TableRow>
                <asp:TableRow ID="trAbizena" runat="server">
                    <asp:TableCell runat="server">
                        <asp:Label ID="Label3" runat="server" Text="Abizena:"></asp:Label>
                    


</asp:TableCell>

                    <asp:TableCell runat="server">
                        <asp:TextBox ID="tbAbizena" runat="server"></asp:TextBox>
                    


</asp:TableCell>
                </asp:TableRow>
            
            
                <asp:TableRow ID="trAdina" runat="server" HorizontalAlign="Left">
                    <asp:TableCell runat="server" Wrap="False">
                        <asp:Label ID="Label4" runat="server" Text="Adina:"></asp:Label>
                    


</asp:TableCell>

                    <asp:TableCell runat="server" Wrap="False">
                        <asp:TextBox ID="tbAdina" runat="server" Width="34px" AutoPostBack="True"></asp:TextBox>
                    


</asp:TableCell>

                    <asp:TableCell runat="server" Wrap="False">
                        <asp:Label ID="lblAdinaOndo" runat="server" Text="Adina ezin da 18 baino gutxiago izan" Visible="False" ForeColor="Red"></asp:Label>
</asp:TableCell>
                </asp:TableRow>
    
    
                <asp:TableRow ID="trTaldea" runat="server">
                    <asp:TableCell runat="server">
                        <asp:Label ID="Label5" runat="server" Text="Taldea"></asp:Label>
                    


</asp:TableCell>

                    <asp:TableCell runat="server">
                        <asp:DropDownList ID="ddTaldeak" runat="server" AutoPostBack="True">
                            <asp:ListItem>DAM</asp:ListItem>
                            


<asp:ListItem>ASIR</asp:ListItem>
                            


<asp:ListItem>SM</asp:ListItem>
        


</asp:DropDownList>
                    


</asp:TableCell>
                </asp:TableRow>

                <asp:TableRow ID="trHizkuntza" runat="server">
                    <asp:TableCell runat="server">
                        <asp:Label ID="Label6" runat="server" Text="Hizkuntza:"></asp:Label>
                    


</asp:TableCell>

                    <asp:TableCell runat="server">
                        <asp:RadioButton ID="rbEuskera" runat="server" GroupName="Hizkuntza" Text="Euskera"/>
                        


<asp:RadioButton ID="rbGaztelania" runat="server" GroupName="Hizkuntza" Text="Gaztelania"/>
                    


</asp:TableCell>
                </asp:TableRow>

                <asp:TableRow ID="trHizkuntzak" runat="server">
                    <asp:TableCell runat="server">
                        <asp:Label ID="Label7" runat="server" Text="Hizkuntzak"></asp:Label>
                    


</asp:TableCell>

                    <asp:TableCell runat="server">
        <asp:CheckBox ID="cbIngelesa" runat="server" Text="Ingelesa" />
        


<asp:CheckBox ID="cbFrantsesa" runat="server" Text="Frantsesa" />
        


<asp:CheckBox ID="cbAlemana" runat="server" Text="Alemana" />
        


<asp:CheckBox ID="cbItaliera" runat="server" Text="Italiera" />
                        

</asp:TableCell>
                </asp:TableRow>
        </asp:Table>
        
        <asp:Image ID="IrudiHau" runat="server" Height="111px" Visible="False" Width="151px" />



    <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Calendar ID="Calendar" runat="server" WeekendDayStyle-BackColor="#CCCCFF" OnDayRender="Calendar1_SelectionChanged"></asp:Calendar>
        <br />

    <p>
        <asp:Label ID="Label8" runat="server" Text="Argazkia: "></asp:Label>
       
            <asp:FileUpload ID="fuAutatu" runat="server" Width="320px" />
            <asp:Button ID="btnIgo" runat="server" Text="Igo" />
       
        </p>
       
        <p>
            <asp:Button ID="btnGorde" runat="server" Text="Gorde" />
            <asp:Button ID="btnHurrengoa" runat="server" Text="Hurrengoa" />
        </p>
       
        </form>
        



</body>
</html>
