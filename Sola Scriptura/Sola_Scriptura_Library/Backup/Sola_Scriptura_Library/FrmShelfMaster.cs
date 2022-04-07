using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace Sola_Scriptura_Library
{
	public class FrmShelfMaster : Sola_Scriptura_Library.FrmShelfLocationMaster
	{
		internal System.Windows.Forms.Label LabelTitle;
		internal System.Windows.Forms.Label labelDescription;
		internal System.Windows.Forms.TextBox textBoxDescription;
		internal System.Windows.Forms.TextBox textBoxShelfCode;
		internal System.Windows.Forms.Label labelShelfCode;
		internal System.Windows.Forms.Label labelLocation;
		internal System.Windows.Forms.Button buttonSave;
		internal System.Windows.Forms.Button buttonCancel;
		internal System.Windows.Forms.Button buttonDelete;
		internal System.Windows.Forms.Button buttonEdit;
		internal System.Windows.Forms.Button buttonAdd;
		internal System.Windows.Forms.DataGrid dataGridShelf;
		internal System.Windows.Forms.DataGridTableStyle dataGridTableStyleShelf;
		internal System.Windows.Forms.ComboBox comboBoxLocationCode;
		private System.ComponentModel.IContainer components = null;


		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnShelfCode;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnDescription;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnLocationCode;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnLocation;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnUpdateUser;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnUpdateDate;
		
		internal ClassDatabase MyClassDatabase;
		internal DataTable MyDataTable;
		internal BookShelf MyBookShelf;
		internal DataTable MyDataTable2;

		public FrmShelfMaster()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public FrmShelfMaster(FrmMDI MDIForm, FrmSetupMenu SetupMenuForm)
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmShelfMaster));
			this.LabelTitle = new System.Windows.Forms.Label();
			this.labelDescription = new System.Windows.Forms.Label();
			this.textBoxDescription = new System.Windows.Forms.TextBox();
			this.textBoxShelfCode = new System.Windows.Forms.TextBox();
			this.labelShelfCode = new System.Windows.Forms.Label();
			this.labelLocation = new System.Windows.Forms.Label();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.dataGridShelf = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyleShelf = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnShelfCode = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnDescription = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnLocationCode = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnLocation = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnUpdateUser = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnUpdateDate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.comboBoxLocationCode = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridShelf)).BeginInit();
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
			this.LabelTitle.TabIndex = 135;
			this.LabelTitle.Text = "    Shelf Master";
			this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelDescription
			// 
			this.labelDescription.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelDescription.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelDescription.Location = new System.Drawing.Point(256, 480);
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Size = new System.Drawing.Size(120, 24);
			this.labelDescription.TabIndex = 185;
			this.labelDescription.Text = "Description";
			// 
			// textBoxDescription
			// 
			this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxDescription.Location = new System.Drawing.Point(384, 480);
			this.textBoxDescription.Name = "textBoxDescription";
			this.textBoxDescription.Size = new System.Drawing.Size(536, 22);
			this.textBoxDescription.TabIndex = 3;
			this.textBoxDescription.Text = "";
			this.textBoxDescription.TextChanged += new System.EventHandler(this.textBoxDescription_TextChanged);
			// 
			// textBoxShelfCode
			// 
			this.textBoxShelfCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxShelfCode.Location = new System.Drawing.Point(384, 448);
			this.textBoxShelfCode.Name = "textBoxShelfCode";
			this.textBoxShelfCode.Size = new System.Drawing.Size(200, 22);
			this.textBoxShelfCode.TabIndex = 1;
			this.textBoxShelfCode.Text = "";
			this.textBoxShelfCode.TextChanged += new System.EventHandler(this.textBoxShelfCode_TextChanged);
			// 
			// labelShelfCode
			// 
			this.labelShelfCode.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelShelfCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelShelfCode.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelShelfCode.Location = new System.Drawing.Point(256, 448);
			this.labelShelfCode.Name = "labelShelfCode";
			this.labelShelfCode.Size = new System.Drawing.Size(120, 24);
			this.labelShelfCode.TabIndex = 184;
			this.labelShelfCode.Text = "Shelf Code";
			// 
			// labelLocation
			// 
			this.labelLocation.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelLocation.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelLocation.Location = new System.Drawing.Point(600, 448);
			this.labelLocation.Name = "labelLocation";
			this.labelLocation.Size = new System.Drawing.Size(120, 24);
			this.labelLocation.TabIndex = 183;
			this.labelLocation.Text = "Location Code";
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
			// dataGridShelf
			// 
			this.dataGridShelf.DataMember = "";
			this.dataGridShelf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGridShelf.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridShelf.Location = new System.Drawing.Point(248, 72);
			this.dataGridShelf.Name = "dataGridShelf";
			this.dataGridShelf.ReadOnly = true;
			this.dataGridShelf.Size = new System.Drawing.Size(672, 360);
			this.dataGridShelf.TabIndex = 182;
			this.dataGridShelf.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																									  this.dataGridTableStyleShelf});
			// 
			// dataGridTableStyleShelf
			// 
			this.dataGridTableStyleShelf.AlternatingBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleShelf.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.dataGridTableStyleShelf.DataGrid = this.dataGridShelf;
			this.dataGridTableStyleShelf.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleShelf.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																													  this.dataGridTextBoxColumnShelfCode,
																													  this.dataGridTextBoxColumnDescription,
																													  this.dataGridTextBoxColumnLocationCode,
																													  this.dataGridTextBoxColumnLocation,
																													  this.dataGridTextBoxColumnUpdateUser,
																													  this.dataGridTextBoxColumnUpdateDate});
			this.dataGridTableStyleShelf.GridLineColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridTableStyleShelf.HeaderBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleShelf.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleShelf.MappingName = "ShelfList";
			// 
			// dataGridTextBoxColumnShelfCode
			// 
			this.dataGridTextBoxColumnShelfCode.Format = "";
			this.dataGridTextBoxColumnShelfCode.FormatInfo = null;
			this.dataGridTextBoxColumnShelfCode.HeaderText = "Shelf Code";
			this.dataGridTextBoxColumnShelfCode.MappingName = "ShelfCode";
			this.dataGridTextBoxColumnShelfCode.Width = 75;
			// 
			// dataGridTextBoxColumnDescription
			// 
			this.dataGridTextBoxColumnDescription.Format = "";
			this.dataGridTextBoxColumnDescription.FormatInfo = null;
			this.dataGridTextBoxColumnDescription.HeaderText = "Description ";
			this.dataGridTextBoxColumnDescription.MappingName = "ShelfDesc";
			this.dataGridTextBoxColumnDescription.Width = 250;
			// 
			// dataGridTextBoxColumnLocationCode
			// 
			this.dataGridTextBoxColumnLocationCode.Format = "";
			this.dataGridTextBoxColumnLocationCode.FormatInfo = null;
			this.dataGridTextBoxColumnLocationCode.MappingName = "LocationCode";
			this.dataGridTextBoxColumnLocationCode.Width = 0;
			// 
			// dataGridTextBoxColumnLocation
			// 
			this.dataGridTextBoxColumnLocation.Format = "";
			this.dataGridTextBoxColumnLocation.FormatInfo = null;
			this.dataGridTextBoxColumnLocation.HeaderText = "Location";
			this.dataGridTextBoxColumnLocation.MappingName = "LocationName";
			this.dataGridTextBoxColumnLocation.Width = 200;
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
			// comboBoxLocationCode
			// 
			this.comboBoxLocationCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.comboBoxLocationCode.Location = new System.Drawing.Point(720, 448);
			this.comboBoxLocationCode.Name = "comboBoxLocationCode";
			this.comboBoxLocationCode.Size = new System.Drawing.Size(200, 24);
			this.comboBoxLocationCode.TabIndex = 2;
			this.comboBoxLocationCode.SelectedIndexChanged += new System.EventHandler(this.comboBoxLocationCode_SelectedIndexChanged);
			// 
			// FrmShelfMaster
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.comboBoxLocationCode);
			this.Controls.Add(this.labelDescription);
			this.Controls.Add(this.textBoxDescription);
			this.Controls.Add(this.textBoxShelfCode);
			this.Controls.Add(this.labelShelfCode);
			this.Controls.Add(this.labelLocation);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonEdit);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.dataGridShelf);
			this.Controls.Add(this.LabelTitle);
			this.Name = "FrmShelfMaster";
			this.Load += new System.EventHandler(this.FrmShelfMaster_Load);
			this.Controls.SetChildIndex(this.LabelTitle, 0);
			this.Controls.SetChildIndex(this.dataGridShelf, 0);
			this.Controls.SetChildIndex(this.buttonAdd, 0);
			this.Controls.SetChildIndex(this.buttonEdit, 0);
			this.Controls.SetChildIndex(this.buttonDelete, 0);
			this.Controls.SetChildIndex(this.buttonCancel, 0);
			this.Controls.SetChildIndex(this.buttonSave, 0);
			this.Controls.SetChildIndex(this.labelLocation, 0);
			this.Controls.SetChildIndex(this.labelShelfCode, 0);
			this.Controls.SetChildIndex(this.textBoxShelfCode, 0);
			this.Controls.SetChildIndex(this.textBoxDescription, 0);
			this.Controls.SetChildIndex(this.labelDescription, 0);
			this.Controls.SetChildIndex(this.comboBoxLocationCode, 0);
			((System.ComponentModel.ISupportInitialize)(this.dataGridShelf)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void FrmShelfMaster_Load(object sender, System.EventArgs e)
		{
			MyBookShelf = new BookShelf();
			MyClassDatabase = new ClassDatabase();
			MyDataTable = MyClassDatabase.GetShelfList();
			dataGridShelf.DataSource = MyDataTable;
			MyDataTable2 = MyClassDatabase.GetLocationCode();
			comboBoxLocationCode.DataSource = MyDataTable2;
			comboBoxLocationCode.DisplayMember = "LocationCode";
			RefreshButton();
		}

		private void textBoxShelfCode_TextChanged(object sender, System.EventArgs e)
		{
			MyBookShelf.ShelfCode = textBoxShelfCode.Text.ToString();
		}

		private void comboBoxLocationCode_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			MyBookShelf.LocationCode = comboBoxLocationCode.Text.ToString();
		}

		private void textBoxDescription_TextChanged(object sender, System.EventArgs e)
		{
			MyBookShelf.ShelfDesc = textBoxDescription.Text.ToString();
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
			textBoxShelfCode.Text = "";
			comboBoxLocationCode.SelectedIndex = -1;
			textBoxDescription.Text = "";
			MyClassDatabase = new ClassDatabase();
			MyDataTable = MyClassDatabase.GetShelfList();
			dataGridShelf.DataSource = MyDataTable;
			MyDataTable2 = MyClassDatabase.GetLocationCode();
			comboBoxLocationCode.DataSource = MyDataTable2;
			comboBoxLocationCode.DisplayMember = "LocationCode";
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
			textBoxShelfCode.Focus();
		}

		private void buttonEdit_Click(object sender, System.EventArgs e)
		{
			DoUnlock();
			textBoxShelfCode.Text = dataGridShelf[dataGridShelf.CurrentRowIndex,0].ToString().Trim();
			comboBoxLocationCode.SelectedIndex = -1;
			comboBoxLocationCode.SelectedIndex = comboBoxLocationCode.FindString(dataGridShelf[dataGridShelf.CurrentRowIndex,2].ToString().Trim());
			textBoxDescription.Text = dataGridShelf[dataGridShelf.CurrentRowIndex,1].ToString().Trim();
		}

		private void buttonDelete_Click(object sender, System.EventArgs e)
		{
			DialogResult ans;
			ans = MessageBox.Show("Are you sure you want to delete Shelf Data with LocationCode=' "+ dataGridShelf[dataGridShelf.CurrentRowIndex,0].ToString().Trim() + "' ?" , "Confirmation", MessageBoxButtons.YesNo );
			if (ans.ToString() == "Yes")
			{	
				MyClassDatabase = new ClassDatabase();
				MyClassDatabase.DeleteShelf(dataGridShelf[dataGridShelf.CurrentRowIndex,0].ToString().Trim());
			}
			DoLock();
		}

		private void buttonSave_Click(object sender, System.EventArgs e)
		{
			MyBookShelf.UpdateUser = MyMDIForm.LibrarianUserName.ToString();
			MyClassDatabase = new ClassDatabase();
			MyClassDatabase.SaveShelf(MyBookShelf);
			DoLock();
		}

		private void buttonCancel_Click(object sender, System.EventArgs e)
		{
			DoLock();
		}
	}
}

