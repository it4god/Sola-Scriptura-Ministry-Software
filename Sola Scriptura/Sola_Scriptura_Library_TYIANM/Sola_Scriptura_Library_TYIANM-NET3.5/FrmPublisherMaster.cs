using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Sola_Scriptura_Library
{
	public class FrmPublisherMaster : Sola_Scriptura_Library.FrmFormParent
	{
		private System.ComponentModel.IContainer components = null;
		internal System.Windows.Forms.Button buttonPublisherDetail;
		internal System.Windows.Forms.Button buttonPublisherList;
		internal System.Windows.Forms.PictureBox pictureBoxLogoPicture;

		internal FrmSetupMenu MySetupMenuForm;

		public FrmPublisherMaster()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}

		public FrmPublisherMaster(FrmMDI MDIForm)
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmPublisherMaster));
			this.buttonPublisherDetail = new System.Windows.Forms.Button();
			this.buttonPublisherList = new System.Windows.Forms.Button();
			this.pictureBoxLogoPicture = new System.Windows.Forms.PictureBox();
			this.SuspendLayout();
			// 
			// buttonPublisherDetail
			// 
			this.buttonPublisherDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonPublisherDetail.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonPublisherDetail.Image = ((System.Drawing.Image)(resources.GetObject("buttonPublisherDetail.Image")));
			this.buttonPublisherDetail.Location = new System.Drawing.Point(34, 128);
			this.buttonPublisherDetail.Name = "buttonPublisherDetail";
			this.buttonPublisherDetail.Size = new System.Drawing.Size(144, 40);
			this.buttonPublisherDetail.TabIndex = 101;
			this.buttonPublisherDetail.Text = "Publisher Detail";
			this.buttonPublisherDetail.Click += new System.EventHandler(this.buttonPublisherDetail_Click);
			// 
			// buttonPublisherList
			// 
			this.buttonPublisherList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonPublisherList.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonPublisherList.Image = ((System.Drawing.Image)(resources.GetObject("buttonPublisherList.Image")));
			this.buttonPublisherList.Location = new System.Drawing.Point(34, 80);
			this.buttonPublisherList.Name = "buttonPublisherList";
			this.buttonPublisherList.Size = new System.Drawing.Size(144, 40);
			this.buttonPublisherList.TabIndex = 100;
			this.buttonPublisherList.Text = "Publisher List";
			this.buttonPublisherList.Click += new System.EventHandler(this.buttonPublisherList_Click);
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
			// FrmPublisherMaster
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.pictureBoxLogoPicture);
			this.Controls.Add(this.buttonPublisherDetail);
			this.Controls.Add(this.buttonPublisherList);
			this.Name = "FrmPublisherMaster";
			this.Controls.SetChildIndex(this.buttonPublisherList, 0);
			this.Controls.SetChildIndex(this.buttonPublisherDetail, 0);
			this.Controls.SetChildIndex(this.pictureBoxLogoPicture, 0);
			this.ResumeLayout(false);

		}
		#endregion

		private void buttonPublisherList_Click(object sender, System.EventArgs e)
		{
			if(this is FrmPublisherList)
				this.Hide();
			else
				this.Dispose();
			//MySetupMenuForm.MyPublisherListForm = new FrmPublisherList(this.MyMDIForm, this.MySetupMenuForm);
			MySetupMenuForm.MyPublisherListForm.Show();
			MySetupMenuForm.MyPublisherListForm.Location = new Point(2,165);
			MySetupMenuForm.MyPublisherListForm.buttonPublisherList.Focus();
		}

		private void buttonPublisherDetail_Click(object sender, System.EventArgs e)
		{
			if(this is FrmPublisherList)
				this.Hide();
			else
				this.Dispose();
			MySetupMenuForm.MyPublisherDetailForm = new FrmPublisherDetail(this.MyMDIForm, this.MySetupMenuForm);
			MySetupMenuForm.MyPublisherDetailForm.Show();
			MySetupMenuForm.MyPublisherDetailForm.Location = new Point(2,165);
			MySetupMenuForm.MyPublisherDetailForm.buttonPublisherDetail.Focus();
			MySetupMenuForm.MyPublisherDetailForm.textBoxPublisherCode.Text = MySetupMenuForm.MyPublisher.PublisherCode;
			MySetupMenuForm.MyPublisherDetailForm.textBoxPublisherName.Text  = MySetupMenuForm.MyPublisher.PublisherName;
			MySetupMenuForm.MyPublisherDetailForm.textBoxAddress.Text = MySetupMenuForm.MyPublisher.Address;
			MySetupMenuForm.MyPublisherDetailForm.textBoxCity.Text = MySetupMenuForm.MyPublisher.City;
			MySetupMenuForm.MyPublisherDetailForm.textBoxPostCode.Text = MySetupMenuForm.MyPublisher.PostCode;
			MySetupMenuForm.MyPublisherDetailForm.textBoxState.Text = MySetupMenuForm.MyPublisher.State;
			MySetupMenuForm.MyPublisherDetailForm.textBoxCountry.Text = MySetupMenuForm.MyPublisher.Country;
			MySetupMenuForm.MyPublisherDetailForm.textBoxPhone.Text = MySetupMenuForm.MyPublisher.Phone;
			MySetupMenuForm.MyPublisherDetailForm.textBoxFax.Text = MySetupMenuForm.MyPublisher.Fax;
			MySetupMenuForm.MyPublisherDetailForm.textBoxEmail.Text = MySetupMenuForm.MyPublisher.Email;
			MySetupMenuForm.MyPublisherDetailForm.textBoxContactPerson.Text = MySetupMenuForm.MyPublisher.ContactPerson;
			MySetupMenuForm.MyPublisherDetailForm.MyPublisher.UpdateUser  = MyMDIForm.LibrarianUserName;
			if(MySetupMenuForm.MyPublisher.PublisherCode.ToString()!="")
				MySetupMenuForm.MyPublisherDetailForm.CanDelete = true;
			else
				MySetupMenuForm.MyPublisherDetailForm.CanDelete = false;
			MySetupMenuForm.MyPublisherDetailForm.RefreshButton();

		}
	}
}

