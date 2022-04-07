using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Sola_Scriptura_Library
{
	public class FrmSearchBookMaster : Sola_Scriptura_Library.FrmFormParent
	{
		internal System.Windows.Forms.Button buttonSearchBook;
		internal System.Windows.Forms.Button buttonShowBook;
		internal System.Windows.Forms.PictureBox pictureBoxLogoPicture;
		private System.ComponentModel.IContainer components = null;

		public FrmSearchBookMaster()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmSearchBookMaster));
			this.buttonShowBook = new System.Windows.Forms.Button();
			this.buttonSearchBook = new System.Windows.Forms.Button();
			this.pictureBoxLogoPicture = new System.Windows.Forms.PictureBox();
			this.SuspendLayout();
			// 
			// buttonShowBook
			// 
			this.buttonShowBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonShowBook.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonShowBook.Image = ((System.Drawing.Image)(resources.GetObject("buttonShowBook.Image")));
			this.buttonShowBook.Location = new System.Drawing.Point(34, 128);
			this.buttonShowBook.Name = "buttonShowBook";
			this.buttonShowBook.Size = new System.Drawing.Size(144, 40);
			this.buttonShowBook.TabIndex = 101;
			this.buttonShowBook.Text = "Show";
			this.buttonShowBook.Click += new System.EventHandler(this.buttonShowBook_Click);
			// 
			// buttonSearchBook
			// 
			this.buttonSearchBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonSearchBook.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonSearchBook.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearchBook.Image")));
			this.buttonSearchBook.Location = new System.Drawing.Point(34, 80);
			this.buttonSearchBook.Name = "buttonSearchBook";
			this.buttonSearchBook.Size = new System.Drawing.Size(144, 40);
			this.buttonSearchBook.TabIndex = 100;
			this.buttonSearchBook.Text = "Search";
			this.buttonSearchBook.Click += new System.EventHandler(this.buttonSearchBook_Click);
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
			// FrmSearchMaster
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.pictureBoxLogoPicture);
			this.Controls.Add(this.buttonShowBook);
			this.Controls.Add(this.buttonSearchBook);
			this.Name = "FrmSearchMaster";
			this.Controls.SetChildIndex(this.buttonSearchBook, 0);
			this.Controls.SetChildIndex(this.buttonShowBook, 0);
			this.Controls.SetChildIndex(this.pictureBoxLogoPicture, 0);
			this.ResumeLayout(false);

		}
		#endregion

		private void buttonSearchBook_Click(object sender, System.EventArgs e)
		{
			if(this is FrmSearchBook)
				this.Hide();
			else
				this.Dispose();

			MyMDIForm.MySearchForm.MySearchBookForm.Show();
			MyMDIForm.MySearchForm.MySearchBookForm.Location = new Point(2,165);
			MyMDIForm.MySearchForm.MySearchBookForm.buttonSearchBook.Focus();


			MyMDIForm.MySearchForm.MySearchBookForm.comboBoxType.SelectedIndex = Convert.ToInt32(MyMDIForm.MySearchForm.MySearchBookForm.MyBookSearch.BookTypeIndex.ToString());
			MyMDIForm.MySearchForm.MySearchBookForm.comboBoxBookGroup.SelectedIndex  = Convert.ToInt32(MyMDIForm.MySearchForm.MySearchBookForm.MyBookSearch.BookGroupIndex.ToString());
			
		}

		private void buttonShowBook_Click(object sender, System.EventArgs e)
		{
			if(this is FrmSearchBook)
				this.Hide();
			else
				this.Dispose();
			MyMDIForm.MySearchForm.MyShowBookForm = new FrmShowBook(this.MyMDIForm);
			MyMDIForm.MySearchForm.MyShowBookForm.Show();
			MyMDIForm.MySearchForm.MyShowBookForm.buttonShowBook.Focus();
		}
	}
}

