using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace Sola_Scriptura_Library
{
	public class FrmBookMsAuthor : Sola_Scriptura_Library.FrmBookMaster
	{
		internal System.Windows.Forms.Label LabelTitle;
		internal System.Windows.Forms.Label labelOriginalTitle;
		internal System.Windows.Forms.Label labelBookName;
		internal System.Windows.Forms.Label labelBookCode;
		internal System.Windows.Forms.TextBox textBoxOriginalTitle;
		internal System.Windows.Forms.TextBox textBoxBookName;
		internal System.Windows.Forms.TextBox textBoxBookCode;
		internal System.Windows.Forms.TextBox textBoxISBN;
		internal System.Windows.Forms.Label labelISBN;
		internal System.Windows.Forms.DataGrid dataGridBookAuthor;
		internal System.Windows.Forms.Button buttonSave;
		internal System.Windows.Forms.Button buttonCancel;
		internal System.Windows.Forms.Button buttonDelete;
		internal System.Windows.Forms.Button buttonEdit;
		internal System.Windows.Forms.Button buttonAdd;
		internal System.Windows.Forms.TextBox textBoxAuthorCode;
		internal System.Windows.Forms.TextBox textBoxAuthorName;
		internal System.Windows.Forms.Label labelAuthorCode;
		internal System.Windows.Forms.TextBox textBoxAuthorType;
		internal System.Windows.Forms.Label labelAuthorType;
		private System.ComponentModel.IContainer components = null;


		internal System.Windows.Forms.DataGridTableStyle dataGridTableStyleBookAuthor;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnAuthorCode;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnFirstName;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnLastName;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnUpdateUser;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnUpdateDate;
		
		internal ClassDatabase MyClassDatabase;
		internal BookAuthor MyBookAuthor;
		internal DataTable MyDataTable;
		internal DataTable MyBookAuthorDataTable;
		internal FrmSearchMiniForm MySearchMiniForm;
		internal System.Windows.Forms.TextBox textBox3;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnAuthorType;


		public FrmBookMsAuthor()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public FrmBookMsAuthor(FrmMDI MDIForm, FrmBookMenu BookMenuForm)
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmBookMsAuthor));
			this.LabelTitle = new System.Windows.Forms.Label();
			this.labelOriginalTitle = new System.Windows.Forms.Label();
			this.labelBookName = new System.Windows.Forms.Label();
			this.labelBookCode = new System.Windows.Forms.Label();
			this.textBoxOriginalTitle = new System.Windows.Forms.TextBox();
			this.textBoxBookName = new System.Windows.Forms.TextBox();
			this.textBoxBookCode = new System.Windows.Forms.TextBox();
			this.textBoxISBN = new System.Windows.Forms.TextBox();
			this.labelISBN = new System.Windows.Forms.Label();
			this.dataGridBookAuthor = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyleBookAuthor = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnAuthorCode = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnFirstName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnLastName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnAuthorType = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnUpdateUser = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnUpdateDate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.textBoxAuthorCode = new System.Windows.Forms.TextBox();
			this.textBoxAuthorName = new System.Windows.Forms.TextBox();
			this.labelAuthorCode = new System.Windows.Forms.Label();
			this.textBoxAuthorType = new System.Windows.Forms.TextBox();
			this.labelAuthorType = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridBookAuthor)).BeginInit();
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
			this.LabelTitle.TabIndex = 107;
			this.LabelTitle.Text = "    Book Author";
			this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelOriginalTitle
			// 
			this.labelOriginalTitle.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelOriginalTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelOriginalTitle.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelOriginalTitle.Location = new System.Drawing.Point(256, 144);
			this.labelOriginalTitle.Name = "labelOriginalTitle";
			this.labelOriginalTitle.Size = new System.Drawing.Size(120, 24);
			this.labelOriginalTitle.TabIndex = 137;
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
			this.labelBookName.TabIndex = 136;
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
			this.labelBookCode.TabIndex = 135;
			this.labelBookCode.Text = "Book Code";
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
			this.textBoxOriginalTitle.TabIndex = 140;
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
			this.textBoxBookName.TabIndex = 139;
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
			this.textBoxBookCode.TabIndex = 138;
			this.textBoxBookCode.Text = "";
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
			this.textBoxISBN.TabIndex = 142;
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
			this.labelISBN.TabIndex = 141;
			this.labelISBN.Text = "ISBN";
			// 
			// dataGridBookAuthor
			// 
			this.dataGridBookAuthor.DataMember = "";
			this.dataGridBookAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGridBookAuthor.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridBookAuthor.Location = new System.Drawing.Point(248, 176);
			this.dataGridBookAuthor.Name = "dataGridBookAuthor";
			this.dataGridBookAuthor.ReadOnly = true;
			this.dataGridBookAuthor.Size = new System.Drawing.Size(672, 272);
			this.dataGridBookAuthor.TabIndex = 143;
			this.dataGridBookAuthor.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																										   this.dataGridTableStyleBookAuthor});
			// 
			// dataGridTableStyleBookAuthor
			// 
			this.dataGridTableStyleBookAuthor.AlternatingBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleBookAuthor.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.dataGridTableStyleBookAuthor.DataGrid = this.dataGridBookAuthor;
			this.dataGridTableStyleBookAuthor.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleBookAuthor.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																														   this.dataGridTextBoxColumnAuthorCode,
																														   this.dataGridTextBoxColumnFirstName,
																														   this.dataGridTextBoxColumnLastName,
																														   this.dataGridTextBoxColumnAuthorType,
																														   this.dataGridTextBoxColumnUpdateUser,
																														   this.dataGridTextBoxColumnUpdateDate});
			this.dataGridTableStyleBookAuthor.GridLineColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridTableStyleBookAuthor.HeaderBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleBookAuthor.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleBookAuthor.MappingName = "BookAuthorData";
			// 
			// dataGridTextBoxColumnAuthorCode
			// 
			this.dataGridTextBoxColumnAuthorCode.Format = "";
			this.dataGridTextBoxColumnAuthorCode.FormatInfo = null;
			this.dataGridTextBoxColumnAuthorCode.HeaderText = "Author Code";
			this.dataGridTextBoxColumnAuthorCode.MappingName = "AuthorCode";
			this.dataGridTextBoxColumnAuthorCode.Width = 120;
			// 
			// dataGridTextBoxColumnFirstName
			// 
			this.dataGridTextBoxColumnFirstName.Format = "";
			this.dataGridTextBoxColumnFirstName.FormatInfo = null;
			this.dataGridTextBoxColumnFirstName.HeaderText = "FirstName";
			this.dataGridTextBoxColumnFirstName.MappingName = "FirstName";
			this.dataGridTextBoxColumnFirstName.Width = 130;
			// 
			// dataGridTextBoxColumnLastName
			// 
			this.dataGridTextBoxColumnLastName.Format = "";
			this.dataGridTextBoxColumnLastName.FormatInfo = null;
			this.dataGridTextBoxColumnLastName.HeaderText = "LastName";
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
			// dataGridTextBoxColumnUpdateUser
			// 
			this.dataGridTextBoxColumnUpdateUser.Format = "";
			this.dataGridTextBoxColumnUpdateUser.FormatInfo = null;
			this.dataGridTextBoxColumnUpdateUser.HeaderText = "UpdateUser";
			this.dataGridTextBoxColumnUpdateUser.MappingName = "UpdateUser";
			this.dataGridTextBoxColumnUpdateUser.Width = 75;
			// 
			// dataGridTextBoxColumnUpdateDate
			// 
			this.dataGridTextBoxColumnUpdateDate.Format = "";
			this.dataGridTextBoxColumnUpdateDate.FormatInfo = null;
			this.dataGridTextBoxColumnUpdateDate.HeaderText = "UpdateDate";
			this.dataGridTextBoxColumnUpdateDate.MappingName = "UpdateDate";
			this.dataGridTextBoxColumnUpdateDate.Width = 75;
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
			this.buttonSave.TabIndex = 6;
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
			this.buttonCancel.TabIndex = 7;
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
			this.buttonDelete.TabIndex = 5;
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
			this.buttonEdit.TabIndex = 4;
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
			this.buttonAdd.TabIndex = 3;
			this.buttonAdd.Text = "Add New";
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// textBoxAuthorCode
			// 
			this.textBoxAuthorCode.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxAuthorCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxAuthorCode.Location = new System.Drawing.Point(384, 456);
			this.textBoxAuthorCode.Name = "textBoxAuthorCode";
			this.textBoxAuthorCode.ReadOnly = true;
			this.textBoxAuthorCode.Size = new System.Drawing.Size(200, 22);
			this.textBoxAuthorCode.TabIndex = 1;
			this.textBoxAuthorCode.Text = "";
			this.textBoxAuthorCode.TextChanged += new System.EventHandler(this.textBoxAuthorCode_TextChanged);
			this.textBoxAuthorCode.Click += new System.EventHandler(this.textBoxAuthorCode_Clicked);
			// 
			// textBoxAuthorName
			// 
			this.textBoxAuthorName.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxAuthorName.ForeColor = System.Drawing.SystemColors.WindowText;
			this.textBoxAuthorName.Location = new System.Drawing.Point(624, 456);
			this.textBoxAuthorName.Name = "textBoxAuthorName";
			this.textBoxAuthorName.ReadOnly = true;
			this.textBoxAuthorName.Size = new System.Drawing.Size(296, 22);
			this.textBoxAuthorName.TabIndex = 175;
			this.textBoxAuthorName.TabStop = false;
			this.textBoxAuthorName.Text = "";
			// 
			// labelAuthorCode
			// 
			this.labelAuthorCode.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelAuthorCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelAuthorCode.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelAuthorCode.Location = new System.Drawing.Point(256, 456);
			this.labelAuthorCode.Name = "labelAuthorCode";
			this.labelAuthorCode.Size = new System.Drawing.Size(120, 24);
			this.labelAuthorCode.TabIndex = 174;
			this.labelAuthorCode.Text = "Author Code";
			// 
			// textBoxAuthorType
			// 
			this.textBoxAuthorType.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxAuthorType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxAuthorType.Location = new System.Drawing.Point(384, 488);
			this.textBoxAuthorType.Name = "textBoxAuthorType";
			this.textBoxAuthorType.ReadOnly = true;
			this.textBoxAuthorType.Size = new System.Drawing.Size(200, 22);
			this.textBoxAuthorType.TabIndex = 2;
			this.textBoxAuthorType.Text = "";
			this.textBoxAuthorType.TextChanged += new System.EventHandler(this.textBoxAuthorType_TextChanged);
			this.textBoxAuthorType.Click += new System.EventHandler(this.textBoxAuthorType_Clicked);
			// 
			// labelAuthorType
			// 
			this.labelAuthorType.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelAuthorType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelAuthorType.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelAuthorType.Location = new System.Drawing.Point(256, 488);
			this.labelAuthorType.Name = "labelAuthorType";
			this.labelAuthorType.Size = new System.Drawing.Size(120, 24);
			this.labelAuthorType.TabIndex = 177;
			this.labelAuthorType.Text = "Author Type";
			// 
			// textBox3
			// 
			this.textBox3.BackColor = System.Drawing.SystemColors.Window;
			this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox3.ForeColor = System.Drawing.SystemColors.WindowText;
			this.textBox3.Location = new System.Drawing.Point(624, 456);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(296, 22);
			this.textBox3.TabIndex = 175;
			this.textBox3.TabStop = false;
			this.textBox3.Text = "";
			// 
			// FrmBookMsAuthor
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.labelAuthorType);
			this.Controls.Add(this.textBoxAuthorType);
			this.Controls.Add(this.textBoxAuthorCode);
			this.Controls.Add(this.textBoxAuthorName);
			this.Controls.Add(this.labelAuthorCode);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonEdit);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.dataGridBookAuthor);
			this.Controls.Add(this.textBoxISBN);
			this.Controls.Add(this.labelISBN);
			this.Controls.Add(this.textBoxOriginalTitle);
			this.Controls.Add(this.textBoxBookName);
			this.Controls.Add(this.textBoxBookCode);
			this.Controls.Add(this.labelOriginalTitle);
			this.Controls.Add(this.labelBookName);
			this.Controls.Add(this.labelBookCode);
			this.Controls.Add(this.LabelTitle);
			this.Controls.Add(this.textBox3);
			this.Name = "FrmBookMsAuthor";
			this.Load += new System.EventHandler(this.FrmBookMsAuthor_Load);
			this.Controls.SetChildIndex(this.textBox3, 0);
			this.Controls.SetChildIndex(this.LabelTitle, 0);
			this.Controls.SetChildIndex(this.labelBookCode, 0);
			this.Controls.SetChildIndex(this.labelBookName, 0);
			this.Controls.SetChildIndex(this.labelOriginalTitle, 0);
			this.Controls.SetChildIndex(this.textBoxBookCode, 0);
			this.Controls.SetChildIndex(this.textBoxBookName, 0);
			this.Controls.SetChildIndex(this.textBoxOriginalTitle, 0);
			this.Controls.SetChildIndex(this.labelISBN, 0);
			this.Controls.SetChildIndex(this.textBoxISBN, 0);
			this.Controls.SetChildIndex(this.dataGridBookAuthor, 0);
			this.Controls.SetChildIndex(this.buttonAdd, 0);
			this.Controls.SetChildIndex(this.buttonEdit, 0);
			this.Controls.SetChildIndex(this.buttonDelete, 0);
			this.Controls.SetChildIndex(this.buttonCancel, 0);
			this.Controls.SetChildIndex(this.buttonSave, 0);
			this.Controls.SetChildIndex(this.labelAuthorCode, 0);
			this.Controls.SetChildIndex(this.textBoxAuthorName, 0);
			this.Controls.SetChildIndex(this.textBoxAuthorCode, 0);
			this.Controls.SetChildIndex(this.textBoxAuthorType, 0);
			this.Controls.SetChildIndex(this.labelAuthorType, 0);
			((System.ComponentModel.ISupportInitialize)(this.dataGridBookAuthor)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void FrmBookMsAuthor_Load(object sender, System.EventArgs e)
		{
			MyBookAuthor = new BookAuthor();
			if(MyBookMenuForm.MyBookSearch.BookCode.ToString() != "")
			{
				MyClassDatabase = new ClassDatabase();
				MyDataTable = MyClassDatabase.GetBookData(MyBookMenuForm.MyBookSearch.BookCode.ToString());
				textBoxBookCode.Text = MyDataTable.Rows[0]["BookCode"].ToString().Trim();
				textBoxBookName.Text = MyDataTable.Rows[0]["BookName"].ToString().Trim();
				textBoxOriginalTitle.Text = MyDataTable.Rows[0]["OriginalTitle"].ToString().Trim();;
				textBoxISBN.Text = (MyDataTable.Rows[0]["ISBN"].ToString().Trim());
				MyClassDatabase = new ClassDatabase();
				MyBookAuthorDataTable = MyClassDatabase.GetBookAuthorData(textBoxBookCode.Text.ToString());
				dataGridBookAuthor.DataSource = MyBookAuthorDataTable;

				MyBookAuthor.BookCode = textBoxBookCode.Text.ToString();
				RefreshButton();
			}
		}
		internal void GetBookData()
		{
			MyClassDatabase = new ClassDatabase();
			MyDataTable = MyClassDatabase.GetBookData(MyBookMenuForm.MyBookSearch.BookCode.ToString());
			textBoxBookCode.Text = MyDataTable.Rows[0]["BookCode"].ToString().Trim();
			textBoxBookName.Text = MyDataTable.Rows[0]["BookName"].ToString().Trim();
			textBoxOriginalTitle.Text = MyDataTable.Rows[0]["OriginalTitle"].ToString().Trim();;
			textBoxISBN.Text = (MyDataTable.Rows[0]["ISBN"].ToString().Trim());
			MyClassDatabase = new ClassDatabase();
			MyBookAuthorDataTable = MyClassDatabase.GetBookAuthorData(textBoxBookCode.Text.ToString());
			dataGridBookAuthor.DataSource = MyBookAuthorDataTable;

			MyBookAuthor.BookCode = textBoxBookCode.Text.ToString();
			RefreshButton();
		}

		private void textBoxAuthorCode_TextChanged(object sender, System.EventArgs e)
		{
			MyBookAuthor.AuthorCode = textBoxAuthorCode.Text.ToString();
		}
		private void textBoxAuthorCode_Clicked(object sender, System.EventArgs e)
		{
			MySearchMiniForm = new FrmSearchMiniForm(this,"BookAuthor");
			MySearchMiniForm.Show();
		}

		private void textBoxAuthorType_TextChanged(object sender, System.EventArgs e)
		{
			MyBookAuthor.AuthorType = textBoxAuthorType.Text.ToString();
		}
		private void textBoxAuthorType_Clicked(object sender, System.EventArgs e)
		{
			MySearchMiniForm = new FrmSearchMiniForm(this,"AuthorType");
			MySearchMiniForm.Show();
		}

		internal void DoLock()
		{
			buttonAdd.Enabled = true;
			buttonSave.Enabled = false;
			buttonCancel.Enabled = false;
			textBoxAuthorCode.Text = "";
			textBoxAuthorName.Text = "";
			textBoxAuthorType.Text = "";
			MyBookAuthor.PreviousAuthorCode = "";
			MyClassDatabase = new ClassDatabase();
			MyBookAuthorDataTable = MyClassDatabase.GetBookAuthorData(textBoxBookCode.Text.ToString());
			dataGridBookAuthor.DataSource = MyBookAuthorDataTable;
			RefreshButton();


		}
		private void DoUnlock()
		{
			textBoxAuthorCode.Focus();
			buttonAdd.Enabled = false;
			buttonEdit.Enabled = false;
			buttonDelete.Enabled = false;
			buttonSave.Enabled = true;
			buttonCancel.Enabled = true;
		}
		internal void RefreshButton()
		{
			if(MyBookAuthorDataTable.Rows.Count>0)
			{
				buttonEdit.Enabled = true;
				buttonDelete.Enabled = true;
			}
			else
			{
				buttonEdit.Enabled = false;
				buttonDelete.Enabled = false;
			}
		}

		private void buttonAdd_Click(object sender, System.EventArgs e)
		{
			DoUnlock();
		}
		private void buttonEdit_Click(object sender, System.EventArgs e)
		{
			//MessageBox.Show("If you want to Edit the Book Author, 1. Delete the Author then 2. Add the Author...", "Information");
			DoUnlock();
			textBoxAuthorCode.Text = dataGridBookAuthor[dataGridBookAuthor.CurrentRowIndex,0].ToString().Trim();
			textBoxAuthorName.Text = dataGridBookAuthor[dataGridBookAuthor.CurrentRowIndex,1].ToString().Trim() + " " + dataGridBookAuthor[dataGridBookAuthor.CurrentRowIndex,2].ToString().Trim();
			textBoxAuthorType.Text = dataGridBookAuthor[dataGridBookAuthor.CurrentRowIndex,3].ToString().Trim();
			MyBookAuthor.PreviousAuthorCode = dataGridBookAuthor[dataGridBookAuthor.CurrentRowIndex,0].ToString().Trim();
		}
		private void buttonDelete_Click(object sender, System.EventArgs e)
		{
			DialogResult ans;
			ans = MessageBox.Show("Are you sure you want to delete BookAuthor Data with Author Code ='" + dataGridBookAuthor[dataGridBookAuthor.CurrentRowIndex,0].ToString().Trim() + "' ?" , "Confirmation", MessageBoxButtons.YesNo );
			if (ans.ToString() == "Yes")
			{	
				MyClassDatabase = new ClassDatabase();
				MyClassDatabase.DeleteBookAuthor(textBoxBookCode.Text.ToString(), dataGridBookAuthor[dataGridBookAuthor.CurrentRowIndex,0].ToString().Trim());

			
			}
			DoLock();
		}

		private void buttonSave_Click(object sender, System.EventArgs e)
		{
			MyBookAuthor.UpdateUser = MyMDIForm.LibrarianUserName.ToString();
			MyClassDatabase = new ClassDatabase();
			MyClassDatabase.SaveBookAuthor(MyBookAuthor);

			DoLock();


		}
		private void buttonCancel_Click(object sender, System.EventArgs e)
		{
			DoLock();


		}

	}
}

