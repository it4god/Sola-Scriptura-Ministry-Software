using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
namespace Sola_Scriptura_Library
{
	public class FrmSearchJournal : Sola_Scriptura_Library.FrmSearchJournalMaster
	{
		internal System.Windows.Forms.Label LabelTitle;
		internal System.Windows.Forms.Label labelKeywords;
		internal System.Windows.Forms.TextBox textBoxAuthorName;
		internal System.Windows.Forms.Label labelAddress;
		internal System.Windows.Forms.Label labelJournalName;
		internal System.Windows.Forms.Button buttonClear;
		internal System.Windows.Forms.Button buttonSearch;
		internal System.Windows.Forms.Label labelInformation;
		internal System.Windows.Forms.TextBox textBoxKeyword;

		internal JournalSearch MyJournalSearch;
		internal ClassDatabase MyClassDatabase;
		internal DataTable MyDataTable;
		internal System.Windows.Forms.TextBox textBoxArticlesName;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyleJournalSearch;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnTitle;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnAuthorName1;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnAuthorName2;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnJournalName;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnSubject;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnJournalLanguage;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnJournalType;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnVolume;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnNumber;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnPublishYear;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnMonthSeason;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnCallNo;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnCallNo2;
		internal System.Windows.Forms.DataGrid dataGridJournalSearch;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnEnteredYear;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnPages;

		private System.ComponentModel.IContainer components = null;

