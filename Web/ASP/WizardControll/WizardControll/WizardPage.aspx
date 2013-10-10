<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WizardPage.aspx.cs" Inherits="WizardControll.WizardPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Wizard ID="Wizard1" runat="server" ActiveStepIndex="0" Height="324px" 
            Width="582px" onfinishbuttonclick="Wizard1_FinishButtonClick">
            <WizardSteps>
                <asp:WizardStep runat="server" title="Page 1">
                    <asp:Label ID="Label1" runat="server" Text="Navn   "></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label2" runat="server" Text="Adresse"></asp:Label>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </asp:WizardStep>
                <asp:WizardStep runat="server" title="Page 2">
                    <asp:Label ID="Label3" runat="server" Text="Bursdag"></asp:Label>
                    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                    <asp:Label ID="Label4" runat="server" Text="Kjønn:"></asp:Label>
                    <asp:RadioButton ID="RadioButton1" runat="server" GroupName="gend" Text="Mann" 
                        Checked="True"/>
                    <asp:RadioButton ID="RadioButton2" runat="server" GroupName="gend" Text="Kvinne"/>
                </asp:WizardStep>
                <asp:WizardStep runat="server" Title="Page 3" StepType="Finish">
                    <asp:Label ID="Label5" runat="server" Text="Email"></asp:Label>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label6" runat="server" Text="Ja Takk til Nyhetsbrev: "></asp:Label>
                    <asp:CheckBox ID="CheckBox1" runat="server" 
                        OnCheckedChanged="CheckBox1_CheckedChanged" Text="Ja takk" />
                </asp:WizardStep>
                <asp:WizardStep runat="server" Title="Last Page" StepType="Complete">
                    <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                </asp:WizardStep>
            </WizardSteps>
        </asp:Wizard>
    
    </div>
    </form>
</body>
</html>
