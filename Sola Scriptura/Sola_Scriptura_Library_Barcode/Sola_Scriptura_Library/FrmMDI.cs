using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Sola_Scriptura_Library
{
	/// <summary>
	/// Summary description for FrmMDI.
	/// </summary>
	public class FrmMDI : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.PictureBox PictureBox2;
		internal System.Windows.Forms.PictureBox PictureBox1;
		internal System.Windows.Forms.PictureBox PictureBox3;
		internal System.Windows.Forms.PictureBox PictureBox4;
		private System.ComponentModel.IContainer components;
		internal System.Windows.Forms.Label LabelLogout;
		internal System.Windows.Forms.PictureBox PictureBoxLogout;
		internal System.Windows.Forms.PictureBox pictureBox5;
		internal System.Windows.Forms.PictureBox PictureBoxHome;
		internal System.Windows.Forms.PictureBox pictureBoxBook;
		internal System.Windows.Forms.PictureBox pictureBoxBookTransaction;
		internal System.Windows.Forms.PictureBox pictureBoxMember;
		internal System.Windows.Forms.PictureBox pictureBoxAbout;
		internal System.Windows.Forms.Label labelDateTime;
		internal System.Windows.Forms.PictureBox pictureBoxAdmin;
		internal System.Windows.Forms.Timer timer1;
		internal System.Windows.Forms.PictureBox pictureBoxSearch;
		internal System.Windows.Forms.Label labelHome;
		internal System.Windows.Forms.Label labelMember;
		internal System.Windows.Forms.Label labelBook;
		internal System.Windows.Forms.Label labelBookTransaction;
		internal System.Windows.Forms.Label labelAdmin;
		internal System.Windows.Forms.Label labelAbout;
		internal System.Windows.Forms.PictureBox pictureBoxSetup;
		internal System.Windows.Forms.Label labelSetup;
		internal System.Windows.Forms.Label labelSearch;

		internal string LibrarianUserName;
		internal string LibrarianGroup;
		internal BookSearch MyBookSearch;
		internal JournalArticles MyJournalArticles;
		internal Journal MyJournal;

		internal FrmLoginServer MyLoginForm;
		internal FrmLoginClient MyLoginForm2;
		internal FrmMemberMenu MyMemberMenuForm;
		internal FrmAdmin MyAdminForm;
		internal FrmBookMenu MyBookMenuForm;
		internal FrmAbout MyAboutForm;
		internal FrmSetupMenu MySetupMenuForm;
		internal FrmTransactionMenu MyTransactionMenuForm;
		internal FrmSTTB MySTTBForm;
		internal FrmSearch MySearchForm;
		internal decimal MyFine;
		internal int MyBorrowPeriod;
		internal ClassDatabase MyClassDatabase;

		public FrmMDI()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}
	
		public FrmMDI(FrmLoginServer LoginForm)
		{
			InitializeComponent();
			MyLoginForm = LoginForm;
			
		}
		public FrmMDI(FrmLoginClient LoginForm)
		{
			InitializeComponent();
			MyLoginForm2 = LoginForm;
			
		}
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmMDI));
			this.PictureBox2 = new System.Windows.Forms.PictureBox();
			this.PictureBox1 = new System.Windows.Forms.PictureBox();
			this.PictureBox3 = new System.Windows.Forms.PictureBox();
			this.PictureBox4 = new System.Windows.Forms.PictureBox();
			this.LabelLogout = new System.Windows.Forms.Label();
			this.PictureBoxLogout = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.PictureBoxHome = new System.Windows.Forms.PictureBox();
			this.pictureBoxBook = new System.Windows.Forms.PictureBox();
			this.pictureBoxBookTransaction = new System.Windows.Forms.PictureBox();
			this.pictureBoxMember = new System.Windows.Forms.PictureBox();
			this.pictureBoxAbout = new System.Windows.Forms.PictureBox();
			this.pictureBoxSetup = new System.Windows.Forms.PictureBox();
			this.labelHome = new System.Windows.Forms.Label();
			this.labelMember = new System.Windows.Forms.Label();
			this.labelBook = new System.Windows.Forms.Label();
			this.labelBookTransaction = new System.Windows.Forms.Label();
			this.labelSetup = new System.Windows.Forms.Label();
			this.labelAdmin = new System.Windows.Forms.Label();
			this.labelAbout = new System.Windows.Forms.Label();
			this.labelDateTime = new System.Windows.Forms.Label();
			this.pictureBoxAdmin = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.pictureBoxSearch = new System.Windows.Forms.PictureBox();
			this.labelSearch = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// PictureBox2
			// 
			this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
			this.PictureBox2.Location = new System.Drawing.Point(2, 2);
			this.PictureBox2.Name = "PictureBox2";
			this.PictureBox2.Size = new System.Drawing.Size(1020, 50);
			this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureBox2.TabIndex = 3;
			this.PictureBox2.TabStop = false;
			// 
			// PictureBox1
			// 
			this.PictureBox1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.PictureBox1.Location = new System.Drawing.Point(2, 2);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new System.Drawing.Size(1020, 126);
			this.PictureBox1.TabIndex = 4;
			this.PictureBox1.TabStop = false;
			// 
			// PictureBox3
			// 
			this.PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox3.Image")));
			this.PictureBox3.Location = new System.Drawing.Point(2, 128);
			this.PictureBox3.Name = "PictureBox3";
			this.PictureBox3.Size = new System.Drawing.Size(1020, 34);
			this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureBox3.TabIndex = 5;
			this.PictureBox3.TabStop = false;
			// 
			// PictureBox4
			// 
			this.PictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox4.Image")));
			this.PictureBox4.Location = new System.Drawing.Point(2, 736);
			this.PictureBox4.Name = "PictureBox4";
			this.PictureBox4.Size = new System.Drawing.Size(1020, 31);
			this.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureBox4.TabIndex = 6;
			this.PictureBox4.TabStop = false;
			// 
			// LabelLogout
			// 
			this.LabelLogout.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.LabelLogout.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.LabelLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.LabelLogout.Location = new System.Drawing.Point(728, 114);
			this.LabelLogout.Name = "LabelLogout";
			this.LabelLogout.Size = new System.Drawing.Size(88, 16);
			this.LabelLogout.TabIndex = 12;
			this.LabelLogout.Text = "Log Out";
			// 
			// PictureBoxLogout
			// 
			this.PictureBoxLogout.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxLogout.Image")));
			this.PictureBoxLogout.Location = new System.Drawing.Point(720, 56);
			this.PictureBoxLogout.Name = "PictureBoxLogout";
			this.PictureBoxLogout.Size = new System.Drawing.Size(69, 72);
			this.PictureBoxLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.PictureBoxLogout.TabIndex = 11;
			this.PictureBoxLogout.TabStop = false;
			this.PictureBoxLogout.Click += new System.EventHandler(this.PictureBoxLogout_Click);
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(800, 56);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(206, 73);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox5.TabIndex = 13;
			this.pictureBox5.TabStop = false;
			// 
			// PictureBoxHome
			// 
			this.PictureBoxHome.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxHome.Image")));
			this.PictureBoxHome.Location = new System.Drawing.Point(8, 56);
			this.PictureBoxHome.Name = "PictureBoxHome";
			this.PictureBoxHome.Size = new System.Drawing.Size(69, 60);
			this.PictureBoxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.PictureBoxHome.TabIndex = 15;
			this.PictureBoxHome.TabStop = false;
			this.PictureBoxHome.Click += new System.EventHandler(this.PictureBoxHome_Click);
			// 
			// pictureBoxBook
			// 
			this.pictureBoxBook.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBook.Image")));
			this.pictureBoxBook.Location = new System.Drawing.Point(248, 56);
			this.pictureBoxBook.Name = "pictureBoxBook";
			this.pictureBoxBook.Size = new System.Drawing.Size(69, 60);
			this.pictureBoxBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxBook.TabIndex = 16;
			this.pictureBoxBook.TabStop = false;
			this.pictureBoxBook.Click += new System.EventHandler(this.pictureBoxBook_Click);
			// 
			// pictureBoxBookTransaction
			// 
			this.pictureBoxBookTransaction.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBookTransaction.Image")));
			this.pictureBoxBookTransaction.Location = new System.Drawing.Point(328, 56);
			this.pictureBoxBookTransaction.Name = "pictureBoxBookTransaction";
			this.pictureBoxBookTransaction.Size = new System.Drawing.Size(69, 60);
			this.pictureBoxBookTransaction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxBookTransaction.TabIndex = 17;
			this.pictureBoxBookTransaction.TabStop = false;
			this.pictureBoxBookTransaction.Click += new System.EventHandler(this.pictureBoxBookTransaction_Click);
			// 
			// pictureBoxMember
			// 
			this.pictureBoxMember.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMember.Image")));
			this.pictureBoxMember.Location = new System.Drawing.Point(168, 56);
			this.pictureBoxMember.Name = "pictureBoxMember";
			this.pictureBoxMember.Size = new System.Drawing.Size(69, 60);
			this.pictureBoxMember.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxMember.TabIndex = 18;
			this.pictureBoxMember.TabStop = false;
			this.pictureBoxMember.Click += new System.EventHandler(this.pictureBoxMember_Click);
			// 
			// pictureBoxAbout
			// 
			this.pictureBoxAbout.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAbout.Image")));
			this.pictureBoxAbout.Location = new System.Drawing.Point(640, 56);
			this.pictureBoxAbout.Name = "pictureBoxAbout";
			this.pictureBoxAbout.Size = new System.Drawing.Size(68, 60);
			this.pictureBoxAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxAbout.TabIndex = 19;
			this.pictureBoxAbout.TabStop = false;
			this.pictureBoxAbout.Click += new System.EventHandler(this.pictureBoxAbout_Click);
			// 
			// pictureBoxSetup
			// 
			this.pictureBoxSetup.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSetup.Image")));
			this.pictureBoxSetup.Location = new System.Drawing.Point(408, 56);
			this.pictureBoxSetup.Name = "pictureBoxSetup";
			this.pictureBoxSetup.Size = new System.Drawing.Size(69, 60);
			this.pictureBoxSetup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxSetup.TabIndex = 20;
			this.pictureBoxSetup.TabStop = false;
			this.pictureBoxSetup.Click += new System.EventHandler(this.pictureBoxSetup_Click);
			// 
			// labelHome
			// 
			this.labelHome.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelHome.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelHome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.labelHome.Location = new System.Drawing.Point(16, 114);
			this.labelHome.Name = "labelHome";
			this.labelHome.Size = new System.Drawing.Size(56, 16);
			this.labelHome.TabIndex = 22;
			this.labelHome.Text = "Home";
			this.labelHome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// labelMember
			// 
			this.labelMember.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelMember.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelMember.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.labelMember.Location = new System.Drawing.Point(172, 114);
			this.labelMember.Name = "labelMember";
			this.labelMember.Size = new System.Drawing.Size(64, 16);
			this.labelMember.TabIndex = 23;
			this.labelMember.Text = "Member";
			this.labelMember.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// labelBook
			// 
			this.labelBook.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelBook.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBook.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.labelBook.Location = new System.Drawing.Point(256, 114);
			this.labelBook.Name = "labelBook";
			this.labelBook.Size = new System.Drawing.Size(56, 16);
			this.labelBook.TabIndex = 24;
			this.labelBook.Text = "Book";
			this.labelBook.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// labelBookTransaction
			// 
			this.labelBookTransaction.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelBookTransaction.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBookTransaction.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.labelBookTransaction.Location = new System.Drawing.Point(336, 114);
			this.labelBookTransaction.Name = "labelBookTransaction";
			this.labelBookTransaction.Size = new System.Drawing.Size(56, 16);
			this.labelBookTransaction.TabIndex = 25;
			this.labelBookTransaction.Text = "Trans";
			this.labelBookTransaction.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// labelSetup
			// 
			this.labelSetup.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelSetup.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelSetup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.labelSetup.Location = new System.Drawing.Point(412, 114);
			this.labelSetup.Name = "labelSetup";
			this.labelSetup.Size = new System.Drawing.Size(64, 16);
			this.labelSetup.TabIndex = 26;
			this.labelSetup.Text = "Setup";
			this.labelSetup.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// labelAdmin
			// 
			this.labelAdmin.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelAdmin.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelAdmin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.labelAdmin.Location = new System.Drawing.Point(490, 114);
			this.labelAdmin.Name = "labelAdmin";
			this.labelAdmin.Size = new System.Drawing.Size(64, 16);
			this.labelAdmin.TabIndex = 27;
			this.labelAdmin.Text = "Admin";
			this.labelAdmin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// labelAbout
			// 
			this.labelAbout.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelAbout.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelAbout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.labelAbout.Location = new System.Drawing.Point(648, 114);
			this.labelAbout.Name = "labelAbout";
			this.labelAbout.Size = new System.Drawing.Size(48, 16);
			this.labelAbout.TabIndex = 28;
			this.labelAbout.Text = "About";
			this.labelAbout.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// labelDateTime
			// 
			this.labelDateTime.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(59)), ((System.Byte)(92)), ((System.Byte)(192)));
			this.labelDateTime.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelDateTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.labelDateTime.Location = new System.Drawing.Point(792, 744);
			this.labelDateTime.Name = "labelDateTime";
			this.labelDateTime.Size = new System.Drawing.Size(224, 16);
			this.labelDateTime.TabIndex = 30;
			this.labelDateTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// pictureBoxAdmin
			// 
			this.pictureBoxAdmin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAdmin.Image")));
			this.pictureBoxAdmin.Location = new System.Drawing.Point(488, 56);
			this.pictureBoxAdmin.Name = "pictureBoxAdmin";
			this.pictureBoxAdmin.Size = new System.Drawing.Size(69, 60);
			this.pictureBoxAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxAdmin.TabIndex = 31;
			this.pictureBoxAdmin.TabStop = false;
			this.pictureBoxAdmin.Click += new System.EventHandler(this.pictureBoxAdmin_Click);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 10000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// pictureBoxSearch
			// 
			this.pictureBoxSearch.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSearch.Image")));
			this.pictureBoxSearch.Location = new System.Drawing.Point(88, 56);
			this.pictureBoxSearch.Name = "pictureBoxSearch";
			this.pictureBoxSearch.Size = new System.Drawing.Size(69, 72);
			this.pictureBoxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxSearch.TabIndex = 33;
			this.pictureBoxSearch.TabStop = false;
			this.pictureBoxSearch.Click += new System.EventHandler(this.pictureBoxSearch_Click);
			// 
			// labelSearch
			// 
			this.labelSearch.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelSearch.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.labelSearch.Location = new System.Drawing.Point(90, 114);
			this.labelSearch.Name = "labelSearch";
			this.labelSearch.Size = new System.Drawing.Size(64, 16);
			this.labelSearch.TabIndex = 34;
			this.labelSearch.Text = "Search";
			this.labelSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// FrmMDI
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(1024, 768);
			this.Controls.Add(this.labelSearch);
			this.Controls.Add(this.pictureBoxSearch);
			this.Controls.Add(this.pictureBoxAdmin);
			this.Controls.Add(this.labelDateTime);
			this.Controls.Add(this.labelAbout);
			this.Controls.Add(this.labelAdmin);
			this.Controls.Add(this.labelSetup);
			this.Controls.Add(this.labelBookTransaction);
			this.Controls.Add(this.labelBook);
			this.Controls.Add(this.labelMember);
			this.Controls.Add(this.labelHome);
			this.Controls.Add(this.pictureBoxSetup);
			this.Controls.Add(this.pictureBoxAbout);
			this.Controls.Add(this.pictureBoxMember);
			this.Controls.Add(this.pictureBoxBookTransaction);
			this.Controls.Add(this.pictureBoxBook);
			this.Controls.Add(this.PictureBoxHome);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.LabelLogout);
			this.Controls.Add(this.PictureBoxLogout);
			this.Controls.Add(this.PictureBox4);
			this.Controls.Add(this.PictureBox3);
			this.Controls.Add(this.PictureBox2);
			this.Controls.Add(this.PictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.IsMdiContainer = true;
			this.Name = "FrmMDI";
			this.Text = "MDI Form";
			this.Load += new System.EventHandler(this.FrmMDI_Load);
			this.ResumeLayout(false);

		}
		#endregion
		private void FrmMDI_Load(object sender, System.EventArgs e)
		{
			labelDateTime.Text = (DateTime.Now.ToLongDateString() ) + ", " + (DateTime.Now.ToLongTimeString());
			MyBookSearch = new BookSearch();
			MyJournalArticles = new JournalArticles();
			MyJournal = new Journal();
			MyClassDatabase = new ClassDatabase();
			MyFine = Convert.ToDecimal(MyClassDatabase.GetFine());
			MyClassDatabase = new ClassDatabase();
			MyBorrowPeriod = Convert.ToInt32(MyClassDatabase.GetBorrowPeriod());
			MySTTBForm = new FrmSTTB(this);
			MySTTBForm.Show();
		}
		private void timer1_Tick(object sender, System.EventArgs e)
		{
			labelDateTime.Text = (DateTime.Now.ToLongDateString() ) + ", " + (DateTime.Now.ToLongTimeString());
		}
		private void PictureBoxLogout_Click(object sender, System.EventArgs e)
		{
			DialogResult ans;
			ans = MessageBox.Show("Are you sure you want to log out ?", "Confirmation", MessageBoxButtons.YesNo );
			if (ans.ToString() == "Yes")
			{	
				if (MyLoginForm !=null)
					MyLoginForm.Show();
				else
					MyLoginForm2.Show();
				this.Dispose();
			}
			else
			{
				
			}
		}
		private void pictureBoxMember_Click(object sender, System.EventArgs e)
		{
				MyMemberMenuForm = new FrmMemberMenu(this);
				MyMemberMenuForm.Show();
		}
		private void pictureBoxAdmin_Click(object sender, System.EventArgs e)
		{
			if(LibrarianGroup.Trim().ToString() == "Administrator") 
			{
				MyAdminForm = new FrmAdmin(this);
				MyAdminForm.Show();
			}
			else
			{
				MessageBox.Show("Access Denied ! You must be a member of Administrator to access this function.", "Information");
			}
		}
		private void pictureBoxBook_Click(object sender, System.EventArgs e)
		{
			MyBookMenuForm = new FrmBookMenu (this);
			MyBookMenuForm.Show();
		}

		private void PictureBoxHome_Click(object sender, System.EventArgs e)
		{
			foreach(Form MyForm in this.MdiChildren)
			{
				MyForm.Close();
				MyForm.Dispose();
			}
			MySTTBForm = new FrmSTTB(this);
			MySTTBForm.Show();

		}

		private void pictureBoxAbout_Click(object sender, System.EventArgs e)
		{
			foreach(Form MyForm in this.MdiChildren)
			{
				MyForm.Close();
				MyForm.Dispose();
			}

			MyAboutForm = new FrmAbout();
			MyAboutForm.MdiParent = this;
			MyAboutForm.Show();
		}

		private void pictureBoxSetup_Click(object sender, System.EventArgs e)
		{
			MySetupMenuForm = new FrmSetupMenu(this);
			MySetupMenuForm.MdiParent = this;
			MySetupMenuForm.Show();
		}

		private void pictureBoxSearch_Click(object sender, System.EventArgs e)
		{
			MySearchForm = new FrmSearch(this);
			MySearchForm.Show();
			//MySearchBookForm.DoClear();
		}

		private void pictureBoxBookTransaction_Click(object sender, System.EventArgs e)
		{
			MyTransactionMenuForm = new FrmTransactionMenu(this);
			MyTransactionMenuForm.Show();
		}

		public void ClearJournal()
		{
			MyJournal = new Journal();
		}
	}
}
