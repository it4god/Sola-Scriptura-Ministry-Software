using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Sola_Scriptura_Wedding
{
	public class FrmSearchMemberMaster : Sola_Scriptura_Wedding.FrmFormParent
	{
		internal System.Windows.Forms.Button buttonShow;
		internal System.Windows.Forms.Button buttonSearch;
		private System.ComponentModel.IContainer components = null;

		public FrmSearchMemberMaster()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmSearchMemberMaster));
			this.buttonShow = new System.Windows.Forms.Button();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonShow
			// 
			this.buttonShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonShow.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonShow.Image = ((System.Drawing.Image)(resources.GetObject("buttonShow.Image")));
			this.buttonShow.Location = new System.Drawing.Point(32, 128);
			this.buttonShow.Name = "buttonShow";
			this.buttonShow.Size = new System.Drawing.Size(144, 40);
			this.buttonShow.TabIndex = 2;
			this.buttonShow.Text = "Show";
			this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
			// 
			// buttonSearch
			// 
			this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonSearch.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearch.Image")));
			this.buttonSearch.Location = new System.Drawing.Point(32, 80);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(144, 40);
			this.buttonSearch.TabIndex = 1;
			this.buttonSearch.Text = "Search";
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// FrmSearchMemberMaster
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.buttonShow);
			this.Controls.Add(this.buttonSearch);
			this.Name = "FrmSearchMemberMaster";
			this.Controls.SetChildIndex(this.buttonSearch, 0);
			this.Controls.SetChildIndex(this.buttonShow, 0);
			this.ResumeLayout(false);

		}
		#endregion

		private void buttonSearch_Click(object sender, System.EventArgs e)
		{
			if(this is FrmSearchMember)
				this.Hide();
			else
				this.Hide();

			MyMDIForm.MySearchMemberForm.Show();
			MyMDIForm.MySearchMemberForm.Location = new Point(2,165);
			MyMDIForm.MySearchMemberForm.buttonSearch.Focus();
		}

		private void buttonShow_Click(object sender, System.EventArgs e)
		{
			if(this is FrmSearchMember)
				this.Hide();
			else
				this.Hide();
			MyMDIForm.MyShowMemberForm = new FrmShowMember(this.MyMDIForm);
			MyMDIForm.MyShowMemberForm.Show();
			MyMDIForm.MyShowMemberForm.Location = new Point(2,165);
			MyMDIForm.MyShowMemberForm.buttonShow.Focus();
		}
	}
}

