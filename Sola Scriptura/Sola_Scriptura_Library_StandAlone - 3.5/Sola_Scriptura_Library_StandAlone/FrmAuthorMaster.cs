using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Sola_Scriptura_Library
{
	public class FrmAuthorMaster : Sola_Scriptura_Library.FrmFormParent
	{
		internal System.Windows.Forms.Button buttonAuthorType;
		private System.ComponentModel.IContainer components = null;
		internal System.Windows.Forms.Button buttonAuthor;
		internal System.Windows.Forms.PictureBox pictureBoxLogoPicture;

		internal FrmSetupMenu MySetupMenuForm;

		public FrmAuthorMaster()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public FrmAuthorMaster(FrmMDI MDIForm)
		{
			base.MyMDIForm = MDIForm;
			InitializeComponent();
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmAuthorMaster));
			this.buttonAuthor = new System.Windows.Forms.Button();
			this.buttonAuthorType = new System.Windows.Forms.Button();
			this.pictureBoxLogoPicture = new System.Windows.Forms.PictureBox();
			this.SuspendLayout();
			// 
			// buttonAuthor
			// 
			this.buttonAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonAuthor.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonAuthor.Image = ((System.Drawing.Image)(resources.GetObject("buttonAuthor.Image")));
			this.buttonAuthor.Location = new System.Drawing.Point(34, 80);
			this.buttonAuthor.Name = "buttonAuthor";
			this.buttonAuthor.Size = new System.Drawing.Size(144, 40);
			this.buttonAuthor.TabIndex = 100;
			this.buttonAuthor.Text = "Auhor";
			this.buttonAuthor.Click += new System.EventHandler(this.buttonAuthor_Click);
			// 
			// buttonAuthorType
			// 
			this.buttonAuthorType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonAuthorType.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonAuthorType.Image = ((System.Drawing.Image)(resources.GetObject("buttonAuthorType.Image")));
			this.buttonAuthorType.Location = new System.Drawing.Point(34, 128);
			this.buttonAuthorType.Name = "buttonAuthorType";
			this.buttonAuthorType.Size = new System.Drawing.Size(144, 40);
			this.buttonAuthorType.TabIndex = 102;
			this.buttonAuthorType.Text = "Auhor Type";
			this.buttonAuthorType.Click += new System.EventHandler(this.buttonAuthorType_Click);
			// 
			// pictureBoxLogoPicture
			// 
			this.pictureBoxLogoPicture.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogoPicture.Image")));
			this.pictureBoxLogoPicture.Location = new System.Drawing.Point(32, 464);
			this.pictureBoxLogoPicture.Name = "pictureBoxLogoPicture";
			this.pictureBoxLogoPicture.Size = new System.Drawing.Size(144, 88);
			this.pictureBoxLogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxLogoPicture.TabIndex = 175;
			this.pictureBoxLogoPicture.TabStop = false;
			// 
			// FrmAuthorMaster
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.pictureBoxLogoPicture);
			this.Controls.Add(this.buttonAuthorType);
			this.Controls.Add(this.buttonAuthor);
			this.Name = "FrmAuthorMaster";
			this.Load += new System.EventHandler(this.FrmAuthorMaster_Load);
			this.Controls.SetChildIndex(this.buttonAuthor, 0);
			this.Controls.SetChildIndex(this.buttonAuthorType, 0);
			this.Controls.SetChildIndex(this.pictureBoxLogoPicture, 0);
			this.ResumeLayout(false);

		}
		#endregion

		private void buttonAuthor_Click(object sender, System.EventArgs e)
		{

			this.Dispose();
			MySetupMenuForm.MyAuthorForm = new FrmAuthor(this.MyMDIForm, this.MySetupMenuForm);
			MySetupMenuForm.MyAuthorForm.Show();
			MySetupMenuForm.MyAuthorForm.Location = new Point(2,165);
			MySetupMenuForm.MyAuthorForm.buttonAuthor.Focus();

		}

		private void buttonAuthorType_Click(object sender, System.EventArgs e)
		{

			this.Dispose();
			MySetupMenuForm.MyAuthorTypeForm = new FrmAuthorType(this.MyMDIForm, this.MySetupMenuForm);
			MySetupMenuForm.MyAuthorTypeForm.Show();
			MySetupMenuForm.MyAuthorTypeForm.Location = new Point(2,165);
			MySetupMenuForm.MyAuthorTypeForm.buttonAuthorType.Focus();
		}

        private void FrmAuthorMaster_Load(object sender, System.EventArgs e)
		{
			this.Location = new System.Drawing.Point(2,165);
		}


	}
}

