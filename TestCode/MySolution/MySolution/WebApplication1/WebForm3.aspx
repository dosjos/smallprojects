<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication1.WebForm3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
	<asp:FormView ID="FormView1" runat="server" AllowPaging="True" DataKeyNames="Id"
		DataSourceID="_personDataSource">
		<EditItemTemplate>
			Firstname:
			<asp:TextBox ID="FirstnameTextBox" runat="server" Text='<%# Bind("Firstname") %>' />
			<br />
			Lastname:
			<asp:TextBox ID="LastnameTextBox" runat="server" Text='<%# Bind("Lastname") %>' />
			<br />
			Id:
			<asp:Label ID="Label1" runat="server" Text='<%# Eval("Id") %>'></asp:Label>
			<br />
			<asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update"
				Text="Update" />
			&nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False"
				CommandName="Cancel" Text="Cancel" />
		</EditItemTemplate>
		<EmptyDataTemplate>
			Det er ingen personer i listen<br />
			<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New"
				Text="New" />
			&nbsp;<asp:LinkButton ID="LinkButton1" runat="server" CommandName="minkommando">New</asp:LinkButton>
		</EmptyDataTemplate>
		<InsertItemTemplate>
			Firstname:
			<asp:TextBox ID="FirstnameTextBox" runat="server" Text='<%# Bind("Firstname") %>' />
			<br />
			Lastname:
			<asp:TextBox ID="LastnameTextBox" runat="server" Text='<%# Bind("Lastname") %>' />
			<br />
			Id:
			<asp:TextBox ID="IdTextBox" runat="server" Text='<%# Bind("Id") %>' />
			<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
				ControlToValidate="IdTextBox" ErrorMessage="Du må velge en id">*</asp:RequiredFieldValidator>
			<br />
			<br />
			<asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert"
				Text="Insert" />
			&nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False"
				CommandName="Cancel" Text="Cancel" />
		</InsertItemTemplate>
		<ItemTemplate>
			Firstname:
			<asp:Label ID="FirstnameLabel" runat="server" Text='<%# Bind("Firstname") %>' />
			<br />
			Lastname:
			<asp:Label ID="LastnameLabel" runat="server" Text='<%# Bind("Lastname") %>' />
			<br />
			Id:
			<asp:Label ID="IdLabel" runat="server" Text='<%# Bind("Id") %>' />
			<br />
			Created:
			<asp:Label ID="CreatedLabel" runat="server" Text='<%# Bind("Created") %>' />
			<br />
			FullName:
			<asp:Label ID="FullNameLabel" runat="server" Text='<%# Bind("FullName") %>' />
			<br />
			<asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit"
				Text="Edit" />
			&nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" CommandName="Delete"
				Text="Delete" />
			&nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New"
				Text="New" />
		</ItemTemplate>
		<PagerTemplate>
			<asp:Button ID="FirstPage" runat="server" Text="First" CommandName="Page" CommandArgument="First" />
			<asp:Button ID="PreviousPage" runat="server" Text="Previous" CommandName="Page" CommandArgument="Prev" />
			<asp:Button ID="Page1" runat="server" Text="1" CommandName="Page" CommandArgument="1" />
			<asp:Button ID="Page2" runat="server" Text="2" CommandName="Page" CommandArgument="2" />
			<asp:Button ID="Page3" runat="server" Text="3" CommandName="Page" CommandArgument="3" />
			<asp:Button ID="NextPage" runat="server" Text="Next" CommandName="Page" CommandArgument="Next" />
			<asp:Button ID="LastPage" runat="server" Text="Last" CommandName="Page" CommandArgument="Last" />
		</PagerTemplate>
	</asp:FormView>
	<asp:ObjectDataSource ID="_personDataSource" runat="server" DeleteMethod="RemovePerson"
		InsertMethod="AddPerson" SelectMethod="GetPersons" TypeName="PersonRepository"
		UpdateMethod="UpdatePerson">
		<DeleteParameters>
			<asp:Parameter Name="id" Type="Int32" />
		</DeleteParameters>
		<InsertParameters>
			<asp:Parameter Name="id" Type="Int32" />
			<asp:Parameter Name="firstname" Type="String" />
			<asp:Parameter Name="lastname" Type="String" />
		</InsertParameters>
		<UpdateParameters>
			<asp:Parameter Name="id" Type="Int32" />
			<asp:Parameter Name="firstname" Type="String" />
			<asp:Parameter Name="lastname" Type="String" />
		</UpdateParameters>
	</asp:ObjectDataSource>
	<div>
	</div>
	<asp:ValidationSummary ID="ValidationSummary1" runat="server" />
	</form>
</body>
</html>
