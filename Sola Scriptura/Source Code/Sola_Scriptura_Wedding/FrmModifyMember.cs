using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace Sola_Scriptura_Wedding
{
	public class FrmModifyMember : Sola_Scriptura_Wedding.FrmFormParent
	{
		internal System.Windows.Forms.Label label1;
		internal System.Windows.Forms.Button buttonModify;
		internal System.Windows.Forms.Label labelLibrarianName;
		internal System.Windows.Forms.Button buttonSearch;
		internal System.Windows.Forms.Label LabelTitle;
		internal System.Windows.Forms.TextBox textBoxMemberName;
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
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnAddress;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnPostCode;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnPhone;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnHandPhone;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnEmail;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnUpdateUser;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnUpdateDate;
		internal System.Windows.Forms.PictureBox pictureBoxLogoPicture;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnParticipate;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnRole;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnCategory;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnRelationTo;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnPlaceDateBirth;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnRegion;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnIsComing;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnMessengerID;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnReligion;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnChurchMember;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnComments;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnTotalperson;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnPhotoPath;
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
			this.textBoxMemberID = new System.Windows.Forms.TextBox();
			this.labelMemberID = new System.Windows.Forms.Label();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.dataGridModifyMember = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyleMember = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnMemberID = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnMemberName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnPlaceDateBirth = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnAddress = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnRegion = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnPostCode = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnPhone = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnHandPhone = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnEmail = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnMessengerID = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnReligion = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnChurchMember = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnComments = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnParticipate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnRole = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnCategory = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnRelationTo = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnIsComing = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnTotalperson = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnPhotoPath = new System.Windows.Forms.DataGridTextBoxColumn();
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
			this.textBoxMemberName.Size = new System.Drawing.Size(536, 22);
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
			this.labelLibrarianName.Text = "Keywords ( Any )";
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
			// dataGridTextBoxColumnPlaceDateBirth
			// 
			this.dataGridTextBoxColumnPlaceDateBirth.Format = "";
			this.dataGridTextBoxColumnPlaceDateBirth.FormatInfo = null;
			this.dataGridTextBoxColumnPlaceDateBirth.HeaderText = "PlaceDateBirth";
			this.dataGridTextBoxColumnPlaceDateBirth.MappingName = "PlaceDateBirth";
			this.dataGridTextBoxColumnPlaceDateBirth.Width = 75;
			// 
			// dataGridTextBoxColumnAddress
			// 
			this.dataGridTextBoxColumnAddress.Format = "";
			this.dataGridTextBoxColumnAddress.FormatInfo = null;
			this.dataGridTextBoxColumnAddress.HeaderText = "Address";
			this.dataGridTextBoxColumnAddress.MappingName = "Address";
			this.dataGridTextBoxColumnAddress.Width = 75;
			// 
			// dataGridTextBoxColumnRegion
			// 
			this.dataGridTextBoxColumnRegion.Format = "";
			this.dataGridTextBoxColumnRegion.FormatInfo = null;
			this.dataGridTextBoxColumnRegion.HeaderText = "Region";
			this.dataGridTextBoxColumnRegion.MappingName = "Region";
			this.dataGridTextBoxColumnRegion.Width = 75;
			// 
			// dataGridTextBoxColumnPostCode
			// 
			this.dataGridTextBoxColumnPostCode.Format = "";
			this.dataGridTextBoxColumnPostCode.FormatInfo = null;
			this.dataGridTextBoxColumnPostCode.HeaderText = "PostCode";
			this.dataGridTextBoxColumnPostCode.MappingName = "PostCode";
			this.dataGridTextBoxColumnPostCode.Width = 75;
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
			// dataGridTextBoxColumnMessengerID
			// 
			this.dataGridTextBoxColumnMessengerID.Format = "";
			this.dataGridTextBoxColumnMessengerID.FormatInfo = null;
			this.dataGridTextBoxColumnMessengerID.HeaderText = "MessengerID";
			this.dataGridTextBoxColumnMessengerID.MappingName = "MessengerID";
			this.dataGridTextBoxColumnMessengerID.Width = 75;
			// 
			// dataGridTextBoxColumnReligion
			// 
			this.dataGridTextBoxColumnReligion.Format = "";
			this.dataGridTextBoxColumnReligion.FormatInfo = null;
			this.dataGridTextBoxColumnReligion.HeaderText = "Religion";
			this.dataGridTextBoxColumnReligion.MappingName = "Religion";
			this.dataGridTextBoxColumnReligion.Width = 75;
			// 
			// dataGridTextBoxColumnChurchMember
			// 
			this.dataGridTextBoxColumnChurchMember.Format = "";
			this.dataGridTextBoxColumnChurchMember.FormatInfo = null;
			this.dataGridTextBoxColumnChurchMember.HeaderText = "ChurchMember";
			this.dataGridTextBoxColumnChurchMember.MappingName = "ChurchMember";
			this.dataGridTextBoxColumnChurchMember.Width = 75;
			// 
			// dataGridTextBoxColumnComments
			// 
			this.dataGridTextBoxColumnComments.Format = "";
			this.dataGridTextBoxColumnComments.FormatInfo = null;
			this.dataGridTextBoxColumnComments.HeaderText = "Comments";
			this.dataGridTextBoxColumnComments.MappingName = "Comments";
			this.dataGridTextBoxColumnComments.Width = 75;
			// 
			// dataGridTextBoxColumnParticipate
			// 
			this.dataGridTextBoxColumnParticipate.Format = "";
			this.dataGridTextBoxColumnParticipate.FormatInfo = null;
			this.dataGridTextBoxColumnParticipate.HeaderText = "Participate";
			this.dataGridTextBoxColumnParticipate.MappingName = "Participate";
			this.dataGridTextBoxColumnParticipate.Width = 75;
			// 
			// dataGridTextBoxColumnRole
			// 
			this.dataGridTextBoxColumnRole.Format = "";
			this.dataGridTextBoxColumnRole.FormatInfo = null;
			this.dataGridTextBoxColumnRole.HeaderText = "In Church";
			this.dataGridTextBoxColumnRole.MappingName = "Role";
			this.dataGridTextBoxColumnRole.Width = 75;
			// 
			// dataGridTextBoxColumnCategory
			// 
			this.dataGridTextBoxColumnCategory.Format = "";
			this.dataGridTextBoxColumnCategory.FormatInfo = null;
			this.dataGridTextBoxColumnCategory.HeaderText = "Category";
			this.dataGridTextBoxColumnCategory.MappingName = "Category";
			this.dataGridTextBoxColumnCategory.Width = 75;
			// 
			// dataGridTextBoxColumnRelationTo
			// 
			this.dataGridTextBoxColumnRelationTo.Format = "";
			this.dataGridTextBoxColumnRelationTo.FormatInfo = null;
			this.dataGridTextBoxColumnRelationTo.MappingName = "";
			this.dataGridTextBoxColumnRelationTo.Width = -1;
			// 
			// dataGridTextBoxColumnIsComing
			// 
			this.dataGridTextBoxColumnIsComing.Format = "";
			this.dataGridTextBoxColumnIsComing.FormatInfo = null;
			this.dataGridTextBoxColumnIsComing.HeaderText = "IsComing";
			this.dataGridTextBoxColumnIsComing.MappingName = "IsComing";
			this.dataGridTextBoxColumnIsComing.Width = 75;
			// 
			// dataGridTextBoxColumnTotalperson
			// 
			this.dataGridTextBoxColumnTotalperson.Format = "";
			this.dataGridTextBoxColumnTotalperson.FormatInfo = null;
			this.dataGridTextBoxColumnTotalperson.HeaderText = "Totalperson";
			this.dataGridTextBoxColumnTotalperson.MappingName = "Totalperson";
			this.dataGridTextBoxColumnTotalperson.Width = 75;
			// 
			// dataGridTextBoxColumnPhotoPath
			// 
			this.dataGridTextBoxColumnPhotoPath.Format = "";
			this.dataGridTextBoxColumnPhotoPath.FormatInfo = null;
			this.dataGridTextBoxColumnPhotoPath.HeaderText = "Photo Path";
			this.dataGridTextBoxColumnPhotoPath.MappingName = "PhotoPath";
			this.dataGridTextBoxColumnPhotoPath.Width = 75;
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
		
		}

		private void buttonModify_Click(object sender, System.EventArgs e)
		{
			if(buttonModify.Text.ToString()=="Edit") 
			{
				MyMemberForm = new FrmMember(this.MyMDIForm);
				MyMemberForm.MdiParent = base.MyMDIForm;
				MyMemberForm.MyMember = new Member ();
				MyMemberForm.textBoxMemberID.Text = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,0].ToString().Trim();
				MyMemberForm.textBoxPhotoPath.Text   = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,1].ToString().Trim();
				MyMemberForm.textBoxMemberName.Text = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,2].ToString().Trim();
				MyMemberForm.textBoxPlaceBirthDate.Text = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,3].ToString().Trim();
				MyMemberForm.textBoxAddress.Text = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,4].ToString().Trim();
				MyMemberForm.textBoxRegion.Text = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,5].ToString().Trim();
				MyMemberForm.textBoxPostCode.Text = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,6].ToString().Trim();	
				MyMemberForm.textBoxPhone.Text = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,7].ToString().Trim();
				MyMemberForm.textBoxHandPhone.Text = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,8].ToString().Trim();
				MyMemberForm.textBoxEmail.Text = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,9].ToString().Trim();
				MyMemberForm.textBoxMessengerID.Text = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,10].ToString().Trim();
				MyMemberForm.comboBoxReligion.Text = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,11].ToString().Trim();
				MyMemberForm.textBoxChurchMember.Text = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,12].ToString().Trim();
				MyMemberForm.comboBoxParticipate.Text  = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,13].ToString().Trim();
				MyMemberForm.textBoxRole.Text  = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,14].ToString().Trim();
				MyMemberForm.comboBoxCategory.Text  = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,15].ToString().Trim();
				MyMemberForm.comboBoxRelationTo.Text = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,16].ToString().Trim();
				MyMemberForm.comboBoxIsComing.Text = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,17].ToString().Trim();
				MyMemberForm.comboBoxTotalPerson.Text = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,18].ToString().Trim();
				MyMemberForm.textBoxComments.Text = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,19].ToString().Trim();
			
				MyMemberForm.MyMember.UpdateUser = this.MyMDIForm.AdminUserName.ToString();
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
				MyMemberForm.textBoxPhotoPath.Text   = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,1].ToString().Trim();
				MyMemberForm.textBoxMemberName.Text = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,2].ToString().Trim();
				MyMemberForm.textBoxPlaceBirthDate.Text = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,3].ToString().Trim();
				MyMemberForm.textBoxAddress.Text = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,4].ToString().Trim();
				MyMemberForm.textBoxRegion.Text = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,5].ToString().Trim();
				MyMemberForm.textBoxPostCode.Text = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,6].ToString().Trim();	
				MyMemberForm.textBoxPhone.Text = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,7].ToString().Trim();
				MyMemberForm.textBoxHandPhone.Text = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,8].ToString().Trim();
				MyMemberForm.textBoxEmail.Text = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,9].ToString().Trim();
				MyMemberForm.textBoxMessengerID.Text = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,10].ToString().Trim();
				MyMemberForm.comboBoxReligion.Text = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,11].ToString().Trim();
				MyMemberForm.textBoxChurchMember.Text = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,12].ToString().Trim();
				MyMemberForm.comboBoxParticipate.Text  = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,13].ToString().Trim();
				MyMemberForm.textBoxRole.Text  = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,14].ToString().Trim();
				MyMemberForm.comboBoxCategory.Text  = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,15].ToString().Trim();
				MyMemberForm.comboBoxRelationTo.Text = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,16].ToString().Trim();
				MyMemberForm.comboBoxIsComing.Text = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,17].ToString().Trim();
				MyMemberForm.comboBoxTotalPerson.Text = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,18].ToString().Trim();
				MyMemberForm.textBoxComments.Text = dataGridModifyMember[dataGridModifyMember.CurrentRowIndex,19].ToString().Trim();
			
				
				MyMemberForm.MyMember.UpdateUser = this.MyMDIForm.AdminUserName.ToString();
				MyMemberForm.LabelTitle.Text = "    Show Member";
				MyMemberForm.buttonSave.Visible = false;
				MyMemberForm.Show();
			}
		}


	}
}

