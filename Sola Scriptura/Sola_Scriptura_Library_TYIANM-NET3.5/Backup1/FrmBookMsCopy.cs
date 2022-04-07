using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace Sola_Scriptura_Library
{
	public class FrmBookMsCopy : Sola_Scriptura_Library.FrmBookMaster
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
		private System.ComponentModel.IContainer components = null;
		internal System.Windows.Forms.Button buttonSave;
		internal System.Windows.Forms.Button buttonCancel;
		internal System.Windows.Forms.Button buttonDelete;
		internal System.Windows.Forms.Button buttonEdit;
		internal System.Windows.Forms.Button buttonAdd;

		internal ClassDatabase MyClassDatabase;
		internal DataTable MyDataTable;
		internal DataTable MyBookCopyDataTable;
		internal System.Windows.Forms.DateTimePicker dateTimePickerBoughtDate;
		internal BookExemplar MyBookExemplar;
		internal System.Windows.Forms.DataGridTableStyle dataGridTableStyleBookCopy;
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
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnUpdateUser;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnUpdateDate;
		internal System.Windows.Forms.Label labelBoughtDate;
		internal System.Windows.Forms.Button buttonPrint;
		internal FrmSearchMiniForm MySearchMiniForm;
		internal FrmCrystalReport MyCrystalReportForm;
		internal DataTable MyDataTableReport;
		public FrmBookMsCopy()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public FrmBookMsCopy(FrmMDI MDIForm, FrmBookMenu BookMenuForm)
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmBookMsCopy));
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
			this.dataGridTableStyleBookCopy = new System.Windows.Forms.DataGridTableStyle();
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
			this.dataGridTextBoxColumnUpdateUser = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnUpdateDate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.textBoxCopyNo = new System.Windows.Forms.TextBox();
			this.labelCopyNo = new System.Windows.Forms.Label();
			this.dateTimePickerBoughtDate = new System.Windows.Forms.DateTimePicker();
			this.labelBoughtDate = new System.Windows.Forms.Label();
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
			this.buttonPrint = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridBookCopy)).BeginInit();
			this.SuspendLayout();
			// 
			// LabelTitle
			// 
			this.LabelTitle.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.LabelTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
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
			this.dataGridBookCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGridBookCopy.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridBookCopy.Location = new System.Drawing.Point(248, 176);
			this.dataGridBookCopy.Name = "dataGridBookCopy";
			this.dataGridBookCopy.ReadOnly = true;
			this.dataGridBookCopy.Size = new System.Drawing.Size(672, 144);
			this.dataGridBookCopy.TabIndex = 152;
			this.dataGridBookCopy.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																										 this.dataGridTableStyleBookCopy});
			// 
			// dataGridTableStyleBookCopy
			// 
			this.dataGridTableStyleBookCopy.AlternatingBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleBookCopy.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.dataGridTableStyleBookCopy.DataGrid = this.dataGridBookCopy;
			this.dataGridTableStyleBookCopy.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleBookCopy.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
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
																														 this.dataGridTextBoxColumnMemberID,
																														 this.dataGridTextBoxColumnUpdateUser,
																														 this.dataGridTextBoxColumnUpdateDate});
			this.dataGridTableStyleBookCopy.GridLineColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridTableStyleBookCopy.HeaderBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleBookCopy.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleBookCopy.MappingName = "BookCopyData";
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
			this.dataGridTextBoxColumnShelfCode.HeaderText = "Shelf Code";
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
			this.dataGridTextBoxColumnStoreCode.HeaderText = "Store Code";
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
			this.dataGridTextBoxColumnBookStatus.MappingName = "BookStatusDesc";
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
			// textBoxCopyNo
			// 
			this.textBoxCopyNo.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxCopyNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxCopyNo.Location = new System.Drawing.Point(384, 328);
			this.textBoxCopyNo.Name = "textBoxCopyNo";
			this.textBoxCopyNo.Size = new System.Drawing.Size(200, 22);
			this.textBoxCopyNo.TabIndex = 1;
			this.textBoxCopyNo.Text = "";
			this.textBoxCopyNo.TextChanged += new System.EventHandler(this.textBoxCopyNo_TextChanged);
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
			// dateTimePickerBoughtDate
			// 
			this.dateTimePickerBoughtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dateTimePickerBoughtDate.Location = new System.Drawing.Point(720, 328);
			this.dateTimePickerBoughtDate.Name = "dateTimePickerBoughtDate";
			this.dateTimePickerBoughtDate.TabIndex = 2;
			this.dateTimePickerBoughtDate.ValueChanged += new System.EventHandler(this.dateTimePickerBoughtDate_ValueChanged);
			// 
			// labelBoughtDate
			// 
			this.labelBoughtDate.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelBoughtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBoughtDate.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelBoughtDate.Location = new System.Drawing.Point(592, 328);
			this.labelBoughtDate.Name = "labelBoughtDate";
			this.labelBoughtDate.Size = new System.Drawing.Size(120, 24);
			this.labelBoughtDate.TabIndex = 178;
			this.labelBoughtDate.Text = "Bought Date";
			// 
			// comboBoxCopyType
			// 
			this.comboBoxCopyType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.comboBoxCopyType.Items.AddRange(new object[] {
																  "Original",
																  "Fotocopy"});
			this.comboBoxCopyType.Location = new System.Drawing.Point(384, 360);
			this.comboBoxCopyType.Name = "comboBoxCopyType";
			this.comboBoxCopyType.Size = new System.Drawing.Size(200, 24);
			this.comboBoxCopyType.TabIndex = 3;
			this.comboBoxCopyType.TextChanged += new System.EventHandler(this.comboBoxCopyType_SelectedIndexChanged);
			this.comboBoxCopyType.SelectedIndexChanged += new System.EventHandler(this.comboBoxCopyType_SelectedIndexChanged);
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
																	"Available",
																	"Out",
																	"Broken",
																	"Lost"});
			this.comboBoxCopyStatus.Location = new System.Drawing.Point(720, 360);
			this.comboBoxCopyStatus.Name = "comboBoxCopyStatus";
			this.comboBoxCopyStatus.Size = new System.Drawing.Size(200, 24);
			this.comboBoxCopyStatus.TabIndex = 4;
			this.comboBoxCopyStatus.TextChanged += new System.EventHandler(this.comboBoxCopyStatus_SelectedIndexChanged);
			this.comboBoxCopyStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxCopyStatus_SelectedIndexChanged);
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
			this.textBoxShelfCode.TextChanged += new System.EventHandler(this.textBoxShelfCode_TextChanged);
			this.textBoxShelfCode.Click += new System.EventHandler(this.textBoxShelfCode_Clicked);
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
			this.textBoxStoreCode.TextChanged += new System.EventHandler(this.textBoxStoreCode_TextChanged);
			this.textBoxStoreCode.Click += new System.EventHandler(this.textBoxStoreCode_Clicked);
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
			this.textBoxCurrRate.Size = new System.Drawing.Size(200, 22);
			this.textBoxCurrRate.TabIndex = 8;
			this.textBoxCurrRate.Text = "";
			this.textBoxCurrRate.TextChanged += new System.EventHandler(this.textBoxCurrRate_TextChanged);
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
			this.textBoxCurr.TextChanged += new System.EventHandler(this.textBoxCurr_TextChanged);
			this.textBoxCurr.Click += new System.EventHandler(this.textBoxCurr_Clicked);
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
			this.textBoxStatusDesc.Size = new System.Drawing.Size(536, 22);
			this.textBoxStatusDesc.TabIndex = 11;
			this.textBoxStatusDesc.Text = "";
			this.textBoxStatusDesc.TextChanged += new System.EventHandler(this.textBoxStatusDesc_TextChanged);
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
			this.textBoxPrice.Size = new System.Drawing.Size(200, 22);
			this.textBoxPrice.TabIndex = 9;
			this.textBoxPrice.Text = "";
			this.textBoxPrice.TextChanged += new System.EventHandler(this.textBoxPrice_TextChanged);
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
																	"Allowed",
																	"Not Allowed"});
			this.comboBoxBookStatus.Location = new System.Drawing.Point(720, 456);
			this.comboBoxBookStatus.Name = "comboBoxBookStatus";
			this.comboBoxBookStatus.Size = new System.Drawing.Size(200, 24);
			this.comboBoxBookStatus.TabIndex = 10;
			this.comboBoxBookStatus.TextChanged += new System.EventHandler(this.comboBoxBookStatus_SelectedIndexChanged);
			this.comboBoxBookStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxBookStatus_SelectedIndexChanged);
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
			this.buttonSave.TabIndex = 200;
			this.buttonSave.Text = "Save";
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
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
			this.buttonCancel.TabIndex = 201;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
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
			this.buttonDelete.TabIndex = 199;
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
			this.buttonEdit.TabIndex = 198;
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
			this.buttonAdd.TabIndex = 197;
			this.buttonAdd.Text = "Add New";
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// buttonPrint
			// 
			this.buttonPrint.Enabled = false;
			this.buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonPrint.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonPrint.Image = ((System.Drawing.Image)(resources.GetObject("buttonPrint.Image")));
			this.buttonPrint.Location = new System.Drawing.Point(928, 288);
			this.buttonPrint.Name = "buttonPrint";
			this.buttonPrint.Size = new System.Drawing.Size(54, 32);
			this.buttonPrint.TabIndex = 202;
			this.buttonPrint.Text = "Print";
			this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
			// 
			// FrmBookMsCopy
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.buttonPrint);
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
			this.Controls.Add(this.labelBoughtDate);
			this.Controls.Add(this.dateTimePickerBoughtDate);
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
			this.Name = "FrmBookMsCopy";
			this.Load += new System.EventHandler(this.FrmBookMsCopy_Load);
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
			this.Controls.SetChildIndex(this.dateTimePickerBoughtDate, 0);
			this.Controls.SetChildIndex(this.labelBoughtDate, 0);
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
			this.Controls.SetChildIndex(this.buttonPrint, 0);
			((System.ComponentModel.ISupportInitialize)(this.dataGridBookCopy)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void FrmBookMsCopy_Load(object sender, System.EventArgs e)
		{
			MyBookExemplar = new BookExemplar();
			MyBookExemplar.BoughtDate  = dateTimePickerBoughtDate.Value.ToShortDateString();

			if(MyBookMenuForm.MyBookSearch.BookCode.ToString() != "")
			{
				MyClassDatabase = new ClassDatabase();
				MyDataTable = MyClassDatabase.GetBookData(MyBookMenuForm.MyBookSearch.BookCode.ToString());
				textBoxBookCode.Text = MyDataTable.Rows[0]["BookCode"].ToString().Trim();
				textBoxBookName.Text = MyDataTable.Rows[0]["BookName"].ToString().Trim();
				textBoxOriginalTitle.Text = MyDataTable.Rows[0]["OriginalTitle"].ToString().Trim();;
				textBoxISBN.Text = (MyDataTable.Rows[0]["ISBN"].ToString().Trim());
				MyClassDatabase = new ClassDatabase();
				MyBookCopyDataTable = MyClassDatabase.GetBookCopyData(textBoxBookCode.Text.ToString());
				dataGridBookCopy.DataSource = MyBookCopyDataTable;

				MyBookExemplar.BookCode = textBoxBookCode.Text.ToString();
				RefreshButton();
			}
		}

		private void textBoxCopyNo_TextChanged(object sender, System.EventArgs e)
		{
			MyBookExemplar.CopyNo = textBoxCopyNo.Text.ToString();
		}

		private void dateTimePickerBoughtDate_ValueChanged(object sender, System.EventArgs e)
		{
			MyBookExemplar.BoughtDate = dateTimePickerBoughtDate.Value.ToShortDateString();
		}

		private void comboBoxCopyType_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(comboBoxCopyType.Text.ToString() == "Original")
				MyBookExemplar.CopyType = "1";
			else if(comboBoxCopyType.Text.ToString() == "Fotocopy")
				MyBookExemplar.CopyType = "2";
		}

		private void comboBoxCopyStatus_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(comboBoxCopyStatus.Text.ToString() == "Available")
				MyBookExemplar.CopyStatus = "1";
			else if(comboBoxCopyStatus.Text.ToString() == "Out")
				MyBookExemplar.CopyStatus = "2";
			else if(comboBoxCopyStatus.Text.ToString() == "Broken")
				MyBookExemplar.CopyStatus = "3";
			else if(comboBoxCopyStatus.Text.ToString() == "Lost")
				MyBookExemplar.CopyStatus = "4";
			
		}

		private void textBoxShelfCode_TextChanged(object sender, System.EventArgs e)
		{
			MyBookExemplar.ShelfCode = textBoxShelfCode.Text.ToString();
		}
		private void textBoxShelfCode_Clicked(object sender, System.EventArgs e)
		{
			MySearchMiniForm = new FrmSearchMiniForm(this,"ShelfCode");
			MySearchMiniForm.Show();
		}
		private void textBoxStoreCode_TextChanged(object sender, System.EventArgs e)
		{
			MyBookExemplar.StoreCode = textBoxStoreCode.Text.ToString();
		}
		private void textBoxStoreCode_Clicked(object sender, System.EventArgs e)
		{
			MySearchMiniForm = new FrmSearchMiniForm(this,"StoreCode");
			MySearchMiniForm.Show();
		}
		private void textBoxCurr_TextChanged(object sender, System.EventArgs e)
		{
			MyBookExemplar.Curr = textBoxCurr.Text.ToString();
		}
		private void textBoxCurr_Clicked(object sender, System.EventArgs e)
		{
			MySearchMiniForm = new FrmSearchMiniForm(this,"Currency");
			MySearchMiniForm.Show();
		}
		private void textBoxCurrRate_TextChanged(object sender, System.EventArgs e)
		{
			MyBookExemplar.CurrRate = textBoxCurrRate.Text.ToString();
			if(textBoxCurrRate.Text.ToString() == "") MyBookExemplar.CurrRate = "0";
		}

		private void textBoxPrice_TextChanged(object sender, System.EventArgs e)
		{
			MyBookExemplar.Price = textBoxPrice.Text.ToString();
			if(textBoxPrice.Text.ToString() == "") MyBookExemplar.Price = "0";
		}

		private void comboBoxBookStatus_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(comboBoxBookStatus.Text.ToString() == "Allowed")
				MyBookExemplar.BookStatus = "1";
			else if(comboBoxBookStatus.Text.ToString() == "Not Allowed")
				MyBookExemplar.BookStatus = "2";
		}

		private void textBoxStatusDesc_TextChanged(object sender, System.EventArgs e)
		{
			MyBookExemplar.StatusDesc = textBoxStatusDesc.Text.ToString();
		}

		internal void DoLock()
		{
			buttonAdd.Enabled = true;
			buttonSave.Enabled = false;
			buttonCancel.Enabled = false;
			textBoxCopyNo.Text = "";
			
			comboBoxCopyType.SelectedIndex = -1;
			comboBoxCopyStatus.SelectedIndex = -1;
			textBoxShelfCode.Text = "";
			textBoxStoreCode.Text = "";
			textBoxCurr.Text = "";
			textBoxCurrRate.Text = "";
			textBoxPrice.Text = "";
			comboBoxBookStatus.SelectedIndex = -1;
			textBoxStatusDesc.Text = "";
			MyBookExemplar.PreviousCopyNo = "";
			MyClassDatabase = new ClassDatabase();
			MyBookCopyDataTable = MyClassDatabase.GetBookCopyData(textBoxBookCode.Text.ToString());
			dataGridBookCopy.DataSource = MyBookCopyDataTable;

			RefreshButton();


		}
		private void DoUnlock()
		{
			textBoxCopyNo.Focus();
			buttonAdd.Enabled = false;
			buttonEdit.Enabled = false;
			buttonDelete.Enabled = false;
			buttonSave.Enabled = true;
			buttonCancel.Enabled = true;
		}
		internal void RefreshButton()
		{
			if(MyBookCopyDataTable.Rows.Count>0)
			{
				buttonEdit.Enabled = true;
				buttonDelete.Enabled = true;
				buttonPrint.Enabled = true;
			}
			else
			{
				buttonEdit.Enabled = false;
				buttonDelete.Enabled = false;
				buttonPrint.Enabled = false;
			}
		}

		private void buttonAdd_Click(object sender, System.EventArgs e)
		{
			DoUnlock();
			textBoxPrice.Text = "0";
			textBoxCurrRate.Text = "0";
			comboBoxCopyType.Text = "Original";
			comboBoxBookStatus.Text = "Allowed";
			MyBookExemplar.CopyType = "1";
			MyBookExemplar.BookStatus = "1";
			comboBoxCopyStatus.SelectedIndex = 0;
		}
		private void buttonEdit_Click(object sender, System.EventArgs e)
		{
			MyBookExemplar.BoughtDate  = dateTimePickerBoughtDate.Value.ToString();
			DoUnlock();
			textBoxCopyNo.Text = dataGridBookCopy[dataGridBookCopy.CurrentRowIndex,0].ToString().Trim();
			dateTimePickerBoughtDate.Text = dataGridBookCopy[dataGridBookCopy.CurrentRowIndex,1].ToString().Trim();
			comboBoxCopyType.Text = dataGridBookCopy[dataGridBookCopy.CurrentRowIndex,2].ToString().Trim();
			comboBoxCopyStatus.Text = dataGridBookCopy[dataGridBookCopy.CurrentRowIndex,3].ToString().Trim();
			textBoxShelfCode.Text = dataGridBookCopy[dataGridBookCopy.CurrentRowIndex,4].ToString().Trim();
			textBoxStoreCode.Text = dataGridBookCopy[dataGridBookCopy.CurrentRowIndex,6].ToString().Trim();
			textBoxCurr.Text = dataGridBookCopy[dataGridBookCopy.CurrentRowIndex,8].ToString().Trim();
			textBoxCurrRate.Text = dataGridBookCopy[dataGridBookCopy.CurrentRowIndex,9].ToString().Trim();
			textBoxPrice.Text = dataGridBookCopy[dataGridBookCopy.CurrentRowIndex,10].ToString().Trim();
			comboBoxBookStatus.Text = dataGridBookCopy[dataGridBookCopy.CurrentRowIndex,11].ToString().Trim();
			textBoxStatusDesc.Text = dataGridBookCopy[dataGridBookCopy.CurrentRowIndex,12].ToString().Trim();
			MyBookExemplar.PreviousCopyNo = dataGridBookCopy[dataGridBookCopy.CurrentRowIndex,0].ToString().Trim();
		}
		private void buttonDelete_Click(object sender, System.EventArgs e)
		{
			DialogResult ans;
			ans = MessageBox.Show("Are you sure you want to delete Book Copy Data with Copy No ='" + dataGridBookCopy[dataGridBookCopy.CurrentRowIndex,0].ToString().Trim() + "' ?" , "Confirmation", MessageBoxButtons.YesNo );
			if (ans.ToString() == "Yes")
			{	
				MyClassDatabase = new ClassDatabase();
				MyClassDatabase.DeleteBookCopy(textBoxBookCode.Text.ToString(), dataGridBookCopy[dataGridBookCopy.CurrentRowIndex,0].ToString().Trim());

			
			}
			DoLock();
		}

		private void buttonSave_Click(object sender, System.EventArgs e)
		{
			if((IsNumeric(MyBookExemplar.Price.ToString())== true||MyBookExemplar.Price.ToString()=="")&&(IsNumeric(MyBookExemplar.CurrRate.ToString())==true)||MyBookExemplar.CurrRate.ToString()=="")
			{
				MyBookExemplar.UpdateUser = MyMDIForm.LibrarianUserName.ToString();
				MyClassDatabase = new ClassDatabase();
				MyClassDatabase.SaveBookCopy(MyBookExemplar);

				DoLock();
			}
			else
			{
				MessageBox.Show("Please Enter the Numeric Value in Price or Curr Rate !", "Requirement");
			}
		}
		private void buttonCancel_Click(object sender, System.EventArgs e)
		{
			DoLock();


		}
		static bool IsNumeric(string Expression)
		{
			bool isNum;
			double retNum;
			isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum );
			return isNum;
		}

		private void buttonPrint_Click(object sender, System.EventArgs e)
		{
			MyClassDatabase = new ClassDatabase();
			MyCrystalReportForm = new FrmCrystalReport();
			MyCrystalReportForm.Show();
			MyDataTableReport = MyClassDatabase.GetBookReport(textBoxBookCode.Text.ToString(), dataGridBookCopy[dataGridBookCopy.CurrentRowIndex,0].ToString().Trim());
			CrystalReportBook MyCrystalReportBook = new CrystalReportBook();
			MyCrystalReportBook.SetDataSource(MyDataTableReport);
			MyCrystalReportForm.crystalReportViewer1.ReportSource = MyCrystalReportBook;
			
		}
	}
}

