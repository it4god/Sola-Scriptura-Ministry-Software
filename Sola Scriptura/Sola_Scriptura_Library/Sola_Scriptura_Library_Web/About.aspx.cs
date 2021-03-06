using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace Sola_Scriptura_Library_Web
{
	/// <summary>
	/// Summary description for WebForm1.
	/// </summary>
	public class About : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Image ImageLogo;
		protected System.Web.UI.WebControls.Image ImageTitle;
		protected System.Web.UI.WebControls.HyperLink HyperLink1;
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.Label Label2;
		protected System.Web.UI.WebControls.Label Label3;
		protected System.Web.UI.WebControls.Image ImageWelcome;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
			Label1.Text = "Sola Scriptura Library System provides users with full flexibility to use the system. This system was made to ease the user and provides complete function that required to run the library.";
			
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void ImageButtonEnter_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Session["SearchBook"] = "";
			Response.Redirect("Home.aspx");
		}
	}
}
