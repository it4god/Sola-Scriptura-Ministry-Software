using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Sola_Scriptura_Library
{
	public class FrmSearch : Sola_Scriptura_Library.FrmBigMenu
	{
		internal System.Windows.Forms.PictureBox pictureBoxBookMaster;
		internal System.Windows.Forms.Label labelTitle;
		internal System.Windows.Forms.Label labelBook;
		internal System.Windows.Forms.Label labelJournal;
		internal System.Windows.Forms.PictureBox pictureBox1;
		
		internal FrmSearchBook MySearchBookForm;
		internal FrmSearchJournal MySearchJournalForm;
		internal FrmShowBook MyShowBookForm;
		internal FrmShowJournal MyShowJournalForm;
        internal FrmSearchJournalList MySearchJournalListForm;

		private System.ComponentModel.IContainer components = null;

		public FrmSearch()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public FrmSearch(FrmMDI MDIForm)
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmSearch));
			this.labelBook = new System.Windows.Forms.Label();
			this.pictureBoxBookMaster = new System.Windows.Forms.PictureBox();
			this.labelTitle = new System.Windows.Forms.Label();
			this.labelJournal = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.SuspendLayout();
			// 
			// labelBook
			// 
			this.labelBook.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBook.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelBook.Image = ((System.Drawing.Image)(resources.GetObject("labelBook.Image")));
			this.labelBook.Location = new System.Drawing.Point(512, 116);
			this.labelBook.Name = "labelBook";
			this.labelBook.Size = new System.Drawing.Size(120, 16);
			this.labelBook.TabIndex = 76;
			this.labelBook.Text = "Book";
			this.labelBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelBook.Click += new System.EventHandler(this.labelBook_Click);
			// 
			// pictureBoxBookMaster
			// 
			this.pictureBoxBookMaster.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBookMaster.Image")));
			this.pictureBoxBookMaster.Location = new System.Drawing.Point(400, 96);
			this.pictureBoxBookMaster.Name = "pictureBoxBookMaster";
			this.pictureBoxBookMaster.Size = new System.Drawing.Size(253, 58);
			this.pictureBoxBookMaster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxBookMaster.TabIndex = 75;
			this.pictureBoxBookMaster.TabStop = false;
			// 
			// labelTitle
			// 
			this.labelTitle.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelTitle.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTitle.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelTitle.Location = new System.Drawing.Point(400, 48);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(240, 32);
			this.labelTitle.TabIndex = 74;
			this.labelTitle.Text = "Search";
			this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// labelJournal
			// 
			this.labelJournal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelJournal.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelJournal.Image = ((System.Drawing.Image)(resources.GetObject("labelJournal.Image")));
			this.labelJournal.Location = new System.Drawing.Point(512, 188);
			this.labelJournal.Name = "labelJournal";
			this.labelJournal.Size = new System.Drawing.Size(120, 16);
			this.labelJournal.TabIndex = 78;
			this.labelJournal.Text = "Journal";
			this.labelJournal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelJournal.Visible = false;
			this.labelJournal.Click += new System.EventHandler(this.labelJournal_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(400, 168);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(253, 58);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 77;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Visible = false;
			// 
			// FrmSearch
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.labelJournal);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.labelBook);
			this.Controls.Add(this.pictureBoxBookMaster);
			this.Controls.Add(this.labelTitle);
			this.Name = "FrmSearch";
			this.Controls.SetChildIndex(this.labelTitle, 0);
			this.Controls.SetChildIndex(this.pictureBoxBookMaster, 0);
			this.Controls.SetChildIndex(this.labelBook, 0);
			this.Controls.SetChildIndex(this.pictureBox1, 0);
			this.Controls.SetChildIndex(this.labelJournal, 0);
			this.ResumeLayout(false);

		}
		#endregion

		private void labelBook_Click(object sender, System.EventArgs e)
		{
			MySearchBookForm = new FrmSearchBook(this.MyMDIForm);
			MySearchBookForm.Show();
			MySearchBookForm.DoClear();
		}

		private void labelJournal_Click(object sender, System.EventArgs e)
		{
			MySearchJournalForm = new FrmSearchJournal(this.MyMDIForm);
			MySearchJournalForm.Show();

		}
	}
}

