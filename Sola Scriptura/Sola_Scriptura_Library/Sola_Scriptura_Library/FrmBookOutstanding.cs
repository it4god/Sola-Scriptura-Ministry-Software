using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace Sola_Scriptura_Library
{
	public class FrmBookOutstanding : Sola_Scriptura_Library.FrmFormParent
	{
		internal System.Windows.Forms.Label LabelTitle;
		internal System.Windows.Forms.TextBox textBoxMemberName;
		internal System.Windows.Forms.Label labelMemberName;
		internal System.Windows.Forms.Label label2;
		internal System.Windows.Forms.TextBox textBoxBookName;
		internal System.Windows.Forms.Label labelBookName;
		internal System.Windows.Forms.TextBox textBoxBookCode;
		internal System.Windows.Forms.Label labelBookCode;
		internal System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		internal System.Windows.Forms.TextBox textBoxBorrowDate;
		internal System.Windows.Forms.Label labelBorrowDate;
		internal System.Windows.Forms.Button buttonClear;
		internal System.Windows.Forms.Button buttonRefresh;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnBorrowDate;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnMemberID;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnMemberName;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnBorrowSeq;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnBookCode;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnCopyNo;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnBookName;
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
		internal System.Windows.Forms.TextBox textBoxMemberID;
		internal System.Windows.Forms.DataGrid dataGridBookOutstanding;
		internal DataView MyDataView;
		internal System.Windows.Forms.PictureBox pictureBoxLogoPicture;
		internal FrmSearchMiniForm MySearchMiniForm;

		public FrmBookOutstanding()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmBookOutstanding));
			this.LabelTitle = new System.Windows.Forms.Label();
			this.dataGridBookOutstanding = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnBorrowDate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnReturnDate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnBorrowSeq = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnBookCode = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnBookName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnCopyNo = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnMemberID = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnMemberName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnActualReturnDate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnFine = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnLibrarianBorrow = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnLibrarianReturn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnUpdateUser = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnUpdateDate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.textBoxBorrowDate = new System.Windows.Forms.TextBox();
			this.textBoxMemberName = new System.Windows.Forms.TextBox();
			this.labelMemberName = new System.Windows.Forms.Label();
			this.labelBorrowDate = new System.Windows.Forms.Label();
			this.textBoxMemberID = new System.Windows.Forms.TextBox();
			this.textBoxBookName = new System.Windows.Forms.TextBox();
			this.labelBookName = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxBookCode = new System.Windows.Forms.TextBox();
			this.labelBookCode = new System.Windows.Forms.Label();
			this.buttonClear = new System.Windows.Forms.Button();
			this.buttonRefresh = new System.Windows.Forms.Button();
			this.pictureBoxLogoPicture = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridBookOutstanding)).BeginInit();
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
			this.LabelTitle.TabIndex = 116;
			this.LabelTitle.Text = "    Book Outstanding";
			this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dataGridBookOutstanding
			// 
			this.dataGridBookOutstanding.DataMember = "";
			this.dataGridBookOutstanding.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGridBookOutstanding.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridBookOutstanding.Location = new System.Drawing.Point(248, 216);
			this.dataGridBookOutstanding.Name = "dataGridBookOutstanding";
			this.dataGridBookOutstanding.ReadOnly = true;
			this.dataGridBookOutstanding.Size = new System.Drawing.Size(672, 336);
			this.dataGridBookOutstanding.TabIndex = 199;
			this.dataGridBookOutstanding.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																												this.dataGridTableStyle1});
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyle1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.dataGridTableStyle1.DataGrid = this.dataGridBookOutstanding;
			this.dataGridTableStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.dataGridTextBoxColumnBorrowDate,
																												  this.dataGridTextBoxColumnReturnDate,
																												  this.dataGridTextBoxColumnBorrowSeq,
																												  this.dataGridTextBoxColumnBookCode,
																												  this.dataGridTextBoxColumnBookName,
																												  this.dataGridTextBoxColumnCopyNo,
																												  this.dataGridTextBoxColumnMemberID,
																												  this.dataGridTextBoxColumnMemberName,
																												  this.dataGridTextBoxColumnActualReturnDate,
																												  this.dataGridTextBoxColumnFine,
																												  this.dataGridTextBoxColumnLibrarianBorrow,
																												  this.dataGridTextBoxColumnLibrarianReturn,
																												  this.dataGridTextBoxColumnUpdateUser,
																												  this.dataGridTextBoxColumnUpdateDate});
			this.dataGridTableStyle1.GridLineColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridTableStyle1.HeaderBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyle1.MappingName = "BookOutstanding";
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
			this.dataGridTextBoxColumnMemberID.HeaderText = "Member ID";
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
			// textBoxBorrowDate
			// 
			this.textBoxBorrowDate.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxBorrowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxBorrowDate.ForeColor = System.Drawing.SystemColors.WindowText;
			this.textBoxBorrowDate.Location = new System.Drawing.Point(384, 80);
			this.textBoxBorrowDate.Name = "textBoxBorrowDate";
			this.textBoxBorrowDate.ReadOnly = true;
			this.textBoxBorrowDate.Size = new System.Drawing.Size(200, 22);
			this.textBoxBorrowDate.TabIndex = 1;
			this.textBoxBorrowDate.Text = "";
			this.textBoxBorrowDate.TextChanged += new System.EventHandler(this.textBoxBorrowDate_TextChanged);
			this.textBoxBorrowDate.Click += new System.EventHandler(this.textBoxBorrowDate_Clicked);
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
			this.textBoxMemberName.TabIndex = 196;
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
			this.labelMemberName.TabIndex = 198;
			this.labelMemberName.Text = "Member Name";
			// 
			// labelBorrowDate
			// 
			this.labelBorrowDate.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelBorrowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBorrowDate.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelBorrowDate.Location = new System.Drawing.Point(256, 80);
			this.labelBorrowDate.Name = "labelBorrowDate";
			this.labelBorrowDate.Size = new System.Drawing.Size(120, 24);
			this.labelBorrowDate.TabIndex = 197;
			this.labelBorrowDate.Text = "Borrow Date";
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
			this.textBoxMemberID.TabIndex = 2;
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
			this.textBoxBookName.TabIndex = 205;
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
			this.labelBookName.TabIndex = 207;
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
			this.label2.TabIndex = 206;
			this.label2.Text = "Member ID";
			// 
			// textBoxBookCode
			// 
			this.textBoxBookCode.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxBookCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxBookCode.ForeColor = System.Drawing.SystemColors.WindowText;
			this.textBoxBookCode.Location = new System.Drawing.Point(384, 144);
			this.textBoxBookCode.Name = "textBoxBookCode";
			this.textBoxBookCode.Size = new System.Drawing.Size(200, 22);
			this.textBoxBookCode.TabIndex = 3;
			this.textBoxBookCode.Text = "";
			this.textBoxBookCode.TextChanged += new System.EventHandler(this.textBoxBookCode_TextChanged);
			this.textBoxBookCode.Click += new System.EventHandler(this.textBoxBookCode_Clicked);
			// 
			// labelBookCode
			// 
			this.labelBookCode.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelBookCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBookCode.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelBookCode.Location = new System.Drawing.Point(256, 144);
			this.labelBookCode.Name = "labelBookCode";
			this.labelBookCode.Size = new System.Drawing.Size(120, 24);
			this.labelBookCode.TabIndex = 209;
			this.labelBookCode.Text = "Book Code";
			// 
			// buttonClear
			// 
			this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonClear.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonClear.Image = ((System.Drawing.Image)(resources.GetObject("buttonClear.Image")));
			this.buttonClear.Location = new System.Drawing.Point(728, 176);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(88, 32);
			this.buttonClear.TabIndex = 210;
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
			this.buttonRefresh.TabIndex = 211;
			this.buttonRefresh.Text = "Refresh";
			this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
			// 
			// pictureBoxLogoPicture
			// 
			this.pictureBoxLogoPicture.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogoPicture.Image")));
			this.pictureBoxLogoPicture.Location = new System.Drawing.Point(32, 72);
			this.pictureBoxLogoPicture.Name = "pictureBoxLogoPicture";
			this.pictureBoxLogoPicture.Size = new System.Drawing.Size(144, 88);
			this.pictureBoxLogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxLogoPicture.TabIndex = 216;
			this.pictureBoxLogoPicture.TabStop = false;
			// 
			// FrmBookOutstanding
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.pictureBoxLogoPicture);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.buttonRefresh);
			this.Controls.Add(this.textBoxBookCode);
			this.Controls.Add(this.labelBookCode);
			this.Controls.Add(this.textBoxMemberID);
			this.Controls.Add(this.textBoxBookName);
			this.Controls.Add(this.labelBookName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGridBookOutstanding);
			this.Controls.Add(this.textBoxBorrowDate);
			this.Controls.Add(this.textBoxMemberName);
			this.Controls.Add(this.labelMemberName);
			this.Controls.Add(this.labelBorrowDate);
			this.Controls.Add(this.LabelTitle);
			this.Name = "FrmBookOutstanding";
			this.Load += new System.EventHandler(this.FrmBookOutstanding_Load);
			this.Controls.SetChildIndex(this.LabelTitle, 0);
			this.Controls.SetChildIndex(this.labelBorrowDate, 0);
			this.Controls.SetChildIndex(this.labelMemberName, 0);
			this.Controls.SetChildIndex(this.textBoxMemberName, 0);
			this.Controls.SetChildIndex(this.textBoxBorrowDate, 0);
			this.Controls.SetChildIndex(this.dataGridBookOutstanding, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.labelBookName, 0);
			this.Controls.SetChildIndex(this.textBoxBookName, 0);
			this.Controls.SetChildIndex(this.textBoxMemberID, 0);
			this.Controls.SetChildIndex(this.labelBookCode, 0);
			this.Controls.SetChildIndex(this.textBoxBookCode, 0);
			this.Controls.SetChildIndex(this.buttonRefresh, 0);
			this.Controls.SetChildIndex(this.buttonClear, 0);
			this.Controls.SetChildIndex(this.pictureBoxLogoPicture, 0);
			((System.ComponentModel.ISupportInitialize)(this.dataGridBookOutstanding)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion



		private void FrmBookOutstanding_Load(object sender, System.EventArgs e)
		{
			MyClassDatabase = new ClassDatabase();
			MyDataTable = MyClassDatabase.GetBookOutstanding();
			if(textBoxBorrowDate.Text.ToString()!="")
				MyDataView = new DataView(MyDataTable, "BorrowDate = '" + Convert.ToDateTime(textBoxBorrowDate.Text.ToString()).Month + "/" + Convert.ToDateTime(textBoxBorrowDate.Text.ToString()).Day + "/" + Convert.ToDateTime(textBoxBorrowDate.Text.ToString()).Year + "' and MemberID LIKE '%" + textBoxMemberID.Text.ToString() + "%' and BookCode LIKE '%" + textBoxBookCode.Text.ToString() + "' and BookName LIKE '%" + textBoxBookName.Text.ToString() + "%' ", "BorrowDate", DataViewRowState.CurrentRows);
			else
				MyDataView = new DataView(MyDataTable, "MemberID LIKE '%" + textBoxMemberID.Text.ToString() + "%' and BookCode LIKE '%" + textBoxBookCode.Text.ToString() + "%' and BookName LIKE '%" + textBoxBookName.Text.ToString() + "%' ", "BorrowDate", DataViewRowState.CurrentRows);
			dataGridBookOutstanding.DataSource = MyDataView;
		}
		
		private void textBoxBorrowDate_TextChanged(object sender, System.EventArgs e)
		{
			if(textBoxBorrowDate.Text.ToString()!="")
				MyDataView = new DataView(MyDataTable, "BorrowDate = '" + Convert.ToDateTime(textBoxBorrowDate.Text.ToString()).Month + "/" + Convert.ToDateTime(textBoxBorrowDate.Text.ToString()).Day + "/" + Convert.ToDateTime(textBoxBorrowDate.Text.ToString()).Year + "' and MemberID LIKE '%" + textBoxMemberID.Text.ToString() + "%' and BookCode LIKE '%" + textBoxBookCode.Text.ToString() + "' and BookName LIKE '%" + textBoxBookName.Text.ToString() + "%' ", "BorrowDate", DataViewRowState.CurrentRows);
			else
				MyDataView = new DataView(MyDataTable, "MemberID LIKE '%" + textBoxMemberID.Text.ToString() + "%' and BookCode LIKE '%" + textBoxBookCode.Text.ToString() + "%' and BookName LIKE '%" + textBoxBookName.Text.ToString() + "%' ", "BorrowDate", DataViewRowState.CurrentRows);
			dataGridBookOutstanding.DataSource = MyDataView;
		}
		private void textBoxBorrowDate_Clicked(object sender, System.EventArgs e)
		{
			MySearchMiniForm = new FrmSearchMiniForm(this,"BookOutstandingBorrowDate");
			MySearchMiniForm.Show();
		}

		private void textBoxMemberID_TextChanged(object sender, System.EventArgs e)
		{
			if(textBoxBorrowDate.Text.ToString()!="")
				MyDataView = new DataView(MyDataTable, "BorrowDate = '" + Convert.ToDateTime(textBoxBorrowDate.Text.ToString()).Month + "/" + Convert.ToDateTime(textBoxBorrowDate.Text.ToString()).Day + "/" + Convert.ToDateTime(textBoxBorrowDate.Text.ToString()).Year + "' and MemberID LIKE '%" + textBoxMemberID.Text.ToString() + "%' and BookCode LIKE '%" + textBoxBookCode.Text.ToString() + "' and BookName LIKE '%" + textBoxBookName.Text.ToString() + "%' ", "BorrowDate", DataViewRowState.CurrentRows);
			else
				MyDataView = new DataView(MyDataTable, "MemberID LIKE '%" + textBoxMemberID.Text.ToString() + "%' and BookCode LIKE '%" + textBoxBookCode.Text.ToString() + "%' and BookName LIKE '%" + textBoxBookName.Text.ToString() + "%' ", "BorrowDate", DataViewRowState.CurrentRows);
			dataGridBookOutstanding.DataSource = MyDataView;
		}
		private void textBoxMemberID_Clicked(object sender, System.EventArgs e)
		{
			MySearchMiniForm = new FrmSearchMiniForm(this,"BookOutstandingMember");
			MySearchMiniForm.Show();
		}

		private void textBoxBookCode_TextChanged(object sender, System.EventArgs e)
		{
			if(textBoxBorrowDate.Text.ToString()!="")
				MyDataView = new DataView(MyDataTable, "BorrowDate = '" + Convert.ToDateTime(textBoxBorrowDate.Text.ToString()).Month + "/" + Convert.ToDateTime(textBoxBorrowDate.Text.ToString()).Day + "/" + Convert.ToDateTime(textBoxBorrowDate.Text.ToString()).Year + "' and MemberID LIKE '%" + textBoxMemberID.Text.ToString() + "%' and BookCode LIKE '%" + textBoxBookCode.Text.ToString() + "' and BookName LIKE '%" + textBoxBookName.Text.ToString() + "%' ", "BorrowDate", DataViewRowState.CurrentRows);
			else
				MyDataView = new DataView(MyDataTable, "MemberID LIKE '%" + textBoxMemberID.Text.ToString() + "%' and BookCode LIKE '%" + textBoxBookCode.Text.ToString() + "%' and BookName LIKE '%" + textBoxBookName.Text.ToString() + "%' ", "BorrowDate", DataViewRowState.CurrentRows);
			dataGridBookOutstanding.DataSource = MyDataView;
		}
		private void textBoxBookCode_Clicked(object sender, System.EventArgs e)
		{

		}
		private void textBoxBookName_TextChanged(object sender, System.EventArgs e)
		{
			if(textBoxBorrowDate.Text.ToString()!="")
				MyDataView = new DataView(MyDataTable, "BorrowDate = '" + Convert.ToDateTime(textBoxBorrowDate.Text.ToString()).Month + "/" + Convert.ToDateTime(textBoxBorrowDate.Text.ToString()).Day + "/" + Convert.ToDateTime(textBoxBorrowDate.Text.ToString()).Year + "' and MemberID LIKE '%" + textBoxMemberID.Text.ToString() + "%' and BookCode LIKE '%" + textBoxBookCode.Text.ToString() + "' and BookName LIKE '%" + textBoxBookName.Text.ToString() + "%' ", "BorrowDate", DataViewRowState.CurrentRows);
			else
				MyDataView = new DataView(MyDataTable, "MemberID LIKE '%" + textBoxMemberID.Text.ToString() + "%' and BookCode LIKE '%" + textBoxBookCode.Text.ToString() + "%' and BookName LIKE '%" + textBoxBookName.Text.ToString() + "%' ", "BorrowDate", DataViewRowState.CurrentRows);
			dataGridBookOutstanding.DataSource = MyDataView;
		}


		private void buttonClear_Click(object sender, System.EventArgs e)
		{
			textBoxBorrowDate.Text = "";
			textBoxMemberID.Text = "";
			textBoxBookCode.Text = "";
			textBoxBookName.Text = "";
			textBoxMemberName.Text = "";
		}

		private void buttonRefresh_Click(object sender, System.EventArgs e)
		{
			MyClassDatabase = new ClassDatabase();
			MyDataTable = MyClassDatabase.GetBookOutstanding();
			if(textBoxBorrowDate.Text.ToString()!="")
				MyDataView = new DataView(MyDataTable, "BorrowDate = '" + Convert.ToDateTime(textBoxBorrowDate.Text.ToString()).Month + "/" + Convert.ToDateTime(textBoxBorrowDate.Text.ToString()).Day + "/" + Convert.ToDateTime(textBoxBorrowDate.Text.ToString()).Year + "' and MemberID LIKE '%" + textBoxMemberID.Text.ToString() + "%' and BookCode LIKE '%" + textBoxBookCode.Text.ToString() + "' and BookName LIKE '%" + textBoxBookName.Text.ToString() + "%' ", "BorrowDate", DataViewRowState.CurrentRows);
			else
				MyDataView = new DataView(MyDataTable, "MemberID LIKE '%" + textBoxMemberID.Text.ToString() + "%' and BookCode LIKE '%" + textBoxBookCode.Text.ToString() + "%' and BookName LIKE '%" + textBoxBookName.Text.ToString() + "%' ", "BorrowDate", DataViewRowState.CurrentRows);
			dataGridBookOutstanding.DataSource = MyDataView;
		}


	}
}

