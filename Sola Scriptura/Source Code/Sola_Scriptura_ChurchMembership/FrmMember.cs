using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Sola_Scriptura_ChurchMembership
{
	public class FrmMember : Sola_Scriptura_ChurchMembership.FrmFormParent
	{
		internal System.Windows.Forms.TextBox textBoxEmail;
		internal System.Windows.Forms.Label labelEmail;
		internal System.Windows.Forms.TextBox textBoxHandPhone;
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
		internal System.Windows.Forms.ComboBox comboBoxStatus;
		internal System.Windows.Forms.Label label3;
		internal System.Windows.Forms.TextBox textBoxMinistry;
		internal System.Windows.Forms.Label labelMinistry;
		internal System.Windows.Forms.ComboBox comboBoxRemark;
		internal System.Windows.Forms.Label labelRemark;
		internal System.Windows.Forms.TextBox textBoxInChurch;
		internal System.Windows.Forms.ComboBox comboBoxIsBaptized;
		internal System.Windows.Forms.TextBox textBoxPlaceBirthDate;
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
			this.textBoxInChurch = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxPlaceBirthDate = new System.Windows.Forms.TextBox();
			this.comboBoxStatus = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBoxIsBaptized = new System.Windows.Forms.ComboBox();
			this.textBoxMinistry = new System.Windows.Forms.TextBox();
			this.labelMinistry = new System.Windows.Forms.Label();
			this.comboBoxRemark = new System.Windows.Forms.ComboBox();
			this.labelRemark = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBoxEmail
			// 
			this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxEmail.Location = new System.Drawing.Point(384, 360);
			this.textBoxEmail.Name = "textBoxEmail";
			this.textBoxEmail.Size = new System.Drawing.Size(536, 22);
			this.textBoxEmail.TabIndex = 11;
			this.textBoxEmail.Text = "";
			this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
			// 
			// labelEmail
			// 
			this.labelEmail.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelEmail.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelEmail.Location = new System.Drawing.Point(256, 360);
			this.labelEmail.Name = "labelEmail";
			this.labelEmail.Size = new System.Drawing.Size(120, 24);
			this.labelEmail.TabIndex = 111;
			this.labelEmail.Text = "Email";
			// 
			// textBoxHandPhone
			// 
			this.textBoxHandPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxHandPhone.Location = new System.Drawing.Point(720, 328);
			this.textBoxHandPhone.Name = "textBoxHandPhone";
			this.textBoxHandPhone.Size = new System.Drawing.Size(200, 22);
			this.textBoxHandPhone.TabIndex = 10;
			this.textBoxHandPhone.Text = "";
			this.textBoxHandPhone.TextChanged += new System.EventHandler(this.textBoxHandPhone_TextChanged);
			// 
			// textBoxPhone
			// 
			this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxPhone.Location = new System.Drawing.Point(384, 328);
			this.textBoxPhone.Name = "textBoxPhone";
			this.textBoxPhone.Size = new System.Drawing.Size(200, 22);
			this.textBoxPhone.TabIndex = 9;
			this.textBoxPhone.Text = "";
			this.textBoxPhone.TextChanged += new System.EventHandler(this.textBoxPhone_TextChanged);
			// 
			// labelPhone
			// 
			this.labelPhone.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelPhone.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelPhone.Location = new System.Drawing.Point(256, 328);
			this.labelPhone.Name = "labelPhone";
			this.labelPhone.Size = new System.Drawing.Size(120, 24);
			this.labelPhone.TabIndex = 110;
			this.labelPhone.Text = "Phone";
			this.labelPhone.Click += new System.EventHandler(this.labelPhone_Click);
			// 
			// textBoxCountry
			// 
			this.textBoxCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxCountry.Location = new System.Drawing.Point(720, 296);
			this.textBoxCountry.Name = "textBoxCountry";
			this.textBoxCountry.Size = new System.Drawing.Size(200, 22);
			this.textBoxCountry.TabIndex = 8;
			this.textBoxCountry.Text = "";
			this.textBoxCountry.TextChanged += new System.EventHandler(this.textBoxCountry_TextChanged);
			// 
			// labelCountry
			// 
			this.labelCountry.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelCountry.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelCountry.Location = new System.Drawing.Point(592, 296);
			this.labelCountry.Name = "labelCountry";
			this.labelCountry.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.labelCountry.Size = new System.Drawing.Size(120, 24);
			this.labelCountry.TabIndex = 109;
			this.labelCountry.Text = "Country";
			this.labelCountry.Click += new System.EventHandler(this.labelCountry_Click);
			// 
			// textBoxState
			// 
			this.textBoxState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxState.Location = new System.Drawing.Point(384, 296);
			this.textBoxState.Name = "textBoxState";
			this.textBoxState.Size = new System.Drawing.Size(200, 22);
			this.textBoxState.TabIndex = 7;
			this.textBoxState.Text = "";
			this.textBoxState.TextChanged += new System.EventHandler(this.textBoxState_TextChanged);
			// 
			// labelState
			// 
			this.labelState.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelState.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelState.Location = new System.Drawing.Point(256, 296);
			this.labelState.Name = "labelState";
			this.labelState.Size = new System.Drawing.Size(120, 24);
			this.labelState.TabIndex = 108;
			this.labelState.Text = "State";
			this.labelState.Click += new System.EventHandler(this.labelState_Click);
			// 
			// textBoxPostCode
			// 
			this.textBoxPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxPostCode.Location = new System.Drawing.Point(720, 264);
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
			this.labelPostCode.Location = new System.Drawing.Point(592, 264);
			this.labelPostCode.Name = "labelPostCode";
			this.labelPostCode.Size = new System.Drawing.Size(120, 24);
			this.labelPostCode.TabIndex = 107;
			this.labelPostCode.Text = "Post Code";
			this.labelPostCode.Click += new System.EventHandler(this.labelPostCode_Click);
			// 
			// textBoxCity
			// 
			this.textBoxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxCity.Location = new System.Drawing.Point(384, 264);
			this.textBoxCity.Name = "textBoxCity";
			this.textBoxCity.Size = new System.Drawing.Size(200, 22);
			this.textBoxCity.TabIndex = 5;
			this.textBoxCity.Text = "";
			this.textBoxCity.TextChanged += new System.EventHandler(this.textBoxCity_TextChanged);
			// 
			// labelCity
			// 
			this.labelCity.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelCity.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelCity.Location = new System.Drawing.Point(256, 264);
			this.labelCity.Name = "labelCity";
			this.labelCity.Size = new System.Drawing.Size(120, 24);
			this.labelCity.TabIndex = 106;
			this.labelCity.Text = "City";
			this.labelCity.Click += new System.EventHandler(this.labelCity_Click);
			// 
			// textBoxAddress
			// 
			this.textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxAddress.Location = new System.Drawing.Point(384, 232);
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
			this.labelAddress.Location = new System.Drawing.Point(256, 232);
			this.labelAddress.Name = "labelAddress";
			this.labelAddress.Size = new System.Drawing.Size(120, 24);
			this.labelAddress.TabIndex = 105;
			this.labelAddress.Text = "Address";
			this.labelAddress.Click += new System.EventHandler(this.labelAddress_Click);
			// 
			// labelMemberGroupCode
			// 
			this.labelMemberGroupCode.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelMemberGroupCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelMemberGroupCode.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelMemberGroupCode.Location = new System.Drawing.Point(256, 200);
			this.labelMemberGroupCode.Name = "labelMemberGroupCode";
			this.labelMemberGroupCode.Size = new System.Drawing.Size(120, 24);
			this.labelMemberGroupCode.TabIndex = 104;
			this.labelMemberGroupCode.Text = "Place / Birth Date";
			this.labelMemberGroupCode.Click += new System.EventHandler(this.labelMemberGroupCode_Click);
			// 
			// textBoxMemberName
			// 
			this.textBoxMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxMemberName.Location = new System.Drawing.Point(384, 168);
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
			this.labelMemberName.Location = new System.Drawing.Point(256, 168);
			this.labelMemberName.Name = "labelMemberName";
			this.labelMemberName.Size = new System.Drawing.Size(120, 24);
			this.labelMemberName.TabIndex = 103;
			this.labelMemberName.Text = "Member Name";
			this.labelMemberName.Click += new System.EventHandler(this.labelMemberName_Click);
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
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// textBoxMemberID
			// 
			this.textBoxMemberID.BackColor = System.Drawing.Color.White;
			this.textBoxMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxMemberID.ForeColor = System.Drawing.SystemColors.ControlText;
			this.textBoxMemberID.Location = new System.Drawing.Point(384, 80);
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
			this.labelMemberID.Location = new System.Drawing.Point(256, 80);
			this.labelMemberID.Name = "labelMemberID";
			this.labelMemberID.Size = new System.Drawing.Size(120, 24);
			this.labelMemberID.TabIndex = 101;
			this.labelMemberID.Text = "Member ID";
			this.labelMemberID.Click += new System.EventHandler(this.labelMemberID_Click);
			// 
			// labelHandPhone
			// 
			this.labelHandPhone.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelHandPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelHandPhone.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelHandPhone.Location = new System.Drawing.Point(592, 328);
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
			this.buttonCancel.Location = new System.Drawing.Point(792, 496);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(136, 40);
			this.buttonCancel.TabIndex = 20;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// buttonSave
			// 
			this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonSave.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
			this.buttonSave.Location = new System.Drawing.Point(640, 496);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(136, 40);
			this.buttonSave.TabIndex = 19;
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
			this.label1.Location = new System.Drawing.Point(256, 392);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 24);
			this.label1.TabIndex = 194;
			this.label1.Text = "Is Baptized ?";
			// 
			// textBoxInChurch
			// 
			this.textBoxInChurch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxInChurch.Location = new System.Drawing.Point(720, 392);
			this.textBoxInChurch.Name = "textBoxInChurch";
			this.textBoxInChurch.Size = new System.Drawing.Size(200, 22);
			this.textBoxInChurch.TabIndex = 15;
			this.textBoxInChurch.Text = "";
			this.textBoxInChurch.TextChanged += new System.EventHandler(this.textBoxInChurch_TextChanged);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label2.Location = new System.Drawing.Point(592, 392);
			this.label2.Name = "label2";
			this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label2.Size = new System.Drawing.Size(120, 24);
			this.label2.TabIndex = 197;
			this.label2.Text = "In Church :";
			// 
			// textBoxPlaceBirthDate
			// 
			this.textBoxPlaceBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxPlaceBirthDate.Location = new System.Drawing.Point(384, 200);
			this.textBoxPlaceBirthDate.Name = "textBoxPlaceBirthDate";
			this.textBoxPlaceBirthDate.Size = new System.Drawing.Size(200, 22);
			this.textBoxPlaceBirthDate.TabIndex = 3;
			this.textBoxPlaceBirthDate.Text = "";
			this.textBoxPlaceBirthDate.TextChanged += new System.EventHandler(this.textBoxPlaceBirthDate_TextChanged);
			// 
			// comboBoxStatus
			// 
			this.comboBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.comboBoxStatus.Items.AddRange(new object[] {
																"Single",
																"Married",
																"Engaged"});
			this.comboBoxStatus.Location = new System.Drawing.Point(384, 424);
			this.comboBoxStatus.Name = "comboBoxStatus";
			this.comboBoxStatus.Size = new System.Drawing.Size(200, 24);
			this.comboBoxStatus.TabIndex = 16;
			this.comboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatus_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label3.Location = new System.Drawing.Point(256, 424);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(120, 24);
			this.label3.TabIndex = 200;
			this.label3.Text = "Status";
			// 
			// comboBoxIsBaptized
			// 
			this.comboBoxIsBaptized.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.comboBoxIsBaptized.Items.AddRange(new object[] {
																	"Already",
																	"Not Yet",
																	"Sidi",
																	"Atestation",
																	"???"});
			this.comboBoxIsBaptized.Location = new System.Drawing.Point(384, 392);
			this.comboBoxIsBaptized.Name = "comboBoxIsBaptized";
			this.comboBoxIsBaptized.Size = new System.Drawing.Size(200, 24);
			this.comboBoxIsBaptized.TabIndex = 14;
			this.comboBoxIsBaptized.Text = "???";
			this.comboBoxIsBaptized.SelectedIndexChanged += new System.EventHandler(this.comboBoxBaptized_SelectedIndexChanged);
			// 
			// textBoxMinistry
			// 
			this.textBoxMinistry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxMinistry.Location = new System.Drawing.Point(384, 456);
			this.textBoxMinistry.Name = "textBoxMinistry";
			this.textBoxMinistry.Size = new System.Drawing.Size(536, 22);
			this.textBoxMinistry.TabIndex = 18;
			this.textBoxMinistry.Text = "";
			this.textBoxMinistry.TextChanged += new System.EventHandler(this.textBoxMinistry_TextChanged);
			// 
			// labelMinistry
			// 
			this.labelMinistry.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelMinistry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelMinistry.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelMinistry.Location = new System.Drawing.Point(256, 456);
			this.labelMinistry.Name = "labelMinistry";
			this.labelMinistry.Size = new System.Drawing.Size(120, 24);
			this.labelMinistry.TabIndex = 203;
			this.labelMinistry.Text = "Ministry";
			// 
			// comboBoxRemark
			// 
			this.comboBoxRemark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.comboBoxRemark.Items.AddRange(new object[] {
																"Active",
																"Non Active"});
			this.comboBoxRemark.Location = new System.Drawing.Point(720, 424);
			this.comboBoxRemark.Name = "comboBoxRemark";
			this.comboBoxRemark.Size = new System.Drawing.Size(200, 24);
			this.comboBoxRemark.TabIndex = 17;
			this.comboBoxRemark.SelectedIndexChanged += new System.EventHandler(this.comboBoxRemark_SelectedIndexChanged);
			// 
			// labelRemark
			// 
			this.labelRemark.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelRemark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelRemark.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelRemark.Location = new System.Drawing.Point(592, 424);
			this.labelRemark.Name = "labelRemark";
			this.labelRemark.Size = new System.Drawing.Size(120, 24);
			this.labelRemark.TabIndex = 206;
			this.labelRemark.Text = "Remark";
			// 
			// FrmMember
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.comboBoxRemark);
			this.Controls.Add(this.labelRemark);
			this.Controls.Add(this.textBoxMinistry);
			this.Controls.Add(this.labelMinistry);
			this.Controls.Add(this.comboBoxIsBaptized);
			this.Controls.Add(this.comboBoxStatus);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxPlaceBirthDate);
			this.Controls.Add(this.textBoxInChurch);
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
			this.Controls.Add(this.labelMemberGroupCode);
			this.Controls.Add(this.textBoxMemberName);
			this.Controls.Add(this.labelMemberName);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.textBoxMemberID);
			this.Controls.Add(this.labelMemberID);
			this.Name = "FrmMember";
			this.Controls.SetChildIndex(this.labelMemberID, 0);
			this.Controls.SetChildIndex(this.textBoxMemberID, 0);
			this.Controls.SetChildIndex(this.pictureBox1, 0);
			this.Controls.SetChildIndex(this.labelMemberName, 0);
			this.Controls.SetChildIndex(this.textBoxMemberName, 0);
			this.Controls.SetChildIndex(this.labelMemberGroupCode, 0);
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
			this.Controls.SetChildIndex(this.textBoxInChurch, 0);
			this.Controls.SetChildIndex(this.textBoxPlaceBirthDate, 0);
			this.Controls.SetChildIndex(this.label3, 0);
			this.Controls.SetChildIndex(this.comboBoxStatus, 0);
			this.Controls.SetChildIndex(this.comboBoxIsBaptized, 0);
			this.Controls.SetChildIndex(this.labelMinistry, 0);
			this.Controls.SetChildIndex(this.textBoxMinistry, 0);
			this.Controls.SetChildIndex(this.labelRemark, 0);
			this.Controls.SetChildIndex(this.comboBoxRemark, 0);
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

		private void textBoxCity_TextChanged(object sender, System.EventArgs e)
		{
			MyMember.City = textBoxCity.Text.ToString();
		}

		private void textBoxPostCode_TextChanged(object sender, System.EventArgs e)
		{
			MyMember.PostCode = textBoxPostCode.Text.ToString();
		}

		private void textBoxState_TextChanged(object sender, System.EventArgs e)
		{
			MyMember.State = textBoxState.Text.ToString();
		}

		private void textBoxCountry_TextChanged(object sender, System.EventArgs e)
		{
			MyMember.Country = textBoxCountry.Text.ToString();
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

		private void comboBoxStatus_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			MyMember.Status  = comboBoxStatus.Text.ToString();
		}

		private void comboBoxRemark_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			MyMember.Remark = comboBoxRemark.Text.ToString();
		}

		private void textBoxMinistry_TextChanged(object sender, System.EventArgs e)
		{
			MyMember.Ministry = textBoxMinistry.Text.ToString();
		}

		private void comboBoxBaptized_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			MyMember.Isbaptised = comboBoxIsBaptized.Text.ToString();
		}

		private void textBoxInChurch_TextChanged(object sender, System.EventArgs e)
		{
			MyMember.InChurch = textBoxInChurch.Text.ToString();
		}

		private void textBoxPlaceBirthDate_TextChanged(object sender, System.EventArgs e)
		{
			MyMember.PlaceDateBirthDate = textBoxPlaceBirthDate.Text.ToString();
		}

		private void labelPhone_Click(object sender, System.EventArgs e)
		{
		
		}

		private void labelCountry_Click(object sender, System.EventArgs e)
		{
		
		}

		private void labelState_Click(object sender, System.EventArgs e)
		{
		
		}

		private void labelPostCode_Click(object sender, System.EventArgs e)
		{
		
		}

		private void labelCity_Click(object sender, System.EventArgs e)
		{
		
		}

		private void labelAddress_Click(object sender, System.EventArgs e)
		{
		
		}

		private void labelMemberGroupCode_Click(object sender, System.EventArgs e)
		{
		
		}

		private void labelMemberName_Click(object sender, System.EventArgs e)
		{
		
		}

		private void pictureBox1_Click(object sender, System.EventArgs e)
		{
		
		}

		private void labelMemberID_Click(object sender, System.EventArgs e)
		{
		
		}


		






	}
}

