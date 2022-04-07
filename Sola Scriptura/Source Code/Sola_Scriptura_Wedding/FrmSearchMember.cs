using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace Sola_Scriptura_Wedding
{
	public class FrmSearchMember : Sola_Scriptura_Wedding.FrmSearchMemberMaster
	{
		internal System.Windows.Forms.Label LabelTitle;
		internal System.Windows.Forms.Label label1;
		internal System.Windows.Forms.Label label3;
		internal System.Windows.Forms.Button buttonClear;
		internal System.Windows.Forms.Label labelKeyWord;
		internal System.Windows.Forms.Button buttonSearch;
		internal System.Windows.Forms.Label labelMemberID;
		internal System.Windows.Forms.TextBox textBoxMemberID;
		internal System.Windows.Forms.TextBox textBoxKeyWord;
		internal System.Windows.Forms.DataGrid dataGridSearchMember;
		private System.ComponentModel.IContainer components = null;
		
		internal ClassDatabase MyClassDatabase;
		internal DataTable MyDataTable;
		internal System.Windows.Forms.Label labelInformation;
		internal System.Windows.Forms.DataGridTableStyle dataGridTableStyleSearchMember;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumMemberID;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnMemberName;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnPlaceDateBirth;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnAddress;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnCity;
		protected internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnPostCode;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnPhone;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnHandPhone;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnEmail;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnRole;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnCategory;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnRelationTo;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnUpdateDate;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnUpdateUser;
		internal System.Windows.Forms.Button buttonShow;
		internal System.Windows.Forms.PictureBox pictureBoxLogoPicture;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnPhotoPath;
		internal Member MyMember;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnIsComing;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnMessengerID;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnReligion;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnChurchMember;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnComments;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnTotalperson;
		internal System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnParticipate;
		internal string AppPath;
		public FrmSearchMember()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public FrmSearchMember(FrmMDI MDIForm)
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmSearchMember));
			this.LabelTitle = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridSearchMember = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyleSearchMember = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumMemberID = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnMemberName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnPlaceDateBirth = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnAddress = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnCity = new System.Windows.Forms.DataGridTextBoxColumn();
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
			this.labelInformation = new System.Windows.Forms.Label();
			this.textBoxKeyWord = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.buttonClear = new System.Windows.Forms.Button();
			this.labelKeyWord = new System.Windows.Forms.Label();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.textBoxMemberID = new System.Windows.Forms.TextBox();
			this.labelMemberID = new System.Windows.Forms.Label();
			this.buttonShow = new System.Windows.Forms.Button();
			this.pictureBoxLogoPicture = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridSearchMember)).BeginInit();
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
			this.LabelTitle.TabIndex = 200;
			this.LabelTitle.Text = "    Search Member";
			this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label1.Location = new System.Drawing.Point(272, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 24);
			this.label1.TabIndex = 189;
			this.label1.Text = "Member ID";
			// 
			// dataGridSearchMember
			// 
			this.dataGridSearchMember.DataMember = "";
			this.dataGridSearchMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGridSearchMember.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridSearchMember.Location = new System.Drawing.Point(248, 176);
			this.dataGridSearchMember.Name = "dataGridSearchMember";
			this.dataGridSearchMember.ReadOnly = true;
			this.dataGridSearchMember.Size = new System.Drawing.Size(696, 376);
			this.dataGridSearchMember.TabIndex = 7;
			this.dataGridSearchMember.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																											 this.dataGridTableStyleSearchMember});
			// 
			// dataGridTableStyleSearchMember
			// 
			this.dataGridTableStyleSearchMember.AlternatingBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleSearchMember.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.dataGridTableStyleSearchMember.DataGrid = this.dataGridSearchMember;
			this.dataGridTableStyleSearchMember.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleSearchMember.GridLineColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridTableStyleSearchMember.HeaderBackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.dataGridTableStyleSearchMember.HeaderForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridTableStyleSearchMember.MappingName = "Member";
			// 
			// dataGridTextBoxColumMemberID
			// 
			this.dataGridTextBoxColumMemberID.Format = "";
			this.dataGridTextBoxColumMemberID.FormatInfo = null;
			this.dataGridTextBoxColumMemberID.HeaderText = "Member ID";
			this.dataGridTextBoxColumMemberID.MappingName = "MemberID";
			this.dataGridTextBoxColumMemberID.Width = 101;
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
			// dataGridTextBoxColumnCity
			// 
			this.dataGridTextBoxColumnCity.Format = "";
			this.dataGridTextBoxColumnCity.FormatInfo = null;
			this.dataGridTextBoxColumnCity.HeaderText = "Region";
			this.dataGridTextBoxColumnCity.MappingName = "Region";
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
			this.dataGridTextBoxColumnMessengerID.HeaderText = "Parent Email";
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
			this.dataGridTextBoxColumnUpdateDate.HeaderText = "UpdateDate";
			this.dataGridTextBoxColumnUpdateDate.MappingName = "UpdateDate";
			this.dataGridTextBoxColumnUpdateDate.Width = 75;
			// 
			// labelInformation
			// 
			this.labelInformation.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelInformation.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelInformation.ForeColor = System.Drawing.Color.LightCoral;
			this.labelInformation.Location = new System.Drawing.Point(256, 144);
			this.labelInformation.Name = "labelInformation";
			this.labelInformation.Size = new System.Drawing.Size(400, 24);
			this.labelInformation.TabIndex = 201;
			this.labelInformation.Text = "Click Member Data in DGrid and Click Show Button to show data !";
			this.labelInformation.Visible = false;
			// 
			// textBoxKeyWord
			// 
			this.textBoxKeyWord.Location = new System.Drawing.Point(392, 104);
			this.textBoxKeyWord.Name = "textBoxKeyWord";
			this.textBoxKeyWord.Size = new System.Drawing.Size(552, 20);
			this.textBoxKeyWord.TabIndex = 2;
			this.textBoxKeyWord.Text = "";
			this.textBoxKeyWord.TextChanged += new System.EventHandler(this.textBoxKeyWord_TextChanged);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label3.Location = new System.Drawing.Point(272, 104);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(144, 24);
			this.label3.TabIndex = 199;
			this.label3.Text = "Keywords ( Any )";
			// 
			// buttonClear
			// 
			this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonClear.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonClear.Image = ((System.Drawing.Image)(resources.GetObject("buttonClear.Image")));
			this.buttonClear.Location = new System.Drawing.Point(752, 136);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(56, 32);
			this.buttonClear.TabIndex = 3;
			this.buttonClear.Text = "Clear";
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// labelKeyWord
			// 
			this.labelKeyWord.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelKeyWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelKeyWord.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelKeyWord.Location = new System.Drawing.Point(264, 104);
			this.labelKeyWord.Name = "labelKeyWord";
			this.labelKeyWord.Size = new System.Drawing.Size(120, 24);
			this.labelKeyWord.TabIndex = 208;
			this.labelKeyWord.Text = "Keywords ( Any )";
			// 
			// buttonSearch
			// 
			this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonSearch.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearch.Image")));
			this.buttonSearch.Location = new System.Drawing.Point(816, 136);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(64, 32);
			this.buttonSearch.TabIndex = 4;
			this.buttonSearch.Text = "Search";
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// textBoxMemberID
			// 
			this.textBoxMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxMemberID.Location = new System.Drawing.Point(392, 80);
			this.textBoxMemberID.Name = "textBoxMemberID";
			this.textBoxMemberID.Size = new System.Drawing.Size(200, 20);
			this.textBoxMemberID.TabIndex = 1;
			this.textBoxMemberID.Text = "";
			this.textBoxMemberID.TextChanged += new System.EventHandler(this.textBoxMemberID_TextChanged);
			// 
			// labelMemberID
			// 
			this.labelMemberID.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelMemberID.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelMemberID.Location = new System.Drawing.Point(264, 80);
			this.labelMemberID.Name = "labelMemberID";
			this.labelMemberID.Size = new System.Drawing.Size(120, 24);
			this.labelMemberID.TabIndex = 207;
			this.labelMemberID.Text = "Member ID";
			// 
			// buttonShow
			// 
			this.buttonShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonShow.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonShow.Image = ((System.Drawing.Image)(resources.GetObject("buttonShow.Image")));
			this.buttonShow.Location = new System.Drawing.Point(888, 136);
			this.buttonShow.Name = "buttonShow";
			this.buttonShow.Size = new System.Drawing.Size(56, 32);
			this.buttonShow.TabIndex = 5;
			this.buttonShow.Text = "Show";
			this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
			// 
			// pictureBoxLogoPicture
			// 
			this.pictureBoxLogoPicture.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogoPicture.Image")));
			this.pictureBoxLogoPicture.Location = new System.Drawing.Point(32, 456);
			this.pictureBoxLogoPicture.Name = "pictureBoxLogoPicture";
			this.pictureBoxLogoPicture.Size = new System.Drawing.Size(144, 88);
			this.pictureBoxLogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxLogoPicture.TabIndex = 216;
			this.pictureBoxLogoPicture.TabStop = false;
			// 
			// FrmSearchMember
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.pictureBoxLogoPicture);
			this.Controls.Add(this.buttonShow);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.labelKeyWord);
			this.Controls.Add(this.buttonSearch);
			this.Controls.Add(this.textBoxMemberID);
			this.Controls.Add(this.labelMemberID);
			this.Controls.Add(this.LabelTitle);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridSearchMember);
			this.Controls.Add(this.labelInformation);
			this.Controls.Add(this.textBoxKeyWord);
			this.Controls.Add(this.label3);
			this.Name = "FrmSearchMember";
			this.Load += new System.EventHandler(this.FrmSearchMember_Load);
			this.Controls.SetChildIndex(this.label3, 0);
			this.Controls.SetChildIndex(this.textBoxKeyWord, 0);
			this.Controls.SetChildIndex(this.labelInformation, 0);
			this.Controls.SetChildIndex(this.dataGridSearchMember, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.LabelTitle, 0);
			this.Controls.SetChildIndex(this.labelMemberID, 0);
			this.Controls.SetChildIndex(this.textBoxMemberID, 0);
			this.Controls.SetChildIndex(this.buttonSearch, 0);
			this.Controls.SetChildIndex(this.labelKeyWord, 0);
			this.Controls.SetChildIndex(this.buttonClear, 0);
			this.Controls.SetChildIndex(this.buttonShow, 0);
			this.Controls.SetChildIndex(this.pictureBoxLogoPicture, 0);
			((System.ComponentModel.ISupportInitialize)(this.dataGridSearchMember)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void buttonSearch_Click(object sender, System.EventArgs e)
		{
			MyClassDatabase = new ClassDatabase();
			MyDataTable = MyClassDatabase.GetMember(MyMember);
			dataGridSearchMember.DataSource = MyDataTable;
			if(MyDataTable.Rows.Count>0)
				labelInformation.Visible = true;
			else
				labelInformation.Visible = false;
		}

		private void FrmSearchMember_Load(object sender, System.EventArgs e)
		{
			AppPath  =Application.ExecutablePath.Replace(Application.ProductName + ".exe", "").Replace(".exe","");
			MyMember = new Member();
			MyMDIForm.MyMP3Player.Close();
			MyMDIForm.MyMP3Player = new MP3Player();
			MyMDIForm.MyMP3Player.Open(AppPath.ToString()+ "\\music\\search.mp3");
			MyMDIForm.MyMP3Player.Play();
		}

		private void textBoxMemberID_TextChanged(object sender, System.EventArgs e)
		{
			MyMember.MemberID = textBoxMemberID.Text.ToString();
		}

		private void textBoxKeyWord_TextChanged(object sender, System.EventArgs e)
		{
			MyMember.MemberName = textBoxKeyWord.Text.ToString();
		}

		private void buttonShow_Click(object sender, System.EventArgs e)
		{
			try
			{
				MyMDIForm.MyShowMemberForm = new FrmShowMember(MyMDIForm);
				MyMDIForm.MyShowMemberForm.textBoxMemberID.Text = dataGridSearchMember[dataGridSearchMember.CurrentRowIndex,0].ToString().Trim();
				MyMDIForm.MyShowMemberForm.textBoxPhotoPath.Text   = dataGridSearchMember[dataGridSearchMember.CurrentRowIndex,1].ToString().Trim();
				MyMDIForm.MyShowMemberForm.textBoxMemberName.Text = dataGridSearchMember[dataGridSearchMember.CurrentRowIndex,2].ToString().Trim();
				MyMDIForm.MyShowMemberForm.textBoxPlaceBirthDate.Text = dataGridSearchMember[dataGridSearchMember.CurrentRowIndex,3].ToString().Trim();
				MyMDIForm.MyShowMemberForm.textBoxAddress.Text = dataGridSearchMember[dataGridSearchMember.CurrentRowIndex,4].ToString().Trim();
				MyMDIForm.MyShowMemberForm.textBoxRegion.Text = dataGridSearchMember[dataGridSearchMember.CurrentRowIndex,5].ToString().Trim();
				MyMDIForm.MyShowMemberForm.textBoxPostCode.Text = dataGridSearchMember[dataGridSearchMember.CurrentRowIndex,6].ToString().Trim();	
				MyMDIForm.MyShowMemberForm.textBoxPhone.Text = dataGridSearchMember[dataGridSearchMember.CurrentRowIndex,7].ToString().Trim();
				MyMDIForm.MyShowMemberForm.textBoxHandPhone.Text = dataGridSearchMember[dataGridSearchMember.CurrentRowIndex,8].ToString().Trim();
				MyMDIForm.MyShowMemberForm.textBoxEmail.Text = dataGridSearchMember[dataGridSearchMember.CurrentRowIndex,9].ToString().Trim();
				MyMDIForm.MyShowMemberForm.textBoxMessengerID.Text = dataGridSearchMember[dataGridSearchMember.CurrentRowIndex,10].ToString().Trim();
				MyMDIForm.MyShowMemberForm.comboBoxReligion.Text = dataGridSearchMember[dataGridSearchMember.CurrentRowIndex,11].ToString().Trim();
				MyMDIForm.MyShowMemberForm.textBoxChurchMember.Text = dataGridSearchMember[dataGridSearchMember.CurrentRowIndex,12].ToString().Trim();
				MyMDIForm.MyShowMemberForm.comboBoxParticipate.Text  = dataGridSearchMember[dataGridSearchMember.CurrentRowIndex,13].ToString().Trim();
				MyMDIForm.MyShowMemberForm.textBoxRole.Text  = dataGridSearchMember[dataGridSearchMember.CurrentRowIndex,14].ToString().Trim();
				MyMDIForm.MyShowMemberForm.comboBoxCategory.Text  = dataGridSearchMember[dataGridSearchMember.CurrentRowIndex,15].ToString().Trim();
				MyMDIForm.MyShowMemberForm.comboBoxRelationTo.Text = dataGridSearchMember[dataGridSearchMember.CurrentRowIndex,16].ToString().Trim();
				MyMDIForm.MyShowMemberForm.comboBoxIsComing.Text = dataGridSearchMember[dataGridSearchMember.CurrentRowIndex,17].ToString().Trim();
				MyMDIForm.MyShowMemberForm.comboBoxTotalPerson.Text = dataGridSearchMember[dataGridSearchMember.CurrentRowIndex,18].ToString().Trim();
				MyMDIForm.MyShowMemberForm.textBoxComments.Text = dataGridSearchMember[dataGridSearchMember.CurrentRowIndex,19].ToString().Trim();
			
				MyMDIForm.MyShowMemberForm.LabelTitle.Text = "    Show Member";
				MyMDIForm.MyShowMemberForm.Show();
				this.Hide();
			}
			catch(Exception ee)
			{
				MessageBox.Show(ee.Message.ToString());
			}
		}

		private void buttonClear_Click(object sender, System.EventArgs e)
		{
			textBoxMemberID.Text = "";
			textBoxKeyWord.Text = "";
		}

		private void Print_Click(object sender, System.EventArgs e)
		{
			MyClassDatabase = new ClassDatabase();
			MyDataTable = MyClassDatabase.GetMember(MyMember);

			DataTable MyDataTableReport;
			MyDataTableReport = MyDataTable;

		}
	}
}

