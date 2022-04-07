using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Threading;
namespace Sola_Scriptura_Library
{
	public class FrmBookMsSubject : Sola_Scriptura_Library.FrmBookMaster
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
		internal System.Windows.Forms.DataGrid dataGridBookSubject;
		private System.ComponentModel.IContainer components = null;


		internal System.Windows.Forms.TextBox textBoxSubjectCode;
		internal System.Windows.Forms.TextBox textBoxSubjectName;
		internal System.Windows.Forms.Label labelSubjectCode;
		internal System.Windows.Forms.Button buttonSave;
		internal System.Windows.Forms.Button buttonCancel;
		internal System.Windows.Forms.Button buttonDelete;
		internal System.Windows.Forms.Button buttonEdit;
		internal System.Windows.Forms.Button buttonAdd;
		internal System.Windows.Forms.Label labelDescription;
		internal System.Windows.Forms.TextBox textBoxDescription;
		internal System.Windows.Forms.OpenFileDialog openFileDialog1;
		internal System.Windows.Forms.DataGridTableStyle dataGridTableStyleBookSubject;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnSubjectCode;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnSubjectName;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnDescription;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnUpdateUser;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnUpdateDate;
		
		internal ClassDatabase MyClassDatabase;
		internal DataTable MyDataTable;
		internal DataTable MyBookSubjectDataTable;
		internal BookSubject MyBookSubject;
		internal FrmSearchMiniForm MySearchMiniForm;
		public FrmBookMsSubject()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public FrmBookMsSubject(FrmMDI MDIForm, FrmBookMenu BookMenuForm)
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmBookMsSubject));
			this.LabelTitle = new System.Windows.Forms.Label();
			this.dataGridBookSubject = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyleBookSubject = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnSubjectCode = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnSubjectName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnDescription = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnUpdateUser = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnUpdateDate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.textBoxISBN = new System.Windows.Forms.TextBox();
			this.labelISBN = new System.Windows.Forms.Label();
			this.textBoxOriginalTitle = new System.Windows.Forms.TextBox();
			this.textBoxBookName = new System.Windows.Forms.TextBox();
			this.textBoxBookCode = new System.Windows.Forms.TextBox();
			this.labelOriginalTitle = new System.Windows.Forms.Label();
			this.labelBookName = new System.Windows.Forms.Label();
			this.labelBookCode = new System.Windows.Forms.Label();
			this.labelDescription = new System.Windows.Forms.Label();
			this.textBoxDescription = new System.Windows.Forms.TextBox();
			this.textBoxSubjectCode = new System.Windows.Forms.TextBox();
			this.textBoxSubjectName = new System.Windows.Forms.TextBox();
			this.labelSubjectCode = new System.Windows.Forms.Label();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.dataGridBookSubject)).BeginInit();
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
			this.LabelTitle.Text = "    Book Subject";
			this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dataGridBookSubject
			// 
			this.dataGridBookSubject.DataMember = "";
			this.dataGridBookSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGridBookSubject.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridBookSubject.Location = new System.Drawing.Point(248, 176);
			this.dataGridBookSubject.Name = "dataGridBookSubject";
			this.dataGridBookSubject.ReadOnly = true;
			this.dataGridBookSubject.Size = new System.Drawing.Size(672, 272);
			this.dataGridBookSubject.TabIndex = 152;
			this.dataGridBookSubject.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																											this.dataGridTableStyleBookSubject});
			this.dataGridBookSubject.DoubleClick += new System.EventHandler(this.dataGridBookSubject_DoubleClick);
			// 
			// dataGridTableStyleBookSubject
			// 
			this.dataGridTableStyleBookSubject.AlternatingBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleBookSubject.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.dataGridTableStyleBookSubject.DataGrid = this.dataGridBookSubject;
			this.dataGridTableStyleBookSubject.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleBookSubject.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																															this.dataGridTextBoxColumnSubjectCode,
																															this.dataGridTextBoxColumnSubjectName,
																															this.dataGridTextBoxColumnDescription,
																															this.dataGridTextBoxColumnUpdateUser,
																															this.dataGridTextBoxColumnUpdateDate});
			this.dataGridTableStyleBookSubject.GridLineColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridTableStyleBookSubject.HeaderBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleBookSubject.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleBookSubject.MappingName = "BookSubjectData";
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
			this.dataGridTextBoxColumnDescription.Width = 150;
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
			// labelDescription
			// 
			this.labelDescription.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelDescription.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelDescription.Location = new System.Drawing.Point(256, 488);
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Size = new System.Drawing.Size(120, 24);
			this.labelDescription.TabIndex = 182;
			this.labelDescription.Text = "Description";
			// 
			// textBoxDescription
			// 
			this.textBoxDescription.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxDescription.Location = new System.Drawing.Point(384, 488);
			this.textBoxDescription.Name = "textBoxDescription";
			this.textBoxDescription.Size = new System.Drawing.Size(536, 22);
			this.textBoxDescription.TabIndex = 2;
			this.textBoxDescription.Text = "";
			this.textBoxDescription.TextChanged += new System.EventHandler(this.textBoxDescription_TextChanged);
			// 
			// textBoxSubjectCode
			// 
			this.textBoxSubjectCode.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxSubjectCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxSubjectCode.Location = new System.Drawing.Point(384, 456);
			this.textBoxSubjectCode.Name = "textBoxSubjectCode";
			this.textBoxSubjectCode.ReadOnly = true;
			this.textBoxSubjectCode.Size = new System.Drawing.Size(200, 22);
			this.textBoxSubjectCode.TabIndex = 1;
			this.textBoxSubjectCode.Text = "";
			this.textBoxSubjectCode.TextChanged += new System.EventHandler(this.textBoxSubjectCode_TextChanged);
			this.textBoxSubjectCode.Click += new System.EventHandler(this.textBoxSubjectCode_Clicked);
			// 
			// textBoxSubjectName
			// 
			this.textBoxSubjectName.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxSubjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxSubjectName.ForeColor = System.Drawing.SystemColors.WindowText;
			this.textBoxSubjectName.Location = new System.Drawing.Point(624, 456);
			this.textBoxSubjectName.Name = "textBoxSubjectName";
			this.textBoxSubjectName.ReadOnly = true;
			this.textBoxSubjectName.Size = new System.Drawing.Size(296, 22);
			this.textBoxSubjectName.TabIndex = 181;
			this.textBoxSubjectName.TabStop = false;
			this.textBoxSubjectName.Text = "";
			// 
			// labelSubjectCode
			// 
			this.labelSubjectCode.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelSubjectCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelSubjectCode.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelSubjectCode.Location = new System.Drawing.Point(256, 456);
			this.labelSubjectCode.Name = "labelSubjectCode";
			this.labelSubjectCode.Size = new System.Drawing.Size(120, 24);
			this.labelSubjectCode.TabIndex = 180;
			this.labelSubjectCode.Text = "Subject Code";
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
			this.buttonSave.TabIndex = 7;
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
			this.buttonCancel.TabIndex = 8;
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
			this.buttonDelete.TabIndex = 6;
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
			this.buttonEdit.TabIndex = 5;
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
			this.buttonAdd.TabIndex = 4;
			this.buttonAdd.Text = "Add New";
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// FrmBookMsSubject
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonEdit);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.labelDescription);
			this.Controls.Add(this.textBoxDescription);
			this.Controls.Add(this.textBoxSubjectCode);
			this.Controls.Add(this.textBoxSubjectName);
			this.Controls.Add(this.labelSubjectCode);
			this.Controls.Add(this.dataGridBookSubject);
			this.Controls.Add(this.textBoxISBN);
			this.Controls.Add(this.labelISBN);
			this.Controls.Add(this.textBoxOriginalTitle);
			this.Controls.Add(this.textBoxBookName);
			this.Controls.Add(this.textBoxBookCode);
			this.Controls.Add(this.labelOriginalTitle);
			this.Controls.Add(this.labelBookName);
			this.Controls.Add(this.labelBookCode);
			this.Controls.Add(this.LabelTitle);
			this.Name = "FrmBookMsSubject";
			this.Load += new System.EventHandler(this.FrmBookMsSubject_Load);
			this.Controls.SetChildIndex(this.LabelTitle, 0);
			this.Controls.SetChildIndex(this.labelBookCode, 0);
			this.Controls.SetChildIndex(this.labelBookName, 0);
			this.Controls.SetChildIndex(this.labelOriginalTitle, 0);
			this.Controls.SetChildIndex(this.textBoxBookCode, 0);
			this.Controls.SetChildIndex(this.textBoxBookName, 0);
			this.Controls.SetChildIndex(this.textBoxOriginalTitle, 0);
			this.Controls.SetChildIndex(this.labelISBN, 0);
			this.Controls.SetChildIndex(this.textBoxISBN, 0);
			this.Controls.SetChildIndex(this.dataGridBookSubject, 0);
			this.Controls.SetChildIndex(this.labelSubjectCode, 0);
			this.Controls.SetChildIndex(this.textBoxSubjectName, 0);
			this.Controls.SetChildIndex(this.textBoxSubjectCode, 0);
			this.Controls.SetChildIndex(this.textBoxDescription, 0);
			this.Controls.SetChildIndex(this.labelDescription, 0);
			this.Controls.SetChildIndex(this.buttonAdd, 0);
			this.Controls.SetChildIndex(this.buttonEdit, 0);
			this.Controls.SetChildIndex(this.buttonDelete, 0);
			this.Controls.SetChildIndex(this.buttonCancel, 0);
			this.Controls.SetChildIndex(this.buttonSave, 0);
			((System.ComponentModel.ISupportInitialize)(this.dataGridBookSubject)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void FrmBookMsSubject_Load(object sender, System.EventArgs e)
		{
			MyBookSubject = new BookSubject();
			MyBookSubjectDataTable = new DataTable();
			if(MyBookMenuForm.MyBookSearch.BookCode.ToString() != "")
			{
				MyClassDatabase = new ClassDatabase();
				MyDataTable = MyClassDatabase.GetBookData(MyBookMenuForm.MyBookSearch.BookCode.ToString());
				textBoxBookCode.Text = MyDataTable.Rows[0]["BookCode"].ToString().Trim();
				textBoxBookName.Text = MyDataTable.Rows[0]["BookName"].ToString().Trim();
				textBoxOriginalTitle.Text = MyDataTable.Rows[0]["OriginalTitle"].ToString().Trim();;
				textBoxISBN.Text = (MyDataTable.Rows[0]["ISBN"].ToString().Trim());
				MyClassDatabase = new ClassDatabase();
				MyBookSubjectDataTable = MyClassDatabase.GetBookSubjectData(textBoxBookCode.Text.ToString());
				dataGridBookSubject.DataSource = MyBookSubjectDataTable;
				MyBookSubject.BookCode = textBoxBookCode.Text.ToString();
				RefreshButton();
			}
		}

		private void textBoxSubjectCode_TextChanged(object sender, System.EventArgs e)
		{
			MyBookSubject.SubjectCode = textBoxSubjectCode.Text.ToString();
		}
		private void textBoxSubjectCode_Clicked(object sender, System.EventArgs e)
		{
			MySearchMiniForm = new FrmSearchMiniForm(this,"BookSubject");
			MySearchMiniForm.Show();
		}

		private void textBoxDescription_TextChanged(object sender, System.EventArgs e)
		{
			MyBookSubject.Description = textBoxDescription.Text.ToString();
		}




		internal void DoLock()
		{
			buttonAdd.Enabled = true;
			buttonSave.Enabled = false;
			buttonCancel.Enabled = false;
			
			textBoxSubjectCode.Text = "";
			textBoxSubjectName.Text = "";
			textBoxDescription.Text = "";
			MyBookSubject.PreviousSubjectCode = "";
			MyClassDatabase = new ClassDatabase();
			MyBookSubjectDataTable = MyClassDatabase.GetBookSubjectData(textBoxBookCode.Text.ToString());
			dataGridBookSubject.DataSource = MyBookSubjectDataTable;
			RefreshButton();


		}
		private void DoUnlock()
		{
			textBoxSubjectCode.Focus();
			buttonAdd.Enabled = false;
			buttonEdit.Enabled = false;
			buttonDelete.Enabled = false;
			buttonSave.Enabled = true;
			buttonCancel.Enabled = true;
		}
		internal void RefreshButton()
		{
			if(MyBookSubjectDataTable.Rows.Count>0)
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
			MyBookSubject.PreviousSubjectCode = dataGridBookSubject[dataGridBookSubject.CurrentRowIndex,0].ToString().Trim();
			textBoxSubjectCode.Text = dataGridBookSubject[dataGridBookSubject.CurrentRowIndex,0].ToString().Trim();
			textBoxSubjectName.Text = dataGridBookSubject[dataGridBookSubject.CurrentRowIndex,1].ToString().Trim();
			textBoxDescription.Text = dataGridBookSubject[dataGridBookSubject.CurrentRowIndex,2].ToString().Trim();				
			
		}
		private void buttonDelete_Click(object sender, System.EventArgs e)
		{
			DialogResult ans;
			ans = MessageBox.Show("Are you sure you want to delete Book Subject Data with SubjectCode ='" + dataGridBookSubject[dataGridBookSubject.CurrentRowIndex,0].ToString().Trim() + "' ?" , "Confirmation", MessageBoxButtons.YesNo );
			if (ans.ToString() == "Yes")
			{	
				MyClassDatabase = new ClassDatabase();
				MyClassDatabase.DeleteBookSubject(textBoxBookCode.Text.ToString(), dataGridBookSubject[dataGridBookSubject.CurrentRowIndex,0].ToString().Trim());
                Thread.Sleep(1000);
			
			}
			DoLock();
		}

		private void buttonSave_Click(object sender, System.EventArgs e)
		{
			MyBookSubject.UpdateUser = MyMDIForm.LibrarianUserName.ToString();
			MyClassDatabase = new ClassDatabase();
			MyClassDatabase.SaveBookSubject(MyBookSubject);
            Thread.Sleep(1000);
			DoLock();


		}
		private void buttonCancel_Click(object sender, System.EventArgs e)
		{
			DoLock();


		}

		private void dataGridBookSubject_DoubleClick(object sender, System.EventArgs e)
		{

		}

	
	}
}

