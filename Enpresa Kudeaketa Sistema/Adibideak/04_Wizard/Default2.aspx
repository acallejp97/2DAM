﻿<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default2.aspx.vb" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Wizard ID="Wizard1" runat="server" ActiveStepIndex="2" Height="144px" Width="328px">
            <FinishNavigationTemplate>
                <asp:Button ID="FinishPreviousButton" runat="server" 
                    CausesValidation="False" CommandName="MovePrevious" 
                    Text="Anterior" UseSubmitBehavior="False" />
                <asp:Button ID="FinishButton" runat="server" 
                    CommandName="MoveComplete" Text="Finalizar" />
            </FinishNavigationTemplate>

            <StartNavigationTemplate>
                <asp:Button ID="StartNextButton" runat="server" 
                    CommandName="MoveNext" Text="Siguiente" OnClientClick="return confirm('Estas seguro?')" />
            </StartNavigationTemplate>

            <StepNavigationTemplate>
                <asp:Button ID="StepPreviousButton" runat="server" 
                    CausesValidation="False" CommandName="MovePrevious" 
                    Text="Anterior" UseSubmitBehavior="False" />
                <asp:Button ID="StepNextButton" runat="server" 
                    CommandName="MoveNext" Text="Siguiente" />
            </StepNavigationTemplate>

            <WizardSteps>
                <asp:WizardStep runat="server" title="Step 1">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </asp:WizardStep>
                <asp:WizardStep runat="server" title="Step 2">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </asp:WizardStep>
                <asp:WizardStep runat="server" Title="Step 3">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label2" runat="server" Text="Salida"></asp:Label>
                </asp:WizardStep>
            </WizardSteps>
        </asp:Wizard>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    
    </div>
    </form>
</body>
</html>
