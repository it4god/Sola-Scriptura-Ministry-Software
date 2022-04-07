using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Sola_Scriptura_Wedding
{
	public class FrmDataMenu : Sola_Scriptura_Wedding.FrmBigMenu
	{
		private System.ComponentModel.IContainer components = null;
		
		internal FrmSingle MySingleForm;
		internal System.Windows.Forms.PictureBox pictureBox5;
		internal System.Windows.Forms.PictureBox pictureBox1;
		internal System.Windows.Forms.Label labelTitle;
		internal System.Windows.Forms.PictureBox pictureBoxInRelationship;
		internal System.Windows.Forms.Label labelSingle;
		internal System.Windows.Forms.Label labelInrelationship;
		internal System.Windows.Forms.PictureBox pictureBox6;
		internal System.Windows.Forms.Label labelFamilies;
		internal System.Windows.Forms.Label labelMinistry;
		internal System.Windows.Forms.PictureBox pictureBox7;
		internal System.Windows.Forms.Label labelFriends;
		internal FrmInRelationship MyInRelationshipForm;
		internal FrmMinistry MyMinistryForm;
		internal FrmFriends MyFriendsForm;
		internal FrmFamilies MyFamiliesForm;
		internal string AppPath;
		public FrmDataMenu()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public FrmDataMenu(FrmMDI MDIForm)
		{
			base.MyMDIForm = MDIForm;
			InitializeComponent();
			this.MdiParent = base.MyMDIForm;
			base.pictureBoxMenu.SendToBack ();
				
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmDataMenu));
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.labelTitle = new System.Windows.Forms.Label();
			this.pictureBoxInRelationship = new System.Windows.Forms.PictureBox();
			this.labelSingle = new System.Windows.Forms.Label();
			this.labelFamilies = new System.Windows.Forms.Label();
			this.labelInrelationship = new System.Windows.Forms.Label();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.labelMinistry = new System.Windows.Forms.Label();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.labelFriends = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(488, 224);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(253, 58);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox5.TabIndex = 189;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(488, 288);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(253, 58);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 187;
			this.pictureBox1.TabStop = false;
			// 
			// labelTitle
			// 
			this.labelTitle.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelTitle.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTitle.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelTitle.Location = new System.Drawing.Point(488, 112);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(240, 32);
			this.labelTitle.TabIndex = 186;
			this.labelTitle.Text = "Album";
			this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// pictureBoxInRelationship
			// 
			this.pictureBoxInRelationship.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInRelationship.Image")));
			this.pictureBoxInRelationship.Location = new System.Drawing.Point(488, 160);
			this.pictureBoxInRelationship.Name = "pictureBoxInRelationship";
			this.pictureBoxInRelationship.Size = new System.Drawing.Size(253, 58);
			this.pictureBoxInRelationship.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxInRelationship.TabIndex = 184;
			this.pictureBoxInRelationship.TabStop = false;
			this.pictureBoxInRelationship.Visible = false;
			// 
			// labelSingle
			// 
			this.labelSingle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelSingle.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelSingle.Image = ((System.Drawing.Image)(resources.GetObject("labelSingle.Image")));
			this.labelSingle.Location = new System.Drawing.Point(576, 180);
			this.labelSingle.Name = "labelSingle";
			this.labelSingle.Size = new System.Drawing.Size(120, 16);
			this.labelSingle.TabIndex = 193;
			this.labelSingle.Text = "Single";
			this.labelSingle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelSingle.Visible = false;
			this.labelSingle.Click += new System.EventHandler(this.labelSingle_Click_1);
			// 
			// labelFamilies
			// 
			this.labelFamilies.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelFamilies.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelFamilies.Image = ((System.Drawing.Image)(resources.GetObject("labelFamilies.Image")));
			this.labelFamilies.Location = new System.Drawing.Point(576, 308);
			this.labelFamilies.Name = "labelFamilies";
			this.labelFamilies.Size = new System.Drawing.Size(144, 16);
			this.labelFamilies.TabIndex = 194;
			this.labelFamilies.Text = "Alone";
			this.labelFamilies.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelFamilies.Click += new System.EventHandler(this.labelFamilies_Click);
			// 
			// labelInrelationship
			// 
			this.labelInrelationship.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelInrelationship.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelInrelationship.Image = ((System.Drawing.Image)(resources.GetObject("labelInrelationship.Image")));
			this.labelInrelationship.Location = new System.Drawing.Point(576, 244);
			this.labelInrelationship.Name = "labelInrelationship";
			this.labelInrelationship.Size = new System.Drawing.Size(120, 16);
			this.labelInrelationship.TabIndex = 195;
			this.labelInrelationship.Text = "Together";
			this.labelInrelationship.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelInrelationship.Click += new System.EventHandler(this.labelInrelationship_Click);
			// 
			// pictureBox6
			// 
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(488, 432);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(253, 58);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox6.TabIndex = 196;
			this.pictureBox6.TabStop = false;
			this.pictureBox6.Visible = false;
			// 
			// labelMinistry
			// 
			this.labelMinistry.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelMinistry.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelMinistry.Image = ((System.Drawing.Image)(resources.GetObject("labelMinistry.Image")));
			this.labelMinistry.Location = new System.Drawing.Point(576, 450);
			this.labelMinistry.Name = "labelMinistry";
			this.labelMinistry.Size = new System.Drawing.Size(120, 16);
			this.labelMinistry.TabIndex = 197;
			this.labelMinistry.Text = "Ministry";
			this.labelMinistry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelMinistry.Visible = false;
			this.labelMinistry.Click += new System.EventHandler(this.labelMinistry_Click);
			// 
			// pictureBox7
			// 
			this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
			this.pictureBox7.Location = new System.Drawing.Point(488, 360);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(253, 58);
			this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox7.TabIndex = 198;
			this.pictureBox7.TabStop = false;
			this.pictureBox7.Visible = false;
			// 
			// labelFriends
			// 
			this.labelFriends.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelFriends.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelFriends.Image = ((System.Drawing.Image)(resources.GetObject("labelFriends.Image")));
			this.labelFriends.Location = new System.Drawing.Point(576, 378);
			this.labelFriends.Name = "labelFriends";
			this.labelFriends.Size = new System.Drawing.Size(144, 16);
			this.labelFriends.TabIndex = 199;
			this.labelFriends.Text = "Friends";
			this.labelFriends.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelFriends.Visible = false;
			this.labelFriends.Click += new System.EventHandler(this.labelFriends_Click);
			// 
			// FrmDataMenu
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.labelFriends);
			this.Controls.Add(this.pictureBox7);
			this.Controls.Add(this.labelMinistry);
			this.Controls.Add(this.pictureBox6);
			this.Controls.Add(this.labelInrelationship);
			this.Controls.Add(this.labelFamilies);
			this.Controls.Add(this.labelSingle);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.labelTitle);
			this.Controls.Add(this.pictureBoxInRelationship);
			this.Name = "FrmDataMenu";
			this.Load += new System.EventHandler(this.FrmDataMenu_Load);
			this.Controls.SetChildIndex(this.pictureBoxInRelationship, 0);
			this.Controls.SetChildIndex(this.labelTitle, 0);
			this.Controls.SetChildIndex(this.pictureBox1, 0);
			this.Controls.SetChildIndex(this.pictureBox5, 0);
			this.Controls.SetChildIndex(this.labelSingle, 0);
			this.Controls.SetChildIndex(this.labelFamilies, 0);
			this.Controls.SetChildIndex(this.labelInrelationship, 0);
			this.Controls.SetChildIndex(this.pictureBox6, 0);
			this.Controls.SetChildIndex(this.labelMinistry, 0);
			this.Controls.SetChildIndex(this.pictureBox7, 0);
			this.Controls.SetChildIndex(this.labelFriends, 0);
			this.ResumeLayout(false);

		}
		#endregion


		private void labelSingle_Click_1(object sender, System.EventArgs e)
		{
			MySingleForm = new FrmSingle(this.MyMDIForm );
			MySingleForm.Show();
		}

		private void labelInrelationship_Click(object sender, System.EventArgs e)
		{
			MyInRelationshipForm = new FrmInRelationship(this.MyMDIForm);
			MyInRelationshipForm.Show();
		}

		private void labelFamilies_Click(object sender, System.EventArgs e)
		{
			MyFamiliesForm = new FrmFamilies(this.MyMDIForm);
			MyFamiliesForm.Show();
		}

		private void labelFriends_Click(object sender, System.EventArgs e)
		{
			MyFriendsForm = new FrmFriends(this.MyMDIForm);
			MyFriendsForm.Show();
		}

		private void labelMinistry_Click(object sender, System.EventArgs e)
		{
			MyMinistryForm = new FrmMinistry(this.MyMDIForm);
			MyMinistryForm.Show();
		}

		private void FrmDataMenu_Load(object sender, System.EventArgs e)
		{
		AppPath  =Application.ExecutablePath.Replace(Application.ProductName + ".exe", "").Replace(".exe","");
			
			MyMDIForm.MyMP3Player.Close();
			MyMDIForm.MyMP3Player = new MP3Player();
			MyMDIForm.MyMP3Player.Open(AppPath.ToString()  + "\\music\\album.mp3");
			MyMDIForm.MyMP3Player.Play();
		}

	}
}

