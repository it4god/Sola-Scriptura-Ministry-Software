using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace Sola_Scriptura_Library
{
	public class FrmPublisherList : Sola_Scriptura_Library.FrmPublisherMaster
	{
		internal System.Windows.Forms.TextBox textBoxEmail;
		internal System.Windows.Forms.Label labelEmail;
		internal System.Windows.Forms.TextBox textBoxPhone;
		internal System.Windows.Forms.Label labelPhone;
		internal System.Windows.Forms.TextBox textBoxCountry;
		internal System.Windows.Forms.Label labelCountry;
		internal System.Windows.Forms.TextBox textBoxState;
		internal System.Windows.Forms.Label labelState;
		internal System.Windows.Forms.TextBox textBoxPostCode;
		internal System.Windows.Forms.Label labelPostCode;
		internal System.Windows.Forms.TextBox textBoxCity;
		internal System.Windows.Forms.Label labelCity;
		internal System.Windows.Forms.TextBox textBoxAddress;
		internal System.Windows.Forms.Label labelAddress;
		internal System.Windows.Forms.Label labelPublisherName;
		internal System.Windows.Forms.TextBox textBoxFax;
		internal System.Windows.Forms.Label labelFax;
		internal System.Windows.Forms.TextBox textBoxContactPerson;
		internal System.Windows.Forms.Label labelContactPerson;
		internal System.Windows.Forms.Label LabelTitle;
		internal System.Windows.Forms.Button buttonClear;
		internal System.Windows.Forms.TextBox textBoxPublisherName;
		internal System.Windows.Forms.TextBox textBoxPublisherCode;
		internal System.Windows.Forms.Label labelPublisherCode;
		internal System.Windows.Forms.DataGridTableStyle dataGridTableStylePublisher;
		private System.ComponentModel.IContainer components = null;
		internal System.Windows.Forms.DataGrid dataGridPublisherList;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnPublisherCode;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnPublisherName;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnAddress;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnCity;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnPostCode;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnState;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnCountry;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnPhone;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnFax;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnEmail;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnContactPerson;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnUpdateUser;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnUpdateDate;
		internal System.Windows.Forms.Label labelRefresh;
		internal System.Windows.Forms.Button buttonRefresh;
		
		internal ClassDatabase MyClassDatabase;
		internal DataTable MyDataTable;
		internal DataView MyDataView;
		internal Publisher MyPublisher;
	
		public FrmPublisherList()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public FrmPublisherList(FrmMDI MDIForm, FrmSetupMenu SetupMenuForm)
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmPublisherList));
			this.textBoxEmail = new System.Windows.Forms.TextBox();
			this.labelEmail = new System.Windows.Forms.Label();
			this.textBoxPhone = new System.Windows.Forms.TextBox();
			this.labelPhone = new System.Windows.Forms.Label();
			this.textBoxCountry = new System.Windows.Forms.TextBox();
			this.labelCountry = new System.Windows.Forms.Label();
			this.textBoxState = new System.Windows.Forms.TextBox();
			this.labelState = new System.Windows.Forms.Label();
			this.textBoxPostCode = new System.Windows.Forms.TextBox();
			this.labelPostCode = new System.Windows.Forms.Label();
			this.textBoxCity = new System.Windows.Forms.TextBox();
			this.labelCity = new System.Windows.Forms.Label();
			this.textBoxAddress = new System.Windows.Forms.TextBox();
			this.labelAddress = new System.Windows.Forms.Label();
			this.textBoxPublisherName = new System.Windows.Forms.TextBox();
			this.labelPublisherName = new System.Windows.Forms.Label();
			this.textBoxPublisherCode = new System.Windows.Forms.TextBox();
			this.labelPublisherCode = new System.Windows.Forms.Label();
			this.textBoxFax = new System.Windows.Forms.TextBox();
			this.labelFax = new System.Windows.Forms.Label();
			this.textBoxContactPerson = new System.Windows.Forms.TextBox();
			this.labelContactPerson = new System.Windows.Forms.Label();
			this.LabelTitle = new System.Windows.Forms.Label();
			this.dataGridPublisherList = new System.Windows.Forms.DataGrid();
			this.dataGridTableStylePublisher = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnPublisherCode = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnPublisherName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnAddress = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnCity = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnPostCode = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnState = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnCountry = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnPhone = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnFax = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnEmail = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnContactPerson = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnUpdateUser = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnUpdateDate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.buttonClear = new System.Windows.Forms.Button();
			this.buttonRefresh = new System.Windows.Forms.Button();
			this.labelRefresh = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridPublisherList)).BeginInit();
			this.SuspendLayout();
			// 
			// textBoxEmail
			// 
			this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxEmail.Location = new System.Drawing.Point(384, 272);
			this.textBoxEmail.Name = "textBoxEmail";
			this.textBoxEmail.Size = new System.Drawing.Size(536, 22);
			this.textBoxEmail.TabIndex = 10;
			this.textBoxEmail.Text = "";
			this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
			// 
			// labelEmail
			// 
			this.labelEmail.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelEmail.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelEmail.Location = new System.Drawing.Point(256, 272);
			this.labelEmail.Name = "labelEmail";
			this.labelEmail.Size = new System.Drawing.Size(120, 24);
			this.labelEmail.TabIndex = 129;
			this.labelEmail.Text = "Email";
			// 
			// textBoxPhone
			// 
			this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxPhone.Location = new System.Drawing.Point(384, 240);
			this.textBoxPhone.Name = "textBoxPhone";
			this.textBoxPhone.Size = new System.Drawing.Size(200, 22);
			this.textBoxPhone.TabIndex = 8;
			this.textBoxPhone.Text = "";
			this.textBoxPhone.TextChanged += new System.EventHandler(this.textBoxPhone_TextChanged);
			// 
			// labelPhone
			// 
			this.labelPhone.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelPhone.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelPhone.Location = new System.Drawing.Point(256, 240);
			this.labelPhone.Name = "labelPhone";
			this.labelPhone.Size = new System.Drawing.Size(120, 24);
			this.labelPhone.TabIndex = 128;
			this.labelPhone.Text = "Phone";
			// 
			// textBoxCountry
			// 
			this.textBoxCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxCountry.Location = new System.Drawing.Point(720, 208);
			this.textBoxCountry.Name = "textBoxCountry";
			this.textBoxCountry.Size = new System.Drawing.Size(200, 22);
			this.textBoxCountry.TabIndex = 7;
			this.textBoxCountry.Text = "";
			this.textBoxCountry.TextChanged += new System.EventHandler(this.textBoxCountry_TextChanged);
			// 
			// labelCountry
			// 
			this.labelCountry.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelCountry.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelCountry.Location = new System.Drawing.Point(592, 208);
			this.labelCountry.Name = "labelCountry";
			this.labelCountry.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.labelCountry.Size = new System.Drawing.Size(120, 24);
			this.labelCountry.TabIndex = 127;
			this.labelCountry.Text = "Country";
			// 
			// textBoxState
			// 
			this.textBoxState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxState.Location = new System.Drawing.Point(384, 208);
			this.textBoxState.Name = "textBoxState";
			this.textBoxState.Size = new System.Drawing.Size(200, 22);
			this.textBoxState.TabIndex = 6;
			this.textBoxState.Text = "";
			this.textBoxState.TextChanged += new System.EventHandler(this.textBoxState_TextChanged);
			// 
			// labelState
			// 
			this.labelState.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelState.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelState.Location = new System.Drawing.Point(256, 208);
			this.labelState.Name = "labelState";
			this.labelState.Size = new System.Drawing.Size(120, 24);
			this.labelState.TabIndex = 126;
			this.labelState.Text = "State";
			// 
			// textBoxPostCode
			// 
			this.textBoxPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxPostCode.Location = new System.Drawing.Point(720, 176);
			this.textBoxPostCode.Name = "textBoxPostCode";
			this.textBoxPostCode.Size = new System.Drawing.Size(200, 22);
			this.textBoxPostCode.TabIndex = 5;
			this.textBoxPostCode.Text = "";
			this.textBoxPostCode.TextChanged += new System.EventHandler(this.textBoxPostCode_TextChanged);
			// 
			// labelPostCode
			// 
			this.labelPostCode.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelPostCode.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelPostCode.Location = new System.Drawing.Point(592, 176);
			this.labelPostCode.Name = "labelPostCode";
			this.labelPostCode.Size = new System.Drawing.Size(120, 24);
			this.labelPostCode.TabIndex = 125;
			this.labelPostCode.Text = "Post Code";
			// 
			// textBoxCity
			// 
			this.textBoxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxCity.Location = new System.Drawing.Point(384, 176);
			this.textBoxCity.Name = "textBoxCity";
			this.textBoxCity.Size = new System.Drawing.Size(200, 22);
			this.textBoxCity.TabIndex = 4;
			this.textBoxCity.Text = "";
			this.textBoxCity.TextChanged += new System.EventHandler(this.textBoxCity_TextChanged);
			// 
			// labelCity
			// 
			this.labelCity.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelCity.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelCity.Location = new System.Drawing.Point(256, 176);
			this.labelCity.Name = "labelCity";
			this.labelCity.Size = new System.Drawing.Size(120, 24);
			this.labelCity.TabIndex = 124;
			this.labelCity.Text = "City";
			// 
			// textBoxAddress
			// 
			this.textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxAddress.Location = new System.Drawing.Point(384, 144);
			this.textBoxAddress.Name = "textBoxAddress";
			this.textBoxAddress.Size = new System.Drawing.Size(536, 22);
			this.textBoxAddress.TabIndex = 3;
			this.textBoxAddress.Text = "";
			this.textBoxAddress.TextChanged += new System.EventHandler(this.textBoxAddress_TextChanged);
			// 
			// labelAddress
			// 
			this.labelAddress.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelAddress.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelAddress.Location = new System.Drawing.Point(256, 144);
			this.labelAddress.Name = "labelAddress";
			this.labelAddress.Size = new System.Drawing.Size(120, 24);
			this.labelAddress.TabIndex = 123;
			this.labelAddress.Text = "Address";
			// 
			// textBoxPublisherName
			// 
			this.textBoxPublisherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxPublisherName.Location = new System.Drawing.Point(384, 112);
			this.textBoxPublisherName.Name = "textBoxPublisherName";
			this.textBoxPublisherName.Size = new System.Drawing.Size(536, 22);
			this.textBoxPublisherName.TabIndex = 2;
			this.textBoxPublisherName.Text = "";
			this.textBoxPublisherName.TextChanged += new System.EventHandler(this.textBoxPublisherName_TextChanged);
			// 
			// labelPublisherName
			// 
			this.labelPublisherName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelPublisherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelPublisherName.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelPublisherName.Location = new System.Drawing.Point(256, 112);
			this.labelPublisherName.Name = "labelPublisherName";
			this.labelPublisherName.Size = new System.Drawing.Size(120, 24);
			this.labelPublisherName.TabIndex = 122;
			this.labelPublisherName.Text = "Publisher Name";
			// 
			// textBoxPublisherCode
			// 
			this.textBoxPublisherCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxPublisherCode.Location = new System.Drawing.Point(384, 80);
			this.textBoxPublisherCode.Name = "textBoxPublisherCode";
			this.textBoxPublisherCode.Size = new System.Drawing.Size(200, 22);
			this.textBoxPublisherCode.TabIndex = 1;
			this.textBoxPublisherCode.Text = "";
			this.textBoxPublisherCode.TextChanged += new System.EventHandler(this.textBoxPublisherCode_TextChanged);
			// 
			// labelPublisherCode
			// 
			this.labelPublisherCode.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelPublisherCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelPublisherCode.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelPublisherCode.Location = new System.Drawing.Point(256, 80);
			this.labelPublisherCode.Name = "labelPublisherCode";
			this.labelPublisherCode.Size = new System.Drawing.Size(120, 24);
			this.labelPublisherCode.TabIndex = 121;
			this.labelPublisherCode.Text = "Publisher Code";
			// 
			// textBoxFax
			// 
			this.textBoxFax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxFax.Location = new System.Drawing.Point(720, 240);
			this.textBoxFax.Name = "textBoxFax";
			this.textBoxFax.Size = new System.Drawing.Size(200, 22);
			this.textBoxFax.TabIndex = 9;
			this.textBoxFax.Text = "";
			this.textBoxFax.TextChanged += new System.EventHandler(this.textBoxFax_TextChanged);
			// 
			// labelFax
			// 
			this.labelFax.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelFax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelFax.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelFax.Location = new System.Drawing.Point(592, 240);
			this.labelFax.Name = "labelFax";
			this.labelFax.Size = new System.Drawing.Size(120, 24);
			this.labelFax.TabIndex = 131;
			this.labelFax.Text = "Fax";
			// 
			// textBoxContactPerson
			// 
			this.textBoxContactPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxContactPerson.Location = new System.Drawing.Point(384, 304);
			this.textBoxContactPerson.Name = "textBoxContactPerson";
			this.textBoxContactPerson.Size = new System.Drawing.Size(536, 22);
			this.textBoxContactPerson.TabIndex = 11;
			this.textBoxContactPerson.Text = "";
			this.textBoxContactPerson.TextChanged += new System.EventHandler(this.textBoxContactPerson_TextChanged);
			// 
			// labelContactPerson
			// 
			this.labelContactPerson.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelContactPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelContactPerson.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelContactPerson.Location = new System.Drawing.Point(256, 304);
			this.labelContactPerson.Name = "labelContactPerson";
			this.labelContactPerson.Size = new System.Drawing.Size(120, 24);
			this.labelContactPerson.TabIndex = 133;
			this.labelContactPerson.Text = "Contact Person";
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
			this.LabelTitle.TabIndex = 134;
			this.LabelTitle.Text = "    Publisher List";
			this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dataGridPublisherList
			// 
			this.dataGridPublisherList.DataMember = "";
			this.dataGridPublisherList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGridPublisherList.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridPublisherList.Location = new System.Drawing.Point(248, 376);
			this.dataGridPublisherList.Name = "dataGridPublisherList";
			this.dataGridPublisherList.ReadOnly = true;
			this.dataGridPublisherList.Size = new System.Drawing.Size(672, 176);
			this.dataGridPublisherList.TabIndex = 163;
			this.dataGridPublisherList.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																											  this.dataGridTableStylePublisher});
			this.dataGridPublisherList.Click += new System.EventHandler(this.dataGridPublisherList_Click);
			this.dataGridPublisherList.DoubleClick += new System.EventHandler(this.dataGridPublisherList_DoubleClick);
			// 
			// dataGridTableStylePublisher
			// 
			this.dataGridTableStylePublisher.AlternatingBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStylePublisher.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.dataGridTableStylePublisher.DataGrid = this.dataGridPublisherList;
			this.dataGridTableStylePublisher.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStylePublisher.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																														  this.dataGridTextBoxColumnPublisherCode,
																														  this.dataGridTextBoxColumnPublisherName,
																														  this.dataGridTextBoxColumnAddress,
																														  this.dataGridTextBoxColumnCity,
																														  this.dataGridTextBoxColumnPostCode,
																														  this.dataGridTextBoxColumnState,
																														  this.dataGridTextBoxColumnCountry,
																														  this.dataGridTextBoxColumnPhone,
																														  this.dataGridTextBoxColumnFax,
																														  this.dataGridTextBoxColumnEmail,
																														  this.dataGridTextBoxColumnContactPerson,
																														  this.dataGridTextBoxColumnUpdateUser,
																														  this.dataGridTextBoxColumnUpdateDate});
			this.dataGridTableStylePublisher.GridLineColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridTableStylePublisher.HeaderBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStylePublisher.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStylePublisher.MappingName = "PublisherList";
			// 
			// dataGridTextBoxColumnPublisherCode
			// 
			this.dataGridTextBoxColumnPublisherCode.Format = "";
			this.dataGridTextBoxColumnPublisherCode.FormatInfo = null;
			this.dataGridTextBoxColumnPublisherCode.HeaderText = "PublisherCode";
			this.dataGridTextBoxColumnPublisherCode.MappingName = "PublisherCode";
			this.dataGridTextBoxColumnPublisherCode.Width = 120;
			// 
			// dataGridTextBoxColumnPublisherName
			// 
			this.dataGridTextBoxColumnPublisherName.Format = "";
			this.dataGridTextBoxColumnPublisherName.FormatInfo = null;
			this.dataGridTextBoxColumnPublisherName.HeaderText = "Publisher Name";
			this.dataGridTextBoxColumnPublisherName.MappingName = "PublisherName";
			this.dataGridTextBoxColumnPublisherName.Width = 175;
			// 
			// dataGridTextBoxColumnAddress
			// 
			this.dataGridTextBoxColumnAddress.Format = "";
			this.dataGridTextBoxColumnAddress.FormatInfo = null;
			this.dataGridTextBoxColumnAddress.HeaderText = "Address";
			this.dataGridTextBoxColumnAddress.MappingName = "Address";
			this.dataGridTextBoxColumnAddress.Width = 75;
			// 
			// dataGridTextBoxColumnCity
			// 
			this.dataGridTextBoxColumnCity.Format = "";
			this.dataGridTextBoxColumnCity.FormatInfo = null;
			this.dataGridTextBoxColumnCity.HeaderText = "City";
			this.dataGridTextBoxColumnCity.MappingName = "City";
			this.dataGridTextBoxColumnCity.Width = 75;
			// 
			// dataGridTextBoxColumnPostCode
			// 
			this.dataGridTextBoxColumnPostCode.Format = "";
			this.dataGridTextBoxColumnPostCode.FormatInfo = null;
			this.dataGridTextBoxColumnPostCode.HeaderText = "PostCode";
			this.dataGridTextBoxColumnPostCode.MappingName = "PostCode";
			this.dataGridTextBoxColumnPostCode.Width = 75;
			// 
			// dataGridTextBoxColumnState
			// 
			this.dataGridTextBoxColumnState.Format = "";
			this.dataGridTextBoxColumnState.FormatInfo = null;
			this.dataGridTextBoxColumnState.HeaderText = "State";
			this.dataGridTextBoxColumnState.MappingName = "State";
			this.dataGridTextBoxColumnState.Width = 75;
			// 
			// dataGridTextBoxColumnCountry
			// 
			this.dataGridTextBoxColumnCountry.Format = "";
			this.dataGridTextBoxColumnCountry.FormatInfo = null;
			this.dataGridTextBoxColumnCountry.HeaderText = "Country";
			this.dataGridTextBoxColumnCountry.MappingName = "Country";
			this.dataGridTextBoxColumnCountry.Width = 75;
			// 
			// dataGridTextBoxColumnPhone
			// 
			this.dataGridTextBoxColumnPhone.Format = "";
			this.dataGridTextBoxColumnPhone.FormatInfo = null;
			this.dataGridTextBoxColumnPhone.HeaderText = "Phone";
			this.dataGridTextBoxColumnPhone.MappingName = "Phone";
			this.dataGridTextBoxColumnPhone.Width = 75;
			// 
			// dataGridTextBoxColumnFax
			// 
			this.dataGridTextBoxColumnFax.Format = "";
			this.dataGridTextBoxColumnFax.FormatInfo = null;
			this.dataGridTextBoxColumnFax.HeaderText = "Fax";
			this.dataGridTextBoxColumnFax.MappingName = "Fax";
			this.dataGridTextBoxColumnFax.Width = 75;
			// 
			// dataGridTextBoxColumnEmail
			// 
			this.dataGridTextBoxColumnEmail.Format = "";
			this.dataGridTextBoxColumnEmail.FormatInfo = null;
			this.dataGridTextBoxColumnEmail.HeaderText = "Email";
			this.dataGridTextBoxColumnEmail.MappingName = "Email";
			this.dataGridTextBoxColumnEmail.Width = 75;
			// 
			// dataGridTextBoxColumnContactPerson
			// 
			this.dataGridTextBoxColumnContactPerson.Format = "";
			this.dataGridTextBoxColumnContactPerson.FormatInfo = null;
			this.dataGridTextBoxColumnContactPerson.HeaderText = "Contact Person";
			this.dataGridTextBoxColumnContactPerson.MappingName = "ContactPerson";
			this.dataGridTextBoxColumnContactPerson.Width = 75;
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
			// buttonClear
			// 
			this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonClear.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonClear.Image = ((System.Drawing.Image)(resources.GetObject("buttonClear.Image")));
			this.buttonClear.Location = new System.Drawing.Point(728, 336);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(88, 32);
			this.buttonClear.TabIndex = 161;
			this.buttonClear.Text = "Clear";
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// buttonRefresh
			// 
			this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonRefresh.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("buttonRefresh.Image")));
			this.buttonRefresh.Location = new System.Drawing.Point(832, 336);
			this.buttonRefresh.Name = "buttonRefresh";
			this.buttonRefresh.Size = new System.Drawing.Size(88, 32);
			this.buttonRefresh.TabIndex = 162;
			this.buttonRefresh.Text = "Refresh";
			this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
			// 
			// labelRefresh
			// 
			this.labelRefresh.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelRefresh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelRefresh.ForeColor = System.Drawing.Color.LightCoral;
			this.labelRefresh.Location = new System.Drawing.Point(256, 344);
			this.labelRefresh.Name = "labelRefresh";
			this.labelRefresh.Size = new System.Drawing.Size(408, 24);
			this.labelRefresh.TabIndex = 175;
			this.labelRefresh.Text = "You must refresh the data to Update Current Change in Data Grid !";
			this.labelRefresh.Visible = false;
			// 
			// FrmPublisherList
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.labelRefresh);
			this.Controls.Add(this.dataGridPublisherList);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.buttonRefresh);
			this.Controls.Add(this.LabelTitle);
			this.Controls.Add(this.textBoxContactPerson);
			this.Controls.Add(this.labelContactPerson);
			this.Controls.Add(this.textBoxFax);
			this.Controls.Add(this.labelFax);
			this.Controls.Add(this.textBoxEmail);
			this.Controls.Add(this.labelEmail);
			this.Controls.Add(this.textBoxPhone);
			this.Controls.Add(this.labelPhone);
			this.Controls.Add(this.textBoxCountry);
			this.Controls.Add(this.labelCountry);
			this.Controls.Add(this.textBoxState);
			this.Controls.Add(this.labelState);
			this.Controls.Add(this.textBoxPostCode);
			this.Controls.Add(this.labelPostCode);
			this.Controls.Add(this.textBoxCity);
			this.Controls.Add(this.labelCity);
			this.Controls.Add(this.textBoxAddress);
			this.Controls.Add(this.labelAddress);
			this.Controls.Add(this.textBoxPublisherName);
			this.Controls.Add(this.labelPublisherName);
			this.Controls.Add(this.textBoxPublisherCode);
			this.Controls.Add(this.labelPublisherCode);
			this.Name = "FrmPublisherList";
			this.Load += new System.EventHandler(this.FrmPublisherList_Load);
			this.Controls.SetChildIndex(this.labelPublisherCode, 0);
			this.Controls.SetChildIndex(this.textBoxPublisherCode, 0);
			this.Controls.SetChildIndex(this.labelPublisherName, 0);
			this.Controls.SetChildIndex(this.textBoxPublisherName, 0);
			this.Controls.SetChildIndex(this.labelAddress, 0);
			this.Controls.SetChildIndex(this.textBoxAddress, 0);
			this.Controls.SetChildIndex(this.labelCity, 0);
			this.Controls.SetChildIndex(this.textBoxCity, 0);
			this.Controls.SetChildIndex(this.labelPostCode, 0);
			this.Controls.SetChildIndex(this.textBoxPostCode, 0);
			this.Controls.SetChildIndex(this.labelState, 0);
			this.Controls.SetChildIndex(this.textBoxState, 0);
			this.Controls.SetChildIndex(this.labelCountry, 0);
			this.Controls.SetChildIndex(this.textBoxCountry, 0);
			this.Controls.SetChildIndex(this.labelPhone, 0);
			this.Controls.SetChildIndex(this.textBoxPhone, 0);
			this.Controls.SetChildIndex(this.labelEmail, 0);
			this.Controls.SetChildIndex(this.textBoxEmail, 0);
			this.Controls.SetChildIndex(this.labelFax, 0);
			this.Controls.SetChildIndex(this.textBoxFax, 0);
			this.Controls.SetChildIndex(this.labelContactPerson, 0);
			this.Controls.SetChildIndex(this.textBoxContactPerson, 0);
			this.Controls.SetChildIndex(this.LabelTitle, 0);
			this.Controls.SetChildIndex(this.buttonRefresh, 0);
			this.Controls.SetChildIndex(this.buttonClear, 0);
			this.Controls.SetChildIndex(this.dataGridPublisherList, 0);
			this.Controls.SetChildIndex(this.labelRefresh, 0);
			((System.ComponentModel.ISupportInitialize)(this.dataGridPublisherList)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void FrmPublisherList_Load(object sender, System.EventArgs e)
		{
			MyPublisher = new Publisher();
			MyClassDatabase = new ClassDatabase();
			MyDataTable = MyClassDatabase.GetPublisherList();
			MyDataView = new DataView(MyDataTable, "PublisherCode LIKE '%" + MyPublisher.PublisherCode.ToString() + "%' and PublisherName LIKE '%" + MyPublisher.PublisherName.ToString() + "%' and Address LIKE '%" + MyPublisher.Address.ToString() + "%' and City LIKE '%" + MyPublisher.City.ToString() + "%' and PostCode LIKE '%" + MyPublisher.PostCode.ToString() + "%' and State LIKE '%" + MyPublisher.State.ToString() + "%' and Country LIKE '%" + MyPublisher.Country.ToString() + "%' and Phone LIKE '%" + MyPublisher.Phone.ToString() + "%' and Fax LIKE '%" + MyPublisher.Fax.ToString() + "%' and Email LIKE '%" + MyPublisher.Email.ToString() + "%' and ContactPerson LIKE '%" + MyPublisher.ContactPerson.ToString() + "%'","PublisherCode",DataViewRowState.CurrentRows);
			dataGridPublisherList.DataSource = MyDataView;
			labelRefresh.Visible = false;
		}

		private void buttonClear_Click(object sender, System.EventArgs e)
		{
			textBoxPublisherCode.Text = "";
			textBoxPublisherName.Text = "";
			textBoxAddress.Text = "";
			textBoxCity.Text = "";
			textBoxPostCode.Text = "";
			textBoxState.Text = "";
			textBoxCountry.Text = "";
			textBoxPhone.Text = "";
			textBoxFax.Text = "";
			textBoxEmail.Text = "";
			textBoxContactPerson.Text = "";
		}

		private void textBoxPublisherCode_TextChanged(object sender, System.EventArgs e)
		{
			MyPublisher.PublisherCode = textBoxPublisherCode.Text.ToString();
			MyPublisher.PublisherCode = MyPublisher.PublisherCode.Replace("'","''");
			MyDataView = new DataView(MyDataTable, "PublisherCode LIKE '%" + MyPublisher.PublisherCode.ToString() + "%' and PublisherName LIKE '%" + MyPublisher.PublisherName.ToString() + "%' and Address LIKE '%" + MyPublisher.Address.ToString() + "%' and City LIKE '%" + MyPublisher.City.ToString() + "%' and PostCode LIKE '%" + MyPublisher.PostCode.ToString() + "%' and State LIKE '%" + MyPublisher.State.ToString() + "%' and Country LIKE '%" + MyPublisher.Country.ToString() + "%' and Phone LIKE '%" + MyPublisher.Phone.ToString() + "%' and Fax LIKE '%" + MyPublisher.Fax.ToString() + "%' and Email LIKE '%" + MyPublisher.Email.ToString() + "%' and ContactPerson LIKE '%" + MyPublisher.ContactPerson.ToString() + "%'","PublisherCode",DataViewRowState.CurrentRows);
			dataGridPublisherList.DataSource = MyDataView;
		}

		private void textBoxPublisherName_TextChanged(object sender, System.EventArgs e)
		{
			MyPublisher.PublisherName = textBoxPublisherName.Text.ToString();
			MyPublisher.PublisherName = MyPublisher.PublisherName.Replace("'","''");
			MyDataView = new DataView(MyDataTable, "PublisherCode LIKE '%" + MyPublisher.PublisherCode.ToString() + "%' and PublisherName LIKE '%" + MyPublisher.PublisherName.ToString() + "%' and Address LIKE '%" + MyPublisher.Address.ToString() + "%' and City LIKE '%" + MyPublisher.City.ToString() + "%' and PostCode LIKE '%" + MyPublisher.PostCode.ToString() + "%' and State LIKE '%" + MyPublisher.State.ToString() + "%' and Country LIKE '%" + MyPublisher.Country.ToString() + "%' and Phone LIKE '%" + MyPublisher.Phone.ToString() + "%' and Fax LIKE '%" + MyPublisher.Fax.ToString() + "%' and Email LIKE '%" + MyPublisher.Email.ToString() + "%' and ContactPerson LIKE '%" + MyPublisher.ContactPerson.ToString() + "%'","PublisherCode",DataViewRowState.CurrentRows);
			dataGridPublisherList.DataSource = MyDataView;
		}

		private void textBoxAddress_TextChanged(object sender, System.EventArgs e)
		{
			MyPublisher.Address = textBoxAddress.Text.ToString();
			MyPublisher.Address = MyPublisher.Address.Replace("'","''");
			MyDataView = new DataView(MyDataTable, "PublisherCode LIKE '%" + MyPublisher.PublisherCode.ToString() + "%' and PublisherName LIKE '%" + MyPublisher.PublisherName.ToString() + "%' and Address LIKE '%" + MyPublisher.Address.ToString() + "%' and City LIKE '%" + MyPublisher.City.ToString() + "%' and PostCode LIKE '%" + MyPublisher.PostCode.ToString() + "%' and State LIKE '%" + MyPublisher.State.ToString() + "%' and Country LIKE '%" + MyPublisher.Country.ToString() + "%' and Phone LIKE '%" + MyPublisher.Phone.ToString() + "%' and Fax LIKE '%" + MyPublisher.Fax.ToString() + "%' and Email LIKE '%" + MyPublisher.Email.ToString() + "%' and ContactPerson LIKE '%" + MyPublisher.ContactPerson.ToString() + "%'","PublisherCode",DataViewRowState.CurrentRows);
			dataGridPublisherList.DataSource = MyDataView;
		}

		private void textBoxCity_TextChanged(object sender, System.EventArgs e)
		{
			MyPublisher.City = textBoxCity.Text.ToString();
			MyPublisher.City = MyPublisher.City.Replace("'","''");
			MyDataView = new DataView(MyDataTable, "PublisherCode LIKE '%" + MyPublisher.PublisherCode.ToString() + "%' and PublisherName LIKE '%" + MyPublisher.PublisherName.ToString() + "%' and Address LIKE '%" + MyPublisher.Address.ToString() + "%' and City LIKE '%" + MyPublisher.City.ToString() + "%' and PostCode LIKE '%" + MyPublisher.PostCode.ToString() + "%' and State LIKE '%" + MyPublisher.State.ToString() + "%' and Country LIKE '%" + MyPublisher.Country.ToString() + "%' and Phone LIKE '%" + MyPublisher.Phone.ToString() + "%' and Fax LIKE '%" + MyPublisher.Fax.ToString() + "%' and Email LIKE '%" + MyPublisher.Email.ToString() + "%' and ContactPerson LIKE '%" + MyPublisher.ContactPerson.ToString() + "%'","PublisherCode",DataViewRowState.CurrentRows);
			dataGridPublisherList.DataSource = MyDataView;
		}

		private void textBoxPostCode_TextChanged(object sender, System.EventArgs e)
		{
			MyPublisher.PostCode = textBoxPostCode.Text.ToString();
			MyPublisher.PostCode = MyPublisher.PostCode.Replace("'","''");
			MyDataView = new DataView(MyDataTable, "PublisherCode LIKE '%" + MyPublisher.PublisherCode.ToString() + "%' and PublisherName LIKE '%" + MyPublisher.PublisherName.ToString() + "%' and Address LIKE '%" + MyPublisher.Address.ToString() + "%' and City LIKE '%" + MyPublisher.City.ToString() + "%' and PostCode LIKE '%" + MyPublisher.PostCode.ToString() + "%' and State LIKE '%" + MyPublisher.State.ToString() + "%' and Country LIKE '%" + MyPublisher.Country.ToString() + "%' and Phone LIKE '%" + MyPublisher.Phone.ToString() + "%' and Fax LIKE '%" + MyPublisher.Fax.ToString() + "%' and Email LIKE '%" + MyPublisher.Email.ToString() + "%' and ContactPerson LIKE '%" + MyPublisher.ContactPerson.ToString() + "%'","PublisherCode",DataViewRowState.CurrentRows);
			dataGridPublisherList.DataSource = MyDataView;
		}

		private void textBoxState_TextChanged(object sender, System.EventArgs e)
		{
			MyPublisher.State = textBoxState.Text.ToString();
			MyPublisher.State = MyPublisher.State.Replace("'","''");
			MyDataView = new DataView(MyDataTable, "PublisherCode LIKE '%" + MyPublisher.PublisherCode.ToString() + "%' and PublisherName LIKE '%" + MyPublisher.PublisherName.ToString() + "%' and Address LIKE '%" + MyPublisher.Address.ToString() + "%' and City LIKE '%" + MyPublisher.City.ToString() + "%' and PostCode LIKE '%" + MyPublisher.PostCode.ToString() + "%' and State LIKE '%" + MyPublisher.State.ToString() + "%' and Country LIKE '%" + MyPublisher.Country.ToString() + "%' and Phone LIKE '%" + MyPublisher.Phone.ToString() + "%' and Fax LIKE '%" + MyPublisher.Fax.ToString() + "%' and Email LIKE '%" + MyPublisher.Email.ToString() + "%' and ContactPerson LIKE '%" + MyPublisher.ContactPerson.ToString() + "%'","PublisherCode",DataViewRowState.CurrentRows);
			dataGridPublisherList.DataSource = MyDataView;
		}

		private void textBoxCountry_TextChanged(object sender, System.EventArgs e)
		{
			MyPublisher.Country = textBoxCountry.Text.ToString();
			MyPublisher.Country = MyPublisher.Country.Replace("'","''");
			MyDataView = new DataView(MyDataTable, "PublisherCode LIKE '%" + textBoxPublisherCode.Text.ToString() + "%' and PublisherName LIKE '%" + textBoxPublisherName.Text.ToString() + "%' and Address LIKE '%" + textBoxAddress.Text.ToString() + "%' and City LIKE '%" + textBoxCity.Text.ToString() + "%' and PostCode LIKE '%" + textBoxPostCode.Text.ToString() + "%' and State LIKE '%" + textBoxState.Text.ToString() + "%' and Country LIKE '%" + textBoxCountry.Text.ToString() + "%' and Phone LIKE '%" + textBoxPhone.Text.ToString() + "%' and Fax LIKE '%" + textBoxFax.Text.ToString() + "%' and Email LIKE '%" + textBoxEmail.Text.ToString() + "%' and ContactPerson LIKE '%" + textBoxContactPerson.Text.ToString() + "%'","PublisherCode",DataViewRowState.CurrentRows);
			dataGridPublisherList.DataSource = MyDataView;
		}

		private void textBoxPhone_TextChanged(object sender, System.EventArgs e)
		{
			MyPublisher.Phone = textBoxPhone.Text.ToString();
			MyPublisher.Phone = MyPublisher.Phone.Replace("'","''");
			MyDataView = new DataView(MyDataTable, "PublisherCode LIKE '%" + MyPublisher.PublisherCode.ToString() + "%' and PublisherName LIKE '%" + MyPublisher.PublisherName.ToString() + "%' and Address LIKE '%" + MyPublisher.Address.ToString() + "%' and City LIKE '%" + MyPublisher.City.ToString() + "%' and PostCode LIKE '%" + MyPublisher.PostCode.ToString() + "%' and State LIKE '%" + MyPublisher.State.ToString() + "%' and Country LIKE '%" + MyPublisher.Country.ToString() + "%' and Phone LIKE '%" + MyPublisher.Phone.ToString() + "%' and Fax LIKE '%" + MyPublisher.Fax.ToString() + "%' and Email LIKE '%" + MyPublisher.Email.ToString() + "%' and ContactPerson LIKE '%" + MyPublisher.ContactPerson.ToString() + "%'","PublisherCode",DataViewRowState.CurrentRows);
			dataGridPublisherList.DataSource = MyDataView;
		}

		private void textBoxFax_TextChanged(object sender, System.EventArgs e)
		{
			MyPublisher.Fax = textBoxFax.Text.ToString();
			MyPublisher.Fax = MyPublisher.Fax.Replace("'","''");
			MyDataView = new DataView(MyDataTable, "PublisherCode LIKE '%" + MyPublisher.PublisherCode.ToString() + "%' and PublisherName LIKE '%" + MyPublisher.PublisherName.ToString() + "%' and Address LIKE '%" + MyPublisher.Address.ToString() + "%' and City LIKE '%" + MyPublisher.City.ToString() + "%' and PostCode LIKE '%" + MyPublisher.PostCode.ToString() + "%' and State LIKE '%" + MyPublisher.State.ToString() + "%' and Country LIKE '%" + MyPublisher.Country.ToString() + "%' and Phone LIKE '%" + MyPublisher.Phone.ToString() + "%' and Fax LIKE '%" + MyPublisher.Fax.ToString() + "%' and Email LIKE '%" + MyPublisher.Email.ToString() + "%' and ContactPerson LIKE '%" + MyPublisher.ContactPerson.ToString() + "%'","PublisherCode",DataViewRowState.CurrentRows);
			dataGridPublisherList.DataSource = MyDataView;
		}

		private void textBoxEmail_TextChanged(object sender, System.EventArgs e)
		{
			MyPublisher.Email = textBoxEmail.Text.ToString();
			MyPublisher.Email = MyPublisher.Email.Replace("'","''");
			MyDataView = new DataView(MyDataTable, "PublisherCode LIKE '%" + MyPublisher.PublisherCode.ToString() + "%' and PublisherName LIKE '%" + MyPublisher.PublisherName.ToString() + "%' and Address LIKE '%" + MyPublisher.Address.ToString() + "%' and City LIKE '%" + MyPublisher.City.ToString() + "%' and PostCode LIKE '%" + MyPublisher.PostCode.ToString() + "%' and State LIKE '%" + MyPublisher.State.ToString() + "%' and Country LIKE '%" + MyPublisher.Country.ToString() + "%' and Phone LIKE '%" + MyPublisher.Phone.ToString() + "%' and Fax LIKE '%" + MyPublisher.Fax.ToString() + "%' and Email LIKE '%" + MyPublisher.Email.ToString() + "%' and ContactPerson LIKE '%" + MyPublisher.ContactPerson.ToString() + "%'","PublisherCode",DataViewRowState.CurrentRows);
			dataGridPublisherList.DataSource = MyDataView;
		}

		private void textBoxContactPerson_TextChanged(object sender, System.EventArgs e)
		{
			MyPublisher.ContactPerson = textBoxContactPerson.Text.ToString();
			MyPublisher.ContactPerson = MyPublisher.ContactPerson.Replace("'","''");
			MyDataView = new DataView(MyDataTable, "PublisherCode LIKE '%" + MyPublisher.PublisherCode.ToString() + "%' and PublisherName LIKE '%" + MyPublisher.PublisherName.ToString() + "%' and Address LIKE '%" + MyPublisher.Address.ToString() + "%' and City LIKE '%" + MyPublisher.City.ToString() + "%' and PostCode LIKE '%" + MyPublisher.PostCode.ToString() + "%' and State LIKE '%" + MyPublisher.State.ToString() + "%' and Country LIKE '%" + MyPublisher.Country.ToString() + "%' and Phone LIKE '%" + MyPublisher.Phone.ToString() + "%' and Fax LIKE '%" + MyPublisher.Fax.ToString() + "%' and Email LIKE '%" + MyPublisher.Email.ToString() + "%' and ContactPerson LIKE '%" + MyPublisher.ContactPerson.ToString() + "%'","PublisherCode",DataViewRowState.CurrentRows);
			dataGridPublisherList.DataSource = MyDataView;
		}

		private void dataGridPublisherList_Click(object sender, System.EventArgs e)
		{
			if(MyDataView.Count>0)
				PublisherSelect();
		}
		private void dataGridPublisherList_DoubleClick(object sender, System.EventArgs e)
		{
			if(MyDataView.Count>0)
			{

				this.Hide();
				MySetupMenuForm.MyPublisherDetailForm = new FrmPublisherDetail(this.MyMDIForm, this.MySetupMenuForm);
				MySetupMenuForm.MyPublisherDetailForm.Show();
				MySetupMenuForm.MyPublisherDetailForm.Location = new Point(2,165);
				MySetupMenuForm.MyPublisherDetailForm.buttonPublisherDetail.Focus();
				MySetupMenuForm.MyPublisherDetailForm.textBoxPublisherCode.Text = MySetupMenuForm.MyPublisher.PublisherCode;
				MySetupMenuForm.MyPublisherDetailForm.textBoxPublisherName.Text  = MySetupMenuForm.MyPublisher.PublisherName;
				MySetupMenuForm.MyPublisherDetailForm.textBoxAddress.Text = MySetupMenuForm.MyPublisher.Address;
				MySetupMenuForm.MyPublisherDetailForm.textBoxCity.Text = MySetupMenuForm.MyPublisher.City;
				MySetupMenuForm.MyPublisherDetailForm.textBoxPostCode.Text = MySetupMenuForm.MyPublisher.PostCode;
				MySetupMenuForm.MyPublisherDetailForm.textBoxState.Text = MySetupMenuForm.MyPublisher.State;
				MySetupMenuForm.MyPublisherDetailForm.textBoxCountry.Text = MySetupMenuForm.MyPublisher.Country;
				MySetupMenuForm.MyPublisherDetailForm.textBoxPhone.Text = MySetupMenuForm.MyPublisher.Phone;
				MySetupMenuForm.MyPublisherDetailForm.textBoxFax.Text = MySetupMenuForm.MyPublisher.Fax;
				MySetupMenuForm.MyPublisherDetailForm.textBoxEmail.Text = MySetupMenuForm.MyPublisher.Email;
				MySetupMenuForm.MyPublisherDetailForm.textBoxContactPerson.Text = MySetupMenuForm.MyPublisher.ContactPerson;
				MySetupMenuForm.MyPublisherDetailForm.MyPublisher.UpdateUser  = MyMDIForm.LibrarianUserName;
				if(MySetupMenuForm.MyPublisher.PublisherCode.ToString()!="")
					MySetupMenuForm.MyPublisherDetailForm.CanDelete = true;
				else
					MySetupMenuForm.MyPublisherDetailForm.CanDelete = false;
				MySetupMenuForm.MyPublisherDetailForm.RefreshButton();
			}
		}
		private void PublisherSelect()
		{
			MySetupMenuForm.MyPublisher.PublisherCode = dataGridPublisherList[dataGridPublisherList.CurrentRowIndex,0].ToString().Trim();
			MySetupMenuForm.MyPublisher.PublisherName = dataGridPublisherList[dataGridPublisherList.CurrentRowIndex,1].ToString().Trim();
			MySetupMenuForm.MyPublisher.Address = dataGridPublisherList[dataGridPublisherList.CurrentRowIndex,2].ToString().Trim();
			MySetupMenuForm.MyPublisher.City = dataGridPublisherList[dataGridPublisherList.CurrentRowIndex,3].ToString().Trim();
			MySetupMenuForm.MyPublisher.PostCode = dataGridPublisherList[dataGridPublisherList.CurrentRowIndex,4].ToString().Trim();
			MySetupMenuForm.MyPublisher.State = dataGridPublisherList[dataGridPublisherList.CurrentRowIndex,5].ToString().Trim();
			MySetupMenuForm.MyPublisher.Country = dataGridPublisherList[dataGridPublisherList.CurrentRowIndex,6].ToString().Trim();
			MySetupMenuForm.MyPublisher.Phone = dataGridPublisherList[dataGridPublisherList.CurrentRowIndex,7].ToString().Trim();
			MySetupMenuForm.MyPublisher.Fax = dataGridPublisherList[dataGridPublisherList.CurrentRowIndex,8].ToString().Trim();
			MySetupMenuForm.MyPublisher.Email = dataGridPublisherList[dataGridPublisherList.CurrentRowIndex,9].ToString().Trim();
			MySetupMenuForm.MyPublisher.ContactPerson = dataGridPublisherList[dataGridPublisherList.CurrentRowIndex,10].ToString().Trim();
			MySetupMenuForm.MyPublisher.UpdateUser = MyMDIForm.LibrarianUserName.ToString();
		}

		private void buttonRefresh_Click(object sender, System.EventArgs e)
		{
			MyClassDatabase = new ClassDatabase();
			MyDataTable = MyClassDatabase.GetPublisherList();
			MyDataView = new DataView(MyDataTable, "PublisherCode LIKE '%" + textBoxPublisherCode.Text.ToString() + "%' and PublisherName LIKE '%" + textBoxPublisherName.Text.ToString() + "%' and Address LIKE '%" + textBoxAddress.Text.ToString() + "%' and City LIKE '%" + textBoxCity.Text.ToString() + "%' and PostCode LIKE '%" + textBoxPostCode.Text.ToString() + "%' and State LIKE '%" + textBoxState.Text.ToString() + "%' and Country LIKE '%" + textBoxCountry.Text.ToString() + "%' and Phone LIKE '%" + textBoxPhone.Text.ToString() + "%' and Fax LIKE '%" + textBoxFax.Text.ToString() + "%' and Email LIKE '%" + textBoxEmail.Text.ToString() + "%' and ContactPerson LIKE '%" + textBoxContactPerson.Text.ToString() + "%'","PublisherCode",DataViewRowState.CurrentRows);
			dataGridPublisherList.DataSource = MyDataView;
			labelRefresh.Visible = false;
		}
	}
}

