using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace Sola_Scriptura_Library
{
	public class FrmTransactionReturn : Sola_Scriptura_Library.FrmFormParent
	{
		internal System.Windows.Forms.Button buttonSave;
		internal System.Windows.Forms.Button buttonCancel;
		internal System.Windows.Forms.Button buttonDelete;
		internal System.Windows.Forms.Button buttonEdit;
		internal System.Windows.Forms.Button buttonAdd;
		internal System.Windows.Forms.DataGrid dataGridReturn;
		internal System.Windows.Forms.TextBox textBoxMemberID;
		internal System.Windows.Forms.TextBox textBoxMemberName;
		internal System.Windows.Forms.Label labelMemberName;
		internal System.Windows.Forms.Label labelAuthorCode;
		internal System.Windows.Forms.TextBox textBoxBorrowDate;
		internal System.Windows.Forms.Label labelBorrowDate;
		internal System.Windows.Forms.TextBox textBoxBorrowSeq;
		internal System.Windows.Forms.Label labelBorrowSeq;
		internal System.Windows.Forms.TextBox textBoxCopyNo;
		internal System.Windows.Forms.Label labelCopyNo;
		internal System.Windows.Forms.TextBox textBoxBookName;
		internal System.Windows.Forms.Label labelBookName;
		internal System.Windows.Forms.TextBox textBoxBookCode;
		internal System.Windows.Forms.Label labelBookCode;
		internal System.Windows.Forms.Label label1;
		internal System.Windows.Forms.DateTimePicker dateTimePickerActualReturnDate;
		internal System.Windows.Forms.Label LabelTitle;
		internal System.Windows.Forms.DataGridTableStyle dataGridTableStyleReturn;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnBorrowDate;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnMemberID;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnBorrowSeq;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnBookCode;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnBookName;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnCopyNo;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnReturnDate;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnActualReturnDate;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnFine;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnLibrarianBorrow;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnLibrarianReturn;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnUpdateUser;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnUpdateDate;
		private System.ComponentModel.IContainer components = null;

		
		internal ClassDatabase MyClassDatabase;
		internal DataTable MyDataTable;
		internal BookTransaction MyBookTransaction;
		internal System.Windows.Forms.TextBox textBoxFine;
		internal System.Windows.Forms.Label labelFine;
		internal FrmSearchMiniForm MySearchMiniForm;
		internal System.Windows.Forms.PictureBox pictureBoxLogoPicture;
		internal FrmTransactionMenu MyTransactionMenuForm;

		public FrmTransactionReturn()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public FrmTransactionReturn(FrmMDI MDIForm, FrmTransactionMenu TransactionMenuForm)
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmTransactionReturn));
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.dataGridReturn = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyleReturn = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnBorrowDate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnMemberID = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnBorrowSeq = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnBookCode = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnCopyNo = new System.Windows.Forms.DataGridTextBoxColumn();
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
			this.textBoxBorrowDate = new System.Windows.Forms.TextBox();
			this.labelBorrowDate = new System.Windows.Forms.Label();
			this.textBoxBorrowSeq = new System.Windows.Forms.TextBox();
			this.labelBorrowSeq = new System.Windows.Forms.Label();
			this.textBoxCopyNo = new System.Windows.Forms.TextBox();
			this.labelCopyNo = new System.Windows.Forms.Label();
			this.textBoxBookName = new System.Windows.Forms.TextBox();
			this.labelBookName = new System.Windows.Forms.Label();
			this.textBoxBookCode = new System.Windows.Forms.TextBox();
			this.labelBookCode = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dateTimePickerActualReturnDate = new System.Windows.Forms.DateTimePicker();
			this.LabelTitle = new System.Windows.Forms.Label();
			this.textBoxFine = new System.Windows.Forms.TextBox();
			this.labelFine = new System.Windows.Forms.Label();
			this.pictureBoxLogoPicture = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridReturn)).BeginInit();
			this.SuspendLayout();
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
			this.buttonSave.TabIndex = 5;
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
			this.buttonCancel.TabIndex = 6;
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
			this.buttonDelete.TabIndex = 197;
			this.buttonDelete.TabStop = false;
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
			this.buttonEdit.TabIndex = 4;
			this.buttonEdit.Text = "Edit";
			this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Enabled = false;
			this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonAdd.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonAdd.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd.Image")));
			this.buttonAdd.Location = new System.Drawing.Point(248, 520);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(88, 32);
			this.buttonAdd.TabIndex = 195;
			this.buttonAdd.TabStop = false;
			this.buttonAdd.Text = "Add New";
			// 
			// dataGridReturn
			// 
			this.dataGridReturn.DataMember = "";
			this.dataGridReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGridReturn.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridReturn.Location = new System.Drawing.Point(248, 144);
			this.dataGridReturn.Name = "dataGridReturn";
			this.dataGridReturn.ReadOnly = true;
			this.dataGridReturn.Size = new System.Drawing.Size(672, 232);
			this.dataGridReturn.TabIndex = 194;
			this.dataGridReturn.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																									   this.dataGridTableStyleReturn});
			// 
			// dataGridTableStyleReturn
			// 
			this.dataGridTableStyleReturn.AlternatingBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleReturn.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.dataGridTableStyleReturn.DataGrid = this.dataGridReturn;
			this.dataGridTableStyleReturn.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleReturn.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																													   this.dataGridTextBoxColumnBorrowDate,
																													   this.dataGridTextBoxColumnMemberID,
																													   this.dataGridTextBoxColumnBorrowSeq,
																													   this.dataGridTextBoxColumnBookCode,
																													   this.dataGridTextBoxColumnCopyNo,
																													   this.dataGridTextBoxColumnBookName,
																													   this.dataGridTextBoxColumnReturnDate,
																													   this.dataGridTextBoxColumnActualReturnDate,
																													   this.dataGridTextBoxColumnFine,
																													   this.dataGridTextBoxColumnLibrarianBorrow,
																													   this.dataGridTextBoxColumnLibrarianReturn,
																													   this.dataGridTextBoxColumnUpdateUser,
																													   this.dataGridTextBoxColumnUpdateDate});
			this.dataGridTableStyleReturn.GridLineColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridTableStyleReturn.HeaderBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleReturn.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleReturn.MappingName = "BorrowData";
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
			// dataGridTextBoxColumnCopyNo
			// 
			this.dataGridTextBoxColumnCopyNo.Format = "";
			this.dataGridTextBoxColumnCopyNo.FormatInfo = null;
			this.dataGridTextBoxColumnCopyNo.HeaderText = "Copy No";
			this.dataGridTextBoxColumnCopyNo.MappingName = "CopyNo";
			this.dataGridTextBoxColumnCopyNo.Width = 75;
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
			this.dataGridTextBoxColumnActualReturnDate.HeaderText = "Actual Return Date";
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
			this.dataGridTextBoxColumnLibrarianBorrow.MappingName = "Librarian Borrow";
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
			this.textBoxMemberID.ReadOnly = true;
			this.textBoxMemberID.Size = new System.Drawing.Size(200, 22);
			this.textBoxMemberID.TabIndex = 1;
			this.textBoxMemberID.Text = "";
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
			this.textBoxMemberName.TabIndex = 191;
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
			this.labelMemberName.TabIndex = 193;
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
			this.labelAuthorCode.TabIndex = 192;
			this.labelAuthorCode.Text = "Member ID";
			// 
			// textBoxBorrowDate
			// 
			this.textBoxBorrowDate.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxBorrowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxBorrowDate.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxBorrowDate.Location = new System.Drawing.Point(384, 384);
			this.textBoxBorrowDate.Name = "textBoxBorrowDate";
			this.textBoxBorrowDate.ReadOnly = true;
			this.textBoxBorrowDate.Size = new System.Drawing.Size(200, 22);
			this.textBoxBorrowDate.TabIndex = 200;
			this.textBoxBorrowDate.TabStop = false;
			this.textBoxBorrowDate.Text = "";
			this.textBoxBorrowDate.TextChanged += new System.EventHandler(this.textBoxBorrowDate_TextChanged);
			// 
			// labelBorrowDate
			// 
			this.labelBorrowDate.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelBorrowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBorrowDate.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelBorrowDate.Location = new System.Drawing.Point(256, 384);
			this.labelBorrowDate.Name = "labelBorrowDate";
			this.labelBorrowDate.Size = new System.Drawing.Size(120, 24);
			this.labelBorrowDate.TabIndex = 201;
			this.labelBorrowDate.Text = "Borrow Date";
			// 
			// textBoxBorrowSeq
			// 
			this.textBoxBorrowSeq.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxBorrowSeq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxBorrowSeq.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxBorrowSeq.Location = new System.Drawing.Point(720, 384);
			this.textBoxBorrowSeq.Name = "textBoxBorrowSeq";
			this.textBoxBorrowSeq.ReadOnly = true;
			this.textBoxBorrowSeq.Size = new System.Drawing.Size(200, 22);
			this.textBoxBorrowSeq.TabIndex = 202;
			this.textBoxBorrowSeq.TabStop = false;
			this.textBoxBorrowSeq.Text = "";
			this.textBoxBorrowSeq.TextChanged += new System.EventHandler(this.textBoxBorrowSeq_TextChanged);
			// 
			// labelBorrowSeq
			// 
			this.labelBorrowSeq.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelBorrowSeq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBorrowSeq.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelBorrowSeq.Location = new System.Drawing.Point(592, 384);
			this.labelBorrowSeq.Name = "labelBorrowSeq";
			this.labelBorrowSeq.Size = new System.Drawing.Size(120, 24);
			this.labelBorrowSeq.TabIndex = 203;
			this.labelBorrowSeq.Text = "Borrow Seq";
			// 
			// textBoxCopyNo
			// 
			this.textBoxCopyNo.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxCopyNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxCopyNo.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxCopyNo.Location = new System.Drawing.Point(720, 416);
			this.textBoxCopyNo.Name = "textBoxCopyNo";
			this.textBoxCopyNo.ReadOnly = true;
			this.textBoxCopyNo.Size = new System.Drawing.Size(200, 22);
			this.textBoxCopyNo.TabIndex = 208;
			this.textBoxCopyNo.TabStop = false;
			this.textBoxCopyNo.Text = "";
			this.textBoxCopyNo.TextChanged += new System.EventHandler(this.textBoxCopyNo_TextChanged);
			// 
			// labelCopyNo
			// 
			this.labelCopyNo.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelCopyNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelCopyNo.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelCopyNo.Location = new System.Drawing.Point(592, 416);
			this.labelCopyNo.Name = "labelCopyNo";
			this.labelCopyNo.Size = new System.Drawing.Size(120, 24);
			this.labelCopyNo.TabIndex = 209;
			this.labelCopyNo.Text = "Copy No";
			// 
			// textBoxBookName
			// 
			this.textBoxBookName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxBookName.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxBookName.Location = new System.Drawing.Point(384, 448);
			this.textBoxBookName.Name = "textBoxBookName";
			this.textBoxBookName.ReadOnly = true;
			this.textBoxBookName.Size = new System.Drawing.Size(536, 22);
			this.textBoxBookName.TabIndex = 205;
			this.textBoxBookName.TabStop = false;
			this.textBoxBookName.Text = "";
			this.textBoxBookName.TextChanged += new System.EventHandler(this.textBoxBookName_TextChanged);
			// 
			// labelBookName
			// 
			this.labelBookName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBookName.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelBookName.Location = new System.Drawing.Point(256, 448);
			this.labelBookName.Name = "labelBookName";
			this.labelBookName.Size = new System.Drawing.Size(120, 24);
			this.labelBookName.TabIndex = 207;
			this.labelBookName.Text = "Book Name";
			// 
			// textBoxBookCode
			// 
			this.textBoxBookCode.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxBookCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxBookCode.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxBookCode.Location = new System.Drawing.Point(384, 416);
			this.textBoxBookCode.Name = "textBoxBookCode";
			this.textBoxBookCode.ReadOnly = true;
			this.textBoxBookCode.Size = new System.Drawing.Size(200, 22);
			this.textBoxBookCode.TabIndex = 204;
			this.textBoxBookCode.TabStop = false;
			this.textBoxBookCode.Text = "";
			this.textBoxBookCode.TextChanged += new System.EventHandler(this.textBoxBookCode_TextChanged);
			// 
			// labelBookCode
			// 
			this.labelBookCode.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelBookCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBookCode.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelBookCode.Location = new System.Drawing.Point(256, 416);
			this.labelBookCode.Name = "labelBookCode";
			this.labelBookCode.Size = new System.Drawing.Size(120, 24);
			this.labelBookCode.TabIndex = 206;
			this.labelBookCode.Text = "Book Code";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label1.Location = new System.Drawing.Point(256, 480);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 24);
			this.label1.TabIndex = 211;
			this.label1.Text = "Actual Return Date";
			// 
			// dateTimePickerActualReturnDate
			// 
			this.dateTimePickerActualReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dateTimePickerActualReturnDate.Location = new System.Drawing.Point(384, 480);
			this.dateTimePickerActualReturnDate.Name = "dateTimePickerActualReturnDate";
			this.dateTimePickerActualReturnDate.TabIndex = 2;
			this.dateTimePickerActualReturnDate.ValueChanged += new System.EventHandler(this.dateTimePickerActualReturnDate_ValueChanged);
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
			this.LabelTitle.TabIndex = 212;
			this.LabelTitle.Text = "    Return Book";
			this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBoxFine
			// 
			this.textBoxFine.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxFine.Location = new System.Drawing.Point(720, 480);
			this.textBoxFine.Name = "textBoxFine";
			this.textBoxFine.Size = new System.Drawing.Size(200, 22);
			this.textBoxFine.TabIndex = 3;
			this.textBoxFine.Text = "";
			this.textBoxFine.TextChanged += new System.EventHandler(this.textBoxFine_TextChanged);
			// 
			// labelFine
			// 
			this.labelFine.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelFine.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelFine.Location = new System.Drawing.Point(592, 480);
			this.labelFine.Name = "labelFine";
			this.labelFine.Size = new System.Drawing.Size(120, 24);
			this.labelFine.TabIndex = 214;
			this.labelFine.Text = "Fine";
			// 
			// pictureBoxLogoPicture
			// 
			this.pictureBoxLogoPicture.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogoPicture.Image")));
			this.pictureBoxLogoPicture.Location = new System.Drawing.Point(32, 72);
			this.pictureBoxLogoPicture.Name = "pictureBoxLogoPicture";
			this.pictureBoxLogoPicture.Size = new System.Drawing.Size(144, 88);
			this.pictureBoxLogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxLogoPicture.TabIndex = 215;
			this.pictureBoxLogoPicture.TabStop = false;
			// 
			// FrmTransactionReturn
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.pictureBoxLogoPicture);
			this.Controls.Add(this.textBoxFine);
			this.Controls.Add(this.labelFine);
			this.Controls.Add(this.LabelTitle);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dateTimePickerActualReturnDate);
			this.Controls.Add(this.textBoxCopyNo);
			this.Controls.Add(this.labelCopyNo);
			this.Controls.Add(this.textBoxBookName);
			this.Controls.Add(this.labelBookName);
			this.Controls.Add(this.textBoxBookCode);
			this.Controls.Add(this.labelBookCode);
			this.Controls.Add(this.textBoxBorrowSeq);
			this.Controls.Add(this.labelBorrowSeq);
			this.Controls.Add(this.textBoxBorrowDate);
			this.Controls.Add(this.labelBorrowDate);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonEdit);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.dataGridReturn);
			this.Controls.Add(this.textBoxMemberID);
			this.Controls.Add(this.textBoxMemberName);
			this.Controls.Add(this.labelMemberName);
			this.Controls.Add(this.labelAuthorCode);
			this.Name = "FrmTransactionReturn";
			this.Load += new System.EventHandler(this.FrmTransactionReturn_Load);
			this.Controls.SetChildIndex(this.labelAuthorCode, 0);
			this.Controls.SetChildIndex(this.labelMemberName, 0);
			this.Controls.SetChildIndex(this.textBoxMemberName, 0);
			this.Controls.SetChildIndex(this.textBoxMemberID, 0);
			this.Controls.SetChildIndex(this.dataGridReturn, 0);
			this.Controls.SetChildIndex(this.buttonAdd, 0);
			this.Controls.SetChildIndex(this.buttonEdit, 0);
			this.Controls.SetChildIndex(this.buttonDelete, 0);
			this.Controls.SetChildIndex(this.buttonCancel, 0);
			this.Controls.SetChildIndex(this.buttonSave, 0);
			this.Controls.SetChildIndex(this.labelBorrowDate, 0);
			this.Controls.SetChildIndex(this.textBoxBorrowDate, 0);
			this.Controls.SetChildIndex(this.labelBorrowSeq, 0);
			this.Controls.SetChildIndex(this.textBoxBorrowSeq, 0);
			this.Controls.SetChildIndex(this.labelBookCode, 0);
			this.Controls.SetChildIndex(this.textBoxBookCode, 0);
			this.Controls.SetChildIndex(this.labelBookName, 0);
			this.Controls.SetChildIndex(this.textBoxBookName, 0);
			this.Controls.SetChildIndex(this.labelCopyNo, 0);
			this.Controls.SetChildIndex(this.textBoxCopyNo, 0);
			this.Controls.SetChildIndex(this.dateTimePickerActualReturnDate, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.LabelTitle, 0);
			this.Controls.SetChildIndex(this.labelFine, 0);
			this.Controls.SetChildIndex(this.textBoxFine, 0);
			this.Controls.SetChildIndex(this.pictureBoxLogoPicture, 0);
			((System.ComponentModel.ISupportInitialize)(this.dataGridReturn)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void FrmTransactionReturn_Load(object sender, System.EventArgs e)
		{
			MyBookTransaction = new BookTransaction();
		}
		private void textBoxMemberID_TextChanged(object sender, System.EventArgs e)
		{
			MyClassDatabase = new ClassDatabase();
			MyDataTable = MyClassDatabase.GetTransactionBorrow(textBoxMemberID.Text.ToString());
			dataGridReturn.DataSource = MyDataTable;
			MyBookTransaction.MemberID = textBoxMemberID.Text.ToString();
			RefreshButton();
		}
		private void textBoxMemberID_Clicked(object sender, System.EventArgs e)
		{
			MySearchMiniForm = new FrmSearchMiniForm(this, "Member2");
			MySearchMiniForm.Show();
		}
		private void textBoxBorrowDate_TextChanged(object sender, System.EventArgs e)
		{
			MyBookTransaction.BorrowDate = textBoxBorrowDate.Text.ToString();
		}

		private void textBoxBorrowSeq_TextChanged(object sender, System.EventArgs e)
		{
			MyBookTransaction.BorrowSeq = textBoxBorrowSeq.Text.ToString();
		}

		private void textBoxBookCode_TextChanged(object sender, System.EventArgs e)
		{
			MyBookTransaction.BookCode = textBoxBookCode.Text.ToString();
		}

		private void textBoxCopyNo_TextChanged(object sender, System.EventArgs e)
		{
			MyBookTransaction.CopyNo = textBoxCopyNo.Text.ToString();
		}

		private void textBoxBookName_TextChanged(object sender, System.EventArgs e)
		{
			
		}
		private void dateTimePickerActualReturnDate_ValueChanged(object sender, System.EventArgs e)
		{
			MyBookTransaction.ActualReturnDate = dateTimePickerActualReturnDate.Value.ToShortDateString();
			System.TimeSpan DateDiff;
			DateDiff = Convert.ToDateTime(dateTimePickerActualReturnDate.Text.ToString())-Convert.ToDateTime(dataGridReturn[dataGridReturn.CurrentRowIndex,6].ToString().Trim());
			int DayDiff = DateDiff.Days;
			if(DayDiff > 0)
			{
				textBoxFine.Text = Convert.ToDecimal(MyMDIForm.MyFine * Convert.ToDecimal(DayDiff)).ToString();
							
			}
			else
			{
				textBoxFine.Text = "0";
			}
		}

		internal void DoLock()
		{
			
			buttonSave.Enabled = false;
			buttonCancel.Enabled = false;
			
			MyClassDatabase = new ClassDatabase();
			MyDataTable = MyClassDatabase.GetTransactionBorrow(textBoxMemberID.Text.ToString());
			dataGridReturn.DataSource = MyDataTable;
			MyBookTransaction.MemberID = textBoxMemberID.Text.ToString();
			textBoxBorrowDate.Text = "";
			textBoxBorrowSeq.Text = "";
			textBoxBookCode.Text = "";
			textBoxCopyNo.Text = "";
			textBoxBookName.Text = "";
			textBoxFine.Text = "";

			RefreshButton();


		}
		private void DoUnlock()
		{
			dateTimePickerActualReturnDate.Focus();
			buttonAdd.Enabled = false;
			buttonEdit.Enabled = false;
			buttonDelete.Enabled = false;
			buttonSave.Enabled = true;
			buttonCancel.Enabled = true;
		}
		internal void RefreshButton()
		{
			if(MyDataTable.Rows.Count>0)
			{
				buttonEdit.Enabled = true;

			}
			else
			{
				buttonEdit.Enabled = false;

			}
		}


		private void buttonEdit_Click(object sender, System.EventArgs e)
		{
			DoUnlock();

			MyBookTransaction.ActualReturnDate = dateTimePickerActualReturnDate.Value.ToShortDateString();
			textBoxBorrowDate.Text = Convert.ToDateTime(dataGridReturn[dataGridReturn.CurrentRowIndex,0].ToString().Trim()).ToLongDateString();
			textBoxBorrowSeq.Text = dataGridReturn[dataGridReturn.CurrentRowIndex,2].ToString().Trim();
			textBoxBookCode.Text = dataGridReturn[dataGridReturn.CurrentRowIndex,3].ToString().Trim();
			textBoxCopyNo.Text = dataGridReturn[dataGridReturn.CurrentRowIndex,4].ToString().Trim();
			textBoxBookName.Text = dataGridReturn[dataGridReturn.CurrentRowIndex,5].ToString().Trim();

			System.TimeSpan DateDiff;
			DateDiff = Convert.ToDateTime(dateTimePickerActualReturnDate.Text.ToString())-Convert.ToDateTime(dataGridReturn[dataGridReturn.CurrentRowIndex,6].ToString().Trim());
			int DayDiff = DateDiff.Days;
			if(DayDiff > 0)
			{
				textBoxFine.Text = Convert.ToDecimal(MyMDIForm.MyFine * Convert.ToDecimal(DayDiff)).ToString();
							
			}
			else
			{
				textBoxFine.Text = "0";
			}
		}


		private void buttonSave_Click(object sender, System.EventArgs e)
		{
			if(IsNumeric(MyBookTransaction.Fine)== true||MyBookTransaction.Fine =="")
			{
				MyBookTransaction.UpdateUser = MyMDIForm.LibrarianUserName.ToString();
				MyBookTransaction.LibrarianReturn = MyMDIForm.LibrarianUserName.ToString();
				MyClassDatabase = new ClassDatabase();
				MyClassDatabase.SaveTransactionReturn(MyBookTransaction);
				DoLock();
			}
			else
			{
				MessageBox.Show("Please Enter numeric value in Fine", "Requirement");
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

		private void textBoxFine_TextChanged(object sender, System.EventArgs e)
		{
			MyBookTransaction.Fine = textBoxFine.Text.ToString();
			if(textBoxFine.Text.ToString() == "") MyBookTransaction.Fine = "0";
													 
		}


	}
}

