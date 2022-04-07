<%@ Page language="c#" Codebehind="Home.aspx.cs" AutoEventWireup="false" Inherits="Sola_Scriptura_Library_Web.Home" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Home</title>
		<meta content="True" name="vs_snapToGrid">
		<meta content="True" name="vs_showGrid">
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body bgColor="#1b40a6" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:image id="ImageTitle" style="Z-INDEX: 101; LEFT: 136px; POSITION: absolute; TOP: 0px"
				runat="server" ImageUrl="Image\ABOUTTITLE.GIF" Height="64px" Width="281px"></asp:image><asp:hyperlink id="HyperLink1" style="Z-INDEX: 110; LEFT: 464px; POSITION: absolute; TOP: 8px"
				runat="server" Height="16px" Width="136px" NavigateUrl="Home.aspx" Target="_self" ForeColor="White">Home</asp:hyperlink><asp:label id="LabelSearchTitle" style="Z-INDEX: 106; LEFT: 216px; POSITION: absolute; TOP: 136px"
				runat="server" Height="24px" Width="408px" ForeColor="White" Font-Names="Verdana"></asp:label><asp:imagebutton id="ImageButtonEnter" style="Z-INDEX: 105; LEFT: 576px; POSITION: absolute; TOP: 80px"
				runat="server" ImageUrl="Image\ENTER.GIF" Height="24px" Width="53px"></asp:imagebutton><asp:textbox id="TextBoxSearch" style="Z-INDEX: 104; LEFT: 216px; POSITION: absolute; TOP: 80px"
				runat="server" Height="24px" Width="352px"></asp:textbox><asp:label id="LabelSearch" style="Z-INDEX: 102; LEFT: 144px; POSITION: absolute; TOP: 80px"
				runat="server" Height="24px" Width="95px" ForeColor="White" Font-Names="Verdana">Search</asp:label><asp:image id="ImageLogo" style="Z-INDEX: 100; LEFT: 0px; POSITION: absolute; TOP: 0px" runat="server"
				ImageUrl="Image\LOGOSOLA.GIF" Height="64px" Width="136px"></asp:image><asp:textbox id="TextBox1" style="Z-INDEX: 107; LEFT: -32000px; POSITION: absolute; TOP: -32000px"
				runat="server" Height="22px" Width="128px"></asp:textbox><asp:datagrid id="DataGridSearchBook" style="Z-INDEX: 108; LEFT: 8px; POSITION: absolute; TOP: 176px"
				runat="server" Height="376px" Width="830px" ForeColor="White" BackColor="#1B40A6" AllowSorting="True" PageSize="20" AutoGenerateColumns="False" AllowPaging="True">
				<AlternatingItemStyle ForeColor="White" BackColor="#1B40A6"></AlternatingItemStyle>
				<ItemStyle ForeColor="White" BackColor="#567FDC"></ItemStyle>
				<HeaderStyle ForeColor="White" BackColor="ActiveCaption"></HeaderStyle>
				<Columns>
					<asp:ButtonColumn Text="Book Code" DataTextField="BookCode" SortExpression="BookCode" HeaderText="Book Code"
						CommandName="BookCodeClick"></asp:ButtonColumn>
					<asp:BoundColumn DataField="BookName" SortExpression="BookName" HeaderText="Book Name"></asp:BoundColumn>
					<asp:BoundColumn DataField="OriginalTitle" SortExpression="OriginalTitle" HeaderText="Original Title"></asp:BoundColumn>
					<asp:BoundColumn DataField="BookType" SortExpression="BookType" HeaderText="Book Type"></asp:BoundColumn>
					<asp:BoundColumn Visible="False" DataField="BookGroup" HeaderText="Book Group"></asp:BoundColumn>
					<asp:BoundColumn DataField="GroupName" SortExpression="GroupName" HeaderText="Book Group"></asp:BoundColumn>
					<asp:BoundColumn DataField="BookISBN" SortExpression="BookISBN" HeaderText="ISBN"></asp:BoundColumn>
					<asp:BoundColumn DataField="BookDDC" SortExpression="BookDDC" HeaderText="DDC"></asp:BoundColumn>
					<asp:BoundColumn DataField="BookVol" SortExpression="BookVol" HeaderText="Vol"></asp:BoundColumn>
					<asp:BoundColumn Visible="False" DataField="BookPages" SortExpression="BookPages" HeaderText="Pages"></asp:BoundColumn>
					<asp:BoundColumn DataField="RevNumber" SortExpression="RevNumber" HeaderText="Rev"></asp:BoundColumn>
					<asp:BoundColumn Visible="False" DataField="PubCode" HeaderText="Pub Code"></asp:BoundColumn>
					<asp:BoundColumn DataField="PubName" SortExpression="PubName" HeaderText="Publisher"></asp:BoundColumn>
					<asp:BoundColumn DataField="PublishYear" SortExpression="PublishYear" HeaderText="Publish Year"></asp:BoundColumn>
					<asp:BoundColumn Visible="False" DataField="BookContents" HeaderText="Contents"></asp:BoundColumn>
				</Columns>
				<PagerStyle Position="TopAndBottom" Mode="NumericPages"></PagerStyle>
			</asp:datagrid></form>
	</body>
</HTML>
