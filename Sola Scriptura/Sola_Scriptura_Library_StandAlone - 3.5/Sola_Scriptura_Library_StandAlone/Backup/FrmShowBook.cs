using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace Sola_Scriptura_Library
{
	public class FrmShowBook : Sola_Scriptura_Library.FrmSearchBookMaster
	{
		internal System.Windows.Forms.TextBox textBoxISBN;
		internal System.Windows.Forms.Label labelISBN;
		internal System.Windows.Forms.TextBox textBoxOriginalTitle;
		internal System.Windows.Forms.TextBox textBoxBookName;
		internal System.Windows.Forms.TextBox textBoxBookCode;
		internal System.Windows.Forms.Label labelOriginalTitle;
		internal System.Windows.Forms.Label labelBookName;
		internal System.Windows.Forms.Label labelBookCode;
		internal System.Windows.Forms.GroupBox groupBox1;
		internal System.Windows.Forms.PictureBox pictureBox1;
		internal System.Windows.Forms.Label labelView;
		internal System.Windows.Forms.ComboBox comboBoxView;
		internal System.Windows.Forms.TextBox textBoxVolume;
		internal System.Windows.Forms.Label labelVolume;
		internal System.Windows.Forms.TextBox textBoxRev;
		internal System.Windows.Forms.Label labelRev;
		internal System.Windows.Forms.TextBox textBoxPages;
		internal System.Windows.Forms.Label labelPages;
		internal System.Windows.Forms.TextBox textBoxBookGroup;
		internal System.Windows.Forms.Label labelPublishYear;
		internal System.Windows.Forms.Label labelPublisher;
		internal System.Windows.Forms.TextBox textBoxLC;
		internal System.Windows.Forms.Label labelLC;
		internal System.Windows.Forms.TextBox textBoxDDC;
		internal System.Windows.Forms.Label labelDDC;
		internal System.Windows.Forms.Label labelBookType;
		internal System.Windows.Forms.Label labelBookGroup;
		internal System.Windows.Forms.TextBox textBoxBookType;
		internal System.Windows.Forms.TextBox textBoxContent;
		internal System.Windows.Forms.Label labelContent;
		internal System.Windows.Forms.TextBox textBoxPublishYear;
		private System.ComponentModel.IContainer components = null;
		internal System.Windows.Forms.TextBox textBoxBookDesc;
		internal System.Windows.Forms.TextBox textBoxPublisherName;
		internal System.Windows.Forms.PictureBox pictureBoxCover;
		internal System.Windows.Forms.DataGrid dataGridView;
		internal System.Windows.Forms.DataGridTableStyle dataGridTableStyleAuthor;
		internal System.Windows.Forms.DataGridTableStyle dataGridTableStyleCopy;
		internal System.Windows.Forms.DataGridTableStyle dataGridTableStyleDescription;
		internal System.Windows.Forms.DataGridTableStyle dataGridTableStyleSubject;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnFAuthorCode;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnFirstName;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnLastName;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnAuthorType;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnCopyNo;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnBoughtDate;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnCopyType;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnCopyStatus;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnShelfCode;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnShelfName;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnStoreCode;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnStoreName;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnCurr;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnCurrRate;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnPrice;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnBookStatus;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnStatusDesc;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnBorrowBy;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnMemberID;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnBookCode;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnBookSeq;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnBookDescription;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnRelatedFile;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnSubjectCode;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnSubjectName;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnDescription;

		internal ClassDatabase MyClassDatabase;
		internal DataTable MyDataTable;
		internal DataTable MyViewDataTable;
		internal DataTable MyBookDtDataTable;
		internal byte [] imageData;
		
		internal System.Windows.Forms.Label LabelTitle;
		internal System.Drawing.Bitmap MyBookImage;
		
		public FrmShowBook()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public FrmShowBook(FrmMDI MDIForm)
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmShowBook));
			this.textBoxISBN = new System.Windows.Forms.TextBox();
			this.labelISBN = new System.Windows.Forms.Label();
			this.textBoxOriginalTitle = new System.Windows.Forms.TextBox();
			this.textBoxBookName = new System.Windows.Forms.TextBox();
			this.textBoxBookCode = new System.Windows.Forms.TextBox();
			this.labelOriginalTitle = new System.Windows.Forms.Label();
			this.labelBookName = new System.Windows.Forms.Label();
			this.labelBookCode = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dataGridView = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyleAuthor = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnFAuthorCode = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnFirstName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnLastName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnAuthorType = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTableStyleCopy = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnCopyNo = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnBoughtDate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnCopyType = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnCopyStatus = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnShelfCode = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnShelfName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnStoreCode = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnStoreName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnCurr = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnCurrRate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnPrice = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnBookStatus = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnStatusDesc = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnBorrowBy = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnMemberID = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTableStyleDescription = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnBookCode = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnBookSeq = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnBookDescription = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnRelatedFile = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTableStyleSubject = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnSubjectCode = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnSubjectName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnDescription = new System.Windows.Forms.DataGridTextBoxColumn();
			this.textBoxBookDesc = new System.Windows.Forms.TextBox();
			this.pictureBoxCover = new System.Windows.Forms.PictureBox();
			this.textBoxPublishYear = new System.Windows.Forms.TextBox();
			this.textBoxContent = new System.Windows.Forms.TextBox();
			this.labelContent = new System.Windows.Forms.Label();
			this.textBoxBookType = new System.Windows.Forms.TextBox();
			this.textBoxPublisherName = new System.Windows.Forms.TextBox();
			this.textBoxBookGroup = new System.Windows.Forms.TextBox();
			this.labelPublishYear = new System.Windows.Forms.Label();
			this.labelPublisher = new System.Windows.Forms.Label();
			this.textBoxLC = new System.Windows.Forms.TextBox();
			this.labelLC = new System.Windows.Forms.Label();
			this.textBoxDDC = new System.Windows.Forms.TextBox();
			this.labelDDC = new System.Windows.Forms.Label();
			this.labelBookType = new System.Windows.Forms.Label();
			this.labelBookGroup = new System.Windows.Forms.Label();
			this.textBoxVolume = new System.Windows.Forms.TextBox();
			this.labelVolume = new System.Windows.Forms.Label();
			this.textBoxRev = new System.Windows.Forms.TextBox();
			this.labelRev = new System.Windows.Forms.Label();
			this.textBoxPages = new System.Windows.Forms.TextBox();
			this.labelPages = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.labelView = new System.Windows.Forms.Label();
			this.comboBoxView = new System.Windows.Forms.ComboBox();
			this.LabelTitle = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// textBoxISBN
			// 
			this.textBoxISBN.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxISBN.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxISBN.Location = new System.Drawing.Point(720, 80);
			this.textBoxISBN.Name = "textBoxISBN";
			this.textBoxISBN.ReadOnly = true;
			this.textBoxISBN.Size = new System.Drawing.Size(200, 22);
			this.textBoxISBN.TabIndex = 167;
			this.textBoxISBN.Text = "";
			// 
			// labelISBN
			// 
			this.labelISBN.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelISBN.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelISBN.Location = new System.Drawing.Point(592, 80);
			this.labelISBN.Name = "labelISBN";
			this.labelISBN.Size = new System.Drawing.Size(120, 24);
			this.labelISBN.TabIndex = 166;
			this.labelISBN.Text = "ISBN";
			// 
			// textBoxOriginalTitle
			// 
			this.textBoxOriginalTitle.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxOriginalTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxOriginalTitle.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxOriginalTitle.Location = new System.Drawing.Point(384, 144);
			this.textBoxOriginalTitle.Name = "textBoxOriginalTitle";
			this.textBoxOriginalTitle.ReadOnly = true;
			this.textBoxOriginalTitle.Size = new System.Drawing.Size(536, 22);
			this.textBoxOriginalTitle.TabIndex = 165;
			this.textBoxOriginalTitle.Text = "";
			// 
			// textBoxBookName
			// 
			this.textBoxBookName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxBookName.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxBookName.Location = new System.Drawing.Point(384, 112);
			this.textBoxBookName.Name = "textBoxBookName";
			this.textBoxBookName.ReadOnly = true;
			this.textBoxBookName.Size = new System.Drawing.Size(536, 22);
			this.textBoxBookName.TabIndex = 164;
			this.textBoxBookName.Text = "";
			// 
			// textBoxBookCode
			// 
			this.textBoxBookCode.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxBookCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxBookCode.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxBookCode.Location = new System.Drawing.Point(384, 80);
			this.textBoxBookCode.Name = "textBoxBookCode";
			this.textBoxBookCode.ReadOnly = true;
			this.textBoxBookCode.Size = new System.Drawing.Size(200, 22);
			this.textBoxBookCode.TabIndex = 163;
			this.textBoxBookCode.Text = "";
			// 
			// labelOriginalTitle
			// 
			this.labelOriginalTitle.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelOriginalTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelOriginalTitle.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelOriginalTitle.Location = new System.Drawing.Point(256, 144);
			this.labelOriginalTitle.Name = "labelOriginalTitle";
			this.labelOriginalTitle.Size = new System.Drawing.Size(120, 24);
			this.labelOriginalTitle.TabIndex = 162;
			this.labelOriginalTitle.Text = "Original Title";
			// 
			// labelBookName
			// 
			this.labelBookName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBookName.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelBookName.Location = new System.Drawing.Point(256, 112);
			this.labelBookName.Name = "labelBookName";
			this.labelBookName.Size = new System.Drawing.Size(120, 24);
			this.labelBookName.TabIndex = 161;
			this.labelBookName.Text = "Book Name";
			// 
			// labelBookCode
			// 
			this.labelBookCode.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelBookCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBookCode.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelBookCode.Location = new System.Drawing.Point(256, 80);
			this.labelBookCode.Name = "labelBookCode";
			this.labelBookCode.Size = new System.Drawing.Size(120, 24);
			this.labelBookCode.TabIndex = 160;
			this.labelBookCode.Text = "Book Code";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.groupBox1.Controls.Add(this.dataGridView);
			this.groupBox1.Controls.Add(this.textBoxBookDesc);
			this.groupBox1.Controls.Add(this.pictureBoxCover);
			this.groupBox1.Controls.Add(this.textBoxPublishYear);
			this.groupBox1.Controls.Add(this.textBoxContent);
			this.groupBox1.Controls.Add(this.labelContent);
			this.groupBox1.Controls.Add(this.textBoxBookType);
			this.groupBox1.Controls.Add(this.textBoxPublisherName);
			this.groupBox1.Controls.Add(this.textBoxBookGroup);
			this.groupBox1.Controls.Add(this.labelPublishYear);
			this.groupBox1.Controls.Add(this.labelPublisher);
			this.groupBox1.Controls.Add(this.textBoxLC);
			this.groupBox1.Controls.Add(this.labelLC);
			this.groupBox1.Controls.Add(this.textBoxDDC);
			this.groupBox1.Controls.Add(this.labelDDC);
			this.groupBox1.Controls.Add(this.labelBookType);
			this.groupBox1.Controls.Add(this.labelBookGroup);
			this.groupBox1.Controls.Add(this.textBoxVolume);
			this.groupBox1.Controls.Add(this.labelVolume);
			this.groupBox1.Controls.Add(this.textBoxRev);
			this.groupBox1.Controls.Add(this.labelRev);
			this.groupBox1.Controls.Add(this.textBoxPages);
			this.groupBox1.Controls.Add(this.labelPages);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.groupBox1.Location = new System.Drawing.Point(248, 232);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(680, 320);
			this.groupBox1.TabIndex = 168;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "View";
			// 
			// dataGridView
			// 
			this.dataGridView.DataMember = "";
			this.dataGridView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGridView.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGridView.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridView.Location = new System.Drawing.Point(8, 24);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.ReadOnly = true;
			this.dataGridView.Size = new System.Drawing.Size(664, 288);
			this.dataGridView.TabIndex = 178;
			this.dataGridView.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																									 this.dataGridTableStyleAuthor,
																									 this.dataGridTableStyleCopy,
																									 this.dataGridTableStyleDescription,
																									 this.dataGridTableStyleSubject});
			this.dataGridView.DoubleClick += new System.EventHandler(this.dataGridView_DoubleClick);
			// 
			// dataGridTableStyleAuthor
			// 
			this.dataGridTableStyleAuthor.AlternatingBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleAuthor.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.dataGridTableStyleAuthor.DataGrid = this.dataGridView;
			this.dataGridTableStyleAuthor.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleAuthor.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																													   this.dataGridTextBoxColumnFAuthorCode,
																													   this.dataGridTextBoxColumnFirstName,
																													   this.dataGridTextBoxColumnLastName,
																													   this.dataGridTextBoxColumnAuthorType});
			this.dataGridTableStyleAuthor.GridLineColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridTableStyleAuthor.HeaderBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleAuthor.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleAuthor.MappingName = "BookAuthorData";
			// 
			// dataGridTextBoxColumnFAuthorCode
			// 
			this.dataGridTextBoxColumnFAuthorCode.Format = "";
			this.dataGridTextBoxColumnFAuthorCode.FormatInfo = null;
			this.dataGridTextBoxColumnFAuthorCode.HeaderText = "Author Code";
			this.dataGridTextBoxColumnFAuthorCode.MappingName = "AuthorCode";
			this.dataGridTextBoxColumnFAuthorCode.Width = 120;
			// 
			// dataGridTextBoxColumnFirstName
			// 
			this.dataGridTextBoxColumnFirstName.Format = "";
			this.dataGridTextBoxColumnFirstName.FormatInfo = null;
			this.dataGridTextBoxColumnFirstName.HeaderText = "First Name";
			this.dataGridTextBoxColumnFirstName.MappingName = "FirstName";
			this.dataGridTextBoxColumnFirstName.Width = 130;
			// 
			// dataGridTextBoxColumnLastName
			// 
			this.dataGridTextBoxColumnLastName.Format = "";
			this.dataGridTextBoxColumnLastName.FormatInfo = null;
			this.dataGridTextBoxColumnLastName.HeaderText = "Last Name";
			this.dataGridTextBoxColumnLastName.MappingName = "LastName";
			this.dataGridTextBoxColumnLastName.Width = 130;
			// 
			// dataGridTextBoxColumnAuthorType
			// 
			this.dataGridTextBoxColumnAuthorType.Format = "";
			this.dataGridTextBoxColumnAuthorType.FormatInfo = null;
			this.dataGridTextBoxColumnAuthorType.HeaderText = "Author Type";
			this.dataGridTextBoxColumnAuthorType.MappingName = "AuthorType";
			this.dataGridTextBoxColumnAuthorType.Width = 120;
			// 
			// dataGridTableStyleCopy
			// 
			this.dataGridTableStyleCopy.AlternatingBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleCopy.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.dataGridTableStyleCopy.DataGrid = this.dataGridView;
			this.dataGridTableStyleCopy.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleCopy.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																													 this.dataGridTextBoxColumnCopyNo,
																													 this.dataGridTextBoxColumnBoughtDate,
																													 this.dataGridTextBoxColumnCopyType,
																													 this.dataGridTextBoxColumnCopyStatus,
																													 this.dataGridTextBoxColumnShelfCode,
																													 this.dataGridTextBoxColumnShelfName,
																													 this.dataGridTextBoxColumnStoreCode,
																													 this.dataGridTextBoxColumnStoreName,
																													 this.dataGridTextBoxColumnCurr,
																													 this.dataGridTextBoxColumnCurrRate,
																													 this.dataGridTextBoxColumnPrice,
																													 this.dataGridTextBoxColumnBookStatus,
																													 this.dataGridTextBoxColumnStatusDesc,
																													 this.dataGridTextBoxColumnBorrowBy,
																													 this.dataGridTextBoxColumnMemberID});
			this.dataGridTableStyleCopy.GridLineColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridTableStyleCopy.HeaderBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleCopy.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleCopy.MappingName = "BookCopyData";
			// 
			// dataGridTextBoxColumnCopyNo
			// 
			this.dataGridTextBoxColumnCopyNo.Format = "";
			this.dataGridTextBoxColumnCopyNo.FormatInfo = null;
			this.dataGridTextBoxColumnCopyNo.HeaderText = "Copy No";
			this.dataGridTextBoxColumnCopyNo.MappingName = "CopyNo";
			this.dataGridTextBoxColumnCopyNo.Width = 75;
			// 
			// dataGridTextBoxColumnBoughtDate
			// 
			this.dataGridTextBoxColumnBoughtDate.Format = "";
			this.dataGridTextBoxColumnBoughtDate.FormatInfo = null;
			this.dataGridTextBoxColumnBoughtDate.HeaderText = "Bought Date";
			this.dataGridTextBoxColumnBoughtDate.MappingName = "BoughtDate";
			this.dataGridTextBoxColumnBoughtDate.Width = 75;
			// 
			// dataGridTextBoxColumnCopyType
			// 
			this.dataGridTextBoxColumnCopyType.Format = "";
			this.dataGridTextBoxColumnCopyType.FormatInfo = null;
			this.dataGridTextBoxColumnCopyType.HeaderText = "Copy Type";
			this.dataGridTextBoxColumnCopyType.MappingName = "CopyTypeDesc";
			this.dataGridTextBoxColumnCopyType.Width = 75;
			// 
			// dataGridTextBoxColumnCopyStatus
			// 
			this.dataGridTextBoxColumnCopyStatus.Format = "";
			this.dataGridTextBoxColumnCopyStatus.FormatInfo = null;
			this.dataGridTextBoxColumnCopyStatus.HeaderText = "Copy Status";
			this.dataGridTextBoxColumnCopyStatus.MappingName = "CopyStatusDesc";
			this.dataGridTextBoxColumnCopyStatus.Width = 75;
			// 
			// dataGridTextBoxColumnShelfCode
			// 
			this.dataGridTextBoxColumnShelfCode.Format = "";
			this.dataGridTextBoxColumnShelfCode.FormatInfo = null;
			this.dataGridTextBoxColumnShelfCode.MappingName = "ShelfCode";
			this.dataGridTextBoxColumnShelfCode.Width = 0;
			// 
			// dataGridTextBoxColumnShelfName
			// 
			this.dataGridTextBoxColumnShelfName.Format = "";
			this.dataGridTextBoxColumnShelfName.FormatInfo = null;
			this.dataGridTextBoxColumnShelfName.HeaderText = "Shelf Name";
			this.dataGridTextBoxColumnShelfName.MappingName = "ShelfDesc";
			this.dataGridTextBoxColumnShelfName.Width = 75;
			// 
			// dataGridTextBoxColumnStoreCode
			// 
			this.dataGridTextBoxColumnStoreCode.Format = "";
			this.dataGridTextBoxColumnStoreCode.FormatInfo = null;
			this.dataGridTextBoxColumnStoreCode.MappingName = "StoreCode";
			this.dataGridTextBoxColumnStoreCode.Width = 0;
			// 
			// dataGridTextBoxColumnStoreName
			// 
			this.dataGridTextBoxColumnStoreName.Format = "";
			this.dataGridTextBoxColumnStoreName.FormatInfo = null;
			this.dataGridTextBoxColumnStoreName.HeaderText = "Store Name";
			this.dataGridTextBoxColumnStoreName.MappingName = "StoreName";
			this.dataGridTextBoxColumnStoreName.Width = 75;
			// 
			// dataGridTextBoxColumnCurr
			// 
			this.dataGridTextBoxColumnCurr.Format = "";
			this.dataGridTextBoxColumnCurr.FormatInfo = null;
			this.dataGridTextBoxColumnCurr.HeaderText = "Curr";
			this.dataGridTextBoxColumnCurr.MappingName = "Curr";
			this.dataGridTextBoxColumnCurr.Width = 75;
			// 
			// dataGridTextBoxColumnCurrRate
			// 
			this.dataGridTextBoxColumnCurrRate.Format = "";
			this.dataGridTextBoxColumnCurrRate.FormatInfo = null;
			this.dataGridTextBoxColumnCurrRate.HeaderText = "Curr Rate";
			this.dataGridTextBoxColumnCurrRate.MappingName = "CurrRate";
			this.dataGridTextBoxColumnCurrRate.Width = 75;
			// 
			// dataGridTextBoxColumnPrice
			// 
			this.dataGridTextBoxColumnPrice.Format = "";
			this.dataGridTextBoxColumnPrice.FormatInfo = null;
			this.dataGridTextBoxColumnPrice.HeaderText = "Price";
			this.dataGridTextBoxColumnPrice.MappingName = "Price";
			this.dataGridTextBoxColumnPrice.Width = 75;
			// 
			// dataGridTextBoxColumnBookStatus
			// 
			this.dataGridTextBoxColumnBookStatus.Format = "";
			this.dataGridTextBoxColumnBookStatus.FormatInfo = null;
			this.dataGridTextBoxColumnBookStatus.HeaderText = "Book Status";
			this.dataGridTextBoxColumnBookStatus.MappingName = "BookStatus";
			this.dataGridTextBoxColumnBookStatus.Width = 75;
			// 
			// dataGridTextBoxColumnStatusDesc
			// 
			this.dataGridTextBoxColumnStatusDesc.Format = "";
			this.dataGridTextBoxColumnStatusDesc.FormatInfo = null;
			this.dataGridTextBoxColumnStatusDesc.HeaderText = "Status Desc";
			this.dataGridTextBoxColumnStatusDesc.MappingName = "StatusDesc";
			this.dataGridTextBoxColumnStatusDesc.Width = 75;
			// 
			// dataGridTextBoxColumnBorrowBy
			// 
			this.dataGridTextBoxColumnBorrowBy.Format = "";
			this.dataGridTextBoxColumnBorrowBy.FormatInfo = null;
			this.dataGridTextBoxColumnBorrowBy.MappingName = "BorrowBy";
			this.dataGridTextBoxColumnBorrowBy.Width = 0;
			// 
			// dataGridTextBoxColumnMemberID
			// 
			this.dataGridTextBoxColumnMemberID.Format = "";
			this.dataGridTextBoxColumnMemberID.FormatInfo = null;
			this.dataGridTextBoxColumnMemberID.HeaderText = "Borrow By";
			this.dataGridTextBoxColumnMemberID.MappingName = "MemberName";
			this.dataGridTextBoxColumnMemberID.Width = 75;
			// 
			// dataGridTableStyleDescription
			// 
			this.dataGridTableStyleDescription.AlternatingBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleDescription.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.dataGridTableStyleDescription.DataGrid = this.dataGridView;
			this.dataGridTableStyleDescription.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleDescription.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																															this.dataGridTextBoxColumnBookCode,
																															this.dataGridTextBoxColumnBookSeq,
																															this.dataGridTextBoxColumnBookDescription,
																															this.dataGridTextBoxColumnRelatedFile});
			this.dataGridTableStyleDescription.GridLineColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridTableStyleDescription.HeaderBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleDescription.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleDescription.MappingName = "BookDescData";
			// 
			// dataGridTextBoxColumnBookCode
			// 
			this.dataGridTextBoxColumnBookCode.Format = "";
			this.dataGridTextBoxColumnBookCode.FormatInfo = null;
			this.dataGridTextBoxColumnBookCode.HeaderText = "Book Code";
			this.dataGridTextBoxColumnBookCode.MappingName = "BookCOde";
			this.dataGridTextBoxColumnBookCode.Width = 0;
			// 
			// dataGridTextBoxColumnBookSeq
			// 
			this.dataGridTextBoxColumnBookSeq.Format = "";
			this.dataGridTextBoxColumnBookSeq.FormatInfo = null;
			this.dataGridTextBoxColumnBookSeq.HeaderText = "Book Seq";
			this.dataGridTextBoxColumnBookSeq.MappingName = "BookSeq";
			this.dataGridTextBoxColumnBookSeq.Width = 75;
			// 
			// dataGridTextBoxColumnBookDescription
			// 
			this.dataGridTextBoxColumnBookDescription.Format = "";
			this.dataGridTextBoxColumnBookDescription.FormatInfo = null;
			this.dataGridTextBoxColumnBookDescription.HeaderText = "Description";
			this.dataGridTextBoxColumnBookDescription.MappingName = "BookDescription";
			this.dataGridTextBoxColumnBookDescription.Width = 300;
			// 
			// dataGridTextBoxColumnRelatedFile
			// 
			this.dataGridTextBoxColumnRelatedFile.Format = "";
			this.dataGridTextBoxColumnRelatedFile.FormatInfo = null;
			this.dataGridTextBoxColumnRelatedFile.HeaderText = "Related File";
			this.dataGridTextBoxColumnRelatedFile.MappingName = "RelatedFile";
			this.dataGridTextBoxColumnRelatedFile.Width = 300;
			// 
			// dataGridTableStyleSubject
			// 
			this.dataGridTableStyleSubject.AlternatingBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleSubject.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.dataGridTableStyleSubject.DataGrid = this.dataGridView;
			this.dataGridTableStyleSubject.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleSubject.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																														this.dataGridTextBoxColumnSubjectCode,
																														this.dataGridTextBoxColumnSubjectName,
																														this.dataGridTextBoxColumnDescription});
			this.dataGridTableStyleSubject.GridLineColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridTableStyleSubject.HeaderBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleSubject.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleSubject.MappingName = "BookSubjectData";
			// 
			// dataGridTextBoxColumnSubjectCode
			// 
			this.dataGridTextBoxColumnSubjectCode.Format = "";
			this.dataGridTextBoxColumnSubjectCode.FormatInfo = null;
			this.dataGridTextBoxColumnSubjectCode.HeaderText = "Subject Code";
			this.dataGridTextBoxColumnSubjectCode.MappingName = "SubjectCode";
			this.dataGridTextBoxColumnSubjectCode.Width = 0;
			// 
			// dataGridTextBoxColumnSubjectName
			// 
			this.dataGridTextBoxColumnSubjectName.Format = "";
			this.dataGridTextBoxColumnSubjectName.FormatInfo = null;
			this.dataGridTextBoxColumnSubjectName.HeaderText = "Subject Name";
			this.dataGridTextBoxColumnSubjectName.MappingName = "SubjectName";
			this.dataGridTextBoxColumnSubjectName.Width = 200;
			// 
			// dataGridTextBoxColumnDescription
			// 
			this.dataGridTextBoxColumnDescription.Format = "";
			this.dataGridTextBoxColumnDescription.FormatInfo = null;
			this.dataGridTextBoxColumnDescription.HeaderText = "Description";
			this.dataGridTextBoxColumnDescription.MappingName = "Description";
			this.dataGridTextBoxColumnDescription.Width = 200;
			// 
			// textBoxBookDesc
			// 
			this.textBoxBookDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxBookDesc.Location = new System.Drawing.Point(216, 24);
			this.textBoxBookDesc.Multiline = true;
			this.textBoxBookDesc.Name = "textBoxBookDesc";
			this.textBoxBookDesc.Size = new System.Drawing.Size(456, 288);
			this.textBoxBookDesc.TabIndex = 177;
			this.textBoxBookDesc.Text = "";
			// 
			// pictureBoxCover
			// 
			this.pictureBoxCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBoxCover.Location = new System.Drawing.Point(8, 24);
			this.pictureBoxCover.Name = "pictureBoxCover";
			this.pictureBoxCover.Size = new System.Drawing.Size(200, 232);
			this.pictureBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxCover.TabIndex = 176;
			this.pictureBoxCover.TabStop = false;
			// 
			// textBoxPublishYear
			// 
			this.textBoxPublishYear.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxPublishYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxPublishYear.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxPublishYear.Location = new System.Drawing.Point(472, 120);
			this.textBoxPublishYear.Name = "textBoxPublishYear";
			this.textBoxPublishYear.Size = new System.Drawing.Size(200, 22);
			this.textBoxPublishYear.TabIndex = 175;
			this.textBoxPublishYear.Text = "";
			// 
			// textBoxContent
			// 
			this.textBoxContent.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxContent.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxContent.Location = new System.Drawing.Point(136, 152);
			this.textBoxContent.Name = "textBoxContent";
			this.textBoxContent.Size = new System.Drawing.Size(536, 22);
			this.textBoxContent.TabIndex = 173;
			this.textBoxContent.Text = "";
			// 
			// labelContent
			// 
			this.labelContent.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelContent.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelContent.Location = new System.Drawing.Point(8, 152);
			this.labelContent.Name = "labelContent";
			this.labelContent.Size = new System.Drawing.Size(120, 24);
			this.labelContent.TabIndex = 174;
			this.labelContent.Text = "Content";
			// 
			// textBoxBookType
			// 
			this.textBoxBookType.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxBookType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxBookType.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxBookType.Location = new System.Drawing.Point(136, 56);
			this.textBoxBookType.Name = "textBoxBookType";
			this.textBoxBookType.ReadOnly = true;
			this.textBoxBookType.Size = new System.Drawing.Size(200, 22);
			this.textBoxBookType.TabIndex = 172;
			this.textBoxBookType.Text = "";
			// 
			// textBoxPublisherName
			// 
			this.textBoxPublisherName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxPublisherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxPublisherName.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxPublisherName.Location = new System.Drawing.Point(136, 120);
			this.textBoxPublisherName.Name = "textBoxPublisherName";
			this.textBoxPublisherName.ReadOnly = true;
			this.textBoxPublisherName.Size = new System.Drawing.Size(200, 22);
			this.textBoxPublisherName.TabIndex = 165;
			this.textBoxPublisherName.Text = "";
			// 
			// textBoxBookGroup
			// 
			this.textBoxBookGroup.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxBookGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxBookGroup.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxBookGroup.Location = new System.Drawing.Point(472, 56);
			this.textBoxBookGroup.Name = "textBoxBookGroup";
			this.textBoxBookGroup.ReadOnly = true;
			this.textBoxBookGroup.Size = new System.Drawing.Size(200, 22);
			this.textBoxBookGroup.TabIndex = 162;
			this.textBoxBookGroup.Text = "";
			// 
			// labelPublishYear
			// 
			this.labelPublishYear.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelPublishYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelPublishYear.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelPublishYear.Location = new System.Drawing.Point(344, 120);
			this.labelPublishYear.Name = "labelPublishYear";
			this.labelPublishYear.Size = new System.Drawing.Size(120, 24);
			this.labelPublishYear.TabIndex = 171;
			this.labelPublishYear.Text = "Publish Year";
			// 
			// labelPublisher
			// 
			this.labelPublisher.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelPublisher.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelPublisher.Location = new System.Drawing.Point(8, 120);
			this.labelPublisher.Name = "labelPublisher";
			this.labelPublisher.Size = new System.Drawing.Size(120, 24);
			this.labelPublisher.TabIndex = 170;
			this.labelPublisher.Text = "Publisher";
			// 
			// textBoxLC
			// 
			this.textBoxLC.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxLC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxLC.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxLC.Location = new System.Drawing.Point(472, 88);
			this.textBoxLC.Name = "textBoxLC";
			this.textBoxLC.Size = new System.Drawing.Size(200, 22);
			this.textBoxLC.TabIndex = 164;
			this.textBoxLC.Text = "";
			// 
			// labelLC
			// 
			this.labelLC.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelLC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelLC.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelLC.Location = new System.Drawing.Point(344, 88);
			this.labelLC.Name = "labelLC";
			this.labelLC.Size = new System.Drawing.Size(120, 24);
			this.labelLC.TabIndex = 169;
			this.labelLC.Text = "LC";
			// 
			// textBoxDDC
			// 
			this.textBoxDDC.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxDDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxDDC.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxDDC.Location = new System.Drawing.Point(136, 88);
			this.textBoxDDC.Name = "textBoxDDC";
			this.textBoxDDC.Size = new System.Drawing.Size(200, 22);
			this.textBoxDDC.TabIndex = 163;
			this.textBoxDDC.Text = "";
			// 
			// labelDDC
			// 
			this.labelDDC.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelDDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelDDC.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelDDC.Location = new System.Drawing.Point(8, 88);
			this.labelDDC.Name = "labelDDC";
			this.labelDDC.Size = new System.Drawing.Size(120, 24);
			this.labelDDC.TabIndex = 168;
			this.labelDDC.Text = "DDC";
			// 
			// labelBookType
			// 
			this.labelBookType.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelBookType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBookType.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelBookType.Location = new System.Drawing.Point(8, 56);
			this.labelBookType.Name = "labelBookType";
			this.labelBookType.Size = new System.Drawing.Size(120, 24);
			this.labelBookType.TabIndex = 167;
			this.labelBookType.Text = "Book Type";
			// 
			// labelBookGroup
			// 
			this.labelBookGroup.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelBookGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBookGroup.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelBookGroup.Location = new System.Drawing.Point(344, 56);
			this.labelBookGroup.Name = "labelBookGroup";
			this.labelBookGroup.Size = new System.Drawing.Size(120, 24);
			this.labelBookGroup.TabIndex = 166;
			this.labelBookGroup.Text = "Book Group";
			// 
			// textBoxVolume
			// 
			this.textBoxVolume.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxVolume.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxVolume.Location = new System.Drawing.Point(200, 24);
			this.textBoxVolume.Name = "textBoxVolume";
			this.textBoxVolume.Size = new System.Drawing.Size(104, 22);
			this.textBoxVolume.TabIndex = 144;
			this.textBoxVolume.Text = "";
			// 
			// labelVolume
			// 
			this.labelVolume.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelVolume.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelVolume.Location = new System.Drawing.Point(136, 24);
			this.labelVolume.Name = "labelVolume";
			this.labelVolume.Size = new System.Drawing.Size(120, 24);
			this.labelVolume.TabIndex = 149;
			this.labelVolume.Text = "Volume";
			// 
			// textBoxRev
			// 
			this.textBoxRev.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxRev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxRev.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxRev.Location = new System.Drawing.Point(568, 24);
			this.textBoxRev.Name = "textBoxRev";
			this.textBoxRev.Size = new System.Drawing.Size(104, 22);
			this.textBoxRev.TabIndex = 146;
			this.textBoxRev.Text = "";
			// 
			// labelRev
			// 
			this.labelRev.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelRev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelRev.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelRev.Location = new System.Drawing.Point(504, 24);
			this.labelRev.Name = "labelRev";
			this.labelRev.Size = new System.Drawing.Size(120, 24);
			this.labelRev.TabIndex = 148;
			this.labelRev.Text = "Rev";
			// 
			// textBoxPages
			// 
			this.textBoxPages.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxPages.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxPages.Location = new System.Drawing.Point(384, 24);
			this.textBoxPages.Name = "textBoxPages";
			this.textBoxPages.Size = new System.Drawing.Size(104, 22);
			this.textBoxPages.TabIndex = 145;
			this.textBoxPages.Text = "";
			// 
			// labelPages
			// 
			this.labelPages.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelPages.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelPages.Location = new System.Drawing.Point(320, 24);
			this.labelPages.Name = "labelPages";
			this.labelPages.Size = new System.Drawing.Size(120, 24);
			this.labelPages.TabIndex = 147;
			this.labelPages.Text = "Pages";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(216, 176);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(704, 10);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 169;
			this.pictureBox1.TabStop = false;
			// 
			// labelView
			// 
			this.labelView.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelView.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelView.Location = new System.Drawing.Point(320, 192);
			this.labelView.Name = "labelView";
			this.labelView.Size = new System.Drawing.Size(120, 24);
			this.labelView.TabIndex = 170;
			this.labelView.Text = "View";
			// 
			// comboBoxView
			// 
			this.comboBoxView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.comboBoxView.Items.AddRange(new object[] {
															  "Detail",
															  "Cover",
															  "Author",
															  "Copy",
															  "Description",
															  "Subject"});
			this.comboBoxView.Location = new System.Drawing.Point(384, 192);
			this.comboBoxView.Name = "comboBoxView";
			this.comboBoxView.Size = new System.Drawing.Size(200, 24);
			this.comboBoxView.TabIndex = 171;
			this.comboBoxView.Text = "Detail";
			this.comboBoxView.SelectedIndexChanged += new System.EventHandler(this.comboBoxView_SelectedIndexChanged);
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
			this.LabelTitle.TabIndex = 172;
			this.LabelTitle.Text = "    Show Book";
			this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FrmShowBook
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.LabelTitle);
			this.Controls.Add(this.comboBoxView);
			this.Controls.Add(this.labelView);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.textBoxISBN);
			this.Controls.Add(this.labelISBN);
			this.Controls.Add(this.textBoxOriginalTitle);
			this.Controls.Add(this.textBoxBookName);
			this.Controls.Add(this.textBoxBookCode);
			this.Controls.Add(this.labelOriginalTitle);
			this.Controls.Add(this.labelBookName);
			this.Controls.Add(this.labelBookCode);
			this.Name = "FrmShowBook";
			this.Load += new System.EventHandler(this.FrmShowBook_Load);
			this.Controls.SetChildIndex(this.labelBookCode, 0);
			this.Controls.SetChildIndex(this.labelBookName, 0);
			this.Controls.SetChildIndex(this.labelOriginalTitle, 0);
			this.Controls.SetChildIndex(this.textBoxBookCode, 0);
			this.Controls.SetChildIndex(this.textBoxBookName, 0);
			this.Controls.SetChildIndex(this.textBoxOriginalTitle, 0);
			this.Controls.SetChildIndex(this.labelISBN, 0);
			this.Controls.SetChildIndex(this.textBoxISBN, 0);
			this.Controls.SetChildIndex(this.groupBox1, 0);
			this.Controls.SetChildIndex(this.pictureBox1, 0);
			this.Controls.SetChildIndex(this.labelView, 0);
			this.Controls.SetChildIndex(this.comboBoxView, 0);
			this.Controls.SetChildIndex(this.LabelTitle, 0);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void FrmShowBook_Load(object sender, System.EventArgs e)
		{	ChangeVisible(1);
			if(MyMDIForm.MyBookSearch.BookCode.ToString() != "")
			{
				MyClassDatabase = new ClassDatabase();
				MyDataTable = MyClassDatabase.GetBookData(MyMDIForm.MyBookSearch.BookCode.ToString());
				textBoxBookCode.Text = MyDataTable.Rows[0]["BookCode"].ToString().Trim();
				textBoxBookName.Text = MyDataTable.Rows[0]["BookName"].ToString().Trim();
				textBoxOriginalTitle.Text = MyDataTable.Rows[0]["OriginalTitle"].ToString().Trim();;
				textBoxISBN.Text = (MyDataTable.Rows[0]["ISBN"].ToString().Trim());
				textBoxVolume.Text = MyDataTable.Rows[0]["Vol"].ToString().Trim();
				textBoxPages.Text = MyDataTable.Rows[0]["Pages"].ToString().Trim();
				textBoxRev.Text = MyDataTable.Rows[0]["Rev"].ToString().Trim();
				textBoxBookType.Text = MyDataTable.Rows[0]["BookType"].ToString().Trim();
				textBoxBookGroup.Text = MyDataTable.Rows[0]["GroupName"].ToString().Trim();
				textBoxDDC.Text = MyDataTable.Rows[0]["DDC"].ToString().Trim();
				textBoxLC.Text = MyDataTable.Rows[0]["LC"].ToString().Trim();
				textBoxPublisherName.Text = MyDataTable.Rows[0]["PublisherName"].ToString().Trim();
				textBoxPublishYear.Text = MyDataTable.Rows[0]["PublishYear"].ToString().Trim();
				textBoxContent.Text = MyDataTable.Rows[0]["Content"].ToString().Trim();


				
			}
		}

		private void comboBoxView_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(comboBoxView.Text.ToString() == "Detail")
			{
				ChangeVisible(1);
			}
			else if(comboBoxView.Text.ToString() == "Cover")
			{
				ChangeVisible(2);

				MyClassDatabase = new ClassDatabase();
				MyBookDtDataTable = MyClassDatabase.GetBookDt(MyMDIForm.MyBookSearch.BookCode.ToString());
				if(MyBookDtDataTable.Rows.Count>0)
				{
					textBoxBookDesc.Text = MyBookDtDataTable.Rows[0][1].ToString().Trim();
			
				
					bool IsImageAvailable;
					MyClassDatabase = new ClassDatabase();
					IsImageAvailable = MyClassDatabase.GetCheckImageData(MyMDIForm.MyBookSearch.BookCode);
					if(IsImageAvailable == true)
					{
						MyClassDatabase = new ClassDatabase();
						imageData = MyClassDatabase.GetImageData(MyMDIForm.MyBookSearch.BookCode.ToString());
						MemoryStream b;		
						try
						{
							b = new MemoryStream(imageData,0,imageData.Length,true,true);
							MyBookImage = new Bitmap(b);
							pictureBoxCover.Image = MyBookImage;
						}
						catch(Exception eee)
						{
							MessageBox.Show(eee.Message);
						}
						
					}
					else
					{
						
					}
		
				}
			}
			else if(comboBoxView.Text.ToString() == "Author")
			{
				ChangeVisible(3);
				if(MyMDIForm.MyBookSearch.BookCode.ToString() != "")
				{
					MyClassDatabase = new ClassDatabase();
					MyViewDataTable = MyClassDatabase.GetBookAuthorData(textBoxBookCode.Text.ToString());
					dataGridView.DataSource = MyViewDataTable;
				}
			}
			else if(comboBoxView.Text.ToString() == "Copy")
			{
				ChangeVisible(3);
				if(MyMDIForm.MyBookSearch.BookCode.ToString() != "")
				{
					MyClassDatabase = new ClassDatabase();
					MyViewDataTable = MyClassDatabase.GetBookCopyData(textBoxBookCode.Text.ToString());
					dataGridView.DataSource = MyViewDataTable;
				}
			}
			else if(comboBoxView.Text.ToString() == "Description")
			{
				ChangeVisible(3);
				if(MyMDIForm.MyBookSearch.BookCode.ToString() != "")
				{
					MyClassDatabase = new ClassDatabase();
					MyViewDataTable = MyClassDatabase.GetBookDescData(textBoxBookCode.Text.ToString());
					dataGridView.DataSource = MyViewDataTable;
				}
			}
			else if(comboBoxView.Text.ToString() == "Subject")
			{
				ChangeVisible(3);
				if(MyMDIForm.MyBookSearch.BookCode.ToString() != "")
				{
					MyClassDatabase = new ClassDatabase();
					MyViewDataTable = MyClassDatabase.GetBookSubjectData(textBoxBookCode.Text.ToString());
					dataGridView.DataSource = MyViewDataTable;
				}
			}
		}

		internal void ChangeVisible(int StatusData)
		{
			if(StatusData == 1)
			{
				labelVolume.Visible = true;
				textBoxVolume.Visible = true;
				labelPages.Visible = true;
				textBoxPages.Visible = true;
				labelRev.Visible = true;
				textBoxRev.Visible = true;
				labelBookType.Visible = true;
				textBoxBookType.Visible = true;
				labelBookGroup.Visible = true;
				textBoxBookGroup.Visible = true;
				labelDDC.Visible = true;
				textBoxDDC.Visible = true;
				labelLC.Visible = true;
				textBoxLC.Visible = true;
				labelPublisher.Visible = true;
				textBoxPublisherName.Visible = true;
				labelPublishYear.Visible = true;
				textBoxPublishYear.Visible = true;
				labelContent.Visible = true;
				textBoxContent.Visible = true;
				dataGridView.Visible = false;
				pictureBoxCover.Visible = false;
				textBoxBookDesc.Visible = false;

			}
			else if(StatusData == 2)
			{
				labelVolume.Visible = false;
				textBoxVolume.Visible = false;
				labelPages.Visible = false;
				textBoxPages.Visible = false;
				labelRev.Visible = false;
				textBoxRev.Visible = false;
				labelBookType.Visible = false;
				textBoxBookType.Visible = false;
				labelBookGroup.Visible = false;
				textBoxBookGroup.Visible = false;
				labelDDC.Visible = false;
				textBoxDDC.Visible = false;
				labelLC.Visible = false;
				textBoxLC.Visible = false;
				labelPublisher.Visible = false;
				textBoxPublisherName.Visible = false;
				labelPublishYear.Visible = false;
				textBoxPublishYear.Visible = false;
				labelContent.Visible = false;
				textBoxContent.Visible = false;
				dataGridView.Visible = false;
				pictureBoxCover.Visible = true;
				textBoxBookDesc.Visible = true;

			}
			else if(StatusData == 3)
			{
				labelVolume.Visible = false;
				textBoxVolume.Visible = false;
				labelPages.Visible = false;
				textBoxPages.Visible = false;
				labelRev.Visible = false;
				textBoxRev.Visible = false;
				labelBookType.Visible = false;
				textBoxBookType.Visible = false;
				labelBookGroup.Visible = false;
				textBoxBookGroup.Visible = false;
				labelDDC.Visible = false;
				textBoxDDC.Visible = false;
				labelLC.Visible = false;
				textBoxLC.Visible = false;
				labelPublisher.Visible = false;
				textBoxPublisherName.Visible = false;
				labelPublishYear.Visible = false;
				textBoxPublishYear.Visible = false;
				labelContent.Visible = false;
				textBoxContent.Visible = false;
				dataGridView.Visible = true;
				pictureBoxCover.Visible = false;
				textBoxBookDesc.Visible = false;

			}
		}
		private void dataGridView_DoubleClick(object sender, System.EventArgs e)
		{
			if(MyViewDataTable.Rows.Count>0)
			{
				Shell32.ShellClass a = new Shell32.ShellClass();
				if(comboBoxView.Text.ToString() == "Description")
				{
					a.Open(dataGridView[dataGridView.CurrentRowIndex,3].ToString().Trim());
				}


			}
		}


	}
}

