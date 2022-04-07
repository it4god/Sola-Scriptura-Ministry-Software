using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace Sola_Scriptura_Library
{
	public class FrmBookCategoryType : Sola_Scriptura_Library.FrmBookCategoryMaster
	{
		internal System.Windows.Forms.Label LabelTitle;
		internal System.Windows.Forms.Button buttonSave;
		internal System.Windows.Forms.Button buttonCancel;
		internal System.Windows.Forms.Button buttonDelete;
		internal System.Windows.Forms.Button buttonEdit;
		internal System.Windows.Forms.Button buttonAdd;
		internal System.Windows.Forms.TextBox textBoxBookType;
		internal System.Windows.Forms.DataGrid dataGridBookCategoryType;
		internal System.Windows.Forms.DataGridTableStyle dataGridTableStyleBookCategoryType;
		internal System.Windows.Forms.Label labelBookType;
		private System.ComponentModel.IContainer components = null;

		internal ClassDatabase MyClassDatabase;
		internal DataTable MyDataTable;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnBookType;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnUpdateUser;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnUpdateDate;
		internal BookType MyBookType;
	
		public FrmBookCategoryType()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public FrmBookCategoryType(FrmMDI MDIForm, FrmSetupMenu SetupMenuForm)
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmBookCategoryType));
			this.LabelTitle = new System.Windows.Forms.Label();
			this.dataGridBookCategoryType = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyleBookCategoryType = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnBookType = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnUpdateUser = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnUpdateDate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.textBoxBookType = new System.Windows.Forms.TextBox();
			this.labelBookType = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridBookCategoryType)).BeginInit();
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
			this.LabelTitle.Text = "    Book Type";
			this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dataGridBookCategoryType
			// 
			this.dataGridBookCategoryType.DataMember = "";
			this.dataGridBookCategoryType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGridBookCategoryType.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridBookCategoryType.Location = new System.Drawing.Point(248, 72);
			this.dataGridBookCategoryType.Name = "dataGridBookCategoryType";
			this.dataGridBookCategoryType.ReadOnly = true;
			this.dataGridBookCategoryType.Size = new System.Drawing.Size(672, 392);
			this.dataGridBookCategoryType.TabIndex = 185;
			this.dataGridBookCategoryType.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																												 this.dataGridTableStyleBookCategoryType});
			// 
			// dataGridTableStyleBookCategoryType
			// 
			this.dataGridTableStyleBookCategoryType.AlternatingBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleBookCategoryType.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.dataGridTableStyleBookCategoryType.DataGrid = this.dataGridBookCategoryType;
			this.dataGridTableStyleBookCategoryType.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleBookCategoryType.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																																 this.dataGridTextBoxColumnBookType,
																																 this.dataGridTextBoxColumnUpdateUser,
																																 this.dataGridTextBoxColumnUpdateDate});
			this.dataGridTableStyleBookCategoryType.GridLineColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridTableStyleBookCategoryType.HeaderBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleBookCategoryType.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleBookCategoryType.MappingName = "BookType";
			// 
			// dataGridTextBoxColumnBookType
			// 
			this.dataGridTextBoxColumnBookType.Format = "";
			this.dataGridTextBoxColumnBookType.FormatInfo = null;
			this.dataGridTextBoxColumnBookType.HeaderText = "Book Type";
			this.dataGridTextBoxColumnBookType.MappingName = "BookType";
			this.dataGridTextBoxColumnBookType.Width = 300;
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
			this.buttonDelete.TabIndex = 4;
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
			this.buttonEdit.TabIndex = 3;
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
			this.buttonAdd.TabIndex = 2;
			this.buttonAdd.Text = "Add New";
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// textBoxBookType
			// 
			this.textBoxBookType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxBookType.Location = new System.Drawing.Point(376, 480);
			this.textBoxBookType.Name = "textBoxBookType";
			this.textBoxBookType.Size = new System.Drawing.Size(544, 22);
			this.textBoxBookType.TabIndex = 1;
			this.textBoxBookType.Text = "";
			this.textBoxBookType.TextChanged += new System.EventHandler(this.textBoxBookType_TextChanged);
			// 
			// labelBookType
			// 
			this.labelBookType.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelBookType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBookType.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelBookType.Location = new System.Drawing.Point(256, 480);
			this.labelBookType.Name = "labelBookType";
			this.labelBookType.Size = new System.Drawing.Size(120, 24);
			this.labelBookType.TabIndex = 179;
			this.labelBookType.Text = "Book Type";
			// 
			// FrmBookCategoryType
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.dataGridBookCategoryType);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonEdit);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.textBoxBookType);
			this.Controls.Add(this.labelBookType);
			this.Controls.Add(this.LabelTitle);
			this.Name = "FrmBookCategoryType";
			this.Load += new System.EventHandler(this.FrmBookCategoryType_Load);
			this.Controls.SetChildIndex(this.LabelTitle, 0);
			this.Controls.SetChildIndex(this.labelBookType, 0);
			this.Controls.SetChildIndex(this.textBoxBookType, 0);
			this.Controls.SetChildIndex(this.buttonAdd, 0);
			this.Controls.SetChildIndex(this.buttonEdit, 0);
			this.Controls.SetChildIndex(this.buttonDelete, 0);
			this.Controls.SetChildIndex(this.buttonCancel, 0);
			this.Controls.SetChildIndex(this.buttonSave, 0);
			this.Controls.SetChildIndex(this.dataGridBookCategoryType, 0);
			((System.ComponentModel.ISupportInitialize)(this.dataGridBookCategoryType)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void FrmBookCategoryType_Load(object sender, System.EventArgs e)
		{
			MyBookType = new BookType();
			MyClassDatabase = new ClassDatabase();
			MyDataTable = MyClassDatabase.GetBookType();
			dataGridBookCategoryType.DataSource = MyDataTable;
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
			textBoxBookType.Text = "";
			MyBookType.PreviousBookTypeID = "";
			MyClassDatabase = new ClassDatabase();
			MyDataTable = MyClassDatabase.GetBookType();
			dataGridBookCategoryType.DataSource = MyDataTable;
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
		private void textBoxBookType_TextChanged(object sender, System.EventArgs e)
		{
			MyBookType.BookTypeID = textBoxBookType.Text.ToString();
		}
		private void buttonAdd_Click(object sender, System.EventArgs e)
		{
			DoUnlock();
			textBoxBookType.Focus();
		}

		private void buttonEdit_Click(object sender, System.EventArgs e)
		{
			DoUnlock();
			MyBookType.PreviousBookTypeID = dataGridBookCategoryType[dataGridBookCategoryType.CurrentRowIndex,0].ToString().Trim();
			textBoxBookType.Text = dataGridBookCategoryType[dataGridBookCategoryType.CurrentRowIndex,0].ToString().Trim();

		}

		private void buttonDelete_Click(object sender, System.EventArgs e)
		{
			DialogResult ans;
			ans = MessageBox.Show("Are you sure you want to delete BookType Data with BookType=' "+ dataGridBookCategoryType[dataGridBookCategoryType.CurrentRowIndex,0].ToString().Trim() + "' ?" , "Confirmation", MessageBoxButtons.YesNo );
			if (ans.ToString() == "Yes")
			{	
				MyClassDatabase = new ClassDatabase();
				MyClassDatabase.DeleteBookType(dataGridBookCategoryType[dataGridBookCategoryType.CurrentRowIndex,0].ToString().Trim());
			}
			DoLock();
		}

		private void buttonSave_Click(object sender, System.EventArgs e)
		{
			MyBookType.UpdateUser = MyMDIForm.LibrarianUserName.ToString();
			MyClassDatabase = new ClassDatabase();
			MyClassDatabase.SaveBookType(MyBookType);
			DoLock();
		}

		private void buttonCancel_Click(object sender, System.EventArgs e)
		{
			DoLock();
		}


	}
}

