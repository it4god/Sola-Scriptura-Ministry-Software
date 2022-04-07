<%@ Page language="c#" Codebehind="About.aspx.cs" AutoEventWireup="false" Inherits="Sola_Scriptura_Library_Web.About" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>WebForm1</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout" bgColor="#567fdc">
		<form id="Form1" method="post" runat="server">
			<asp:Image id="ImageLogo" style="Z-INDEX: 100; LEFT: 0px; POSITION: absolute; TOP: 0px" runat="server"
				Width="136px" Height="64px" ImageUrl="Image\LOGOSOLA.GIF"></asp:Image>
			<asp:Label id="Label3" style="Z-INDEX: 107; LEFT: 144px; POSITION: absolute; TOP: 464px" runat="server"
				Height="56px" Width="184px" ForeColor="White">Created by : Jeffrey Lim <BR>               (022)-6030183  <BR>  (022)-6642828 <BR>  081572322121  <BR>  Email : limpingen@yahoo.com</asp:Label>
			<asp:Label id="Label2" style="Z-INDEX: 106; LEFT: 144px; POSITION: absolute; TOP: 400px" runat="server"
				Height="56px" Width="353px" ForeColor="White">Warning: All rights reserved. This system is copyright to Sola Scriptura Development System.</asp:Label>
			<asp:hyperlink id="HyperLink1" style="Z-INDEX: 103; LEFT: 424px; POSITION: absolute; TOP: 8px"
				runat="server" Height="16px" Width="44px" NavigateUrl="Home.aspx" Target="_self" ForeColor="White">Home</asp:hyperlink>&nbsp;
			<asp:Image id="ImageWelcome" style="Z-INDEX: 101; LEFT: 96px; POSITION: absolute; TOP: 76px"
				runat="server" ImageUrl="Image\LOGINWELCOME.GIF" Height="208px" Width="460px"></asp:Image>
			<asp:Image id="ImageTitle" style="Z-INDEX: 102; LEFT: 136px; POSITION: absolute; TOP: 0px"
				runat="server" Width="281px" Height="64px" ImageUrl="Image\ABOUTTITLE.GIF"></asp:Image>
			<asp:Label id="Label1" style="Z-INDEX: 104; LEFT: 144px; POSITION: absolute; TOP: 296px" runat="server"
				Height="56px" Width="353px" ForeColor="White">Sola Scriptura Library System provides users with full flexibility to use the system. This system was made to ease the user and provides complete function that required to run the library.</asp:Label>
		</form>
	</body>
</HTML>
