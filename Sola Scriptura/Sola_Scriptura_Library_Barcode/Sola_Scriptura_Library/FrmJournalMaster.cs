using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Sola_Scriptura_Library
{
	public class FrmJournalMaster : Sola_Scriptura_Library.FrmFormParent
	{
		internal System.Windows.Forms.PictureBox pictureBoxLogoPicture;
		internal System.Windows.Forms.Button buttonJournalList;
		internal System.Windows.Forms.Button buttonJournalArticles;
		internal System.Windows.Forms.Button buttonJournalDetail;
		internal System.Windows.Forms.Button buttonJournalMaster;
		private System.ComponentModel.IContainer components = null;

		internal FrmBookMenu MyBookMenuForm;

		public FrmJournalMaster()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmJournalMaster));
			this.pictureBoxLogoPicture = new System.Windows.Forms.PictureBox();
			this.buttonJournalDetail = new System.Windows.Forms.Button();
			this.buttonJournalMaster = new System.Windows.Forms.Button();
			this.buttonJournalList = new System.Windows.Forms.Button();
			this.buttonJournalArticles = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// pictureBoxLogoPicture
			// 
			this.pictureBoxLogoPicture.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogoPicture.Image")));
			this.pictureBoxLogoPicture.Location = new System.Drawing.Point(32, 464);
			this.pictureBoxLogoPicture.Name = "pictureBoxLogoPicture";
			this.pictureBoxLogoPicture.Size = new System.Drawing.Size(144, 88);
			this.pictureBoxLogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxLogoPicture.TabIndex = 179;
			this.pictureBoxLogoPicture.TabStop = false;
			// 
			// buttonJournalDetail
			// 
			this.buttonJournalDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonJournalDetail.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonJournalDetail.Image = ((System.Drawing.Image)(resources.GetObject("buttonJournalDetail.Image")));
			this.buttonJournalDetail.Location = new System.Drawing.Point(34, 176);
			this.buttonJournalDetail.Name = "buttonJournalDetail";
			this.buttonJournalDetail.Size = new System.Drawing.Size(144, 40);
			this.buttonJournalDetail.TabIndex = 178;
			this.buttonJournalDetail.Text = "Journal Detail";
			this.buttonJournalDetail.Click += new System.EventHandler(this.buttonJournalDetail_Click);
			// 
			// buttonJournalMaster
			// 
			this.buttonJournalMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonJournalMaster.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonJournalMaster.Image = ((System.Drawing.Image)(resources.GetObject("buttonJournalMaster.Image")));
			this.buttonJournalMaster.Location = new System.Drawing.Point(34, 128);
			this.buttonJournalMaster.Name = "buttonJournalMaster";
			this.buttonJournalMaster.Size = new System.Drawing.Size(144, 40);
			this.buttonJournalMaster.TabIndex = 177;
			this.buttonJournalMaster.Text = "Journal Master";
			this.buttonJournalMaster.Click += new System.EventHandler(this.buttonJournalMaster_Click);
			// 
			// buttonJournalList
			// 
			this.buttonJournalList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonJournalList.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonJournalList.Image = ((System.Drawing.Image)(resources.GetObject("buttonJournalList.Image")));
			this.buttonJournalList.Location = new System.Drawing.Point(34, 80);
			this.buttonJournalList.Name = "buttonJournalList";
			this.buttonJournalList.Size = new System.Drawing.Size(144, 40);
			this.buttonJournalList.TabIndex = 176;
			this.buttonJournalList.Text = "Journal List";
			this.buttonJournalList.Click += new System.EventHandler(this.buttonJournalList_Click);
			// 
			// buttonJournalArticles
			// 
			this.buttonJournalArticles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonJournalArticles.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonJournalArticles.Image = ((System.Drawing.Image)(resources.GetObject("buttonJournalArticles.Image")));
			this.buttonJournalArticles.Location = new System.Drawing.Point(34, 224);
			this.buttonJournalArticles.Name = "buttonJournalArticles";
			this.buttonJournalArticles.Size = new System.Drawing.Size(144, 40);
			this.buttonJournalArticles.TabIndex = 180;
			this.buttonJournalArticles.Text = "Journal Articles";
			this.buttonJournalArticles.Click += new System.EventHandler(this.buttonJournalArticles_Click);
			// 
			// FrmJournalMaster
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.buttonJournalArticles);
			this.Controls.Add(this.pictureBoxLogoPicture);
			this.Controls.Add(this.buttonJournalDetail);
			this.Controls.Add(this.buttonJournalMaster);
			this.Controls.Add(this.buttonJournalList);
			this.Name = "FrmJournalMaster";
			this.Controls.SetChildIndex(this.buttonJournalList, 0);
			this.Controls.SetChildIndex(this.buttonJournalMaster, 0);
			this.Controls.SetChildIndex(this.buttonJournalDetail, 0);
			this.Controls.SetChildIndex(this.pictureBoxLogoPicture, 0);
			this.Controls.SetChildIndex(this.buttonJournalArticles, 0);
			this.ResumeLayout(false);

		}
		#endregion

		private void buttonJournalList_Click(object sender, System.EventArgs e)
		{
	
				this.Hide();

			
			MyBookMenuForm.MyJournalListForm.Show();
			MyBookMenuForm.MyJournalListForm.Location = new Point(2,165);
			MyBookMenuForm.MyJournalListForm.buttonJournalList.Focus();
		}

		private void buttonJournalMaster_Click(object sender, System.EventArgs e)
		{

				this.Hide();

			MyBookMenuForm.MyJournalMasterForm = new FrmJournalMasterDetail(this.MyMDIForm,this.MyBookMenuForm);
			MyBookMenuForm.MyJournalMasterForm.Show();
			MyBookMenuForm.MyJournalMasterForm.Location = new Point(2,165);
			MyBookMenuForm.MyJournalMasterForm.buttonJournalMaster.Focus();
		}

		private void buttonJournalDetail_Click(object sender, System.EventArgs e)
		{
			if(this.MyMDIForm.MyJournal.JournalID !="")
			{

					this.Hide();

				MyBookMenuForm.MyJournalDetailForm = new FrmJournalDetail(this.MyMDIForm,this.MyBookMenuForm);
				MyBookMenuForm.MyJournalDetailForm.Show();
				MyBookMenuForm.MyJournalDetailForm.Location = new Point(2,165);
				MyBookMenuForm.MyJournalDetailForm.buttonJournalDetail.Focus();
			}
			else
			{
				MessageBox.Show("Please get the Journal Master Data in Journal List !","Information");
			}
		}
		private void buttonJournalArticles_Click(object sender, System.EventArgs e)
		{
			if(this.MyMDIForm.MyJournal.JournalID !="" && this.MyMDIForm.MyJournal.JournalDetailID!="")
			{

					this.Hide();

				MyBookMenuForm.MyJournalArticlesForm = new FrmJournalArticles(this.MyMDIForm,this.MyBookMenuForm);
				MyBookMenuForm.MyJournalArticlesForm.Show();
				MyBookMenuForm.MyJournalArticlesForm.Location = new Point(2,165);
				MyBookMenuForm.MyJournalArticlesForm.buttonJournalArticles.Focus();
			}
			else
			{
				MessageBox.Show("Please get the Journal Detail Data in Journal Detail !","Information");
			}
		}
	}
}

