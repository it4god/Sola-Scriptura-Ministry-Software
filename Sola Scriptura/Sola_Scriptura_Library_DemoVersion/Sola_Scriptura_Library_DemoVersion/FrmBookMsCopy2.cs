using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace Sola_Scriptura_Library
{
	public class FrmBookMsCopy2 : Sola_Scriptura_Library.FrmBookMaster
	{
		internal System.Windows.Forms.Label LabelTitle;
		internal System.Windows.Forms.TextBox textBoxISBN;
		internal System.Windows.Forms.Label labelISBN;
		internal System.Windows.Forms.TextBox textBoxOriginalTitle;
		internal System.Windows.Forms.TextBox textBoxBookName;
		internal System.Windows.Forms.TextBox textBoxBookCode;
		internal System.Windows.Forms.Label labelOriginalTitle;
		internal System.Windows.Forms.Label labelBookName;
		internal System.Windows.Forms.Label labelBookCode;
		internal System.Windows.Forms.DataGrid dataGridBookCopy;
		internal System.Windows.Forms.TextBox textBoxCopyNo;
		internal System.Windows.Forms.Label labelCopyNo;
		internal System.Windows.Forms.DateTimePicker dateTimePickerBroughtDate;
		internal System.Windows.Forms.Label labelBroughtDate;
		internal System.Windows.Forms.ComboBox comboBoxCopyType;
		internal System.Windows.Forms.Label labelCopyType;
		internal System.Windows.Forms.Label labelCopyStatus;
		internal System.Windows.Forms.ComboBox comboBoxCopyStatus;
		internal System.Windows.Forms.TextBox textBoxShelfCode;
		internal System.Windows.Forms.Label labelShelfCode;
		internal System.Windows.Forms.TextBox textBoxStoreCode;
		internal System.Windows.Forms.Label labelStoreCode;
		internal System.Windows.Forms.TextBox textBoxCurrRate;
		internal System.Windows.Forms.Label labelCurrRate;
		internal System.Windows.Forms.TextBox textBoxCurr;
		internal System.Windows.Forms.Label labelCurr;
		internal System.Windows.Forms.TextBox textBoxStatusDesc;
		internal System.Windows.Forms.Label labelBookDesc;
		internal System.Windows.Forms.TextBox textBoxPrice;
		internal System.Windows.Forms.Label labelPrice;
		internal System.Windows.Forms.Label label2;
		internal System.Windows.Forms.ComboBox comboBoxBookStatus;
		internal System.Windows.Forms.Button buttonSave;
		internal System.Windows.Forms.Button buttonCancel;
		internal System.Windows.Forms.Button buttonDelete;
		internal System.Windows.Forms.Button buttonEdit;
		internal System.Windows.Forms.Button buttonAdd;
		private System.ComponentModel.IContainer components = null;

		internal ClassDatabase MyClassDatabase;
		

		public FrmBookMsCopy2()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public FrmBookMsCopy2(FrmMDI MDIForm, FrmBookMenu BookMenuForm)
		{
			base.MyMDIForm = MDIForm;
			base.MyBookMenuForm = BookMenuForm;
			InitializeComponent();
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmBookMsCopy2));
			this.LabelTitle = new System.Windows.Forms.Label();
			this.textBoxISBN = new System.Windows.Forms.TextBox();
			this.labelISBN = new System.Windows.Forms.Label();
			this.textBoxOriginalTitle = new System.Windows.Forms.TextBox();
			this.textBoxBookName = new System.Windows.Forms.TextBox();
			this.textBoxBookCode = new System.Windows.Forms.TextBox();
			this.labelOriginalTitle = new System.Windows.Forms.Label();
			this.labelBookName = new System.Windows.Forms.Label();
			this.labelBookCode = new System.Windows.Forms.Label();
			this.dataGridBookCopy = new System.Windows.Forms.DataGrid();
			this.textBoxCopyNo = new System.Windows.Forms.TextBox();
			this.labelCopyNo = new System.Windows.Forms.Label();
			this.dateTimePickerBroughtDate = new System.Windows.Forms.DateTimePicker();
			this.labelBroughtDate = new System.Windows.Forms.Label();
			this.comboBoxCopyType = new System.Windows.Forms.ComboBox();
			this.labelCopyType = new System.Windows.Forms.Label();
			this.labelCopyStatus = new System.Windows.Forms.Label();
			this.comboBoxCopyStatus = new System.Windows.Forms.ComboBox();
			this.textBoxShelfCode = new System.Windows.Forms.TextBox();
			this.labelShelfCode = new System.Windows.Forms.Label();
			this.textBoxStoreCode = new System.Windows.Forms.TextBox();
			this.labelStoreCode = new System.Windows.Forms.Label();
			this.textBoxCurrRate = new System.Windows.Forms.TextBox();
			this.labelCurrRate = new System.Windows.Forms.Label();
			this.textBoxCurr = new System.Windows.Forms.TextBox();
			this.labelCurr = new System.Windows.Forms.Label();
			this.textBoxStatusDesc = new System.Windows.Forms.TextBox();
			this.labelBookDesc = new System.Windows.Forms.Label();
			this.textBoxPrice = new System.Windows.Forms.TextBox();
			this.labelPrice = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBoxBookStatus = new System.Windows.Forms.ComboBox();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridBookCopy)).BeginInit();
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
			this.LabelTitle.TabIndex = 108;
			this.LabelTitle.Text = "    Book Copy";
			this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.textBoxISBN.TabIndex = 151;
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
			this.labelISBN.TabIndex = 150;
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
			this.textBoxOriginalTitle.TabIndex = 149;
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
			this.textBoxBookName.TabIndex = 148;
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
			this.textBoxBookCode.TabIndex = 147;
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
			this.labelOriginalTitle.TabIndex = 146;
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
			this.labelBookName.TabIndex = 145;
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
			this.labelBookCode.TabIndex = 144;
			this.labelBookCode.Text = "Book Code";
			// 
			// dataGridBookCopy
			// 
			this.dataGridBookCopy.DataMember = "";
			this.dataGridBookCopy.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridBookCopy.Location = new System.Drawing.Point(248, 176);
			this.dataGridBookCopy.Name = "dataGridBookCopy";
			this.dataGridBookCopy.ReadOnly = true;
			this.dataGridBookCopy.Size = new System.Drawing.Size(672, 144);
			this.dataGridBookCopy.TabIndex = 152;
			// 
			// textBoxCopyNo
			// 
			this.textBoxCopyNo.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxCopyNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxCopyNo.Location = new System.Drawing.Point(384, 328);
			this.textBoxCopyNo.Name = "textBoxCopyNo";
			this.textBoxCopyNo.ReadOnly = true;
			this.textBoxCopyNo.Size = new System.Drawing.Size(200, 22);
			this.textBoxCopyNo.TabIndex = 1;
			this.textBoxCopyNo.Text = "";
			// 
			// labelCopyNo
			// 
			this.labelCopyNo.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelCopyNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelCopyNo.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelCopyNo.Location = new System.Drawing.Point(256, 328);
			this.labelCopyNo.Name = "labelCopyNo";
			this.labelCopyNo.Size = new System.Drawing.Size(120, 24);
			this.labelCopyNo.TabIndex = 176;
			this.labelCopyNo.Text = "Copy No";
			// 
			// dateTimePickerBroughtDate
			// 
			this.dateTimePickerBroughtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dateTimePickerBroughtDate.Location = new System.Drawing.Point(720, 328);
			this.dateTimePickerBroughtDate.Name = "dateTimePickerBroughtDate";
			this.dateTimePickerBroughtDate.TabIndex = 2;
			// 
			// labelBroughtDate
			// 
			this.labelBroughtDate.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelBroughtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBroughtDate.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelBroughtDate.Location = new System.Drawing.Point(592, 328);
			this.labelBroughtDate.Name = "labelBroughtDate";
			this.labelBroughtDate.Size = new System.Drawing.Size(120, 24);
			this.labelBroughtDate.TabIndex = 178;
			this.labelBroughtDate.Text = "Brought Date";
			// 
			// comboBoxCopyType
			// 
			this.comboBoxCopyType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.comboBoxCopyType.Items.AddRange(new object[] {
																  "",
																  "Original",
																  "Fotocopy"});
			this.comboBoxCopyType.Location = new System.Drawing.Point(384, 360);
			this.comboBoxCopyType.Name = "comboBoxCopyType";
			this.comboBoxCopyType.Size = new System.Drawing.Size(200, 24);
			this.comboBoxCopyType.TabIndex = 3;
			// 
			// labelCopyType
			// 
			this.labelCopyType.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelCopyType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelCopyType.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelCopyType.Location = new System.Drawing.Point(256, 360);
			this.labelCopyType.Name = "labelCopyType";
			this.labelCopyType.Size = new System.Drawing.Size(120, 24);
			this.labelCopyType.TabIndex = 180;
			this.labelCopyType.Text = "Copy Type";
			// 
			// labelCopyStatus
			// 
			this.labelCopyStatus.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelCopyStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelCopyStatus.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelCopyStatus.Location = new System.Drawing.Point(592, 360);
			this.labelCopyStatus.Name = "labelCopyStatus";
			this.labelCopyStatus.Size = new System.Drawing.Size(120, 24);
			this.labelCopyStatus.TabIndex = 182;
			this.labelCopyStatus.Text = "Copy Status";
			// 
			// comboBoxCopyStatus
			// 
			this.comboBoxCopyStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.comboBoxCopyStatus.Items.AddRange(new object[] {
																	"",
																	"Available",
																	"Out",
																	"Broken",
																	"Lost"});
			this.comboBoxCopyStatus.Location = new System.Drawing.Point(720, 360);
			this.comboBoxCopyStatus.Name = "comboBoxCopyStatus";
			this.comboBoxCopyStatus.Size = new System.Drawing.Size(200, 24);
			this.comboBoxCopyStatus.TabIndex = 4;
			// 
			// textBoxShelfCode
			// 
			this.textBoxShelfCode.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxShelfCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxShelfCode.Location = new System.Drawing.Point(384, 392);
			this.textBoxShelfCode.Name = "textBoxShelfCode";
			this.textBoxShelfCode.ReadOnly = true;
			this.textBoxShelfCode.Size = new System.Drawing.Size(200, 22);
			this.textBoxShelfCode.TabIndex = 5;
			this.textBoxShelfCode.Text = "";
			// 
			// labelShelfCode
			// 
			this.labelShelfCode.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelShelfCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelShelfCode.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelShelfCode.Location = new System.Drawing.Point(256, 392);
			this.labelShelfCode.Name = "labelShelfCode";
			this.labelShelfCode.Size = new System.Drawing.Size(120, 24);
			this.labelShelfCode.TabIndex = 184;
			this.labelShelfCode.Text = "Shelf Code";
			// 
			// textBoxStoreCode
			// 
			this.textBoxStoreCode.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxStoreCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxStoreCode.Location = new System.Drawing.Point(720, 392);
			this.textBoxStoreCode.Name = "textBoxStoreCode";
			this.textBoxStoreCode.ReadOnly = true;
			this.textBoxStoreCode.Size = new System.Drawing.Size(200, 22);
			this.textBoxStoreCode.TabIndex = 6;
			this.textBoxStoreCode.Text = "";
			// 
			// labelStoreCode
			// 
			this.labelStoreCode.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelStoreCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelStoreCode.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelStoreCode.Location = new System.Drawing.Point(592, 392);
			this.labelStoreCode.Name = "labelStoreCode";
			this.labelStoreCode.Size = new System.Drawing.Size(120, 24);
			this.labelStoreCode.TabIndex = 186;
			this.labelStoreCode.Text = "Store Code";
			// 
			// textBoxCurrRate
			// 
			this.textBoxCurrRate.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxCurrRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxCurrRate.Location = new System.Drawing.Point(720, 424);
			this.textBoxCurrRate.Name = "textBoxCurrRate";
			this.textBoxCurrRate.ReadOnly = true;
			this.textBoxCurrRate.Size = new System.Drawing.Size(200, 22);
			this.textBoxCurrRate.TabIndex = 8;
			this.textBoxCurrRate.Text = "";
			// 
			// labelCurrRate
			// 
			this.labelCurrRate.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelCurrRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelCurrRate.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelCurrRate.Location = new System.Drawing.Point(592, 424);
			this.labelCurrRate.Name = "labelCurrRate";
			this.labelCurrRate.Size = new System.Drawing.Size(120, 24);
			this.labelCurrRate.TabIndex = 190;
			this.labelCurrRate.Text = "Curr Rate";
			// 
			// textBoxCurr
			// 
			this.textBoxCurr.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxCurr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxCurr.Location = new System.Drawing.Point(384, 424);
			this.textBoxCurr.Name = "textBoxCurr";
			this.textBoxCurr.ReadOnly = true;
			this.textBoxCurr.Size = new System.Drawing.Size(200, 22);
			this.textBoxCurr.TabIndex = 7;
			this.textBoxCurr.Text = "";
			// 
			// labelCurr
			// 
			this.labelCurr.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelCurr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelCurr.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelCurr.Location = new System.Drawing.Point(256, 424);
			this.labelCurr.Name = "labelCurr";
			this.labelCurr.Size = new System.Drawing.Size(120, 24);
			this.labelCurr.TabIndex = 188;
			this.labelCurr.Text = "Curr";
			// 
			// textBoxStatusDesc
			// 
			this.textBoxStatusDesc.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxStatusDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxStatusDesc.Location = new System.Drawing.Point(384, 488);
			this.textBoxStatusDesc.Name = "textBoxStatusDesc";
			this.textBoxStatusDesc.ReadOnly = true;
			this.textBoxStatusDesc.Size = new System.Drawing.Size(536, 22);
			this.textBoxStatusDesc.TabIndex = 11;
			this.textBoxStatusDesc.Text = "";
			// 
			// labelBookDesc
			// 
			this.labelBookDesc.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelBookDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBookDesc.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelBookDesc.Location = new System.Drawing.Point(256, 488);
			this.labelBookDesc.Name = "labelBookDesc";
			this.labelBookDesc.Size = new System.Drawing.Size(120, 24);
			this.labelBookDesc.TabIndex = 194;
			this.labelBookDesc.Text = "Status Desc";
			// 
			// textBoxPrice
			// 
			this.textBoxPrice.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxPrice.Location = new System.Drawing.Point(384, 456);
			this.textBoxPrice.Name = "textBoxPrice";
			this.textBoxPrice.ReadOnly = true;
			this.textBoxPrice.Size = new System.Drawing.Size(200, 22);
			this.textBoxPrice.TabIndex = 9;
			this.textBoxPrice.Text = "";
			// 
			// labelPrice
			// 
			this.labelPrice.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelPrice.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelPrice.Location = new System.Drawing.Point(256, 456);
			this.labelPrice.Name = "labelPrice";
			this.labelPrice.Size = new System.Drawing.Size(120, 24);
			this.labelPrice.TabIndex = 192;
			this.labelPrice.Text = "Price";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label2.Location = new System.Drawing.Point(592, 456);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 24);
			this.label2.TabIndex = 196;
			this.label2.Text = "Book Status";
			// 
			// comboBoxBookStatus
			// 
			this.comboBoxBookStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.comboBoxBookStatus.Items.AddRange(new object[] {
																	"",
																	"Allowed",
																	"Not Allowed"});
			this.comboBoxBookStatus.Location = new System.Drawing.Point(720, 456);
			this.comboBoxBookStatus.Name = "comboBoxBookStatus";
			this.comboBoxBookStatus.Size = new System.Drawing.Size(200, 24);
			this.comboBoxBookStatus.TabIndex = 10;
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
			this.buttonSave.TabIndex = 15;
			this.buttonSave.Text = "Save";
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
			this.buttonCancel.TabIndex = 16;
			this.buttonCancel.Text = "Cancel";
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
			this.buttonDelete.TabIndex = 14;
			this.buttonDelete.Text = "Delete";
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
			this.buttonEdit.TabIndex = 13;
			this.buttonEdit.Text = "Edit";
			// 
			// buttonAdd
			// 
			this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonAdd.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonAdd.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd.Image")));
			this.buttonAdd.Location = new System.Drawing.Point(248, 520);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(88, 32);
			this.buttonAdd.TabIndex = 12;
			this.buttonAdd.Text = "Add New";
			// 
			// FrmBookMsCopy2
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonEdit);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.comboBoxBookStatus);
			this.Controls.Add(this.textBoxStatusDesc);
			this.Controls.Add(this.labelBookDesc);
			this.Controls.Add(this.textBoxPrice);
			this.Controls.Add(this.labelPrice);
			this.Controls.Add(this.textBoxCurrRate);
			this.Controls.Add(this.labelCurrRate);
			this.Controls.Add(this.textBoxCurr);
			this.Controls.Add(this.labelCurr);
			this.Controls.Add(this.textBoxStoreCode);
			this.Controls.Add(this.labelStoreCode);
			this.Controls.Add(this.textBoxShelfCode);
			this.Controls.Add(this.labelShelfCode);
			this.Controls.Add(this.labelCopyStatus);
			this.Controls.Add(this.comboBoxCopyStatus);
			this.Controls.Add(this.labelCopyType);
			this.Controls.Add(this.comboBoxCopyType);
			this.Controls.Add(this.labelBroughtDate);
			this.Controls.Add(this.dateTimePickerBroughtDate);
			this.Controls.Add(this.textBoxCopyNo);
			this.Controls.Add(this.labelCopyNo);
			this.Controls.Add(this.dataGridBookCopy);
			this.Controls.Add(this.textBoxISBN);
			this.Controls.Add(this.labelISBN);
			this.Controls.Add(this.textBoxOriginalTitle);
			this.Controls.Add(this.textBoxBookName);
			this.Controls.Add(this.textBoxBookCode);
			this.Controls.Add(this.labelOriginalTitle);
			this.Controls.Add(this.labelBookName);
			this.Controls.Add(this.labelBookCode);
			this.Controls.Add(this.LabelTitle);
			this.Name = "FrmBookMsCopy2";
			this.Controls.SetChildIndex(this.LabelTitle, 0);
			this.Controls.SetChildIndex(this.labelBookCode, 0);
			this.Controls.SetChildIndex(this.labelBookName, 0);
			this.Controls.SetChildIndex(this.labelOriginalTitle, 0);
			this.Controls.SetChildIndex(this.textBoxBookCode, 0);
			this.Controls.SetChildIndex(this.textBoxBookName, 0);
			this.Controls.SetChildIndex(this.textBoxOriginalTitle, 0);
			this.Controls.SetChildIndex(this.labelISBN, 0);
			this.Controls.SetChildIndex(this.textBoxISBN, 0);
			this.Controls.SetChildIndex(this.dataGridBookCopy, 0);
			this.Controls.SetChildIndex(this.labelCopyNo, 0);
			this.Controls.SetChildIndex(this.textBoxCopyNo, 0);
			this.Controls.SetChildIndex(this.dateTimePickerBroughtDate, 0);
			this.Controls.SetChildIndex(this.labelBroughtDate, 0);
			this.Controls.SetChildIndex(this.comboBoxCopyType, 0);
			this.Controls.SetChildIndex(this.labelCopyType, 0);
			this.Controls.SetChildIndex(this.comboBoxCopyStatus, 0);
			this.Controls.SetChildIndex(this.labelCopyStatus, 0);
			this.Controls.SetChildIndex(this.labelShelfCode, 0);
			this.Controls.SetChildIndex(this.textBoxShelfCode, 0);
			this.Controls.SetChildIndex(this.labelStoreCode, 0);
			this.Controls.SetChildIndex(this.textBoxStoreCode, 0);
			this.Controls.SetChildIndex(this.labelCurr, 0);
			this.Controls.SetChildIndex(this.textBoxCurr, 0);
			this.Controls.SetChildIndex(this.labelCurrRate, 0);
			this.Controls.SetChildIndex(this.textBoxCurrRate, 0);
			this.Controls.SetChildIndex(this.labelPrice, 0);
			this.Controls.SetChildIndex(this.textBoxPrice, 0);
			this.Controls.SetChildIndex(this.labelBookDesc, 0);
			this.Controls.SetChildIndex(this.textBoxStatusDesc, 0);
			this.Controls.SetChildIndex(this.comboBoxBookStatus, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.buttonAdd, 0);
			this.Controls.SetChildIndex(this.buttonEdit, 0);
			this.Controls.SetChildIndex(this.buttonDelete, 0);
			this.Controls.SetChildIndex(this.buttonCancel, 0);
			this.Controls.SetChildIndex(this.buttonSave, 0);
			((System.ComponentModel.ISupportInitialize)(this.dataGridBookCopy)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
	}
}

