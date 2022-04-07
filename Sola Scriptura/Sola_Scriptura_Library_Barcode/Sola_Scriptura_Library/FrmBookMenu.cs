using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Sola_Scriptura_Library
{
	public class FrmBookMenu : Sola_Scriptura_Library.FrmBigMenu
	{
		internal System.Windows.Forms.Label labelTitle;
		internal System.Windows.Forms.PictureBox pictureBoxBookMaster;
		internal System.Windows.Forms.Label labelBookMaster;
		internal System.Windows.Forms.PictureBox pictureBoxBookOutstanding;
		internal System.Windows.Forms.PictureBox pictureBoxBookHistory;
		internal System.Windows.Forms.Label labelBookOutstanding;
		internal System.Windows.Forms.Label labelBookHistory;
		internal System.Windows.Forms.Label labelJournalMaster;
		internal System.Windows.Forms.PictureBox pictureBox1;
		internal System.Windows.Forms.PictureBox pictureBox5;
		internal System.Windows.Forms.Label labelBookStatistics;
		
		private System.ComponentModel.IContainer components = null;

		internal FrmBookMsList MyBookMsListForm;
		internal FrmBookMsDetail MyBookMsDetailForm;
		internal FrmBookMsCover MyBookMsCoverForm;
		internal FrmBookMsAuthor MyBookMsAuthorForm;
		internal FrmBookMsCopy MyBookMsCopyForm;
		internal FrmBookMsDesc MyBookMsDescForm;
		internal FrmBookMsSubject MyBookMsSubjectForm;
		internal FrmBookOutstanding MyBookOutstandingForm;
		internal FrmBookHistory MyBookHistoryForm;
		internal FrmJournalList MyJournalListForm;
		internal FrmJournalMasterDetail MyJournalMasterForm;
		internal FrmJournalDetail MyJournalDetailForm;
		internal FrmJournalArticles MyJournalArticlesForm;

		internal BookSearch MyBookSearch;
	
		internal System.Windows.Forms.PictureBox pictureBoxStatistics;
		internal FrmStatistics MyStatisticsForm;

		public FrmBookMenu()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public FrmBookMenu(FrmMDI MDIForm)
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmBookMenu));
			this.labelTitle = new System.Windows.Forms.Label();
			this.pictureBoxBookMaster = new System.Windows.Forms.PictureBox();
			this.labelBookMaster = new System.Windows.Forms.Label();
			this.pictureBoxBookOutstanding = new System.Windows.Forms.PictureBox();
			this.pictureBoxBookHistory = new System.Windows.Forms.PictureBox();
			this.labelBookOutstanding = new System.Windows.Forms.Label();
			this.labelBookHistory = new System.Windows.Forms.Label();
			this.labelJournalMaster = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBoxStatistics = new System.Windows.Forms.PictureBox();
			this.labelBookStatistics = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelTitle
			// 
			this.labelTitle.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelTitle.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTitle.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelTitle.Location = new System.Drawing.Point(400, 48);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(240, 32);
			this.labelTitle.TabIndex = 68;
			this.labelTitle.Text = "Book / Journal";
			this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// pictureBoxBookMaster
			// 
			this.pictureBoxBookMaster.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBookMaster.Image")));
			this.pictureBoxBookMaster.Location = new System.Drawing.Point(400, 96);
			this.pictureBoxBookMaster.Name = "pictureBoxBookMaster";
			this.pictureBoxBookMaster.Size = new System.Drawing.Size(253, 58);
			this.pictureBoxBookMaster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxBookMaster.TabIndex = 69;
			this.pictureBoxBookMaster.TabStop = false;
			// 
			// labelBookMaster
			// 
			this.labelBookMaster.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBookMaster.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelBookMaster.Image = ((System.Drawing.Image)(resources.GetObject("labelBookMaster.Image")));
			this.labelBookMaster.Location = new System.Drawing.Point(512, 116);
			this.labelBookMaster.Name = "labelBookMaster";
			this.labelBookMaster.Size = new System.Drawing.Size(120, 16);
			this.labelBookMaster.TabIndex = 73;
			this.labelBookMaster.Text = "Book Master";
			this.labelBookMaster.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelBookMaster.Click += new System.EventHandler(this.labelBookMaster_Click);
			// 
			// pictureBoxBookOutstanding
			// 
			this.pictureBoxBookOutstanding.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBookOutstanding.Image")));
			this.pictureBoxBookOutstanding.Location = new System.Drawing.Point(400, 280);
			this.pictureBoxBookOutstanding.Name = "pictureBoxBookOutstanding";
			this.pictureBoxBookOutstanding.Size = new System.Drawing.Size(253, 58);
			this.pictureBoxBookOutstanding.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxBookOutstanding.TabIndex = 75;
			this.pictureBoxBookOutstanding.TabStop = false;
			// 
			// pictureBoxBookHistory
			// 
			this.pictureBoxBookHistory.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBookHistory.Image")));
			this.pictureBoxBookHistory.Location = new System.Drawing.Point(400, 352);
			this.pictureBoxBookHistory.Name = "pictureBoxBookHistory";
			this.pictureBoxBookHistory.Size = new System.Drawing.Size(253, 58);
			this.pictureBoxBookHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxBookHistory.TabIndex = 76;
			this.pictureBoxBookHistory.TabStop = false;
			// 
			// labelBookOutstanding
			// 
			this.labelBookOutstanding.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBookOutstanding.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelBookOutstanding.Image = ((System.Drawing.Image)(resources.GetObject("labelBookOutstanding.Image")));
			this.labelBookOutstanding.Location = new System.Drawing.Point(512, 296);
			this.labelBookOutstanding.Name = "labelBookOutstanding";
			this.labelBookOutstanding.Size = new System.Drawing.Size(120, 16);
			this.labelBookOutstanding.TabIndex = 77;
			this.labelBookOutstanding.Text = "Book Outstanding";
			this.labelBookOutstanding.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelBookOutstanding.Click += new System.EventHandler(this.labelBookOutstanding_Click);
			// 
			// labelBookHistory
			// 
			this.labelBookHistory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBookHistory.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelBookHistory.Image = ((System.Drawing.Image)(resources.GetObject("labelBookHistory.Image")));
			this.labelBookHistory.Location = new System.Drawing.Point(512, 368);
			this.labelBookHistory.Name = "labelBookHistory";
			this.labelBookHistory.Size = new System.Drawing.Size(120, 16);
			this.labelBookHistory.TabIndex = 78;
			this.labelBookHistory.Text = "Book History";
			this.labelBookHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelBookHistory.Click += new System.EventHandler(this.labelBookHistory_Click);
			// 
			// labelJournalMaster
			// 
			this.labelJournalMaster.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelJournalMaster.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelJournalMaster.Image = ((System.Drawing.Image)(resources.GetObject("labelJournalMaster.Image")));
			this.labelJournalMaster.Location = new System.Drawing.Point(512, 188);
			this.labelJournalMaster.Name = "labelJournalMaster";
			this.labelJournalMaster.Size = new System.Drawing.Size(120, 16);
			this.labelJournalMaster.TabIndex = 80;
			this.labelJournalMaster.Text = "Journal Master";
			this.labelJournalMaster.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelJournalMaster.Click += new System.EventHandler(this.labelJournalMaster_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(400, 168);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(253, 58);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 79;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(344, 240);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(448, 10);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox5.TabIndex = 170;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBoxStatistics
			// 
			this.pictureBoxStatistics.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxStatistics.Image")));
			this.pictureBoxStatistics.Location = new System.Drawing.Point(400, 424);
			this.pictureBoxStatistics.Name = "pictureBoxStatistics";
			this.pictureBoxStatistics.Size = new System.Drawing.Size(253, 58);
			this.pictureBoxStatistics.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxStatistics.TabIndex = 171;
			this.pictureBoxStatistics.TabStop = false;
			// 
			// labelBookStatistics
			// 
			this.labelBookStatistics.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBookStatistics.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelBookStatistics.Image = ((System.Drawing.Image)(resources.GetObject("labelBookStatistics.Image")));
			this.labelBookStatistics.Location = new System.Drawing.Point(512, 444);
			this.labelBookStatistics.Name = "labelBookStatistics";
			this.labelBookStatistics.Size = new System.Drawing.Size(120, 16);
			this.labelBookStatistics.TabIndex = 172;
			this.labelBookStatistics.Text = "Book Statistics";
			this.labelBookStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelBookStatistics.Click += new System.EventHandler(this.labelBookStatistics_Click);
			// 
			// FrmBookMenu
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.labelBookStatistics);
			this.Controls.Add(this.pictureBoxStatistics);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.labelJournalMaster);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.labelBookHistory);
			this.Controls.Add(this.labelBookOutstanding);
			this.Controls.Add(this.pictureBoxBookHistory);
			this.Controls.Add(this.pictureBoxBookOutstanding);
			this.Controls.Add(this.labelBookMaster);
			this.Controls.Add(this.pictureBoxBookMaster);
			this.Controls.Add(this.labelTitle);
			this.Name = "FrmBookMenu";
			this.Controls.SetChildIndex(this.labelTitle, 0);
			this.Controls.SetChildIndex(this.pictureBoxBookMaster, 0);
			this.Controls.SetChildIndex(this.labelBookMaster, 0);
			this.Controls.SetChildIndex(this.pictureBoxBookOutstanding, 0);
			this.Controls.SetChildIndex(this.pictureBoxBookHistory, 0);
			this.Controls.SetChildIndex(this.labelBookOutstanding, 0);
			this.Controls.SetChildIndex(this.labelBookHistory, 0);
			this.Controls.SetChildIndex(this.pictureBox1, 0);
			this.Controls.SetChildIndex(this.labelJournalMaster, 0);
			this.Controls.SetChildIndex(this.pictureBox5, 0);
			this.Controls.SetChildIndex(this.pictureBoxStatistics, 0);
			this.Controls.SetChildIndex(this.labelBookStatistics, 0);
			this.ResumeLayout(false);

		}
		#endregion

		private void labelBookMaster_Click(object sender, System.EventArgs e)
		{
			MyBookMsListForm = new FrmBookMsList(this.MyMDIForm, this);
			MyBookMsListForm.Show();
			MyBookMsListForm.DoClear();
			MyBookSearch = new BookSearch();
		}

		private void labelBookOutstanding_Click(object sender, System.EventArgs e)
		{
			MyBookOutstandingForm = new FrmBookOutstanding();
			MyBookOutstandingForm.MdiParent = base.MyMDIForm;
			MyBookOutstandingForm.Show();
		}

		private void labelBookHistory_Click(object sender, System.EventArgs e)
		{
			MyBookHistoryForm = new FrmBookHistory();
			MyBookHistoryForm.MdiParent = base.MyMDIForm;
			MyBookHistoryForm.Show();
		}

		private void labelBookStatistics_Click(object sender, System.EventArgs e)
		{
			MyStatisticsForm = new FrmStatistics();
			MyStatisticsForm.MdiParent = base.MyMDIForm;
			MyStatisticsForm.Show();
		}

		private void labelJournalMaster_Click(object sender, System.EventArgs e)
		{
			MyJournalListForm = new FrmJournalList(this.MyMDIForm, this);
		
			MyJournalListForm.Show();
			MyJournalMasterForm = new FrmJournalMasterDetail(this.MyMDIForm,this);
			MyJournalDetailForm = new FrmJournalDetail(this.MyMDIForm,this);
			MyJournalArticlesForm = new FrmJournalArticles(this.MyMDIForm,this);
			
			//MyJournalListForm.DoClear();
			//MyBookSearch = new BookSearch();	
		}
	}
}

