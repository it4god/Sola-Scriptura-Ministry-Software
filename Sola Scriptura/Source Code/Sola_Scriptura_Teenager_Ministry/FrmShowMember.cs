using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Teenager_Ministry
{
	public class FrmShowMember : Teenager_Ministry.FrmSearchMemberMaster
	{
		internal System.Windows.Forms.Label LabelTitle;
		internal System.Windows.Forms.PictureBox pictureBoxLogoPicture;
		internal System.Windows.Forms.TextBox textBoxPhotoPath;
		internal System.Windows.Forms.Label label9;
		internal System.Windows.Forms.TextBox textBoxTalents;
		internal System.Windows.Forms.TextBox textBoxParentEmail;
		internal System.Windows.Forms.Label label8;
		internal System.Windows.Forms.TextBox textBoxHobbies;
		internal System.Windows.Forms.Label label4;
		internal System.Windows.Forms.Label label6;
		internal System.Windows.Forms.TextBox textBoxMotherName;
		internal System.Windows.Forms.Label label7;
		internal System.Windows.Forms.TextBox textBoxParentHP;
		internal System.Windows.Forms.Label label5;
		internal System.Windows.Forms.ComboBox comboBoxRemark;
		internal System.Windows.Forms.Label labelRemark;
		internal System.Windows.Forms.Label labelMinistry;
		internal System.Windows.Forms.Label label3;
		internal System.Windows.Forms.TextBox textBoxPlaceBirthDate;
		internal System.Windows.Forms.TextBox textBoxInChurch;
		internal System.Windows.Forms.Label label2;
		internal System.Windows.Forms.Label label1;
		internal System.Windows.Forms.Label labelHandPhone;
		internal System.Windows.Forms.Label labelEmail;
		internal System.Windows.Forms.TextBox textBoxHandPhone;
		internal System.Windows.Forms.Label labelPhone;
		internal System.Windows.Forms.TextBox textBoxPostCode;
		internal System.Windows.Forms.Label labelPostCode;
		internal System.Windows.Forms.Label labelCity;
		internal System.Windows.Forms.TextBox textBoxAddress;
		internal System.Windows.Forms.Label labelAddress;
		internal System.Windows.Forms.Label labelMemberGroupCode;
		internal System.Windows.Forms.TextBox textBoxMemberName;
		internal System.Windows.Forms.Label labelMemberName;
		internal System.Windows.Forms.PictureBox pictureBox1;
		internal System.Windows.Forms.TextBox textBoxMemberID;
		internal System.Windows.Forms.Label labelMemberID;
		internal System.Windows.Forms.TextBox textBoxRegion;
		internal System.Windows.Forms.TextBox textBoxFatherName;
		internal System.Windows.Forms.ComboBox comboBoxIsBaptized;
		internal System.Windows.Forms.ComboBox comboBoxStatus;
		internal System.Windows.Forms.TextBox textBoxEmail;
		internal System.Windows.Forms.TextBox textBoxPhone;
		private System.ComponentModel.IContainer components = null;

		public FrmShowMember()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public FrmShowMember(FrmMDI MDIForm)
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmShowMember));
			this.LabelTitle = new System.Windows.Forms.Label();
			this.pictureBoxLogoPicture = new System.Windows.Forms.PictureBox();
			this.textBoxPhotoPath = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.textBoxTalents = new System.Windows.Forms.TextBox();
			this.textBoxParentEmail = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textBoxHobbies = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxMotherName = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBoxParentHP = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBoxRemark = new System.Windows.Forms.ComboBox();
			this.labelRemark = new System.Windows.Forms.Label();
			this.labelMinistry = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxPlaceBirthDate = new System.Windows.Forms.TextBox();
			this.textBoxInChurch = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.labelHandPhone = new System.Windows.Forms.Label();
			this.labelEmail = new System.Windows.Forms.Label();
			this.textBoxHandPhone = new System.Windows.Forms.TextBox();
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
			this.textBoxRegion = new System.Windows.Forms.TextBox();
			this.textBoxFatherName = new System.Windows.Forms.TextBox();
			this.comboBoxIsBaptized = new System.Windows.Forms.ComboBox();
			this.comboBoxStatus = new System.Windows.Forms.ComboBox();
			this.textBoxEmail = new System.Windows.Forms.TextBox();
			this.textBoxPhone = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// LabelTitle
			// 
			this.LabelTitle.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.LabelTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.LabelTitle.Image = ((System.Drawing.Image)(resources.GetObject("LabelTitle.Image")));
			this.LabelTitle.Location = new System.Drawing.Point(800, 16);
			this.LabelTitle.Name = "LabelTitle";
			this.LabelTitle.Size = new System.Drawing.Size(192, 32);
			this.LabelTitle.TabIndex = 228;
			this.LabelTitle.Text = "    Show Member";
			this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBoxLogoPicture
			// 
			this.pictureBoxLogoPicture.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogoPicture.Image")));
			this.pictureBoxLogoPicture.Location = new System.Drawing.Point(32, 464);
			this.pictureBoxLogoPicture.Name = "pictureBoxLogoPicture";
			this.pictureBoxLogoPicture.Size = new System.Drawing.Size(144, 88);
			this.pictureBoxLogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxLogoPicture.TabIndex = 240;
			this.pictureBoxLogoPicture.TabStop = false;
			// 
			// textBoxPhotoPath
			// 
			this.textBoxPhotoPath.BackColor = System.Drawing.Color.White;
			this.textBoxPhotoPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxPhotoPath.ForeColor = System.Drawing.SystemColors.ControlText;
			this.textBoxPhotoPath.Location = new System.Drawing.Point(392, 112);
			this.textBoxPhotoPath.Name = "textBoxPhotoPath";
			this.textBoxPhotoPath.Size = new System.Drawing.Size(488, 22);
			this.textBoxPhotoPath.TabIndex = 2;
			this.textBoxPhotoPath.Text = "";
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label9.Location = new System.Drawing.Point(264, 112);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(120, 24);
			this.label9.TabIndex = 275;
			this.label9.Text = "Photo Path";
			// 
			// textBoxTalents
			// 
			this.textBoxTalents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxTalents.Location = new System.Drawing.Point(392, 472);
			this.textBoxTalents.Name = "textBoxTalents";
			this.textBoxTalents.Size = new System.Drawing.Size(536, 22);
			this.textBoxTalents.TabIndex = 19;
			this.textBoxTalents.Text = "";
			// 
			// textBoxParentEmail
			// 
			this.textBoxParentEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxParentEmail.Location = new System.Drawing.Point(728, 312);
			this.textBoxParentEmail.Name = "textBoxParentEmail";
			this.textBoxParentEmail.Size = new System.Drawing.Size(200, 22);
			this.textBoxParentEmail.TabIndex = 11;
			this.textBoxParentEmail.Text = "";
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label8.Location = new System.Drawing.Point(600, 312);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(120, 24);
			this.label8.TabIndex = 274;
			this.label8.Text = "Parent\'s Email";
			// 
			// textBoxHobbies
			// 
			this.textBoxHobbies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxHobbies.Location = new System.Drawing.Point(392, 504);
			this.textBoxHobbies.Name = "textBoxHobbies";
			this.textBoxHobbies.Size = new System.Drawing.Size(536, 22);
			this.textBoxHobbies.TabIndex = 20;
			this.textBoxHobbies.Text = "";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label4.Location = new System.Drawing.Point(264, 504);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(120, 24);
			this.label4.TabIndex = 273;
			this.label4.Text = "Hobbies";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label6.Location = new System.Drawing.Point(600, 344);
			this.label6.Name = "label6";
			this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label6.Size = new System.Drawing.Size(120, 24);
			this.label6.TabIndex = 272;
			this.label6.Text = "Mother\'s Name";
			// 
			// textBoxMotherName
			// 
			this.textBoxMotherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxMotherName.Location = new System.Drawing.Point(728, 344);
			this.textBoxMotherName.Name = "textBoxMotherName";
			this.textBoxMotherName.Size = new System.Drawing.Size(200, 22);
			this.textBoxMotherName.TabIndex = 13;
			this.textBoxMotherName.Text = "";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label7.Location = new System.Drawing.Point(264, 344);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(120, 24);
			this.label7.TabIndex = 271;
			this.label7.Text = "Father\'s Name";
			// 
			// textBoxParentHP
			// 
			this.textBoxParentHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxParentHP.Location = new System.Drawing.Point(392, 376);
			this.textBoxParentHP.Name = "textBoxParentHP";
			this.textBoxParentHP.Size = new System.Drawing.Size(536, 22);
			this.textBoxParentHP.TabIndex = 14;
			this.textBoxParentHP.Text = "";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label5.Location = new System.Drawing.Point(264, 376);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(120, 24);
			this.label5.TabIndex = 270;
			this.label5.Text = "Parent\'s HP";
			// 
			// comboBoxRemark
			// 
			this.comboBoxRemark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.comboBoxRemark.Items.AddRange(new object[] {
																"Remaja1",
																"Remaja2"});
			this.comboBoxRemark.Location = new System.Drawing.Point(728, 440);
			this.comboBoxRemark.Name = "comboBoxRemark";
			this.comboBoxRemark.Size = new System.Drawing.Size(200, 24);
			this.comboBoxRemark.TabIndex = 18;
			this.comboBoxRemark.Text = "Remaja1";
			// 
			// labelRemark
			// 
			this.labelRemark.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelRemark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelRemark.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelRemark.Location = new System.Drawing.Point(600, 440);
			this.labelRemark.Name = "labelRemark";
			this.labelRemark.Size = new System.Drawing.Size(120, 24);
			this.labelRemark.TabIndex = 269;
			this.labelRemark.Text = "Remark";
			// 
			// labelMinistry
			// 
			this.labelMinistry.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelMinistry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelMinistry.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelMinistry.Location = new System.Drawing.Point(264, 472);
			this.labelMinistry.Name = "labelMinistry";
			this.labelMinistry.Size = new System.Drawing.Size(120, 24);
			this.labelMinistry.TabIndex = 268;
			this.labelMinistry.Text = "Instrument Talents";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label3.Location = new System.Drawing.Point(264, 440);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(120, 24);
			this.label3.TabIndex = 267;
			this.label3.Text = "Status";
			// 
			// textBoxPlaceBirthDate
			// 
			this.textBoxPlaceBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxPlaceBirthDate.Location = new System.Drawing.Point(392, 184);
			this.textBoxPlaceBirthDate.Name = "textBoxPlaceBirthDate";
			this.textBoxPlaceBirthDate.Size = new System.Drawing.Size(536, 22);
			this.textBoxPlaceBirthDate.TabIndex = 4;
			this.textBoxPlaceBirthDate.Text = "";
			// 
			// textBoxInChurch
			// 
			this.textBoxInChurch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxInChurch.Location = new System.Drawing.Point(728, 408);
			this.textBoxInChurch.Name = "textBoxInChurch";
			this.textBoxInChurch.Size = new System.Drawing.Size(200, 22);
			this.textBoxInChurch.TabIndex = 16;
			this.textBoxInChurch.Text = "";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label2.Location = new System.Drawing.Point(600, 408);
			this.label2.Name = "label2";
			this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label2.Size = new System.Drawing.Size(120, 24);
			this.label2.TabIndex = 266;
			this.label2.Text = "In Church :";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label1.Location = new System.Drawing.Point(264, 408);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 24);
			this.label1.TabIndex = 265;
			this.label1.Text = "Is Baptized ?";
			// 
			// labelHandPhone
			// 
			this.labelHandPhone.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelHandPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelHandPhone.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelHandPhone.Location = new System.Drawing.Point(600, 280);
			this.labelHandPhone.Name = "labelHandPhone";
			this.labelHandPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.labelHandPhone.Size = new System.Drawing.Size(120, 24);
			this.labelHandPhone.TabIndex = 264;
			this.labelHandPhone.Text = "Hand Phone";
			// 
			// labelEmail
			// 
			this.labelEmail.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelEmail.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelEmail.Location = new System.Drawing.Point(264, 312);
			this.labelEmail.Name = "labelEmail";
			this.labelEmail.Size = new System.Drawing.Size(120, 24);
			this.labelEmail.TabIndex = 263;
			this.labelEmail.Text = "Email";
			// 
			// textBoxHandPhone
			// 
			this.textBoxHandPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxHandPhone.Location = new System.Drawing.Point(728, 280);
			this.textBoxHandPhone.Name = "textBoxHandPhone";
			this.textBoxHandPhone.Size = new System.Drawing.Size(200, 22);
			this.textBoxHandPhone.TabIndex = 9;
			this.textBoxHandPhone.Text = "";
			// 
			// labelPhone
			// 
			this.labelPhone.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelPhone.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelPhone.Location = new System.Drawing.Point(264, 280);
			this.labelPhone.Name = "labelPhone";
			this.labelPhone.Size = new System.Drawing.Size(120, 24);
			this.labelPhone.TabIndex = 262;
			this.labelPhone.Text = "Phone";
			// 
			// textBoxPostCode
			// 
			this.textBoxPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxPostCode.Location = new System.Drawing.Point(728, 248);
			this.textBoxPostCode.Name = "textBoxPostCode";
			this.textBoxPostCode.Size = new System.Drawing.Size(200, 22);
			this.textBoxPostCode.TabIndex = 7;
			this.textBoxPostCode.Text = "";
			// 
			// labelPostCode
			// 
			this.labelPostCode.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelPostCode.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelPostCode.Location = new System.Drawing.Point(600, 248);
			this.labelPostCode.Name = "labelPostCode";
			this.labelPostCode.Size = new System.Drawing.Size(120, 24);
			this.labelPostCode.TabIndex = 261;
			this.labelPostCode.Text = "Post Code";
			// 
			// labelCity
			// 
			this.labelCity.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelCity.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelCity.Location = new System.Drawing.Point(264, 248);
			this.labelCity.Name = "labelCity";
			this.labelCity.Size = new System.Drawing.Size(120, 24);
			this.labelCity.TabIndex = 260;
			this.labelCity.Text = "Region";
			// 
			// textBoxAddress
			// 
			this.textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxAddress.Location = new System.Drawing.Point(392, 216);
			this.textBoxAddress.Name = "textBoxAddress";
			this.textBoxAddress.Size = new System.Drawing.Size(536, 22);
			this.textBoxAddress.TabIndex = 5;
			this.textBoxAddress.Text = "";
			// 
			// labelAddress
			// 
			this.labelAddress.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelAddress.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelAddress.Location = new System.Drawing.Point(264, 216);
			this.labelAddress.Name = "labelAddress";
			this.labelAddress.Size = new System.Drawing.Size(120, 24);
			this.labelAddress.TabIndex = 259;
			this.labelAddress.Text = "Address";
			// 
			// labelMemberGroupCode
			// 
			this.labelMemberGroupCode.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelMemberGroupCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelMemberGroupCode.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelMemberGroupCode.Location = new System.Drawing.Point(264, 184);
			this.labelMemberGroupCode.Name = "labelMemberGroupCode";
			this.labelMemberGroupCode.Size = new System.Drawing.Size(120, 24);
			this.labelMemberGroupCode.TabIndex = 258;
			this.labelMemberGroupCode.Text = "Place / Birth Date";
			// 
			// textBoxMemberName
			// 
			this.textBoxMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxMemberName.Location = new System.Drawing.Point(392, 152);
			this.textBoxMemberName.Name = "textBoxMemberName";
			this.textBoxMemberName.Size = new System.Drawing.Size(536, 22);
			this.textBoxMemberName.TabIndex = 3;
			this.textBoxMemberName.Text = "";
			// 
			// labelMemberName
			// 
			this.labelMemberName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelMemberName.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelMemberName.Location = new System.Drawing.Point(264, 152);
			this.labelMemberName.Name = "labelMemberName";
			this.labelMemberName.Size = new System.Drawing.Size(120, 24);
			this.labelMemberName.TabIndex = 257;
			this.labelMemberName.Text = "Member Name";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(240, 136);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(680, 10);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 256;
			this.pictureBox1.TabStop = false;
			// 
			// textBoxMemberID
			// 
			this.textBoxMemberID.BackColor = System.Drawing.Color.White;
			this.textBoxMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxMemberID.ForeColor = System.Drawing.SystemColors.ControlText;
			this.textBoxMemberID.Location = new System.Drawing.Point(392, 88);
			this.textBoxMemberID.Name = "textBoxMemberID";
			this.textBoxMemberID.Size = new System.Drawing.Size(200, 22);
			this.textBoxMemberID.TabIndex = 1;
			this.textBoxMemberID.Text = "";
			// 
			// labelMemberID
			// 
			this.labelMemberID.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelMemberID.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelMemberID.Location = new System.Drawing.Point(264, 88);
			this.labelMemberID.Name = "labelMemberID";
			this.labelMemberID.Size = new System.Drawing.Size(120, 24);
			this.labelMemberID.TabIndex = 255;
			this.labelMemberID.Text = "Member ID";
			// 
			// textBoxRegion
			// 
			this.textBoxRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxRegion.Location = new System.Drawing.Point(392, 248);
			this.textBoxRegion.Name = "textBoxRegion";
			this.textBoxRegion.Size = new System.Drawing.Size(200, 22);
			this.textBoxRegion.TabIndex = 6;
			this.textBoxRegion.Text = "";
			// 
			// textBoxFatherName
			// 
			this.textBoxFatherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxFatherName.Location = new System.Drawing.Point(392, 344);
			this.textBoxFatherName.Name = "textBoxFatherName";
			this.textBoxFatherName.Size = new System.Drawing.Size(200, 22);
			this.textBoxFatherName.TabIndex = 12;
			this.textBoxFatherName.Text = "";
			// 
			// comboBoxIsBaptized
			// 
			this.comboBoxIsBaptized.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.comboBoxIsBaptized.Items.AddRange(new object[] {
																	"Sudah",
																	"Belum",
																	"???"});
			this.comboBoxIsBaptized.Location = new System.Drawing.Point(392, 408);
			this.comboBoxIsBaptized.Name = "comboBoxIsBaptized";
			this.comboBoxIsBaptized.Size = new System.Drawing.Size(200, 24);
			this.comboBoxIsBaptized.TabIndex = 15;
			this.comboBoxIsBaptized.Text = "???";
			// 
			// comboBoxStatus
			// 
			this.comboBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.comboBoxStatus.Items.AddRange(new object[] {
																"Working",
																"Student"});
			this.comboBoxStatus.Location = new System.Drawing.Point(392, 440);
			this.comboBoxStatus.Name = "comboBoxStatus";
			this.comboBoxStatus.Size = new System.Drawing.Size(200, 24);
			this.comboBoxStatus.TabIndex = 17;
			// 
			// textBoxEmail
			// 
			this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxEmail.Location = new System.Drawing.Point(392, 312);
			this.textBoxEmail.Name = "textBoxEmail";
			this.textBoxEmail.Size = new System.Drawing.Size(200, 22);
			this.textBoxEmail.TabIndex = 10;
			this.textBoxEmail.Text = "";
			// 
			// textBoxPhone
			// 
			this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxPhone.Location = new System.Drawing.Point(392, 280);
			this.textBoxPhone.Name = "textBoxPhone";
			this.textBoxPhone.Size = new System.Drawing.Size(200, 22);
			this.textBoxPhone.TabIndex = 8;
			this.textBoxPhone.Text = "";
			// 
			// FrmShowMember
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.textBoxRegion);
			this.Controls.Add(this.textBoxFatherName);
			this.Controls.Add(this.comboBoxIsBaptized);
			this.Controls.Add(this.comboBoxStatus);
			this.Controls.Add(this.textBoxEmail);
			this.Controls.Add(this.textBoxPhone);
			this.Controls.Add(this.textBoxPhotoPath);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.textBoxTalents);
			this.Controls.Add(this.textBoxParentEmail);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.textBoxHobbies);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBoxMotherName);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBoxParentHP);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.comboBoxRemark);
			this.Controls.Add(this.labelRemark);
			this.Controls.Add(this.labelMinistry);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxPlaceBirthDate);
			this.Controls.Add(this.textBoxInChurch);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.labelHandPhone);
			this.Controls.Add(this.labelEmail);
			this.Controls.Add(this.textBoxHandPhone);
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
			this.Controls.Add(this.pictureBoxLogoPicture);
			this.Controls.Add(this.LabelTitle);
			this.Name = "FrmShowMember";
			this.Controls.SetChildIndex(this.LabelTitle, 0);
			this.Controls.SetChildIndex(this.pictureBoxLogoPicture, 0);
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
			this.Controls.SetChildIndex(this.textBoxHandPhone, 0);
			this.Controls.SetChildIndex(this.labelEmail, 0);
			this.Controls.SetChildIndex(this.labelHandPhone, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.textBoxInChurch, 0);
			this.Controls.SetChildIndex(this.textBoxPlaceBirthDate, 0);
			this.Controls.SetChildIndex(this.label3, 0);
			this.Controls.SetChildIndex(this.labelMinistry, 0);
			this.Controls.SetChildIndex(this.labelRemark, 0);
			this.Controls.SetChildIndex(this.comboBoxRemark, 0);
			this.Controls.SetChildIndex(this.label5, 0);
			this.Controls.SetChildIndex(this.textBoxParentHP, 0);
			this.Controls.SetChildIndex(this.label7, 0);
			this.Controls.SetChildIndex(this.textBoxMotherName, 0);
			this.Controls.SetChildIndex(this.label6, 0);
			this.Controls.SetChildIndex(this.label4, 0);
			this.Controls.SetChildIndex(this.textBoxHobbies, 0);
			this.Controls.SetChildIndex(this.label8, 0);
			this.Controls.SetChildIndex(this.textBoxParentEmail, 0);
			this.Controls.SetChildIndex(this.textBoxTalents, 0);
			this.Controls.SetChildIndex(this.label9, 0);
			this.Controls.SetChildIndex(this.textBoxPhotoPath, 0);
			this.Controls.SetChildIndex(this.textBoxPhone, 0);
			this.Controls.SetChildIndex(this.textBoxEmail, 0);
			this.Controls.SetChildIndex(this.comboBoxStatus, 0);
			this.Controls.SetChildIndex(this.comboBoxIsBaptized, 0);
			this.Controls.SetChildIndex(this.textBoxFatherName, 0);
			this.Controls.SetChildIndex(this.textBoxRegion, 0);
			this.ResumeLayout(false);

		}
		#endregion
	}
}

