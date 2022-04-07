using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace Sola_Scriptura_Library
{
	public class FrmTransactionBorrow : Sola_Scriptura_Library.FrmFormParent
	{
		internal System.Windows.Forms.Label labelAuthorCode;
		internal System.Windows.Forms.DataGrid dataGridBorrow;
		public System.Windows.Forms.TextBox textBoxMemberID;
		internal System.Windows.Forms.TextBox textBoxMemberName;
		internal System.Windows.Forms.Label labelMemberName;
		internal System.Windows.Forms.Label labelBookCode;
		internal System.Windows.Forms.TextBox textBoxBookName;
		internal System.Windows.Forms.Label labelBookName;
		internal System.Windows.Forms.Label labelBorrowDate;
		internal System.Windows.Forms.DateTimePicker dateTimePickerBorrowDate;
		internal System.Windows.Forms.Label labelReturnDate;
		internal System.Windows.Forms.DateTimePicker dateTimePickerReturnDate;
		private System.ComponentModel.IContainer components = null;


		internal System.Windows.Forms.DataGridTableStyle dataGridTableStyleBorrow;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnBorrowDate;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnMemberID;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnBookName;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnReturnDate;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnActualReturnDate;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnFine;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnLibrarianBorrow;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnLibrarianReturn;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnUpdateUser;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnUpdateDate;
		internal System.Windows.Forms.Button buttonSave;
		internal System.Windows.Forms.Button buttonCancel;
		internal System.Windows.Forms.Button buttonDelete;
		internal System.Windows.Forms.Button buttonEdit;
		internal System.Windows.Forms.Button buttonAdd;


		internal FrmTransactionMenu MyTransactionMenuForm;
		internal ClassDatabase MyClassDatabase;
		internal DataTable MyDataTable;
		internal FrmSearchMiniForm MySearchMiniForm;
		internal FrmSearchBookMiniForm MySearchBookMiniForm;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnBorrowSeq;
		internal System.Windows.Forms.Label LabelTitle;
		internal System.Windows.Forms.PictureBox pictureBoxLogoPicture;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnBarCodeNo;
		internal System.Windows.Forms.TextBox textBoxBarCodeNo;
		internal System.Windows.Forms.Button buttonSearchMember;
		internal System.Windows.Forms.Button buttonBarCodeNo;
		internal BookTransaction MyBookTransaction;
		internal BookSearch MyBookSearch;
		internal bool MyStatusEdit;
		internal bool MyStatusAdd;
		public FrmTransactionBorrow()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public FrmTransactionBorrow(FrmMDI MDIForm, FrmTransactionMenu TransactionMenuForm)
		{
			base.MyMDIForm = MDIForm;
			MyTransactionMenuForm = TransactionMenuForm;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmTransactionBorrow));
			this.dataGridBorrow = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyleBorrow = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnBorrowDate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnMemberID = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnBorrowSeq = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnBarCodeNo = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnBookName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnReturnDate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnActualReturnDate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnFine = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnLibrarianBorrow = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnLibrarianReturn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnUpdateUser = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnUpdateDate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.textBoxMemberID = new System.Windows.Forms.TextBox();
			this.textBoxMemberName = new System.Windows.Forms.TextBox();
			this.labelMemberName = new System.Windows.Forms.Label();
			this.labelAuthorCode = new System.Windows.Forms.Label();
			this.textBoxBookName = new System.Windows.Forms.TextBox();
			this.labelBookName = new System.Windows.Forms.Label();
			this.textBoxBarCodeNo = new System.Windows.Forms.TextBox();
			this.labelBookCode = new System.Windows.Forms.Label();
			this.labelBorrowDate = new System.Windows.Forms.Label();
			this.dateTimePickerBorrowDate = new System.Windows.Forms.DateTimePicker();
			this.labelReturnDate = new System.Windows.Forms.Label();
			this.dateTimePickerReturnDate = new System.Windows.Forms.DateTimePicker();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.LabelTitle = new System.Windows.Forms.Label();
			this.pictureBoxLogoPicture = new System.Windows.Forms.PictureBox();
			this.buttonSearchMember = new System.Windows.Forms.Button();
			this.buttonBarCodeNo = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridBorrow)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridBorrow
			// 
			this.dataGridBorrow.DataMember = "";
			this.dataGridBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGridBorrow.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridBorrow.Location = new System.Drawing.Point(248, 144);
			this.dataGridBorrow.Name = "dataGridBorrow";
			this.dataGridBorrow.ReadOnly = true;
			this.dataGridBorrow.Size = new System.Drawing.Size(672, 256);
			this.dataGridBorrow.TabIndex = 165;
			this.dataGridBorrow.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																									   this.dataGridTableStyleBorrow});
			// 
			// dataGridTableStyleBorrow
			// 
			this.dataGridTableStyleBorrow.AlternatingBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleBorrow.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.dataGridTableStyleBorrow.DataGrid = this.dataGridBorrow;
			this.dataGridTableStyleBorrow.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleBorrow.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																													   this.dataGridTextBoxColumnBorrowDate,
																													   this.dataGridTextBoxColumnMemberID,
																													   this.dataGridTextBoxColumnBorrowSeq,
																													   this.dataGridTextBoxColumnBarCodeNo,
																													   this.dataGridTextBoxColumnBookName,
																													   this.dataGridTextBoxColumnReturnDate,
																													   this.dataGridTextBoxColumnActualReturnDate,
																													   this.dataGridTextBoxColumnFine,
																													   this.dataGridTextBoxColumnLibrarianBorrow,
																													   this.dataGridTextBoxColumnLibrarianReturn,
																													   this.dataGridTextBoxColumnUpdateUser,
																													   this.dataGridTextBoxColumnUpdateDate});
			this.dataGridTableStyleBorrow.GridLineColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridTableStyleBorrow.HeaderBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleBorrow.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleBorrow.MappingName = "BorrowData";
			// 
			// dataGridTextBoxColumnBorrowDate
			// 
			this.dataGridTextBoxColumnBorrowDate.Format = "";
			this.dataGridTextBoxColumnBorrowDate.FormatInfo = null;
			this.dataGridTextBoxColumnBorrowDate.HeaderText = "Borrow Date";
			this.dataGridTextBoxColumnBorrowDate.MappingName = "BorrowDate";
			this.dataGridTextBoxColumnBorrowDate.Width = 75;
			// 
			// dataGridTextBoxColumnMemberID
			// 
			this.dataGridTextBoxColumnMemberID.Format = "";
			this.dataGridTextBoxColumnMemberID.FormatInfo = null;
			this.dataGridTextBoxColumnMemberID.HeaderText = "Member ID";
			this.dataGridTextBoxColumnMemberID.MappingName = "MemberID";
			this.dataGridTextBoxColumnMemberID.Width = 0;
			// 
			// dataGridTextBoxColumnBorrowSeq
			// 
			this.dataGridTextBoxColumnBorrowSeq.Format = "";
			this.dataGridTextBoxColumnBorrowSeq.FormatInfo = null;
			this.dataGridTextBoxColumnBorrowSeq.HeaderText = "Seq";
			this.dataGridTextBoxColumnBorrowSeq.MappingName = "BorrowSeq";
			this.dataGridTextBoxColumnBorrowSeq.Width = 20;
			// 
			// dataGridTextBoxColumnBarCodeNo
			// 
			this.dataGridTextBoxColumnBarCodeNo.Format = "";
			this.dataGridTextBoxColumnBarCodeNo.FormatInfo = null;
			this.dataGridTextBoxColumnBarCodeNo.HeaderText = "BarCodeNo";
			this.dataGridTextBoxColumnBarCodeNo.MappingName = "BarCodeNo";
			this.dataGridTextBoxColumnBarCodeNo.Width = 75;
			// 
			// dataGridTextBoxColumnBookName
			// 
			this.dataGridTextBoxColumnBookName.Format = "";
			this.dataGridTextBoxColumnBookName.FormatInfo = null;
			this.dataGridTextBoxColumnBookName.HeaderText = "Book Name";
			this.dataGridTextBoxColumnBookName.MappingName = "BookName";
			this.dataGridTextBoxColumnBookName.Width = 200;
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
			this.dataGridTextBoxColumnActualReturnDate.HeaderText = "Actual ReturnDate";
			this.dataGridTextBoxColumnActualReturnDate.MappingName = "ActualReturnDate";
			this.dataGridTextBoxColumnActualReturnDate.Width = 75;
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
			// textBoxMemberID
			// 
			this.textBoxMemberID.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxMemberID.Location = new System.Drawing.Point(384, 80);
			this.textBoxMemberID.Name = "textBoxMemberID";
			this.textBoxMemberID.Size = new System.Drawing.Size(200, 22);
			this.textBoxMemberID.TabIndex = 1;
			this.textBoxMemberID.Text = "";
			this.textBoxMemberID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxMemberID_KeyDown);
			this.textBoxMemberID.TextChanged += new System.EventHandler(this.textBoxMemberID_TextChanged);
			this.textBoxMemberID.Click += new System.EventHandler(this.textBoxMemberID_Clicked);
			// 
			// textBoxMemberName
			// 
			this.textBoxMemberName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxMemberName.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxMemberName.Location = new System.Drawing.Point(384, 112);
			this.textBoxMemberName.Name = "textBoxMemberName";
			this.textBoxMemberName.ReadOnly = true;
			this.textBoxMemberName.Size = new System.Drawing.Size(200, 22);
			this.textBoxMemberName.TabIndex = 162;
			this.textBoxMemberName.TabStop = false;
			this.textBoxMemberName.Text = "";
			// 
			// labelMemberName
			// 
			this.labelMemberName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelMemberName.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelMemberName.Location = new System.Drawing.Point(256, 112);
			this.labelMemberName.Name = "labelMemberName";
			this.labelMemberName.Size = new System.Drawing.Size(120, 24);
			this.labelMemberName.TabIndex = 164;
			this.labelMemberName.Text = "Member Name";
			// 
			// labelAuthorCode
			// 
			this.labelAuthorCode.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelAuthorCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelAuthorCode.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelAuthorCode.Location = new System.Drawing.Point(256, 80);
			this.labelAuthorCode.Name = "labelAuthorCode";
			this.labelAuthorCode.Size = new System.Drawing.Size(120, 24);
			this.labelAuthorCode.TabIndex = 163;
			this.labelAuthorCode.Text = "Member ID";
			// 
			// textBoxBookName
			// 
			this.textBoxBookName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxBookName.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxBookName.Location = new System.Drawing.Point(384, 440);
			this.textBoxBookName.Name = "textBoxBookName";
			this.textBoxBookName.ReadOnly = true;
			this.textBoxBookName.Size = new System.Drawing.Size(536, 22);
			this.textBoxBookName.TabIndex = 175;
			this.textBoxBookName.TabStop = false;
			this.textBoxBookName.Text = "";
			// 
			// labelBookName
			// 
			this.labelBookName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBookName.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelBookName.Location = new System.Drawing.Point(256, 440);
			this.labelBookName.Name = "labelBookName";
			this.labelBookName.Size = new System.Drawing.Size(120, 24);
			this.labelBookName.TabIndex = 177;
			this.labelBookName.Text = "Book Name";
			// 
			// textBoxBarCodeNo
			// 
			this.textBoxBarCodeNo.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxBarCodeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxBarCodeNo.Location = new System.Drawing.Point(384, 408);
			this.textBoxBarCodeNo.Name = "textBoxBarCodeNo";
			this.textBoxBarCodeNo.Size = new System.Drawing.Size(200, 22);
			this.textBoxBarCodeNo.TabIndex = 2;
			this.textBoxBarCodeNo.Text = "";
			this.textBoxBarCodeNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxBarCodeNo_KeyDown);
			this.textBoxBarCodeNo.TextChanged += new System.EventHandler(this.textBoxBarCodeNo_TextChanged);
			this.textBoxBarCodeNo.Click += new System.EventHandler(this.textBoxBarCodeNo_Clicked);
			// 
			// labelBookCode
			// 
			this.labelBookCode.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelBookCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBookCode.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelBookCode.Location = new System.Drawing.Point(256, 408);
			this.labelBookCode.Name = "labelBookCode";
			this.labelBookCode.Size = new System.Drawing.Size(120, 24);
			this.labelBookCode.TabIndex = 176;
			this.labelBookCode.Text = "BarCode No";
			// 
			// labelBorrowDate
			// 
			this.labelBorrowDate.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelBorrowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBorrowDate.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelBorrowDate.Location = new System.Drawing.Point(256, 472);
			this.labelBorrowDate.Name = "labelBorrowDate";
			this.labelBorrowDate.Size = new System.Drawing.Size(120, 24);
			this.labelBorrowDate.TabIndex = 182;
			this.labelBorrowDate.Text = "Borrow Date";
			// 
			// dateTimePickerBorrowDate
			// 
			this.dateTimePickerBorrowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dateTimePickerBorrowDate.Location = new System.Drawing.Point(384, 472);
			this.dateTimePickerBorrowDate.Name = "dateTimePickerBorrowDate";
			this.dateTimePickerBorrowDate.TabIndex = 3;
			this.dateTimePickerBorrowDate.ValueChanged += new System.EventHandler(this.dateTimePickerBorrowDate_ValueChanged);
			// 
			// labelReturnDate
			// 
			this.labelReturnDate.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelReturnDate.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelReturnDate.Location = new System.Drawing.Point(592, 472);
			this.labelReturnDate.Name = "labelReturnDate";
			this.labelReturnDate.Size = new System.Drawing.Size(120, 24);
			this.labelReturnDate.TabIndex = 184;
			this.labelReturnDate.Text = "Return Date";
			// 
			// dateTimePickerReturnDate
			// 
			this.dateTimePickerReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dateTimePickerReturnDate.Location = new System.Drawing.Point(720, 472);
			this.dateTimePickerReturnDate.Name = "dateTimePickerReturnDate";
			this.dateTimePickerReturnDate.TabIndex = 4;
			this.dateTimePickerReturnDate.ValueChanged += new System.EventHandler(this.dateTimePickerReturnDate_ValueChanged);
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
			this.buttonSave.TabIndex = 188;
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
			this.buttonCancel.TabIndex = 189;
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
			this.buttonDelete.TabIndex = 187;
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
			this.buttonEdit.TabIndex = 186;
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
			this.buttonAdd.TabIndex = 185;
			this.buttonAdd.Text = "Add New";
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
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
			this.LabelTitle.TabIndex = 190;
			this.LabelTitle.Text = "    Borrow Book";
			this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBoxLogoPicture
			// 
			this.pictureBoxLogoPicture.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogoPicture.Image")));
			this.pictureBoxLogoPicture.Location = new System.Drawing.Point(32, 72);
			this.pictureBoxLogoPicture.Name = "pictureBoxLogoPicture";
			this.pictureBoxLogoPicture.Size = new System.Drawing.Size(144, 88);
			this.pictureBoxLogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxLogoPicture.TabIndex = 191;
			this.pictureBoxLogoPicture.TabStop = false;
			// 
			// buttonSearchMember
			// 
			this.buttonSearchMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonSearchMember.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonSearchMember.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearchMember.Image")));
			this.buttonSearchMember.Location = new System.Drawing.Point(600, 80);
			this.buttonSearchMember.Name = "buttonSearchMember";
			this.buttonSearchMember.Size = new System.Drawing.Size(88, 24);
			this.buttonSearchMember.TabIndex = 192;
			this.buttonSearchMember.Text = "Search";
			this.buttonSearchMember.Click += new System.EventHandler(this.buttonSearchMember_Click);
			// 
			// buttonBarCodeNo
			// 
			this.buttonBarCodeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonBarCodeNo.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonBarCodeNo.Image = ((System.Drawing.Image)(resources.GetObject("buttonBarCodeNo.Image")));
			this.buttonBarCodeNo.Location = new System.Drawing.Point(592, 408);
			this.buttonBarCodeNo.Name = "buttonBarCodeNo";
			this.buttonBarCodeNo.Size = new System.Drawing.Size(88, 24);
			this.buttonBarCodeNo.TabIndex = 193;
			this.buttonBarCodeNo.Text = "Search";
			this.buttonBarCodeNo.Click += new System.EventHandler(this.buttonBarCodeNo_Click);
			// 
			// FrmTransactionBorrow
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.buttonBarCodeNo);
			this.Controls.Add(this.buttonSearchMember);
			this.Controls.Add(this.pictureBoxLogoPicture);
			this.Controls.Add(this.LabelTitle);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonEdit);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.labelReturnDate);
			this.Controls.Add(this.dateTimePickerReturnDate);
			this.Controls.Add(this.labelBorrowDate);
			this.Controls.Add(this.dateTimePickerBorrowDate);
			this.Controls.Add(this.textBoxBookName);
			this.Controls.Add(this.labelBookName);
			this.Controls.Add(this.textBoxBarCodeNo);
			this.Controls.Add(this.labelBookCode);
			this.Controls.Add(this.dataGridBorrow);
			this.Controls.Add(this.textBoxMemberID);
			this.Controls.Add(this.textBoxMemberName);
			this.Controls.Add(this.labelMemberName);
			this.Controls.Add(this.labelAuthorCode);
			this.Name = "FrmTransactionBorrow";
			this.Load += new System.EventHandler(this.FrmTransactionBorrow_Load);
			this.Controls.SetChildIndex(this.labelAuthorCode, 0);
			this.Controls.SetChildIndex(this.labelMemberName, 0);
			this.Controls.SetChildIndex(this.textBoxMemberName, 0);
			this.Controls.SetChildIndex(this.textBoxMemberID, 0);
			this.Controls.SetChildIndex(this.dataGridBorrow, 0);
			this.Controls.SetChildIndex(this.labelBookCode, 0);
			this.Controls.SetChildIndex(this.textBoxBarCodeNo, 0);
			this.Controls.SetChildIndex(this.labelBookName, 0);
			this.Controls.SetChildIndex(this.textBoxBookName, 0);
			this.Controls.SetChildIndex(this.dateTimePickerBorrowDate, 0);
			this.Controls.SetChildIndex(this.labelBorrowDate, 0);
			this.Controls.SetChildIndex(this.dateTimePickerReturnDate, 0);
			this.Controls.SetChildIndex(this.labelReturnDate, 0);
			this.Controls.SetChildIndex(this.buttonAdd, 0);
			this.Controls.SetChildIndex(this.buttonEdit, 0);
			this.Controls.SetChildIndex(this.buttonDelete, 0);
			this.Controls.SetChildIndex(this.buttonCancel, 0);
			this.Controls.SetChildIndex(this.buttonSave, 0);
			this.Controls.SetChildIndex(this.LabelTitle, 0);
			this.Controls.SetChildIndex(this.pictureBoxLogoPicture, 0);
			this.Controls.SetChildIndex(this.buttonSearchMember, 0);
			this.Controls.SetChildIndex(this.buttonBarCodeNo, 0);
			((System.ComponentModel.ISupportInitialize)(this.dataGridBorrow)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void FrmTransactionBorrow_Load(object sender, System.EventArgs e)
		{
			MyDataTable = new DataTable();
			RefreshButton();
			MyBookTransaction = new BookTransaction();
			MyBookTransaction.LibrarianBorrow = MyMDIForm.LibrarianUserName.ToString();
			dateTimePickerReturnDate.Value = dateTimePickerBorrowDate.Value.Add(new System.TimeSpan(MyMDIForm.MyBorrowPeriod,0,0,0,0));
			textBoxMemberID.Focus();
		}

		private void textBoxMemberID_TextChanged(object sender, System.EventArgs e)
		{
			
		}
		private void textBoxMemberID_KeyDown(object sender,  System.Windows.Forms.KeyEventArgs  e)
		{
			
			if (e.KeyCode == Keys.Enter )
			{
				MyClassDatabase = new ClassDatabase();
				MyDataTable = MyClassDatabase.GetTransactionBorrow(textBoxMemberID.Text.ToString());
				dataGridBorrow.DataSource = MyDataTable;
				MyBookTransaction.MemberID = textBoxMemberID.Text.ToString();
				textBoxMemberName.Text = MyClassDatabase.GetMemberName(textBoxMemberID.Text.ToString());
				RefreshButton();
			}

		}
		private void textBoxMemberID_Clicked(object sender, System.EventArgs e)
		{
			
		}

		private void textBoxBarCodeNo_TextChanged(object sender, System.EventArgs e)
		{
			MyBookTransaction.BarCodeNo = textBoxBarCodeNo.Text.ToString();

		}
		private void textBoxBarCodeNo_Clicked(object sender, System.EventArgs e)
		{
		
		}
		private void textBoxBarCodeNo_KeyDown(object sender,  System.Windows.Forms.KeyEventArgs  e)
		{

			if (e.KeyCode == Keys.Enter&&MyStatusAdd == true)
			{
				MyBookTransaction.BarCodeNo = textBoxBarCodeNo.Text.ToString();
				MyClassDatabase = new ClassDatabase();
				MyDataTable = new DataTable();
				MyBookSearch = new BookSearch();
				MyBookSearch.BarCodeNo = textBoxBarCodeNo.Text.ToString().Trim();
				MyDataTable = MyClassDatabase.GetBookList2(MyBookSearch);
				if(MyDataTable.Rows.Count > 0)
				{
					textBoxBarCodeNo.Text   = MyDataTable.Rows[0][2].ToString().Trim();
					MyBookTransaction.BookCode = MyDataTable.Rows[0][0].ToString().Trim();
					textBoxBookName.Text = MyDataTable.Rows[0][3].ToString().Trim();
					MyClassDatabase = new ClassDatabase();
					if(MyClassDatabase.GetBookStatusOk(textBoxBarCodeNo.Text.ToString().Trim()) == false)
					{
						DialogResult ans;
				
						ans = MessageBox.Show("Are you sure you want to Force Borrow : '" + textBoxBookName.Text.ToString().Trim() + "' ?" , "Confirmation", MessageBoxButtons.YesNo );
						if (ans.ToString() == "Yes")
						{	
							MyClassDatabase = new ClassDatabase();
							MyClassDatabase.SetCopyStatusOk(textBoxBarCodeNo.Text.ToString().Trim());	
							MyBookTransaction.UpdateUser = MyMDIForm.LibrarianUserName.ToString();
							MyClassDatabase = new ClassDatabase();
							MyClassDatabase.SaveTransactionBorrow(MyBookTransaction);
							textBoxBarCodeNo.Text = "";
							MyClassDatabase = new ClassDatabase();
							MyDataTable = MyClassDatabase.GetTransactionBorrow(textBoxMemberID.Text.ToString());
							dataGridBorrow.DataSource = MyDataTable;
							textBoxBarCodeNo.Text = "";
							textBoxBarCodeNo.ReadOnly = false;
							textBoxBarCodeNo.Focus();
						}
						else 
						{
				
						}
					}
					else
					{
						MyBookTransaction.UpdateUser = MyMDIForm.LibrarianUserName.ToString();
						MyClassDatabase = new ClassDatabase();
						MyClassDatabase.SaveTransactionBorrow(MyBookTransaction);
						textBoxBarCodeNo.Text = "";
						MyClassDatabase = new ClassDatabase();
						MyDataTable = MyClassDatabase.GetTransactionBorrow(textBoxMemberID.Text.ToString());
						dataGridBorrow.DataSource = MyDataTable;
						textBoxBarCodeNo.Text = "";
						textBoxBarCodeNo.ReadOnly = false;
						textBoxBarCodeNo.Focus();
					}
					
				}
			}

		}
		private void dateTimePickerBorrowDate_ValueChanged(object sender, System.EventArgs e)
		{
			MyBookTransaction.BorrowDate = dateTimePickerBorrowDate.Value.ToShortDateString().ToString();
			dateTimePickerReturnDate.Value = dateTimePickerBorrowDate.Value.Add(new System.TimeSpan(MyMDIForm.MyBorrowPeriod,0,0,0,0));
		}

		private void dateTimePickerReturnDate_ValueChanged(object sender, System.EventArgs e)
		{
			MyBookTransaction.ReturnDate = dateTimePickerReturnDate.Value.ToShortDateString();
		}
	
		internal void DoLock()
		{
			buttonAdd.Enabled = true;
			buttonSave.Enabled = false;
			buttonCancel.Enabled = false;
			
			MyClassDatabase = new ClassDatabase();
			MyDataTable = MyClassDatabase.GetTransactionBorrow(textBoxMemberID.Text.ToString());
			dataGridBorrow.DataSource = MyDataTable;
			MyBookTransaction.MemberID = textBoxMemberID.Text.ToString();
			MyBookTransaction.BorrowSeq = "";
			MyBookTransaction.PreviousBorrowDate = "";
			MyBookTransaction.PreviousBookCode = "";
			MyBookTransaction.PreviousBarCodeNo  = "";
			textBoxBarCodeNo.ReadOnly = true;
			textBoxBarCodeNo.Text = "";
			textBoxBookName.Text = "";
			RefreshButton();
			MyStatusAdd = false;

		}
		private void DoUnlock()
		{
			textBoxBarCodeNo.Text = "";
			textBoxBarCodeNo.ReadOnly = false;
			textBoxBarCodeNo.Focus();
			
			buttonAdd.Enabled = false;
			buttonEdit.Enabled = false;
			buttonDelete.Enabled = false;
			buttonSave.Enabled = true;
			buttonCancel.Enabled = true;
			MyStatusAdd = true;
		}
		internal void RefreshButton()
		{
			if(MyDataTable.Rows.Count>0)
			{
				buttonEdit.Enabled = true;
				buttonDelete.Enabled = true;
			}
			else
			{
				buttonEdit.Enabled = false;
				buttonDelete.Enabled = false;
			}
			MyStatusEdit = false;
		}

		private void buttonAdd_Click(object sender, System.EventArgs e)
		{
			DoUnlock();
			MyBookTransaction.BorrowDate = dateTimePickerBorrowDate.Value.ToShortDateString().ToString();
			MyBookTransaction.ReturnDate = dateTimePickerReturnDate.Value.ToShortDateString();
		}
		private void buttonEdit_Click(object sender, System.EventArgs e)
		{
			DoUnlock();
			
			MyBookTransaction.PreviousBorrowDate = dataGridBorrow[dataGridBorrow.CurrentRowIndex,0].ToString().Trim();
			MyBookTransaction.BorrowSeq = dataGridBorrow[dataGridBorrow.CurrentRowIndex,2].ToString().Trim();
			MyBookTransaction.PreviousBookCode = dataGridBorrow[dataGridBorrow.CurrentRowIndex,3].ToString().Trim();
			textBoxBarCodeNo.Text = dataGridBorrow[dataGridBorrow.CurrentRowIndex,3].ToString().Trim();
			MyBookTransaction.PreviousBarCodeNo = dataGridBorrow[dataGridBorrow.CurrentRowIndex,4].ToString().Trim();
			textBoxBookName.Text = dataGridBorrow[dataGridBorrow.CurrentRowIndex,4].ToString().Trim();
			dateTimePickerBorrowDate.Value = Convert.ToDateTime(dataGridBorrow[dataGridBorrow.CurrentRowIndex,0].ToString().Trim());
			dateTimePickerReturnDate.Value = Convert.ToDateTime(dataGridBorrow[dataGridBorrow.CurrentRowIndex,5].ToString().Trim());
			MyStatusEdit = true;
		}
		private void buttonDelete_Click(object sender, System.EventArgs e)
		{
			DialogResult ans;
			ans = MessageBox.Show("Are you sure you want to delete Transaction Data with BorrowSeq ='" + dataGridBorrow[dataGridBorrow.CurrentRowIndex,2].ToString().Trim() + "' ?" , "Confirmation", MessageBoxButtons.YesNo );
			if (ans.ToString() == "Yes")
			{	
				MyClassDatabase = new ClassDatabase();
				MyClassDatabase.DeleteTransactionBorrow(dataGridBorrow[dataGridBorrow.CurrentRowIndex,0].ToString().Trim(), textBoxMemberID.Text.ToString(), dataGridBorrow[dataGridBorrow.CurrentRowIndex,2].ToString().Trim(),dataGridBorrow[dataGridBorrow.CurrentRowIndex,3].ToString().Trim(), dataGridBorrow[dataGridBorrow.CurrentRowIndex,4].ToString().Trim());

			
			}
			DoLock();
		}

		private void buttonSave_Click(object sender, System.EventArgs e)
		{
			if(textBoxMemberID.Text.ToString() == "")
			{
				MessageBox.Show("Please enter Member ID !", "Requirement");
			}
			else if(textBoxBarCodeNo.Text.ToString() == "")
			{
				MessageBox.Show("Please enter Book Code !", "Requirement");
			}
			else if(MyStatusEdit == true)
			{
				MyBookTransaction.UpdateUser = MyMDIForm.LibrarianUserName.ToString();
				MyClassDatabase = new ClassDatabase();
				MyClassDatabase.SaveTransactionBorrow(MyBookTransaction);
				textBoxBarCodeNo.Text = "";
				DoLock();
			}
			else 
			{
				MyBookTransaction.UpdateUser = MyMDIForm.LibrarianUserName.ToString();
				MyClassDatabase = new ClassDatabase();
				MyClassDatabase.SaveTransactionBorrow(MyBookTransaction);
				textBoxBarCodeNo.Text = "";
				DoLock();
			}
			DoLock();
		}
		private void buttonCancel_Click(object sender, System.EventArgs e)
		{
			DoLock();


		}

		private void buttonSearchMember_Click(object sender, System.EventArgs e)
		{
			MySearchMiniForm = new FrmSearchMiniForm(this, "Member");
			MySearchMiniForm.Show();

		}

		private void buttonBarCodeNo_Click(object sender, System.EventArgs e)
		{
			MySearchBookMiniForm = new  FrmSearchBookMiniForm(this, "Borrow");
			MySearchBookMiniForm.Show();
			MySearchBookMiniForm.DoClear();
		}



	}
}

