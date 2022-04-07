using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace Sola_Scriptura_Library
{
	public class FrmIncomeHistory : Sola_Scriptura_Library.FrmFormParent
	{
		internal System.Windows.Forms.Button buttonNow;
		internal System.Windows.Forms.Label LabelTitle;
		internal System.Windows.Forms.Label labelToDate;
		internal System.Windows.Forms.DateTimePicker dateTimePickerToDate;
		internal System.Windows.Forms.Label labelFromDate;
		internal System.Windows.Forms.DateTimePicker dateTimePickerFromDate;
		internal System.Windows.Forms.PictureBox pictureBoxLogoPicture;
		internal System.Windows.Forms.Button buttonClear;
		internal System.Windows.Forms.Button buttonRefresh;
		internal System.Windows.Forms.DataGrid dataGridBookHistory;
		private System.ComponentModel.IContainer components = null;



		internal System.Windows.Forms.DataGridTableStyle dataGridTableStyleTotalIncome;
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
		internal System.Windows.Forms.TextBox textBoxTotalFine;
		internal System.Windows.Forms.Label labelTotalFine;
		internal System.Windows.Forms.DataGrid dataGridTotalFine;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnCurrRate;
		internal System.Windows.Forms.DataGridTableStyle dataGridTableStyleTotalFine;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnBorrowDate2;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnReturnDate2;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnActualReturnDate2;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnBorrowSeq2;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnBookCode2;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnBookName2;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnCopyNo2;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnMemberID2;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnMemberName2;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnCurrRate2;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnFine2;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnLibrarianBorrow2;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnLibrarianReturn2;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnUpdateUser2;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnUpdateDate2;
		
		internal ClassDatabase MyClassDatabase;
		internal DataTable MyDataTable;
		internal DataTable MyDataTable2;
		internal string MyTotalIncome;
		internal string MyTotalFine;
		internal System.Windows.Forms.TextBox textBoxTotalIncome;
		internal System.Windows.Forms.Label labelTotalIncome;
		internal DataView MyDataView;

		public FrmIncomeHistory()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmIncomeHistory));
			this.buttonNow = new System.Windows.Forms.Button();
			this.LabelTitle = new System.Windows.Forms.Label();
			this.labelToDate = new System.Windows.Forms.Label();
			this.dateTimePickerToDate = new System.Windows.Forms.DateTimePicker();
			this.labelFromDate = new System.Windows.Forms.Label();
			this.dateTimePickerFromDate = new System.Windows.Forms.DateTimePicker();
			this.pictureBoxLogoPicture = new System.Windows.Forms.PictureBox();
			this.buttonClear = new System.Windows.Forms.Button();
			this.buttonRefresh = new System.Windows.Forms.Button();
			this.dataGridBookHistory = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyleTotalIncome = new System.Windows.Forms.DataGridTableStyle();
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
			this.textBoxTotalIncome = new System.Windows.Forms.TextBox();
			this.labelTotalIncome = new System.Windows.Forms.Label();
			this.textBoxTotalFine = new System.Windows.Forms.TextBox();
			this.labelTotalFine = new System.Windows.Forms.Label();
			this.dataGridTotalFine = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyleTotalFine = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnBorrowDate2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnReturnDate2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnActualReturnDate2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnBorrowSeq2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnBookCode2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnBookName2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnCopyNo2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnMemberID2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnMemberName2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnCurrRate2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnFine2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnLibrarianBorrow2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnLibrarianReturn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnUpdateUser2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnUpdateDate2 = new System.Windows.Forms.DataGridTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridBookHistory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridTotalFine)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonNow
			// 
			this.buttonNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonNow.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonNow.Image = ((System.Drawing.Image)(resources.GetObject("buttonNow.Image")));
			this.buttonNow.Location = new System.Drawing.Point(498, 112);
			this.buttonNow.Name = "buttonNow";
			this.buttonNow.Size = new System.Drawing.Size(88, 32);
			this.buttonNow.TabIndex = 236;
			this.buttonNow.Text = "Now";
			this.buttonNow.Click += new System.EventHandler(this.buttonNow_Click);
			// 
			// LabelTitle
			// 
			this.LabelTitle.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.LabelTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.LabelTitle.Image = ((System.Drawing.Image)(resources.GetObject("LabelTitle.Image")));
			this.LabelTitle.Location = new System.Drawing.Point(794, 17);
			this.LabelTitle.Name = "LabelTitle";
			this.LabelTitle.Size = new System.Drawing.Size(192, 32);
			this.LabelTitle.TabIndex = 243;
			this.LabelTitle.Text = "    Income History";
			this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelToDate
			// 
			this.labelToDate.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelToDate.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelToDate.Location = new System.Drawing.Point(594, 81);
			this.labelToDate.Name = "labelToDate";
			this.labelToDate.Size = new System.Drawing.Size(120, 24);
			this.labelToDate.TabIndex = 242;
			this.labelToDate.Text = "To";
			// 
			// dateTimePickerToDate
			// 
			this.dateTimePickerToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dateTimePickerToDate.Location = new System.Drawing.Point(722, 81);
			this.dateTimePickerToDate.Name = "dateTimePickerToDate";
			this.dateTimePickerToDate.TabIndex = 235;
			this.dateTimePickerToDate.ValueChanged += new System.EventHandler(this.dateTimePickerToDate_ValueChanged);
			// 
			// labelFromDate
			// 
			this.labelFromDate.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelFromDate.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelFromDate.Location = new System.Drawing.Point(258, 81);
			this.labelFromDate.Name = "labelFromDate";
			this.labelFromDate.Size = new System.Drawing.Size(120, 24);
			this.labelFromDate.TabIndex = 241;
			this.labelFromDate.Text = "From";
			// 
			// dateTimePickerFromDate
			// 
			this.dateTimePickerFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dateTimePickerFromDate.Location = new System.Drawing.Point(386, 81);
			this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
			this.dateTimePickerFromDate.TabIndex = 234;
			this.dateTimePickerFromDate.ValueChanged += new System.EventHandler(this.dateTimePickerFromDate_ValueChanged);
			// 
			// pictureBoxLogoPicture
			// 
			this.pictureBoxLogoPicture.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogoPicture.Image")));
			this.pictureBoxLogoPicture.Location = new System.Drawing.Point(34, 73);
			this.pictureBoxLogoPicture.Name = "pictureBoxLogoPicture";
			this.pictureBoxLogoPicture.Size = new System.Drawing.Size(144, 88);
			this.pictureBoxLogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxLogoPicture.TabIndex = 240;
			this.pictureBoxLogoPicture.TabStop = false;
			// 
			// buttonClear
			// 
			this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonClear.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonClear.Image = ((System.Drawing.Image)(resources.GetObject("buttonClear.Image")));
			this.buttonClear.Location = new System.Drawing.Point(728, 112);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(88, 32);
			this.buttonClear.TabIndex = 237;
			this.buttonClear.Text = "Clear";
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// buttonRefresh
			// 
			this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonRefresh.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("buttonRefresh.Image")));
			this.buttonRefresh.Location = new System.Drawing.Point(832, 112);
			this.buttonRefresh.Name = "buttonRefresh";
			this.buttonRefresh.Size = new System.Drawing.Size(88, 32);
			this.buttonRefresh.TabIndex = 238;
			this.buttonRefresh.Text = "Refresh";
			this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
			// 
			// dataGridBookHistory
			// 
			this.dataGridBookHistory.DataMember = "";
			this.dataGridBookHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGridBookHistory.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridBookHistory.Location = new System.Drawing.Point(248, 152);
			this.dataGridBookHistory.Name = "dataGridBookHistory";
			this.dataGridBookHistory.ReadOnly = true;
			this.dataGridBookHistory.Size = new System.Drawing.Size(672, 160);
			this.dataGridBookHistory.TabIndex = 239;
			this.dataGridBookHistory.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																											this.dataGridTableStyleTotalIncome});
			// 
			// dataGridTableStyleTotalIncome
			// 
			this.dataGridTableStyleTotalIncome.AlternatingBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleTotalIncome.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.dataGridTableStyleTotalIncome.DataGrid = this.dataGridBookHistory;
			this.dataGridTableStyleTotalIncome.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleTotalIncome.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
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
			this.dataGridTableStyleTotalIncome.GridLineColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridTableStyleTotalIncome.HeaderBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleTotalIncome.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleTotalIncome.MappingName = "BookHistory";
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
			this.dataGridTextBoxColumnBorrowSeq.HeaderText = "Borrow Seq";
			this.dataGridTextBoxColumnBorrowSeq.MappingName = "BorrowSeq";
			this.dataGridTextBoxColumnBorrowSeq.Width = 30;
			// 
			// dataGridTextBoxColumnBookCode
			// 
			this.dataGridTextBoxColumnBookCode.Format = "";
			this.dataGridTextBoxColumnBookCode.FormatInfo = null;
			this.dataGridTextBoxColumnBookCode.HeaderText = "BookCode";
			this.dataGridTextBoxColumnBookCode.MappingName = "BookCode";
			this.dataGridTextBoxColumnBookCode.Width = 120;
			// 
			// dataGridTextBoxColumnBookName
			// 
			this.dataGridTextBoxColumnBookName.Format = "";
			this.dataGridTextBoxColumnBookName.FormatInfo = null;
			this.dataGridTextBoxColumnBookName.HeaderText = "BookName";
			this.dataGridTextBoxColumnBookName.MappingName = "BookName";
			this.dataGridTextBoxColumnBookName.Width = 250;
			// 
			// dataGridTextBoxColumnCopyNo
			// 
			this.dataGridTextBoxColumnCopyNo.Format = "";
			this.dataGridTextBoxColumnCopyNo.FormatInfo = null;
			this.dataGridTextBoxColumnCopyNo.HeaderText = "CopyNo";
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
			this.dataGridTextBoxColumnLibrarianBorrow.HeaderText = "LibrarianBorrow";
			this.dataGridTextBoxColumnLibrarianBorrow.MappingName = "LibrarianBorrow";
			this.dataGridTextBoxColumnLibrarianBorrow.Width = 75;
			// 
			// dataGridTextBoxColumnLibrarianReturn
			// 
			this.dataGridTextBoxColumnLibrarianReturn.Format = "";
			this.dataGridTextBoxColumnLibrarianReturn.FormatInfo = null;
			this.dataGridTextBoxColumnLibrarianReturn.HeaderText = "LibrarianReturn";
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
			// textBoxTotalIncome
			// 
			this.textBoxTotalIncome.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxTotalIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxTotalIncome.ForeColor = System.Drawing.SystemColors.WindowText;
			this.textBoxTotalIncome.Location = new System.Drawing.Point(720, 320);
			this.textBoxTotalIncome.Name = "textBoxTotalIncome";
			this.textBoxTotalIncome.Size = new System.Drawing.Size(200, 22);
			this.textBoxTotalIncome.TabIndex = 244;
			this.textBoxTotalIncome.Text = "";
			// 
			// labelTotalIncome
			// 
			this.labelTotalIncome.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelTotalIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTotalIncome.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelTotalIncome.Location = new System.Drawing.Point(592, 320);
			this.labelTotalIncome.Name = "labelTotalIncome";
			this.labelTotalIncome.Size = new System.Drawing.Size(120, 24);
			this.labelTotalIncome.TabIndex = 245;
			this.labelTotalIncome.Text = "Total Income";
			// 
			// textBoxTotalFine
			// 
			this.textBoxTotalFine.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxTotalFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxTotalFine.ForeColor = System.Drawing.SystemColors.WindowText;
			this.textBoxTotalFine.Location = new System.Drawing.Point(720, 528);
			this.textBoxTotalFine.Name = "textBoxTotalFine";
			this.textBoxTotalFine.Size = new System.Drawing.Size(200, 22);
			this.textBoxTotalFine.TabIndex = 246;
			this.textBoxTotalFine.Text = "";
			// 
			// labelTotalFine
			// 
			this.labelTotalFine.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelTotalFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTotalFine.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelTotalFine.Location = new System.Drawing.Point(592, 528);
			this.labelTotalFine.Name = "labelTotalFine";
			this.labelTotalFine.Size = new System.Drawing.Size(120, 24);
			this.labelTotalFine.TabIndex = 247;
			this.labelTotalFine.Text = "Total Fine";
			// 
			// dataGridTotalFine
			// 
			this.dataGridTotalFine.DataMember = "";
			this.dataGridTotalFine.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTotalFine.Location = new System.Drawing.Point(248, 360);
			this.dataGridTotalFine.Name = "dataGridTotalFine";
			this.dataGridTotalFine.ReadOnly = true;
			this.dataGridTotalFine.Size = new System.Drawing.Size(672, 160);
			this.dataGridTotalFine.TabIndex = 248;
			this.dataGridTotalFine.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																										  this.dataGridTableStyleTotalFine});
			// 
			// dataGridTableStyleTotalFine
			// 
			this.dataGridTableStyleTotalFine.AlternatingBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleTotalFine.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.dataGridTableStyleTotalFine.DataGrid = this.dataGridTotalFine;
			this.dataGridTableStyleTotalFine.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleTotalFine.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																														  this.dataGridTextBoxColumnBorrowDate2,
																														  this.dataGridTextBoxColumnReturnDate2,
																														  this.dataGridTextBoxColumnActualReturnDate2,
																														  this.dataGridTextBoxColumnBorrowSeq2,
																														  this.dataGridTextBoxColumnBookCode2,
																														  this.dataGridTextBoxColumnBookName2,
																														  this.dataGridTextBoxColumnCopyNo2,
																														  this.dataGridTextBoxColumnMemberID2,
																														  this.dataGridTextBoxColumnMemberName2,
																														  this.dataGridTextBoxColumnCurrRate2,
																														  this.dataGridTextBoxColumnFine2,
																														  this.dataGridTextBoxColumnLibrarianBorrow2,
																														  this.dataGridTextBoxColumnLibrarianReturn2,
																														  this.dataGridTextBoxColumnUpdateUser2,
																														  this.dataGridTextBoxColumnUpdateDate2});
			this.dataGridTableStyleTotalFine.GridLineColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridTableStyleTotalFine.HeaderBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleTotalFine.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleTotalFine.MappingName = "BookHistory2";
			// 
			// dataGridTextBoxColumnBorrowDate2
			// 
			this.dataGridTextBoxColumnBorrowDate2.Format = "";
			this.dataGridTextBoxColumnBorrowDate2.FormatInfo = null;
			this.dataGridTextBoxColumnBorrowDate2.HeaderText = "BorrowDate";
			this.dataGridTextBoxColumnBorrowDate2.MappingName = "BorrowDate";
			this.dataGridTextBoxColumnBorrowDate2.Width = 75;
			// 
			// dataGridTextBoxColumnReturnDate2
			// 
			this.dataGridTextBoxColumnReturnDate2.Format = "";
			this.dataGridTextBoxColumnReturnDate2.FormatInfo = null;
			this.dataGridTextBoxColumnReturnDate2.HeaderText = "Return Date";
			this.dataGridTextBoxColumnReturnDate2.MappingName = "ReturnDate";
			this.dataGridTextBoxColumnReturnDate2.Width = 75;
			// 
			// dataGridTextBoxColumnActualReturnDate2
			// 
			this.dataGridTextBoxColumnActualReturnDate2.Format = "";
			this.dataGridTextBoxColumnActualReturnDate2.FormatInfo = null;
			this.dataGridTextBoxColumnActualReturnDate2.HeaderText = "Actual Return Date";
			this.dataGridTextBoxColumnActualReturnDate2.MappingName = "ActualReturnDate";
			this.dataGridTextBoxColumnActualReturnDate2.Width = 75;
			// 
			// dataGridTextBoxColumnBorrowSeq2
			// 
			this.dataGridTextBoxColumnBorrowSeq2.Format = "";
			this.dataGridTextBoxColumnBorrowSeq2.FormatInfo = null;
			this.dataGridTextBoxColumnBorrowSeq2.HeaderText = "BorrowSeq";
			this.dataGridTextBoxColumnBorrowSeq2.MappingName = "BorrowSeq";
			this.dataGridTextBoxColumnBorrowSeq2.Width = 30;
			// 
			// dataGridTextBoxColumnBookCode2
			// 
			this.dataGridTextBoxColumnBookCode2.Format = "";
			this.dataGridTextBoxColumnBookCode2.FormatInfo = null;
			this.dataGridTextBoxColumnBookCode2.HeaderText = "BookCode";
			this.dataGridTextBoxColumnBookCode2.MappingName = "BookCode";
			this.dataGridTextBoxColumnBookCode2.Width = 120;
			// 
			// dataGridTextBoxColumnBookName2
			// 
			this.dataGridTextBoxColumnBookName2.Format = "";
			this.dataGridTextBoxColumnBookName2.FormatInfo = null;
			this.dataGridTextBoxColumnBookName2.HeaderText = "Book Name";
			this.dataGridTextBoxColumnBookName2.MappingName = "BookName";
			this.dataGridTextBoxColumnBookName2.Width = 250;
			// 
			// dataGridTextBoxColumnCopyNo2
			// 
			this.dataGridTextBoxColumnCopyNo2.Format = "";
			this.dataGridTextBoxColumnCopyNo2.FormatInfo = null;
			this.dataGridTextBoxColumnCopyNo2.HeaderText = "Copy No";
			this.dataGridTextBoxColumnCopyNo2.MappingName = "CopyNo";
			this.dataGridTextBoxColumnCopyNo2.Width = 75;
			// 
			// dataGridTextBoxColumnMemberID2
			// 
			this.dataGridTextBoxColumnMemberID2.Format = "";
			this.dataGridTextBoxColumnMemberID2.FormatInfo = null;
			this.dataGridTextBoxColumnMemberID2.HeaderText = "MemberID";
			this.dataGridTextBoxColumnMemberID2.MappingName = "MemberID";
			this.dataGridTextBoxColumnMemberID2.Width = 75;
			// 
			// dataGridTextBoxColumnMemberName2
			// 
			this.dataGridTextBoxColumnMemberName2.Format = "";
			this.dataGridTextBoxColumnMemberName2.FormatInfo = null;
			this.dataGridTextBoxColumnMemberName2.HeaderText = "Member Name";
			this.dataGridTextBoxColumnMemberName2.MappingName = "MemberName";
			this.dataGridTextBoxColumnMemberName2.Width = 200;
			// 
			// dataGridTextBoxColumnCurrRate2
			// 
			this.dataGridTextBoxColumnCurrRate2.Format = "";
			this.dataGridTextBoxColumnCurrRate2.FormatInfo = null;
			this.dataGridTextBoxColumnCurrRate2.HeaderText = "CurrRate";
			this.dataGridTextBoxColumnCurrRate2.MappingName = "CurrRate";
			this.dataGridTextBoxColumnCurrRate2.Width = 75;
			// 
			// dataGridTextBoxColumnFine2
			// 
			this.dataGridTextBoxColumnFine2.Format = "";
			this.dataGridTextBoxColumnFine2.FormatInfo = null;
			this.dataGridTextBoxColumnFine2.HeaderText = "Fine";
			this.dataGridTextBoxColumnFine2.MappingName = "Fine";
			this.dataGridTextBoxColumnFine2.Width = 75;
			// 
			// dataGridTextBoxColumnLibrarianBorrow2
			// 
			this.dataGridTextBoxColumnLibrarianBorrow2.Format = "";
			this.dataGridTextBoxColumnLibrarianBorrow2.FormatInfo = null;
			this.dataGridTextBoxColumnLibrarianBorrow2.HeaderText = "Librarian Borrow";
			this.dataGridTextBoxColumnLibrarianBorrow2.MappingName = "LibrarianBorrow";
			this.dataGridTextBoxColumnLibrarianBorrow2.Width = 75;
			// 
			// dataGridTextBoxColumnLibrarianReturn2
			// 
			this.dataGridTextBoxColumnLibrarianReturn2.Format = "";
			this.dataGridTextBoxColumnLibrarianReturn2.FormatInfo = null;
			this.dataGridTextBoxColumnLibrarianReturn2.HeaderText = "Librarian Return";
			this.dataGridTextBoxColumnLibrarianReturn2.MappingName = "LibrarianReturn";
			this.dataGridTextBoxColumnLibrarianReturn2.Width = 75;
			// 
			// dataGridTextBoxColumnUpdateUser2
			// 
			this.dataGridTextBoxColumnUpdateUser2.Format = "";
			this.dataGridTextBoxColumnUpdateUser2.FormatInfo = null;
			this.dataGridTextBoxColumnUpdateUser2.HeaderText = "Update User";
			this.dataGridTextBoxColumnUpdateUser2.MappingName = "UpdateUser";
			this.dataGridTextBoxColumnUpdateUser2.Width = 75;
			// 
			// dataGridTextBoxColumnUpdateDate2
			// 
			this.dataGridTextBoxColumnUpdateDate2.Format = "";
			this.dataGridTextBoxColumnUpdateDate2.FormatInfo = null;
			this.dataGridTextBoxColumnUpdateDate2.HeaderText = "Update Date";
			this.dataGridTextBoxColumnUpdateDate2.MappingName = "UpdateDate";
			this.dataGridTextBoxColumnUpdateDate2.Width = 75;
			// 
			// FrmIncomeHistory
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.dataGridTotalFine);
			this.Controls.Add(this.textBoxTotalFine);
			this.Controls.Add(this.labelTotalFine);
			this.Controls.Add(this.textBoxTotalIncome);
			this.Controls.Add(this.labelTotalIncome);
			this.Controls.Add(this.buttonNow);
			this.Controls.Add(this.LabelTitle);
			this.Controls.Add(this.labelToDate);
			this.Controls.Add(this.dateTimePickerToDate);
			this.Controls.Add(this.labelFromDate);
			this.Controls.Add(this.dateTimePickerFromDate);
			this.Controls.Add(this.pictureBoxLogoPicture);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.buttonRefresh);
			this.Controls.Add(this.dataGridBookHistory);
			this.Name = "FrmIncomeHistory";
			this.Load += new System.EventHandler(this.FrmIncomeHistory_Load);
			this.Controls.SetChildIndex(this.dataGridBookHistory, 0);
			this.Controls.SetChildIndex(this.buttonRefresh, 0);
			this.Controls.SetChildIndex(this.buttonClear, 0);
			this.Controls.SetChildIndex(this.pictureBoxLogoPicture, 0);
			this.Controls.SetChildIndex(this.dateTimePickerFromDate, 0);
			this.Controls.SetChildIndex(this.labelFromDate, 0);
			this.Controls.SetChildIndex(this.dateTimePickerToDate, 0);
			this.Controls.SetChildIndex(this.labelToDate, 0);
			this.Controls.SetChildIndex(this.LabelTitle, 0);
			this.Controls.SetChildIndex(this.buttonNow, 0);
			this.Controls.SetChildIndex(this.labelTotalIncome, 0);
			this.Controls.SetChildIndex(this.textBoxTotalIncome, 0);
			this.Controls.SetChildIndex(this.labelTotalFine, 0);
			this.Controls.SetChildIndex(this.textBoxTotalFine, 0);
			this.Controls.SetChildIndex(this.dataGridTotalFine, 0);
			((System.ComponentModel.ISupportInitialize)(this.dataGridBookHistory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridTotalFine)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void FrmIncomeHistory_Load(object sender, System.EventArgs e)
		{
			dateTimePickerToDate.Value = dateTimePickerFromDate.Value.AddMonths(1);
			MyClassDatabase = new ClassDatabase();
			MyDataTable = MyClassDatabase.GetBookHistory(dateTimePickerFromDate.Value.ToShortDateString(), dateTimePickerToDate.Value.ToShortDateString());
			MyDataTable2 = MyClassDatabase.GetBookHistory2(dateTimePickerFromDate.Value.ToShortDateString(), dateTimePickerToDate.Value.ToShortDateString());
			dataGridBookHistory.DataSource = MyDataTable;
			dataGridTotalFine.DataSource = MyDataTable2;
			MyTotalIncome = MyClassDatabase.GetTotalIncome(dateTimePickerFromDate.Value.ToShortDateString(), dateTimePickerToDate.Value.ToShortDateString());
			MyTotalFine = MyClassDatabase.GetTotalFine(dateTimePickerFromDate.Value.ToShortDateString(), dateTimePickerToDate.Value.ToShortDateString());
			textBoxTotalIncome.Text = MyTotalIncome;
			textBoxTotalFine.Text = MyTotalFine;
		}

		private void dateTimePickerFromDate_ValueChanged(object sender, System.EventArgs e)
		{
			MyClassDatabase = new ClassDatabase();
			MyDataTable = MyClassDatabase.GetBookHistory(dateTimePickerFromDate.Value.ToShortDateString(), dateTimePickerToDate.Value.ToShortDateString());
			MyDataTable2 = MyClassDatabase.GetBookHistory2(dateTimePickerFromDate.Value.ToShortDateString(), dateTimePickerToDate.Value.ToShortDateString());
			dataGridBookHistory.DataSource = MyDataTable;
			dataGridTotalFine.DataSource = MyDataTable2;
			MyTotalIncome = MyClassDatabase.GetTotalIncome(dateTimePickerFromDate.Value.ToShortDateString(), dateTimePickerToDate.Value.ToShortDateString());
			MyTotalFine = MyClassDatabase.GetTotalFine(dateTimePickerFromDate.Value.ToShortDateString(), dateTimePickerToDate.Value.ToShortDateString());
			textBoxTotalIncome.Text = MyTotalIncome;
			textBoxTotalFine.Text = MyTotalFine;
		}

		private void dateTimePickerToDate_ValueChanged(object sender, System.EventArgs e)
		{
			MyClassDatabase = new ClassDatabase();
			MyDataTable = MyClassDatabase.GetBookHistory(dateTimePickerFromDate.Value.ToShortDateString(), dateTimePickerToDate.Value.ToShortDateString());
			MyDataTable2 = MyClassDatabase.GetBookHistory2(dateTimePickerFromDate.Value.ToShortDateString(), dateTimePickerToDate.Value.ToShortDateString());
			dataGridBookHistory.DataSource = MyDataTable;
			dataGridTotalFine.DataSource = MyDataTable2;
			MyTotalIncome = MyClassDatabase.GetTotalIncome(dateTimePickerFromDate.Value.ToShortDateString(), dateTimePickerToDate.Value.ToShortDateString());
			MyTotalFine = MyClassDatabase.GetTotalFine(dateTimePickerFromDate.Value.ToShortDateString(), dateTimePickerToDate.Value.ToShortDateString());
			textBoxTotalIncome.Text = MyTotalIncome;
			textBoxTotalFine.Text = MyTotalFine;
		}


		private void buttonClear_Click(object sender, System.EventArgs e)
		{
			dateTimePickerFromDate.Value = DateTime.Now.Date;

		}

		private void buttonRefresh_Click(object sender, System.EventArgs e)
		{
			MyClassDatabase = new ClassDatabase();
			MyDataTable = MyClassDatabase.GetBookHistory(dateTimePickerFromDate.Value.ToShortDateString(), dateTimePickerToDate.Value.ToShortDateString());
			MyDataTable2 = MyClassDatabase.GetBookHistory2(dateTimePickerFromDate.Value.ToShortDateString(), dateTimePickerToDate.Value.ToShortDateString());
			dataGridBookHistory.DataSource = MyDataTable;
			dataGridTotalFine.DataSource = MyDataTable2;
			MyTotalIncome = MyClassDatabase.GetTotalIncome(dateTimePickerFromDate.Value.ToShortDateString(), dateTimePickerToDate.Value.ToShortDateString());
			MyTotalFine = MyClassDatabase.GetTotalFine(dateTimePickerFromDate.Value.ToShortDateString(), dateTimePickerToDate.Value.ToShortDateString());
			textBoxTotalIncome.Text = MyTotalIncome;
			textBoxTotalFine.Text = MyTotalFine;
		}

		private void buttonNow_Click(object sender, System.EventArgs e)
		{
			dateTimePickerFromDate.Value = DateTime.Now.Date;
			dateTimePickerToDate.Value = DateTime.Now.Date;
			MyClassDatabase = new ClassDatabase();
			MyDataTable = MyClassDatabase.GetBookHistory(dateTimePickerFromDate.Value.ToShortDateString(), dateTimePickerToDate.Value.ToShortDateString());
			dataGridBookHistory.DataSource = MyDataTable;
			MyTotalIncome = MyClassDatabase.GetTotalIncome(dateTimePickerFromDate.Value.ToShortDateString(), dateTimePickerToDate.Value.ToShortDateString());
			MyTotalFine = MyClassDatabase.GetTotalFine(dateTimePickerFromDate.Value.ToShortDateString(), dateTimePickerToDate.Value.ToShortDateString());
			textBoxTotalIncome.Text = MyTotalIncome;
			textBoxTotalFine.Text = MyTotalFine;
		}
	}
}

