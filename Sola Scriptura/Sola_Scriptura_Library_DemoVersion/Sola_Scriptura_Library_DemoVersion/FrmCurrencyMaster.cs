using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace Sola_Scriptura_Library
{
	public class FrmCurrencyMaster : Sola_Scriptura_Library.FrmFormParent
	{
		internal System.Windows.Forms.Label LabelTitle;
		internal System.Windows.Forms.Label labelCurrency;
		internal System.Windows.Forms.TextBox textBoxCurrency;
		internal System.Windows.Forms.TextBox textBoxCurrencyName;
		internal System.Windows.Forms.Label labelCurrencyName;
		internal System.Windows.Forms.TextBox textBoxCurrencyRate;
		internal System.Windows.Forms.Label labelCurrencyRate;
		internal System.Windows.Forms.Button buttonSave;
		internal System.Windows.Forms.Button buttonCancel;
		internal System.Windows.Forms.Button buttonDelete;
		internal System.Windows.Forms.Button buttonEdit;
		internal System.Windows.Forms.Button buttonAdd;
		internal System.Windows.Forms.DataGrid dataGridCurrencyMaster;
		internal System.Windows.Forms.DataGridTableStyle dataGridTableStyleCurrencyMaster;
		private System.ComponentModel.IContainer components = null;

		internal ClassDatabase MyClassDatabase;
		internal DataTable MyDataTable;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnCurr;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnCurrName;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnCurrRate;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnUpdateUser;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnUpdateDate;
		internal System.Windows.Forms.PictureBox pictureBoxLogoPicture;
		internal Currency MyCurrency;

		public FrmCurrencyMaster()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public FrmCurrencyMaster(FrmMDI MDIForm)
		{
			base.MyMDIForm = MDIForm;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmCurrencyMaster));
			this.LabelTitle = new System.Windows.Forms.Label();
			this.labelCurrency = new System.Windows.Forms.Label();
			this.textBoxCurrency = new System.Windows.Forms.TextBox();
			this.textBoxCurrencyName = new System.Windows.Forms.TextBox();
			this.labelCurrencyName = new System.Windows.Forms.Label();
			this.textBoxCurrencyRate = new System.Windows.Forms.TextBox();
			this.labelCurrencyRate = new System.Windows.Forms.Label();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.dataGridCurrencyMaster = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyleCurrencyMaster = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnCurr = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnCurrName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnCurrRate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnUpdateUser = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnUpdateDate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.pictureBoxLogoPicture = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridCurrencyMaster)).BeginInit();
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
			this.LabelTitle.TabIndex = 115;
			this.LabelTitle.Text = "    Currency Master";
			this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelCurrency
			// 
			this.labelCurrency.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelCurrency.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelCurrency.Location = new System.Drawing.Point(256, 448);
			this.labelCurrency.Name = "labelCurrency";
			this.labelCurrency.Size = new System.Drawing.Size(120, 24);
			this.labelCurrency.TabIndex = 185;
			this.labelCurrency.Text = "Currency";
			// 
			// textBoxCurrency
			// 
			this.textBoxCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxCurrency.Location = new System.Drawing.Point(384, 448);
			this.textBoxCurrency.Name = "textBoxCurrency";
			this.textBoxCurrency.Size = new System.Drawing.Size(200, 22);
			this.textBoxCurrency.TabIndex = 1;
			this.textBoxCurrency.Text = "";
			this.textBoxCurrency.TextChanged += new System.EventHandler(this.textBoxCurrency_TextChanged);
			// 
			// textBoxCurrencyName
			// 
			this.textBoxCurrencyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxCurrencyName.Location = new System.Drawing.Point(384, 480);
			this.textBoxCurrencyName.Name = "textBoxCurrencyName";
			this.textBoxCurrencyName.Size = new System.Drawing.Size(200, 22);
			this.textBoxCurrencyName.TabIndex = 2;
			this.textBoxCurrencyName.Text = "";
			this.textBoxCurrencyName.TextChanged += new System.EventHandler(this.textBoxCurrencyName_TextChanged);
			// 
			// labelCurrencyName
			// 
			this.labelCurrencyName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelCurrencyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelCurrencyName.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelCurrencyName.Location = new System.Drawing.Point(256, 480);
			this.labelCurrencyName.Name = "labelCurrencyName";
			this.labelCurrencyName.Size = new System.Drawing.Size(120, 24);
			this.labelCurrencyName.TabIndex = 184;
			this.labelCurrencyName.Text = "Currency Name";
			// 
			// textBoxCurrencyRate
			// 
			this.textBoxCurrencyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxCurrencyRate.Location = new System.Drawing.Point(720, 480);
			this.textBoxCurrencyRate.Name = "textBoxCurrencyRate";
			this.textBoxCurrencyRate.Size = new System.Drawing.Size(200, 22);
			this.textBoxCurrencyRate.TabIndex = 3;
			this.textBoxCurrencyRate.Text = "";
			this.textBoxCurrencyRate.TextChanged += new System.EventHandler(this.textBoxCurrencyRate_TextChanged);
			// 
			// labelCurrencyRate
			// 
			this.labelCurrencyRate.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelCurrencyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelCurrencyRate.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelCurrencyRate.Location = new System.Drawing.Point(600, 480);
			this.labelCurrencyRate.Name = "labelCurrencyRate";
			this.labelCurrencyRate.Size = new System.Drawing.Size(120, 24);
			this.labelCurrencyRate.TabIndex = 183;
			this.labelCurrencyRate.Text = "Currency Rate";
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
			// dataGridCurrencyMaster
			// 
			this.dataGridCurrencyMaster.DataMember = "";
			this.dataGridCurrencyMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGridCurrencyMaster.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridCurrencyMaster.Location = new System.Drawing.Point(248, 72);
			this.dataGridCurrencyMaster.Name = "dataGridCurrencyMaster";
			this.dataGridCurrencyMaster.ReadOnly = true;
			this.dataGridCurrencyMaster.Size = new System.Drawing.Size(672, 360);
			this.dataGridCurrencyMaster.TabIndex = 182;
			this.dataGridCurrencyMaster.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																											   this.dataGridTableStyleCurrencyMaster});
			// 
			// dataGridTableStyleCurrencyMaster
			// 
			this.dataGridTableStyleCurrencyMaster.AlternatingBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleCurrencyMaster.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.dataGridTableStyleCurrencyMaster.DataGrid = this.dataGridCurrencyMaster;
			this.dataGridTableStyleCurrencyMaster.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleCurrencyMaster.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																															   this.dataGridTextBoxColumnCurr,
																															   this.dataGridTextBoxColumnCurrName,
																															   this.dataGridTextBoxColumnCurrRate,
																															   this.dataGridTextBoxColumnUpdateUser,
																															   this.dataGridTextBoxColumnUpdateDate});
			this.dataGridTableStyleCurrencyMaster.GridLineColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridTableStyleCurrencyMaster.HeaderBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleCurrencyMaster.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleCurrencyMaster.MappingName = "CurrencyList";
			// 
			// dataGridTextBoxColumnCurr
			// 
			this.dataGridTextBoxColumnCurr.Format = "";
			this.dataGridTextBoxColumnCurr.FormatInfo = null;
			this.dataGridTextBoxColumnCurr.HeaderText = "Curr";
			this.dataGridTextBoxColumnCurr.MappingName = "Curr";
			this.dataGridTextBoxColumnCurr.Width = 75;
			// 
			// dataGridTextBoxColumnCurrName
			// 
			this.dataGridTextBoxColumnCurrName.Format = "";
			this.dataGridTextBoxColumnCurrName.FormatInfo = null;
			this.dataGridTextBoxColumnCurrName.HeaderText = "Curr Name";
			this.dataGridTextBoxColumnCurrName.MappingName = "CurrName";
			this.dataGridTextBoxColumnCurrName.Width = 270;
			// 
			// dataGridTextBoxColumnCurrRate
			// 
			this.dataGridTextBoxColumnCurrRate.Format = "";
			this.dataGridTextBoxColumnCurrRate.FormatInfo = null;
			this.dataGridTextBoxColumnCurrRate.HeaderText = "Curr Rate";
			this.dataGridTextBoxColumnCurrRate.MappingName = "CurrRate";
			this.dataGridTextBoxColumnCurrRate.Width = 150;
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
			// dataGridTextBoxColumn1
			// 
			this.dataGridTextBoxColumn1.Format = "";
			this.dataGridTextBoxColumn1.FormatInfo = null;
			this.dataGridTextBoxColumn1.HeaderText = "Update User";
			this.dataGridTextBoxColumn1.MappingName = "UpdateUser";
			this.dataGridTextBoxColumn1.Width = 75;
			// 
			// pictureBoxLogoPicture
			// 
			this.pictureBoxLogoPicture.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogoPicture.Image")));
			this.pictureBoxLogoPicture.Location = new System.Drawing.Point(32, 464);
			this.pictureBoxLogoPicture.Name = "pictureBoxLogoPicture";
			this.pictureBoxLogoPicture.Size = new System.Drawing.Size(144, 88);
			this.pictureBoxLogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxLogoPicture.TabIndex = 186;
			this.pictureBoxLogoPicture.TabStop = false;
			// 
			// FrmCurrencyMaster
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.pictureBoxLogoPicture);
			this.Controls.Add(this.labelCurrency);
			this.Controls.Add(this.textBoxCurrency);
			this.Controls.Add(this.textBoxCurrencyName);
			this.Controls.Add(this.labelCurrencyName);
			this.Controls.Add(this.textBoxCurrencyRate);
			this.Controls.Add(this.labelCurrencyRate);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonEdit);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.dataGridCurrencyMaster);
			this.Controls.Add(this.LabelTitle);
			this.Name = "FrmCurrencyMaster";
			this.Load += new System.EventHandler(this.FrmCurrencyMaster_Load);
			this.Controls.SetChildIndex(this.LabelTitle, 0);
			this.Controls.SetChildIndex(this.dataGridCurrencyMaster, 0);
			this.Controls.SetChildIndex(this.buttonAdd, 0);
			this.Controls.SetChildIndex(this.buttonEdit, 0);
			this.Controls.SetChildIndex(this.buttonDelete, 0);
			this.Controls.SetChildIndex(this.buttonCancel, 0);
			this.Controls.SetChildIndex(this.buttonSave, 0);
			this.Controls.SetChildIndex(this.labelCurrencyRate, 0);
			this.Controls.SetChildIndex(this.textBoxCurrencyRate, 0);
			this.Controls.SetChildIndex(this.labelCurrencyName, 0);
			this.Controls.SetChildIndex(this.textBoxCurrencyName, 0);
			this.Controls.SetChildIndex(this.textBoxCurrency, 0);
			this.Controls.SetChildIndex(this.labelCurrency, 0);
			this.Controls.SetChildIndex(this.pictureBoxLogoPicture, 0);
			((System.ComponentModel.ISupportInitialize)(this.dataGridCurrencyMaster)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void FrmCurrencyMaster_Load(object sender, System.EventArgs e)
		{
			MyCurrency = new Currency();
			MyClassDatabase = new ClassDatabase();
			MyDataTable = MyClassDatabase.GetCurrencyList();
			dataGridCurrencyMaster.DataSource = MyDataTable;
			RefreshButton();
		}

		private void textBoxCurrency_TextChanged(object sender, System.EventArgs e)
		{
			MyCurrency.Curr = textBoxCurrency.Text.ToString();
		}

		private void textBoxCurrencyName_TextChanged(object sender, System.EventArgs e)
		{
			MyCurrency.CurrName = textBoxCurrencyName.Text.ToString();
		}

		private void textBoxCurrencyRate_TextChanged(object sender, System.EventArgs e)
		{
			MyCurrency.CurrRate = textBoxCurrencyRate.Text.ToString();
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
			textBoxCurrency.Text = "";
			textBoxCurrencyName.Text = "";
			textBoxCurrencyRate.Text = "";
			MyClassDatabase = new ClassDatabase();
			MyDataTable = MyClassDatabase.GetCurrencyList();
			dataGridCurrencyMaster.DataSource = MyDataTable;
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
			textBoxCurrency.Focus();
		}

		private void buttonEdit_Click(object sender, System.EventArgs e)
		{
			DoUnlock();
			textBoxCurrency.Text = dataGridCurrencyMaster[dataGridCurrencyMaster.CurrentRowIndex,0].ToString().Trim();
			textBoxCurrencyName.Text = dataGridCurrencyMaster[dataGridCurrencyMaster.CurrentRowIndex,1].ToString().Trim();
			textBoxCurrencyRate.Text = dataGridCurrencyMaster[dataGridCurrencyMaster.CurrentRowIndex,2].ToString().Trim();
		}

		private void buttonDelete_Click(object sender, System.EventArgs e)
		{
			DialogResult ans;
			ans = MessageBox.Show("Are you sure you want to delete Currency Data with Currency=' "+ dataGridCurrencyMaster[dataGridCurrencyMaster.CurrentRowIndex,0].ToString().Trim() + "' ?" , "Confirmation", MessageBoxButtons.YesNo );
			if (ans.ToString() == "Yes")
			{	
				MyClassDatabase = new ClassDatabase();
				MyClassDatabase.DeleteCurrency(dataGridCurrencyMaster[dataGridCurrencyMaster.CurrentRowIndex,0].ToString().Trim());
			}
			DoLock();
		}

		private void buttonSave_Click(object sender, System.EventArgs e)
		{
			if(IsNumeric(MyCurrency.CurrRate.ToString()))
			{
				MyCurrency.UpdateUser = MyMDIForm.LibrarianUserName.ToString();
				MyClassDatabase = new ClassDatabase();
				MyClassDatabase.SaveCurrency(MyCurrency);
				DoLock();
			}
			else
			{
				MessageBox.Show("Please Enter the Value value in currency Rate", "Requirement");
			}
		}
		private void buttonCancel_Click(object sender, System.EventArgs e)
		{
			DoLock();
		}
		static bool IsNumeric(string Expression)
		{
			bool isNum;
			double retNum;
			isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum );
			return isNum;
		}
	}

}

