using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Teenager_Ministry
{
	/// <summary>
	/// Summary description for FrmMemberMenu.
	/// </summary>
	public class FrmBigMenu : System.Windows.Forms.Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		internal System.Windows.Forms.PictureBox PictureBoxHelp;
		internal System.Windows.Forms.PictureBox pictureBox2;
		internal System.Windows.Forms.PictureBox pictureBox3;
		internal System.Windows.Forms.PictureBox pictureBox4;
		internal System.Windows.Forms.PictureBox PictureBoxClose;
		internal System.Windows.Forms.PictureBox pictureBoxMenu;
	
		internal FrmMDI MyMDIForm;
		public FrmBigMenu()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}
	
		public FrmBigMenu(FrmMDI MDIForm)
		{
			InitializeComponent();
			MyMDIForm = MDIForm;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmBigMenu));
			this.pictureBoxMenu = new System.Windows.Forms.PictureBox();
			this.PictureBoxHelp = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.PictureBoxClose = new System.Windows.Forms.PictureBox();
			this.SuspendLayout();
			// 
			// pictureBoxMenu
			// 
			this.pictureBoxMenu.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMenu.Image")));
			this.pictureBoxMenu.Location = new System.Drawing.Point(32, 16);
			this.pictureBoxMenu.Name = "pictureBoxMenu";
			this.pictureBoxMenu.Size = new System.Drawing.Size(949, 520);
			this.pictureBoxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxMenu.TabIndex = 0;
			this.pictureBoxMenu.TabStop = false;
			// 
			// PictureBoxHelp
			// 
			this.PictureBoxHelp.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxHelp.Image")));
			this.PictureBoxHelp.Location = new System.Drawing.Point(896, 144);
			this.PictureBoxHelp.Name = "PictureBoxHelp";
			this.PictureBoxHelp.Size = new System.Drawing.Size(43, 46);
			this.PictureBoxHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.PictureBoxHelp.TabIndex = 44;
			this.PictureBoxHelp.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(56, 80);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(249, 115);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox2.TabIndex = 45;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(752, 32);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(187, 28);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox3.TabIndex = 46;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(288, 360);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(29, 154);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox4.TabIndex = 47;
			this.pictureBox4.TabStop = false;
			// 
			// PictureBoxClose
			// 
			this.PictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxClose.Image")));
			this.PictureBoxClose.Location = new System.Drawing.Point(896, 80);
			this.PictureBoxClose.Name = "PictureBoxClose";
			this.PictureBoxClose.Size = new System.Drawing.Size(43, 43);
			this.PictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.PictureBoxClose.TabIndex = 57;
			this.PictureBoxClose.TabStop = false;
			this.PictureBoxClose.Click += new System.EventHandler(this.PictureBoxClose_Click);
			// 
			// FrmBigMenu
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.PictureBoxClose);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.PictureBoxHelp);
			this.Controls.Add(this.pictureBoxMenu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmBigMenu";
			this.Text = "FrmMemberMenu";
			this.Load += new System.EventHandler(this.FrmMemberMenu_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void FrmMemberMenu_Load(object sender, System.EventArgs e)
		{
			this.Location = new System.Drawing.Point(2,165);
		}

		private void PictureBoxClose_Click(object sender, System.EventArgs e)
		{
			this.Dispose();
		}







	}
}
