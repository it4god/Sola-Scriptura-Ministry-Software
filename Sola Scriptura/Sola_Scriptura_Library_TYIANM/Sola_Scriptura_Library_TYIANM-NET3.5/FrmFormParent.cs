using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Sola_Scriptura_Library
{
	/// <summary>
	/// Summary description for FrmSmallMenu.
	/// </summary>
	public class FrmFormParent : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.PictureBox pictureBoxLeftForm;
		internal System.Windows.Forms.PictureBox pictureBoxMainForm;
		internal System.Windows.Forms.PictureBox pictureBoxVariant;
		internal System.Windows.Forms.PictureBox PictureBoxHelp;
		internal System.Windows.Forms.PictureBox PictureBoxClose;
		internal FrmMDI MyMDIForm;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmFormParent()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}
		public FrmFormParent(FrmMDI MDIForm)
		{
			MyMDIForm = MDIForm;
			InitializeComponent();
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmFormParent));
			this.pictureBoxLeftForm = new System.Windows.Forms.PictureBox();
			this.pictureBoxMainForm = new System.Windows.Forms.PictureBox();
			this.pictureBoxVariant = new System.Windows.Forms.PictureBox();
			this.PictureBoxHelp = new System.Windows.Forms.PictureBox();
			this.PictureBoxClose = new System.Windows.Forms.PictureBox();
			this.SuspendLayout();
			// 
			// pictureBoxLeftForm
			// 
			this.pictureBoxLeftForm.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLeftForm.Image")));
			this.pictureBoxLeftForm.Location = new System.Drawing.Point(8, 0);
			this.pictureBoxLeftForm.Name = "pictureBoxLeftForm";
			this.pictureBoxLeftForm.Size = new System.Drawing.Size(192, 568);
			this.pictureBoxLeftForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxLeftForm.TabIndex = 0;
			this.pictureBoxLeftForm.TabStop = false;
			// 
			// pictureBoxMainForm
			// 
			this.pictureBoxMainForm.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMainForm.Image")));
			this.pictureBoxMainForm.Location = new System.Drawing.Point(200, 0);
			this.pictureBoxMainForm.Name = "pictureBoxMainForm";
			this.pictureBoxMainForm.Size = new System.Drawing.Size(816, 568);
			this.pictureBoxMainForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxMainForm.TabIndex = 1;
			this.pictureBoxMainForm.TabStop = false;
			// 
			// pictureBoxVariant
			// 
			this.pictureBoxVariant.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxVariant.Image")));
			this.pictureBoxVariant.Location = new System.Drawing.Point(216, 400);
			this.pictureBoxVariant.Name = "pictureBoxVariant";
			this.pictureBoxVariant.Size = new System.Drawing.Size(29, 154);
			this.pictureBoxVariant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxVariant.TabIndex = 2;
			this.pictureBoxVariant.TabStop = false;
			// 
			// PictureBoxHelp
			// 
			this.PictureBoxHelp.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxHelp.Image")));
			this.PictureBoxHelp.Location = new System.Drawing.Point(952, 136);
			this.PictureBoxHelp.Name = "PictureBoxHelp";
			this.PictureBoxHelp.Size = new System.Drawing.Size(43, 46);
			this.PictureBoxHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.PictureBoxHelp.TabIndex = 63;
			this.PictureBoxHelp.TabStop = false;
			// 
			// PictureBoxClose
			// 
			this.PictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxClose.Image")));
			this.PictureBoxClose.Location = new System.Drawing.Point(952, 72);
			this.PictureBoxClose.Name = "PictureBoxClose";
			this.PictureBoxClose.Size = new System.Drawing.Size(43, 43);
			this.PictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.PictureBoxClose.TabIndex = 62;
			this.PictureBoxClose.TabStop = false;
			this.PictureBoxClose.Click += new System.EventHandler(this.PictureBoxClose_Click);
			// 
			// FrmFormParent
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(86)), ((System.Byte)(127)), ((System.Byte)(220)));
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.PictureBoxHelp);
			this.Controls.Add(this.PictureBoxClose);
			this.Controls.Add(this.pictureBoxVariant);
			this.Controls.Add(this.pictureBoxMainForm);
			this.Controls.Add(this.pictureBoxLeftForm);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmFormParent";
			this.Text = "FrmFormParent";
			this.Load += new System.EventHandler(this.FrmFormParent_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void FrmFormParent_Load(object sender, System.EventArgs e)
		{
			this.Location = new System.Drawing.Point(2,165);
		}

		private void PictureBoxClose_Click(object sender, System.EventArgs e)
		{
			this.Dispose();
		}
	}
}
