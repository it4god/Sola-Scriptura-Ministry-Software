using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Sola_Scriptura_Library
{
	public class FrmShelfLocationMaster : Sola_Scriptura_Library.FrmFormParent
	{
		internal System.Windows.Forms.Button buttonLocation;
		private System.ComponentModel.IContainer components = null;
		internal System.Windows.Forms.Button buttonShelfMaster;
		internal System.Windows.Forms.PictureBox pictureBoxLogoPicture;

		internal FrmSetupMenu MySetupMenuForm;

		public FrmShelfLocationMaster()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmShelfLocationMaster));
			this.buttonShelfMaster = new System.Windows.Forms.Button();
			this.buttonLocation = new System.Windows.Forms.Button();
			this.pictureBoxLogoPicture = new System.Windows.Forms.PictureBox();
			this.SuspendLayout();
			// 
			// buttonShelfMaster
			// 
			this.buttonShelfMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonShelfMaster.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonShelfMaster.Image = ((System.Drawing.Image)(resources.GetObject("buttonShelfMaster.Image")));
			this.buttonShelfMaster.Location = new System.Drawing.Point(34, 128);
			this.buttonShelfMaster.Name = "buttonShelfMaster";
			this.buttonShelfMaster.Size = new System.Drawing.Size(144, 40);
			this.buttonShelfMaster.TabIndex = 101;
			this.buttonShelfMaster.Text = "Shelf";
			this.buttonShelfMaster.Click += new System.EventHandler(this.buttonShelfMaster_Click);
			// 
			// buttonLocation
			// 
			this.buttonLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonLocation.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonLocation.Image = ((System.Drawing.Image)(resources.GetObject("buttonLocation.Image")));
			this.buttonLocation.Location = new System.Drawing.Point(34, 80);
			this.buttonLocation.Name = "buttonLocation";
			this.buttonLocation.Size = new System.Drawing.Size(144, 40);
			this.buttonLocation.TabIndex = 100;
			this.buttonLocation.Text = "Location";
			this.buttonLocation.Click += new System.EventHandler(this.buttonLocation_Click);
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
			// FrmShelfLocationMaster
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.pictureBoxLogoPicture);
			this.Controls.Add(this.buttonShelfMaster);
			this.Controls.Add(this.buttonLocation);
			this.Name = "FrmShelfLocationMaster";
			this.Controls.SetChildIndex(this.buttonLocation, 0);
			this.Controls.SetChildIndex(this.buttonShelfMaster, 0);
			this.Controls.SetChildIndex(this.pictureBoxLogoPicture, 0);
			this.ResumeLayout(false);

		}
		#endregion

		private void buttonLocation_Click(object sender, System.EventArgs e)
		{
			this.Dispose();
			MySetupMenuForm.MyLocationForm = new FrmLocation(this.MyMDIForm, this.MySetupMenuForm);
			MySetupMenuForm.MyLocationForm.Show();
			MySetupMenuForm.MyLocationForm.Location = new Point(2,165);
			MySetupMenuForm.MyLocationForm.buttonLocation.Focus();
		}

		private void buttonShelfMaster_Click(object sender, System.EventArgs e)
		{
			this.Dispose();
			MySetupMenuForm.MyShelfMasterForm = new FrmShelfMaster(this.MyMDIForm, this.MySetupMenuForm);
			MySetupMenuForm.MyShelfMasterForm.Show();
			MySetupMenuForm.MyShelfMasterForm.Location = new Point(2,165);
			MySetupMenuForm.MyShelfMasterForm.buttonShelfMaster.Focus();
		}


	}
}

