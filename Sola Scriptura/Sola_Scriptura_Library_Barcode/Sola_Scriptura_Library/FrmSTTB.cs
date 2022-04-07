using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Sola_Scriptura_Library
{
	/// <summary>
	/// Summary description for FrmSTTB.
	/// </summary>
	public class FrmSTTB : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.PictureBox pictureBox1;
		internal System.Windows.Forms.PictureBox PictureBoxHelp;
		internal System.Windows.Forms.PictureBox PictureBoxClose;
		internal System.Windows.Forms.PictureBox pictureBox4;
		internal System.Windows.Forms.PictureBox pictureBox3;
		internal System.Windows.Forms.Label label1;
		internal System.Windows.Forms.Label LabelTitle;
		
		internal FrmMDI MyMDIForm;
		internal System.Windows.Forms.Label label2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
	
		public FrmSTTB()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}
		public FrmSTTB(FrmMDI MDIForm)
		{
			MyMDIForm = MDIForm;
			InitializeComponent();
			this.MdiParent = MyMDIForm;
							
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmSTTB));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.PictureBoxHelp = new System.Windows.Forms.PictureBox();
			this.PictureBoxClose = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.LabelTitle = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(744, 552);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// PictureBoxHelp
			// 
			this.PictureBoxHelp.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxHelp.Image")));
			this.PictureBoxHelp.Location = new System.Drawing.Point(664, 128);
			this.PictureBoxHelp.Name = "PictureBoxHelp";
			this.PictureBoxHelp.Size = new System.Drawing.Size(43, 46);
			this.PictureBoxHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.PictureBoxHelp.TabIndex = 67;
			this.PictureBoxHelp.TabStop = false;
			// 
			// PictureBoxClose
			// 
			this.PictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxClose.Image")));
			this.PictureBoxClose.Location = new System.Drawing.Point(664, 64);
			this.PictureBoxClose.Name = "PictureBoxClose";
			this.PictureBoxClose.Size = new System.Drawing.Size(43, 43);
			this.PictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.PictureBoxClose.TabIndex = 66;
			this.PictureBoxClose.TabStop = false;
			this.PictureBoxClose.Click += new System.EventHandler(this.PictureBoxClose_Click);
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(24, 400);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(376, 128);
			this.pictureBox4.TabIndex = 69;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(32, 80);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(176, 216);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 70;
			this.pictureBox3.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(128)));
			this.label1.Location = new System.Drawing.Point(296, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(168, 80);
			this.label1.TabIndex = 71;
			this.label1.Text = "PERPUSTAKAAN";
			// 
			// LabelTitle
			// 
			this.LabelTitle.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.LabelTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.LabelTitle.Image = ((System.Drawing.Image)(resources.GetObject("LabelTitle.Image")));
			this.LabelTitle.Location = new System.Drawing.Point(520, 16);
			this.LabelTitle.Name = "LabelTitle";
			this.LabelTitle.Size = new System.Drawing.Size(192, 32);
			this.LabelTitle.TabIndex = 158;
			this.LabelTitle.Text = "    Home";
			this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Yellow;
			this.label2.Location = new System.Drawing.Point(304, 128);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(256, 88);
			this.label2.TabIndex = 159;
			this.label2.Text = "Reformed Institute";
			// 
			// FrmSTTB
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.ClientSize = new System.Drawing.Size(728, 542);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.LabelTitle);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.PictureBoxHelp);
			this.Controls.Add(this.PictureBoxClose);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmSTTB";
			this.Text = "FrmInstitut";
			this.Load += new System.EventHandler(this.FrmSTTB_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void FrmSTTB_Load(object sender, System.EventArgs e)
		{
			this.Location = new System.Drawing.Point(150,180);
		}

		private void PictureBoxClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
			this.Dispose();
		}

		private void pictureBox1_Click(object sender, System.EventArgs e)
		{
		
		}
	}
}
