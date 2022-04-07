using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Sola_Scriptura_Library
{
	public class FrmSearchJournalMaster : Sola_Scriptura_Library.FrmFormParent
	{
		internal System.Windows.Forms.PictureBox pictureBoxLogoPicture;
		internal FrmSearchJournal MySearchJournalForm;
		internal System.Windows.Forms.Button buttonShowJournal;
		internal System.Windows.Forms.Button buttonSearchJournal;
		internal FrmShowJournal MyShowJournalForm;
		internal FrmSearchJournalList MySearchJournalListForm;
		internal System.Windows.Forms.Button buttonJournalList;

	

		private System.ComponentModel.IContainer components = null;

		public FrmSearchJournalMaster()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmSearchJournalMaster));
			this.buttonShowJournal = new System.Windows.Forms.Button();
			this.buttonSearchJournal = new System.Windows.Forms.Button();
			this.pictureBoxLogoPicture = new System.Windows.Forms.PictureBox();
			this.buttonJournalList = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonShowJournal
			// 
			this.buttonShowJournal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonShowJournal.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonShowJournal.Image = ((System.Drawing.Image)(resources.GetObject("buttonShowJournal.Image")));
			this.buttonShowJournal.Location = new System.Drawing.Point(34, 128);
			this.buttonShowJournal.Name = "buttonShowJournal";
			this.buttonShowJournal.Size = new System.Drawing.Size(144, 40);
			this.buttonShowJournal.TabIndex = 103;
			this.buttonShowJournal.Text = "Show";
			this.buttonShowJournal.Click += new System.EventHandler(this.buttonShowJournal_Click);
			// 
			// buttonSearchJournal
			// 
			this.buttonSearchJournal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonSearchJournal.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonSearchJournal.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearchJournal.Image")));
			this.buttonSearchJournal.Location = new System.Drawing.Point(34, 80);
			this.buttonSearchJournal.Name = "buttonSearchJournal";
			this.buttonSearchJournal.Size = new System.Drawing.Size(144, 40);
			this.buttonSearchJournal.TabIndex = 102;
			this.buttonSearchJournal.Text = "Search";
			this.buttonSearchJournal.Click += new System.EventHandler(this.buttonSearchJournal_Click);
			// 
			// pictureBoxLogoPicture
			// 
			this.pictureBoxLogoPicture.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogoPicture.Image")));
			this.pictureBoxLogoPicture.Location = new System.Drawing.Point(32, 464);
			this.pictureBoxLogoPicture.Name = "pictureBoxLogoPicture";
			this.pictureBoxLogoPicture.Size = new System.Drawing.Size(144, 88);
			this.pictureBoxLogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxLogoPicture.TabIndex = 176;
			this.pictureBoxLogoPicture.TabStop = false;
			// 
			// buttonJournalList
			// 
			this.buttonJournalList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonJournalList.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonJournalList.Image = ((System.Drawing.Image)(resources.GetObject("buttonJournalList.Image")));
			this.buttonJournalList.Location = new System.Drawing.Point(34, 176);
			this.buttonJournalList.Name = "buttonJournalList";
			this.buttonJournalList.Size = new System.Drawing.Size(144, 40);
			this.buttonJournalList.TabIndex = 177;
			this.buttonJournalList.Text = "Journal List";
			this.buttonJournalList.Click += new System.EventHandler(this.buttonJournalList_Click);
			// 
			// FrmSearchJournalMaster
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.buttonJournalList);
			this.Controls.Add(this.pictureBoxLogoPicture);
			this.Controls.Add(this.buttonShowJournal);
			this.Controls.Add(this.buttonSearchJournal);
			this.Name = "FrmSearchJournalMaster";
			this.Load += new System.EventHandler(this.FrmSearchJournalMaster_Load);
			this.Controls.SetChildIndex(this.buttonSearchJournal, 0);
			this.Controls.SetChildIndex(this.buttonShowJournal, 0);
			this.Controls.SetChildIndex(this.pictureBoxLogoPicture, 0);
			this.Controls.SetChildIndex(this.buttonJournalList, 0);
			this.ResumeLayout(false);

		}
		#endregion

		private void FrmSearchJournalMaster_Load(object sender, System.EventArgs e)
		{
		
		}

		private void buttonSearchJournal_Click(object sender, System.EventArgs e)
		{
			if(this is FrmSearchJournal)
				this.Hide();
			else
				this.Dispose();

			MyMDIForm.MySearchForm.MySearchJournalForm.Show();
			MyMDIForm.MySearchForm.MySearchJournalForm.Location = new Point(2,165);
			MyMDIForm.MySearchForm.MySearchJournalForm.buttonSearchJournal.Focus();

		}

		private void buttonShowJournal_Click(object sender, System.EventArgs e)
		{
			if(this is FrmSearchJournal)
				this.Hide();
			else
				this.Dispose();

			MyMDIForm.MySearchForm.MyShowJournalForm = new FrmShowJournal(this.MyMDIForm);
			MyMDIForm.MySearchForm.MyShowJournalForm.Show();
			MyMDIForm.MySearchForm.MyShowJournalForm.Location = new Point(2,165);
			MyMDIForm.MySearchForm.MyShowJournalForm.buttonShowJournal.Focus();
		}

		private void buttonJournalList_Click(object sender, System.EventArgs e)
		{
			if(this is FrmSearchJournal)
				this.Hide();
			else
				this.Dispose();

			MyMDIForm.MySearchForm.MySearchJournalListForm  = new  FrmSearchJournalList(this.MyMDIForm);
			MyMDIForm.MySearchForm.MySearchJournalListForm.Show();
			MyMDIForm.MySearchForm.MySearchJournalListForm.Location = new Point(2,165);
			MyMDIForm.MySearchForm.MySearchJournalListForm.buttonJournalList.Focus();
		}
	}
}

