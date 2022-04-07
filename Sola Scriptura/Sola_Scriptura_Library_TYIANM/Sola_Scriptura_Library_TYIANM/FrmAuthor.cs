using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace Sola_Scriptura_Library
{
	public class FrmAuthor : Sola_Scriptura_Library.FrmAuthorMaster
	{
		internal System.Windows.Forms.TextBox textBoxAuthorCode;
		internal System.Windows.Forms.Button buttonClear;
		internal System.Windows.Forms.TextBox textBoxFirstName;
		internal System.Windows.Forms.Label labelFirstName;
		internal System.Windows.Forms.TextBox textBoxLastName;
		internal System.Windows.Forms.Label labelLastName;
		internal System.Windows.Forms.Label labelAuthorCode;
		internal System.Windows.Forms.Label LabelTitle;
		internal System.Windows.Forms.Button buttonSave;
		internal System.Windows.Forms.Button buttonCancel;
		internal System.Windows.Forms.Button buttonDelete;
		internal System.Windows.Forms.Button buttonEdit;
		internal System.Windows.Forms.Button buttonAdd;
		internal System.Windows.Forms.TextBox textBoxAuthorCode2;
		internal System.Windows.Forms.TextBox textBoxFirstName2;
		internal System.Windows.Forms.Label labelFirstName2;
		internal System.Windows.Forms.Label labelLastName2;
		internal System.Windows.Forms.Label labelAuthorCode2;
		internal System.Windows.Forms.DataGrid dataGridAuthor;
		internal System.Windows.Forms.DataGridTableStyle dataGridTableStyleAuthor;
		internal System.Windows.Forms.TextBox textBoxLastName2;

		private System.ComponentModel.IContainer components = null;

		internal ClassDatabase MyClassDatabase;
		internal DataTable MyDataTable;
		internal DataView MyDataView;
		internal Author MyAuthor;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnAuthorCode;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnFirstName;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnLastName;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnUpdateUser;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnUpdateDate;
		internal System.Windows.Forms.Button buttonRefresh;
		internal System.Windows.Forms.Label labelRefresh;
	
	

		public FrmAuthor()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public FrmAuthor(FrmMDI MDIForm, FrmSetupMenu SetupMenuForm)
		{
			InitializeComponent();
			base.MyMDIForm = MDIForm;
			base.MySetupMenuForm = SetupMenuForm;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmAuthor));
			this.textBoxAuthorCode = new System.Windows.Forms.TextBox();
			this.buttonClear = new System.Windows.Forms.Button();
			this.buttonRefresh = new System.Windows.Forms.Button();
			this.textBoxFirstName = new System.Windows.Forms.TextBox();
			this.labelFirstName = new System.Windows.Forms.Label();
			this.textBoxLastName = new System.Windows.Forms.TextBox();
			this.labelLastName = new System.Windows.Forms.Label();
			this.labelAuthorCode = new System.Windows.Forms.Label();
			this.dataGridAuthor = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyleAuthor = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnAuthorCode = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnFirstName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnLastName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnUpdateUser = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnUpdateDate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.LabelTitle = new System.Windows.Forms.Label();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.textBoxAuthorCode2 = new System.Windows.Forms.TextBox();
			this.textBoxFirstName2 = new System.Windows.Forms.TextBox();
			this.labelFirstName2 = new System.Windows.Forms.Label();
			this.textBoxLastName2 = new System.Windows.Forms.TextBox();
			this.labelLastName2 = new System.Windows.Forms.Label();
			this.labelAuthorCode2 = new System.Windows.Forms.Label();
			this.labelRefresh = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridAuthor)).BeginInit();
			this.SuspendLayout();
			// 
			// textBoxAuthorCode
			// 
			this.textBoxAuthorCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxAuthorCode.Location = new System.Drawing.Point(384, 80);
			this.textBoxAuthorCode.Name = "textBoxAuthorCode";
			this.textBoxAuthorCode.Size = new System.Drawing.Size(200, 22);
			this.textBoxAuthorCode.TabIndex = 1;
			this.textBoxAuthorCode.Text = "";
			this.textBoxAuthorCode.TextChanged += new System.EventHandler(this.textBoxAuthorCode_TextChanged);
			// 
			// buttonClear
			// 
			this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonClear.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonClear.Image = ((System.Drawing.Image)(resources.GetObject("buttonClear.Image")));
			this.buttonClear.Location = new System.Drawing.Point(728, 144);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(88, 32);
			this.buttonClear.TabIndex = 4;
			this.buttonClear.Text = "Clear";
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// buttonRefresh
			// 
			this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonRefresh.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("buttonRefresh.Image")));
			this.buttonRefresh.Location = new System.Drawing.Point(832, 144);
			this.buttonRefresh.Name = "buttonRefresh";
			this.buttonRefresh.Size = new System.Drawing.Size(88, 32);
			this.buttonRefresh.TabIndex = 5;
			this.buttonRefresh.Text = "Refresh";
			this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
			// 
			// textBoxFirstName
			// 
			this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxFirstName.Location = new System.Drawing.Point(384, 112);
			this.textBoxFirstName.Name = "textBoxFirstName";
			this.textBoxFirstName.Size = new System.Drawing.Size(200, 22);
			this.textBoxFirstName.TabIndex = 2;
			this.textBoxFirstName.Text = "";
			this.textBoxFirstName.TextChanged += new System.EventHandler(this.textBoxFirstName_TextChanged);
			// 
			// labelFirstName
			// 
			this.labelFirstName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelFirstName.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelFirstName.Location = new System.Drawing.Point(256, 112);
			this.labelFirstName.Name = "labelFirstName";
			this.labelFirstName.Size = new System.Drawing.Size(120, 24);
			this.labelFirstName.TabIndex = 157;
			this.labelFirstName.Text = "First Name";
			// 
			// textBoxLastName
			// 
			this.textBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxLastName.Location = new System.Drawing.Point(720, 112);
			this.textBoxLastName.Name = "textBoxLastName";
			this.textBoxLastName.Size = new System.Drawing.Size(200, 22);
			this.textBoxLastName.TabIndex = 3;
			this.textBoxLastName.Text = "";
			this.textBoxLastName.TextChanged += new System.EventHandler(this.textBoxLastName_TextChanged);
			// 
			// labelLastName
			// 
			this.labelLastName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelLastName.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelLastName.Location = new System.Drawing.Point(600, 112);
			this.labelLastName.Name = "labelLastName";
			this.labelLastName.Size = new System.Drawing.Size(120, 24);
			this.labelLastName.TabIndex = 156;
			this.labelLastName.Text = "Last Name";
			// 
			// labelAuthorCode
			// 
			this.labelAuthorCode.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelAuthorCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelAuthorCode.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelAuthorCode.Location = new System.Drawing.Point(256, 80);
			this.labelAuthorCode.Name = "labelAuthorCode";
			this.labelAuthorCode.Size = new System.Drawing.Size(120, 24);
			this.labelAuthorCode.TabIndex = 155;
			this.labelAuthorCode.Text = "Author Code";
			// 
			// dataGridAuthor
			// 
			this.dataGridAuthor.DataMember = "";
			this.dataGridAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGridAuthor.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGridAuthor.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridAuthor.Location = new System.Drawing.Point(248, 184);
			this.dataGridAuthor.Name = "dataGridAuthor";
			this.dataGridAuthor.ReadOnly = true;
			this.dataGridAuthor.Size = new System.Drawing.Size(672, 256);
			this.dataGridAuthor.TabIndex = 160;
			this.dataGridAuthor.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																									   this.dataGridTableStyleAuthor});
			// 
			// dataGridTableStyleAuthor
			// 
			this.dataGridTableStyleAuthor.AlternatingBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleAuthor.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.dataGridTableStyleAuthor.DataGrid = this.dataGridAuthor;
			this.dataGridTableStyleAuthor.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleAuthor.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																													   this.dataGridTextBoxColumnAuthorCode,
																													   this.dataGridTextBoxColumnFirstName,
																													   this.dataGridTextBoxColumnLastName,
																													   this.dataGridTextBoxColumnUpdateUser,
																													   this.dataGridTextBoxColumnUpdateDate});
			this.dataGridTableStyleAuthor.GridLineColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridTableStyleAuthor.HeaderBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleAuthor.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleAuthor.MappingName = "AuthorList";
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
			this.dataGridTextBoxColumnFirstName.HeaderText = "First Name";
			this.dataGridTextBoxColumnFirstName.MappingName = "FirstName";
			this.dataGridTextBoxColumnFirstName.Width = 130;
			// 
			// dataGridTextBoxColumnLastName
			// 
			this.dataGridTextBoxColumnLastName.Format = "";
			this.dataGridTextBoxColumnLastName.FormatInfo = null;
			this.dataGridTextBoxColumnLastName.HeaderText = "Last Name";
			this.dataGridTextBoxColumnLastName.MappingName = "LastName";
			this.dataGridTextBoxColumnLastName.Width = 130;
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
			// LabelTitle
			// 
			this.LabelTitle.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.LabelTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.LabelTitle.Image = ((System.Drawing.Image)(resources.GetObject("LabelTitle.Image")));
			this.LabelTitle.Location = new System.Drawing.Point(792, 16);
			this.LabelTitle.Name = "LabelTitle";
			this.LabelTitle.Size = new System.Drawing.Size(192, 32);
			this.LabelTitle.TabIndex = 161;
			this.LabelTitle.Text = "    Author List";
			this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.buttonSave.TabIndex = 12;
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
			this.buttonCancel.TabIndex = 13;
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
			this.buttonDelete.TabIndex = 11;
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
			this.buttonEdit.TabIndex = 10;
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
			this.buttonAdd.TabIndex = 9;
			this.buttonAdd.Text = "Add New";
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// textBoxAuthorCode2
			// 
			this.textBoxAuthorCode2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxAuthorCode2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxAuthorCode2.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxAuthorCode2.Location = new System.Drawing.Point(384, 448);
			this.textBoxAuthorCode2.Name = "textBoxAuthorCode2";
			this.textBoxAuthorCode2.ReadOnly = true;
			this.textBoxAuthorCode2.Size = new System.Drawing.Size(200, 22);
			this.textBoxAuthorCode2.TabIndex = 6;
			this.textBoxAuthorCode2.Text = "";
			this.textBoxAuthorCode2.TextChanged += new System.EventHandler(this.textBoxAuthorCode2_TextChanged);
			// 
			// textBoxFirstName2
			// 
			this.textBoxFirstName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxFirstName2.Location = new System.Drawing.Point(384, 480);
			this.textBoxFirstName2.Name = "textBoxFirstName2";
			this.textBoxFirstName2.Size = new System.Drawing.Size(200, 22);
			this.textBoxFirstName2.TabIndex = 7;
			this.textBoxFirstName2.Text = "";
			this.textBoxFirstName2.TextChanged += new System.EventHandler(this.textBoxFirstName2_TextChanged);
			// 
			// labelFirstName2
			// 
			this.labelFirstName2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelFirstName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelFirstName2.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelFirstName2.Location = new System.Drawing.Point(256, 480);
			this.labelFirstName2.Name = "labelFirstName2";
			this.labelFirstName2.Size = new System.Drawing.Size(120, 24);
			this.labelFirstName2.TabIndex = 172;
			this.labelFirstName2.Text = "First Name";
			// 
			// textBoxLastName2
			// 
			this.textBoxLastName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxLastName2.Location = new System.Drawing.Point(720, 480);
			this.textBoxLastName2.Name = "textBoxLastName2";
			this.textBoxLastName2.Size = new System.Drawing.Size(200, 22);
			this.textBoxLastName2.TabIndex = 8;
			this.textBoxLastName2.Text = "";
			this.textBoxLastName2.TextChanged += new System.EventHandler(this.textBoxLastName2_TextChanged);
			// 
			// labelLastName2
			// 
			this.labelLastName2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelLastName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelLastName2.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelLastName2.Location = new System.Drawing.Point(592, 480);
			this.labelLastName2.Name = "labelLastName2";
			this.labelLastName2.Size = new System.Drawing.Size(120, 24);
			this.labelLastName2.TabIndex = 171;
			this.labelLastName2.Text = "Last Name";
			// 
			// labelAuthorCode2
			// 
			this.labelAuthorCode2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelAuthorCode2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelAuthorCode2.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelAuthorCode2.Location = new System.Drawing.Point(256, 448);
			this.labelAuthorCode2.Name = "labelAuthorCode2";
			this.labelAuthorCode2.Size = new System.Drawing.Size(120, 24);
			this.labelAuthorCode2.TabIndex = 173;
			this.labelAuthorCode2.Text = "Author Code";
			// 
			// labelRefresh
			// 
			this.labelRefresh.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelRefresh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelRefresh.ForeColor = System.Drawing.Color.LightCoral;
			this.labelRefresh.Location = new System.Drawing.Point(256, 152);
			this.labelRefresh.Name = "labelRefresh";
			this.labelRefresh.Size = new System.Drawing.Size(408, 24);
			this.labelRefresh.TabIndex = 174;
			this.labelRefresh.Text = "You must refresh the data to Update Current Change in Data Grid !";
			this.labelRefresh.Visible = false;
			// 
			// FrmAuthor
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.labelRefresh);
			this.Controls.Add(this.labelAuthorCode2);
			this.Controls.Add(this.textBoxAuthorCode2);
			this.Controls.Add(this.textBoxFirstName2);
			this.Controls.Add(this.labelFirstName2);
			this.Controls.Add(this.textBoxLastName2);
			this.Controls.Add(this.labelLastName2);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonEdit);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.LabelTitle);
			this.Controls.Add(this.dataGridAuthor);
			this.Controls.Add(this.textBoxAuthorCode);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.buttonRefresh);
			this.Controls.Add(this.textBoxFirstName);
			this.Controls.Add(this.labelFirstName);
			this.Controls.Add(this.textBoxLastName);
			this.Controls.Add(this.labelLastName);
			this.Controls.Add(this.labelAuthorCode);
			this.Name = "FrmAuthor";
			this.Load += new System.EventHandler(this.FrmAuthor_Load);
			this.Controls.SetChildIndex(this.labelAuthorCode, 0);
			this.Controls.SetChildIndex(this.labelLastName, 0);
			this.Controls.SetChildIndex(this.textBoxLastName, 0);
			this.Controls.SetChildIndex(this.labelFirstName, 0);
			this.Controls.SetChildIndex(this.textBoxFirstName, 0);
			this.Controls.SetChildIndex(this.buttonRefresh, 0);
			this.Controls.SetChildIndex(this.buttonClear, 0);
			this.Controls.SetChildIndex(this.textBoxAuthorCode, 0);
			this.Controls.SetChildIndex(this.dataGridAuthor, 0);
			this.Controls.SetChildIndex(this.LabelTitle, 0);
			this.Controls.SetChildIndex(this.buttonAdd, 0);
			this.Controls.SetChildIndex(this.buttonEdit, 0);
			this.Controls.SetChildIndex(this.buttonDelete, 0);
			this.Controls.SetChildIndex(this.buttonCancel, 0);
			this.Controls.SetChildIndex(this.buttonSave, 0);
			this.Controls.SetChildIndex(this.labelLastName2, 0);
			this.Controls.SetChildIndex(this.textBoxLastName2, 0);
			this.Controls.SetChildIndex(this.labelFirstName2, 0);
			this.Controls.SetChildIndex(this.textBoxFirstName2, 0);
			this.Controls.SetChildIndex(this.textBoxAuthorCode2, 0);
			this.Controls.SetChildIndex(this.labelAuthorCode2, 0);
			this.Controls.SetChildIndex(this.labelRefresh, 0);
			((System.ComponentModel.ISupportInitialize)(this.dataGridAuthor)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void FrmAuthor_Load(object sender, System.EventArgs e)
		{
			MyAuthor = new Author();
			MyClassDatabase = new ClassDatabase();
			MyDataTable = MyClassDatabase.GetAuthorList();
			MyDataView = new DataView(MyDataTable, "AuthorCode LIKE '%" + MyAuthor.AuthorCode.ToString() + "%' and FirstName LIKE '%" + MyAuthor.FirstName.ToString() + "%' " + " and LastName LIKE '%" + MyAuthor.LastName.ToString() + "%' ", "AuthorCode", DataViewRowState.CurrentRows);
			dataGridAuthor.DataSource = MyDataView;
			RefreshButton();
			labelRefresh.Visible = false;
			
		}

		private void textBoxAuthorCode_TextChanged(object sender, System.EventArgs e)
		{
			MyAuthor.AuthorCode = textBoxAuthorCode.Text.ToString();
			MyAuthor.AuthorCode = MyAuthor.AuthorCode.Replace("'","''");
			MyDataView = new DataView(MyDataTable, "AuthorCode LIKE '%" + MyAuthor.AuthorCode.ToString() + "%' and FirstName LIKE '%" + MyAuthor.FirstName.ToString() + "%' " + " and LastName LIKE '%" + MyAuthor.LastName.ToString() + "%' ", "AuthorCode", DataViewRowState.CurrentRows);
			dataGridAuthor.DataSource = MyDataView;
			RefreshButton();
		}

		private void textBoxFirstName_TextChanged(object sender, System.EventArgs e)
		{
			MyAuthor.FirstName = textBoxFirstName.Text.ToString();
			MyAuthor.FirstName = MyAuthor.FirstName.Replace("'","''");
			MyDataView = new DataView(MyDataTable, "AuthorCode LIKE '%" + MyAuthor.AuthorCode.ToString() + "%' and FirstName LIKE '%" + MyAuthor.FirstName.ToString() + "%' " + " and LastName LIKE '%" + MyAuthor.LastName.ToString() + "%' ", "AuthorCode", DataViewRowState.CurrentRows);
			dataGridAuthor.DataSource = MyDataView;
			RefreshButton();
		}

		private void textBoxLastName_TextChanged(object sender, System.EventArgs e)
		{
			MyAuthor.LastName = textBoxLastName.Text.ToString();
			MyAuthor.LastName = MyAuthor.LastName.Replace("'","''");
			MyDataView = new DataView(MyDataTable, "AuthorCode LIKE '%" + MyAuthor.AuthorCode.ToString() + "%' and FirstName LIKE '%" + MyAuthor.FirstName.ToString() + "%' " + " and LastName LIKE '%" + MyAuthor.LastName.ToString() + "%' ", "AuthorCode", DataViewRowState.CurrentRows);
			dataGridAuthor.DataSource = MyDataView;
			RefreshButton();
		}

		private void textBoxAuthorCode2_TextChanged(object sender, System.EventArgs e)
		{
			MyAuthor.AuthorCode = textBoxAuthorCode2.Text.ToString();
		}

		private void textBoxFirstName2_TextChanged(object sender, System.EventArgs e)
		{
			MyAuthor.FirstName = textBoxFirstName2.Text.ToString();
		}

		private void textBoxLastName2_TextChanged(object sender, System.EventArgs e)
		{
			MyAuthor.LastName = textBoxLastName2.Text.ToString();
		}
		private void buttonClear_Click(object sender, System.EventArgs e)
		{
			textBoxAuthorCode.Text = "";
			textBoxFirstName.Text = "";
			textBoxLastName.Text = "";

		}
		private void buttonRefresh_Click(object sender, System.EventArgs e)
		{
			MyClassDatabase = new ClassDatabase();
			MyDataTable = MyClassDatabase.GetAuthorList();
			dataGridAuthor.DataSource = MyDataTable;
			RefreshButton();
			labelRefresh.Visible = false;

		}
		private void RefreshButton()
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
		}
		private void DoLock()
		{
			buttonAdd.Enabled = true;
			buttonSave.Enabled = false;
			buttonCancel.Enabled = false;
			textBoxAuthorCode2.Text = "";
			textBoxFirstName2.Text = "";
			textBoxLastName2.Text = "";
			RefreshButton();
		}
		private void DoUnlock()
		{
			buttonAdd.Enabled = false;
			buttonEdit.Enabled = false;
			buttonDelete.Enabled = false;
			buttonSave.Enabled = true;
			buttonCancel.Enabled = true;
		}

		private void buttonAdd_Click(object sender, System.EventArgs e)
		{
			MyClassDatabase = new ClassDatabase();
			string MaxNo;
			int len;
			long MaxNoPlusOne;
			string AuthorCode;
		
			MaxNo = MyClassDatabase.GetMaxAuthorCode();
			MaxNo = MaxNo.Trim().Substring(1);
			MaxNoPlusOne = Convert.ToInt64(MaxNo) + 1;
			len = MaxNoPlusOne.ToString().Length;
			AuthorCode = "A";
			for(int x=0;x<(MaxNo.Length-len);x++)
				AuthorCode += "0";
			AuthorCode += MaxNoPlusOne.ToString();
			textBoxAuthorCode2.Text = AuthorCode;
			DoUnlock();
			textBoxFirstName2.Focus();
		}

		private void buttonEdit_Click(object sender, System.EventArgs e)
		{
			DoUnlock();
			textBoxAuthorCode2.Text = dataGridAuthor[dataGridAuthor.CurrentRowIndex,0].ToString().Trim();
			textBoxFirstName2.Text = dataGridAuthor[dataGridAuthor.CurrentRowIndex,1].ToString().Trim();
			textBoxLastName2.Text = dataGridAuthor[dataGridAuthor.CurrentRowIndex,2].ToString().Trim();

		}

		private void buttonDelete_Click(object sender, System.EventArgs e)
		{
			DialogResult ans;
			ans = MessageBox.Show("Are you sure you want to delete Author Data with AuthorCode=' "+ dataGridAuthor[dataGridAuthor.CurrentRowIndex,0].ToString().Trim() + "' ?" , "Confirmation", MessageBoxButtons.YesNo );
			if (ans.ToString() == "Yes")
			{	
				MyClassDatabase = new ClassDatabase();
				MyClassDatabase.DeleteAuthor(dataGridAuthor[dataGridAuthor.CurrentRowIndex,0].ToString().Trim());
				labelRefresh.Visible = true;
			}
			DoLock();
		}

		private void buttonSave_Click(object sender, System.EventArgs e)
		{
			MyAuthor.UpdateUser = MyMDIForm.LibrarianUserName.ToString();
			MyClassDatabase = new ClassDatabase();
			MyClassDatabase.SaveAuthor(MyAuthor);
			labelRefresh.Visible = true;
			DoLock();
		}

		private void buttonCancel_Click(object sender, System.EventArgs e)
		{
			DoLock();
		}





		
	}
}

