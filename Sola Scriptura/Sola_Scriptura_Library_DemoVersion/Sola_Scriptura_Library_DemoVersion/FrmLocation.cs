using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace Sola_Scriptura_Library
{
	public class FrmLocation : Sola_Scriptura_Library.FrmShelfLocationMaster
	{
		internal System.Windows.Forms.Label LabelTitle;
		internal System.Windows.Forms.Button buttonSave;
		internal System.Windows.Forms.Button buttonCancel;
		internal System.Windows.Forms.Button buttonDelete;
		internal System.Windows.Forms.Button buttonEdit;
		internal System.Windows.Forms.Button buttonAdd;
		internal System.Windows.Forms.TextBox textBoxLocationCode;
		internal System.Windows.Forms.Label labelLocationCode;
		internal System.Windows.Forms.TextBox textBoxLocationName;
		internal System.Windows.Forms.Label labelLocationName;
		internal System.Windows.Forms.DataGrid dataGridLocation;
		internal System.Windows.Forms.DataGridTableStyle dataGridTableStyleLocation;
		private System.ComponentModel.IContainer components = null;

		internal ClassDatabase MyClassDatabase;
		internal DataTable MyDataTable;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnLocationCode;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnLocationName;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnUpdateUser;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnUpdateDate;
		internal Location MyLocation;

		public FrmLocation()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public FrmLocation(FrmMDI MDIForm, FrmSetupMenu SetupMenuForm)
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmLocation));
			this.LabelTitle = new System.Windows.Forms.Label();
			this.dataGridLocation = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyleLocation = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnLocationCode = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnLocationName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnUpdateUser = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnUpdateDate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.textBoxLocationCode = new System.Windows.Forms.TextBox();
			this.labelLocationCode = new System.Windows.Forms.Label();
			this.textBoxLocationName = new System.Windows.Forms.TextBox();
			this.labelLocationName = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridLocation)).BeginInit();
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
			this.LabelTitle.TabIndex = 136;
			this.LabelTitle.Text = "    Location";
			this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dataGridLocation
			// 
			this.dataGridLocation.DataMember = "";
			this.dataGridLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGridLocation.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridLocation.Location = new System.Drawing.Point(248, 72);
			this.dataGridLocation.Name = "dataGridLocation";
			this.dataGridLocation.ReadOnly = true;
			this.dataGridLocation.Size = new System.Drawing.Size(672, 392);
			this.dataGridLocation.TabIndex = 193;
			this.dataGridLocation.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																										 this.dataGridTableStyleLocation});
			// 
			// dataGridTableStyleLocation
			// 
			this.dataGridTableStyleLocation.AlternatingBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleLocation.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.dataGridTableStyleLocation.DataGrid = this.dataGridLocation;
			this.dataGridTableStyleLocation.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleLocation.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																														 this.dataGridTextBoxColumnLocationCode,
																														 this.dataGridTextBoxColumnLocationName,
																														 this.dataGridTextBoxColumnUpdateUser,
																														 this.dataGridTextBoxColumnUpdateDate});
			this.dataGridTableStyleLocation.GridLineColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridTableStyleLocation.HeaderBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleLocation.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleLocation.MappingName = "LocationList";
			// 
			// dataGridTextBoxColumnLocationCode
			// 
			this.dataGridTextBoxColumnLocationCode.Format = "";
			this.dataGridTextBoxColumnLocationCode.FormatInfo = null;
			this.dataGridTextBoxColumnLocationCode.HeaderText = "Location Code";
			this.dataGridTextBoxColumnLocationCode.MappingName = "LocationCode";
			this.dataGridTextBoxColumnLocationCode.Width = 75;
			// 
			// dataGridTextBoxColumnLocationName
			// 
			this.dataGridTextBoxColumnLocationName.Format = "";
			this.dataGridTextBoxColumnLocationName.FormatInfo = null;
			this.dataGridTextBoxColumnLocationName.HeaderText = "Location Name";
			this.dataGridTextBoxColumnLocationName.MappingName = "LocationName";
			this.dataGridTextBoxColumnLocationName.Width = 200;
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
			// textBoxLocationCode
			// 
			this.textBoxLocationCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxLocationCode.Location = new System.Drawing.Point(384, 480);
			this.textBoxLocationCode.Name = "textBoxLocationCode";
			this.textBoxLocationCode.Size = new System.Drawing.Size(200, 22);
			this.textBoxLocationCode.TabIndex = 1;
			this.textBoxLocationCode.Text = "";
			this.textBoxLocationCode.TextChanged += new System.EventHandler(this.textBoxLocationCode_TextChanged);
			// 
			// labelLocationCode
			// 
			this.labelLocationCode.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelLocationCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelLocationCode.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelLocationCode.Location = new System.Drawing.Point(256, 480);
			this.labelLocationCode.Name = "labelLocationCode";
			this.labelLocationCode.Size = new System.Drawing.Size(120, 24);
			this.labelLocationCode.TabIndex = 197;
			this.labelLocationCode.Text = "Location Code";
			// 
			// textBoxLocationName
			// 
			this.textBoxLocationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxLocationName.Location = new System.Drawing.Point(720, 480);
			this.textBoxLocationName.Name = "textBoxLocationName";
			this.textBoxLocationName.Size = new System.Drawing.Size(200, 22);
			this.textBoxLocationName.TabIndex = 2;
			this.textBoxLocationName.Text = "";
			this.textBoxLocationName.TextChanged += new System.EventHandler(this.textBoxLocationName_TextChanged);
			// 
			// labelLocationName
			// 
			this.labelLocationName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelLocationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelLocationName.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelLocationName.Location = new System.Drawing.Point(600, 480);
			this.labelLocationName.Name = "labelLocationName";
			this.labelLocationName.Size = new System.Drawing.Size(120, 24);
			this.labelLocationName.TabIndex = 196;
			this.labelLocationName.Text = "Location Name";
			// 
			// FrmLocation
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.textBoxLocationCode);
			this.Controls.Add(this.labelLocationCode);
			this.Controls.Add(this.textBoxLocationName);
			this.Controls.Add(this.labelLocationName);
			this.Controls.Add(this.dataGridLocation);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonEdit);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.LabelTitle);
			this.Name = "FrmLocation";
			this.Load += new System.EventHandler(this.FrmLocation_Load);
			this.Controls.SetChildIndex(this.LabelTitle, 0);
			this.Controls.SetChildIndex(this.buttonAdd, 0);
			this.Controls.SetChildIndex(this.buttonEdit, 0);
			this.Controls.SetChildIndex(this.buttonDelete, 0);
			this.Controls.SetChildIndex(this.buttonCancel, 0);
			this.Controls.SetChildIndex(this.buttonSave, 0);
			this.Controls.SetChildIndex(this.dataGridLocation, 0);
			this.Controls.SetChildIndex(this.labelLocationName, 0);
			this.Controls.SetChildIndex(this.textBoxLocationName, 0);
			this.Controls.SetChildIndex(this.labelLocationCode, 0);
			this.Controls.SetChildIndex(this.textBoxLocationCode, 0);
			((System.ComponentModel.ISupportInitialize)(this.dataGridLocation)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void FrmLocation_Load(object sender, System.EventArgs e)
		{
			MyLocation = new Location();
			MyClassDatabase = new ClassDatabase();
			MyDataTable = MyClassDatabase.GetLocationList();
			dataGridLocation.DataSource = MyDataTable;
			RefreshButton();
		}

		private void textBoxLocationCode_TextChanged(object sender, System.EventArgs e)
		{
			MyLocation.LocationCode = textBoxLocationCode.Text.ToString();
		}

		private void textBoxLocationName_TextChanged(object sender, System.EventArgs e)
		{
			MyLocation.LocationName = textBoxLocationName.Text.ToString();
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
			textBoxLocationCode.Text = "";
			textBoxLocationName.Text = "";
			MyClassDatabase = new ClassDatabase();
			MyDataTable = MyClassDatabase.GetLocationList();
			dataGridLocation.DataSource = MyDataTable;
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
			textBoxLocationCode.Focus();
		}

		private void buttonEdit_Click(object sender, System.EventArgs e)
		{
			DoUnlock();
			textBoxLocationCode.Text = dataGridLocation[dataGridLocation.CurrentRowIndex,0].ToString().Trim();
			textBoxLocationName.Text = dataGridLocation[dataGridLocation.CurrentRowIndex,1].ToString().Trim();
		}

		private void buttonDelete_Click(object sender, System.EventArgs e)
		{
			DialogResult ans;
			ans = MessageBox.Show("Are you sure you want to delete Location Data with LocationCode=' "+ dataGridLocation[dataGridLocation.CurrentRowIndex,0].ToString().Trim() + "' ?" , "Confirmation", MessageBoxButtons.YesNo );
			if (ans.ToString() == "Yes")
			{	
				MyClassDatabase = new ClassDatabase();
				MyClassDatabase.DeleteLocation (dataGridLocation[dataGridLocation.CurrentRowIndex,0].ToString().Trim());
			}
			DoLock();
		}

		private void buttonSave_Click(object sender, System.EventArgs e)
		{
			MyLocation.UpdateUser = MyMDIForm.LibrarianUserName.ToString();
			MyClassDatabase = new ClassDatabase();
			MyClassDatabase.SaveLocation(MyLocation);
			DoLock();
		}

		private void buttonCancel_Click(object sender, System.EventArgs e)
		{
			DoLock();
		}
	}
}

