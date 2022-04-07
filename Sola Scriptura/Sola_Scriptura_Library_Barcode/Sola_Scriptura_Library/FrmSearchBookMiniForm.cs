using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Sola_Scriptura_Library
{
	/// <summary>
	/// Summary description for FrmSearchBookMiniForm.
	/// </summary>
	public class FrmSearchBookMiniForm : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.TextBox textBoxSearch;
		internal System.Windows.Forms.Label labelCity;
		internal System.Windows.Forms.Label LabelTitle;
		internal System.Windows.Forms.PictureBox pictureBoxMainForm;
		internal System.Windows.Forms.PictureBox pictureBoxLeftForm;
		internal System.Windows.Forms.TextBox textBoxSubject;
		internal System.Windows.Forms.TextBox textBoxISBN;
		internal System.Windows.Forms.Label labelISBN;
		internal System.Windows.Forms.Button buttonClear;
		internal System.Windows.Forms.Button buttonSearch;
		internal System.Windows.Forms.ComboBox comboBoxPublishYearFrom;
		internal System.Windows.Forms.ComboBox comboBoxPublishYearTo;
		internal System.Windows.Forms.Label labelPublishYear;
		internal System.Windows.Forms.TextBox textBoxPublisher;
		internal System.Windows.Forms.Label labelPublisher;
		internal System.Windows.Forms.TextBox textBoxAuthor;
		internal System.Windows.Forms.Label labelAuthor;
		internal System.Windows.Forms.Label labelSubject;
		internal System.Windows.Forms.TextBox textBoxLC;
		internal System.Windows.Forms.Label labelLC;
		internal System.Windows.Forms.TextBox textBoxDDC;
		internal System.Windows.Forms.Label labelDDC;
		internal System.Windows.Forms.ComboBox comboBoxBookGroup;
		internal System.Windows.Forms.Label labelBookGroup;
		internal System.Windows.Forms.ComboBox comboBoxType;
		internal System.Windows.Forms.Label labelType;
		internal System.Windows.Forms.TextBox textBoxBookName;
		internal System.Windows.Forms.Label labelBookName;
		internal System.Windows.Forms.TextBox textBoxBookCode;
		internal System.Windows.Forms.Label labelBookCode;
		
		
		
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;


		internal System.Windows.Forms.DataGrid dataGridGetBook;
		internal System.Windows.Forms.DataGridTableStyle dataGridTableStyleGetBook;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnBookCode;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnBookCopy;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnBookName;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnOriginalTitle;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnBookType;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnBookGroupCode;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnGroupName;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnISBN;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnDDC;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnLC;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnVol;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnPages;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnRev;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnPublisherCode;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnPublisherName;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnPublishYear;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnContent;
		internal System.Windows.Forms.PictureBox pictureBoxVariant;
		
		
		internal DataTable MyBookType;
		internal FrmTransactionBorrow MyTransactionBorrowForm;

		internal string MyCurrentData;
		internal ClassDatabase MyClassDatabase;
		internal DataTable MyDataTable;
		internal BookSearch MyBookSearch;
		internal System.Windows.Forms.PictureBox pictureBoxLogoPicture;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnBarCodeNo;
		internal System.Windows.Forms.TextBox textBoxBarCodeNo;
		internal System.Windows.Forms.Label labelBarCodeNo;
		internal DataTable MyGroupName;
		public FrmSearchBookMiniForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}
		public FrmSearchBookMiniForm(FrmTransactionBorrow TransactionBorrowForm, string CurrentData)
		{

			InitializeComponent();

			this.MdiParent = TransactionBorrowForm.MyMDIForm;
			MyTransactionBorrowForm = TransactionBorrowForm;
			MyCurrentData = CurrentData;


		}


		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmSearchBookMiniForm));
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.labelCity = new System.Windows.Forms.Label();
			this.LabelTitle = new System.Windows.Forms.Label();
			this.pictureBoxMainForm = new System.Windows.Forms.PictureBox();
			this.pictureBoxLeftForm = new System.Windows.Forms.PictureBox();
			this.textBoxSubject = new System.Windows.Forms.TextBox();
			this.textBoxISBN = new System.Windows.Forms.TextBox();
			this.labelISBN = new System.Windows.Forms.Label();
			this.buttonClear = new System.Windows.Forms.Button();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.comboBoxPublishYearFrom = new System.Windows.Forms.ComboBox();
			this.comboBoxPublishYearTo = new System.Windows.Forms.ComboBox();
			this.labelPublishYear = new System.Windows.Forms.Label();
			this.textBoxPublisher = new System.Windows.Forms.TextBox();
			this.labelPublisher = new System.Windows.Forms.Label();
			this.textBoxAuthor = new System.Windows.Forms.TextBox();
			this.labelAuthor = new System.Windows.Forms.Label();
			this.labelSubject = new System.Windows.Forms.Label();
			this.textBoxLC = new System.Windows.Forms.TextBox();
			this.labelLC = new System.Windows.Forms.Label();
			this.textBoxDDC = new System.Windows.Forms.TextBox();
			this.labelDDC = new System.Windows.Forms.Label();
			this.comboBoxBookGroup = new System.Windows.Forms.ComboBox();
			this.labelBookGroup = new System.Windows.Forms.Label();
			this.comboBoxType = new System.Windows.Forms.ComboBox();
			this.labelType = new System.Windows.Forms.Label();
			this.textBoxBookName = new System.Windows.Forms.TextBox();
			this.labelBookName = new System.Windows.Forms.Label();
			this.textBoxBookCode = new System.Windows.Forms.TextBox();
			this.labelBookCode = new System.Windows.Forms.Label();
			this.dataGridGetBook = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyleGetBook = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnBookCode = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnBookCopy = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnBookName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnOriginalTitle = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnBookType = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnBookGroupCode = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnGroupName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnISBN = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnDDC = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnLC = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnVol = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnPages = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnRev = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnPublisherCode = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnPublisherName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnPublishYear = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnContent = new System.Windows.Forms.DataGridTextBoxColumn();
			this.pictureBoxVariant = new System.Windows.Forms.PictureBox();
			this.pictureBoxLogoPicture = new System.Windows.Forms.PictureBox();
			this.dataGridTextBoxColumnBarCodeNo = new System.Windows.Forms.DataGridTextBoxColumn();
			this.textBoxBarCodeNo = new System.Windows.Forms.TextBox();
			this.labelBarCodeNo = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridGetBook)).BeginInit();
			this.SuspendLayout();
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxSearch.Location = new System.Drawing.Point(16, 136);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(160, 22);
			this.textBoxSearch.TabIndex = 152;
			this.textBoxSearch.Text = "";
			// 
			// labelCity
			// 
			this.labelCity.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelCity.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelCity.Location = new System.Drawing.Point(16, 104);
			this.labelCity.Name = "labelCity";
			this.labelCity.Size = new System.Drawing.Size(120, 24);
			this.labelCity.TabIndex = 155;
			this.labelCity.Text = "Text to Find   :";
			// 
			// LabelTitle
			// 
			this.LabelTitle.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.LabelTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.LabelTitle.Image = ((System.Drawing.Image)(resources.GetObject("LabelTitle.Image")));
			this.LabelTitle.Location = new System.Drawing.Point(728, 16);
			this.LabelTitle.Name = "LabelTitle";
			this.LabelTitle.Size = new System.Drawing.Size(192, 32);
			this.LabelTitle.TabIndex = 154;
			this.LabelTitle.Text = "    Get Book";
			this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBoxMainForm
			// 
			this.pictureBoxMainForm.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMainForm.Image")));
			this.pictureBoxMainForm.Location = new System.Drawing.Point(192, 8);
			this.pictureBoxMainForm.Name = "pictureBoxMainForm";
			this.pictureBoxMainForm.Size = new System.Drawing.Size(744, 456);
			this.pictureBoxMainForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxMainForm.TabIndex = 153;
			this.pictureBoxMainForm.TabStop = false;
			// 
			// pictureBoxLeftForm
			// 
			this.pictureBoxLeftForm.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLeftForm.Image")));
			this.pictureBoxLeftForm.Location = new System.Drawing.Point(0, 8);
			this.pictureBoxLeftForm.Name = "pictureBoxLeftForm";
			this.pictureBoxLeftForm.Size = new System.Drawing.Size(192, 456);
			this.pictureBoxLeftForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxLeftForm.TabIndex = 151;
			this.pictureBoxLeftForm.TabStop = false;
			// 
			// textBoxSubject
			// 
			this.textBoxSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxSubject.Location = new System.Drawing.Point(368, 200);
			this.textBoxSubject.Name = "textBoxSubject";
			this.textBoxSubject.Size = new System.Drawing.Size(200, 20);
			this.textBoxSubject.TabIndex = 9;
			this.textBoxSubject.Text = "";
			this.textBoxSubject.TextChanged += new System.EventHandler(this.textBoxSubject_TextChanged);
			// 
			// textBoxISBN
			// 
			this.textBoxISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxISBN.Location = new System.Drawing.Point(712, 104);
			this.textBoxISBN.Name = "textBoxISBN";
			this.textBoxISBN.Size = new System.Drawing.Size(200, 20);
			this.textBoxISBN.TabIndex = 3;
			this.textBoxISBN.Text = "";
			this.textBoxISBN.TextChanged += new System.EventHandler(this.textBoxISBN_TextChanged);
			// 
			// labelISBN
			// 
			this.labelISBN.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelISBN.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelISBN.Location = new System.Drawing.Point(584, 104);
			this.labelISBN.Name = "labelISBN";
			this.labelISBN.Size = new System.Drawing.Size(120, 24);
			this.labelISBN.TabIndex = 199;
			this.labelISBN.Text = "ISBN";
			// 
			// buttonClear
			// 
			this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonClear.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonClear.Image = ((System.Drawing.Image)(resources.GetObject("buttonClear.Image")));
			this.buttonClear.Location = new System.Drawing.Point(720, 256);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(88, 32);
			this.buttonClear.TabIndex = 14;
			this.buttonClear.Text = "Clear";
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// buttonSearch
			// 
			this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonSearch.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearch.Image")));
			this.buttonSearch.Location = new System.Drawing.Point(824, 256);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(88, 32);
			this.buttonSearch.TabIndex = 15;
			this.buttonSearch.Text = "Search";
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// comboBoxPublishYearFrom
			// 
			this.comboBoxPublishYearFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.comboBoxPublishYearFrom.Location = new System.Drawing.Point(712, 224);
			this.comboBoxPublishYearFrom.Name = "comboBoxPublishYearFrom";
			this.comboBoxPublishYearFrom.Size = new System.Drawing.Size(96, 21);
			this.comboBoxPublishYearFrom.TabIndex = 12;
			this.comboBoxPublishYearFrom.SelectedIndexChanged += new System.EventHandler(this.comboBoxPublishYearFrom_SelectedIndexChanged);
			// 
			// comboBoxPublishYearTo
			// 
			this.comboBoxPublishYearTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.comboBoxPublishYearTo.Location = new System.Drawing.Point(816, 224);
			this.comboBoxPublishYearTo.Name = "comboBoxPublishYearTo";
			this.comboBoxPublishYearTo.Size = new System.Drawing.Size(96, 21);
			this.comboBoxPublishYearTo.TabIndex = 13;
			this.comboBoxPublishYearTo.SelectedIndexChanged += new System.EventHandler(this.comboBoxPublishYearTo_SelectedIndexChanged);
			// 
			// labelPublishYear
			// 
			this.labelPublishYear.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelPublishYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelPublishYear.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelPublishYear.Location = new System.Drawing.Point(584, 224);
			this.labelPublishYear.Name = "labelPublishYear";
			this.labelPublishYear.Size = new System.Drawing.Size(120, 24);
			this.labelPublishYear.TabIndex = 198;
			this.labelPublishYear.Text = "Publish Year";
			// 
			// textBoxPublisher
			// 
			this.textBoxPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxPublisher.Location = new System.Drawing.Point(368, 224);
			this.textBoxPublisher.Name = "textBoxPublisher";
			this.textBoxPublisher.Size = new System.Drawing.Size(200, 20);
			this.textBoxPublisher.TabIndex = 11;
			this.textBoxPublisher.Text = "";
			this.textBoxPublisher.TextChanged += new System.EventHandler(this.textBoxPublisher_TextChanged);
			// 
			// labelPublisher
			// 
			this.labelPublisher.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelPublisher.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelPublisher.Location = new System.Drawing.Point(240, 224);
			this.labelPublisher.Name = "labelPublisher";
			this.labelPublisher.Size = new System.Drawing.Size(120, 24);
			this.labelPublisher.TabIndex = 197;
			this.labelPublisher.Text = "Publisher";
			// 
			// textBoxAuthor
			// 
			this.textBoxAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxAuthor.Location = new System.Drawing.Point(712, 200);
			this.textBoxAuthor.Name = "textBoxAuthor";
			this.textBoxAuthor.Size = new System.Drawing.Size(200, 20);
			this.textBoxAuthor.TabIndex = 10;
			this.textBoxAuthor.Text = "";
			this.textBoxAuthor.TextChanged += new System.EventHandler(this.textBoxAuthor_TextChanged);
			// 
			// labelAuthor
			// 
			this.labelAuthor.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelAuthor.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelAuthor.Location = new System.Drawing.Point(584, 200);
			this.labelAuthor.Name = "labelAuthor";
			this.labelAuthor.Size = new System.Drawing.Size(120, 24);
			this.labelAuthor.TabIndex = 196;
			this.labelAuthor.Text = "Author";
			// 
			// labelSubject
			// 
			this.labelSubject.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelSubject.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelSubject.Location = new System.Drawing.Point(240, 200);
			this.labelSubject.Name = "labelSubject";
			this.labelSubject.Size = new System.Drawing.Size(120, 24);
			this.labelSubject.TabIndex = 195;
			this.labelSubject.Text = "Subject";
			// 
			// textBoxLC
			// 
			this.textBoxLC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxLC.Location = new System.Drawing.Point(712, 176);
			this.textBoxLC.Name = "textBoxLC";
			this.textBoxLC.Size = new System.Drawing.Size(200, 20);
			this.textBoxLC.TabIndex = 8;
			this.textBoxLC.Text = "";
			this.textBoxLC.TextChanged += new System.EventHandler(this.textBoxLC_TextChanged);
			// 
			// labelLC
			// 
			this.labelLC.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelLC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelLC.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelLC.Location = new System.Drawing.Point(584, 176);
			this.labelLC.Name = "labelLC";
			this.labelLC.Size = new System.Drawing.Size(120, 24);
			this.labelLC.TabIndex = 194;
			this.labelLC.Text = "LC";
			// 
			// textBoxDDC
			// 
			this.textBoxDDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxDDC.Location = new System.Drawing.Point(368, 176);
			this.textBoxDDC.Name = "textBoxDDC";
			this.textBoxDDC.Size = new System.Drawing.Size(200, 20);
			this.textBoxDDC.TabIndex = 7;
			this.textBoxDDC.Text = "";
			this.textBoxDDC.TextChanged += new System.EventHandler(this.textBoxDDC_TextChanged);
			// 
			// labelDDC
			// 
			this.labelDDC.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelDDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelDDC.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelDDC.Location = new System.Drawing.Point(240, 176);
			this.labelDDC.Name = "labelDDC";
			this.labelDDC.Size = new System.Drawing.Size(120, 24);
			this.labelDDC.TabIndex = 193;
			this.labelDDC.Text = "DDC";
			// 
			// comboBoxBookGroup
			// 
			this.comboBoxBookGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxBookGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.comboBoxBookGroup.Location = new System.Drawing.Point(712, 152);
			this.comboBoxBookGroup.Name = "comboBoxBookGroup";
			this.comboBoxBookGroup.Size = new System.Drawing.Size(200, 21);
			this.comboBoxBookGroup.TabIndex = 6;
			this.comboBoxBookGroup.SelectedIndexChanged += new System.EventHandler(this.comboBoxBookGroup_SelectedIndexChanged);
			// 
			// labelBookGroup
			// 
			this.labelBookGroup.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelBookGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBookGroup.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelBookGroup.Location = new System.Drawing.Point(584, 152);
			this.labelBookGroup.Name = "labelBookGroup";
			this.labelBookGroup.Size = new System.Drawing.Size(120, 24);
			this.labelBookGroup.TabIndex = 192;
			this.labelBookGroup.Text = "Book Group";
			// 
			// comboBoxType
			// 
			this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.comboBoxType.Location = new System.Drawing.Point(368, 152);
			this.comboBoxType.Name = "comboBoxType";
			this.comboBoxType.Size = new System.Drawing.Size(200, 21);
			this.comboBoxType.TabIndex = 5;
			this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
			// 
			// labelType
			// 
			this.labelType.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelType.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelType.Location = new System.Drawing.Point(240, 152);
			this.labelType.Name = "labelType";
			this.labelType.Size = new System.Drawing.Size(120, 24);
			this.labelType.TabIndex = 191;
			this.labelType.Text = "Type";
			// 
			// textBoxBookName
			// 
			this.textBoxBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxBookName.Location = new System.Drawing.Point(368, 128);
			this.textBoxBookName.Name = "textBoxBookName";
			this.textBoxBookName.Size = new System.Drawing.Size(544, 20);
			this.textBoxBookName.TabIndex = 4;
			this.textBoxBookName.Text = "";
			this.textBoxBookName.TextChanged += new System.EventHandler(this.textBoxBookName_TextChanged);
			// 
			// labelBookName
			// 
			this.labelBookName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBookName.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelBookName.Location = new System.Drawing.Point(240, 128);
			this.labelBookName.Name = "labelBookName";
			this.labelBookName.Size = new System.Drawing.Size(120, 24);
			this.labelBookName.TabIndex = 189;
			this.labelBookName.Text = "Book Name";
			// 
			// textBoxBookCode
			// 
			this.textBoxBookCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxBookCode.Location = new System.Drawing.Point(368, 104);
			this.textBoxBookCode.Name = "textBoxBookCode";
			this.textBoxBookCode.Size = new System.Drawing.Size(200, 20);
			this.textBoxBookCode.TabIndex = 2;
			this.textBoxBookCode.Text = "";
			this.textBoxBookCode.TextChanged += new System.EventHandler(this.textBoxBookCode_TextChanged);
			// 
			// labelBookCode
			// 
			this.labelBookCode.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelBookCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBookCode.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelBookCode.Location = new System.Drawing.Point(240, 104);
			this.labelBookCode.Name = "labelBookCode";
			this.labelBookCode.Size = new System.Drawing.Size(120, 24);
			this.labelBookCode.TabIndex = 188;
			this.labelBookCode.Text = "Book Code";
			// 
			// dataGridGetBook
			// 
			this.dataGridGetBook.DataMember = "";
			this.dataGridGetBook.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridGetBook.Location = new System.Drawing.Point(232, 288);
			this.dataGridGetBook.Name = "dataGridGetBook";
			this.dataGridGetBook.ReadOnly = true;
			this.dataGridGetBook.Size = new System.Drawing.Size(680, 160);
			this.dataGridGetBook.TabIndex = 187;
			this.dataGridGetBook.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																										this.dataGridTableStyleGetBook});
			this.dataGridGetBook.DoubleClick += new System.EventHandler(this.dataGridGetBook_DoubleClick);
			// 
			// dataGridTableStyleGetBook
			// 
			this.dataGridTableStyleGetBook.AlternatingBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleGetBook.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.dataGridTableStyleGetBook.DataGrid = this.dataGridGetBook;
			this.dataGridTableStyleGetBook.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleGetBook.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																														this.dataGridTextBoxColumnBookCode,
																														this.dataGridTextBoxColumnBookCopy,
																														this.dataGridTextBoxColumnBarCodeNo,
																														this.dataGridTextBoxColumnBookName,
																														this.dataGridTextBoxColumnOriginalTitle,
																														this.dataGridTextBoxColumnBookType,
																														this.dataGridTextBoxColumnBookGroupCode,
																														this.dataGridTextBoxColumnGroupName,
																														this.dataGridTextBoxColumnISBN,
																														this.dataGridTextBoxColumnDDC,
																														this.dataGridTextBoxColumnLC,
																														this.dataGridTextBoxColumnVol,
																														this.dataGridTextBoxColumnPages,
																														this.dataGridTextBoxColumnRev,
																														this.dataGridTextBoxColumnPublisherCode,
																														this.dataGridTextBoxColumnPublisherName,
																														this.dataGridTextBoxColumnPublishYear,
																														this.dataGridTextBoxColumnContent});
			this.dataGridTableStyleGetBook.GridLineColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridTableStyleGetBook.HeaderBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleGetBook.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleGetBook.MappingName = "BookList2";
			// 
			// dataGridTextBoxColumnBookCode
			// 
			this.dataGridTextBoxColumnBookCode.Format = "";
			this.dataGridTextBoxColumnBookCode.FormatInfo = null;
			this.dataGridTextBoxColumnBookCode.HeaderText = "Book Code";
			this.dataGridTextBoxColumnBookCode.MappingName = "BookCode";
			this.dataGridTextBoxColumnBookCode.Width = 120;
			// 
			// dataGridTextBoxColumnBookCopy
			// 
			this.dataGridTextBoxColumnBookCopy.Format = "";
			this.dataGridTextBoxColumnBookCopy.FormatInfo = null;
			this.dataGridTextBoxColumnBookCopy.HeaderText = "Copy No";
			this.dataGridTextBoxColumnBookCopy.MappingName = "CopyNo";
			this.dataGridTextBoxColumnBookCopy.Width = 75;
			// 
			// dataGridTextBoxColumnBookName
			// 
			this.dataGridTextBoxColumnBookName.Format = "";
			this.dataGridTextBoxColumnBookName.FormatInfo = null;
			this.dataGridTextBoxColumnBookName.HeaderText = "Book Name";
			this.dataGridTextBoxColumnBookName.MappingName = "BookName";
			this.dataGridTextBoxColumnBookName.Width = 200;
			// 
			// dataGridTextBoxColumnOriginalTitle
			// 
			this.dataGridTextBoxColumnOriginalTitle.Format = "";
			this.dataGridTextBoxColumnOriginalTitle.FormatInfo = null;
			this.dataGridTextBoxColumnOriginalTitle.HeaderText = "Original Title";
			this.dataGridTextBoxColumnOriginalTitle.MappingName = "OriginalTitle";
			this.dataGridTextBoxColumnOriginalTitle.Width = 200;
			// 
			// dataGridTextBoxColumnBookType
			// 
			this.dataGridTextBoxColumnBookType.Format = "";
			this.dataGridTextBoxColumnBookType.FormatInfo = null;
			this.dataGridTextBoxColumnBookType.HeaderText = "Book Type";
			this.dataGridTextBoxColumnBookType.MappingName = "BookType";
			this.dataGridTextBoxColumnBookType.Width = 120;
			// 
			// dataGridTextBoxColumnBookGroupCode
			// 
			this.dataGridTextBoxColumnBookGroupCode.Format = "";
			this.dataGridTextBoxColumnBookGroupCode.FormatInfo = null;
			this.dataGridTextBoxColumnBookGroupCode.HeaderText = "Group Code";
			this.dataGridTextBoxColumnBookGroupCode.MappingName = "BookGroupCode";
			this.dataGridTextBoxColumnBookGroupCode.Width = 0;
			// 
			// dataGridTextBoxColumnGroupName
			// 
			this.dataGridTextBoxColumnGroupName.Format = "";
			this.dataGridTextBoxColumnGroupName.FormatInfo = null;
			this.dataGridTextBoxColumnGroupName.HeaderText = "Group Name";
			this.dataGridTextBoxColumnGroupName.MappingName = "GroupName";
			this.dataGridTextBoxColumnGroupName.Width = 120;
			// 
			// dataGridTextBoxColumnISBN
			// 
			this.dataGridTextBoxColumnISBN.Format = "";
			this.dataGridTextBoxColumnISBN.FormatInfo = null;
			this.dataGridTextBoxColumnISBN.HeaderText = "ISBN";
			this.dataGridTextBoxColumnISBN.MappingName = "ISBN";
			this.dataGridTextBoxColumnISBN.Width = 120;
			// 
			// dataGridTextBoxColumnDDC
			// 
			this.dataGridTextBoxColumnDDC.Format = "";
			this.dataGridTextBoxColumnDDC.FormatInfo = null;
			this.dataGridTextBoxColumnDDC.HeaderText = "DDC";
			this.dataGridTextBoxColumnDDC.MappingName = "DDC";
			this.dataGridTextBoxColumnDDC.Width = 120;
			// 
			// dataGridTextBoxColumnLC
			// 
			this.dataGridTextBoxColumnLC.Format = "";
			this.dataGridTextBoxColumnLC.FormatInfo = null;
			this.dataGridTextBoxColumnLC.HeaderText = "LC";
			this.dataGridTextBoxColumnLC.MappingName = "LC";
			this.dataGridTextBoxColumnLC.Width = 120;
			// 
			// dataGridTextBoxColumnVol
			// 
			this.dataGridTextBoxColumnVol.Format = "";
			this.dataGridTextBoxColumnVol.FormatInfo = null;
			this.dataGridTextBoxColumnVol.HeaderText = "Vol";
			this.dataGridTextBoxColumnVol.MappingName = "Vol";
			this.dataGridTextBoxColumnVol.Width = 40;
			// 
			// dataGridTextBoxColumnPages
			// 
			this.dataGridTextBoxColumnPages.Format = "";
			this.dataGridTextBoxColumnPages.FormatInfo = null;
			this.dataGridTextBoxColumnPages.HeaderText = "Pages";
			this.dataGridTextBoxColumnPages.MappingName = "Pages";
			this.dataGridTextBoxColumnPages.Width = 40;
			// 
			// dataGridTextBoxColumnRev
			// 
			this.dataGridTextBoxColumnRev.Format = "";
			this.dataGridTextBoxColumnRev.FormatInfo = null;
			this.dataGridTextBoxColumnRev.HeaderText = "Rev";
			this.dataGridTextBoxColumnRev.MappingName = "Rev";
			this.dataGridTextBoxColumnRev.Width = 40;
			// 
			// dataGridTextBoxColumnPublisherCode
			// 
			this.dataGridTextBoxColumnPublisherCode.Format = "";
			this.dataGridTextBoxColumnPublisherCode.FormatInfo = null;
			this.dataGridTextBoxColumnPublisherCode.HeaderText = "Publisher Code";
			this.dataGridTextBoxColumnPublisherCode.MappingName = "PublisherCode";
			this.dataGridTextBoxColumnPublisherCode.Width = 0;
			// 
			// dataGridTextBoxColumnPublisherName
			// 
			this.dataGridTextBoxColumnPublisherName.Format = "";
			this.dataGridTextBoxColumnPublisherName.FormatInfo = null;
			this.dataGridTextBoxColumnPublisherName.HeaderText = "Publisher Name";
			this.dataGridTextBoxColumnPublisherName.MappingName = "PublisherName";
			this.dataGridTextBoxColumnPublisherName.Width = 120;
			// 
			// dataGridTextBoxColumnPublishYear
			// 
			this.dataGridTextBoxColumnPublishYear.Format = "";
			this.dataGridTextBoxColumnPublishYear.FormatInfo = null;
			this.dataGridTextBoxColumnPublishYear.HeaderText = "Publish Year";
			this.dataGridTextBoxColumnPublishYear.MappingName = "PublishYear";
			this.dataGridTextBoxColumnPublishYear.Width = 75;
			// 
			// dataGridTextBoxColumnContent
			// 
			this.dataGridTextBoxColumnContent.Format = "";
			this.dataGridTextBoxColumnContent.FormatInfo = null;
			this.dataGridTextBoxColumnContent.HeaderText = "Content";
			this.dataGridTextBoxColumnContent.MappingName = "Content";
			this.dataGridTextBoxColumnContent.Width = 75;
			// 
			// pictureBoxVariant
			// 
			this.pictureBoxVariant.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxVariant.Image")));
			this.pictureBoxVariant.Location = new System.Drawing.Point(200, 296);
			this.pictureBoxVariant.Name = "pictureBoxVariant";
			this.pictureBoxVariant.Size = new System.Drawing.Size(29, 154);
			this.pictureBoxVariant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxVariant.TabIndex = 200;
			this.pictureBoxVariant.TabStop = false;
			// 
			// pictureBoxLogoPicture
			// 
			this.pictureBoxLogoPicture.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogoPicture.Image")));
			this.pictureBoxLogoPicture.Location = new System.Drawing.Point(24, 352);
			this.pictureBoxLogoPicture.Name = "pictureBoxLogoPicture";
			this.pictureBoxLogoPicture.Size = new System.Drawing.Size(144, 88);
			this.pictureBoxLogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxLogoPicture.TabIndex = 216;
			this.pictureBoxLogoPicture.TabStop = false;
			// 
			// dataGridTextBoxColumnBarCodeNo
			// 
			this.dataGridTextBoxColumnBarCodeNo.Format = "";
			this.dataGridTextBoxColumnBarCodeNo.FormatInfo = null;
			this.dataGridTextBoxColumnBarCodeNo.HeaderText = "BarCodeNo";
			this.dataGridTextBoxColumnBarCodeNo.MappingName = "BarCodeNo";
			this.dataGridTextBoxColumnBarCodeNo.Width = 75;
			// 
			// textBoxBarCodeNo
			// 
			this.textBoxBarCodeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxBarCodeNo.Location = new System.Drawing.Point(368, 80);
			this.textBoxBarCodeNo.Name = "textBoxBarCodeNo";
			this.textBoxBarCodeNo.Size = new System.Drawing.Size(200, 20);
			this.textBoxBarCodeNo.TabIndex = 1;
			this.textBoxBarCodeNo.Text = "";
			this.textBoxBarCodeNo.TextChanged += new System.EventHandler(this.textBoxBarCodeNo_TextChanged);
			// 
			// labelBarCodeNo
			// 
			this.labelBarCodeNo.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelBarCodeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBarCodeNo.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelBarCodeNo.Location = new System.Drawing.Point(240, 80);
			this.labelBarCodeNo.Name = "labelBarCodeNo";
			this.labelBarCodeNo.Size = new System.Drawing.Size(120, 24);
			this.labelBarCodeNo.TabIndex = 218;
			this.labelBarCodeNo.Text = "BarCode No";
			// 
			// FrmSearchBookMiniForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.ClientSize = new System.Drawing.Size(936, 466);
			this.Controls.Add(this.textBoxBarCodeNo);
			this.Controls.Add(this.labelBarCodeNo);
			this.Controls.Add(this.pictureBoxLogoPicture);
			this.Controls.Add(this.pictureBoxVariant);
			this.Controls.Add(this.textBoxSubject);
			this.Controls.Add(this.textBoxISBN);
			this.Controls.Add(this.textBoxPublisher);
			this.Controls.Add(this.textBoxAuthor);
			this.Controls.Add(this.textBoxLC);
			this.Controls.Add(this.textBoxDDC);
			this.Controls.Add(this.textBoxBookName);
			this.Controls.Add(this.textBoxBookCode);
			this.Controls.Add(this.textBoxSearch);
			this.Controls.Add(this.labelISBN);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.buttonSearch);
			this.Controls.Add(this.comboBoxPublishYearFrom);
			this.Controls.Add(this.comboBoxPublishYearTo);
			this.Controls.Add(this.labelPublishYear);
			this.Controls.Add(this.labelPublisher);
			this.Controls.Add(this.labelAuthor);
			this.Controls.Add(this.labelSubject);
			this.Controls.Add(this.labelLC);
			this.Controls.Add(this.labelDDC);
			this.Controls.Add(this.comboBoxBookGroup);
			this.Controls.Add(this.labelBookGroup);
			this.Controls.Add(this.comboBoxType);
			this.Controls.Add(this.labelType);
			this.Controls.Add(this.labelBookName);
			this.Controls.Add(this.labelBookCode);
			this.Controls.Add(this.dataGridGetBook);
			this.Controls.Add(this.labelCity);
			this.Controls.Add(this.LabelTitle);
			this.Controls.Add(this.pictureBoxMainForm);
			this.Controls.Add(this.pictureBoxLeftForm);
			this.Location = new System.Drawing.Point(30, 250);
			this.Name = "FrmSearchBookMiniForm";
			this.Text = "Get Book";
			this.Load += new System.EventHandler(this.FrmSearchBookMiniForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridGetBook)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void FrmSearchBookMiniForm_Load(object sender, System.EventArgs e)
		{
			this.Location = new System.Drawing.Point(32,190);
			int x;
			for(x=DateTime.Now.Year;x>=1900;x--)
			{
				comboBoxPublishYearFrom.Items.Add(x);
				comboBoxPublishYearTo.Items.Add(x);
			}
			MyBookSearch = new BookSearch();
			MyClassDatabase = new ClassDatabase();
			MyBookType = MyClassDatabase.GetBookType();
			comboBoxType.DataSource = MyBookType;
			comboBoxType.DisplayMember = "BookType";
			comboBoxType.SelectedIndex = -1;
			MyGroupName = MyClassDatabase.GetBookGroup();
			comboBoxBookGroup.DataSource = MyGroupName;
			comboBoxBookGroup.DisplayMember = "GroupName";
			comboBoxBookGroup.SelectedIndex = -1;
			MyDataTable = new DataTable();
		}



		private void textBoxBookCode_TextChanged(object sender, System.EventArgs e)
		{
			MyBookSearch.BookCode = textBoxBookCode.Text.ToString();
		}

		private void textBoxISBN_TextChanged(object sender, System.EventArgs e)
		{
			MyBookSearch.ISBN = textBoxISBN.Text.ToString();
		}

		private void textBoxBookName_TextChanged(object sender, System.EventArgs e)
		{
			MyBookSearch.BookName  = textBoxBookName.Text.ToString();
		}

	

		private void comboBoxType_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			MyBookSearch.BookTypeID = comboBoxType.Text.ToString();
		}

		private void comboBoxBookGroup_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			MyBookSearch.BookGroupName = comboBoxBookGroup.Text.ToString();
		}

		private void textBoxDDC_TextChanged(object sender, System.EventArgs e)
		{
			MyBookSearch.DDC = textBoxDDC.Text.ToString();
		}

		private void textBoxLC_TextChanged(object sender, System.EventArgs e)
		{
			MyBookSearch.LC = textBoxLC.Text.ToString();
		}

		private void textBoxSubject_TextChanged(object sender, System.EventArgs e)
		{
			MyBookSearch.Subject = textBoxSubject.Text.ToString();
		}

		private void textBoxAuthor_TextChanged(object sender, System.EventArgs e)
		{
			MyBookSearch.Author = textBoxAuthor.Text.ToString();
		}

		private void textBoxPublisher_TextChanged(object sender, System.EventArgs e)
		{
			MyBookSearch.Publisher = textBoxPublisher.Text.ToString();
		}

		private void comboBoxPublishYearFrom_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			MyBookSearch.PublishYearFrom = comboBoxPublishYearFrom.Text.ToString();
		}

		private void comboBoxPublishYearTo_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			MyBookSearch.PublishYearTo = comboBoxPublishYearTo.Text.ToString();
		}
		private void buttonClear_Click(object sender, System.EventArgs e)
		{
			DoClear();
		}

		private void buttonSearch_Click(object sender, System.EventArgs e)
		{
			if(textBoxBarCodeNo.Text.ToString() =="" && textBoxAuthor.Text.ToString() == "" && textBoxBookCode.Text.ToString() == "" && comboBoxBookGroup.Text.ToString() == "" && textBoxBookName.Text.ToString() == "" && comboBoxType.Text.ToString() == "" && textBoxDDC.Text.ToString() =="" && textBoxISBN.Text.ToString() == "" && textBoxLC.Text.ToString() == "" && textBoxPublisher.Text.ToString() =="" && comboBoxPublishYearFrom.Text.ToString() =="" && comboBoxPublishYearTo.Text.ToString() == "" && textBoxSubject.Text.ToString() == "")
			{
				MessageBox.Show("Please input the criteria for searching books !","Information");
			}
			else
			{
				MyClassDatabase = new ClassDatabase();
				MyDataTable = MyClassDatabase.GetBookList2(MyBookSearch);
				dataGridGetBook.DataSource = MyDataTable;
			}
		}
		internal void DoClear()
		{
			textBoxBookCode.Text = "";
			textBoxBookName.Text = "";
			textBoxDDC.Text = "";
			textBoxLC.Text = "";
			textBoxSubject.Text = "";
			textBoxAuthor.Text = "";
			textBoxPublisher.Text = "";
			textBoxBarCodeNo.Text = "";
			comboBoxPublishYearFrom.Text = "";
			comboBoxPublishYearTo.Text = "";
			MyClassDatabase = new ClassDatabase();
			MyBookType = MyClassDatabase.GetBookType();
			comboBoxType.DataSource = MyBookType;
			comboBoxType.DisplayMember = "BookType";
			comboBoxType.SelectedIndex = -1;
			MyGroupName = MyClassDatabase.GetBookGroup();
			comboBoxBookGroup.DataSource = MyGroupName;
			comboBoxBookGroup.DisplayMember = "GroupName";
			comboBoxBookGroup.SelectedIndex = -1;
		}

		private void dataGridGetBook_Click(object sender, System.EventArgs e)
		{

		}
		private void dataGridGetBook_DoubleClick(object sender, System.EventArgs e)
		{
			
			if(MyDataTable.Rows.Count>0)
			{
				if(MyCurrentData == "Borrow")
				{

					MyTransactionBorrowForm.textBoxBarCodeNo.Text   = dataGridGetBook[dataGridGetBook.CurrentRowIndex,2].ToString().Trim();
					MyTransactionBorrowForm.MyBookTransaction.BookCode = dataGridGetBook[dataGridGetBook.CurrentRowIndex,0].ToString().Trim();
					MyTransactionBorrowForm.textBoxBookName.Text = dataGridGetBook[dataGridGetBook.CurrentRowIndex,3].ToString().Trim();
					this.Hide();
				}
			}	
		}

		private void textBoxBarCodeNo_TextChanged(object sender, System.EventArgs e)
		{
			MyBookSearch.BarCodeNo = textBoxBarCodeNo.Text.ToString();
		}

	}
}
