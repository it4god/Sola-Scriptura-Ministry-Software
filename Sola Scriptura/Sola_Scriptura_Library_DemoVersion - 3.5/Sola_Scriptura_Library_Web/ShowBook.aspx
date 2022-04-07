<%@ Page language="c#" Codebehind="ShowBook.aspx.cs" AutoEventWireup="false" Inherits="Sola_Scriptura_Library_Web.ShowBook" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>ShowBook</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body bgColor="#1b40a6" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:image id="ImageLogo" style="Z-INDEX: 101; LEFT: 16px; POSITION: absolute; TOP: 0px" runat="server"
				Width="136px" Height="64px" ImageUrl="Image\LOGOSOLA.GIF"></asp:image>
			<asp:label id="Label9" style="Z-INDEX: 124; LEFT: 32px; POSITION: absolute; TOP: 224px" runat="server"
				Height="16px" Width="104px" ForeColor="White" Font-Names="Verdana" Font-Size="Small">LC No</asp:label>
			<asp:textbox id="TextBoxLCNo" style="Z-INDEX: 123; LEFT: 152px; POSITION: absolute; TOP: 224px"
				runat="server" Width="562px" Font-Names="Verdana" ReadOnly="True"></asp:textbox><asp:label id="LabelSearch" style="Z-INDEX: 122; LEFT: 152px; POSITION: absolute; TOP: 80px"
				runat="server" Width="48px" Height="24px" Font-Names="Verdana" ForeColor="White">Search</asp:label><asp:textbox id="TextBoxSearch" style="Z-INDEX: 107; LEFT: 216px; POSITION: absolute; TOP: 80px"
				runat="server" Width="352px" Height="24px"></asp:textbox><asp:imagebutton id="ImageButtonEnter" style="Z-INDEX: 108; LEFT: 576px; POSITION: absolute; TOP: 80px"
				runat="server" Width="53px" Height="24px" ImageUrl="Image\ENTER.GIF"></asp:imagebutton><asp:textbox id="TextBoxSubject" style="Z-INDEX: 121; LEFT: 152px; POSITION: absolute; TOP: 448px"
				runat="server" Width="562px" Height="56px" Font-Names="Verdana" TextMode="MultiLine" ReadOnly="True"></asp:textbox><asp:textbox id="TextBoxISBN" style="Z-INDEX: 120; LEFT: 152px; POSITION: absolute; TOP: 416px"
				runat="server" Width="562px" Font-Names="Verdana" ReadOnly="True"></asp:textbox><asp:textbox id="TextBoxPublisher" style="Z-INDEX: 119; LEFT: 152px; POSITION: absolute; TOP: 384px"
				runat="server" Width="562px" Font-Names="Verdana" ReadOnly="True"></asp:textbox><asp:textbox id="TextBoxType" style="Z-INDEX: 118; LEFT: 152px; POSITION: absolute; TOP: 352px"
				runat="server" Width="562px" Font-Names="Verdana" ReadOnly="True"></asp:textbox><asp:textbox id="TextBoxBy" style="Z-INDEX: 117; LEFT: 152px; POSITION: absolute; TOP: 288px"
				runat="server" Width="562px" Height="56px" Font-Names="Verdana" TextMode="MultiLine" ReadOnly="True"></asp:textbox><asp:textbox id="TextBoxTitle" style="Z-INDEX: 116; LEFT: 152px; POSITION: absolute; TOP: 256px"
				runat="server" Width="562px" Font-Names="Verdana" ReadOnly="True"></asp:textbox><asp:label id="Label7" style="Z-INDEX: 114; LEFT: 32px; POSITION: absolute; TOP: 448px" runat="server"
				Width="136px" Height="16px" Font-Names="Verdana" ForeColor="White" Font-Size="Small">Subject</asp:label><asp:label id="Label6" style="Z-INDEX: 113; LEFT: 32px; POSITION: absolute; TOP: 416px" runat="server"
				Width="136px" Height="16px" Font-Names="Verdana" ForeColor="White" Font-Size="Small">ISBN</asp:label><asp:label id="Label5" style="Z-INDEX: 112; LEFT: 32px; POSITION: absolute; TOP: 384px" runat="server"
				Width="136px" Height="16px" Font-Names="Verdana" ForeColor="White" Font-Size="Small">Publisher</asp:label><asp:label id="Label4" style="Z-INDEX: 111; LEFT: 32px; POSITION: absolute; TOP: 352px" runat="server"
				Width="136px" Height="16px" Font-Names="Verdana" ForeColor="White" Font-Size="Small">Type</asp:label><asp:label id="Label3" style="Z-INDEX: 110; LEFT: 32px; POSITION: absolute; TOP: 288px" runat="server"
				Width="136px" Height="16px" Font-Names="Verdana" ForeColor="White" Font-Size="Small">By</asp:label><asp:label id="Label2" style="Z-INDEX: 109; LEFT: 32px; POSITION: absolute; TOP: 256px" runat="server"
				Width="136px" Height="16px" Font-Names="Verdana" ForeColor="White" Font-Size="Small">Title</asp:label><asp:label id="LabelTitle" style="Z-INDEX: 103; LEFT: 176px; POSITION: absolute; TOP: 144px"
				runat="server" Width="408px" Height="24px" Font-Names="Verdana" ForeColor="White">Book Detail :</asp:label><asp:image id="ImageTitle" style="Z-INDEX: 100; LEFT: 152px; POSITION: absolute; TOP: 0px"
				runat="server" Width="288px" Height="64px" ImageUrl="Image\ABOUTTITLE.GIF"></asp:image><asp:hyperlink id="HyperLink1" style="Z-INDEX: 102; LEFT: 464px; POSITION: absolute; TOP: 8px"
				runat="server" Width="136px" Height="16px" ForeColor="White" NavigateUrl="Home.aspx" Target="_self">Home</asp:hyperlink><asp:label id="Label1" style="Z-INDEX: 105; LEFT: 32px; POSITION: absolute; TOP: 192px" runat="server"
				Width="136px" Height="16px" Font-Names="Verdana" ForeColor="White" Font-Size="Small">DDC No</asp:label><asp:textbox id="TextBoxCallNo" style="Z-INDEX: 115; LEFT: 152px; POSITION: absolute; TOP: 192px"
				runat="server" Width="562px" Font-Names="Verdana" ReadOnly="True"></asp:textbox></form>
	</body>
</HTML>
