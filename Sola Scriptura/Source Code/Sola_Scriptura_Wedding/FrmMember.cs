using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Sola_Scriptura_Wedding
{
	public class FrmMember : Sola_Scriptura_Wedding.FrmFormParent
	{
		internal System.Windows.Forms.TextBox textBoxEmail;
		internal System.Windows.Forms.Label labelEmail;
		internal System.Windows.Forms.TextBox textBoxHandPhone;
		internal System.Windows.Forms.TextBox textBoxPhone;
		internal System.Windows.Forms.Label labelPhone;
		internal System.Windows.Forms.TextBox textBoxPostCode;
		internal System.Windows.Forms.Label labelPostCode;
		internal System.Windows.Forms.Label labelCity;
		internal System.Windows.Forms.TextBox textBoxAddress;
		internal System.Windows.Forms.Label labelAddress;
		internal System.Windows.Forms.PictureBox pictureBox1;
		internal System.Windows.Forms.Label labelMemberName;
		internal System.Windows.Forms.TextBox textBoxMemberID;
		internal System.Windows.Forms.Label labelMemberID;
		internal System.Windows.Forms.Label labelMemberGroupCode;
		internal System.Windows.Forms.Label labelHandPhone;
		internal System.Windows.Forms.Button buttonCancel;
		internal System.Windows.Forms.Button buttonSave;
		private System.ComponentModel.IContainer components = null;
		internal System.Windows.Forms.TextBox textBoxMemberName;

		internal ClassDatabase MyClassDatabase;
		internal System.Windows.Forms.Label LabelTitle;
		internal System.Windows.Forms.PictureBox pictureBoxLogoPicture;
		internal System.Windows.Forms.Label label1;
		internal System.Windows.Forms.Label label2;
		internal System.Windows.Forms.Label label3;
		internal System.Windows.Forms.Label labelMinistry;
		internal System.Windows.Forms.Label labelRelationTo;
		internal System.Windows.Forms.TextBox textBoxPlaceBirthDate;
		internal System.Windows.Forms.Label label5;
		internal System.Windows.Forms.Label label6;
		internal System.Windows.Forms.Label label7;
		internal System.Windows.Forms.Label label4;
		internal System.Windows.Forms.Label label8;
		internal System.Windows.Forms.TextBox textBoxRegion;
		internal System.Windows.Forms.Label label9;
		internal System.Windows.Forms.Button btnBrowse;
		internal System.Windows.Forms.OpenFileDialog OFD;
		internal System.Windows.Forms.TextBox textBoxPhotoPath;
		internal System.Windows.Forms.PictureBox PbPhoto;
		internal System.Windows.Forms.TextBox textBoxChurchMember;
		internal System.Windows.Forms.TextBox textBoxMessengerID;
		internal System.Windows.Forms.ComboBox comboBoxReligion;
		internal System.Windows.Forms.TextBox textBoxRole;
		internal System.Windows.Forms.ComboBox comboBoxCategory;
		internal System.Windows.Forms.ComboBox comboBoxParticipate;
		internal System.Windows.Forms.TextBox textBoxComments;
		internal System.Windows.Forms.Label label10;
		internal System.Windows.Forms.ComboBox comboBoxIsComing;
		internal System.Windows.Forms.ComboBox comboBoxTotalPerson;
		internal System.Windows.Forms.ComboBox comboBoxRelationTo;
		internal Member MyMember;
		
		public FrmMember()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public FrmMember(FrmMDI MDIForm)
		{
			base.MyMDIForm = MDIForm;
			InitializeComponent();
			this.MdiParent = base.MyMDIForm;
			base.pictureBoxMainForm.SendToBack ();

			// TODO: Add any initialization after the InitializeComponent call
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmMember));
			this.textBoxEmail = new System.Windows.Forms.TextBox();
			this.labelEmail = new System.Windows.Forms.Label();
			this.textBoxHandPhone = new System.Windows.Forms.TextBox();
			this.textBoxPhone = new System.Windows.Forms.TextBox();
			this.labelPhone = new System.Windows.Forms.Label();
			this.textBoxPostCode = new System.Windows.Forms.TextBox();
			this.labelPostCode = new System.Windows.Forms.Label();
			this.labelCity = new System.Windows.Forms.Label();
			this.textBoxAddress = new System.Windows.Forms.TextBox();
			this.labelAddress = new System.Windows.Forms.Label();
			this.labelMemberGroupCode = new System.Windows.Forms.Label();
			this.textBoxMemberName = new System.Windows.Forms.TextBox();
			this.labelMemberName = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.textBoxMemberID = new System.Windows.Forms.TextBox();
			this.labelMemberID = new System.Windows.Forms.Label();
			this.labelHandPhone = new System.Windows.Forms.Label();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.LabelTitle = new System.Windows.Forms.Label();
			this.pictureBoxLogoPicture = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxRole = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxPlaceBirthDate = new System.Windows.Forms.TextBox();
			this.comboBoxCategory = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBoxParticipate = new System.Windows.Forms.ComboBox();
			this.labelMinistry = new System.Windows.Forms.Label();
			this.labelRelationTo = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxChurchMember = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBoxComments = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxMessengerID = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textBoxRegion = new System.Windows.Forms.TextBox();
			this.textBoxPhotoPath = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.OFD = new System.Windows.Forms.OpenFileDialog();
			this.PbPhoto = new System.Windows.Forms.PictureBox();
			this.comboBoxReligion = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.comboBoxIsComing = new System.Windows.Forms.ComboBox();
			this.comboBoxTotalPerson = new System.Windows.Forms.ComboBox();
			this.comboBoxRelationTo = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// textBoxEmail
			// 
			this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxEmail.Location = new System.Drawing.Point(384, 288);
			this.textBoxEmail.Name = "textBoxEmail";
			this.textBoxEmail.Size = new System.Drawing.Size(200, 22);
			this.textBoxEmail.TabIndex = 9;
			this.textBoxEmail.Text = "";
			this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
			// 
			// labelEmail
			// 
			this.labelEmail.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelEmail.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelEmail.Location = new System.Drawing.Point(256, 288);
			this.labelEmail.Name = "labelEmail";
			this.labelEmail.Size = new System.Drawing.Size(120, 24);
			this.labelEmail.TabIndex = 111;
			this.labelEmail.Text = "Email";
			// 
			// textBoxHandPhone
			// 
			this.textBoxHandPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxHandPhone.Location = new System.Drawing.Point(720, 256);
			this.textBoxHandPhone.Name = "textBoxHandPhone";
			this.textBoxHandPhone.Size = new System.Drawing.Size(200, 22);
			this.textBoxHandPhone.TabIndex = 8;
			this.textBoxHandPhone.Text = "";
			this.textBoxHandPhone.TextChanged += new System.EventHandler(this.textBoxHandPhone_TextChanged);
			// 
			// textBoxPhone
			// 
			this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxPhone.Location = new System.Drawing.Point(384, 256);
			this.textBoxPhone.Name = "textBoxPhone";
			this.textBoxPhone.Size = new System.Drawing.Size(200, 22);
			this.textBoxPhone.TabIndex = 7;
			this.textBoxPhone.Text = "";
			this.textBoxPhone.TextChanged += new System.EventHandler(this.textBoxPhone_TextChanged);
			// 
			// labelPhone
			// 
			this.labelPhone.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelPhone.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelPhone.Location = new System.Drawing.Point(256, 256);
			this.labelPhone.Name = "labelPhone";
			this.labelPhone.Size = new System.Drawing.Size(120, 24);
			this.labelPhone.TabIndex = 110;
			this.labelPhone.Text = "Phone";
			// 
			// textBoxPostCode
			// 
			this.textBoxPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxPostCode.Location = new System.Drawing.Point(720, 224);
			this.textBoxPostCode.Name = "textBoxPostCode";
			this.textBoxPostCode.Size = new System.Drawing.Size(200, 22);
			this.textBoxPostCode.TabIndex = 6;
			this.textBoxPostCode.Text = "";
			this.textBoxPostCode.TextChanged += new System.EventHandler(this.textBoxPostCode_TextChanged);
			// 
			// labelPostCode
			// 
			this.labelPostCode.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelPostCode.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelPostCode.Location = new System.Drawing.Point(592, 224);
			this.labelPostCode.Name = "labelPostCode";
			this.labelPostCode.Size = new System.Drawing.Size(120, 24);
			this.labelPostCode.TabIndex = 107;
			this.labelPostCode.Text = "Post Code";
			// 
			// labelCity
			// 
			this.labelCity.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelCity.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelCity.Location = new System.Drawing.Point(256, 224);
			this.labelCity.Name = "labelCity";
			this.labelCity.Size = new System.Drawing.Size(120, 24);
			this.labelCity.TabIndex = 106;
			this.labelCity.Text = "Region";
			// 
			// textBoxAddress
			// 
			this.textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxAddress.Location = new System.Drawing.Point(384, 192);
			this.textBoxAddress.Name = "textBoxAddress";
			this.textBoxAddress.Size = new System.Drawing.Size(536, 22);
			this.textBoxAddress.TabIndex = 4;
			this.textBoxAddress.Text = "";
			this.textBoxAddress.TextChanged += new System.EventHandler(this.textBoxAddress_TextChanged);
			// 
			// labelAddress
			// 
			this.labelAddress.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelAddress.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelAddress.Location = new System.Drawing.Point(256, 192);
			this.labelAddress.Name = "labelAddress";
			this.labelAddress.Size = new System.Drawing.Size(120, 24);
			this.labelAddress.TabIndex = 105;
			this.labelAddress.Text = "Address";
			// 
			// labelMemberGroupCode
			// 
			this.labelMemberGroupCode.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelMemberGroupCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelMemberGroupCode.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelMemberGroupCode.Location = new System.Drawing.Point(256, 160);
			this.labelMemberGroupCode.Name = "labelMemberGroupCode";
			this.labelMemberGroupCode.Size = new System.Drawing.Size(120, 24);
			this.labelMemberGroupCode.TabIndex = 104;
			this.labelMemberGroupCode.Text = "Place / Birth Date";
			// 
			// textBoxMemberName
			// 
			this.textBoxMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxMemberName.Location = new System.Drawing.Point(384, 128);
			this.textBoxMemberName.Name = "textBoxMemberName";
			this.textBoxMemberName.Size = new System.Drawing.Size(536, 22);
			this.textBoxMemberName.TabIndex = 2;
			this.textBoxMemberName.Text = "";
			this.textBoxMemberName.TextChanged += new System.EventHandler(this.textBoxMemberName_TextChanged);
			// 
			// labelMemberName
			// 
			this.labelMemberName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelMemberName.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelMemberName.Location = new System.Drawing.Point(256, 128);
			this.labelMemberName.Name = "labelMemberName";
			this.labelMemberName.Size = new System.Drawing.Size(120, 24);
			this.labelMemberName.TabIndex = 103;
			this.labelMemberName.Text = "Member Name";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(232, 112);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(680, 10);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 102;
			this.pictureBox1.TabStop = false;
			// 
			// textBoxMemberID
			// 
			this.textBoxMemberID.BackColor = System.Drawing.Color.White;
			this.textBoxMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxMemberID.ForeColor = System.Drawing.SystemColors.ControlText;
			this.textBoxMemberID.Location = new System.Drawing.Point(384, 64);
			this.textBoxMemberID.Name = "textBoxMemberID";
			this.textBoxMemberID.Size = new System.Drawing.Size(200, 22);
			this.textBoxMemberID.TabIndex = 1;
			this.textBoxMemberID.Text = "";
			this.textBoxMemberID.TextChanged += new System.EventHandler(this.textBoxMemberID_TextChanged);
			// 
			// labelMemberID
			// 
			this.labelMemberID.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelMemberID.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelMemberID.Location = new System.Drawing.Point(256, 64);
			this.labelMemberID.Name = "labelMemberID";
			this.labelMemberID.Size = new System.Drawing.Size(120, 24);
			this.labelMemberID.TabIndex = 101;
			this.labelMemberID.Text = "Member ID";
			// 
			// labelHandPhone
			// 
			this.labelHandPhone.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelHandPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelHandPhone.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelHandPhone.Location = new System.Drawing.Point(592, 256);
			this.labelHandPhone.Name = "labelHandPhone";
			this.labelHandPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.labelHandPhone.Size = new System.Drawing.Size(120, 24);
			this.labelHandPhone.TabIndex = 114;
			this.labelHandPhone.Text = "Hand Phone";
			// 
			// buttonCancel
			// 
			this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonCancel.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonCancel.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancel.Image")));
			this.buttonCancel.Location = new System.Drawing.Point(784, 518);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(136, 40);
			this.buttonCancel.TabIndex = 21;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// buttonSave
			// 
			this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonSave.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
			this.buttonSave.Location = new System.Drawing.Point(640, 518);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(136, 40);
			this.buttonSave.TabIndex = 20;
			this.buttonSave.Text = "Save";
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
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
			this.LabelTitle.TabIndex = 117;
			this.LabelTitle.Text = "    Member";
			this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBoxLogoPicture
			// 
			this.pictureBoxLogoPicture.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogoPicture.Image")));
			this.pictureBoxLogoPicture.Location = new System.Drawing.Point(32, 72);
			this.pictureBoxLogoPicture.Name = "pictureBoxLogoPicture";
			this.pictureBoxLogoPicture.Size = new System.Drawing.Size(144, 88);
			this.pictureBoxLogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxLogoPicture.TabIndex = 192;
			this.pictureBoxLogoPicture.TabStop = false;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label1.Location = new System.Drawing.Point(256, 352);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 24);
			this.label1.TabIndex = 194;
			this.label1.Text = "Participate";
			// 
			// textBoxRole
			// 
			this.textBoxRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxRole.Location = new System.Drawing.Point(720, 352);
			this.textBoxRole.Name = "textBoxRole";
			this.textBoxRole.Size = new System.Drawing.Size(200, 22);
			this.textBoxRole.TabIndex = 14;
			this.textBoxRole.Text = "";
			this.textBoxRole.TextChanged += new System.EventHandler(this.textBoxRole_TextChanged_1);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label2.Location = new System.Drawing.Point(592, 352);
			this.label2.Name = "label2";
			this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label2.Size = new System.Drawing.Size(120, 24);
			this.label2.TabIndex = 197;
			this.label2.Text = "Role";
			// 
			// textBoxPlaceBirthDate
			// 
			this.textBoxPlaceBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxPlaceBirthDate.Location = new System.Drawing.Point(384, 160);
			this.textBoxPlaceBirthDate.Name = "textBoxPlaceBirthDate";
			this.textBoxPlaceBirthDate.Size = new System.Drawing.Size(536, 22);
			this.textBoxPlaceBirthDate.TabIndex = 3;
			this.textBoxPlaceBirthDate.Text = "";
			this.textBoxPlaceBirthDate.TextChanged += new System.EventHandler(this.textBoxPlaceBirthDate_TextChanged);
			// 
			// comboBoxCategory
			// 
			this.comboBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.comboBoxCategory.Items.AddRange(new object[] {
																  "Friend",
																  "Family",
																  "Alumni",
																  "Evangelist",
																  "Reverend",
																  "Elder",
																  "Institut",
																  "GRII",
																  "Other"});
			this.comboBoxCategory.Location = new System.Drawing.Point(384, 384);
			this.comboBoxCategory.Name = "comboBoxCategory";
			this.comboBoxCategory.Size = new System.Drawing.Size(200, 24);
			this.comboBoxCategory.TabIndex = 15;
			this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged_1);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label3.Location = new System.Drawing.Point(256, 384);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(120, 24);
			this.label3.TabIndex = 200;
			this.label3.Text = "Category";
			// 
			// comboBoxParticipate
			// 
			this.comboBoxParticipate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.comboBoxParticipate.Items.AddRange(new object[] {
																	 "Yes",
																	 "No",
																	 "???"});
			this.comboBoxParticipate.Location = new System.Drawing.Point(384, 352);
			this.comboBoxParticipate.Name = "comboBoxParticipate";
			this.comboBoxParticipate.Size = new System.Drawing.Size(200, 24);
			this.comboBoxParticipate.TabIndex = 13;
			this.comboBoxParticipate.SelectedIndexChanged += new System.EventHandler(this.comboBoxBaptized_SelectedIndexChanged);
			// 
			// labelMinistry
			// 
			this.labelMinistry.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelMinistry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelMinistry.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelMinistry.Location = new System.Drawing.Point(256, 416);
			this.labelMinistry.Name = "labelMinistry";
			this.labelMinistry.Size = new System.Drawing.Size(120, 24);
			this.labelMinistry.TabIndex = 203;
			this.labelMinistry.Text = "Is Coming ?";
			// 
			// labelRelationTo
			// 
			this.labelRelationTo.Location = new System.Drawing.Point(0, 0);
			this.labelRelationTo.Name = "labelRelationTo";
			this.labelRelationTo.TabIndex = 227;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label5.Location = new System.Drawing.Point(592, 416);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(128, 24);
			this.label5.TabIndex = 209;
			this.label5.Text = "How many person(s)";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label6.Location = new System.Drawing.Point(592, 320);
			this.label6.Name = "label6";
			this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label6.Size = new System.Drawing.Size(120, 24);
			this.label6.TabIndex = 214;
			this.label6.Text = "Church Member";
			// 
			// textBoxChurchMember
			// 
			this.textBoxChurchMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxChurchMember.Location = new System.Drawing.Point(720, 320);
			this.textBoxChurchMember.Name = "textBoxChurchMember";
			this.textBoxChurchMember.Size = new System.Drawing.Size(200, 22);
			this.textBoxChurchMember.TabIndex = 12;
			this.textBoxChurchMember.Text = "";
			this.textBoxChurchMember.TextChanged += new System.EventHandler(this.textBoxChurchMember_TextChanged);
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label7.Location = new System.Drawing.Point(256, 320);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(120, 24);
			this.label7.TabIndex = 213;
			this.label7.Text = "Religion";
			// 
			// textBoxComments
			// 
			this.textBoxComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxComments.Location = new System.Drawing.Point(384, 448);
			this.textBoxComments.Name = "textBoxComments";
			this.textBoxComments.Size = new System.Drawing.Size(536, 22);
			this.textBoxComments.TabIndex = 19;
			this.textBoxComments.Text = "";
			this.textBoxComments.TextChanged += new System.EventHandler(this.textBoxComments_TextChanged_1);
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label4.Location = new System.Drawing.Point(256, 448);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(120, 24);
			this.label4.TabIndex = 216;
			this.label4.Text = "Comments";
			// 
			// textBoxMessengerID
			// 
			this.textBoxMessengerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxMessengerID.Location = new System.Drawing.Point(720, 288);
			this.textBoxMessengerID.Name = "textBoxMessengerID";
			this.textBoxMessengerID.Size = new System.Drawing.Size(200, 22);
			this.textBoxMessengerID.TabIndex = 10;
			this.textBoxMessengerID.Text = "";
			this.textBoxMessengerID.TextChanged += new System.EventHandler(this.textBoxMessengerId_TextChanged);
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label8.Location = new System.Drawing.Point(592, 288);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(120, 24);
			this.label8.TabIndex = 218;
			this.label8.Text = "Messenger ID";
			// 
			// textBoxRegion
			// 
			this.textBoxRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxRegion.Location = new System.Drawing.Point(384, 224);
			this.textBoxRegion.Name = "textBoxRegion";
			this.textBoxRegion.Size = new System.Drawing.Size(200, 22);
			this.textBoxRegion.TabIndex = 5;
			this.textBoxRegion.Text = "";
			this.textBoxRegion.TextChanged += new System.EventHandler(this.textBoxRegion_TextChanged);
			// 
			// textBoxPhotoPath
			// 
			this.textBoxPhotoPath.BackColor = System.Drawing.Color.White;
			this.textBoxPhotoPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxPhotoPath.ForeColor = System.Drawing.SystemColors.ControlText;
			this.textBoxPhotoPath.Location = new System.Drawing.Point(384, 88);
			this.textBoxPhotoPath.Name = "textBoxPhotoPath";
			this.textBoxPhotoPath.Size = new System.Drawing.Size(488, 22);
			this.textBoxPhotoPath.TabIndex = 1;
			this.textBoxPhotoPath.Text = "";
			this.textBoxPhotoPath.TextChanged += new System.EventHandler(this.textBoxPhotoPath_TextChanged);
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label9.Location = new System.Drawing.Point(256, 88);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(120, 24);
			this.label9.TabIndex = 220;
			this.label9.Text = "Photo Path";
			// 
			// btnBrowse
			// 
			this.btnBrowse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBrowse.BackgroundImage")));
			this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBrowse.Location = new System.Drawing.Point(888, 88);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(32, 24);
			this.btnBrowse.TabIndex = 222;
			this.btnBrowse.Text = ".....";
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// PbPhoto
			// 
			this.PbPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PbPhoto.Location = new System.Drawing.Point(24, 184);
			this.PbPhoto.Name = "PbPhoto";
			this.PbPhoto.Size = new System.Drawing.Size(160, 216);
			this.PbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PbPhoto.TabIndex = 223;
			this.PbPhoto.TabStop = false;
			// 
			// comboBoxReligion
			// 
			this.comboBoxReligion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.comboBoxReligion.Items.AddRange(new object[] {
																  "Christianity",
																  "Catholic",
																  "Buddhist",
																  "Moslem",
																  "Hindu",
																  "Confusian"});
			this.comboBoxReligion.Location = new System.Drawing.Point(384, 320);
			this.comboBoxReligion.Name = "comboBoxReligion";
			this.comboBoxReligion.Size = new System.Drawing.Size(200, 24);
			this.comboBoxReligion.TabIndex = 11;
			this.comboBoxReligion.SelectedIndexChanged += new System.EventHandler(this.comboBoxReligion_SelectedIndexChanged);
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label10.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label10.Location = new System.Drawing.Point(592, 384);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(120, 24);
			this.label10.TabIndex = 228;
			this.label10.Text = "Relation To";
			// 
			// comboBoxIsComing
			// 
			this.comboBoxIsComing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.comboBoxIsComing.Items.AddRange(new object[] {
																  "Yes",
																  "No",
																  "??"});
			this.comboBoxIsComing.Location = new System.Drawing.Point(384, 416);
			this.comboBoxIsComing.Name = "comboBoxIsComing";
			this.comboBoxIsComing.Size = new System.Drawing.Size(200, 24);
			this.comboBoxIsComing.TabIndex = 17;
			this.comboBoxIsComing.SelectedIndexChanged += new System.EventHandler(this.comboBoxIsComing_SelectedIndexChanged);
			// 
			// comboBoxTotalPerson
			// 
			this.comboBoxTotalPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.comboBoxTotalPerson.Items.AddRange(new object[] {
																	 "0",
																	 "1",
																	 "2",
																	 "3",
																	 "4",
																	 "5",
																	 "6",
																	 "7",
																	 "8",
																	 "9"});
			this.comboBoxTotalPerson.Location = new System.Drawing.Point(720, 416);
			this.comboBoxTotalPerson.Name = "comboBoxTotalPerson";
			this.comboBoxTotalPerson.Size = new System.Drawing.Size(200, 24);
			this.comboBoxTotalPerson.TabIndex = 18;
			this.comboBoxTotalPerson.SelectedIndexChanged += new System.EventHandler(this.comboBoxTotalPerson_SelectedIndexChanged);
			// 
			// comboBoxRelationTo
			// 
			this.comboBoxRelationTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.comboBoxRelationTo.Items.AddRange(new object[] {
																	"Both",
																	"Randee",
																	"Stanly"});
			this.comboBoxRelationTo.Location = new System.Drawing.Point(720, 384);
			this.comboBoxRelationTo.Name = "comboBoxRelationTo";
			this.comboBoxRelationTo.Size = new System.Drawing.Size(200, 24);
			this.comboBoxRelationTo.TabIndex = 16;
			this.comboBoxRelationTo.SelectedIndexChanged += new System.EventHandler(this.comboBoxRelationTo_SelectedIndexChanged);
			// 
			// FrmMember
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.comboBoxRelationTo);
			this.Controls.Add(this.comboBoxTotalPerson);
			this.Controls.Add(this.comboBoxIsComing);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.comboBoxReligion);
			this.Controls.Add(this.PbPhoto);
			this.Controls.Add(this.btnBrowse);
			this.Controls.Add(this.textBoxPhotoPath);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.textBoxRegion);
			this.Controls.Add(this.textBoxMessengerID);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.textBoxComments);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBoxChurchMember);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.labelRelationTo);
			this.Controls.Add(this.labelMinistry);
			this.Controls.Add(this.comboBoxParticipate);
			this.Controls.Add(this.comboBoxCategory);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxPlaceBirthDate);
			this.Controls.Add(this.textBoxRole);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBoxLogoPicture);
			this.Controls.Add(this.LabelTitle);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.labelHandPhone);
			this.Controls.Add(this.textBoxEmail);
			this.Controls.Add(this.labelEmail);
			this.Controls.Add(this.textBoxHandPhone);
			this.Controls.Add(this.textBoxPhone);
			this.Controls.Add(this.labelPhone);
			this.Controls.Add(this.textBoxPostCode);
			this.Controls.Add(this.labelPostCode);
			this.Controls.Add(this.labelCity);
			this.Controls.Add(this.textBoxAddress);
			this.Controls.Add(this.labelAddress);
			this.Controls.Add(this.labelMemberGroupCode);
			this.Controls.Add(this.textBoxMemberName);
			this.Controls.Add(this.labelMemberName);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.textBoxMemberID);
			this.Controls.Add(this.labelMemberID);
			this.Name = "FrmMember";
			this.Load += new System.EventHandler(this.FrmMember_Load);
			this.Controls.SetChildIndex(this.labelMemberID, 0);
			this.Controls.SetChildIndex(this.textBoxMemberID, 0);
			this.Controls.SetChildIndex(this.pictureBox1, 0);
			this.Controls.SetChildIndex(this.labelMemberName, 0);
			this.Controls.SetChildIndex(this.textBoxMemberName, 0);
			this.Controls.SetChildIndex(this.labelMemberGroupCode, 0);
			this.Controls.SetChildIndex(this.labelAddress, 0);
			this.Controls.SetChildIndex(this.textBoxAddress, 0);
			this.Controls.SetChildIndex(this.labelCity, 0);
			this.Controls.SetChildIndex(this.labelPostCode, 0);
			this.Controls.SetChildIndex(this.textBoxPostCode, 0);
			this.Controls.SetChildIndex(this.labelPhone, 0);
			this.Controls.SetChildIndex(this.textBoxPhone, 0);
			this.Controls.SetChildIndex(this.textBoxHandPhone, 0);
			this.Controls.SetChildIndex(this.labelEmail, 0);
			this.Controls.SetChildIndex(this.textBoxEmail, 0);
			this.Controls.SetChildIndex(this.labelHandPhone, 0);
			this.Controls.SetChildIndex(this.buttonSave, 0);
			this.Controls.SetChildIndex(this.buttonCancel, 0);
			this.Controls.SetChildIndex(this.LabelTitle, 0);
			this.Controls.SetChildIndex(this.pictureBoxLogoPicture, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.textBoxRole, 0);
			this.Controls.SetChildIndex(this.textBoxPlaceBirthDate, 0);
			this.Controls.SetChildIndex(this.label3, 0);
			this.Controls.SetChildIndex(this.comboBoxCategory, 0);
			this.Controls.SetChildIndex(this.comboBoxParticipate, 0);
			this.Controls.SetChildIndex(this.labelMinistry, 0);
			this.Controls.SetChildIndex(this.labelRelationTo, 0);
			this.Controls.SetChildIndex(this.label5, 0);
			this.Controls.SetChildIndex(this.label7, 0);
			this.Controls.SetChildIndex(this.textBoxChurchMember, 0);
			this.Controls.SetChildIndex(this.label6, 0);
			this.Controls.SetChildIndex(this.label4, 0);
			this.Controls.SetChildIndex(this.textBoxComments, 0);
			this.Controls.SetChildIndex(this.label8, 0);
			this.Controls.SetChildIndex(this.textBoxMessengerID, 0);
			this.Controls.SetChildIndex(this.textBoxRegion, 0);
			this.Controls.SetChildIndex(this.label9, 0);
			this.Controls.SetChildIndex(this.textBoxPhotoPath, 0);
			this.Controls.SetChildIndex(this.btnBrowse, 0);
			this.Controls.SetChildIndex(this.PbPhoto, 0);
			this.Controls.SetChildIndex(this.comboBoxReligion, 0);
			this.Controls.SetChildIndex(this.label10, 0);
			this.Controls.SetChildIndex(this.comboBoxIsComing, 0);
			this.Controls.SetChildIndex(this.comboBoxTotalPerson, 0);
			this.Controls.SetChildIndex(this.comboBoxRelationTo, 0);
			this.ResumeLayout(false);

		}
		#endregion
		public void GetMaxMemberID()
		{
			MyClassDatabase = new ClassDatabase();
			string MaxNo = "1";
			int len;
			long MaxNoPlusOne;
			string MemberID;
		
			MaxNo = MyClassDatabase.GetMaxMemberID ();
			if(MaxNo.Substring(0,1).ToString() == "M")
				MaxNo = MaxNo.Trim().Substring(1);
			else
                MaxNo = MaxNo.Trim().Substring(0);
			MaxNoPlusOne = Convert.ToInt64(MaxNo) + 1;
			len = MaxNoPlusOne.ToString().Length;
			MemberID = "M";
			for(int x=0;x<(MaxNo.Length-len);x++)
				MemberID += "0";
			MemberID += MaxNoPlusOne.ToString();
			textBoxMemberID.Text = MemberID.ToString();

			
			this.LabelTitle.Text = "    Add Member";
		}
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
			
		}

		private void textBoxAddress_TextChanged(object sender, System.EventArgs e)
		{
			MyMember.Address = textBoxAddress.Text.ToString();
		}

		private void textBoxPostCode_TextChanged(object sender, System.EventArgs e)
		{
			MyMember.PostCode = textBoxPostCode.Text.ToString();
		}


		private void textBoxPhone_TextChanged(object sender, System.EventArgs e)
		{
			MyMember.Phone = textBoxPhone.Text.ToString();
		}

		private void textBoxHandPhone_TextChanged(object sender, System.EventArgs e)
		{
			MyMember.HandPhone = textBoxHandPhone.Text.ToString();
		}

		private void textBoxEmail_TextChanged(object sender, System.EventArgs e)
		{
			MyMember.Email = textBoxEmail.Text.ToString();
		}



		private void buttonSave_Click(object sender, System.EventArgs e)
		{
			if(textBoxMemberName.Text.ToString() == "")
			{
				MessageBox.Show("Please enter Member Name !", "Information");
				textBoxMemberName.Focus();
			}
			else
			{
				MyClassDatabase = new ClassDatabase();
				MyClassDatabase.SaveMember(MyMember);
				this.Close();
				this.Dispose();
			}
		}

		private void buttonCancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
			this.Dispose();
		}

		private void comboBoxCategory_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			MyMember.Category  = comboBoxCategory.Text.ToString();
		}

		private void textBoxRole_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			MyMember.RelationTo = textBoxRole.Text.ToString();
		}



		private void comboBoxBaptized_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			MyMember.Participate = comboBoxParticipate.Text.ToString();
		}

		private void textBoxRole_TextChanged(object sender, System.EventArgs e)
		{
			MyMember.Role = textBoxRole.Text.ToString();
		}

		private void textBoxPlaceBirthDate_TextChanged(object sender, System.EventArgs e)
		{
			MyMember.PlaceDateBirthDate = textBoxPlaceBirthDate.Text.ToString();
		}


		private void textBoxRegion_TextChanged(object sender, System.EventArgs e)
		{
			MyMember.Region = textBoxRegion.Text.ToString();
		}

		private void textBoxMessengerId_TextChanged(object sender, System.EventArgs e)
		{
			MyMember.MessengerID = textBoxMessengerID.Text.ToString();
		}

		private void comboBoxReligion_TextChanged(object sender, System.EventArgs e)
		{
			MyMember.Religion = comboBoxReligion.Text.ToString();
		}

		private void textBoxChurchMember_TextChanged(object sender, System.EventArgs e)
		{
			MyMember.ChurchMember = textBoxChurchMember.Text.ToString();
		}

		private void textBoxComments_TextChanged(object sender, System.EventArgs e)
		{
			MyMember.Comments = textBoxComments.Text.ToString();
		}



		private void comboBoxRelationTo_TextChanged(object sender, System.EventArgs e)
		{
			MyMember.IsComing = comboBoxRelationTo.Text.ToString();
		}

	

		private void btnBrowse_Click(object sender, System.EventArgs e)
		{
		     OFD.Filter = "Image Files (*.JPEG, *.jpg, *.bmp, *.gif, *.png)|*.JPEG; *.jpg; *.bmp; *.gif; *.png";
			 OFD.ShowDialog();
			 textBoxPhotoPath.Text = OFD.FileName.ToString();
		
			if(textBoxPhotoPath.Text != "")
			{
				
				PbPhoto.Image = Image.FromFile(textBoxPhotoPath.Text);

			}
			
		}

		private void textBoxPhotoPath_TextChanged(object sender, System.EventArgs e)
		{
			MyMember.PhotoPath = textBoxPhotoPath.Text.ToString();


		}

		private void FrmMember_Load(object sender, System.EventArgs e)
		{
			if(textBoxPhotoPath.Text != "")
			{
				
				PbPhoto.Image = Image.FromFile(textBoxPhotoPath.Text);

			}
		}

		private void comboBoxTotalPerson_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			MyMember.Totalperson = comboBoxTotalPerson.Text.ToString();
		}

		private void comboBoxReligion_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			MyMember.Religion = comboBoxReligion.Text.ToString();
		}

		private void textBoxRole_TextChanged_1(object sender, System.EventArgs e)
		{
			MyMember.Role = textBoxRole.Text.ToString();
		}

		private void comboBoxCategory_SelectedIndexChanged_1(object sender, System.EventArgs e)
		{
			MyMember.Category = comboBoxCategory.Text.ToString();
		}

		private void comboBoxRelationTo_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			MyMember.RelationTo = comboBoxRelationTo.Text.ToString();
		}

		private void comboBoxIsComing_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			MyMember.IsComing = comboBoxIsComing.Text.ToString();
		}

		private void textBoxComments_TextChanged_1(object sender, System.EventArgs e)
		{
			MyMember.Comments = textBoxComments.Text.ToString();
		}

		






	}
}

