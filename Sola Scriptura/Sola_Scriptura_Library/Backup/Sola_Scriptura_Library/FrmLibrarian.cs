using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Sola_Scriptura_Library
{
	public class FrmLibrarian : Sola_Scriptura_Library.FrmFormParent
	{
		internal System.Windows.Forms.Label LabelTitle;
		internal System.Windows.Forms.PictureBox pictureBox1;
		internal System.Windows.Forms.Label labelLibrarianID;
		internal System.Windows.Forms.TextBox textBoxLibrarianID;
		internal System.Windows.Forms.TextBox textBoxUserName;
		internal System.Windows.Forms.Label labelUserName;
		internal System.Windows.Forms.TextBox textBoxPassword;
		internal System.Windows.Forms.Label labelUserPassword;
		internal System.Windows.Forms.TextBox textBoxLibrarianName;
		internal System.Windows.Forms.Label labelLibrarianName;
		internal System.Windows.Forms.Label labelLibrarianGroup;
		internal System.Windows.Forms.ComboBox comboBoxLibrarianGroup;
		internal System.Windows.Forms.TextBox textBoxAddress;
		internal System.Windows.Forms.Label labelAddress;
		internal System.Windows.Forms.TextBox textBoxPostCode;
		internal System.Windows.Forms.Label labelPostCode;
		internal System.Windows.Forms.TextBox textBoxCity;
		internal System.Windows.Forms.Label labelCity;
		internal System.Windows.Forms.TextBox textBoxCountry;
		internal System.Windows.Forms.Label labelCountry;
		internal System.Windows.Forms.TextBox textBoxState;
		internal System.Windows.Forms.Label labelState;
		internal System.Windows.Forms.TextBox textBoxHandPhone;
		internal System.Windows.Forms.Label labelHandPhone;
		internal System.Windows.Forms.TextBox textBoxPhone;
		internal System.Windows.Forms.Label labelPhone;
		internal System.Windows.Forms.TextBox textBoxEmail;
		internal System.Windows.Forms.Label labelEmail;
		internal System.Windows.Forms.Label labelLocationCode;
		internal System.Windows.Forms.TextBox textBoxLocationCode;
		internal System.Windows.Forms.Button buttonSave;
		internal System.Windows.Forms.Button buttonCancel;
		private System.ComponentModel.IContainer components = null;

		internal ClassDatabase MyClassDatabase;
		internal System.Windows.Forms.PictureBox pictureBoxLogoPicture;

		internal Librarian MyLibrarian;
		public FrmLibrarian()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public FrmLibrarian(FrmMDI MDIForm)
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmLibrarian));
			this.LabelTitle = new System.Windows.Forms.Label();
			this.labelLibrarianID = new System.Windows.Forms.Label();
			this.textBoxLibrarianID = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.textBoxUserName = new System.Windows.Forms.TextBox();
			this.labelUserName = new System.Windows.Forms.Label();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.labelUserPassword = new System.Windows.Forms.Label();
			this.textBoxLibrarianName = new System.Windows.Forms.TextBox();
			this.labelLibrarianName = new System.Windows.Forms.Label();
			this.labelLibrarianGroup = new System.Windows.Forms.Label();
			this.comboBoxLibrarianGroup = new System.Windows.Forms.ComboBox();
			this.textBoxAddress = new System.Windows.Forms.TextBox();
			this.labelAddress = new System.Windows.Forms.Label();
			this.textBoxPostCode = new System.Windows.Forms.TextBox();
			this.labelPostCode = new System.Windows.Forms.Label();
			this.textBoxCity = new System.Windows.Forms.TextBox();
			this.labelCity = new System.Windows.Forms.Label();
			this.textBoxCountry = new System.Windows.Forms.TextBox();
			this.labelCountry = new System.Windows.Forms.Label();
			this.textBoxState = new System.Windows.Forms.TextBox();
			this.labelState = new System.Windows.Forms.Label();
			this.textBoxHandPhone = new System.Windows.Forms.TextBox();
			this.labelHandPhone = new System.Windows.Forms.Label();
			this.textBoxPhone = new System.Windows.Forms.TextBox();
			this.labelPhone = new System.Windows.Forms.Label();
			this.textBoxEmail = new System.Windows.Forms.TextBox();
			this.labelEmail = new System.Windows.Forms.Label();
			this.labelLocationCode = new System.Windows.Forms.Label();
			this.textBoxLocationCode = new System.Windows.Forms.TextBox();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.pictureBoxLogoPicture = new System.Windows.Forms.PictureBox();
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
			this.LabelTitle.TabIndex = 59;
			this.LabelTitle.Text = "    Title";
			this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelLibrarianID
			// 
			this.labelLibrarianID.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelLibrarianID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelLibrarianID.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelLibrarianID.Location = new System.Drawing.Point(256, 80);
			this.labelLibrarianID.Name = "labelLibrarianID";
			this.labelLibrarianID.Size = new System.Drawing.Size(120, 24);
			this.labelLibrarianID.TabIndex = 64;
			this.labelLibrarianID.Text = "Librarian ID";
			// 
			// textBoxLibrarianID
			// 
			this.textBoxLibrarianID.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxLibrarianID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxLibrarianID.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxLibrarianID.Location = new System.Drawing.Point(384, 80);
			this.textBoxLibrarianID.Name = "textBoxLibrarianID";
			this.textBoxLibrarianID.ReadOnly = true;
			this.textBoxLibrarianID.Size = new System.Drawing.Size(200, 22);
			this.textBoxLibrarianID.TabIndex = 0;
			this.textBoxLibrarianID.Text = "";
			this.textBoxLibrarianID.TextChanged += new System.EventHandler(this.textBoxLibrarianID_TextChanged);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(232, 112);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(680, 10);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 66;
			this.pictureBox1.TabStop = false;
			// 
			// textBoxUserName
			// 
			this.textBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxUserName.Location = new System.Drawing.Point(384, 136);
			this.textBoxUserName.Name = "textBoxUserName";
			this.textBoxUserName.Size = new System.Drawing.Size(200, 22);
			this.textBoxUserName.TabIndex = 1;
			this.textBoxUserName.Text = "";
			this.textBoxUserName.TextChanged += new System.EventHandler(this.textBoxUserName_TextChanged);
			// 
			// labelUserName
			// 
			this.labelUserName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelUserName.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelUserName.Location = new System.Drawing.Point(256, 136);
			this.labelUserName.Name = "labelUserName";
			this.labelUserName.Size = new System.Drawing.Size(120, 24);
			this.labelUserName.TabIndex = 67;
			this.labelUserName.Text = "User Name";
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxPassword.Location = new System.Drawing.Point(720, 136);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.PasswordChar = '*';
			this.textBoxPassword.Size = new System.Drawing.Size(200, 22);
			this.textBoxPassword.TabIndex = 2;
			this.textBoxPassword.Text = "";
			this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
			// 
			// labelUserPassword
			// 
			this.labelUserPassword.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelUserPassword.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelUserPassword.Location = new System.Drawing.Point(592, 136);
			this.labelUserPassword.Name = "labelUserPassword";
			this.labelUserPassword.Size = new System.Drawing.Size(120, 24);
			this.labelUserPassword.TabIndex = 69;
			this.labelUserPassword.Text = "User Password";
			// 
			// textBoxLibrarianName
			// 
			this.textBoxLibrarianName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxLibrarianName.Location = new System.Drawing.Point(384, 168);
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
			this.labelLibrarianName.Location = new System.Drawing.Point(256, 168);
			this.labelLibrarianName.Name = "labelLibrarianName";
			this.labelLibrarianName.Size = new System.Drawing.Size(120, 24);
			this.labelLibrarianName.TabIndex = 71;
			this.labelLibrarianName.Text = "Librarian Name";
			// 
			// labelLibrarianGroup
			// 
			this.labelLibrarianGroup.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelLibrarianGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelLibrarianGroup.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelLibrarianGroup.Location = new System.Drawing.Point(592, 168);
			this.labelLibrarianGroup.Name = "labelLibrarianGroup";
			this.labelLibrarianGroup.Size = new System.Drawing.Size(120, 24);
			this.labelLibrarianGroup.TabIndex = 73;
			this.labelLibrarianGroup.Text = "Librarian Group";
			// 
			// comboBoxLibrarianGroup
			// 
			this.comboBoxLibrarianGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.comboBoxLibrarianGroup.Items.AddRange(new object[] {
																		"Administrator",
																		"User"});
			this.comboBoxLibrarianGroup.Location = new System.Drawing.Point(720, 168);
			this.comboBoxLibrarianGroup.Name = "comboBoxLibrarianGroup";
			this.comboBoxLibrarianGroup.Size = new System.Drawing.Size(200, 24);
			this.comboBoxLibrarianGroup.TabIndex = 4;
			this.comboBoxLibrarianGroup.TextChanged += new System.EventHandler(this.comboBoxLibrarianGroup_TextChanged);
			this.comboBoxLibrarianGroup.SelectedIndexChanged += new System.EventHandler(this.comboBoxLibrarianGroup_SelectedIndexChanged);
			// 
			// textBoxAddress
			// 
			this.textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxAddress.Location = new System.Drawing.Point(384, 200);
			this.textBoxAddress.Name = "textBoxAddress";
			this.textBoxAddress.Size = new System.Drawing.Size(536, 22);
			this.textBoxAddress.TabIndex = 5;
			this.textBoxAddress.Text = "";
			this.textBoxAddress.TextChanged += new System.EventHandler(this.textBoxAddress_TextChanged);
			// 
			// labelAddress
			// 
			this.labelAddress.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelAddress.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelAddress.Location = new System.Drawing.Point(256, 200);
			this.labelAddress.Name = "labelAddress";
			this.labelAddress.Size = new System.Drawing.Size(120, 24);
			this.labelAddress.TabIndex = 75;
			this.labelAddress.Text = "Address";
			// 
			// textBoxPostCode
			// 
			this.textBoxPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxPostCode.Location = new System.Drawing.Point(720, 232);
			this.textBoxPostCode.Name = "textBoxPostCode";
			this.textBoxPostCode.Size = new System.Drawing.Size(200, 22);
			this.textBoxPostCode.TabIndex = 7;
			this.textBoxPostCode.Text = "";
			this.textBoxPostCode.TextChanged += new System.EventHandler(this.textBoxPostCode_TextChanged);
			// 
			// labelPostCode
			// 
			this.labelPostCode.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelPostCode.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelPostCode.Location = new System.Drawing.Point(592, 232);
			this.labelPostCode.Name = "labelPostCode";
			this.labelPostCode.Size = new System.Drawing.Size(120, 24);
			this.labelPostCode.TabIndex = 79;
			this.labelPostCode.Text = "Post Code";
			// 
			// textBoxCity
			// 
			this.textBoxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxCity.Location = new System.Drawing.Point(384, 232);
			this.textBoxCity.Name = "textBoxCity";
			this.textBoxCity.Size = new System.Drawing.Size(200, 22);
			this.textBoxCity.TabIndex = 6;
			this.textBoxCity.Text = "";
			this.textBoxCity.TextChanged += new System.EventHandler(this.textBoxCity_TextChanged);
			// 
			// labelCity
			// 
			this.labelCity.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelCity.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelCity.Location = new System.Drawing.Point(256, 232);
			this.labelCity.Name = "labelCity";
			this.labelCity.Size = new System.Drawing.Size(120, 24);
			this.labelCity.TabIndex = 77;
			this.labelCity.Text = "City";
			// 
			// textBoxCountry
			// 
			this.textBoxCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxCountry.Location = new System.Drawing.Point(720, 264);
			this.textBoxCountry.Name = "textBoxCountry";
			this.textBoxCountry.Size = new System.Drawing.Size(200, 22);
			this.textBoxCountry.TabIndex = 9;
			this.textBoxCountry.Text = "";
			this.textBoxCountry.TextChanged += new System.EventHandler(this.textBoxCountry_TextChanged);
			// 
			// labelCountry
			// 
			this.labelCountry.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelCountry.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelCountry.Location = new System.Drawing.Point(592, 264);
			this.labelCountry.Name = "labelCountry";
			this.labelCountry.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.labelCountry.Size = new System.Drawing.Size(120, 24);
			this.labelCountry.TabIndex = 83;
			this.labelCountry.Text = "Country";
			// 
			// textBoxState
			// 
			this.textBoxState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxState.Location = new System.Drawing.Point(384, 264);
			this.textBoxState.Name = "textBoxState";
			this.textBoxState.Size = new System.Drawing.Size(200, 22);
			this.textBoxState.TabIndex = 8;
			this.textBoxState.Text = "";
			this.textBoxState.TextChanged += new System.EventHandler(this.textBoxState_TextChanged);
			// 
			// labelState
			// 
			this.labelState.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelState.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelState.Location = new System.Drawing.Point(256, 264);
			this.labelState.Name = "labelState";
			this.labelState.Size = new System.Drawing.Size(120, 24);
			this.labelState.TabIndex = 81;
			this.labelState.Text = "State";
			// 
			// textBoxHandPhone
			// 
			this.textBoxHandPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxHandPhone.Location = new System.Drawing.Point(720, 296);
			this.textBoxHandPhone.Name = "textBoxHandPhone";
			this.textBoxHandPhone.Size = new System.Drawing.Size(200, 22);
			this.textBoxHandPhone.TabIndex = 11;
			this.textBoxHandPhone.Text = "";
			this.textBoxHandPhone.TextChanged += new System.EventHandler(this.textBoxHandPhone_TextChanged);
			// 
			// labelHandPhone
			// 
			this.labelHandPhone.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelHandPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelHandPhone.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelHandPhone.Location = new System.Drawing.Point(592, 296);
			this.labelHandPhone.Name = "labelHandPhone";
			this.labelHandPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.labelHandPhone.Size = new System.Drawing.Size(120, 24);
			this.labelHandPhone.TabIndex = 87;
			this.labelHandPhone.Text = "Hand Phone";
			// 
			// textBoxPhone
			// 
			this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxPhone.Location = new System.Drawing.Point(384, 296);
			this.textBoxPhone.Name = "textBoxPhone";
			this.textBoxPhone.Size = new System.Drawing.Size(200, 22);
			this.textBoxPhone.TabIndex = 10;
			this.textBoxPhone.Text = "";
			this.textBoxPhone.TextChanged += new System.EventHandler(this.textBoxPhone_TextChanged);
			// 
			// labelPhone
			// 
			this.labelPhone.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelPhone.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelPhone.Location = new System.Drawing.Point(256, 296);
			this.labelPhone.Name = "labelPhone";
			this.labelPhone.Size = new System.Drawing.Size(120, 24);
			this.labelPhone.TabIndex = 85;
			this.labelPhone.Text = "Phone";
			// 
			// textBoxEmail
			// 
			this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxEmail.Location = new System.Drawing.Point(384, 328);
			this.textBoxEmail.Name = "textBoxEmail";
			this.textBoxEmail.Size = new System.Drawing.Size(536, 22);
			this.textBoxEmail.TabIndex = 12;
			this.textBoxEmail.Text = "";
			this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
			// 
			// labelEmail
			// 
			this.labelEmail.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelEmail.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelEmail.Location = new System.Drawing.Point(256, 328);
			this.labelEmail.Name = "labelEmail";
			this.labelEmail.Size = new System.Drawing.Size(120, 24);
			this.labelEmail.TabIndex = 89;
			this.labelEmail.Text = "Email";
			// 
			// labelLocationCode
			// 
			this.labelLocationCode.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelLocationCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelLocationCode.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelLocationCode.Location = new System.Drawing.Point(256, 360);
			this.labelLocationCode.Name = "labelLocationCode";
			this.labelLocationCode.Size = new System.Drawing.Size(120, 24);
			this.labelLocationCode.TabIndex = 91;
			this.labelLocationCode.Text = "LocationCode";
			// 
			// textBoxLocationCode
			// 
			this.textBoxLocationCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxLocationCode.Location = new System.Drawing.Point(384, 360);
			this.textBoxLocationCode.Name = "textBoxLocationCode";
			this.textBoxLocationCode.Size = new System.Drawing.Size(200, 22);
			this.textBoxLocationCode.TabIndex = 13;
			this.textBoxLocationCode.Text = "";
			this.textBoxLocationCode.TextChanged += new System.EventHandler(this.textBoxLocationCode_TextChanged);
			// 
			// buttonSave
			// 
			this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonSave.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
			this.buttonSave.Location = new System.Drawing.Point(640, 496);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(136, 40);
			this.buttonSave.TabIndex = 92;
			this.buttonSave.Text = "Save";
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonCancel.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonCancel.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancel.Image")));
			this.buttonCancel.Location = new System.Drawing.Point(792, 496);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(136, 40);
			this.buttonCancel.TabIndex = 93;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
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
			// FrmLibrarian
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.pictureBoxLogoPicture);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.textBoxLocationCode);
			this.Controls.Add(this.labelLocationCode);
			this.Controls.Add(this.textBoxEmail);
			this.Controls.Add(this.labelEmail);
			this.Controls.Add(this.textBoxHandPhone);
			this.Controls.Add(this.labelHandPhone);
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
			this.Controls.Add(this.comboBoxLibrarianGroup);
			this.Controls.Add(this.labelLibrarianGroup);
			this.Controls.Add(this.textBoxLibrarianName);
			this.Controls.Add(this.labelLibrarianName);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.labelUserPassword);
			this.Controls.Add(this.textBoxUserName);
			this.Controls.Add(this.labelUserName);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.textBoxLibrarianID);
			this.Controls.Add(this.labelLibrarianID);
			this.Controls.Add(this.LabelTitle);
			this.Name = "FrmLibrarian";
			this.Load += new System.EventHandler(this.FrmLibrarian_Load);
			this.Controls.SetChildIndex(this.LabelTitle, 0);
			this.Controls.SetChildIndex(this.labelLibrarianID, 0);
			this.Controls.SetChildIndex(this.textBoxLibrarianID, 0);
			this.Controls.SetChildIndex(this.pictureBox1, 0);
			this.Controls.SetChildIndex(this.labelUserName, 0);
			this.Controls.SetChildIndex(this.textBoxUserName, 0);
			this.Controls.SetChildIndex(this.labelUserPassword, 0);
			this.Controls.SetChildIndex(this.textBoxPassword, 0);
			this.Controls.SetChildIndex(this.labelLibrarianName, 0);
			this.Controls.SetChildIndex(this.textBoxLibrarianName, 0);
			this.Controls.SetChildIndex(this.labelLibrarianGroup, 0);
			this.Controls.SetChildIndex(this.comboBoxLibrarianGroup, 0);
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
			this.Controls.SetChildIndex(this.labelHandPhone, 0);
			this.Controls.SetChildIndex(this.textBoxHandPhone, 0);
			this.Controls.SetChildIndex(this.labelEmail, 0);
			this.Controls.SetChildIndex(this.textBoxEmail, 0);
			this.Controls.SetChildIndex(this.labelLocationCode, 0);
			this.Controls.SetChildIndex(this.textBoxLocationCode, 0);
			this.Controls.SetChildIndex(this.buttonSave, 0);
			this.Controls.SetChildIndex(this.buttonCancel, 0);
			this.Controls.SetChildIndex(this.pictureBoxLogoPicture, 0);
			this.ResumeLayout(false);

		}
		#endregion

		private void FrmLibrarian_Load(object sender, System.EventArgs e)
		{
 
		}

		public void DoLock()
		{
		    textBoxUserName.ReadOnly = true;
			textBoxPassword.ReadOnly = true;
			textBoxLibrarianName.ReadOnly = true;
			textBoxAddress.ReadOnly = true;
			textBoxCity.ReadOnly = true;
			textBoxPostCode.ReadOnly = true;
			textBoxState.ReadOnly = true;
			textBoxCountry.ReadOnly = true;
			textBoxPhone.ReadOnly = true;
			textBoxHandPhone.ReadOnly = true;
			textBoxEmail.ReadOnly = true;
			textBoxLocationCode.ReadOnly = true;
		}
		public void DoUnlock()
		{
			textBoxUserName.ReadOnly = false;
			textBoxPassword.ReadOnly = false;
			textBoxLibrarianName.ReadOnly = false;
			textBoxAddress.ReadOnly = false;
			textBoxCity.ReadOnly = false;
			textBoxPostCode.ReadOnly = false;
			textBoxState.ReadOnly = false;
			textBoxCountry.ReadOnly = false;
			textBoxPhone.ReadOnly = false;
			textBoxHandPhone.ReadOnly = false;
			textBoxEmail.ReadOnly = false;
			textBoxLocationCode.ReadOnly = false;
		}
		public void GetMaxLibrarianID()
		{
			MyClassDatabase = new ClassDatabase();
			string MaxNo;
			int len;
			long MaxNoPlusOne;
			string LibrarianID;
		
			MaxNo = MyClassDatabase.GetMaxLibrarianID ();
			MaxNo = MaxNo.Trim().Substring(1);
			MaxNoPlusOne = Convert.ToInt64(MaxNo) + 1;
			len = MaxNoPlusOne.ToString().Length;
			LibrarianID = "L";
			for(int x=0;x<(MaxNo.Length-len);x++)
				LibrarianID += "0";
			LibrarianID += MaxNoPlusOne.ToString();
			textBoxLibrarianID.Text = LibrarianID.ToString();
			MyLibrarian.LibrarianGroup = comboBoxLibrarianGroup.Text.ToString();
			this.LabelTitle.Text = "    Add Librarian";
		}
		private void textBoxUserName_TextChanged(object sender, System.EventArgs e)
		{
			MyLibrarian.UserName = textBoxUserName.Text.ToString();		
		}

		private void textBoxPassword_TextChanged(object sender, System.EventArgs e)
		{
			MyLibrarian.UserPassword = textBoxPassword.Text.ToString();
		}

		private void textBoxLibrarianName_TextChanged(object sender, System.EventArgs e)
		{
			MyLibrarian.LibrarianName = textBoxLibrarianName.Text.ToString();
		}

		private void comboBoxLibrarianGroup_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			MyLibrarian.LibrarianGroup = comboBoxLibrarianGroup.Text.ToString();
		}
		private void comboBoxLibrarianGroup_TextChanged(object sender, System.EventArgs e)
		{
			MyLibrarian.LibrarianGroup = comboBoxLibrarianGroup.Text.ToString();
		}
		private void textBoxAddress_TextChanged(object sender, System.EventArgs e)
		{
			MyLibrarian.Address = textBoxAddress.Text.ToString();
		}

		private void textBoxCity_TextChanged(object sender, System.EventArgs e)
		{
			MyLibrarian.City = textBoxCity.Text.ToString();
		}

		private void textBoxPostCode_TextChanged(object sender, System.EventArgs e)
		{
			MyLibrarian.PostCode = textBoxPostCode.Text.ToString();
		}

		private void textBoxState_TextChanged(object sender, System.EventArgs e)
		{
			MyLibrarian.State = textBoxState.Text.ToString();
		}

		private void textBoxCountry_TextChanged(object sender, System.EventArgs e)
		{
			MyLibrarian.Country = textBoxCountry.Text.ToString();
		}

		private void textBoxPhone_TextChanged(object sender, System.EventArgs e)
		{
			MyLibrarian.Phone = textBoxPhone.Text.ToString();
		}

		private void textBoxHandPhone_TextChanged(object sender, System.EventArgs e)
		{
			MyLibrarian.HandPhone = textBoxHandPhone.Text.ToString();
		}

		private void textBoxEmail_TextChanged(object sender, System.EventArgs e)
		{
			MyLibrarian.Email = textBoxEmail.Text.ToString();
		}

		private void textBoxLocationCode_TextChanged(object sender, System.EventArgs e)
		{
			MyLibrarian.LocationCode = textBoxLocationCode.Text.ToString();
		}

		private void textBoxLibrarianID_TextChanged(object sender, System.EventArgs e)
		{
			MyLibrarian.LibrarianID = textBoxLibrarianID.Text.ToString();
		}

		private void buttonSave_Click(object sender, System.EventArgs e)
		{
			if(textBoxUserName.Text.ToString() == "")
			{
				MessageBox.Show("Please enter User Name !", "Information");
				textBoxUserName.Focus();
			}
			else if(textBoxPassword.Text.ToString() == "")
			{
				MessageBox.Show("Please enter User Password !", "Information");
				textBoxPassword.Focus();
			}
			else if(textBoxLibrarianName.Text.ToString() == "")
			{
				MessageBox.Show("Please enter Librarian Name !", "Information");
				textBoxLibrarianName.Focus();
			}
			else
			{
				MyClassDatabase = new ClassDatabase();
				MyClassDatabase.SaveLibrarian(MyLibrarian);
				this.Close();
				this.Dispose();
			}
		}
		private void buttonCancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
			this.Dispose();
		}

	}
}

