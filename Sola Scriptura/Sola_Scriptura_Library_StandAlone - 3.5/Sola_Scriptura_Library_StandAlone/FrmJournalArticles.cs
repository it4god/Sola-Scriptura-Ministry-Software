using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
namespace Sola_Scriptura_Library
{
	public class FrmJournalArticles : Sola_Scriptura_Library.FrmJournalMaster
	{
		internal System.Windows.Forms.TextBox textBoxCallNo2;
		internal System.Windows.Forms.Label labelCallNo2;
		internal System.Windows.Forms.TextBox textBoxCallNo;
		internal System.Windows.Forms.Label labelCallNo;
		internal System.Windows.Forms.TextBox textBoxMonthSeason;
		internal System.Windows.Forms.Label labelMonthSeason;
		internal System.Windows.Forms.TextBox textBoxPublishYear;
		internal System.Windows.Forms.Label labelPublishYear;
		internal System.Windows.Forms.TextBox textBoxNumber;
		internal System.Windows.Forms.Label labelNumber;
		internal System.Windows.Forms.TextBox textBoxVolume;
		internal System.Windows.Forms.Label labelVolume;
		internal System.Windows.Forms.TextBox textBoxJournalDetailID;
		internal System.Windows.Forms.Label labelJournalDetailID;
		internal System.Windows.Forms.Label LabelTitle;
		internal System.Windows.Forms.Button buttonCancel;
		internal System.Windows.Forms.TextBox textBoxJournalName;
		internal System.Windows.Forms.Label labelJournalName;
		internal System.Windows.Forms.TextBox textBoxJournalID;
		internal System.Windows.Forms.Label labelJournalID;
		internal System.Windows.Forms.Button buttonSave;
		internal System.Windows.Forms.Button buttonDelete;
		internal System.Windows.Forms.Button buttonEdit;
		internal System.Windows.Forms.Button buttonAdd;
		internal System.Windows.Forms.Label label4;
		internal System.Windows.Forms.TextBox textBoxAuthorName2;
		internal System.Windows.Forms.Label labelAuthorName2;
		internal System.Windows.Forms.TextBox textBoxAuthorName;
		internal System.Windows.Forms.Label labelAuthorName;
		internal System.Windows.Forms.TextBox textBoxSubject;
		internal System.Windows.Forms.Label labelSubject;
		internal System.Windows.Forms.TextBox textBoxTitle;
		internal System.Windows.Forms.Label labelPages;
		internal System.Windows.Forms.TextBox textBoxPages;
		private System.ComponentModel.IContainer components = null;

		internal ClassDatabase MyClassDatabase;
		internal DataTable MyDataTable;
		internal bool CanDelete;
		internal string StatusAction;
		internal System.Windows.Forms.DataGrid dataGridJournalArticles;
		internal System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnJournalDetailID;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnPages;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnTitle;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnAuthorName;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnAuthorName2;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnSubject;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnUpdateUser;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnUpdateDate;
		internal Journal MyJournal;

