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
	/// Summary description for ShowBook.
	/// </summary>
	public class ShowBook : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Image ImageTitle;
		protected System.Web.UI.WebControls.Image ImageLogo;
		protected System.Web.UI.WebControls.Label LabelTitle;
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.Label Label2;
		protected System.Web.UI.WebControls.Label Label3;
		protected System.Web.UI.WebControls.Label Label4;
		protected System.Web.UI.WebControls.Label Label5;
		protected System.Web.UI.WebControls.Label Label6;
		protected System.Web.UI.WebControls.Label Label7;
		protected System.Web.UI.WebControls.TextBox TextBoxCallNo;
		protected System.Web.UI.WebControls.TextBox TextBoxTitle;
		protected System.Web.UI.WebControls.TextBox TextBoxBy;
		protected System.Web.UI.WebControls.TextBox TextBoxType;
		protected System.Web.UI.WebControls.TextBox TextBoxPublisher;
		protected System.Web.UI.WebControls.TextBox TextBoxISBN;
		protected System.Web.UI.WebControls.TextBox TextBoxSubject;
		protected System.Web.UI.WebControls.HyperLink HyperLink1;
		
		internal string BookCode;
		internal ClassDatabase MyClassDatabase;
		protected System.Web.UI.WebControls.ImageButton ImageButtonEnter;
		protected System.Web.UI.WebControls.TextBox TextBoxSearch;
		protected System.Web.UI.WebControls.Label LabelSearch;
		protected System.Web.UI.WebControls.Label Label9;
		protected System.Web.UI.WebControls.TextBox TextBoxLCNo;
		internal DataTable MyDataTable;

		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here

			if(this.Page.IsPostBack ==true)
				MyClassDatabase = new ClassDatabase();
			else
				TextBoxSearch.Text = Session["SearchBook"].ToString();
			BookCode = Request["BookCode"].Trim();
			MyClassDatabase = new ClassDatabase();
			MyDataTable = MyClassDatabase.GetBook(BookCode);
 			TextBoxCallNo.Text = MyDataTable.Rows[0]["DDC"] .ToString();
			TextBoxLCNo.Text = MyDataTable.Rows[0]["LC"].ToString();
			TextBoxTitle.Text = MyDataTable.Rows[0]["BookName"].ToString();
			TextBoxType.Text = MyDataTable.Rows[0]["BookType"].ToString();
			TextBoxPublisher.Text = MyDataTable.Rows[0]["PublisherName"].ToString();
			TextBoxISBN.Text = MyDataTable.Rows[0]["ISBN"].ToString();
			MyClassDatabase = new ClassDatabase();
			MyDataTable = MyClassDatabase.GetAuthor(BookCode);
			string MyAuthor = "";
			for(int x=0;x<MyDataTable.Rows.Count;x++)
			{
				MyAuthor = MyAuthor + MyDataTable.Rows[x][0].ToString().Trim() + " " + MyDataTable.Rows[x][1].ToString().Trim() + "; ";
			}
			TextBoxBy.Text = MyAuthor;

			MyClassDatabase = new ClassDatabase();
			MyDataTable = MyClassDatabase.GetSubject(BookCode);
			string MySubject = "";
			for(int x=0;x<MyDataTable.Rows.Count;x++)
			{
				MySubject = MySubject + MyDataTable.Rows[x][0].ToString().Trim() + "; ";
			}
			TextBoxSubject.Text =MySubject;
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
			this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
			this.ImageButtonEnter.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButtonEnter_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void ImageButtonEnter_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			if(TextBoxSearch.Text!="")
			{
				string MyURL;
				Session["SearchBook"] = TextBoxSearch.Text.ToString();
				MyURL = "Home.aspx";
				Response.Redirect(MyURL);
			}
		}

		private void TextBoxSearch_TextChanged(object sender, System.EventArgs e)
		{
		
		}
	}
}
