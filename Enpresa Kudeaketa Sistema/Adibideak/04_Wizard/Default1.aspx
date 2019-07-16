<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default1.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Wizard ID="Wizard1" runat="server" Height="110px" Width="323px" ActiveStepIndex="2">
            <FinishNavigationTemplate>
                <asp:Button ID="FinishPreviousButton" runat="server" CausesValidation="False" CommandName="MovePrevious" Text="Anterior" />
                <asp:Button ID="FinishButton" runat="server" CommandName="MoveComplete" Text="ACEPTAR" />
            </FinishNavigationTemplate>
            <StartNavigationTemplate>
                <asp:Button ID="StartNextButton" runat="server" CommandName="MoveNext" Text="JARRAITU" />
            </StartNavigationTemplate>
            <StepNavigationTemplate>
                <asp:Button ID="StepPreviousButton" runat="server" CausesValidation="False" CommandName="MovePrevious" Text="Anterior" />
                <asp:Button ID="StepNextButton" runat="server" CommandName="MoveNext" Text="Siguiente" />
            </StepNavigationTemplate>
            <WizardSteps>
                <asp:WizardStep runat="server" title="Step 1">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </asp:WizardStep>
                <asp:WizardStep runat="server" title="Step 2">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </asp:WizardStep>
                <asp:WizardStep runat="server" Title="Step 3">
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </asp:WizardStep>
            </WizardSteps>
        </asp:Wizard>
    
    </div>
    </form>
</body>
</html>