		public FrmJournalArticles()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public FrmJournalArticles(FrmMDI MDIForm, FrmBookMenu BookMenuForm)
		{
			InitializeComponent();
			base.MyMDIForm = MDIForm;
			base.MyBookMenuForm = BookMenuForm;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmJournalArticles));
			this.textBoxCallNo2 = new System.Windows.Forms.TextBox();
			this.labelCallNo2 = new System.Windows.Forms.Label();
			this.textBoxCallNo = new System.Windows.Forms.TextBox();
			this.labelCallNo = new System.Windows.Forms.Label();
			this.textBoxMonthSeason = new System.Windows.Forms.TextBox();
			this.labelMonthSeason = new System.Windows.Forms.Label();
			this.textBoxPublishYear = new System.Windows.Forms.TextBox();
			this.labelPublishYear = new System.Windows.Forms.Label();
			this.textBoxNumber = new System.Windows.Forms.TextBox();
			this.labelNumber = new System.Windows.Forms.Label();
			this.textBoxVolume = new System.Windows.Forms.TextBox();
			this.labelVolume = new System.Windows.Forms.Label();
			this.textBoxJournalDetailID = new System.Windows.Forms.TextBox();
			this.labelJournalDetailID = new System.Windows.Forms.Label();
			this.LabelTitle = new System.Windows.Forms.Label();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.textBoxJournalName = new System.Windows.Forms.TextBox();
			this.labelJournalName = new System.Windows.Forms.Label();
			this.textBoxJournalID = new System.Windows.Forms.TextBox();
			this.labelJournalID = new System.Windows.Forms.Label();
			this.dataGridJournalArticles = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnJournalDetailID = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnPages = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnTitle = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnAuthorName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnAuthorName2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnSubject = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnUpdateUser = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnUpdateDate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.textBoxAuthorName2 = new System.Windows.Forms.TextBox();
			this.labelAuthorName2 = new System.Windows.Forms.Label();
			this.textBoxAuthorName = new System.Windows.Forms.TextBox();
			this.labelAuthorName = new System.Windows.Forms.Label();
			this.textBoxSubject = new System.Windows.Forms.TextBox();
			this.labelSubject = new System.Windows.Forms.Label();
			this.textBoxTitle = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.labelPages = new System.Windows.Forms.Label();
			this.textBoxPages = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridJournalArticles)).BeginInit();
			this.SuspendLayout();
			// 
			// textBoxCallNo2
			// 
			this.textBoxCallNo2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxCallNo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxCallNo2.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxCallNo2.Location = new System.Drawing.Point(720, 208);
			this.textBoxCallNo2.Name = "textBoxCallNo2";
			this.textBoxCallNo2.Size = new System.Drawing.Size(200, 22);
			this.textBoxCallNo2.TabIndex = 244;
			this.textBoxCallNo2.Text = "";
			// 
			// labelCallNo2
			// 
			this.labelCallNo2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelCallNo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelCallNo2.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelCallNo2.Location = new System.Drawing.Point(600, 208);
			this.labelCallNo2.Name = "labelCallNo2";
			this.labelCallNo2.Size = new System.Drawing.Size(120, 24);
			this.labelCallNo2.TabIndex = 245;
			this.labelCallNo2.Text = "Call No 2";
			// 
			// textBoxCallNo
			// 
			this.textBoxCallNo.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxCallNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxCallNo.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxCallNo.Location = new System.Drawing.Point(384, 208);
			this.textBoxCallNo.Name = "textBoxCallNo";
			this.textBoxCallNo.Size = new System.Drawing.Size(200, 22);
			this.textBoxCallNo.TabIndex = 242;
			this.textBoxCallNo.Text = "";
			// 
			// labelCallNo
			// 
			this.labelCallNo.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelCallNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelCallNo.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelCallNo.Location = new System.Drawing.Point(256, 208);
			this.labelCallNo.Name = "labelCallNo";
			this.labelCallNo.Size = new System.Drawing.Size(120, 24);
			this.labelCallNo.TabIndex = 243;
			this.labelCallNo.Text = "Call No";
			// 
			// textBoxMonthSeason
			// 
			this.textBoxMonthSeason.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxMonthSeason.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxMonthSeason.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxMonthSeason.Location = new System.Drawing.Point(720, 176);
			this.textBoxMonthSeason.Name = "textBoxMonthSeason";
			this.textBoxMonthSeason.Size = new System.Drawing.Size(200, 22);
			this.textBoxMonthSeason.TabIndex = 240;
			this.textBoxMonthSeason.Text = "";
			// 
			// labelMonthSeason
			// 
			this.labelMonthSeason.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelMonthSeason.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelMonthSeason.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelMonthSeason.Location = new System.Drawing.Point(600, 176);
			this.labelMonthSeason.Name = "labelMonthSeason";
			this.labelMonthSeason.Size = new System.Drawing.Size(120, 24);
			this.labelMonthSeason.TabIndex = 241;
			this.labelMonthSeason.Text = "Month / Season";
			// 
			// textBoxPublishYear
			// 
			this.textBoxPublishYear.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxPublishYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxPublishYear.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxPublishYear.Location = new System.Drawing.Point(384, 176);
			this.textBoxPublishYear.Name = "textBoxPublishYear";
			this.textBoxPublishYear.Size = new System.Drawing.Size(200, 22);
			this.textBoxPublishYear.TabIndex = 238;
			this.textBoxPublishYear.Text = "";
			// 
			// labelPublishYear
			// 
			this.labelPublishYear.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelPublishYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelPublishYear.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelPublishYear.Location = new System.Drawing.Point(256, 176);
			this.labelPublishYear.Name = "labelPublishYear";
			this.labelPublishYear.Size = new System.Drawing.Size(120, 24);
			this.labelPublishYear.TabIndex = 239;
			this.labelPublishYear.Text = "Publish Year";
			// 
			// textBoxNumber
			// 
			this.textBoxNumber.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxNumber.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxNumber.Location = new System.Drawing.Point(720, 144);
			this.textBoxNumber.Name = "textBoxNumber";
			this.textBoxNumber.Size = new System.Drawing.Size(200, 22);
			this.textBoxNumber.TabIndex = 236;
			this.textBoxNumber.Text = "";
			// 
			// labelNumber
			// 
			this.labelNumber.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelNumber.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelNumber.Location = new System.Drawing.Point(600, 144);
			this.labelNumber.Name = "labelNumber";
			this.labelNumber.Size = new System.Drawing.Size(120, 24);
			this.labelNumber.TabIndex = 237;
			this.labelNumber.Text = "Number";
			// 
			// textBoxVolume
			// 
			this.textBoxVolume.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxVolume.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxVolume.Location = new System.Drawing.Point(384, 144);
			this.textBoxVolume.Name = "textBoxVolume";
			this.textBoxVolume.Size = new System.Drawing.Size(200, 22);
			this.textBoxVolume.TabIndex = 234;
			this.textBoxVolume.Text = "";
			// 
			// labelVolume
			// 
			this.labelVolume.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelVolume.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelVolume.Location = new System.Drawing.Point(256, 144);
			this.labelVolume.Name = "labelVolume";
			this.labelVolume.Size = new System.Drawing.Size(120, 24);
			this.labelVolume.TabIndex = 235;
			this.labelVolume.Text = "Volume";
			// 
			// textBoxJournalDetailID
			// 
			this.textBoxJournalDetailID.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxJournalDetailID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxJournalDetailID.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxJournalDetailID.Location = new System.Drawing.Point(720, 80);
			this.textBoxJournalDetailID.Name = "textBoxJournalDetailID";
			this.textBoxJournalDetailID.Size = new System.Drawing.Size(200, 22);
			this.textBoxJournalDetailID.TabIndex = 232;
			this.textBoxJournalDetailID.Text = "";
			// 
			// labelJournalDetailID
			// 
			this.labelJournalDetailID.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelJournalDetailID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelJournalDetailID.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelJournalDetailID.Location = new System.Drawing.Point(592, 80);
			this.labelJournalDetailID.Name = "labelJournalDetailID";
			this.labelJournalDetailID.Size = new System.Drawing.Size(120, 24);
			this.labelJournalDetailID.TabIndex = 233;
			this.labelJournalDetailID.Text = "JournalDetailID";
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
			this.LabelTitle.TabIndex = 231;
			this.LabelTitle.Text = "    Journal Detail";
			this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// buttonCancel
			// 
			this.buttonCancel.Enabled = false;
			this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonCancel.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonCancel.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancel.Image")));
			this.buttonCancel.Location = new System.Drawing.Point(832, 520);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(88, 32);
			this.buttonCancel.TabIndex = 10;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// textBoxJournalName
			// 
			this.textBoxJournalName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxJournalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxJournalName.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxJournalName.Location = new System.Drawing.Point(384, 112);
			this.textBoxJournalName.Name = "textBoxJournalName";
			this.textBoxJournalName.Size = new System.Drawing.Size(536, 22);
			this.textBoxJournalName.TabIndex = 226;
			this.textBoxJournalName.Text = "";
			// 
			// labelJournalName
			// 
			this.labelJournalName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelJournalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelJournalName.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelJournalName.Location = new System.Drawing.Point(256, 112);
			this.labelJournalName.Name = "labelJournalName";
			this.labelJournalName.Size = new System.Drawing.Size(120, 24);
			this.labelJournalName.TabIndex = 229;
			this.labelJournalName.Text = "Journal Name";
			// 
			// textBoxJournalID
			// 
			this.textBoxJournalID.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxJournalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxJournalID.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxJournalID.Location = new System.Drawing.Point(384, 80);
			this.textBoxJournalID.Name = "textBoxJournalID";
			this.textBoxJournalID.Size = new System.Drawing.Size(200, 22);
			this.textBoxJournalID.TabIndex = 225;
			this.textBoxJournalID.Text = "";
			// 
			// labelJournalID
			// 
			this.labelJournalID.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelJournalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelJournalID.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelJournalID.Location = new System.Drawing.Point(256, 80);
			this.labelJournalID.Name = "labelJournalID";
			this.labelJournalID.Size = new System.Drawing.Size(120, 24);
			this.labelJournalID.TabIndex = 228;
			this.labelJournalID.Text = "Journal ID";
			// 
			// dataGridJournalArticles
			// 
			this.dataGridJournalArticles.DataMember = "";
			this.dataGridJournalArticles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGridJournalArticles.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridJournalArticles.Location = new System.Drawing.Point(248, 240);
			this.dataGridJournalArticles.Name = "dataGridJournalArticles";
			this.dataGridJournalArticles.ReadOnly = true;
			this.dataGridJournalArticles.Size = new System.Drawing.Size(672, 176);
			this.dataGridJournalArticles.TabIndex = 246;
			this.dataGridJournalArticles.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																												this.dataGridTableStyle1});
			this.dataGridJournalArticles.Click += new System.EventHandler(this.dataGridJournalArticles_Click);
			this.dataGridJournalArticles.DoubleClick += new System.EventHandler(this.dataGridJournalArticles_DoubleClick);
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyle1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.dataGridTableStyle1.DataGrid = this.dataGridJournalArticles;
			this.dataGridTableStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.dataGridTextBoxColumnJournalDetailID,
																												  this.dataGridTextBoxColumnPages,
																												  this.dataGridTextBoxColumnTitle,
																												  this.dataGridTextBoxColumnAuthorName,
																												  this.dataGridTextBoxColumnAuthorName2,
																												  this.dataGridTextBoxColumnSubject,
																												  this.dataGridTextBoxColumnUpdateUser,
																												  this.dataGridTextBoxColumnUpdateDate});
			this.dataGridTableStyle1.GridLineColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridTableStyle1.HeaderBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyle1.MappingName = "JournalArticles";
			// 
			// dataGridTextBoxColumnJournalDetailID
			// 
			this.dataGridTextBoxColumnJournalDetailID.Format = "";
			this.dataGridTextBoxColumnJournalDetailID.FormatInfo = null;
			this.dataGridTextBoxColumnJournalDetailID.MappingName = "JournalDetailID";
			this.dataGridTextBoxColumnJournalDetailID.Width = 0;
			// 
			// dataGridTextBoxColumnPages
			// 
			this.dataGridTextBoxColumnPages.Format = "";
			this.dataGridTextBoxColumnPages.FormatInfo = null;
			this.dataGridTextBoxColumnPages.HeaderText = "Pages";
			this.dataGridTextBoxColumnPages.MappingName = "Pages";
			this.dataGridTextBoxColumnPages.Width = 75;
			// 
			// dataGridTextBoxColumnTitle
			// 
			this.dataGridTextBoxColumnTitle.Format = "";
			this.dataGridTextBoxColumnTitle.FormatInfo = null;
			this.dataGridTextBoxColumnTitle.HeaderText = "Title";
			this.dataGridTextBoxColumnTitle.MappingName = "Title";
			this.dataGridTextBoxColumnTitle.Width = 300;
			// 
			// dataGridTextBoxColumnAuthorName
			// 
			this.dataGridTextBoxColumnAuthorName.Format = "";
			this.dataGridTextBoxColumnAuthorName.FormatInfo = null;
			this.dataGridTextBoxColumnAuthorName.HeaderText = "Author Name";
			this.dataGridTextBoxColumnAuthorName.MappingName = "AuthorName";
			this.dataGridTextBoxColumnAuthorName.Width = 170;
			// 
			// dataGridTextBoxColumnAuthorName2
			// 
			this.dataGridTextBoxColumnAuthorName2.Format = "";
			this.dataGridTextBoxColumnAuthorName2.FormatInfo = null;
			this.dataGridTextBoxColumnAuthorName2.HeaderText = "Author Name 2";
			this.dataGridTextBoxColumnAuthorName2.MappingName = "AuthorName2";
			this.dataGridTextBoxColumnAuthorName2.Width = 150;
			// 
			// dataGridTextBoxColumnSubject
			// 
			this.dataGridTextBoxColumnSubject.Format = "";
			this.dataGridTextBoxColumnSubject.FormatInfo = null;
			this.dataGridTextBoxColumnSubject.HeaderText = "Subject";
			this.dataGridTextBoxColumnSubject.MappingName = "Subject";
			this.dataGridTextBoxColumnSubject.Width = 150;
			// 
			// dataGridTextBoxColumnUpdateUser
			// 
			this.dataGridTextBoxColumnUpdateUser.Format = "";
			this.dataGridTextBoxColumnUpdateUser.FormatInfo = null;
			this.dataGridTextBoxColumnUpdateUser.HeaderText = "Update User";
			this.dataGridTextBoxColumnUpdateUser.MappingName = "UpdateUser";
			this.dataGridTextBoxColumnUpdateUser.Width = 75;
			// 
			// dataGridTextBoxColumnUpdateDate
			// 
			this.dataGridTextBoxColumnUpdateDate.Format = "";
			this.dataGridTextBoxColumnUpdateDate.FormatInfo = null;
			this.dataGridTextBoxColumnUpdateDate.HeaderText = "Update Date";
			this.dataGridTextBoxColumnUpdateDate.MappingName = "UpdateDate";
			this.dataGridTextBoxColumnUpdateDate.Width = 75;
			// 
			// buttonSave
			// 
			this.buttonSave.Enabled = false;
			this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonSave.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
			this.buttonSave.Location = new System.Drawing.Point(728, 520);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(88, 32);
			this.buttonSave.TabIndex = 9;
			this.buttonSave.Text = "Save";
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Enabled = false;
			this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonDelete.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
			this.buttonDelete.Location = new System.Drawing.Point(456, 520);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(88, 32);
			this.buttonDelete.TabIndex = 8;
			this.buttonDelete.Text = "Delete";
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// buttonEdit
			// 
			this.buttonEdit.Enabled = false;
			this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonEdit.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonEdit.Image = ((System.Drawing.Image)(resources.GetObject("buttonEdit.Image")));
			this.buttonEdit.Location = new System.Drawing.Point(352, 520);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(88, 32);
			this.buttonEdit.TabIndex = 7;
			this.buttonEdit.Text = "Edit";
			this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonAdd.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonAdd.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd.Image")));
			this.buttonAdd.Location = new System.Drawing.Point(248, 520);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(88, 32);
			this.buttonAdd.TabIndex = 6;
			this.buttonAdd.Text = "Add New";
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// textBoxAuthorName2
			// 
			this.textBoxAuthorName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxAuthorName2.Location = new System.Drawing.Point(720, 488);
			this.textBoxAuthorName2.Name = "textBoxAuthorName2";
			this.textBoxAuthorName2.Size = new System.Drawing.Size(200, 22);
			this.textBoxAuthorName2.TabIndex = 5;
			this.textBoxAuthorName2.Text = "";
			this.textBoxAuthorName2.TextChanged += new System.EventHandler(this.textBoxAuthorName2_TextChanged);
			// 
			// labelAuthorName2
			// 
			this.labelAuthorName2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelAuthorName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelAuthorName2.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelAuthorName2.Location = new System.Drawing.Point(600, 488);
			this.labelAuthorName2.Name = "labelAuthorName2";
			this.labelAuthorName2.Size = new System.Drawing.Size(120, 24);
			this.labelAuthorName2.TabIndex = 261;
			this.labelAuthorName2.Text = "Author Name 2";
			// 
			// textBoxAuthorName
			// 
			this.textBoxAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxAuthorName.Location = new System.Drawing.Point(384, 488);
			this.textBoxAuthorName.Name = "textBoxAuthorName";
			this.textBoxAuthorName.Size = new System.Drawing.Size(200, 22);
			this.textBoxAuthorName.TabIndex = 4;
			this.textBoxAuthorName.Text = "";
			this.textBoxAuthorName.TextChanged += new System.EventHandler(this.textBoxAuthorName_TextChanged);
			// 
			// labelAuthorName
			// 
			this.labelAuthorName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelAuthorName.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelAuthorName.Location = new System.Drawing.Point(256, 488);
			this.labelAuthorName.Name = "labelAuthorName";
			this.labelAuthorName.Size = new System.Drawing.Size(120, 24);
			this.labelAuthorName.TabIndex = 259;
			this.labelAuthorName.Text = "Author Name";
			// 
			// textBoxSubject
			// 
			this.textBoxSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxSubject.Location = new System.Drawing.Point(720, 424);
			this.textBoxSubject.Name = "textBoxSubject";
			this.textBoxSubject.Size = new System.Drawing.Size(200, 22);
			this.textBoxSubject.TabIndex = 2;
			this.textBoxSubject.Text = "";
			this.textBoxSubject.TextChanged += new System.EventHandler(this.textBoxSubject_TextChanged);
			// 
			// labelSubject
			// 
			this.labelSubject.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelSubject.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelSubject.Location = new System.Drawing.Point(600, 424);
			this.labelSubject.Name = "labelSubject";
			this.labelSubject.Size = new System.Drawing.Size(120, 24);
			this.labelSubject.TabIndex = 257;
			this.labelSubject.Text = "Subject";
			// 
			// textBoxTitle
			// 
			this.textBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxTitle.Location = new System.Drawing.Point(384, 456);
			this.textBoxTitle.Name = "textBoxTitle";
			this.textBoxTitle.Size = new System.Drawing.Size(536, 22);
			this.textBoxTitle.TabIndex = 3;
			this.textBoxTitle.Text = "";
			this.textBoxTitle.TextChanged += new System.EventHandler(this.textBoxTitle_TextChanged);
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label4.Location = new System.Drawing.Point(256, 456);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(120, 24);
			this.label4.TabIndex = 255;
			this.label4.Text = "Title";
			// 
			// labelPages
			// 
			this.labelPages.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelPages.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelPages.Location = new System.Drawing.Point(256, 424);
			this.labelPages.Name = "labelPages";
			this.labelPages.Size = new System.Drawing.Size(120, 24);
			this.labelPages.TabIndex = 253;
			this.labelPages.Text = "Pages";
			// 
			// textBoxPages
			// 
			this.textBoxPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxPages.Location = new System.Drawing.Point(384, 424);
			this.textBoxPages.Name = "textBoxPages";
			this.textBoxPages.Size = new System.Drawing.Size(200, 22);
			this.textBoxPages.TabIndex = 1;
			this.textBoxPages.Text = "";
			this.textBoxPages.TextChanged += new System.EventHandler(this.textBoxPages_TextChanged);
			// 
			// FrmJournalArticles
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.textBoxPages);
			this.Controls.Add(this.textBoxAuthorName2);
			this.Controls.Add(this.labelAuthorName2);
			this.Controls.Add(this.textBoxAuthorName);
			this.Controls.Add(this.labelAuthorName);
			this.Controls.Add(this.textBoxSubject);
			this.Controls.Add(this.labelSubject);
			this.Controls.Add(this.textBoxTitle);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.labelPages);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonEdit);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.dataGridJournalArticles);
			this.Controls.Add(this.textBoxCallNo2);
			this.Controls.Add(this.labelCallNo2);
			this.Controls.Add(this.textBoxCallNo);
			this.Controls.Add(this.labelCallNo);
			this.Controls.Add(this.textBoxMonthSeason);
			this.Controls.Add(this.labelMonthSeason);
			this.Controls.Add(this.textBoxPublishYear);
			this.Controls.Add(this.labelPublishYear);
			this.Controls.Add(this.textBoxNumber);
			this.Controls.Add(this.labelNumber);
			this.Controls.Add(this.textBoxVolume);
			this.Controls.Add(this.labelVolume);
			this.Controls.Add(this.textBoxJournalDetailID);
			this.Controls.Add(this.labelJournalDetailID);
			this.Controls.Add(this.LabelTitle);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.textBoxJournalName);
			this.Controls.Add(this.labelJournalName);
			this.Controls.Add(this.textBoxJournalID);
			this.Controls.Add(this.labelJournalID);
			this.Name = "FrmJournalArticles";
			this.Load += new System.EventHandler(this.FrmJournalArticles_Load);
			this.Controls.SetChildIndex(this.labelJournalID, 0);
			this.Controls.SetChildIndex(this.textBoxJournalID, 0);
			this.Controls.SetChildIndex(this.labelJournalName, 0);
			this.Controls.SetChildIndex(this.textBoxJournalName, 0);
			this.Controls.SetChildIndex(this.buttonCancel, 0);
			this.Controls.SetChildIndex(this.LabelTitle, 0);
			this.Controls.SetChildIndex(this.labelJournalDetailID, 0);
			this.Controls.SetChildIndex(this.textBoxJournalDetailID, 0);
			this.Controls.SetChildIndex(this.labelVolume, 0);
			this.Controls.SetChildIndex(this.textBoxVolume, 0);
			this.Controls.SetChildIndex(this.labelNumber, 0);
			this.Controls.SetChildIndex(this.textBoxNumber, 0);
			this.Controls.SetChildIndex(this.labelPublishYear, 0);
			this.Controls.SetChildIndex(this.textBoxPublishYear, 0);
			this.Controls.SetChildIndex(this.labelMonthSeason, 0);
			this.Controls.SetChildIndex(this.textBoxMonthSeason, 0);
			this.Controls.SetChildIndex(this.labelCallNo, 0);
			this.Controls.SetChildIndex(this.textBoxCallNo, 0);
			this.Controls.SetChildIndex(this.labelCallNo2, 0);
			this.Controls.SetChildIndex(this.textBoxCallNo2, 0);
			this.Controls.SetChildIndex(this.dataGridJournalArticles, 0);
			this.Controls.SetChildIndex(this.buttonAdd, 0);
			this.Controls.SetChildIndex(this.buttonEdit, 0);
			this.Controls.SetChildIndex(this.buttonDelete, 0);
			this.Controls.SetChildIndex(this.buttonSave, 0);
			this.Controls.SetChildIndex(this.labelPages, 0);
			this.Controls.SetChildIndex(this.label4, 0);
			this.Controls.SetChildIndex(this.textBoxTitle, 0);
			this.Controls.SetChildIndex(this.labelSubject, 0);
			this.Controls.SetChildIndex(this.textBoxSubject, 0);
			this.Controls.SetChildIndex(this.labelAuthorName, 0);
			this.Controls.SetChildIndex(this.textBoxAuthorName, 0);
			this.Controls.SetChildIndex(this.labelAuthorName2, 0);
			this.Controls.SetChildIndex(this.textBoxAuthorName2, 0);
			this.Controls.SetChildIndex(this.textBoxPages, 0);
			((System.ComponentModel.ISupportInitialize)(this.dataGridJournalArticles)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void FrmJournalArticles_Load(object sender, System.EventArgs e)
		{
			MyJournal = new Journal();
			textBoxJournalID.Text = this.MyMDIForm.MyJournal.JournalID.ToString();
			textBoxJournalName.Text = this.MyMDIForm.MyJournal.JournalName.ToString();
			textBoxVolume.Text = this.MyMDIForm.MyJournal.Volume.ToString();
			textBoxNumber.Text = this.MyMDIForm.MyJournal.Number.ToString();
			textBoxPublishYear.Text = this.MyMDIForm.MyJournal.PublishYear.ToString();
			textBoxMonthSeason.Text = this.MyMDIForm.MyJournal.MonthSeason.ToString();
			textBoxCallNo.Text = this.MyMDIForm.MyJournal.CallNo.ToString();
			textBoxCallNo2.Text = this.MyMDIForm.MyJournal.CallNo2.ToString();
			textBoxJournalDetailID.Text = this.MyMDIForm.MyJournal.JournalDetailID.ToString();

			MyJournal.JournalID = textBoxJournalID.Text.ToString();
			MyJournal.JournalName = textBoxJournalName.Text.ToString();
			MyJournal.JournalDetailID = textBoxJournalDetailID.Text.ToString();

			MyClassDatabase = new ClassDatabase();
			MyDataTable = MyClassDatabase.GetJournalArticles(MyJournal.JournalDetailID.ToString());
			dataGridJournalArticles.DataSource = MyDataTable;
		}
		private void dataGridJournalArticles_Click(object sender, System.EventArgs e)
		{
			if(MyDataTable.Rows.Count>0)
			{
				textBoxJournalDetailID.Text = dataGridJournalArticles[dataGridJournalArticles.CurrentRowIndex,0].ToString().Trim();
				
				textBoxPages.Text =dataGridJournalArticles[dataGridJournalArticles.CurrentRowIndex,1].ToString().Trim();
				textBoxTitle.Text = dataGridJournalArticles[dataGridJournalArticles.CurrentRowIndex,2].ToString().Trim();
				textBoxAuthorName.Text =dataGridJournalArticles[dataGridJournalArticles.CurrentRowIndex,3].ToString().Trim();
				textBoxAuthorName2.Text = dataGridJournalArticles[dataGridJournalArticles.CurrentRowIndex,4].ToString().Trim();
				textBoxSubject.Text =dataGridJournalArticles[dataGridJournalArticles.CurrentRowIndex,5].ToString().Trim();
				
				CanDelete = true;
				DoLock();
			}
		}
		private void dataGridJournalArticles_DoubleClick(object sender, System.EventArgs e)
		{
			
			if(MyDataTable.Rows.Count>0)
			{
				
			}
		}

		private void textBoxPages_TextChanged(object sender, System.EventArgs e)
		{
			MyJournal.Pages = textBoxPages.Text.ToString();
		}

		private void textBoxSubject_TextChanged(object sender, System.EventArgs e)
		{
			MyJournal.Subject = textBoxSubject.Text.ToString();
		}

		private void textBoxTitle_TextChanged(object sender, System.EventArgs e)
		{
			MyJournal.Title = textBoxTitle.Text.ToString();
		}

		private void textBoxAuthorName_TextChanged(object sender, System.EventArgs e)
		{
			MyJournal.AuthorName = textBoxAuthorName.Text.ToString();
		}

		private void textBoxAuthorName2_TextChanged(object sender, System.EventArgs e)
		{
			MyJournal.AuthorName2 = textBoxAuthorName2.Text.ToString();
		}

		internal void DoLock()
		{
			buttonAdd.Enabled = true;
			buttonSave.Enabled = false;
			buttonCancel.Enabled = false;


			RefreshButton();


		}
		private void DoUnlock()
		{
			textBoxVolume.Focus();
			buttonAdd.Enabled = false;
			buttonEdit.Enabled = false;
			buttonDelete.Enabled = false;
			buttonSave.Enabled = true;
			buttonCancel.Enabled = true;
			textBoxPages.Text = "";
			textBoxSubject.Text = "";
			textBoxTitle.Text = "";
			textBoxAuthorName.Text = "";
			textBoxAuthorName2.Text = "";

			
		}
		internal void RefreshButton()
		{
			if(CanDelete == true)
			{
				buttonEdit.Enabled = true;
				buttonDelete.Enabled = true;
			}
			else
			{
				buttonEdit.Enabled = false;
				buttonDelete.Enabled = false;
			}

		}

		private void buttonAdd_Click(object sender, System.EventArgs e)
		{
			DoUnlock();

			
			textBoxPages.Focus();
			StatusAction = "Add";
			MyClassDatabase = new ClassDatabase();
			
		}
		private void buttonEdit_Click(object sender, System.EventArgs e)
		{
			textBoxVolume.Focus();
			buttonAdd.Enabled = false;
			buttonEdit.Enabled = false;
			buttonDelete.Enabled = false;
			buttonSave.Enabled = true;
			buttonCancel.Enabled = true;
			StatusAction = "Edit";
		}
		private void buttonDelete_Click(object sender, System.EventArgs e)
		{
			DialogResult ans;
			ans = MessageBox.Show("Are you sure you want to delete Journal Articles Data with JournalDetailID=' "+ textBoxJournalDetailID.Text.ToString().Trim() + "' and Pages = " + textBoxPages.Text.ToString() + " ?" , "Confirmation", MessageBoxButtons.YesNo );
			if (ans.ToString() == "Yes")
			{	
				MyClassDatabase = new ClassDatabase();
				MyClassDatabase.DeleteJournalArticles(textBoxJournalDetailID.Text.ToString().Trim(), textBoxPages.Text.ToString());
				CanDelete = false;

				
			}
			DoLock();
			textBoxPages.Text = "";
			textBoxSubject.Text = "";
			textBoxTitle.Text = "";
			textBoxAuthorName.Text = "";
			textBoxAuthorName2.Text = "";

			DoRefresh();

		}

		private void buttonSave_Click(object sender, System.EventArgs e)
		{
			if(MyJournal.Pages.ToString() == "")
			{
				MessageBox.Show("Please enter the pages !", "Information");
			}
			else
			{
				MyClassDatabase = new ClassDatabase();
		
				MyJournal.UpdateUser = MyMDIForm.LibrarianUserName.ToString();
				MyClassDatabase = new ClassDatabase();
				MyClassDatabase.SaveJournalArticles(MyJournal);
				CanDelete = true;
				DoLock();
				StatusAction = "Nothing";
				DoRefresh();
			}
		}
		private void buttonCancel_Click(object sender, System.EventArgs e)
		{
			DoLock();
			StatusAction = "Nothing";
		}
		public void DoRefresh()
		{
			MyClassDatabase = new ClassDatabase();
			MyDataTable = MyClassDatabase.GetJournalArticles(MyJournal.JournalDetailID.ToString());
			dataGridJournalArticles.DataSource = MyDataTable;
		}



	}
}

