using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using Shell32;
using System.Threading;
namespace Sola_Scriptura_Library
{
	public class FrmBookMsDesc : Sola_Scriptura_Library.FrmBookMaster
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
		private System.ComponentModel.IContainer components = null;


		internal System.Windows.Forms.Button buttonSave;
		internal System.Windows.Forms.Button buttonCancel;
		internal System.Windows.Forms.Button buttonDelete;
		internal System.Windows.Forms.Button buttonEdit;
		internal System.Windows.Forms.Button buttonAdd;
		internal System.Windows.Forms.Label labelRelatedFile;
		internal System.Windows.Forms.Label labelBookDesc;
		internal System.Windows.Forms.TextBox textBoxRelatedFile;
		internal System.Windows.Forms.TextBox textBoxBookDesc;
		internal System.Windows.Forms.DataGrid dataGridBookDesc;
		internal System.Windows.Forms.DataGridTableStyle dataGridTableStyleBookDesc;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnBookCode;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnBookSeq;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnBookDesc;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnRelatedFile;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnUpdateUser;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnUpdateDate;
		internal System.Windows.Forms.OpenFileDialog openFileDialog1;
		
		
		internal ClassDatabase MyClassDatabase;
		internal DataTable MyDataTable;
		internal DataTable MyBookDescDataTable;
		internal BookDescription MyBookDescription;

