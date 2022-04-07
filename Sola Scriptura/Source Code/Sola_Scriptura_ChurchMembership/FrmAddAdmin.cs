using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Sola_Scriptura_ChurchMembership
{
	public class FrmAddAdmin: Sola_Scriptura_ChurchMembership.FrmFormParent
	{
		internal System.Windows.Forms.Label LabelTitle;
		internal System.Windows.Forms.PictureBox pictureBox1;
		internal System.Windows.Forms.Label labelLibrarianID;
		internal System.Windows.Forms.TextBox textBoxUserName;
		internal System.Windows.Forms.Label labelUserName;
		internal System.Windows.Forms.TextBox textBoxPassword;
		internal System.Windows.Forms.Label labelUserPassword;
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
		internal System.Windows.Forms.TextBox textBoxAdminName;
		internal System.Windows.Forms.Label labelAdminName;
		internal System.Windows.Forms.Label labelAdminGroup;
		internal System.Windows.Forms.ComboBox comboBoxAdminGroup;
		internal System.Windows.Forms.TextBox textBoxAdminID;

		internal Administrator MyAdmin;
		public FrmAddAdmin()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public FrmAddAdmin(FrmMDI MDIForm)
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmAddAdmin));
			this.LabelTitle = new System.Windows.Forms.Label();
			this.labelLibrarianID = new System.Windows.Forms.Label();
			this.textBoxAdminID = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.textBoxUserName = new System.Windows.Forms.TextBox();
			this.labelUserName = new System.Windows.Forms.Label();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.labelUserPassword = new System.Windows.Forms.Label();
			this.textBoxAdminName = new System.Windows.Forms.TextBox();
			this.labelAdminName = new System.Windows.Forms.Label();
			this.labelAdminGroup = new System.Windows.Forms.Label();
			this.comboBoxAdminGroup = new System.Windows.Forms.ComboBox();
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
			this.labelLibrarianID.Text = "Admin ID";
			// 
			// textBoxAdminID
			// 
			this.textBoxAdminID.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxAdminID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxAdminID.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxAdminID.Location = new System.Drawing.Point(384, 80);
			this.textBoxAdminID.Name = "textBoxAdminID";
			this.textBoxAdminID.ReadOnly = true;
			this.textBoxAdminID.Size = new System.Drawing.Size(200, 22);
			this.textBoxAdminID.TabIndex = 0;
			this.textBoxAdminID.Text = "";
			this.textBoxAdminID.TextChanged += new System.EventHandler(this.textBoxAdminID_TextChanged);
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
			// textBoxAdminName
			// 
			this.textBoxAdminName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxAdminName.Location = new System.Drawing.Point(384, 168);
			this.textBoxAdminName.Name = "textBoxAdminName";
			this.textBoxAdminName.Size = new System.Drawing.Size(200, 22);
			this.textBoxAdminName.TabIndex = 3;
			this.textBoxAdminName.Text = "";
			this.textBoxAdminName.TextChanged += new System.EventHandler(this.textBoxAdminName_TextChanged);
			// 
			// labelAdminName
			// 
			this.labelAdminName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelAdminName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelAdminName.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelAdminName.Location = new System.Drawing.Point(256, 168);
			this.labelAdminName.Name = "labelAdminName";
			this.labelAdminName.Size = new System.Drawing.Size(120, 24);
			this.labelAdminName.TabIndex = 71;
			this.labelAdminName.Text = "Admin Name";
			// 
			// labelAdminGroup
			// 
			this.labelAdminGroup.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelAdminGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelAdminGroup.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelAdminGroup.Location = new System.Drawing.Point(592, 168);
			this.labelAdminGroup.Name = "labelAdminGroup";
			this.labelAdminGroup.Size = new System.Drawing.Size(120, 24);
			this.labelAdminGroup.TabIndex = 73;
			this.labelAdminGroup.Text = "Admin Group";
			// 
			// comboBoxAdminGroup
			// 
			this.comboBoxAdminGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.comboBoxAdminGroup.Items.AddRange(new object[] {
																	"Administrator",
																	"User"});
			this.comboBoxAdminGroup.Location = new System.Drawing.Point(720, 168);
			this.comboBoxAdminGroup.Name = "comboBoxAdminGroup";
			this.comboBoxAdminGroup.Size = new System.Drawing.Size(200, 24);
			this.comboBoxAdminGroup.TabIndex = 4;
			this.comboBoxAdminGroup.TextChanged += new System.EventHandler(this.comboBoxAdminGroup_TextChanged);
			this.comboBoxAdminGroup.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdminGroup_SelectedIndexChanged);
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
			// FrmAddAdmin
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
			this.Controls.Add(this.comboBoxAdminGroup);
			this.Controls.Add(this.labelAdminGroup);
			this.Controls.Add(this.textBoxAdminName);
			this.Controls.Add(this.labelAdminName);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.labelUserPassword);
			this.Controls.Add(this.textBoxUserName);
			this.Controls.Add(this.labelUserName);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.textBoxAdminID);
			this.Controls.Add(this.labelLibrarianID);
			this.Controls.Add(this.LabelTitle);
			this.Name = "FrmAddAdmin";
			this.Controls.SetChildIndex(this.LabelTitle, 0);
			this.Controls.SetChildIndex(this.labelLibrarianID, 0);
			this.Controls.SetChildIndex(this.textBoxAdminID, 0);
			this.Controls.SetChildIndex(this.pictureBox1, 0);
			this.Controls.SetChildIndex(this.labelUserName, 0);
			this.Controls.SetChildIndex(this.textBoxUserName, 0);
			this.Controls.SetChildIndex(this.labelUserPassword, 0);
			this.Controls.SetChildIndex(this.textBoxPassword, 0);
			this.Controls.SetChildIndex(this.labelAdminName, 0);
			this.Controls.SetChildIndex(this.textBoxAdminName, 0);
			this.Controls.SetChildIndex(this.labelAdminGroup, 0);
			this.Controls.SetChildIndex(this.comboBoxAdminGroup, 0);
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

		private void FrmAdmin_Load(object sender, System.EventArgs e)
		{
 
		}

		public void DoLock()
		{
		    textBoxUserName.ReadOnly = true;
			textBoxPassword.ReadOnly = true;
			textBoxAdminName.ReadOnly = true;
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
			textBoxAdminName.ReadOnly = false;
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
		public void GetMaxAdminID()
		{
			MyClassDatabase = new ClassDatabase();
			string MaxNo;
			int len;
			long MaxNoPlusOne;
			string AdminID;
		
			MaxNo = MyClassDatabase.GetMaxAdminID ();
			MaxNo = MaxNo.Trim().Substring(1);
			MaxNoPlusOne = Convert.ToInt64(MaxNo) + 1;
			len = MaxNoPlusOne.ToString().Length;
			AdminID = "L";
			for(int x=0;x<(MaxNo.Length-len);x++)
				AdminID += "0";
			AdminID += MaxNoPlusOne.ToString();
			textBoxAdminID.Text = AdminID.ToString();
			MyAdmin.AdminGroup = comboBoxAdminGroup.Text.ToString();
			this.LabelTitle.Text = "    Add Admin";
		}
		private void textBoxUserName_TextChanged(object sender, System.EventArgs e)
		{
			MyAdmin.UserName = textBoxUserName.Text.ToString();		
		}

		private void textBoxPassword_TextChanged(object sender, System.EventArgs e)
		{
			MyAdmin.UserPassword = textBoxPassword.Text.ToString();
		}

		private void textBoxAdminName_TextChanged(object sender, System.EventArgs e)
		{
			MyAdmin.AdminName = textBoxAdminName.Text.ToString();
		}

		private void comboBoxAdminGroup_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			MyAdmin.AdminGroup = comboBoxAdminGroup.Text.ToString();
		}
		private void comboBoxAdminGroup_TextChanged(object sender, System.EventArgs e)
		{
			MyAdmin.AdminGroup = comboBoxAdminGroup.Text.ToString();
		}
		private void textBoxAddress_TextChanged(object sender, System.EventArgs e)
		{
			MyAdmin.Address = textBoxAddress.Text.ToString();
		}

		private void textBoxCity_TextChanged(object sender, System.EventArgs e)
		{
			MyAdmin.City = textBoxCity.Text.ToString();
		}

		private void textBoxPostCode_TextChanged(object sender, System.EventArgs e)
		{
			MyAdmin.PostCode = textBoxPostCode.Text.ToString();
		}

		private void textBoxState_TextChanged(object sender, System.EventArgs e)
		{
			MyAdmin.State = textBoxState.Text.ToString();
		}

		private void textBoxCountry_TextChanged(object sender, System.EventArgs e)
		{
			MyAdmin.Country = textBoxCountry.Text.ToString();
		}

		private void textBoxPhone_TextChanged(object sender, System.EventArgs e)
		{
			MyAdmin.Phone = textBoxPhone.Text.ToString();
		}

		private void textBoxHandPhone_TextChanged(object sender, System.EventArgs e)
		{
			MyAdmin.HandPhone = textBoxHandPhone.Text.ToString();
		}

		private void textBoxEmail_TextChanged(object sender, System.EventArgs e)
		{
			MyAdmin.Email = textBoxEmail.Text.ToString();
		}

		private void textBoxLocationCode_TextChanged(object sender, System.EventArgs e)
		{
			MyAdmin.LocationCode = textBoxLocationCode.Text.ToString();
		}

		private void textBoxAdminID_TextChanged(object sender, System.EventArgs e)
		{
			MyAdmin.AdminID = textBoxAdminID.Text.ToString();
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
			else if(textBoxAdminName.Text.ToString() == "")
			{
				MessageBox.Show("Please enter Admin Name !", "Information");
				textBoxAdminName.Focus();
			}
			else
			{
				MyClassDatabase = new ClassDatabase();
				MyClassDatabase.SaveAdmin(MyAdmin);
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

