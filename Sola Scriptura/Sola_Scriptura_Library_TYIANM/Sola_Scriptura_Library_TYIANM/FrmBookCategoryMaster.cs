using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Sola_Scriptura_Library
{
	public class FrmBookCategoryMaster : Sola_Scriptura_Library.FrmFormParent
	{
		internal System.Windows.Forms.Button buttonBookGroup;
		internal System.Windows.Forms.Button buttonBookType;
		private System.ComponentModel.IContainer components = null;
		internal System.Windows.Forms.Button buttonBookSubject;
		internal System.Windows.Forms.PictureBox pictureBoxLogoPicture;

		internal FrmSetupMenu MySetupMenuForm;

		public FrmBookCategoryMaster()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public FrmBookCategoryMaster(FrmMDI MDIForm)
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmBookCategoryMaster));
			this.buttonBookGroup = new System.Windows.Forms.Button();
			this.buttonBookType = new System.Windows.Forms.Button();
			this.buttonBookSubject = new System.Windows.Forms.Button();
			this.pictureBoxLogoPicture = new System.Windows.Forms.PictureBox();
			this.SuspendLayout();
			// 
			// buttonBookGroup
			// 
			this.buttonBookGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonBookGroup.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonBookGroup.Image = ((System.Drawing.Image)(resources.GetObject("buttonBookGroup.Image")));
			this.buttonBookGroup.Location = new System.Drawing.Point(34, 128);
			this.buttonBookGroup.Name = "buttonBookGroup";
			this.buttonBookGroup.Size = new System.Drawing.Size(144, 40);
			this.buttonBookGroup.TabIndex = 101;
			this.buttonBookGroup.Text = "Book Group";
			this.buttonBookGroup.Click += new System.EventHandler(this.buttonBookGroup_Click);
			// 
			// buttonBookType
			// 
			this.buttonBookType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonBookType.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonBookType.Image = ((System.Drawing.Image)(resources.GetObject("buttonBookType.Image")));
			this.buttonBookType.Location = new System.Drawing.Point(34, 80);
			this.buttonBookType.Name = "buttonBookType";
			this.buttonBookType.Size = new System.Drawing.Size(144, 40);
			this.buttonBookType.TabIndex = 100;
			this.buttonBookType.Text = "Book Type";
			this.buttonBookType.Click += new System.EventHandler(this.buttonBookType_Click);
			// 
			// buttonBookSubject
			// 
			this.buttonBookSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonBookSubject.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonBookSubject.Image = ((System.Drawing.Image)(resources.GetObject("buttonBookSubject.Image")));
			this.buttonBookSubject.Location = new System.Drawing.Point(34, 176);
			this.buttonBookSubject.Name = "buttonBookSubject";
			this.buttonBookSubject.Size = new System.Drawing.Size(144, 40);
			this.buttonBookSubject.TabIndex = 102;
			this.buttonBookSubject.Text = "Book Subject";
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
			// FrmBookCategoryMaster
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.pictureBoxLogoPicture);
			this.Controls.Add(this.buttonBookSubject);
			this.Controls.Add(this.buttonBookGroup);
			this.Controls.Add(this.buttonBookType);
			this.Name = "FrmBookCategoryMaster";
			this.Controls.SetChildIndex(this.buttonBookType, 0);
			this.Controls.SetChildIndex(this.buttonBookGroup, 0);
			this.Controls.SetChildIndex(this.buttonBookSubject, 0);
			this.Controls.SetChildIndex(this.pictureBoxLogoPicture, 0);
			this.ResumeLayout(false);

		}
		#endregion

		private void buttonBookType_Click(object sender, System.EventArgs e)
		{

			this.Dispose();
			MySetupMenuForm.MyBookCategoryTypeForm  = new FrmBookCategoryType(this.MyMDIForm, this.MySetupMenuForm);
			MySetupMenuForm.MyBookCategoryTypeForm.Show();
			MySetupMenuForm.MyBookCategoryTypeForm.Location = new Point(2,165);
			MySetupMenuForm.MyBookCategoryTypeForm.buttonBookType.Focus();

		}

		private void buttonBookGroup_Click(object sender, System.EventArgs e)
		{

			this.Dispose();
			MySetupMenuForm.MyBookCategoryGroupForm  = new FrmBookCategoryGroup(this.MyMDIForm, this.MySetupMenuForm);
			MySetupMenuForm.MyBookCategoryGroupForm.Show();
			MySetupMenuForm.MyBookCategoryGroupForm.Location = new Point(2,165);
			MySetupMenuForm.MyBookCategoryGroupForm.buttonBookGroup.Focus();
		}

		private void buttonBookSubject_Click(object sender, System.EventArgs e)
		{
			this.Dispose();
			MySetupMenuForm.MyBookCategorySubjectForm  = new  FrmBookCategorySubject(this.MyMDIForm, this.MySetupMenuForm);
			MySetupMenuForm.MyBookCategorySubjectForm.Show();
			MySetupMenuForm.MyBookCategorySubjectForm.Location = new Point(2,165);
			MySetupMenuForm.MyBookCategorySubjectForm.buttonBookSubject.Focus();
		}


	}
}

