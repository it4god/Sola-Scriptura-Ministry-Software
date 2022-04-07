using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace Sola_Scriptura_Library
{
	public class FrmBookHistory : Sola_Scriptura_Library.FrmFormParent
	{
		internal System.Windows.Forms.PictureBox pictureBoxLogoPicture;
		internal System.Windows.Forms.Button buttonClear;
		internal System.Windows.Forms.Button buttonRefresh;
		internal System.Windows.Forms.TextBox textBoxBookCode;
		internal System.Windows.Forms.Label labelBookCode;
		internal System.Windows.Forms.TextBox textBoxMemberID;
		internal System.Windows.Forms.TextBox textBoxBookName;
		internal System.Windows.Forms.Label labelBookName;
		internal System.Windows.Forms.Label label2;
		internal System.Windows.Forms.TextBox textBoxMemberName;
		internal System.Windows.Forms.Label labelMemberName;
		internal System.Windows.Forms.Label labelFromDate;
		internal System.Windows.Forms.DateTimePicker dateTimePickerFromDate;
		internal System.Windows.Forms.Label labelToDate;
		internal System.Windows.Forms.DateTimePicker dateTimePickerToDate;
		internal System.Windows.Forms.DataGrid dataGridBookHistory;
		internal System.Windows.Forms.DataGridTableStyle dataGridTableStyleBookHistory;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnBorrowDate;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnReturnDate;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnActualReturnDate;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnBorrowSeq;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnBookCode;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnBookName;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnCopyNo;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnMemberID;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnMemberName;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnFine;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnLibrarianBorrow;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnLibrarianReturn;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnUpdateUser;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnUpdateDate;
		private System.ComponentModel.IContainer components = null;

		internal ClassDatabase MyClassDatabase;
		internal DataTable MyDataTable;
		internal string MyProfit;
		internal DataView MyDataView;
		internal System.Windows.Forms.Label LabelTitle;
		internal System.Windows.Forms.Button buttonNow;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnCurrRate;
		internal FrmSearchMiniForm MySearchMiniForm;

		public FrmBookHistory()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmBookHistory));
			this.pictureBoxLogoPicture = new System.Windows.Forms.PictureBox();
			this.buttonClear = new System.Windows.Forms.Button();
			this.buttonRefresh = new System.Windows.Forms.Button();
			this.textBoxBookCode = new System.Windows.Forms.TextBox();
			this.labelBookCode = new System.Windows.Forms.Label();
			this.textBoxMemberID = new System.Windows.Forms.TextBox();
			this.textBoxBookName = new System.Windows.Forms.TextBox();
			this.labelBookName = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridBookHistory = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyleBookHistory = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnBorrowDate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnReturnDate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnActualReturnDate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnBorrowSeq = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnBookCode = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnBookName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnCopyNo = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnMemberID = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnMemberName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnCurrRate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnFine = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnLibrarianBorrow = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnLibrarianReturn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnUpdateUser = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnUpdateDate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.textBoxMemberName = new System.Windows.Forms.TextBox();
			this.labelMemberName = new System.Windows.Forms.Label();
			this.labelFromDate = new System.Windows.Forms.Label();
			this.dateTimePickerFromDate = new System.Windows.Forms.DateTimePicker();
			this.labelToDate = new System.Windows.Forms.Label();
			this.dateTimePickerToDate = new System.Windows.Forms.DateTimePicker();
			this.LabelTitle = new System.Windows.Forms.Label();
			this.buttonNow = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridBookHistory)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxLogoPicture
			// 
			this.pictureBoxLogoPicture.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogoPicture.Image")));
			this.pictureBoxLogoPicture.Location = new System.Drawing.Point(32, 72);
			this.pictureBoxLogoPicture.Name = "pictureBoxLogoPicture";
			this.pictureBoxLogoPicture.Size = new System.Drawing.Size(144, 88);
			this.pictureBoxLogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxLogoPicture.TabIndex = 228;
			this.pictureBoxLogoPicture.TabStop = false;
			// 
			// buttonClear
			// 
			this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonClear.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonClear.Image = ((System.Drawing.Image)(resources.GetObject("buttonClear.Image")));
			this.buttonClear.Location = new System.Drawing.Point(728, 176);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(88, 32);
			this.buttonClear.TabIndex = 7;
			this.buttonClear.Text = "Clear";
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// buttonRefresh
			// 
			this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonRefresh.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("buttonRefresh.Image")));
			this.buttonRefresh.Location = new System.Drawing.Point(832, 176);
			this.buttonRefresh.Name = "buttonRefresh";
			this.buttonRefresh.Size = new System.Drawing.Size(88, 32);
			this.buttonRefresh.TabIndex = 8;
			this.buttonRefresh.Text = "Refresh";
			this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
			// 
			// textBoxBookCode
			// 
			this.textBoxBookCode.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxBookCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxBookCode.ForeColor = System.Drawing.SystemColors.WindowText;
			this.textBoxBookCode.Location = new System.Drawing.Point(384, 144);
			this.textBoxBookCode.Name = "textBoxBookCode";
			this.textBoxBookCode.Size = new System.Drawing.Size(200, 22);
			this.textBoxBookCode.TabIndex = 4;
			this.textBoxBookCode.Text = "";
			this.textBoxBookCode.TextChanged += new System.EventHandler(this.textBoxBookCode_TextChanged);
			// 
			// labelBookCode
			// 
			this.labelBookCode.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelBookCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBookCode.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelBookCode.Location = new System.Drawing.Point(256, 144);
			this.labelBookCode.Name = "labelBookCode";
			this.labelBookCode.Size = new System.Drawing.Size(120, 24);
			this.labelBookCode.TabIndex = 225;
			this.labelBookCode.Text = "Book Code";
			// 
			// textBoxMemberID
			// 
			this.textBoxMemberID.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxMemberID.ForeColor = System.Drawing.SystemColors.WindowText;
			this.textBoxMemberID.Location = new System.Drawing.Point(384, 112);
			this.textBoxMemberID.Name = "textBoxMemberID";
			this.textBoxMemberID.ReadOnly = true;
			this.textBoxMemberID.Size = new System.Drawing.Size(200, 22);
			this.textBoxMemberID.TabIndex = 3;
			this.textBoxMemberID.Text = "";
			this.textBoxMemberID.TextChanged += new System.EventHandler(this.textBoxMemberID_TextChanged);
			this.textBoxMemberID.Click += new System.EventHandler(this.textBoxMemberID_Clicked);
			// 
			// textBoxBookName
			// 
			this.textBoxBookName.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxBookName.ForeColor = System.Drawing.SystemColors.WindowText;
			this.textBoxBookName.Location = new System.Drawing.Point(720, 144);
			this.textBoxBookName.Name = "textBoxBookName";
			this.textBoxBookName.Size = new System.Drawing.Size(200, 22);
			this.textBoxBookName.TabIndex = 5;
			this.textBoxBookName.Text = "";
			this.textBoxBookName.TextChanged += new System.EventHandler(this.textBoxBookName_TextChanged);
			// 
			// labelBookName
			// 
			this.labelBookName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBookName.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelBookName.Location = new System.Drawing.Point(592, 144);
			this.labelBookName.Name = "labelBookName";
			this.labelBookName.Size = new System.Drawing.Size(120, 24);
			this.labelBookName.TabIndex = 224;
			this.labelBookName.Text = "Book Name";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label2.Location = new System.Drawing.Point(256, 112);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 24);
			this.label2.TabIndex = 223;
			this.label2.Text = "Member ID";
			// 
			// dataGridBookHistory
			// 
			this.dataGridBookHistory.DataMember = "";
			this.dataGridBookHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGridBookHistory.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridBookHistory.Location = new System.Drawing.Point(248, 216);
			this.dataGridBookHistory.Name = "dataGridBookHistory";
			this.dataGridBookHistory.ReadOnly = true;
			this.dataGridBookHistory.Size = new System.Drawing.Size(672, 336);
			this.dataGridBookHistory.TabIndex = 221;
			this.dataGridBookHistory.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																											this.dataGridTableStyleBookHistory});
			// 
			// dataGridTableStyleBookHistory
			// 
			this.dataGridTableStyleBookHistory.AlternatingBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleBookHistory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.dataGridTableStyleBookHistory.DataGrid = this.dataGridBookHistory;
			this.dataGridTableStyleBookHistory.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleBookHistory.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																															this.dataGridTextBoxColumnBorrowDate,
																															this.dataGridTextBoxColumnReturnDate,
																															this.dataGridTextBoxColumnActualReturnDate,
																															this.dataGridTextBoxColumnBorrowSeq,
																															this.dataGridTextBoxColumnBookCode,
																															this.dataGridTextBoxColumnBookName,
																															this.dataGridTextBoxColumnCopyNo,
																															this.dataGridTextBoxColumnMemberID,
																															this.dataGridTextBoxColumnMemberName,
																															this.dataGridTextBoxColumnCurrRate,
																															this.dataGridTextBoxColumnFine,
																															this.dataGridTextBoxColumnLibrarianBorrow,
																															this.dataGridTextBoxColumnLibrarianReturn,
																															this.dataGridTextBoxColumnUpdateUser,
																															this.dataGridTextBoxColumnUpdateDate});
			this.dataGridTableStyleBookHistory.GridLineColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridTableStyleBookHistory.HeaderBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleBookHistory.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleBookHistory.MappingName = "BookHistory";
			// 
			// dataGridTextBoxColumnBorrowDate
			// 
			this.dataGridTextBoxColumnBorrowDate.Format = "";
			this.dataGridTextBoxColumnBorrowDate.FormatInfo = null;
			this.dataGridTextBoxColumnBorrowDate.HeaderText = "Borrow Date";
			this.dataGridTextBoxColumnBorrowDate.MappingName = "BorrowDate";
			this.dataGridTextBoxColumnBorrowDate.Width = 75;
			// 
			// dataGridTextBoxColumnReturnDate
			// 
			this.dataGridTextBoxColumnReturnDate.Format = "";
			this.dataGridTextBoxColumnReturnDate.FormatInfo = null;
			this.dataGridTextBoxColumnReturnDate.HeaderText = "Return Date";
			this.dataGridTextBoxColumnReturnDate.MappingName = "ReturnDate";
			this.dataGridTextBoxColumnReturnDate.Width = 75;
			// 
			// dataGridTextBoxColumnActualReturnDate
			// 
			this.dataGridTextBoxColumnActualReturnDate.Format = "";
			this.dataGridTextBoxColumnActualReturnDate.FormatInfo = null;
			this.dataGridTextBoxColumnActualReturnDate.HeaderText = "Actual Return Date";
			this.dataGridTextBoxColumnActualReturnDate.MappingName = "ActualReturnDate";
			this.dataGridTextBoxColumnActualReturnDate.Width = 75;
			// 
			// dataGridTextBoxColumnBorrowSeq
			// 
			this.dataGridTextBoxColumnBorrowSeq.Format = "";
			this.dataGridTextBoxColumnBorrowSeq.FormatInfo = null;
			this.dataGridTextBoxColumnBorrowSeq.HeaderText = "Seq";
			this.dataGridTextBoxColumnBorrowSeq.MappingName = "BorrowSeq";
			this.dataGridTextBoxColumnBorrowSeq.Width = 30;
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
			this.dataGridTextBoxColumnBookName.Width = 250;
			// 
			// dataGridTextBoxColumnCopyNo
			// 
			this.dataGridTextBoxColumnCopyNo.Format = "";
			this.dataGridTextBoxColumnCopyNo.FormatInfo = null;
			this.dataGridTextBoxColumnCopyNo.HeaderText = "Copy No";
			this.dataGridTextBoxColumnCopyNo.MappingName = "CopyNo";
			this.dataGridTextBoxColumnCopyNo.Width = 75;
			// 
			// dataGridTextBoxColumnMemberID
			// 
			this.dataGridTextBoxColumnMemberID.Format = "";
			this.dataGridTextBoxColumnMemberID.FormatInfo = null;
			this.dataGridTextBoxColumnMemberID.HeaderText = "MemberID";
			this.dataGridTextBoxColumnMemberID.MappingName = "MemberID";
			this.dataGridTextBoxColumnMemberID.Width = 75;
			// 
			// dataGridTextBoxColumnMemberName
			// 
			this.dataGridTextBoxColumnMemberName.Format = "";
			this.dataGridTextBoxColumnMemberName.FormatInfo = null;
			this.dataGridTextBoxColumnMemberName.HeaderText = "Member Name";
			this.dataGridTextBoxColumnMemberName.MappingName = "MemberName";
			this.dataGridTextBoxColumnMemberName.Width = 200;
			// 
			// dataGridTextBoxColumnCurrRate
			// 
			this.dataGridTextBoxColumnCurrRate.Format = "";
			this.dataGridTextBoxColumnCurrRate.FormatInfo = null;
			this.dataGridTextBoxColumnCurrRate.HeaderText = "CurrRate";
			this.dataGridTextBoxColumnCurrRate.MappingName = "CurrRate";
			this.dataGridTextBoxColumnCurrRate.Width = 75;
			// 
			// dataGridTextBoxColumnFine
			// 
			this.dataGridTextBoxColumnFine.Format = "";
			this.dataGridTextBoxColumnFine.FormatInfo = null;
			this.dataGridTextBoxColumnFine.HeaderText = "Fine";
			this.dataGridTextBoxColumnFine.MappingName = "Fine";
			this.dataGridTextBoxColumnFine.Width = 75;
			// 
			// dataGridTextBoxColumnLibrarianBorrow
			// 
			this.dataGridTextBoxColumnLibrarianBorrow.Format = "";
			this.dataGridTextBoxColumnLibrarianBorrow.FormatInfo = null;
			this.dataGridTextBoxColumnLibrarianBorrow.HeaderText = "Librarian Borrow";
			this.dataGridTextBoxColumnLibrarianBorrow.MappingName = "LibrarianBorrow";
			this.dataGridTextBoxColumnLibrarianBorrow.Width = 75;
			// 
			// dataGridTextBoxColumnLibrarianReturn
			// 
			this.dataGridTextBoxColumnLibrarianReturn.Format = "";
			this.dataGridTextBoxColumnLibrarianReturn.FormatInfo = null;
			this.dataGridTextBoxColumnLibrarianReturn.HeaderText = "Librarian Return";
			this.dataGridTextBoxColumnLibrarianReturn.MappingName = "LibrarianReturn";
			this.dataGridTextBoxColumnLibrarianReturn.Width = 75;
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
			// textBoxMemberName
			// 
			this.textBoxMemberName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxMemberName.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxMemberName.Location = new System.Drawing.Point(720, 112);
			this.textBoxMemberName.Name = "textBoxMemberName";
			this.textBoxMemberName.ReadOnly = true;
			this.textBoxMemberName.Size = new System.Drawing.Size(200, 22);
			this.textBoxMemberName.TabIndex = 219;
			this.textBoxMemberName.Text = "";
			// 
			// labelMemberName
			// 
			this.labelMemberName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelMemberName.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelMemberName.Location = new System.Drawing.Point(592, 112);
			this.labelMemberName.Name = "labelMemberName";
			this.labelMemberName.Size = new System.Drawing.Size(120, 24);
			this.labelMemberName.TabIndex = 220;
			this.labelMemberName.Text = "Member Name";
			// 
			// labelFromDate
			// 
			this.labelFromDate.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelFromDate.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelFromDate.Location = new System.Drawing.Point(256, 80);
			this.labelFromDate.Name = "labelFromDate";
			this.labelFromDate.Size = new System.Drawing.Size(120, 24);
			this.labelFromDate.TabIndex = 230;
			this.labelFromDate.Text = "From";
			// 
			// dateTimePickerFromDate
			// 
			this.dateTimePickerFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dateTimePickerFromDate.Location = new System.Drawing.Point(384, 80);
			this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
			this.dateTimePickerFromDate.TabIndex = 1;
			this.dateTimePickerFromDate.ValueChanged += new System.EventHandler(this.dateTimePickerFromDate_ValueChanged);
			// 
			// labelToDate
			// 
			this.labelToDate.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelToDate.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelToDate.Location = new System.Drawing.Point(592, 80);
			this.labelToDate.Name = "labelToDate";
			this.labelToDate.Size = new System.Drawing.Size(120, 24);
			this.labelToDate.TabIndex = 232;
			this.labelToDate.Text = "To";
			// 
			// dateTimePickerToDate
			// 
			this.dateTimePickerToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dateTimePickerToDate.Location = new System.Drawing.Point(720, 80);
			this.dateTimePickerToDate.Name = "dateTimePickerToDate";
			this.dateTimePickerToDate.TabIndex = 2;
			this.dateTimePickerToDate.ValueChanged += new System.EventHandler(this.dateTimePickerToDate_ValueChanged);
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
			this.LabelTitle.TabIndex = 233;
			this.LabelTitle.Text = "    Book History";
			this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// buttonNow
			// 
			this.buttonNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonNow.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonNow.Image = ((System.Drawing.Image)(resources.GetObject("buttonNow.Image")));
			this.buttonNow.Location = new System.Drawing.Point(496, 176);
			this.buttonNow.Name = "buttonNow";
			this.buttonNow.Size = new System.Drawing.Size(88, 32);
			this.buttonNow.TabIndex = 6;
			this.buttonNow.Text = "Now";
			this.buttonNow.Click += new System.EventHandler(this.buttonNow_Click);
			// 
			// FrmBookHistory
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.buttonNow);
			this.Controls.Add(this.LabelTitle);
			this.Controls.Add(this.labelToDate);
			this.Controls.Add(this.dateTimePickerToDate);
			this.Controls.Add(this.labelFromDate);
			this.Controls.Add(this.dateTimePickerFromDate);
			this.Controls.Add(this.pictureBoxLogoPicture);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.buttonRefresh);
			this.Controls.Add(this.textBoxBookCode);
			this.Controls.Add(this.labelBookCode);
			this.Controls.Add(this.textBoxMemberID);
			this.Controls.Add(this.textBoxBookName);
			this.Controls.Add(this.labelBookName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGridBookHistory);
			this.Controls.Add(this.textBoxMemberName);
			this.Controls.Add(this.labelMemberName);
			this.Name = "FrmBookHistory";
			this.Load += new System.EventHandler(this.FrmBookHistory_Load);
			this.Controls.SetChildIndex(this.labelMemberName, 0);
			this.Controls.SetChildIndex(this.textBoxMemberName, 0);
			this.Controls.SetChildIndex(this.dataGridBookHistory, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.labelBookName, 0);
			this.Controls.SetChildIndex(this.textBoxBookName, 0);
			this.Controls.SetChildIndex(this.textBoxMemberID, 0);
			this.Controls.SetChildIndex(this.labelBookCode, 0);
			this.Controls.SetChildIndex(this.textBoxBookCode, 0);
			this.Controls.SetChildIndex(this.buttonRefresh, 0);
			this.Controls.SetChildIndex(this.buttonClear, 0);
			this.Controls.SetChildIndex(this.pictureBoxLogoPicture, 0);
			this.Controls.SetChildIndex(this.dateTimePickerFromDate, 0);
			this.Controls.SetChildIndex(this.labelFromDate, 0);
			this.Controls.SetChildIndex(this.dateTimePickerToDate, 0);
			this.Controls.SetChildIndex(this.labelToDate, 0);
			this.Controls.SetChildIndex(this.LabelTitle, 0);
			this.Controls.SetChildIndex(this.buttonNow, 0);
			((System.ComponentModel.ISupportInitialize)(this.dataGridBookHistory)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void FrmBookHistory_Load(object sender, System.EventArgs e)
		{
			MyClassDatabase = new ClassDatabase();
			dateTimePickerToDate.Value = dateTimePickerFromDate.Value.AddMonths(1);
			MyDataTable = MyClassDatabase.GetBookHistory(dateTimePickerFromDate.Value.ToShortDateString(), dateTimePickerToDate.Value.ToShortDateString());
			MyDataView = new DataView(MyDataTable, "MemberID LIKE '%" + textBoxMemberID.Text.ToString() + "%' and BookCode LIKE '%" + textBoxBookCode.Text.ToString() + "%' and BookName LIKE '%" + textBoxBookName.Text.ToString() + "%' ","BorrowDate",DataViewRowState.CurrentRows);
			dataGridBookHistory.DataSource = MyDataView;

		}

		private void dateTimePickerFromDate_ValueChanged(object sender, System.EventArgs e)
		{
			dateTimePickerToDate.Value = dateTimePickerFromDate.Value.AddMonths(1);
			MyClassDatabase = new ClassDatabase();
			MyDataTable = MyClassDatabase.GetBookHistory(dateTimePickerFromDate.Value.ToShortDateString(), dateTimePickerToDate.Value.ToShortDateString());
			MyDataView = new DataView(MyDataTable, "MemberID LIKE '%" + textBoxMemberID.Text.ToString() + "%' and BookCode LIKE '%" + textBoxBookCode.Text.ToString() + "%' and BookName LIKE '%" + textBoxBookName.Text.ToString() + "%' ","BorrowDate",DataViewRowState.CurrentRows);
			dataGridBookHistory.DataSource = MyDataView;
		}

		private void dateTimePickerToDate_ValueChanged(object sender, System.EventArgs e)
		{
			MyClassDatabase = new ClassDatabase();
			MyDataTable = MyClassDatabase.GetBookHistory(dateTimePickerFromDate.Value.ToShortDateString(), dateTimePickerToDate.Value.ToShortDateString());
			MyDataView = new DataView(MyDataTable, "MemberID LIKE '%" + textBoxMemberID.Text.ToString() + "%' and BookCode LIKE '%" + textBoxBookCode.Text.ToString() + "%' and BookName LIKE '%" + textBoxBookName.Text.ToString() + "%' ","BorrowDate",DataViewRowState.CurrentRows);
			dataGridBookHistory.DataSource = MyDataView;
		}

		private void textBoxMemberID_TextChanged(object sender, System.EventArgs e)
		{
			MyDataView = new DataView(MyDataTable, "MemberID LIKE '%" + textBoxMemberID.Text.ToString() + "%' and BookCode LIKE '%" + textBoxBookCode.Text.ToString() + "%' and BookName LIKE '%" + textBoxBookName.Text.ToString() + "%' ","BorrowDate",DataViewRowState.CurrentRows);
			dataGridBookHistory.DataSource = MyDataView;
		}
		private void textBoxMemberID_Clicked(object sender, System.EventArgs e)
		{
			MySearchMiniForm = new FrmSearchMiniForm(this, "BookHistory");
			MySearchMiniForm.Show();
		}
		private void textBoxBookCode_TextChanged(object sender, System.EventArgs e)
		{
			MyDataView = new DataView(MyDataTable, "MemberID LIKE '%" + textBoxMemberID.Text.ToString() + "%' and BookCode LIKE '%" + textBoxBookCode.Text.ToString() + "%' and BookName LIKE '%" + textBoxBookName.Text.ToString() + "%' ","BorrowDate",DataViewRowState.CurrentRows);
			dataGridBookHistory.DataSource = MyDataView;
		}

		private void textBoxBookName_TextChanged(object sender, System.EventArgs e)
		{
			MyDataView = new DataView(MyDataTable, "MemberID LIKE '%" + textBoxMemberID.Text.ToString() + "%' and BookCode LIKE '%" + textBoxBookCode.Text.ToString() + "%' and BookName LIKE '%" + textBoxBookName.Text.ToString() + "%' ","BorrowDate",DataViewRowState.CurrentRows);
			dataGridBookHistory.DataSource = MyDataView;
		}

		private void buttonClear_Click(object sender, System.EventArgs e)
		{
			dateTimePickerFromDate.Value = DateTime.Now.Date;
			textBoxMemberID.Text = "";
			textBoxMemberName.Text = "";
			textBoxBookCode.Text = "";
			textBoxBookName.Text = "";
		}

		private void buttonRefresh_Click(object sender, System.EventArgs e)
		{
			MyClassDatabase = new ClassDatabase();
			MyDataTable = MyClassDatabase.GetBookHistory(dateTimePickerFromDate.Value.ToShortDateString(), dateTimePickerToDate.Value.ToShortDateString());
			MyDataView = new DataView(MyDataTable, "MemberID LIKE '%" + textBoxMemberID.Text.ToString() + "%' and BookCode LIKE '%" + textBoxBookCode.Text.ToString() + "%' and BookName LIKE '%" + textBoxBookName.Text.ToString() + "%' ","BorrowDate",DataViewRowState.CurrentRows);
			dataGridBookHistory.DataSource = MyDataView;

		}

		private void buttonNow_Click(object sender, System.EventArgs e)
		{
			dateTimePickerFromDate.Value = DateTime.Now.Date;
			dateTimePickerToDate.Value = DateTime.Now.Date;
		}
	}
}

