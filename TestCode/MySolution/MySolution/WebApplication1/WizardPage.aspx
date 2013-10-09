<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WizardPage.aspx.cs" Inherits="WebApplication1.WizardPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    	<asp:Wizard ID="Wizard1" runat="server" ActiveStepIndex="0" 
			onfinishbuttonclick="Wizard1_FinishButtonClick">
			<WizardSteps>
				<asp:WizardStep runat="server" title="Step 1">
					Name: <asp:TextBox ID="_name" runat="server"></asp:TextBox>
					<br />
					Address: <asp:TextBox ID="_address" runat="server" TextMode="MultiLine"></asp:TextBox>
				</asp:WizardStep>
				<asp:WizardStep runat="server" title="Step 2">
					Birthday: <asp:Calendar ID="_birthday" runat="server"></asp:Calendar>
					<br />
					Gender:
					<asp:RadioButtonList ID="_gender" runat="server">
						<asp:ListItem Value="f">Female</asp:ListItem>
						<asp:ListItem Value="m">Male</asp:ListItem>
					</asp:RadioButtonList>
				</asp:WizardStep>
				<asp:WizardStep runat="server" Title="Step3">
					Email: <asp:TextBox ID="_email" runat="server"></asp:TextBox>
					<br />
					<asp:CheckBox ID="_receiveUpdates" runat="server" Text="Yes, please! I'd like to receive emails with news and stuff." />
				</asp:WizardStep>
				<asp:WizardStep runat="server" StepType="Complete" Title="Receipt">
					<asp:Label ID="_receiptLabel" runat="server" />
				</asp:WizardStep>
			</WizardSteps>
		</asp:Wizard>
    
    </div>
    </form>
</body>
</html>
