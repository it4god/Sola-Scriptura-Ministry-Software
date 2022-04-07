using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Sola_Scriptura_Library
{
	public class FrmTransactionMenu : Sola_Scriptura_Library.FrmBigMenu
	{
		internal System.Windows.Forms.Label labelTitle;
		internal System.Windows.Forms.Label labelReturn;
		internal System.Windows.Forms.PictureBox pictureBoxReturn;
		internal System.Windows.Forms.Label labelBorrow;
		internal System.Windows.Forms.PictureBox pictureBoxBorrow;
		private System.ComponentModel.IContainer components = null;
		
		internal FrmTransactionBorrow MyTransactionBorrowForm;
		internal FrmIncomeHistory MyIncomeHistoryForm;
		internal System.Windows.Forms.PictureBox pictureBox5;
		internal System.Windows.Forms.Label labelIncomeHistory;
		internal System.Windows.Forms.PictureBox pictureBoxIncomeHistory;
		internal System.Windows.Forms.Label label1;
		internal System.Windows.Forms.Label labelReturnBookByCode;
		internal System.Windows.Forms.PictureBox pictureBox1;
		internal FrmTransactionReturn MyTransactionReturnForm;
		internal FrmTransactionReturnByCode MyTransactionReturnByCodeForm;

		public FrmTransactionMenu()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public FrmTransactionMenu(FrmMDI MDIForm)
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmTransactionMenu));
			this.labelTitle = new System.Windows.Forms.Label();
			this.labelReturn = new System.Windows.Forms.Label();
			this.pictureBoxReturn = new System.Windows.Forms.PictureBox();
			this.labelBorrow = new System.Windows.Forms.Label();
			this.pictureBoxBorrow = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.labelIncomeHistory = new System.Windows.Forms.Label();
			this.pictureBoxIncomeHistory = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.labelReturnBookByCode = new System.Windows.Forms.Label();
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
			this.labelTitle.TabIndex = 67;
			this.labelTitle.Text = "Book Transaction";
			this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// labelReturn
			// 
			this.labelReturn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelReturn.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelReturn.Image = ((System.Drawing.Image)(resources.GetObject("labelReturn.Image")));
			this.labelReturn.Location = new System.Drawing.Point(464, 186);
			this.labelReturn.Name = "labelReturn";
			this.labelReturn.Size = new System.Drawing.Size(144, 16);
			this.labelReturn.TabIndex = 81;
			this.labelReturn.Text = "Return Book by Name";
			this.labelReturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelReturn.Click += new System.EventHandler(this.labelReturn_Click);
			// 
			// pictureBoxReturn
			// 
			this.pictureBoxReturn.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxReturn.Image")));
			this.pictureBoxReturn.Location = new System.Drawing.Point(376, 168);
			this.pictureBoxReturn.Name = "pictureBoxReturn";
			this.pictureBoxReturn.Size = new System.Drawing.Size(244, 58);
			this.pictureBoxReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxReturn.TabIndex = 80;
			this.pictureBoxReturn.TabStop = false;
			// 
			// labelBorrow
			// 
			this.labelBorrow.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBorrow.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelBorrow.Image = ((System.Drawing.Image)(resources.GetObject("labelBorrow.Image")));
			this.labelBorrow.Location = new System.Drawing.Point(464, 114);
			this.labelBorrow.Name = "labelBorrow";
			this.labelBorrow.Size = new System.Drawing.Size(120, 16);
			this.labelBorrow.TabIndex = 79;
			this.labelBorrow.Text = "Borrow Book";
			this.labelBorrow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelBorrow.Click += new System.EventHandler(this.labelBorrow_Click);
			// 
			// pictureBoxBorrow
			// 
			this.pictureBoxBorrow.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBorrow.Image")));
			this.pictureBoxBorrow.Location = new System.Drawing.Point(376, 96);
			this.pictureBoxBorrow.Name = "pictureBoxBorrow";
			this.pictureBoxBorrow.Size = new System.Drawing.Size(244, 58);
			this.pictureBoxBorrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxBorrow.TabIndex = 78;
			this.pictureBoxBorrow.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(360, 248);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(448, 10);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox5.TabIndex = 175;
			this.pictureBox5.TabStop = false;
			// 
			// labelIncomeHistory
			// 
			this.labelIncomeHistory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelIncomeHistory.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelIncomeHistory.Image = ((System.Drawing.Image)(resources.GetObject("labelIncomeHistory.Image")));
			this.labelIncomeHistory.Location = new System.Drawing.Point(464, 364);
			this.labelIncomeHistory.Name = "labelIncomeHistory";
			this.labelIncomeHistory.Size = new System.Drawing.Size(120, 16);
			this.labelIncomeHistory.TabIndex = 174;
			this.labelIncomeHistory.Text = "Income History";
			this.labelIncomeHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelIncomeHistory.Click += new System.EventHandler(this.labelIncomeHistory_Click);
			// 
			// pictureBoxIncomeHistory
			// 
			this.pictureBoxIncomeHistory.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIncomeHistory.Image")));
			this.pictureBoxIncomeHistory.Location = new System.Drawing.Point(376, 344);
			this.pictureBoxIncomeHistory.Name = "pictureBoxIncomeHistory";
			this.pictureBoxIncomeHistory.Size = new System.Drawing.Size(253, 58);
			this.pictureBoxIncomeHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxIncomeHistory.TabIndex = 173;
			this.pictureBoxIncomeHistory.TabStop = false;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(27)), ((System.Byte)(64)), ((System.Byte)(166)));
			this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label1.Location = new System.Drawing.Point(390, 269);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(240, 32);
			this.label1.TabIndex = 178;
			this.label1.Text = "History";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// labelReturnBookByCode
			// 
			this.labelReturnBookByCode.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelReturnBookByCode.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelReturnBookByCode.Image = ((System.Drawing.Image)(resources.GetObject("labelReturnBookByCode.Image")));
			this.labelReturnBookByCode.Location = new System.Drawing.Point(728, 114);
			this.labelReturnBookByCode.Name = "labelReturnBookByCode";
			this.labelReturnBookByCode.Size = new System.Drawing.Size(144, 16);
			this.labelReturnBookByCode.TabIndex = 180;
			this.labelReturnBookByCode.Text = "Return Book By Code";
			this.labelReturnBookByCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelReturnBookByCode.Click += new System.EventHandler(this.labelReturnBookByCode_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(632, 96);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(244, 58);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 179;
			this.pictureBox1.TabStop = false;
			// 
			// FrmTransactionMenu
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 570);
			this.Controls.Add(this.labelReturnBookByCode);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.labelIncomeHistory);
			this.Controls.Add(this.pictureBoxIncomeHistory);
			this.Controls.Add(this.labelReturn);
			this.Controls.Add(this.pictureBoxReturn);
			this.Controls.Add(this.labelBorrow);
			this.Controls.Add(this.pictureBoxBorrow);
			this.Controls.Add(this.labelTitle);
			this.Name = "FrmTransactionMenu";
			this.Controls.SetChildIndex(this.labelTitle, 0);
			this.Controls.SetChildIndex(this.pictureBoxBorrow, 0);
			this.Controls.SetChildIndex(this.labelBorrow, 0);
			this.Controls.SetChildIndex(this.pictureBoxReturn, 0);
			this.Controls.SetChildIndex(this.labelReturn, 0);
			this.Controls.SetChildIndex(this.pictureBoxIncomeHistory, 0);
			this.Controls.SetChildIndex(this.labelIncomeHistory, 0);
			this.Controls.SetChildIndex(this.pictureBox5, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.pictureBox1, 0);
			this.Controls.SetChildIndex(this.labelReturnBookByCode, 0);
			this.ResumeLayout(false);

		}
		#endregion

		private void labelBorrow_Click(object sender, System.EventArgs e)
		{
			MyTransactionBorrowForm = new FrmTransactionBorrow(base.MyMDIForm,this);
			MyTransactionBorrowForm.Show();
		}

		private void labelReturn_Click(object sender, System.EventArgs e)
		{
			MyTransactionReturnForm = new FrmTransactionReturn(base.MyMDIForm,this);
			MyTransactionReturnForm.Show();
		}

		private void labelIncomeHistory_Click(object sender, System.EventArgs e)
		{
			MyIncomeHistoryForm = new FrmIncomeHistory();
			MyIncomeHistoryForm.MdiParent = base.MyMDIForm;
			MyIncomeHistoryForm.Show();
		}

		private void labelReturnBookByCode_Click(object sender, System.EventArgs e)
		{
			MyTransactionReturnByCodeForm = new  FrmTransactionReturnByCode(base.MyMDIForm , this );
			MyTransactionReturnByCodeForm.Show ();

		}

	}
}