		public FrmSearchJournal()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public FrmSearchJournal(FrmMDI MDIForm)
		{
			InitializeComponent();
			base.MyMDIForm = MDIForm;
			this.MdiParent = base.MyMDIForm;
			base.pictureBoxMainForm.SendToBack ();
					
		}
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmSearchJournal));
			this.LabelTitle = new System.Windows.Forms.Label();
			this.dataGridJournalSearch = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyleJournalSearch = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnTitle = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnAuthorName1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnAuthorName2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnSubject = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnJournalName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnJournalLanguage = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnJournalType = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnVolume = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnNumber = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnPages = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnPublishYear = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnMonthSeason = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnCallNo = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnCallNo2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnEnteredYear = new System.Windows.Forms.DataGridTextBoxColumn();
			this.textBoxKeyword = new System.Windows.Forms.TextBox();
			this.labelKeywords = new System.Windows.Forms.Label();
			this.textBoxAuthorName = new System.Windows.Forms.TextBox();
			this.labelAddress = new System.Windows.Forms.Label();
			this.textBoxArticlesName = new System.Windows.Forms.TextBox();
			this.labelJournalName = new System.Windows.Forms.Label();
			this.buttonClear = new System.Windows.Forms.Button();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.labelInformation = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridJournalSearch)).BeginInit();
			this.SuspendLayout();
			// 
			// LabelTitle
			// 
			this.LabelTitle.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.LabelTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.LabelTitle.Image = ((System.Drawing.Image)(resources.GetObject("LabelTitle.Image")));
			this.LabelTitle.Location = new System.Drawing.Point(792, 16);
			this.LabelTitle.Name = "LabelTitle";
			this.LabelTitle.Size = new System.Drawing.Size(192, 32);
			this.LabelTitle.TabIndex = 177;
			this.LabelTitle.Text = "    Search Journal";
			this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dataGridJournalSearch
			// 
			this.dataGridJournalSearch.DataMember = "";
			this.dataGridJournalSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGridJournalSearch.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridJournalSearch.Location = new System.Drawing.Point(248, 208);
			this.dataGridJournalSearch.Name = "dataGridJournalSearch";
			this.dataGridJournalSearch.ReadOnly = true;
			this.dataGridJournalSearch.Size = new System.Drawing.Size(672, 336);
			this.dataGridJournalSearch.TabIndex = 188;
			this.dataGridJournalSearch.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																											  this.dataGridTableStyleJournalSearch});
			this.dataGridJournalSearch.Click += new System.EventHandler(this.dataGridJournalSearch_Click);
			this.dataGridJournalSearch.DoubleClick += new System.EventHandler(this.dataGridJournalSearch_DoubleClick);
			// 
			// dataGridTableStyleJournalSearch
			// 
			this.dataGridTableStyleJournalSearch.AlternatingBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleJournalSearch.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.dataGridTableStyleJournalSearch.DataGrid = this.dataGridJournalSearch;
			this.dataGridTableStyleJournalSearch.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleJournalSearch.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																															  this.dataGridTextBoxColumnTitle,
																															  this.dataGridTextBoxColumnAuthorName1,
																															  this.dataGridTextBoxColumnAuthorName2,
																															  this.dataGridTextBoxColumnSubject,
																															  this.dataGridTextBoxColumnJournalName,
																															  this.dataGridTextBoxColumnJournalLanguage,
																															  this.dataGridTextBoxColumnJournalType,
																															  this.dataGridTextBoxColumnVolume,
																															  this.dataGridTextBoxColumnNumber,
																															  this.dataGridTextBoxColumnPages,
																															  this.dataGridTextBoxColumnPublishYear,
																															  this.dataGridTextBoxColumnMonthSeason,
																															  this.dataGridTextBoxColumnCallNo,
																															  this.dataGridTextBoxColumnCallNo2,
																															  this.dataGridTextBoxColumnEnteredYear});
			this.dataGridTableStyleJournalSearch.GridLineColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridTableStyleJournalSearch.HeaderBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleJournalSearch.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleJournalSearch.MappingName = "JournalSearch";
			// 
			// dataGridTextBoxColumnTitle
			// 
			this.dataGridTextBoxColumnTitle.Format = "";
			this.dataGridTextBoxColumnTitle.FormatInfo = null;
			this.dataGridTextBoxColumnTitle.HeaderText = "Title";
			this.dataGridTextBoxColumnTitle.MappingName = "Title";
			this.dataGridTextBoxColumnTitle.Width = 350;
			// 
			// dataGridTextBoxColumnAuthorName1
			// 
			this.dataGridTextBoxColumnAuthorName1.Format = "";
			this.dataGridTextBoxColumnAuthorName1.FormatInfo = null;
			this.dataGridTextBoxColumnAuthorName1.HeaderText = "Author Name ";
			this.dataGridTextBoxColumnAuthorName1.MappingName = "AuthorName";
			this.dataGridTextBoxColumnAuthorName1.Width = 150;
			// 
			// dataGridTextBoxColumnAuthorName2
			// 
			this.dataGridTextBoxColumnAuthorName2.Format = "";
			this.dataGridTextBoxColumnAuthorName2.FormatInfo = null;
			this.dataGridTextBoxColumnAuthorName2.HeaderText = "Author Name 2";
			this.dataGridTextBoxColumnAuthorName2.MappingName = "AuthorName2";
			this.dataGridTextBoxColumnAuthorName2.Width = 75;
			// 
			// dataGridTextBoxColumnSubject
			// 
			this.dataGridTextBoxColumnSubject.Format = "";
			this.dataGridTextBoxColumnSubject.FormatInfo = null;
			this.dataGridTextBoxColumnSubject.HeaderText = "Subject";
			this.dataGridTextBoxColumnSubject.MappingName = "Subject";
			this.dataGridTextBoxColumnSubject.Width = 75;
			// 
			// dataGridTextBoxColumnJournalName
			// 
			this.dataGridTextBoxColumnJournalName.Format = "";
			this.dataGridTextBoxColumnJournalName.FormatInfo = null;
			this.dataGridTextBoxColumnJournalName.HeaderText = "Journal Name";
			this.dataGridTextBoxColumnJournalName.MappingName = "JournalName";
			this.dataGridTextBoxColumnJournalName.Width = 250;
			// 
			// dataGridTextBoxColumnJournalLanguage
			// 
			this.dataGridTextBoxColumnJournalLanguage.Format = "";
			this.dataGridTextBoxColumnJournalLanguage.FormatInfo = null;
			this.dataGridTextBoxColumnJournalLanguage.HeaderText = "Language";
			this.dataGridTextBoxColumnJournalLanguage.MappingName = "JournalLanguage";
			this.dataGridTextBoxColumnJournalLanguage.Width = 50;
			// 
			// dataGridTextBoxColumnJournalType
			// 
			this.dataGridTextBoxColumnJournalType.Format = "";
			this.dataGridTextBoxColumnJournalType.FormatInfo = null;
			this.dataGridTextBoxColumnJournalType.HeaderText = "Type";
			this.dataGridTextBoxColumnJournalType.MappingName = "JournalType";
			this.dataGridTextBoxColumnJournalType.Width = 50;
			// 
			// dataGridTextBoxColumnVolume
			// 
			this.dataGridTextBoxColumnVolume.Format = "";
			this.dataGridTextBoxColumnVolume.FormatInfo = null;
			this.dataGridTextBoxColumnVolume.HeaderText = "Volume";
			this.dataGridTextBoxColumnVolume.MappingName = "Volume";
			this.dataGridTextBoxColumnVolume.Width = 50;
			// 
			// dataGridTextBoxColumnNumber
			// 
			this.dataGridTextBoxColumnNumber.Format = "";
			this.dataGridTextBoxColumnNumber.FormatInfo = null;
			this.dataGridTextBoxColumnNumber.HeaderText = "Number";
			this.dataGridTextBoxColumnNumber.MappingName = "Number";
			this.dataGridTextBoxColumnNumber.Width = 50;
			// 
			// dataGridTextBoxColumnPages
			// 
			this.dataGridTextBoxColumnPages.Format = "";
			this.dataGridTextBoxColumnPages.FormatInfo = null;
			this.dataGridTextBoxColumnPages.HeaderText = "Pages";
			this.dataGridTextBoxColumnPages.MappingName = "Pages";
			this.dataGridTextBoxColumnPages.Width = 75;
			// 
			// dataGridTextBoxColumnPublishYear
			// 
			this.dataGridTextBoxColumnPublishYear.Format = "";
			this.dataGridTextBoxColumnPublishYear.FormatInfo = null;
			this.dataGridTextBoxColumnPublishYear.HeaderText = "PublishYear";
			this.dataGridTextBoxColumnPublishYear.MappingName = "PublishYear";
			this.dataGridTextBoxColumnPublishYear.Width = 75;
			// 
			// dataGridTextBoxColumnMonthSeason
			// 
			this.dataGridTextBoxColumnMonthSeason.Format = "";
			this.dataGridTextBoxColumnMonthSeason.FormatInfo = null;
			this.dataGridTextBoxColumnMonthSeason.HeaderText = "Month/Season";
			this.dataGridTextBoxColumnMonthSeason.MappingName = "MonthSeason";
			this.dataGridTextBoxColumnMonthSeason.Width = 75;
			// 
			// dataGridTextBoxColumnCallNo
			// 
			this.dataGridTextBoxColumnCallNo.Format = "";
			this.dataGridTextBoxColumnCallNo.FormatInfo = null;
			this.dataGridTextBoxColumnCallNo.HeaderText = "CallNo";
			this.dataGridTextBoxColumnCallNo.MappingName = "CallNo";
			this.dataGridTextBoxColumnCallNo.Width = 75;
			// 
			// dataGridTextBoxColumnCallNo2
			// 
			this.dataGridTextBoxColumnCallNo2.Format = "";
			this.dataGridTextBoxColumnCallNo2.FormatInfo = null;
			this.dataGridTextBoxColumnCallNo2.HeaderText = "CallNo2";
			this.dataGridTextBoxColumnCallNo2.MappingName = "CallNo2";
			this.dataGridTextBoxColumnCallNo2.Width = 75;
			// 
			// dataGridTextBoxColumnEnteredYear
			// 
			this.dataGridTextBoxColumnEnteredYear.Format = "";
			this.dataGridTextBoxColumnEnteredYear.FormatInfo = null;
			this.dataGridTextBoxColumnEnteredYear.HeaderText = "EnteredYear";
			this.dataGridTextBoxColumnEnteredYear.MappingName = "EnteredYear";
			this.dataGridTextBoxColumnEnteredYear.Width = 75;
			// 
			// textBoxKeyword
			// 
			this.textBoxKeyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxKeyword.Location = new System.Drawing.Point(384, 144);
			this.textBoxKeyword.Name = "textBoxKeyword";
			this.textBoxKeyword.Size = new System.Drawing.Size(536, 22);
			this.textBoxKeyword.TabIndex = 181;
			this.textBoxKeyword.Text = "";
			this.textBoxKeyword.TextChanged += new System.EventHandler(this.textBoxKeyword_TextChanged);
			// 
			// labelKeywords
			// 
			this.labelKeywords.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelKeywords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelKeywords.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelKeywords.Location = new System.Drawing.Point(256, 144);
			this.labelKeywords.Name = "labelKeywords";
			this.labelKeywords.Size = new System.Drawing.Size(120, 24);
			this.labelKeywords.TabIndex = 186;
			this.labelKeywords.Text = "Keyword";
			// 
			// textBoxAuthorName
			// 
			this.textBoxAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxAuthorName.Location = new System.Drawing.Point(384, 112);
			this.textBoxAuthorName.Name = "textBoxAuthorName";
			this.textBoxAuthorName.Size = new System.Drawing.Size(536, 22);
			this.textBoxAuthorName.TabIndex = 180;
			this.textBoxAuthorName.Text = "";
			this.textBoxAuthorName.TextChanged += new System.EventHandler(this.textBoxAuthorName_TextChanged);
			// 
			// labelAddress
			// 
			this.labelAddress.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelAddress.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelAddress.Location = new System.Drawing.Point(256, 112);
			this.labelAddress.Name = "labelAddress";
			this.labelAddress.Size = new System.Drawing.Size(120, 24);
			this.labelAddress.TabIndex = 185;
			this.labelAddress.Text = "Author Name";
			// 
			// textBoxArticlesName
			// 
			this.textBoxArticlesName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxArticlesName.Location = new System.Drawing.Point(384, 80);
			this.textBoxArticlesName.Name = "textBoxArticlesName";
			this.textBoxArticlesName.Size = new System.Drawing.Size(536, 22);
			this.textBoxArticlesName.TabIndex = 179;
			this.textBoxArticlesName.Text = "";
			this.textBoxArticlesName.TextChanged += new System.EventHandler(this.textBoxArticlesName_TextChanged);
			// 
			// labelJournalName
			// 
			this.labelJournalName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelJournalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelJournalName.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelJournalName.Location = new System.Drawing.Point(256, 80);
			this.labelJournalName.Name = "labelJournalName";
			this.labelJournalName.Size = new System.Drawing.Size(120, 24);
			this.labelJournalName.TabIndex = 184;
			this.labelJournalName.Text = "Articles Name";
			// 
			// buttonClear
			// 
			this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonClear.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonClear.Image = ((System.Drawing.Image)(resources.GetObject("buttonClear.Image")));
			this.buttonClear.Location = new System.Drawing.Point(728, 176);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(88, 32);
			this.buttonClear.TabIndex = 189;
			this.buttonClear.Text = "Clear";
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// buttonSearch
			// 
			this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonSearch.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearch.Image")));
			this.buttonSearch.Location = new System.Drawing.Point(832, 176);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(88, 32);
			this.buttonSearch.TabIndex = 190;
			this.buttonSearch.Text = "Search";
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// labelInformation
			// 
			this.labelInformation.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelInformation.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelInformation.ForeColor = System.Drawing.Color.LightCoral;
			this.labelInformation.Location = new System.Drawing.Point(256, 184);
			this.labelInformation.Name = "labelInformation";
			this.labelInformation.Size = new System.Drawing.Size(456, 24);
			this.labelInformation.TabIndex = 191;
			this.labelInformation.Text = "Please click Journal in the DataGrid to show the journal\'s information !";
			// 
			// FrmSearchJournal
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.labelInformation);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.buttonSearch);
			this.Controls.Add(this.dataGridJournalSearch);
			this.Controls.Add(this.textBoxKeyword);
			this.Controls.Add(this.labelKeywords);
			this.Controls.Add(this.textBoxAuthorName);
			this.Controls.Add(this.labelAddress);
			this.Controls.Add(this.textBoxArticlesName);
			this.Controls.Add(this.labelJournalName);
			this.Controls.Add(this.LabelTitle);
			this.Name = "FrmSearchJournal";
			this.Load += new System.EventHandler(this.FrmSearchJournal_Load);
			this.Controls.SetChildIndex(this.LabelTitle, 0);
			this.Controls.SetChildIndex(this.labelJournalName, 0);
			this.Controls.SetChildIndex(this.textBoxArticlesName, 0);
			this.Controls.SetChildIndex(this.labelAddress, 0);
			this.Controls.SetChildIndex(this.textBoxAuthorName, 0);
			this.Controls.SetChildIndex(this.labelKeywords, 0);
			this.Controls.SetChildIndex(this.textBoxKeyword, 0);
			this.Controls.SetChildIndex(this.dataGridJournalSearch, 0);
			this.Controls.SetChildIndex(this.buttonSearch, 0);
			this.Controls.SetChildIndex(this.buttonClear, 0);
			this.Controls.SetChildIndex(this.labelInformation, 0);
			((System.ComponentModel.ISupportInitialize)(this.dataGridJournalSearch)).EndInit();
			this.ResumeLayout(false);

		}
	
		#endregion
	
		private void buttonSearch_Click(object sender, System.EventArgs e)
		{
			if(textBoxArticlesName.Text.ToString()=="" && textBoxAuthorName.Text.ToString() == "" && textBoxKeyword.Text.ToString() == "")
			{
				MessageBox.Show("Please input the criteria for searching Journals !","Information");
			}
			else
			{
				MyClassDatabase = new ClassDatabase();
				MyDataTable = MyClassDatabase.GetJournalSearch(MyJournalSearch);
				dataGridJournalSearch.DataSource = MyDataTable;
			}
		}
		private void buttonClear_Click(object sender, System.EventArgs e)
		{
			textBoxArticlesName.Text = "";
			textBoxAuthorName.Text = "";
			textBoxKeyword.Text = "";
		}

		private void FrmSearchJournal_Load(object sender, System.EventArgs e)
		{
			MyJournalSearch = new JournalSearch();
			MyClassDatabase = new ClassDatabase();
			MyDataTable = new DataTable();
			
		}

		private void textBoxArticlesName_TextChanged(object sender, System.EventArgs e)
		{
			MyJournalSearch.ArticlesNames = textBoxArticlesName.Text.ToString();
		}

		private void textBoxAuthorName_TextChanged(object sender, System.EventArgs e)
		{
			MyJournalSearch.AuthorName = textBoxAuthorName.Text.ToString();
		}

		private void textBoxKeyword_TextChanged(object sender, System.EventArgs e)
		{
			MyJournalSearch.Keyword = textBoxKeyword.Text.ToString();
		}
		private void dataGridJournalSearch_Click(object sender, System.EventArgs e)
		{
			if(MyDataTable.Rows.Count>0)
			{
				
				MyMDIForm.MyJournalArticles.Title   = dataGridJournalSearch[dataGridJournalSearch.CurrentRowIndex,0].ToString();
				MyMDIForm.MyJournalArticles.AuthorName    = dataGridJournalSearch[dataGridJournalSearch.CurrentRowIndex,1].ToString();
				MyMDIForm.MyJournalArticles.AuthorName2    = dataGridJournalSearch[dataGridJournalSearch.CurrentRowIndex,2].ToString();
				MyMDIForm.MyJournalArticles.Subject    = dataGridJournalSearch[dataGridJournalSearch.CurrentRowIndex,3].ToString();
				MyMDIForm.MyJournalArticles.JournalName    = dataGridJournalSearch[dataGridJournalSearch.CurrentRowIndex,4].ToString();
				MyMDIForm.MyJournalArticles.JournalLanguage    = dataGridJournalSearch[dataGridJournalSearch.CurrentRowIndex,5].ToString();
				MyMDIForm.MyJournalArticles.JournalType    = dataGridJournalSearch[dataGridJournalSearch.CurrentRowIndex,6].ToString();
				
				MyMDIForm.MyJournalArticles.Volume    = dataGridJournalSearch[dataGridJournalSearch.CurrentRowIndex,7].ToString();
				MyMDIForm.MyJournalArticles.Number     = dataGridJournalSearch[dataGridJournalSearch.CurrentRowIndex,8].ToString();
				MyMDIForm.MyJournalArticles.Pages    = dataGridJournalSearch[dataGridJournalSearch.CurrentRowIndex,9].ToString();
				
				MyMDIForm.MyJournalArticles.PublishYear     = dataGridJournalSearch[dataGridJournalSearch.CurrentRowIndex,10].ToString();
				MyMDIForm.MyJournalArticles.MonthSeason     = dataGridJournalSearch[dataGridJournalSearch.CurrentRowIndex,11].ToString();
				MyMDIForm.MyJournalArticles.CallNo    = dataGridJournalSearch[dataGridJournalSearch.CurrentRowIndex,12].ToString();
				MyMDIForm.MyJournalArticles.CallNo2     = dataGridJournalSearch[dataGridJournalSearch.CurrentRowIndex,13].ToString();
				MyMDIForm.MyJournalArticles.EnteredYear    = dataGridJournalSearch[dataGridJournalSearch.CurrentRowIndex,14].ToString();
		
			}
		}
		private void dataGridJournalSearch_DoubleClick(object sender, System.EventArgs e)
		{
			
			if(MyDataTable.Rows.Count>0)
			{
				this.Hide();
				MyMDIForm.MySearchForm.MyShowJournalForm = new FrmShowJournal(this.MyMDIForm);
				MyMDIForm.MySearchForm.MyShowJournalForm.Show();
				MyMDIForm.MySearchForm.MyShowJournalForm.buttonShowJournal.Focus();

			}	
		}

	
	}
}

