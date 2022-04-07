using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Teenager_Ministry
{
	public class FrmDataMenu : Teenager_Ministry.FrmBigMenu
	{
		internal System.Windows.Forms.PictureBox pictureBoxStatistics;
		internal System.Windows.Forms.PictureBox pictureBoxBookOutstanding;
		internal System.Windows.Forms.Label labelCheckStatistics;
		internal System.Windows.Forms.Label labelCheckAttendance;
		internal System.Windows.Forms.Label labelTitle;
		private System.ComponentModel.IContainer components = null;
		
		internal FrmCheckAttendance MyCheckAttendanceForm;
		internal FrmStatistics MyStatisticsForm;
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
			this.labelCheckStatistics = new System.Windows.Forms.Label();
			this.pictureBoxStatistics = new System.Windows.Forms.PictureBox();
			this.labelCheckAttendance = new System.Windows.Forms.Label();
			this.pictureBoxBookOutstanding = new System.Windows.Forms.PictureBox();
			this.labelTitle = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelCheckStatistics
			// 
			this.labelCheckStatistics.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelCheckStatistics.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelCheckStatistics.Image = ((System.Drawing.Image)(resources.GetObject("labelCheckStatistics.Image")));
			this.labelCheckStatistics.Location = new System.Drawing.Point(560, 252);
			this.labelCheckStatistics.Name = "labelCheckStatistics";
			this.labelCheckStatistics.Size = new System.Drawing.Size(120, 16);
			this.labelCheckStatistics.TabIndex = 178;
			this.labelCheckStatistics.Text = "Check Statistics";
			this.labelCheckStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelCheckStatistics.Click += new System.EventHandler(this.labelCheckStatistics_Click);
			// 
			// pictureBoxStatistics
			// 
			this.pictureBoxStatistics.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxStatistics.Image")));
			this.pictureBoxStatistics.Location = new System.Drawing.Point(448, 232);
			this.pictureBoxStatistics.Name = "pictureBoxStatistics";
			this.pictureBoxStatistics.Size = new System.Drawing.Size(253, 58);
			this.pictureBoxStatistics.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxStatistics.TabIndex = 177;
			this.pictureBoxStatistics.TabStop = false;
			// 
			// labelCheckAttendance
			// 
			this.labelCheckAttendance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelCheckAttendance.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelCheckAttendance.Image = ((System.Drawing.Image)(resources.GetObject("labelCheckAttendance.Image")));
			this.labelCheckAttendance.Location = new System.Drawing.Point(560, 180);
			this.labelCheckAttendance.Name = "labelCheckAttendance";
			this.labelCheckAttendance.Size = new System.Drawing.Size(120, 16);
			this.labelCheckAttendance.TabIndex = 175;
			this.labelCheckAttendance.Text = "Check Attendance";
			this.labelCheckAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelCheckAttendance.Click += new System.EventHandler(this.labelCheckAttendance_Click);
			// 
			// pictureBoxBookOutstanding
			// 
			this.pictureBoxBookOutstanding.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBookOutstanding.Image")));
			this.pictureBoxBookOutstanding.Location = new System.Drawing.Point(448, 160);
			this.pictureBoxBookOutstanding.Name = "pictureBoxBookOutstanding";
			this.pictureBoxBookOutstanding.Size = new System.Drawing.Size(253, 58);
			this.pictureBoxBookOutstanding.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxBookOutstanding.TabIndex = 173;
			this.pictureBoxBookOutstanding.TabStop = false;
			// 
			// labelTitle
			// 
			this.labelTitle.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelTitle.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTitle.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelTitle.Location = new System.Drawing.Point(448, 88);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(240, 32);
			this.labelTitle.TabIndex = 179;
			this.labelTitle.Text = "Data";
			this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// FrmDataMenu
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.labelTitle);
			this.Controls.Add(this.labelCheckStatistics);
			this.Controls.Add(this.pictureBoxStatistics);
			this.Controls.Add(this.labelCheckAttendance);
			this.Controls.Add(this.pictureBoxBookOutstanding);
			this.Name = "FrmDataMenu";
			this.Controls.SetChildIndex(this.pictureBoxBookOutstanding, 0);
			this.Controls.SetChildIndex(this.labelCheckAttendance, 0);
			this.Controls.SetChildIndex(this.pictureBoxStatistics, 0);
			this.Controls.SetChildIndex(this.labelCheckStatistics, 0);
			this.Controls.SetChildIndex(this.labelTitle, 0);
			this.ResumeLayout(false);

		}
		#endregion

		private void labelCheckAttendance_Click(object sender, System.EventArgs e)
		{
			MyCheckAttendanceForm = new FrmCheckAttendance(this.MyMDIForm );
			MyCheckAttendanceForm.Show();
		}

		private void labelCheckStatistics_Click(object sender, System.EventArgs e)
		{
			MyStatisticsForm = new FrmStatistics(this.MyMDIForm);
			MyStatisticsForm.Show();
		}
	}
}

