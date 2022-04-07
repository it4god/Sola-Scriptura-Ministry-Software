using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace Sola_Scriptura_Library
{
	public class FrmJournalDetail : Sola_Scriptura_Library.FrmJournalMaster
	{
		internal System.Windows.Forms.Label labelType;
		internal System.Windows.Forms.Button buttonSave;
		internal System.Windows.Forms.Button buttonCancel;
		internal System.Windows.Forms.Button buttonDelete;
		internal System.Windows.Forms.Button buttonEdit;
		internal System.Windows.Forms.Button buttonAdd;
		internal System.Windows.Forms.Label labelLanguage;
		internal System.Windows.Forms.TextBox textBoxJournalName;
		internal System.Windows.Forms.Label labelJournalName;
		internal System.Windows.Forms.TextBox textBoxJournalID;
		internal System.Windows.Forms.Label labelJournalID;
		internal System.Windows.Forms.Label LabelTitle;
		internal System.Windows.Forms.TextBox textBoxLanguage;
		internal System.Windows.Forms.TextBox textBoxJournalType;
		internal System.Windows.Forms.TextBox textBoxJournalDetailID;
		internal System.Windows.Forms.Label labelJournalDetailID;
		internal System.Windows.Forms.TextBox textBoxVolume;
		internal System.Windows.Forms.Label labelVolume;
		internal System.Windows.Forms.TextBox textBoxNumber;
		internal System.Windows.Forms.Label labelNumber;
		internal System.Windows.Forms.TextBox textBoxMonthSeason;
		internal System.Windows.Forms.Label labelMonthSeason;
		internal System.Windows.Forms.TextBox textBoxPublishYear;
		internal System.Windows.Forms.Label labelPublishYear;
		internal System.Windows.Forms.TextBox textBoxCallNo2;
		internal System.Windows.Forms.Label labelCallNo2;
		internal System.Windows.Forms.TextBox textBoxCallNo;
		internal System.Windows.Forms.Label labelCallNo;
		internal System.Windows.Forms.DataGrid dataGridJournalDetail;
		private System.ComponentModel.IContainer components = null;
		
		internal ClassDatabase MyClassDatabase;
		internal DataTable MyDataTable;
		internal bool CanDelete;
		internal string StatusAction;
		
		internal System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnJournalDetailID;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnPublishYear;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnMonthSeason;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnVolume;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnNumber;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnCallNo;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnCallNo2;
		internal System.Windows.Forms.Label labelInformation;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnUpdateUser;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnUpdateDate;
		internal Journal MyJournal;

		public FrmJournalDetail()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public FrmJournalDetail(FrmMDI MDIForm, FrmBookMenu BookMenuForm)
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmJournalDetail));
			this.labelType = new System.Windows.Forms.Label();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.labelLanguage = new System.Windows.Forms.Label();
			this.textBoxJournalName = new System.Windows.Forms.TextBox();
			this.labelJournalName = new System.Windows.Forms.Label();
			this.textBoxJournalID = new System.Windows.Forms.TextBox();
			this.labelJournalID = new System.Windows.Forms.Label();
			this.LabelTitle = new System.Windows.Forms.Label();
			this.textBoxLanguage = new System.Windows.Forms.TextBox();
			this.textBoxJournalType = new System.Windows.Forms.TextBox();
			this.dataGridJournalDetail = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnJournalDetailID = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnPublishYear = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnMonthSeason = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnVolume = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnNumber = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnCallNo = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnCallNo2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnUpdateUser = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnUpdateDate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.textBoxJournalDetailID = new System.Windows.Forms.TextBox();
			this.labelJournalDetailID = new System.Windows.Forms.Label();
			this.textBoxVolume = new System.Windows.Forms.TextBox();
			this.labelVolume = new System.Windows.Forms.Label();
			this.textBoxNumber = new System.Windows.Forms.TextBox();
			this.labelNumber = new System.Windows.Forms.Label();
			this.textBoxMonthSeason = new System.Windows.Forms.TextBox();
			this.labelMonthSeason = new System.Windows.Forms.Label();
			this.textBoxPublishYear = new System.Windows.Forms.TextBox();
			this.labelPublishYear = new System.Windows.Forms.Label();
			this.textBoxCallNo2 = new System.Windows.Forms.TextBox();
			this.labelCallNo2 = new System.Windows.Forms.Label();
			this.textBoxCallNo = new System.Windows.Forms.TextBox();
			this.labelCallNo = new System.Windows.Forms.Label();
			this.labelInformation = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridJournalDetail)).BeginInit();
			this.SuspendLayout();
			// 
			// labelType
			// 
			this.labelType.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelType.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelType.Location = new System.Drawing.Point(600, 144);
			this.labelType.Name = "labelType";
			this.labelType.Size = new System.Drawing.Size(120, 24);
			this.labelType.TabIndex = 204;
			this.labelType.Text = "Journal Type";
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
			this.buttonSave.TabIndex = 10;
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
			this.buttonCancel.TabIndex = 11;
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
			this.buttonDelete.TabIndex = 9;
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
			this.buttonEdit.TabIndex = 8;
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
			this.buttonAdd.TabIndex = 7;
			this.buttonAdd.Text = "Add New";
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// labelLanguage
			// 
			this.labelLanguage.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelLanguage.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelLanguage.Location = new System.Drawing.Point(256, 144);
			this.labelLanguage.Name = "labelLanguage";
			this.labelLanguage.Size = new System.Drawing.Size(120, 24);
			this.labelLanguage.TabIndex = 203;
			this.labelLanguage.Text = "Language";
			// 
			// textBoxJournalName
			// 
			this.textBoxJournalName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxJournalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxJournalName.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxJournalName.Location = new System.Drawing.Point(384, 112);
			this.textBoxJournalName.Name = "textBoxJournalName";
			this.textBoxJournalName.Size = new System.Drawing.Size(536, 22);
			this.textBoxJournalName.TabIndex = 195;
			this.textBoxJournalName.Text = "";
			// 
			// labelJournalName
			// 
			this.labelJournalName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelJournalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelJournalName.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelJournalName.Location = new System.Drawing.Point(256, 112);
			this.labelJournalName.Name = "labelJournalName";
			this.labelJournalName.Size = new System.Drawing.Size(120, 24);
			this.labelJournalName.TabIndex = 202;
			this.labelJournalName.Text = "Journal Name";
			// 
			// textBoxJournalID
			// 
			this.textBoxJournalID.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxJournalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxJournalID.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxJournalID.Location = new System.Drawing.Point(384, 80);
			this.textBoxJournalID.Name = "textBoxJournalID";
			this.textBoxJournalID.Size = new System.Drawing.Size(200, 22);
			this.textBoxJournalID.TabIndex = 194;
			this.textBoxJournalID.Text = "";
			// 
			// labelJournalID
			// 
			this.labelJournalID.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelJournalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelJournalID.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelJournalID.Location = new System.Drawing.Point(256, 80);
			this.labelJournalID.Name = "labelJournalID";
			this.labelJournalID.Size = new System.Drawing.Size(120, 24);
			this.labelJournalID.TabIndex = 201;
			this.labelJournalID.Text = "Journal ID";
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
			this.LabelTitle.TabIndex = 205;
			this.LabelTitle.Text = "    Journal Detail";
			this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBoxLanguage
			// 
			this.textBoxLanguage.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxLanguage.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxLanguage.Location = new System.Drawing.Point(384, 144);
			this.textBoxLanguage.Name = "textBoxLanguage";
			this.textBoxLanguage.Size = new System.Drawing.Size(200, 22);
			this.textBoxLanguage.TabIndex = 206;
			this.textBoxLanguage.Text = "";
			// 
			// textBoxJournalType
			// 
			this.textBoxJournalType.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxJournalType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxJournalType.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxJournalType.Location = new System.Drawing.Point(720, 144);
			this.textBoxJournalType.Name = "textBoxJournalType";
			this.textBoxJournalType.Size = new System.Drawing.Size(200, 22);
			this.textBoxJournalType.TabIndex = 207;
			this.textBoxJournalType.Text = "";
			// 
			// dataGridJournalDetail
			// 
			this.dataGridJournalDetail.DataMember = "";
			this.dataGridJournalDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGridJournalDetail.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridJournalDetail.Location = new System.Drawing.Point(248, 200);
			this.dataGridJournalDetail.Name = "dataGridJournalDetail";
			this.dataGridJournalDetail.ReadOnly = true;
			this.dataGridJournalDetail.Size = new System.Drawing.Size(672, 216);
			this.dataGridJournalDetail.TabIndex = 208;
			this.dataGridJournalDetail.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																											  this.dataGridTableStyle1});
			this.dataGridJournalDetail.Click += new System.EventHandler(this.dataGridJournalDetail_Click);
			this.dataGridJournalDetail.DoubleClick += new System.EventHandler(this.dataGridJournalDetail_DoubleClick);
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
																												  this.dataGridTextBoxColumnUpdateUser,
																												  this.dataGridTextBoxColumnUpdateDate});
			this.dataGridTableStyle1.GridLineColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridTableStyle1.HeaderBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyle1.MappingName = "JournalDetail";
			// 
			// dataGridTextBoxColumnJournalDetailID
			// 
			this.dataGridTextBoxColumnJournalDetailID.Format = "";
			this.dataGridTextBoxColumnJournalDetailID.FormatInfo = null;
			this.dataGridTextBoxColumnJournalDetailID.HeaderText = "JournalDetailID";
			this.dataGridTextBoxColumnJournalDetailID.MappingName = "JournalDetailID";
			this.dataGridTextBoxColumnJournalDetailID.Width = 75;
			// 
			// dataGridTextBoxColumnPublishYear
			// 
			this.dataGridTextBoxColumnPublishYear.Format = "";
			this.dataGridTextBoxColumnPublishYear.FormatInfo = null;
			this.dataGridTextBoxColumnPublishYear.HeaderText = "Publish Year";
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
			// textBoxJournalDetailID
			// 
			this.textBoxJournalDetailID.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxJournalDetailID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxJournalDetailID.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxJournalDetailID.Location = new System.Drawing.Point(720, 80);
			this.textBoxJournalDetailID.Name = "textBoxJournalDetailID";
			this.textBoxJournalDetailID.Size = new System.Drawing.Size(200, 22);
			this.textBoxJournalDetailID.TabIndex = 210;
			this.textBoxJournalDetailID.Text = "";
			this.textBoxJournalDetailID.TextChanged += new System.EventHandler(this.textBoxJournalDetailID_TextChanged);
			// 
			// labelJournalDetailID
			// 
			this.labelJournalDetailID.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelJournalDetailID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelJournalDetailID.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelJournalDetailID.Location = new System.Drawing.Point(600, 80);
			this.labelJournalDetailID.Name = "labelJournalDetailID";
			this.labelJournalDetailID.Size = new System.Drawing.Size(120, 24);
			this.labelJournalDetailID.TabIndex = 211;
			this.labelJournalDetailID.Text = "JournalDetailID";
			// 
			// textBoxVolume
			// 
			this.textBoxVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxVolume.Location = new System.Drawing.Point(384, 424);
			this.textBoxVolume.Name = "textBoxVolume";
			this.textBoxVolume.Size = new System.Drawing.Size(200, 22);
			this.textBoxVolume.TabIndex = 1;
			this.textBoxVolume.Text = "";
			this.textBoxVolume.TextChanged += new System.EventHandler(this.textBoxVolume_TextChanged);
			// 
			// labelVolume
			// 
			this.labelVolume.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelVolume.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelVolume.Location = new System.Drawing.Point(256, 424);
			this.labelVolume.Name = "labelVolume";
			this.labelVolume.Size = new System.Drawing.Size(120, 24);
			this.labelVolume.TabIndex = 214;
			this.labelVolume.Text = "Volume";
			// 
			// textBoxNumber
			// 
			this.textBoxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxNumber.Location = new System.Drawing.Point(720, 424);
			this.textBoxNumber.Name = "textBoxNumber";
			this.textBoxNumber.Size = new System.Drawing.Size(200, 22);
			this.textBoxNumber.TabIndex = 2;
			this.textBoxNumber.Text = "";
			this.textBoxNumber.TextChanged += new System.EventHandler(this.textBoxNumber_TextChanged);
			// 
			// labelNumber
			// 
			this.labelNumber.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelNumber.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelNumber.Location = new System.Drawing.Point(592, 424);
			this.labelNumber.Name = "labelNumber";
			this.labelNumber.Size = new System.Drawing.Size(120, 24);
			this.labelNumber.TabIndex = 216;
			this.labelNumber.Text = "Number";
			// 
			// textBoxMonthSeason
			// 
			this.textBoxMonthSeason.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxMonthSeason.Location = new System.Drawing.Point(720, 456);
			this.textBoxMonthSeason.Name = "textBoxMonthSeason";
			this.textBoxMonthSeason.Size = new System.Drawing.Size(200, 22);
			this.textBoxMonthSeason.TabIndex = 4;
			this.textBoxMonthSeason.Text = "";
			this.textBoxMonthSeason.TextChanged += new System.EventHandler(this.textBoxMonthSeason_TextChanged);
			// 
			// labelMonthSeason
			// 
			this.labelMonthSeason.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelMonthSeason.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelMonthSeason.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelMonthSeason.Location = new System.Drawing.Point(592, 456);
			this.labelMonthSeason.Name = "labelMonthSeason";
			this.labelMonthSeason.Size = new System.Drawing.Size(120, 24);
			this.labelMonthSeason.TabIndex = 220;
			this.labelMonthSeason.Text = "Month / Season";
			// 
			// textBoxPublishYear
			// 
			this.textBoxPublishYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxPublishYear.Location = new System.Drawing.Point(384, 456);
			this.textBoxPublishYear.Name = "textBoxPublishYear";
			this.textBoxPublishYear.Size = new System.Drawing.Size(200, 22);
			this.textBoxPublishYear.TabIndex = 3;
			this.textBoxPublishYear.Text = "";
			this.textBoxPublishYear.TextChanged += new System.EventHandler(this.textBoxPublishYear_TextChanged);
			// 
			// labelPublishYear
			// 
			this.labelPublishYear.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelPublishYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelPublishYear.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelPublishYear.Location = new System.Drawing.Point(256, 456);
			this.labelPublishYear.Name = "labelPublishYear";
			this.labelPublishYear.Size = new System.Drawing.Size(120, 24);
			this.labelPublishYear.TabIndex = 218;
			this.labelPublishYear.Text = "Publish Year";
			// 
			// textBoxCallNo2
			// 
			this.textBoxCallNo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxCallNo2.Location = new System.Drawing.Point(720, 488);
			this.textBoxCallNo2.Name = "textBoxCallNo2";
			this.textBoxCallNo2.Size = new System.Drawing.Size(200, 22);
			this.textBoxCallNo2.TabIndex = 6;
			this.textBoxCallNo2.Text = "";
			this.textBoxCallNo2.TextChanged += new System.EventHandler(this.textBoxCallNo2_TextChanged);
			// 
			// labelCallNo2
			// 
			this.labelCallNo2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelCallNo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelCallNo2.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelCallNo2.Location = new System.Drawing.Point(592, 488);
			this.labelCallNo2.Name = "labelCallNo2";
			this.labelCallNo2.Size = new System.Drawing.Size(120, 24);
			this.labelCallNo2.TabIndex = 224;
			this.labelCallNo2.Text = "Call No 2";
			// 
			// textBoxCallNo
			// 
			this.textBoxCallNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxCallNo.Location = new System.Drawing.Point(384, 488);
			this.textBoxCallNo.Name = "textBoxCallNo";
			this.textBoxCallNo.Size = new System.Drawing.Size(200, 22);
			this.textBoxCallNo.TabIndex = 5;
			this.textBoxCallNo.Text = "";
			this.textBoxCallNo.TextChanged += new System.EventHandler(this.textBoxCallNo_TextChanged);
			// 
			// labelCallNo
			// 
			this.labelCallNo.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelCallNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelCallNo.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelCallNo.Location = new System.Drawing.Point(256, 488);
			this.labelCallNo.Name = "labelCallNo";
			this.labelCallNo.Size = new System.Drawing.Size(120, 24);
			this.labelCallNo.TabIndex = 222;
			this.labelCallNo.Text = "Call No";
			// 
			// labelInformation
			// 
			this.labelInformation.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelInformation.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelInformation.ForeColor = System.Drawing.Color.LightCoral;
			this.labelInformation.Location = new System.Drawing.Point(232, 176);
			this.labelInformation.Name = "labelInformation";
			this.labelInformation.Size = new System.Drawing.Size(736, 24);
			this.labelInformation.TabIndex = 225;
			this.labelInformation.Text = "Please click JournalDetail  in DataGrid to get JournalDetail Data or Double Click" +
				" JournalDetail to get JournalArticles Data !";
			// 
			// FrmJournalDetail
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.labelInformation);
			this.Controls.Add(this.textBoxCallNo2);
			this.Controls.Add(this.labelCallNo2);
			this.Controls.Add(this.textBoxCallNo);
			this.Controls.Add(this.labelCallNo);
			this.Controls.Add(this.textBoxMonthSeason);
			this.Controls.Add(this.labelMonthSeason);
			this.Controls.Add(this.textBoxPublishYear);
			this.Controls.Add(this.labelPublishYear);
			this.Controls.Add(this.textBoxNumber);
			this.Controls.Add(this.labelNumber);
			this.Controls.Add(this.textBoxVolume);
			this.Controls.Add(this.labelVolume);
			this.Controls.Add(this.textBoxJournalDetailID);
			this.Controls.Add(this.labelJournalDetailID);
			this.Controls.Add(this.dataGridJournalDetail);
			this.Controls.Add(this.textBoxJournalType);
			this.Controls.Add(this.textBoxLanguage);
			this.Controls.Add(this.LabelTitle);
			this.Controls.Add(this.labelType);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonEdit);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.labelLanguage);
			this.Controls.Add(this.textBoxJournalName);
			this.Controls.Add(this.labelJournalName);
			this.Controls.Add(this.textBoxJournalID);
			this.Controls.Add(this.labelJournalID);
			this.Name = "FrmJournalDetail";
			this.Load += new System.EventHandler(this.FrmJournalDetail_Load);
			this.Controls.SetChildIndex(this.labelJournalID, 0);
			this.Controls.SetChildIndex(this.textBoxJournalID, 0);
			this.Controls.SetChildIndex(this.labelJournalName, 0);
			this.Controls.SetChildIndex(this.textBoxJournalName, 0);
			this.Controls.SetChildIndex(this.labelLanguage, 0);
			this.Controls.SetChildIndex(this.buttonAdd, 0);
			this.Controls.SetChildIndex(this.buttonEdit, 0);
			this.Controls.SetChildIndex(this.buttonDelete, 0);
			this.Controls.SetChildIndex(this.buttonCancel, 0);
			this.Controls.SetChildIndex(this.buttonSave, 0);
			this.Controls.SetChildIndex(this.labelType, 0);
			this.Controls.SetChildIndex(this.LabelTitle, 0);
			this.Controls.SetChildIndex(this.textBoxLanguage, 0);
			this.Controls.SetChildIndex(this.textBoxJournalType, 0);
			this.Controls.SetChildIndex(this.dataGridJournalDetail, 0);
			this.Controls.SetChildIndex(this.labelJournalDetailID, 0);
			this.Controls.SetChildIndex(this.textBoxJournalDetailID, 0);
			this.Controls.SetChildIndex(this.labelVolume, 0);
			this.Controls.SetChildIndex(this.textBoxVolume, 0);
			this.Controls.SetChildIndex(this.labelNumber, 0);
			this.Controls.SetChildIndex(this.textBoxNumber, 0);
			this.Controls.SetChildIndex(this.labelPublishYear, 0);
			this.Controls.SetChildIndex(this.textBoxPublishYear, 0);
			this.Controls.SetChildIndex(this.labelMonthSeason, 0);
			this.Controls.SetChildIndex(this.textBoxMonthSeason, 0);
			this.Controls.SetChildIndex(this.labelCallNo, 0);
			this.Controls.SetChildIndex(this.textBoxCallNo, 0);
			this.Controls.SetChildIndex(this.labelCallNo2, 0);
			this.Controls.SetChildIndex(this.textBoxCallNo2, 0);
			this.Controls.SetChildIndex(this.labelInformation, 0);
			((System.ComponentModel.ISupportInitialize)(this.dataGridJournalDetail)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void FrmJournalDetail_Load(object sender, System.EventArgs e)
		{
			MyJournal = new Journal();
			textBoxJournalID.Text = this.MyMDIForm.MyJournal.JournalID.ToString();
			textBoxJournalName.Text = this.MyMDIForm.MyJournal.JournalName.ToString();
			textBoxLanguage.Text = this.MyMDIForm.MyJournal.JournalLanguage.ToString();
			textBoxJournalType.Text = this.MyMDIForm.MyJournal.JournalType.ToString();
			
			MyJournal.JournalID = textBoxJournalID.Text.ToString();
			MyJournal.JournalName = textBoxJournalName.Text.ToString();
			MyJournal.JournalLanguage = textBoxLanguage.Text.ToString();
			MyJournal.JournalType = textBoxJournalType.Text.ToString();
			MyClassDatabase = new ClassDatabase();
			MyDataTable = MyClassDatabase.GetJournalDetail(MyJournal.JournalID.ToString());
			dataGridJournalDetail.DataSource = MyDataTable;
		}
		private void dataGridJournalDetail_Click(object sender, System.EventArgs e)
		{
			if(MyDataTable.Rows.Count>0)
			{
				textBoxJournalDetailID.Text = dataGridJournalDetail[dataGridJournalDetail.CurrentRowIndex,0].ToString().Trim();
				textBoxPublishYear.Text =dataGridJournalDetail[dataGridJournalDetail.CurrentRowIndex,1].ToString().Trim();
				textBoxMonthSeason.Text = dataGridJournalDetail[dataGridJournalDetail.CurrentRowIndex,2].ToString().Trim();
				textBoxVolume.Text =dataGridJournalDetail[dataGridJournalDetail.CurrentRowIndex,3].ToString().Trim();
				textBoxNumber.Text = dataGridJournalDetail[dataGridJournalDetail.CurrentRowIndex,4].ToString().Trim();
				textBoxCallNo.Text =dataGridJournalDetail[dataGridJournalDetail.CurrentRowIndex,5].ToString().Trim();
				textBoxCallNo2.Text =dataGridJournalDetail[dataGridJournalDetail.CurrentRowIndex,6].ToString().Trim();
				CanDelete = true;
				DoLock();
			}
		}
		private void dataGridJournalDetail_DoubleClick(object sender, System.EventArgs e)
		{
			
			if(MyDataTable.Rows.Count>0)
			{
				
				MyMDIForm.MyBookMenuForm.MyJournalArticlesForm = new FrmJournalArticles (this.MyMDIForm,this.MyBookMenuForm);				
				MyMDIForm.MyBookMenuForm.MyJournalArticlesForm.Show();
				//MyMDIForm.MyBookMenuForm.MyJournalMasterForm.CanDelete = true;
				//MyMDIForm.MyBookMenuForm.MyJournalMasterForm.DoLock();
				this.Hide();
			}
		}
		private void textBoxJournalDetailID_TextChanged(object sender, System.EventArgs e)
		{
			MyJournal.JournalDetailID = textBoxJournalDetailID.Text.ToString();
			this.MyMDIForm.MyJournal.JournalDetailID  =  textBoxJournalDetailID.Text.ToString();
		}

		private void textBoxVolume_TextChanged(object sender, System.EventArgs e)
		{
			MyJournal.Volume =textBoxVolume.Text.ToString();
		this.MyMDIForm.MyJournal.Volume  = textBoxVolume.Text.ToString();
		}

		private void textBoxNumber_TextChanged(object sender, System.EventArgs e)
		{
			MyJournal.Number = textBoxNumber.Text.ToString();
		this.MyMDIForm.MyJournal.Number  = textBoxNumber.Text.ToString();
		}

		private void textBoxPublishYear_TextChanged(object sender, System.EventArgs e)
		{
			MyJournal.PublishYear = textBoxPublishYear.Text.ToString();
		this.MyMDIForm.MyJournal.PublishYear  = textBoxPublishYear.Text.ToString();
		}

		private void textBoxMonthSeason_TextChanged(object sender, System.EventArgs e)
		{
			MyJournal.MonthSeason = textBoxMonthSeason.Text.ToString();
		this.MyMDIForm.MyJournal.MonthSeason  =textBoxMonthSeason.Text.ToString();
		}

		private void textBoxCallNo_TextChanged(object sender, System.EventArgs e)
		{
			MyJournal.CallNo = textBoxCallNo.Text.ToString();
		this.MyMDIForm.MyJournal.CallNo  =textBoxCallNo.Text.ToString();
		}

		private void textBoxCallNo2_TextChanged(object sender, System.EventArgs e)
		{
			MyJournal.CallNo2 = textBoxCallNo2.Text.ToString();
		this.MyMDIForm.MyJournal.CallNo2  =textBoxCallNo2.Text.ToString();
		}
		internal void DoLock()
		{
			buttonAdd.Enabled = true;
			buttonSave.Enabled = false;
			buttonCancel.Enabled = false;


			RefreshButton();


		}
		private void DoUnlock()
		{
			textBoxVolume.Focus();
			buttonAdd.Enabled = false;
			buttonEdit.Enabled = false;
			buttonDelete.Enabled = false;
			buttonSave.Enabled = true;
			buttonCancel.Enabled = true;
			textBoxVolume.Text = "";
			textBoxNumber.Text = "";
			textBoxPublishYear.Text = "";
			textBoxMonthSeason.Text = "";
			textBoxCallNo.Text = "";
			textBoxCallNo2.Text = "";
			
		}
		internal void RefreshButton()
		{
			if(CanDelete == true)
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

		private void buttonAdd_Click(object sender, System.EventArgs e)
		{
			DoUnlock();

			
			textBoxVolume.Focus();
			StatusAction = "Add";
			MyClassDatabase = new ClassDatabase();
			textBoxJournalDetailID.Text  = MyClassDatabase.GetJournalDetailID(MyJournal.JournalLanguage.ToString().Substring(0,1));

		}
		private void buttonEdit_Click(object sender, System.EventArgs e)
		{
			textBoxVolume.Focus();
			buttonAdd.Enabled = false;
			buttonEdit.Enabled = false;
			buttonDelete.Enabled = false;
			buttonSave.Enabled = true;
			buttonCancel.Enabled = true;
			StatusAction = "Edit";
		}
		private void buttonDelete_Click(object sender, System.EventArgs e)
		{
			DialogResult ans;
			ans = MessageBox.Show("Are you sure you want to delete Journal Detail Data with JournalDetailID=' "+ textBoxJournalDetailID.Text.ToString().Trim() + "' ?" , "Confirmation", MessageBoxButtons.YesNo );
			if (ans.ToString() == "Yes")
			{	
				MyClassDatabase = new ClassDatabase();
				MyClassDatabase.DeleteJournalDetail(textBoxJournalDetailID.Text.ToString().Trim());
				CanDelete = false;
				MyMDIForm.MyJournal.JournalDetailID = "";
				
			}
			DoLock();
			textBoxJournalDetailID.Text = "";
			textBoxVolume.Text = "";
			textBoxNumber.Text = "";
			textBoxPublishYear.Text = "";
			textBoxMonthSeason.Text = "";
			textBoxCallNo.Text = "";
			textBoxCallNo2.Text = "";
			this.MyMDIForm.MyJournal.JournalDetailID = "";
			DoRefresh();

		}

		private void buttonSave_Click(object sender, System.EventArgs e)
		{
			MyClassDatabase = new ClassDatabase();
			{
				MyJournal.UpdateUser = MyMDIForm.LibrarianUserName.ToString();
				MyClassDatabase = new ClassDatabase();
				MyClassDatabase.SaveJournalDetail(MyJournal);
				CanDelete = true;
				DoLock();
				StatusAction = "Nothing";
				DoRefresh();
			}
		}
		private void buttonCancel_Click(object sender, System.EventArgs e)
		{
			DoLock();
			StatusAction = "Nothing";
		}
		public void DoRefresh()
		{
			MyClassDatabase = new ClassDatabase();
			MyDataTable = MyClassDatabase.GetJournalDetail(MyJournal.JournalID.ToString());
			dataGridJournalDetail.DataSource = MyDataTable;
		}

	}
}

