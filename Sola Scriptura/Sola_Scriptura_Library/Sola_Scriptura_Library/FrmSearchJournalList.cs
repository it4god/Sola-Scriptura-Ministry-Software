using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data; 
namespace Sola_Scriptura_Library
{
	public class FrmSearchJournalList : Sola_Scriptura_Library.FrmSearchJournalMaster
	{
		internal System.Windows.Forms.Label LabelTitle;
		internal System.Windows.Forms.DataGrid dataGridJournalList;
		private System.ComponentModel.IContainer components = null;
		internal System.Windows.Forms.ComboBox comboBoxLanguage;
		internal System.Windows.Forms.Label labelLanguage;
		internal System.Windows.Forms.DataGrid dataGridJournalDetail;
		internal System.Windows.Forms.Label labelInformation;
		internal System.Windows.Forms.TextBox textBoxJournalName;
		internal System.Windows.Forms.Label labelJournalName;

		internal ClassDatabase MyClassDatabase;
		internal DataTable MyDataTable;
		internal System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		internal System.Windows.Forms.DataGridTableStyle dataGridTableStyleJournalList;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnJournalID;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnJournalName;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnJournalLanguage;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnType;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnPublishYear;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnMonthSeason;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnNumber;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnVolume;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnJournalName2;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnJournalDetailID;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnCallNo2;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnCallNo;
		internal DataTable MyDataTable2;
		public FrmSearchJournalList()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public FrmSearchJournalList(FrmMDI MDIForm)
		{
			InitializeComponent();
			base.MyMDIForm = MDIForm;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmSearchJournalList));
			this.LabelTitle = new System.Windows.Forms.Label();
			this.dataGridJournalList = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyleJournalList = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnJournalID = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnJournalName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnJournalLanguage = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnType = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridJournalDetail = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnJournalDetailID = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnPublishYear = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnMonthSeason = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnVolume = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnNumber = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnCallNo = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnCallNo2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnJournalName2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
			this.labelLanguage = new System.Windows.Forms.Label();
			this.labelInformation = new System.Windows.Forms.Label();
			this.textBoxJournalName = new System.Windows.Forms.TextBox();
			this.labelJournalName = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridJournalList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridJournalDetail)).BeginInit();
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
			this.LabelTitle.TabIndex = 186;
			this.LabelTitle.Text = "    Journal List";
			this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dataGridJournalList
			// 
			this.dataGridJournalList.DataMember = "";
			this.dataGridJournalList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGridJournalList.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridJournalList.Location = new System.Drawing.Point(248, 104);
			this.dataGridJournalList.Name = "dataGridJournalList";
			this.dataGridJournalList.ParentRowsBackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.dataGridJournalList.ReadOnly = true;
			this.dataGridJournalList.Size = new System.Drawing.Size(672, 232);
			this.dataGridJournalList.TabIndex = 185;
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
																															this.dataGridTextBoxColumnJournalLanguage,
																															this.dataGridTextBoxColumnType});
			this.dataGridTableStyleJournalList.GridLineColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridTableStyleJournalList.HeaderBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleJournalList.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleJournalList.MappingName = "JournalList";
			// 
			// dataGridTextBoxColumnJournalID
			// 
			this.dataGridTextBoxColumnJournalID.Format = "";
			this.dataGridTextBoxColumnJournalID.FormatInfo = null;
			this.dataGridTextBoxColumnJournalID.HeaderText = "Journal ID";
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
			// dataGridTextBoxColumnJournalLanguage
			// 
			this.dataGridTextBoxColumnJournalLanguage.Format = "";
			this.dataGridTextBoxColumnJournalLanguage.FormatInfo = null;
			this.dataGridTextBoxColumnJournalLanguage.HeaderText = "Language";
			this.dataGridTextBoxColumnJournalLanguage.MappingName = "JournalLanguage";
			this.dataGridTextBoxColumnJournalLanguage.Width = 75;
			// 
			// dataGridTextBoxColumnType
			// 
			this.dataGridTextBoxColumnType.Format = "";
			this.dataGridTextBoxColumnType.FormatInfo = null;
			this.dataGridTextBoxColumnType.HeaderText = "Type";
			this.dataGridTextBoxColumnType.MappingName = "JournalType";
			this.dataGridTextBoxColumnType.Width = 75;
			// 
			// dataGridJournalDetail
			// 
			this.dataGridJournalDetail.DataMember = "";
			this.dataGridJournalDetail.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridJournalDetail.Location = new System.Drawing.Point(248, 376);
			this.dataGridJournalDetail.Name = "dataGridJournalDetail";
			this.dataGridJournalDetail.ParentRowsBackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.dataGridJournalDetail.ReadOnly = true;
			this.dataGridJournalDetail.Size = new System.Drawing.Size(672, 176);
			this.dataGridJournalDetail.TabIndex = 189;
			this.dataGridJournalDetail.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																											  this.dataGridTableStyle1});
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyle1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.dataGridTableStyle1.DataGrid = this.dataGridJournalDetail;
			this.dataGridTableStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.dataGridTextBoxColumnJournalDetailID,
																												  this.dataGridTextBoxColumnPublishYear,
																												  this.dataGridTextBoxColumnMonthSeason,
																												  this.dataGridTextBoxColumnVolume,
																												  this.dataGridTextBoxColumnNumber,
																												  this.dataGridTextBoxColumnCallNo,
																												  this.dataGridTextBoxColumnCallNo2,
																												  this.dataGridTextBoxColumnJournalName2});
			this.dataGridTableStyle1.GridLineColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridTableStyle1.HeaderBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyle1.MappingName = "JournalDetail";
			// 
			// dataGridTextBoxColumnJournalDetailID
			// 
			this.dataGridTextBoxColumnJournalDetailID.Format = "";
			this.dataGridTextBoxColumnJournalDetailID.FormatInfo = null;
			this.dataGridTextBoxColumnJournalDetailID.MappingName = "JournalDetailID";
			this.dataGridTextBoxColumnJournalDetailID.Width = 0;
			// 
			// dataGridTextBoxColumnPublishYear
			// 
			this.dataGridTextBoxColumnPublishYear.Format = "";
			this.dataGridTextBoxColumnPublishYear.FormatInfo = null;
			this.dataGridTextBoxColumnPublishYear.HeaderText = "PublishYear";
			this.dataGridTextBoxColumnPublishYear.MappingName = "PublishYear";
			this.dataGridTextBoxColumnPublishYear.Width = 75;
			// 
			// dataGridTextBoxColumnMonthSeason
			// 
			this.dataGridTextBoxColumnMonthSeason.Format = "";
			this.dataGridTextBoxColumnMonthSeason.FormatInfo = null;
			this.dataGridTextBoxColumnMonthSeason.HeaderText = "Month / Season";
			this.dataGridTextBoxColumnMonthSeason.MappingName = "MonthSeason";
			this.dataGridTextBoxColumnMonthSeason.Width = 170;
			// 
			// dataGridTextBoxColumnVolume
			// 
			this.dataGridTextBoxColumnVolume.Format = "";
			this.dataGridTextBoxColumnVolume.FormatInfo = null;
			this.dataGridTextBoxColumnVolume.HeaderText = "Volume";
			this.dataGridTextBoxColumnVolume.MappingName = "Volume";
			this.dataGridTextBoxColumnVolume.Width = 75;
			// 
			// dataGridTextBoxColumnNumber
			// 
			this.dataGridTextBoxColumnNumber.Format = "";
			this.dataGridTextBoxColumnNumber.FormatInfo = null;
			this.dataGridTextBoxColumnNumber.HeaderText = "Number";
			this.dataGridTextBoxColumnNumber.MappingName = "Number";
			this.dataGridTextBoxColumnNumber.Width = 75;
			// 
			// dataGridTextBoxColumnCallNo
			// 
			this.dataGridTextBoxColumnCallNo.Format = "";
			this.dataGridTextBoxColumnCallNo.FormatInfo = null;
			this.dataGridTextBoxColumnCallNo.HeaderText = "Call No";
			this.dataGridTextBoxColumnCallNo.MappingName = "CallNo";
			this.dataGridTextBoxColumnCallNo.Width = 90;
			// 
			// dataGridTextBoxColumnCallNo2
			// 
			this.dataGridTextBoxColumnCallNo2.Format = "";
			this.dataGridTextBoxColumnCallNo2.FormatInfo = null;
			this.dataGridTextBoxColumnCallNo2.HeaderText = "Call No 2";
			this.dataGridTextBoxColumnCallNo2.MappingName = "CallNo2";
			this.dataGridTextBoxColumnCallNo2.Width = 90;
			// 
			// dataGridTextBoxColumnJournalName2
			// 
			this.dataGridTextBoxColumnJournalName2.Format = "";
			this.dataGridTextBoxColumnJournalName2.FormatInfo = null;
			this.dataGridTextBoxColumnJournalName2.HeaderText = "Journal Name";
			this.dataGridTextBoxColumnJournalName2.MappingName = "JournalName";
			this.dataGridTextBoxColumnJournalName2.Width = 300;
			// 
			// comboBoxLanguage
			// 
			this.comboBoxLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.comboBoxLanguage.Items.AddRange(new object[] {
																  "All",
																  "English",
																  "Indonesian"});
			this.comboBoxLanguage.Location = new System.Drawing.Point(744, 72);
			this.comboBoxLanguage.Name = "comboBoxLanguage";
			this.comboBoxLanguage.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.comboBoxLanguage.Size = new System.Drawing.Size(176, 24);
			this.comboBoxLanguage.TabIndex = 187;
			this.comboBoxLanguage.Text = "All";
			this.comboBoxLanguage.SelectedIndexChanged += new System.EventHandler(this.comboBoxLanguage_SelectedIndexChanged);
			// 
			// labelLanguage
			// 
			this.labelLanguage.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelLanguage.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelLanguage.Location = new System.Drawing.Point(664, 72);
			this.labelLanguage.Name = "labelLanguage";
			this.labelLanguage.Size = new System.Drawing.Size(120, 24);
			this.labelLanguage.TabIndex = 188;
			this.labelLanguage.Text = "Language";
			// 
			// labelInformation
			// 
			this.labelInformation.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelInformation.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelInformation.ForeColor = System.Drawing.Color.LightCoral;
			this.labelInformation.Location = new System.Drawing.Point(248, 72);
			this.labelInformation.Name = "labelInformation";
			this.labelInformation.Size = new System.Drawing.Size(400, 24);
			this.labelInformation.TabIndex = 192;
			this.labelInformation.Text = "Please click Journal in the DataGrid to show the journal\'s season !";
			// 
			// textBoxJournalName
			// 
			this.textBoxJournalName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxJournalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxJournalName.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxJournalName.Location = new System.Drawing.Point(384, 344);
			this.textBoxJournalName.Name = "textBoxJournalName";
			this.textBoxJournalName.Size = new System.Drawing.Size(536, 22);
			this.textBoxJournalName.TabIndex = 203;
			this.textBoxJournalName.Text = "";
			// 
			// labelJournalName
			// 
			this.labelJournalName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelJournalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelJournalName.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelJournalName.Location = new System.Drawing.Point(256, 344);
			this.labelJournalName.Name = "labelJournalName";
			this.labelJournalName.Size = new System.Drawing.Size(120, 24);
			this.labelJournalName.TabIndex = 204;
			this.labelJournalName.Text = "Journal Name";
			// 
			// FrmSearchJournalList
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.textBoxJournalName);
			this.Controls.Add(this.labelJournalName);
			this.Controls.Add(this.labelInformation);
			this.Controls.Add(this.dataGridJournalDetail);
			this.Controls.Add(this.comboBoxLanguage);
			this.Controls.Add(this.labelLanguage);
			this.Controls.Add(this.LabelTitle);
			this.Controls.Add(this.dataGridJournalList);
			this.Name = "FrmSearchJournalList";
			this.Load += new System.EventHandler(this.FrmSearchJournalList_Load);
			this.Controls.SetChildIndex(this.dataGridJournalList, 0);
			this.Controls.SetChildIndex(this.LabelTitle, 0);
			this.Controls.SetChildIndex(this.labelLanguage, 0);
			this.Controls.SetChildIndex(this.comboBoxLanguage, 0);
			this.Controls.SetChildIndex(this.dataGridJournalDetail, 0);
			this.Controls.SetChildIndex(this.labelInformation, 0);
			this.Controls.SetChildIndex(this.labelJournalName, 0);
			this.Controls.SetChildIndex(this.textBoxJournalName, 0);
			((System.ComponentModel.ISupportInitialize)(this.dataGridJournalList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridJournalDetail)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void FrmSearchJournalList_Load(object sender, System.EventArgs e)
		{
			MyClassDatabase = new ClassDatabase();
			MyDataTable = MyClassDatabase.GetJournalList("All","");
			dataGridJournalList.DataSource = MyDataTable;
		}

		private void comboBoxLanguage_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			MyClassDatabase = new ClassDatabase();
			MyDataTable = MyClassDatabase.GetJournalList(comboBoxLanguage.Text.ToString(),"");
			dataGridJournalList.DataSource = MyDataTable;
		}

		private void dataGridJournalList_Click(object sender, System.EventArgs e)
		{
			if(MyDataTable.Rows.Count>0)
			{
				textBoxJournalName.Text = "";
			}
		}
		private void dataGridJournalList_DoubleClick(object sender, System.EventArgs e)
		{
			
			if(MyDataTable.Rows.Count>0)
			{
				textBoxJournalName.Text = dataGridJournalList[dataGridJournalList.CurrentRowIndex,1].ToString();
				MyClassDatabase = new ClassDatabase();
				MyDataTable2 = MyClassDatabase.GetJournalDetail(dataGridJournalList[dataGridJournalList.CurrentRowIndex,0].ToString().Trim());
				dataGridJournalDetail.DataSource = MyDataTable2;
			}	
		}
	}
}

