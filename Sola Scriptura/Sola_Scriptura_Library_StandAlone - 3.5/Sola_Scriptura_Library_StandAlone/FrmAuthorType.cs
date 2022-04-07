using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace Sola_Scriptura_Library
{
	public class FrmAuthorType : Sola_Scriptura_Library.FrmAuthorMaster
	{
		internal System.Windows.Forms.Button buttonSave;
		internal System.Windows.Forms.Button buttonCancel;
		internal System.Windows.Forms.Button buttonDelete;
		internal System.Windows.Forms.Button buttonEdit;
		internal System.Windows.Forms.Button buttonAdd;
		internal System.Windows.Forms.Label labelAuthorType;
		internal System.Windows.Forms.DataGrid dataGridAuthorType;
		internal System.Windows.Forms.Label LabelTitle;
		internal System.Windows.Forms.TextBox textBoxAuthorType;
		internal System.Windows.Forms.DataGridTableStyle dataGridTableStyleAuthorType;
		private System.ComponentModel.IContainer components = null;

		internal AuthorType MyAuthorType;
		internal ClassDatabase MyClassDatabase;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnAuthorType;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnUpdateUser;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnUpdateDate;
		internal DataTable MyDataTable;

		public FrmAuthorType()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}

		public FrmAuthorType(FrmMDI MDIForm, FrmSetupMenu SetupMenuForm)
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmAuthorType));
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.textBoxAuthorType = new System.Windows.Forms.TextBox();
			this.labelAuthorType = new System.Windows.Forms.Label();
			this.dataGridAuthorType = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyleAuthorType = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnAuthorType = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnUpdateUser = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnUpdateDate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.LabelTitle = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridAuthorType)).BeginInit();
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
			// textBoxAuthorType
			// 
			this.textBoxAuthorType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxAuthorType.Location = new System.Drawing.Point(376, 480);
			this.textBoxAuthorType.Name = "textBoxAuthorType";
			this.textBoxAuthorType.Size = new System.Drawing.Size(544, 22);
			this.textBoxAuthorType.TabIndex = 1;
			this.textBoxAuthorType.Text = "";
			this.textBoxAuthorType.TextChanged += new System.EventHandler(this.textBoxAuthorType_TextChanged);
			// 
			// labelAuthorType
			// 
			this.labelAuthorType.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelAuthorType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelAuthorType.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelAuthorType.Location = new System.Drawing.Point(256, 480);
			this.labelAuthorType.Name = "labelAuthorType";
			this.labelAuthorType.Size = new System.Drawing.Size(120, 24);
			this.labelAuthorType.TabIndex = 171;
			this.labelAuthorType.Text = "Author Type";
			// 
			// dataGridAuthorType
			// 
			this.dataGridAuthorType.DataMember = "";
			this.dataGridAuthorType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGridAuthorType.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGridAuthorType.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridAuthorType.Location = new System.Drawing.Point(248, 72);
			this.dataGridAuthorType.Name = "dataGridAuthorType";
			this.dataGridAuthorType.ReadOnly = true;
			this.dataGridAuthorType.Size = new System.Drawing.Size(672, 392);
			this.dataGridAuthorType.TabIndex = 177;
			this.dataGridAuthorType.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																										   this.dataGridTableStyleAuthorType});
			// 
			// dataGridTableStyleAuthorType
			// 
			this.dataGridTableStyleAuthorType.AlternatingBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleAuthorType.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.dataGridTableStyleAuthorType.DataGrid = this.dataGridAuthorType;
			this.dataGridTableStyleAuthorType.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleAuthorType.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																														   this.dataGridTextBoxColumnAuthorType,
																														   this.dataGridTextBoxColumnUpdateUser,
																														   this.dataGridTextBoxColumnUpdateDate});
			this.dataGridTableStyleAuthorType.GridLineColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridTableStyleAuthorType.HeaderBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleAuthorType.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleAuthorType.MappingName = "AuthorType";
			// 
			// dataGridTextBoxColumnAuthorType
			// 
			this.dataGridTextBoxColumnAuthorType.Format = "";
			this.dataGridTextBoxColumnAuthorType.FormatInfo = null;
			this.dataGridTextBoxColumnAuthorType.HeaderText = "Author Type";
			this.dataGridTextBoxColumnAuthorType.MappingName = "AuthorType";
			this.dataGridTextBoxColumnAuthorType.Width = 250;
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
			this.LabelTitle.TabIndex = 178;
			this.LabelTitle.Text = "    Author Type";
			this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FrmAuthorType
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.LabelTitle);
			this.Controls.Add(this.dataGridAuthorType);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonEdit);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.textBoxAuthorType);
			this.Controls.Add(this.labelAuthorType);
			this.Name = "FrmAuthorType";
			this.Load += new System.EventHandler(this.FrmAuthorType_Load);
			this.Controls.SetChildIndex(this.labelAuthorType, 0);
			this.Controls.SetChildIndex(this.textBoxAuthorType, 0);
			this.Controls.SetChildIndex(this.buttonAdd, 0);
			this.Controls.SetChildIndex(this.buttonEdit, 0);
			this.Controls.SetChildIndex(this.buttonDelete, 0);
			this.Controls.SetChildIndex(this.buttonCancel, 0);
			this.Controls.SetChildIndex(this.buttonSave, 0);
			this.Controls.SetChildIndex(this.dataGridAuthorType, 0);
			this.Controls.SetChildIndex(this.LabelTitle, 0);
			((System.ComponentModel.ISupportInitialize)(this.dataGridAuthorType)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void FrmAuthorType_Load(object sender, System.EventArgs e)
		{
			MyAuthorType = new AuthorType();
			MyClassDatabase = new ClassDatabase();
			MyDataTable = MyClassDatabase.GetAuthorType();
			dataGridAuthorType.DataSource = MyDataTable;
			RefreshButton();
		}

		private void textBoxAuthorType_TextChanged(object sender, System.EventArgs e)
		{
			MyAuthorType.Type = textBoxAuthorType.Text.ToString();
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
			textBoxAuthorType.Text = "";
			MyAuthorType.PreviousType = "";
			MyClassDatabase = new ClassDatabase();
			MyDataTable = MyClassDatabase.GetAuthorType();
			dataGridAuthorType.DataSource = MyDataTable;
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
			DoUnlock();
			textBoxAuthorType.Focus();
		}

		private void buttonEdit_Click(object sender, System.EventArgs e)
		{
			DoUnlock();
			MyAuthorType.PreviousType = dataGridAuthorType[dataGridAuthorType.CurrentRowIndex,0].ToString().Trim();
			textBoxAuthorType.Text = dataGridAuthorType[dataGridAuthorType.CurrentRowIndex,0].ToString().Trim();
		}

		private void buttonDelete_Click(object sender, System.EventArgs e)
		{
			DialogResult ans;
			ans = MessageBox.Show("Are you sure you want to delete AuthorType Data with AuthorType=' "+ dataGridAuthorType[dataGridAuthorType.CurrentRowIndex,0].ToString().Trim() + "' ?" , "Confirmation", MessageBoxButtons.YesNo );
			if (ans.ToString() == "Yes")
			{	
				MyClassDatabase = new ClassDatabase();
				MyClassDatabase.DeleteAuthorType(dataGridAuthorType[dataGridAuthorType.CurrentRowIndex,0].ToString().Trim());
			}
			DoLock();
		}

		private void buttonSave_Click(object sender, System.EventArgs e)
		{
			MyAuthorType.UpdateUser = MyMDIForm.LibrarianUserName.ToString();
			MyClassDatabase = new ClassDatabase();
			MyClassDatabase.SaveAuthorType(MyAuthorType);
			DoLock();
		}

		private void buttonCancel_Click(object sender, System.EventArgs e)
		{
			DoLock();
		}
	}
}

