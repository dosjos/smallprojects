<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
	<asp:Wizard ID="Wizard1" runat="server" ActiveStepIndex="1" 
		onactivestepchanged="Wizard1_ActiveStepChanged" 
		onfinishbuttonclick="Wizard1_FinishButtonClick">
		<WizardSteps>
			<asp:WizardStep runat="server" title="Step 1">
				<asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
			</asp:WizardStep>
			<asp:WizardStep runat="server" title="Step 2">
				<asp:CheckBox ID="CheckBox1" runat="server" />
				<asp:CheckBox ID="CheckBox2" runat="server" />
			</asp:WizardStep>
			<asp:WizardStep runat="server" Title="Step 3">
			</asp:WizardStep>
			<asp:WizardStep runat="server" Title="Step 4">
			</asp:WizardStep>
			<asp:WizardStep runat="server" StepType="Complete" Title="Step 5">
				Kvittering
			</asp:WizardStep>
		</WizardSteps>
	</asp:Wizard>
	</form>
</body>
</html>
