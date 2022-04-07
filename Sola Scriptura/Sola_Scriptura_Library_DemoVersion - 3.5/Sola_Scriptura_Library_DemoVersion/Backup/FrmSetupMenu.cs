using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Sola_Scriptura_Library
{
	public class FrmSetupMenu : Sola_Scriptura_Library.FrmBigMenu
	{
		internal System.Windows.Forms.Label labelTitle;
		internal System.Windows.Forms.PictureBox pictureBoxAuthorMaster;
		internal System.Windows.Forms.PictureBox pictureBoxPublisher;
		internal System.Windows.Forms.PictureBox pictureBoxBookCategory;
		internal System.Windows.Forms.PictureBox pictureBoxBookStore;
		internal System.Windows.Forms.PictureBox pictureBoxDDCMaster;
		internal System.Windows.Forms.PictureBox pictureBoxShelfMaster;
		internal System.Windows.Forms.PictureBox pictureBoxCurrencyMaster;
		internal System.Windows.Forms.PictureBox pictureBoxPolicyMaster;
		internal System.Windows.Forms.Label labelAuthorMaster;
		internal System.Windows.Forms.Label labelBookCategory;
		internal System.Windows.Forms.Label labelDDCMaster;
		internal System.Windows.Forms.Label labelShelfMaster;
		internal System.Windows.Forms.Label labelPolicy;
		internal System.Windows.Forms.Label labelCurrencyMaster;
		internal System.Windows.Forms.Label labelBookStore;
		internal System.Windows.Forms.Label labelPublisher;
		
		private System.ComponentModel.IContainer components = null;

		internal FrmAuthor MyAuthorForm;
		internal FrmAuthorType MyAuthorTypeForm;

		internal FrmPublisherList MyPublisherListForm;
		internal FrmPublisherDetail MyPublisherDetailForm;
		internal Publisher MyPublisher;

		internal FrmBookCategoryType MyBookCategoryTypeForm;
		internal FrmBookCategoryGroup MyBookCategoryGroupForm;
		internal FrmBookCategorySubject MyBookCategorySubjectForm;

		internal FrmBookStoreList MyBookStoreListForm;
		internal FrmBookStoreDetail MyBookStoreDetailForm;
		internal BookStore MyBookStore;

		internal FrmDDCMaster MyDDCMasterForm;

		internal FrmLocation MyLocationForm;
		internal FrmShelfMaster MyShelfMasterForm;

		internal FrmCurrencyMaster MyCurrencyMasterForm;
		
		internal FrmBookPrint MyBookPrintForm;
		
		internal System.Windows.Forms.Label labelBookPrint;
		internal System.Windows.Forms.PictureBox pictureBox1;
	


		


		internal FrmPolicy MyPolicyForm;


		public FrmSetupMenu()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public FrmSetupMenu(FrmMDI MDIForm)
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmSetupMenu));
			this.labelTitle = new System.Windows.Forms.Label();
			this.pictureBoxAuthorMaster = new System.Windows.Forms.PictureBox();
			this.pictureBoxPublisher = new System.Windows.Forms.PictureBox();
			this.pictureBoxBookCategory = new System.Windows.Forms.PictureBox();
			this.pictureBoxBookStore = new System.Windows.Forms.PictureBox();
			this.pictureBoxDDCMaster = new System.Windows.Forms.PictureBox();
			this.pictureBoxShelfMaster = new System.Windows.Forms.PictureBox();
			this.pictureBoxCurrencyMaster = new System.Windows.Forms.PictureBox();
			this.pictureBoxPolicyMaster = new System.Windows.Forms.PictureBox();
			this.labelAuthorMaster = new System.Windows.Forms.Label();
			this.labelBookCategory = new System.Windows.Forms.Label();
			this.labelDDCMaster = new System.Windows.Forms.Label();
			this.labelShelfMaster = new System.Windows.Forms.Label();
			this.labelPolicy = new System.Windows.Forms.Label();
			this.labelCurrencyMaster = new System.Windows.Forms.Label();
			this.labelBookStore = new System.Windows.Forms.Label();
			this.labelPublisher = new System.Windows.Forms.Label();
			this.labelBookPrint = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
			this.labelTitle.TabIndex = 69;
			this.labelTitle.Text = "Setup";
			this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// pictureBoxAuthorMaster
			// 
			this.pictureBoxAuthorMaster.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAuthorMaster.Image")));
			this.pictureBoxAuthorMaster.Location = new System.Drawing.Point(344, 112);
			this.pictureBoxAuthorMaster.Name = "pictureBoxAuthorMaster";
			this.pictureBoxAuthorMaster.Size = new System.Drawing.Size(224, 58);
			this.pictureBoxAuthorMaster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxAuthorMaster.TabIndex = 70;
			this.pictureBoxAuthorMaster.TabStop = false;
			// 
			// pictureBoxPublisher
			// 
			this.pictureBoxPublisher.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPublisher.Image")));
			this.pictureBoxPublisher.Location = new System.Drawing.Point(608, 112);
			this.pictureBoxPublisher.Name = "pictureBoxPublisher";
			this.pictureBoxPublisher.Size = new System.Drawing.Size(224, 58);
			this.pictureBoxPublisher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxPublisher.TabIndex = 71;
			this.pictureBoxPublisher.TabStop = false;
			// 
			// pictureBoxBookCategory
			// 
			this.pictureBoxBookCategory.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBookCategory.Image")));
			this.pictureBoxBookCategory.Location = new System.Drawing.Point(344, 184);
			this.pictureBoxBookCategory.Name = "pictureBoxBookCategory";
			this.pictureBoxBookCategory.Size = new System.Drawing.Size(224, 58);
			this.pictureBoxBookCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxBookCategory.TabIndex = 72;
			this.pictureBoxBookCategory.TabStop = false;
			// 
			// pictureBoxBookStore
			// 
			this.pictureBoxBookStore.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBookStore.Image")));
			this.pictureBoxBookStore.Location = new System.Drawing.Point(608, 184);
			this.pictureBoxBookStore.Name = "pictureBoxBookStore";
			this.pictureBoxBookStore.Size = new System.Drawing.Size(224, 58);
			this.pictureBoxBookStore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxBookStore.TabIndex = 73;
			this.pictureBoxBookStore.TabStop = false;
			// 
			// pictureBoxDDCMaster
			// 
			this.pictureBoxDDCMaster.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDDCMaster.Image")));
			this.pictureBoxDDCMaster.Location = new System.Drawing.Point(344, 256);
			this.pictureBoxDDCMaster.Name = "pictureBoxDDCMaster";
			this.pictureBoxDDCMaster.Size = new System.Drawing.Size(224, 58);
			this.pictureBoxDDCMaster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxDDCMaster.TabIndex = 74;
			this.pictureBoxDDCMaster.TabStop = false;
			// 
			// pictureBoxShelfMaster
			// 
			this.pictureBoxShelfMaster.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxShelfMaster.Image")));
			this.pictureBoxShelfMaster.Location = new System.Drawing.Point(608, 256);
			this.pictureBoxShelfMaster.Name = "pictureBoxShelfMaster";
			this.pictureBoxShelfMaster.Size = new System.Drawing.Size(224, 58);
			this.pictureBoxShelfMaster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxShelfMaster.TabIndex = 76;
			this.pictureBoxShelfMaster.TabStop = false;
			// 
			// pictureBoxCurrencyMaster
			// 
			this.pictureBoxCurrencyMaster.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCurrencyMaster.Image")));
			this.pictureBoxCurrencyMaster.Location = new System.Drawing.Point(344, 328);
			this.pictureBoxCurrencyMaster.Name = "pictureBoxCurrencyMaster";
			this.pictureBoxCurrencyMaster.Size = new System.Drawing.Size(224, 58);
			this.pictureBoxCurrencyMaster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxCurrencyMaster.TabIndex = 77;
			this.pictureBoxCurrencyMaster.TabStop = false;
			// 
			// pictureBoxPolicyMaster
			// 
			this.pictureBoxPolicyMaster.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPolicyMaster.Image")));
			this.pictureBoxPolicyMaster.Location = new System.Drawing.Point(608, 328);
			this.pictureBoxPolicyMaster.Name = "pictureBoxPolicyMaster";
			this.pictureBoxPolicyMaster.Size = new System.Drawing.Size(224, 58);
			this.pictureBoxPolicyMaster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxPolicyMaster.TabIndex = 78;
			this.pictureBoxPolicyMaster.TabStop = false;

			// 
			// labelAuthorMaster
			// 
			this.labelAuthorMaster.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelAuthorMaster.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelAuthorMaster.Image = ((System.Drawing.Image)(resources.GetObject("labelAuthorMaster.Image")));
			this.labelAuthorMaster.Location = new System.Drawing.Point(432, 132);
			this.labelAuthorMaster.Name = "labelAuthorMaster";
			this.labelAuthorMaster.Size = new System.Drawing.Size(112, 16);
			this.labelAuthorMaster.TabIndex = 79;
			this.labelAuthorMaster.Text = "Author Master";
			this.labelAuthorMaster.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelAuthorMaster.Click += new System.EventHandler(this.labelAuthorMaster_Click);
			// 
			// labelBookCategory
			// 
			this.labelBookCategory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBookCategory.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelBookCategory.Image = ((System.Drawing.Image)(resources.GetObject("labelBookCategory.Image")));
			this.labelBookCategory.Location = new System.Drawing.Point(432, 204);
			this.labelBookCategory.Name = "labelBookCategory";
			this.labelBookCategory.Size = new System.Drawing.Size(112, 16);
			this.labelBookCategory.TabIndex = 80;
			this.labelBookCategory.Text = "Book Category";
			this.labelBookCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelBookCategory.Click += new System.EventHandler(this.labelBookCategory_Click);
			// 
			// labelDDCMaster
			// 
			this.labelDDCMaster.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelDDCMaster.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelDDCMaster.Image = ((System.Drawing.Image)(resources.GetObject("labelDDCMaster.Image")));
			this.labelDDCMaster.Location = new System.Drawing.Point(432, 276);
			this.labelDDCMaster.Name = "labelDDCMaster";
			this.labelDDCMaster.Size = new System.Drawing.Size(112, 16);
			this.labelDDCMaster.TabIndex = 81;
			this.labelDDCMaster.Text = "DDC Master";
			this.labelDDCMaster.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelDDCMaster.Click += new System.EventHandler(this.labelDDCMaster_Click);
			// 
			// labelShelfMaster
			// 
			this.labelShelfMaster.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelShelfMaster.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelShelfMaster.Image = ((System.Drawing.Image)(resources.GetObject("labelShelfMaster.Image")));
			this.labelShelfMaster.Location = new System.Drawing.Point(696, 276);
			this.labelShelfMaster.Name = "labelShelfMaster";
			this.labelShelfMaster.Size = new System.Drawing.Size(112, 16);
			this.labelShelfMaster.TabIndex = 82;
			this.labelShelfMaster.Text = "Shelf Master";
			this.labelShelfMaster.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelShelfMaster.Click += new System.EventHandler(this.labelShelfMaster_Click);
			// 
			// labelPolicy
			// 
			this.labelPolicy.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelPolicy.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelPolicy.Image = ((System.Drawing.Image)(resources.GetObject("labelPolicy.Image")));
			this.labelPolicy.Location = new System.Drawing.Point(696, 348);
			this.labelPolicy.Name = "labelPolicy";
			this.labelPolicy.Size = new System.Drawing.Size(112, 16);
			this.labelPolicy.TabIndex = 83;
			this.labelPolicy.Text = "Policy";
			this.labelPolicy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelPolicy.Click += new System.EventHandler(this.labelPolicy_Click);
			// 
			// labelCurrencyMaster
			// 
			this.labelCurrencyMaster.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelCurrencyMaster.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelCurrencyMaster.Image = ((System.Drawing.Image)(resources.GetObject("labelCurrencyMaster.Image")));
			this.labelCurrencyMaster.Location = new System.Drawing.Point(432, 348);
			this.labelCurrencyMaster.Name = "labelCurrencyMaster";
			this.labelCurrencyMaster.Size = new System.Drawing.Size(112, 16);
			this.labelCurrencyMaster.TabIndex = 86;
			this.labelCurrencyMaster.Text = "Currency Master";
			this.labelCurrencyMaster.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelCurrencyMaster.Click += new System.EventHandler(this.labelCurrencyMaster_Click);
			// 
			// labelBookStore
			// 
			this.labelBookStore.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBookStore.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelBookStore.Image = ((System.Drawing.Image)(resources.GetObject("labelBookStore.Image")));
			this.labelBookStore.Location = new System.Drawing.Point(696, 204);
			this.labelBookStore.Name = "labelBookStore";
			this.labelBookStore.Size = new System.Drawing.Size(112, 16);
			this.labelBookStore.TabIndex = 88;
			this.labelBookStore.Text = "Book Store";
			this.labelBookStore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelBookStore.Click += new System.EventHandler(this.labelBookStore_Click);
			// 
			// labelPublisher
			// 
			this.labelPublisher.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelPublisher.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelPublisher.Image = ((System.Drawing.Image)(resources.GetObject("labelPublisher.Image")));
			this.labelPublisher.Location = new System.Drawing.Point(696, 132);
			this.labelPublisher.Name = "labelPublisher";
			this.labelPublisher.Size = new System.Drawing.Size(112, 16);
			this.labelPublisher.TabIndex = 89;
			this.labelPublisher.Text = "Publisher";
			this.labelPublisher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelPublisher.Click += new System.EventHandler(this.labelPublisher_Click);
			// 
			// labelBookPrint
			// 
			this.labelBookPrint.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBookPrint.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelBookPrint.Image = ((System.Drawing.Image)(resources.GetObject("labelBookPrint.Image")));
			this.labelBookPrint.Location = new System.Drawing.Point(432, 422);
			this.labelBookPrint.Name = "labelBookPrint";
			this.labelBookPrint.Size = new System.Drawing.Size(112, 16);
			this.labelBookPrint.TabIndex = 91;
			this.labelBookPrint.Text = "Book Print";
			this.labelBookPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelBookPrint.Click += new System.EventHandler(this.labelBookPrint_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(344, 400);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(224, 58);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 90;
			this.pictureBox1.TabStop = false;
			// 
			// FrmSetupMenu
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.labelBookPrint);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.labelPublisher);
			this.Controls.Add(this.labelBookStore);
			this.Controls.Add(this.labelCurrencyMaster);
			this.Controls.Add(this.labelPolicy);
			this.Controls.Add(this.labelShelfMaster);
			this.Controls.Add(this.labelDDCMaster);
			this.Controls.Add(this.labelBookCategory);
			this.Controls.Add(this.labelAuthorMaster);
			this.Controls.Add(this.pictureBoxPolicyMaster);
			this.Controls.Add(this.pictureBoxCurrencyMaster);
			this.Controls.Add(this.pictureBoxShelfMaster);
			this.Controls.Add(this.pictureBoxDDCMaster);
			this.Controls.Add(this.pictureBoxBookStore);
			this.Controls.Add(this.pictureBoxBookCategory);
			this.Controls.Add(this.pictureBoxPublisher);
			this.Controls.Add(this.pictureBoxAuthorMaster);
			this.Controls.Add(this.labelTitle);
			this.Name = "FrmSetupMenu";
			this.Controls.SetChildIndex(this.labelTitle, 0);
			this.Controls.SetChildIndex(this.pictureBoxAuthorMaster, 0);
			this.Controls.SetChildIndex(this.pictureBoxPublisher, 0);
			this.Controls.SetChildIndex(this.pictureBoxBookCategory, 0);
			this.Controls.SetChildIndex(this.pictureBoxBookStore, 0);
			this.Controls.SetChildIndex(this.pictureBoxDDCMaster, 0);
			this.Controls.SetChildIndex(this.pictureBoxShelfMaster, 0);
			this.Controls.SetChildIndex(this.pictureBoxCurrencyMaster, 0);
			this.Controls.SetChildIndex(this.pictureBoxPolicyMaster, 0);
			this.Controls.SetChildIndex(this.labelAuthorMaster, 0);
			this.Controls.SetChildIndex(this.labelBookCategory, 0);
			this.Controls.SetChildIndex(this.labelDDCMaster, 0);
			this.Controls.SetChildIndex(this.labelShelfMaster, 0);
			this.Controls.SetChildIndex(this.labelPolicy, 0);
			this.Controls.SetChildIndex(this.labelCurrencyMaster, 0);
			this.Controls.SetChildIndex(this.labelBookStore, 0);
			this.Controls.SetChildIndex(this.labelPublisher, 0);
			this.Controls.SetChildIndex(this.pictureBox1, 0);
			this.Controls.SetChildIndex(this.labelBookPrint, 0);
			this.ResumeLayout(false);

		}
		#endregion

		private void labelAuthorMaster_Click(object sender, System.EventArgs e)
		{
			MyAuthorForm = new FrmAuthor(this.MyMDIForm,this);
			MyAuthorForm.Show();
		}

		private void labelPublisher_Click(object sender, System.EventArgs e)
		{
			MyPublisherListForm = new FrmPublisherList(this.MyMDIForm,this);
			MyPublisher = new Publisher();
			MyPublisherListForm.Show();
			
		}

		private void labelBookCategory_Click(object sender, System.EventArgs e)
		{
			
			MyBookCategoryTypeForm = new FrmBookCategoryType(this.MyMDIForm,this);
			MyBookCategoryTypeForm.Show();
			
		}

		private void labelBookStore_Click(object sender, System.EventArgs e)
		{
			MyBookStoreListForm = new FrmBookStoreList(this.MyMDIForm,this);
			MyBookStore = new BookStore();
			MyBookStoreListForm.Show();
		}

		private void labelShelfMaster_Click(object sender, System.EventArgs e)
		{
			MyLocationForm = new FrmLocation(this.MyMDIForm,this);
			MyLocationForm.Show();
		}

		private void labelCurrencyMaster_Click(object sender, System.EventArgs e)
		{
			MyCurrencyMasterForm = new FrmCurrencyMaster(this.MyMDIForm);
			MyCurrencyMasterForm.Show();
		}

		private void labelDDCMaster_Click(object sender, System.EventArgs e)
		{
			MyDDCMasterForm = new FrmDDCMaster(this.MyMDIForm); 
			MyDDCMasterForm.Show();
		}



		private void labelPolicy_Click(object sender, System.EventArgs e)
		{
			MyPolicyForm = new FrmPolicy(this.MyMDIForm);
			MyPolicyForm.Show();
		}

		private void labelBookPrint_Click(object sender, System.EventArgs e)
		{
			MyBookPrintForm = new FrmBookPrint(this.MyMDIForm);
			MyBookPrintForm.Show();
		}


	}
}

