using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;


namespace Sola_Scriptura_Wedding
{
	/// <summary>
	/// Summary description for FrmWebsite.
	/// </summary>
	public class FrmWebsite : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		internal System.Windows.Forms.PictureBox PictureBoxHelp;
		internal System.Windows.Forms.PictureBox PictureBoxClose;
		public System.Data.SqlClient.SqlConnection sqlConnection1;
		internal System.Windows.Forms.Label label5;
		private System.Windows.Forms.PictureBox pictureBox6;
		public string AppPath;
		private System.Windows.Forms.PictureBox pictureBox1;
		private object empty;
		public MP3Player MyMP3Player;
		public static System.Object nullObject = 0;
		public static String str = "";
		public static System.Object nullObjStr = str;
		public static bool showButtons, showAddress, showStatus = true;
		private System.Windows.Forms.ProgressBar pBar;
		
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmWebsite()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmWebsite));
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.PictureBoxHelp = new System.Windows.Forms.PictureBox();
			this.PictureBoxClose = new System.Windows.Forms.PictureBox();
			this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
			this.label5 = new System.Windows.Forms.Label();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pBar = new System.Windows.Forms.ProgressBar();
			this.SuspendLayout();
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(104, 64);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(440, 120);
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(552, 16);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(152, 32);
			this.pictureBox3.TabIndex = 2;
			this.pictureBox3.TabStop = false;
			// 
			// PictureBoxHelp
			// 
			this.PictureBoxHelp.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxHelp.Image")));
			this.PictureBoxHelp.Location = new System.Drawing.Point(664, 128);
			this.PictureBoxHelp.Name = "PictureBoxHelp";
			this.PictureBoxHelp.Size = new System.Drawing.Size(43, 46);
			this.PictureBoxHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.PictureBoxHelp.TabIndex = 65;
			this.PictureBoxHelp.TabStop = false;
			// 
			// PictureBoxClose
			// 
			this.PictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxClose.Image")));
			this.PictureBoxClose.Location = new System.Drawing.Point(664, 64);
			this.PictureBoxClose.Name = "PictureBoxClose";
			this.PictureBoxClose.Size = new System.Drawing.Size(43, 43);
			this.PictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.PictureBoxClose.TabIndex = 64;
			this.PictureBoxClose.TabStop = false;
			this.PictureBoxClose.Click += new System.EventHandler(this.PictureBoxClose_Click);
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label5.Location = new System.Drawing.Point(256, 96);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(232, 40);
			this.label5.TabIndex = 67;
			this.label5.Text = "    Website";
			// 
			// pictureBox6
			// 
			this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(24, 64);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(72, 65);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox6.TabIndex = 70;
			this.pictureBox6.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(744, 552);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// pBar
			// 
			this.pBar.Location = new System.Drawing.Point(0, 0);
			this.pBar.Name = "pBar";
			this.pBar.TabIndex = 0;
			// 
			// FrmWebsite
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.ClientSize = new System.Drawing.Size(728, 542);
			this.Controls.Add(this.pictureBox6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.PictureBoxHelp);
			this.Controls.Add(this.PictureBoxClose);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmWebsite";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "`";
			this.Load += new System.EventHandler(this.FrmWebsite_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void PictureBoxClose_Click(object sender, System.EventArgs e)
		{
			MyMP3Player.Close();
			this.Close();
			this.Dispose();
			
		}


		private void FrmWebsite_Load(object sender, System.EventArgs e)
		{
			this.Location = new System.Drawing.Point(150,180);
			AppPath  =Application.ExecutablePath.Replace(Application.ProductName + ".exe", "").Replace(".exe","");
			
		
			
			MyMP3Player = new MP3Player();
			MyMP3Player.Close();
			MyMP3Player.Open(AppPath + "\\music\\website.mp3");
			MyMP3Player.Play();
			
		
		}
		private void WB_ProgressChange(object sender, AxSHDocVw.DWebBrowserEvents2_ProgressChangeEvent e)
		{																				
			pBar.Maximum = e.progressMax;
			pBar.Value = e.progress;
							   
		}

		private void pictureBox1_Click(object sender, System.EventArgs e)
		{
		
		}
	}
}
