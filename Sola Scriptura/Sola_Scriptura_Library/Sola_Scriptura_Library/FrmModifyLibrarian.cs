using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace Sola_Scriptura_Library
{
	public class FrmModifyLibrarian : Sola_Scriptura_Library.FrmFormParent
	{
		internal System.Windows.Forms.Label LabelTitle;
		internal System.Windows.Forms.ComboBox comboBoxLibrarianGroup;
		internal System.Windows.Forms.Label labelLibrarianGroup;
		internal System.Windows.Forms.TextBox textBoxUserName;
		internal System.Windows.Forms.Label labelUserName;
		internal System.Windows.Forms.TextBox textBoxLibrarianID;
		internal System.Windows.Forms.Label labelLibrarianID;
		internal System.Windows.Forms.Button buttonSearch;
		internal System.Windows.Forms.TextBox textBoxLibrarianName;
		internal System.Windows.Forms.Label labelLibrarianName;
		internal System.Windows.Forms.Button buttonModify;
		internal System.Windows.Forms.Label label1;
		internal System.Windows.Forms.DataGrid dataGridModifyLibrarian;
		private System.ComponentModel.IContainer components = null;

		internal Librarian MyLibrarian;
		internal ClassDatabase MyClassDatabase;
		internal System.Windows.Forms.DataGridTableStyle dataGridTableStyleLibrarian;
		internal DataTable MyDataTable;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnLibrarianID;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnUserName;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnUserPassword;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnLibrarianName;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnLibrarianGroup;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnActiveDate;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnAddress;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnCity;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnPostCode;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnState;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnCountry;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnPhone;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnHandPhone;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnEmail;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnLocationCode;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnUpdateUser;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnUpdateDate;
		internal System.Windows.Forms.PictureBox pictureBoxLogoPicture;
		
		internal FrmLibrarian MyLibrarianForm;

		public FrmModifyLibrarian()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public FrmModifyLibrarian(FrmMDI MDIForm)
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmModifyLibrarian));
			this.LabelTitle = new System.Windows.Forms.Label();
			this.dataGridModifyLibrarian = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyleLibrarian = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnLibrarianID = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnUserName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnUserPassword = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnLibrarianName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnLibrarianGroup = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnActiveDate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnAddress = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnCity = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnPostCode = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnState = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnCountry = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnPhone = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnHandPhone = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnEmail = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnLocationCode = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnUpdateUser = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnUpdateDate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.comboBoxLibrarianGroup = new System.Windows.Forms.ComboBox();
			this.labelLibrarianGroup = new System.Windows.Forms.Label();
			this.textBoxUserName = new System.Windows.Forms.TextBox();
			this.labelUserName = new System.Windows.Forms.Label();
			this.textBoxLibrarianID = new System.Windows.Forms.TextBox();
			this.labelLibrarianID = new System.Windows.Forms.Label();
			this.textBoxLibrarianName = new System.Windows.Forms.TextBox();
			this.labelLibrarianName = new System.Windows.Forms.Label();
			this.buttonModify = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBoxLogoPicture = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridModifyLibrarian)).BeginInit();
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
			this.LabelTitle.TabIndex = 64;
			this.LabelTitle.Text = "    Title";
			this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dataGridModifyLibrarian
			// 
			this.dataGridModifyLibrarian.DataMember = "";
			this.dataGridModifyLibrarian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGridModifyLibrarian.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridModifyLibrarian.Location = new System.Drawing.Point(248, 208);
			this.dataGridModifyLibrarian.Name = "dataGridModifyLibrarian";
			this.dataGridModifyLibrarian.ReadOnly = true;
			this.dataGridModifyLibrarian.Size = new System.Drawing.Size(656, 336);
			this.dataGridModifyLibrarian.TabIndex = 65;
			this.dataGridModifyLibrarian.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																												this.dataGridTableStyleLibrarian});
			// 
			// dataGridTableStyleLibrarian
			// 
			this.dataGridTableStyleLibrarian.AlternatingBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleLibrarian.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.dataGridTableStyleLibrarian.DataGrid = this.dataGridModifyLibrarian;
			this.dataGridTableStyleLibrarian.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleLibrarian.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																														  this.dataGridTextBoxColumnLibrarianID,
																														  this.dataGridTextBoxColumnUserName,
																														  this.dataGridTextBoxColumnUserPassword,
																														  this.dataGridTextBoxColumnLibrarianName,
																														  this.dataGridTextBoxColumnLibrarianGroup,
																														  this.dataGridTextBoxColumnActiveDate,
																														  this.dataGridTextBoxColumnAddress,
																														  this.dataGridTextBoxColumnCity,
																														  this.dataGridTextBoxColumnPostCode,
																														  this.dataGridTextBoxColumnState,
																														  this.dataGridTextBoxColumnCountry,
																														  this.dataGridTextBoxColumnPhone,
																														  this.dataGridTextBoxColumnHandPhone,
																														  this.dataGridTextBoxColumnEmail,
																														  this.dataGridTextBoxColumnLocationCode,
																														  this.dataGridTextBoxColumnUpdateUser,
																														  this.dataGridTextBoxColumnUpdateDate});
			this.dataGridTableStyleLibrarian.GridLineColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridTableStyleLibrarian.HeaderBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleLibrarian.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleLibrarian.MappingName = "Librarian";
			this.dataGridTableStyleLibrarian.ReadOnly = true;
			// 
			// dataGridTextBoxColumnLibrarianID
			// 
			this.dataGridTextBoxColumnLibrarianID.Format = "";
			this.dataGridTextBoxColumnLibrarianID.FormatInfo = null;
			this.dataGridTextBoxColumnLibrarianID.HeaderText = "LibrarianID";
			this.dataGridTextBoxColumnLibrarianID.MappingName = "LibrarianID";
			this.dataGridTextBoxColumnLibrarianID.Width = 75;
			// 
			// dataGridTextBoxColumnUserName
			// 
			this.dataGridTextBoxColumnUserName.Format = "";
			this.dataGridTextBoxColumnUserName.FormatInfo = null;
			this.dataGridTextBoxColumnUserName.HeaderText = "UserName";
			this.dataGridTextBoxColumnUserName.MappingName = "UserName";
			this.dataGridTextBoxColumnUserName.Width = 75;
			// 
			// dataGridTextBoxColumnUserPassword
			// 
			this.dataGridTextBoxColumnUserPassword.Format = "";
			this.dataGridTextBoxColumnUserPassword.FormatInfo = null;
			this.dataGridTextBoxColumnUserPassword.HeaderText = "User Password";
			this.dataGridTextBoxColumnUserPassword.MappingName = "UserPassword";
			this.dataGridTextBoxColumnUserPassword.Width = 0;
			// 
			// dataGridTextBoxColumnLibrarianName
			// 
			this.dataGridTextBoxColumnLibrarianName.Format = "";
			this.dataGridTextBoxColumnLibrarianName.FormatInfo = null;
			this.dataGridTextBoxColumnLibrarianName.HeaderText = "Librarian Name";
			this.dataGridTextBoxColumnLibrarianName.MappingName = "LibrarianName";
			this.dataGridTextBoxColumnLibrarianName.Width = 75;
			// 
			// dataGridTextBoxColumnLibrarianGroup
			// 
			this.dataGridTextBoxColumnLibrarianGroup.Format = "";
			this.dataGridTextBoxColumnLibrarianGroup.FormatInfo = null;
			this.dataGridTextBoxColumnLibrarianGroup.HeaderText = "Librarian Group";
			this.dataGridTextBoxColumnLibrarianGroup.MappingName = "LibrarianGroup";
			this.dataGridTextBoxColumnLibrarianGroup.Width = 75;
			// 
			// dataGridTextBoxColumnActiveDate
			// 
			this.dataGridTextBoxColumnActiveDate.Format = "";
			this.dataGridTextBoxColumnActiveDate.FormatInfo = null;
			this.dataGridTextBoxColumnActiveDate.HeaderText = "Active Date";
			this.dataGridTextBoxColumnActiveDate.MappingName = "ActiveDate";
			this.dataGridTextBoxColumnActiveDate.Width = 75;
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
			// dataGridTextBoxColumnHandPhone
			// 
			this.dataGridTextBoxColumnHandPhone.Format = "";
			this.dataGridTextBoxColumnHandPhone.FormatInfo = null;
			this.dataGridTextBoxColumnHandPhone.HeaderText = "HandPhone";
			this.dataGridTextBoxColumnHandPhone.MappingName = "HandPhone";
			this.dataGridTextBoxColumnHandPhone.Width = 75;
			// 
			// dataGridTextBoxColumnEmail
			// 
			this.dataGridTextBoxColumnEmail.Format = "";
			this.dataGridTextBoxColumnEmail.FormatInfo = null;
			this.dataGridTextBoxColumnEmail.HeaderText = "Email";
			this.dataGridTextBoxColumnEmail.MappingName = "Email";
			this.dataGridTextBoxColumnEmail.Width = 75;
			// 
			// dataGridTextBoxColumnLocationCode
			// 
			this.dataGridTextBoxColumnLocationCode.Format = "";
			this.dataGridTextBoxColumnLocationCode.FormatInfo = null;
			this.dataGridTextBoxColumnLocationCode.HeaderText = "Location Code";
			this.dataGridTextBoxColumnLocationCode.MappingName = "LocationCode";
			this.dataGridTextBoxColumnLocationCode.Width = 75;
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
			// buttonSearch
			// 
			this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonSearch.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearch.Image")));
			this.buttonSearch.Location = new System.Drawing.Point(768, 168);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(136, 32);
			this.buttonSearch.TabIndex = 5;
			this.buttonSearch.Text = "Search";
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// comboBoxLibrarianGroup
			// 
			this.comboBoxLibrarianGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.comboBoxLibrarianGroup.Items.AddRange(new object[] {
																		"All",
																		"Administrator",
																		"User"});
			this.comboBoxLibrarianGroup.Location = new System.Drawing.Point(704, 136);
			this.comboBoxLibrarianGroup.Name = "comboBoxLibrarianGroup";
			this.comboBoxLibrarianGroup.Size = new System.Drawing.Size(200, 24);
			this.comboBoxLibrarianGroup.TabIndex = 4;
			this.comboBoxLibrarianGroup.Text = "All";
			this.comboBoxLibrarianGroup.SelectedIndexChanged += new System.EventHandler(this.comboBoxLibrarianGroup_SelectedIndexChanged);
			// 
			// labelLibrarianGroup
			// 
			this.labelLibrarianGroup.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelLibrarianGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelLibrarianGroup.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelLibrarianGroup.Location = new System.Drawing.Point(576, 136);
			this.labelLibrarianGroup.Name = "labelLibrarianGroup";
			this.labelLibrarianGroup.Size = new System.Drawing.Size(120, 24);
			this.labelLibrarianGroup.TabIndex = 101;
			this.labelLibrarianGroup.Text = "Librarian Group";
			// 
			// textBoxUserName
			// 
			this.textBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxUserName.Location = new System.Drawing.Point(704, 104);
			this.textBoxUserName.Name = "textBoxUserName";
			this.textBoxUserName.Size = new System.Drawing.Size(200, 22);
			this.textBoxUserName.TabIndex = 2;
			this.textBoxUserName.Text = "";
			this.textBoxUserName.TextChanged += new System.EventHandler(this.textBoxUserName_TextChanged);
			// 
			// labelUserName
			// 
			this.labelUserName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelUserName.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelUserName.Location = new System.Drawing.Point(576, 104);
			this.labelUserName.Name = "labelUserName";
			this.labelUserName.Size = new System.Drawing.Size(120, 24);
			this.labelUserName.TabIndex = 99;
			this.labelUserName.Text = "User Name";
			// 
			// textBoxLibrarianID
			// 
			this.textBoxLibrarianID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxLibrarianID.Location = new System.Drawing.Point(368, 104);
			this.textBoxLibrarianID.Name = "textBoxLibrarianID";
			this.textBoxLibrarianID.Size = new System.Drawing.Size(200, 22);
			this.textBoxLibrarianID.TabIndex = 1;
			this.textBoxLibrarianID.Text = "";
			this.textBoxLibrarianID.TextChanged += new System.EventHandler(this.textBoxLibrarianID_TextChanged);
			// 
			// labelLibrarianID
			// 
			this.labelLibrarianID.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelLibrarianID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelLibrarianID.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelLibrarianID.Location = new System.Drawing.Point(240, 104);
			this.labelLibrarianID.Name = "labelLibrarianID";
			this.labelLibrarianID.Size = new System.Drawing.Size(120, 24);
			this.labelLibrarianID.TabIndex = 98;
			this.labelLibrarianID.Text = "Librarian ID";
			// 
			// textBoxLibrarianName
			// 
			this.textBoxLibrarianName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxLibrarianName.Location = new System.Drawing.Point(368, 136);
			this.textBoxLibrarianName.Name = "textBoxLibrarianName";
			this.textBoxLibrarianName.Size = new System.Drawing.Size(200, 22);
			this.textBoxLibrarianName.TabIndex = 3;
			this.textBoxLibrarianName.Text = "";
			this.textBoxLibrarianName.TextChanged += new System.EventHandler(this.textBoxLibrarianName_TextChanged);
			// 
			// labelLibrarianName
			// 
			this.labelLibrarianName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelLibrarianName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelLibrarianName.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelLibrarianName.Location = new System.Drawing.Point(240, 136);
			this.labelLibrarianName.Name = "labelLibrarianName";
			this.labelLibrarianName.Size = new System.Drawing.Size(120, 24);
			this.labelLibrarianName.TabIndex = 103;
			this.labelLibrarianName.Text = "Librarian Name";
			// 
			// buttonModify
			// 
			this.buttonModify.Enabled = false;
			this.buttonModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonModify.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonModify.Image = ((System.Drawing.Image)(resources.GetObject("buttonModify.Image")));
			this.buttonModify.Location = new System.Drawing.Point(912, 512);
			this.buttonModify.Name = "buttonModify";
			this.buttonModify.Size = new System.Drawing.Size(88, 32);
			this.buttonModify.TabIndex = 6;
			this.buttonModify.Text = "Modify";
			this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label1.Location = new System.Drawing.Point(240, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(656, 24);
			this.label1.TabIndex = 104;
			this.label1.Text = "Please enter the required fields, then click Search";
			// 
			// pictureBoxLogoPicture
			// 
			this.pictureBoxLogoPicture.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogoPicture.Image")));
			this.pictureBoxLogoPicture.Location = new System.Drawing.Point(32, 72);
			this.pictureBoxLogoPicture.Name = "pictureBoxLogoPicture";
			this.pictureBoxLogoPicture.Size = new System.Drawing.Size(144, 88);
			this.pictureBoxLogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxLogoPicture.TabIndex = 216;
			this.pictureBoxLogoPicture.TabStop = false;
			// 
			// FrmModifyLibrarian
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.pictureBoxLogoPicture);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonModify);
			this.Controls.Add(this.textBoxLibrarianName);
			this.Controls.Add(this.labelLibrarianName);
			this.Controls.Add(this.comboBoxLibrarianGroup);
			this.Controls.Add(this.labelLibrarianGroup);
			this.Controls.Add(this.textBoxUserName);
			this.Controls.Add(this.labelUserName);
			this.Controls.Add(this.textBoxLibrarianID);
			this.Controls.Add(this.labelLibrarianID);
			this.Controls.Add(this.buttonSearch);
			this.Controls.Add(this.dataGridModifyLibrarian);
			this.Controls.Add(this.LabelTitle);
			this.Name = "FrmModifyLibrarian";
			this.Load += new System.EventHandler(this.FrmModifyLibrarian_Load);
			this.Controls.SetChildIndex(this.LabelTitle, 0);
			this.Controls.SetChildIndex(this.dataGridModifyLibrarian, 0);
			this.Controls.SetChildIndex(this.buttonSearch, 0);
			this.Controls.SetChildIndex(this.labelLibrarianID, 0);
			this.Controls.SetChildIndex(this.textBoxLibrarianID, 0);
			this.Controls.SetChildIndex(this.labelUserName, 0);
			this.Controls.SetChildIndex(this.textBoxUserName, 0);
			this.Controls.SetChildIndex(this.labelLibrarianGroup, 0);
			this.Controls.SetChildIndex(this.comboBoxLibrarianGroup, 0);
			this.Controls.SetChildIndex(this.labelLibrarianName, 0);
			this.Controls.SetChildIndex(this.textBoxLibrarianName, 0);
			this.Controls.SetChildIndex(this.buttonModify, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.pictureBoxLogoPicture, 0);
			((System.ComponentModel.ISupportInitialize)(this.dataGridModifyLibrarian)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void textBoxLibrarianID_TextChanged(object sender, System.EventArgs e)
		{
			MyLibrarian.LibrarianID = textBoxLibrarianID.Text.ToString();
		}

		private void textBoxUserName_TextChanged(object sender, System.EventArgs e)
		{
			MyLibrarian.UserName = textBoxUserName.Text.ToString();
		}

		private void textBoxLibrarianName_TextChanged(object sender, System.EventArgs e)
		{
			MyLibrarian.LibrarianName = textBoxLibrarianName.Text.ToString();
		}

		private void comboBoxLibrarianGroup_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			MyLibrarian.LibrarianGroup = comboBoxLibrarianGroup.Text.ToString();
		}

		private void buttonSearch_Click(object sender, System.EventArgs e)
		{
			MyClassDatabase = new ClassDatabase();
			MyDataTable = MyClassDatabase.GetLibrarian(MyLibrarian);
			dataGridModifyLibrarian.DataSource = MyDataTable;
			if(MyDataTable.Rows.Count > 0)
				buttonModify.Enabled = true;
			else
				buttonModify.Enabled = false;
		}

		private void FrmModifyLibrarian_Load(object sender, System.EventArgs e)
		{
			MyLibrarian.LibrarianGroup = "All";
		}

		private void buttonModify_Click(object sender, System.EventArgs e)
		{
			
			if(buttonModify.Text.ToString()=="Edit") 
			{
				MyLibrarianForm = new FrmLibrarian(this.MyMDIForm);
				MyLibrarianForm.MdiParent = base.MyMDIForm;
				MyLibrarianForm.MyLibrarian = new Librarian ();
				MyLibrarianForm.textBoxLibrarianID.Text = dataGridModifyLibrarian[dataGridModifyLibrarian.CurrentRowIndex,0].ToString().Trim();
				MyLibrarianForm.textBoxUserName.Text = dataGridModifyLibrarian[dataGridModifyLibrarian.CurrentRowIndex,1].ToString().Trim();
				MyLibrarianForm.textBoxPassword.Text = dataGridModifyLibrarian[dataGridModifyLibrarian.CurrentRowIndex,2].ToString().Trim();
				MyLibrarianForm.textBoxLibrarianName.Text = dataGridModifyLibrarian[dataGridModifyLibrarian.CurrentRowIndex,3].ToString().Trim();
				MyLibrarianForm.comboBoxLibrarianGroup.Text = dataGridModifyLibrarian[dataGridModifyLibrarian.CurrentRowIndex,4].ToString().Trim();
				MyLibrarianForm.textBoxAddress.Text = dataGridModifyLibrarian[dataGridModifyLibrarian.CurrentRowIndex,6].ToString().Trim();
				MyLibrarianForm.textBoxCity.Text = dataGridModifyLibrarian[dataGridModifyLibrarian.CurrentRowIndex,7].ToString().Trim();
				MyLibrarianForm.textBoxPostCode.Text = dataGridModifyLibrarian[dataGridModifyLibrarian.CurrentRowIndex,8].ToString().Trim();
				MyLibrarianForm.textBoxState.Text = dataGridModifyLibrarian[dataGridModifyLibrarian.CurrentRowIndex,9].ToString().Trim();
				MyLibrarianForm.textBoxCountry.Text = dataGridModifyLibrarian[dataGridModifyLibrarian.CurrentRowIndex,10].ToString().Trim();
				MyLibrarianForm.textBoxPhone.Text = dataGridModifyLibrarian[dataGridModifyLibrarian.CurrentRowIndex,11].ToString().Trim();
				MyLibrarianForm.textBoxHandPhone.Text = dataGridModifyLibrarian[dataGridModifyLibrarian.CurrentRowIndex,12].ToString().Trim();
				MyLibrarianForm.textBoxEmail.Text = dataGridModifyLibrarian[dataGridModifyLibrarian.CurrentRowIndex,13].ToString().Trim();
				MyLibrarianForm.textBoxLocationCode.Text = dataGridModifyLibrarian[dataGridModifyLibrarian.CurrentRowIndex,14].ToString().Trim();
				MyLibrarianForm.MyLibrarian.UpdateUser = this.MyMDIForm.LibrarianUserName.ToString();
				MyLibrarianForm.LabelTitle.Text = "    Edit Librarian";
				MyLibrarianForm.buttonSave.Text = "Update";
				MyLibrarianForm.Show();
				this.Close();
				this.Dispose();
			}
			else if(buttonModify.Text.ToString()=="Delete")
			{
				DialogResult ans;
				ans = MessageBox.Show("Are you sure you want to delete Librarian Data with Librarian ID=' "+ dataGridModifyLibrarian[dataGridModifyLibrarian.CurrentRowIndex,0].ToString().Trim() + "' ?" , "Confirmation", MessageBoxButtons.YesNo );
				if (ans.ToString() == "Yes")
				{	
					MyClassDatabase = new ClassDatabase();
					MyClassDatabase.DeleteLibrarian(dataGridModifyLibrarian[dataGridModifyLibrarian.CurrentRowIndex,0].ToString().Trim());
					
					this.Dispose();
				}
				else
				{
				
				}
			}
			else if(buttonModify.Text.ToString()=="Show")
			{
				MyLibrarianForm = new FrmLibrarian(this.MyMDIForm);
				MyLibrarianForm.MdiParent = base.MyMDIForm;
				MyLibrarianForm.MyLibrarian = new Librarian ();
				MyLibrarianForm.textBoxLibrarianID.Text = dataGridModifyLibrarian[dataGridModifyLibrarian.CurrentRowIndex,0].ToString().Trim();
				MyLibrarianForm.textBoxUserName.Text = dataGridModifyLibrarian[dataGridModifyLibrarian.CurrentRowIndex,1].ToString().Trim();
				MyLibrarianForm.textBoxPassword.Text = dataGridModifyLibrarian[dataGridModifyLibrarian.CurrentRowIndex,2].ToString().Trim();
				MyLibrarianForm.textBoxLibrarianName.Text = dataGridModifyLibrarian[dataGridModifyLibrarian.CurrentRowIndex,3].ToString().Trim();
				MyLibrarianForm.comboBoxLibrarianGroup.Text = dataGridModifyLibrarian[dataGridModifyLibrarian.CurrentRowIndex,4].ToString().Trim();
				MyLibrarianForm.textBoxAddress.Text = dataGridModifyLibrarian[dataGridModifyLibrarian.CurrentRowIndex,6].ToString().Trim();
				MyLibrarianForm.textBoxCity.Text = dataGridModifyLibrarian[dataGridModifyLibrarian.CurrentRowIndex,7].ToString().Trim();
				MyLibrarianForm.textBoxPostCode.Text = dataGridModifyLibrarian[dataGridModifyLibrarian.CurrentRowIndex,8].ToString().Trim();
				MyLibrarianForm.textBoxState.Text = dataGridModifyLibrarian[dataGridModifyLibrarian.CurrentRowIndex,9].ToString().Trim();
				MyLibrarianForm.textBoxCountry.Text = dataGridModifyLibrarian[dataGridModifyLibrarian.CurrentRowIndex,10].ToString().Trim();
				MyLibrarianForm.textBoxPhone.Text = dataGridModifyLibrarian[dataGridModifyLibrarian.CurrentRowIndex,11].ToString().Trim();
				MyLibrarianForm.textBoxHandPhone.Text = dataGridModifyLibrarian[dataGridModifyLibrarian.CurrentRowIndex,12].ToString().Trim();
				MyLibrarianForm.textBoxEmail.Text = dataGridModifyLibrarian[dataGridModifyLibrarian.CurrentRowIndex,13].ToString().Trim();
				MyLibrarianForm.textBoxLocationCode.Text = dataGridModifyLibrarian[dataGridModifyLibrarian.CurrentRowIndex,14].ToString().Trim();
				MyLibrarianForm.MyLibrarian.UpdateUser = this.MyMDIForm.LibrarianUserName.ToString();
				MyLibrarianForm.LabelTitle.Text = "    Show Librarian";
				MyLibrarianForm.buttonSave.Visible = false;
				MyLibrarianForm.Show();
			}

			
		}

	}
}

