using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Sola_Scriptura_Library
{
	public class FrmPublisherDetail : Sola_Scriptura_Library.FrmPublisherMaster
	{
		internal System.Windows.Forms.TextBox textBoxContactPerson;
		internal System.Windows.Forms.Label labelContactPerson;
		internal System.Windows.Forms.TextBox textBoxFax;
		internal System.Windows.Forms.Label labelFax;
		internal System.Windows.Forms.TextBox textBoxEmail;
		internal System.Windows.Forms.Label labelEmail;
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
		internal System.Windows.Forms.Label labelPublisherName;
		internal System.Windows.Forms.Button buttonSave;
		internal System.Windows.Forms.Button buttonCancel;
		internal System.Windows.Forms.Button buttonDelete;
		internal System.Windows.Forms.Button buttonEdit;
		internal System.Windows.Forms.Button buttonAdd;
		internal System.Windows.Forms.Label LabelTitle;
		internal System.Windows.Forms.TextBox textBoxPublisherName;
		internal System.Windows.Forms.TextBox textBoxPublisherCode;
		internal System.Windows.Forms.Label labelPublisherCode;
		private System.ComponentModel.IContainer components = null;

		internal ClassDatabase MyClassDatabase;
		internal Publisher MyPublisher;
		internal bool CanDelete;

		public FrmPublisherDetail()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public FrmPublisherDetail(FrmMDI MDIForm, FrmSetupMenu SetupMenuForm)
		{
			InitializeComponent();
			base.MyMDIForm = MDIForm;
			base.MySetupMenuForm = SetupMenuForm;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmPublisherDetail));
			this.textBoxContactPerson = new System.Windows.Forms.TextBox();
			this.labelContactPerson = new System.Windows.Forms.Label();
			this.textBoxFax = new System.Windows.Forms.TextBox();
			this.labelFax = new System.Windows.Forms.Label();
			this.textBoxEmail = new System.Windows.Forms.TextBox();
			this.labelEmail = new System.Windows.Forms.Label();
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
			this.textBoxPublisherName = new System.Windows.Forms.TextBox();
			this.labelPublisherName = new System.Windows.Forms.Label();
			this.textBoxPublisherCode = new System.Windows.Forms.TextBox();
			this.labelPublisherCode = new System.Windows.Forms.Label();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.LabelTitle = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBoxContactPerson
			// 
			this.textBoxContactPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxContactPerson.Location = new System.Drawing.Point(384, 304);
			this.textBoxContactPerson.Name = "textBoxContactPerson";
			this.textBoxContactPerson.Size = new System.Drawing.Size(536, 22);
			this.textBoxContactPerson.TabIndex = 10;
			this.textBoxContactPerson.Text = "";
			this.textBoxContactPerson.TextChanged += new System.EventHandler(this.textBoxContactPerson_TextChanged);
			// 
			// labelContactPerson
			// 
			this.labelContactPerson.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelContactPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelContactPerson.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelContactPerson.Location = new System.Drawing.Point(256, 304);
			this.labelContactPerson.Name = "labelContactPerson";
			this.labelContactPerson.Size = new System.Drawing.Size(120, 24);
			this.labelContactPerson.TabIndex = 155;
			this.labelContactPerson.Text = "Contact Person";
			// 
			// textBoxFax
			// 
			this.textBoxFax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxFax.Location = new System.Drawing.Point(720, 240);
			this.textBoxFax.Name = "textBoxFax";
			this.textBoxFax.Size = new System.Drawing.Size(200, 22);
			this.textBoxFax.TabIndex = 8;
			this.textBoxFax.Text = "";
			this.textBoxFax.TextChanged += new System.EventHandler(this.textBoxFax_TextChanged);
			// 
			// labelFax
			// 
			this.labelFax.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelFax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelFax.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelFax.Location = new System.Drawing.Point(592, 240);
			this.labelFax.Name = "labelFax";
			this.labelFax.Size = new System.Drawing.Size(120, 24);
			this.labelFax.TabIndex = 154;
			this.labelFax.Text = "Fax";
			// 
			// textBoxEmail
			// 
			this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxEmail.Location = new System.Drawing.Point(384, 272);
			this.textBoxEmail.Name = "textBoxEmail";
			this.textBoxEmail.Size = new System.Drawing.Size(536, 22);
			this.textBoxEmail.TabIndex = 9;
			this.textBoxEmail.Text = "";
			this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
			// 
			// labelEmail
			// 
			this.labelEmail.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelEmail.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelEmail.Location = new System.Drawing.Point(256, 272);
			this.labelEmail.Name = "labelEmail";
			this.labelEmail.Size = new System.Drawing.Size(120, 24);
			this.labelEmail.TabIndex = 153;
			this.labelEmail.Text = "Email";
			// 
			// textBoxPhone
			// 
			this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxPhone.Location = new System.Drawing.Point(384, 240);
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
			this.labelPhone.Location = new System.Drawing.Point(256, 240);
			this.labelPhone.Name = "labelPhone";
			this.labelPhone.Size = new System.Drawing.Size(120, 24);
			this.labelPhone.TabIndex = 152;
			this.labelPhone.Text = "Phone";
			// 
			// textBoxCountry
			// 
			this.textBoxCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxCountry.Location = new System.Drawing.Point(720, 208);
			this.textBoxCountry.Name = "textBoxCountry";
			this.textBoxCountry.Size = new System.Drawing.Size(200, 22);
			this.textBoxCountry.TabIndex = 6;
			this.textBoxCountry.Text = "";
			this.textBoxCountry.TextChanged += new System.EventHandler(this.textBoxCountry_TextChanged);
			// 
			// labelCountry
			// 
			this.labelCountry.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelCountry.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelCountry.Location = new System.Drawing.Point(592, 208);
			this.labelCountry.Name = "labelCountry";
			this.labelCountry.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.labelCountry.Size = new System.Drawing.Size(120, 24);
			this.labelCountry.TabIndex = 151;
			this.labelCountry.Text = "Country";
			// 
			// textBoxState
			// 
			this.textBoxState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxState.Location = new System.Drawing.Point(384, 208);
			this.textBoxState.Name = "textBoxState";
			this.textBoxState.Size = new System.Drawing.Size(200, 22);
			this.textBoxState.TabIndex = 5;
			this.textBoxState.Text = "";
			this.textBoxState.TextChanged += new System.EventHandler(this.textBoxState_TextChanged);
			// 
			// labelState
			// 
			this.labelState.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelState.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelState.Location = new System.Drawing.Point(256, 208);
			this.labelState.Name = "labelState";
			this.labelState.Size = new System.Drawing.Size(120, 24);
			this.labelState.TabIndex = 150;
			this.labelState.Text = "State";
			// 
			// textBoxPostCode
			// 
			this.textBoxPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxPostCode.Location = new System.Drawing.Point(720, 176);
			this.textBoxPostCode.Name = "textBoxPostCode";
			this.textBoxPostCode.Size = new System.Drawing.Size(200, 22);
			this.textBoxPostCode.TabIndex = 4;
			this.textBoxPostCode.Text = "";
			this.textBoxPostCode.TextChanged += new System.EventHandler(this.textBoxPostCode_TextChanged);
			// 
			// labelPostCode
			// 
			this.labelPostCode.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelPostCode.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelPostCode.Location = new System.Drawing.Point(592, 176);
			this.labelPostCode.Name = "labelPostCode";
			this.labelPostCode.Size = new System.Drawing.Size(120, 24);
			this.labelPostCode.TabIndex = 149;
			this.labelPostCode.Text = "Post Code";
			// 
			// textBoxCity
			// 
			this.textBoxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxCity.Location = new System.Drawing.Point(384, 176);
			this.textBoxCity.Name = "textBoxCity";
			this.textBoxCity.Size = new System.Drawing.Size(200, 22);
			this.textBoxCity.TabIndex = 3;
			this.textBoxCity.Text = "";
			this.textBoxCity.TextChanged += new System.EventHandler(this.textBoxCity_TextChanged);
			// 
			// labelCity
			// 
			this.labelCity.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelCity.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelCity.Location = new System.Drawing.Point(256, 176);
			this.labelCity.Name = "labelCity";
			this.labelCity.Size = new System.Drawing.Size(120, 24);
			this.labelCity.TabIndex = 148;
			this.labelCity.Text = "City";
			// 
			// textBoxAddress
			// 
			this.textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxAddress.Location = new System.Drawing.Point(384, 144);
			this.textBoxAddress.Name = "textBoxAddress";
			this.textBoxAddress.Size = new System.Drawing.Size(536, 22);
			this.textBoxAddress.TabIndex = 2;
			this.textBoxAddress.Text = "";
			this.textBoxAddress.TextChanged += new System.EventHandler(this.textBoxAddress_TextChanged);
			// 
			// labelAddress
			// 
			this.labelAddress.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelAddress.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelAddress.Location = new System.Drawing.Point(256, 144);
			this.labelAddress.Name = "labelAddress";
			this.labelAddress.Size = new System.Drawing.Size(120, 24);
			this.labelAddress.TabIndex = 147;
			this.labelAddress.Text = "Address";
			// 
			// textBoxPublisherName
			// 
			this.textBoxPublisherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxPublisherName.Location = new System.Drawing.Point(384, 112);
			this.textBoxPublisherName.Name = "textBoxPublisherName";
			this.textBoxPublisherName.Size = new System.Drawing.Size(536, 22);
			this.textBoxPublisherName.TabIndex = 1;
			this.textBoxPublisherName.Text = "";
			this.textBoxPublisherName.TextChanged += new System.EventHandler(this.textBoxPublisherName_TextChanged);
			// 
			// labelPublisherName
			// 
			this.labelPublisherName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelPublisherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelPublisherName.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelPublisherName.Location = new System.Drawing.Point(256, 112);
			this.labelPublisherName.Name = "labelPublisherName";
			this.labelPublisherName.Size = new System.Drawing.Size(120, 24);
			this.labelPublisherName.TabIndex = 146;
			this.labelPublisherName.Text = "Publisher Name";
			// 
			// textBoxPublisherCode
			// 
			this.textBoxPublisherCode.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.textBoxPublisherCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxPublisherCode.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxPublisherCode.Location = new System.Drawing.Point(384, 80);
			this.textBoxPublisherCode.Name = "textBoxPublisherCode";
			this.textBoxPublisherCode.ReadOnly = true;
			this.textBoxPublisherCode.Size = new System.Drawing.Size(200, 22);
			this.textBoxPublisherCode.TabIndex = 1;
			this.textBoxPublisherCode.Text = "";
			this.textBoxPublisherCode.TextChanged += new System.EventHandler(this.textBoxPublisherCode_TextChanged);
			// 
			// labelPublisherCode
			// 
			this.labelPublisherCode.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelPublisherCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelPublisherCode.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelPublisherCode.Location = new System.Drawing.Point(256, 80);
			this.labelPublisherCode.Name = "labelPublisherCode";
			this.labelPublisherCode.Size = new System.Drawing.Size(120, 24);
			this.labelPublisherCode.TabIndex = 145;
			this.labelPublisherCode.Text = "Publisher Code";
			// 
			// buttonSave
			// 
			this.buttonSave.Enabled = false;
			this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonSave.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
			this.buttonSave.Location = new System.Drawing.Point(728, 520);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(88, 32);
			this.buttonSave.TabIndex = 14;
			this.buttonSave.Text = "Save";
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Enabled = false;
			this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonCancel.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonCancel.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancel.Image")));
			this.buttonCancel.Location = new System.Drawing.Point(832, 520);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(88, 32);
			this.buttonCancel.TabIndex = 15;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Enabled = false;
			this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonDelete.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
			this.buttonDelete.Location = new System.Drawing.Point(456, 520);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(88, 32);
			this.buttonDelete.TabIndex = 13;
			this.buttonDelete.Text = "Delete";
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// buttonEdit
			// 
			this.buttonEdit.Enabled = false;
			this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonEdit.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonEdit.Image = ((System.Drawing.Image)(resources.GetObject("buttonEdit.Image")));
			this.buttonEdit.Location = new System.Drawing.Point(352, 520);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(88, 32);
			this.buttonEdit.TabIndex = 12;
			this.buttonEdit.Text = "Edit";
			this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonAdd.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonAdd.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd.Image")));
			this.buttonAdd.Location = new System.Drawing.Point(248, 520);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(88, 32);
			this.buttonAdd.TabIndex = 11;
			this.buttonAdd.Text = "Add New";
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
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
			this.LabelTitle.TabIndex = 156;
			this.LabelTitle.Text = "    Publisher Detail";
			this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FrmPublisherDetail
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.LabelTitle);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonEdit);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.textBoxContactPerson);
			this.Controls.Add(this.labelContactPerson);
			this.Controls.Add(this.textBoxFax);
			this.Controls.Add(this.labelFax);
			this.Controls.Add(this.textBoxEmail);
			this.Controls.Add(this.labelEmail);
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
			this.Controls.Add(this.textBoxPublisherName);
			this.Controls.Add(this.labelPublisherName);
			this.Controls.Add(this.textBoxPublisherCode);
			this.Controls.Add(this.labelPublisherCode);
			this.Name = "FrmPublisherDetail";
			this.Load += new System.EventHandler(this.FrmPublisherDetail_Load);
			this.Controls.SetChildIndex(this.labelPublisherCode, 0);
			this.Controls.SetChildIndex(this.textBoxPublisherCode, 0);
			this.Controls.SetChildIndex(this.labelPublisherName, 0);
			this.Controls.SetChildIndex(this.textBoxPublisherName, 0);
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
			this.Controls.SetChildIndex(this.labelEmail, 0);
			this.Controls.SetChildIndex(this.textBoxEmail, 0);
			this.Controls.SetChildIndex(this.labelFax, 0);
			this.Controls.SetChildIndex(this.textBoxFax, 0);
			this.Controls.SetChildIndex(this.labelContactPerson, 0);
			this.Controls.SetChildIndex(this.textBoxContactPerson, 0);
			this.Controls.SetChildIndex(this.buttonAdd, 0);
			this.Controls.SetChildIndex(this.buttonEdit, 0);
			this.Controls.SetChildIndex(this.buttonDelete, 0);
			this.Controls.SetChildIndex(this.buttonCancel, 0);
			this.Controls.SetChildIndex(this.buttonSave, 0);
			this.Controls.SetChildIndex(this.LabelTitle, 0);
			this.ResumeLayout(false);

		}
		#endregion
		private void textBoxPublisherCode_TextChanged(object sender, System.EventArgs e)
		{
			MyPublisher.PublisherCode = textBoxPublisherCode.Text.ToString();
		}
		private void textBoxPublisherName_TextChanged(object sender, System.EventArgs e)
		{
			MyPublisher.PublisherName = textBoxPublisherName.Text.ToString();
		}

		private void textBoxAddress_TextChanged(object sender, System.EventArgs e)
		{
			MyPublisher.Address = textBoxAddress.Text.ToString();
		}

		private void textBoxCity_TextChanged(object sender, System.EventArgs e)
		{
			MyPublisher.City = textBoxCity.Text.ToString();
		}

		private void textBoxPostCode_TextChanged(object sender, System.EventArgs e)
		{
			MyPublisher.PostCode = textBoxPostCode.Text.ToString();
		}

		private void textBoxState_TextChanged(object sender, System.EventArgs e)
		{
			MyPublisher.State = textBoxState.Text.ToString();
		}

		private void textBoxCountry_TextChanged(object sender, System.EventArgs e)
		{
			MyPublisher.Country = textBoxCountry.Text.ToString();
		}

		private void textBoxPhone_TextChanged(object sender, System.EventArgs e)
		{
			MyPublisher.Phone = textBoxPhone.Text.ToString();
		}

		private void textBoxFax_TextChanged(object sender, System.EventArgs e)
		{
			MyPublisher.Fax = textBoxFax.Text.ToString();
		}

		private void textBoxEmail_TextChanged(object sender, System.EventArgs e)
		{
			MyPublisher.Email = textBoxEmail.Text.ToString();
		}

		private void textBoxContactPerson_TextChanged(object sender, System.EventArgs e)
		{
			MyPublisher.ContactPerson = textBoxContactPerson.Text.ToString();
		}

		private void FrmPublisherDetail_Load(object sender, System.EventArgs e)
		{
			MyPublisher = new Publisher();

		}
		private void DoLock()
		{
			buttonAdd.Enabled = true;
			buttonSave.Enabled = false;
			buttonCancel.Enabled = false;

			RefreshButton();

		}
		private void DoUnlock()
		{
			buttonAdd.Enabled = false;
			buttonEdit.Enabled = false;
			buttonDelete.Enabled = false;
			buttonSave.Enabled = true;
			buttonCancel.Enabled = true;
		}
		internal void RefreshButton()
		{
			if(CanDelete == true)
			{
				buttonEdit.Enabled = true;
				buttonDelete.Enabled = true;
			}
			else
			{
				buttonEdit.Enabled = false;
				buttonDelete.Enabled = false;
			}
		}
		private void buttonAdd_Click(object sender, System.EventArgs e)
		{
			textBoxPublisherCode.Text = "";
			textBoxPublisherName.Text = "";
			textBoxAddress.Text = "";
			textBoxCity.Text = "";
			textBoxPostCode.Text = "";
			textBoxState.Text = "";
			textBoxCountry.Text = "";
			textBoxPhone.Text = "";
			textBoxFax.Text = "";
			textBoxEmail.Text = "";
			textBoxContactPerson.Text = "";
			MyClassDatabase = new ClassDatabase();
			string MaxNo;
			int len;
			long MaxNoPlusOne;
			string PublisherCode;
		
			MaxNo = MyClassDatabase.GetMaxPublisherCode();
			MaxNo = MaxNo.Trim().Substring(1);
			MaxNoPlusOne = Convert.ToInt64(MaxNo) + 1;
			len = MaxNoPlusOne.ToString().Length;
			PublisherCode = "P";
			for(int x=0;x<(MaxNo.Length-len);x++)
				PublisherCode += "0";
			PublisherCode += MaxNoPlusOne.ToString();
			textBoxPublisherCode.Text = PublisherCode;

			DoUnlock();
			textBoxPublisherName.Focus();
		}

		private void buttonEdit_Click(object sender, System.EventArgs e)
		{
			DoUnlock();
		}

		private void buttonDelete_Click(object sender, System.EventArgs e)
		{
			DialogResult ans;
			ans = MessageBox.Show("Are you sure you want to delete Publisher Data with AuthorCode=' "+ textBoxPublisherCode.Text.ToString().Trim() + "' ?" , "Confirmation", MessageBoxButtons.YesNo );
			if (ans.ToString() == "Yes")
			{	
				MyClassDatabase = new ClassDatabase();
				MyClassDatabase.DeletePublisher(textBoxPublisherCode.Text.ToString().Trim());
				CanDelete = false;
				MySetupMenuForm.MyPublisherListForm.labelRefresh.Visible = true;
				MySetupMenuForm.MyPublisher = new Publisher();
			}
			DoLock();
		}

		private void buttonSave_Click(object sender, System.EventArgs e)
		{
			MyPublisher.UpdateUser = MyMDIForm.LibrarianUserName.ToString();
			MyClassDatabase = new ClassDatabase();
			MyClassDatabase.SavePublisher(MyPublisher);
			MySetupMenuForm.MyPublisherListForm.labelRefresh.Visible = true;
			CanDelete = true;
			DoLock();
			MySetupMenuForm.MyPublisher = new Publisher();
		}

		private void buttonCancel_Click(object sender, System.EventArgs e)
		{
			DoLock();
			MySetupMenuForm.MyPublisher = new Publisher();
		}



	}
}
