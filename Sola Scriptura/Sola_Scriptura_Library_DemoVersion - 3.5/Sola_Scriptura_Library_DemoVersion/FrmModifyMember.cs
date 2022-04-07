using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace Sola_Scriptura_Library
{
	public class FrmModifyMember : Sola_Scriptura_Library.FrmFormParent
	{
		internal System.Windows.Forms.Label label1;
		internal System.Windows.Forms.Button buttonModify;
		internal System.Windows.Forms.Label labelLibrarianName;
		internal System.Windows.Forms.Label labelLibrarianGroup;
		internal System.Windows.Forms.Button buttonSearch;
		internal System.Windows.Forms.Label LabelTitle;
		internal System.Windows.Forms.TextBox textBoxMemberName;
		internal System.Windows.Forms.ComboBox comboBoxMemberGroupCode;
		internal System.Windows.Forms.Label labelMemberID;
		internal System.Windows.Forms.DataGrid dataGridModifyMember;
		private System.ComponentModel.IContainer components = null;
		
		internal FrmMember MyMemberForm;
		internal Member MyMember;
		internal ClassDatabase MyClassDatabase;
		internal System.Windows.Forms.TextBox textBoxMemberID;
		internal System.Windows.Forms.DataGridTableStyle dataGridTableStyleMember;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnMemberID;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnMemberName;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnActiveDate;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnMemberGroupCode;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnAddress;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnCity;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnPostCode;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnState;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnCountry;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnPhone;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnHandPhone;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnEmail;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnUpdateUser;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnUpdateDate;
		internal System.Windows.Forms.PictureBox pictureBoxLogoPicture;
		internal DataTable MyDataTable;
	
		public FrmModifyMember()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public FrmModifyMember(FrmMDI MDIForm)
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmModifyMember));
			this.label1 = new System.Windows.Forms.Label();
			this.buttonModify = new System.Windows.Forms.Button();
			this.textBoxMemberName = new System.Windows.Forms.TextBox();
			this.labelLibrarianName = new System.Windows.Forms.Label();
			this.comboBoxMemberGroupCode = new System.Windows.Forms.ComboBox();
			this.labelLibrarianGroup = new System.Windows.Forms.Label();
			this.textBoxMemberID = new System.Windows.Forms.TextBox();
			this.labelMemberID = new System.Windows.Forms.Label();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.dataGridModifyMember = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyleMember = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnMemberID = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnMemberName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnActiveDate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnMemberGroupCode = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnAddress = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnCity = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnPostCode = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnState = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnCountry = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnPhone = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnHandPhone = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnEmail = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnUpdateUser = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnUpdateDate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.LabelTitle = new System.Windows.Forms.Label();
			this.pictureBoxLogoPicture = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridModifyMember)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label1.Location = new System.Drawing.Point(240, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(656, 24);
			this.label1.TabIndex = 117;
			this.label1.Text = "Please enter the required fields, then click Search";
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
			this.buttonModify.TabIndex = 110;
			this.buttonModify.Text = "Modify";
			this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
			// 
			// textBoxMemberName
			// 
			this.textBoxMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxMemberName.Location = new System.Drawing.Point(368, 136);
			this.textBoxMemberName.Name = "textBoxMemberName";
			this.textBoxMemberName.Size = new System.Drawing.Size(200, 22);
			this.textBoxMemberName.TabIndex = 107;
			this.textBoxMemberName.Text = "";
			this.textBoxMemberName.TextChanged += new System.EventHandler(this.textBoxMemberName_TextChanged);
			// 
			// labelLibrarianName
			// 
			this.labelLibrarianName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelLibrarianName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelLibrarianName.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelLibrarianName.Location = new System.Drawing.Point(240, 136);
			this.labelLibrarianName.Name = "labelLibrarianName";
			this.labelLibrarianName.Size = new System.Drawing.Size(120, 24);
			this.labelLibrarianName.TabIndex = 116;
			this.labelLibrarianName.Text = "Member Name";
			// 
			// comboBoxMemberGroupCode
			// 
			this.comboBoxMemberGroupCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.comboBoxMemberGroupCode.Items.AddRange(new object[] {
																		 "All",
																		 "Student",
																		 "Lecturer"});
			this.comboBoxMemberGroupCode.Location = new System.Drawing.Point(704, 136);
			this.comboBoxMemberGroupCode.Name = "comboBoxMemberGroupCode";
			this.comboBoxMemberGroupCode.Size = new System.Drawing.Size(200, 24);
			this.comboBoxMemberGroupCode.TabIndex = 108;
			this.comboBoxMemberGroupCode.Text = "All";
			this.comboBoxMemberGroupCode.SelectedIndexChanged += new System.EventHandler(this.comboBoxMemberGroupCode_SelectedIndexChanged);
			// 
			// labelLibrarianGroup
			// 
			this.labelLibrarianGroup.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelLibrarianGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelLibrarianGroup.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelLibrarianGroup.Location = new System.Drawing.Point(576, 136);
			this.labelLibrarianGroup.Name = "labelLibrarianGroup";
			this.labelLibrarianGroup.Size = new System.Drawing.Size(136, 24);
			this.labelLibrarianGroup.TabIndex = 115;
			this.labelLibrarianGroup.Text = "Group Code";
			// 
			// textBoxMemberID
			// 
			this.textBoxMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxMemberID.Location = new System.Drawing.Point(368, 104);
			this.textBoxMemberID.Name = "textBoxMemberID";
			this.textBoxMemberID.Size = new System.Drawing.Size(200, 22);
			this.textBoxMemberID.TabIndex = 105;
			this.textBoxMemberID.Text = "";
			this.textBoxMemberID.TextChanged += new System.EventHandler(this.textBoxMemberID_TextChanged);
			// 
			// labelMemberID
			// 
			this.labelMemberID.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelMemberID.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelMemberID.Location = new System.Drawing.Point(240, 104);
			this.labelMemberID.Name = "labelMemberID";
			this.labelMemberID.Size = new System.Drawing.Size(120, 24);
			this.labelMemberID.TabIndex = 113;
			this.labelMemberID.Text = "Member ID";
			// 
			// buttonSearch
			// 
			this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonSearch.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearch.Image")));
			this.buttonSearch.Location = new System.Drawing.Point(768, 168);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(136, 32);
			this.buttonSearch.TabIndex = 109;
			this.buttonSearch.Text = "Search";
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// dataGridModifyMember
			// 
			this.dataGridModifyMember.DataMember = "";
			this.dataGridModifyMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGridModifyMember.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridModifyMember.Location = new System.Drawing.Point(248, 208);
			this.dataGridModifyMember.Name = "dataGridModifyMember";
			this.dataGridModifyMember.ReadOnly = true;
			this.dataGridModifyMember.Size = new System.Drawing.Size(656, 336);
			this.dataGridModifyMember.TabIndex = 112;
			this.dataGridModifyMember.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																											 this.dataGridTableStyleMember});
			// 
			// dataGridTableStyleMember
			// 
			this.dataGridTableStyleMember.AlternatingBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleMember.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.dataGridTableStyleMember.DataGrid = this.dataGridModifyMember;
			this.dataGridTableStyleMember.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleMember.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																													   this.dataGridTextBoxColumnMemberID,
																													   this.dataGridTextBoxColumnMemberName,
																													   this.dataGridTextBoxColumnActiveDate,
																													   this.dataGridTextBoxColumnMemberGroupCode,
																													   this.dataGridTextBoxColumnAddress,
																													   this.dataGridTextBoxColumnCity,
																													   this.dataGridTextBoxColumnPostCode,
																													   this.dataGridTextBoxColumnState,
																													   this.dataGridTextBoxColumnCountry,
																													   this.dataGridTextBoxColumnPhone,
																													   this.dataGridTextBoxColumnHandPhone,
																													   this.dataGridTextBoxColumnEmail,
																													   this.dataGridTextBoxColumnUpdateUser,
																													   this.dataGridTextBoxColumnUpdateDate});
			this.dataGridTableStyleMember.GridLineColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridTableStyleMember.HeaderBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleMember.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleMember.MappingName = "Member";
			// 
			// dataGridTextBoxColumnMemberID
			// 
			this.dataGridTextBoxColumnMemberID.Format = "";
			this.dataGridTextBoxColumnMemberID.FormatInfo = null;
			this.dataGridTextBoxColumnMemberID.HeaderText = "Member ID";
			this.dataGridTextBoxColumnMemberID.MappingName = "MemberID";
			this.dataGridTextBoxColumnMemberID.Width = 101;
			// 
			// dataGridTextBoxColumnMemberName
			// 
			this.dataGridTextBoxColumnMemberName.Format = "";
			this.dataGridTextBoxColumnMemberName.FormatInfo = null;
			this.dataGridTextBoxColumnMemberName.HeaderText = "Member Name";
			this.dataGridTextBoxColumnMemberName.MappingName = "MemberName";
			this.dataGridTextBoxColumnMemberName.Width = 200;
			// 
			// dataGridTextBoxColumnActiveDate
			// 
			this.dataGridTextBoxColumnActiveDate.Format = "";
			this.dataGridTextBoxColumnActiveDate.FormatInfo = null;
			this.dataGridTextBoxColumnActiveDate.HeaderText = "Active Date";
			this.dataGridTextBoxColumnActiveDate.MappingName = "ActiveDate";
			this.dataGridTextBoxColumnActiveDate.Width = 75;
			// 
			// dataGridTextBoxColumnMemberGroupCode
			// 
			this.dataGridTextBoxColumnMemberGroupCode.Format = "";
			this.dataGridTextBoxColumnMemberGroupCode.FormatInfo = null;
			this.dataGridTextBoxColumnMemberGroupCode.HeaderText = "Group Code";
			this.dataGridTextBoxColumnMemberGroupCode.MappingName = "MemberGroupCode";
			this.dataGridTextBoxColumnMemberGroupCode.Width = 75;
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
			this.LabelTitle.TabIndex = 111;
			this.LabelTitle.Text = "    Title";
			this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			// FrmModifyMember
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.pictureBoxLogoPicture);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonModify);
			this.Controls.Add(this.textBoxMemberName);
			this.Controls.Add(this.labelLibrarianName);
			this.Controls.Add(this.comboBoxMemberGroupCode);
			this.Controls.Add(this.labelLibrarianGroup);
			this.Controls.Add(this.textBoxMemberID);
			this.Controls.Add(this.labelMemberID);
			this.Controls.Add(this.buttonSearch);
			this.Controls.Add(this.dataGridModifyMember);
			this.Controls.Add(this.LabelTitle);
			this.Name = "FrmModifyMember";
			this.Load += new System.EventHandler(this.FrmModifyMember_Load);
			this.Controls.SetChildIndex(this.LabelTitle, 0);
			this.Controls.SetChildIndex(this.dataGridModifyMember, 0);
			this.Controls.SetChildIndex(this.buttonSearch, 0);
			this.Controls.SetChildIndex(this.labelMemberID, 0);
			this.Controls.SetChildIndex(this.textBoxMemberID, 0);
			this.Controls.SetChildIndex(this.labelLibrarianGroup, 0);
			this.Controls.SetChildIndex(this.comboBoxMemberGroupCode, 0);
			this.Controls.SetChildIndex(this.labelLibrarianName, 0);
			this.Controls.SetChildIndex(this.textBoxMemberName, 0);
			this.Controls.SetChildIndex(this.buttonModify, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.pictureBoxLogoPicture, 0);
			((System.ComponentModel.ISupportInitialize)(this.dataGridModifyMember)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void textBoxMemberID_TextChanged(object sender, System.EventArgs e)
		{
			MyMember.MemberID = textBoxMemberID.Text.ToString();
		}

		private void textBoxMemberName_TextChanged(object sender, System.EventArgs e)
		{
			MyMember.MemberName = textBoxMemberName.Text.ToString();
		}

		private void comboBoxMemberGroupCode_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			MyMember.MemberGroupCode = comboBoxMemberGroupCode.Text.ToString();
		}

		private void buttonSearch_Click(object sender, System.EventArgs e)
		{
			MyClassDatabase = new ClassDatabase();
			MyDataTable = MyClassDatabase.GetMember(MyMember);
			dataGridModifyMember.DataSource = MyDataTable;
			if(MyDataTable.Rows.Count>0)
				buttonModify.Enabled = true;
			else
				buttonModify.Enabled = false;
		}

		private void FrmModifyMember_Load(object sender, System.EventArgs e)
		{
			MyMember.MemberGroupCode = "All";
		}

		private void buttonModify_Click(object sender, System.EventArgs e)
		{
			if(buttonModify.Text.ToString()=="Edit") 
			{
				MyMemberForm = new FrmMember(this.MyMDIForm);
				MyMemberForm.MdiParent = base.MyMDIForm;
				MyMemberForm.MyMember = new Member ();
				MyMemberForm.textBoxMemberID.Text = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,0].ToString().Trim();
				MyMemberForm.textBoxMemberName.Text = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,1].ToString().Trim();
				MyMemberForm.comboBoxMemberGroupCode.Text = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,3].ToString().Trim();
				MyMemberForm.textBoxAddress.Text = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,4].ToString().Trim();
				MyMemberForm.textBoxCity.Text = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,5].ToString().Trim();
				MyMemberForm.textBoxPostCode.Text = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,6].ToString().Trim();
				MyMemberForm.textBoxState.Text = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,7].ToString().Trim();
				MyMemberForm.textBoxCountry.Text = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,8].ToString().Trim();
				MyMemberForm.textBoxPhone.Text = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,9].ToString().Trim();
				MyMemberForm.textBoxHandPhone.Text = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,10].ToString().Trim();
				MyMemberForm.textBoxEmail.Text = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,11].ToString().Trim();
				MyMemberForm.MyMember.UpdateUser = this.MyMDIForm.LibrarianUserName.ToString();
				MyMemberForm.LabelTitle.Text = "    Edit Member";
				MyMemberForm.buttonSave.Text = "Update";
				MyMemberForm.Show();
				this.Close();
				this.Dispose();
			}
			else if(buttonModify.Text.ToString()=="Delete")
			{
				DialogResult ans;
				ans = MessageBox.Show("Are you sure you want to delete Member Data with Member ID=' "+ dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,0].ToString().Trim() + "' ?" , "Confirmation", MessageBoxButtons.YesNo );
				if (ans.ToString() == "Yes")
				{	
					MyClassDatabase = new ClassDatabase();
					MyClassDatabase.DeleteMember(dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,0].ToString().Trim());
					
					this.Dispose();
				}
				else
				{
				
				}
			}
			else if(buttonModify.Text.ToString()=="Show")
			{
				MyMemberForm = new FrmMember(this.MyMDIForm);
				MyMemberForm.MdiParent = base.MyMDIForm;
				MyMemberForm.MyMember = new Member ();
				MyMemberForm.textBoxMemberID.Text = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,0].ToString().Trim();
				MyMemberForm.textBoxMemberName.Text = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,1].ToString().Trim();
				MyMemberForm.comboBoxMemberGroupCode.Text = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,3].ToString().Trim();
				MyMemberForm.textBoxAddress.Text = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,4].ToString().Trim();
				MyMemberForm.textBoxCity.Text = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,5].ToString().Trim();
				MyMemberForm.textBoxPostCode.Text = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,6].ToString().Trim();
				MyMemberForm.textBoxState.Text = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,7].ToString().Trim();
				MyMemberForm.textBoxCountry.Text = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,8].ToString().Trim();
				MyMemberForm.textBoxPhone.Text = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,9].ToString().Trim();
				MyMemberForm.textBoxHandPhone.Text = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,10].ToString().Trim();
				MyMemberForm.textBoxEmail.Text = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,11].ToString().Trim();
				MyMemberForm.MyMember.UpdateUser = this.MyMDIForm.LibrarianUserName.ToString();
				MyMemberForm.LabelTitle.Text = "    Show Member";
				MyMemberForm.buttonSave.Visible = false;
				MyMemberForm.Show();
			}
		}


	}
}

