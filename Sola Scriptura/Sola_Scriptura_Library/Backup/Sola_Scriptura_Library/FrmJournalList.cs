using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
namespace Sola_Scriptura_Library
{
	public class FrmJournalList : Sola_Scriptura_Library.FrmJournalMaster
	{
		internal System.Windows.Forms.Label LabelTitle;
		internal System.Windows.Forms.DataGrid dataGridJournalList;
		internal System.Windows.Forms.Label labelInformation;
		internal System.Windows.Forms.DataGridTableStyle dataGridTableStyleJournalList;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnJournalID;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnJournalName;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnLanguage;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnType;
		private System.ComponentModel.IContainer components = null;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnUpdateUser;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnUpdateDate;

		internal ClassDatabase MyClassDatabase;
		internal System.Windows.Forms.TextBox textBoxSearch;
		internal System.Windows.Forms.Label labelCity;
		internal DataTable MyDataTable;
		public FrmJournalList()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public FrmJournalList(FrmMDI MDIForm, FrmBookMenu BookMenuForm)
		{
			InitializeComponent();
			base.MyMDIForm = MDIForm;
			base.MyBookMenuForm = BookMenuForm;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmJournalList));
			this.LabelTitle = new System.Windows.Forms.Label();
			this.dataGridJournalList = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyleJournalList = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnJournalID = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnJournalName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnLanguage = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnType = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnUpdateUser = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnUpdateDate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.labelInformation = new System.Windows.Forms.Label();
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.labelCity = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridJournalList)).BeginInit();
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
			this.LabelTitle.TabIndex = 188;
			this.LabelTitle.Text = "    Journal List";
			this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dataGridJournalList
			// 
			this.dataGridJournalList.DataMember = "";
			this.dataGridJournalList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGridJournalList.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridJournalList.Location = new System.Drawing.Point(248, 144);
			this.dataGridJournalList.Name = "dataGridJournalList";
			this.dataGridJournalList.ParentRowsBackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.dataGridJournalList.ReadOnly = true;
			this.dataGridJournalList.Size = new System.Drawing.Size(672, 408);
			this.dataGridJournalList.TabIndex = 187;
			this.dataGridJournalList.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																											this.dataGridTableStyleJournalList});
			this.dataGridJournalList.Click += new System.EventHandler(this.dataGridJournalList_Click);
			this.dataGridJournalList.DoubleClick += new System.EventHandler(this.dataGridJournalList_DoubleClick);
			// 
			// dataGridTableStyleJournalList
			// 
			this.dataGridTableStyleJournalList.AlternatingBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleJournalList.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.dataGridTableStyleJournalList.DataGrid = this.dataGridJournalList;
			this.dataGridTableStyleJournalList.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleJournalList.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																															this.dataGridTextBoxColumnJournalID,
																															this.dataGridTextBoxColumnJournalName,
																															this.dataGridTextBoxColumnLanguage,
																															this.dataGridTextBoxColumnType,
																															this.dataGridTextBoxColumnUpdateUser,
																															this.dataGridTextBoxColumnUpdateDate});
			this.dataGridTableStyleJournalList.GridLineColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridTableStyleJournalList.HeaderBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleJournalList.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleJournalList.MappingName = "JournalList";
			// 
			// dataGridTextBoxColumnJournalID
			// 
			this.dataGridTextBoxColumnJournalID.Format = "";
			this.dataGridTextBoxColumnJournalID.FormatInfo = null;
			this.dataGridTextBoxColumnJournalID.HeaderText = "JournalID";
			this.dataGridTextBoxColumnJournalID.MappingName = "JournalID";
			this.dataGridTextBoxColumnJournalID.Width = 75;
			// 
			// dataGridTextBoxColumnJournalName
			// 
			this.dataGridTextBoxColumnJournalName.Format = "";
			this.dataGridTextBoxColumnJournalName.FormatInfo = null;
			this.dataGridTextBoxColumnJournalName.HeaderText = "Journal Name";
			this.dataGridTextBoxColumnJournalName.MappingName = "JournalName";
			this.dataGridTextBoxColumnJournalName.Width = 300;
			// 
			// dataGridTextBoxColumnLanguage
			// 
			this.dataGridTextBoxColumnLanguage.Format = "";
			this.dataGridTextBoxColumnLanguage.FormatInfo = null;
			this.dataGridTextBoxColumnLanguage.HeaderText = "Language";
			this.dataGridTextBoxColumnLanguage.MappingName = "JournalLanguage";
			this.dataGridTextBoxColumnLanguage.Width = 75;
			// 
			// dataGridTextBoxColumnType
			// 
			this.dataGridTextBoxColumnType.Format = "";
			this.dataGridTextBoxColumnType.FormatInfo = null;
			this.dataGridTextBoxColumnType.HeaderText = "Journal Type";
			this.dataGridTextBoxColumnType.MappingName = "JournalType";
			this.dataGridTextBoxColumnType.Width = 75;
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
			// labelInformation
			// 
			this.labelInformation.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelInformation.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelInformation.ForeColor = System.Drawing.Color.LightCoral;
			this.labelInformation.Location = new System.Drawing.Point(248, 120);
			this.labelInformation.Name = "labelInformation";
			this.labelInformation.Size = new System.Drawing.Size(456, 24);
			this.labelInformation.TabIndex = 189;
			this.labelInformation.Text = "Please click Journal in the DataGrid to show the journal\'s information !";
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxSearch.Location = new System.Drawing.Point(360, 80);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(280, 22);
			this.textBoxSearch.TabIndex = 190;
			this.textBoxSearch.Text = "";
			this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
			// 
			// labelCity
			// 
			this.labelCity.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelCity.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelCity.Location = new System.Drawing.Point(256, 80);
			this.labelCity.Name = "labelCity";
			this.labelCity.Size = new System.Drawing.Size(120, 24);
			this.labelCity.TabIndex = 191;
			this.labelCity.Text = "Text to Find   :";
			// 
			// FrmJournalList
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.textBoxSearch);
			this.Controls.Add(this.labelCity);
			this.Controls.Add(this.labelInformation);
			this.Controls.Add(this.LabelTitle);
			this.Controls.Add(this.dataGridJournalList);
			this.Name = "FrmJournalList";
			this.Load += new System.EventHandler(this.FrmJournalList_Load);
			this.Controls.SetChildIndex(this.dataGridJournalList, 0);
			this.Controls.SetChildIndex(this.LabelTitle, 0);
			this.Controls.SetChildIndex(this.labelInformation, 0);
			this.Controls.SetChildIndex(this.labelCity, 0);
			this.Controls.SetChildIndex(this.textBoxSearch, 0);
			((System.ComponentModel.ISupportInitialize)(this.dataGridJournalList)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void FrmJournalList_Load(object sender, System.EventArgs e)
		{
			MyClassDatabase = new ClassDatabase();
			MyDataTable = MyClassDatabase.GetJournalList("All",textBoxSearch.Text.ToString());
			dataGridJournalList.DataSource = MyDataTable; 
		}
		public void DoRefresh()
		{
			MyClassDatabase = new ClassDatabase();
			MyDataTable = MyClassDatabase.GetJournalList("All",textBoxSearch.Text.ToString());
			dataGridJournalList.DataSource = MyDataTable; 
		}

		private void dataGridJournalList_Click(object sender, System.EventArgs e)
		{
			if(MyDataTable.Rows.Count>0)
			{
				
			}
		}
		private void dataGridJournalList_DoubleClick(object sender, System.EventArgs e)
		{
			
			if(MyDataTable.Rows.Count>0)
			{
				MyMDIForm.MyJournal.JournalID = dataGridJournalList[dataGridJournalList.CurrentRowIndex,0].ToString().Trim();
				MyMDIForm.MyJournal.JournalName = dataGridJournalList[dataGridJournalList.CurrentRowIndex,1].ToString().Trim();
				MyMDIForm.MyJournal.JournalLanguage = dataGridJournalList[dataGridJournalList.CurrentRowIndex,2].ToString().Trim();
				MyMDIForm.MyJournal.JournalType = dataGridJournalList[dataGridJournalList.CurrentRowIndex,3].ToString().Trim();
				MyMDIForm.MyBookMenuForm.MyJournalMasterForm = new FrmJournalMasterDetail (this.MyMDIForm,this.MyBookMenuForm);				
				MyMDIForm.MyBookMenuForm.MyJournalMasterForm.Show();
				MyMDIForm.MyBookMenuForm.MyJournalMasterForm.textBoxJournalID.Text = MyMDIForm.MyJournal.JournalID.ToString();
				MyMDIForm.MyBookMenuForm.MyJournalMasterForm.textBoxJournalName.Text = MyMDIForm.MyJournal.JournalName.ToString();
				MyMDIForm.MyBookMenuForm.MyJournalMasterForm.comboBoxLanguage.Text = "";
				MyMDIForm.MyBookMenuForm.MyJournalMasterForm.comboBoxJournalType.Text = "";
				if(MyMDIForm.MyJournal.JournalLanguage=="E")
					MyMDIForm.MyBookMenuForm.MyJournalMasterForm.comboBoxLanguage.Text = "English";
				else if(MyMDIForm.MyJournal.JournalLanguage =="I")
					MyMDIForm.MyBookMenuForm.MyJournalMasterForm.comboBoxLanguage.Text = "Indonesian";
				else
					MyMDIForm.MyBookMenuForm.MyJournalMasterForm.comboBoxLanguage.Text = "";
				MyMDIForm.MyBookMenuForm.MyJournalMasterForm.comboBoxJournalType.Text = MyMDIForm.MyJournal.JournalType.ToString();
				MyMDIForm.MyBookMenuForm.MyJournalMasterForm.CanDelete = true;
				MyMDIForm.MyBookMenuForm.MyJournalMasterForm.DoLock();
				this.Hide();
			}
		}

		private void textBoxSearch_TextChanged(object sender, System.EventArgs e)
		{
			DoRefresh();
		}
	

	}
}

