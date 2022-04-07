using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace Sola_Scriptura_Library
{
	public class FrmBookCategoryGroup : Sola_Scriptura_Library.FrmBookCategoryMaster
	{
		internal System.Windows.Forms.Label LabelTitle;
		internal System.Windows.Forms.Button buttonSave;
		internal System.Windows.Forms.Button buttonCancel;
		internal System.Windows.Forms.Button buttonDelete;
		internal System.Windows.Forms.Button buttonEdit;
		internal System.Windows.Forms.Button buttonAdd;
		internal System.Windows.Forms.Label labelGroupCode;
		internal System.Windows.Forms.TextBox textBoxGroupCode;
		internal System.Windows.Forms.TextBox textBoxGroupName;
		internal System.Windows.Forms.Label labelGroupName;
		internal System.Windows.Forms.DataGrid dataGridBookCategoryGroup;
		internal System.Windows.Forms.DataGridTableStyle dataGridTableStyleBookCategoryGroup;
		private System.ComponentModel.IContainer components = null;

		internal ClassDatabase MyClassDatabase;
		internal DataTable MyDataTable;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnBookGroupCode;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnBookGroupName;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnUpdateUser;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnUpdateDate;
		internal BookGroup MyBookGroup;

		public FrmBookCategoryGroup()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public FrmBookCategoryGroup(FrmMDI MDIForm, FrmSetupMenu SetupMenuForm)
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmBookCategoryGroup));
			this.LabelTitle = new System.Windows.Forms.Label();
			this.labelGroupCode = new System.Windows.Forms.Label();
			this.textBoxGroupCode = new System.Windows.Forms.TextBox();
			this.textBoxGroupName = new System.Windows.Forms.TextBox();
			this.labelGroupName = new System.Windows.Forms.Label();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.dataGridBookCategoryGroup = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyleBookCategoryGroup = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnBookGroupCode = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnBookGroupName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnUpdateUser = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnUpdateDate = new System.Windows.Forms.DataGridTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridBookCategoryGroup)).BeginInit();
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
			this.LabelTitle.Text = "    Book Group";
			this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelGroupCode
			// 
			this.labelGroupCode.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelGroupCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelGroupCode.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelGroupCode.Location = new System.Drawing.Point(256, 448);
			this.labelGroupCode.Name = "labelGroupCode";
			this.labelGroupCode.Size = new System.Drawing.Size(120, 24);
			this.labelGroupCode.TabIndex = 183;
			this.labelGroupCode.Text = "Group Code";
			// 
			// textBoxGroupCode
			// 
			this.textBoxGroupCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxGroupCode.Location = new System.Drawing.Point(384, 448);
			this.textBoxGroupCode.Name = "textBoxGroupCode";
			this.textBoxGroupCode.Size = new System.Drawing.Size(200, 22);
			this.textBoxGroupCode.TabIndex = 1;
			this.textBoxGroupCode.Text = "";
			this.textBoxGroupCode.TextChanged += new System.EventHandler(this.textBoxGroupCode_TextChanged);
			// 
			// textBoxGroupName
			// 
			this.textBoxGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxGroupName.Location = new System.Drawing.Point(384, 480);
			this.textBoxGroupName.Name = "textBoxGroupName";
			this.textBoxGroupName.Size = new System.Drawing.Size(536, 22);
			this.textBoxGroupName.TabIndex = 2;
			this.textBoxGroupName.Text = "";
			this.textBoxGroupName.TextChanged += new System.EventHandler(this.textBoxGroupName_TextChanged);
			// 
			// labelGroupName
			// 
			this.labelGroupName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelGroupName.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelGroupName.Location = new System.Drawing.Point(256, 480);
			this.labelGroupName.Name = "labelGroupName";
			this.labelGroupName.Size = new System.Drawing.Size(120, 24);
			this.labelGroupName.TabIndex = 182;
			this.labelGroupName.Text = "Group Name";
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
			// dataGridBookCategoryGroup
			// 
			this.dataGridBookCategoryGroup.DataMember = "";
			this.dataGridBookCategoryGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGridBookCategoryGroup.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridBookCategoryGroup.Location = new System.Drawing.Point(248, 72);
			this.dataGridBookCategoryGroup.Name = "dataGridBookCategoryGroup";
			this.dataGridBookCategoryGroup.ReadOnly = true;
			this.dataGridBookCategoryGroup.Size = new System.Drawing.Size(672, 368);
			this.dataGridBookCategoryGroup.TabIndex = 181;
			this.dataGridBookCategoryGroup.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																												  this.dataGridTableStyleBookCategoryGroup});
			// 
			// dataGridTableStyleBookCategoryGroup
			// 
			this.dataGridTableStyleBookCategoryGroup.AlternatingBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleBookCategoryGroup.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.dataGridTableStyleBookCategoryGroup.DataGrid = this.dataGridBookCategoryGroup;
			this.dataGridTableStyleBookCategoryGroup.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleBookCategoryGroup.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																																  this.dataGridTextBoxColumnBookGroupCode,
																																  this.dataGridTextBoxColumnBookGroupName,
																																  this.dataGridTextBoxColumnUpdateUser,
																																  this.dataGridTextBoxColumnUpdateDate});
			this.dataGridTableStyleBookCategoryGroup.GridLineColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridTableStyleBookCategoryGroup.HeaderBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleBookCategoryGroup.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleBookCategoryGroup.MappingName = "BookGroup";
			// 
			// dataGridTextBoxColumnBookGroupCode
			// 
			this.dataGridTextBoxColumnBookGroupCode.Format = "";
			this.dataGridTextBoxColumnBookGroupCode.FormatInfo = null;
			this.dataGridTextBoxColumnBookGroupCode.HeaderText = "Group Code";
			this.dataGridTextBoxColumnBookGroupCode.MappingName = "BookGroupCode";
			this.dataGridTextBoxColumnBookGroupCode.Width = 75;
			// 
			// dataGridTextBoxColumnBookGroupName
			// 
			this.dataGridTextBoxColumnBookGroupName.Format = "";
			this.dataGridTextBoxColumnBookGroupName.FormatInfo = null;
			this.dataGridTextBoxColumnBookGroupName.HeaderText = "Group Name";
			this.dataGridTextBoxColumnBookGroupName.MappingName = "GroupName";
			this.dataGridTextBoxColumnBookGroupName.Width = 250;
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
			// FrmBookCategoryGroup
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.labelGroupCode);
			this.Controls.Add(this.textBoxGroupCode);
			this.Controls.Add(this.textBoxGroupName);
			this.Controls.Add(this.labelGroupName);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonEdit);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.dataGridBookCategoryGroup);
			this.Controls.Add(this.LabelTitle);
			this.Name = "FrmBookCategoryGroup";
			this.Load += new System.EventHandler(this.FrmBookCategoryGroup_Load);
			this.Controls.SetChildIndex(this.LabelTitle, 0);
			this.Controls.SetChildIndex(this.dataGridBookCategoryGroup, 0);
			this.Controls.SetChildIndex(this.buttonAdd, 0);
			this.Controls.SetChildIndex(this.buttonEdit, 0);
			this.Controls.SetChildIndex(this.buttonDelete, 0);
			this.Controls.SetChildIndex(this.buttonCancel, 0);
			this.Controls.SetChildIndex(this.buttonSave, 0);
			this.Controls.SetChildIndex(this.labelGroupName, 0);
			this.Controls.SetChildIndex(this.textBoxGroupName, 0);
			this.Controls.SetChildIndex(this.textBoxGroupCode, 0);
			this.Controls.SetChildIndex(this.labelGroupCode, 0);
			((System.ComponentModel.ISupportInitialize)(this.dataGridBookCategoryGroup)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void FrmBookCategoryGroup_Load(object sender, System.EventArgs e)
		{
			MyBookGroup = new BookGroup();
			MyClassDatabase = new ClassDatabase();
			MyDataTable = MyClassDatabase.GetBookGroup();
			dataGridBookCategoryGroup.DataSource = MyDataTable;
			RefreshButton();
		}
		private void RefreshButton()
		{
			if(MyDataTable.Rows.Count >0)
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
			textBoxGroupCode.Text = "";
			textBoxGroupName.Text = "";
			MyClassDatabase = new ClassDatabase();
			MyDataTable = MyClassDatabase.GetBookGroup();
			dataGridBookCategoryGroup.DataSource = MyDataTable;
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
		private void textBoxGroupCode_TextChanged(object sender, System.EventArgs e)
		{
			MyBookGroup.BookGroupCode = textBoxGroupCode.Text.ToString();		
		}
		private void textBoxGroupName_TextChanged(object sender, System.EventArgs e)
		{
			MyBookGroup.BookGroupName = textBoxGroupName.Text.ToString();
		}
		private void buttonAdd_Click(object sender, System.EventArgs e)
		{
			DoUnlock();
			textBoxGroupCode.Focus();
		}

		private void buttonEdit_Click(object sender, System.EventArgs e)
		{
			DoUnlock();
			textBoxGroupCode.Text = dataGridBookCategoryGroup[dataGridBookCategoryGroup.CurrentRowIndex,0].ToString().Trim();
			textBoxGroupName.Text = dataGridBookCategoryGroup[dataGridBookCategoryGroup.CurrentRowIndex,1].ToString().Trim();
		}

		private void buttonDelete_Click(object sender, System.EventArgs e)
		{
			DialogResult ans;
			ans = MessageBox.Show("Are you sure you want to delete BookGroup Data with BookGroup=' "+ dataGridBookCategoryGroup[dataGridBookCategoryGroup.CurrentRowIndex,0].ToString().Trim() + "' ?" , "Confirmation", MessageBoxButtons.YesNo );
			if (ans.ToString() == "Yes")
			{	
				MyClassDatabase = new ClassDatabase();
				MyClassDatabase.DeleteBookGroup(dataGridBookCategoryGroup[dataGridBookCategoryGroup.CurrentRowIndex,0].ToString().Trim());
			}
			DoLock();
		}

		private void buttonSave_Click(object sender, System.EventArgs e)
		{
			MyBookGroup.UpdateUser = MyMDIForm.LibrarianUserName.ToString();
			MyClassDatabase = new ClassDatabase();
			MyClassDatabase.SaveBookGroup(MyBookGroup);
			DoLock();
		}

		private void buttonCancel_Click(object sender, System.EventArgs e)
		{
			DoLock();
		}


	}
}

