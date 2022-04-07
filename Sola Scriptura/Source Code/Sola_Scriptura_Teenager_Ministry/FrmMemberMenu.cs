using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Teenager_Ministry
{
	public class FrmMemberMenu : Teenager_Ministry.FrmBigMenu
	{
		internal System.Windows.Forms.Label labelTitle;
		internal System.Windows.Forms.PictureBox pictureBoxData;
		internal System.Windows.Forms.PictureBox pictureBoxDelete;
		internal System.Windows.Forms.PictureBox pictureBoxEdit;
		internal System.Windows.Forms.PictureBox pictureBoxAdd;
		internal System.Windows.Forms.Label labelData;
		internal System.Windows.Forms.Label labelDelete;
		internal System.Windows.Forms.Label labelEdit;
		internal System.Windows.Forms.Label labelAdd;
		private System.ComponentModel.IContainer components = null;

		internal FrmMember MyMemberForm;
		internal FrmModifyMember MyModifyMemberForm;
		//internal FrmMemberHistory MyMemberHistoryForm;
		public FrmMemberMenu()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			base.pictureBoxMenu.SendToBack ();
			// TODO: Add any initialization after the InitializeComponent call
		}
		public FrmMemberMenu(FrmMDI MDIForm)
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmMemberMenu));
			this.labelData = new System.Windows.Forms.Label();
			this.pictureBoxData = new System.Windows.Forms.PictureBox();
			this.labelDelete = new System.Windows.Forms.Label();
			this.pictureBoxDelete = new System.Windows.Forms.PictureBox();
			this.labelEdit = new System.Windows.Forms.Label();
			this.labelAdd = new System.Windows.Forms.Label();
			this.pictureBoxEdit = new System.Windows.Forms.PictureBox();
			this.pictureBoxAdd = new System.Windows.Forms.PictureBox();
			this.labelTitle = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelData
			// 
			this.labelData.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelData.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelData.Image = ((System.Drawing.Image)(resources.GetObject("labelData.Image")));
			this.labelData.Location = new System.Drawing.Point(480, 334);
			this.labelData.Name = "labelData";
			this.labelData.Size = new System.Drawing.Size(120, 16);
			this.labelData.TabIndex = 65;
			this.labelData.Text = "Member Data";
			this.labelData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelData.Click += new System.EventHandler(this.labelData_Click);
			// 
			// pictureBoxData
			// 
			this.pictureBoxData.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxData.Image")));
			this.pictureBoxData.Location = new System.Drawing.Point(400, 312);
			this.pictureBoxData.Name = "pictureBoxData";
			this.pictureBoxData.Size = new System.Drawing.Size(224, 58);
			this.pictureBoxData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxData.TabIndex = 64;
			this.pictureBoxData.TabStop = false;
			// 
			// labelDelete
			// 
			this.labelDelete.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelDelete.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelDelete.Image = ((System.Drawing.Image)(resources.GetObject("labelDelete.Image")));
			this.labelDelete.Location = new System.Drawing.Point(480, 259);
			this.labelDelete.Name = "labelDelete";
			this.labelDelete.Size = new System.Drawing.Size(120, 16);
			this.labelDelete.TabIndex = 63;
			this.labelDelete.Text = "Delete Member";
			this.labelDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelDelete.Click += new System.EventHandler(this.labelDelete_Click);
			// 
			// pictureBoxDelete
			// 
			this.pictureBoxDelete.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDelete.Image")));
			this.pictureBoxDelete.Location = new System.Drawing.Point(400, 240);
			this.pictureBoxDelete.Name = "pictureBoxDelete";
			this.pictureBoxDelete.Size = new System.Drawing.Size(224, 58);
			this.pictureBoxDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxDelete.TabIndex = 62;
			this.pictureBoxDelete.TabStop = false;
			// 
			// labelEdit
			// 
			this.labelEdit.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelEdit.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelEdit.Image = ((System.Drawing.Image)(resources.GetObject("labelEdit.Image")));
			this.labelEdit.Location = new System.Drawing.Point(480, 188);
			this.labelEdit.Name = "labelEdit";
			this.labelEdit.Size = new System.Drawing.Size(128, 16);
			this.labelEdit.TabIndex = 61;
			this.labelEdit.Text = "Edit Member";
			this.labelEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelEdit.Click += new System.EventHandler(this.labelEdit_Click);
			// 
			// labelAdd
			// 
			this.labelAdd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelAdd.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelAdd.Image = ((System.Drawing.Image)(resources.GetObject("labelAdd.Image")));
			this.labelAdd.Location = new System.Drawing.Point(480, 116);
			this.labelAdd.Name = "labelAdd";
			this.labelAdd.Size = new System.Drawing.Size(112, 16);
			this.labelAdd.TabIndex = 60;
			this.labelAdd.Text = "Add Member";
			this.labelAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelAdd.Click += new System.EventHandler(this.labelAdd_Click);
			// 
			// pictureBoxEdit
			// 
			this.pictureBoxEdit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEdit.Image")));
			this.pictureBoxEdit.Location = new System.Drawing.Point(400, 168);
			this.pictureBoxEdit.Name = "pictureBoxEdit";
			this.pictureBoxEdit.Size = new System.Drawing.Size(224, 58);
			this.pictureBoxEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxEdit.TabIndex = 59;
			this.pictureBoxEdit.TabStop = false;
			// 
			// pictureBoxAdd
			// 
			this.pictureBoxAdd.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAdd.Image")));
			this.pictureBoxAdd.Location = new System.Drawing.Point(400, 96);
			this.pictureBoxAdd.Name = "pictureBoxAdd";
			this.pictureBoxAdd.Size = new System.Drawing.Size(224, 58);
			this.pictureBoxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxAdd.TabIndex = 58;
			this.pictureBoxAdd.TabStop = false;
			// 
			// labelTitle
			// 
			this.labelTitle.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.labelTitle.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTitle.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelTitle.Location = new System.Drawing.Point(400, 48);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(240, 32);
			this.labelTitle.TabIndex = 66;
			this.labelTitle.Text = "Member";
			this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// FrmMemberMenu
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.labelTitle);
			this.Controls.Add(this.labelData);
			this.Controls.Add(this.pictureBoxData);
			this.Controls.Add(this.labelDelete);
			this.Controls.Add(this.pictureBoxDelete);
			this.Controls.Add(this.labelEdit);
			this.Controls.Add(this.labelAdd);
			this.Controls.Add(this.pictureBoxEdit);
			this.Controls.Add(this.pictureBoxAdd);
			this.Name = "FrmMemberMenu";
			this.Controls.SetChildIndex(this.pictureBoxAdd, 0);
			this.Controls.SetChildIndex(this.pictureBoxEdit, 0);
			this.Controls.SetChildIndex(this.labelAdd, 0);
			this.Controls.SetChildIndex(this.labelEdit, 0);
			this.Controls.SetChildIndex(this.pictureBoxDelete, 0);
			this.Controls.SetChildIndex(this.labelDelete, 0);
			this.Controls.SetChildIndex(this.pictureBoxData, 0);
			this.Controls.SetChildIndex(this.labelData, 0);
			this.Controls.SetChildIndex(this.labelTitle, 0);
			this.ResumeLayout(false);

		}
		#endregion

		private void labelAdd_Click(object sender, System.EventArgs e)
		{
			MyMemberForm = new FrmMember (this.MyMDIForm);
			MyMemberForm.MdiParent = base.MyMDIForm;
			MyMemberForm.MyMember = new Member();
			MyMemberForm.MyMember.UpdateUser = base.MyMDIForm.AdminUserName.ToString();
			MyMemberForm.GetMaxMemberID ();
			MyMemberForm.Show();

		}

		private void labelEdit_Click(object sender, System.EventArgs e)
		{
			MyModifyMemberForm = new FrmModifyMember(this.MyMDIForm);
			MyModifyMemberForm.MdiParent = base.MyMDIForm;
			MyModifyMemberForm.MyMember = new Member();
			MyModifyMemberForm.MyMember.UpdateUser = base.MyMDIForm.AdminUserName.ToString();
			MyModifyMemberForm.LabelTitle.Text = "    Edit Member";
			MyModifyMemberForm.buttonModify.Text = "Edit";
			MyModifyMemberForm.Show();
		}
		private void labelDelete_Click(object sender, System.EventArgs e)
		{
			MyModifyMemberForm = new FrmModifyMember(this.MyMDIForm);
			MyModifyMemberForm.MdiParent = base.MyMDIForm;
			MyModifyMemberForm.MyMember = new Member();
			MyModifyMemberForm.MyMember.UpdateUser = base.MyMDIForm.AdminUserName.ToString();
			MyModifyMemberForm.LabelTitle.Text = "    Delete Member";
			MyModifyMemberForm.buttonModify.Text = "Delete";		
			MyModifyMemberForm.Show();
		}
		private void labelData_Click(object sender, System.EventArgs e)
		{
			MyModifyMemberForm = new FrmModifyMember(this.MyMDIForm);
			MyModifyMemberForm.MdiParent = base.MyMDIForm;
			MyModifyMemberForm.MyMember = new Member();
			MyModifyMemberForm.MyMember.UpdateUser = base.MyMDIForm.AdminUserName.ToString();
			MyModifyMemberForm.LabelTitle.Text = "    Show Member";
			MyModifyMemberForm.buttonModify.Text = "Show";
			MyModifyMemberForm.Show();
		}

		private void labelMemberHistory_Click(object sender, System.EventArgs e)
		{
//			MyMemberHistoryForm = new FrmMemberHistory();
//			MyMemberHistoryForm.MdiParent = base.MyMDIForm;
//			MyMemberHistoryForm.Show();
		}



	}
}

