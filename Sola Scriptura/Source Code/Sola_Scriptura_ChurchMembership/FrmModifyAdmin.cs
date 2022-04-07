using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace Sola_Scriptura_ChurchMembership
{
	public class FrmModifyAdmin : Sola_Scriptura_ChurchMembership.FrmFormParent
	{
		internal System.Windows.Forms.Label LabelTitle;
		internal System.Windows.Forms.TextBox textBoxUserName;
		internal System.Windows.Forms.Label labelUserName;
		internal System.Windows.Forms.Button buttonSearch;
		internal System.Windows.Forms.Button buttonModify;
		internal System.Windows.Forms.Label label1;
		private System.ComponentModel.IContainer components = null;

		internal Administrator MyAdmin;
		internal ClassDatabase MyClassDatabase;
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
		internal System.Windows.Forms.ComboBox comboBoxAdminGroup;
		internal System.Windows.Forms.Label labelAdminGroup;
		internal System.Windows.Forms.TextBox textBoxAdminID;
		internal System.Windows.Forms.Label labelAdminID;
		internal System.Windows.Forms.TextBox textBoxAdminName;
		internal System.Windows.Forms.Label labeAdminName;
		internal System.Windows.Forms.DataGrid dataGridModifyAdmin;
		internal System.Windows.Forms.DataGridTableStyle dataGridTableStyleAdmin;
		
		internal FrmAddAdmin MyAddAdminForm;

		public FrmModifyAdmin()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public FrmModifyAdmin(FrmMDI MDIForm)
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmModifyAdmin));
			this.LabelTitle = new System.Windows.Forms.Label();
			this.dataGridModifyAdmin = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyleAdmin = new System.Windows.Forms.DataGridTableStyle();
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
			this.comboBoxAdminGroup = new System.Windows.Forms.ComboBox();
			this.labelAdminGroup = new System.Windows.Forms.Label();
			this.textBoxUserName = new System.Windows.Forms.TextBox();
			this.labelUserName = new System.Windows.Forms.Label();
			this.textBoxAdminID = new System.Windows.Forms.TextBox();
			this.labelAdminID = new System.Windows.Forms.Label();
			this.textBoxAdminName = new System.Windows.Forms.TextBox();
			this.labeAdminName = new System.Windows.Forms.Label();
			this.buttonModify = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBoxLogoPicture = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridModifyAdmin)).BeginInit();
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
			// dataGridModifyAdmin
			// 
			this.dataGridModifyAdmin.DataMember = "";
			this.dataGridModifyAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGridModifyAdmin.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridModifyAdmin.Location = new System.Drawing.Point(248, 208);
			this.dataGridModifyAdmin.Name = "dataGridModifyAdmin";
			this.dataGridModifyAdmin.ReadOnly = true;
			this.dataGridModifyAdmin.Size = new System.Drawing.Size(656, 336);
			this.dataGridModifyAdmin.TabIndex = 65;
			this.dataGridModifyAdmin.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																											this.dataGridTableStyleAdmin});
			// 
			// dataGridTableStyleAdmin
			// 
			this.dataGridTableStyleAdmin.AlternatingBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleAdmin.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.dataGridTableStyleAdmin.DataGrid = this.dataGridModifyAdmin;
			this.dataGridTableStyleAdmin.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleAdmin.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
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
			this.dataGridTableStyleAdmin.GridLineColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridTableStyleAdmin.HeaderBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleAdmin.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleAdmin.MappingName = "Admin";
			this.dataGridTableStyleAdmin.ReadOnly = true;
			// 
			// dataGridTextBoxColumnLibrarianID
			// 
			this.dataGridTextBoxColumnLibrarianID.Format = "";
			this.dataGridTextBoxColumnLibrarianID.FormatInfo = null;
			this.dataGridTextBoxColumnLibrarianID.HeaderText = "AdminID";
			this.dataGridTextBoxColumnLibrarianID.MappingName = "AdminID";
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
			this.dataGridTextBoxColumnLibrarianName.HeaderText = "Admin Name";
			this.dataGridTextBoxColumnLibrarianName.MappingName = "AdminName";
			this.dataGridTextBoxColumnLibrarianName.Width = 75;
			// 
			// dataGridTextBoxColumnLibrarianGroup
			// 
			this.dataGridTextBoxColumnLibrarianGroup.Format = "";
			this.dataGridTextBoxColumnLibrarianGroup.FormatInfo = null;
			this.dataGridTextBoxColumnLibrarianGroup.HeaderText = "Admin Group";
			this.dataGridTextBoxColumnLibrarianGroup.MappingName = "AdminGroup";
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
			// comboBoxAdminGroup
			// 
			this.comboBoxAdminGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.comboBoxAdminGroup.Items.AddRange(new object[] {
																	"All",
																	"Administrator",
																	"User"});
			this.comboBoxAdminGroup.Location = new System.Drawing.Point(704, 136);
			this.comboBoxAdminGroup.Name = "comboBoxAdminGroup";
			this.comboBoxAdminGroup.Size = new System.Drawing.Size(200, 24);
			this.comboBoxAdminGroup.TabIndex = 4;
			this.comboBoxAdminGroup.Text = "All";
			this.comboBoxAdminGroup.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdminGroup_SelectedIndexChanged);
			// 
			// labelAdminGroup
			// 
			this.labelAdminGroup.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelAdminGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelAdminGroup.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelAdminGroup.Location = new System.Drawing.Point(576, 136);
			this.labelAdminGroup.Name = "labelAdminGroup";
			this.labelAdminGroup.Size = new System.Drawing.Size(120, 24);
			this.labelAdminGroup.TabIndex = 101;
			this.labelAdminGroup.Text = "Admin Group";
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
			// textBoxAdminID
			// 
			this.textBoxAdminID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxAdminID.Location = new System.Drawing.Point(368, 104);
			this.textBoxAdminID.Name = "textBoxAdminID";
			this.textBoxAdminID.Size = new System.Drawing.Size(200, 22);
			this.textBoxAdminID.TabIndex = 1;
			this.textBoxAdminID.Text = "";
			this.textBoxAdminID.TextChanged += new System.EventHandler(this.textBoxAdminID_TextChanged);
			// 
			// labelAdminID
			// 
			this.labelAdminID.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelAdminID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelAdminID.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelAdminID.Location = new System.Drawing.Point(240, 104);
			this.labelAdminID.Name = "labelAdminID";
			this.labelAdminID.Size = new System.Drawing.Size(120, 24);
			this.labelAdminID.TabIndex = 98;
			this.labelAdminID.Text = "Admin ID";
			// 
			// textBoxAdminName
			// 
			this.textBoxAdminName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxAdminName.Location = new System.Drawing.Point(368, 136);
			this.textBoxAdminName.Name = "textBoxAdminName";
			this.textBoxAdminName.Size = new System.Drawing.Size(200, 22);
			this.textBoxAdminName.TabIndex = 3;
			this.textBoxAdminName.Text = "";
			this.textBoxAdminName.TextChanged += new System.EventHandler(this.textBoxAdminName_TextChanged);
			// 
			// labeAdminName
			// 
			this.labeAdminName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labeAdminName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labeAdminName.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labeAdminName.Location = new System.Drawing.Point(240, 136);
			this.labeAdminName.Name = "labeAdminName";
			this.labeAdminName.Size = new System.Drawing.Size(120, 24);
			this.labeAdminName.TabIndex = 103;
			this.labeAdminName.Text = "Admin Name";
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
			// FrmModifyAdmin
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.pictureBoxLogoPicture);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonModify);
			this.Controls.Add(this.textBoxAdminName);
			this.Controls.Add(this.labeAdminName);
			this.Controls.Add(this.comboBoxAdminGroup);
			this.Controls.Add(this.labelAdminGroup);
			this.Controls.Add(this.textBoxUserName);
			this.Controls.Add(this.labelUserName);
			this.Controls.Add(this.textBoxAdminID);
			this.Controls.Add(this.labelAdminID);
			this.Controls.Add(this.buttonSearch);
			this.Controls.Add(this.dataGridModifyAdmin);
			this.Controls.Add(this.LabelTitle);
			this.Name = "FrmModifyAdmin";
			this.Load += new System.EventHandler(this.FrmModifyAdmin_Load);
			this.Controls.SetChildIndex(this.LabelTitle, 0);
			this.Controls.SetChildIndex(this.dataGridModifyAdmin, 0);
			this.Controls.SetChildIndex(this.buttonSearch, 0);
			this.Controls.SetChildIndex(this.labelAdminID, 0);
			this.Controls.SetChildIndex(this.textBoxAdminID, 0);
			this.Controls.SetChildIndex(this.labelUserName, 0);
			this.Controls.SetChildIndex(this.textBoxUserName, 0);
			this.Controls.SetChildIndex(this.labelAdminGroup, 0);
			this.Controls.SetChildIndex(this.comboBoxAdminGroup, 0);
			this.Controls.SetChildIndex(this.labeAdminName, 0);
			this.Controls.SetChildIndex(this.textBoxAdminName, 0);
			this.Controls.SetChildIndex(this.buttonModify, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.pictureBoxLogoPicture, 0);
			((System.ComponentModel.ISupportInitialize)(this.dataGridModifyAdmin)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void textBoxAdminID_TextChanged(object sender, System.EventArgs e)
		{
			MyAdmin.AdminID = textBoxAdminID.Text.ToString();
		}

		private void textBoxUserName_TextChanged(object sender, System.EventArgs e)
		{
			MyAdmin.UserName = textBoxUserName.Text.ToString();
		}

		private void textBoxAdminName_TextChanged(object sender, System.EventArgs e)
		{
			MyAdmin.AdminName = textBoxAdminName.Text.ToString();
		}

		private void comboBoxAdminGroup_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			MyAdmin.AdminGroup = comboBoxAdminGroup.Text.ToString();
		}

		private void buttonSearch_Click(object sender, System.EventArgs e)
		{
			MyClassDatabase = new ClassDatabase();
			MyDataTable = MyClassDatabase.GetAdmin(MyAdmin);
			dataGridModifyAdmin.DataSource = MyDataTable;
			if(MyDataTable.Rows.Count > 0)
				buttonModify.Enabled = true;
			else
				buttonModify.Enabled = false;
		}

		private void FrmModifyAdmin_Load(object sender, System.EventArgs e)
		{
			MyAdmin.AdminGroup = "All";
		}

		private void buttonModify_Click(object sender, System.EventArgs e)
		{
			
			if(buttonModify.Text.ToString()=="Edit") 
			{
				MyAddAdminForm = new FrmAddAdmin(this.MyMDIForm);
				MyAddAdminForm.MdiParent = base.MyMDIForm;
				MyAddAdminForm.MyAdmin = new Administrator ();
				MyAddAdminForm.textBoxAdminID.Text = dataGridModifyAdmin[dataGridModifyAdmin.CurrentRowIndex,0].ToString().Trim();
				MyAddAdminForm.textBoxUserName.Text = dataGridModifyAdmin[dataGridModifyAdmin.CurrentRowIndex,1].ToString().Trim();
				MyAddAdminForm.textBoxPassword.Text = dataGridModifyAdmin[dataGridModifyAdmin.CurrentRowIndex,2].ToString().Trim();
				MyAddAdminForm.textBoxAdminName.Text = dataGridModifyAdmin[dataGridModifyAdmin.CurrentRowIndex,3].ToString().Trim();
				MyAddAdminForm.comboBoxAdminGroup.Text = dataGridModifyAdmin[dataGridModifyAdmin.CurrentRowIndex,4].ToString().Trim();
				MyAddAdminForm.textBoxAddress.Text = dataGridModifyAdmin[dataGridModifyAdmin.CurrentRowIndex,6].ToString().Trim();
				MyAddAdminForm.textBoxCity.Text = dataGridModifyAdmin[dataGridModifyAdmin.CurrentRowIndex,7].ToString().Trim();
				MyAddAdminForm.textBoxPostCode.Text = dataGridModifyAdmin[dataGridModifyAdmin.CurrentRowIndex,8].ToString().Trim();
				MyAddAdminForm.textBoxState.Text = dataGridModifyAdmin[dataGridModifyAdmin.CurrentRowIndex,9].ToString().Trim();
				MyAddAdminForm.textBoxCountry.Text = dataGridModifyAdmin[dataGridModifyAdmin.CurrentRowIndex,10].ToString().Trim();
				MyAddAdminForm.textBoxPhone.Text = dataGridModifyAdmin[dataGridModifyAdmin.CurrentRowIndex,11].ToString().Trim();
				MyAddAdminForm.textBoxHandPhone.Text = dataGridModifyAdmin[dataGridModifyAdmin.CurrentRowIndex,12].ToString().Trim();
				MyAddAdminForm.textBoxEmail.Text = dataGridModifyAdmin[dataGridModifyAdmin.CurrentRowIndex,13].ToString().Trim();
				MyAddAdminForm.textBoxLocationCode.Text = dataGridModifyAdmin[dataGridModifyAdmin.CurrentRowIndex,14].ToString().Trim();
				MyAddAdminForm.MyAdmin.UpdateUser = this.MyMDIForm.AdminUserName.ToString();
				MyAddAdminForm.LabelTitle.Text = "    Edit Admin";
				MyAddAdminForm.buttonSave.Text = "Update";
				MyAddAdminForm.Show();
				this.Close();
				this.Dispose();
			}
			else if(buttonModify.Text.ToString()=="Delete")
			{
				DialogResult ans;
				ans = MessageBox.Show("Are you sure you want to delete Admin Data with Admin ID=' "+ dataGridModifyAdmin[dataGridModifyAdmin.CurrentRowIndex,0].ToString().Trim() + "' ?" , "Confirmation", MessageBoxButtons.YesNo );
				if (ans.ToString() == "Yes")
				{	
					MyClassDatabase = new ClassDatabase();
					MyClassDatabase.DeleteAdmin(dataGridModifyAdmin[dataGridModifyAdmin.CurrentRowIndex,0].ToString().Trim());
					
					this.Dispose();
				}
				else
				{
				
				}
			}
			else if(buttonModify.Text.ToString()=="Show")
			{
				MyAddAdminForm = new FrmAddAdmin(this.MyMDIForm);
				MyAddAdminForm.MdiParent = base.MyMDIForm;
				MyAddAdminForm.MyAdmin = new  Administrator ();
				MyAddAdminForm.textBoxAdminID.Text = dataGridModifyAdmin[dataGridModifyAdmin.CurrentRowIndex,0].ToString().Trim();
				MyAddAdminForm.textBoxUserName.Text = dataGridModifyAdmin[dataGridModifyAdmin.CurrentRowIndex,1].ToString().Trim();
				MyAddAdminForm.textBoxPassword.Text = dataGridModifyAdmin[dataGridModifyAdmin.CurrentRowIndex,2].ToString().Trim();
				MyAddAdminForm.textBoxAdminName.Text = dataGridModifyAdmin[dataGridModifyAdmin.CurrentRowIndex,3].ToString().Trim();
				MyAddAdminForm.comboBoxAdminGroup.Text = dataGridModifyAdmin[dataGridModifyAdmin.CurrentRowIndex,4].ToString().Trim();
				MyAddAdminForm.textBoxAddress.Text = dataGridModifyAdmin[dataGridModifyAdmin.CurrentRowIndex,6].ToString().Trim();
				MyAddAdminForm.textBoxCity.Text = dataGridModifyAdmin[dataGridModifyAdmin.CurrentRowIndex,7].ToString().Trim();
				MyAddAdminForm.textBoxPostCode.Text = dataGridModifyAdmin[dataGridModifyAdmin.CurrentRowIndex,8].ToString().Trim();
				MyAddAdminForm.textBoxState.Text = dataGridModifyAdmin[dataGridModifyAdmin.CurrentRowIndex,9].ToString().Trim();
				MyAddAdminForm.textBoxCountry.Text = dataGridModifyAdmin[dataGridModifyAdmin.CurrentRowIndex,10].ToString().Trim();
				MyAddAdminForm.textBoxPhone.Text = dataGridModifyAdmin[dataGridModifyAdmin.CurrentRowIndex,11].ToString().Trim();
				MyAddAdminForm.textBoxHandPhone.Text = dataGridModifyAdmin[dataGridModifyAdmin.CurrentRowIndex,12].ToString().Trim();
				MyAddAdminForm.textBoxEmail.Text = dataGridModifyAdmin[dataGridModifyAdmin.CurrentRowIndex,13].ToString().Trim();
				MyAddAdminForm.textBoxLocationCode.Text = dataGridModifyAdmin[dataGridModifyAdmin.CurrentRowIndex,14].ToString().Trim();
				MyAddAdminForm.MyAdmin.UpdateUser = this.MyMDIForm.AdminUserName.ToString();
				MyAddAdminForm.LabelTitle.Text = "    Show Admin";
				MyAddAdminForm.buttonSave.Visible = false;
				MyAddAdminForm.Show();
			}

			
		}

	}
}

