using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Sola_Scriptura_ChurchMembership
{
	/// <summary>
	/// Summary description for FrmSearchParentForm.
	/// </summary>
	public class FrmSearchMiniForm : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.PictureBox pictureBoxLeftForm;
		internal System.Windows.Forms.PictureBox pictureBoxMainForm;
		internal System.Windows.Forms.PictureBox pictureBoxVariant;
		internal System.Windows.Forms.Label LabelTitle;
		internal System.Windows.Forms.Label labelCity;
		internal System.Windows.Forms.TextBox textBoxSearch;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		internal System.Windows.Forms.DataGrid dataGridSearch;
		internal System.Windows.Forms.DataGridTableStyle dataGridTableStyleBookGroupCode;
		internal System.Windows.Forms.DataGridTableStyle dataGridTableStylePublisher;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnBookGroupCode;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnBookGroupName;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnPublisherCode;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnPublisherName;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnAddress;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnCity;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnPostCode;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnState;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnCountry;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnPhone;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnFax;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnEmail;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnContactPerson;
		internal System.Windows.Forms.DataGridTableStyle dataGridTableStyleBookAuthor;
		internal System.Windows.Forms.DataGridTableStyle dataGridTableStyleAuthorType;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnAuthorCode;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnFirstname;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnLastName;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnAuthorType;
		internal System.Windows.Forms.DataGridTableStyle dataGridTableStyleBookShelf;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnShelfCode;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnShelfDes;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnLocationCode;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnLocationName;
		internal System.Windows.Forms.DataGridTableStyle dataGridTableStyleBookStore;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnStoreCode;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnStoreName;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnStoreAddress;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnStoreCity;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnStorePostCode;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnStoreState;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnStoreCountry;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnStorePhone;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnStoreFax;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnStoreEmail;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnStoreContactPerson;
		internal System.Windows.Forms.DataGridTableStyle dataGridTableStyleBookSubject;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnSubjectCode;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnSubjectName;
		internal System.Windows.Forms.DataGridTableStyle dataGridTableStyleCurrency;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnCurr;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnCurrencyName;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnCurrRate;
		internal System.Windows.Forms.DataGridTableStyle dataGridTableStyleMember;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnMemberID;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnMemberName;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnActiveDate;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnMemberGroupCode;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnMemberAddress;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnMemberCity;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnMemberPostCode;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnMemberState;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnMemberCountry;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnMemberPhone;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnMemberHandPhone;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnMemberEmail;
		



		internal ClassDatabase MyClassDatabase;
		internal DataTable MyDataTable;
		internal System.Windows.Forms.DataGridTableStyle dataGridTableStyleBorrowDate;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnBorrowDate;
		internal System.Windows.Forms.PictureBox pictureBoxLogoPicture;
		internal DataView MyDataView;
		internal System.Windows.Forms.Button buttonAdd;
		internal string MyCriteria;
		internal FrmTransaction MyTransactionForm;
		
		public FrmSearchMiniForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}
		public FrmSearchMiniForm(FrmTransaction MyTransactionFormForm)
		{

			InitializeComponent();
			this.MdiParent = MyTransactionFormForm.MyMDIForm;
			MyTransactionForm = MyTransactionFormForm;

		}

		///
		///
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmSearchMiniForm));
			this.pictureBoxLeftForm = new System.Windows.Forms.PictureBox();
			this.pictureBoxMainForm = new System.Windows.Forms.PictureBox();
			this.pictureBoxVariant = new System.Windows.Forms.PictureBox();
			this.LabelTitle = new System.Windows.Forms.Label();
			this.dataGridSearch = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyleBookGroupCode = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnBookGroupCode = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnBookGroupName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTableStylePublisher = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnPublisherCode = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnPublisherName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnAddress = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnCity = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnPostCode = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnState = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnCountry = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnPhone = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnFax = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnEmail = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnContactPerson = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTableStyleBookAuthor = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnAuthorCode = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnFirstname = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnLastName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTableStyleAuthorType = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnAuthorType = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTableStyleBookShelf = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnShelfCode = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnShelfDes = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnLocationCode = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnLocationName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTableStyleBookStore = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnStoreCode = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnStoreName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnStoreAddress = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnStoreCity = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnStorePostCode = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnStoreState = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnStoreCountry = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnStorePhone = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnStoreFax = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnStoreEmail = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnStoreContactPerson = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTableStyleBookSubject = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnSubjectCode = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnSubjectName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTableStyleCurrency = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnCurr = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnCurrencyName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnCurrRate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTableStyleMember = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnMemberID = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnMemberName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnActiveDate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnMemberGroupCode = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnMemberAddress = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnMemberCity = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnMemberPostCode = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnMemberState = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnMemberCountry = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnMemberPhone = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnMemberHandPhone = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnMemberEmail = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTableStyleBorrowDate = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnBorrowDate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.labelCity = new System.Windows.Forms.Label();
			this.pictureBoxLogoPicture = new System.Windows.Forms.PictureBox();
			this.buttonAdd = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridSearch)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxLeftForm
			// 
			this.pictureBoxLeftForm.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLeftForm.Image")));
			this.pictureBoxLeftForm.Location = new System.Drawing.Point(0, 0);
			this.pictureBoxLeftForm.Name = "pictureBoxLeftForm";
			this.pictureBoxLeftForm.Size = new System.Drawing.Size(192, 416);
			this.pictureBoxLeftForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxLeftForm.TabIndex = 1;
			this.pictureBoxLeftForm.TabStop = false;
			this.pictureBoxLeftForm.Click += new System.EventHandler(this.pictureBoxLeftForm_Click);
			// 
			// pictureBoxMainForm
			// 
			this.pictureBoxMainForm.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMainForm.Image")));
			this.pictureBoxMainForm.Location = new System.Drawing.Point(192, 0);
			this.pictureBoxMainForm.Name = "pictureBoxMainForm";
			this.pictureBoxMainForm.Size = new System.Drawing.Size(704, 416);
			this.pictureBoxMainForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxMainForm.TabIndex = 2;
			this.pictureBoxMainForm.TabStop = false;
			// 
			// pictureBoxVariant
			// 
			this.pictureBoxVariant.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxVariant.Image")));
			this.pictureBoxVariant.Location = new System.Drawing.Point(208, 248);
			this.pictureBoxVariant.Name = "pictureBoxVariant";
			this.pictureBoxVariant.Size = new System.Drawing.Size(29, 154);
			this.pictureBoxVariant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxVariant.TabIndex = 3;
			this.pictureBoxVariant.TabStop = false;
			// 
			// LabelTitle
			// 
			this.LabelTitle.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.LabelTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.LabelTitle.Image = ((System.Drawing.Image)(resources.GetObject("LabelTitle.Image")));
			this.LabelTitle.Location = new System.Drawing.Point(688, 8);
			this.LabelTitle.Name = "LabelTitle";
			this.LabelTitle.Size = new System.Drawing.Size(192, 32);
			this.LabelTitle.TabIndex = 60;
			this.LabelTitle.Text = "    Title";
			this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dataGridSearch
			// 
			this.dataGridSearch.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGridSearch.DataMember = "";
			this.dataGridSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGridSearch.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridSearch.Location = new System.Drawing.Point(240, 56);
			this.dataGridSearch.Name = "dataGridSearch";
			this.dataGridSearch.ReadOnly = true;
			this.dataGridSearch.Size = new System.Drawing.Size(640, 344);
			this.dataGridSearch.TabIndex = 2;
			this.dataGridSearch.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																									   this.dataGridTableStyleBookGroupCode,
																									   this.dataGridTableStylePublisher,
																									   this.dataGridTableStyleBookAuthor,
																									   this.dataGridTableStyleAuthorType,
																									   this.dataGridTableStyleBookShelf,
																									   this.dataGridTableStyleBookStore,
																									   this.dataGridTableStyleBookSubject,
																									   this.dataGridTableStyleCurrency,
																									   this.dataGridTableStyleMember,
																									   this.dataGridTableStyleBorrowDate});
			this.dataGridSearch.DoubleClick += new System.EventHandler(this.dataGridSearch_DoubleClick);
			// 
			// dataGridTableStyleBookGroupCode
			// 
			this.dataGridTableStyleBookGroupCode.AlternatingBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleBookGroupCode.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.dataGridTableStyleBookGroupCode.DataGrid = this.dataGridSearch;
			this.dataGridTableStyleBookGroupCode.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleBookGroupCode.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																															  this.dataGridTextBoxColumnBookGroupCode,
																															  this.dataGridTextBoxColumnBookGroupName});
			this.dataGridTableStyleBookGroupCode.GridLineColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridTableStyleBookGroupCode.HeaderBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleBookGroupCode.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleBookGroupCode.MappingName = "BookGroup";
			// 
			// dataGridTextBoxColumnBookGroupCode
			// 
			this.dataGridTextBoxColumnBookGroupCode.Format = "";
			this.dataGridTextBoxColumnBookGroupCode.FormatInfo = null;
			this.dataGridTextBoxColumnBookGroupCode.HeaderText = "Group Code";
			this.dataGridTextBoxColumnBookGroupCode.MappingName = "BookGroupCode";
			this.dataGridTextBoxColumnBookGroupCode.Width = 75;
			// 
			// dataGridTextBoxColumnBookGroupName
			// 
			this.dataGridTextBoxColumnBookGroupName.Format = "";
			this.dataGridTextBoxColumnBookGroupName.FormatInfo = null;
			this.dataGridTextBoxColumnBookGroupName.HeaderText = "Group Name";
			this.dataGridTextBoxColumnBookGroupName.MappingName = "GroupName";
			this.dataGridTextBoxColumnBookGroupName.Width = 250;
			// 
			// dataGridTableStylePublisher
			// 
			this.dataGridTableStylePublisher.AlternatingBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStylePublisher.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(96)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.dataGridTableStylePublisher.DataGrid = this.dataGridSearch;
			this.dataGridTableStylePublisher.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStylePublisher.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																														  this.dataGridTextBoxColumnPublisherCode,
																														  this.dataGridTextBoxColumnPublisherName,
																														  this.dataGridTextBoxColumnAddress,
																														  this.dataGridTextBoxColumnCity,
																														  this.dataGridTextBoxColumnPostCode,
																														  this.dataGridTextBoxColumnState,
																														  this.dataGridTextBoxColumnCountry,
																														  this.dataGridTextBoxColumnPhone,
																														  this.dataGridTextBoxColumnFax,
																														  this.dataGridTextBoxColumnEmail,
																														  this.dataGridTextBoxColumnContactPerson});
			this.dataGridTableStylePublisher.GridLineColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridTableStylePublisher.HeaderBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStylePublisher.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStylePublisher.MappingName = "PublisherList";
			// 
			// dataGridTextBoxColumnPublisherCode
			// 
			this.dataGridTextBoxColumnPublisherCode.Format = "";
			this.dataGridTextBoxColumnPublisherCode.FormatInfo = null;
			this.dataGridTextBoxColumnPublisherCode.HeaderText = "Publisher Code";
			this.dataGridTextBoxColumnPublisherCode.MappingName = "PublisherCode";
			this.dataGridTextBoxColumnPublisherCode.Width = 120;
			// 
			// dataGridTextBoxColumnPublisherName
			// 
			this.dataGridTextBoxColumnPublisherName.Format = "";
			this.dataGridTextBoxColumnPublisherName.FormatInfo = null;
			this.dataGridTextBoxColumnPublisherName.HeaderText = "Publisher Name";
			this.dataGridTextBoxColumnPublisherName.MappingName = "PublisherName";
			this.dataGridTextBoxColumnPublisherName.Width = 175;
			// 
			// dataGridTextBoxColumnAddress
			// 
			this.dataGridTextBoxColumnAddress.Format = "";
			this.dataGridTextBoxColumnAddress.FormatInfo = null;
			this.dataGridTextBoxColumnAddress.HeaderText = "Address";
			this.dataGridTextBoxColumnAddress.MappingName = "Address";
			this.dataGridTextBoxColumnAddress.Width = 75;
			// 
			// dataGridTextBoxColumnCity
			// 
			this.dataGridTextBoxColumnCity.Format = "";
			this.dataGridTextBoxColumnCity.FormatInfo = null;
			this.dataGridTextBoxColumnCity.HeaderText = "City";
			this.dataGridTextBoxColumnCity.MappingName = "City";
			this.dataGridTextBoxColumnCity.Width = 75;
			// 
			// dataGridTextBoxColumnPostCode
			// 
			this.dataGridTextBoxColumnPostCode.Format = "";
			this.dataGridTextBoxColumnPostCode.FormatInfo = null;
			this.dataGridTextBoxColumnPostCode.HeaderText = "PostCode";
			this.dataGridTextBoxColumnPostCode.MappingName = "PostCode";
			this.dataGridTextBoxColumnPostCode.Width = 75;
			// 
			// dataGridTextBoxColumnState
			// 
			this.dataGridTextBoxColumnState.Format = "";
			this.dataGridTextBoxColumnState.FormatInfo = null;
			this.dataGridTextBoxColumnState.HeaderText = "State";
			this.dataGridTextBoxColumnState.MappingName = "State";
			this.dataGridTextBoxColumnState.Width = 75;
			// 
			// dataGridTextBoxColumnCountry
			// 
			this.dataGridTextBoxColumnCountry.Format = "";
			this.dataGridTextBoxColumnCountry.FormatInfo = null;
			this.dataGridTextBoxColumnCountry.HeaderText = "Country";
			this.dataGridTextBoxColumnCountry.MappingName = "Country";
			this.dataGridTextBoxColumnCountry.Width = 75;
			// 
			// dataGridTextBoxColumnPhone
			// 
			this.dataGridTextBoxColumnPhone.Format = "";
			this.dataGridTextBoxColumnPhone.FormatInfo = null;
			this.dataGridTextBoxColumnPhone.HeaderText = "Phone";
			this.dataGridTextBoxColumnPhone.MappingName = "Phone";
			this.dataGridTextBoxColumnPhone.Width = 75;
			// 
			// dataGridTextBoxColumnFax
			// 
			this.dataGridTextBoxColumnFax.Format = "";
			this.dataGridTextBoxColumnFax.FormatInfo = null;
			this.dataGridTextBoxColumnFax.HeaderText = "Fax";
			this.dataGridTextBoxColumnFax.MappingName = "Fax";
			this.dataGridTextBoxColumnFax.Width = 75;
			// 
			// dataGridTextBoxColumnEmail
			// 
			this.dataGridTextBoxColumnEmail.Format = "";
			this.dataGridTextBoxColumnEmail.FormatInfo = null;
			this.dataGridTextBoxColumnEmail.HeaderText = "Email";
			this.dataGridTextBoxColumnEmail.MappingName = "Email";
			this.dataGridTextBoxColumnEmail.Width = 120;
			// 
			// dataGridTextBoxColumnContactPerson
			// 
			this.dataGridTextBoxColumnContactPerson.Format = "";
			this.dataGridTextBoxColumnContactPerson.FormatInfo = null;
			this.dataGridTextBoxColumnContactPerson.HeaderText = "Contact Person";
			this.dataGridTextBoxColumnContactPerson.MappingName = "ContactPerson";
			this.dataGridTextBoxColumnContactPerson.Width = 75;
			// 
			// dataGridTableStyleBookAuthor
			// 
			this.dataGridTableStyleBookAuthor.AlternatingBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleBookAuthor.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.dataGridTableStyleBookAuthor.DataGrid = this.dataGridSearch;
			this.dataGridTableStyleBookAuthor.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleBookAuthor.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																														   this.dataGridTextBoxColumnAuthorCode,
																														   this.dataGridTextBoxColumnFirstname,
																														   this.dataGridTextBoxColumnLastName});
			this.dataGridTableStyleBookAuthor.GridLineColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridTableStyleBookAuthor.HeaderBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleBookAuthor.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleBookAuthor.MappingName = "AuthorList";
			// 
			// dataGridTextBoxColumnAuthorCode
			// 
			this.dataGridTextBoxColumnAuthorCode.Format = "";
			this.dataGridTextBoxColumnAuthorCode.FormatInfo = null;
			this.dataGridTextBoxColumnAuthorCode.HeaderText = "Author Code";
			this.dataGridTextBoxColumnAuthorCode.MappingName = "AuthorCode";
			this.dataGridTextBoxColumnAuthorCode.Width = 120;
			// 
			// dataGridTextBoxColumnFirstname
			// 
			this.dataGridTextBoxColumnFirstname.Format = "";
			this.dataGridTextBoxColumnFirstname.FormatInfo = null;
			this.dataGridTextBoxColumnFirstname.HeaderText = "FirstName";
			this.dataGridTextBoxColumnFirstname.MappingName = "FirstName";
			this.dataGridTextBoxColumnFirstname.Width = 130;
			// 
			// dataGridTextBoxColumnLastName
			// 
			this.dataGridTextBoxColumnLastName.Format = "";
			this.dataGridTextBoxColumnLastName.FormatInfo = null;
			this.dataGridTextBoxColumnLastName.HeaderText = "LastName";
			this.dataGridTextBoxColumnLastName.MappingName = "LastName";
			this.dataGridTextBoxColumnLastName.Width = 130;
			// 
			// dataGridTableStyleAuthorType
			// 
			this.dataGridTableStyleAuthorType.AlternatingBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleAuthorType.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.dataGridTableStyleAuthorType.DataGrid = this.dataGridSearch;
			this.dataGridTableStyleAuthorType.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleAuthorType.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																														   this.dataGridTextBoxColumnAuthorType});
			this.dataGridTableStyleAuthorType.GridLineColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridTableStyleAuthorType.HeaderBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleAuthorType.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleAuthorType.MappingName = "AuthorType";
			// 
			// dataGridTextBoxColumnAuthorType
			// 
			this.dataGridTextBoxColumnAuthorType.Format = "";
			this.dataGridTextBoxColumnAuthorType.FormatInfo = null;
			this.dataGridTextBoxColumnAuthorType.HeaderText = "Author Type";
			this.dataGridTextBoxColumnAuthorType.MappingName = "AuthorType";
			this.dataGridTextBoxColumnAuthorType.Width = 250;
			// 
			// dataGridTableStyleBookShelf
			// 
			this.dataGridTableStyleBookShelf.AlternatingBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleBookShelf.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.dataGridTableStyleBookShelf.DataGrid = this.dataGridSearch;
			this.dataGridTableStyleBookShelf.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleBookShelf.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																														  this.dataGridTextBoxColumnShelfCode,
																														  this.dataGridTextBoxColumnShelfDes,
																														  this.dataGridTextBoxColumnLocationCode,
																														  this.dataGridTextBoxColumnLocationName});
			this.dataGridTableStyleBookShelf.GridLineColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridTableStyleBookShelf.HeaderBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleBookShelf.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleBookShelf.MappingName = "ShelfList";
			// 
			// dataGridTextBoxColumnShelfCode
			// 
			this.dataGridTextBoxColumnShelfCode.Format = "";
			this.dataGridTextBoxColumnShelfCode.FormatInfo = null;
			this.dataGridTextBoxColumnShelfCode.HeaderText = "Shelf Code";
			this.dataGridTextBoxColumnShelfCode.MappingName = "ShelfCode";
			this.dataGridTextBoxColumnShelfCode.Width = 75;
			// 
			// dataGridTextBoxColumnShelfDes
			// 
			this.dataGridTextBoxColumnShelfDes.Format = "";
			this.dataGridTextBoxColumnShelfDes.FormatInfo = null;
			this.dataGridTextBoxColumnShelfDes.HeaderText = "Shelf Desc";
			this.dataGridTextBoxColumnShelfDes.MappingName = "ShelfDesc";
			this.dataGridTextBoxColumnShelfDes.Width = 250;
			// 
			// dataGridTextBoxColumnLocationCode
			// 
			this.dataGridTextBoxColumnLocationCode.Format = "";
			this.dataGridTextBoxColumnLocationCode.FormatInfo = null;
			this.dataGridTextBoxColumnLocationCode.HeaderText = "Location Code";
			this.dataGridTextBoxColumnLocationCode.MappingName = "LocationCode";
			this.dataGridTextBoxColumnLocationCode.Width = 0;
			// 
			// dataGridTextBoxColumnLocationName
			// 
			this.dataGridTextBoxColumnLocationName.Format = "";
			this.dataGridTextBoxColumnLocationName.FormatInfo = null;
			this.dataGridTextBoxColumnLocationName.HeaderText = "LocationName";
			this.dataGridTextBoxColumnLocationName.MappingName = "LocationName";
			this.dataGridTextBoxColumnLocationName.Width = 75;
			// 
			// dataGridTableStyleBookStore
			// 
			this.dataGridTableStyleBookStore.AlternatingBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleBookStore.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.dataGridTableStyleBookStore.DataGrid = this.dataGridSearch;
			this.dataGridTableStyleBookStore.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleBookStore.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																														  this.dataGridTextBoxColumnStoreCode,
																														  this.dataGridTextBoxColumnStoreName,
																														  this.dataGridTextBoxColumnStoreAddress,
																														  this.dataGridTextBoxColumnStoreCity,
																														  this.dataGridTextBoxColumnStorePostCode,
																														  this.dataGridTextBoxColumnStoreState,
																														  this.dataGridTextBoxColumnStoreCountry,
																														  this.dataGridTextBoxColumnStorePhone,
																														  this.dataGridTextBoxColumnStoreFax,
																														  this.dataGridTextBoxColumnStoreEmail,
																														  this.dataGridTextBoxColumnStoreContactPerson});
			this.dataGridTableStyleBookStore.GridLineColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridTableStyleBookStore.HeaderBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleBookStore.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleBookStore.MappingName = "BookStoreList";
			// 
			// dataGridTextBoxColumnStoreCode
			// 
			this.dataGridTextBoxColumnStoreCode.Format = "";
			this.dataGridTextBoxColumnStoreCode.FormatInfo = null;
			this.dataGridTextBoxColumnStoreCode.HeaderText = "StoreCode";
			this.dataGridTextBoxColumnStoreCode.MappingName = "StoreCode";
			this.dataGridTextBoxColumnStoreCode.Width = 75;
			// 
			// dataGridTextBoxColumnStoreName
			// 
			this.dataGridTextBoxColumnStoreName.Format = "";
			this.dataGridTextBoxColumnStoreName.FormatInfo = null;
			this.dataGridTextBoxColumnStoreName.HeaderText = "Store Name";
			this.dataGridTextBoxColumnStoreName.MappingName = "StoreName";
			this.dataGridTextBoxColumnStoreName.Width = 150;
			// 
			// dataGridTextBoxColumnStoreAddress
			// 
			this.dataGridTextBoxColumnStoreAddress.Format = "";
			this.dataGridTextBoxColumnStoreAddress.FormatInfo = null;
			this.dataGridTextBoxColumnStoreAddress.HeaderText = "Address";
			this.dataGridTextBoxColumnStoreAddress.MappingName = "Address";
			this.dataGridTextBoxColumnStoreAddress.Width = 75;
			// 
			// dataGridTextBoxColumnStoreCity
			// 
			this.dataGridTextBoxColumnStoreCity.Format = "";
			this.dataGridTextBoxColumnStoreCity.FormatInfo = null;
			this.dataGridTextBoxColumnStoreCity.HeaderText = "City";
			this.dataGridTextBoxColumnStoreCity.MappingName = "City";
			this.dataGridTextBoxColumnStoreCity.Width = 75;
			// 
			// dataGridTextBoxColumnStorePostCode
			// 
			this.dataGridTextBoxColumnStorePostCode.Format = "";
			this.dataGridTextBoxColumnStorePostCode.FormatInfo = null;
			this.dataGridTextBoxColumnStorePostCode.HeaderText = "PostCode";
			this.dataGridTextBoxColumnStorePostCode.MappingName = "PostCode";
			this.dataGridTextBoxColumnStorePostCode.Width = 75;
			// 
			// dataGridTextBoxColumnStoreState
			// 
			this.dataGridTextBoxColumnStoreState.Format = "";
			this.dataGridTextBoxColumnStoreState.FormatInfo = null;
			this.dataGridTextBoxColumnStoreState.HeaderText = "State";
			this.dataGridTextBoxColumnStoreState.MappingName = "State";
			this.dataGridTextBoxColumnStoreState.Width = 75;
			// 
			// dataGridTextBoxColumnStoreCountry
			// 
			this.dataGridTextBoxColumnStoreCountry.Format = "";
			this.dataGridTextBoxColumnStoreCountry.FormatInfo = null;
			this.dataGridTextBoxColumnStoreCountry.HeaderText = "Country";
			this.dataGridTextBoxColumnStoreCountry.MappingName = "Country";
			this.dataGridTextBoxColumnStoreCountry.Width = 75;
			// 
			// dataGridTextBoxColumnStorePhone
			// 
			this.dataGridTextBoxColumnStorePhone.Format = "";
			this.dataGridTextBoxColumnStorePhone.FormatInfo = null;
			this.dataGridTextBoxColumnStorePhone.HeaderText = "Phone";
			this.dataGridTextBoxColumnStorePhone.MappingName = "Phone";
			this.dataGridTextBoxColumnStorePhone.Width = 75;
			// 
			// dataGridTextBoxColumnStoreFax
			// 
			this.dataGridTextBoxColumnStoreFax.Format = "";
			this.dataGridTextBoxColumnStoreFax.FormatInfo = null;
			this.dataGridTextBoxColumnStoreFax.HeaderText = "Fax";
			this.dataGridTextBoxColumnStoreFax.MappingName = "Fax";
			this.dataGridTextBoxColumnStoreFax.Width = 75;
			// 
			// dataGridTextBoxColumnStoreEmail
			// 
			this.dataGridTextBoxColumnStoreEmail.Format = "";
			this.dataGridTextBoxColumnStoreEmail.FormatInfo = null;
			this.dataGridTextBoxColumnStoreEmail.HeaderText = "Email";
			this.dataGridTextBoxColumnStoreEmail.MappingName = "Email";
			this.dataGridTextBoxColumnStoreEmail.Width = 75;
			// 
			// dataGridTextBoxColumnStoreContactPerson
			// 
			this.dataGridTextBoxColumnStoreContactPerson.Format = "";
			this.dataGridTextBoxColumnStoreContactPerson.FormatInfo = null;
			this.dataGridTextBoxColumnStoreContactPerson.HeaderText = "Contact Person";
			this.dataGridTextBoxColumnStoreContactPerson.MappingName = "ContactPerson";
			this.dataGridTextBoxColumnStoreContactPerson.Width = 75;
			// 
			// dataGridTableStyleBookSubject
			// 
			this.dataGridTableStyleBookSubject.AlternatingBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleBookSubject.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.dataGridTableStyleBookSubject.DataGrid = this.dataGridSearch;
			this.dataGridTableStyleBookSubject.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleBookSubject.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																															this.dataGridTextBoxColumnSubjectCode,
																															this.dataGridTextBoxColumnSubjectName});
			this.dataGridTableStyleBookSubject.GridLineColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridTableStyleBookSubject.HeaderBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleBookSubject.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleBookSubject.MappingName = "SubjectList";
			// 
			// dataGridTextBoxColumnSubjectCode
			// 
			this.dataGridTextBoxColumnSubjectCode.Format = "";
			this.dataGridTextBoxColumnSubjectCode.FormatInfo = null;
			this.dataGridTextBoxColumnSubjectCode.HeaderText = "Subject Code";
			this.dataGridTextBoxColumnSubjectCode.MappingName = "SubjectCode";
			this.dataGridTextBoxColumnSubjectCode.Width = 75;
			// 
			// dataGridTextBoxColumnSubjectName
			// 
			this.dataGridTextBoxColumnSubjectName.Format = "";
			this.dataGridTextBoxColumnSubjectName.FormatInfo = null;
			this.dataGridTextBoxColumnSubjectName.HeaderText = "Subject Name";
			this.dataGridTextBoxColumnSubjectName.MappingName = "SubjectName";
			this.dataGridTextBoxColumnSubjectName.Width = 300;
			// 
			// dataGridTableStyleCurrency
			// 
			this.dataGridTableStyleCurrency.AlternatingBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleCurrency.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.dataGridTableStyleCurrency.DataGrid = this.dataGridSearch;
			this.dataGridTableStyleCurrency.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleCurrency.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																														 this.dataGridTextBoxColumnCurr,
																														 this.dataGridTextBoxColumnCurrencyName,
																														 this.dataGridTextBoxColumnCurrRate});
			this.dataGridTableStyleCurrency.GridLineColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridTableStyleCurrency.HeaderBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleCurrency.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleCurrency.MappingName = "CurrencyList";
			// 
			// dataGridTextBoxColumnCurr
			// 
			this.dataGridTextBoxColumnCurr.Format = "";
			this.dataGridTextBoxColumnCurr.FormatInfo = null;
			this.dataGridTextBoxColumnCurr.HeaderText = "Curr";
			this.dataGridTextBoxColumnCurr.MappingName = "Curr";
			this.dataGridTextBoxColumnCurr.Width = 75;
			// 
			// dataGridTextBoxColumnCurrencyName
			// 
			this.dataGridTextBoxColumnCurrencyName.Format = "";
			this.dataGridTextBoxColumnCurrencyName.FormatInfo = null;
			this.dataGridTextBoxColumnCurrencyName.HeaderText = "Currency Name";
			this.dataGridTextBoxColumnCurrencyName.MappingName = "CurrName";
			this.dataGridTextBoxColumnCurrencyName.Width = 270;
			// 
			// dataGridTextBoxColumnCurrRate
			// 
			this.dataGridTextBoxColumnCurrRate.Format = "";
			this.dataGridTextBoxColumnCurrRate.FormatInfo = null;
			this.dataGridTextBoxColumnCurrRate.HeaderText = "Curr Rate";
			this.dataGridTextBoxColumnCurrRate.MappingName = "CurrRate";
			this.dataGridTextBoxColumnCurrRate.Width = 150;
			// 
			// dataGridTableStyleMember
			// 
			this.dataGridTableStyleMember.AlternatingBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleMember.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.dataGridTableStyleMember.DataGrid = this.dataGridSearch;
			this.dataGridTableStyleMember.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleMember.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																													   this.dataGridTextBoxColumnMemberID,
																													   this.dataGridTextBoxColumnMemberName,
																													   this.dataGridTextBoxColumnActiveDate,
																													   this.dataGridTextBoxColumnMemberGroupCode,
																													   this.dataGridTextBoxColumnMemberAddress,
																													   this.dataGridTextBoxColumnMemberCity,
																													   this.dataGridTextBoxColumnMemberPostCode,
																													   this.dataGridTextBoxColumnMemberState,
																													   this.dataGridTextBoxColumnMemberCountry,
																													   this.dataGridTextBoxColumnMemberPhone,
																													   this.dataGridTextBoxColumnMemberHandPhone,
																													   this.dataGridTextBoxColumnMemberEmail});
			this.dataGridTableStyleMember.GridLineColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridTableStyleMember.HeaderBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleMember.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleMember.MappingName = "Member";
			// 
			// dataGridTextBoxColumnMemberID
			// 
			this.dataGridTextBoxColumnMemberID.Format = "";
			this.dataGridTextBoxColumnMemberID.FormatInfo = null;
			this.dataGridTextBoxColumnMemberID.HeaderText = "MemberID";
			this.dataGridTextBoxColumnMemberID.MappingName = "MemberID";
			this.dataGridTextBoxColumnMemberID.Width = 101;
			// 
			// dataGridTextBoxColumnMemberName
			// 
			this.dataGridTextBoxColumnMemberName.Format = "";
			this.dataGridTextBoxColumnMemberName.FormatInfo = null;
			this.dataGridTextBoxColumnMemberName.HeaderText = "Member Name";
			this.dataGridTextBoxColumnMemberName.MappingName = "MemberName";
			this.dataGridTextBoxColumnMemberName.Width = 200;
			// 
			// dataGridTextBoxColumnActiveDate
			// 
			this.dataGridTextBoxColumnActiveDate.Format = "";
			this.dataGridTextBoxColumnActiveDate.FormatInfo = null;
			this.dataGridTextBoxColumnActiveDate.HeaderText = "Active Date";
			this.dataGridTextBoxColumnActiveDate.MappingName = "ActiveDate";
			this.dataGridTextBoxColumnActiveDate.Width = 75;
			// 
			// dataGridTextBoxColumnMemberGroupCode
			// 
			this.dataGridTextBoxColumnMemberGroupCode.Format = "";
			this.dataGridTextBoxColumnMemberGroupCode.FormatInfo = null;
			this.dataGridTextBoxColumnMemberGroupCode.HeaderText = "Group Code";
			this.dataGridTextBoxColumnMemberGroupCode.MappingName = "MemberGroupCode";
			this.dataGridTextBoxColumnMemberGroupCode.Width = 75;
			// 
			// dataGridTextBoxColumnMemberAddress
			// 
			this.dataGridTextBoxColumnMemberAddress.Format = "";
			this.dataGridTextBoxColumnMemberAddress.FormatInfo = null;
			this.dataGridTextBoxColumnMemberAddress.HeaderText = "Address";
			this.dataGridTextBoxColumnMemberAddress.MappingName = "Address";
			this.dataGridTextBoxColumnMemberAddress.Width = 75;
			// 
			// dataGridTextBoxColumnMemberCity
			// 
			this.dataGridTextBoxColumnMemberCity.Format = "";
			this.dataGridTextBoxColumnMemberCity.FormatInfo = null;
			this.dataGridTextBoxColumnMemberCity.HeaderText = "City";
			this.dataGridTextBoxColumnMemberCity.MappingName = "City";
			this.dataGridTextBoxColumnMemberCity.Width = 75;
			// 
			// dataGridTextBoxColumnMemberPostCode
			// 
			this.dataGridTextBoxColumnMemberPostCode.Format = "";
			this.dataGridTextBoxColumnMemberPostCode.FormatInfo = null;
			this.dataGridTextBoxColumnMemberPostCode.HeaderText = "PostCode";
			this.dataGridTextBoxColumnMemberPostCode.MappingName = "PostCode";
			this.dataGridTextBoxColumnMemberPostCode.Width = 75;
			// 
			// dataGridTextBoxColumnMemberState
			// 
			this.dataGridTextBoxColumnMemberState.Format = "";
			this.dataGridTextBoxColumnMemberState.FormatInfo = null;
			this.dataGridTextBoxColumnMemberState.HeaderText = "State";
			this.dataGridTextBoxColumnMemberState.MappingName = "State";
			this.dataGridTextBoxColumnMemberState.Width = 75;
			// 
			// dataGridTextBoxColumnMemberCountry
			// 
			this.dataGridTextBoxColumnMemberCountry.Format = "";
			this.dataGridTextBoxColumnMemberCountry.FormatInfo = null;
			this.dataGridTextBoxColumnMemberCountry.HeaderText = "Country";
			this.dataGridTextBoxColumnMemberCountry.MappingName = "Country";
			this.dataGridTextBoxColumnMemberCountry.Width = 75;
			// 
			// dataGridTextBoxColumnMemberPhone
			// 
			this.dataGridTextBoxColumnMemberPhone.Format = "";
			this.dataGridTextBoxColumnMemberPhone.FormatInfo = null;
			this.dataGridTextBoxColumnMemberPhone.HeaderText = "Phone";
			this.dataGridTextBoxColumnMemberPhone.MappingName = "Phone";
			this.dataGridTextBoxColumnMemberPhone.Width = 75;
			// 
			// dataGridTextBoxColumnMemberHandPhone
			// 
			this.dataGridTextBoxColumnMemberHandPhone.Format = "";
			this.dataGridTextBoxColumnMemberHandPhone.FormatInfo = null;
			this.dataGridTextBoxColumnMemberHandPhone.HeaderText = "Hand Phone";
			this.dataGridTextBoxColumnMemberHandPhone.MappingName = "HandPhone";
			this.dataGridTextBoxColumnMemberHandPhone.Width = 75;
			// 
			// dataGridTextBoxColumnMemberEmail
			// 
			this.dataGridTextBoxColumnMemberEmail.Format = "";
			this.dataGridTextBoxColumnMemberEmail.FormatInfo = null;
			this.dataGridTextBoxColumnMemberEmail.HeaderText = "Email";
			this.dataGridTextBoxColumnMemberEmail.MappingName = "Email";
			this.dataGridTextBoxColumnMemberEmail.Width = 75;
			// 
			// dataGridTableStyleBorrowDate
			// 
			this.dataGridTableStyleBorrowDate.AlternatingBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleBorrowDate.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.dataGridTableStyleBorrowDate.DataGrid = this.dataGridSearch;
			this.dataGridTableStyleBorrowDate.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleBorrowDate.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																														   this.dataGridTextBoxColumnBorrowDate});
			this.dataGridTableStyleBorrowDate.GridLineColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridTableStyleBorrowDate.HeaderBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleBorrowDate.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleBorrowDate.MappingName = "BookOutstanding";
			// 
			// dataGridTextBoxColumnBorrowDate
			// 
			this.dataGridTextBoxColumnBorrowDate.Format = "";
			this.dataGridTextBoxColumnBorrowDate.FormatInfo = null;
			this.dataGridTextBoxColumnBorrowDate.HeaderText = "Borrow Date";
			this.dataGridTextBoxColumnBorrowDate.MappingName = "BorrowDate";
			this.dataGridTextBoxColumnBorrowDate.Width = 150;
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxSearch.Location = new System.Drawing.Point(16, 128);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(160, 22);
			this.textBoxSearch.TabIndex = 1;
			this.textBoxSearch.Text = "";
			this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
			// 
			// labelCity
			// 
			this.labelCity.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelCity.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelCity.Location = new System.Drawing.Point(16, 96);
			this.labelCity.Name = "labelCity";
			this.labelCity.Size = new System.Drawing.Size(120, 24);
			this.labelCity.TabIndex = 150;
			this.labelCity.Text = "Text to Find   :";
			// 
			// pictureBoxLogoPicture
			// 
			this.pictureBoxLogoPicture.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogoPicture.Image")));
			this.pictureBoxLogoPicture.Location = new System.Drawing.Point(24, 312);
			this.pictureBoxLogoPicture.Name = "pictureBoxLogoPicture";
			this.pictureBoxLogoPicture.Size = new System.Drawing.Size(144, 88);
			this.pictureBoxLogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxLogoPicture.TabIndex = 216;
			this.pictureBoxLogoPicture.TabStop = false;
			// 
			// buttonAdd
			// 
			this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonAdd.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonAdd.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd.Image")));
			this.buttonAdd.Location = new System.Drawing.Point(208, 96);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(24, 24);
			this.buttonAdd.TabIndex = 217;
			this.buttonAdd.Text = "<<";
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// FrmSearchMiniForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.ClientSize = new System.Drawing.Size(896, 416);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.pictureBoxLogoPicture);
			this.Controls.Add(this.textBoxSearch);
			this.Controls.Add(this.labelCity);
			this.Controls.Add(this.dataGridSearch);
			this.Controls.Add(this.LabelTitle);
			this.Controls.Add(this.pictureBoxVariant);
			this.Controls.Add(this.pictureBoxMainForm);
			this.Controls.Add(this.pictureBoxLeftForm);
			this.Location = new System.Drawing.Point(30, 250);
			this.Name = "FrmSearchMiniForm";
			this.Text = "Search Mini Form";
			this.Load += new System.EventHandler(this.FrmSearchMiniForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridSearch)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void FrmSearchMiniForm_Load(object sender, System.EventArgs e)
		{
			MyCriteria = "";

			
				MyClassDatabase = new ClassDatabase();
				MyDataTable = MyClassDatabase.GetMember(new Member());
				MyDataView = new DataView(MyDataTable, "MemberName LIKE '%" + MyCriteria + "%' ", "MemberName", DataViewRowState.CurrentRows);
				dataGridSearch.DataSource = MyDataView;
				LabelTitle.Text = "Member Data";
			
			
			this.Location = new System.Drawing.Point(62,250);
		}

		private void dataGridSearch_DoubleClick(object sender, System.EventArgs e)
		{
	
		}

		private void textBoxSearch_TextChanged(object sender, System.EventArgs e)
		{
			MyCriteria = textBoxSearch.Text.ToString();
			MyCriteria = MyCriteria.Replace("'","''");
		
				MyDataView = new DataView(MyDataTable, "MemberName LIKE '%" + MyCriteria + "%' ", "MemberName", DataViewRowState.CurrentRows);
				dataGridSearch.DataSource = MyDataView;
			
			
		}

		private void buttonAdd_Click(object sender, System.EventArgs e)
		{
			MyTransactionForm.textBoxMember.Text = dataGridSearch[dataGridSearch.CurrentRowIndex,0].ToString();
			this.Dispose();
		}

		private void pictureBoxLeftForm_Click(object sender, System.EventArgs e)
		{
		
		}

	}
}

