using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
namespace Sola_Scriptura_Wedding
{
	public class FrmInRelationship : Sola_Scriptura_Wedding.FrmFormParent
	{
		internal System.Windows.Forms.Label LabelTitle;
		internal System.Windows.Forms.PictureBox pictureBoxLogoPicture;
		private System.ComponentModel.IContainer components = null;


		internal System.Windows.Forms.PictureBox MyPicture1;
		internal System.Windows.Forms.PictureBox MyPicture2;
		internal System.Windows.Forms.PictureBox MyPicture3;
		internal System.Windows.Forms.PictureBox MyPicture4;
		private System.Windows.Forms.Timer timer1;
		internal System.Windows.Forms.Label label6;

		internal int ticktick;
		public FrmInRelationship()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public FrmInRelationship(FrmMDI MDIForm)
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmInRelationship));
			this.LabelTitle = new System.Windows.Forms.Label();
			this.pictureBoxLogoPicture = new System.Windows.Forms.PictureBox();
			this.MyPicture1 = new System.Windows.Forms.PictureBox();
			this.MyPicture2 = new System.Windows.Forms.PictureBox();
			this.MyPicture3 = new System.Windows.Forms.PictureBox();
			this.MyPicture4 = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.label6 = new System.Windows.Forms.Label();
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
			this.LabelTitle.TabIndex = 195;
			this.LabelTitle.Text = "    In Relationship";
			this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBoxLogoPicture
			// 
			this.pictureBoxLogoPicture.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogoPicture.Image")));
			this.pictureBoxLogoPicture.Location = new System.Drawing.Point(32, 80);
			this.pictureBoxLogoPicture.Name = "pictureBoxLogoPicture";
			this.pictureBoxLogoPicture.Size = new System.Drawing.Size(144, 88);
			this.pictureBoxLogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxLogoPicture.TabIndex = 196;
			this.pictureBoxLogoPicture.TabStop = false;
			// 
			// MyPicture1
			// 
			this.MyPicture1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.MyPicture1.Image = ((System.Drawing.Image)(resources.GetObject("MyPicture1.Image")));
			this.MyPicture1.Location = new System.Drawing.Point(288, 96);
			this.MyPicture1.Name = "MyPicture1";
			this.MyPicture1.Size = new System.Drawing.Size(616, 392);
			this.MyPicture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.MyPicture1.TabIndex = 197;
			this.MyPicture1.TabStop = false;
			// 
			// MyPicture2
			// 
			this.MyPicture2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.MyPicture2.Image = ((System.Drawing.Image)(resources.GetObject("MyPicture2.Image")));
			this.MyPicture2.Location = new System.Drawing.Point(288, 96);
			this.MyPicture2.Name = "MyPicture2";
			this.MyPicture2.Size = new System.Drawing.Size(616, 392);
			this.MyPicture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.MyPicture2.TabIndex = 198;
			this.MyPicture2.TabStop = false;
			// 
			// MyPicture3
			// 
			this.MyPicture3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.MyPicture3.Image = ((System.Drawing.Image)(resources.GetObject("MyPicture3.Image")));
			this.MyPicture3.Location = new System.Drawing.Point(288, 96);
			this.MyPicture3.Name = "MyPicture3";
			this.MyPicture3.Size = new System.Drawing.Size(616, 392);
			this.MyPicture3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.MyPicture3.TabIndex = 199;
			this.MyPicture3.TabStop = false;
			// 
			// MyPicture4
			// 
			this.MyPicture4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.MyPicture4.Image = ((System.Drawing.Image)(resources.GetObject("MyPicture4.Image")));
			this.MyPicture4.Location = new System.Drawing.Point(288, 96);
			this.MyPicture4.Name = "MyPicture4";
			this.MyPicture4.Size = new System.Drawing.Size(616, 392);
			this.MyPicture4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.MyPicture4.TabIndex = 200;
			this.MyPicture4.TabStop = false;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 7000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label6.Location = new System.Drawing.Point(288, 504);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(376, 32);
			this.label6.TabIndex = 205;
			this.label6.Text = "Watch this pictures :) wait the next in some seconds";
			// 
			// FrmInRelationship
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.MyPicture4);
			this.Controls.Add(this.MyPicture3);
			this.Controls.Add(this.MyPicture2);
			this.Controls.Add(this.MyPicture1);
			this.Controls.Add(this.LabelTitle);
			this.Controls.Add(this.pictureBoxLogoPicture);
			this.Name = "FrmInRelationship";
			this.Load += new System.EventHandler(this.FrmInRelationship_Load);
			this.Controls.SetChildIndex(this.pictureBoxLogoPicture, 0);
			this.Controls.SetChildIndex(this.LabelTitle, 0);
			this.Controls.SetChildIndex(this.MyPicture1, 0);
			this.Controls.SetChildIndex(this.MyPicture2, 0);
			this.Controls.SetChildIndex(this.MyPicture3, 0);
			this.Controls.SetChildIndex(this.MyPicture4, 0);
			this.Controls.SetChildIndex(this.label6, 0);
			this.ResumeLayout(false);

		}
		#endregion

		private void FrmInRelationship_Load(object sender, System.EventArgs e)
		{
			ticktick = 1;
MyPicture1.BringToFront();
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			
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
	
			ticktick = ticktick + 1;
			if ( ticktick.ToString() == "5"  )
			{
				ticktick =1;
			}


			
		}
	}
}