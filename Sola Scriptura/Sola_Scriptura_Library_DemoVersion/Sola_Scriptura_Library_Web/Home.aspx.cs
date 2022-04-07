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
	/// Summary description for Home.
	/// </summary>
	public class Home : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Image ImageLogo;
		protected System.Web.UI.WebControls.Label LabelSearch;
		protected System.Web.UI.WebControls.ImageButton ImageButtonEnter;
		protected System.Web.UI.WebControls.Image Image1;
		protected System.Web.UI.WebControls.Label LabelSearchTitle;
		protected System.Web.UI.WebControls.TextBox TextBoxSearch;
		protected System.Web.UI.WebControls.Image ImageTitle;
		protected System.Web.UI.WebControls.TextBox TextBox1;

		internal ClassDatabase MyClassDatabase;
		internal DataTable MyDataTable;
		protected System.Web.UI.WebControls.DataGrid DataGridSearchBook;
		protected System.Web.UI.WebControls.HyperLink HyperLink1;
		protected System.Web.UI.WebControls.HyperLink Hyperlink2;

		internal DataView MyDataView;
		
		private void Page_Load(object sender, System.EventArgs e)
		{
			MyClassDatabase = new ClassDatabase();
			if(this.Page.IsPostBack == true)
				MyClassDatabase = new ClassDatabase();
			else
				TextBoxSearch.Text = Session["SearchBook"].ToString();
			if(Session["SearchBook"].ToString()!="")
			{
					
				
				MyDataTable = MyClassDatabase.SearchBook(Session["SearchBook"].ToString());
				MyDataView = new DataView(MyDataTable);
				Session["DataTable"] = MyDataTable;
				DataGridSearchBook.DataSource = MyDataView;
				DataGridSearchBook.DataBind();
				LabelSearchTitle.Text = "";
				if(MyDataView.Count>0)
				{
					LabelSearchTitle.Text = "List of Books : ";
					DataGridSearchBook.Visible = true;
				}
				else
				{
					LabelSearchTitle.Text = "Book is not found !";
					DataGridSearchBook.Visible = false;
				}
				

			}
			else
			{
				DataGridSearchBook.Visible = false;
				Session["Sort"] = "DESC";
			}
			// Put user code to initialize the page here
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
			this.ImageButtonEnter.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButtonEnter_Click);
			this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
			this.DataGridSearchBook.ItemCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.DataGridSearchBook_Command);
			this.DataGridSearchBook.PageIndexChanged += new System.Web.UI.WebControls.DataGridPageChangedEventHandler(this.DataGridSearchBook_PageIndexChanged);
			this.DataGridSearchBook.SortCommand += new System.Web.UI.WebControls.DataGridSortCommandEventHandler(this.DataGridSearchBook_Sort);
			this.DataGridSearchBook.SelectedIndexChanged += new System.EventHandler(this.DataGridSearchBook_SelectedIndexChanged);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void ImageButtonEnter_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Session["SearchBook"] = TextBoxSearch.Text.ToString();
			if(Session["SearchBook"].ToString()!="")
			{
				
				DataGridSearchBook.CurrentPageIndex = 0;
				MyDataTable = MyClassDatabase.SearchBook(Session["SearchBook"].ToString());
				MyDataView = new DataView(MyDataTable);
				Session["DataTable"] = MyDataTable;
				DataGridSearchBook.DataSource = MyDataView;
				DataGridSearchBook.DataBind();
				LabelSearchTitle.Text = "List of Books : ";
				if(MyDataView.Count>0)
				{
					LabelSearchTitle.Text = "List of Books : ";
					DataGridSearchBook.Visible = true;
				}
				else
				{
					LabelSearchTitle.Text = "Book is not found !";
					DataGridSearchBook.Visible = false;
				}
				Session["Sort"] = "DESC";
			}
			else
			{
				LabelSearchTitle.Text = "Please enter the TextBox to search !";
				LabelSearchTitle.Visible = true;
				DataGridSearchBook.Visible = false;
			}
		}

		private void DataGridSearchBook_PageIndexChanged(Object sender, DataGridPageChangedEventArgs e)
		{
			DataGridSearchBook.CurrentPageIndex = e.NewPageIndex;			
			MyDataTable = (DataTable)Session["DataTable"];
			MyDataView = new DataView(MyDataTable);
			DataGridSearchBook.DataSource = MyDataView;
			DataGridSearchBook.DataBind();
			if(MyDataView.Count>0)
			{
				LabelSearchTitle.Text = "List of Books : ";
				DataGridSearchBook.Visible = true;
			}
			else
			{
				LabelSearchTitle.Text = "Book is not found !";
				DataGridSearchBook.Visible = false;
			}
		}
		private void DataGridSearchBook_Sort(Object sender, DataGridSortCommandEventArgs e)
		{ 
			if(Session["Sort"].ToString() == "ASC")
				Session["Sort"] = "DESC";
			else
				Session["Sort"] = "ASC";
			MyDataTable = (DataTable)Session["DataTable"];
			MyDataView = new DataView(MyDataTable);
			MyDataView.Sort = e.SortExpression + " " + Session["Sort"];
			DataGridSearchBook.DataSource = MyDataView;
			DataGridSearchBook.DataBind();
			if(MyDataView.Count>0)
			{
				LabelSearchTitle.Text = "List of Books : ";
				DataGridSearchBook.Visible = true;
			}
			else
			{
				LabelSearchTitle.Text = "Book is not found !";
				DataGridSearchBook.Visible = false;
			}
		}
		private void DataGridSearchBook_Command(Object sender, DataGridCommandEventArgs e)
		{
			if(((LinkButton)e.CommandSource).CommandName == "BookCodeClick")
			{
				string BookCode = ((LinkButton)e.CommandSource).Text.ToString();
				string MyURL;
				MyURL = "ShowBook.aspx?BookCode=" + BookCode + "";
				Response.Redirect(MyURL);
			}	

		}

		private void DataGridSearchBook_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}

		private void TextBoxSearch_TextChanged(object sender, System.EventArgs e)
		{
			Session["SearchBook"] = TextBoxSearch.Text.ToString();
		}

	}
}
