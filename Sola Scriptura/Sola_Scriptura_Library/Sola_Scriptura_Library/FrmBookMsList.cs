using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace Sola_Scriptura_Library
{
	public class FrmBookMsList : Sola_Scriptura_Library.FrmBookMaster
	{
		internal System.Windows.Forms.Label LabelTitle;
		internal System.Windows.Forms.TextBox textBoxBookCode;
		internal System.Windows.Forms.Label labelBookCode;
		internal System.Windows.Forms.Label labelBookName;
		internal System.Windows.Forms.ComboBox comboBoxType;
		internal System.Windows.Forms.Label labelType;
		internal System.Windows.Forms.ComboBox comboBoxBookGroup;
		internal System.Windows.Forms.Label labelBookGroup;
		internal System.Windows.Forms.TextBox textBoxDDC;
		internal System.Windows.Forms.Label labelDDC;
		internal System.Windows.Forms.TextBox textBoxLC;
		internal System.Windows.Forms.TextBox textBoxAuthor;
		internal System.Windows.Forms.Label labelAuthor;
		internal System.Windows.Forms.Label labelSubject;
		internal System.Windows.Forms.TextBox textBoxPublisher;
		internal System.Windows.Forms.Label labelPublisher;
		internal System.Windows.Forms.Label labelPublishYear;
		internal System.Windows.Forms.Label label2;
		internal System.Windows.Forms.TextBox textBoxBookName;
		internal System.Windows.Forms.Button buttonSearch;
		internal System.Windows.Forms.Button buttonClear;
		internal System.Windows.Forms.TextBox textBoxISBN;
		internal System.Windows.Forms.Label labelISBN;
		internal System.Windows.Forms.DataGrid dataGridBookMaster;
		internal System.Windows.Forms.DataGridTableStyle dataGridTableStyleMaster;
		internal System.Windows.Forms.TextBox textBoxSubject;
		internal System.Windows.Forms.ComboBox comboBoxPublishYearFrom;
		internal System.Windows.Forms.ComboBox comboBoxPublishYearTo;
		private System.ComponentModel.IContainer components = null;


		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnBookCode;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnBookName;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnOriginalTitle;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnBookType;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnBookGroupCode;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnGroupName;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnISBN;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnDDC;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnLC;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnUpdateUser;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnUpdateDate;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnVol;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnPages;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnRev;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnPublisherCode;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnPublisherName;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnPublishYear;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnContent;

		internal BookSearch MyBookSearch;
		internal ClassDatabase MyClassDatabase;
		internal DataTable MyDataTable;
		internal DataTable MyBookType;
		internal System.Windows.Forms.Label labelLC;
		internal System.Windows.Forms.Label labelRefresh;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnBorrowBy;
		
		internal DataTable MyGroupName;

		public FrmBookMsList()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public FrmBookMsList(FrmMDI MDIForm, FrmBookMenu BookMenuForm)
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmBookMsList));
			this.dataGridBookMaster = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyleMaster = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnBookCode = new System.Windows.Forms.DataGridTextBoxColumn();
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
			this.dataGridTextBoxColumnUpdateUser = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnUpdateDate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.LabelTitle = new System.Windows.Forms.Label();
			this.textBoxBookCode = new System.Windows.Forms.TextBox();
			this.labelBookCode = new System.Windows.Forms.Label();
			this.textBoxBookName = new System.Windows.Forms.TextBox();
			this.labelBookName = new System.Windows.Forms.Label();
			this.comboBoxType = new System.Windows.Forms.ComboBox();
			this.labelType = new System.Windows.Forms.Label();
			this.comboBoxBookGroup = new System.Windows.Forms.ComboBox();
			this.labelBookGroup = new System.Windows.Forms.Label();
			this.textBoxDDC = new System.Windows.Forms.TextBox();
			this.labelDDC = new System.Windows.Forms.Label();
			this.textBoxLC = new System.Windows.Forms.TextBox();
			this.labelLC = new System.Windows.Forms.Label();
			this.textBoxAuthor = new System.Windows.Forms.TextBox();
			this.labelAuthor = new System.Windows.Forms.Label();
			this.labelSubject = new System.Windows.Forms.Label();
			this.textBoxPublisher = new System.Windows.Forms.TextBox();
			this.labelPublisher = new System.Windows.Forms.Label();
			this.labelPublishYear = new System.Windows.Forms.Label();
			this.comboBoxPublishYearFrom = new System.Windows.Forms.ComboBox();
			this.comboBoxPublishYearTo = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.buttonClear = new System.Windows.Forms.Button();
			this.textBoxISBN = new System.Windows.Forms.TextBox();
			this.labelISBN = new System.Windows.Forms.Label();
			this.textBoxSubject = new System.Windows.Forms.TextBox();
			this.labelRefresh = new System.Windows.Forms.Label();
			this.dataGridTextBoxColumnBorrowBy = new System.Windows.Forms.DataGridTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridBookMaster)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridBookMaster
			// 
			this.dataGridBookMaster.DataMember = "";
			this.dataGridBookMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGridBookMaster.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridBookMaster.Location = new System.Drawing.Point(248, 272);
			this.dataGridBookMaster.Name = "dataGridBookMaster";
			this.dataGridBookMaster.ReadOnly = true;
			this.dataGridBookMaster.Size = new System.Drawing.Size(680, 280);
			this.dataGridBookMaster.TabIndex = 113;
			this.dataGridBookMaster.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																										   this.dataGridTableStyleMaster});
			this.dataGridBookMaster.Click += new System.EventHandler(this.dataGridBookMaster_Click);
			this.dataGridBookMaster.DoubleClick += new System.EventHandler(this.dataGridBookMaster_DoubleClick);
			// 
			// dataGridTableStyleMaster
			// 
			this.dataGridTableStyleMaster.AlternatingBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleMaster.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.dataGridTableStyleMaster.DataGrid = this.dataGridBookMaster;
			this.dataGridTableStyleMaster.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleMaster.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																													   this.dataGridTextBoxColumnBookCode,
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
																													   this.dataGridTextBoxColumnContent,
																													   this.dataGridTextBoxColumnBorrowBy,
																													   this.dataGridTextBoxColumnUpdateUser,
																													   this.dataGridTextBoxColumnUpdateDate});
			this.dataGridTableStyleMaster.GridLineColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridTableStyleMaster.HeaderBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleMaster.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleMaster.MappingName = "BookList";
			// 
			// dataGridTextBoxColumnBookCode
			// 
			this.dataGridTextBoxColumnBookCode.Format = "";
			this.dataGridTextBoxColumnBookCode.FormatInfo = null;
			this.dataGridTextBoxColumnBookCode.HeaderText = "Book Code";
			this.dataGridTextBoxColumnBookCode.MappingName = "BookCode";
			this.dataGridTextBoxColumnBookCode.Width = 120;
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
			this.dataGridTextBoxColumnVol.HeaderText = "Volume";
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
			// LabelTitle
			// 
			this.LabelTitle.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.LabelTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.LabelTitle.Image = ((System.Drawing.Image)(resources.GetObject("LabelTitle.Image")));
			this.LabelTitle.Location = new System.Drawing.Point(792, 16);
			this.LabelTitle.Name = "LabelTitle";
			this.LabelTitle.Size = new System.Drawing.Size(192, 32);
			this.LabelTitle.TabIndex = 114;
			this.LabelTitle.Text = "    Book List";
			this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBoxBookCode
			// 
			this.textBoxBookCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxBookCode.Location = new System.Drawing.Point(384, 80);
			this.textBoxBookCode.Name = "textBoxBookCode";
			this.textBoxBookCode.Size = new System.Drawing.Size(200, 20);
			this.textBoxBookCode.TabIndex = 1;
			this.textBoxBookCode.Text = "";
			this.textBoxBookCode.TextChanged += new System.EventHandler(this.textBoxBookCode_TextChanged);
			// 
			// labelBookCode
			// 
			this.labelBookCode.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelBookCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBookCode.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelBookCode.Location = new System.Drawing.Point(256, 80);
			this.labelBookCode.Name = "labelBookCode";
			this.labelBookCode.Size = new System.Drawing.Size(120, 24);
			this.labelBookCode.TabIndex = 116;
			this.labelBookCode.Text = "Item Code";
			// 
			// textBoxBookName
			// 
			this.textBoxBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxBookName.Location = new System.Drawing.Point(384, 104);
			this.textBoxBookName.Name = "textBoxBookName";
			this.textBoxBookName.Size = new System.Drawing.Size(544, 20);
			this.textBoxBookName.TabIndex = 3;
			this.textBoxBookName.Text = "";
			this.textBoxBookName.TextChanged += new System.EventHandler(this.textBoxBookName_TextChanged);
			// 
			// labelBookName
			// 
			this.labelBookName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBookName.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelBookName.Location = new System.Drawing.Point(256, 104);
			this.labelBookName.Name = "labelBookName";
			this.labelBookName.Size = new System.Drawing.Size(120, 24);
			this.labelBookName.TabIndex = 118;
			this.labelBookName.Text = "Key Word ( Name )";
			// 
			// comboBoxType
			// 
			this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.comboBoxType.Location = new System.Drawing.Point(384, 128);
			this.comboBoxType.Name = "comboBoxType";
			this.comboBoxType.Size = new System.Drawing.Size(200, 21);
			this.comboBoxType.TabIndex = 4;
			this.comboBoxType.TextChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
			this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
			// 
			// labelType
			// 
			this.labelType.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelType.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelType.Location = new System.Drawing.Point(256, 128);
			this.labelType.Name = "labelType";
			this.labelType.Size = new System.Drawing.Size(120, 24);
			this.labelType.TabIndex = 122;
			this.labelType.Text = "Type";
			// 
			// comboBoxBookGroup
			// 
			this.comboBoxBookGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxBookGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.comboBoxBookGroup.Location = new System.Drawing.Point(728, 128);
			this.comboBoxBookGroup.Name = "comboBoxBookGroup";
			this.comboBoxBookGroup.Size = new System.Drawing.Size(200, 21);
			this.comboBoxBookGroup.TabIndex = 5;
			this.comboBoxBookGroup.TextChanged += new System.EventHandler(this.comboBoxBookGroup_SelectedIndexChanged);
			this.comboBoxBookGroup.SelectedIndexChanged += new System.EventHandler(this.comboBoxBookGroup_SelectedIndexChanged);
			// 
			// labelBookGroup
			// 
			this.labelBookGroup.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelBookGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBookGroup.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelBookGroup.Location = new System.Drawing.Point(600, 128);
			this.labelBookGroup.Name = "labelBookGroup";
			this.labelBookGroup.Size = new System.Drawing.Size(120, 24);
			this.labelBookGroup.TabIndex = 124;
			this.labelBookGroup.Text = "Book Group";
			// 
			// textBoxDDC
			// 
			this.textBoxDDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxDDC.Location = new System.Drawing.Point(384, 152);
			this.textBoxDDC.Name = "textBoxDDC";
			this.textBoxDDC.Size = new System.Drawing.Size(200, 20);
			this.textBoxDDC.TabIndex = 6;
			this.textBoxDDC.Text = "";
			this.textBoxDDC.TextChanged += new System.EventHandler(this.textBoxDDC_TextChanged);
			// 
			// labelDDC
			// 
			this.labelDDC.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelDDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelDDC.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelDDC.Location = new System.Drawing.Point(256, 152);
			this.labelDDC.Name = "labelDDC";
			this.labelDDC.Size = new System.Drawing.Size(120, 24);
			this.labelDDC.TabIndex = 126;
			this.labelDDC.Text = "DDC";
			// 
			// textBoxLC
			// 
			this.textBoxLC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxLC.Location = new System.Drawing.Point(728, 152);
			this.textBoxLC.Name = "textBoxLC";
			this.textBoxLC.Size = new System.Drawing.Size(200, 20);
			this.textBoxLC.TabIndex = 7;
			this.textBoxLC.Text = "";
			this.textBoxLC.TextChanged += new System.EventHandler(this.textBoxLC_TextChanged);
			// 
			// labelLC
			// 
			this.labelLC.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelLC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelLC.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelLC.Location = new System.Drawing.Point(600, 152);
			this.labelLC.Name = "labelLC";
			this.labelLC.Size = new System.Drawing.Size(120, 24);
			this.labelLC.TabIndex = 128;
			this.labelLC.Text = "LC";
			// 
			// textBoxAuthor
			// 
			this.textBoxAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxAuthor.Location = new System.Drawing.Point(728, 176);
			this.textBoxAuthor.Name = "textBoxAuthor";
			this.textBoxAuthor.Size = new System.Drawing.Size(200, 20);
			this.textBoxAuthor.TabIndex = 9;
			this.textBoxAuthor.Text = "";
			this.textBoxAuthor.TextChanged += new System.EventHandler(this.textBoxAuthor_TextChanged);
			// 
			// labelAuthor
			// 
			this.labelAuthor.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelAuthor.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelAuthor.Location = new System.Drawing.Point(600, 176);
			this.labelAuthor.Name = "labelAuthor";
			this.labelAuthor.Size = new System.Drawing.Size(120, 24);
			this.labelAuthor.TabIndex = 132;
			this.labelAuthor.Text = "Author";
			// 
			// labelSubject
			// 
			this.labelSubject.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelSubject.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelSubject.Location = new System.Drawing.Point(256, 176);
			this.labelSubject.Name = "labelSubject";
			this.labelSubject.Size = new System.Drawing.Size(120, 24);
			this.labelSubject.TabIndex = 130;
			this.labelSubject.Text = "Subject";
			// 
			// textBoxPublisher
			// 
			this.textBoxPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxPublisher.Location = new System.Drawing.Point(384, 200);
			this.textBoxPublisher.Name = "textBoxPublisher";
			this.textBoxPublisher.Size = new System.Drawing.Size(200, 20);
			this.textBoxPublisher.TabIndex = 10;
			this.textBoxPublisher.Text = "";
			this.textBoxPublisher.TextChanged += new System.EventHandler(this.textBoxPublisher_TextChanged);
			// 
			// labelPublisher
			// 
			this.labelPublisher.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelPublisher.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelPublisher.Location = new System.Drawing.Point(256, 200);
			this.labelPublisher.Name = "labelPublisher";
			this.labelPublisher.Size = new System.Drawing.Size(120, 24);
			this.labelPublisher.TabIndex = 134;
			this.labelPublisher.Text = "Publisher";
			// 
			// labelPublishYear
			// 
			this.labelPublishYear.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelPublishYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelPublishYear.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelPublishYear.Location = new System.Drawing.Point(600, 200);
			this.labelPublishYear.Name = "labelPublishYear";
			this.labelPublishYear.Size = new System.Drawing.Size(120, 24);
			this.labelPublishYear.TabIndex = 135;
			this.labelPublishYear.Text = "Publish Year";
			// 
			// comboBoxPublishYearFrom
			// 
			this.comboBoxPublishYearFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.comboBoxPublishYearFrom.Location = new System.Drawing.Point(728, 200);
			this.comboBoxPublishYearFrom.Name = "comboBoxPublishYearFrom";
			this.comboBoxPublishYearFrom.Size = new System.Drawing.Size(96, 21);
			this.comboBoxPublishYearFrom.TabIndex = 11;
			this.comboBoxPublishYearFrom.TextChanged += new System.EventHandler(this.comboBoxPublishYearFrom_SelectedIndexChanged);
			this.comboBoxPublishYearFrom.SelectedIndexChanged += new System.EventHandler(this.comboBoxPublishYearFrom_SelectedIndexChanged);
			// 
			// comboBoxPublishYearTo
			// 
			this.comboBoxPublishYearTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.comboBoxPublishYearTo.Location = new System.Drawing.Point(832, 200);
			this.comboBoxPublishYearTo.Name = "comboBoxPublishYearTo";
			this.comboBoxPublishYearTo.Size = new System.Drawing.Size(96, 21);
			this.comboBoxPublishYearTo.TabIndex = 12;
			this.comboBoxPublishYearTo.TextChanged += new System.EventHandler(this.comboBoxPublishYearTo_SelectedIndexChanged);
			this.comboBoxPublishYearTo.SelectedIndexChanged += new System.EventHandler(this.comboBoxPublishYearTo_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label2.Location = new System.Drawing.Point(824, 200);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 24);
			this.label2.TabIndex = 138;
			this.label2.Text = "-";
			// 
			// buttonSearch
			// 
			this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonSearch.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearch.Image")));
			this.buttonSearch.Location = new System.Drawing.Point(840, 232);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(88, 32);
			this.buttonSearch.TabIndex = 14;
			this.buttonSearch.Text = "Search";
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// buttonClear
			// 
			this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonClear.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonClear.Image = ((System.Drawing.Image)(resources.GetObject("buttonClear.Image")));
			this.buttonClear.Location = new System.Drawing.Point(736, 232);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(88, 32);
			this.buttonClear.TabIndex = 13;
			this.buttonClear.Text = "Clear";
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// textBoxISBN
			// 
			this.textBoxISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxISBN.Location = new System.Drawing.Point(728, 80);
			this.textBoxISBN.Name = "textBoxISBN";
			this.textBoxISBN.Size = new System.Drawing.Size(200, 20);
			this.textBoxISBN.TabIndex = 2;
			this.textBoxISBN.Text = "";
			this.textBoxISBN.TextChanged += new System.EventHandler(this.textBoxISBN_TextChanged);
			// 
			// labelISBN
			// 
			this.labelISBN.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelISBN.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelISBN.Location = new System.Drawing.Point(600, 80);
			this.labelISBN.Name = "labelISBN";
			this.labelISBN.Size = new System.Drawing.Size(120, 24);
			this.labelISBN.TabIndex = 142;
			this.labelISBN.Text = "ISBN";
			// 
			// textBoxSubject
			// 
			this.textBoxSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxSubject.Location = new System.Drawing.Point(384, 176);
			this.textBoxSubject.Name = "textBoxSubject";
			this.textBoxSubject.Size = new System.Drawing.Size(200, 20);
			this.textBoxSubject.TabIndex = 8;
			this.textBoxSubject.Text = "";
			this.textBoxSubject.TextChanged += new System.EventHandler(this.textBoxSubject_TextChanged);
			// 
			// labelRefresh
			// 
			this.labelRefresh.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelRefresh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelRefresh.ForeColor = System.Drawing.Color.LightCoral;
			this.labelRefresh.Location = new System.Drawing.Point(256, 240);
			this.labelRefresh.Name = "labelRefresh";
			this.labelRefresh.Size = new System.Drawing.Size(408, 24);
			this.labelRefresh.TabIndex = 175;
			this.labelRefresh.Text = "You must refresh the data to Update Current Change in Data Grid !";
			this.labelRefresh.Visible = false;
			// 
			// dataGridTextBoxColumnBorrowBy
			// 
			this.dataGridTextBoxColumnBorrowBy.Format = "";
			this.dataGridTextBoxColumnBorrowBy.FormatInfo = null;
			this.dataGridTextBoxColumnBorrowBy.HeaderText = "Borrow By";
			this.dataGridTextBoxColumnBorrowBy.MappingName = "BorrowBy";
			// 
			// FrmBookMsList
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.labelRefresh);
			this.Controls.Add(this.textBoxSubject);
			this.Controls.Add(this.textBoxISBN);
			this.Controls.Add(this.labelISBN);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.buttonSearch);
			this.Controls.Add(this.comboBoxPublishYearFrom);
			this.Controls.Add(this.comboBoxPublishYearTo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.labelPublishYear);
			this.Controls.Add(this.textBoxPublisher);
			this.Controls.Add(this.labelPublisher);
			this.Controls.Add(this.textBoxAuthor);
			this.Controls.Add(this.labelAuthor);
			this.Controls.Add(this.labelSubject);
			this.Controls.Add(this.textBoxLC);
			this.Controls.Add(this.labelLC);
			this.Controls.Add(this.textBoxDDC);
			this.Controls.Add(this.labelDDC);
			this.Controls.Add(this.comboBoxBookGroup);
			this.Controls.Add(this.labelBookGroup);
			this.Controls.Add(this.comboBoxType);
			this.Controls.Add(this.labelType);
			this.Controls.Add(this.textBoxBookName);
			this.Controls.Add(this.labelBookName);
			this.Controls.Add(this.textBoxBookCode);
			this.Controls.Add(this.labelBookCode);
			this.Controls.Add(this.LabelTitle);
			this.Controls.Add(this.dataGridBookMaster);
			this.Name = "FrmBookMsList";
			this.Load += new System.EventHandler(this.FrmBookMsList_Load);
			this.Controls.SetChildIndex(this.dataGridBookMaster, 0);
			this.Controls.SetChildIndex(this.LabelTitle, 0);
			this.Controls.SetChildIndex(this.labelBookCode, 0);
			this.Controls.SetChildIndex(this.textBoxBookCode, 0);
			this.Controls.SetChildIndex(this.labelBookName, 0);
			this.Controls.SetChildIndex(this.textBoxBookName, 0);
			this.Controls.SetChildIndex(this.labelType, 0);
			this.Controls.SetChildIndex(this.comboBoxType, 0);
			this.Controls.SetChildIndex(this.labelBookGroup, 0);
			this.Controls.SetChildIndex(this.comboBoxBookGroup, 0);
			this.Controls.SetChildIndex(this.labelDDC, 0);
			this.Controls.SetChildIndex(this.textBoxDDC, 0);
			this.Controls.SetChildIndex(this.labelLC, 0);
			this.Controls.SetChildIndex(this.textBoxLC, 0);
			this.Controls.SetChildIndex(this.labelSubject, 0);
			this.Controls.SetChildIndex(this.labelAuthor, 0);
			this.Controls.SetChildIndex(this.textBoxAuthor, 0);
			this.Controls.SetChildIndex(this.labelPublisher, 0);
			this.Controls.SetChildIndex(this.textBoxPublisher, 0);
			this.Controls.SetChildIndex(this.labelPublishYear, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.comboBoxPublishYearTo, 0);
			this.Controls.SetChildIndex(this.comboBoxPublishYearFrom, 0);
			this.Controls.SetChildIndex(this.buttonSearch, 0);
			this.Controls.SetChildIndex(this.buttonClear, 0);
			this.Controls.SetChildIndex(this.labelISBN, 0);
			this.Controls.SetChildIndex(this.textBoxISBN, 0);
			this.Controls.SetChildIndex(this.textBoxSubject, 0);
			this.Controls.SetChildIndex(this.labelRefresh, 0);
			((System.ComponentModel.ISupportInitialize)(this.dataGridBookMaster)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

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
			MyBookSearch.BookTypeIndex = comboBoxType.SelectedIndex.ToString();
		}

		private void comboBoxBookGroup_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			MyBookSearch.BookGroupName = comboBoxBookGroup.Text.ToString();
			MyBookSearch.BookGroupIndex = comboBoxBookGroup.SelectedIndex.ToString();
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

		private void FrmBookMsList_Load(object sender, System.EventArgs e)
		{
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

		private void buttonClear_Click(object sender, System.EventArgs e)
		{
			DoClear();
		}

		private void buttonSearch_Click(object sender, System.EventArgs e)
		{
			if(textBoxAuthor.Text.ToString() == "" && textBoxBookCode.Text.ToString() == "" && comboBoxBookGroup.Text.ToString() == "" && textBoxBookName.Text.ToString() == "" && comboBoxType.Text.ToString() == "" && textBoxDDC.Text.ToString() =="" && textBoxISBN.Text.ToString() == "" && textBoxLC.Text.ToString() == "" && textBoxPublisher.Text.ToString() =="" && comboBoxPublishYearFrom.Text.ToString() =="" && comboBoxPublishYearTo.Text.ToString() == "" && textBoxSubject.Text.ToString() == "")
			{
				MessageBox.Show("Please input the criteria for searching Books !","Information");
			}
			else
			{
				MyClassDatabase = new ClassDatabase();
				MyDataTable = MyClassDatabase.GetBookList(MyBookSearch);
				dataGridBookMaster.DataSource = MyDataTable;
				labelRefresh.Visible = false;
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

		private void dataGridBookMaster_Click(object sender, System.EventArgs e)
		{
			if(MyDataTable.Rows.Count>0)
				MyBookMenuForm.MyBookSearch.BookCode = dataGridBookMaster[dataGridBookMaster.CurrentRowIndex,0].ToString();

		}
		private void dataGridBookMaster_DoubleClick(object sender, System.EventArgs e)
		{
			
			if(MyDataTable.Rows.Count>0)
			{
				this.Hide();
				MyBookMenuForm.MyBookSearch.BookCode = dataGridBookMaster[dataGridBookMaster.CurrentRowIndex,0].ToString();
				MyBookMenuForm.MyBookMsDetailForm = new FrmBookMsDetail(this.MyMDIForm, this.MyBookMenuForm);
				MyBookMenuForm.MyBookMsDetailForm.Show();
				MyBookMenuForm.MyBookMsDetailForm.buttonBookDetail.Focus();
				if(MyBookMenuForm.MyBookSearch.BookCode.ToString()!="")
				{
					MyBookMenuForm.MyBookMsDetailForm.CanDelete = true;
					MyBookMenuForm.MyBookMsDetailForm.DoLock();
					MyBookMenuForm.MyBookMsDetailForm.GetBookData();
				}
				else
				{
					MyBookMenuForm.MyBookMsDetailForm.CanDelete = false;
				}
			}	
		}
	}
}
