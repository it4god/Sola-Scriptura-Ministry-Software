using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Sola_Scriptura_ChurchMembership
{
	public class FrmAdmin : Sola_Scriptura_ChurchMembership.FrmBigMenu
	{
		internal System.Windows.Forms.Label label5;
		internal System.Windows.Forms.PictureBox pictureBoxData;
		internal System.Windows.Forms.PictureBox pictureBoxDelete;
		internal System.Windows.Forms.PictureBox pictureBoxEdit;
		internal System.Windows.Forms.PictureBox pictureBoxAdd;
		internal System.Windows.Forms.Label labelAdd;
		internal System.Windows.Forms.Label labelEdit;
		internal System.Windows.Forms.Label labelDelete;
		internal System.Windows.Forms.Label labelData;
		private System.ComponentModel.IContainer components = null;

		internal FrmAddAdmin MyAddAdminForm;
		internal FrmModifyAdmin MyModifyAdminForm;
		public FrmAdmin()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public FrmAdmin(FrmMDI MDIForm)
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmAdmin));
			this.label5 = new System.Windows.Forms.Label();
			this.pictureBoxData = new System.Windows.Forms.PictureBox();
			this.pictureBoxDelete = new System.Windows.Forms.PictureBox();
			this.pictureBoxEdit = new System.Windows.Forms.PictureBox();
			this.pictureBoxAdd = new System.Windows.Forms.PictureBox();
			this.labelAdd = new System.Windows.Forms.Label();
			this.labelEdit = new System.Windows.Forms.Label();
			this.labelDelete = new System.Windows.Forms.Label();
			this.labelData = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.label5.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label5.Location = new System.Drawing.Point(400, 48);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(240, 32);
			this.label5.TabIndex = 67;
			this.label5.Text = "Admin";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// pictureBoxData
			// 
			this.pictureBoxData.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxData.Image")));
			this.pictureBoxData.Location = new System.Drawing.Point(400, 312);
			this.pictureBoxData.Name = "pictureBoxData";
			this.pictureBoxData.Size = new System.Drawing.Size(224, 58);
			this.pictureBoxData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxData.TabIndex = 71;
			this.pictureBoxData.TabStop = false;
			// 
			// pictureBoxDelete
			// 
			this.pictureBoxDelete.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDelete.Image")));
			this.pictureBoxDelete.Location = new System.Drawing.Point(400, 240);
			this.pictureBoxDelete.Name = "pictureBoxDelete";
			this.pictureBoxDelete.Size = new System.Drawing.Size(224, 58);
			this.pictureBoxDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxDelete.TabIndex = 70;
			this.pictureBoxDelete.TabStop = false;
			// 
			// pictureBoxEdit
			// 
			this.pictureBoxEdit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEdit.Image")));
			this.pictureBoxEdit.Location = new System.Drawing.Point(400, 168);
			this.pictureBoxEdit.Name = "pictureBoxEdit";
			this.pictureBoxEdit.Size = new System.Drawing.Size(224, 58);
			this.pictureBoxEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxEdit.TabIndex = 69;
			this.pictureBoxEdit.TabStop = false;
			// 
			// pictureBoxAdd
			// 
			this.pictureBoxAdd.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAdd.Image")));
			this.pictureBoxAdd.Location = new System.Drawing.Point(400, 96);
			this.pictureBoxAdd.Name = "pictureBoxAdd";
			this.pictureBoxAdd.Size = new System.Drawing.Size(224, 58);
			this.pictureBoxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxAdd.TabIndex = 68;
			this.pictureBoxAdd.TabStop = false;
			// 
			// labelAdd
			// 
			this.labelAdd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelAdd.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelAdd.Image = ((System.Drawing.Image)(resources.GetObject("labelAdd.Image")));
			this.labelAdd.Location = new System.Drawing.Point(480, 116);
			this.labelAdd.Name = "labelAdd";
			this.labelAdd.Size = new System.Drawing.Size(112, 16);
			this.labelAdd.TabIndex = 72;
			this.labelAdd.Text = "Add Admin";
			this.labelAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelAdd.Click += new System.EventHandler(this.labelAdd_Click);
			// 
			// labelEdit
			// 
			this.labelEdit.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelEdit.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelEdit.Image = ((System.Drawing.Image)(resources.GetObject("labelEdit.Image")));
			this.labelEdit.Location = new System.Drawing.Point(480, 188);
			this.labelEdit.Name = "labelEdit";
			this.labelEdit.Size = new System.Drawing.Size(128, 16);
			this.labelEdit.TabIndex = 73;
			this.labelEdit.Text = "Edit Admin";
			this.labelEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelEdit.Click += new System.EventHandler(this.labelEdit_Click);
			// 
			// labelDelete
			// 
			this.labelDelete.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelDelete.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelDelete.Image = ((System.Drawing.Image)(resources.GetObject("labelDelete.Image")));
			this.labelDelete.Location = new System.Drawing.Point(480, 259);
			this.labelDelete.Name = "labelDelete";
			this.labelDelete.Size = new System.Drawing.Size(120, 16);
			this.labelDelete.TabIndex = 74;
			this.labelDelete.Text = "Delete Admin";
			this.labelDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelDelete.Click += new System.EventHandler(this.labelDelete_Click);
			// 
			// labelData
			// 
			this.labelData.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelData.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelData.Image = ((System.Drawing.Image)(resources.GetObject("labelData.Image")));
			this.labelData.Location = new System.Drawing.Point(480, 334);
			this.labelData.Name = "labelData";
			this.labelData.Size = new System.Drawing.Size(120, 16);
			this.labelData.TabIndex = 75;
			this.labelData.Text = "Admin Data";
			this.labelData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelData.Click += new System.EventHandler(this.labelData_Click);
			// 
			// FrmAdmin
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.labelData);
			this.Controls.Add(this.labelDelete);
			this.Controls.Add(this.labelEdit);
			this.Controls.Add(this.labelAdd);
			this.Controls.Add(this.pictureBoxData);
			this.Controls.Add(this.pictureBoxDelete);
			this.Controls.Add(this.pictureBoxEdit);
			this.Controls.Add(this.pictureBoxAdd);
			this.Controls.Add(this.label5);
			this.Name = "FrmAdmin";
			this.Controls.SetChildIndex(this.label5, 0);
			this.Controls.SetChildIndex(this.pictureBoxAdd, 0);
			this.Controls.SetChildIndex(this.pictureBoxEdit, 0);
			this.Controls.SetChildIndex(this.pictureBoxDelete, 0);
			this.Controls.SetChildIndex(this.pictureBoxData, 0);
			this.Controls.SetChildIndex(this.labelAdd, 0);
			this.Controls.SetChildIndex(this.labelEdit, 0);
			this.Controls.SetChildIndex(this.labelDelete, 0);
			this.Controls.SetChildIndex(this.labelData, 0);
			this.ResumeLayout(false);

		}
		#endregion

		private void labelAdd_Click(object sender, System.EventArgs e)
		{
			MyAddAdminForm = new FrmAddAdmin (this.MyMDIForm);
			MyAddAdminForm.MdiParent = base.MyMDIForm;
			MyAddAdminForm.MyAdmin = new Administrator();
			MyAddAdminForm.MyAdmin.UpdateUser = base.MyMDIForm.AdminUserName.ToString();
			MyAddAdminForm.comboBoxAdminGroup.Text = "User";
			MyAddAdminForm.DoUnlock();
			MyAddAdminForm.GetMaxAdminID ();
			MyAddAdminForm.Show();
			
		}

		private void labelEdit_Click(object sender, System.EventArgs e)
		{
			MyModifyAdminForm = new FrmModifyAdmin(this.MyMDIForm);
			MyModifyAdminForm.MdiParent = base.MyMDIForm;
			MyModifyAdminForm.MyAdmin = new  Administrator();
			MyModifyAdminForm.MyAdmin.UpdateUser = base.MyMDIForm.AdminUserName.ToString();
			MyModifyAdminForm.LabelTitle.Text = "    Edit Admin";
			MyModifyAdminForm.buttonModify.Text = "Edit";
			MyModifyAdminForm.Show();
		}

		private void labelDelete_Click(object sender, System.EventArgs e)
		{
			MyModifyAdminForm = new FrmModifyAdmin(this.MyMDIForm);
			MyModifyAdminForm.MdiParent = base.MyMDIForm;
			MyModifyAdminForm.MyAdmin = new Administrator();
			MyModifyAdminForm.MyAdmin.UpdateUser = base.MyMDIForm.AdminUserName.ToString();
			MyModifyAdminForm.LabelTitle.Text = "    Delete Admin";
			MyModifyAdminForm.buttonModify.Text = "Delete";		
			MyModifyAdminForm.Show();
		}

		private void labelData_Click(object sender, System.EventArgs e)
		{
			MyModifyAdminForm = new FrmModifyAdmin(this.MyMDIForm);
			MyModifyAdminForm.MdiParent = base.MyMDIForm;
			MyModifyAdminForm.MyAdmin = new Administrator();
			MyModifyAdminForm.MyAdmin.UpdateUser = base.MyMDIForm.AdminUserName.ToString();
			MyModifyAdminForm.LabelTitle.Text = "    Show Admin";
			MyModifyAdminForm.buttonModify.Text = "Show";
			MyModifyAdminForm.Show();
		}


	}
}

