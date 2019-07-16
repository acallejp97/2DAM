<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default4_FilteredTextboxExtender.aspx.vb" Inherits="Default4_FilteredTextboxExtender" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Utilizo un control AJAX"></asp:Label>
        <br />
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </asp:ToolkitScriptManager>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Solo DIGITOS"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
       
        <asp:FilteredTextBoxExtender  
            ID="TextBox1_FilteredTextBoxExtender" 
            runat="server" Enabled="True" 
            TargetControlID="TextBox1" 
            FilterType="Numbers">
        </asp:FilteredTextBoxExtender>
       
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Solo letras minúsculas"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:FilteredTextBoxExtender 
            ID="TextBox2_FilteredTextBoxExtender" 
            runat="server" Enabled="True" 
            TargetControlID="TextBox2" 
            FilterType="LowercaseLetters">
        </asp:FilteredTextBoxExtender>
       

        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Numeros y  [+,-,*,/,=,(,)]"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:FilteredTextBoxExtender 
            ID="TextBox3_FilteredTextBoxExtender" 
            runat="server" Enabled="True" 
            TargetControlID="TextBox3" FilterType="Numbers,Custom"
            ValidChars="[,+-*/=()]">
        </asp:FilteredTextBoxExtender>
       

        <br />
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="No permite  aeiouAEIOU"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <asp:FilteredTextBoxExtender 
            ID="TextBox4_FilteredTextBoxExtender" 
            runat="server" Enabled="True" 
            TargetControlID="TextBox4"
            InvalidChars="aeiouAEIOU" 
            FilterMode="InvalidChars">
        </asp:FilteredTextBoxExtender>
       

        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Solo permite  aeiouAEIOU"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <asp:FilteredTextBoxExtender 
            ID="TextBox5_FilteredTextBoxExtender" 
            runat="server" Enabled="True" 
            TargetControlID="TextBox5" 
            ValidChars="aeiouAEIOU" 
            FilterMode="ValidChars">
        </asp:FilteredTextBoxExtender>
       

        <br />
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" 
   Text="Caracteres en minusculas, digitos y $&amp;€"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <asp:FilteredTextBoxExtender 
            ID="TextBox6_FilteredTextBoxExtender" 
            runat="server" Enabled="True" 
            TargetControlID="TextBox6" 
            FilterType="LowercaseLetters,Numbers,Custom" 
            ValidChars="$€& " 
            FilterMode="ValidChars">
        </asp:FilteredTextBoxExtender>
       

    </div>
    </form>
</body>
</html>
