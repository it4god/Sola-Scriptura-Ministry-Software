using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace Sola_Scriptura_Library
{
	public class FrmBookCategorySubject : Sola_Scriptura_Library.FrmBookCategoryMaster
	{
		internal System.Windows.Forms.Label LabelTitle;
		internal System.Windows.Forms.Button buttonClear;
		internal System.Windows.Forms.TextBox textBoxSubjectCode;
		internal System.Windows.Forms.TextBox textBoxSubjectName;
		internal System.Windows.Forms.Label labelSubjectName;
		internal System.Windows.Forms.Label labelSubjectCode;
		internal System.Windows.Forms.Label label1;
		internal System.Windows.Forms.Label label2;
		internal System.Windows.Forms.Button buttonSave;
		internal System.Windows.Forms.Button buttonCancel;
		internal System.Windows.Forms.Button buttonDelete;
		internal System.Windows.Forms.Button buttonEdit;
		internal System.Windows.Forms.Button buttonAdd;
		internal System.Windows.Forms.DataGrid dataGridSubject;
		internal System.Windows.Forms.DataGridTableStyle dataGridTableStyleBookCategorySubject;
		internal System.Windows.Forms.Label labelRefresh;
		internal System.Windows.Forms.TextBox textBoxSubjectCode2;
		internal System.Windows.Forms.TextBox textBoxSubjectName2;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnSubjectCode;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnSubjectName;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnUpdateUser;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnUpdateDate;
		internal System.Windows.Forms.Button buttonRefresh;
		private System.ComponentModel.IContainer components = null;
		
		internal ClassDatabase MyClassDatabase;
		internal DataTable MyDataTable;
		internal DataView MyDataView;
		internal Subject MySubject;
		public FrmBookCategorySubject()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public FrmBookCategorySubject(FrmMDI MDIForm, FrmSetupMenu SetupMenuForm)
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmBookCategorySubject));
			this.LabelTitle = new System.Windows.Forms.Label();
			this.dataGridSubject = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyleBookCategorySubject = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnSubjectCode = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnSubjectName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnUpdateUser = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnUpdateDate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.textBoxSubjectCode = new System.Windows.Forms.TextBox();
			this.buttonClear = new System.Windows.Forms.Button();
			this.buttonRefresh = new System.Windows.Forms.Button();
			this.textBoxSubjectName = new System.Windows.Forms.TextBox();
			this.labelSubjectName = new System.Windows.Forms.Label();
			this.labelSubjectCode = new System.Windows.Forms.Label();
			this.textBoxSubjectCode2 = new System.Windows.Forms.TextBox();
			this.textBoxSubjectName2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.labelRefresh = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridSubject)).BeginInit();
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
			this.LabelTitle.TabIndex = 109;
			this.LabelTitle.Text = "    Subject List";
			this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dataGridSubject
			// 
			this.dataGridSubject.DataMember = "";
			this.dataGridSubject.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridSubject.Location = new System.Drawing.Point(248, 184);
			this.dataGridSubject.Name = "dataGridSubject";
			this.dataGridSubject.ReadOnly = true;
			this.dataGridSubject.Size = new System.Drawing.Size(672, 256);
			this.dataGridSubject.TabIndex = 169;
			this.dataGridSubject.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																										this.dataGridTableStyleBookCategorySubject});
			// 
			// dataGridTableStyleBookCategorySubject
			// 
			this.dataGridTableStyleBookCategorySubject.AlternatingBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleBookCategorySubject.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.dataGridTableStyleBookCategorySubject.DataGrid = this.dataGridSubject;
			this.dataGridTableStyleBookCategorySubject.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleBookCategorySubject.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																																	this.dataGridTextBoxColumnSubjectCode,
																																	this.dataGridTextBoxColumnSubjectName,
																																	this.dataGridTextBoxColumnUpdateUser,
																																	this.dataGridTextBoxColumnUpdateDate});
			this.dataGridTableStyleBookCategorySubject.GridLineColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridTableStyleBookCategorySubject.HeaderBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleBookCategorySubject.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleBookCategorySubject.MappingName = "SubjectList";
			// 
			// dataGridTextBoxColumnSubjectCode
			// 
			this.dataGridTextBoxColumnSubjectCode.Format = "";
			this.dataGridTextBoxColumnSubjectCode.FormatInfo = null;
			this.dataGridTextBoxColumnSubjectCode.HeaderText = "SubjectCode";
			this.dataGridTextBoxColumnSubjectCode.MappingName = "SubjectCode";
			this.dataGridTextBoxColumnSubjectCode.Width = 75;
			// 
			// dataGridTextBoxColumnSubjectName
			// 
			this.dataGridTextBoxColumnSubjectName.Format = "";
			this.dataGridTextBoxColumnSubjectName.FormatInfo = null;
			this.dataGridTextBoxColumnSubjectName.HeaderText = "Subject Name";
			this.dataGridTextBoxColumnSubjectName.MappingName = "SubjectName";
			this.dataGridTextBoxColumnSubjectName.Width = 300;
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
			// textBoxSubjectCode
			// 
			this.textBoxSubjectCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxSubjectCode.Location = new System.Drawing.Point(384, 80);
			this.textBoxSubjectCode.Name = "textBoxSubjectCode";
			this.textBoxSubjectCode.Size = new System.Drawing.Size(200, 22);
			this.textBoxSubjectCode.TabIndex = 161;
			this.textBoxSubjectCode.Text = "";
			this.textBoxSubjectCode.TextChanged += new System.EventHandler(this.textBoxSubjectCode_TextChanged);
			// 
			// buttonClear
			// 
			this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonClear.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonClear.Image = ((System.Drawing.Image)(resources.GetObject("buttonClear.Image")));
			this.buttonClear.Location = new System.Drawing.Point(728, 144);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(88, 32);
			this.buttonClear.TabIndex = 164;
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
			this.buttonRefresh.TabIndex = 165;
			this.buttonRefresh.Text = "Refresh";
			this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
			// 
			// textBoxSubjectName
			// 
			this.textBoxSubjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxSubjectName.Location = new System.Drawing.Point(384, 112);
			this.textBoxSubjectName.Name = "textBoxSubjectName";
			this.textBoxSubjectName.Size = new System.Drawing.Size(536, 22);
			this.textBoxSubjectName.TabIndex = 162;
			this.textBoxSubjectName.Text = "";
			this.textBoxSubjectName.TextChanged += new System.EventHandler(this.textBoxSubjectName_TextChanged);
			// 
			// labelSubjectName
			// 
			this.labelSubjectName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelSubjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelSubjectName.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelSubjectName.Location = new System.Drawing.Point(256, 112);
			this.labelSubjectName.Name = "labelSubjectName";
			this.labelSubjectName.Size = new System.Drawing.Size(120, 24);
			this.labelSubjectName.TabIndex = 168;
			this.labelSubjectName.Text = "Subject Name";
			// 
			// labelSubjectCode
			// 
			this.labelSubjectCode.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelSubjectCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelSubjectCode.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelSubjectCode.Location = new System.Drawing.Point(256, 80);
			this.labelSubjectCode.Name = "labelSubjectCode";
			this.labelSubjectCode.Size = new System.Drawing.Size(120, 24);
			this.labelSubjectCode.TabIndex = 166;
			this.labelSubjectCode.Text = "Subject Code";
			// 
			// textBoxSubjectCode2
			// 
			this.textBoxSubjectCode2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxSubjectCode2.Location = new System.Drawing.Point(384, 448);
			this.textBoxSubjectCode2.Name = "textBoxSubjectCode2";
			this.textBoxSubjectCode2.Size = new System.Drawing.Size(200, 22);
			this.textBoxSubjectCode2.TabIndex = 170;
			this.textBoxSubjectCode2.Text = "";
			this.textBoxSubjectCode2.TextChanged += new System.EventHandler(this.textBoxSubjectCode2_TextChanged);
			// 
			// textBoxSubjectName2
			// 
			this.textBoxSubjectName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxSubjectName2.Location = new System.Drawing.Point(384, 480);
			this.textBoxSubjectName2.Name = "textBoxSubjectName2";
			this.textBoxSubjectName2.Size = new System.Drawing.Size(536, 22);
			this.textBoxSubjectName2.TabIndex = 171;
			this.textBoxSubjectName2.Text = "";
			this.textBoxSubjectName2.TextChanged += new System.EventHandler(this.textBoxSubjectName2_TextChanged);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label1.Location = new System.Drawing.Point(256, 480);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 24);
			this.label1.TabIndex = 173;
			this.label1.Text = "Subject Name";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label2.Location = new System.Drawing.Point(256, 448);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 24);
			this.label2.TabIndex = 172;
			this.label2.Text = "Subject Code";
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
			this.buttonSave.TabIndex = 177;
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
			this.buttonCancel.TabIndex = 178;
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
			this.buttonDelete.TabIndex = 176;
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
			this.buttonEdit.TabIndex = 175;
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
			this.buttonAdd.TabIndex = 174;
			this.buttonAdd.Text = "Add New";
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// labelRefresh
			// 
			this.labelRefresh.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelRefresh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelRefresh.ForeColor = System.Drawing.Color.LightCoral;
			this.labelRefresh.Location = new System.Drawing.Point(256, 152);
			this.labelRefresh.Name = "labelRefresh";
			this.labelRefresh.Size = new System.Drawing.Size(408, 24);
			this.labelRefresh.TabIndex = 179;
			this.labelRefresh.Text = "You must refresh the data to Update Current Change in Data Grid !";
			this.labelRefresh.Visible = false;
			// 
			// FrmBookCategorySubject
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.labelRefresh);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonEdit);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.textBoxSubjectCode2);
			this.Controls.Add(this.textBoxSubjectName2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGridSubject);
			this.Controls.Add(this.textBoxSubjectCode);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.buttonRefresh);
			this.Controls.Add(this.textBoxSubjectName);
			this.Controls.Add(this.labelSubjectName);
			this.Controls.Add(this.labelSubjectCode);
			this.Controls.Add(this.LabelTitle);
			this.Name = "FrmBookCategorySubject";
			this.Load += new System.EventHandler(this.FrmBookCategorySubject_Load);
			this.Controls.SetChildIndex(this.LabelTitle, 0);
			this.Controls.SetChildIndex(this.labelSubjectCode, 0);
			this.Controls.SetChildIndex(this.labelSubjectName, 0);
			this.Controls.SetChildIndex(this.textBoxSubjectName, 0);
			this.Controls.SetChildIndex(this.buttonRefresh, 0);
			this.Controls.SetChildIndex(this.buttonClear, 0);
			this.Controls.SetChildIndex(this.textBoxSubjectCode, 0);
			this.Controls.SetChildIndex(this.dataGridSubject, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.textBoxSubjectName2, 0);
			this.Controls.SetChildIndex(this.textBoxSubjectCode2, 0);
			this.Controls.SetChildIndex(this.buttonAdd, 0);
			this.Controls.SetChildIndex(this.buttonEdit, 0);
			this.Controls.SetChildIndex(this.buttonDelete, 0);
			this.Controls.SetChildIndex(this.buttonCancel, 0);
			this.Controls.SetChildIndex(this.buttonSave, 0);
			this.Controls.SetChildIndex(this.labelRefresh, 0);
			((System.ComponentModel.ISupportInitialize)(this.dataGridSubject)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void FrmBookCategorySubject_Load(object sender, System.EventArgs e)
		{
			MySubject = new Subject();
			MyClassDatabase = new ClassDatabase();
			MyDataTable = MyClassDatabase.GetSubjectList();
			MyDataView = new DataView(MyDataTable, "SubjectCode LIKE '%" + MySubject.SubjectCode.ToString() + "%' and SubjectName LIKE '%" + MySubject.SubjectName.ToString() + "%'","SubjectCode", DataViewRowState.CurrentRows);
			dataGridSubject.DataSource = MyDataView;
			labelRefresh.Visible = false;
			RefreshButton();
		}

		private void textBoxSubjectCode_TextChanged(object sender, System.EventArgs e)
		{
			MySubject.SubjectCode = textBoxSubjectCode.Text.ToString();
			MySubject.SubjectCode = MySubject.SubjectCode.Replace("'","''");
			MyDataView = new DataView(MyDataTable, "SubjectCode LIKE '%" + MySubject.SubjectCode.ToString() + "%' and SubjectName LIKE '%" + MySubject.SubjectName.ToString() + "%'","SubjectCode", DataViewRowState.CurrentRows);
			dataGridSubject.DataSource = MyDataView;
		}

		private void textBoxSubjectName_TextChanged(object sender, System.EventArgs e)
		{
			MySubject.SubjectName = textBoxSubjectName.Text.ToString();
			MySubject.SubjectName = MySubject.SubjectName.Replace("'","''");
			MyDataView = new DataView(MyDataTable, "SubjectCode LIKE '%" + MySubject.SubjectCode.ToString() + "%' and SubjectName LIKE '%" + MySubject.SubjectName.ToString() + "%'","SubjectCode", DataViewRowState.CurrentRows);
			dataGridSubject.DataSource = MyDataView;
		}

		private void textBoxSubjectCode2_TextChanged(object sender, System.EventArgs e)
		{
			MySubject.SubjectCode = textBoxSubjectCode2.Text.ToString();		
		}

		private void textBoxSubjectName2_TextChanged(object sender, System.EventArgs e)
		{
			MySubject.SubjectName = textBoxSubjectName2.Text.ToString();
		}

		private void RefreshButton()
		{
			if(MyDataView.Count>0)
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
			textBoxSubjectCode2.Text = "";
			textBoxSubjectName2.Text = "";
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
		private void buttonClear_Click(object sender, System.EventArgs e)
		{
			textBoxSubjectCode.Text = "";
			textBoxSubjectName.Text = "";
		}

		private void buttonRefresh_Click(object sender, System.EventArgs e)
		{
			MyClassDatabase = new ClassDatabase();
			MyDataTable = MyClassDatabase.GetSubjectList();
			MyDataView = new DataView(MyDataTable, "SubjectCode LIKE '%" + textBoxSubjectCode.Text.ToString() + "%' and SubjectName LIKE '%" + textBoxSubjectName.Text.ToString() + "%'","SubjectCode", DataViewRowState.CurrentRows);
			dataGridSubject.DataSource = MyDataView;
			labelRefresh.Visible = false;
			RefreshButton();
		}
		private void buttonAdd_Click(object sender, System.EventArgs e)
		{
			DoUnlock();
		}

		private void buttonEdit_Click(object sender, System.EventArgs e)
		{
			DoUnlock();
			textBoxSubjectCode2.Text = dataGridSubject[dataGridSubject.CurrentRowIndex,0].ToString().Trim();
			textBoxSubjectName2.Text = dataGridSubject[dataGridSubject.CurrentRowIndex,1].ToString().Trim();
		}

		private void buttonDelete_Click(object sender, System.EventArgs e)
		{
			DialogResult ans;
			ans = MessageBox.Show("Are you sure you want to delete Subject Data with SubjectCode=' "+ dataGridSubject[dataGridSubject.CurrentRowIndex,0].ToString().Trim() + "' ?" , "Confirmation", MessageBoxButtons.YesNo );
			if (ans.ToString() == "Yes")
			{	
				MyClassDatabase = new ClassDatabase();
				MyClassDatabase.DeleteSubject(dataGridSubject[dataGridSubject.CurrentRowIndex,0].ToString().Trim());
				labelRefresh.Visible = true;
			}
			DoLock();
		}

		private void buttonSave_Click(object sender, System.EventArgs e)
		{
			MySubject.UpdateUser = MyMDIForm.LibrarianUserName.ToString();
			MyClassDatabase = new ClassDatabase();
			MyClassDatabase.SaveSubject(MySubject);
			labelRefresh.Visible = true;
			DoLock();
		
		}

		private void buttonCancel_Click(object sender, System.EventArgs e)
		{
			DoLock();
		}




	}
}

