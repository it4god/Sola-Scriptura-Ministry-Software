using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Sola_Scriptura_Library
{
	public class FrmBookStoreMaster : Sola_Scriptura_Library.FrmFormParent
	{
		internal System.Windows.Forms.Button buttonBookStoreDetail;
		internal System.Windows.Forms.Button buttonBookStoreList;
		private System.ComponentModel.IContainer components = null;
		internal System.Windows.Forms.PictureBox pictureBoxLogoPicture;

		internal FrmSetupMenu MySetupMenuForm;

		public FrmBookStoreMaster()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmBookStoreMaster));
			this.buttonBookStoreDetail = new System.Windows.Forms.Button();
			this.buttonBookStoreList = new System.Windows.Forms.Button();
			this.pictureBoxLogoPicture = new System.Windows.Forms.PictureBox();
			this.SuspendLayout();
			// 
			// buttonBookStoreDetail
			// 
			this.buttonBookStoreDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonBookStoreDetail.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonBookStoreDetail.Image = ((System.Drawing.Image)(resources.GetObject("buttonBookStoreDetail.Image")));
			this.buttonBookStoreDetail.Location = new System.Drawing.Point(34, 128);
			this.buttonBookStoreDetail.Name = "buttonBookStoreDetail";
			this.buttonBookStoreDetail.Size = new System.Drawing.Size(144, 40);
			this.buttonBookStoreDetail.TabIndex = 101;
			this.buttonBookStoreDetail.Text = "BookStore Detail";
			this.buttonBookStoreDetail.Click += new System.EventHandler(this.buttonBookStoreDetail_Click);
			// 
			// buttonBookStoreList
			// 
			this.buttonBookStoreList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonBookStoreList.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonBookStoreList.Image = ((System.Drawing.Image)(resources.GetObject("buttonBookStoreList.Image")));
			this.buttonBookStoreList.Location = new System.Drawing.Point(34, 80);
			this.buttonBookStoreList.Name = "buttonBookStoreList";
			this.buttonBookStoreList.Size = new System.Drawing.Size(144, 40);
			this.buttonBookStoreList.TabIndex = 100;
			this.buttonBookStoreList.Text = "BookStore List";
			this.buttonBookStoreList.Click += new System.EventHandler(this.buttonBookStoreList_Click);
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
			// FrmBookStoreMaster
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.pictureBoxLogoPicture);
			this.Controls.Add(this.buttonBookStoreDetail);
			this.Controls.Add(this.buttonBookStoreList);
			this.Name = "FrmBookStoreMaster";
			this.Controls.SetChildIndex(this.buttonBookStoreList, 0);
			this.Controls.SetChildIndex(this.buttonBookStoreDetail, 0);
			this.Controls.SetChildIndex(this.pictureBoxLogoPicture, 0);
			this.ResumeLayout(false);

		}
		#endregion

		private void buttonBookStoreList_Click(object sender, System.EventArgs e)
		{
			if(this is FrmBookStoreList)
				this.Hide();
			else
				this.Dispose();
			//MySetupMenuForm.MyBookStoreListForm = new FrmBookStoreList(this.MyMDIForm, this.MySetupMenuForm);
			MySetupMenuForm.MyBookStoreListForm.Show();
			MySetupMenuForm.MyBookStoreListForm.Location = new Point(2,165);
			MySetupMenuForm.MyBookStoreListForm.buttonBookStoreList.Focus();
		}

		private void buttonBookStoreDetail_Click(object sender, System.EventArgs e)
		{
			if(this is FrmBookStoreList)
				this.Hide();
			else
				this.Dispose();
			MySetupMenuForm.MyBookStoreDetailForm = new FrmBookStoreDetail(this.MyMDIForm, this.MySetupMenuForm);
			MySetupMenuForm.MyBookStoreDetailForm.Show();
			MySetupMenuForm.MyBookStoreDetailForm.Location = new Point(2,165);
			MySetupMenuForm.MyBookStoreDetailForm.buttonBookStoreDetail.Focus();
			MySetupMenuForm.MyBookStoreDetailForm.textBoxStoreCode.Text = MySetupMenuForm.MyBookStore.StoreCode;
			MySetupMenuForm.MyBookStoreDetailForm.textBoxStoreName.Text  = MySetupMenuForm.MyBookStore.StoreName;
			MySetupMenuForm.MyBookStoreDetailForm.textBoxAddress.Text = MySetupMenuForm.MyBookStore.Address;
			MySetupMenuForm.MyBookStoreDetailForm.textBoxCity.Text = MySetupMenuForm.MyBookStore.City;
			MySetupMenuForm.MyBookStoreDetailForm.textBoxPostCode.Text = MySetupMenuForm.MyBookStore.PostCode;
			MySetupMenuForm.MyBookStoreDetailForm.textBoxState.Text = MySetupMenuForm.MyBookStore.State;
			MySetupMenuForm.MyBookStoreDetailForm.textBoxCountry.Text = MySetupMenuForm.MyBookStore.Country;
			MySetupMenuForm.MyBookStoreDetailForm.textBoxPhone.Text = MySetupMenuForm.MyBookStore.Phone;
			MySetupMenuForm.MyBookStoreDetailForm.textBoxFax.Text = MySetupMenuForm.MyBookStore.Fax;
			MySetupMenuForm.MyBookStoreDetailForm.textBoxEmail.Text = MySetupMenuForm.MyBookStore.Email;
			MySetupMenuForm.MyBookStoreDetailForm.textBoxContactPerson.Text = MySetupMenuForm.MyBookStore.ContactPerson;
			MySetupMenuForm.MyBookStoreDetailForm.MyBookStore.UpdateUser  = MyMDIForm.LibrarianUserName;
			if(MySetupMenuForm.MyBookStore.StoreCode.ToString()!="")
				MySetupMenuForm.MyBookStoreDetailForm.CanDelete = true;
			else
				MySetupMenuForm.MyBookStoreDetailForm.CanDelete = false;
			MySetupMenuForm.MyBookStoreDetailForm.RefreshButton();
		}
	}
}