		public FrmBookMsDesc()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public FrmBookMsDesc(FrmMDI MDIForm, FrmBookMenu BookMenuForm)
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBookMsDesc));
            this.LabelTitle = new System.Windows.Forms.Label();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.labelISBN = new System.Windows.Forms.Label();
            this.textBoxOriginalTitle = new System.Windows.Forms.TextBox();
            this.textBoxBookName = new System.Windows.Forms.TextBox();
            this.textBoxBookCode = new System.Windows.Forms.TextBox();
            this.labelOriginalTitle = new System.Windows.Forms.Label();
            this.labelBookName = new System.Windows.Forms.Label();
            this.labelBookCode = new System.Windows.Forms.Label();
            this.dataGridBookDesc = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyleBookDesc = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumnBookCode = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumnBookSeq = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumnBookDesc = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumnRelatedFile = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumnUpdateUser = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumnUpdateDate = new System.Windows.Forms.DataGridTextBoxColumn();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxRelatedFile = new System.Windows.Forms.TextBox();
            this.labelRelatedFile = new System.Windows.Forms.Label();
            this.textBoxBookDesc = new System.Windows.Forms.TextBox();
            this.labelBookDesc = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBookDesc)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelTitle
            // 
            this.LabelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(64)))), ((int)(((byte)(166)))));
            this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelTitle.Image = ((System.Drawing.Image)(resources.GetObject("LabelTitle.Image")));
            this.LabelTitle.Location = new System.Drawing.Point(792, 16);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(192, 32);
            this.LabelTitle.TabIndex = 108;
            this.LabelTitle.Text = "    Book Description";
            this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(64)))), ((int)(((byte)(166)))));
            this.textBoxISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxISBN.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxISBN.Location = new System.Drawing.Point(720, 80);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.ReadOnly = true;
            this.textBoxISBN.Size = new System.Drawing.Size(200, 22);
            this.textBoxISBN.TabIndex = 159;
            // 
            // labelISBN
            // 
            this.labelISBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(64)))), ((int)(((byte)(166)))));
            this.labelISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelISBN.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelISBN.Location = new System.Drawing.Point(592, 80);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(120, 24);
            this.labelISBN.TabIndex = 158;
            this.labelISBN.Text = "ISBN";
            // 
            // textBoxOriginalTitle
            // 
            this.textBoxOriginalTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(64)))), ((int)(((byte)(166)))));
            this.textBoxOriginalTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOriginalTitle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxOriginalTitle.Location = new System.Drawing.Point(384, 144);
            this.textBoxOriginalTitle.Name = "textBoxOriginalTitle";
            this.textBoxOriginalTitle.ReadOnly = true;
            this.textBoxOriginalTitle.Size = new System.Drawing.Size(536, 22);
            this.textBoxOriginalTitle.TabIndex = 157;
            // 
            // textBoxBookName
            // 
            this.textBoxBookName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(64)))), ((int)(((byte)(166)))));
            this.textBoxBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBookName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxBookName.Location = new System.Drawing.Point(384, 112);
            this.textBoxBookName.Name = "textBoxBookName";
            this.textBoxBookName.ReadOnly = true;
            this.textBoxBookName.Size = new System.Drawing.Size(536, 22);
            this.textBoxBookName.TabIndex = 156;
            // 
            // textBoxBookCode
            // 
            this.textBoxBookCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(64)))), ((int)(((byte)(166)))));
            this.textBoxBookCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBookCode.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxBookCode.Location = new System.Drawing.Point(384, 80);
            this.textBoxBookCode.Name = "textBoxBookCode";
            this.textBoxBookCode.ReadOnly = true;
            this.textBoxBookCode.Size = new System.Drawing.Size(200, 22);
            this.textBoxBookCode.TabIndex = 155;
            // 
            // labelOriginalTitle
            // 
            this.labelOriginalTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(64)))), ((int)(((byte)(166)))));
            this.labelOriginalTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOriginalTitle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelOriginalTitle.Location = new System.Drawing.Point(256, 144);
            this.labelOriginalTitle.Name = "labelOriginalTitle";
            this.labelOriginalTitle.Size = new System.Drawing.Size(120, 24);
            this.labelOriginalTitle.TabIndex = 154;
            this.labelOriginalTitle.Text = "Original Title";
            // 
            // labelBookName
            // 
            this.labelBookName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(64)))), ((int)(((byte)(166)))));
            this.labelBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelBookName.Location = new System.Drawing.Point(256, 112);
            this.labelBookName.Name = "labelBookName";
            this.labelBookName.Size = new System.Drawing.Size(120, 24);
            this.labelBookName.TabIndex = 153;
            this.labelBookName.Text = "Book Name";
            // 
            // labelBookCode
            // 
            this.labelBookCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(64)))), ((int)(((byte)(166)))));
            this.labelBookCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookCode.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelBookCode.Location = new System.Drawing.Point(256, 80);
            this.labelBookCode.Name = "labelBookCode";
            this.labelBookCode.Size = new System.Drawing.Size(120, 24);
            this.labelBookCode.TabIndex = 152;
            this.labelBookCode.Text = "Book Code";
            // 
            // dataGridBookDesc
            // 
            this.dataGridBookDesc.DataMember = "";
            this.dataGridBookDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridBookDesc.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGridBookDesc.Location = new System.Drawing.Point(248, 176);
            this.dataGridBookDesc.Name = "dataGridBookDesc";
            this.dataGridBookDesc.ReadOnly = true;
            this.dataGridBookDesc.Size = new System.Drawing.Size(672, 264);
            this.dataGridBookDesc.TabIndex = 160;
            this.dataGridBookDesc.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
            this.dataGridTableStyleBookDesc});
            this.dataGridBookDesc.DoubleClick += new System.EventHandler(this.dataGridBookDesc_DoubleClick);
            // 
            // dataGridTableStyleBookDesc
            // 
            this.dataGridTableStyleBookDesc.AlternatingBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(64)))), ((int)(((byte)(166)))));
            this.dataGridTableStyleBookDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(127)))), ((int)(((byte)(220)))));
            this.dataGridTableStyleBookDesc.DataGrid = this.dataGridBookDesc;
            this.dataGridTableStyleBookDesc.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridTableStyleBookDesc.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
            this.dataGridTextBoxColumnBookCode,
            this.dataGridTextBoxColumnBookSeq,
            this.dataGridTextBoxColumnBookDesc,
            this.dataGridTextBoxColumnRelatedFile,
            this.dataGridTextBoxColumnUpdateUser,
            this.dataGridTextBoxColumnUpdateDate});
            this.dataGridTableStyleBookDesc.GridLineColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridTableStyleBookDesc.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(64)))), ((int)(((byte)(166)))));
            this.dataGridTableStyleBookDesc.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridTableStyleBookDesc.MappingName = "BookDescData";
            // 
            // dataGridTextBoxColumnBookCode
            // 
            this.dataGridTextBoxColumnBookCode.Format = "";
            this.dataGridTextBoxColumnBookCode.FormatInfo = null;
            this.dataGridTextBoxColumnBookCode.MappingName = "BookCode";
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
            // dataGridTextBoxColumnBookDesc
            // 
            this.dataGridTextBoxColumnBookDesc.Format = "";
            this.dataGridTextBoxColumnBookDesc.FormatInfo = null;
            this.dataGridTextBoxColumnBookDesc.HeaderText = "Book Description";
            this.dataGridTextBoxColumnBookDesc.MappingName = "BookDescription";
            this.dataGridTextBoxColumnBookDesc.Width = 300;
            // 
            // dataGridTextBoxColumnRelatedFile
            // 
            this.dataGridTextBoxColumnRelatedFile.Format = "";
            this.dataGridTextBoxColumnRelatedFile.FormatInfo = null;
            this.dataGridTextBoxColumnRelatedFile.HeaderText = "Related File";
            this.dataGridTextBoxColumnRelatedFile.MappingName = "RelatedFile";
            this.dataGridTextBoxColumnRelatedFile.Width = 300;
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
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonAdd.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd.Image")));
            this.buttonAdd.Location = new System.Drawing.Point(248, 520);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(88, 32);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Add New";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxRelatedFile
            // 
            this.textBoxRelatedFile.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxRelatedFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRelatedFile.Location = new System.Drawing.Point(384, 488);
            this.textBoxRelatedFile.Name = "textBoxRelatedFile";
            this.textBoxRelatedFile.ReadOnly = true;
            this.textBoxRelatedFile.Size = new System.Drawing.Size(536, 22);
            this.textBoxRelatedFile.TabIndex = 2;
            this.textBoxRelatedFile.TextChanged += new System.EventHandler(this.textBoxRelatedFile_TextChanged);
            this.textBoxRelatedFile.Click += new System.EventHandler(this.textBoxRelatedFile_Clicked);
            // 
            // labelRelatedFile
            // 
            this.labelRelatedFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(64)))), ((int)(((byte)(166)))));
            this.labelRelatedFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRelatedFile.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelRelatedFile.Location = new System.Drawing.Point(256, 488);
            this.labelRelatedFile.Name = "labelRelatedFile";
            this.labelRelatedFile.Size = new System.Drawing.Size(120, 24);
            this.labelRelatedFile.TabIndex = 205;
            this.labelRelatedFile.Text = "Related File";
            // 
            // textBoxBookDesc
            // 
            this.textBoxBookDesc.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxBookDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBookDesc.Location = new System.Drawing.Point(384, 456);
            this.textBoxBookDesc.Name = "textBoxBookDesc";
            this.textBoxBookDesc.Size = new System.Drawing.Size(536, 22);
            this.textBoxBookDesc.TabIndex = 1;
            this.textBoxBookDesc.TextChanged += new System.EventHandler(this.textBoxBookDesc_TextChanged);
            // 
            // labelBookDesc
            // 
            this.labelBookDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(64)))), ((int)(((byte)(166)))));
            this.labelBookDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookDesc.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelBookDesc.Location = new System.Drawing.Point(256, 456);
            this.labelBookDesc.Name = "labelBookDesc";
            this.labelBookDesc.Size = new System.Drawing.Size(120, 24);
            this.labelBookDesc.TabIndex = 204;
            this.labelBookDesc.Text = "Book Desc";
            // 
            // FrmBookMsDesc
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1020, 570);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxRelatedFile);
            this.Controls.Add(this.labelRelatedFile);
            this.Controls.Add(this.textBoxBookDesc);
            this.Controls.Add(this.labelBookDesc);
            this.Controls.Add(this.dataGridBookDesc);
            this.Controls.Add(this.textBoxISBN);
            this.Controls.Add(this.labelISBN);
            this.Controls.Add(this.textBoxOriginalTitle);
            this.Controls.Add(this.textBoxBookName);
            this.Controls.Add(this.textBoxBookCode);
            this.Controls.Add(this.labelOriginalTitle);
            this.Controls.Add(this.labelBookName);
            this.Controls.Add(this.labelBookCode);
            this.Controls.Add(this.LabelTitle);
            this.Name = "FrmBookMsDesc";
            this.Load += new System.EventHandler(this.FrmBookMsDesc_Load);
            this.Controls.SetChildIndex(this.LabelTitle, 0);
            this.Controls.SetChildIndex(this.labelBookCode, 0);
            this.Controls.SetChildIndex(this.labelBookName, 0);
            this.Controls.SetChildIndex(this.labelOriginalTitle, 0);
            this.Controls.SetChildIndex(this.textBoxBookCode, 0);
            this.Controls.SetChildIndex(this.textBoxBookName, 0);
            this.Controls.SetChildIndex(this.textBoxOriginalTitle, 0);
            this.Controls.SetChildIndex(this.labelISBN, 0);
            this.Controls.SetChildIndex(this.textBoxISBN, 0);
            this.Controls.SetChildIndex(this.dataGridBookDesc, 0);
            this.Controls.SetChildIndex(this.labelBookDesc, 0);
            this.Controls.SetChildIndex(this.textBoxBookDesc, 0);
            this.Controls.SetChildIndex(this.labelRelatedFile, 0);
            this.Controls.SetChildIndex(this.textBoxRelatedFile, 0);
            this.Controls.SetChildIndex(this.buttonAdd, 0);
            this.Controls.SetChildIndex(this.buttonEdit, 0);
            this.Controls.SetChildIndex(this.buttonDelete, 0);
            this.Controls.SetChildIndex(this.buttonCancel, 0);
            this.Controls.SetChildIndex(this.buttonSave, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBookDesc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void FrmBookMsDesc_Load(object sender, System.EventArgs e)
		{
			MyBookDescription = new BookDescription();
			MyBookDescDataTable = new DataTable();
			if(MyBookMenuForm.MyBookSearch.BookCode.ToString() != "")
			{
				MyClassDatabase = new ClassDatabase();
				MyDataTable = MyClassDatabase.GetBookData(MyBookMenuForm.MyBookSearch.BookCode.ToString());
				textBoxBookCode.Text = MyDataTable.Rows[0]["BookCode"].ToString().Trim();
				textBoxBookName.Text = MyDataTable.Rows[0]["BookName"].ToString().Trim();
				textBoxOriginalTitle.Text = MyDataTable.Rows[0]["OriginalTitle"].ToString().Trim();;
				textBoxISBN.Text = (MyDataTable.Rows[0]["ISBN"].ToString().Trim());
				MyClassDatabase = new ClassDatabase();
				MyBookDescDataTable = MyClassDatabase.GetBookDescData(textBoxBookCode.Text.ToString());
				dataGridBookDesc.DataSource = MyBookDescDataTable;
				MyBookDescription.BookCode = textBoxBookCode.Text.ToString();
				RefreshButton();
			}
		}

		private void textBoxBookDesc_TextChanged(object sender, System.EventArgs e)
		{
			MyBookDescription.Description = textBoxBookDesc.Text.ToString();
		}

		private void textBoxRelatedFile_TextChanged(object sender, System.EventArgs e)
		{
			MyBookDescription.RelatedFile = textBoxRelatedFile.Text.ToString();
		}
		private void textBoxRelatedFile_Clicked(object sender, System.EventArgs e)
		{
			openFileDialog1.ShowDialog();
			textBoxRelatedFile.Text = openFileDialog1.FileName;
		}

		internal void DoLock()
		{
			buttonAdd.Enabled = true;
			buttonSave.Enabled = false;
			buttonCancel.Enabled = false;
			
			textBoxBookDesc.Text = "";
			textBoxRelatedFile.Text = "";
			MyBookDescription.BookSeq = "";
			MyClassDatabase = new ClassDatabase();
			MyBookDescDataTable = MyClassDatabase.GetBookDescData(textBoxBookCode.Text.ToString());
			dataGridBookDesc.DataSource = MyBookDescDataTable;
			RefreshButton();


		}
		private void DoUnlock()
		{
			textBoxBookDesc.Focus();
			buttonAdd.Enabled = false;
			buttonEdit.Enabled = false;
			buttonDelete.Enabled = false;
			buttonSave.Enabled = true;
			buttonCancel.Enabled = true;
		}
		internal void RefreshButton()
		{
			if(MyBookDescDataTable.Rows.Count>0)
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
			MyBookDescription.BookSeq = dataGridBookDesc[dataGridBookDesc.CurrentRowIndex,1].ToString().Trim();
			textBoxBookDesc.Text = dataGridBookDesc[dataGridBookDesc.CurrentRowIndex,2].ToString().Trim();
			textBoxRelatedFile.Text =  dataGridBookDesc[dataGridBookDesc.CurrentRowIndex,3].ToString().Trim();
				
		}
		private void buttonDelete_Click(object sender, System.EventArgs e)
		{
			DialogResult ans;
			ans = MessageBox.Show("Are you sure you want to delete Book Description Data with Description ='" + dataGridBookDesc[dataGridBookDesc.CurrentRowIndex,2].ToString().Trim() + "' ?" , "Confirmation", MessageBoxButtons.YesNo );
			if (ans.ToString() == "Yes")
			{	
				MyClassDatabase = new ClassDatabase();
				MyClassDatabase.DeleteBookDesc(textBoxBookCode.Text.ToString(), dataGridBookDesc[dataGridBookDesc.CurrentRowIndex,1].ToString().Trim());
                Thread.Sleep(1000);
			
			}
			DoLock();
		}

		private void buttonSave_Click(object sender, System.EventArgs e)
		{
			MyBookDescription.UpdateUser = MyMDIForm.LibrarianUserName.ToString();
			MyClassDatabase = new ClassDatabase();
			MyClassDatabase.SaveBookDesc(MyBookDescription);
            Thread.Sleep(1000);
			DoLock();


		}
		private void buttonCancel_Click(object sender, System.EventArgs e)
		{
			DoLock();


		}

		private void dataGridBookDesc_DoubleClick(object sender, System.EventArgs e)
		{
			if(MyBookDescDataTable.Rows.Count>0)
			{
				Shell32.ShellClass a= new Shell32.ShellClass();
				a.Open(dataGridBookDesc[dataGridBookDesc.CurrentRowIndex,3].ToString().Trim());
			}
		}
	}
}

