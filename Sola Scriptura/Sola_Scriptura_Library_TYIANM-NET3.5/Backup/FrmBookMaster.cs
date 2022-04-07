using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Sola_Scriptura_Library
{
	public class FrmBookMaster : Sola_Scriptura_Library.FrmFormParent
	{
		internal System.Windows.Forms.Button buttonBookList;
		internal System.Windows.Forms.Button buttonBookDetail;
		internal System.Windows.Forms.Button buttonBookAuthor;
		internal System.Windows.Forms.Button buttonBookCopy;
		internal System.Windows.Forms.Button buttonBookDesc;
		private System.ComponentModel.IContainer components = null;
		internal System.Windows.Forms.Button buttonBookCover;
		internal System.Windows.Forms.Button buttonBookSubject;
		internal System.Windows.Forms.PictureBox pictureBoxLogoPicture;

		internal FrmBookMenu MyBookMenuForm;

		public FrmBookMaster()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}

		public FrmBookMaster(FrmMDI MDIForm)
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmBookMaster));
			this.buttonBookList = new System.Windows.Forms.Button();
			this.buttonBookDetail = new System.Windows.Forms.Button();
			this.buttonBookCover = new System.Windows.Forms.Button();
			this.buttonBookAuthor = new System.Windows.Forms.Button();
			this.buttonBookCopy = new System.Windows.Forms.Button();
			this.buttonBookDesc = new System.Windows.Forms.Button();
			this.buttonBookSubject = new System.Windows.Forms.Button();
			this.pictureBoxLogoPicture = new System.Windows.Forms.PictureBox();
			this.SuspendLayout();
			// 
			// buttonBookList
			// 
			this.buttonBookList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonBookList.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonBookList.Image = ((System.Drawing.Image)(resources.GetObject("buttonBookList.Image")));
			this.buttonBookList.Location = new System.Drawing.Point(34, 80);
			this.buttonBookList.Name = "buttonBookList";
			this.buttonBookList.Size = new System.Drawing.Size(144, 40);
			this.buttonBookList.TabIndex = 100;
			this.buttonBookList.Text = "List";
			this.buttonBookList.Click += new System.EventHandler(this.buttonBookList_Click);
			// 
			// buttonBookDetail
			// 
			this.buttonBookDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonBookDetail.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonBookDetail.Image = ((System.Drawing.Image)(resources.GetObject("buttonBookDetail.Image")));
			this.buttonBookDetail.Location = new System.Drawing.Point(34, 128);
			this.buttonBookDetail.Name = "buttonBookDetail";
			this.buttonBookDetail.Size = new System.Drawing.Size(144, 40);
			this.buttonBookDetail.TabIndex = 101;
			this.buttonBookDetail.Text = "Detail";
			this.buttonBookDetail.Click += new System.EventHandler(this.buttonBookDetail_Click);
			// 
			// buttonBookCover
			// 
			this.buttonBookCover.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonBookCover.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonBookCover.Image = ((System.Drawing.Image)(resources.GetObject("buttonBookCover.Image")));
			this.buttonBookCover.Location = new System.Drawing.Point(34, 176);
			this.buttonBookCover.Name = "buttonBookCover";
			this.buttonBookCover.Size = new System.Drawing.Size(144, 40);
			this.buttonBookCover.TabIndex = 102;
			this.buttonBookCover.Text = "Cover";
			this.buttonBookCover.Click += new System.EventHandler(this.buttonBookCover_Click);
			// 
			// buttonBookAuthor
			// 
			this.buttonBookAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonBookAuthor.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonBookAuthor.Image = ((System.Drawing.Image)(resources.GetObject("buttonBookAuthor.Image")));
			this.buttonBookAuthor.Location = new System.Drawing.Point(34, 224);
			this.buttonBookAuthor.Name = "buttonBookAuthor";
			this.buttonBookAuthor.Size = new System.Drawing.Size(144, 40);
			this.buttonBookAuthor.TabIndex = 103;
			this.buttonBookAuthor.Text = "Author";
			this.buttonBookAuthor.Click += new System.EventHandler(this.buttonBookAuthor_Click);
			// 
			// buttonBookCopy
			// 
			this.buttonBookCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonBookCopy.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonBookCopy.Image = ((System.Drawing.Image)(resources.GetObject("buttonBookCopy.Image")));
			this.buttonBookCopy.Location = new System.Drawing.Point(34, 272);
			this.buttonBookCopy.Name = "buttonBookCopy";
			this.buttonBookCopy.Size = new System.Drawing.Size(144, 40);
			this.buttonBookCopy.TabIndex = 104;
			this.buttonBookCopy.Text = "Copy / Exemplar";
			this.buttonBookCopy.Click += new System.EventHandler(this.buttonBookCopy_Click);
			// 
			// buttonBookDesc
			// 
			this.buttonBookDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonBookDesc.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonBookDesc.Image = ((System.Drawing.Image)(resources.GetObject("buttonBookDesc.Image")));
			this.buttonBookDesc.Location = new System.Drawing.Point(34, 320);
			this.buttonBookDesc.Name = "buttonBookDesc";
			this.buttonBookDesc.Size = new System.Drawing.Size(144, 40);
			this.buttonBookDesc.TabIndex = 105;
			this.buttonBookDesc.Text = "Description";
			this.buttonBookDesc.Click += new System.EventHandler(this.buttonBookDesc_Click);
			// 
			// buttonBookSubject
			// 
			this.buttonBookSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonBookSubject.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonBookSubject.Image = ((System.Drawing.Image)(resources.GetObject("buttonBookSubject.Image")));
			this.buttonBookSubject.Location = new System.Drawing.Point(34, 368);
			this.buttonBookSubject.Name = "buttonBookSubject";
			this.buttonBookSubject.Size = new System.Drawing.Size(144, 40);
			this.buttonBookSubject.TabIndex = 106;
			this.buttonBookSubject.Text = "Subject";
			this.buttonBookSubject.Click += new System.EventHandler(this.buttonBookSubject_Click);
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
			// FrmBookMaster
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.pictureBoxLogoPicture);
			this.Controls.Add(this.buttonBookSubject);
			this.Controls.Add(this.buttonBookDesc);
			this.Controls.Add(this.buttonBookCopy);
			this.Controls.Add(this.buttonBookAuthor);
			this.Controls.Add(this.buttonBookCover);
			this.Controls.Add(this.buttonBookDetail);
			this.Controls.Add(this.buttonBookList);
			this.Name = "FrmBookMaster";
			this.Load += new System.EventHandler(this.FrmBookMaster_Load);
			this.Controls.SetChildIndex(this.buttonBookList, 0);
			this.Controls.SetChildIndex(this.buttonBookDetail, 0);
			this.Controls.SetChildIndex(this.buttonBookCover, 0);
			this.Controls.SetChildIndex(this.buttonBookAuthor, 0);
			this.Controls.SetChildIndex(this.buttonBookCopy, 0);
			this.Controls.SetChildIndex(this.buttonBookDesc, 0);
			this.Controls.SetChildIndex(this.buttonBookSubject, 0);
			this.Controls.SetChildIndex(this.pictureBoxLogoPicture, 0);
			this.ResumeLayout(false);

		}
		#endregion

		private void buttonBookList_Click(object sender, System.EventArgs e)
		{
			if(this is FrmBookMsList)
				this.Hide();
			else
				this.Dispose();
			//MyBookMenuForm.MyBookMsListForm = new FrmBookMsList(this.MyMDIForm, this.MyBookMenuForm);
			MyBookMenuForm.MyBookMsListForm.Show();
			MyBookMenuForm.MyBookMsListForm.Location = new Point(2,165);
			MyBookMenuForm.MyBookMsListForm.buttonBookList.Focus();
			MyBookMenuForm.MyBookMsListForm.comboBoxType.SelectedIndex = Convert.ToInt32(MyBookMenuForm.MyBookMsListForm.MyBookSearch.BookTypeIndex.ToString());
			MyBookMenuForm.MyBookMsListForm.comboBoxBookGroup.SelectedIndex = Convert.ToInt32(MyBookMenuForm.MyBookMsListForm.MyBookSearch.BookGroupIndex.ToString());
		}

		private void buttonBookDetail_Click(object sender, System.EventArgs e)
		{
			if(this is FrmBookMsList)
				this.Hide();
			else
				this.Dispose();
			MyBookMenuForm.MyBookMsDetailForm = new FrmBookMsDetail(this.MyMDIForm, this.MyBookMenuForm);
			MyBookMenuForm.MyBookMsDetailForm.Show();
			MyBookMenuForm.MyBookMsDetailForm.Location = new Point(2,165);
			MyBookMenuForm.MyBookMsDetailForm.buttonBookDetail.Focus();
			if(MyBookMenuForm.MyBookSearch.BookCode.ToString()!="")
			{
				MyBookMenuForm.MyBookMsDetailForm.CanDelete = true;
				MyBookMenuForm.MyBookMsDetailForm.DoClear();
				MyBookMenuForm.MyBookMsDetailForm.GetBookData();
			}
			else
			{
				MyBookMenuForm.MyBookMsDetailForm.CanDelete = false;
				MyBookMenuForm.MyBookMsDetailForm.DoClear();
			}
			

		}

		private void buttonBookCover_Click(object sender, System.EventArgs e)
		{
			if(this is FrmBookMsList)
				this.Hide();
			else
				this.Dispose();
			MyBookMenuForm.MyBookMsCoverForm = new FrmBookMsCover(this.MyMDIForm, this.MyBookMenuForm);
			MyBookMenuForm.MyBookMsCoverForm.Show();
			MyBookMenuForm.MyBookMsCoverForm.buttonBookCover.Focus();

		}

		private void buttonBookAuthor_Click(object sender, System.EventArgs e)
		{
			if(this is FrmBookMsList)
				this.Hide();
			else
				this.Dispose();
			MyBookMenuForm.MyBookMsAuthorForm = new FrmBookMsAuthor(this.MyMDIForm, this.MyBookMenuForm);
			MyBookMenuForm.MyBookMsAuthorForm.Show();
			MyBookMenuForm.MyBookMsAuthorForm.buttonBookAuthor.Focus();
			if(MyBookMenuForm.MyBookSearch.BookCode.ToString()!="")
			{

				MyBookMenuForm.MyBookMsAuthorForm.GetBookData();
			}
			else
			{

			}



		}
		private void buttonBookCopy_Click(object sender, System.EventArgs e)
		{
			if(this is FrmBookMsList)
				this.Hide();
			else
				this.Dispose();
			MyBookMenuForm.MyBookMsCopyForm = new FrmBookMsCopy(this.MyMDIForm, this.MyBookMenuForm);
			MyBookMenuForm.MyBookMsCopyForm.Show();

			MyBookMenuForm.MyBookMsCopyForm.buttonBookCopy.Focus();

		}
		private void buttonBookDesc_Click(object sender, System.EventArgs e)
		{
			if(this is FrmBookMsList)
				this.Hide();
			else
				this.Dispose();
			MyBookMenuForm.MyBookMsDescForm = new FrmBookMsDesc(this.MyMDIForm, this.MyBookMenuForm);
			MyBookMenuForm.MyBookMsDescForm.Show();
			MyBookMenuForm.MyBookMsDescForm.buttonBookDesc.Focus();

		}
		private void buttonBookSubject_Click(object sender, System.EventArgs e)
		{
			if(this is FrmBookMsList)
				this.Hide();
			else
				this.Dispose();
			MyBookMenuForm.MyBookMsSubjectForm = new FrmBookMsSubject(this.MyMDIForm, this.MyBookMenuForm);
			MyBookMenuForm.MyBookMsSubjectForm.Show();
			MyBookMenuForm.MyBookMsSubjectForm.buttonBookSubject.Focus();

		}

		private void FrmBookMaster_Load(object sender, System.EventArgs e)
		{
			this.Location = new System.Drawing.Point(2,165);
		}
	}
}

