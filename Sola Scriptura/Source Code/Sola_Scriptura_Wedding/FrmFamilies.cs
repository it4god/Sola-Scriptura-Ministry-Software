using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Sola_Scriptura_Wedding
{
	public class FrmFamilies : Sola_Scriptura_Wedding.FrmFormParent
	{
		internal System.Windows.Forms.PictureBox pictureBoxLogoPicture;
		internal System.Windows.Forms.Label LabelTitle;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Timer timer1;
		internal int ticktick;
		internal System.Windows.Forms.PictureBox MyPicture1;
		internal System.Windows.Forms.PictureBox MyPicture2;
		internal System.Windows.Forms.PictureBox MyPicture3;
		internal System.Windows.Forms.PictureBox MyPicture4;
		internal System.Windows.Forms.Label label6;
		internal System.Windows.Forms.PictureBox MyPicture5;
		internal System.Windows.Forms.PictureBox MyPicture6;
		internal System.Windows.Forms.PictureBox MyPicture7;
		internal ClassDatabase MyClassDatabase;

		public FrmFamilies()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public FrmFamilies(FrmMDI MDIForm)
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmFamilies));
			this.pictureBoxLogoPicture = new System.Windows.Forms.PictureBox();
			this.LabelTitle = new System.Windows.Forms.Label();
			this.MyPicture1 = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.MyPicture2 = new System.Windows.Forms.PictureBox();
			this.MyPicture3 = new System.Windows.Forms.PictureBox();
			this.MyPicture4 = new System.Windows.Forms.PictureBox();
			this.label6 = new System.Windows.Forms.Label();
			this.MyPicture5 = new System.Windows.Forms.PictureBox();
			this.MyPicture6 = new System.Windows.Forms.PictureBox();
			this.MyPicture7 = new System.Windows.Forms.PictureBox();
			this.SuspendLayout();
			// 
			// pictureBoxLogoPicture
			// 
			this.pictureBoxLogoPicture.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogoPicture.Image")));
			this.pictureBoxLogoPicture.Location = new System.Drawing.Point(32, 80);
			this.pictureBoxLogoPicture.Name = "pictureBoxLogoPicture";
			this.pictureBoxLogoPicture.Size = new System.Drawing.Size(144, 88);
			this.pictureBoxLogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxLogoPicture.TabIndex = 194;
			this.pictureBoxLogoPicture.TabStop = false;
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
			this.LabelTitle.TabIndex = 193;
			this.LabelTitle.Text = "    Alone";
			this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// MyPicture1
			// 
			this.MyPicture1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.MyPicture1.Image = ((System.Drawing.Image)(resources.GetObject("MyPicture1.Image")));
			this.MyPicture1.Location = new System.Drawing.Point(288, 96);
			this.MyPicture1.Name = "MyPicture1";
			this.MyPicture1.Size = new System.Drawing.Size(344, 424);
			this.MyPicture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.MyPicture1.TabIndex = 195;
			this.MyPicture1.TabStop = false;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 7000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// MyPicture2
			// 
			this.MyPicture2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.MyPicture2.Image = ((System.Drawing.Image)(resources.GetObject("MyPicture2.Image")));
			this.MyPicture2.Location = new System.Drawing.Point(288, 96);
			this.MyPicture2.Name = "MyPicture2";
			this.MyPicture2.Size = new System.Drawing.Size(344, 424);
			this.MyPicture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.MyPicture2.TabIndex = 196;
			this.MyPicture2.TabStop = false;
			// 
			// MyPicture3
			// 
			this.MyPicture3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.MyPicture3.Image = ((System.Drawing.Image)(resources.GetObject("MyPicture3.Image")));
			this.MyPicture3.Location = new System.Drawing.Point(288, 96);
			this.MyPicture3.Name = "MyPicture3";
			this.MyPicture3.Size = new System.Drawing.Size(344, 424);
			this.MyPicture3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.MyPicture3.TabIndex = 197;
			this.MyPicture3.TabStop = false;
			// 
			// MyPicture4
			// 
			this.MyPicture4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.MyPicture4.Image = ((System.Drawing.Image)(resources.GetObject("MyPicture4.Image")));
			this.MyPicture4.Location = new System.Drawing.Point(288, 96);
			this.MyPicture4.Name = "MyPicture4";
			this.MyPicture4.Size = new System.Drawing.Size(344, 424);
			this.MyPicture4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.MyPicture4.TabIndex = 198;
			this.MyPicture4.TabStop = false;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label6.Location = new System.Drawing.Point(680, 352);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(240, 32);
			this.label6.TabIndex = 199;
			this.label6.Text = "Watch this pictures :) wait the next in some seconds";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// MyPicture5
			// 
			this.MyPicture5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.MyPicture5.Image = ((System.Drawing.Image)(resources.GetObject("MyPicture5.Image")));
			this.MyPicture5.Location = new System.Drawing.Point(288, 96);
			this.MyPicture5.Name = "MyPicture5";
			this.MyPicture5.Size = new System.Drawing.Size(344, 424);
			this.MyPicture5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.MyPicture5.TabIndex = 200;
			this.MyPicture5.TabStop = false;
			// 
			// MyPicture6
			// 
			this.MyPicture6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.MyPicture6.Image = ((System.Drawing.Image)(resources.GetObject("MyPicture6.Image")));
			this.MyPicture6.Location = new System.Drawing.Point(288, 96);
			this.MyPicture6.Name = "MyPicture6";
			this.MyPicture6.Size = new System.Drawing.Size(344, 424);
			this.MyPicture6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.MyPicture6.TabIndex = 201;
			this.MyPicture6.TabStop = false;
			// 
			// MyPicture7
			// 
			this.MyPicture7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.MyPicture7.Image = ((System.Drawing.Image)(resources.GetObject("MyPicture7.Image")));
			this.MyPicture7.Location = new System.Drawing.Point(288, 96);
			this.MyPicture7.Name = "MyPicture7";
			this.MyPicture7.Size = new System.Drawing.Size(344, 424);
			this.MyPicture7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.MyPicture7.TabIndex = 202;
			this.MyPicture7.TabStop = false;
			// 
			// FrmFamilies
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.MyPicture7);
			this.Controls.Add(this.MyPicture6);
			this.Controls.Add(this.MyPicture5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.MyPicture4);
			this.Controls.Add(this.MyPicture3);
			this.Controls.Add(this.MyPicture1);
			this.Controls.Add(this.MyPicture2);
			this.Controls.Add(this.LabelTitle);
			this.Controls.Add(this.pictureBoxLogoPicture);
			this.Name = "FrmFamilies";
			this.Load += new System.EventHandler(this.FrmFamilies_Load);
			this.Controls.SetChildIndex(this.pictureBoxLogoPicture, 0);
			this.Controls.SetChildIndex(this.LabelTitle, 0);
			this.Controls.SetChildIndex(this.MyPicture2, 0);
			this.Controls.SetChildIndex(this.MyPicture1, 0);
			this.Controls.SetChildIndex(this.MyPicture3, 0);
			this.Controls.SetChildIndex(this.MyPicture4, 0);
			this.Controls.SetChildIndex(this.label6, 0);
			this.Controls.SetChildIndex(this.MyPicture5, 0);
			this.Controls.SetChildIndex(this.MyPicture6, 0);
			this.Controls.SetChildIndex(this.MyPicture7, 0);
			this.ResumeLayout(false);

		}
		#endregion

	

		private void FrmFamilies_Load(object sender, System.EventArgs e)
		{
			MyClassDatabase = new ClassDatabase();	
			ticktick = 5;
		}

		private void textBoxRole_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		
			MyClassDatabase = new ClassDatabase();	
			
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
		
			MyClassDatabase = new ClassDatabase();	
			if(ticktick.ToString() == "1")
			{
				MyPicture1.BringToFront();
			}
			else if (ticktick.ToString() =="2")
			{	
				MyPicture2.BringToFront();
			}
			else if (ticktick.ToString() =="3")
			{	
				MyPicture3.BringToFront();
			}
			else if (ticktick.ToString() =="4")
			{	
				MyPicture4.BringToFront();
			}
			else if (ticktick.ToString() =="5")
			{	
				MyPicture5.BringToFront();
			}
			else if (ticktick.ToString() =="6")
			{	
				MyPicture6.BringToFront();
			}
			else if (ticktick.ToString() =="7")
			{	
				MyPicture7.BringToFront();
			}
		
		ticktick = ticktick + 1;
			if ( ticktick.ToString() == "7"  )
			{
				ticktick =1;
			}
			
		}

		private void label6_Click(object sender, System.EventArgs e)
		{
		
		}

	}
}

