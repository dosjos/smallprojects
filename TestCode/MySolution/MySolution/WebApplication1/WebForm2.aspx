<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication1.WebForm2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
	<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
		DataSourceID="_categoriesDataSource" DataTextField="CategoryName" 
		DataValueField="CategoryID">
	</asp:DropDownList>
	<asp:SqlDataSource ID="_categoriesDataSource" runat="server" 
		ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>" 
		SelectCommand="SELECT [CategoryID], [CategoryName] FROM [Categories]">
	</asp:SqlDataSource>
	<asp:SqlDataSource ID="_productsSqlDataSource" runat="server" 
		ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>" 
		
		SelectCommand="SELECT [ProductID], [ProductName], [UnitPrice], [QuantityPerUnit] FROM [Products] WHERE ([CategoryID] = @CategoryID)">
		<SelectParameters>
			<asp:ControlParameter ControlID="DropDownList1" Name="CategoryID" 
				PropertyName="SelectedValue" Type="Int32" />
		</SelectParameters>
	</asp:SqlDataSource>
	<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
		DataKeyNames="ProductID" DataSourceID="_productsSqlDataSource">
		<Columns>
			<asp:CommandField ShowSelectButton="True" />
			<asp:BoundField DataField="ProductID" HeaderText="ProductID" 
				InsertVisible="False" ReadOnly="True" SortExpression="ProductID" />
			<asp:BoundField DataField="ProductName" HeaderText="ProductName" 
				SortExpression="ProductName" />
			<asp:BoundField DataField="UnitPrice" HeaderText="UnitPrice" 
				SortExpression="UnitPrice" />
			<asp:BoundField DataField="QuantityPerUnit" HeaderText="QuantityPerUnit" 
				SortExpression="QuantityPerUnit" />
		</Columns>
	</asp:GridView>
	<asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" 
		DataKeyNames="ProductID" DataSourceID="_productDataSource" Height="50px" 
		Width="125px">
		<Fields>
			<asp:BoundField DataField="ProductID" HeaderText="ProductID" 
				InsertVisible="False" ReadOnly="True" SortExpression="ProductID" />
			<asp:BoundField DataField="ProductName" HeaderText="ProductName" 
				SortExpression="ProductName" />
			<asp:BoundField DataField="SupplierID" HeaderText="SupplierID" 
				SortExpression="SupplierID" />
			<asp:BoundField DataField="CategoryID" HeaderText="CategoryID" 
				SortExpression="CategoryID" />
			<asp:BoundField DataField="QuantityPerUnit" HeaderText="QuantityPerUnit" 
				SortExpression="QuantityPerUnit" />
			<asp:BoundField DataField="UnitPrice" HeaderText="UnitPrice" 
				SortExpression="UnitPrice" />
			<asp:BoundField DataField="UnitsInStock" HeaderText="UnitsInStock" 
				SortExpression="UnitsInStock" />
			<asp:BoundField DataField="UnitsOnOrder" HeaderText="UnitsOnOrder" 
				SortExpression="UnitsOnOrder" />
			<asp:BoundField DataField="ReorderLevel" HeaderText="ReorderLevel" 
				SortExpression="ReorderLevel" />
			<asp:CheckBoxField DataField="Discontinued" HeaderText="Discontinued" 
				SortExpression="Discontinued" />
		</Fields>
	</asp:DetailsView>
	<asp:SqlDataSource ID="_productDataSource" runat="server" 
		ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>" 
		SelectCommand="SELECT * FROM [Products] WHERE ([ProductID] = @ProductID)">
		<SelectParameters>
			<asp:ControlParameter ControlID="GridView1" Name="ProductID" 
				PropertyName="SelectedValue" Type="Int32" />
		</SelectParameters>
	</asp:SqlDataSource>
	</form>
</body>
</html>
